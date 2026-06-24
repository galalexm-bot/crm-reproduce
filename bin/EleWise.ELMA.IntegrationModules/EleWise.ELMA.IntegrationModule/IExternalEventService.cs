using EleWise.ELMA.Common.Models;

namespace EleWise.ELMA.IntegrationModules.Services;

public interface IExternalEventService
{
	bool ExecuteExternalEvent(string eventUrl);

	bool ExecuteExternalEventPOST(string eventUrl, WebData data);
}
