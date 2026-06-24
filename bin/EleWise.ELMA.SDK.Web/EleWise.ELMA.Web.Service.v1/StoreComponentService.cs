using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("3B810B40-13E4-4620-A5D2-91327CF75E29")]
public class StoreComponentService : IStoreComponentService, IInternalAPIWebService
{
	public const string GuidS = "3B810B40-13E4-4620-A5D2-91327CF75E29";

	public static Guid Guid = new Guid("3B810B40-13E4-4620-A5D2-91327CF75E29");

	public ManifestList GetInstalledComponentManifests()
	{
		ManifestList manifestList = new ManifestList();
		foreach (ElmaStoreComponentManifest installedComponentManifest in Locator.GetServiceNotNull<IModuleManager>().GetInstalledComponentManifests())
		{
			byte[] item = ClassSerializationHelper.SerializeObjectByXmlToBytes(installedComponentManifest).Zip();
			manifestList.Manifests.Add(item);
		}
		return manifestList;
	}

	public PackageList GetComponentPackages(string componentId)
	{
		PackageList packageList = new PackageList();
		foreach (PackageManifest componentPackage in Locator.GetServiceNotNull<IModuleManager>().GetComponentPackages(componentId))
		{
			byte[] item = ClassSerializationHelper.SerializeObjectByXmlToBytes(componentPackage).Zip();
			packageList.PackageManifests.Add(item);
		}
		return packageList;
	}
}
