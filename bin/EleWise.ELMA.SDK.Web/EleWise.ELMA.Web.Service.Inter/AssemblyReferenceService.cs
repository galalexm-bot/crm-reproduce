using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.ServiceReference;
using EleWise.ELMA.Scripts.ServiceReference.Models;
using EleWise.ELMA.Scripts.ServiceReference.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[Component]
[Uid("{EEF53BF5-FFC7-46E6-8D45-83828EC3D053}")]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
internal sealed class AssemblyReferenceService : IAssemblyReferenceService, IInternalAPIWebService
{
	private const string GuidS = "{EEF53BF5-FFC7-46E6-8D45-83828EC3D053}";

	private static ReferenceDiscoveryService referenceDiscoveryService;

	private static ReferenceDiscoveryService ReferenceDiscoveryService => referenceDiscoveryService ?? (referenceDiscoveryService = Locator.GetServiceNotNull<ReferenceDiscoveryService>());

	public DiscoverServiceReferenceResponse DiscoverServiceReference(DiscoverServiceReferenceRequest request)
	{
		if (Uri.TryCreate(request.Uri, UriKind.Absolute, out var result))
		{
			DiscoveryRequest request2 = new DiscoveryRequest
			{
				Namespace = request.Namespace,
				ProjectName = request.ProjectName,
				Uri = request.Uri,
				Credential = new DiscoveryNetworkCredential(request.UserName, request.Password, request.Domain, request.AuthenticationType)
			};
			ServiceReferenceDiscoverer serviceReferenceDiscover = ReferenceDiscoveryService.GetServiceReferenceDiscover(request2, result);
			DiscoverServiceReferenceResponse discoverServiceReferenceResponse = FormResponse(serviceReferenceDiscover);
			if (!discoverServiceReferenceResponse.NeedAuthenticateUser)
			{
				EleWise.ELMA.Scripts.ServiceReference.Models.ServiceReferenceInfo serviceReferencesInfo = AssemblyReferenceHelper.GetServiceReferencesInfo(serviceReferenceDiscover.Services);
				discoverServiceReferenceResponse.ServiceReferenceInfo = new EleWise.ELMA.Web.Service.Internal.Model.ServiceReferenceInfo
				{
					Name = serviceReferencesInfo.Name,
					MethodNames = serviceReferencesInfo.MethodNames
				};
			}
			return discoverServiceReferenceResponse;
		}
		return null;
	}

	public DiscoverServiceReferenceResponse DiscoverWebReference(DiscoverServiceReferenceRequest request)
	{
		if (Uri.TryCreate(request.Uri, UriKind.Absolute, out var result))
		{
			DiscoveryRequest request2 = new DiscoveryRequest
			{
				Namespace = request.Namespace,
				ProjectName = request.ProjectName,
				Uri = request.Uri,
				Credential = new DiscoveryNetworkCredential(request.UserName, request.Password, request.Domain, request.AuthenticationType)
			};
			WebReferenceDiscoverer webReferenceDiscover = ReferenceDiscoveryService.GetWebReferenceDiscover(request2, result);
			DiscoverServiceReferenceResponse discoverServiceReferenceResponse = FormResponse(webReferenceDiscover);
			if (!discoverServiceReferenceResponse.NeedAuthenticateUser)
			{
				discoverServiceReferenceResponse.ServiceString = AssemblyReferenceHelper.GetServiceString(result);
			}
			return discoverServiceReferenceResponse;
		}
		return null;
	}

	private DiscoverServiceReferenceResponse FormResponse(ServiceReferenceDiscovererBase discoverer)
	{
		DiscoverServiceReferenceResponse discoverServiceReferenceResponse = new DiscoverServiceReferenceResponse();
		if (discoverer == null)
		{
			return discoverServiceReferenceResponse;
		}
		if (discoverer.NeedAuthenticateUser)
		{
			discoverServiceReferenceResponse.NeedAuthenticateUser = true;
			discoverServiceReferenceResponse.AuthenticationType = discoverer.AuthenticationType;
			return discoverServiceReferenceResponse;
		}
		EleWise.ELMA.Web.Service.Internal.Model.ScriptWebReference scriptWebReference2 = (discoverServiceReferenceResponse.WebReference = new EleWise.ELMA.Web.Service.Internal.Model.ScriptWebReference
		{
			Name = discoverer.WebReference.Name,
			Namespace = discoverer.WebReference.ProxyNamespace,
			Items = discoverer.WebReference.Items.Select((EleWise.ELMA.Model.Scripts.ScriptProjectItem i) => new EleWise.ELMA.Web.Service.Internal.Model.ScriptProjectItem
			{
				Include = i.Include,
				FileContent = i.FileContent,
				ItemType = i.ItemType,
				Metadata = i.Metadata.Select((EleWise.ELMA.Model.Scripts.MetadataItem a) => new EleWise.ELMA.Web.Service.Internal.Model.MetadataItem
				{
					Name = a.Name,
					Value = a.Value
				}).ToList()
			}).ToList()
		});
		discoverServiceReferenceResponse.CodeFilePath = discoverer.WebReference.GetFullProxyFileName();
		discoverServiceReferenceResponse.ErrorMessage = discoverer.ErrorMessage;
		return discoverServiceReferenceResponse;
	}
}
