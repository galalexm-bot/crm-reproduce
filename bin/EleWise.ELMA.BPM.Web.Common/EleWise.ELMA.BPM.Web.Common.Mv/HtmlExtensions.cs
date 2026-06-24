using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Boxes;
using EleWise.ELMA.Web.Mvc.Models.Buttons;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Web.Mvc.Views.ViewItem;

namespace EleWise.ELMA.BPM.Web.Common.Mvc.html;

public static class HtmlExtensions
{
	public static MvcHtmlString UserCard(this HtmlHelper htmlHelper, UserCardModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "UserCard", (object)model);
	}

	public static MvcHtmlString AutoResizeTextbox(this HtmlHelper htmlHelper, AutoResizeTextboxModel model)
	{
		return PartialExtensions.Partial(htmlHelper, "AutoResizeTextbox", (object)model);
	}

	public static string AddComment(this HtmlHelper helper, string popupId)
	{
		return $"elma.addComment('{popupId}'); return false;";
	}

	public static MvcHtmlString EntityCollection(this HtmlHelper html, ICollection<ActionButtonType> hideActions, Guid? viewFormUid = null, Guid? editFormUid = null, string createCallback = null, string editCallback = null, string deleteCallback = null)
	{
		Type type = (html.get_ViewData().get_ModelMetadata().get_ModelType()
			.IsGenericType ? html.get_ViewData().get_ModelMetadata().get_ModelType()
			.GetGenericArguments()
			.FirstOrDefault() : null);
		if (type == null)
		{
			throw new ArgumentException(SR.T("Не удалось получить тип сущности"));
		}
		if (!(MetadataLoader.LoadMetadata(type) is EntityMetadata entityMetadata))
		{
			throw new MetadataLoadException(SR.T("Не удалось загрузить метаданные сущности"));
		}
		FormViewItem formViewItem = null;
		if (!viewFormUid.HasValue)
		{
			formViewItem = entityMetadata.DefaultForms.GetForm(ViewType.Display);
			if (formViewItem == null)
			{
				throw new NotSupportedException(SR.T("Для отображения коллекции сущностей типа \"{0}\" необходимо создать форму просмотра в конструкторе форм или указать идентификатор другой формы", entityMetadata.DisplayName));
			}
		}
		string text = UIExtensions.PrepareId(Guid.NewGuid().ToString());
		EntityCollectionModel model = new EntityCollectionModel
		{
			EntityCollection = (html.get_ViewData().get_Model() as IEnumerable<IEntity>),
			RootType = type,
			Metadata = entityMetadata,
			UniqueId = text,
			ViewFormUid = (viewFormUid ?? formViewItem.Uid),
			CreateCallback = createCallback,
			EditCallback = editCallback,
			DeleteCallback = deleteCallback,
			EditFormUid = editFormUid,
			HideActions = hideActions,
			ComboBoxAddLoading = false
		};
		model.AdditionalRouteValueDictionary = new RouteValueDictionary
		{
			{
				"parentHtmlPrefix",
				html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix()
			},
			{
				"openEntityCreator",
				$"openEntityCreator{model.UniqueId}(this)"
			},
			{
				"createEntityCallback",
				$"createEntityCallback{model.UniqueId}(data)"
			},
			{ "viewFormUid", model.ViewFormUid },
			{ "uniqueId", text }
		};
		model.EditEntityFormRoute = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{ "viewFormUid", model.ViewFormUid },
			{ "uniqueId", text },
			{
				"editEntityCallback",
				$"editEntityCallback{text}(data)"
			},
			{
				"popupId",
				$"EditEntityPopup{text}"
			},
			{ "containerId", model.ContainerId },
			{ "EditFormUid", model.EditFormUid }
		};
		UIExtensions.InitAutocompleteEntityComboBoxModel(html, model);
		return FormViewItemControl.WithDisableNotify(() => PartialExtensions.Partial(html, "EntityCollection/EntityCollection", (object)model, html.get_ViewData()));
	}

	public static MvcHtmlString EntityCollection(this HtmlHelper html, Guid? viewFormUid = null, Guid? editFormUid = null, string createCallback = null, string editCallback = null, string deleteCallback = null)
	{
		return html.EntityCollection(null, viewFormUid, editFormUid, createCallback, editCallback, deleteCallback);
	}

	public static MvcHtmlString ViewForm(this HtmlHelper html, IEntity entity, Guid viewFormUid, string uniqueId, bool hideEdit, bool hideDelete)
	{
		return ChildActionExtensions.Action(html, "CustomView", "Entity", new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Common" },
			{
				"customEntity",
				new ParameterContainer(entity)
			},
			{ "viewFormUid", viewFormUid },
			{ "uniqueId", uniqueId },
			{ "hideEdit", hideEdit },
			{ "hideDelete", hideDelete }
		});
	}
}
