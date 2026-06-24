using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Content;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("41962339-e99f-47dd-ba78-78e5b26d7433")]
internal class __AssemblyInfo
{
	public const string UID_S = "41962339-e99f-47dd-ba78-78e5b26d7433";

	private static Guid _UID = new Guid("41962339-e99f-47dd-ba78-78e5b26d7433");

	public static Guid UID => _UID;
}
