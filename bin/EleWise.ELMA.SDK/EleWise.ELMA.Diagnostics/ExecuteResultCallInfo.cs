using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(ExecuteResultCallStartEvent), EndEvent = typeof(ExecuteResultCallEndEvent), ErrorEvent = typeof(ExecuteResultCallErrorEvent))]
public class ExecuteResultCallInfo : AbstractCallInfo, IEmptyCallInfo
{
	internal static ExecuteResultCallInfo wAhALHEFScXsFPhWyVPv;

	public ResultExecutingContext ResultExecutingContext
	{
		[CompilerGenerated]
		get
		{
			return _003CResultExecutingContext_003Ek__BackingField;
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
					_003CResultExecutingContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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

	public ResultExecutedContext ResultExecutedContext
	{
		[CompilerGenerated]
		get
		{
			return _003CResultExecutedContext_003Ek__BackingField;
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
					_003CResultExecutedContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
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

	public Type ControllerType
	{
		[CompilerGenerated]
		get
		{
			return _003CControllerType_003Ek__BackingField;
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
					_003CControllerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	public override string CallType => (string)vnXxqGEFXy8Oehyvfdab(-1334993905 ^ -1335248139);

	public override string Description => (string)KmkB8iEFkPeC2pUM41oj(i6Yd4yEFTFbdBS5T4FhV(ResultExecutingContext).GetType(), vnXxqGEFXy8Oehyvfdab(-606654180 ^ -606923260));

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	public ExecuteResultCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ht9DZJEFqOm8acx840sd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ExecuteResultCallInfo(ResultExecutingContext resultExecutingContext)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		Ht9DZJEFqOm8acx840sd();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				ResultExecutingContext = resultExecutingContext;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			default:
				ControllerType = RdUDCpEFKw2giyaw9y7K(resultExecutingContext).GetType();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num = 0;
				}
				break;
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
			default:
				return;
			case 0:
				return;
			case 1:
				ngWm6fEFnW3nDHw4F3ul(info, vnXxqGEFXy8Oehyvfdab(0x3CE17B75 ^ 0x3CE55DD7), ControllerType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void Ht9DZJEFqOm8acx840sd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gIUuYGEFilAaNxvDIR8T()
	{
		return wAhALHEFScXsFPhWyVPv == null;
	}

	internal static ExecuteResultCallInfo HuHB6VEFRcJVZuXyAv3l()
	{
		return wAhALHEFScXsFPhWyVPv;
	}

	internal static object RdUDCpEFKw2giyaw9y7K(object P_0)
	{
		return ((ControllerContext)P_0).get_Controller();
	}

	internal static object vnXxqGEFXy8Oehyvfdab(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object i6Yd4yEFTFbdBS5T4FhV(object P_0)
	{
		return ((ResultExecutingContext)P_0).get_Result();
	}

	internal static object KmkB8iEFkPeC2pUM41oj(Type controllerType, object P_1)
	{
		return DiagnosticsHelper.GetControllerActionCallName(controllerType, (string)P_1);
	}

	internal static void ngWm6fEFnW3nDHw4F3ul(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
