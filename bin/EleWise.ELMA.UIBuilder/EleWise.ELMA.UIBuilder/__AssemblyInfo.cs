using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("41EC134B-95A8-4C72-ACD1-2E7B868651AC")]
internal class __AssemblyInfo
{
	public const string UID_S = "41EC134B-95A8-4C72-ACD1-2E7B868651AC";

	private static Guid _UID = new Guid("41EC134B-95A8-4C72-ACD1-2E7B868651AC");

	public static Guid UID => _UID;
}
