using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Model.Types;

public class Int32RangeDescriptor : RangeTypeDescriptor<Int32Range, int, Int32Settings>
{
	public static readonly Guid UID = TypeConstants.Int32RangeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Целое число 32 бита (Диапазон)");

	public Int32RangeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected override object GetFromValue(Int32Range value)
	{
		return value.From;
	}

	protected override object GetToValue(Int32Range value)
	{
		return value.To;
	}
}
