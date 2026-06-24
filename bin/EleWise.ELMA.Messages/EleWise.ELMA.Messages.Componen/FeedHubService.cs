using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Hubs;

namespace EleWise.ELMA.Messages.Components.Hubs;

[Service(EnableInterceptors = false, InjectProperties = false)]
internal sealed class FeedHubService : IFeedHubService
{
	private readonly IAuthenticationService authenticationService;

	private readonly IHubContextFactory contextFactory;

	private IHubContextWrapper<IFeedClient> hubContext;

	private IHubContextWrapper<IFeedClient> HubContext => hubContext ?? (hubContext = contextFactory.GetContext<FeedHub, IFeedClient>());

	public FeedHubService(IAuthenticationService authenticationService, IHubContextFactory contextFactory)
	{
		this.authenticationService = authenticationService;
		this.contextFactory = contextFactory;
	}

	public void SendComment(FeedModel model, IEnumerable<IUser> users)
	{
		IUser currentUser = authenticationService.GetCurrentUser<IUser>();
		List<string> userIds = (from q in users
			where q != currentUser
			select q.UserName).ToList();
		FeedCommentModel feedCommentModel = new FeedCommentModel(model);
		if (HubContext != null)
		{
			HubContext.Clients.Users(userIds).SendComment(feedCommentModel);
			if (users.Contains(currentUser))
			{
				feedCommentModel.IsRead = true;
				HubContext.Clients.User(currentUser.UserName).SendComment(feedCommentModel);
			}
		}
	}
}
