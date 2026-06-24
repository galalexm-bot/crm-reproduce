using System.Reflection;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Settings.Events;

public class EditGlobalSettingsEventArgs : GlobalSettingsEventArgs
{
	protected string newValue;

	private IStoreValuesObject store;

	internal static EditGlobalSettingsEventArgs rA3VK3WGp91bxPG1WI80;

	public string NewValue => newValue;

	public IStoreValuesObject Store => store;

	public EditGlobalSettingsEventArgs(PropertyInfo property, IStoreValuesObject store, string newValue)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		MkawV7WGtVnyatYW37jI();
		base._002Ector(property);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.newValue = newValue;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.store = store;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void MkawV7WGtVnyatYW37jI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rvYimYWGaIloF2T96Vjb()
	{
		return rA3VK3WGp91bxPG1WI80 == null;
	}

	internal static EditGlobalSettingsEventArgs tRflJWWGD0DIueMrAxH8()
	{
		return rA3VK3WGp91bxPG1WI80;
	}
}
