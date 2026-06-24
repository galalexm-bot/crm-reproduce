using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(MethodCallStartEvent), EndEvent = typeof(MethodCallEndEvent), ErrorEvent = typeof(MethodCallErrorEvent))]
public class MethodCallInfo : AbstractCallInfo, IEmptyCallInfo
{
	internal static MethodCallInfo z2CKSgEWFvd3tRw9kSxO;

	public Type OwnerType
	{
		[CompilerGenerated]
		get
		{
			return _003COwnerType_003Ek__BackingField;
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
					_003COwnerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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

	public MethodInfo Method
	{
		[CompilerGenerated]
		get
		{
			return _003CMethod_003Ek__BackingField;
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
					_003CMethod_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
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

	public object[] Arguments
	{
		[CompilerGenerated]
		get
		{
			return _003CArguments_003Ek__BackingField;
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
					_003CArguments_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	public override string CallType => (string)AJXowPEWhKPru7iYksXP(0x307E9FD1 ^ 0x307AB663);

	public override string Description => DiagnosticsHelper.GetMethodCallName(OwnerType, Method);

	public bool IsEmpty
	{
		[CompilerGenerated]
		get
		{
			return _003CIsEmpty_003Ek__BackingField;
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
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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

	public MethodCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		APAEV2EWoqcrIpOShAA6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected MethodCallInfo(Type ownerType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		APAEV2EWoqcrIpOShAA6();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				throw new ArgumentNullException((string)AJXowPEWhKPru7iYksXP(-1886646897 ^ -1886903053));
			case 0:
				return;
			case 1:
				if (!bbWc2DEWbWtIPhxOYfED(ownerType, null))
				{
					OwnerType = ownerType;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 2;
				}
				break;
			}
		}
	}

	public MethodCallInfo(Type ownerType, MethodInfo method, object[] arguments)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		APAEV2EWoqcrIpOShAA6();
		this._002Ector(ownerType);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				throw new ArgumentNullException((string)AJXowPEWhKPru7iYksXP(-70037984 ^ -70102218));
			case 0:
				return;
			case 3:
				Arguments = arguments;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (!xsJSYKEWGqP9CgU6kLBs(method, null))
				{
					Method = method;
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num = 2;
					}
				}
				else
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 1;
					}
				}
				break;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Arguments.Length != 0)
					{
						num2 = 2;
						continue;
					}
					return;
				case 4:
					break;
				default:
					if (Arguments != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 3:
					u69eJAEWEY2HlH3Y3HGq(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138415238), Method);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					info.AddValue((string)AJXowPEWhKPru7iYksXP(0x26FFCB59 ^ 0x26FBE28D), Arguments.Select((object a) => a.ToString()));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			info.AddValue((string)AJXowPEWhKPru7iYksXP(-1939377524 ^ -1939645646), OwnerType);
			num = 3;
		}
	}

	internal static void APAEV2EWoqcrIpOShAA6()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Ecct7gEWBDfpqC9gLvJX()
	{
		return z2CKSgEWFvd3tRw9kSxO == null;
	}

	internal static MethodCallInfo vXYJBGEWW2QhrpKSM0J9()
	{
		return z2CKSgEWFvd3tRw9kSxO;
	}

	internal static bool bbWc2DEWbWtIPhxOYfED(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object AJXowPEWhKPru7iYksXP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xsJSYKEWGqP9CgU6kLBs(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static void u69eJAEWEY2HlH3Y3HGq(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
