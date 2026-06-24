using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[DataContract]
public enum ElmaStoreComponentActivationType
{
	[EnumMember]
	Free,
	[EnumMember]
	Paid,
	[EnumMember]
	Demo,
	[EnumMember]
	CE
}
public static class ElmaStoreComponentActivationTypeDescription
{
	public static Dictionary<ElmaStoreComponentActivationType, string> Names = new Dictionary<ElmaStoreComponentActivationType, string>
	{
		{
			ElmaStoreComponentActivationType.Free,
			SR.T("Бесплатный")
		},
		{
			ElmaStoreComponentActivationType.Paid,
			SR.T("Платный")
		},
		{
			ElmaStoreComponentActivationType.Demo,
			SR.T("Демо")
		},
		{
			ElmaStoreComponentActivationType.CE,
			"CE"
		}
	};
}
