namespace EleWise.ELMA.Security.Services;

public interface ITrustedDeviceService
{
	string AddDevice(string deviceInfo, string deviceName);

	bool CheckDevice(string deviceToken, string deviceInfo, IUser user);
}
