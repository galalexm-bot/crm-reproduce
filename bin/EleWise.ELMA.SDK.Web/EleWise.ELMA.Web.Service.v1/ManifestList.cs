using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1;

[Serializable]
[DataContract(Name = "ManifestList")]
public class ManifestList
{
	[DataMember]
	public List<byte[]> Manifests { get; set; }

	public ManifestList()
	{
		Manifests = new List<byte[]>();
	}
}
