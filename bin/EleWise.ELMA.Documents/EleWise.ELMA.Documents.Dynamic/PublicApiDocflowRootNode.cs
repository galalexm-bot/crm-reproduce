using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Documents.DynamicAPI;

public class PublicApiDocflowRootNode : PublicApiStaticPropertyClassRootNode
{
	public new const string Path = "PublicAPI.Docflow";

	public override string Description => SR.T("Документооборот");

	public override string Remarks => SR.T("<see href=\"http://www.elma-bpm.ru/kb/category-24.html\">Ссылка на раздел Базы Знаний посвященный данному модулю</see>");

	public override string Code => SR.T("\r\nДля того, чтобы узнать более подробную информацию о работе с объектами модуля, вы можете пройти по следующим ссылкам:<br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Folder\">Папка</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Document\">Документ</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.DocumentVersion\">Версия документа</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Permissions\">Привилегии</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.DocflowApiRoot.Tasks\">Задачи</see>\r\n");

	public PublicApiDocflowRootNode()
		: base("DocflowApiRoot", "Docflow")
	{
	}
}
