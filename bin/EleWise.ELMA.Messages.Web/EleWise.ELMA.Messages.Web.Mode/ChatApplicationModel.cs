namespace EleWise.ELMA.Messages.Web.Models;

public sealed class ChatApplicationModel
{
	public bool Debug { get; set; }

	public string JwtAuthToken { get; set; }

	public string RefreshToken { get; set; }
}
