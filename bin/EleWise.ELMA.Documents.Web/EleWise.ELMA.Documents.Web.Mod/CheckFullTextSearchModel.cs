using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Documents.Web.Models;

public class CheckFullTextSearchModel
{
	public List<string> Errors { get; set; }

	public bool IsFullTextSearch
	{
		get
		{
			if (Errors != null)
			{
				return !Errors.Any();
			}
			return true;
		}
	}

	public string ErrorsString
	{
		get
		{
			string text = string.Empty;
			for (int i = 1; i <= Errors.Count; i++)
			{
				text += $"{i}. {Errors[i - 1]}<br>";
			}
			return text;
		}
	}

	public CheckFullTextSearchModel()
	{
		Errors = new List<string>();
	}
}
