using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
[ServiceKnownType("GetMetadataKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{69668872-46B2-4570-88E0-3BBD380741F6}")]
public class FilesService : IFilesService, ICorePublicService
{
	public const string GuidS = "{69668872-46B2-4570-88E0-3BBD380741F6}";

	public static Guid Guid = new Guid("{69668872-46B2-4570-88E0-3BBD380741F6}");

	private CommonSettings commonSettings;

	private static IEnumerable<IExtendedFilePermissionValidator> extendedFilePermissionValidators;

	private static IEnumerable<IExtendedFilePermissionValidator> ExtendedFilePermissionValidators => extendedFilePermissionValidators ?? (extendedFilePermissionValidators = Locator.GetServiceNotNull<IEnumerable<IExtendedFilePermissionValidator>>());

	protected CommonSettings CommonSettings => commonSettings ?? (commonSettings = Locator.GetServiceNotNull<CommonSettingsModule>().Settings);

	private long MaxFileSize()
	{
		return CommonSettings.MaxFileSize;
	}

	public long FileSize(Guid uid)
	{
		try
		{
			return DataAccessManager.FileManager.FileSize(uid.ToString());
		}
		catch (FileNotFoundException)
		{
			string filePath = Locator.GetServiceNotNull<ICacheFilesService>().GetFilePath(uid);
			if (filePath.IsNullOrWhiteSpace())
			{
				throw new FileNotFoundException(SR.T("Файл с идентификатором {0} не найден в хранилище системы", uid));
			}
			return new FileInfo(filePath).Length;
		}
	}

