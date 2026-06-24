using System;
using System.IO;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Modules;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.IntegrationDevServer.Services;

[Service]
internal sealed class DevServerService : IDevServerService
{
	private static readonly ILogger deployLog = Logger.GetLogger("ElmaAutoDeploy");

	private readonly ISessionProvider sessionProvider;

	private readonly IModuleFileDeployService moduleFileDeployService;

	public DevServerService(ISessionProvider sessionProvider, IModuleFileDeployService moduleFileDeployService)
	{
		this.sessionProvider = sessionProvider;
		this.moduleFileDeployService = moduleFileDeployService;
	}

	public async Task<string> Deploy(byte[] container)
	{
		BinaryFile container2 = BinaryFile.CreateNew().Content(container).Build();
		StringWriter writer = new StringWriter();
		ModuleDeployLogger logger = new ModuleDeployLogger(deployLog, writer);
		try
		{
			await moduleFileDeployService.Deploy(container2, logger);
		}
		catch (Exception exception)
		{
			logger.Log(LogLevel.Error, exception, SR.T("Развертывание приложения завершилось ошибкой"));
		}
		return writer.ToString();
	}
}
