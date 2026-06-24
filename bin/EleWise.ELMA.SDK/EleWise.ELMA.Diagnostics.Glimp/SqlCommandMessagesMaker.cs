using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Events;
using Glimpse.Ado.Message;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse.MessagesMakers;

[Component]
internal class SqlCommandMessagesMaker : AbstractMessagesMaker
{
	internal static SqlCommandMessagesMaker lknvasERkNRR79io3bUm;

	public override Type[] SupportedEventTypes => new Type[2]
	{
		TypeOf<SqlCommandExecuteEndEvent>.Raw,
		TypeOf<SqlCommandExecuteErrorEvent>.Raw
	};

	public override object[] MakeMessages(DiagnosticsEvent @event)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00cb: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent = default(IDiagnosticsCallInfoEvent);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		CommandDurationAndRowCountMessage val2 = default(CommandDurationAndRowCountMessage);
		TimerResult val = default(TimerResult);
		DbCommandExecuteMessage dbCommandExecuteMessage = default(DbCommandExecuteMessage);
		while (true)
		{
			switch (num2)
			{
			case 2:
				diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (t7y1cdERwPIwcmo3AaQc(sqlQueryInfo) != null)
				{
					num2 = 7;
					break;
				}
				val2 = TimedMessageExtension.AsTimedMessage<CommandDurationAndRowCountMessage>(TimelineMessageExtension.AsTimelineMessage<CommandDurationAndRowCountMessage>(new CommandDurationAndRowCountMessage(wjeLWTER4IgZkTP5Axj0(sqlQueryInfo), QoWBKqERDbXxWkFLsAb8(sqlQueryInfo), sqlQueryInfo.RowsAffected), (string)tTxx5MER6jK4EVPUXBI6(sqlQueryInfo), (TimelineCategoryItem)xQeIU7ERHJAmR1ko1Tpg(), (string)null), val);
				num2 = 6;
				break;
			case 1:
				if (diagnosticsCallInfoEvent != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 3:
				return new object[0];
			case 7:
				return new object[1] { dbCommandExecuteMessage };
			case 6:
				return new object[2] { dbCommandExecuteMessage, val2 };
			case 4:
				if ((sqlQueryInfo = diagnosticsCallInfoEvent.Info as SqlQueryInfo) != null)
				{
					TimerResult val3 = new TimerResult();
					vpbr7jERe6JhbNMjm8hI((object)val3, XRcCbrER2Av1tdsaxxdw(sqlQueryInfo));
					tMnkFaER3eg3UOoJM7aP((object)val3, pKBswSERNBreDdDBPPnl(XRcCbrER2Av1tdsaxxdw(sqlQueryInfo), choqwIER1Hpykk4LFvqh(GcMomFERPGcETaZEmAbP(sqlQueryInfo))));
					EpE93DERa6XA5KmtoqRB((object)val3, EYq6x1ERpvlRhW34Dnly(sqlQueryInfo));
					val = val3;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			default:
				dbCommandExecuteMessage = TimelineMessageExtension.AsTimelineMessage<DbCommandExecuteMessage>(TimedMessageExtension.AsTimedMessage<DbCommandExecuteMessage>(new DbCommandExecuteMessage(sqlQueryInfo.ConnectionId, QoWBKqERDbXxWkFLsAb8(sqlQueryInfo), sqlQueryInfo.Sql, ((IEnumerable<SqlQueryInfo.CommandParamater>)sqlQueryInfo.Paramaters).Select((Func<SqlQueryInfo.CommandParamater, CommandExecutedParamater>)delegate(SqlQueryInfo.CommandParamater p)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0011: Expected O, but got Unknown
					//IL_0011: Unknown result type (might be due to invalid IL or missing references)
					//IL_001d: Expected O, but got Unknown
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0029: Expected O, but got Unknown
					//IL_0029: Unknown result type (might be due to invalid IL or missing references)
					//IL_0035: Expected O, but got Unknown
					//IL_0036: Expected O, but got Unknown
					CommandExecutedParamater val4 = new CommandExecutedParamater();
					_003C_003Ec.EurDsY8XIjp11obo68JC((object)val4, p.Name);
					_003C_003Ec.y9AxYa8XSEMjWJ8GUVku((object)val4, _003C_003Ec.rYo4CR8XVDxiY67PIWhQ(p));
					_003C_003Ec.Yxfmsi8XRlCuLh4O81Y5((object)val4, _003C_003Ec.hCnuh58Xi5cRfSBdKpVw(p));
					_003C_003Ec.oe3JIj8XKKndXs1icICS((object)val4, _003C_003Ec.ssNueP8XqEGVkRb8aY36(p));
					return val4;
				}).ToList(), hasTransaction: true), val), (string)krAWKUERt4F3rI4EYCL4(sqlQueryInfo), AdoTimelineCategory.get_Command(), (t7y1cdERwPIwcmo3AaQc(sqlQueryInfo) != null) ? ((Exception)t7y1cdERwPIwcmo3AaQc(sqlQueryInfo)).Message : "");
				num2 = 5;
				break;
			}
		}
	}

	public SqlCommandMessagesMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bBEO7iERnn0FNvuIGnWf()
	{
		return lknvasERkNRR79io3bUm == null;
	}

	internal static SqlCommandMessagesMaker DmufbmERO20uACQlnFQm()
	{
		return lknvasERkNRR79io3bUm;
	}

	internal static DateTime XRcCbrER2Av1tdsaxxdw(object P_0)
	{
		return ((AbstractCallInfo)P_0).StartTime;
	}

	internal static void vpbr7jERe6JhbNMjm8hI(object P_0, DateTime P_1)
	{
		((TimerResult)P_0).set_StartTime(P_1);
	}

	internal static object GcMomFERPGcETaZEmAbP(object P_0)
	{
		return ((AbstractCallInfo)P_0).ContextInfo;
	}

	internal static DateTime choqwIER1Hpykk4LFvqh(object P_0)
	{
		return ((CallContextInfo)P_0).StartTime;
	}

	internal static TimeSpan pKBswSERNBreDdDBPPnl(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static void tMnkFaER3eg3UOoJM7aP(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Offset(P_1);
	}

	internal static TimeSpan EYq6x1ERpvlRhW34Dnly(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void EpE93DERa6XA5KmtoqRB(object P_0, TimeSpan P_1)
	{
		((TimerResult)P_0).set_Duration(P_1);
	}

	internal static Guid QoWBKqERDbXxWkFLsAb8(object P_0)
	{
		return ((SqlQueryInfo)P_0).CommandId;
	}

	internal static object krAWKUERt4F3rI4EYCL4(object P_0)
	{
		return ((SqlQueryInfo)P_0).Sql;
	}

	internal static object t7y1cdERwPIwcmo3AaQc(object P_0)
	{
		return ((AbstractCallInfo)P_0).Exception;
	}

	internal static Guid wjeLWTER4IgZkTP5Axj0(object P_0)
	{
		return ((SqlQueryInfo)P_0).ConnectionId;
	}

	internal static object tTxx5MER6jK4EVPUXBI6(object P_0)
	{
		return ((AbstractCallInfo)P_0).CallType;
	}

	internal static object xQeIU7ERHJAmR1ko1Tpg()
	{
		return AdoTimelineCategory.get_Command();
	}
}
