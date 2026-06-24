using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.Web.Models;

public class ChannelViewInfo : EntityModel<IInformationChannel>
{
	public bool IsOpen { get; set; }

	public ChannelViewInfo()
	{
		IsOpen = true;
	}
}
