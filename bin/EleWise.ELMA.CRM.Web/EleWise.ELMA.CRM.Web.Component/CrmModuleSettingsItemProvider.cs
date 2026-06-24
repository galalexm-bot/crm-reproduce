using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CrmModuleSettingsItemProvider : ICrmModuleSettingsItemProvider
{
	public IEnumerable<CrmModuleSettingsItem> GetItems(UrlHelper urlHelper)
	{
		string category = SR.T("Справочники");
		string category2 = SR.T("Настройка воронки продаж");
		string category3 = SR.T("Настройки адресов");
		string category4 = SR.T("Настройка возможностей");
		string image = "#dictionary.svg";
		string category5 = SR.T("Настройка банковских реквизитов");
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(InterfaceActivator.UID<IBankDetailsSWIFT>(loadImplementation: false));
		List<CrmModuleSettingsItem> list = new List<CrmModuleSettingsItem>
		{
			new CrmModuleSettingsItem
			{
				Order = 10,
				Text = SR.T("Категории"),
				Description = SR.T("Позволяет создавать и редактировать категории контрагентов и возможностей"),
				Image = "#category.svg",
				Url = urlHelper.Action("Index", "Category", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 20,
				Text = SR.T("Правила назначения категорий"),
				Description = SR.T("Позволяет создавать и редактировать правила автоматического назначения категорий"),
				Image = "#category.svg",
				Url = urlHelper.Action("Index", "CategoryRule", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 30,
				Text = SR.T("Права доступа"),
				Description = SR.T("Раздел содержит перечень прав доступа к объектам модуля <b>CRM</b>. С помощью данного раздела настраиваются параметры видимости объектов и набор доступных операций с этими объектами."),
				Image = "#access.svg",
				Url = urlHelper.Action("Permissions", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 40,
				Text = SR.T("Права доступа к полям и свойствам"),
				Description = SR.T("Раздел содержит перечень прав доступа к полям и свойствам объектов модуля <b>CRM</b>. С помощью данного раздела производится настройка прав доступа к полям и свойствам этих объектов."),
				Image = "#access.svg",
				Url = urlHelper.Action("PropertiesPermissions", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			}
		};
		if (ComponentManager.Current.GetExtensionPoints<IAddressBaseSettings>().SelectMany((IAddressBaseSettings p) => p.Settings(urlHelper)).Any((NamedValue<string> i) => !string.IsNullOrWhiteSpace(i.Name) && !string.IsNullOrWhiteSpace(i.Value)))
		{
			list.Add(new CrmModuleSettingsItem
			{
				Order = 45,
				Category = category3,
				Text = SR.T("Настройки адресной базы контрагентов"),
				Description = SR.T("Содержит настройки адресной базы контрагентов для различных стран"),
				Image = image,
				Url = urlHelper.Action("Settings", "ContractorBaseAddress", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			});
		}
		list.AddRange(new List<CrmModuleSettingsItem>
		{
			new CrmModuleSettingsItem
			{
				Order = 46,
				Category = category3,
				Text = SR.T("Выбор страны по умолчанию"),
				Image = image,
				Description = SR.T("Позволяет выбрать страну по умолчанию"),
				Url = urlHelper.Action("DefaultCountry", "ContractorBaseAddress", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 50,
				Category = category2,
				Text = SR.T("Воронка продаж"),
				Description = SR.T("Позволяет создавать и редактировать воронки продаж"),
				Image = "#bar_chart_vertical.svg",
				Url = urlHelper.Action("Index", "SaleFunnel", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 60,
				Category = category2,
				Text = SR.T("Тип сделки"),
				Description = SR.T("Позволяет создавать и редактировать типы сделок"),
				Image = image,
				Url = urlHelper.Action("", "SaleType", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 70,
				Category = category,
				Text = SR.T("Валюта"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ICurrency>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 80,
				Category = category,
				Text = SR.T("Источник возможности"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ILeadSource>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 90,
				Category = category,
				Text = SR.T("Организационно-правовая форма"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ILegalForm>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 100,
				Category = category,
				Text = SR.T("Отрасль"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IContractorIndustry>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 110,
				Category = category,
				Text = SR.T("Региональная группа"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IContractorRegion>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 120,
				Category = category,
				Text = SR.T("Страна"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ICountry>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 130,
				Category = category,
				Text = SR.T("Тип возможности"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ILeadType>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 140,
				Category = category,
				Text = SR.T("Тип клиента"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IContractorType>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 150,
				Category = category,
				Text = SR.T("Тип контакта"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<ICientType>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 160,
				Category = category,
				Text = SR.T("Товары и услуги"),
				Image = image,
				Url = urlHelper.Action("Index", "Product", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 61,
				Category = category5,
				Text = SR.T("Права доступа \"Реквизиты банка в системе SWIFT\""),
				Description = SR.T("Позволяет настраивать права доступа для справочника \"Реквизиты банка в системе SWIFT\""),
				Image = "#access.svg",
				Url = urlHelper.Action("EntityPermissionSettings", "PermissionManagment", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					id = catalogProfile.Id,
					type = catalogProfile.GetType().AssemblyQualifiedName
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 62,
				Category = category5,
				Text = SR.T("Банк"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IFinancialInstitutionBank>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 63,
				Category = category5,
				Text = SR.T("Реквизиты банка в системе SWIFT"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IBankDetailsSWIFT>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 64,
				Category = category5,
				Text = SR.T("Платежная система"),
				Image = image,
				Url = urlHelper.Action("View", "Catalogs", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					uid = InterfaceActivator.UID<IPaymentSystem>()
				})
			}
		});
		if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.LeadSearchDublicate)
		{
			list.Add(new CrmModuleSettingsItem
			{
				Order = 61,
				Category = category4,
				Text = SR.T("Таблица скоринга дублей"),
				Description = SR.T("Позволяет настраивать поля для определения дублей возможностей"),
				Image = image,
				Url = urlHelper.Action("Index", "LeadScoringSettings", (object)new
				{
					area = "EleWise.ELMA.CRM.Web"
				})
			});
		}
		return list;
	}

	public IEnumerable<CrmModuleSettingsItem> GetObjects(UrlHelper urlHelper)
	{
		string category = SR.T("Список объектов CRM");
		string image = "#dictionary.svg";
		return new List<CrmModuleSettingsItem>
		{
			new CrmModuleSettingsItem
			{
				Order = 10,
				Category = category,
				Text = SR.T((MetadataLoader.LoadMetadata(typeof(IContractor)) as EntityMetadata).DisplayName),
				Image = image,
				Inheritors = GetInheritors(typeof(IContractor), urlHelper),
				Url = urlHelper.Action("PermissionSettings", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web",
					uid = InterfaceActivator.UID<IContractor>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 20,
				Category = category,
				Text = SR.T((MetadataLoader.LoadMetadata(typeof(ISale)) as EntityMetadata).DisplayName),
				Image = image,
				Inheritors = GetInheritors(typeof(ISale), urlHelper),
				Url = urlHelper.Action("PermissionSettings", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web",
					uid = InterfaceActivator.UID<ISale>()
				})
			},
			new CrmModuleSettingsItem
			{
				Order = 30,
				Category = category,
				Text = SR.T((MetadataLoader.LoadMetadata(typeof(IRelationship)) as EntityMetadata).DisplayName),
				Image = image,
				Inheritors = GetInheritors(typeof(IRelationship), urlHelper),
				Url = urlHelper.Action("PermissionSettings", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web",
					uid = InterfaceActivator.UID<IRelationship>()
				})
			}
		};
	}

	private IEnumerable<CrmModuleSettingsItem> GetInheritors(Type type, UrlHelper urlHelper)
	{
		string dictionaryImageUrl = "#dictionary.svg";
		Guid baseUid = InterfaceActivator.UID(type);
		List<ClassMetadata> list = (from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<ClassMetadata>()
			where m.BaseClassUid == baseUid
			select m).ToList();
		List<CrmModuleSettingsItem> result = new List<CrmModuleSettingsItem>();
		list.ForEach(delegate(ClassMetadata i)
		{
			result.Add(new CrmModuleSettingsItem
			{
				Text = i.DisplayName,
				Image = dictionaryImageUrl,
				Url = urlHelper.Action("PermissionSettings", "Security", (object)new
				{
					area = "EleWise.ELMA.CRM.Web",
					uid = i.Uid
				})
			});
		});
		return result;
	}
}
