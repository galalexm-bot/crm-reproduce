using System;
using EleWise.ELMA.Common.Extensions;

namespace EleWise.ELMA.Common.Models.PeriodicalEntitySettings;

public sealed class DailyPeriodicalEntitySettings : IPeriodicalEntitySettings
{
	public int RepeatEvery { get; set; } = 1;


	public DateTime GetNextDate(DateTime fromDate, DateTime currentDate)
	{
		ValidateSettings();
		return PeriodicalEntityHelper.GetNextDate(fromDate, currentDate, (DateTime f, DateTime c) => (int)(c - f).TotalDays / RepeatEvery, (DateTime d, int c) => d.AddDays(c * RepeatEvery), moveBeforeHoliday: false);
	}

	public override bool Equals(object obj)
	{
		if (obj is DailyPeriodicalEntitySettings dailyPeriodicalEntitySettings)
		{
			return RepeatEvery == dailyPeriodicalEntitySettings.RepeatEvery;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return -966111503 + RepeatEvery.GetHashCode();
	}

	public DateTime MoveDate(DateTime oldDate, DateTime oldStartDate, DateTime startDate)
	{
		ValidateSettings();
		Contract.Check<ArgumentOutOfRangeException>(oldDate >= oldStartDate, "oldDate >= oldStartDate");
		return startDate.AddDays((int)(oldDate - oldStartDate).TotalDays / RepeatEvery * RepeatEvery);
	}

	private void ValidateSettings()
	{
		Contract.Check<ArgumentOutOfRangeException>(RepeatEvery > 0, "RepeatEvery > 0");
	}
}
