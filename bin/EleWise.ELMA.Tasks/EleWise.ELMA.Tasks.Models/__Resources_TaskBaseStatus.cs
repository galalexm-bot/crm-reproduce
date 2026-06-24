namespace EleWise.ELMA.Tasks.Models;

internal class __Resources_TaskBaseStatus
{
	public static string DisplayName => SR.T("Статус задачи");

	public static string Description => SR.T("Статусы задачи, присваемые автоматически (Новая, Прочитано и т.п.), либо в результате пользовтелтьских действий над задачей (Прочитано, Выполнено и т.д.)");

	public static string P_NewOrder_DisplayName => SR.T("Новая");

	public static string P_Complete_DisplayName => SR.T("Выполнено");

	public static string P_Incomplete_DisplayName => SR.T("Невозможно выполнить");

	public static string P_InProgress_DisplayName => SR.T("Выполняется");

	public static string P_WasClosed_DisplayName => SR.T("Закрыто");

	public static string P_Read_DisplayName => SR.T("Прочитана");

	public static string P_Prepared_DisplayName => SR.T("Подготовлено");

	public static string P_CompleteControlled_DisplayName => SR.T("Выполнено и проконтролировано");

	public static string P_IncompleteControlled_DisplayName => SR.T("Невозможно выполнить и проконтролировано");

	public static string P_OnApproval_DisplayName => SR.T("На предварительном согласовании");

	public static string P_RefuseApproval_DisplayName => SR.T("Отказано в предварительном согласовании");

	public static string P_OnApprovalExecutor_DisplayName => SR.T("На согласовании");

	public static string P_RefuseApprovalExecutor_DisplayName => SR.T("Отказано в согласовании");

	public static string P_NoComplete_DisplayName => SR.T("Не выполнено");

	public static string P_CompleteNeedControl_DisplayName => SR.T("Выполнено, нужен контроль");

	public static string P_IncompleteNeedControl_DisplayName => SR.T("Невозможно выполнить, нужен контроль");
}
