// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Menu.CRMMenuItems
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Menu
{
  [Component]
  public class CRMMenuItems : IMenuItemsProvider
  {
    public const string CREATE_RING = "crm-create-ring";
    public const string CREATE_MEETING = "crm-create-meeting";
    public const string CREATE_MAIL = "crm-create-mail";
    public const string CONTACTS_MENU = "crm-contacts";
    public const string CONTRACTORS_MENU = "crm-contractors";
    public const string LEADS_MENU = "crm-leads";
    public const string SALES_MENU = "crm-salies";
    public const string INPAYMENTS_MENU = "crm-inpayments";
    public const string MARKETING_ACTIVITIES_MENU = "crm-marketing-aktivities";
    public const string CRM_ADMIN_MENU = "crm-admin-menu";
    public const string CRM_SALE_FUNNELS = "crm-sale-funnels";

    public void Items(MenuItemFactory factory)
    {
      factory.Action("crm-create-ring").Order(60).Container("create");
      factory.Action("crm-create-meeting").Order(70).Container("create");
      factory.Action("crm-create-mail").Order(80).Container("create");
      factory.With((Action<MenuItemBuilder>) (b => b.Container("start")));
      factory.Section(EleWise.ELMA.SR.M("Работа с клиентами"), "start-crm-menu").Order(600).Color("blue").Image16("#user.svg");
      factory.Action(new ActionRoute("Index", "Contractor", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Name(EleWise.ELMA.SR.M("Контрагенты")).Parent("start-crm-menu").Order(610).Image16("#contractors.svg");
      factory.Action(new ActionRoute("Index", "Lead", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Name(EleWise.ELMA.SR.M("Возможности")).Parent("start-crm-menu").Order(620).Image16("#contact.svg");
      factory.Action(new ActionRoute("Index", "Contact", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Name(EleWise.ELMA.SR.M("Контакты")).Parent("start-crm-menu").Order(630);
      factory.Action(new ActionRoute("Index", "Sale", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Name(EleWise.ELMA.SR.M("Сделки")).Parent("start-crm-menu").Order(640).Image16("#sale.svg");
      factory.With((Action<MenuItemBuilder>) (b => b.Container("top")));
      factory.Section(EleWise.ELMA.SR.M("Работа с клиентами"), "crm-top-menu").Order(31);
      factory.Action(new ActionRoute("Index", "Contractor", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-contractors").Parent("crm-top-menu").Order(10).Name(EleWise.ELMA.SR.M("Контрагенты"));
      factory.Action(new ActionRoute("Index", "Contact", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-contacts").Parent("crm-top-menu").Order(20).Name(EleWise.ELMA.SR.M("Контакты"));
      factory.Action(new ActionRoute("Index", "Lead", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-leads").Parent("crm-top-menu").Order(30).Name(EleWise.ELMA.SR.M("Возможности"));
      factory.Action(new ActionRoute("Index", "Sale", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm-top-menu").Code("crm-salies").Order(40).Name(EleWise.ELMA.SR.M("Сделки"));
      factory.Action(new ActionRoute("Index", "Inpayment", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm-top-menu").Code("crm-inpayments").Order(50).Name(EleWise.ELMA.SR.M("План поступлений"));
      factory.Action(new ActionRoute("Index", "SaleFunnelReport", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm-top-menu").Code("crm-sale-funnels").Order(60).Name(EleWise.ELMA.SR.M("Воронки продаж"));
      factory.Action(new ActionRoute("Index", "MarketingActivity", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm-top-menu").Code("crm-marketing-aktivities").Order(70).Name(EleWise.ELMA.SR.M("Маркетинговые мероприятия"));
      factory.Action("crm-create-ring").Parent("create").Order(90).Image24("#add.svg").Name(EleWise.ELMA.SR.M("Звонок"));
      factory.Action("crm-create-meeting").Parent("create").Order(91).Image24("#add_meeting.svg").Name(EleWise.ELMA.SR.M("Встреча"));
      factory.Action("crm-create-mail").Parent("create").Order(92).Image24("#message_outline.svg").Name(EleWise.ELMA.SR.M("Письмо"));
      factory.Section(EleWise.ELMA.SR.M("Работа с клиентами"), "create-crm-items").Parent("create").Order(100);
      factory.Section(EleWise.ELMA.SR.M("Клиент"), "create-crm-client-items").Parent("create-crm-items").Order(10).Image24("#add.svg");
      foreach (ClassMetadata classMetadata in (IEnumerable<ClassMetadata>) Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList().Where<IMetadata>((Func<IMetadata, bool>) (m => m is ClassMetadata && ((ClassMetadata) m).BaseClassUid == InterfaceActivator.UID<IContractor>())).Cast<ClassMetadata>().OrderBy<ClassMetadata, string>((Func<ClassMetadata, string>) (md => md.DisplayName)))
      {
        string actionName;
        string controllerName;
        string areaName;
        UIExtensions.SearchAction<ContractorCreateAttribute>(classMetadata.Uid, out actionName, out controllerName, out areaName, out ContractorCreateAttribute _);
        if (!string.IsNullOrEmpty(controllerName))
          factory.Action(new ActionRoute(actionName, controllerName.Replace("Controller", ""), (object) new
          {
            area = areaName
          })).Parent("create-crm-client-items").Order(10).Name(classMetadata.DisplayName).Image24(string.Format("~/SDK.Action/Images/Object/{0}?size=16&useParent=True", (object) classMetadata.Uid));
      }
      factory.Action(new ActionRoute("Create", "Contact", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("create-crm-items").Order(20).Name(EleWise.ELMA.SR.M("Контакт")).Image24("#add.svg");
      factory.Action(new ActionRoute("Create", "Lead", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("create-crm-items").Order(30).Name(EleWise.ELMA.SR.M("Возможность")).Image24("#add.svg");
      factory.Action(new ActionRoute("Create", "Sale", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("create-crm-items").Order(40).Name(EleWise.ELMA.SR.M("Сделка")).Image24("#sale.svg");
      factory.With((Action<MenuItemBuilder>) (b => b.Container("left")));
      factory.Section(EleWise.ELMA.SR.M("Клиенты"), "crm").Order(11).Image24("#crm.svg").OnTop(true).Stretch(true);
      factory.Action(new ActionRoute("Index", "Contractor", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-contractors").Parent("crm").Order(10);
      factory.Action(new ActionRoute("Index", "Contact", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-contacts").Parent("crm").Order(11);
      factory.Action(new ActionRoute("Index", "Lead", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-leads").Parent("crm").Order(12);
      factory.Action(new ActionRoute("Index", "Sale", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm").Code("crm-salies").Order(20);
      factory.Action(new ActionRoute("Index", "Inpayment", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm").Code("crm-inpayments").Order(20);
      factory.Action(new ActionRoute("Index", "SaleFunnelReport", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm").Code("crm-sale-funnels").Order(25);
      factory.Action(new ActionRoute("Index", "MarketingActivity", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Parent("crm").Code("crm-marketing-aktivities").Order(30);
      factory.Action(new ActionRoute("Index", "Admin", (object) new
      {
        area = "EleWise.ELMA.CRM.Web"
      })).Code("crm-admin-menu").Order(101).Parent("admin").Copy((Action<MenuItemBuilder>) (b => b.Container("top")));
    }

    public List<string> LocalizedItemsNames => (List<string>) null;

    public List<string> LocalizedItemsDescriptions => (List<string>) null;
  }
}
