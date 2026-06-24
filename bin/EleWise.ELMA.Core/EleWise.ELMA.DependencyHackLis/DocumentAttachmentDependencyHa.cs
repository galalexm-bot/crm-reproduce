using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.Documents;

internal sealed class DocumentAttachmentDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[3]
	{
		new ValueTuple<Guid, string>(new Guid("8b8a98f1-b7d6-48c3-986c-5b16200a38a4"), "Document"),
		new ValueTuple<Guid, string>(new Guid("f6a788f6-08c0-41fd-80d7-4f1e5cd6a882"), "CreationAuthor"),
		new ValueTuple<Guid, string>(new Guid("8283ff0b-f34d-4525-ab40-06298333ef6c"), "CreationDate")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.DocumentAttachementTypeUid,
		MetadataConstants.DocumentAttachementTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(DocumentAttachmentWrapper);
}
