using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Models;

[FilterFor(typeof(IDiscussion))]
public interface IDiscussionFilter : IChannelMessageFilter, IBaseMessageFilter, IEntityFilter
{
	DiscussionStatus? DiscussionStatus { get; set; }
}
