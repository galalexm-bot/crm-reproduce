using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class ImportOptions
{
	internal class ImportOptions_SR
	{
		public static string KeyFieldName_SR => SR.T("Ключевое поле");

		public static string OverwriteExisting_SR => SR.T("Заменять существующих клиентов");

		public static string AllowAddToDictionary_SR => SR.T("Добавлять в справочники отсутствующие значения");

		public static string ViewTop100_SR => SR.T("Ограничить предпросмотр первыми 100 записями");
	}

	[DisplayName(typeof(ImportOptions_SR), "KeyFieldName_SR")]
	public string KeyFieldName { get; set; }

	[DisplayName(typeof(ImportOptions_SR), "OverwriteExisting_SR")]
	public bool OverwriteExisting { get; set; }

	[DisplayName(typeof(ImportOptions_SR), "AllowAddToDictionary_SR")]
	public bool AllowAddToDictionary { get; set; }

	[DisplayName(typeof(ImportOptions_SR), "ViewTop100_SR")]
	public bool ViewTop100 { get; set; }

	public ImportOptions()
	{
		OverwriteExisting = false;
		AllowAddToDictionary = true;
	}
}
