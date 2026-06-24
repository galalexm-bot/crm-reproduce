using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.Security;

internal sealed class UserDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[5]
	{
		new ValueTuple<Guid, string>(new Guid("d6eed170-9e90-4917-8df3-ecfa2b686794"), "Photo"),
		new ValueTuple<Guid, string>(new Guid("ddc8866a-4538-4887-9290-bdc9ad5bc939"), "Status"),
		new ValueTuple<Guid, string>(new Guid("8e0ba2c6-880d-4604-af61-c4f71accb066"), "ReplacementUser"),
		new ValueTuple<Guid, string>(new Guid("b12af3bd-e6ef-455d-b155-dbe3467ab5a0"), "OrganizationItems"),
		new ValueTuple<Guid, string>(new Guid("60eccd59-f2b4-4497-9837-c7077b1000a7"), "OrganizationGroups")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.EntityUserTypeUid,
		MetadataConstants.EntityUserTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(UserWrapper);
}
