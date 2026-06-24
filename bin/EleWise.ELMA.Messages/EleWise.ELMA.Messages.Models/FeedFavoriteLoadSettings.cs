using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

internal class FeedFavoriteLoadSettings
{
	public IUser Recipient { get; set; }

	public int MaxCount { get; set; }

	public string ChangeDateHash { get; set; }

	public FeedFavoriteLoadSettings()
	{
		MaxCount = 20;
	}
}
