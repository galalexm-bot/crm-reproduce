using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Scheduling;

[PublicApiMember("ProductionCalendarServicesApi", "SR.M('Сервис для работы с производственным календарём')", "SR.M('\r\n    /// <code>\r\n    /// // Сервис производственного календаря позволяет непосредственно, или через вычислитель календаря: \r\n    /// // - Получить дату начала недели от временной точки\r\n    /// // - Получить название месяца от временной точки\r\n    /// // - Проверить на рабочий день\r\n    /// // - Получить рабочие дни недели\r\n    /// // - Получить количество рабочих дней за период\r\n    /// // - Получить начало рабочего времени для временной точки\r\n    /// // - Получить окончание рабочего времени для временной точки\r\n    /// // - Получить продолжительность базового рабочего дня\r\n    /// // - Получить продолжительность рабочего дня от временной точки\r\n    /// // - Получить количество рабочего времени за период\r\n    /// // - Рассчитать срок\r\n    /// \r\n    /// // Запиcать сервис в переменную, для удобства работы с ним\r\n    /// var service = PublicAPI.Services.ProductionCalendar;\r\n    /// \r\n    /// // Получить вычислитель агрегированного производственного календаря\r\n    /// // Для этого необходимо передать в метод максимальное количество информации для агрегации\r\n    /// // Пользователь системы - при агрегации данных производственного календаря будут учтены индивидуальные настройки производственного календаря пользователя, его отгулы, отпуск и прочая информация\r\n    /// // Сущность - при агрегации данных производственного календаря будут учтены данные календаря соответствующие сущности, например календарь процесса, проекта и так далее\r\n    /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра\r\n    /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность);\r\n    /// // или\r\n    /// var productionSchedule = service.GetProductionSchedule(пользователь, сущность, настройки часового пояса);\r\n    ///\r\n    /// // Получить вычислитель глоабльного производственного календаря\r\n    /// // Настройки часового пояса - по умолчанию вычислитель агрегированного производственного календаря будет настроен в серверном часовом поясе, при необходимости использовать метод, принимающий настройки часового пояса в качестве параметра\r\n    /// var productionSchedule = service.GetGlobalProductionSchedule();\r\n    /// // или\r\n    /// var productionSchedule = service.GetGlobalProductionSchedule(настройки часового пояса);\r\n    /// \r\n    /// // При использовании часовых поясов важно помнить о том, что передаваемое в методы вычислителя время должно быть в часовом поясе среды выполнения\r\n    /// // В 99% для выполнения этого условия ничего делать не нужно, но если по какой-либо причине условия не выполнилось - использовать методы трансформации времени статического класса EleWise.ELMA.TZ\r\n    /// \r\n    /// // Все методы расчета сервиса работают с учетом глобального производственного календаря в серверном часовом поясе и допустимы к использованию только для систем, работающих в одном часовом поясе, с единственным, глоабльным, производственным календарем\r\n    /// // Рекомендуется использовать методы вычислителя полученного посредством методов описанных выше\r\n    /// \r\n    /// // Проверить, является ли день рабочим\r\n    /// var isWorkingDay = service.IsWorkDay(время);\r\n    /// \r\n    /// // Получить срок от интервала - формата TimeSpan\r\n    /// var deadlineByTimeSpan = service.EvalTargetTime(время начала, интервал времени);\r\n    /// \r\n    /// // Получить срок от интервала в часах формат - double\r\n    /// var deadlineByHours = service.EvalTargetTime(время начала, интервал времени в часах);\r\n    /// \r\n    /// // Добавить количество дней и получить время начала рабочего дня (срока) с учетом календаря (с учетом рабочих дней, но без учета рабочего времени в рабочем дне)\r\n    /// var deadlineByDays = service.AddDays(время начала, интервал времени в днях)\r\n    ///\r\n    /// // Получить количество рабочего времени за период в формате TimeSpan, где\r\n    /// // Days - количество рабочих дней (не количество рабочих часов переведенное в дни, учитывается рабочий день без учета продолжительности рабочего времени)\r\n    /// // Hours, Minutes, Seconds - рабочее время в часах\r\n    /// // Например, за период с ПН по СР при условии что ПН, ВТ, СР - рабочие дни вернется TimeSpan, где\r\n    /// // Days == 1 (это вторник), остальное это рабочее время за ПН + рабочее время за СР\r\n    /// var timeSpan = service.EvalWorkTimeSpanDifference(начало периода, конец периода);\r\n    /// \r\n    /// // Получить количество рабочего времени за период в формате TimeSpan - количество часов рабочего времени в формате TimeSpan\r\n    /// var timeSpanByHours = service.EvalWorkTimeDifference(начало периода, конец периода);\r\n    /// \r\n    /// // Получить количество рабочего времени за период в часах - формат double\r\n    /// var doubleByHours = service.EvalWorkTimeHoursDifference(начало периода, конец периода);\r\n    ///\r\n    /// // Получить время начала рабочего дня\r\n    /// var workingTimeStart = service.GetWorkTimeStart(время);\r\n    /// \r\n    /// // Получить время окончания рабочего дня\r\n    /// var workingTimeEnd = service.GetWorkTimeEnd(время);\r\n    /// \r\n    /// // Получить продолжительность базового рабочего дня\r\n    /// var baseWorkingDayDuration = service.GetWorkTimeInDay();\r\n    /// \r\n    /// // Получить продолжительность базового рабочего дня\r\n    /// var baseWorkingDayDuration = service.GetWorkTimeInDay(время);\r\n    ///\r\n    /// // Получить продолжительность базового рабочего дня в минутах\r\n    /// var minutesInDay = service.MinutesInDay();\r\n    ///\r\n    /// // Получить продолжительность базового рабочего дня в минутах\r\n    /// var minutesInDay = service.MinutesInDay(время);\r\n    /// </code>')")]
[DeveloperApi(DeveloperApiType.Service)]
public interface IProductionCalendarService
{
	[PublicApiNodeId("ProductionCalendarServicesApi")]
	IProductionSchedule GetProductionSchedule(IUser user, IEntity entity, TZSettings tzSettings);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	IProductionSchedule GetProductionSchedule(IUser user, IEntity entity);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	IProductionSchedule GetGlobalProductionSchedule(TZSettings tzSettings);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	IProductionSchedule GetGlobalProductionSchedule();

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	bool IsWorkDay(DateTime dateTime);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	bool IsWorkDay(DateTime dateTime, bool needTransformToClientTimezone);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	DateTime EvalTargetTime(DateTime startTime, TimeSpan interval);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	DateTime EvalTargetTime(DateTime startTime, double intervalHours);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	DateTime AddDays(DateTime startTime, int addDays);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan EvalWorkTimeSpanDifference(DateTime startTime, DateTime endTime);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan EvalWorkTimeDifference(DateTime startTime, DateTime endTime);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	double EvalWorkTimeHoursDifference(DateTime startTime, DateTime endTime);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan GetWorkTimeStart(DateTime day);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan GetWorkTimeEnd(DateTime day);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan GetWorkTimeInDay();

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	TimeSpan GetWorkTimeInDay(DateTime day);

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	long MinutesInDay();

	[PublicApiNodeId("ProductionCalendarServicesApi")]
	long MinutesInDay(DateTime day);
}
