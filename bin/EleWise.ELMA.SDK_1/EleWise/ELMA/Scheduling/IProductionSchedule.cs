// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.IProductionSchedule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Интерфейс вычислителя производственного календаря</summary>
  /// <remarks>
  /// Получать вычислитель необходимо через <seealso cref="P:EleWise.ELMA.API.PublicAPI.ServicesApiRoot.ProductionCalendar">сервис</seealso>
  /// </remarks>
  /// <example>
  /// <code>
  /// // Получить дату, с которой начинается неделя
  /// var startDateOfWeek = productionSchedule.StartDateOfWeek(время);
  /// 
  /// // Получить номер дня недели (ВС-0)
  /// var dayOfWeekNumber = productionSchedule.DayOfWeekNumber(время);
  /// 
  /// // Получить название месяца
  /// var monthName = productionSchedule.DayOfWeekNumber(время);
  /// 
  /// // Проверить, является ли день рабочим
  /// var isWorkingDay = productionSchedule.IsWorkDay(время);
  /// 
  /// // Получить рабочие дни в неделе
  /// var workingWeekDays = productionSchedule.GetWorkingWeekDays();
  /// 
  /// // Получить количество рабочих дней за период
  /// var workingDays = productionSchedule.GetWorkDays(начало периода, конец периода);
  /// 
  /// // Получить время начала рабочего дня
  /// var workingTimeStart = productionSchedule.GetWorkTimeStart(время);
  /// 
  /// // Получить время окончания рабочего дня
  /// var workingTimeEnd = productionSchedule.GetWorkTimeEnd(время);
  /// 
  /// // Получить ближайший рабочий день
  /// var workingDay = productionSchedule.CheckWorkDay(время);
  /// 
  /// // Получить самое раннее время начала рабочего дня за неделю
  /// var  minWorkingTimeStartByWeek = productionSchedule.GetMinWorkTimeStartByWeek();
  /// 
  /// // Получить самое позднее время окончания рабочего дня за неделю
  /// var maxWorkingTimeEndByWeek = productionSchedule.GetMaxWorkTimeEndByWeek();
  /// 
  /// // Получить продолжительность базового рабочего дня
  /// var baseWorkingDayDuration = productionSchedule.GetWorkTimeInDay();
  /// 
  /// // Получить продолжительность базового рабочего дня
  /// var baseWorkingDayDuration = productionSchedule.GetWorkTimeInDay(время);
  /// 
  /// // Вычисление количества рабочего вермени за период
  /// 
  /// // Получить количество рабочего времени за период в формате TimeSpan, где
  /// // Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)
  /// // Hours, Minutes, Seconds - рабочее время в часах
  /// // Например, за период с ПН по СР при условии что ПН, ВТ, СР - рабочие дни вернется TimeSpan, где
  /// // Days == 1 (это вторник), остальное это рабочее время за ПН + рабочее время за СР
  /// var timeSpan = productionSchedule.EvalWorkTimeSpanDifference(начало периода, конец периода);
  /// 
  /// // Получить количество рабочего времени за период в формате TimeSpan - количество часов рабочего времени в формате TimeSpan
  /// var timeSpanByHours = productionSchedule.EvalWorkTimeDifference(начало периода, конец периода);
  /// 
  /// // Получить количество рабочего времени за период в часах - формат double
  /// var doubleByHours = productionSchedule.EvalWorkTimeHoursDifference(начало периода, конец периода);
  /// 
  /// // Расчет срока
  /// 
  /// // Получить срок от интервала - формата TimeSpan
  /// var deadlineByTimeSpan = productionSchedule.EvalTargetTime(время начала, интервал времени);
  /// 
  /// // Получить срок от интервала в часах формат - double
  /// var deadlineByHours = productionSchedule.EvalTargetTime(время начала, интервал времени в часах);
  /// 
  /// // Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)
  /// var deadlineByDays = productionSchedule.AddDays(время начала, интервал времени в днях)
  /// </code>
  /// </example>
  public interface IProductionSchedule
  {
    /// <summary>Получить дату начала недели от временной точки</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Дата начала недели для временной точки</returns>
    DateTime StartDateOfWeek(DateTime runtimeDateTime);

    /// <summary>Получить номер дня недели от временной точки</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Номер дня недели для временной точки (номер начинается с 0)</returns>
    int DayOfWeekNumber(DateTime runtimeDateTime);

    /// <summary>Получить название месяца от временной точки</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Наименование месяца для временной точки</returns>
    string MonthName(DateTime runtimeDateTime);

    /// <summary>Временная точка - рабочий день</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Временная точка - рабочий день</returns>
    bool IsWorkDay(DateTime runtimeDateTime);

    /// <summary>Временная точка - рабочий день</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <param name="needTransformToClientTimezone">Необходимо ли приводить указанную дату к клиентскому часовому поясу, либо указанное дата/время уже в клиентском времени</param>
    /// <returns>Временная точка - рабочий день</returns>
    bool IsWorkDay(DateTime runtimeDateTime, bool needTransformToClientTimezone);

    /// <summary>Получить рабочие дни недели</summary>
    /// <returns></returns>
    IEnumerable<DayOfWeek> GetWorkingWeekDays();

    /// <summary>Получить количество рабочих дней за период</summary>
    /// <param name="startRuntimeDateTime">Локальное время начала периода</param>
    /// <param name="endRuntimeDateTime">Локальное время конца периода</param>
    /// <returns>Количество рабочих дней за период</returns>
    int GetWorkDays(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

    /// <summary>Получить начало рабочего времени для временной точки</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Начало рабочего времени для временной точки, если выходной день - то начало рабочего времени и окончание рабочего времени = 0</returns>
    TimeSpan GetWorkTimeStart(DateTime runtimeDateTime);

    /// <summary>
    /// Получить окончание рабочего времени для временной точки
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Конец рабочего времени для временной точки, если выходной день - то начало рабочего времени и окончание рабочего времени = 0</returns>
    TimeSpan GetWorkTimeEnd(DateTime runtimeDateTime);

    /// <summary>Получить ближайший рабочий день</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>
    /// Значение относительно производственного календаря для временной точки,
    /// если рабочий день - возвращает то же время, иначе ближайший рабочий день с учетом времени
    /// </returns>
    DateTime CheckWorkDay(DateTime runtimeDateTime);

    /// <summary>Получить ближайшее следующее рабочее время</summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>
    /// Значение относительно производственного календаря для временной точки,
    /// если рабочее время (не учитывая интервалы внутри рабочего дня - только его границы) - возвращает то же время,
    /// иначе начало рабочего времени ближайего рабочего дня
    /// </returns>
    DateTime GetNextWorkTime(DateTime runtimeDateTime);

    /// <summary>
    /// Получить самое раннее время начала рабочего дня за неделю
    /// </summary>
    /// <returns></returns>
    TimeSpan GetMinWorkTimeStartByWeek();

    /// <summary>
    /// Получить самое позднее время окончания рабочего дня за неделю
    /// </summary>
    /// <returns></returns>
    TimeSpan GetMaxWorkTimeEndByWeek();

    /// <summary>Получить продолжительность базового рабочего дня</summary>
    /// <returns>Продолжительность базового рабочего дня</returns>
    TimeSpan GetWorkTimeInDay();

    /// <summary>
    /// Получить продолжительность рабочего дня от временной точки
    /// </summary>
    /// <param name="runtimeDateTime">Локальное время</param>
    /// <returns>Продолжительность рабочего дня для временной точки</returns>
    TimeSpan GetWorkTimeInDay(DateTime runtimeDateTime);

    /// <summary>Получить количество рабочего времени за период</summary>
    /// <param name="startRuntimeDateTime">Локальное время начала периода</param>
    /// <param name="endRuntimeDateTime">Локальное время конца периода</param>
    /// <returns>
    /// Количество рабочего времени в формате TimeSpan, где
    /// Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)
    /// Hours, Minutes, Seconds - рабочее время в часах
    /// </returns>
    TimeSpan EvalWorkTimeSpanDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

    /// <summary>Получить количество рабочего времени за период</summary>
    /// <param name="startRuntimeDateTime">Локальное время начала периода</param>
    /// <param name="endRuntimeDateTime">Локальное время конца периода</param>
    /// <returns>Количество рабочего времени в формате TimeSpan</returns>
    TimeSpan EvalWorkTimeDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

    /// <summary>
    /// Получить количество рабочего времени за период в часах
    /// </summary>
    /// <param name="startRuntimeDateTime">Локальное время начала периода</param>
    /// <param name="endRuntimeDateTime">Локальное время конца периода</param>
    /// <returns>Количество рабочего времени в часах</returns>
    double EvalWorkTimeHoursDifference(DateTime startRuntimeDateTime, DateTime endRuntimeDateTime);

    /// <summary>
    /// Получить количество рабочего времени в часах от начала базового рабочего дня
    /// </summary>
    /// <param name="timeOfDay">Время дня, до которого нужно посчитать количество часов</param>
    /// <returns>Количество рабочих часов</returns>
    double GetBaseWorkTimeStartDifference(TimeSpan timeOfDay);

    /// <summary>
    /// Получить количество рабочего времени в часах до конца базового рабочего дня
    /// </summary>
    /// <param name="timeOfDay">Время дня, от которого нужно посчитать количество часов</param>
    /// <returns>Количество рабочих часов</returns>
    double GetBaseWorkTimeEndDifference(TimeSpan timeOfDay);

    /// <summary>Рассчитать срок от интервала</summary>
    /// <param name="startRuntimeDateTime">Исходное локальное время</param>
    /// <param name="interval">Интервал времени</param>
    /// <returns>Срок</returns>
    DateTime EvalTargetTime(DateTime startRuntimeDateTime, TimeSpan interval);

    /// <summary>Рассчитать срок от интервала в часах</summary>
    /// <param name="startRuntimeDateTime">Исходное локальное время</param>
    /// <param name="intervalHours">Интервал в часах</param>
    /// <returns>Срок</returns>
    DateTime EvalTargetTime(DateTime startRuntimeDateTime, double intervalHours);

    /// <summary>
    /// Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)
    /// </summary>
    /// <param name="startRuntimeDateTime">Исходное локальное время</param>
    /// <param name="addDays">Добавляемое/вычитаемое количество дней</param>
    /// <returns>
    /// Время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне),
    /// вычисляемого при прибавлении количества дней от даты начала периода
    /// </returns>
    DateTime AddDays(DateTime startRuntimeDateTime, int addDays);
  }
}
