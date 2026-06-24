namespace EleWise.ELMA.Tasks.Models;

internal class __Resources_ITaskBasePermission
{
	public static string DisplayName => SR.T("Привилегия для задачи");

	public static string Description => SR.T("Привилегии на просмотр задачи");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Target_DisplayName => SR.T("Target");

	public static string P_Target_Description => SR.T("Задача, к которой относится привилегия");

	public static string P_User_DisplayName => SR.T("User");

	public static string P_TypeRole_DisplayName => SR.T("TypeRole");

	public static string P_TypeRole_Description => SR.T("Роль пользователя, по которому назначено право, например:\r\nАвтор, Ответственный, Информируемый и т.д.\r\n");

	public static string P_AllowChief_DisplayName => SR.T("AllowChief");

	public static string P_UserSecuritySetCacheId_DisplayName => SR.T("UserSecuritySetCacheId");
}
