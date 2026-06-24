using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Service;
using Newtonsoft.Json;

namespace EleWise.ELMA.Web.Mvc.Helpers;

internal static class UploadAjaxHelper
{
	internal class UploadAjaxArg
	{
		public string FileName { get; set; }

		public Stream Stream { get; set; }

		public Func<Guid, string> CreateHref { get; set; }

		public long MaxFileSizeMb { get; set; }

		public List<string> InvalidFileExtensions { get; set; }

		public IDictionary<string, string> Headers { get; set; }

		public ILogger Logger { get; set; }

		public UploadAjaxArg()
		{
			InvalidFileExtensions = new List<string>();
			Headers = new Dictionary<string, string>();
		}
	}

	internal static CachFileUploadInfo UploadAjax(UploadAjaxArg arg)
	{
		long maxFileSizeMb = arg.MaxFileSizeMb;
		long num = maxFileSizeMb * 1024 * 1024;
		Guid result = Guid.Empty;
		arg.Headers.TryGetValue("FileGuid", out var value);
		string empty = string.Empty;
		long fileLength = 0L;
		long startPos = 0L;
		long endPos = 0L;
		bool flag = false;
		ILogger logger = arg.Logger;
		string error = SR.T("Неизвестная ошибка.");
		CachFileUploadInfo cachFileUploadInfo = new CachFileUploadInfo
		{
			JsonData = JsonConvert.SerializeObject((object)new
			{
				success = false,
				error = error
			})
		};
		try
		{
			string extension = Path.GetExtension(arg.FileName);
			if (arg.InvalidFileExtensions.Contains(extension, StringComparer.InvariantCultureIgnoreCase))
			{
				error = SR.T("Ошибка. Недопустимое расширение файла (\"{0}\")", extension);
				logger?.Warn(error);
				cachFileUploadInfo.JsonData = JsonConvert.SerializeObject((object)new
				{
					success = false,
					error = error
				});
				return cachFileUploadInfo;
			}
			if (string.IsNullOrEmpty(value))
			{
				result = Guid.Empty;
			}
			else if (!Guid.TryParse(value, out result))
			{
				error = SR.T("Ошибка. Переданный UID файла некорректен");
				logger?.Warn(error);
				cachFileUploadInfo.JsonData = JsonConvert.SerializeObject((object)new
				{
					success = false,
					error = error
				});
				return cachFileUploadInfo;
			}
			arg.Headers.TryGetValue("Content-Range", out var value2);
			FileUpDownHelper.GetContentRange(value2, out fileLength, out startPos, out endPos);
			long num2 = Math.Max(fileLength, arg.Stream.Length);
			bool flag2 = fileLength > 0 && arg.Stream.Length > 0;
			if (fileLength < num2 || num < num2 || !flag2 || !(flag = FileUpDownHelper.CheckFileLength(ref result, arg.FileName, arg.Stream.Length, num)))
			{
				error = SR.T("Ошибка. Размер файла не корректен");
				logger?.WarnFormat(SR.T("Ошибка. Размер файла не корректен (validMaxSize: {0}; validSizeZero: {1})", flag, flag2));
				cachFileUploadInfo.JsonData = JsonConvert.SerializeObject((object)new
				{
					success = false,
					validMaxSize = flag,
					validSizeZero = flag2,
					maxFileSizeMb = maxFileSizeMb,
					error = error
				});
				return cachFileUploadInfo;
			}
			if (FileUpDownHelper.CreateOrAppendIncrementFile(result, arg.Stream, startPos, endPos))
			{
				empty = ((arg.CreateHref != null) ? arg.CreateHref(result) : empty);
				arg.Headers.TryGetValue("IsLastXhr", out var value3);
				cachFileUploadInfo.UploadComplete = value3 == "true";
				uint fileHash = 0u;
				if (cachFileUploadInfo.UploadComplete)
				{
					string filePath = Locator.GetServiceNotNull<ICacheFilesService>().GetFilePath(result);
					fileHash = Crc32.GetCrcValue(filePath);
					if (!FileUpDownHelper.DeepCheckFileExtension(filePath))
					{
						error = SR.T("Ошибка. Файл не прошел глубокую проверку расширения ({0})", filePath);
						logger?.Warn(error);
						cachFileUploadInfo.JsonData = JsonConvert.SerializeObject((object)new
						{
							success = false,
							error = error
						});
						return cachFileUploadInfo;
					}
				}
				cachFileUploadInfo.JsonData = (cachFileUploadInfo.UploadComplete ? JsonConvert.SerializeObject((object)new
				{
					success = true,
					uid = result,
					fileHref = empty,
					fileSize = fileLength,
					fileName = arg.FileName,
					fileHash = fileHash
				}) : JsonConvert.SerializeObject((object)new
				{
					success = true,
					uid = result
				}));
				cachFileUploadInfo.FileGuid = result;
				return cachFileUploadInfo;
			}
			return cachFileUploadInfo;
		}
		catch (Exception ex)
		{
			error = ex.Message;
			logger?.WarnFormat(error);
			cachFileUploadInfo.JsonData = JsonConvert.SerializeObject((object)new
			{
				success = false,
				error = error
			});
			return cachFileUploadInfo;
		}
	}
}
