using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class RowDriver : IRowDriver
{
	protected string propertyName;

	private WebViewAttributes _captionAttributes;

	private WebViewAttributes _valueAttributes;

	private WebViewAttributes _editorAttributes;

	private WebViewAttributes _descriptionAttributes;

	public virtual string PropertyName
	{
		get
		{
			return propertyName;
		}
		set
		{
			propertyName = value;
		}
	}

	protected Type ModelType { get; set; }

	public Func<HtmlHelper, object, bool, MvcHtmlString> RenderCaption { get; set; }

	public Func<HtmlHelper, object, MvcHtmlString> RenderValue { get; set; }

	public Func<HtmlHelper, object, MvcHtmlString> RenderEditor { get; set; }

	public Func<HtmlHelper, object, MvcHtmlString> RenderDescription { get; set; }

	public WebViewAttributes CaptionAttributes
	{
		get
		{
			if (_captionAttributes == null)
			{
				_captionAttributes = new WebViewAttributes();
			}
			return _captionAttributes;
		}
		set
		{
			_captionAttributes = value;
		}
	}

	public WebViewAttributes ValueAttributes
	{
		get
		{
			if (_valueAttributes == null)
			{
				_valueAttributes = new WebViewAttributes();
			}
			return _valueAttributes;
		}
		set
		{
			_valueAttributes = value;
		}
	}

	public WebViewAttributes EditorAttributes
	{
		get
		{
			if (_editorAttributes == null)
			{
				_editorAttributes = new WebViewAttributes();
			}
			return _editorAttributes;
		}
		set
		{
			_editorAttributes = value;
		}
	}

	public WebViewAttributes DescriptionAttributes
	{
		get
		{
			if (_descriptionAttributes == null)
			{
				_descriptionAttributes = new WebViewAttributes();
			}
			return _descriptionAttributes;
		}
		set
		{
			_descriptionAttributes = value;
		}
	}

	protected RowDriver()
	{
	}

	public RowDriver(Type modelType, string propertyName)
		: this()
	{
		ModelType = modelType;
		this.propertyName = propertyName;
		RenderCaption = (HtmlHelper helper, object model, bool forDisplay) => helper.Caption(PropertyName, delegate(WebViewAttributes a)
		{
			if (_captionAttributes != null)
			{
				a.CopyFrom(_captionAttributes);
			}
		}, forDisplay);
		RenderValue = (HtmlHelper helper, object model) => helper.EditorOrDisplay(PropertyName, delegate(WebViewAttributes a)
		{
			a.ReadOnly = true;
			if (_valueAttributes != null)
			{
				a.CopyFrom(_valueAttributes);
			}
		});
		RenderEditor = (HtmlHelper helper, object model) => helper.EditorOrDisplay(PropertyName, delegate(WebViewAttributes a)
		{
			a.ReadOnly = false;
			if (_editorAttributes != null)
			{
				a.CopyFrom(_editorAttributes);
			}
		});
		RenderDescription = (HtmlHelper helper, object model) => (_descriptionAttributes == null || !_descriptionAttributes.ShowDescription) ? null : helper.Description(PropertyName, delegate(WebViewAttributes a)
		{
			if (_descriptionAttributes != null)
			{
				a.CopyFrom(_descriptionAttributes);
			}
		});
	}

	public virtual MvcHtmlString Caption(HtmlHelper html, object model, bool forDisplay)
	{
		if (RenderCaption == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderCaption(html, model, forDisplay);
	}

	public virtual MvcHtmlString Value(HtmlHelper html, object model)
	{
		if (RenderValue == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderValue(html, model);
	}

	public virtual MvcHtmlString Editor(HtmlHelper html, object model)
	{
		if (RenderEditor == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderEditor(html, model);
	}

	public virtual MvcHtmlString Description(HtmlHelper html, object model)
	{
		if (RenderDescription == null)
		{
			return MvcHtmlString.Empty;
		}
		return RenderDescription(html, model);
	}

	public virtual PropertyMetadata GetMetadata()
	{
		if (MetadataLoader.LoadMetadata(ModelType) is ClassMetadata classMetadata)
		{
			return classMetadata.Properties.FirstOrDefault((PropertyMetadata m) => m.Name == PropertyName);
		}
		return null;
	}

	public virtual PropertyInfo GetPropertyInfo()
	{
		return ModelType.GetReflectionProperty(PropertyName);
	}
}
