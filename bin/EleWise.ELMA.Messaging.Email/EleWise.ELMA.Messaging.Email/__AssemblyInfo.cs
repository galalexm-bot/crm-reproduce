using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messaging.Email;

[MetadataType(typeof(AssemblyInfoMetadata))]
[Uid("d13e29c4-3419-41fa-b86b-3bf88e7a3b71")]
internal class __AssemblyInfo
{
	public const string UID_S = "d13e29c4-3419-41fa-b86b-3bf88e7a3b71";

	private static Guid _UID = new Guid("d13e29c4-3419-41fa-b86b-3bf88e7a3b71");

	public static Guid UID => _UID;
}
