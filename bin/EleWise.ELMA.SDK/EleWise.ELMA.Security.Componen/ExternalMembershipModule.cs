using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Security.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

[Component]
public abstract class ExternalMembershipModule<TS> : IExternalMembershipModule where TS : ExternalMembershipModuleSettings, new()
{
	private static object EqsWsYBUE7T5sHUCIq9e;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public abstract string Description { get; }

	public virtual string Category => string.Empty;

	public virtual IExternalMembershipModuleSettings CreateDefaultSettings()
	{
		return new TS
		{
			InstanceUid = Guid.NewGuid()
		};
	}

	public abstract IEnumerable<IUser> FindUsers(string searchString, IExternalMembershipModuleSettings settings);

	public abstract void Sync(IUser user, IExternalMembershipModuleSettings settings);

	public abstract bool ValidateUser(UserValidationContext context, IExternalMembershipModuleSettings settings);

	protected ExternalMembershipModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TZnWEFBUfREGEVdfGao7()
	{
		return EqsWsYBUE7T5sHUCIq9e == null;
	}

	internal static object Eo8ZrjBUQqBLk0x8hHy0()
	{
		return EqsWsYBUE7T5sHUCIq9e;
	}
}
