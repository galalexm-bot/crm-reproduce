using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.SDK.Web.ExtensionPoints;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Service;

public class FileUpDownHelper
{
	private static ILogger logger;

	private static ICacheFilesService cacheFilesService;

	private static ILogger Logger
	{
		get
		{
			if (logger == null)
			{
				logger = EleWise.ELMA.Logging.Logger.GetLogger("Files");
			}
			return logger;
		}
	}

	private static ICacheFilesService CacheFilesService
	{
		get
		{
			if (cacheFilesService == null)
			{
				cacheFilesService = Locator.GetServiceNotNull<ICacheFilesService>();
			}
			return cacheFilesService;
		}
	}

	[Obsolete("Данный метод устарел, используйте вместо него IExtendedFilePermissionValidator.HasPermission", true)]
	public static void HasPermissionOnFile(BinaryFile file)
	{
		HasPermissionOnFile(file, out var _);
	}

	[Obsolete("Данный метод устарел, используйте вместо него IExtendedFilePermissionValidator.HasPermission", true)]
	public static void HasPermissionOnFile(BinaryFile file, out string errorMessage)
	{
		errorMessage = string.Empty;
		if (file != null)
		{
			IEnumerable<IExtendedFilePermissionValidator> extensionPoints = ComponentManager.Current.GetExtensionPoints<IExtendedFilePermissionValidator>();
			string newErrorMessage = "";
			if (extensionPoints.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out newErrorMessage)))
			{
				errorMessage = newErrorMessage;
				throw new SecurityException(newErrorMessage);
			}
		}
	}

	public static BinaryFile PrepareBinaryFile(BinaryFile file)
	{
		(from p in ComponentManager.Current.GetExtensionPoints<IPrepareFileToDownload>()
			where p.Check(file)
			select p).ForEach(delegate(IPrepareFileToDownload p)
		{
			file = p.Prepare(file);
		});
		return file;
	}

	public static void GetRanges(string rangesHeader, long fileLength, out long[] RangesStartIndexes, out long[] RangesEndIndexes)
	{
		char[] separator = new char[1] { ',' };
		char[] separator2 = new char[1] { '-' };
		rangesHeader = (string.IsNullOrEmpty(rangesHeader) ? "" : rangesHeader.Replace("\"", string.Empty));
		if (rangesHeader.IsNullOrEmpty())
		{
			RangesStartIndexes = new long[0];
			RangesEndIndexes = new long[0];
			return;
		}
		string[] array = rangesHeader.Replace("bytes=", string.Empty).Split(separator);
		RangesStartIndexes = new long[array.Length];
		RangesEndIndexes = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(separator2);
			if (string.IsNullOrEmpty(array2[1]))
			{
				RangesEndIndexes[i] = fileLength - 1;
			}
			else
			{
				RangesEndIndexes[i] = long.Parse(array2[1]);
			}
			if (string.IsNullOrEmpty(array2[0]))
			{
				RangesStartIndexes[i] = fileLength - 1 - RangesEndIndexes[i];
				RangesEndIndexes[i] = fileLength - 1;
			}
			else
			{
				RangesStartIndexes[i] = long.Parse(array2[0]);
			}
		}
	}

	public static void GetContentRange(string rangeHeader, out long fileLength, out long startPos, out long endPos)
	{
		if (rangeHeader.IsNullOrEmpty())
		{
			fileLength = -1L;
			startPos = -1L;
			endPos = -1L;
			return;
		}
		string[] array = rangeHeader.Replace("bytes", "").Split("-/".ToCharArray());
		if (array.Length != 3)
		{
			Logger.WarnFormat(SR.T("Не корректный формат заголовка Content-Range: {0}"), rangeHeader);
			fileLength = -1L;
			startPos = -1L;
			endPos = -1L;
		}
		else
		{
			startPos = long.Parse(array[0]);
			endPos = long.Parse(array[1]);
			fileLength = long.Parse(array[2]);
		}
	}

	[Obsolete("Данный метод устарел, используйте вместо него FileManager.LoadFile для загрузки файла и IExtendedFilePermissionValidator.HasPermisson для проверки прав на этот файл", true)]
	public static BinaryFile GetStorableBinaryFile(string id, out string errMessage)
	{
		errMessage = string.Empty;
		BinaryFile binaryFile;
		try
		{
			binaryFile = DataAccessManager.FileManager.LoadFile(id);
		}
		catch (Exception ex)
		{
			errMessage = ex.Message;
			return null;
		}
		try
		{
			HasPermissionOnFile(binaryFile);
			return binaryFile;
		}
		catch (SecurityException ex2)
		{
			errMessage = ex2.Message;
			throw;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Stream GetPartialFileStream(string filePath, out long fileLength, out long startOffset, out long endOffset, out bool isPartial, out string errMessage)
	{
		return GetPartialFileStream(File.OpenRead(filePath), out fileLength, out startOffset, out endOffset, out isPartial, out errMessage);
	}

	public static Stream GetPartialFileStream(Stream fs, out long fileLength, out long startOffset, out long endOffset, out bool isPartial, out string errMessage)
	{
		string requestHeader = APIRouteProvider.GetRequestHeader("Range");
		try
		{
			fileLength = fs.Length;
			GetRanges(requestHeader, fileLength, out var RangesStartIndexes, out var RangesEndIndexes);
			if (RangesStartIndexes.Length != 0 || RangesEndIndexes.Length != 0)
			{
				if (RangesStartIndexes.Length > 1 || RangesEndIndexes.Length > 1)
				{
					throw new ArgumentException(SR.T("Несколько интервалов в заголовке \"Range\" не поддерживается"));
				}
				startOffset = RangesStartIndexes[0];
				endOffset = RangesEndIndexes[0];
				isPartial = true;
				errMessage = string.Empty;
				if (endOffset >= fileLength)
				{
					endOffset = fileLength - 1;
				}
				if (RangesEndIndexes[0] < fileLength)
				{
					return new RangeStreamWrapper(fs, startOffset, endOffset);
				}
				fs.Seek(startOffset, SeekOrigin.Begin);
				return fs;
			}
			errMessage = string.Empty;
			startOffset = 0L;
			fileLength = (endOffset = fs.Length);
			isPartial = false;
			return fs;
		}
		catch (Exception ex)
		{
			errMessage = ex.Message;
			fileLength = (startOffset = (endOffset = 0L));
			isPartial = false;
			return null;
		}
	}

	private static bool CreateCacheFileIfNeeded(ref Guid fileGuid, string fileName)
	{
		if (fileGuid == Guid.Empty)
		{
			fileGuid = CacheFilesService.CreateCacheFile(fileName);
			if (fileGuid == Guid.Empty)
			{
				Logger.WarnFormat(SR.T("Не удалось создать временный файл"));
				return false;
			}
		}
		return true;
	}

	public static bool CreateOrAppendIncrementFile(ref Guid fileGuid, string fileName, Stream inputStream, long startPos, long endPos)
	{
		if (!CreateCacheFileIfNeeded(ref fileGuid, fileName))
		{
			return false;
		}
		return CreateOrAppendIncrementFile(fileGuid, inputStream, startPos, endPos);
	}

	public static bool CreateOrAppendIncrementFile(Guid fileGuid, Stream inputStream, long startPos, long endPos)
	{
		bool num = CacheFilesService.IncrementCacheFile(fileGuid, inputStream, startPos, endPos);
		if (!num)
		{
			Logger.WarnFormat(SR.T("Ошибка записи во временный файл"));
		}
		return num;
	}

	public static bool CheckFileLength(ref Guid fileGuid, string fileName, long fileLength, long maxFileSize)
	{
		if (!CreateCacheFileIfNeeded(ref fileGuid, fileName))
		{
			return false;
		}
		Logger.DebugFormat("CheckFileLength - filePath: {0}", CacheFilesService.GetFilePath(fileGuid));
		return fileLength + CacheFilesService.GetFileLength(fileGuid) <= maxFileSize;
	}

	internal static bool DeepCheckFileExtension(string tempFilePath)
	{
		IEnumerable<IDeepExtensionCheck> extensionPoints = ComponentManager.Current.GetExtensionPoints<IDeepExtensionCheck>();
		if (extensionPoints.Any())
		{
			return extensionPoints.Any((IDeepExtensionCheck p) => p.DeepCheckFileExtension(tempFilePath));
		}
		return true;
	}
}
