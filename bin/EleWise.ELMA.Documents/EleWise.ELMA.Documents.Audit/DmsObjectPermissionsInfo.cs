using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using EleWise.ELMA.Security.Audit;

namespace EleWise.ELMA.Documents.Audit;

[Serializable]
[XmlRoot("DmsObjectPermissionsInfo")]
public class DmsObjectPermissionsInfo
{
	[XmlArray]
	public IList<HistoryPermissionInfo> OldPermissionInfos { get; set; }

	[XmlArray]
	public IList<HistoryPermissionInfo> NewPermissionInfos { get; set; }
}
