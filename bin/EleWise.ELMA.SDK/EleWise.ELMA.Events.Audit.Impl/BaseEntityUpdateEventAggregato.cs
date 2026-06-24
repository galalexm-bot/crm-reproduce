using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class BaseEntityUpdateEventAggregator : IEntityActionEventAggregator
{
	internal static BaseEntityUpdateEventAggregator rFGkr5GcvolBOt70NxA0;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	protected abstract IEnumerable<Guid> ProcessedActions { get; }

	protected virtual IEnumerable<Guid> MergeOldEntityActions
	{
		[IteratorStateMachine(typeof(_003Cget_MergeOldEntityActions_003Ed__8))]
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003Cget_MergeOldEntityActions_003Ed__8(-2);
		}
	}

	protected BaseEntityUpdateEventAggregator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dCcpRqGcuYTeqQbxeVoa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Logger = (ILogger)oR4w5gGcIU3DcPWiI72L();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
			{
				num = 1;
			}
		}
	}

	protected virtual bool IsProcessedAction(EntityActionEventArgs @event)
	{
		//Discarded unreachable code: IL_0066, IL_0075
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (@event == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return ProcessedActions.Contains(wylGS0GcSvFcW2XcvdWh(EokPAQGcV6J2NKGRSG9q(@event)));
			default:
				return false;
			}
		}
	}

	protected virtual bool IsMergeAction(EntityActionEventArgs @event, EntityActionEventArgs processEvent)
	{
		//Discarded unreachable code: IL_0041, IL_0054, IL_0063
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return h2NOPdGcXosbdYTHLggg(dLW5YeGcKVWcd8SCM7lS(@event)).Equals(h2NOPdGcXosbdYTHLggg(dLW5YeGcKVWcd8SCM7lS(processEvent)));
				default:
					return false;
				case 2:
					if (@event != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 6:
					if (!OGyAnhGcqgVYNE7b5fkW(EaQ1QpGcR93En8wxdX4O(j9DhrgGcijSY9Eeg3hc4(@event)), EaQ1QpGcR93En8wxdX4O(processEvent.Object)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				case 1:
					if (!MergeOldEntityActions.Contains(wylGS0GcSvFcW2XcvdWh(EokPAQGcV6J2NKGRSG9q(@event))))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 5:
					if (processEvent == null)
					{
						break;
					}
					goto case 2;
				}
				break;
			}
			num = 4;
		}
	}

	protected virtual void MergeEventResult(ActionEventAggregatorResult eventResult, EntityActionEventArgs mergeEvent)
	{
		//Discarded unreachable code: IL_00b6, IL_00c5
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				MergeEventData((EntityActionEventArgs)dvmVotGcTNly3mqEKZm0(eventResult), mergeEvent);
				num2 = 3;
				continue;
			case 5:
				if (mergeEvent == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 2;
			case 3:
				return;
			case 4:
				return;
			case 1:
				if (eventResult == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (dvmVotGcTNly3mqEKZm0(eventResult) != null)
			{
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 5;
				}
				continue;
			}
			return;
		}
	}

	protected virtual void MergeEventData([NotNull] EntityActionEventArgs @event, [NotNull] EntityActionEventArgs mergeEvent)
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
				o4QCY9Gcka4e2KPtOHvV(@event, mergeEvent.Old);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		try
		{
			using List<ActionEventAggregatorResult>.Enumerator enumerator = previousResults.Where((ActionEventAggregatorResult r) => id8ChuGcnYBNBoN8pQ10(this, r.EventArgs)).ToList().GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.eventResult = enumerator.Current;
				foreach (EntityActionEventArgs item in eventList.Where((EntityActionEventArgs e) => _003C_003Ec__DisplayClass13_0.d6Iklw8VGIBT5aVlY6hv(CS_0024_003C_003E8__locals0._003C_003E4__this, e, _003C_003Ec__DisplayClass13_0.WhJCtR8Vhj9IV3Sb2mmt(CS_0024_003C_003E8__locals0.eventResult))).ToList())
				{
					MergeEventResult(CS_0024_003C_003E8__locals0.eventResult, item);
				}
			}
		}
		catch (Exception exception)
		{
			Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8356B80)), exception);
		}
		return Enumerable.Empty<ActionEventAggregatorResult>();
	}

	internal static void dCcpRqGcuYTeqQbxeVoa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object oR4w5gGcIU3DcPWiI72L()
	{
		return NullLogger.Instance;
	}

	internal static bool V6UHM7Gc8jlVX7YSLaeR()
	{
		return rFGkr5GcvolBOt70NxA0 == null;
	}

	internal static BaseEntityUpdateEventAggregator JX6eCWGcZ8oVkLmcGtqs()
	{
		return rFGkr5GcvolBOt70NxA0;
	}

	internal static object EokPAQGcV6J2NKGRSG9q(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static Guid wylGS0GcSvFcW2XcvdWh(object P_0)
	{
		return ((IAuditAction)P_0).Uid;
	}

	internal static object j9DhrgGcijSY9Eeg3hc4(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static Guid EaQ1QpGcR93En8wxdX4O(object P_0)
	{
		return ((IAuditObject)P_0).Uid;
	}

	internal static bool OGyAnhGcqgVYNE7b5fkW(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object dLW5YeGcKVWcd8SCM7lS(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static object h2NOPdGcXosbdYTHLggg(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object dvmVotGcTNly3mqEKZm0(object P_0)
	{
		return ((ActionEventAggregatorResult)P_0).EventArgs;
	}

	internal static void o4QCY9Gcka4e2KPtOHvV(object P_0, object P_1)
	{
		((EntityActionEventArgs)P_0).Old = (IEntity)P_1;
	}

	internal static bool id8ChuGcnYBNBoN8pQ10(object P_0, object P_1)
	{
		return ((BaseEntityUpdateEventAggregator)P_0).IsProcessedAction((EntityActionEventArgs)P_1);
	}
}
