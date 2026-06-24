using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class UserImageModel
{
	public IUser CreationAuthor { get; set; }

	public bool IsRead { get; set; }
}
