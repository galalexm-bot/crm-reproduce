using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class AssertionConditionAttribute : Attribute
{
	internal static AssertionConditionAttribute ssKserfCwFyNp52EaeKB;

	public AssertionConditionType ConditionType
	{
		[CompilerGenerated]
		get
		{
			return _003CConditionType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CConditionType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AssertionConditionAttribute(AssertionConditionType conditionType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				ConditionType = conditionType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool OgwywJfC41VtDGqdK4S6()
	{
		return ssKserfCwFyNp52EaeKB == null;
	}

	internal static AssertionConditionAttribute BIiBaIfC6YiMSgEc5g4G()
	{
		return ssKserfCwFyNp52EaeKB;
	}
}
