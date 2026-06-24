using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Boxes;

namespace EleWise.ELMA.Web.Mvc.Html.Boxes;

public class MessageBoxBuilder
{
	protected MessageBox messageBox;

	protected HtmlHelper html;

	public MessageBoxBuilder(HtmlHelper html, MessageBox messageBox)
	{
		this.html = html;
		this.messageBox = messageBox;
	}

	public MessageBoxBuilder Dialog(string message, string header, MessageBoxType messageBoxType = EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.NONE, ButtonsType buttons = EleWise.ELMA.Web.Mvc.Models.Boxes.ButtonsType.OK)
	{
		Message(message);
		Header(header);
		MessageBoxType(messageBoxType);
		ButtonsType(buttons);
		return this;
	}

	public MessageBoxBuilder Header(string header)
	{
		messageBox.Header = header;
		return this;
	}

	public MessageBoxBuilder Message(string message)
	{
		messageBox.Message = message;
		return this;
	}

	public MessageBoxBuilder ButtonsType(ButtonsType buttons)
	{
		messageBox.ButtonsType = buttons;
		return this;
	}

	public MessageBoxBuilder MessageBoxType(MessageBoxType messageBoxType)
	{
		messageBox.MessageBoxType = messageBoxType;
		return this;
	}

	public MessageBoxBuilder Ok(string text)
	{
		messageBox.Buttons["ok"] = text;
		return this;
	}

	public MessageBoxBuilder Cancel(string text)
	{
		messageBox.Buttons["cancel"] = text;
		return this;
	}

	public MessageBoxBuilder Yes(string text)
	{
		messageBox.Buttons["yes"] = text;
		return this;
	}

	public MessageBoxBuilder No(string text)
	{
		messageBox.Buttons["no"] = text;
		return this;
	}

	public MessageBoxBuilder Error(string message, string header = "")
	{
		return Dialog(message, header, EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.ERROR);
	}

	public MessageBoxBuilder Info(string message, string header = "", ButtonsType buttons = EleWise.ELMA.Web.Mvc.Models.Boxes.ButtonsType.OK)
	{
		return Dialog(message, header, EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.INFORMATIONAL, buttons);
	}

	public MessageBoxBuilder Question(string message, string header = "", ButtonsType buttons = EleWise.ELMA.Web.Mvc.Models.Boxes.ButtonsType.YESNO)
	{
		return Dialog(message, header, EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.QUESTION, buttons);
	}

	public MessageBoxBuilder Warning(string message, string header = "", ButtonsType buttons = EleWise.ELMA.Web.Mvc.Models.Boxes.ButtonsType.OK)
	{
		return Dialog(message, header, EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.WARNING, buttons);
	}

	public MessageBoxBuilder OkHandler(string script)
	{
		messageBox.OkHandler = script;
		return this;
	}

	public MessageBoxBuilder CancelHandler(string script)
	{
		messageBox.CancelHandler = script;
		return this;
	}

	public MessageBoxBuilder YesHandler(string script)
	{
		messageBox.YesHandler = script;
		return this;
	}

	public MessageBoxBuilder NoHandler(string script)
	{
		messageBox.NoHandler = script;
		return this;
	}

	public MvcHtmlString Script(bool renderScriptTag = true)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		HtmlHelper obj = html;
		MessageBox obj2 = messageBox;
		ViewDataDictionary val = new ViewDataDictionary();
		val.Add("renderScriptTag", (object)renderScriptTag);
		return PartialExtensions.Partial(obj, "UI/Box/MessageBox", (object)obj2, val);
	}

	public MvcHtmlString ConfirmDialog()
	{
		return PartialExtensions.Partial(html, "UI/Box/ConfirmMessageBox", (object)messageBox);
	}

	public MvcHtmlString Render()
	{
		if (messageBox.MessageBoxType == EleWise.ELMA.Web.Mvc.Models.Boxes.MessageBoxType.QUESTION)
		{
			return MvcHtmlString.Create($"jConfirm('{messageBox.Message}', '{messageBox.Header}', function (r) {{if (r == true) {{{messageBox.YesHandler}}} else {{{messageBox.CancelHandler}}}}});");
		}
		return MvcHtmlString.Create($"jAlert('{messageBox.Message}', '{messageBox.Header}', function () {{{messageBox.OkHandler}}});");
	}
}
