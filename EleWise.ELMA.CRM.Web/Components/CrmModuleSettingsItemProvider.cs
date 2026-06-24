// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.CrmModuleSettingsItemProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class CrmModuleSettingsItemProvider : ICrmModuleSettingsItemProvider
  {
    public IEnumerable<CrmModuleSettingsItem> GetItems(UrlHelper urlHelper)
    {
      string str1 = EleWise.ELMA.SR.T("Справочники");
      string str2 = EleWise.ELMA.SR.T("Настройка воронки продаж");
      string str3 = EleWise.ELMA.SR.T("Настройки адресов");
      string str4 = EleWise.ELMA.SR.T("Настройка возможностей");
      string str5 = "#dictionary.svg";
      string str6 = EleWise.ELMA.SR.T("Настройка банковских реквизитов");
      ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(InterfaceActivator.UID<IBankDetailsSWIFT>(false));
      List<CrmModuleSettingsItem> items = new List<CrmModuleSettingsItem>()
      {
        new CrmModuleSettingsItem()
        {
          Order = 10,
          Text = EleWise.ELMA.SR.T("Категории"),
          Description = EleWise.ELMA.SR.T("Позволяет создавать и редактировать категории контрагентов и возможностей"),
          Image = "#category.svg",
          Url = urlHelper.Action("Index", "Category", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 20,
          Text = EleWise.ELMA.SR.T("Правила назначения категорий"),
          Description = EleWise.ELMA.SR.T("Позволяет создавать и редактировать правила автоматического назначения категорий"),
          Image = "#category.svg",
          Url = urlHelper.Action("Index", "CategoryRule", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 30,
          Text = EleWise.ELMA.SR.T("Права доступа"),
          Description = EleWise.ELMA.SR.T("Раздел содержит перечень прав доступа к объектам модуля <b>CRM</b>. С помощью данного раздела настраиваются параметры видимости объектов и набор доступных операций с этими объектами."),
          Image = "#access.svg",
          Url = urlHelper.Action("Permissions", "Security", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 40,
          Text = EleWise.ELMA.SR.T("Права доступа к полям и свойствам"),
          Description = EleWise.ELMA.SR.T("Раздел содержит перечень прав доступа к полям и свойствам объектов модуля <b>CRM</b>. С помощью данного раздела производится настройка прав доступа к полям и свойствам этих объектов."),
          Image = "#access.svg",
          Url = urlHelper.Action("PropertiesPermissions", "Security", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        }
      };
      if (ComponentManager.Current.GetExtensionPoints<IAddressBaseSettings>().SelectMany<IAddressBaseSettings, NamedValue<string>>((Func<IAddressBaseSettings, IEnumerable<NamedValue<string>>>) (p => p.Settings(urlHelper))).Any<NamedValue<string>>((Func<NamedValue<string>, bool>) (i => !string.IsNullOrWhiteSpace(i.Name) && !string.IsNullOrWhiteSpace(i.Value))))
        items.Add(new CrmModuleSettingsItem()
        {
          Order = 45,
          Category = str3,
          Text = EleWise.ELMA.SR.T("Настройки адресной базы контрагентов"),
          Description = EleWise.ELMA.SR.T("Содержит настройки адресной базы контрагентов для различных стран"),
          Image = str5,
          Url = urlHelper.Action("Settings", "ContractorBaseAddress", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        });
      items.AddRange((IEnumerable<CrmModuleSettingsItem>) new List<CrmModuleSettingsItem>()
      {
        new CrmModuleSettingsItem()
        {
          Order = 46,
          Category = str3,
          Text = EleWise.ELMA.SR.T("Выбор страны по умолчанию"),
          Image = str5,
          Description = EleWise.ELMA.SR.T("Позволяет выбрать страну по умолчанию"),
          Url = urlHelper.Action("DefaultCountry", "ContractorBaseAddress", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 50,
          Category = str2,
          Text = EleWise.ELMA.SR.T("Воронка продаж"),
          Description = EleWise.ELMA.SR.T("Позволяет создавать и редактировать воронки продаж"),
          Image = "#bar_chart_vertical.svg",
          Url = urlHelper.Action("Index", "SaleFunnel", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 60,
          Category = str2,
          Text = EleWise.ELMA.SR.T("Тип сделки"),
          Description = EleWise.ELMA.SR.T("Позволяет создавать и редактировать типы сделок"),
          Image = str5,
          Url = urlHelper.Action("", "SaleType", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 70,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Валюта"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ICurrency>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 80,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Источник возможности"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ILeadSource>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 90,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Организационно-правовая форма"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ILegalForm>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 100,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Отрасль"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IContractorIndustry>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 110,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Региональная группа"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IContractorRegion>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 120,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Страна"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ICountry>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 130,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Тип возможности"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ILeadType>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 140,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Тип клиента"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IContractorType>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 150,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Тип контакта"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<ICientType>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 160,
          Category = str1,
          Text = EleWise.ELMA.SR.T("Товары и услуги"),
          Image = str5,
          Url = urlHelper.Action("Index", "Product", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 61,
          Category = str6,
          Text = EleWise.ELMA.SR.T("Права доступа \"Реквизиты банка в системе SWIFT\""),
          Description = EleWise.ELMA.SR.T("Позволяет настраивать права доступа для справочника \"Реквизиты банка в системе SWIFT\""),
          Image = "#access.svg",
          Url = urlHelper.Action("EntityPermissionSettings", "PermissionManagment", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Security",
            id = catalogProfile.Id,
            type = catalogProfile.GetType().AssemblyQualifiedName
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 62,
          Category = str6,
          Text = EleWise.ELMA.SR.T("Банк"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IFinancialInstitutionBank>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 63,
          Category = str6,
          Text = EleWise.ELMA.SR.T("Реквизиты банка в системе SWIFT"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IBankDetailsSWIFT>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 64,
          Category = str6,
          Text = EleWise.ELMA.SR.T("Платежная система"),
          Image = str5,
          Url = urlHelper.Action("View", "Catalogs", (object) new
          {
            area = "EleWise.ELMA.BPM.Web.Common",
            uid = InterfaceActivator.UID<IPaymentSystem>()
          })
        }
      });
      if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.LeadSearchDublicate)
        items.Add(new CrmModuleSettingsItem()
        {
          Order = 61,
          Category = str4,
          Text = EleWise.ELMA.SR.T("Таблица скоринга дублей"),
          Description = EleWise.ELMA.SR.T("Позволяет настраивать поля для определения дублей возможностей"),
          Image = str5,
          Url = urlHelper.Action("Index", "LeadScoringSettings", (object) new
          {
            area = "EleWise.ELMA.CRM.Web"
          })
        });
      return (IEnumerable<CrmModuleSettingsItem>) items;
    }

    public IEnumerable<CrmModuleSettingsItem> GetObjects(UrlHelper urlHelper)
    {
      string str1 = EleWise.ELMA.SR.T("Список объектов CRM");
      string str2 = "#dictionary.svg";
      return (IEnumerable<CrmModuleSettingsItem>) new List<CrmModuleSettingsItem>()
      {
        new CrmModuleSettingsItem()
        {
          Order = 10,
          Category = str1,
          Text = EleWise.ELMA.SR.T((MetadataLoader.LoadMetadata(typeof (IContractor)) as EntityMetadata).DisplayName),
          Image = str2,
          Inheritors = this.GetInheritors(typeof (IContractor), urlHelper),
          Url = urlHelper.Action("PermissionSettings", "Security", (object) new
          {
            area = "EleWise.ELMA.CRM.Web",
            uid = InterfaceActivator.UID<IContractor>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 20,
          Category = str1,
          Text = EleWise.ELMA.SR.T((MetadataLoader.LoadMetadata(typeof (ISale)) as EntityMetadata).DisplayName),
          Image = str2,
          Inheritors = this.GetInheritors(typeof (ISale), urlHelper),
          Url = urlHelper.Action("PermissionSettings", "Security", (object) new
          {
            area = "EleWise.ELMA.CRM.Web",
            uid = InterfaceActivator.UID<ISale>()
          })
        },
        new CrmModuleSettingsItem()
        {
          Order = 30,
          Category = str1,
          Text = EleWise.ELMA.SR.T((MetadataLoader.LoadMetadata(typeof (IRelationship)) as EntityMetadata).DisplayName),
          Image = str2,
          Inheritors = this.GetInheritors(typeof (IRelationship), urlHelper),
          Url = urlHelper.Action("PermissionSettings", "Security", (object) new
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
      List<ClassMetadata> list = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().OfType<ClassMetadata>().Where<ClassMetadata>((Func<ClassMetadata, bool>) (m => m.BaseClassUid == baseUid)).ToList<ClassMetadata>();
      List<CrmModuleSettingsItem> result = new List<CrmModuleSettingsItem>();
      Action<ClassMetadata> action = (Action<ClassMetadata>) (i => result.Add(new CrmModuleSettingsItem()
      {
        Text = i.DisplayName,
        Image = dictionaryImageUrl,
        Url = urlHelper.Action("PermissionSettings", "Security", (object) new
        {
          area = "EleWise.ELMA.CRM.Web",
          uid = i.Uid
        })
      }));
      list.ForEach(action);
      return (IEnumerable<CrmModuleSettingsItem>) result;
    }
  }
}
