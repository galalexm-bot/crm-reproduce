using System.Collections.Generic;

namespace EleWise.ELMA.Messaging.Email.Models;

public class FooterFileModel
{
	public string HtmlFooter { get; set; }

	public Dictionary<string, string> FileInfo { get; set; }

	public FooterFileModel()
	{
		FileInfo = new Dictionary<string, string>();
	}
}
