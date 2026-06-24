using EleWise.ELMA.Security;

namespace EleWise.ELMA.Services;

public interface IFileGatewayService
{
	string SystemGateway { get; }

	string[] AllGateways { get; }

	string GetClosestGateway();

	string GetUserGateway(IUser user);

	void SetUserGateway(IUser user, string gateway);
}
