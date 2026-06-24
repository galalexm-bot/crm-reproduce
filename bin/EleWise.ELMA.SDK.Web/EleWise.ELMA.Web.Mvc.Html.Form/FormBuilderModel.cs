using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class FormBuilderModel<TModel> : FormBuilderModel
{
	protected FormDriverForModel<TModel> Driver
	{
		get
		{
			return (FormDriverForModel<TModel>)base.FormDriver;
		}
		set
		{
			base.FormDriver = value;
		}
	}

	public TModel Model
	{
		get
		{
			return (TModel)FormModel;
		}
		set
		{
			FormModel = value;
		}
	}

	public new Func<FormBuilderModel<TModel>, object> LayoutTemplate
	{
		get
		{
			if (base.LayoutTemplate == null)
			{
				return null;
			}
			return (FormBuilderModel<TModel> model) => base.LayoutTemplate(model);
		}
		set
		{
			if (value == null)
			{
				base.LayoutTemplate = null;
				return;
			}
			base.LayoutTemplate = (FormBuilderModel model) => value((FormBuilderModel<TModel>)model);
		}
	}

	public FormBuilderModel(TModel model, ViewType viewType)
		: base(model, viewType)
	{
		Driver = new FormDriverForModel<TModel>(model.Implementation().GetType());
	}

	public FormBuilderModel(TModel model, string elementId, ViewType viewType)
		: base(model, viewType, elementId)
	{
		Driver = new FormDriverForModel<TModel>(elementId, model.Implementation().GetType());
	}

	[NotNull]
	public new PropertyRowModel<TModel> GetPropertyRow(string propertyName)
	{
		if (!propertyRows.TryGetValue(propertyName, out var value))
		{
			RowDriverForModel<TModel> rowDriverForModel = Driver.GetRowDrivers().FirstOrDefault((RowDriverForModel<TModel> rd) => rd.PropertyName == propertyName);
			if (rowDriverForModel == null)
			{
				throw new ArgumentException(SR.T("Невозможно найти драйвер для свойства {0} модели {1}", propertyName, base.ModelType));
			}
			value = new PropertyRowModel<TModel>(Model, rowDriverForModel)
			{
				Order = propertyRows.Count + 1
			};
			PropertyMetadata metadata = rowDriverForModel.GetMetadata();
			if (metadata != null)
			{
				ViewAttribute forView = metadata.ViewSettings.GetForView(ViewType);
				if (forView != null)
				{
					value.Visible = forView.Visible;
					WebViewAttributes attributes = value.Attributes;
					WebViewAttributes captionAttributes = rowDriverForModel.CaptionAttributes;
					WebViewAttributes valueAttributes = rowDriverForModel.ValueAttributes;
					WebViewAttributes editorAttributes = rowDriverForModel.EditorAttributes;
					bool? flag2 = (rowDriverForModel.DescriptionAttributes.ReadOnly = forView.ReadOnly);
					bool? flag4 = (editorAttributes.ReadOnly = flag2);
					bool? flag6 = (valueAttributes.ReadOnly = flag4);
					bool? flag9 = (attributes.ReadOnly = (captionAttributes.ReadOnly = flag6));
					WebViewAttributes attributes2 = value.Attributes;
					WebViewAttributes captionAttributes2 = rowDriverForModel.CaptionAttributes;
					WebViewAttributes valueAttributes2 = rowDriverForModel.ValueAttributes;
					WebViewAttributes editorAttributes2 = rowDriverForModel.EditorAttributes;
					bool flag11 = (rowDriverForModel.DescriptionAttributes.Required = !forView.ReadOnly && metadata.Required);
					bool flag13 = (editorAttributes2.Required = flag11);
					bool flag15 = (valueAttributes2.Required = flag13);
					bool required = (captionAttributes2.Required = flag15);
					attributes2.Required = required;
				}
			}
			propertyRows.Add(propertyName, value);
		}
		return (PropertyRowModel<TModel>)value;
	}
}
public class FormBuilderModel
{
	private FormDriver _formDriver;

	private Type _modelType;

	private ViewType _viewType;

	private object _formModel;

	private WebViewAttributes _attributes;

