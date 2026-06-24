using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.ViewItem;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class ViewItemController : BaseController
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly FormViewItemDescriptor formViewItemDescriptor;

	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	private readonly IEnumerable<IViewItemContentExtension> viewItemContentExtensions;

	public ViewItemController(IMetadataRuntimeService metadataRuntimeService, FormViewItemDescriptor formViewItemDescriptor, IEnumerable<IObjectFormProvider> objectFormProviders, IEnumerable<IViewItemContentExtension> viewItemContentExtensions)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.formViewItemDescriptor = formViewItemDescriptor;
		this.objectFormProviders = objectFormProviders;
		this.viewItemContentExtensions = viewItemContentExtensions;
	}

	[AsyncViewItemAction]
	public ActionResult GetViewItemContent(ViewItemContentRequest request)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		Type typeByUid = metadataRuntimeService.GetTypeByUid(request.EntityTypeUid);
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeByUid, inherit: false) as EntityMetadata;
		if (metadata == null)
		{
			return (ActionResult)new EmptyResult();
		}
		IObjectFormProvider objectFormProvider = objectFormProviders.FirstOrDefault((IObjectFormProvider provider) => provider.Check(metadata.TypeUid, metadata.Uid));
		if (objectFormProvider == null)
		{
			return (ActionResult)new EmptyResult();
		}
		IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
		if (entityManager == null)
		{
			return (ActionResult)new EmptyResult();
		}
		long entityId = request.EntityId;
		IEntity entity;
		if (entityId == 0L)
		{
			entity = entityManager.Create() as IEntity;
		}
		else
		{
			entity = entityManager.Load(entityId) as IEntity;
		}
		if (entity == null)
		{
			return (ActionResult)new EmptyResult();
		}
		FormViewItem formByUid = objectFormProvider.GetFormByUid(entity, request.FormUid);
		if (formByUid == null)
		{
			return (ActionResult)new EmptyResult();
		}
		ViewItem viewItem = formByUid.FindItem(request.ViewItemUid);
		if (viewItem == null)
		{
			return (ActionResult)new EmptyResult();
		}
		object model = viewItemContentExtensions.First((IViewItemContentExtension extension) => extension.Check(viewItem, entity)).GetModel(entity);
		StringBuilder stringBuilder = new StringBuilder();
		HtmlHelper html = GetHtmlHelper(model, request.HtmlPrefix);
		html.IgnoreZones(request.RegisteredZones);
		using (new ObjectViewData(html, ((ControllerBase)this).get_ViewData(), model, initialize: true)
		{
			ViewType = formByUid.ViewType,
			ItemType = ItemType.Default,
			ReadOnly = (viewItem.FormViewItem.ViewType == ViewType.Display),
			View = formByUid,
			ShowDescription = true
		})
		{
			stringBuilder.Append(html.AsyncViewItem(viewItem, model, null, null, null, formByUid.ViewType, ItemType.Default, (IViewItemRenderer r) => r.Render(html, viewItem, null)));
			List<Func<object, object>> list = new List<Func<object, object>>();
			foreach (object item in ((ControllerContext)html.get_ViewContext()).get_HttpContext().Items)
			{
				DictionaryEntry? dictionaryEntry = item as DictionaryEntry?;
				if (dictionaryEntry.HasValue)
				{
					DictionaryEntry value = dictionaryEntry.Value;
					if (value.Key is string text && !(text != "zone-content-Scripts") && value.Value is Dictionary<string, Func<object, object>> dictionary)
					{
						list.AddRange(dictionary.Values);
					}
				}
			}
			foreach (Func<object, object> item2 in list)
			{
				object obj = item2(null);
				MvcHtmlString val = (MvcHtmlString)((obj is MvcHtmlString) ? obj : null);
				if (val != null && val != MvcHtmlString.Empty)
				{
					stringBuilder.Append(((HtmlString)(object)val).ToHtmlString());
				}
			}
		}
		AppendDefaultContent(stringBuilder, html);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			Html = stringBuilder.ToString()
		});
	}

	[AsyncViewItemAction]
	public ActionResult GetCustomViewItemContent(CustomViewItemContentRequest request)
	{
		object model = null;
		if (request.EntityTypeUid != Guid.Empty)
		{
			model = (IEntity)ModelHelper.GetEntityManager(metadataRuntimeService.GetTypeByUid(request.EntityTypeUid)).LoadOrNull(request.EntityId);
		}
		StringBuilder stringBuilder = new StringBuilder();
		HtmlHelper htmlHelper = GetHtmlHelper(model, request.HtmlPrefix);
		ICustomViewItem viewItem = (ICustomViewItem)formViewItemDescriptor.DeserializeSimple(request.ViewItem, typeof(ICustomViewItem));
		stringBuilder.Append(htmlHelper.CustomViewItem(viewItem));
		AppendDefaultContent(stringBuilder, htmlHelper);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			Html = stringBuilder.ToString()
		});
	}

	private HtmlHelper GetHtmlHelper(object model, string prefix)
	{
		HtmlHelper htmlHelper = GetHtmlHelper();
		htmlHelper.get_ViewData().set_Model(model);
		htmlHelper.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
		return htmlHelper;
	}

	private void AppendDefaultContent(StringBuilder builder, HtmlHelper html)
	{
		builder.Append(html.RenderForZone("DefaultContentZone"));
		string value = HtmlHelperExtension.Telerik(html).ScriptRegistrar().jQuery(false)
			.OutputScriptFiles(false)
			.ToHtmlString();
		builder.Append(value);
	}
}
