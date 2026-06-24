using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Export;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("1f46d53d-51c5-42bd-848d-b493cccc959f")]
internal class __AssemblyInfo
{
	public const string UID_S = "1f46d53d-51c5-42bd-848d-b493cccc959f";

	private static Guid _UID = new Guid("1f46d53d-51c5-42bd-848d-b493cccc959f");

	public static Guid UID => _UID;
}
