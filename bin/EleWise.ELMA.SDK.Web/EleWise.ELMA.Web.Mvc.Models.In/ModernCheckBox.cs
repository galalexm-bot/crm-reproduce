using System.Web.Mvc;
using System.Web.UI;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernCheckBox : ModernCheckBoxBase
{
	public override object Value
	{
		get
		{
			return base.Value;
		}
		set
		{
			base.Value = value;
		}
	}

	public virtual bool RenderUncheckedInput { get; set; }

	public virtual object UncheckedValue { get; set; }

	protected override InputType InputType => (InputType)0;

	protected override string DefaultIdPrefix => "cb_";

	protected override string DefaultValue => "true";

	public ModernCheckBox()
	{
		Value = "true";
		UncheckedValue = "false";
	}

	protected override void RenderContent(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		base.RenderMainInput(htmlHelper, writer);
		RenderIcon(htmlHelper, writer);
		base.RenderLabel(htmlHelper, writer);
		if (RenderUncheckedInput && !string.IsNullOrEmpty(Name))
		{
			TagBuilder val = new TagBuilder("input");
			val.MergeAttribute("type", HtmlHelper.GetInputTypeString((InputType)1));
			val.MergeAttribute("name", Name);
			val.MergeAttribute("value", (UncheckedValue != null) ? UncheckedValue.ToString() : "false");
			writer.Write(val.ToString((TagRenderMode)3));
		}
	}

	protected override void RenderIcon(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		writer.Write(htmlHelper.SvgImage("#checkbox.svg", new
		{
			@class = "checkboxbase-icon"
		}));
	}
}
