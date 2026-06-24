using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FileProvider.Distributed.IO;
using EleWise.ELMA.FileProvider.Distributed.Models;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.FileProvider.Distributed;

internal class DistributedStorageOperationsProvider : IStorageOperationsProvider, IUploadUrlFactory, IDownloadUrlFactory, IUploadedContentLocationMapperService
{
	private class ContentResponse
	{
		public const int ResultOK = 0;

		public int Result { get; set; }

		public void Validate()
		{
			if (Result != 0)
			{
				throw new IOException(SR.T("Неуспешное завершение длительной команды (код result={0})", Result));
			}
		}
	}

	private class FileContentResponse : ContentResponse
	{
		public FileContentInfo ContentInfo { get; set; }
	}

	private class FileContentInfo
	{
		public long ContentLength { get; set; }

		public string ContentPath { get; set; }

		public uint Crc { get; set; }
	}

	private class HashContentResponse : ContentResponse
	{
		public string Hash { get; set; }
	}

	private class TaskResult
	{
		public const int TaskIsCompleteState = 3;

		public int State { get; set; }

		public Guid Uid { get; set; }

		public void Validate()
		{
			if (State != 3)
			{
				throw new IOException(SR.T("Неожиданное состояние выполненной длительной команды (код state={0})", State));
			}
		}
	}

	private class FileInfoTaskResult : TaskResult
	{
		public FileContentResponse Response { get; set; }
	}

	private class GetHashTaskResult : TaskResult
	{
		public HashContentResponse Response { get; set; }
	}

	private const int ReadBufferSize = 1048576;

	private readonly ILogger logger;

	private readonly DistributedFsLocationSchemaCollection locationSchemaCollection;

	private readonly IStorageOperationsProvider localFsOperationsProvider;

	private readonly IFileGatewayService fileGatewayService;

	private readonly DistributedStorageApiUrlGenerator apiUrlGenerator;

	private readonly EndpointsCollection endpoints;

	protected IFileGatewayService FileGatewayService => fileGatewayService;

	protected DistributedStorageApiUrlGenerator ApiUrlGenerator => apiUrlGenerator;

	public DistributedStorageOperationsProvider(ILogger logger, EndpointsCollection endpoints, IFileGatewayService fileGatewayService, DistributedStorageApiUrlGenerator apiUrlGenerator, DistributedFsLocationSchemaCollection locationSchemaCollection, IStorageOperationsProvider localFsOperationsProvider)
	{
		this.logger = logger;
		this.endpoints = endpoints;
		this.fileGatewayService = fileGatewayService;
		this.apiUrlGenerator = apiUrlGenerator;
		this.locationSchemaCollection = locationSchemaCollection;
		this.localFsOperationsProvider = localFsOperationsProvider;
	}

	public Uri GetSourceContentLocation(SystemFile systemFile)
	{
		return locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
	}

	public Uri SaveContent(Uri srcLocation, SystemFile systemFile, bool deleteSourceAfterSave = false)
	{
		Contract.ArgumentNotNull(srcLocation, "srcLocation");
		Contract.ArgumentNotNull(systemFile, "systemFile");
		string name = ((srcLocation.Scheme == "elma" && !srcLocation.Host.IsNullOrEmpty()) ? srcLocation.Host : FileGatewayService.GetClosestGateway());
		Uri uri = locationSchemaCollection.GetOrDefault(name).MapPersistentLocation(systemFile);
		if (srcLocation != uri)
		{
			Uri saveContentUrl = ApiUrlGenerator.GetSaveContentUrl(srcLocation, VirtualContentPath.GetNameFromVirtualPath(uri.LocalPath));
			PerformSaveRequest(saveContentUrl);
		}
		return uri;
	}

	public void FetchContent(SystemFile systemFile)
	{
		Contract.ArgumentNotNull(systemFile, "systemFile");
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		Uri uri2 = locationSchemaCollection.GetNearestLocationSchema().MapPersistentLocation(systemFile);
		if (uri != uri2)
		{
			string fileCrc = systemFile.FileCrc;
			Uri streamDownloadUrl = ApiUrlGenerator.GetStreamDownloadUrl(uri, fileCrc);
			Uri fetchContentUrl = ApiUrlGenerator.GetFetchContentUrl(uri2, fileCrc, streamDownloadUrl.AbsoluteUri);
			FileInfoTaskResult fileInfoTaskResult = PerformLongRunningCommand<FileInfoTaskResult>(fetchContentUrl);
			FileInfoTaskResult fileInfoTaskResult2 = AwaitCommandResult<FileInfoTaskResult>(uri2.Host, fileInfoTaskResult.Uid);
			fileInfoTaskResult2.Validate();
			fileInfoTaskResult2.Response.Validate();
			if (fileInfoTaskResult2.Response.ContentInfo.ContentPath.IsNullOrEmpty())
			{
				throw new InvalidOperationException(SR.T("Копирование файла из первоисточника закончилось неудачно"));
			}
		}
	}

