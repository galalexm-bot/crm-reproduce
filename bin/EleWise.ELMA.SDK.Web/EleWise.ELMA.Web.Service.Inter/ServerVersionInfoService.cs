using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[Component]
[Uid("{F205D3CC-ACFC-4FAD-B555-426CFD0A0A88}")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class ServerVersionInfoService : IServerVersionInfoService, IInternalAPIWebService
{
	public const string GuidS = "{F205D3CC-ACFC-4FAD-B555-426CFD0A0A88}";

	private static IModuleMetadataLoader moduleMetadataLoader;

	private static IMetadataCacheService metadataCacheService;

	private static IModuleMetadataLoader ModuleMetadataLoader => moduleMetadataLoader ?? (moduleMetadataLoader = Locator.GetServiceNotNull<IModuleMetadataLoader>());

	private static IMetadataCacheService MetadataCacheService => metadataCacheService ?? (metadataCacheService = Locator.GetServiceNotNull<IMetadataCacheService>());

	public ServerVersionInfo GetInfo()
	{
		ModuleVersion defaultModuleVersion = ModuleMetadataLoader.GetDefaultModuleVersion(ModuleMetadataItemHeaderManager.BuilderUiModuleUid);
		return new ServerVersionInfo
		{
			Type = 1,
			Version = SR.M("ELMA") + " v. " + VersionInfo.GetInfoVersion<SR>(),
			UIVersion = defaultModuleVersion.Header.Version.ToString(),
			RuntimeModelHash = MetadataCacheService.GetRuntimeHash()
		};
	}

	public void UpdateSession()
	{
	}
}
