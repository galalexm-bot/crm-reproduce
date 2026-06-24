using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.FilePreview.LocalService.Services;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

[StatelessWorker]
internal sealed class PreviewWorkerActor : Actor, IPreviewWorkerActor, IActorWithGuidKey, IActor
{
	private AppDomain domain;

	private readonly ILogger logger;

	private readonly ICreateFilePreviewSettings settings;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	public PreviewWorkerActor(ILoggerFactory factory, ICreateFilePreviewSettings settings, IServerPlacementPublishService serverPlacementPublishService)
	{
		logger = factory.CreateLogger("PreviewWorkerActor");
		this.settings = settings;
		this.serverPlacementPublishService = serverPlacementPublishService;
		if (!AppDomain.MonitoringIsEnabled)
		{
			AppDomain.MonitoringIsEnabled = true;
		}
	}

	public Task Process(string fileId, string creator, string sourceFilePath, string targetFilePath, string password)
	{
		if (domain == null)
		{
			string text = string.Format("{0}-Domain-{1}", "PreviewWorkerActor", Guid.NewGuid());
			try
			{
				domain = AppDomain.CreateDomain(text);
			}
			catch (Exception ex)
			{
				Exception exc = ex;
				logger.Error("Unable to create a new AppDomain '" + text + "' for preview generation.", exc);
				serverPlacementPublishService.For<IPreviewsServerInstanceActor>().Publish((IPreviewsServerInstanceActor actor) => actor.Complete(fileId, exc));
			}
			logger.Warn("A new AppDomain '" + text + "' for preview generation was created successfully.");
		}
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		RunHealthChecks(domain, cancellationTokenSource.Token).ContinueWith(delegate(Task t)
		{
			AppDomain appDomain = domain;
			domain = null;
			logger.Error("An error occurred while generating the preview: " + t.Exception.InnerException.Message, t.Exception.InnerException);
			serverPlacementPublishService.For<IPreviewsServerInstanceActor>().Publish((IPreviewsServerInstanceActor actor) => actor.Complete(fileId, t.Exception.InnerException));
			AppDomain.Unload(appDomain);
		}, cancellationTokenSource.Token, TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		try
		{
			string assemblyFile = Path.Combine(settings.FilePreviewCreatorRoot, creator);
			domain.ExecuteAssembly(assemblyFile, (password == null) ? new string[2] { targetFilePath, sourceFilePath } : new string[3]
			{
				targetFilePath,
				sourceFilePath,
				Convert.ToBase64String(Encoding.UTF8.GetBytes(password))
			});
			serverPlacementPublishService.For<IPreviewsServerInstanceActor>().Publish((IPreviewsServerInstanceActor actor) => actor.Complete(fileId), ignoreError: false, delegate(Guid siloUid, Exception exception)
			{
				Logger.Log.Error($"Silo: {siloUid}", exception);
			});
		}
		catch (AppDomainUnloadedException innerException)
		{
			throw new Exception("The preview generation was forcibly stopped!", innerException);
		}
		finally
		{
			cancellationTokenSource.Cancel();
		}
		return Task.CompletedTask;
	}

	public override Task OnDeactivateAsync()
	{
		try
		{
			AppDomain.Unload(domain);
		}
		catch (CannotUnloadAppDomainException exception)
		{
			logger.Error("An error occurred while attempting to unload the AppDomain.", exception);
		}
		return Task.CompletedTask;
	}

	private Task RunHealthChecks(AppDomain domain, CancellationToken token)
	{
		List<Task> list = new List<Task> { Task.Delay(settings.MaxProcessingTime, token) };
		if (AppDomain.MonitoringIsEnabled)
		{
			list.Add(Task.Run(() => MonitorDomainSize(domain, token)));
		}
		return Task.WhenAny(list).ContinueWith(delegate(Task<Task> task)
		{
			if (!task.Result.IsCanceled)
			{
				throw new Exception($"The preview generation cannot be completed in a reasonable amount of time ({settings.MaxProcessingTime} ms) or exceeds the memory limit of {settings.MaxMemorySize} bytes.");
			}
		}, TaskScheduler.Default);
	}

	private async Task MonitorDomainSize(AppDomain domain, CancellationToken token)
	{
		do
		{
			await Task.Delay(settings.DomainHealthCheckPeriod);
			token.ThrowIfCancellationRequested();
		}
		while (domain.MonitoringSurvivedMemorySize <= settings.MaxMemorySize);
	}
}