	public Task FetchContentAsync(SystemFile systemFile, CancellationToken token)
	{
		Contract.ArgumentNotNull(systemFile, "systemFile");
		return Task.Factory.StartNew(delegate
		{
			using (CallContextSessionOwner.Create())
			{
				FetchContent(systemFile);
			}
		}, token);
	}

	public BinaryFileContentInfo DecryptContent(SystemFile systemFile, string password)
	{
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		Uri uri2 = locationSchemaCollection.GetNearestLocationSchema().MapPersistentLocation(systemFile);
		string fileCrc = systemFile.FileCrc;
		string sourceUrl = ((uri != uri2) ? ApiUrlGenerator.GetStreamDownloadUrl(uri, fileCrc).AbsoluteUri : null);
		Uri decryptContentUrl = ApiUrlGenerator.GetDecryptContentUrl(uri2, fileCrc, password, systemFile.Salt, sourceUrl);
		FileInfoTaskResult fileInfoTaskResult = PerformLongRunningCommand<FileInfoTaskResult>(decryptContentUrl);
		FileInfoTaskResult fileInfoTaskResult2 = AwaitCommandResult<FileInfoTaskResult>(uri2.Host, fileInfoTaskResult.Uid);
		fileInfoTaskResult2.Validate();
		fileInfoTaskResult2.Response.Validate();
		FileContentInfo contentInfo = fileInfoTaskResult2.Response.ContentInfo;
		Uri contentLocation = locationSchemaCollection.GetOrDefault(uri2.Host).MapTempLocation(contentInfo.ContentPath, null);
		return new BinaryFileContentInfo
		{
			ContentLength = contentInfo.ContentLength,
			ContentLocation = contentLocation,
			Crc = contentInfo.Crc
		};
	}

	public BinaryFileContentInfo EncryptContent(SystemFile systemFile, string password)
	{
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		Uri encryptContentUrl = ApiUrlGenerator.GetEncryptContentUrl(uri, systemFile.FileCrc, password, systemFile.Salt);
		FileInfoTaskResult fileInfoTaskResult = PerformLongRunningCommand<FileInfoTaskResult>(encryptContentUrl);
		FileInfoTaskResult fileInfoTaskResult2 = AwaitCommandResult<FileInfoTaskResult>(uri.Host, fileInfoTaskResult.Uid);
		fileInfoTaskResult2.Validate();
		fileInfoTaskResult2.Response.Validate();
		FileContentInfo contentInfo = fileInfoTaskResult2.Response.ContentInfo;
		Uri contentLocation = locationSchemaCollection.GetOrDefault(uri.Host).MapTempLocation(contentInfo.ContentPath, null);
		return new BinaryFileContentInfo
		{
			ContentLength = contentInfo.ContentLength,
			ContentLocation = contentLocation,
			Crc = contentInfo.Crc
		};
	}

	public long? GetContentSize(SystemFile systemFile)
	{
		return -1L;
	}

	public Stream OpenPersistentContentReadStream(SystemFile systemFile, GetContentOptions options)
	{
		Contract.ArgumentNotNull(systemFile, "systemFile");
		Contract.ArgumentNotNull(options, "options");
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		string fileCrc = systemFile.FileCrc;
		Uri uri2 = locationSchemaCollection.GetNearestLocationSchema().MapPersistentLocation(systemFile);
		AdditionalDownloadParameters parameters = ((uri2.Host == uri.Host) ? null : new AdditionalDownloadParameters
		{
			SourceUrl = ApiUrlGenerator.GetStreamDownloadUrl(uri, fileCrc).AbsoluteUri
		});
		return new BufferedStream(new HttpReceiveStream(ApiUrlGenerator.GetStreamDownloadUrl(uri2, fileCrc, parameters)), 1048576);
	}

