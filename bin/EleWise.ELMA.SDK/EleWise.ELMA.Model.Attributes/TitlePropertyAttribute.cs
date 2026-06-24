using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

public class TitlePropertyAttribute : Attribute
{
	private Guid uid;

	private static TitlePropertyAttribute lgVr89ou9PXT5c7MIReR;

	public Guid Uid
	{
		get
		{
			return uid;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public TitlePropertyAttribute(string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ADdWLUour8Ai0YYXVrCK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.uid = new Guid(uid);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
			{
				num = 1;
			}
		}
	}

	internal static void ADdWLUour8Ai0YYXVrCK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Y0oktjoud1vN0ynFwfIh()
	{
		return lgVr89ou9PXT5c7MIReR == null;
	}

	internal static TitlePropertyAttribute zAdKSqoula3WT5tp0R5k()
	{
		return lgVr89ou9PXT5c7MIReR;
	}
}
