using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Managers;

[Service]
internal sealed class ContentActionManager
{
	[StructLayout(3)]
	private struct _003CGetActionId_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ContentActionId> _003C_003Et__builder;

		public ContentActionManager _003C_003E4__this;

		public ContentActionModel model;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ContentActionManager contentActionManager = _003C_003E4__this;
			ContentActionId result2;
			try
			{
				TaskAwaiter<ContentActionId> val;
				if (num != 0)
				{
					val = contentActionManager.contentActionService.LoadActionId(model).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ContentActionId>, _003CGetActionId_003Ed__6>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ContentActionId>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ContentActionId result = val.GetResult();
				ContentActionId obj = InterfaceCreator.Create<ContentActionId>();
				obj.set_Value(result.get_Value());
				result2 = obj;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CInit_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ContentActionManager _003C_003E4__this;

		public Guid moduleUid;

		private IDictionary<string, ContentAction> _003CcontentActions_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ContentActionManager contentActionManager = _003C_003E4__this;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ContentAction>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ContentAction>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ac;
				}
				TaskAwaiter<System.Collections.Generic.ICollection<ContentAction>> val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter<System.Collections.Generic.ICollection<ContentAction>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_014e;
				}
				if (!contentActionManager.cache.ContainsKey(moduleUid))
				{
					if (!contentActionManager.cache.TryGetValue(moduleUid, ref _003CcontentActions_003E5__2))
					{
						_003CcontentActions_003E5__2 = (IDictionary<string, ContentAction>)(object)new Dictionary<string, ContentAction>();
					}
					val = contentActionManager.contentActionCacheService.GetFromCache().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ContentAction>>, _003CInit_003Ed__10>(ref val, ref this);
						return;
					}
					goto IL_00ac;
				}
				goto end_IL_000e;
				IL_01a7:
				System.Collections.Generic.IEnumerator<IContentActionV2> enumerator = contentActionManager.contentActionsV2.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						IContentActionV2 current = enumerator.get_Current();
						_003CcontentActions_003E5__2.set_Item(current.Id, current.ContentAction);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				contentActionManager.cache.set_Item(moduleUid, _003CcontentActions_003E5__2);
				goto end_IL_000e;
				IL_014e:
				System.Collections.Generic.ICollection<ContentAction> result = val2.GetResult();
				contentActionManager.contentActionCacheService.Cache((System.Collections.Generic.IEnumerable<ContentAction>)result);
				System.Collections.Generic.IEnumerator<ContentAction> enumerator2 = ((System.Collections.Generic.IEnumerable<ContentAction>)result).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ContentAction current2 = enumerator2.get_Current();
						_003CcontentActions_003E5__2.set_Item(current2.get_Id(), current2);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator2)?.Dispose();
					}
				}
				goto IL_01a7;
				IL_00ac:
				ContentAction[] array = Enumerable.ToArray<ContentAction>(val.GetResult());
				if (array.Length != 0)
				{
					ContentAction[] array2 = array;
					foreach (ContentAction val3 in array2)
					{
						_003CcontentActions_003E5__2.set_Item(val3.get_Id(), val3);
					}
					goto IL_01a7;
				}
				val2 = contentActionManager.contentActionService.LoadAll().GetAwaiter();
				if (!val2.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val2;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<ContentAction>>, _003CInit_003Ed__10>(ref val2, ref this);
					return;
				}
				goto IL_014e;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private readonly IContentActionService contentActionService;

	private readonly System.Collections.Generic.IEnumerable<IContentActionV2> contentActionsV2;

	private readonly IContentActionCacheService contentActionCacheService;

	private readonly IDictionary<Guid, IDictionary<string, ContentAction>> cache = (IDictionary<Guid, IDictionary<string, ContentAction>>)(object)new Dictionary<Guid, IDictionary<string, ContentAction>>();

	public ContentActionManager(IContentActionService contentActionService, System.Collections.Generic.IEnumerable<IContentActionV2> contentActionsV2, IContentActionCacheService contentActionCacheService)
	{
		this.contentActionService = contentActionService;
		this.contentActionsV2 = contentActionsV2;
		this.contentActionCacheService = contentActionCacheService;
	}

	public System.Threading.Tasks.Task<FormBindingModel> GetFormBindingModel(string actionId)
	{
		ContentActionId val = InterfaceCreator.Create<ContentActionId>();
		val.set_Value(actionId);
		return contentActionService.LoadFormBindingModel(val);
	}

	public System.Threading.Tasks.Task<ContentActionId> GetActionId(ContentActionModel model)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetActionId_003Ed__6 _003CGetActionId_003Ed__ = default(_003CGetActionId_003Ed__6);
		_003CGetActionId_003Ed__._003C_003E4__this = this;
		_003CGetActionId_003Ed__.model = model;
		_003CGetActionId_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ContentActionId>.Create();
		_003CGetActionId_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ContentActionId> _003C_003Et__builder = _003CGetActionId_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetActionId_003Ed__6>(ref _003CGetActionId_003Ed__);
		return _003CGetActionId_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<EntityFormView> LoadEntityForm(FormModel model)
	{
		return contentActionService.LoadEntityForm(model);
	}

	public System.Collections.Generic.IEnumerable<ContentAction> GetAll(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		IDictionary<string, ContentAction> val = default(IDictionary<string, ContentAction>);
		if (cache.TryGetValue(moduleUid, ref val))
		{
			return (System.Collections.Generic.IEnumerable<ContentAction>)val.get_Values();
		}
		return (System.Collections.Generic.IEnumerable<ContentAction>)Enumerable.Empty<ContentAction>();
	}

	public ContentAction GetAction(Guid moduleUid, string actionId)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(actionId))
		{
			return null;
		}
		IDictionary<string, ContentAction> val = default(IDictionary<string, ContentAction>);
		ContentAction result = default(ContentAction);
		if (cache.TryGetValue(moduleUid, ref val) && val.TryGetValue(actionId, ref result))
		{
			return result;
		}
		return null;
	}

	internal System.Threading.Tasks.Task Init(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CInit_003Ed__10 _003CInit_003Ed__ = default(_003CInit_003Ed__10);
		_003CInit_003Ed__._003C_003E4__this = this;
		_003CInit_003Ed__.moduleUid = moduleUid;
		_003CInit_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInit_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CInit_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInit_003Ed__10>(ref _003CInit_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CInit_003Ed__._003C_003Et__builder)).get_Task();
	}

	internal void Refresh(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		cache.Remove(moduleUid);
	}
}
