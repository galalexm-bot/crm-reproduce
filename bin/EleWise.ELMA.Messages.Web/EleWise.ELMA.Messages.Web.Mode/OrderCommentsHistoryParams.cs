using System.ComponentModel;

namespace EleWise.ELMA.Messages.Web.Models;

public sealed class OrderCommentsHistoryParams
{
	public long MessageId { get; set; }

	public ListSortDirection CommentsSortDirection { get; set; }
}
