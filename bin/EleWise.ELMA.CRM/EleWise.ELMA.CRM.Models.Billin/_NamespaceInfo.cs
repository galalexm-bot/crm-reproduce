using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("bca8e4b8-b25d-4d64-b0e0-4e5172b7e2cf")]
[AllowCreateModels]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "bca8e4b8-b25d-4d64-b0e0-4e5172b7e2cf";

	private static Guid _UID = new Guid("bca8e4b8-b25d-4d64-b0e0-4e5172b7e2cf");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Банковские реквизиты");
}
