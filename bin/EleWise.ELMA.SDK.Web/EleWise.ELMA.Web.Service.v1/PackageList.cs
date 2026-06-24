using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1;

[Serializable]
[DataContract(Name = "PackageList")]
public class PackageList
{
	[DataMember]
	public List<byte[]> PackageManifests { get; set; }

	public PackageList()
	{
		PackageManifests = new List<byte[]>();
	}
}
