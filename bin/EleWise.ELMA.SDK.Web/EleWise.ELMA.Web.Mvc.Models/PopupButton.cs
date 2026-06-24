namespace EleWise.ELMA.Web.Mvc.Models;

public class PopupButton
{
	public static string Ok(string postUrl, string redirectUrl, string text = null)
	{
		return string.Format("{text:'{0}',handler:function() {Ext.Ajax.request({url: '{1}',success: function() {win.hide();document.location.href = '{2}';}})}}", text ?? SR.T("Ок"), postUrl, redirectUrl);
	}

	public static string Cancel(string text = null)
	{
		return string.Format("{text:'{0}',handler:function(){win.hide();}}", text ?? SR.T("Отмена"));
	}
}
