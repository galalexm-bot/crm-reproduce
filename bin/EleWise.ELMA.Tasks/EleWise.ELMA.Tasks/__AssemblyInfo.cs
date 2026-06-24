using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("0ac37901-8600-47a2-a240-3bc69aa75a36")]
internal class __AssemblyInfo
{
	public const string UID_S = "0ac37901-8600-47a2-a240-3bc69aa75a36";

	private static Guid _UID = new Guid("0ac37901-8600-47a2-a240-3bc69aa75a36");

	public static Guid UID => _UID;
}
