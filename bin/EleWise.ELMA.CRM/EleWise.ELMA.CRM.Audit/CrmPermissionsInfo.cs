using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.Security.Audit;

namespace EleWise.ELMA.CRM.Audit;

[Serializable]
[XmlRoot("CrmPermissionsInfo")]
public class CrmPermissionsInfo
{
	[XmlArray]
	public IList<HistoryPermissionInfo> OldPermissionInfos { get; set; }

	[XmlArray]
	public IList<HistoryPermissionInfo> NewPermissionInfos { get; set; }

	[XmlArray]
	public long CategoryId { get; set; }
}
