using System.Runtime.Serialization;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[DataContract]
public enum ManifestComponentType
{
	[EnumMember]
	Module = 0,
	[EnumMember]
	Application = 1,
	[EnumMember]
	Solution = 2,
	[EnumMember]
	MobileApplication = 3,
	[EnumMember]
	ProcessPackage = 4,
	[EnumMember]
	Process = 5,
	[EnumMember]
	ExternalApplication = 6,
	[EnumMember]
	Report = 7,
	[EnumMember]
	Platform = 100
}
