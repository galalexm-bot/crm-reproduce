using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.CRM;

internal sealed class EmailDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[1]
	{
		new ValueTuple<Guid, string>(new Guid("eaf5817b-bbcd-47ed-9136-6274de3a73b2"), "EmailString")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.EmailMetadataTypeUid,
		MetadataConstants.EmailMetadataTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(EmailWrapper);
}
