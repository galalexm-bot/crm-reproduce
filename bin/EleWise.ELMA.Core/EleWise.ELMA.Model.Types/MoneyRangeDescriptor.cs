using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Model.Types;

public class MoneyRangeDescriptor : RangeTypeDescriptor<MoneyRange, Money, MoneySettings>
{
	public static readonly Guid UID = TypeConstants.MoneyRangeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Деньги (Диапазон)");

	public MoneyRangeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
