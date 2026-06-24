using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Controllers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Integration.Views;

[Component(Order = 100)]
public class DocumentObjectCreator : FormCreator
{
	private const string Key = "EleWise.ELMA.Documents.Web.Integration.Views.DocumentObjectCreator";

	public override bool IsBase => true;

	public override bool CheckType(Type type)
	{
		if (type != null)
		{
			if (typeof(IDocument).IsAssignableFrom(type))
			{
				return InitActionMap(type, typeof(DocumentController));
			}
			return false;
		}
		return false;
	}

	public override RouteValueDictionary Route(Type type, string prefix, IEntity entity, FormBindingModel bindingModel)
	{
		if (bindingModel.TypeUid == InterfaceActivator.UID<IDocument>())
		{
			bindingModel.TypeUid = InterfaceActivator.UID<IFile>();
		}
		RouteValueDictionary routeValueDictionary = base.Route(type, prefix, entity, bindingModel);
		routeValueDictionary["area"] = "EleWise.ELMA.Documents.Web";
		routeValueDictionary["needButtons"] = false;
		return routeValueDictionary;
	}

	public override IDictionary<string, object> GetServerParams(object container, IPropertyMetadata propertyMetadata)
	{
		IEntity entityContainer = container as IEntity;
		if (propertyMetadata == null || entityContainer == null)
		{
			return null;
		}
		SimpleTypeSettings settings = propertyMetadata.Settings as SimpleTypeSettings;
		if (settings == null)
		{
			return null;
		}
		return ContextVars.GetOrAdd(string.Concat("EleWise.ELMA.Documents.Web.Integration.Views.DocumentObjectCreator", entityContainer.GetType().FullName, entityContainer.GetId(), propertyMetadata.DeclaringType?.FullName, propertyMetadata.Uid), delegate
		{
			Guid? customSetting = settings.GetCustomSetting<Guid?>("FolderContextVariable");
			bool? customSetting2 = settings.GetCustomSetting<bool?>("RestrictFolderChangeVariable");
			if (!customSetting.HasValue || customSetting.Value == Guid.Empty || !customSetting2.HasValue)
			{
				return null;
			}
			IFolder folder;
			try
			{
				entityContainer = FindContextIfTablePart(entityContainer);
				folder = entityContainer.GetPropertyValue(customSetting.Value) as IFolder;
			}
			catch (Exception)
			{
				return null;
			}
			return (folder == null) ? null : new Dictionary<string, object>
			{
				{ "folderId", folder.Id },
				{ "restrictChangeFolder", customSetting2.Value }
			};
		});
	}

	public override string GetParamsFunc(HtmlHelper html, string extprefix)
	{
		string fullHtmlFieldId = html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("DocumentLinkOwner");
		return $"\r\nvar owner = $('#{fullHtmlFieldId}').val();\r\nif (owner) {{\r\n    data = (data && data.length > 0 ? data + '&' : '') + 'parentDocument=' + owner;    \r\n}}\r\n";
	}

	protected IEntity FindContextIfTablePart(IEntity container)
	{
		if (container == null || !(container is ITablePartItem))
		{
			return container;
		}
		return FindContextIfTablePart(((ITablePartItem)container).Parent);
	}
}
