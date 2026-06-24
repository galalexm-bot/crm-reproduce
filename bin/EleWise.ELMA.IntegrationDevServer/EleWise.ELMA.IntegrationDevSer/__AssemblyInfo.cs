using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationDevServer;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("fb53aa0f-3f6b-42c6-a8a3-2380b8511d1b")]
internal class __AssemblyInfo
{
	public const string UID_S = "fb53aa0f-3f6b-42c6-a8a3-2380b8511d1b";

	private static Guid _UID = new Guid("fb53aa0f-3f6b-42c6-a8a3-2380b8511d1b");

	public static Guid UID => _UID;
}
