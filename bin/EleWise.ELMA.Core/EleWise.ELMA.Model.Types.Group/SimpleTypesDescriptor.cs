using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Model.Types.Groups;

[Component(Order = 100)]
public sealed class SimpleTypesDescriptor : TypesGroupDescriptor
{
	public static readonly Guid UID = TypeConstants.SimpleTypesUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Простые");

	internal override bool OrderTypesByName => false;
}