	public Stream OpenTempContentReadStream(Uri contentLocation, GetContentOptions options)
	{
		Contract.ArgumentNotNull(contentLocation, "location");
		Contract.ArgumentNotNull(options, "options");
		if (contentLocation.Scheme == "elma")
		{
			return OpenTempRemoteObjectReadStream(contentLocation, options);
		}
		if (contentLocation.Scheme == "file")
		{
			return localFsOperationsProvider.OpenTempContentReadStream(contentLocation, options);
		}
		throw new NotSupportedException(SR.T("Используется неподдерживаемая схема ссылки на местоположение ({0})", contentLocation.Scheme));
	}

	public Stream OpenTempContentWriteStream(Action<Uri> contentInfoHandler, PutContentOptions options)
	{
		Contract.ArgumentNotNull(options, "options");
		logger.DebugFormat("Opening new write temp stream for content");
		if (options.ForAsync)
		{
			throw new NotImplementedException(SR.T("Асинхронная запись контента на удалённый узел с использованием потока не реализована"));
		}
		Action<string> uploadInfoSetter = delegate(string uid)
		{
			contentInfoHandler(locationSchemaCollection.GetNearestLocationSchema().MapTempLocation(uid, null));
		};
		string closestGateway = FileGatewayService.GetClosestGateway();
		string fileName = closestGateway + "_" + Guid.NewGuid().ToString("N");
		return new HttpSendStream(ApiUrlGenerator.GetUploadUrl(closestGateway, fileName), uploadInfoSetter);
	}

	public Uri GetPersistentContentDownloadUrl(SystemFile systemFile, string password)
	{
		AdditionalDownloadParameters additionalDownloadParameters = new AdditionalDownloadParameters
		{
			ContentType = systemFile.ContentType,
			DownloadName = systemFile.Name
		};
		if (password != null)
		{
			additionalDownloadParameters.Secret = new AdditionalDownloadParameters.SecretCredentials
			{
				Password = password,
				Salt = systemFile.Salt
			};
		}
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		Uri uri2 = locationSchemaCollection.GetNearestLocationSchema().MapPersistentLocation(systemFile);
		if (uri2.Host != uri.Host)
		{
			additionalDownloadParameters.SourceUrl = ApiUrlGenerator.GetStreamDownloadUrl(uri, systemFile.FileCrc).AbsoluteUri;
		}
		return ApiUrlGenerator.GetStreamDownloadUrl(uri2, systemFile.FileCrc, additionalDownloadParameters);
	}

	public Uri GetTempContentDownloadUrl(Uri contentLocation, string contentType, string name)
	{
		AdditionalDownloadParameters parameters = new AdditionalDownloadParameters
		{
			ContentType = contentType,
			DownloadName = name
		};
		return ApiUrlGenerator.GetStreamDownloadUrl(contentLocation, null, parameters);
	}

	public Uri GetClosestUploadBaseUrl()
	{
		string closestGateway = FileGatewayService.GetClosestGateway();
		return ApiUrlGenerator.GetBaseUploadUrl(closestGateway);
	}

	public string GetContentHash(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm)
	{
		Uri uri = locationSchemaCollection.GetSourceLocationSchema(systemFile).MapPersistentLocation(systemFile);
		Uri contentHashUrl = ApiUrlGenerator.GetContentHashUrl(uri, hashAlgorithm.ToString(), systemFile.FileCrc, null);
		GetHashTaskResult getHashTaskResult = PerformLongRunningCommand<GetHashTaskResult>(contentHashUrl);
		GetHashTaskResult getHashTaskResult2 = AwaitCommandResult<GetHashTaskResult>(uri.Host, getHashTaskResult.Uid);
		getHashTaskResult2.Validate();
		getHashTaskResult2.Response.Validate();
		return getHashTaskResult2.Response.Hash;
	}

	public Task<string> GetContentHashAsync(SystemFile systemFile, HashAlogrithmEnum hashAlgorithm, CancellationToken token)
	{
		return Task.Factory.StartNew(() => GetContentHash(systemFile, hashAlgorithm), token, TaskCreationOptions.LongRunning, TaskScheduler.Current);
	}

	Uri IUploadedContentLocationMapperService.GetUploadedContentLocation(string gatewayId, string id)
	{
		return locationSchemaCollection.GetOrDefault(gatewayId).MapTempLocation(id, null);
	}

