using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("a123630c-ba15-4af1-8c7f-49e6e12e8044")]
internal class __AssemblyInfo
{
	public const string UID_S = "a123630c-ba15-4af1-8c7f-49e6e12e8044";

	private static Guid _UID = new Guid("a123630c-ba15-4af1-8c7f-49e6e12e8044");

	public static Guid UID => _UID;
}
