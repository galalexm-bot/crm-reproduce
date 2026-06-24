using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FilePreview.LocalService.Actors;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.FilePreview.LocalService.Services;

[Component]
public class FilePreviewServiceLocal : FilePreviewServiceProvider
{
	private readonly Guid providerUid = new Guid("2F26BC74-BBE3-41F9-BFBC-E835B53C6CDC");

	public IActorModelRuntime ActorModelRuntime { get; set; }

	public IFileManager FileManager { get; set; }

	public ILogger Logger { get; set; }

	public override Guid ProviderUid => providerUid;

	public override void AddFileToQueue(string fileId, long priority)
	{
		ActorModelRuntime.GetActor<IPreviewsActor>(Guid.Empty).QueueWorkItem(fileId, priority);
	}

	public override bool GeneratePreview(string fileId, string fileEncryptPassword, string password)
	{
		return Task.Run(async () => await ActorModelRuntime.GetActor<IPreviewsActor>(Guid.Empty).RunWork(fileId, fileEncryptPassword, password)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter()
			.GetResult();
	}

	public override bool CheckPassword(string fileId, string password)
	{
		return CheckPassword(fileId, null, password);
	}

	public override bool CheckPassword(string fileId, string fileEncryptPassword, string password)
	{
		BinaryFile binaryFile = FileManager.LoadFile(fileId);
		if (binaryFile == null)
		{
			Logger.Error(SR.T("Ошибка генерации предпросмотра. Файл #Id={0} не найден в хранилище", fileId));
			return false;
		}
		if (!(GetFilePreviewCreator(binaryFile) is IPasswordFilePreviewCreator passwordFilePreviewCreator))
		{
			return password == null;
		}
		if (binaryFile.Encrypt)
		{
			if (fileEncryptPassword == null)
			{
				Logger.Error(SR.T("Ошибка генерации предпросмотра. Не указан пароль для расшифровки файла"));
				return false;
			}
			BinaryFile binaryFile2 = DataAccessManager.FileManager.Decrypt(binaryFile, fileEncryptPassword);
			binaryFile2.Uid = binaryFile.Uid;
			binaryFile2.Id = binaryFile.Id;
			binaryFile = binaryFile2;
		}
		return passwordFilePreviewCreator.CheckPassword(binaryFile, password);
	}

	public override void DeleteFileFromQueue(string fileId)
	{
		ActorModelRuntime.GetActor<IPreviewsActor>(Guid.Empty).RemoveWorkItem(fileId);
	}

	public override PreviewWorkStatus GetFilePreviewWorkStatus(string fileId)
	{
		return PreviewWorkStatus.None;
	}
}
