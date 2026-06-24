using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

[Serializable]
public class ScriptWebReference
{
	internal static ScriptWebReference kIOw8xbRGIHFLMStmtX9;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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

	public string Namespace
	{
		[CompilerGenerated]
		get
		{
			return _003CNamespace_003Ek__BackingField;
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
					_003CNamespace_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
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

	public List<ScriptProjectItem> Items { get; set; }

	public ScriptWebReference()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PU1GDSbRQ8iHbujITiOV();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Items = new List<ScriptProjectItem>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void PU1GDSbRQ8iHbujITiOV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EFLBBkbREQN1KmBaArBR()
	{
		return kIOw8xbRGIHFLMStmtX9 == null;
	}

	internal static ScriptWebReference K13bWNbRfH4fe9jgo2Fo()
	{
		return kIOw8xbRGIHFLMStmtX9;
	}
}
