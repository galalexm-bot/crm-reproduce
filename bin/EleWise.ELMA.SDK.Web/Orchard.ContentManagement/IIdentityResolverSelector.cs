namespace Orchard.ContentManagement;

public interface IIdentityResolverSelector : IDependency
{
	IdentityResolverSelectorResult GetResolver(ContentIdentity contentIdentity);
}
