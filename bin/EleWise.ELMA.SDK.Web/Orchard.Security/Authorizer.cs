using Orchard.ContentManagement;
using Orchard.Localization;
using Orchard.Security.Permissions;

namespace Orchard.Security;

public class Authorizer : IAuthorizer, IDependency
{
	private readonly IWorkContextAccessor _workContextAccessor;

	public Localizer T { get; set; }

	public Authorizer(IWorkContextAccessor workContextAccessor)
	{
		_workContextAccessor = workContextAccessor;
		T = NullLocalizer.Instance;
	}

	public bool Authorize(Permission permission)
	{
		return Authorize(permission, null, null);
	}

	public bool Authorize(Permission permission, LocalizedString message)
	{
		return Authorize(permission, null, message);
	}

	public bool Authorize(Permission permission, IContent content)
	{
		return Authorize(permission, content, null);
	}

	public bool Authorize(Permission permission, IContent content, LocalizedString message)
	{
		return true;
	}
}
