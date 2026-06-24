using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("3ffb315f-4061-4df9-8f3a-1ab8ce9f5a61")]
internal class __AssemblyInfo
{
	public const string UID_S = "3ffb315f-4061-4df9-8f3a-1ab8ce9f5a61";

	private static Guid _UID = new Guid("3ffb315f-4061-4df9-8f3a-1ab8ce9f5a61");

	public static Guid UID => _UID;
}
