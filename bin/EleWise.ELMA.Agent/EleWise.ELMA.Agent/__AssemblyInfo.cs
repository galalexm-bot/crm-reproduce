using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Agent;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("431ce8ed-50c2-4392-b316-5e96e25be907")]
internal class __AssemblyInfo
{
	public const string UID_S = "431ce8ed-50c2-4392-b316-5e96e25be907";

	private static Guid _UID = new Guid("431ce8ed-50c2-4392-b316-5e96e25be907");

	public static Guid UID => _UID;
}
