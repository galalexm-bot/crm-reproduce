using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class LogMessage
{
	public LogMessageType MessageType { get; set; }

	public string Message { get; set; }

	public static string GetTypeDisplayName(LogMessageType messageType)
	{
		return messageType switch
		{
			LogMessageType.Error => SR.T("Ошибка"), 
			LogMessageType.Info => SR.T("Предупреждение"), 
			LogMessageType.RecordAdded => SR.T("Добавлена запись"), 
			_ => string.Empty, 
		};
	}

	public static MvcHtmlString GetTypeImage(HtmlHelper html, LogMessageType messageType)
	{
		string typeDisplayName = GetTypeDisplayName(messageType);
		return (MvcHtmlString)(messageType switch
		{
			LogMessageType.Error => html.SvgImage("#delete.svg", new
			{
				@class = "color-red",
				tooltipText = typeDisplayName
			}), 
			LogMessageType.Info => html.SvgImage("#info-circle.svg", new
			{
				@class = "color-yellow",
				tooltipText = typeDisplayName
			}), 
			LogMessageType.RecordAdded => html.SvgImage("#add_outline.svg", new
			{
				@class = "color-green",
				tooltipText = typeDisplayName
			}), 
			_ => MvcHtmlString.Empty, 
		});
	}
}