	public Stream Download(Guid uid)
	{
		string errMessage = string.Empty;
		BinaryFile file;
		try
		{
			file = DataAccessManager.FileManager.LoadFile(uid.ToString());
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex);
			errMessage = ex.Message;
			file = null;
		}
		if (file != null)
		{
			try
			{
				file.CheckLoaded();
				if (ExtendedFilePermissionValidators.Any((IExtendedFilePermissionValidator v) => !v.HasPermission(file, out errMessage)))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Произошла ошибка доступа"), new SecurityException(errMessage), 403);
				}
			}
			catch (WebFaultException)
			{
				throw;
			}
			catch (Exception message)
			{
				Logger.Log.Error(message);
				file = null;
			}
		}
		if (file == null)
		{
			file = Locator.GetServiceNotNull<ICacheFilesService>().GetBinaryFile(uid);
		}
		try
		{
			if (file == null)
			{
				if (!string.IsNullOrWhiteSpace(errMessage))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при получении файла") + Environment.NewLine + errMessage, 403);
				}
				throw new FileNotFoundException(SR.T("Файл с идентификатором {0} не найден в хранилище системы", uid));
			}
			string name = file.Name;
			if (!name.IsNullOrWhiteSpace())
			{
				string headerValue = FileResult.ContentDispositionUtil.GetHeaderValue(name);
				WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-Disposition", headerValue);
				if (OperationContext.Current == null || IsWebHttpBinding(typeof(IFilesService)))
				{
					string typeByExtension = Locator.GetServiceNotNull<IMimeMappingService>().GetTypeByExtension(file.Extension);
					WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-Type", typeByExtension);
				}
			}
			bool isPartial = false;
			long fileLength;
			long startOffset;
			long endOffset;
			Stream partialFileStream = FileUpDownHelper.GetPartialFileStream(file.GetContent(), out fileLength, out startOffset, out endOffset, out isPartial, out errMessage);
			if (isPartial)
			{
				WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-Range", $"bytes {startOffset}-{endOffset}/{fileLength}");
				WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.PartialContent;
			}
			return partialFileStream;
		}
		catch (WebFaultException)
		{
			throw;
		}
		catch (FileNotFoundException ex4)
		{
			throw PublicServiceException.CreateWebFault(ex4.Message, ex4, 404);
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при получении файла"), innerException, 500);
		}
	}

	public Guid Upload(Stream body)
	{
		ICacheFilesService serviceNotNull = Locator.GetServiceNotNull<ICacheFilesService>();
		string requestHeader = APIRouteProvider.GetRequestHeader("FileGuid");
		string requestHeader2 = APIRouteProvider.GetRequestHeader("FileName");
		string text = string.Empty;
		if (!requestHeader2.IsNullOrWhiteSpace())
		{
			text = HttpUtility.UrlDecode(requestHeader2);
		}
		if (text.IsNullOrWhiteSpace())
		{
			throw PublicServiceException.CreateWebFault(SR.T("Необходимо указать имя файла в заголовке запроса \"FileName\", закодированное при помощи UrlEncode"), 400);
		}
		string extension = Path.GetExtension(text);
		if (CommonSettings.GetInvalidFileExtensions().Contains(extension, StringComparer.InvariantCultureIgnoreCase))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Недопустимое расширение файла (\"{0}\")", extension), 400);
		}
		string s = APIRouteProvider.GetRequestHeader("FileLength") ?? APIRouteProvider.GetRequestHeader("Content-Length");
		long result = -1L;
		long startPos = -1L;
		long endPos = -1L;
		string requestHeader3 = APIRouteProvider.GetRequestHeader("Content-Range");
		string requestHeader4 = APIRouteProvider.GetRequestHeader("Range");
		if (requestHeader3.IsNullOrEmpty())
		{
			if (!long.TryParse(s, out result))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Не удалось определить размер пересылаемого контента."), 400);
			}
			FileUpDownHelper.GetRanges(requestHeader4, result, out var RangesStartIndexes, out var RangesEndIndexes);
			if (result > 0 && (RangesStartIndexes.Length != 0 || RangesEndIndexes.Length != 0))
			{
				if (RangesStartIndexes.Length > 1 || RangesEndIndexes.Length > 1)
				{
					throw PublicServiceException.CreateWebFault(SR.T("Несколько интервалов в заголовке \"Range\" не поддерживается"), 400);
				}
				startPos = RangesStartIndexes[0];
				endPos = RangesEndIndexes[0];
				if (endPos > result)
				{
					endPos = result;
				}
			}
		}
		else
		{
			FileUpDownHelper.GetContentRange(requestHeader3, out result, out startPos, out endPos);
		}
		Guid result2;
		if (!requestHeader.IsNullOrWhiteSpace())
		{
			if (!Guid.TryParse(requestHeader, out result2))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Невозможно привести заголовок запроса \"FileGuid\" к типу Guid"), 400);
			}
			if (startPos > 0 || endPos > 0)
			{
				try
				{
					long num = MaxFileSize() * 1024 * 1024;
					if (result == 0L)
					{
						throw new Exception(SR.T("Загрузка файла не удалась. Файл пустой."));
					}
					if (result > num)
					{
						throw new Exception(SR.T("Загрузка файла не удалась. Размер файла превышает максимальный размер файла при загрузке."));
					}
					if (!FileUpDownHelper.CreateOrAppendIncrementFile(ref result2, text, body, startPos, endPos))
					{
						throw new Exception(SR.T("Загрузка файла не удалась"));
					}
				}
				catch (Exception ex)
				{
					throw PublicServiceException.CreateWebFault(ex.Message, 400);
				}
			}
			else
			{
				serviceNotNull.AppendCacheFile(result2, body);
			}
			if (!FileUpDownHelper.DeepCheckFileExtension(serviceNotNull.GetFilePath(result2)))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Файл не прошел глубокую проверку расширения"), 400);
			}
			return result2;
		}
		result2 = serviceNotNull.CreateCacheFile(text);
		serviceNotNull.IncrementCacheFile(result2, body, 0L);
		if (!FileUpDownHelper.DeepCheckFileExtension(serviceNotNull.GetFilePath(result2)))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Файл не прошел глубокую проверку расширения"), 400);
		}
		return result2;
	}

	public IEnumerable<string> PreviewFileTypes()
	{
		return (from c in ComponentManager.Current.GetExtensionPoints<IFilePreviewCreator>()
			where c.EnableGenerateHtml()
			select c).ToList().SelectMany((IFilePreviewCreator c) => c.Extensions).ToList();
	}

	public Stream DownloadPreview(Guid uid)
	{
		BinaryFile file = DataAccessManager.FileManager.LoadFile(uid.ToString());
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (!serviceNotNull.IsSupportPreview(file))
		{
			Exception ex = new Exception(SR.T("Для данного типа файла система не формирует превью"));
			throw PublicServiceException.CreateWebFault(ex.Message, ex, 404);
		}
		IFilePreviewCreator previewCreator = serviceNotNull.GetPreviewCreator(file);
		if (previewCreator == null)
		{
			Exception ex2 = new Exception(SR.T("Для данного типа файла система не формирует превью"));
			throw PublicServiceException.CreateWebFault(ex2.Message, ex2, 404);
		}
		if (!previewCreator.IsAvaliable(file))
		{
			Exception ex3 = new Exception(SR.T("Формирование певью для этого типа файла отключено в настройках. Для включения генерации превью по этому типу обратитесь к администратору"));
			throw PublicServiceException.CreateWebFault(ex3.Message, ex3, 501);
		}
		if (!previewCreator.HasPreview(file))
		{
			Exception ex4 = new Exception(SR.T("Предпросмотр для файла еще не готов"));
			throw PublicServiceException.CreateWebFault(ex4.Message, ex4, 204);
		}
		try
		{
			string archive = Locator.GetServiceNotNull<IFilePreviewArchiverService>().GetArchive(file);
			bool isPartial = false;
			string errMessage = string.Empty;
			long fileLength;
			long startOffset;
			long endOffset;
			FileStream result = FileUpDownHelper.GetPartialFileStream(archive, out fileLength, out startOffset, out endOffset, out isPartial, out errMessage) as FileStream;
			if (isPartial)
			{
				WebOperationContext.Current.OutgoingResponse.Headers.Add("Content-Range", $"bytes {startOffset}-{endOffset}/{fileLength}");
				WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.PartialContent;
			}
			return result;
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка при получении файла"), innerException, 500);
		}
	}

	private static bool IsWebHttpBinding(Type contractType)
	{
		if (OperationContext.Current == null && HttpContextAccessor.CurrentContext != null)
		{
			return true;
		}
		if (OperationContext.Current == null)
		{
			return false;
		}
		ServiceEndpoint serviceEndpoint = OperationContext.Current.EndpointDispatcher.ChannelDispatcher.Host.Description.Endpoints.Find(contractType);
		if (serviceEndpoint != null)
		{
			return serviceEndpoint.Binding.Name == "WebHttpBinding-ELMA";
		}
		return false;
	}
}
