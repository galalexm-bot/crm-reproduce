using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Inputs;

namespace EleWise.ELMA.Web.Mvc.Html.EditableList;

public class EditableListBuilder
{
	private readonly EditableListModel model;

	private readonly HtmlHelper htmlHelper;

	public EditableListBuilder(string name, HtmlHelper htmlHelper)
	{
		if (htmlHelper == null)
		{
			throw new ArgumentNullException("htmlHelper");
		}
		model = new EditableListModel
		{
			Name = name,
			Items = new EditableListItem[0],
			Edit = true,
			SeparateDeleteButton = false
		};
		this.htmlHelper = htmlHelper;
	}

	public EditableListBuilder Items(IEnumerable<EditableListItem> items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		model.Items = items;
		return this;
	}

	public EditableListBuilder Items<T>(IEnumerable<T> items) where T : IEntity
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		Type typeFromHandle = typeof(T);
		ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(typeFromHandle);
		EntityPropertyMetadata propertyMetadata = new EntityPropertyMetadata
		{
			SubTypeUid = InterfaceActivator.UID(typeFromHandle, loadImplementation: false),
			TypeUid = (typeDescriptor?.Uid ?? EntityDescriptor.UID)
		};
		IEnumerable<IInput> extensionPoints = ComponentManager.Current.GetExtensionPoints<IInput>();
		EntityInput input = (extensionPoints.FirstOrDefault((IInput inp) => inp.TypeUid == propertyMetadata.TypeUid) ?? extensionPoints.FirstOrDefault((IInput inp) => inp.TypeUid == Guid.Empty)) as EntityInput;
		ViewAttributes viewAttributes = new ViewAttributes
		{
			TypeSettings = propertyMetadata.Settings
		};
		model.Items = items.Select((T i) => new EditableListItem
		{
			Value = i.GetId().ToString(),
			DisplayText = i.ToString(),
			Content = ((input != null) ? PartialExtensions.Partial(htmlHelper, "DisplayTemplates/" + input.EditorTemplateName(((ControllerContext)htmlHelper.get_ViewContext()).get_Controller().get_ControllerContext(), propertyMetadata, i.GetType(), viewAttributes), (object)i) : null)
		});
		return this;
	}

	public EditableListBuilder Edit(bool edit)
	{
		model.Edit = edit;
		return this;
	}

	public EditableListBuilder ItemTemplate(Func<Tuple<MvcHtmlString, ListItem, MvcHtmlString>, object> itemTemplate)
	{
		model.ItemTemplate = itemTemplate;
		return this;
	}

	public EditableListBuilder ListTemplate(Func<MvcHtmlString, object> listTemplate)
	{
		model.ListTemplate = listTemplate;
		return this;
	}

	public EditableListBuilder SeparateDeleteButton(bool isSeparate)
	{
		model.SeparateDeleteButton = isSeparate;
		return this;
	}

	public EditableListBuilder AddTemplate(string addTemplate)
	{
		model.AddTemplate = addTemplate;
		return this;
	}

	public EditableListBuilder GroupByProperty(string property)
	{
		model.GroupByProperty = property;
		return this;
	}

	public override string ToString()
	{
		throw new InvalidOperationException(SR.T("Следует использовать метод ToMvcHtmlString() вместо ToString()"));
	}

	public MvcHtmlString ToMvcHtmlString()
	{
		return PartialExtensions.Partial(htmlHelper, "Templates/EditableList", (object)model);
	}
}
