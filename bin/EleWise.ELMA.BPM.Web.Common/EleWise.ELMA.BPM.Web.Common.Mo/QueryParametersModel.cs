using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers.EQL;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public sealed class QueryParametersModel
{
	private sealed class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }

		public ViewDataContainer(ViewDataDictionary viewData)
		{
			ViewData = viewData;
		}
	}

	private sealed class PropertyMetadata : IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
	{
		public string DisplayName { get; set; }

		public Guid TypeUid { get; set; }

		public Guid SubTypeUid { get; set; }

		public TypeSettings Settings { get; set; }

		public bool Required
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		public string OnChangeScriptName
		{
			get
			{
				return string.Empty;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Type DeclaringType
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Guid PropertyUid
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<MetadataImage> Images
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int Order
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Guid Uid
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Guid ModuleUid
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool Internal
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public void AfterLoad()
		{
			throw new NotImplementedException();
		}

		public void InitNew()
		{
			throw new NotImplementedException();
		}
	}

	internal const string ParameterNamePostfix = "__ParameterName";

	internal const string ParameterTypePostfix = "__ParameterType";

	private readonly ParsedQueryParameters queryParameters;

	private readonly IDictionary<string, string> parameterPrefixes;

	public ICollection<string> ParameterNames => queryParameters.ParameterNames;

	public QueryParametersModel(FilterModel filterModel)
	{
		EntityMetadata metadata = (EntityMetadata)MetadataLoader.LoadMetadata(filterModel.FilterTypeUid);
		queryParameters = EQLHelper.ParseEqlParameters(filterModel.Filter.Query, metadata).FillValues(filterModel.Filter.QueryParameters);
		parameterPrefixes = queryParameters.ParameterNames.Select((string n, int i) => (n, i)).ToDictionary<(string, int), string, string>(((string n, int i) p) => p.n, ((string n, int i) p) => $"Filter.QueryParameters[{p.i}]");
	}

	public MvcHtmlString EditableProperty(HtmlHelper<QueryParametersModel> html, string parameterName)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		try
		{
			object model = queryParameters[parameterName];
			ViewDataDictionary val = new ViewDataDictionary(model);
			TemplateInfo val2 = new TemplateInfo();
			val2.set_HtmlFieldPrefix(((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldName(parameterPrefixes[parameterName]));
			val.set_TemplateInfo(val2);
			val.set_ModelMetadata(ModelMetadataProviders.get_Current().GetMetadataForType((Func<object>)(() => model), queryParameters.GetType(parameterName)));
			ViewDataDictionary val3 = val;
			val3.get_ModelMetadata().SetPropertyMetadata(new PropertyMetadata
			{
				DisplayName = parameterName,
				TypeUid = queryParameters.GetTypeUid(parameterName),
				SubTypeUid = queryParameters.GetSubTypeUid(parameterName),
				Settings = queryParameters.GetTypeSettings(parameterName)
			});
			return ModelExtensions.EditableProperty(new HtmlHelper(new ViewContext((ControllerContext)(object)((HtmlHelper)html).get_ViewContext(), ((HtmlHelper)html).get_ViewContext().get_View(), val3, ((HtmlHelper)html).get_ViewContext().get_TempData(), ((HtmlHelper)html).get_ViewContext().get_Writer()), (IViewDataContainer)(object)new ViewDataContainer(val3)), "", delegate(WebViewAttributes a)
			{
				a.Required = true;
			});
		}
		catch (Exception ex)
		{
			Logger.Log.Error("Error render property", ex);
			return PartialExtensions.Partial((HtmlHelper)(object)html, "Filter/QueryParameterError", (object)new QueryParameterErrorModel(parameterName, ex.Message));
		}
	}

	public MvcHtmlString RenderParameterTypes(HtmlHelper html)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string parameterName in ParameterNames)
		{
			string text = parameterPrefixes[parameterName];
			stringBuilder.AppendLine(((HtmlString)(object)InputExtensions.Hidden(html, text + "__ParameterName", (object)parameterName)).ToHtmlString());
			stringBuilder.AppendLine(((HtmlString)(object)InputExtensions.Hidden(html, text + "__ParameterType", (object)queryParameters.GetType(parameterName).AssemblyQualifiedName)).ToHtmlString());
		}
		return new MvcHtmlString(stringBuilder.ToString());
	}
}
