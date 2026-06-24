using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Portlets.Layouts;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class FilterTreeContentController<TModel, TId> : FilterTreeBaseController<TModel, TId> where TModel : IEntity<TId>
{
	public IEnumerable<IPortletLayout> PortletLayouts { get; set; }

	public virtual bool ShowContentButtons => true;

	[HttpGet]
	public ActionResult SelectPortletPage()
	{
		SelectPortletPageModel selectPortletPageModel = new SelectPortletPageModel();
		return (ActionResult)(object)((Controller)this).PartialView("FilterTreeContent/SelectPortletPage", (object)selectPortletPageModel);
	}

	protected virtual IFilterActionLink CreateActionLink(IPortletPage page)
	{
		ReferenceOnEntityType referenceOnEntityType = new ReferenceOnEntityType
		{
			TypeUid = InterfaceActivator.UID<TModel>()
		};
		IFilterActionLink filterActionLink = InterfaceActivator.Create<IFilterActionLink>();
		filterActionLink.ParentFolder = FilterFolderManager.Instance.LoadOrCreateMyFilterFolder(referenceOnEntityType, Code);
		filterActionLink.ObjectsType = referenceOnEntityType;
		filterActionLink.ActionTypeProviderId = "PagesLinkTypeProvider";
		filterActionLink.ActionId = page.Id.ToString();
		filterActionLink.FilterType = FilterType.MyFilter;
		filterActionLink.Name = page.Name;
		filterActionLink.Code = Code;
		return filterActionLink;
	}

	[HttpPost]
	public ActionResult SelectPortletPage(SelectPortletPageModel model)
	{
		try
		{
			IFilterActionLink filterActionLink = CreateActionLink(model.Page);
			filterActionLink.Save();
			if (FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<TModel>()) == null)
			{
				FilterDefaultManager.Instance.SaveDefaultFilter(filterActionLink);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			}, "text/html");
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			}, "text/html");
		}
	}

	[HttpGet]
	public ActionResult CreatePortletPage()
	{
		IPortletPage page = InterfaceActivator.Create<IPortletPage>();
		PortletPageAttributesModel portletPageAttributesModel = new PortletPageAttributesModel();
		portletPageAttributesModel.Page = page;
		portletPageAttributesModel.Layouts = PortletLayouts;
		portletPageAttributesModel.Themes = new string[1] { "ELMA" };
		PortletPageAttributesModel portletPageAttributesModel2 = portletPageAttributesModel;
		return (ActionResult)(object)((Controller)this).PartialView("FilterTreeContent/CreatePortletPage", (object)portletPageAttributesModel2);
	}

	[HttpPost]
	public ActionResult CreatePortletPage(PortletPageAttributesModel model)
	{
		try
		{
			model.Page.Save();
			IFilterActionLink filterActionLink = CreateActionLink(model.Page);
			filterActionLink.Save();
			if (FilterDefaultManager.Instance.LoadDefaultFilter(InterfaceActivator.UID<TModel>()) == null)
			{
				FilterDefaultManager.Instance.SaveDefaultFilter(filterActionLink);
			}
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true,
				pageId = model.Page.Id
			}, "text/html");
		}
		catch (Exception ex)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				error = ex.Message
			}, "text/html");
		}
	}

	public override ActionResult EditFilters()
	{
		((ControllerBase)this).get_ViewData().set_Item("ShowContentButtons", (object)ShowContentButtons);
		return base.EditFilters();
	}
}