	protected readonly SortedDictionary<string, PropertyRowModel> propertyRows = new SortedDictionary<string, PropertyRowModel>();

	protected virtual FormDriver FormDriver
	{
		get
		{
			return _formDriver;
		}
		set
		{
			_formDriver = value;
		}
	}

	protected Type ModelType
	{
		get
		{
			return _modelType;
		}
		set
		{
			if (_modelType != value)
			{
				propertyRows.Clear();
			}
			_modelType = value;
		}
	}

	public IFormBuilderLayout Layout { get; set; }

	public FormViewModel FormViewModel { get; set; }

	public bool HideForm { get; set; }

	public virtual ViewType ViewType
	{
		get
		{
			return _viewType;
		}
		set
		{
			_viewType = value;
		}
	}

	public virtual bool HideDefaults { get; set; }

	public virtual string HtmlInputPrefix { get; set; }

	public Func<FormBuilderModel, object> LayoutTemplate { get; set; }

	public virtual object FormModel
	{
		get
		{
			return _formModel;
		}
		set
		{
			ModelType = value.Implementation().GetType();
			_formModel = value.Implementation();
		}
	}

	public virtual WebViewAttributes Attributes
	{
		get
		{
			return _attributes;
		}
		set
		{
			_attributes = value;
		}
	}

	public virtual IEnumerable<PropertyRowModel> PropertyRows
	{
		get
		{
			List<PropertyRowModel> list = propertyRows.Values.ToList();
			if (!HideDefaults)
			{
				List<PropertyRowModel> first = (from r in FormDriver.GetRowDrivers()
					where !propertyRows.Keys.Contains(r.PropertyName)
					select GetPropertyRow(r.PropertyName)).ToList();
				return FinalFilter(first.Union(list));
			}
			return FinalFilter(list);
		}
	}

	public ICollection<Func<PropertyInfo, bool>> PropertyVisibleFilters { get; protected set; }

	public ICollection<Action<PropertyRowModel>> PropertyRowActions { get; protected set; }

	public FormBuilderModel(object model, ViewType viewType, string elementId = null)
	{
		_modelType = model.Implementation().GetType();
		_formModel = model.Implementation();
		_viewType = viewType;
		_attributes = new WebViewAttributes();
		_formDriver = ((elementId == null) ? new FormDriver(_modelType) : new FormDriver(elementId, _modelType));
		FormViewModel = new FormViewModel
		{
			Id = _formDriver.ElementId
		};
		PropertyVisibleFilters = new List<Func<PropertyInfo, bool>>();
		PropertyRowActions = new List<Action<PropertyRowModel>>();
		OnAfterCreateModel();
	}

	private void OnAfterCreateModel()
	{
		IEnumerable<IFormBuilderModelUpdater> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFormBuilderModelUpdater>();
		if (extensionPoints == null)
		{
			return;
		}
		foreach (IFormBuilderModelUpdater item in extensionPoints)
		{
			item.AfterCreate(this);
		}
	}

	private void OnBeforeRender(HtmlHelper html)
	{
		IEnumerable<IFormBuilderModelUpdater> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFormBuilderModelUpdater>();
		if (extensionPoints == null)
		{
			return;
		}
		foreach (IFormBuilderModelUpdater item in extensionPoints)
		{
			item.BeforeRender(html, this);
		}
	}

	private IEnumerable<PropertyRowModel> FinalFilter(IEnumerable<PropertyRowModel> collection)
	{
		IOrderedEnumerable<PropertyRowModel> orderedEnumerable = from r in PropertyVisibleFilters.Where((Func<PropertyInfo, bool> filter) => filter != null).Aggregate(collection, (IEnumerable<PropertyRowModel> current, Func<PropertyInfo, bool> filter) => current.Where((PropertyRowModel r) => filter(r.Driver.GetPropertyInfo())))
			orderby r.Order
			select r;
		if (orderedEnumerable == null)
		{
			throw new ArgumentNullException("res");
		}
		foreach (Action<PropertyRowModel> propertyRowAction in PropertyRowActions)
		{
			orderedEnumerable.Each(propertyRowAction);
		}
		orderedEnumerable.Each(delegate(PropertyRowModel row)
		{
			row.RowDisplayActions.Each(delegate(Action<PropertyRowModel> a)
			{
				a(row);
			});
		});
		return from r in orderedEnumerable
			where r.Visible
			orderby r.Order
			select r;
	}

