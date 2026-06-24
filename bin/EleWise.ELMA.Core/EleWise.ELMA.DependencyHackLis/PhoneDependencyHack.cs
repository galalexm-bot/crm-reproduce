using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.CRM;

internal sealed class PhoneDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[1]
	{
		new ValueTuple<Guid, string>(new Guid("5ee382ec-597a-4787-918a-3378046b57f6"), "PhoneString")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.PhoneMetadataTypeUid,
		MetadataConstants.PhoneMetadataTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(PhoneWrapper);
}
