using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit;

public class AuditEventHolder : IAuditEventHolder
{
	private IAuditObject _auditObject;

	private IAuditAction _auditAction;

	private static AuditEventHolder F8fGy7GsqBVpt8v6MS1f;

	public virtual IAuditObject Object
	{
		get
		{
			return _auditObject;
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
					_auditObject = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual IAuditAction Action
	{
		get
		{
			return _auditAction;
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
					_auditAction = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AuditEventHolder(IAuditObject auditObject, IAuditAction auditAction)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_auditAction = auditAction;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 0;
				}
				break;
			case 2:
				_auditObject = auditObject;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public AuditEventHolder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KemfibGsT5LbPSKYQrPN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UuMbZjGsKxFFAKqfJN65()
	{
		return F8fGy7GsqBVpt8v6MS1f == null;
	}

	internal static AuditEventHolder xrN25nGsX8GWT4oCxADt()
	{
		return F8fGy7GsqBVpt8v6MS1f;
	}

	internal static void KemfibGsT5LbPSKYQrPN()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
