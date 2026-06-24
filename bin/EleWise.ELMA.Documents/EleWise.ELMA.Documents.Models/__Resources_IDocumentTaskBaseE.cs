namespace EleWise.ELMA.Documents.Models;

internal class __Resources_IDocumentTaskBaseExtension
{
	public static string DisplayName => SR.T("Расширение базовой задачи в документе");

	public static string FP_InnerDocument_DisplayName => SR.T("Документ");

	public static string FP_InnerDocument_Description => SR.T("Ищет те задачи, в которых каким-нибудь образом участвует указанный документ");

	public static string FP_InnerDocuments_DisplayName => SR.T("Документы для задач по документу");

	public static string FP_InnerDocuments_Description => SR.T("Возвращает только задачи по документу. Без вложений.");
}
