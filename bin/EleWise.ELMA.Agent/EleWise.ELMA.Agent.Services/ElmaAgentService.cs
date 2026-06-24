using System;
using System.IO;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Hubs.Services;

namespace EleWise.ELMA.Agent.Services;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal sealed class ElmaAgentService : IElmaAgentService
{
	private readonly IAgentHubService agentHubService;

	private readonly ILogger logger;

	public ElmaAgentService(IAgentHubService agentHubService, ILogger logger)
	{
		this.agentHubService = agentHubService;
		this.logger = logger;
	}

	public void UpdateAgentsConfig()
	{
		try
		{
			string setting = SR.GetSetting("ELMAAgent.Config");
			string path = (Path.IsPathRooted(setting) ? setting : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, setting));
			string text = string.Empty;
			using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
			{
				using StreamReader streamReader = new StreamReader(stream);
				text = streamReader.ReadToEnd();
			}
			if (!IsValidConfig(text, out var exceptionMessage))
			{
				throw new Exception(exceptionMessage);
			}
			agentHubService.SendAll("UpdateConfig", text);
		}
		catch (Exception ex)
		{
			string message = SR.T("Ошибка обновление настроек ELMA Агентов: {0}", ex.Message);
			logger.Error(message, ex);
			throw new Exception(message, ex);
		}
	}

	private bool IsValidConfig(string xmlString, out string exceptionMessage)
	{
		exceptionMessage = null;
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xmlString);
			return true;
		}
		catch (XmlException exception)
		{
			exceptionMessage = SR.T("Ошибка чтения файла конфигурации. Конфигурационный файл должен быть составлен в формате xml");
			logger.Error(exceptionMessage, exception);
			return false;
		}
		catch (Exception exception2)
		{
			exceptionMessage = SR.T("Ошибка чтения файла конфигурации. Подробную информацию об ошибке можно найти в лог-файле сервера ELMA");
			logger.Error(exceptionMessage, exception2);
			return false;
		}
	}
}
