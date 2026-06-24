using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Hosting;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.API.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.Agent;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{0D8D2593-93B3-44E8-A2B5-6E270BF3573D}")]
public class UpdateAgentService : IUpdateAgentService, IInternalAPIWebService
{
	private readonly IAgentPathsResolver agentPathsResolver = Locator.GetService<IAgentPathsResolver>();

	private CommonSettingsModule commonSettingsModule;

	public const string GuidS = "{0D8D2593-93B3-44E8-A2B5-6E270BF3573D}";

	public static Guid Guid = new Guid("{0D8D2593-93B3-44E8-A2B5-6E270BF3573D}");

	private CommonSettingsModule CommonSettingsModule => commonSettingsModule ?? (commonSettingsModule = Locator.GetServiceNotNull<CommonSettingsModule>());

	private Version GetCurrentVersion()
	{
		try
		{
			if (agentPathsResolver == null)
			{
				Logger.Log.Warn(SR.T("Невозможно определить версию ELMA Агента"));
				return null;
			}
			string text = HostingEnvironment.MapPath(agentPathsResolver.GetAgentVersionFilePath());
			if (File.Exists(text))
			{
				using XmlReader xmlReader = XmlReader.Create(text);
				if (xmlReader != null && xmlReader.IsStartElement() && xmlReader.Name == "AgentVersion" && xmlReader.MoveToAttribute("Build"))
				{
					if (Version.TryParse(xmlReader.GetAttribute("Build"), out var result))
					{
						return result;
					}
					Logger.Log.Warn(SR.T("AgentVersionInfo.xml: Информация о сборке повреждена"));
					return null;
				}
				Logger.Log.Warn(SR.T("AgentVersionInfo.xml: Файл поврежден"));
			}
			else
			{
				Logger.Log.Warn(SR.T("Файл \"{0}\" не найден", text));
			}
		}
		catch (Exception ex)
		{
			Logger.Log.Warn(SR.T("Ошибка получения текущей версии ELMA Агента: {0}", ex.Message));
			return null;
		}
		return null;
	}

	public UpdateAgentInfo GetUpdateInfoString(string version)
	{
		Version result = null;
		Version.TryParse(version, out result);
		return GetUpdateInfoPrivate(result);
	}

	private UpdateAgentInfo GetUpdateInfoPrivate(Version agentVersion)
	{
		UpdateAgentInfo updateAgentInfo = new UpdateAgentInfo
		{
			Error = true
		};
		if (agentVersion == null)
		{
			Logger.Log.Warn(SR.T("Версия ELMA Агента не указана"));
			return updateAgentInfo;
		}
		Version currentVersion = GetCurrentVersion();
		if (currentVersion == null)
		{
			return updateAgentInfo;
		}
		int major = currentVersion.Major;
		int major2 = agentVersion.Major;
		if (major2 != major)
		{
			Logger.Log.Warn(SR.T("Мажорная версия ELMA Агента не совпадает с текущей версией: {0}", major2));
			return updateAgentInfo;
		}
		int revision = currentVersion.Revision;
		int revision2 = agentVersion.Revision;
		if (revision2 > 0 && revision > 0 && revision > revision2)
		{
			string applicationBaseUrl = CommonSettingsModule.Settings.ApplicationBaseUrl;
			updateAgentInfo.LinkWin = applicationBaseUrl + agentPathsResolver.GetAgentWindowsInstallerPath();
			updateAgentInfo.LinkMac = applicationBaseUrl + agentPathsResolver.GetAgentMacInstallerPath();
			updateAgentInfo.LinkLinux = applicationBaseUrl + agentPathsResolver.GetAgentLinuxInstallerPath();
			updateAgentInfo.Error = false;
			updateAgentInfo.NeedUpdate = true;
		}
		return updateAgentInfo;
	}
}
