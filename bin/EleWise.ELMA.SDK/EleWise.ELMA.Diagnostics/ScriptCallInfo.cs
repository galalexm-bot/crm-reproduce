using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
public class ScriptCallInfo : MethodCallInfo
{
	internal static ScriptCallInfo FKbQyNEWyHZkypGWxsh8;

	public string OwnerName
	{
		[CompilerGenerated]
		get
		{
			return _003COwnerName_003Ek__BackingField;
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
					_003COwnerName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	public override string CallType => (string)zHONpOEWd8UTY6SlT9QI(-1411196499 ^ -1411178541);

	public ScriptCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JZUexLEW9GGnGc1O34Cr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ScriptCallInfo(Type ownerType, string ownerName, MethodInfo method, object[] arguments)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(ownerType, method, arguments);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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
			OwnerName = ownerName;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
			{
				num = 1;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				info.AddValue((string)zHONpOEWd8UTY6SlT9QI(-521266112 ^ -521521304), OwnerName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				base.GetObjectData(info, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			if (!bnHRvQEWlqnTGDAv09AK(OwnerName))
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			return;
		}
	}

	internal static void JZUexLEW9GGnGc1O34Cr()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hjxkbvEWMHyiMyZLY4Ia()
	{
		return FKbQyNEWyHZkypGWxsh8 == null;
	}

	internal static ScriptCallInfo HjCUtLEWJPXKShHWp4BZ()
	{
		return FKbQyNEWyHZkypGWxsh8;
	}

	internal static object zHONpOEWd8UTY6SlT9QI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bnHRvQEWlqnTGDAv09AK(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}
}
