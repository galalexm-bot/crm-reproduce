using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CatalogsPermissionsGrid
{
	public List<CatalogPermissionItem> Data;

	public CatalogsPermissionsGrid()
	{
		Data = new List<CatalogPermissionItem>();
	}
}
