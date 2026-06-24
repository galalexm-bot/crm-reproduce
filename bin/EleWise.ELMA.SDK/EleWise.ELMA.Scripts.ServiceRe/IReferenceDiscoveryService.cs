using EleWise.ELMA.Scripts.ServiceReference.Models;

namespace EleWise.ELMA.Scripts.ServiceReference.Services;

public interface IReferenceDiscoveryService
{
	ServiceDiscoveryResponse DiscoverServiceReference(DiscoveryRequest request);

	WebReferenceDiscoveryResponse DiscoverWebReference(DiscoveryRequest request);
}
