using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Groups;

[Component(Order = 700)]
public sealed class SystemTypesDescriptor : TypesGroupDescriptor
{
	public static readonly Guid UID = TypeConstants.SystemTypesUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Системные");
}
