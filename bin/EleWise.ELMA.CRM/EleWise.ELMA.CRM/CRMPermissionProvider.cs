using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM;

[Component]
public class CRMPermissionProvider : IPermissionProvider
{
	[Component]
	private sealed class MetadataPublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
	{
		public void PublishExecuted(MetadataPublishedEventArgs e)
		{
			if (!(from metadata in e.DeltaPublishedMetadata.OfType<EntityMetadata>()
				where MetadataLoader.IsBaseOrChildClass<IContractor>(metadata.Uid)
				select metadata.ImplementationUid).Any((Guid metadataUid) => ListContractor.Keys.Contains(metadataUid)))
			{
				ListContractor = null;
			}
		}
	}

	public const string Module = "EleWise.ELMA.CRM.Web";

	public static string ModuleName = SR.M("Работа с клиентами");

	public const string CRMAccessPermissionId = "{46401803-1B46-4E60-8DA0-227FF8CF60F3}";

	public const string ViewContractorPermissionId = "{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}";

	public const string ViewContactPermissionId = "{3626682F-B657-419E-9A8E-392C14ABE455}";

	public const string ViewSalePermissionId = "{AAE16346-B0E6-4949-ACAB-0914C573DE55}";

	public const string ViewInpaymentPermissionId = "{837FF0F3-03A7-4A17-86EA-A72B3AB4886B}";

	public const string ViewLeadPermissionId = "{C660E4B4-03BF-4315-9600-5086E47653B4}";

	public const string EditContractorPermissionId = "{8C932B94-2F9C-488E-A36F-949A11C9741E}";

	public const string EditContactPermissionId = "{ABC752AD-3623-4F14-A47F-121999890D2C}";

	public const string EditSalePermissionId = "{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}";

	public const string EditInpaymentPermissionId = "{E23802D7-F3B5-431E-A72E-7133C3C9343F}";

	public const string CreateInpaymentPermissionId = "{E027FC5A-B0D9-4E73-B396-F740342716A6}";

	public const string DeleteInpaymentPermissionId = "{FFD12AE5-15FF-41B6-AA56-B948AE1C92CD}";

	public const string EditLeadPermissionId = "{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}";

	public const string FiltersFullAccessToAllObjectsPermissionId = "5CC22632-683C-410B-AC7F-26C568D79E38";

	public const string InpaymentsAccessPermissionId = "{EE6119AA-D9B9-4FDA-8EA3-7C3B92B4956E}";

	public const string SalesAccessPermissionId = "{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}";

	public const string MarketingAccessPermissionId = "{5A9420EC-B6AD-4610-982B-4795E850A72E}";

	public const string MarketingFullAccessPermissionId = "{99901266-412E-4DAF-BDD4-8CD62EE1D04F}";

