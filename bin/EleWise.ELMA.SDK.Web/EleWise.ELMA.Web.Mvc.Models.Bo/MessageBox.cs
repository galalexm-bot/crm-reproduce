using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Boxes;

public class MessageBox
{
	public const string BtnOk = "ok";

	public const string BtnCancel = "cancel";

	public const string BtnYes = "yes";

	public const string BtnNo = "no";

	private readonly Dictionary<string, string> _buttons = new Dictionary<string, string>
	{
		{
			"ok",
			SR.Ok
		},
		{
			"cancel",
			SR.Cancel
		},
		{
			"yes",
			SR.Yes
		},
		{
			"no",
			SR.No
		}
	};

	public Dictionary<string, string> Buttons => _buttons;

	public string Message { get; set; }

	public string Header { get; set; }

	public MessageBoxType MessageBoxType { get; set; }

	public ButtonsType ButtonsType { get; set; }

	public string OkHandler { get; set; }

	public string CancelHandler { get; set; }

	public string YesHandler { get; set; }

	public string NoHandler { get; set; }

	public string Id { get; set; }

	public MessageBox(string id)
	{
		Id = id;
	}

	public bool IsButtonVisible(string btnKey)
	{
		switch (ButtonsType)
		{
		case ButtonsType.CANCEL:
			return btnKey == "cancel";
		case ButtonsType.OK:
			return btnKey == "ok";
		case ButtonsType.OKCANCEL:
			if (!(btnKey == "ok"))
			{
				return btnKey == "cancel";
			}
			return true;
		case ButtonsType.YESNO:
			if (!(btnKey == "yes"))
			{
				return btnKey == "no";
			}
			return true;
		case ButtonsType.YESNOCANCEL:
			if (!(btnKey == "yes") && !(btnKey == "no"))
			{
				return btnKey == "cancel";
			}
			return true;
		default:
			return false;
		}
	}
}
