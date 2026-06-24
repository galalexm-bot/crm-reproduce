using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Messages.Models;

public class DiscussionHistoryModel : HistoryBaseModel
{
	public IChannelMessage Message { get; set; }

	public object Object { get; set; }

	public DiscussionHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
