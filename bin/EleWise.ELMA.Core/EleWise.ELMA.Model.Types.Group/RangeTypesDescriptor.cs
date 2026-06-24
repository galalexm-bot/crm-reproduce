using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Model.Types.Groups;

public sealed class RangeTypesDescriptor : TypesGroupDescriptor
{
	public static readonly Guid UID = TypeConstants.RangeTypesUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Диапазоны");
}
