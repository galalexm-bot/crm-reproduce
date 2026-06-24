using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

public abstract class BaseEntityActionHandler : IEntityActionHandler, IEventHandler
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private static BaseEntityActionHandler qBAR4sGsa0BZ0gJeOPEr;

	protected virtual bool TransactionRequired => true;

	protected abstract string EventListContextKey { get; }

	public BaseEntityActionHandler([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] IUnitOfWorkManager unitOfWorkManager)
	{
		//Discarded unreachable code: IL_002a, IL_00a1, IL_00b0
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (contextBoundVariableService == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num = 0;
					}
					break;
				}
				if (unitOfWorkManager != null)
				{
					num = 4;
					break;
				}
				goto case 5;
			case 2:
				return;
			case 1:
				throw new ArgumentNullException((string)geLdTtGswyETuOqjeRdj(-1876063057 ^ -1876323857));
			case 5:
				throw new ArgumentNullException((string)geLdTtGswyETuOqjeRdj(0x31326106 ^ 0x31367C7C));
			case 4:
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			default:
			{
				this.unitOfWorkManager = unitOfWorkManager;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	public void ActionExecuted(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0098, IL_00f4
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (e != null)
					{
						if (!NeedPersistEvent(e))
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto end_IL_0012;
				case 2:
					if (RwfWr0Gs6bS0Mc30eCwF(unitOfWorkManager, ""))
					{
						num2 = 6;
						break;
					}
					goto case 7;
				case 1:
					return;
				case 8:
					return;
				default:
					if (!RLaEK5Gs439G5QVLDfDi(this))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return;
				case 7:
					throw new TransactionRequiredException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FE1D6E), (QpyV3AGsHrsuwAamPwwC(e) != null) ? FgW3k1GsAdol8C1OpMqj(QpyV3AGsHrsuwAamPwwC(e)) : "", (RDxujnGs7ZmCer3TPFUe(e) != null) ? ((IAuditObject)RDxujnGs7ZmCer3TPFUe(e)).Name : ""));
				case 5:
				case 6:
					UJHDTvGsxdhI0CwVp5GP(this, e);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected virtual void PersistEvent(EntityActionEventArgs e)
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
				contextBoundVariableService.GetOrAdd((string)eXmrnYGs0q53Rabpip3o(this), () => new List<EntityActionEventArgs>()).Add(e);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected abstract bool NeedPersistEvent(EntityActionEventArgs e);

	internal static object geLdTtGswyETuOqjeRdj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Qa6SPBGsDw7K6YFwq2EC()
	{
		return qBAR4sGsa0BZ0gJeOPEr == null;
	}

	internal static BaseEntityActionHandler zWjHy1GstWuhwQ2Jfbo8()
	{
		return qBAR4sGsa0BZ0gJeOPEr;
	}

	internal static bool RLaEK5Gs439G5QVLDfDi(object P_0)
	{
		return ((BaseEntityActionHandler)P_0).TransactionRequired;
	}

	internal static bool RwfWr0Gs6bS0Mc30eCwF(object P_0, object P_1)
	{
		return ((IUnitOfWorkManager)P_0).HasActiveTransaction((string)P_1);
	}

	internal static object QpyV3AGsHrsuwAamPwwC(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static object FgW3k1GsAdol8C1OpMqj(object P_0)
	{
		return ((IAuditAction)P_0).Name;
	}

	internal static object RDxujnGs7ZmCer3TPFUe(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static void UJHDTvGsxdhI0CwVp5GP(object P_0, object P_1)
	{
		((BaseEntityActionHandler)P_0).PersistEvent((EntityActionEventArgs)P_1);
	}

	internal static object eXmrnYGs0q53Rabpip3o(object P_0)
	{
		return ((BaseEntityActionHandler)P_0).EventListContextKey;
	}
}