	public static readonly Permission CRMAccessPermission = Permission.Create("{46401803-1B46-4E60-8DA0-227FF8CF60F3}", SR.M("Доступ к модулю \"Работа с клиентами\""), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web");

	public const string CRMFullAccessPermissionId = "{f1a116d4-2d3e-46c5-ba01-7d16c11fcb07}";

	public static readonly Permission CRMFullAccessPermission = Permission.Create("{f1a116d4-2d3e-46c5-ba01-7d16c11fcb07}", SR.M("Полный доступ"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false);

	public static readonly Permission ViewContractorPermission = Permission.Create("{9219C9AB-7E68-47B1-8939-FF6FC4439DA0}", SR.M("Просмотр контрагента"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContractor>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission ViewContactPermission = Permission.Create("{3626682F-B657-419E-9A8E-392C14ABE455}", SR.M("Просмотр контакта"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContact>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission ViewSalePermission = Permission.Create("{AAE16346-B0E6-4949-ACAB-0914C573DE55}", SR.M("Просмотр сделки"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ISale>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission ViewInpaymentPermission = Permission.Create("{837FF0F3-03A7-4A17-86EA-A72B3AB4886B}", SR.M("Просмотр поступления"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.InstanceParentPermission((IInpayment i) => i.Sale, ViewSalePermission, CommonPermissions.View);

	public static readonly Permission ViewLeadPermission = Permission.Create("{C660E4B4-03BF-4315-9600-5086E47653B4}", SR.M("Просмотр возможности"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ILead>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string ViewRelationshipPermissionId = "186D4CC4-6924-4848-93AC-6D8DE389CB08";

	public static readonly Permission ViewRelationshipPermission = Permission.Create("186D4CC4-6924-4848-93AC-6D8DE389CB08", SR.M("Просмотр взаимоотношения"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string ViewMarketingPermissionId = "24217B41-14F2-4F45-A766-8AFA9BB89C70";

	public static readonly Permission ViewMarketingPermission = Permission.Create("24217B41-14F2-4F45-A766-8AFA9BB89C70", SR.M("Просмотр объекта маркетинга"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMContactCreateElementPermissionId = "BCE45C2C-CAE1-41df-8A0A-C54E0409E8B5";

	public static readonly Permission CRMContactCreateElementPermission = Permission.Create("BCE45C2C-CAE1-41df-8A0A-C54E0409E8B5", SR.M("Добавление элементов"), SR.M("Добавление элементов для контактов"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContact>()
		.Dependencies(ViewContactPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMLeadCreateElementPermissionId = "643FE44B-8192-4615-B853-106CD6F09EDE";

	public static readonly Permission CRMLeadCreateElementPermission = Permission.Create("643FE44B-8192-4615-B853-106CD6F09EDE", SR.M("Добавление элементов"), SR.M("Добавление элементов для возможностей"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ILead>()
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewLeadPermission);

	public const string CRMContractorCreateElementPermissionId = "{44ED88D4-A466-4fed-B194-B8288560CB48}";

	public static readonly Permission CRMContractorCreateElementPermission = Permission.Create("{44ED88D4-A466-4fed-B194-B8288560CB48}", SR.M("Добавление элементов"), SR.M("Добавление элементов для контрагентов"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContractor>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewContractorPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMMarketingCreateElementPermissionId = "{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}";

	public static readonly Permission CRMMarketingCreateElementPermission = Permission.Create("{12F5ECDA-DDFF-422F-83DE-BFF4E94ACD1E}", SR.M("Добавление элементов"), SR.M("Добавление элементов для объекта маркетинга"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>(CommonPermissions.View)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewMarketingPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission EditContractorPermission = Permission.Create("{8C932B94-2F9C-488E-A36F-949A11C9741E}", SR.M("Редактирование контрагента"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContractor>(CommonPermissions.Edit)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewContractorPermission, CRMContractorCreateElementPermission);

	public static readonly Permission EditContactPermission = Permission.Create("{ABC752AD-3623-4F14-A47F-121999890D2C}", SR.M("Редактирование контакта"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContact>(CommonPermissions.Edit)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewContactPermission, CRMContactCreateElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission EditSalePermission = Permission.Create("{AF2CEF4B-F639-49B4-BD88-363F20BD5A74}", SR.M("Редактирование сделки"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ISale>(CommonPermissions.Edit)
		.Dependencies(ViewSalePermission)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission EditInpaymentPermission = Permission.Create("{E23802D7-F3B5-431E-A72E-7133C3C9343F}", SR.M("Редактирование поступления"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewInpaymentPermission)
		.InstanceParentPermission((IInpayment i) => i.Sale, EditSalePermission, CommonPermissions.Edit);

	public static readonly Permission CreateInpaymentPermission = Permission.Create("{E027FC5A-B0D9-4E73-B396-F740342716A6}", SR.M("Создание поступления"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewInpaymentPermission)
		.InstanceParentPermission((IInpayment i) => i.Sale, EditSalePermission, CommonPermissions.Create);

	public static readonly Permission DeleteInpaymentPermission = Permission.Create("{FFD12AE5-15FF-41B6-AA56-B948AE1C92CD}", SR.M("Удаление поступления"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewInpaymentPermission)
		.InstanceParentPermission((IInpayment i) => i.Sale, EditSalePermission, CommonPermissions.Delete);

	public static readonly Permission EditLeadPermission = Permission.Create("{AE298CD3-A16A-4B55-ACFC-545E4A0EBD48}", SR.M("Редактирование возможности"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ILead>(CommonPermissions.Edit)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewLeadPermission, CRMLeadCreateElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMRelationshipCreateElementPermissionId = "BA5E9414-B347-4eaa-A019-14D4FA02F5E2";

	public static readonly Permission CRMRelationshipCreateElementPermission = Permission.Create("BA5E9414-B347-4eaa-A019-14D4FA02F5E2", SR.M("Добавление элементов"), SR.M("Добавление элементов для взаимоотношений"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>(CommonPermissions.GrantAccess)
		.Dependencies(ViewRelationshipPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string EditRelationshipPermissionId = "{0B980531-D097-4EC1-8616-56E6AB15770E}";

	public static readonly Permission EditRelationshipPermission = Permission.Create("{0B980531-D097-4EC1-8616-56E6AB15770E}", SR.M("Редактирование взаимоотношения"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>(CommonPermissions.Edit)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewRelationshipPermission, CRMRelationshipCreateElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string ExecuteRelationshipPermissionId = "{FBC84F03-79E8-4E90-A7B6-D0E35C43DD51}";

	public static readonly Permission ExecuteRelationshipPermission = Permission.Create("{FBC84F03-79E8-4E90-A7B6-D0E35C43DD51}", SR.M("Выполнение взаимоотношения"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>()
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewRelationshipPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMMarketingBudgetControlPermissionId = "{E0F57F69-5FBA-428A-93B4-8C80F35879B5}";

	public static readonly Permission CRMMarketingBudgetControlPermission = Permission.Create("{E0F57F69-5FBA-428A-93B4-8C80F35879B5}", SR.M("Управление бюджетом"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>()
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewMarketingPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string EditMarketingPermissionId = "{7D45412B-8491-49B7-B033-93FFE3F394E5}";

	public static readonly Permission EditMarketingPermission = Permission.Create("{7D45412B-8491-49B7-B033-93FFE3F394E5}", SR.M("Редактирование объекта маркетинга"), string.Empty, SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>(CommonPermissions.Edit)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewMarketingPermission, CRMMarketingCreateElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission FiltersFullAccessToAllObjectsPermission = Permission.Create("5CC22632-683C-410B-AC7F-26C568D79E38", "Доступ ко всем фильтрам CRM", "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").AdminPermissions(CRMFullAccessPermission);

	public const string CRMDeletePermissionId = "{dde5667e-bc3f-458c-abb6-2d693f6ffec2}";

	public static readonly Permission CRMDeletePermission = Permission.Create("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}", SR.M("Удаление"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMCreatePermissionId = "{1df995f3-0755-4fe8-a1f8-f62ba3dc12fa}";

	public const string CRMproductCreatePermissionId = "{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}";

	public static readonly Permission CRMproductCreatePermission = Permission.Create("{E0572F14-9BA4-4AE9-B10E-6084D84EAC51}", SR.M("Создание Продукта"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Create)
		.EntityType(InterfaceActivator.TypeOf<IProduct>())
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMContactCreatePermissionId = "{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}";

	public static readonly Permission CRMContactCreatePermission = Permission.Create("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}", SR.M("Создание Контакта"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Create)
		.EntityType(InterfaceActivator.TypeOf<IContact>())
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMLeadCreatePermissionId = "{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}";

	public static readonly Permission CRMLeadCreatePermission = Permission.Create("{C8B3D353-B34D-4463-ABED-9FEF8B6D4B47}", SR.M("Создание Возможности"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Create)
		.EntityType(InterfaceActivator.TypeOf<ILead>())
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMMarketingCreatePermissionId = "{02A3BAE6-0756-4E65-90E1-31FACA090262}";

	public static readonly Permission CRMMarketingCreatePermission = Permission.Create("{02A3BAE6-0756-4E65-90E1-31FACA090262}", SR.M("Создание маркетингового воздействия"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Create)
		.EntityType(InterfaceActivator.TypeOf<IMarketingBase>())
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMSaleCreatePermissionId = "{F7D14102-3444-458C-A0B7-7C067D07BDF8}";

	public static readonly Permission CRMSaleCreatePermission = Permission.Create("{F7D14102-3444-458C-A0B7-7C067D07BDF8}", SR.M("Создание Сделки"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Create)
		.EntityType(InterfaceActivator.TypeOf<ISale>())
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMEditGlobalFiltersId = "42F5B2E6-BCEC-41A1-AA61-92294DF3884D";

	public static readonly Permission CRMEditGlobalFilters = Permission.Create("42F5B2E6-BCEC-41A1-AA61-92294DF3884D", SR.M("Редактирование дерева общих фильтров"), SR.M("Пользователи, обладающие этой привилегией, могут редактировать структуру дерева общих фильтров. Для предоставление полного доступа ко всем фильтрам необходимо дабавить глобальную привилегию \"Доступ ко всем фильтрам\""), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMSaleFunnelReportId = "6D7D9545-BCA8-4D1A-8856-996684F76130";

	public static readonly Permission CRMSaleFunnelReport = Permission.Create("6D7D9545-BCA8-4D1A-8856-996684F76130", SR.M("Доступ к воронкам продаж"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMImportPermissionId = "A4F6E0B9-1C7D-41AE-87CD-46AD010A011F";

	public static readonly Permission CRMImportPermission = Permission.Create("A4F6E0B9-1C7D-41AE-87CD-46AD010A011F", SR.M("Импорт контрагентов, контактов, возможностей"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMDublicateLeadPermissionId = "A9582C07-A47C-457D-B323-2EAA1E5EDE6F";

	public static readonly Permission CRMDublicateLeadPermission = Permission.Create("A9582C07-A47C-457D-B323-2EAA1E5EDE6F", SR.M("Отмечать дубли возможностей"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMDeleteInpaymentPermissionId = "E56A21C6-2981-4BCF-AB5E-9F012811197D";

	public static readonly Permission CRMDeleteInpaymentPermission = Permission.Create("E56A21C6-2981-4BCF-AB5E-9F012811197D", SR.M("Удаление поступлений"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").Base(CommonPermissions.Delete)
		.EntityType(InterfaceActivator.TypeOf<IInpayment>())
		.AdminPermissions(CRMFullAccessPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMExportPermissionId = "60185303-1C94-4DB4-8019-14D0471CFF49";

	public static readonly Permission CRMExportPermission = Permission.Create("60185303-1C94-4DB4-8019-14D0471CFF49", SR.M("Экспорт контрагентов, контактов, возможностей, сделок"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMChangeSaleStatusPermissionId = "C2BB68A5-6342-4BF1-A40A-5F729355ED79";

	public static readonly Permission CRMChangeSaleStatusPermission = Permission.Create("C2BB68A5-6342-4BF1-A40A-5F729355ED79", SR.M("Смена статуса закрытых сделок"), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission InpaymentsAccessPermission = Permission.Create("{EE6119AA-D9B9-4FDA-8EA3-7C3B92B4956E}", SR.M("Доступ к разделу \"Поступления\""), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission SalesAccessPermission = Permission.Create("{96144EE1-1A52-45C4-9AE7-4FF1AD6A03E8}", SR.M("Доступ к разделу \"Сделки\""), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission MarketingAccessPermission = Permission.Create("{5A9420EC-B6AD-4610-982B-4795E850A72E}", SR.M("Доступ к разделу \"Маркетинг\""), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").AdminPermissions(CRMFullAccessPermission);

	public static readonly Permission MarketingFullAccessPermission = Permission.Create("{99901266-412E-4DAF-BDD4-8CD62EE1D04F}", SR.M("Полный доступ к разделу \"Маркетинг\""), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").AdminPermissions(CRMFullAccessPermission);

	public const string CRMSaleCreateElementPermissionId = "7DB77821-D6D3-4dd2-AD1B-798330506ADC";

	public static readonly Permission CRMSaleCreateElementPermission = Permission.Create("7DB77821-D6D3-4dd2-AD1B-798330506ADC", SR.M("Добавление элементов"), SR.M("Добавление элементов для сделок"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ISale>(CommonPermissions.GrantAccess)
		.Dependencies(ViewSalePermission)
		.AdminPermissions(CRMFullAccessPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMContactIssuancePermissionId = "05D9000F-0600-49a6-8AE8-DA1DA72BFCF1";

	public static readonly Permission CRMContactIssuanceElementPermission = Permission.Create("05D9000F-0600-49a6-8AE8-DA1DA72BFCF1", SR.M("Выдача прав"), SR.M("Выдача прав для контактов"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContact>(CommonPermissions.GrantAccess)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewContactPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMContractorIssuancePermissionId = "1CD25727-7CE6-443c-84BD-7975822C79E6";

	public static readonly Permission CRMContractorIssuanceElementPermission = Permission.Create("1CD25727-7CE6-443c-84BD-7975822C79E6", SR.M("Выдача прав"), SR.M("Выдача прав для контрагентов"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IContractor>(CommonPermissions.GrantAccess)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewContractorPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMRelationshipIssuancePermissionId = "679876A7-8882-43d4-8FC2-3E7C9DB58ADB";

	public static readonly Permission CRMRelationshipIssuanceElementPermission = Permission.Create("679876A7-8882-43d4-8FC2-3E7C9DB58ADB", SR.M("Выдача прав"), SR.M("Выдача прав для взаимоотношений"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>(CommonPermissions.GrantAccess)
		.Dependencies(ViewRelationshipPermission)
		.AdminPermissions(CRMFullAccessPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMLeadIssuancePermissionId = "E70A9AD1-80B2-4435-80E9-EF8E14B974CE";

	public static readonly Permission CRMLeadIssuanceElementPermission = Permission.Create("E70A9AD1-80B2-4435-80E9-EF8E14B974CE", SR.M("Выдача прав"), SR.M("Выдача прав для возможностей"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ILead>(CommonPermissions.GrantAccess)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewLeadPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMSaleIssuancePermissionId = "F2141650-BB6D-4e3a-BB62-C0F071CF8EEA";

	public static readonly Permission CRMSaleIssuanceElementPermission = Permission.Create("F2141650-BB6D-4e3a-BB62-C0F071CF8EEA", SR.M("Выдача прав"), SR.M("Выдача прав для сделок"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ISale>(CommonPermissions.GrantAccess)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewSalePermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMMarketingIssuancePermissionId = "{7E1B0348-85E7-4629-8944-BC1B7D5F96F8}";

	public static readonly Permission CRMMarketingIssuanceElementPermission = Permission.Create("{7E1B0348-85E7-4629-8944-BC1B7D5F96F8}", SR.M("Выдача прав"), SR.M("Выдача прав для объекта маркетинга"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>(CommonPermissions.GrantAccess)
		.AdminPermissions(CRMFullAccessPermission)
		.Dependencies(ViewMarketingPermission)
		.ShowInGlobalSettings(showInGlobalSettings: false);

	public const string CRMContractorFullAccessPermissionId = "E612615C-D5E2-4c4b-9DF0-B4D9EEB983A5";

	public static readonly Permission CRMContractorFullAccessPermission = Permission.Create("E612615C-D5E2-4c4b-9DF0-B4D9EEB983A5", SR.M("Полный доступ"), "Полный доступ к контрагенту", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.InstancePermission<IContractor>()
		.Dependencies(ViewContractorPermission, EditContractorPermission, CRMContractorCreateElementPermission, CRMContractorIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMContactFullAccessPermissionId = "76B481D5-2E07-4417-9098-A57DE879FA56";

	public static readonly Permission CRMContactFullAccessPermission = Permission.Create("76B481D5-2E07-4417-9098-A57DE879FA56", SR.M("Полный доступ"), "Полный доступ к контакту", SR.M("Работа с контактами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.InstancePermission<IContact>()
		.Dependencies(ViewContactPermission, EditContactPermission, CRMContactCreateElementPermission, CRMContactIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMLeadFullAccessPermissionId = "90BE803C-7857-4F2D-A8B4-129264504101";

	public static readonly Permission CRMLeadFullAccessPermission = Permission.Create("90BE803C-7857-4F2D-A8B4-129264504101", SR.M("Полный доступ"), "Полный доступ к возможностям", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<ILead>()
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewLeadPermission, EditLeadPermission, CRMLeadCreateElementPermission, CRMLeadIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMSaleFullAccessPermissionId = "DB60BB49-0DE1-46ee-8CE8-DCD59DB93351";

	public static readonly Permission CRMSaleFullAccessPermission = Permission.Create("DB60BB49-0DE1-46ee-8CE8-DCD59DB93351", SR.M("Полный доступ"), "Полный доступ к сделке", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
		.InstancePermission<ISale>()
		.Dependencies(ViewSalePermission, EditSalePermission, CRMSaleCreateElementPermission, CRMSaleIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMRelationshipFullAccessPermissionId = "38A0AC5D-8D9C-4BB5-BDBA-A0E6CFD43C30";

	public static readonly Permission CRMRelationshipFullAccessPermission = Permission.Create("38A0AC5D-8D9C-4BB5-BDBA-A0E6CFD43C30", SR.M("Полный доступ"), "Полный доступ к взаимоотношению", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IRelationship>()
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewRelationshipPermission, EditRelationshipPermission, CRMRelationshipCreateElementPermission, CRMRelationshipIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	public const string CRMMarketingFullAccessPermissionId = "{81B30D9D-42F8-483F-A8D7-EC7E2E0F7CAD}";

	public static readonly Permission CRMMarketingFullAccessPermission = Permission.Create("{81B30D9D-42F8-483F-A8D7-EC7E2E0F7CAD}", SR.M("Полный доступ"), SR.M("Полный доступ к объекту маркетинга"), SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").InstancePermission<IMarketingBase>(CommonPermissions.Delete)
		.ShowInGlobalSettings(showInGlobalSettings: false)
		.Dependencies(ViewMarketingPermission, EditMarketingPermission, CRMMarketingCreateElementPermission, CRMMarketingBudgetControlPermission, CRMMarketingIssuanceElementPermission)
		.AdminPermissions(CRMFullAccessPermission);

	private static Dictionary<Guid, Permission> ListContractor;

	private static object ListContractorLocker = new object();

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public static Dictionary<Guid, Permission> ListContractorType
	{
		get
		{
			IMetadataRuntimeService metadataRuntimeService;
			SR.RunWithCulture(SR.KeyCultureInfo, delegate
			{
				if (ListContractor == null)
				{
					lock (ListContractorLocker)
					{
						if (ListContractor == null)
						{
							metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
							ListContractor = MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(typeof(IContractor), inherit: false), loadImplementation: false).OfType<EntityMetadata>().ToDictionary((EntityMetadata m) => m.ImplementationUid, (EntityMetadata m) => Permission.Create(m.Uid, () => SR.T("Создание '{0}'", SR.T(m.DisplayName)), "", SR.M("Работа с клиентами")).ModuleUid("EleWise.ELMA.CRM.Web").ShowInGlobalSettings(showInGlobalSettings: false)
								.EntityType(metadataRuntimeService.GetTypeByUid(m.Uid, loadImplementation: false))
								.Base(CommonPermissions.Create)
								.AdminPermissions(CRMFullAccessPermission)
								.GlobalPermission()
								.Build());
						}
					}
				}
			});
			return ListContractor;
		}
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[2]
		{
			new PermissionStereotype(GetPermissions(), SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(GetAllUsersPermissions(), SecurityConstants.AllUsersGroupDescriptor)
		};
	}

	public IEnumerable<Permission> GetPermissions()
	{
		List<Permission> list = new List<Permission>
		{
			CRMDeletePermission, CRMFullAccessPermission, CRMAccessPermission, CRMproductCreatePermission, ViewContractorPermission, ViewContactPermission, ViewSalePermission, ViewInpaymentPermission, ViewLeadPermission, ViewRelationshipPermission,
			CRMContactCreateElementPermission, CRMRelationshipCreateElementPermission, CRMLeadCreateElementPermission, CRMSaleCreateElementPermission, EditContractorPermission, EditContactPermission, EditSalePermission, EditInpaymentPermission, CreateInpaymentPermission, EditLeadPermission,
			EditRelationshipPermission, ExecuteRelationshipPermission, CRMEditGlobalFilters, CRMSaleFunnelReport, CRMImportPermission, CRMDublicateLeadPermission, CRMDeleteInpaymentPermission, CRMExportPermission, CRMChangeSaleStatusPermission, InpaymentsAccessPermission,
			SalesAccessPermission, CRMContractorCreateElementPermission, CRMContactIssuanceElementPermission, CRMContractorIssuanceElementPermission, CRMRelationshipIssuanceElementPermission, CRMLeadIssuanceElementPermission, CRMSaleIssuanceElementPermission, CRMContractorFullAccessPermission, CRMSaleFullAccessPermission, CRMContactFullAccessPermission,
			CRMRelationshipFullAccessPermission, CRMLeadFullAccessPermission, CRMContactCreatePermission, CRMLeadCreatePermission, CRMSaleCreatePermission, MarketingAccessPermission, MarketingFullAccessPermission, ViewMarketingPermission, EditMarketingPermission, CRMMarketingCreateElementPermission,
			CRMMarketingBudgetControlPermission, CRMMarketingIssuanceElementPermission, CRMMarketingFullAccessPermission
		};
		foreach (KeyValuePair<Guid, Permission> item in ListContractorType)
		{
			list.Add(item.Value);
		}
		return list;
	}

	protected IEnumerable<Permission> GetAllUsersPermissions()
	{
		List<Permission> list = new List<Permission>
		{
			CRMAccessPermission, CRMproductCreatePermission, ViewContractorPermission, ViewContactPermission, ViewSalePermission, ViewInpaymentPermission, ViewLeadPermission, ViewRelationshipPermission, CRMContactCreateElementPermission, CRMRelationshipCreateElementPermission,
			CRMLeadCreateElementPermission, CRMSaleCreateElementPermission, EditContractorPermission, EditContactPermission, EditSalePermission, EditInpaymentPermission, CreateInpaymentPermission, EditLeadPermission, EditRelationshipPermission, ExecuteRelationshipPermission,
			CRMContractorCreateElementPermission, CRMSaleFunnelReport, CRMDublicateLeadPermission, InpaymentsAccessPermission, SalesAccessPermission, CRMContactIssuanceElementPermission, CRMContractorIssuanceElementPermission, CRMRelationshipIssuanceElementPermission, CRMLeadIssuanceElementPermission, CRMSaleIssuanceElementPermission,
			CRMContractorFullAccessPermission, CRMSaleFullAccessPermission, CRMContactFullAccessPermission, CRMRelationshipFullAccessPermission, CRMLeadFullAccessPermission, CRMContactCreatePermission, CRMLeadCreatePermission, CRMSaleCreatePermission, MarketingAccessPermission
		};
		foreach (KeyValuePair<Guid, Permission> item in ListContractorType)
		{
			list.Add(item.Value);
		}
		return list;
	}

	public static bool HasPermission(Permission permission)
	{
		return Locator.GetServiceNotNull<ISecurityService>().HasPermission(permission);
	}

	public static bool CheckAny(IEnumerable<Permission> permissions)
	{
		if (permissions == null || permissions.Count() == 0)
		{
			return false;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		foreach (Permission permission in permissions)
		{
			if (serviceNotNull.HasPermission(permission))
			{
				return true;
			}
		}
		return false;
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		Dictionary<Permission, string> dictionary = new Dictionary<Permission, string>();
		dictionary.Add(CRMDeletePermission, "CRMDeletePermission");
		dictionary.Add(CRMFullAccessPermission, "CRMFullAccessPermission");
		dictionary.Add(CRMAccessPermission, "CRMAccessPermission");
		dictionary.Add(ViewContractorPermission, "ViewContractorPermission");
		dictionary.Add(ViewContactPermission, "ViewContactPermission");
		dictionary.Add(ViewSalePermission, "ViewSalePermission");
		dictionary.Add(ViewInpaymentPermission, "ViewInpaymentPermission");
		dictionary.Add(ViewLeadPermission, "ViewLeadPermission");
		dictionary.Add(CRMContractorCreateElementPermission, "CRMContractorCreateElementPermission");
		dictionary.Add(CRMContactCreateElementPermission, "CRMContactCreateElementPermission");
		dictionary.Add(CRMRelationshipCreateElementPermission, "CRMRelationshipCreateElementPermission");
		dictionary.Add(CRMLeadCreateElementPermission, "CRMLeadCreateElementPermission");
		dictionary.Add(CRMSaleCreateElementPermission, "CRMSaleCreateElementPermission");
		dictionary.Add(CRMproductCreatePermission, "CRMproductCreatePermission");
		dictionary.Add(EditContractorPermission, "EditContractorPermission");
		dictionary.Add(EditContactPermission, "EditContactPermission");
		dictionary.Add(EditSalePermission, "EditSalePermission");
		dictionary.Add(EditInpaymentPermission, "EditInpaymentPermission");
		dictionary.Add(EditLeadPermission, "EditLeadPermission");
		dictionary.Add(ExecuteRelationshipPermission, "ExecuteRelationshipPermission");
		dictionary.Add(CRMEditGlobalFilters, "CRMEditGlobalFilters");
		dictionary.Add(CRMSaleFunnelReport, "CRMSaleFunnelReport");
		dictionary.Add(CRMImportPermission, "CRMImportPermission");
		dictionary.Add(CRMDublicateLeadPermission, "CRMDublicateLeadPermission");
		dictionary.Add(CRMDeleteInpaymentPermission, "CRMDeleteInpaymentPermission");
		dictionary.Add(CRMExportPermission, "CRMExportPermission");
		dictionary.Add(CRMChangeSaleStatusPermission, "CRMChangeSaleStatusPermission");
		dictionary.Add(InpaymentsAccessPermission, "InpaymentsAccessPermission");
		dictionary.Add(SalesAccessPermission, "SalesAccessPermission");
		dictionary.Add(MarketingAccessPermission, "MarketingAccessPermission");
		dictionary.Add(MarketingFullAccessPermission, "MarketingFullAccessPermission");
		dictionary.Add(ViewRelationshipPermission, "ViewRelationshipPermission");
		dictionary.Add(EditRelationshipPermission, "EditRelationshipPermission");
		dictionary.Add(CRMContactIssuanceElementPermission, "CRMContactIssuanceElementPermission");
		dictionary.Add(CRMContractorIssuanceElementPermission, "CRMContractorIssuanceElementPermission");
		dictionary.Add(CRMRelationshipIssuanceElementPermission, "CRMRelationshipIssuanceElementPermission");
		dictionary.Add(CRMLeadIssuanceElementPermission, "CRMLeadIssuanceElementPermission");
		dictionary.Add(CRMSaleIssuanceElementPermission, "CRMSaleIssuanceElementPermission");
		dictionary.Add(CRMContractorFullAccessPermission, "CRMContractorFullAccessPermission");
		dictionary.Add(CRMContactFullAccessPermission, "CRMContactFullAccessPermission");
		dictionary.Add(CRMSaleFullAccessPermission, "CRMSaleFullAccessPermission");
		dictionary.Add(CRMRelationshipFullAccessPermission, "CRMRelationshipFullAccessPermission");
		dictionary.Add(CRMLeadFullAccessPermission, "CRMLeadFullAccessPermission");
		dictionary.Add(CRMContactCreatePermission, "CRMContactCreatePermission");
		dictionary.Add(CRMLeadCreatePermission, "CRMLeadCreatePermission");
		dictionary.Add(CRMSaleCreatePermission, "CRMSaleCreatePermission");
		dictionary.Add(ViewMarketingPermission, "ViewMarketingPermission");
		dictionary.Add(EditMarketingPermission, "EditMarketingPermission");
		dictionary.Add(CRMMarketingCreateElementPermission, "CRMMarketingCreateElementPermission");
		dictionary.Add(CRMMarketingBudgetControlPermission, "CRMMarketingBudgetControlPermission");
		dictionary.Add(CRMMarketingIssuanceElementPermission, "CRMMarketingIssuanceElementPermission");
		dictionary.Add(CRMMarketingFullAccessPermission, "CRMMarketingFullAccessPermission");
		foreach (KeyValuePair<Guid, Permission> item in ListContractorType)
		{
			dictionary.Add(item.Value, item.Value.Name);
		}
		return dictionary;
	}

	public static Permission GetCreateContractorPermission<IContractor>()
	{
		return GetCreateContractorPermission(typeof(IContractor));
	}

	public static Permission GetCreateContractorPermission(Type type)
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(type);
		Permission value = null;
		ListContractorType.TryGetValue(entityMetadata.ImplementationUid, out value);
		return value;
	}

	public static Permission GetCreateContractorPermission(Guid typeGuid)
	{
		Permission value = null;
		ListContractorType.TryGetValue(typeGuid, out value);
		return value;
	}
}
