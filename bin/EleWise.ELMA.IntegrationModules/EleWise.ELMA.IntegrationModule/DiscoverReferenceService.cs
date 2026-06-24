using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Services.Description;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Extensions;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts.ServiceReference;
using EleWise.ELMA.Scripts.ServiceReference.Models;

namespace EleWise.ELMA.IntegrationModules.Services;

[Service]
internal sealed class DiscoverReferenceService : IDiscoverReferenceService
{
	public ServiceDiscoveryResponse Discover(DiscoveryRequest request)
	{
		if (Uri.TryCreate(request.Uri, UriKind.Absolute, out var result))
		{
			ServiceReferenceDiscoverer serviceReferenceDiscoverer = new ServiceReferenceDiscoverer();
			ServiceDiscoveryResponse serviceDiscoveryResponse = new ServiceDiscoveryResponse
			{
				DiscoveryResponse = DiscoverServiceReference(request, serviceReferenceDiscoverer, result)
			};
			if (!serviceDiscoveryResponse.DiscoveryResponse.NeedAuthenticateUser)
			{
				serviceDiscoveryResponse.ServiceReferenceInfo = GetServiceReferencesInfo(serviceReferenceDiscoverer.Services);
			}
			return serviceDiscoveryResponse;
		}
		return null;
	}

	private DiscoveryResponse DiscoverServiceReference(DiscoveryRequest request, ServiceReferenceDiscovererBase discoverer, Uri uri)
	{
		string tempPath = IOExtensions.GetTempPath("WebReferences");
		if (!Directory.Exists(tempPath))
		{
			Directory.CreateDirectory(tempPath);
		}
		discoverer.NamespacePrefix = request.Namespace;
		discoverer.ProjectDir = Path.Combine(tempPath, request.ProjectName);
		if (request.Credential != null && !request.Credential.UserName.IsNullOrEmpty())
		{
			discoverer.Run(uri, request.Credential);
		}
		else
		{
			discoverer.Run(uri);
		}
		if (discoverer.NeedAuthenticateUser)
		{
			return new DiscoveryResponse
			{
				NeedAuthenticateUser = true,
				AuthenticationType = discoverer.AuthenticationType
			};
		}
		discoverer.WebReference.Name = EleWise.ELMA.Scripts.ServiceReference.WebReference.GetReferenceName(discoverer.WebReference.WebReferencesDirectory, discoverer.WebReference.Name);
		try
		{
			WebReferenceHelper.Save(discoverer.WebReference);
		}
		catch (InvalidOperationException)
		{
			return new DiscoveryResponse();
		}
		ScriptWebReference webReference = new ScriptWebReference
		{
			Name = discoverer.WebReference.Name,
			Namespace = discoverer.WebReference.ProxyNamespace,
			Items = discoverer.WebReference.Items.Select((ScriptProjectItem i) => new ScriptProjectItem
			{
				Include = i.Include,
				FileContent = i.FileContent,
				ItemType = i.ItemType,
				Metadata = i.Metadata.Select((MetadataItem a) => new MetadataItem
				{
					Name = a.Name,
					Value = a.Value
				}).ToList()
			}).ToList()
		};
		return new DiscoveryResponse
		{
			WebReference = webReference,
			CodeFilePath = discoverer.WebReference.GetFullProxyFileName(),
			ErrorMessage = discoverer.ErrorMessage
		};
	}

	private ServiceReferenceInfo GetServiceReferencesInfo(IEnumerable<ServiceDescription> contracts)
	{
		ServiceReferenceInfo serviceReferenceInfo = new ServiceReferenceInfo
		{
			MethodNames = new List<string>()
		};
		foreach (ServiceDescription contract in contracts)
		{
			serviceReferenceInfo.Name = contract.Name;
			if (contract.Services.Count > 0)
			{
				foreach (Service service in contract.Services)
				{
					foreach (Port port in service.Ports)
					{
						Binding[] source = contract.Bindings.CastToArrayOrNull<Binding>();
						Binding binding = source.FirstOrDefault((Binding q) => q.Name == port.Binding.Name);
						if (binding == null)
						{
							continue;
						}
						PortType portType = contract.PortTypes.CastToArrayOrNull<PortType>().FirstOrDefault((PortType q) => q.Name == binding.Type.Name);
						if (portType == null)
						{
							continue;
						}
						foreach (Operation operation3 in portType.Operations)
						{
							serviceReferenceInfo.MethodNames.Add(operation3.Name);
						}
					}
					if (string.IsNullOrEmpty(serviceReferenceInfo.Name))
					{
						serviceReferenceInfo.Name = service.Name;
					}
				}
				continue;
			}
			foreach (PortType portType2 in contract.PortTypes)
			{
				foreach (Operation operation4 in portType2.Operations)
				{
					serviceReferenceInfo.MethodNames.Add(operation4.Name);
				}
			}
		}
		return serviceReferenceInfo;
	}
}
