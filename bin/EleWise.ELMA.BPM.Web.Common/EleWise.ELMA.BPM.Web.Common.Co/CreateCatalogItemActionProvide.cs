using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
[ActionWizardItem(Order = 80, Image32 = "#objects.svg")]
public class CreateCatalogItemActionProvider : LinkTypeProvider, ILinkTypeProvider
{
	public const string ProviderId = "CreateCatalogItemLinkTypeProvider";

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public string Id => "CreateCatalogItemLinkTypeProvider";

	public string Name => SR.M("Создать запись справочника");

	public int? Order => 15;

	public override string Category => SR.M("Общее");

	public override string Image => "#objects.svg";

	public override string ActionType => ContentAction.ActionTypeDialog;

	public IContentAction Get(string parameters)
	{
		string link = ((!string.IsNullOrEmpty(parameters)) ? $"CreateCatalogItem('{parameters}')" : "CreateCatalogItem()");
		return new ContentAction
		{
			Id = parameters,
			NameForLocalization = SR.M("Создать запись справочника"),
			DescriptionForLocalization = SR.M("Создать запись справочника"),
			Image24 = "#objects.svg",
			ActionType = ContentAction.ActionTypeDialog,
			IsAvalilableDelegate = (RequestContext x) => true,
			LinkTemplate = (RequestContext cc) => link.PrepareJavascriptHref(),
			OnRenderDelegate = delegate(HtmlHelper html)
			{
				html.RegisterContent("CreateCatalogItemSelectorContent", (dynamic d) => PartialExtensions.Partial(html, "ContentSelectors/CreateCatalogItemScript"));
			}
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		AutocompleteComboBox autocompleteComboBox = new AutocompleteComboBox
		{
			Name = "CatalogsComboBox",
			MultiSelect = false,
			ActionName = "FilteringAjax",
			ControllerName = "Catalogs",
			AutocompleteActionUrl = htmlHelper.Url().Action("FilteringAjax", "Catalogs", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Common"
			}),
			HtmlAttributes = new HtmlAttributes(),
			OnChange = "onChangeCatalogsComboBox"
		};
		autocompleteComboBox.RouteValueDictionary.Add("area", "EleWise.ELMA.BPM.Web.Common");
		string text = "CatalogsTree";
		TreeState treeState = TreePersonalizationAdministration.LoadState(text);
		if (treeState == null)
		{
			treeState = new TreeState
			{
				Id = text
			};
			TreePersonalizationAdministration.SaveState(text, treeState);
		}
		TreeModel tree = new TreeModel
		{
			Id = text,
			Children = CatalogsController.BuildTree(CatalogsController.EntityList, treeState, null, htmlHelper.Url(), (Guid guid) => "onSelectCatalogsTreeItem(this)", checkPermissions: false),
			HtmlAttributes = new
			{
				style = "width:100%;"
			},
			ShowExpandCollapseButtons = true
		};
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateCatalogItemActionParameters", (object)new CatalogListModel
		{
			Tree = tree,
			ComboBox = autocompleteComboBox
		});
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return "Catalogs_SelectedValue";
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return "Catalogs_SelectedText";
	}

	public override MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction)
	{
		Guid uid = Guid.Parse(contentAction.Id);
		ICatalogProfile catalogProfile = CatalogManager.Instance.LoadByCatalog(uid);
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/CreateCatalogItemActionView", (object)catalogProfile);
	}
}
