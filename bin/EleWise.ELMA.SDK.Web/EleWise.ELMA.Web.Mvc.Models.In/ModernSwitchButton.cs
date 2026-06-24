using System.Web.Mvc;
using System.Web.UI;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernSwitchButton : ModernCheckBox
{
	public enum LabelPosition
	{
		Left,
		Right
	}

	protected override string ContainerCssClass => "switch-label input-label";

	public virtual LabelPosition TextPosition { get; set; }

	protected override string DefaultIdPrefix => "switch_";

	public ModernSwitchButton()
	{
		TextPosition = LabelPosition.Right;
	}

	protected override void RenderContent(HtmlHelper htmlHelper, HtmlTextWriter writer)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		val.MergeAttribute("class", "spot");
		TagBuilder val2 = new TagBuilder("div");
		val2.MergeAttribute("class", "layer");
		TagBuilder val3 = new TagBuilder("div");
		val3.MergeAttribute("class", "sb-container");
		switch (TextPosition)
		{
		case LabelPosition.Left:
			val3.AddCssClass("text-on-left");
			break;
		case LabelPosition.Right:
			val3.AddCssClass("text-on-right");
			break;
		}
		if (TextPosition == LabelPosition.Left)
		{
			base.RenderLabel(htmlHelper, writer);
		}
		writer.Write(val3.ToString((TagRenderMode)1));
		base.RenderMainInput(htmlHelper, writer);
		writer.Write(val.ToString((TagRenderMode)1));
		writer.Write(val.ToString((TagRenderMode)2));
		writer.Write(val2.ToString((TagRenderMode)1));
		writer.Write(val2.ToString((TagRenderMode)2));
		writer.Write(val3.ToString((TagRenderMode)2));
		if (TextPosition == LabelPosition.Right)
		{
			base.RenderLabel(htmlHelper, writer);
		}
		if (RenderUncheckedInput && !string.IsNullOrEmpty(Name))
		{
			TagBuilder val4 = new TagBuilder("input");
			val4.MergeAttribute("type", HtmlHelper.GetInputTypeString((InputType)1));
			val4.MergeAttribute("name", Name);
			val4.MergeAttribute("value", (UncheckedValue != null) ? UncheckedValue.ToString() : "false");
			writer.Write(val4.ToString((TagRenderMode)3));
		}
	}
}
