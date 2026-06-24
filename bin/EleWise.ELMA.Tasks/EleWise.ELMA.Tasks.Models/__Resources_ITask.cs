namespace EleWise.ELMA.Tasks.Models;

internal class __Resources_ITask
{
	public static string DisplayName => SR.T("Задача");

	public static string Description => SR.T("Задача-поручение, наследует базовый класс задачи");

	public static string P_ControlUserReplaced_DisplayName => SR.T("Контролер (Замещаемый)");

	public static string P_UnderControl_DisplayName => SR.T("На контроле");

	public static string P_UnderControl_Description => SR.T("Признак находится или нет задача на контроле исполнения задачи");

	public static string P_ControlUser_DisplayName => SR.T("Контролер");

	public static string P_ControlUser_Description => SR.T("Пользователь осуществляющий контроль исполнения задачи, если задача находится \"На контроле\"");

	public static string P_ControlType_DisplayName => SR.T("Тип контроля");

	public static string P_ControlType_Description => SR.T("Правило осуществления контроля исполнения задачи");

	public static string P_ControlNotifyMe_DisplayName => SR.T("Оповестить меня");

	public static string P_ControlNotifyMe_Description => SR.T("Уведомлять автора задачи, по завершению, если задача на контроле.");

	public static string P_Period_DisplayName => SR.T("Периодичность");

	public static string P_Period_Description => SR.T("Периодичность постановки задачи на исполнение");

	public static string P_UntilDate_DisplayName => SR.T("Завершить");

	public static string P_InformAboutExpiration_DisplayName => SR.T("Информировать о просрочке");

	public static string P_InformAboutExpiration_Description => SR.T("Информировать или нет Автора задачи о просрочке исполнения задачи");

	public static string P_PauseDate_DisplayName => SR.T("Дата приостановки");

	public static string P_PeriodTemplate_DisplayName => SR.T("Шаблон периодической задачи");

	public static string P_IsTemplate_DisplayName => SR.T("Является шаблоном");

	public static string P_NextTasksCreationCount_DisplayName => SR.T("Количество вперед создаваемых задач");

	public static string P_LastPeriodTaskDate_DisplayName => SR.T("Дата последней созданной периодической задачи");

	public static string P_CurrentControllers_DisplayName => SR.T("Текущие контролеры");

	public static string FP_Periodical_DisplayName => SR.T("Периодическая");

	public static string FP_ControlStatus_DisplayName => SR.T("Статус контроля");

	public static string FP_CurrentControllers_DisplayName => SR.T("На текущем контроле");

	public static string FP_UnderControl_DisplayName => SR.T("На контроле");

	public static string FP_UnderControl_Description => SR.T("Признак находится или нет задача на контроле исполнения задачи");
}
