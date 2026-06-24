using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db;

public abstract class ItemsDeletingEventArgs : EventArgs
{
	private List<string> skipNames;

	private static ItemsDeletingEventArgs nJ99ylWSpinVYgRD9gNu;

	public List<string> SkipNames => skipNames;

	protected ItemsDeletingEventArgs()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		kkfybVWStBb2UPsUXTKx();
		skipNames = new List<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void kkfybVWStBb2UPsUXTKx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool w01QUAWSaSwQkrlpjI8i()
	{
		return nJ99ylWSpinVYgRD9gNu == null;
	}

	internal static ItemsDeletingEventArgs H4WE6tWSDs0HNjHdkQGZ()
	{
		return nJ99ylWSpinVYgRD9gNu;
	}
}
