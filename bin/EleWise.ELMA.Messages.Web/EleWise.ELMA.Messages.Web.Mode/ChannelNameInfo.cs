using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelNameInfo
{
	public IInformationChannel Channel { get; set; }

	public bool Admin { get; set; }
}
