using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.OAuth.Client.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IOAuthProvider
{
	string ProviderName { get; }

	string Icon16 { get; }

	string Icon24 { get; }

	string Icon36 { get; }

	Guid ProviderUid { get; }

	bool CanUse();

	string LogOn(object requestData, string redirectUrl);

	string LogOnResponse(object requestData, string redirectUrl);

	IUser UserByToken(string token);

	object GetUserInfo(string token);

	string AddOAuth(object requestData, IUser user);

	void AddOAuthResponse(object requestData);

	void RemoveOAuth(IUser user);

	bool OAuthAccepted(IUser user);

	bool OAuthExist(IUser user);
}
