using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Mobile;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("6b6c426c-5711-4896-8744-57fa4df52cf0")]
internal class __AssemblyInfo
{
	public const string UID_S = "6b6c426c-5711-4896-8744-57fa4df52cf0";

	private static Guid _UID = new Guid("6b6c426c-5711-4896-8744-57fa4df52cf0");

	public static Guid UID => _UID;
}
