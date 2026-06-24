namespace EleWise.ELMA.Documents.Models;

internal class __Resources_IDmsObject
{
	public static string DisplayName => SR.T("Объект документооборота");

	public static string Description => SR.T("Базовый класс в документообороте, от которого наследуются папки, документы и пр.\n");

	public static string P_Uid_DisplayName => SR.T("Уникальный идентификатор");

	public static string P_Name_DisplayName => SR.T("Название");

	public static string P_Name_Description => SR.T("Название документа формируется по шаблону");

	public static string P_CreationAuthor_DisplayName => SR.T("Автор");

	public static string P_CreationDate_DisplayName => SR.T("Дата создания");

	public static string P_Folder_DisplayName => SR.T("Родительская папка");

	public static string P_Permissions_DisplayName => SR.T("Привилегии");

	public static string P_SortTypeId_DisplayName => SR.T("Идентификатор типа сортировки");

	public static string P_SortTypeId_Description => SR.T("Применяется для сортировки по типу объекта (документ/папка)");

	public static string P_ChangeAuthor_DisplayName => SR.T("Изменения внес");

	public static string P_ChangeDate_DisplayName => SR.T("Дата изменения");

	public static string P_InheritPermissions_DisplayName => SR.T("Наследовать права родительской папки");

	public static string P_Virtual_DisplayName => SR.T("Виртуальный");

	public static string P_IsArchived_DisplayName => SR.T("В архиве");

	public static string P_ArchiveDate_DisplayName => SR.T("Дата отправки в архив");

	public static string P_ArchiveAuthor_DisplayName => SR.T("Автор отправки в архив");

	public static string P_IsDeleted_DisplayName => SR.T("Признак удаления");

	public static string P_HardDelete_DisplayName => SR.T("Реально удалить сущность из базы");

	public static string P_OldFolder_DisplayName => SR.T("Родительская папка (до отправки в архив)");

	public static string P_DeleteAuthor_DisplayName => SR.T("Автор удаления");

	public static string FP_DocumentType_DisplayName => SR.T("Тип документа");

	public static string FP_DocumentType_Description => SR.T("Фильтрарация по типу документа");

	public static string FP_HierarchicalByFolder_DisplayName => SR.T("Иерархически фильтровать по папке");

	public static string FP_DisableArchive_DisplayName => SR.T("Включить учет архива");

	public static string FP_ReturnOnlyDocuments_DisplayName => SR.T("Вернуть только документы");

	public static string FP_ReturnOnlyDocuments_Description => SR.T("Для фильтрации по типу документа, чтобы возвращались только документы, без папок. По умолчанию false");

	public static string FP_SearchAlsoEncrypted_DisplayName => SR.T("Включить в результат поиска зашифрованные документы");

	public static string FP_Permissions_DisplayName => SR.T("Привилегии");
}
