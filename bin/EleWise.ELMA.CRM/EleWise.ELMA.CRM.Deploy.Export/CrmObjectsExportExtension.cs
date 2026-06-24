using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Deploy.Export;

[Component(Order = 250)]
internal class CrmObjectsExportExtension : IConfigExportExtension
{
	private static readonly Guid saleStageMetadataUid = InterfaceActivator.UID<ISaleStage>(loadImplementation: false);

	public SaleStageManager SaleStageManager { get; set; }

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object>();
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		if (parameters.Parameters[ObjectsExportConsts.ExportExtensionUid] is ObjectsExportSetting objectsParameters && IsSaleStageCatalogSelected(objectsParameters))
		{
			AddColors(parameters);
		}
	}

	private static bool IsSaleStageCatalogSelected(ObjectsExportSetting objectsParameters)
	{
		if (!objectsParameters.SysCatalogs.Contains(saleStageMetadataUid))
		{
			return (from c in objectsParameters.Catalogs
				where c.Value
				select c.Key).Contains(saleStageMetadataUid);
		}
		return true;
	}

	private void AddColors(ExportExtensionParams parameters)
	{
		foreach (ColorBinding allSaleStageColorBinding in SaleStageManager.GetAllSaleStageColorBindings())
		{
			string key = string.Format("{0}_{1}", "SaleStageColor", allSaleStageColorBinding.EntityUid);
			parameters.ServiceData.Add(key, allSaleStageColorBinding.ColorCode);
		}
	}
}
