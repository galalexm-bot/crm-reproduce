namespace EleWise.ELMA.Messages.Web.Models;

public class FeedCommentsListJsonModel
{
	public bool Success { get; set; }

	public string Error { get; set; }

	public bool CanCreateComment { get; set; }

	public bool CanCreateNextComment { get; set; }

	public bool CanCreateQuestion { get; set; }

	public FeedCommentsListModel Model { get; set; }

	public string ViewResult { get; set; }
}
