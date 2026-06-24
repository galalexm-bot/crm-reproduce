using Orchard.ContentManagement;
using Orchard.Security.Permissions;

namespace Orchard.Security;

public class CheckAccessContext
{
	public Permission Permission { get; set; }

	public IUser User { get; set; }

	public IContent Content { get; set; }

	public bool Granted { get; set; }

	public bool Adjusted { get; set; }
}
