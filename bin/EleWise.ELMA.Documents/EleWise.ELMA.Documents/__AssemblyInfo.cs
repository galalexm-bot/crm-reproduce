using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("0dc0e270-8283-43cd-9f97-1acac6015a83")]
internal class __AssemblyInfo
{
	public const string UID_S = "0dc0e270-8283-43cd-9f97-1acac6015a83";

	private static Guid _UID = new Guid("0dc0e270-8283-43cd-9f97-1acac6015a83");

	public static Guid UID => _UID;
}
