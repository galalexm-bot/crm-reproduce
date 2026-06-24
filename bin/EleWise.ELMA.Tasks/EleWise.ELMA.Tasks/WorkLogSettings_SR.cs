namespace EleWise.ELMA.Tasks;

internal static class WorkLogSettings_SR
{
	public static string P_WorkLogEnabled => SR.T("Разрешить ведение трудозатрат");

	public static string P_ReportEmptyLineCount => SR.T("Количество задач на день недели");

	public static string P_ReportEmptyLineCount_description => SR.T("Определяет, сколько пустых строк будет по умолчанию выводиться для дня недели на странице подачи трудозатрат.");

	public static string P_DisableOvertime => SR.T("Включить лимиты на трудозатраты");

	public static string P_DisableOvertime_description => SR.T("Запретить подачу трудозатрат при переработке.");

	public static string P_ReportNotificationsEnabled => SR.T("Уведомлять о новых задачах согласования");

	public static string P_ReportNotificationsEnabled_description => SR.T("Если установлено Да, пользователь будет получать сообщение-уведомление, что от него требуется согласовать новые записи трудозатрат. В противном случае узнать о новых задачах согласования можно будет только, вручную зайдя в соответствующий раздел системы и просмотрев список записей.");

	public static string P_ReportNotificationsApprovalEnabled => SR.T("Уведомлять о результатах согласования");

	public static string P_ReportNotificationsApprovalEnabled_description => SR.T("В случае каждой операции согласования, подавшему лист согласования, приходит сообщение с результатами (списком). Если установить в Нет, сообщение приходить не будет – результаты можно будет посмотреть только, вручную зайдя в соответствующий раздел системы и просмотрев список записей.");

	public static string P_ReportNotificationsChangeEnabled => SR.T("Уведомлять о правке трудозатрат");

	public static string P_ReportNotificationsChangeEnabled_description => SR.T("Если установлено Да, согласующий трудозатраты будет получать сообщение с уведомлением и описанием правки записи трудозатрат ее автором.");

	public static string P_ReportUnconfirmComment => SR.T("Обязательно указывать комментарий в случае отказа согласования");

	public static string P_AutoApproveMyWorklog => SR.T("Разрешить автосогласование собственных трудозатрат");

	public static string P_LimitDayReport => SR.T("Ограничить срок подачи трудозатрат задним числом (дни)");

	public static string P_LimitDayHours => SR.T("Ограничить подневное количество трудозатрат (часы)");

	public static string P_GroupTasks => SR.T("Группировка журнала трудозатрат");

	public static string P_GroupTasksType_None => SR.T("Не группировать");

	public static string P_GroupTasksType_Days => SR.T("Группировать по дням");

	public static string P_GroupTasksType_Weeks => SR.T("Группировать по неделям");
}
