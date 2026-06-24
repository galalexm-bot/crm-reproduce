namespace EleWise.ELMA.BPM.Web.Security.Models;

public sealed class UserSelectModel
{
	public AutoCompleteUserItem Item { get; set; }

	public string PhotoUrl { get; set; }

	public bool AsLink { get; set; }
}