	[NotNull]
	public virtual PropertyRowModel GetPropertyRow(string propertyName)
	{
		if (!propertyRows.TryGetValue(propertyName, out var value))
		{
			RowDriver rowDriver = FormDriver.GetRowDrivers().FirstOrDefault((RowDriver rd) => rd.PropertyName == propertyName);
			if (rowDriver == null)
			{
				throw new ArgumentException(SR.T("Невозможно найти драйвер для свойства {0} модели {1}", propertyName, ModelType));
			}
			value = new PropertyRowModel(FormModel, rowDriver);
			PropertyMetadata metadata = rowDriver.GetMetadata();
			if (metadata != null)
			{
				int inheritLevel = GetInheritLevel(metadata.DeclaringType);
				value.Order = inheritLevel * 100 + metadata.Order;
				ViewAttribute forView = metadata.ViewSettings.GetForView(ViewType);
				if (forView != null)
				{
					value.Visible = forView.Visible;
					WebViewAttributes attributes = value.Attributes;
					WebViewAttributes captionAttributes = rowDriver.CaptionAttributes;
					WebViewAttributes valueAttributes = rowDriver.ValueAttributes;
					WebViewAttributes editorAttributes = rowDriver.EditorAttributes;
					bool? flag2 = (rowDriver.DescriptionAttributes.ReadOnly = forView.ReadOnly);
					bool? flag4 = (editorAttributes.ReadOnly = flag2);
					bool? flag6 = (valueAttributes.ReadOnly = flag4);
					bool? flag9 = (attributes.ReadOnly = (captionAttributes.ReadOnly = flag6));
					WebViewAttributes attributes2 = value.Attributes;
					WebViewAttributes captionAttributes2 = rowDriver.CaptionAttributes;
					WebViewAttributes valueAttributes2 = rowDriver.ValueAttributes;
					WebViewAttributes editorAttributes2 = rowDriver.EditorAttributes;
					bool flag11 = (rowDriver.DescriptionAttributes.Required = !forView.ReadOnly && metadata.Required);
					bool flag13 = (editorAttributes2.Required = flag11);
					bool flag15 = (valueAttributes2.Required = flag13);
					bool required = (captionAttributes2.Required = flag15);
					attributes2.Required = required;
				}
			}
			else
			{
				value.Order = ((!propertyRows.Any()) ? 1 : (propertyRows.Max((KeyValuePair<string, PropertyRowModel> p) => p.Value.Order) + 1));
			}
			propertyRows.Add(propertyName, value);
		}
		return value;
	}

	private int GetInheritLevel(Type type)
	{
		if ((!type.IsGenericType || !(type.GetGenericTypeDefinition() == typeof(Entity<>))) && !(type.BaseType == null))
		{
			return 1 + GetInheritLevel(type.BaseType);
		}
		return 0;
	}

	public virtual MvcHtmlString Render(HtmlHelper html)
	{
		string text = null;
		if (!string.IsNullOrWhiteSpace(HtmlInputPrefix))
		{
			text = html.get_ViewData().get_TemplateInfo().get_HtmlFieldPrefix();
			if (!string.IsNullOrWhiteSpace(text))
			{
				TemplateInfo templateInfo = html.get_ViewData().get_TemplateInfo();
				templateInfo.set_HtmlFieldPrefix(templateInfo.get_HtmlFieldPrefix() + "." + HtmlInputPrefix);
			}
			else
			{
				html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(HtmlInputPrefix);
			}
		}
		OnBeforeRender(html);
		MvcHtmlString result = ((LayoutTemplate != null) ? MvcHtmlString.Create(LayoutTemplate(this).ToString()) : ((Layout != null) ? Layout.RenderForm(html, this) : new DefaultFormLayout().RenderForm(html, this)));
		if (!string.IsNullOrWhiteSpace(HtmlInputPrefix))
		{
			html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(text);
		}
		return result;
	}
}
