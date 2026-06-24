using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models;

public class ObjectViewData : IDisposable
{
	private static class Fields
	{
		public static readonly string View = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.View));

		public static readonly string Inherit = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.Inherit));

		public static readonly string CustomView = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.CustomView));

		public static readonly string Padding = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.Padding));

		public static readonly string ViewType = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ViewType));

		public static readonly string ItemType = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ItemType));

		public static readonly string ReadOnly = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ReadOnly));

		public static readonly string ViewProviderUid = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ViewProviderUid));

		public static readonly string ViewItemId = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ViewItemId));

		public static readonly string DynamicFormsProviderUid = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.DynamicFormsProviderUid));

		public static readonly string DynamicFormsProviderData = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.DynamicFormsProviderData));

		public static readonly string ShowDescription = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.ShowDescription));

		public static readonly string RenderReadOnlyPropertyFiled = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.RenderReadOnlyPropertyFiled));

		public static readonly string FormId = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.FormId));

		public static readonly string DisableDynamicForm = LinqUtils.NameOf((Expression<Func<ObjectViewData, object>>)((ObjectViewData d) => d.DisableDynamicForm));
	}

	private ObjectViewData _oldData;

	private ViewDataDictionary _viewData;

	private HtmlHelper _html;

	private RootViewItem _view;

	private bool _inherit;

	private MvcHtmlString _customView;

	private int _padding;

	private ViewType _viewType;

	private ItemType _itemType;

	private bool _readOnly;

	private Guid _viewProviderUid;

	private string _viewItemId;

	private Guid _dynamicFormsProviderUid;

	private string _dynamicFormsProviderData;

	private bool _showDescription;

	private bool _renderReadOnlyPropertyFiled;

	private string _formId;

	private bool _disableDynamicForm;

	private bool ignoreOldData;

	public object Model { get; private set; }

	public Type ModelType { get; private set; }

	public ClassMetadata Metadata { get; private set; }

	public RootViewItem View
	{
		get
		{
			return _view;
		}
		set
		{
			_view = value;
			_viewData.set_Item(Fields.View, (object)value);
		}
	}

	public bool Inherit
	{
		get
		{
			return _inherit;
		}
		set
		{
			_inherit = value;
			_viewData.set_Item(Fields.Inherit, (object)value);
		}
	}

	public MvcHtmlString CustomView
	{
		get
		{
			return _customView;
		}
		set
		{
			_customView = value;
			_viewData.set_Item(Fields.CustomView, (object)value);
		}
	}

	public int Padding
	{
		get
		{
			return _padding;
		}
		set
		{
			_padding = value;
			_viewData.set_Item(Fields.Padding, (object)value);
		}
	}

	public ViewType ViewType
	{
		get
		{
			return _viewType;
		}
		set
		{
			_viewType = value;
			_viewData.set_Item(Fields.ViewType, (object)value);
		}
	}

	public ItemType ItemType
	{
		get
		{
			return _itemType;
		}
		set
		{
			_itemType = value;
			_viewData.set_Item(Fields.ItemType, (object)value);
		}
	}

	public bool ReadOnly
	{
		get
		{
			return _readOnly;
		}
		set
		{
			_readOnly = value;
			_viewData.set_Item(Fields.ReadOnly, (object)value);
		}
	}

	public Guid ViewProviderUid
	{
		get
		{
			return _viewProviderUid;
		}
		set
		{
			_viewProviderUid = value;
			_viewData.set_Item(Fields.ViewProviderUid, (object)value);
		}
	}

	public string ViewItemId
	{
		get
		{
			return _viewItemId;
		}
		set
		{
			_viewItemId = value;
			_viewData.set_Item(Fields.ViewItemId, (object)value);
		}
	}

	public Guid DynamicFormsProviderUid
	{
		get
		{
			return _dynamicFormsProviderUid;
		}
		set
		{
			_dynamicFormsProviderUid = value;
			_viewData.set_Item(Fields.DynamicFormsProviderUid, (object)value);
		}
	}

	public string DynamicFormsProviderData
	{
		get
		{
			return _dynamicFormsProviderData;
		}
		set
		{
			_dynamicFormsProviderData = value;
			_viewData.set_Item(Fields.DynamicFormsProviderData, (object)value);
		}
	}

	public bool ShowDescription
	{
		get
		{
			return _showDescription;
		}
		set
		{
			_showDescription = value;
			_viewData.set_Item(Fields.ShowDescription, (object)value);
		}
	}

	public bool RenderReadOnlyPropertyFiled
	{
		get
		{
			return _renderReadOnlyPropertyFiled;
		}
		set
		{
			_renderReadOnlyPropertyFiled = value;
			_viewData.set_Item(Fields.RenderReadOnlyPropertyFiled, (object)value);
		}
	}

	public string FormId
	{
		get
		{
			return _formId;
		}
		set
		{
			_formId = value;
			_viewData.set_Item(Fields.FormId, (object)value);
		}
	}

	public bool DisableDynamicForm
	{
		get
		{
			return _disableDynamicForm;
		}
		set
		{
			_disableDynamicForm = value;
			_viewData.set_Item(Fields.DisableDynamicForm, (object)value);
		}
	}

	public ObjectViewData(WebViewPage page)
		: this(page, initialize: true)
	{
	}

	public ObjectViewData(WebViewPage page, object model)
		: this((HtmlHelper)(object)page.get_Html(), page.get_ViewData(), model, initialize: true)
	{
		Contract.ArgumentNotNull(page, "page");
	}

	public ObjectViewData(WebViewPage page, bool initialize)
		: this((HtmlHelper)(object)page.get_Html(), page.get_ViewData(), page.get_Model(), initialize)
	{
		Contract.ArgumentNotNull(page, "page");
	}

	public ObjectViewData(WebViewPage page, object model, bool initialize)
		: this((HtmlHelper)(object)page.get_Html(), page.get_ViewData(), model, initialize)
	{
		Contract.ArgumentNotNull(page, "page");
	}

	public ObjectViewData(HtmlHelper html, ViewDataDictionary viewData, object model, bool initialize)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (viewData == null)
		{
			throw new ArgumentNullException("viewData");
		}
		_html = html;
		_viewData = viewData;
		if (!initialize)
		{
			ignoreOldData = true;
			return;
		}
		Model = model;
		ModelType = ((model != null) ? model.GetType() : viewData.get_ModelMetadata().get_ModelType());
		_inherit = Convert.ToBoolean(_viewData.get_Item(Fields.Inherit) ?? ((object)true));
		Metadata = ((ModelType != null) ? ((ClassMetadata)MetadataLoader.LoadMetadata(ModelType, Inherit, loadImplementation: false)) : null);
		_view = viewData.get_Item(Fields.View) as RootViewItem;
		_padding = ((viewData.get_Item(Fields.Padding) != null) ? Convert.ToInt32(viewData.get_Item(Fields.Padding)) : 0);
		_viewType = (viewData.ContainsKey(Fields.ViewType) ? ((ViewType)viewData.get_Item(Fields.ViewType)) : ViewType.Edit);
		_itemType = (viewData.ContainsKey(Fields.ItemType) ? ((ItemType)viewData.get_Item(Fields.ItemType)) : ItemType.Default);
		_readOnly = viewData.get_Item(Fields.ReadOnly) != null && (bool)viewData.get_Item(Fields.ReadOnly);
		_viewProviderUid = (viewData.ContainsKey(Fields.ViewProviderUid) ? ((Guid)viewData.get_Item(Fields.ViewProviderUid)) : Guid.Empty);
		_viewItemId = (viewData.ContainsKey(Fields.ViewItemId) ? ((string)viewData.get_Item(Fields.ViewItemId)) : null);
		_disableDynamicForm = viewData.get_Item(Fields.DisableDynamicForm) != null && Convert.ToBoolean(viewData.get_Item(Fields.DisableDynamicForm));
		_dynamicFormsProviderUid = (viewData.ContainsKey(Fields.DynamicFormsProviderUid) ? ((Guid)viewData.get_Item(Fields.DynamicFormsProviderUid)) : Guid.Empty);
		_dynamicFormsProviderData = (viewData.ContainsKey(Fields.DynamicFormsProviderData) ? ((string)viewData.get_Item(Fields.DynamicFormsProviderData)) : null);
		_showDescription = !viewData.ContainsKey(Fields.ShowDescription) || (bool)viewData.get_Item(Fields.ShowDescription);
		_renderReadOnlyPropertyFiled = viewData.ContainsKey(Fields.RenderReadOnlyPropertyFiled) && (bool)viewData.get_Item(Fields.RenderReadOnlyPropertyFiled);
		_formId = (viewData.ContainsKey(Fields.FormId) ? ((string)viewData.get_Item(Fields.FormId)) : null);
		_customView = null;
		_oldData = GetCurrent();
		ContextVars.Set(typeof(ObjectViewData).FullName, this);
	}

	public void InitializeCustomView()
	{
		if (Metadata is EntityMetadata)
		{
			EntityModel<IEntity> entityModel = new EntityModel<IEntity>((IEntity)Model);
			bool num = entityModel.HasCustomFormViews(ViewType, false);
			FormView customFormView = entityModel.GetCustomFormView(ViewType, false);
			if (num && customFormView.UseRazorView)
			{
				_customView = PartialExtensions.Partial(_html, customFormView.RazorCommonViewName, (object)entityModel.Entity);
			}
		}
	}

	public void Dispose()
	{
		if (!ignoreOldData)
		{
			ContextVars.Set(typeof(ObjectViewData).FullName, _oldData);
			_oldData = null;
		}
	}

	public static ObjectViewData GetCurrent()
	{
		return ContextVars.GetOrDefault<ObjectViewData>(typeof(ObjectViewData).FullName);
	}
}
