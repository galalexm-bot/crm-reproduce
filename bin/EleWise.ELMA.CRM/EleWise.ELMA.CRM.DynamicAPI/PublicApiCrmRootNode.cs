using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.CRM.DynamicAPI;

internal class PublicApiCrmRootNode : PublicApiStaticPropertyClassRootNode
{
	public new const string Path = "PublicAPI.CRM";

	public override string Description => SR.T("Работа с клиентами");

	public override string Remarks => SR.T("<see href=\"http://www.elma-bpm.ru/kb/category-11.html\">Ссылка на раздел Базы Знаний посвященный данному модулю</see>");

	public override string Code => SR.T("\r\nДля того, чтобы узнать более подробную информацию о работе с объектами модуля, вы можете пройти по следующим ссылкам:<br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contractor\">Контрагент</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contact\">Контакт</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Sale\">Сделка</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Relationship\">Взаимотношение</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Lead\">Возможность</see><br />\r\n<see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Inpayment\">Поступление</see>\r\n");

	public PublicApiCrmRootNode()
		: base("CRMApiRoot", "CRM")
	{
	}
}
