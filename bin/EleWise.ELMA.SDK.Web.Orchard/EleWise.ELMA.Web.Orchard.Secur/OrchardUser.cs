using System.Web.Security;
using Orchard.ContentManagement;
using Orchard.Security;

namespace EleWise.ELMA.Web.Orchard.Security;

public class OrchardUser : IUser, IContent
{
	private readonly string userName;

	private readonly string email;

	private readonly long id;

	private ContentItem contentItem;

	public ContentItem ContentItem => contentItem;

	public int Id => (int)id;

	public string UserName => userName;

	public string Email => email;

	public OrchardUser(MembershipUser elmaUser)
	{
		userName = elmaUser.UserName;
		email = elmaUser.Email;
		id = 0L;
		contentItem = new ContentItem();
	}
}
