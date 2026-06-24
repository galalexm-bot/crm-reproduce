using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("6b745c6c-c27b-47ea-b0d6-b00a38d331e3")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "6b745c6c-c27b-47ea-b0d6-b00a38d331e3";

	private static Guid _UID = new Guid("6b745c6c-c27b-47ea-b0d6-b00a38d331e3");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Общий модуль");
}
