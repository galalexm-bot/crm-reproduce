using System;

namespace EleWise.ELMA.Web.Components;

public static class FormattingHelper
{
	public static string DateToString(DateTime runtimeDateTime)
	{
		DateTime dateTime = runtimeDateTime.ToClientDateTime();
		TimeSpan timeSpan = TZ.CurrentClientDate - dateTime.Date;
		string text = "";
		return string.Format("{0}, {1}", (int)timeSpan.TotalDays switch
		{
			0 => SR.Today, 
			1 => SR.T("Вчера"), 
			_ => SR.T("{0:d.MM.yyyy}", dateTime), 
		}, SR.T("{0:HH:mm}", dateTime));
	}
}
