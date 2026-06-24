using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptWebReference
{
	[DataMember]
	public string Name { get; set; }

	[DataMember]
	public string Namespace { get; set; }

	[DataMember]
	public List<ScriptProjectItem> Items { get; set; }

	public ScriptWebReference()
	{
		Items = new List<ScriptProjectItem>();
	}
}
