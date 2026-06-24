using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class ContentActionController : BPMController
{
	public ActionsLinkTypeProvider ActionsLinkTypeProvider { get; set; }

	public ContentActionRegistry ContentActionRegistry { get; set; }

	public IEnumerable<ILinkTypeProvider> ContentLinkTypeProviders { get; set; }

	public ActionResult Selector()
	{
		return TreeSelector();
	}

	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "3BE77643-C23B-429D-9437-E6D2565680A2" })]
	public JsonResult Select(string text)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		if (text == null)
		{
			text = "";
		}
		text = text.ToLower();
		Func<IContentAction, string> actionText = (IContentAction u) => $"{u.Category} - {u.Name}";
		SelectList data = new SelectList((IEnumerable)(from u in (from a in ActionsLinkTypeProvider.All().OfType<IContentAction>()
				where string.IsNullOrWhiteSpace(text) || actionText(a).ToLower().Contains(text)
				select a).Distinct(FunctorEqualityComparer<IContentAction, string>.Create(actionText)).OrderBy(actionText).Take(100)
				.ToList()
			select new
			{
				id = new
				{
					id = u.Id,
					type = "ActionsLinkTypeProvider"
				}.ToJson(),
				text = actionText(u)
			}), "id", "text");
		JsonResult val = new JsonResult();
		val.set_Data((object)data);
		return val;
	}

	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "3BE77643-C23B-429D-9437-E6D2565680A2" })]
	[ContentItem(Name = "SR.M('Реестр действий')", Description = "SR.M('Каталог зарегистрированных действий')", Image24 = "#action.svg")]
	public ActionResult Index()
	{
		GridData<ContentActionModel> gridData = CreateContentActionModels(showSelectButton: false).CreateGridData("Category");
		return (ActionResult)(object)((Controller)this).View("Index", (object)gridData);
	}

	private IEnumerable<ContentActionModel> CreateContentActionModels(bool showSelectButton)
	{
		return (from a in (from a in ActionsLinkTypeProvider.All().OfType<IContentAction>()
				select new ContentActionModel(a)).Union(from p in ContentLinkTypeProviders
				where p.ShowInTree
				select new ContentActionModel(p, showSelectButton))
			orderby a.Category
			select a).ToList();
	}

	[AnyPermission(new string[] { "F7B8B68B-FFD1-4211-ACDE-C60E2065E6A6", "3BE77643-C23B-429D-9437-E6D2565680A2" })]
	public ActionResult TreeSelector()
	{
		return (ActionResult)(object)((Controller)this).PartialView("Tree", (object)ActionsTreeModel());
	}

	public ActionResult WizardRegistryTree(string popupId)
	{
		TreeModel treeModel = ActionsTreeModel();
		treeModel.Id = $"{popupId}_registryTree";
		treeModel.ShowExpandCollapseButtons = true;
		treeModel.HtmlAttributes = new { };
		treeModel.OnSelectFunction = $"function (e) {{ elma.tree.onSelect(e); {popupId}_onTreeNodeSelect(e); }}";
		return (ActionResult)(object)((Controller)this).PartialView((object)treeModel);
	}

	public ActionResult ContentActionSelectorDisplay(string actionTypeId, string actionId, string prefix)
	{
		if (!string.IsNullOrEmpty(prefix))
		{
			((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Editortemplates/ContentActionSelectorDisplay", (object)LinkModel.Create(ContentActionRegistry, actionTypeId, actionId));
	}

	private TreeModel ActionsTreeModel()
	{
		IEnumerable<ContentActionModel> source = CreateContentActionModels(showSelectButton: true);
		TreeState treeState = TreePersonalizationAdministration.LoadState("ContentActionsTree");
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = "ContentActionsTree"
			};
			TreePersonalizationAdministration.SaveState("ContentActionsTree", treeState);
		}
		Func<ContentActionModel, TreeMenuNode> createNode = null;
		createNode = delegate(ContentActionModel contentAction)
		{
			string url = null;
			return new TreeMenuNode
			{
				id = ((object)new
				{
					id = contentAction.Id,
					url = url,
					text = contentAction.Name,
					hasParamaters = contentAction.HasParameters,
					paramsPopupId = contentAction.ParamsPopupId()
				}.ToJson()).ToString(),
				text = (contentAction.Name ?? contentAction.Id),
				icon = contentAction.Image,
				tag = contentAction
			};
		};
		return new TreeModel
		{
			Id = "ContentActionsTree",
			Children = (from ca in source
				group ca by ca.Category into g
				select new TreeMenuNode
				{
					id = "cat_" + g.Key,
					text = g.Key,
					children = g.OrderBy((ContentActionModel x) => x.Order).Select(createNode).ToList()
				}).ToList()
		};
	}

	public ActionResult ParametersStep(string id, string wizardId)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		if (id == "ActionsLinkTypeProvider")
		{
			ContentResult val = new ContentResult();
			val.set_Content(SR.T("Действие не имеет параметров"));
			return (ActionResult)val;
		}
		List<ILinkTypeProvider> list = ContentLinkTypeProviders.ToList();
		ILinkTypeProvider linkTypeProvider = list.Find((ILinkTypeProvider a) => a.Id == id);
		if (linkTypeProvider != null)
		{
			((ControllerBase)this).get_ViewData().set_Item("WizardId", (object)wizardId);
			return (ActionResult)(object)((Controller)this).PartialView((object)linkTypeProvider);
		}
		if (id.StartsWith("configuration_pagev2"))
		{
			ILinkTypeProvider linkTypeProvider2 = list.Find((ILinkTypeProvider provider) => provider.Id == "EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider");
			if (linkTypeProvider2 != null)
			{
				((ControllerBase)this).get_ViewData().set_Item("PageName", (object)id.Replace("configuration_pagev2_", ""));
				((ControllerBase)this).get_ViewData().set_Item("WizardId", (object)wizardId);
				return (ActionResult)(object)((Controller)this).PartialView((object)linkTypeProvider2);
			}
		}
		ContentResult val2 = new ContentResult();
		val2.set_Content(SR.T("Действие не найдено"));
		return (ActionResult)val2;
	}
}
