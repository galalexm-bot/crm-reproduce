namespace EleWise.ELMA.Web.Hubs.Services;

public interface IAgentHubConnectionService
{
	void OnConnected(string connectionId, string userId);

	void OnDisconnected(string connectionId);

	bool IsConnected(string userId);

	void Send<T>(string user, string command, T arguments) where T : class;
}
