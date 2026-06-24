using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FileProvider.Distributed.Web;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("cd244e9e-ac0b-480a-906c-57e3c25d7e7a")]
internal class __AssemblyInfo
{
	public const string UID_S = "cd244e9e-ac0b-480a-906c-57e3c25d7e7a";

	private static Guid uid = new Guid("cd244e9e-ac0b-480a-906c-57e3c25d7e7a");

	public static Guid UID => uid;
}
