using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.Web.Mvc.Html.FilterSearchForm;

public class FilterSearchFormBuilder<T> : IHtmlString
{
	public class ExpandButtonModel
	{
		public string ExpandText { get; set; }

		public string CollapseText { get; set; }

		public string OnClick { get; set; }

		public bool Collapsed { get; set; }

		public HtmlAttributes ContainerAttributes { get; private set; }

		public HtmlAttributes ExpandButtonAttributes { get; private set; }

		public HtmlAttributes CollapseButtonAttributes { get; private set; }

		public ExpandButtonModel()
		{
			OnClick = "toogleCustomSearch(false, this)";
			ContainerAttributes = new HtmlAttributes();
			ExpandButtonAttributes = new HtmlAttributes();
			ExpandButtonAttributes["id"] = "csOpen";
			CollapseButtonAttributes = new HtmlAttributes();
			CollapseButtonAttributes["id"] = "csClose";
			Collapsed = true;
		}

		public string ToHtmlString(HtmlHelper html)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			StringBuilder stringBuilder = new StringBuilder();
			TagBuilder val = new TagBuilder("div");
			val.MergeAttributes<string, object>((IDictionary<string, object>)ContainerAttributes);
			val.AddCssClass("expand-button");
			if (!string.IsNullOrEmpty(OnClick))
			{
				val.get_Attributes()["onclick"] = OnClick;
			}
			stringBuilder.Append(val.ToString((TagRenderMode)1));
			TagBuilder val2 = new TagBuilder("div");
			val2.AddCssClass("expand-button-content");
			stringBuilder.Append(val2.ToString((TagRenderMode)1));
			if (!Collapsed)
			{
				ExpandButtonAttributes.style["display"] = "none";
			}
			stringBuilder.Append(((HtmlString)(object)html.LinkButton(new LinkButton
			{
				Text = ((!string.IsNullOrEmpty(ExpandText)) ? ExpandText : SR.T("Расширенный поиск")),
				Href = "javascript:void(0)",
				Attributes = ExpandButtonAttributes
			})).ToHtmlString());
			if (Collapsed)
			{
				CollapseButtonAttributes.style["display"] = "none";
			}
			stringBuilder.Append(((HtmlString)(object)html.LinkButton(new LinkButton
			{
				Text = ((!string.IsNullOrEmpty(CollapseText)) ? CollapseText : SR.T("Скрыть поля поиска")),
				Href = "javascript:void(0)",
				Attributes = CollapseButtonAttributes
			})).ToHtmlString());
			stringBuilder.Append(val2.ToString((TagRenderMode)2));
			stringBuilder.Append(val.ToString((TagRenderMode)2));
			return stringBuilder.ToString();
		}
	}

	public class ExpandButtonBuilder : IHtmlString
	{
		protected HtmlHelper Html { get; private set; }

		protected ExpandButtonModel Component { get; private set; }

		public ExpandButtonBuilder(HtmlHelper html, ExpandButtonModel component)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			Html = html;
			Component = component;
		}

		public ExpandButtonBuilder ExpandText(string text)
		{
			Component.ExpandText = text;
			return this;
		}

		public ExpandButtonBuilder CollapseText(string text)
		{
			Component.CollapseText = text;
			return this;
		}

		public ExpandButtonBuilder OnClick(string onClick)
		{
			Component.OnClick = onClick;
			return this;
		}

		public ExpandButtonBuilder Collapsed(bool collapsed)
		{
			Component.Collapsed = collapsed;
			return this;
		}

		public ExpandButtonBuilder ContainerAttributes(Action<HtmlAttributes> attrAction)
		{
			attrAction?.Invoke(Component.ContainerAttributes);
			return this;
		}

		public ExpandButtonBuilder ExpandButtonAttributes(Action<HtmlAttributes> attrAction)
		{
			attrAction?.Invoke(Component.ExpandButtonAttributes);
			return this;
		}

		public ExpandButtonBuilder CollapseButtonAttributes(Action<HtmlAttributes> attrAction)
		{
			attrAction?.Invoke(Component.CollapseButtonAttributes);
			return this;
		}

		public override string ToString()
		{
			return ToHtmlString();
		}

		public string ToHtmlString()
		{
			return Component.ToHtmlString(Html);
		}
	}

	public class FastSearchBoxModel
	{
		private HtmlHelper<T> htmlHelper;

		public Expression<Func<T, string>> PropertyAccessor { get; set; }

		public string PropertyName { get; set; }

		public string Placeholder
		{
			get
			{
				if (!Attributes.Html.ContainsKey("placeholder"))
				{
					return null;
				}
				return (string)Attributes.Html["placeholder"];
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					Attributes.Html["placeholder"] = value;
				}
				else if (Attributes.Html.ContainsKey("placeholder"))
				{
					Attributes.Html.Remove("placeholder");
				}
			}
		}

		public bool Enabled { get; set; }

		public string DisabledText { get; set; }

		public WebViewAttributes Attributes { get; private set; }

		public bool ShowExpandButton { get; set; }

		public string ExpandButtonOnClick { get; set; }

		public bool ShortSearch { get; set; }

		public Func<object, object> CustomContent { get; set; }

		public List<IFastSearchActionButton> ActionButtons { get; set; }

		public FastSearchBoxModel()
		{
			Attributes = new WebViewAttributes();
			Attributes.Html.@class = "input-large";
			Placeholder = SR.T("Что ищем?");
			Enabled = true;
			DisabledText = SR.T("Нет полей, участвующих в быстром поиске");
			ActionButtons = new List<IFastSearchActionButton>();
			ShortSearch = false;
		}

		public string ToHtmlString(HtmlHelper<T> html)
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			htmlHelper = html;
			if (Enabled)
			{
				string input = string.Empty;
				if (PropertyAccessor != null)
				{
					input = ((HtmlString)(object)html.Editor(PropertyAccessor, delegate(WebViewAttributes a)
					{
						a.CopyFrom(Attributes);
						a.Html.Add("autocomplete", "off");
					})).ToHtmlString();
				}
				else if (!string.IsNullOrEmpty(PropertyName))
				{
					input = ((HtmlString)(object)((HtmlHelper)(object)html).Editor(PropertyName, delegate(WebViewAttributes a)
					{
						a.CopyFrom(Attributes);
						a.Html.Add("autocomplete", "off");
					})).ToHtmlString();
				}
				return CreateContainer(input);
			}
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("text-box");
			val.AddCssClass("input-large");
			TagBuilder val2 = new TagBuilder("input");
			val2.get_Attributes()["type"] = "text";
			val2.get_Attributes()["autocomplete"] = "off";
			val2.AddCssClass("text-box");
			if (!string.IsNullOrEmpty(DisabledText))
			{
				val2.get_Attributes()["value"] = ((HtmlHelper)html).Encode(DisabledText);
			}
			val2.get_Attributes()["style"] = "width: 100%;z-index: 15;";
			val2.get_Attributes()["disabled"] = "disabled";
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(val.ToString((TagRenderMode)1));
			stringBuilder.Append(val2.ToString((TagRenderMode)3));
			stringBuilder.Append(val.ToString((TagRenderMode)2));
			return CreateContainer(stringBuilder.ToString());
		}

		private string CreateContainer(string input)
		{
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			if (ShowExpandButton)
			{
				FastSearchActionButton fastSearchActionButton = new FastSearchActionButton
				{
					CssClass = "expand-search",
					Icon = "#more_points.svg",
					Index = 100L
				};
				if (!string.IsNullOrWhiteSpace(ExpandButtonOnClick))
				{
					fastSearchActionButton.OnClick = ExpandButtonOnClick;
				}
				else
				{
					object obj = ((ViewDataDictionary)htmlHelper.get_ViewData()).get_Item("filterGridId");
					string arg = ((obj != null) ? obj.ToString().Replace("-", "m") : "");
					fastSearchActionButton.OnClick = $"toogleCustomSearch{arg}(false, this)";
				}
				ActionButtons.Add(fastSearchActionButton);
			}
			StringBuilder stringBuilder = new StringBuilder();
			TagBuilder val = new TagBuilder("input");
			val.AddCssClass("t-button hidden-submit-button");
			val.get_Attributes()["type"] = "submit";
			stringBuilder.Append(val.ToString((TagRenderMode)3));
			TagBuilder val2 = new TagBuilder("div");
			val2.get_Attributes()["autofocus"] = "false";
			val2.AddCssClass("custom-fastSearch-container GroupControlsContainer");
			stringBuilder.Append(val2.ToString((TagRenderMode)1));
			TagBuilder val3 = new TagBuilder("div");
			if (ShowExpandButton || ShortSearch)
			{
				val3.AddCssClass("t-search-picker-wrap");
				val3.get_Attributes()["id"] = "FastSearchPickerWrap";
			}
			stringBuilder.Append(val3.ToString((TagRenderMode)1));
			stringBuilder.Append(input);
			AppendToolbarActions(stringBuilder);
			stringBuilder.Append(val3.ToString((TagRenderMode)2));
			if (CustomContent != null)
			{
				object obj2 = CustomContent(this);
				if (obj2 != null)
				{
					TagBuilder val4 = new TagBuilder("div");
					val4.AddCssClass("custom-fastSearch");
					stringBuilder.Append(val4.ToString((TagRenderMode)1));
					TagBuilder val5 = new TagBuilder("div");
					val5.AddCssClass("custom-fastSearch-content");
					stringBuilder.Append(val5.ToString((TagRenderMode)1));
					stringBuilder.Append(obj2);
					stringBuilder.Append(val5.ToString((TagRenderMode)2));
					stringBuilder.Append(val4.ToString((TagRenderMode)2));
				}
			}
			stringBuilder.Append(val2.ToString((TagRenderMode)2));
			TagBuilder val6 = new TagBuilder("div");
			val6.AddCssClass("fastSearch");
			val6.set_InnerHtml(stringBuilder.ToString());
			return val6.ToString((TagRenderMode)0);
		}

		private void AppendToolbarActions(StringBuilder builder)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (ActionButtons.Count == 0)
			{
				return;
			}
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("t-select-actions");
			builder.Append(val.ToString((TagRenderMode)1));
			foreach (IFastSearchActionButton item in ActionButtons.OrderBy((IFastSearchActionButton a) => a.Index))
			{
				builder.Append(CreateAction(item));
			}
			builder.Append(val.ToString((TagRenderMode)2));
		}

		private string CreateAction(IFastSearchActionButton item)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			TagBuilder val = new TagBuilder("div");
			val.AddCssClass("t-select groupControlsExclude");
			if (item.Style != null && !string.IsNullOrWhiteSpace(item.Style.width))
			{
				val.get_Attributes()["style"] = "width:" + item.Style.width;
			}
			if (!string.IsNullOrWhiteSpace(item.CssClass))
			{
				val.AddCssClass(item.CssClass);
			}
			if (!string.IsNullOrWhiteSpace(item.OnClick))
			{
				val.get_Attributes()["onclick"] = item.OnClick;
			}
			val.set_InnerHtml(string.Concat((!string.IsNullOrWhiteSpace(item.Icon)) ? ((HtmlHelper)(object)htmlHelper).Image(item.Icon, "") : MvcHtmlString.Empty, item.Content));
			return val.ToString((TagRenderMode)0);
		}
	}

	public class FastSearchBoxBuilder : IHtmlString
	{
		protected HtmlHelper<T> Html { get; private set; }

		protected FastSearchBoxModel Component { get; private set; }

		public FastSearchBoxBuilder(HtmlHelper<T> html, FastSearchBoxModel component)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			Html = html;
			Component = component;
		}

		public FastSearchBoxBuilder Placeholder(string text)
		{
			Component.Placeholder = text;
			return this;
		}

		public FastSearchBoxBuilder Enabled(bool enabled)
		{
			Component.Enabled = enabled;
			return this;
		}

		public FastSearchBoxBuilder DisabledText(string text)
		{
			Component.DisabledText = text;
			return this;
		}

		public FastSearchBoxBuilder Attributes(Action<WebViewAttributes> attributesAction)
		{
			attributesAction?.Invoke(Component.Attributes);
			return this;
		}

		public FastSearchBoxBuilder ShowExpandButton(bool showExpandButton)
		{
			Component.ShowExpandButton = showExpandButton;
			return this;
		}

		public FastSearchBoxBuilder ExpandButtonOnClick(string expandButtonOnClick)
		{
			Component.ExpandButtonOnClick = expandButtonOnClick;
			return this;
		}

		public FastSearchBoxBuilder Custom(Func<object, object> content)
		{
			Component.CustomContent = content;
			return this;
		}

		public FastSearchBoxBuilder IsShortSearch(bool shortSearch)
		{
			Component.ShortSearch = shortSearch;
			return this;
		}

		public FastSearchBoxBuilder ActionButtons(Action<FastSearchActionButtonBuilder> items)
		{
			items(new FastSearchActionButtonBuilder(Component));
			return this;
		}

		public override string ToString()
		{
			return ToHtmlString();
		}

		public string ToHtmlString()
		{
			return Component.ToHtmlString(Html);
		}
	}

	public class FastSearchButtonModel : IFastSearchButtonModel
	{
		public string Text { get; set; }

		public bool Enabled { get; set; }

		public HtmlAttributes HtmlAttributes { get; private set; }

		public FastSearchButtonModel()
		{
			HtmlAttributes = new HtmlAttributes();
			Text = SR.T("Найти");
			Enabled = true;
		}

		public string ToHtmlString(HtmlHelper html)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			TagBuilder val = new TagBuilder("input");
			val.MergeAttributes<string, object>((IDictionary<string, object>)HtmlAttributes);
			val.get_Attributes()["type"] = "submit";
			val.AddCssClass("confirm");
			val.AddCssClass("quick-search-button");
			if (!string.IsNullOrEmpty(Text))
			{
				val.get_Attributes()["value"] = Text;
			}
			if (!Enabled)
			{
				val.get_Attributes()["disabled"] = "disabled";
			}
			return val.ToString((TagRenderMode)3);
		}
	}

	public class FastSearchButtonBuilder : IHtmlString
	{
		protected HtmlHelper Html { get; private set; }

		protected IFastSearchButtonModel Component { get; private set; }

		public FastSearchButtonBuilder(HtmlHelper html, IFastSearchButtonModel component)
		{
			if (html == null)
			{
				throw new ArgumentNullException("html");
			}
			if (component == null)
			{
				throw new ArgumentNullException("component");
			}
			Html = html;
			Component = component;
		}

		public FastSearchButtonBuilder Text(string text)
		{
			Component.Text = text;
			return this;
		}

		public FastSearchButtonBuilder Enabled(bool enabled)
		{
			Component.Enabled = enabled;
			return this;
		}

		public FastSearchButtonBuilder HtmlAttributes(Action<HtmlAttributes> attributesAction)
		{
			attributesAction?.Invoke(Component.HtmlAttributes);
			return this;
		}

		public override string ToString()
		{
			return ToHtmlString();
		}

		public string ToHtmlString()
		{
			return Component.ToHtmlString(Html);
		}
	}

	public class FastSearchResetButtonModel : IFastSearchButtonModel
	{
		public string Text { get; set; }

		public bool Enabled { get; set; }

		public HtmlAttributes HtmlAttributes { get; private set; }

		public FastSearchResetButtonModel()
		{
			HtmlAttributes = new HtmlAttributes();
			Text = SR.T("Сбросить");
			Enabled = true;
		}

		public string ToHtmlString(HtmlHelper html)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			TagBuilder val = new TagBuilder("input");
			val.get_Attributes()["type"] = "reset";
			val.AddCssClass("t-button");
			val.AddCssClass("quick-reset-button");
			if (!string.IsNullOrEmpty(Text))
			{
				val.get_Attributes()["value"] = Text;
			}
			if (!Enabled)
			{
				val.get_Attributes()["disabled"] = "disabled";
			}
			val.MergeAttributes<string, object>((IDictionary<string, object>)HtmlAttributes);
			return val.ToString((TagRenderMode)3);
		}
	}

	public class FastSearchActionButtonBuilder
	{
		protected FastSearchBoxModel Parent { get; set; }

		public FastSearchActionButtonBuilder(FastSearchBoxModel parent)
		{
			Parent = parent;
		}

		public void Add([NotNull] IFastSearchActionButton item)
		{
			Parent.ActionButtons.Add(item);
		}
	}

	protected HtmlHelper<T> Html { get; private set; }

	public FilterSearchFormBuilder(HtmlHelper<T> html)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		Html = html;
	}

	public override string ToString()
	{
		return ToHtmlString();
	}

	public string ToHtmlString()
	{
		return string.Empty;
	}

	public FastSearchBoxBuilder FastSearchBoxFor(Expression<Func<T, string>> propertyAccessor)
	{
		return new FastSearchBoxBuilder(Html, new FastSearchBoxModel
		{
			PropertyAccessor = propertyAccessor
		});
	}

	public FastSearchBoxBuilder FastSearchBoxFor(string propertyName)
	{
		return new FastSearchBoxBuilder(Html, new FastSearchBoxModel
		{
			PropertyName = propertyName
		});
	}

	public FastSearchButtonBuilder FastSearchButton()
	{
		return new FastSearchButtonBuilder((HtmlHelper)(object)Html, new FastSearchButtonModel());
	}

	public FastSearchButtonBuilder FastSearchResetButton()
	{
		return new FastSearchButtonBuilder((HtmlHelper)(object)Html, new FastSearchResetButtonModel());
	}

	public ExpandButtonBuilder ExpandButton()
	{
		return new ExpandButtonBuilder((HtmlHelper)(object)Html, new ExpandButtonModel());
	}
}
