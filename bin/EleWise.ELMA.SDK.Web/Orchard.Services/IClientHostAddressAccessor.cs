namespace Orchard.Services;

public interface IClientHostAddressAccessor : IDependency
{
	string GetClientAddress();
}
