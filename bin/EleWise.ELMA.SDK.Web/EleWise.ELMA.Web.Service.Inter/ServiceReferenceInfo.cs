using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ServiceReferenceInfo
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public List<string> MethodNames { get; set; }

	public ServiceReferenceInfo()
	{
		MethodNames = new List<string>();
	}
}
