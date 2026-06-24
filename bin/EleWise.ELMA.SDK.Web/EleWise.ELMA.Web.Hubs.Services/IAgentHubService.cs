using System.Collections.Generic;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Web.Hubs.Services;

public interface IAgentHubService
{
	void Send<T>(IUser user, string command, T arguments) where T : class;

	void Send<T>(IEnumerable<IUser> users, string command, T arguments) where T : class;

	void Send<T>(string userName, string command, T arguments) where T : class;

	void Send<T>(IEnumerable<string> userNames, string command, T arguments) where T : class;

	void SendAll<T>(string command, T arguments) where T : class;
}
