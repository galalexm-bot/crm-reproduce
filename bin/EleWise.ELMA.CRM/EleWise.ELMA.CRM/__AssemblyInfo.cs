using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("e90b8c54-840b-4cd7-8cd8-fdb79a5010a7")]
internal class __AssemblyInfo
{
	public const string UID_S = "e90b8c54-840b-4cd7-8cd8-fdb79a5010a7";

	private static Guid _UID = new Guid("e90b8c54-840b-4cd7-8cd8-fdb79a5010a7");

	public static Guid UID => _UID;
}
