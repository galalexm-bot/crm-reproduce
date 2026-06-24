using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.vCard;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("93d71fe2-ff49-401d-9434-8c7e156c3e43")]
internal class __AssemblyInfo
{
	public const string UID_S = "93d71fe2-ff49-401d-9434-8c7e156c3e43";

	private static Guid _UID = new Guid("93d71fe2-ff49-401d-9434-8c7e156c3e43");

	public static Guid UID => _UID;
}