	private Stream OpenTempRemoteObjectReadStream(Uri location, GetContentOptions options)
	{
		Contract.ArgumentNotNull(options, "options");
		Contract.CheckArgument(location.Scheme == "elma", "location.Scheme == \"elma\"");
		Uri uri = locationSchemaCollection.GetNearestLocationSchema().RemapTempLocationFor(location);
		AdditionalDownloadParameters parameters = ((uri.Host == location.Host) ? null : new AdditionalDownloadParameters
		{
			SourceUrl = ApiUrlGenerator.GetStreamDownloadUrl(location, null).AbsoluteUri
		});
		return new BufferedStream(new HttpReceiveStream(ApiUrlGenerator.GetStreamDownloadUrl(uri, null, parameters)), 1048576);
	}

	private void PerformSaveRequest(Uri url)
	{
		PerformRequest(url, CreateEmptyPostRequest, null, null);
	}

	private T PerformLongRunningCommand<T>(Uri url)
	{
		return PerformRequestWithResult(url, CreateEmptyPostRequest, GetLongRunningCommandResult<T>, null);
	}

	private T AwaitCommandResult<T>(string gatewayId, Guid cmdUid) where T : TaskResult
	{
		bool flag = true;
		DateTime now = DateTime.Now;
		T val = null;
		do
		{
			Thread.Sleep(SleepTimeProvider(DateTime.Now - now));
			Uri checkUrl = ApiUrlGenerator.GetCheckUrl(gatewayId, cmdUid);
			val = PerformRequestWithResult(checkUrl, delegate(HttpWebRequest request)
			{
				request.Method = "GET";
			}, GetLongRunningCommandResult<T>, null);
		}
		while (val.State != 3);
		return val;
	}

	private TimeSpan SleepTimeProvider(TimeSpan timeSinceStart)
	{
		if (timeSinceStart.TotalMilliseconds < 5000.0)
		{
			return TimeSpan.FromMilliseconds(500.0);
		}
		if (timeSinceStart.TotalSeconds < 60.0)
		{
			return TimeSpan.FromSeconds(3.0);
		}
		return TimeSpan.FromSeconds(15.0);
	}

	private void PerformRequest(Uri url, Action<HttpWebRequest> requestBuilder, Action<HttpWebResponse> responseHandler, Action<HttpWebRequest, WebException> errorHandler)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		requestBuilder?.Invoke(httpWebRequest);
		httpWebRequest.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
		try
		{
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				responseHandler?.Invoke(httpWebResponse);
				return;
			}
			throw new Exception(SR.T("Неожиданный (но успешный) ответ от точки хранения контента."));
		}
		catch (WebException ex)
		{
			if (errorHandler != null)
			{
				errorHandler(httpWebRequest, ex);
				return;
			}
			LogErrorHandler(httpWebRequest, ex);
			throw;
		}
	}

	private T PerformRequestWithResult<T>(Uri url, Action<HttpWebRequest> requestBuilder, Func<HttpWebResponse, T> responseHandler, Func<HttpWebRequest, WebException, T> errorHandler)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		requestBuilder?.Invoke(httpWebRequest);
		httpWebRequest.ServerCertificateValidationCallback = (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
		try
		{
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				if (responseHandler != null)
				{
					return responseHandler(httpWebResponse);
				}
				return default(T);
			}
			throw new Exception(SR.T("Неожиданный (но успешный) ответ от точки хранения контента."));
		}
		catch (WebException ex)
		{
			if (errorHandler != null)
			{
				return errorHandler(httpWebRequest, ex);
			}
			LogErrorHandler(httpWebRequest, ex);
			throw;
		}
	}

	private void CreateEmptyPostRequest(HttpWebRequest request)
	{
		request.Method = "POST";
		request.ContentLength = 0L;
	}

	private T GetLongRunningCommandResult<T>(HttpWebResponse response)
	{
		using Stream stream = response.GetResponseStream();
		return JsonHelper.DeserializeResponse<T>(stream);
	}

	private void LogErrorHandler(HttpWebRequest request, WebException webException)
	{
		string text = ((webException.Status == WebExceptionStatus.ProtocolError) ? $"(code={((HttpWebResponse)webException.Response).StatusCode})" : string.Empty);
		string message = $"Request '{request.Method} {request.RequestUri}' failed with status {webException.Status} {text}";
		logger.Error(message, webException);
	}
}
