using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SchedulerTaskJobManager : EntityManager<ISchedulerTaskJob, long>
{
	private static SchedulerTaskJobManager yD9nlmBTPmTQG2PmcASn;

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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

	[Transaction]
	public virtual void DeleteJobs(long[] jobIds)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_008e
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 5:
				return;
			case 4:
				if (jobIds == null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				if (Uo4y4ABT3D2hsQtYjlMr(jobIds))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 2:
				return;
			case 1:
			{
				object obj = LbNZjDBTpXeijSIPSFHg(base.SessionProvider, "");
				LAI6vkBTaEDd7Z4UBdXc(obj);
				string text = string.Format((string)WTS86yBTDLseZsE6BRAK(-606654180 ^ -606725626), d1f5cUBTwFGmWywZUFZh(RF63REBTtbtPFmt1VGdN(TransformationProvider), WTS86yBTDLseZsE6BRAK(-1939377524 ^ -1939449380)), ElmaInExpression.ToString((string)d1f5cUBTwFGmWywZUFZh(RF63REBTtbtPFmt1VGdN(TransformationProvider), WTS86yBTDLseZsE6BRAK(-867826612 ^ -867793646)), jobIds, DbType.Int64, null, null, (string)WTS86yBTDLseZsE6BRAK(-2107978722 ^ -2107981724)));
				sCJg9IBT6LtQgBh9CrmI(xPGN1OBT48rVdMhEwDxt(obj, text), false);
				((ISession)obj).CleanUpCache(typeof(ISchedulerTaskJob));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 5;
				}
				break;
			}
			}
		}
	}

	public SchedulerTaskJobManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TfiNbkBTHKI6DWmJS9M6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool OTB1OJBT1hEJkspYq0GX()
	{
		return yD9nlmBTPmTQG2PmcASn == null;
	}

	internal static SchedulerTaskJobManager MNl12WBTNcdbUQOtFfdZ()
	{
		return yD9nlmBTPmTQG2PmcASn;
	}

	internal static bool Uo4y4ABT3D2hsQtYjlMr(object P_0)
	{
		return EnumerableExtensions.Any((IEnumerable)P_0);
	}

	internal static object LbNZjDBTpXeijSIPSFHg(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void LAI6vkBTaEDd7Z4UBdXc(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static object WTS86yBTDLseZsE6BRAK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RF63REBTtbtPFmt1VGdN(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object d1f5cUBTwFGmWywZUFZh(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object xPGN1OBT48rVdMhEwDxt(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static int sCJg9IBT6LtQgBh9CrmI(object P_0, bool cleanUpCache)
	{
		return ((IQuery)P_0).ExecuteUpdate(cleanUpCache);
	}

	internal static void TfiNbkBTHKI6DWmJS9M6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
