using System;
using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class CatalogEditTaskInfo : CatalogTaskInfo
{
	public CatalogItemModel CatalogInfo { get; set; }

	public List<Guid> CancelConnectorUid { get; set; }

	public bool ValidateContext { get; set; }

	public CatalogEditTaskInfo()
	{
		CancelConnectorUid = new List<Guid>();
	}
}
