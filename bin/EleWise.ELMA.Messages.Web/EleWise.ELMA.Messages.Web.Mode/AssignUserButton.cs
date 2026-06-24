using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Models;

public class AssignUserButton
{
	protected static IAuthenticationService AuthenticationService => Locator.GetService<IAuthenticationService>();

	public IInformationChannel Channel { get; set; }

	public bool IsAssign
	{
		get
		{
			IUser user = AuthenticationService.GetCurrentUser<IUser>();
			return ((IEnumerable<IInformationChannelSubscriber>)Channel.Subscribers).Any((IInformationChannelSubscriber u) => u.User.Id == user.Id && u.Channel.Id == Channel.Id);
		}
	}
}
