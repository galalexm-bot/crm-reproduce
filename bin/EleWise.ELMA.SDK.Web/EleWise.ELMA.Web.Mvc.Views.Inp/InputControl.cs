using System.Web.Mvc;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Views.Inputs;

public abstract class InputControl<TModel> : BaseViewPage<TModel>
{
	private HtmlAttributes htmlAttributes;

	private ViewAttributes viewAttributes;

	protected HtmlAttributes HtmlAttributes
	{
		get
		{
			if (htmlAttributes == null)
			{
				htmlAttributes = ((WebViewPage<TModel>)this).get_ViewData().HtmlAttributes<TModel>();
				if (htmlAttributes == null)
				{
					htmlAttributes = new HtmlAttributes();
				}
			}
			return htmlAttributes;
		}
	}

	protected ViewAttributes ViewAttributes
	{
		get
		{
			if (viewAttributes == null)
			{
				viewAttributes = ((WebViewPage<TModel>)this).get_ViewData().ViewAttributes<TModel>();
				if (viewAttributes == null)
				{
					viewAttributes = new ViewAttributes();
				}
			}
			return viewAttributes;
		}
	}

	protected bool IsFilterProperty => ((ViewDataDictionary)((WebViewPage<TModel>)this).get_ViewData()).get_ModelMetadata().GetContainerObject() is IEntityFilter;

	protected override void SetViewData(ViewDataDictionary viewData)
	{
		((WebViewPage<TModel>)this).SetViewData(viewData);
		ViewAttributes viewAttributes = ((WebViewPage<TModel>)this).get_ViewData().ViewAttributes<TModel>();
		if (viewAttributes != null && !string.IsNullOrEmpty(viewAttributes.Prefix))
		{
			viewData.get_TemplateInfo().set_HtmlFieldPrefix($"{viewAttributes.Prefix}.{viewData.get_TemplateInfo().get_HtmlFieldPrefix()}");
		}
	}
}
public abstract class InputControl<TModel, TSettings> : InputControl<TModel> where TSettings : TypeSettings, new()
{
	private TSettings _settings;

	protected TSettings Settings
	{
		get
		{
			TSettings val = _settings;
			if (val == null)
			{
				TSettings obj = ((TSettings)((WebViewPage<TModel>)this).get_ViewData().TypeSettings<TModel>()) ?? new TSettings();
				TSettings val2 = obj;
				_settings = obj;
				val = val2;
			}
			return val;
		}
	}
}
