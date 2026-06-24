using Orchard.ContentManagement;

namespace Orchard.Security;

public interface IUser : IContent
{
	string UserName { get; }

	string Email { get; }
}
