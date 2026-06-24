using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelMessageGrid
{
	public GridData<IChannelMessage, IChannelMessageFilter> Data { get; set; }

	public string GridId { get; set; }
}
