using System;
using System.IO;
using System.Net;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.RPA.DTO.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.RPA.Services;

[Service]
internal class RPAClientService : IRPAClientService
{
	private RPAClientSettingsModule settingsModule;

	private readonly IRPASerializationService serializationService;

	private RPAClientSettingsModule SettingsModule
	{
		get
		{
			if (settingsModule == null)
			{
				settingsModule = Locator.GetServiceNotNull<RPAClientSettingsModule>();
			}
			return settingsModule;
		}
	}

	private RPAClientSettings RPAClientSettings => SettingsModule.Settings;

	public RPAClientService(IRPASerializationService serializationService)
	{
		this.serializationService = serializationService;
	}

	private WebRequest CreateRequest(Uri baseUri, string relativeRequestUri, string method, string contentType)
	{
		WebRequest webRequest = WebRequest.Create(new Uri(baseUri, relativeRequestUri));
		if (!string.IsNullOrEmpty(method))
		{
			webRequest.Method = method;
		}
		if (!string.IsNullOrEmpty(contentType))
		{
			webRequest.ContentType = contentType;
		}
		return webRequest;
	}

	private void SendRequestData(WebRequest request, byte[] data)
	{
		Contract.ArgumentNotNull(request, "request");
		if (data != null)
		{
			using (Stream stream = request.GetRequestStream())
			{
				stream.Write(data, 0, data.Length);
			}
		}
	}

	private T GetResponse<T>(WebRequest request) where T : class
	{
		string json = "";
		WebResponse response = request.GetResponse();
		if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
		{
			using Stream stream = response.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream);
			json = streamReader.ReadToEnd();
		}
		response.Close();
		return serializationService.Deserialize<T>(json);
	}

	private TResult ExecuteRequest<TSource, TResult>(Uri baseUri, string relativeUrl, TSource requestBodyDTO) where TSource : class where TResult : class
	{
		if (baseUri == null)
		{
			throw new ArgumentNullException(SR.T("Не указан адрес сервера RPA"), (Exception)null);
		}
		byte[] bytes = Encoding.UTF8.GetBytes(serializationService.Serialize(requestBodyDTO));
		WebRequest request = CreateRequest(baseUri, relativeUrl, "POST", "application/json");
		SendRequestData(request, bytes);
		return GetResponse<TResult>(request);
	}

	public ActualProcessesResponseDTO GetActualProcesses(Guid authToken)
	{
		return ExecuteRequest<ActualProcessesRequestBodyDTO, ActualProcessesResponseDTO>(RPAClientSettings.ServerAddress, "v1/repository/actual", new ActualProcessesRequestBodyDTO
		{
			AuthToken = authToken
		});
	}

	public ProcessContextResponseDTO GetContextVariables(Guid processVersionUid, Guid authToken)
	{
		return ExecuteRequest<ProcessContextRequestBodyDTO, ProcessContextResponseDTO>(RPAClientSettings.ServerAddress, "v1/repository/context", new ProcessContextRequestBodyDTO
		{
			AuthToken = authToken,
			ProcessVersionUid = processVersionUid
		});
	}

	public FindProcessResponseDTO FindProcess(Guid processToken, Guid authToken, int version = 0)
	{
		return ExecuteRequest<FindProcessRequestBodyDTO, FindProcessResponseDTO>(RPAClientSettings.ServerAddress, "v1/repository/find", new FindProcessRequestBodyDTO
		{
			AuthToken = authToken,
			ProcessToken = processToken,
			Version = version
		});
	}

	public TaskCreateResponseDTO CreateTask(Guid authToken, TaskDTO task)
	{
		return ExecuteRequest<TaskCreateRequestBodyDTO, TaskCreateResponseDTO>(RPAClientSettings.ServerAddress, "v1/orchestra/task/create", new TaskCreateRequestBodyDTO
		{
			AuthToken = authToken,
			Task = task
		});
	}

	public TaskStatusResponseDTO GetTaskStatus(Guid authToken, int taskId)
	{
		return ExecuteRequest<TaskStatusRequestBodyDTO, TaskStatusResponseDTO>(RPAClientSettings.ServerAddress, "v1/orchestra/task/status", new TaskStatusRequestBodyDTO
		{
			AuthToken = authToken,
			Id = taskId
		});
	}

	public RegistrationResponseDTO Register(RegistrationRequestBodyDTO registrationDTO)
	{
		string text = "";
		try
		{
			return ExecuteRequest<RegistrationRequestBodyDTO, RegistrationResponseDTO>(RPAClientSettings.ServerAddress, "v1/orchestra/system/registration", registrationDTO);
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex);
			text = ex.Message;
		}
		return new RegistrationResponseDTO
		{
			Status = 0,
			ErrorMessage = text
		};
	}

	public RegistrationStatusResponseDTO GetRegistrationStatus(RegistrationStatusRequestBodyDTO body)
	{
		string text = "";
		try
		{
			return ExecuteRequest<RegistrationStatusRequestBodyDTO, RegistrationStatusResponseDTO>(RPAClientSettings.ServerAddress, "v1/orchestra/system/status", body);
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex);
			text = ex.Message;
		}
		return new RegistrationStatusResponseDTO
		{
			Status = 0,
			ErrorMessage = text
		};
	}
}
