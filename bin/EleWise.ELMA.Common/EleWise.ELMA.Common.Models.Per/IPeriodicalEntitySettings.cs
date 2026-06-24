using System;

namespace EleWise.ELMA.Common.Models.PeriodicalEntitySettings;

public interface IPeriodicalEntitySettings
{
	int RepeatEvery { get; set; }

	DateTime GetNextDate(DateTime fromDate, DateTime currentDate);

	DateTime MoveDate(DateTime oldDate, DateTime oldStartDate, DateTime startDate);
}
