using System;
using System.Linq;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.IntegrationModules.Web.Models;

public class IntegrationActivityViewModel
{
	protected string viewItemId;

	protected DynamicFormSettings dynamicFormSettings;

	protected FormViewItem view;

	public IIntegrationModuleActivity Entity { get; set; }

	public ViewType ViewType { get; set; }

	public string FormId { get; set; }

	public string ViewItemId
	{
		get
		{
			if (!string.IsNullOrEmpty(viewItemId))
			{
				return viewItemId;
			}
			viewItemId = EntityObjectViewItemProvider.CreateViewItemId(Entity, ViewType, ItemType.Element);
			return viewItemId;
		}
		set
		{
			viewItemId = value;
		}
	}

	public bool FormReadOnly { get; set; }

	public Guid? FormUid { get; set; }

	public virtual DynamicFormSettings DynamicFormSettings
	{
		get
		{
			if (dynamicFormSettings != null)
			{
				return dynamicFormSettings;
			}
			dynamicFormSettings = new DynamicFormSettings
			{
				DynamicFormsProviderUid = EntityDynamicFormProvider.UID,
				DynamicFormsProviderData = EntityDynamicFormProvider.CreateData(Entity, ViewType, ItemType.Element),
				ViewProviderUid = EntityObjectViewItemProvider.UID,
				ViewItemId = ViewItemId
			};
			if (!string.IsNullOrEmpty(FormId))
			{
				dynamicFormSettings.FormId = FormId;
			}
			GetViewItem();
			return dynamicFormSettings;
		}
		set
		{
			dynamicFormSettings = value;
		}
	}

	public FormViewItem View
	{
		get
		{
			return GetViewItem();
		}
		set
		{
			view = value;
		}
	}

	protected virtual FormViewItem GetViewItem()
	{
		if (view != null)
		{
			return view;
		}
		Type type = EntityHelper.GetType(Entity);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(type);
		if (FormUid.HasValue && FormUid.Value != Guid.Empty)
		{
			view = classMetadata.GetForms().FirstOrDefault((FormViewItem q) => q.Uid == FormUid.Value);
		}
		else
		{
			view = EntityObjectViewItemProvider.GetViewItem(type, ViewType, ItemType.Element) as FormViewItem;
		}
		view = DynamicFormHelper.FormWithExecutedLoadScripts(view, Entity, classMetadata, DynamicFormSettings);
		if (view == null)
		{
			return null;
		}
		if (ViewType == ViewType.Display)
		{
			view = (FormViewItem)view.CloneAsReadOnly();
			ViewType = ViewType.Display;
		}
		return view;
	}
}
