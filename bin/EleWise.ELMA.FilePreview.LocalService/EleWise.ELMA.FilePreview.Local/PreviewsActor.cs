using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FilePreview.LocalService.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.FilePreview.LocalService.Actors;

internal sealed class PreviewsActor : Actor, IPreviewsActor, IActorWithGuidKey, IActor
{
	private readonly ILogger logger;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IFileManager fileManager;

	private readonly ISecurityService securityService;

	private readonly IFilePreviewService previewService;

	private readonly ICreateFilePreviewSettings settings;

	private readonly IEnumerable<ICreateFilePreviewItemIndex> filePreviewItemIndexElements;

	private readonly CreateFilePreviewQueueItemManager queue;

	private readonly string filePreviewRootDir;

	private readonly TimeSpan[] attemptIntervals = new TimeSpan[8]
	{
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(5.0),
		TimeSpan.FromMinutes(15.0),
		TimeSpan.FromMinutes(30.0),
		TimeSpan.FromHours(1.0),
		TimeSpan.FromHours(1.0),
		TimeSpan.FromHours(1.0),
		TimeSpan.FromHours(1.0)
	};

	public PreviewsActor(ILoggerFactory factory, IActorModelRuntime actorModelRuntime, IFileManager fileManager, ICreateFilePreviewSettings settings, ISecurityService securityService, IFilePreviewService previewService, IEnumerable<ICreateFilePreviewItemIndex> filePreviewItemIndexElements)
	{
		logger = factory.CreateLogger("PreviewsActor");
		this.actorModelRuntime = actorModelRuntime;
		this.fileManager = fileManager;
		this.settings = settings;
		this.securityService = securityService;
		this.previewService = previewService;
		this.filePreviewItemIndexElements = filePreviewItemIndexElements;
		queue = CreateFilePreviewQueueItemManager.Instance;
		filePreviewRootDir = this.fileManager.PreviewsPath;
		if (!Directory.Exists(filePreviewRootDir))
		{
			Directory.CreateDirectory(filePreviewRootDir);
		}
	}

	public Task QueueWorkItem(string fileId, long priority)
	{
		try
		{
			ICreateFilePreviewQueueItem createFilePreviewQueueItem = queue.FindItemById(fileId);
			if (createFilePreviewQueueItem == null)
			{
				createFilePreviewQueueItem = InterfaceActivator.Create<ICreateFilePreviewQueueItem>();
				createFilePreviewQueueItem.FileId = fileId;
				createFilePreviewQueueItem.Status = PreviewWorkStatus.None;
				createFilePreviewQueueItem.Priority = priority;
				createFilePreviewQueueItem.Save();
			}
			else
			{
				createFilePreviewQueueItem.Priority = priority;
				createFilePreviewQueueItem.Save();
			}
		}
		catch (Exception ex)
		{
			logger.Error("An error occurred while attempting to add the work item to the queue: " + ex.Message, ex);
			return Task.FromException(ex);
		}
		return Task.CompletedTask;
	}

	public async Task<bool> RunWork(string fileId, string fileEncryptPassword, string password)
	{
		BinaryFile binaryFile = fileManager.LoadFile(fileId);
		if (binaryFile.Encrypt)
		{
			if (fileEncryptPassword == null)
			{
				logger.Error(SR.T("Ошибка генерации предпросмотра. Не указан пароль для расшифровки файла"));
				return false;
			}
			BinaryFile binaryFile2 = DataAccessManager.FileManager.Decrypt(binaryFile, fileEncryptPassword);
			binaryFile2.Uid = binaryFile.Uid;
			binaryFile2.Id = binaryFile.Id;
			binaryFile = binaryFile2;
		}
		try
		{
			await StartWorker(binaryFile, password);
			return true;
		}
		catch (Exception ex)
		{
			logger.Error(SR.T("Ошибка генерации предпросмотра. Работа внешнего генератора предпросмотра для файла #Id={0} завершилась с ошибкой: {1}", fileId, ex.Message));
			return false;
		}
	}

	public Task RemoveWorkItem(string fileId)
	{
		try
		{
			queue.FindItemById(fileId)?.Delete();
		}
		catch (Exception ex)
		{
			logger.Error("An error occurred while attempting to remove the work item from the queue: " + ex.Message, ex);
			return Task.FromException(ex);
		}
		return Task.CompletedTask;
	}

