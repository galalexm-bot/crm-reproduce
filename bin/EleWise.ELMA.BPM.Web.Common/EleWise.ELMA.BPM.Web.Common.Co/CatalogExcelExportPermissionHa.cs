using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.SDK.Web.ExtensionPoints;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
internal sealed class CatalogExcelExportPermissionHandler : IExcelExportPermissionHandler
{
	private readonly ISecurityService securityService;

	public CatalogExcelExportPermissionHandler(ISecurityService securityService)
	{
		this.securityService = securityService;
	}

	public bool CanExportType(IMetadata metadata)
	{
		if (metadata == null)
		{
			return false;
		}
		ICatalogProfile catalogProfile = ((metadata is EntityMetadata entityMetadata && entityMetadata.Type == EntityMetadataType.InterfaceImplementation) ? CatalogManager.Instance.LoadByCatalog(entityMetadata.ImplementationUid) : CatalogManager.Instance.LoadByCatalog(metadata.Uid));
		if (catalogProfile != null)
		{
			return securityService.HasPermission(EleWise.ELMA.Common.PermissionProvider.CatalogExportPermission, catalogProfile);
		}
		return false;
	}
}
