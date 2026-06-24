using System;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class DateTimeWithoutOffsetNHType : DateTimeNHType
{
	private static DateTimeWithoutOffsetNHType sUkdUFW0W6IPJXsahCYP;

	public override object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		return tFJPjRW0h6YQqFbT70XT(NHibernateUtil.DateTime, rs, names[0], session);
	}

	public override void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				((IDataParameter)CUcwjHW0Ea0nwXUv3wTR(X7mYagW0Gbl8TvDu2iyj(cmd), index)).Value = DBNull.Value;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				dateTime = (DateTime)value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 4:
				return;
			case 3:
				((IDataParameter)CUcwjHW0Ea0nwXUv3wTR(X7mYagW0Gbl8TvDu2iyj(cmd), index)).Value = ((dateTime != default(DateTime)) ? ((object)dateTime) : DBNull.Value);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public DateTimeWithoutOffsetNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YxKMvqW0fI4xHxSL88HB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object tFJPjRW0h6YQqFbT70XT(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static bool RwPAkmW0oDL6C37nK1Br()
	{
		return sUkdUFW0W6IPJXsahCYP == null;
	}

	internal static DateTimeWithoutOffsetNHType H9XXhbW0bPvo369SwdOS()
	{
		return sUkdUFW0W6IPJXsahCYP;
	}

	internal static object X7mYagW0Gbl8TvDu2iyj(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object CUcwjHW0Ea0nwXUv3wTR(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void YxKMvqW0fI4xHxSL88HB()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
