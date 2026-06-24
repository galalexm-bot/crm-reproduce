using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Hubs;

public class FeedUserModel
{
	public bool HasPhoto { get; }

	public string PhotoUid { get; }

	public string ShortName { get; }

	public long UserId { get; }

	public string UserName { get; }

	public FeedUserModel(IUser user)
	{
		if (user.Photo != null)
		{
			HasPhoto = true;
			PhotoUid = user.Photo.Uid.ToString("N");
		}
		UserId = user.Id;
		ShortName = user.GetShortName();
		UserName = user.UserName;
	}
}
