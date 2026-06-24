namespace EleWise.ELMA.Documents.Models;

internal class __Resources_DragAndDropSettings
{
	public static string P_DocumentType_DisplayName => SR.T("Тип документа");

	public static string P_UseCustomTemplate_DisplayName => SR.T("Использовать пользовательский шаблон");

	public static string P_TemplateName_DisplayName => SR.T("Пользовательский шаблон");

	public static string P_DoubleNameUseFileName_DisplayName => SR.T("Создавать с названием файла");

	public static string P_DoubleNameUseFileName_Description => SR.T("Для каждого файла будет создан свой документ. Уникальность названий не отслеживается.");

	public static string P_DoubleNameAnotherName_DisplayName => SR.T("Запрашивать название документа");

	public static string P_DoubleNameAnotherName_Description => SR.T("Будет предложено ввести имя документа для каждого неуникального имени документа");

	public static string P_DoubleNameExistDocument_DisplayName => SR.T("Добавить новую версию");

	public static string P_DoubleNameExistDocument_Description => SR.T("Передаваемые файлы будут добавлены в документы как версии. Поиск документов будет вестись по имени документа. Если документ не найден, то для файла создается новый документ.");

	public static string P_DoubleNameAction_DisplayName => SR.T("При дублировании названий документов");
}
