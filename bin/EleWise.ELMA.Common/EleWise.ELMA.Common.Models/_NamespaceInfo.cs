using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("f4e4a78d-45cc-49cc-ac5a-8f51731819c8")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "f4e4a78d-45cc-49cc-ac5a-8f51731819c8";

	private static Guid _UID = new Guid("f4e4a78d-45cc-49cc-ac5a-8f51731819c8");

	public static Guid UID => _UID;

	public override string DisplayName => "";
}
