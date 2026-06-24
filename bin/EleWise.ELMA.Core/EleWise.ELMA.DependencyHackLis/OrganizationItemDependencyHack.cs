using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.DependencyHackList.Security;

internal sealed class OrganizationItemDependencyHack : EleWise.ELMA.Common.Models.DependencyHackList
{
	private readonly ValueTuple<Guid, string>[] properties = new ValueTuple<Guid, string>[1]
	{
		new ValueTuple<Guid, string>(new Guid("f8983979-45d6-411f-a505-770f381030a8"), "ParentItem")
	};

	private readonly Guid[] typeUids = (Guid[])(object)new Guid[2]
	{
		MetadataConstants.OrganizationItemTypeUid,
		MetadataConstants.OrganizationItemTypeImplementationUid
	};

	public override Guid[] TypeUids => typeUids;

	public override ValueTuple<Guid, string>[] Properties => properties;

	protected override System.Type RealType => typeof(OrganizationItemWrapper);
}
