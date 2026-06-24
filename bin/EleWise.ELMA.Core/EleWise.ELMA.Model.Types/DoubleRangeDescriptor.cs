using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Model.Types;

public class DoubleRangeDescriptor : RangeTypeDescriptor<DoubleRange, double, DoubleSettings>
{
	public static readonly Guid UID = TypeConstants.DoubleRangeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Дробное число (Диапазон)");

	public DoubleRangeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected override object GetFromValue(DoubleRange value)
	{
		return value.From;
	}

	protected override object GetToValue(DoubleRange value)
	{
		return value.To;
	}
}
