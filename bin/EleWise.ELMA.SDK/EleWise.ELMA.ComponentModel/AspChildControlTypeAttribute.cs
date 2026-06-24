using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AspChildControlTypeAttribute : Attribute
{
	internal static AspChildControlTypeAttribute VNbaA9fvBSgrkNniAV04;

	public string TagName
	{
		[CompilerGenerated]
		get
		{
			return _003CTagName_003Ek__BackingField;
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
					_003CTagName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type ControlType
	{
		[CompilerGenerated]
		get
		{
			return _003CControlType_003Ek__BackingField;
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
					_003CControlType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AspChildControlTypeAttribute(string tagName, Type controlType)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				TagName = tagName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				ControlType = controlType;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool PDHL0CfvWaaCHj2OLSX4()
	{
		return VNbaA9fvBSgrkNniAV04 == null;
	}

	internal static AspChildControlTypeAttribute r3Ax9ifvoHLeam9tx7Wg()
	{
		return VNbaA9fvBSgrkNniAV04;
	}
}
