using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Orleans.Runtime;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Orleans;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class ActorProxy<TActor> : Grain, IActorModelProvider, IRemindable, IGrain, IAddressable, IIncomingGrainCallFilter where TActor : IActor
{
	private sealed class OrleansELMAContext : ELMAContext
	{
		private class EmptyDisposable : IDisposable
		{
			void IDisposable.Dispose()
			{
			}
		}

		private static IDisposable emptyDisposable = new EmptyDisposable();

		private const string RequestContextKey = "EleWise.ELMA.Orleans.OrleansELMAContext.Key";

		private readonly CallContextSessionOwner callContextSessionOwner;

		private readonly TaskScheduler initializationTaskScheduler = TaskScheduler.Current;

		private readonly object restoreRequestContext;

		protected override object KeyObject
		{
			get
			{
				if (initializationTaskScheduler != TaskScheduler.Current)
				{
					return null;
				}
				return RequestContext.Get("EleWise.ELMA.Orleans.OrleansELMAContext.Key");
			}
		}

		public new static IDisposable Create()
		{
			if (!ELMAContext.Initialized)
			{
				return new OrleansELMAContext();
			}
			return emptyDisposable;
		}

		private OrleansELMAContext()
			: base(isolatedContext: false)
		{
			restoreRequestContext = RequestContext.Get("EleWise.ELMA.Orleans.OrleansELMAContext.Key");
			RequestContext.Set("EleWise.ELMA.Orleans.OrleansELMAContext.Key", new object());
			callContextSessionOwner = CallContextSessionOwner.Create();
		}

		public override void Dispose()
		{
			callContextSessionOwner.Dispose();
			ELMAContext.Items.Clear();
			RequestContext.Set("EleWise.ELMA.Orleans.OrleansELMAContext.Key", restoreRequestContext);
			base.Dispose();
		}
	}

	protected readonly IActorInterfaceWrapper ActorWrapper;

	private readonly ILazy<IUnitOfWorkManager> uowManager;

	private readonly ILazy<IAuthenticationService> authService;

	private readonly ILogger logger;

	private readonly ILazy<IActorContextManagementService> actorContextService;

	private static readonly TimeSpan DefaultResponseTimeout = TimeSpan.FromSeconds(30.0);

	protected ActorProxy(TActor actor, ILazy<IUnitOfWorkManager> uowManager, ILazy<IAuthenticationService> authService, ILazy<IActorContextManagementService> actorContextService)
	{
		ActorWrapper = (IActorInterfaceWrapper)(object)actor;
		this.uowManager = uowManager;
		this.authService = authService;
		this.actorContextService = actorContextService;
		logger = Logger.Log;
	}

	public override async Task OnActivateAsync()
	{
		Actor actor = (Actor)ActorWrapper.Actor;
		actor.Initialize(this);
		using (OrleansELMAContext.Create())
		{
			((IActorModelProvider)this).DelayDeactivation(actor.LifeTime);
			await actor.OnActivateAsync();
		}
		await _003C_003En__0();
	}

	public override async Task OnDeactivateAsync()
	{
		using (OrleansELMAContext.Create())
		{
			await ((Actor)ActorWrapper.Actor).OnDeactivateAsync();
		}
		await _003C_003En__1();
	}

	object IActorModelProvider.GetPrimaryKey()
	{
		if (typeof(IActorWithIntegerKey).IsAssignableFrom(typeof(TActor)))
		{
			return GrainExtensions.GetPrimaryKeyLong((IGrain)(object)this);
		}
		if (typeof(IActorWithGuidKey).IsAssignableFrom(typeof(TActor)))
		{
			return GrainExtensions.GetPrimaryKey((IGrain)(object)this);
		}
		if (typeof(IActorWithGuidCompoundKey).IsAssignableFrom(typeof(TActor)))
		{
			string stringKey = default(string);
			Guid primaryKey = GrainExtensions.GetPrimaryKey((IGrain)(object)this, ref stringKey);
			GuidCompoundKey guidCompoundKey = default(GuidCompoundKey);
			guidCompoundKey.GuidKey = primaryKey;
			guidCompoundKey.StringKey = stringKey;
			return guidCompoundKey;
		}
		return GrainExtensions.GetPrimaryKeyString((IAddressable)(object)this);
	}

	async Task IActorModelProvider.UnregisterReminder(string reminderName)
	{
		IGrainReminder val = await ((Grain)this).GetReminder(reminderName);
		if (val != null)
		{
			await ((Grain)this).UnregisterReminder(val);
		}
	}

	Task IActorModelProvider.RegisterOrUpdateReminder(string reminderName, TimeSpan dueTime, TimeSpan period)
	{
		return ((Grain)this).RegisterOrUpdateReminder(reminderName, dueTime, period);
	}

	IDisposable IActorModelProvider.RegisterTimer(Func<object, Task> asyncCallback, object state, TimeSpan dueTime, TimeSpan period)
	{
		return ((Grain)this).RegisterTimer((Func<object, Task>)WrappedCallback, state, dueTime, period);
		async Task WrappedCallback(object s)
		{
			using (OrleansELMAContext.Create())
			{
				await asyncCallback(s);
			}
		}
	}

	public Task RunExternalTask(Func<Task> action)
	{
		return RunExternalTask(delegate
		{
			TaskCompletionSource<int> tsc = new TaskCompletionSource<int>(TaskCreationOptions.RunContinuationsAsynchronously);
			action().ContinueWith(delegate(Task t)
			{
				if (t.IsFaulted)
				{
					tsc.TrySetException(t.Exception);
				}
				else if (t.IsCanceled)
				{
					tsc.TrySetCanceled();
				}
				else
				{
					tsc.TrySetResult(0);
				}
			});
			return tsc.Task;
		});
	}

	public Task<TResult> RunExternalTask<TResult>(Func<Task<TResult>> action)
	{
		Contract.ArgumentNotNull(action, "action");
		object userId = RequestContext.Get("UserId");
		CultureInfo currentUICulture = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
		CultureInfo currentCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
		return Task.Run(async delegate
		{
			Thread.CurrentThread.CurrentUICulture = currentUICulture;
			Thread.CurrentThread.CurrentCulture = currentCulture;
			using (ELMAContext.Create())
			{
				SetupCurrentUser(userId);
				if (actorContextService.IsRegistered && RequestContext.Get("PassContextKey") is SerializableDictionary<string, object> incomingContext)
				{
					actorContextService.Value.Set(incomingContext);
				}
				return await action();
			}
		});
	}

	void IActorModelProvider.DelayDeactivation(TimeSpan timeSpan)
	{
		if (timeSpan < OrleansHostWrapper.DefaultCollectionAge)
		{
			throw new InvalidOperationException(SR.T("Установленное время жизни Актора {0} не может быть меньше {1}", timeSpan.ToString("g"), OrleansHostWrapper.DefaultCollectionAge.ToString("g")));
		}
		((Grain)this).DelayDeactivation(timeSpan);
	}

	void IActorModelProvider.DeactivateOnIdle()
	{
		((Grain)this).DeactivateOnIdle();
	}

	async Task IRemindable.ReceiveReminder(string reminderName, TickStatus status)
	{
		using (OrleansELMAContext.Create())
		{
			await ((Actor)ActorWrapper.Actor).ReceiveReminder(reminderName);
		}
	}

	async Task IIncomingGrainCallFilter.Invoke(IIncomingGrainCallContext context)
	{
		_ = 1;
		try
		{
			using (OrleansELMAContext.Create())
			{
				SetupCurrentUser(RequestContext.Get("UserId"));
				string text = RequestContext.Get("UICultureName") as string;
				if (!string.IsNullOrEmpty(text))
				{
					Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(text);
				}
				string text2 = RequestContext.Get("CultureName") as string;
				if (!string.IsNullOrEmpty(text2))
				{
					Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(text2);
				}
				if (actorContextService.IsRegistered && RequestContext.Get("PassContextKey") is SerializableDictionary<string, object> incomingContext)
				{
					actorContextService.Value.Set(incomingContext);
				}
				IUnitOfWork unitOfWork = null;
				try
				{
					TransactionAttribute attribute = AttributeHelper<TransactionAttribute>.GetAttribute(context.get_ImplementationMethod(), inherited: false);
					if (attribute != null)
					{
						unitOfWork = uowManager.Value.Create(string.Empty, transactional: true, attribute.IsolationLevel);
					}
					try
					{
						Task actorTask = ((IGrainCallContext)context).Invoke();
						if (await Task.WhenAny(actorTask, Task.Delay(DefaultResponseTimeout)) != actorTask)
						{
							logger.Warn(SR.T("Превышено время выполнения операции по умолчанию: '{0}'", DefaultResponseTimeout));
						}
						await actorTask;
					}
					catch
					{
						unitOfWork?.Rollback();
						throw;
					}
					unitOfWork?.Commit();
				}
				finally
				{
					unitOfWork?.Dispose();
				}
			}
		}
		catch (Exception exception)
		{
			logger.Error("An error occurred in the method '" + context.get_ImplementationMethod().Name + "'!", exception);
			throw;
		}
	}

	private void SetupCurrentUser(object userId)
	{
		if (userId != null && authService.IsRegistered)
		{
			authService.Value.SetAuthenticatedUserIdForRequest(userId);
		}
	}
}
