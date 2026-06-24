using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class MessageList
{
	public IBaseMessageFilter BaseMessageFilter { get; set; }

	public string GridId { get; set; }

	public bool CanAddMessage { get; set; }

	public int? CurrentPage { get; set; }

	public int? PageSize { get; set; }

	public int? CommentsCount { get; set; }

	public MessageList()
	{
		GridId = "MessageGrid";
	}
}
