using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web.Mvc;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
[DiagnosticEvents(StartEvent = typeof(ControllerActionCallStartEvent), EndEvent = typeof(ControllerActionCallEndEvent), ErrorEvent = typeof(ControllerActionCallErrorEvent))]
public class ControllerActionCallInfo : AbstractCallInfo, IEmptyCallInfo
{
	internal static ControllerActionCallInfo LABG2cEFb63YqCIOPBgX;

	public ActionExecutedContext ActionExecutedContext
	{
		[CompilerGenerated]
		get
		{
			return _003CActionExecutedContext_003Ek__BackingField;
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
					_003CActionExecutedContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ActionExecutingContext ActionExecutingContext
	{
		[CompilerGenerated]
		get
		{
			return _003CActionExecutingContext_003Ek__BackingField;
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
					_003CActionExecutingContext_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
				case 0:
					return;
				case 1:
					_003CControllerType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ControllerName
	{
		[CompilerGenerated]
		get
		{
			return _003CControllerName_003Ek__BackingField;
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
					_003CControllerName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ActionName
	{
		[CompilerGenerated]
		get
		{
			return _003CActionName_003Ek__BackingField;
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
					_003CActionName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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

	public override string CallType => z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E65D18);

	public override string Description => (string)I1nsr7EFZi664vWmWFM7(ControllerType, ActionName);

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
				case 0:
					return;
				case 1:
					_003CIsEmpty_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ControllerActionCallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yekxtPEFEQlItGFLAJBg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ControllerActionCallInfo(ActionExecutingContext actionExecutingContext)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				ControllerType = VEUEqFEFfDhgLiYhqqfj(actionExecutingContext).GetType();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ActionExecutingContext = actionExecutingContext;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 1;
				}
				break;
			default:
				ControllerName = (string)TRocy2EFvWbIRaO7yLfs(Xb49lXEFC7DTxGehEWEV(g2Z3MuEFQ2whPvQYpc9y(actionExecutingContext)));
				num = 3;
				break;
			case 4:
				return;
			case 3:
				ActionName = (string)crLsgoEF8qItTnZ6qD4n(actionExecutingContext.get_ActionDescriptor());
				num = 4;
				break;
			}
		}
	}

	protected override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_00dd, IL_00ec
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (ActionName.IsNullOrEmpty())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					goto end_IL_0012;
				case 5:
					info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583997866), ControllerType);
					num2 = 4;
					continue;
				case 4:
					if (!XZ5aEiEFuCGBowYsKvLd(ControllerName))
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 1:
					return;
				case 6:
					return;
				}
				info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978604055), ActionName);
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			fFCLiyEFVXtADjHXgJ3p(info, R5u1IPEFIBncxLbCpuIb(-957824448 ^ -957553534), ControllerName);
			num = 2;
		}
	}

	internal static void yekxtPEFEQlItGFLAJBg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool L9A4nXEFhtyMLN0u2H9d()
	{
		return LABG2cEFb63YqCIOPBgX == null;
	}

	internal static ControllerActionCallInfo KTMFW7EFGJBIMyEIA4p3()
	{
		return LABG2cEFb63YqCIOPBgX;
	}

	internal static object VEUEqFEFfDhgLiYhqqfj(object P_0)
	{
		return ((ControllerContext)P_0).get_Controller();
	}

	internal static object g2Z3MuEFQ2whPvQYpc9y(object P_0)
	{
		return ((ActionExecutingContext)P_0).get_ActionDescriptor();
	}

	internal static object Xb49lXEFC7DTxGehEWEV(object P_0)
	{
		return ((ActionDescriptor)P_0).get_ControllerDescriptor();
	}

	internal static object TRocy2EFvWbIRaO7yLfs(object P_0)
	{
		return ((ControllerDescriptor)P_0).get_ControllerName();
	}

	internal static object crLsgoEF8qItTnZ6qD4n(object P_0)
	{
		return ((ActionDescriptor)P_0).get_ActionName();
	}

	internal static object I1nsr7EFZi664vWmWFM7(Type controllerType, object P_1)
	{
		return DiagnosticsHelper.GetControllerActionCallName(controllerType, (string)P_1);
	}

	internal static bool XZ5aEiEFuCGBowYsKvLd(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object R5u1IPEFIBncxLbCpuIb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void fFCLiyEFVXtADjHXgJ3p(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}
}
