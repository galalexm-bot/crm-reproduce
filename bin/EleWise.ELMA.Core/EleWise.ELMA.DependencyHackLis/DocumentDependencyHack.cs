using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.Documents;

internal sealed class DocumentDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[2]
	{
		new ValueTuple<Guid, string>(new Guid("9c064c49-850b-4b9a-b715-c263b738f5b9"), "CreationDate"),
		new ValueTuple<Guid, string>(new Guid("49c9f655-1404-45c9-86d1-7e523b951f5a"), "CurrentVersion")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.DocumentMetadataTypeUid,
		MetadataConstants.DocumentMetadataTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(DocumentWrapper);
}
