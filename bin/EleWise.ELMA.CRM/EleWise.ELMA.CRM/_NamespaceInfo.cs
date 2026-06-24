using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("299b1233-c8c3-43c7-b96d-76a949bee12f")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "299b1233-c8c3-43c7-b96d-76a949bee12f";

	private static Guid _UID = new Guid("299b1233-c8c3-43c7-b96d-76a949bee12f");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Работа с клиентами");
}
