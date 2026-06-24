using System;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

[Serializable]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public abstract class ActionImplAttribute : AuditableAttribute
{
	private IAuditObject _auditObject;

	private IAuditAction _auditAction;

	private string _auditActionByUid;

	private Guid _auditActionUid;

	private Guid _auditObjectUid;

	private static ActionImplAttribute iEsqNffw06wj6xwQ1nJy;

	internal Guid AuditObjectUid
	{
		get
		{
			return _auditObjectUid;
		}
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
					_auditObjectUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected void Apply(string actionTypeUid, string auditObjectUid = null)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_00a0
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_auditObjectUid = Guid.Empty;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (Guid.TryParse(auditObjectUid, out _auditObjectUid))
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 6:
					return;
				case 3:
					if (Guid.TryParse(actionTypeUid, out _auditActionUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 1:
					return;
				case 5:
					break;
				case 4:
					_auditActionByUid = actionTypeUid;
					num2 = 3;
					continue;
				}
				break;
			}
			_auditActionUid = Guid.Empty;
			num = 2;
		}
	}

	private void Initialize()
	{
		//Discarded unreachable code: IL_00c7, IL_0205, IL_0214, IL_0224
		int num = 1;
		int num2 = num;
		IAuditManager serviceNotNull = default(IAuditManager);
		while (true)
		{
			switch (num2)
			{
			case 12:
				if (_auditAction == null)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 9:
				if (_auditObject == null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 10:
				throw new InvalidOperationException(SR.T((string)tcLdgvfwMUqeZZM9hEr1(-643786247 ^ -643447269), _auditActionUid));
			case 2:
				return;
			case 3:
				return;
			case 6:
				if (_auditObject == null)
				{
					num2 = 13;
					break;
				}
				if (_auditAction != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 11;
			case 4:
				_auditObject = (IAuditObject)Gxkhxtfwdx5pd5YTfXUy(serviceNotNull, _auditObjectUid);
				num2 = 6;
				break;
			case 1:
				if (_auditObjectUid == Guid.Empty)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (!GsrgZZfw9s07ABKOpqwu(_auditActionUid, Guid.Empty))
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 13:
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17A893A4), _auditObjectUid));
			case 5:
				if (_auditObject != null)
				{
					num2 = 3;
					break;
				}
				goto case 14;
			case 11:
				_auditAction = (IAuditAction)KQoDbPfwl6AbbdWmT4j4(serviceNotNull, _auditObject, _auditActionUid);
				num2 = 12;
				break;
			case 14:
				serviceNotNull = Locator.GetServiceNotNull<IAuditManager>();
				num2 = 9;
				break;
			case 7:
				throw new InvalidOperationException((string)nvl7WUfwJoaWUnCfDqco(tcLdgvfwMUqeZZM9hEr1(-787452571 ^ -787140023)));
			case 8:
				if (_auditAction != null)
				{
					num2 = 5;
					break;
				}
				goto case 14;
			default:
				throw new InvalidOperationException((string)nvl7WUfwJoaWUnCfDqco(tcLdgvfwMUqeZZM9hEr1(-561074844 ^ -561253466)));
			}
		}
	}

	public virtual IAuditAction GetAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Initialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return _auditAction;
			}
		}
	}

	public virtual IAuditObject GetObject()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Initialize();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return _auditObject;
			}
		}
	}

	protected ActionImplAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rQwC7mfwrrksKYZRVu5R();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NAcTUIfwmj4Eh8BEIrdj()
	{
		return iEsqNffw06wj6xwQ1nJy == null;
	}

	internal static ActionImplAttribute J1Ht30fwythEQgHinOCD()
	{
		return iEsqNffw06wj6xwQ1nJy;
	}

	internal static object tcLdgvfwMUqeZZM9hEr1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nvl7WUfwJoaWUnCfDqco(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool GsrgZZfw9s07ABKOpqwu(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object Gxkhxtfwdx5pd5YTfXUy(object P_0, Guid uid)
	{
		return ((IAuditManager)P_0).GetObject(uid);
	}

	internal static object KQoDbPfwl6AbbdWmT4j4(object P_0, object P_1, Guid uid)
	{
		return ((IAuditManager)P_0).GetAction((IAuditObject)P_1, uid);
	}

	internal static void rQwC7mfwrrksKYZRVu5R()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
