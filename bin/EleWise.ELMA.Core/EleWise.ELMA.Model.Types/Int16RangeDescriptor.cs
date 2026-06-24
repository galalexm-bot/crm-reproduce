using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Model.Types;

public class Int16RangeDescriptor : RangeTypeDescriptor<Int16Range, short, Int16Settings>
{
	public static readonly Guid UID = TypeConstants.Int16RangeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Целое число 16 бит (Диапазон)");

	public Int16RangeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected override object GetFromValue(Int16Range value)
	{
		return value.From;
	}

	protected override object GetToValue(Int16Range value)
	{
		return value.To;
	}
}
