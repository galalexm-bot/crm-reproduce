using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class UserSetModel
{
	public IUser User { get; set; }

	public string Prefix { get; set; }

	public bool CheckReplacement { get; set; }

	public string Width { get; set; }

	public bool CreateValidationMessage { get; set; }

	public string OnChange { get; set; }
}
