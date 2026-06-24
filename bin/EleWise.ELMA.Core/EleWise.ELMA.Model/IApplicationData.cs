namespace EleWise.ELMA.Model;

public interface IApplicationData
{
	string JwtAuthToken { get; }

	string RefreshToken { get; }

	string PageUid { get; }

	bool Debug { get; }

	InterfaceBuilderMode InterfaceBuilderMode { get; }

	string BaseUrl { get; }

	string Version { get; }

	string UIVersion { get; }

	string RuntimeModelHash { get; }
}
