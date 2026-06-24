using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

[Obsolete("Класс устарел и больше не используется. Используйте EleWise.ELMA.Actions.ActionInvokerAsync", true)]
public sealed class ActionInvoker : IActionInvoker
{
	private static ActionInvoker qv5lf2ft976kgvnR2pJC;

	public Func<ActionInvokeEventArgs, object> Handler { get; private set; }

	public Func<ActionInvokeEventArgs, ActionCheckResult> CheckHandler { get; private set; }

	public IAuditObject ActionObject
	{
		[CompilerGenerated]
		get
		{
			return _003CActionObject_003Ek__BackingField;
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
					_003CActionObject_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
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

	public IAuditAction ActionType
	{
		[CompilerGenerated]
		get
		{
			return _003CActionType_003Ek__BackingField;
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
					_003CActionType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public ActionMethodMetadata MethodMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMethodMetadata_003Ek__BackingField;
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
					_003CMethodMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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

	public ActionInvoker([NotNull] IAuditObject actionObject, [NotNull] IAuditAction actionType, [NotNull] MethodInfo targetMethodInfo, [NotNull] Func<ActionInvokeEventArgs, object> handler, Func<ActionInvokeEventArgs, ActionCheckResult> checkHandler = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426399691));
		Contract.ArgumentNotNull(actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138617080));
		Contract.ArgumentNotNull(targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309454024));
		Contract.ArgumentNotNull(handler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867410627));
		Handler = handler;
		CheckHandler = checkHandler;
		ActionType = actionType;
		ActionObject = actionObject;
		MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
	}

	public object InvokeAction(ActionInvokeEventArgs e)
	{
		//Discarded unreachable code: IL_007a, IL_0089
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Handler != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				throw new InvalidOperationException((string)XkcxwoftgctsRmCwNyh7(TKAx1VftrfCDrbgPNRii(0x3CE17B75 ^ 0x3CE427CF)));
			case 1:
				return Handler(e);
			}
		}
	}

	public ActionCheckResult CheckAction(ActionInvokeEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				Func<ActionInvokeEventArgs, ActionCheckResult> checkHandler = CheckHandler;
				if (checkHandler == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
				return checkHandler(e);
			}
			default:
				return GPctldft5lUQjmCdtbY2();
			}
		}
	}

	internal static bool DhUYc7ftdH7PPXDRBnKE()
	{
		return qv5lf2ft976kgvnR2pJC == null;
	}

	internal static ActionInvoker btXnL4ftlKgcL1XjY2P1()
	{
		return qv5lf2ft976kgvnR2pJC;
	}

	internal static object TKAx1VftrfCDrbgPNRii(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XkcxwoftgctsRmCwNyh7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static ActionCheckResult GPctldft5lUQjmCdtbY2()
	{
		return ActionCheckResult.True;
	}
}
