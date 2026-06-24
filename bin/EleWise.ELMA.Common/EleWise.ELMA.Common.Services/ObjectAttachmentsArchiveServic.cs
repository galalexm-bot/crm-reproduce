using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Services;

[Service]
internal class ObjectAttachmentsArchiveService : IObjectAttachmentsArchiveServiceExt, IObjectAttachmentsArchiveService, IObjectAttachmentsArchiveServiceCheckFileExt
{
	private const long maxSizeZipArchive = 1073741824L;

	private readonly IZipService ZipService;

	private readonly ICacheFilesService CacheFilesService;

	private readonly IEnumerable<IExtendedFilePermissionValidator> ExtendedFilePermissionValidator;

	public ObjectAttachmentsArchiveService(IZipService zipService, ICacheFilesService cacheFilesService, IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators)
	{
		ZipService = zipService;
		CacheFilesService = cacheFilesService;
		ExtendedFilePermissionValidator = extendedFilePermissionValidators;
	}

	public Guid CreateArchiveCacheFile(string[] uidArray)
	{
		return CreateArchiveCacheFile(uidArray, null);
	}

	public Guid CreateArchiveCacheFile(string[] uidArray, string fileNameEntity)
	{
		return CreateArchiveCacheFileAndCheckSizeFile(uidArray, null)?.GuidArchive ?? Guid.Empty;
	}

	public AttachmentArchiveModel CreateArchiveCacheFileAndCheckSizeFile(string[] uidArray, string fileNameEntity)
	{
		string errMessage = string.Empty;
		string tempFileNameWithoutExtension = IOExtensions.GetTempFileNameWithoutExtension();
		Guid guid = Guid.NewGuid();
		string text = (fileNameEntity.IsNullOrEmpty() ? IOExtensions.GetTempFileName(".zip") : (fileNameEntity.ReplaceInvalidFileNameChars() + ".zip"));
		if (!Directory.Exists(tempFileNameWithoutExtension))
		{
			Directory.CreateDirectory(tempFileNameWithoutExtension);
		}
		AttachmentArchiveModel attachmentArchiveModel = new AttachmentArchiveModel();
		try
		{
			long num = 0L;
			List<BinaryFile> list = new List<BinaryFile>();
			foreach (string id in uidArray)
			{
				BinaryFile storableBinaryFile = GetStorableBinaryFile(id, out errMessage);
				num += storableBinaryFile?.GetSize() ?? 0;
				list.Add(storableBinaryFile);
			}
			attachmentArchiveModel.CheckSizeFile = 1073741824 > num;
			if (!attachmentArchiveModel.CheckSizeFile)
			{
				return attachmentArchiveModel;
			}
			foreach (BinaryFile item in list)
			{
				if (!errMessage.IsNullOrEmpty())
				{
					Logger.Log.Error(SR.T("[Не удалось получить файл из хранилища: {0}]", errMessage));
				}
				if (item != null)
				{
					string text2 = item.Name.ReplaceInvalidFileNameChars();
					string text3 = Path.Combine(tempFileNameWithoutExtension, text2);
					if (File.Exists(text3))
					{
						text3 = Path.Combine(string.Concat(Path.GetFileNameWithoutExtension(text2), "_", item.Uid, item.Extension));
					}
					item.SaveToLocalPath(Path.Combine(tempFileNameWithoutExtension, text3));
				}
			}
			Exception ex = ZipService.CreateZipFolder(text, tempFileNameWithoutExtension);
			if (ex != null)
			{
				Logger.Log.Error(SR.T("Ошибка при архивировании папки"), ex);
			}
			CacheFilesService.CreateCacheFileByUid(guid, text);
			using FileStream inputStream = File.OpenRead(text);
			CacheFilesService.IncrementCacheFile(guid, inputStream, 0L);
		}
		finally
		{
			if (Directory.Exists(tempFileNameWithoutExtension))
			{
				Directory.Delete(tempFileNameWithoutExtension, recursive: true);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
		}
		attachmentArchiveModel.GuidArchive = guid;
		return attachmentArchiveModel;
	}

	private BinaryFile GetStorableBinaryFile(string id, out string errMessage)
	{
		errMessage = string.Empty;
		BinaryFile file;
		try
		{
			file = DataAccessManager.FileManager.LoadFile(id);
		}
		catch (Exception ex)
		{
			errMessage = ex.Message;
			return null;
		}
		string newErrorMessage = "";
		if (ExtendedFilePermissionValidator.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out newErrorMessage)))
		{
			errMessage = newErrorMessage;
			return null;
		}
		return file;
	}
}
