// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.IProductionCalendarService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Интерфейс сервиса производственного календаря</summary>
  /// <example>
  /// <code>
  /// // Сервис производственного календаря позволяет непосредственно, или через вычислитель календаря:
  /// // - Получить дату начала недели от временной точки
  /// // - Получить название месяца от временной точки
  /// // - Проверить на рабочий день
  /// // - Получить рабочие дни недели
  /// // - Получить количество рабочих дней за период
  /// // - Получить начало рабочего времени для временной точки
  /// // - Получить окончание рабочего времени для временной точки
  /// // - Получить продолжительность базового рабочего дня
  /// // - Получить продолжительность рабочего дня от временной точки
  /// // - Получить количество рабочего времени за период
  /// // - Рассчитать срок
  /// 
  /// // Запиcать сервис в переменную, для удобства работы с ним
  /// var service = PublicAPI.Services.ProductionCalendar;
  /// 
  /// // Получить вычислитель агрегированного производственного календаря
  /// // Для этого необходимо передать в метод максимальное количество информации для агрегации
  /// // Пользователь системы - при агрегации данных производственного календаря будут учтены индивидуальные настройки производственного календаря пользователя, его отгулы, отпуск и прочая информация
  /// // Сущность - при агрегации данных производственного календаря будут учтены данные календаря соответствующие сущности, например календарь процесса, проекта и так далее
  /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра
  /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность);
  /// // или
  /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность, настройки часового пояса);
  /// 
  /// // Получить вычислитель глоабльного производственного календаря
  /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра
  /// var productionSchedule = service.GetGlobalProductionSchedule();
  /// // или
  /// var productionSchedule = service.GetGlobalProductionSchedule(настройки часового пояса);
  /// 
  /// // При использовании часовых поясов важно помнить о том, что передаваемое в методы вычислителя время должно быть в часовом поясе среды выполнения
  /// // В 99% для выполнения этого условия ничего делать не нужно, но если по какой-либо причине условия не выполнилось - использовать методы трансформации времени статического класса EleWise.ELMA.TZ
  /// 
  /// // Все методы расчета сервиса работают с учетом глобального производственного календаря в серверном часовом поясе и допустимы к использованию только для систем, работающих в одном часовом поясе, с единственным, глоабльным, производственным календарем
  /// // Рекомендуется использовать методы вычислителя полученного посредством методов описанных выше
  /// 
  /// // Проверить, является ли день рабочим
  /// var isWorkingDay = service.IsWorkDay(время);
  /// 
  /// // Получить срок от интервала - формата TimeSpan
  /// var deadlineByTimeSpan = service.EvalTargetTime(время начала, интервал времени);
  /// 
  /// // Получить срок от интервала в часах формат - double
  /// var deadlineByHours = service.EvalTargetTime(время начала, интервал времени в часах);
  /// 
  /// // Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)
  /// var deadlineByDays = service.AddDays(время начала, интервал времени в днях)
  /// 
  /// // Получить количество рабочего времени за период в формате TimeSpan, где
  /// // Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)
  /// // Hours, Minutes, Seconds - рабочее время в часах
  /// // Например, за период с ПН по СР при условии что ПН, ВТ, СР - рабочие дни вернется TimeSpan, где
  /// // Days == 1 (это вторник), остальное это рабочее время за ПН + рабочее время за СР
  /// var timeSpan = service.EvalWorkTimeSpanDifference(начало периода, конец периода);
  /// 
  /// // Получить количество рабочего времени за период в формате TimeSpan - количество часов рабочего времени в формате TimeSpan
  /// var timeSpanByHours = service.EvalWorkTimeDifference(начало периода, конец периода);
  /// 
  /// // Получить количество рабочего времени за период в часах - формат double
  /// var doubleByHours = service.EvalWorkTimeHoursDifference(начало периода, конец периода);
  /// 
  /// // Получить время начала рабочего дня
  /// var workingTimeStart = service.GetWorkTimeStart(время);
  /// 
  /// // Получить время окончания рабочего дня
  /// var workingTimeEnd = service.GetWorkTimeEnd(время);
  /// 
  /// // Получить продолжительность базового рабочего дня
  /// var baseWorkingDayDuration = service.GetWorkTimeInDay();
  /// 
  /// // Получить продолжительность базового рабочего дня
  /// var baseWorkingDayDuration = service.GetWorkTimeInDay(время);
  /// 
  /// // Получить продолжительность базового рабочего дня в минутах
  /// var minutesInDay = service.MinutesInDay();
  /// 
  /// // Получить продолжительность базового рабочего дня в минутах
  /// var minutesInDay = service.MinutesInDay(время);
  /// </code>
  /// </example>
  [PublicApiMember("ProductionCalendarServicesApi", "SR.M('Сервис для работы с производственным календарём')", "SR.M('\r\n    /// <code>\r\n    /// // Сервис производственного календаря позволяет непосредственно, или через вычислитель календаря: \r\n    /// // - Получить дату начала недели от временной точки\r\n    /// // - Получить название месяца от временной точки\r\n    /// // - Проверить на рабочий день\r\n    /// // - Получить рабочие дни недели\r\n    /// // - Получить количество рабочих дней за период\r\n    /// // - Получить начало рабочего времени для временной точки\r\n    /// // - Получить окончание рабочего времени для временной точки\r\n    /// // - Получить продолжительность базового рабочего дня\r\n    /// // - Получить продолжительность рабочего дня от временной точки\r\n    /// // - Получить количество рабочего времени за период\r\n    /// // - Рассчитать срок\r\n    /// \r\n    /// // Запиcать сервис в переменную, для удобства работы с ним\r\n    /// var service = PublicAPI.Services.ProductionCalendar;\r\n    /// \r\n    /// // Получить вычислитель агрегированного производственного календаря\r\n    /// // Для этого необходимо передать в метод максимальное количество информации для агрегации\r\n    /// // Пользователь системы - при агрегации данных производственного календаря будут учтены индивидуальные настройки производственного календаря пользователя, его отгулы, отпуск и прочая информация\r\n    /// // Сущность - при агрегации данных производственного календаря будут учтены данные календаря соответствующие сущности, например календарь процесса, проекта и так далее\r\n    /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра\r\n    /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность);\r\n    /// // или\r\n    /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность, настройки часового пояса);\r\n    ///\r\n    /// // Получить вычислитель глоабльного производственного календаря\r\n    /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра\r\n    /// var productionSchedule = service.GetGlobalProductionSchedule();\r\n    /// // или\r\n    /// var productionSchedule = service.GetGlobalProductionSchedule(настройки часового пояса);\r\n    /// \r\n    /// // При использовании часовых поясов важно помнить о том, что передаваемое в методы вычислителя время должно быть в часовом поясе среды выполнения\r\n    /// // В 99% для выполнения этого условия ничего делать не нужно, но если по какой-либо причине условия не выполнилось - использовать методы трансформации времени статического класса EleWise.ELMA.TZ\r\n    /// \r\n    /// // Все методы расчета сервиса работают с учетом глобального производственного календаря в серверном часовом поясе и допустимы к использованию только для систем, работающих в одном часовом поясе, с единственным, глоабльным, производственным календарем\r\n    /// // Рекомендуется использовать методы вычислителя полученного посредством методов описанных выше\r\n    /// \r\n    /// // Проверить, является ли день рабочим\r\n    /// var isWorkingDay = service.IsWorkDay(время);\r\n    /// \r\n    /// // Получить срок от интервала - формата TimeSpan\r\n    /// var deadlineByTimeSpan = service.EvalTargetTime(время начала, интервал времени);\r\n    /// \r\n    /// // Получить срок от интервала в часах формат - double\r\n    /// var deadlineByHours = service.EvalTargetTime(время начала, интервал времени в часах);\r\n    /// \r\n    /// // Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)\r\n    /// var deadlineByDays = service.AddDays(время начала, интервал времени в днях)\r\n    ///\r\n    /// // Получить количество рабочего времени за период в формате TimeSpan, где\r\n    /// // Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)\r\n    /// // Hours, Minutes, Seconds - рабочее время в часах\r\n    /// // Например, за период с ПН по СР при условии что ПН, ВТ, СР - рабочие дни вернется TimeSpan, где\r\n    /// // Days == 1 (это вторник), остальное это рабочее время за ПН + рабочее время за СР\r\n    /// var timeSpan = service.EvalWorkTimeSpanDifference(начало периода, конец периода);\r\n    /// \r\n    /// // Получить количество рабочего времени за период в формате TimeSpan - количество часов рабочего времени в формате TimeSpan\r\n    /// var timeSpanByHours = service.EvalWorkTimeDifference(начало периода, конец периода);\r\n    /// \r\n    /// // Получить количество рабочего времени за период в часах - формат double\r\n    /// var doubleByHours = service.EvalWorkTimeHoursDifference(начало периода, конец периода);\r\n    ///\r\n    /// // Получить время начала рабочего дня\r\n    /// var workingTimeStart = service.GetWorkTimeStart(время);\r\n    /// \r\n    /// // Получить время окончания рабочего дня\r\n    /// var workingTimeEnd = service.GetWorkTimeEnd(время);\r\n    /// \r\n    /// // Получить продолжительность базового рабочего дня\r\n    /// var baseWorkingDayDuration = service.GetWorkTimeInDay();\r\n    /// \r\n    /// // Получить продолжительность базового рабочего дня\r\n    /// var baseWorkingDayDuration = service.GetWorkTimeInDay(время);\r\n    ///\r\n    /// // Получить продолжительность базового рабочего дня в минутах\r\n    /// var minutesInDay = service.MinutesInDay();\r\n    ///\r\n    /// // Получить продолжительность базового рабочего дня в минутах\r\n    /// var minutesInDay = service.MinutesInDay(время);\r\n    /// </code>')")]
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IProductionCalendarService
  {
    /// <summary>
    /// Получить вычислитель агрегированного производственного календаря
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="entity">Сущность</param>
    /// <param name="tzSettings">Часовой пояс</param>
    /// <returns>Вычислитель агрегированного производственного календаря</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    IProductionSchedule GetProductionSchedule(IUser user, IEntity entity, TZSettings tzSettings);

    /// <summary>
    /// Получить вычислитель агрегированного производственного календаря в серверном часовом поясе
    /// </summary>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.ServicesApiRoot.ProductionCalendarServicesApi.GetProductionSchedule(EleWise.ELMA.Security.Models.User,EleWise.ELMA.Documents.Models.Document,EleWise.ELMA.TZSettings)">Основной метод</seealso>
    /// <param name="user">Пользователь</param>
    /// <param name="entity">Сущность</param>
    /// <returns>Вычислитель агрегированного производственного календаря в серверном часовом поясе</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    IProductionSchedule GetProductionSchedule(IUser user, IEntity entity);

    /// <summary>
    /// Получить вычислитель глобального производственного календаря
    /// </summary>
    /// <param name="tzSettings">Часовой пояс</param>
    /// <returns>Вычислитель глобального производственного календаря</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    IProductionSchedule GetGlobalProductionSchedule(TZSettings tzSettings);

    /// <summary>
    /// Получить вычислитель глобального производственного календаря в серверном часовом поясе
    /// </summary>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.ServicesApiRoot.ProductionCalendarServicesApi.GetGlobalProductionSchedule(EleWise.ELMA.TZSettings)">Основной метод</seealso>
    /// <returns>Вычислитель глобального производственного календаря в серверном часовом поясе</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    IProductionSchedule GetGlobalProductionSchedule();

    /// <summary>Временная точка - рабочий день</summary>
    /// <param name="dateTime">Локальное время</param>
    /// <returns>Временная точка - рабочий день</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    bool IsWorkDay(DateTime dateTime);

    /// <summary>Временная точка - рабочий день</summary>
    /// <param name="dateTime">Локальное время</param>
    /// <param name="needTransformToClientTimezone">Необходимо ли приводить указанную дату к клиентскому часовому поясу, либо указанное дата/время уже в клиентском времени</param>
    /// <returns>Временная точка - рабочий день</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    bool IsWorkDay(DateTime dateTime, bool needTransformToClientTimezone);

    /// <summary>Рассчитать срок от интервала</summary>
    /// <param name="startTime">Исходное локальное время</param>
    /// <param name="interval">Интервал времени</param>
    /// <returns>Срок</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    DateTime EvalTargetTime(DateTime startTime, TimeSpan interval);

    /// <summary>Рассчитать срок от интервала в часах</summary>
    /// <param name="startTime">Исходное локальное время</param>
    /// <param name="intervalHours">Интервал в часах</param>
    /// <returns>Срок</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    DateTime EvalTargetTime(DateTime startTime, double intervalHours);

    /// <summary>
    /// Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)
    /// </summary>
    /// <param name="startTime">Исходное локальное время</param>
    /// <param name="addDays">Добавляемое/вычитаемое количество дней</param>
    /// <returns>
    /// Время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне),
    /// вычисляемого при прибавлении количества дней от даты начала периода
    /// </returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    DateTime AddDays(DateTime startTime, int addDays);

    /// <summary>Получить количество рабочего времени за период</summary>
    /// <param name="startTime">Локальное время начала периода</param>
    /// <param name="endTime">Локальное время конца периода</param>
    /// <returns>
    /// Количество рабочего времени в формате TimeSpan, где
    /// Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)
    /// Hours, Minutes, Seconds - рабочее время в часах
    /// </returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan EvalWorkTimeSpanDifference(DateTime startTime, DateTime endTime);

    /// <summary>Получить количество рабочего времени за период</summary>
    /// <param name="startTime">Локальное время начала периода</param>
    /// <param name="endTime">Локальное время конца периода</param>
    /// <returns>Количество рабочего времени в формате TimeSpan</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan EvalWorkTimeDifference(DateTime startTime, DateTime endTime);

    /// <summary>
    /// Получить количество рабочего времени за период в часах
    /// </summary>
    /// <param name="startTime">Локальное время начала периода</param>
    /// <param name="endTime">Локальное время конца периода</param>
    /// <returns>Количество рабочего времени в часах</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    double EvalWorkTimeHoursDifference(DateTime startTime, DateTime endTime);

    /// <summary>Получить начало рабочего времени для временной точки</summary>
    /// <param name="day">Локальное время</param>
    /// <returns>
    /// Начало рабочего времени для временной точки, если выходной день - то начало рабочего времени и окончание рабочего времени = 0
    /// </returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan GetWorkTimeStart(DateTime day);

    /// <summary>
    /// Получить окончание рабочего времени для временной точки
    /// </summary>
    /// <param name="day">Локальное время</param>
    /// <returns>Конец рабочего времени для временной точки, если выходной день - то начало рабочего времени и окончание рабочего времени = 0</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan GetWorkTimeEnd(DateTime day);

    /// <summary>Получить продолжительность базового рабочего дня</summary>
    /// <returns>Продолжительность базового рабочего дня</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan GetWorkTimeInDay();

    /// <summary>
    /// Получение продолжительности рабочего дня от временной точки
    /// </summary>
    /// <param name="day">Локальное время</param>
    /// <returns>Продолжительность базового рабочего дня для временной точки</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    TimeSpan GetWorkTimeInDay(DateTime day);

    /// <summary>
    /// Получить продолжительность базового рабочего дня в минутах
    /// </summary>
    /// <returns>Получить продолжительность базового рабочего дня в минутах</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    long MinutesInDay();

    /// <summary>
    /// Получить продолжительность базового рабочего дня от временной точки в минутах
    /// </summary>
    /// <param name="day">Локальное время</param>
    /// <returns>Продолжительность базового рабочего дня от временной точки в минутах</returns>
    [PublicApiNodeId("ProductionCalendarServicesApi")]
    long MinutesInDay(DateTime day);
  }
}