	public override Task OnActivateAsync()
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(settings.CheckQueuePeriod);
		RegisterTimer(ProcessQueue, null, timeSpan, timeSpan);
		return Task.CompletedTask;
	}

	private Task ProcessQueue(object arg)
	{
		IList<ICreateFilePreviewQueueItem> list = null;
		List<(ICreateFilePreviewQueueItem, BinaryFile, Task)> list2 = new List<(ICreateFilePreviewQueueItem, BinaryFile, Task)>();
		list = queue.GetNewElements();
		if (list.Count == 0)
		{
			return Task.CompletedTask;
		}
		foreach (ICreateFilePreviewQueueItem item2 in list)
		{
			item2.Status = PreviewWorkStatus.InProgress;
			item2.Save();
			try
			{
				BinaryFile binaryFile = fileManager.LoadFile(item2.FileId);
				Task item = StartWorker(binaryFile);
				list2.Add((item2, binaryFile, item));
			}
			catch (Exception ex)
			{
				item2.Delete();
				logger.Error("An error occurred while attempting to start preview generation: " + ex.Message, ex);
			}
		}
		foreach (var work in list2)
		{
			work.Item3.ContinueWith(delegate(Task task)
			{
				using (CallContextSessionOwner.Create())
				{
					if (task.IsFaulted)
					{
						logger.Error(SR.T("Ошибка генерации предпросмотра. Работа внешнего генератора предпросмотра для файла #Id={0} завершилась с ошибкой: {1}", work.Item1.FileId, task.Exception.InnerException.Message));
						work.Item1.NextAttemptDate = work.Item1.NextAttemptDate?.Add(attemptIntervals[work.Item1.Attempt]) ?? DateTime.Now.Add(attemptIntervals[work.Item1.Attempt]);
						work.Item1.Attempt++;
						work.Item1.Status = PreviewWorkStatus.Fail;
						work.Item1.Save();
					}
					else
					{
						foreach (ICreateFilePreviewItemIndex indexElement in filePreviewItemIndexElements)
						{
							securityService.RunBySystemUser(delegate
							{
								indexElement.AddPreviewToIndexQueue(work.Item2);
							});
						}
						work.Item1.Delete();
					}
				}
			});
		}
		queue.DeleteExecuted();
		return Task.CompletedTask;
	}

	private Task StartWorker(BinaryFile file, string password = null)
	{
		IFilePreviewCreatorEx filePreviewCreator = GetFilePreviewCreator(file);
		if (filePreviewCreator == null)
		{
			return Task.FromException(new NotSupportedException(SR.T("Ошибка генерации предпросмотра. Не удалось получить генератор предпросмотра для файла #Id={0}", file.Id)));
		}
		if (filePreviewCreator is IPasswordFilePreviewCreatorEx passwordFilePreviewCreatorEx && !passwordFilePreviewCreatorEx.CheckPassword(file, password))
		{
			return Task.FromException(new NotSupportedException(SR.T("Ошибка генерации предпросмотра. Не указан пароль для расшифровки файла #Id={0}", file.Id)));
		}
		string contentFilePath = file.ContentFilePath;
		string fileId = ((file.Uid != Guid.Empty) ? file.Uid.ToString() : file.Id);
		string mainFileName = filePreviewCreator.GetMainFileName(file);
		if (File.Exists(mainFileName))
		{
			return Task.CompletedTask;
		}
		if (filePreviewCreator.RequiredExternalCreator)
		{
			return actorModelRuntime.GetActor<IPreviewWorkDispatcherActor>(file.Uid).Process(fileId, filePreviewCreator.ExternalCreatorFileName, contentFilePath, mainFileName, (filePreviewCreator is IPasswordFilePreviewCreatorEx) ? password : null);
		}
		return Task.CompletedTask;
	}

	private IFilePreviewCreatorEx GetFilePreviewCreator(BinaryFile file)
	{
		string ext = Path.GetExtension(file.ContentFilePath);
		if (string.IsNullOrEmpty(ext))
		{
			return null;
		}
		return ComponentManager.Current.GetExtensionPoints<IFilePreviewCreator>().FirstOrDefault((IFilePreviewCreator c) => c.Extensions.Any((string e) => e.Equals(ext, StringComparison.OrdinalIgnoreCase)) && c.IsAvaliable(file)) as IFilePreviewCreatorEx;
	}
}
