using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

[FilterFor(typeof(IMessageNotAssignedUser))]
public interface IMessageNotAssignedUserFilter : IEntityFilter
{
	IUser Recipient { get; set; }

	IChannelMessage ChannelMessage { get; set; }
}
