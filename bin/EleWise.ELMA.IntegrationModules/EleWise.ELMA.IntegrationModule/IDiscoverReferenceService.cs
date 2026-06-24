using EleWise.ELMA.Scripts.ServiceReference.Models;

namespace EleWise.ELMA.IntegrationModules.Services;

public interface IDiscoverReferenceService
{
	ServiceDiscoveryResponse Discover(DiscoveryRequest request);
}
