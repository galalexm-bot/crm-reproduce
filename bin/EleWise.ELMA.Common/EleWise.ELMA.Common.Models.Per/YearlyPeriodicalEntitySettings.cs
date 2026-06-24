using System;
using EleWise.ELMA.Common.Extensions;

namespace EleWise.ELMA.Common.Models.PeriodicalEntitySettings;

public sealed class YearlyPeriodicalEntitySettings : IPeriodicalEntitySettings
{
	public int RepeatEvery { get; set; } = 1;


	public DateTime GetNextDate(DateTime fromDate, DateTime currentDate)
	{
		ValidateSettings();
		return PeriodicalEntityHelper.GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (c.Year - f.Year) / RepeatEvery, (DateTime d, int c) => d.AddYears(c * RepeatEvery), moveBeforeHoliday: false);
	}

	public DateTime MoveDate(DateTime oldDate, DateTime oldStartDate, DateTime startDate)
	{
		ValidateSettings();
		Contract.Check<ArgumentOutOfRangeException>(oldDate >= oldStartDate, "oldDate >= oldStartDate");
		return startDate.AddYears((oldDate.Year - oldStartDate.Year) / RepeatEvery * RepeatEvery);
	}

	public override bool Equals(object obj)
	{
		if (obj is YearlyPeriodicalEntitySettings yearlyPeriodicalEntitySettings)
		{
			return RepeatEvery == yearlyPeriodicalEntitySettings.RepeatEvery;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return -966111503 + RepeatEvery.GetHashCode();
	}

	private void ValidateSettings()
	{
		Contract.Check<ArgumentOutOfRangeException>(RepeatEvery > 0, "RepeatEvery > 0");
	}
}
