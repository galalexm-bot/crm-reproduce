using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling;

public interface IProductionSchedule
{
	DateTime StartDateOfWeek(DateTime runtimeDateTime);

	int DayOfWeekNumber(DateTime runtimeDateTime);

	string MonthName(DateTime runtimeDateTime);

	bool IsWorkDay(DateTime runtimeDateTime);

	bool IsWorkDay(DateTime runtimeDateTime, bool needTransformToClientTimezone);

	IEnumerable<DayOfWeek> GetWorkingWeekDays();

	int GetWorkDays(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

	TimeSpan GetWorkTimeStart(DateTime runtimeDateTime);

	TimeSpan GetWorkTimeEnd(DateTime runtimeDateTime);

	DateTime CheckWorkDay(DateTime runtimeDateTime);

	DateTime GetNextWorkTime(DateTime runtimeDateTime);

	TimeSpan GetMinWorkTimeStartByWeek();

	TimeSpan GetMaxWorkTimeEndByWeek();

	TimeSpan GetWorkTimeInDay();

	TimeSpan GetWorkTimeInDay(DateTime runtimeDateTime);

	TimeSpan EvalWorkTimeSpanDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

	TimeSpan EvalWorkTimeDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

	double EvalWorkTimeHoursDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

	double GetBaseWorkTimeStartDifference(TimeSpan timeOfDay);

	double GetBaseWorkTimeEndDifference(TimeSpan timeOfDay);

	DateTime EvalTargetTime(DateTime startRuntimeDateTime, TimeSpan interval);

	DateTime EvalTargetTime(DateTime startRuntimeDateTime, double intervalHours);

	DateTime AddDays(DateTime startRuntimeDateTime, int addDays);
}
