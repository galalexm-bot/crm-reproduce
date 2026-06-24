using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("F9EAAABE-1218-4A81-9B15-3C14F8308EA3")]
internal class __AssemblyInfo
{
	public const string UID_S = "F9EAAABE-1218-4A81-9B15-3C14F8308EA3";

	private static Guid _UID = new Guid("F9EAAABE-1218-4A81-9B15-3C14F8308EA3");

	public static Guid UID => _UID;
}
