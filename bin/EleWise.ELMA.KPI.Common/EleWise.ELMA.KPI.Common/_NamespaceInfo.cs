using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Common;

[MetadataType(typeof(NamespaceMetadata))]
[Uid("380be7ef-f76e-4941-8eba-0831be2ff8c4")]
internal class _NamespaceInfo : NamespaceInfo
{
	public const string UID_S = "380be7ef-f76e-4941-8eba-0831be2ff8c4";

	private static Guid _UID = new Guid("380be7ef-f76e-4941-8eba-0831be2ff8c4");

	public static Guid UID => _UID;

	public override string DisplayName => SR.T("Общие классы модулей KPI и Workflow");
}
