namespace EleWise.ELMA.Documents.API.Service.v1;

internal class __IDocumentServiceResources
{
	public static string Description => SR.T("Сервис для работы с документами и их версиями");

	public static string DocumentVersionLockDescription => SR.T("Блокировать версию документа");

	public static string DocumentVersionUnLockDescription => SR.T("Разблокировать версию документа");

	public static string GetCurrentVersionsDescription => SR.T("Получить список текущих версий документа");

	public static string GetCurrentVersionsResultDescription => SR.T("Список версий документа, отмеченных как Текущие");

	public static string CanEditDocumentDescription => SR.T("Можно ли редактировать документ");
}
