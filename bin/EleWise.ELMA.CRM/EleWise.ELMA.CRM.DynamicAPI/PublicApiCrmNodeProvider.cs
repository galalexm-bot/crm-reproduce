using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.CRM.DynamicAPI;

[Component(Order = 8)]
internal class PublicApiCrmNodeProvider : IPublicApiNodeProvider
{
	public IEnumerable<IPublicApiNode> CreatePublicApiNodes()
	{
		yield return new PublicApiCrmRootNode();
		PublicApiPropertyClassNode contractorNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "ContractorCRMApi", typeof(IContractor))
		{
			Description = SR.T("Контрагент"),
			Remarks = SR.T("Раздел содержащий методы для работы с контрагентами"),
			Code = SR.T("\r\n<para>\r\nСоздадим пустого контрагента (юридическое лицо)\r\n<code>\r\n<![CDATA[\r\nvar myContractor = PublicAPI.CRM.Contractor.ContractorLegal.Create();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной myContractor, нужно заполнить обязательные поля этой переменной\r\n<code>\r\n<![CDATA[\r\n//имя созданного контрагента\r\nmyContractor.Name = \"ООО Новый Мир\"; \r\n//Ответственный за контрагента, загружаем администратора\r\nmyContractor.Responsible = PublicAPI.Security.User.LoadOrNull(1); \r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к нашему контрагенту\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Contractor.AddComment(myContractor, \"У данного контрагента пока не созданы контакты, но они будут созданы в дальнейшем\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyContractor.Save();\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return contractorNode;
		PublicApiPropertyClassNode contractorLegalNode = new PublicApiPropertyClassNode(contractorNode.Path, "ContractorLegalCRMApi", typeof(IContractorLegal))
		{
			Description = SR.T("Юридическое лицо"),
			Remarks = SR.T("Раздел, содержащий методы для работы с юридическими лицами")
		};
		yield return contractorLegalNode;
		foreach (IPublicApiNode item in PublicApiNodeEntityProvider.Members<IContractorLegal, ContractorManager<IContractorLegal>>(contractorLegalNode.Path))
		{
			yield return item;
		}
		PublicApiPropertyClassNode contractorIndividualNode = new PublicApiPropertyClassNode(contractorNode.Path, "ContractorIndividualCRMApi", typeof(IContractorIndividual))
		{
			Description = SR.T("Физическое лицо"),
			Remarks = SR.T("Раздел, содержащий методы для работы с физическими лицами")
		};
		yield return contractorIndividualNode;
		foreach (IPublicApiNode item2 in PublicApiNodeEntityProvider.Members<IContractorIndividual, ContractorManager<IContractorIndividual>>(contractorIndividualNode.Path))
		{
			yield return item2;
		}
		foreach (IPublicApiNode item3 in PublicApiNodeEntityProvider.Members<IContractor, ContractorManager>(contractorNode.Path))
		{
			yield return item3;
		}
		PublicApiPropertyClassNode contactNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "ContactCRMApi", typeof(IContact))
		{
			Description = SR.T("Контакт"),
			Remarks = SR.T("Раздел содержащий методы для работы с контактами"),
			Code = SR.T("\r\n<para>\r\nСоздадим контакт к контрагенту, который был создан <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contractor\">тут</see>\r\n<code>\r\n<![CDATA[\r\n//Данный метод создаст контакт, привязанный к контрагенту\r\nvar myContact = PublicAPI.CRM.Contact.Create(myContractor);\t\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной myContact, нужно заполнить обязательные поля этой переменной\r\n<code>\r\n<![CDATA[\r\n//Имя контакта\r\nmyContact.Firstname = \"Иван\";\r\n//Фамилия контакта \r\nmyContact.Surname = \"Иванов\";\r\n//Отчество контакта \r\nmyContact.Middlename = \"Иванович\"; \r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к нашему контакту\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Contact.AddComment(myContact, \"myContact - это контакт, созданный для контрагента myContractor\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyContact.Save();\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return contactNode;
		foreach (IPublicApiNode item4 in PublicApiNodeEntityProvider.Members<IContact, ContactManager>(contactNode.Path))
		{
			yield return item4;
		}
		PublicApiPropertyClassNode leadNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "LeadCRMApi", typeof(ILead))
		{
			Description = SR.T("Возможность"),
			Remarks = SR.T("Раздел содержащий методы для работы с возможностями"),
			Code = SR.T("\r\n<para>\r\nСоздадим возможного клиента\r\n<code>\r\n<![CDATA[\r\nvar myLead = PublicAPI.CRM.Lead.Create();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной myLead, нужно заполнить обязательные поля этой переменной\r\n<code>\r\n<![CDATA[\r\n//заполняем имя возможного клиента\r\nmyLead.Name = \"Тестовый возможный клиент\";\r\n//назначем ответственного за возможного клиента (загружаем администратора)\r\nmyLead.Responsible = PublicAPI.Security.User.LoadOrNull(1); \r\n//выставим статус \"Новый\"\r\nmyLead.Status = PublicAPI.Enums.CRM.Enums.LeadStatus.New;\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyLead.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к нашей возможности\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Lead.AddComment(myLead, \"Эту возможность можно конвертировать в контрагента\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nКонвертируем возможного клиента в контрагента.\r\n<code>\r\n<![CDATA[\r\nvar convertLead = PublicAPI.CRM.Lead.ConvertLeadToContractorLegal(myLead);\r\n]]>\r\n</code>\r\nconvertLead - переменная типа Contractor. Теперь с ней можно работать как с <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contractor\">контрагентом</see>\r\n</para>\r\n")
		};
		yield return leadNode;
		foreach (IPublicApiNode item5 in PublicApiNodeEntityProvider.Members<ILead, LeadManager>(leadNode.Path))
		{
			yield return item5;
		}
		PublicApiPropertyClassNode saleNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "SaleCRMApi", typeof(ISale))
		{
			Description = SR.T("Сделка"),
			Remarks = SR.T("Раздел содержащий методы для работы со сделками"),
			Code = SR.T("\r\n<para>\r\nСоздадим сделку для контрагента, который был создан <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contractor\">тут</see>\r\n<code>\r\n<![CDATA[\r\nvar mySale = PublicAPI.CRM.Contractor.CreateSale(myContractor);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной mySale, нужно заполнить обязательные поля этой переменной (кроме поля \"Контрагент\", т.к. оно уже заполнено)\r\n<code>\r\n<![CDATA[\r\n//Имя сделки\r\nmySale.Name = \"Продажа оборудования для ООО Новый Мир\"; \r\n//Ответственный за сделку, загружаем администратора\r\nmySale.Responsible = PublicAPI.Security.User.LoadOrNull(1); \t\t\t\r\n//Загружаем тип сделки по имени и передаем его в сделку\r\nmySale.SaleType = PublicAPI.CRM.Sale.LoadSaleTypeOrNull(\"Тип сделки\"); \r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к нашей сделке\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Sale.AddComment(mySale, \"mySale - сделка, созданная для контаргента myContarctor\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmySale.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПосле <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Inpayment\">создания постпупления денег и добавления его к сделке</see>, изменим статус сделки с \"Активна\" на \"Закрыто(Успех)\"\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Sale.SetPositiveClosedStatus(mySale, \"Сделка прошла успешно, замечаний нет\");\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return saleNode;
		foreach (IPublicApiNode item6 in PublicApiNodeEntityProvider.Members<ISale, SaleManager>(saleNode.Path))
		{
			yield return item6;
		}
		PublicApiPropertyClassNode inpaymentNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "InpaymentCRMApi", typeof(IInpayment))
		{
			Description = SR.T("Поступление"),
			Remarks = SR.T("Раздел содержащий методы работы с поступлениями"),
			Code = SR.T("\r\n<para>\r\nСоздадим поступление денег для сделки, созданной <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Sale\">тут</see>\r\n<code>\r\n<![CDATA[\r\nvar myInpayment = PublicAPI.CRM.Sale.CreateInpayment(mySale);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной mySale, нужно заполнить обязательные поля этой переменной (кроме поля \"Сделка\", т.к. оно уже заполнено)\r\n<code>\r\n<![CDATA[\r\n//Название поступления\r\nmyInpayment.Name = \"Оплата за оборудование\";\r\n//Сумма поступления\r\nmyInpayment.Sum = new Money{Value = 15000};\r\n//Передаем статус поступления 'В плане' \r\nmyInpayment.Status = InpaymentStatus.InPlan;\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyInpayment.Save();\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nУстановим дату поступления денег\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Inpayment.SetInpaymentDate(myInpayment, DateTime.Now);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nИзменим статус поступления денег с \"В плане\" на \"Получено\"\r\n<code>\r\n<![CDATA[\t\t\r\nPublicAPI.CRM.Inpayment.SetReceivedStatus(myInpayment, \"Комментарий при смене статуса поступления\");\r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return inpaymentNode;
		foreach (IPublicApiNode item7 in PublicApiNodeEntityProvider.Members<IInpayment, InpaymentManager>(inpaymentNode.Path))
		{
			yield return item7;
		}
		PublicApiPropertyClassNode relationshipCrmNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "RelationshipCRMApi", typeof(IRelationship))
		{
			Description = SR.T("Взаимоотношения"),
			Remarks = SR.T("Раздел содержащий методы работы с взаимоотношениями"),
			Code = SR.T("\r\n<para>\r\nСоздадим взаимоотношение для контрагента, который был создан <see cref=\"P:EleWise.ELMA.API.PublicAPI.CRMApiRoot.Contractor\">тут</see>. Для примера создадим встречу\r\n<code>\r\n<![CDATA[\r\nvar myMeeting = PublicAPI.CRM.Relationship.CreateMeeting(myContractor);\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nПрежде чем работать с переменной myMeeting, нужно заполнить обязательные поля этой переменной\r\n<code>\r\n<![CDATA[\r\n//Тема встречи\r\nmyMeeting.Theme = \"Встреча с ООО Новый Мир\";\r\n\r\n//Дата начала встречи 15:00 15.02.2014 \r\nmyMeeting.StartDate = new DateTime(2014, 02, 15, 15, 00, 00);\r\n \r\n//Дату окончания встречи можно не ставить, по умолчанию будут добавлено 15 минут к дате начала встречи\r\n//Если же 15 минут вам мало, то заполняем поле 'Дата окончания' вручную\r\n//Дата окончания встречи 16:00 15.02.2014\r\nmyMeeting.EndDate = new DateTime(2014, 02, 15, 16, 00, 00);\r\n\r\n//context.RelationshipUsers - список участников встречи, список типа IRelationshipUser\r\n//в котором представлены следующие поля для заполнения\r\n//User - тип User - пользователь системы\r\n//Status - тип RelationshipStatus - перечисление\r\n//Relationship - взаимоотношение, укажите свое взаимоотношение\r\nmyMeeting.RelationshipUsers = context.RelationshipUsers;\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nДобавим комментарий к нашей встрече\r\n<code>\r\n<![CDATA[\r\nPublicAPI.CRM.Relationship.AddComment(myMeeting, \"myMeeting - созданная встреча для контрагента myContractor\");\r\n]]>\r\n</code>\r\n</para>\r\n\r\n<para>\r\nНе забываем сохранить объект в базу для его корректной работы\r\n<code>\r\n<![CDATA[\r\nmyMeeting.Save(); \r\n]]>\r\n</code>\r\n</para>\r\n")
		};
		yield return relationshipCrmNode;
		foreach (IPublicApiNode item8 in PublicApiNodeEntityProvider.Members<IRelationship, RelationshipManager>(relationshipCrmNode.Path))
		{
			yield return item8;
		}
		PublicApiCodeGenerator.Current.SaveUsesMetadata<IRelationshipMail>();
		PublicApiCodeGenerator.Current.SaveUsesMetadata<IRelationshipCall>();
		PublicApiCodeGenerator.Current.SaveUsesMetadata<IRelationshipMeeting>();
		PublicApiPropertyClassNode objectsCrmNode = new PublicApiPropertyClassNode("PublicAPI.CRM", "ObjectsApi", "Objects")
		{
			Description = SR.T("Объекты модуля работа с клиентами"),
			Remarks = SR.T("Раздел содержащий обьекты модуля работа с клиентами и методы работы с ними")
		};
		yield return objectsCrmNode;
		foreach (IPublicApiNode item9 in PublicApiNodeEntityProvider.BuildObjectsTree(objectsCrmNode.Path, "CRM"))
		{
			yield return item9;
		}
	}
}
