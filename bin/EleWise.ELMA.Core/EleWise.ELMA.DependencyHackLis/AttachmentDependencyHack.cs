using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.Documents;

internal sealed class AttachmentDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[3]
	{
		new ValueTuple<Guid, string>(new Guid("53c0cf38-a6a8-46a4-a141-6c7c698508ed"), "File"),
		new ValueTuple<Guid, string>(new Guid("d84dcc81-1fa4-4924-96d5-ba66353ce443"), "CreationAuthor"),
		new ValueTuple<Guid, string>(new Guid("b8b7e2b1-67b4-492a-8023-7f2bf71c5523"), "CreationDate")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.AttachmentMetadataTypeUid,
		MetadataConstants.AttachmentMetadataTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(AttachmentWrapper);
}
