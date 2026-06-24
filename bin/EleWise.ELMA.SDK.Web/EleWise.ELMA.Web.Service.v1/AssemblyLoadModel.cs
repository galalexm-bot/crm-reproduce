using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1;

[Serializable]
[DataContract(Name = "AssemblyLoadModel")]
public class AssemblyLoadModel
{
	[DataMember]
	public string Hash { get; set; }

	[DataMember]
	public string AssemblyName { get; set; }

	[DataMember]
	public byte[] AssemblyData { get; set; }
}
