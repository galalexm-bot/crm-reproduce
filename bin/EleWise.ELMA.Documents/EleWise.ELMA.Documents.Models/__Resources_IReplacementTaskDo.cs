namespace EleWise.ELMA.Documents.Models;

internal class __Resources_IReplacementTaskDocumentPermission
{
	public static string DisplayName => SR.T("Расширение замещения для задач, содержащих документы");

	public static string P_TaskDocumentsPermissions_DisplayName => SR.T("Права на чтение/просмотр документов");

	public static string P_TaskDocumentsPermissions_Description => SR.T("При отсутствии прав на документ (вложения, контекстные переменные с типом Документ и др.) замещающему будут выданы права на чтение при автоматическом назначении.");

	public static string P_TaskDocumentsManagePermissions_DisplayName => SR.T("Выдача прав доступа к документам");

	public static string P_TaskDocumentsManagePermissions_Description => SR.T("Определяет возможность замещающего выдавать права доступа к документам, связанным с задачей (вложения, контекстные переменные с типом Документ и др.)");
}
