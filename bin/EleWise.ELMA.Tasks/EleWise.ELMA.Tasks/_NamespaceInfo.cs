using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("e2838eb2-ce5e-4981-9881-800b098bc225")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "e2838eb2-ce5e-4981-9881-800b098bc225";

	private static Guid _UID = new Guid("e2838eb2-ce5e-4981-9881-800b098bc225");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Задачи");
}
