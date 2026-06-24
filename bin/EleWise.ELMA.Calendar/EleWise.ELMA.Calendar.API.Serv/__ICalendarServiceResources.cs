namespace EleWise.ELMA.Calendar.API.Service.v1;

internal class __ICalendarServiceResources
{
	public static string CalendarServiceDescription => SR.T("Сервис для работы с календарем");

	public static string SetPackagesPeriodDescription => SR.T("Установить значение месяцев для получения данных из сервиса отслеживания изменений");

	public static string SetPackagesPeriodResultDescription => SR.T("True, если данные переданы на сервер");

	public static string SetPackagesPeriodMonthsDescription => SR.T("Количество месяцев до и после текущего для получения данных (0 - только текущий месяц)");

	public static string CalendarItemsDescription => SR.T("Получить список элементов календаря для заданного промежутка времени");

	public static string CalendarItemsResultDescription => SR.T("Список элементов календаря для заданного промежутка времени");

	public static string CalendarItemsStartDateDescription => SR.T("Дата, с которой нужно получить данные");

	public static string CalendarItemsEndDateDescription => SR.T("Дата, до которой нужно получить данные (включительно)");

	public static string ProductionScheduleDescription => SR.T("Получить производственный календарь");

	public static string ProductionScheduleResultDescription => SR.T("Настройки производственного календаря и список дней-исключений");

	public static string AvailableTimeSlotsDescription => SR.T("Получить свободные интервалы времени пользователей для заданных промежутков времени");

	public static string AvailableTimeSlotsResultDescription => SR.T("Свободные интервалы времени пользователей для заданных промежутков времени");

	public static string AvailableTimeSlotsDataDescription => SR.T("Данные, которые необходимы для запроса");
}
