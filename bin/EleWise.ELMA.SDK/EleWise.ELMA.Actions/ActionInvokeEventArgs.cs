using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

[Serializable]
public class ActionInvokeEventArgs : AuditEventArgs
{
	internal static ActionInvokeEventArgs P6mm9Bft7kN0VAjE8x4n;

	public object Invoker
	{
		[CompilerGenerated]
		get
		{
			return _003CInvoker_003Ek__BackingField;
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
					_003CInvoker_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICollection<object> Params { get; set; }

	public bool Invoked
	{
		[CompilerGenerated]
		get
		{
			return _003CInvoked_003Ek__BackingField;
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
					_003CInvoked_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object Result
	{
		[CompilerGenerated]
		get
		{
			return _003CResult_003Ek__BackingField;
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
					_003CResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
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

	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B32B7DF)] = Invoker;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BEE94C)] = Invoked;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F49ECE1)] = Params;
			extendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139051408)] = Result;
			return extendedProperties;
		}
	}

	public ActionInvokeEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HntYoeftmQRgF9Tiv9f9();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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
				Params = new List<object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void HntYoeftmQRgF9Tiv9f9()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool xHhjCgftxxm8dQSAj9Xh()
	{
		return P6mm9Bft7kN0VAjE8x4n == null;
	}

	internal static ActionInvokeEventArgs WcHmHvft0Ipt7Nr3Jknp()
	{
		return P6mm9Bft7kN0VAjE8x4n;
	}
}
