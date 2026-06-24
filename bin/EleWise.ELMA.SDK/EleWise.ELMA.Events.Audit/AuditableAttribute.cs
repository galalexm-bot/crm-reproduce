using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

[AttributeUsage(AttributeTargets.Method)]
public class AuditableAttribute : Attribute
{
	private static AuditableAttribute o9NIX1Gs1DSXw8ejnw0B;

	public bool Preprocess
	{
		[CompilerGenerated]
		get
		{
			return _003CPreprocess_003Ek__BackingField;
		}
		[CompilerGenerated]
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
				case 0:
					return;
				case 1:
					_003CPreprocess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Postprocess
	{
		[CompilerGenerated]
		get
		{
			return _003CPostprocess_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CPostprocess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
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

	public AuditableAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VsWC5oGsp5PLtV507esu();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Postprocess = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				Preprocess = true;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	internal static void VsWC5oGsp5PLtV507esu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jmqmjZGsNvmSSUsF8MvP()
	{
		return o9NIX1Gs1DSXw8ejnw0B == null;
	}

	internal static AuditableAttribute NB7uKpGs32y17CgFmmTV()
	{
		return o9NIX1Gs1DSXw8ejnw0B;
	}
}
