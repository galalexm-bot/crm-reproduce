using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorInjectionAttribute : Attribute
{
	internal static RazorInjectionAttribute j1mvavfvOQrZlKYDj4jt;

	public string Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
				case 1:
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	public string FieldName
	{
		[CompilerGenerated]
		get
		{
			return _003CFieldName_003Ek__BackingField;
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
					_003CFieldName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public RazorInjectionAttribute(string type, string fieldName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WGum7ifvPxLsm5G8j6qN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				FieldName = fieldName;
				num = 2;
				continue;
			case 2:
				return;
			}
			Type = type;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
			{
				num = 1;
			}
		}
	}

	internal static void WGum7ifvPxLsm5G8j6qN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool RkTUjBfv2td5jWJJ6IhD()
	{
		return j1mvavfvOQrZlKYDj4jt == null;
	}

	internal static RazorInjectionAttribute TFJDtufveBfXxsTQoy10()
	{
		return j1mvavfvOQrZlKYDj4jt;
	}
}
