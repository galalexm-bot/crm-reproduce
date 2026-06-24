using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;

namespace EleWise.ELMA.CRM.Web.Menu;

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

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public void Items(MenuItemFactory factory)
	{
		factory.Action("crm-create-ring").Order(60).Container("create");
		factory.Action("crm-create-meeting").Order(70).Container("create");
		factory.Action("crm-create-mail").Order(80).Container("create");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("start");
		});
		factory.Section(SR.M("Работа с клиентами"), "start-crm-menu").Order(600).Color("blue")
			.Image16("#user.svg");
		factory.Action(new ActionRoute("Index", "Contractor", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Name(SR.M("Контрагенты")).Parent("start-crm-menu")
			.Order(610)
			.Image16("#contractors.svg");
		factory.Action(new ActionRoute("Index", "Lead", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Name(SR.M("Возможности")).Parent("start-crm-menu")
			.Order(620)
			.Image16("#contact.svg");
		factory.Action(new ActionRoute("Index", "Contact", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Name(SR.M("Контакты")).Parent("start-crm-menu")
			.Order(630);
		factory.Action(new ActionRoute("Index", "Sale", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Name(SR.M("Сделки")).Parent("start-crm-menu")
			.Order(640)
			.Image16("#sale.svg");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("top");
		});
		factory.Section(SR.M("Работа с клиентами"), "crm-top-menu").Order(31);
		factory.Action(new ActionRoute("Index", "Contractor", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-contractors").Parent("crm-top-menu")
			.Order(10)
			.Name(SR.M("Контрагенты"));
		factory.Action(new ActionRoute("Index", "Contact", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-contacts").Parent("crm-top-menu")
			.Order(20)
			.Name(SR.M("Контакты"));
		factory.Action(new ActionRoute("Index", "Lead", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-leads").Parent("crm-top-menu")
			.Order(30)
			.Name(SR.M("Возможности"));
		factory.Action(new ActionRoute("Index", "Sale", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm-top-menu").Code("crm-salies")
			.Order(40)
			.Name(SR.M("Сделки"));
		factory.Action(new ActionRoute("Index", "Inpayment", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm-top-menu").Code("crm-inpayments")
			.Order(50)
			.Name(SR.M("План поступлений"));
		factory.Action(new ActionRoute("Index", "SaleFunnelReport", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm-top-menu").Code("crm-sale-funnels")
			.Order(60)
			.Name(SR.M("Воронки продаж"));
		factory.Action(new ActionRoute("Index", "MarketingActivity", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm-top-menu").Code("crm-marketing-aktivities")
			.Order(70)
			.Name(SR.M("Маркетинговые мероприятия"));
		factory.Action("crm-create-ring").Parent("create").Order(90)
			.Image24("#add.svg")
			.Name(SR.M("Звонок"));
		factory.Action("crm-create-meeting").Parent("create").Order(91)
			.Image24("#add_meeting.svg")
			.Name(SR.M("Встреча"));
		factory.Action("crm-create-mail").Parent("create").Order(92)
			.Image24("#message_outline.svg")
			.Name(SR.M("Письмо"));
		factory.Section(SR.M("Работа с клиентами"), "create-crm-items").Parent("create").Order(100);
		factory.Section(SR.M("Клиент"), "create-crm-client-items").Parent("create-crm-items").Order(10)
			.Image24("#add.svg");
		foreach (ClassMetadata item in from ClassMetadata md in from m in Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadataList()
				where m is ClassMetadata && ((ClassMetadata)m).BaseClassUid == InterfaceActivator.UID<IContractor>()
				select m
			orderby md.DisplayName
			select md)
		{
			UIExtensions.SearchAction<ContractorCreateAttribute>(item.Uid, out var actionName, out var controllerName, out var areaName, out var _);
			if (!string.IsNullOrEmpty(controllerName))
			{
				factory.Action(new ActionRoute(actionName, controllerName.Replace("Controller", ""), new
				{
					area = areaName
				})).Parent("create-crm-client-items").Order(10)
					.Name(item.DisplayName)
					.Image24($"~/SDK.Action/Images/Object/{item.Uid}?size=16&useParent=True");
			}
		}
		factory.Action(new ActionRoute("Create", "Contact", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("create-crm-items").Order(20)
			.Name(SR.M("Контакт"))
			.Image24("#add.svg");
		factory.Action(new ActionRoute("Create", "Lead", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("create-crm-items").Order(30)
			.Name(SR.M("Возможность"))
			.Image24("#add.svg");
		factory.Action(new ActionRoute("Create", "Sale", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("create-crm-items").Order(40)
			.Name(SR.M("Сделка"))
			.Image24("#sale.svg");
		factory.With(delegate(MenuItemBuilder b)
		{
			b.Container("left");
		});
		factory.Section(SR.M("Клиенты"), "crm").Order(11).Image24("#crm.svg")
			.OnTop(onTop: true)
			.Stretch(stretch: true);
		factory.Action(new ActionRoute("Index", "Contractor", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-contractors").Parent("crm")
			.Order(10);
		factory.Action(new ActionRoute("Index", "Contact", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-contacts").Parent("crm")
			.Order(11);
		factory.Action(new ActionRoute("Index", "Lead", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-leads").Parent("crm")
			.Order(12);
		factory.Action(new ActionRoute("Index", "Sale", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm").Code("crm-salies")
			.Order(20);
		factory.Action(new ActionRoute("Index", "Inpayment", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm").Code("crm-inpayments")
			.Order(20);
		factory.Action(new ActionRoute("Index", "SaleFunnelReport", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm").Code("crm-sale-funnels")
			.Order(25);
		factory.Action(new ActionRoute("Index", "MarketingActivity", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Parent("crm").Code("crm-marketing-aktivities")
			.Order(30);
		factory.Action(new ActionRoute("Index", "Admin", new
		{
			area = "EleWise.ELMA.CRM.Web"
		})).Code("crm-admin-menu").Order(101)
			.Parent("admin")
			.Copy(delegate(MenuItemBuilder b)
			{
				b.Container("top");
			});
	}
}
