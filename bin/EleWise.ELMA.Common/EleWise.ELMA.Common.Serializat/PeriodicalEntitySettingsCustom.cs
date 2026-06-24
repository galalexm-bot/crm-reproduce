using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.PeriodicalEntitySettings;
using Newtonsoft.Json.Converters;

namespace EleWise.ELMA.Common.Serialization;

internal class PeriodicalEntitySettingsCustomCreationConverter : CustomCreationConverter<IPeriodicalEntitySettings>
{
	private readonly Periodicity periodicity;

	private readonly IPeriodicalEntityExtension periodicalEntity;

	public PeriodicalEntitySettingsCustomCreationConverter(Periodicity periodicity)
	{
		this.periodicity = periodicity;
	}

	public PeriodicalEntitySettingsCustomCreationConverter(IPeriodicalEntityExtension periodicalEntity)
	{
		Contract.ArgumentNotNull(periodicalEntity, "periodicalEntity");
		this.periodicalEntity = periodicalEntity;
		periodicity = periodicalEntity.Period;
	}

	public override IPeriodicalEntitySettings Create(Type objectType)
	{
		switch (periodicity)
		{
		case Periodicity.Monthly:
			return new MonthlyPeriodicalEntitySettings(periodicalEntity);
		case Periodicity.Weekly:
			return new WeeklyPeriodicalEntitySettings(periodicalEntity);
		case Periodicity.Daily:
			return new DailyPeriodicalEntitySettings();
		case Periodicity.Yearly:
			return new YearlyPeriodicalEntitySettings();
		case Periodicity.WorkingDays:
		case Periodicity.Quarterly:
			return null;
		default:
			throw new NotImplementedException(SR.T("Неизвестный тип периодичности"));
		}
	}
}
