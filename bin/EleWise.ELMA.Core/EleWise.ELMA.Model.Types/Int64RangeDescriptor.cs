using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Model.Types;

public class Int64RangeDescriptor : RangeTypeDescriptor<Int64Range, long, Int64Settings>
{
	public static readonly Guid UID = TypeConstants.Int64RangeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Целое число (Диапазон)");

	public Int64RangeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected override object GetFromValue(Int64Range value)
	{
		return value.From;
	}

	protected override object GetToValue(Int64Range value)
	{
		return value.To;
	}
}
