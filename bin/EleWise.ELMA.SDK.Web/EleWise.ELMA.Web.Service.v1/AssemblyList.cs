using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.v1;

[Serializable]
[DataContract(Name = "AssemblyList")]
public class AssemblyList
{
	[DataMember]
	public AssemblyLoadModel[] AssemblyLoadModels { get; set; }
}
