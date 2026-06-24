using System;
using System.Collections.Generic;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Settings;

namespace EleWise.ELMA.Security.Services;

public interface IExternalMembershipManager
{
	IEnumerable<IExternalMembershipModule> Modules { get; set; }

	IExternalMembershipModule GetModule(Guid moduleUid);

	void SaveSettings(IExternalMembershipModuleSettings settings);

	IExternalMembershipModuleSettings LoadSettings(Guid instanceUid);

	void DeleteSettings(Guid moduleUid, Guid instanceUid);

	IEnumerable<IExternalMembershipModuleSettings> GetAllSettings();

	IExternalMembershipModuleSettings CreateDefaultSettings(IExternalMembershipModule module);

	IExternalMembershipModuleSettings CreateDefaultSettings(Func<IExternalMembershipModuleSettings> createDefaultSettingsFunc);

	IEnumerable<IUser> FindUsers(string searchString, Guid authProviderGuid);

	string Name(Guid authProviderGuid);

	Dictionary<Guid, string> GetAllName();

	void Sync(IUser user, Guid authProviderGuid);

	void ValidateUser(UserValidationContext validationContext, Guid authProviderGuid);
}
