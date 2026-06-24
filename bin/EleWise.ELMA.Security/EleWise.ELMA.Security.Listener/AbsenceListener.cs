using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
public class AbsenceListener : EntityEventsListener
{
	internal static AbsenceListener DvtwFwHK0GHGGvFjM0k;

	public IComplexCacheService ComplexCacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CComplexCacheService_003Ek__BackingField;
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
					_003CComplexCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
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

	public override void OnPostInsert(PostInsertEvent @event)
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
				RefreshCache(HFZL9sHOH4oUjZvtcJW(@event));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
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
				RefreshCache(HFZL9sHOH4oUjZvtcJW(@event));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
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
				RefreshCache(HFZL9sHOH4oUjZvtcJW(@event));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void RefreshCache(object entity)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 2;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		IAbsence absence = default(IAbsence);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				user = (EleWise.ELMA.Security.Models.IUser)WiBqhUHqEyueJuSOZKk(absence);
				num2 = 4;
				break;
			case 1:
				if (absence == null)
				{
					return;
				}
				num2 = 5;
				break;
			case 3:
				return;
			case 4:
				ComplexCacheService.RefreshTimestamp((string)mHVaPGHFyakecFlNhTx(v2KTdDHceBrvNSj4f3Y(-1826813434 ^ -1826797626), pHZHT8HGAgdKXjk4H08(user)));
				num2 = 3;
				break;
			case 2:
				absence = entity as IAbsence;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public AbsenceListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Sth2t3H0KOHDaxE4hFC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lZv5FbHtss9OAG3JDDp()
	{
		return DvtwFwHK0GHGGvFjM0k == null;
	}

	internal static AbsenceListener AJK1VcHh2FykcgpyNPf()
	{
		return DvtwFwHK0GHGGvFjM0k;
	}

	internal static object HFZL9sHOH4oUjZvtcJW(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object WiBqhUHqEyueJuSOZKk(object P_0)
	{
		return ((IAbsence)P_0).User;
	}

	internal static object v2KTdDHceBrvNSj4f3Y(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object pHZHT8HGAgdKXjk4H08(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object mHVaPGHFyakecFlNhTx(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void Sth2t3H0KOHDaxE4hFC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
