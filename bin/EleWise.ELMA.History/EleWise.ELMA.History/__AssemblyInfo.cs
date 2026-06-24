using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.History;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("19776b2b-1ba8-4776-a57a-c202ac84a7d6")]
[MetadataAccessLevel(MetadataAccessLevel.EleWise)]
internal class __AssemblyInfo
{
	public const string UID_S = "19776b2b-1ba8-4776-a57a-c202ac84a7d6";

	private static Guid _UID = new Guid("19776b2b-1ba8-4776-a57a-c202ac84a7d6");

	public static Guid UID => _UID;
}
