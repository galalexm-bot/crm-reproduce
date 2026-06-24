using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IChannelMesagesToolbarExtension
{
	void BackToExt(List<IInformationChannel> channels, ToolbarGroupBuilder groupBuilder);
}
