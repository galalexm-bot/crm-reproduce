using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Mobile;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("7beb66c7-9524-48ec-bcaf-b734b0ed9128")]
internal class __AssemblyInfo
{
	public const string UID_S = "7beb66c7-9524-48ec-bcaf-b734b0ed9128";

	private static Guid _UID = new Guid("7beb66c7-9524-48ec-bcaf-b734b0ed9128");

	public static Guid UID => _UID;
}
