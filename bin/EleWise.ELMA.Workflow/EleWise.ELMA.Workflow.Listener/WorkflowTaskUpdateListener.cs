using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowTaskUpdateListener : EntityEventsListener
{
	internal static WorkflowTaskUpdateListener M0fUeHTH271skktv82l;

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00af, IL_01a6
		int num = 7;
		string key = default(string);
		long id = default(long);
		Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState> orAdd = default(Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState>);
		WorkflowPostTaskUpdateListener.OldTaskState value = default(WorkflowPostTaskUpdateListener.OldTaskState);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					key = id.ToString();
					num2 = 12;
					continue;
				case 5:
					if (!orAdd.TryGetValue(key, out value))
					{
						num2 = 8;
						continue;
					}
					goto case 13;
				case 6:
					if (workflowTaskBase != null)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 4;
				case 14:
					if (VMxmkMT90isMUSL9IAu(workflowTaskBase) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					id = workflowTaskBase.Id;
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					workflowTaskBase = ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as IWorkflowTaskBase;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 6;
					}
					continue;
				case 13:
					if (ONCptnT3HKtjxkICxAH(value))
					{
						num2 = 2;
						continue;
					}
					goto case 10;
				case 15:
					m0ve3XTQ3vZuB8e1Dqb(value, true);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					GJ6419TTKOW31JrXVaj(value, Krr3n5Tq5fl7EJl67Rr(xMwKnNT6j6XdfgZTPio(@event)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
				case 2:
				case 3:
					return VFmf5gTpJkaJb2CfQmE(this, @event);
				case 4:
					return base.OnPreUpdate(@event);
				case 10:
					X8P5p9TRc4JkSP8MbqN(value, AusRnkTjAHUm4cTRP8J(@event));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					break;
				case 8:
				{
					WorkflowPostTaskUpdateListener.OldTaskState oldTaskState = new WorkflowPostTaskUpdateListener.OldTaskState();
					X8P5p9TRc4JkSP8MbqN(oldTaskState, AusRnkTjAHUm4cTRP8J(@event));
					oldTaskState.PropertyNames = (string[])Krr3n5Tq5fl7EJl67Rr(xMwKnNT6j6XdfgZTPio(@event));
					oldTaskState.IsFilled = true;
					value = oldTaskState;
					num2 = 9;
					continue;
				}
				case 12:
					orAdd = ContextVars.GetOrAdd((string)JuAMfVTWX4yPaZrZoya(0x628167BE ^ 0x628194D8), () => new Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState>());
					num2 = 5;
					continue;
				}
				break;
			}
			orAdd[key] = value;
			num = 3;
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_01d2
		int num = 15;
		string key2 = default(string);
		CollectionEntry val = default(CollectionEntry);
		string key = default(string);
		long id = default(long);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		WorkflowPostTaskUpdateListener.OldTaskState value = default(WorkflowPostTaskUpdateListener.OldTaskState);
		IEnumerable enumerable = default(IEnumerable);
		Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState> orAdd = default(Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 12:
					key2 = ((string)kXEPi5TVycubyGh3AQj(val)).Split(new char[1] { '.' }).LastOrDefault();
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					key = id.ToString();
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					if (workflowTaskBase != null)
					{
						num2 = 11;
						break;
					}
					return;
				case 8:
					value = new WorkflowPostTaskUpdateListener.OldTaskState();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					return;
				case 3:
					return;
				case 1:
					enumerable = WiZUADTAtwI6aml43c5(val) as IEnumerable;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 8;
					}
					break;
				case 7:
					return;
				case 14:
					workflowTaskBase = IwGq3DTC4SIsbKVyHl0(@event) as IWorkflowTaskBase;
					num2 = 5;
					break;
				case 15:
					if (@event == null)
					{
						return;
					}
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 8;
					}
					break;
				case 9:
					val = (CollectionEntry)huXx7kTUs0t9TmD8bS5(((ISessionImplementor)ngR2rwTMBjVP3mNG5U7(@event)).get_PersistenceContext(), hhxRKjTkun3hqsbevH3(@event));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 12;
					}
					break;
				case 6:
					if (!orAdd.TryGetValue(key, out value))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 13:
					if (enumerable != null)
					{
						value.OldCollectionState.AddIfNotContainsKey(key2, enumerable);
						num2 = 4;
						break;
					}
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 6;
					}
					break;
				case 11:
					if (VMxmkMT90isMUSL9IAu(workflowTaskBase) != null)
					{
						id = workflowTaskBase.Id;
						num2 = 2;
					}
					else
					{
						num2 = 3;
					}
					break;
				default:
					orAdd[key] = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 1;
					}
					break;
				case 16:
					orAdd = ContextVars.GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B70542), () => new Dictionary<string, WorkflowPostTaskUpdateListener.OldTaskState>());
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 6;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public WorkflowTaskUpdateListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mt4xamTGYGrcSZFWnKt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object VMxmkMT90isMUSL9IAu(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object JuAMfVTWX4yPaZrZoya(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AusRnkTjAHUm4cTRP8J(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_OldState();
	}

	internal static void X8P5p9TRc4JkSP8MbqN(object P_0, object P_1)
	{
		((WorkflowPostTaskUpdateListener.OldTaskState)P_0).OldState = (object[])P_1;
	}

	internal static object xMwKnNT6j6XdfgZTPio(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object Krr3n5Tq5fl7EJl67Rr(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static bool ONCptnT3HKtjxkICxAH(object P_0)
	{
		return ((WorkflowPostTaskUpdateListener.OldTaskState)P_0).IsFilled;
	}

	internal static void GJ6419TTKOW31JrXVaj(object P_0, object P_1)
	{
		((WorkflowPostTaskUpdateListener.OldTaskState)P_0).PropertyNames = (string[])P_1;
	}

	internal static void m0ve3XTQ3vZuB8e1Dqb(object P_0, bool value)
	{
		((WorkflowPostTaskUpdateListener.OldTaskState)P_0).IsFilled = value;
	}

	internal static bool VFmf5gTpJkaJb2CfQmE(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreUpdate((PreUpdateEvent)P_1);
	}

	internal static bool dY4lOGTLbVqOgcHZ8uQ()
	{
		return M0fUeHTH271skktv82l == null;
	}

	internal static WorkflowTaskUpdateListener y6y1MKTfo03TeywJYUh()
	{
		return M0fUeHTH271skktv82l;
	}

	internal static object IwGq3DTC4SIsbKVyHl0(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static object ngR2rwTMBjVP3mNG5U7(object P_0)
	{
		return ((AbstractEvent)P_0).get_Session();
	}

	internal static object hhxRKjTkun3hqsbevH3(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_Collection();
	}

	internal static object huXx7kTUs0t9TmD8bS5(object P_0, object P_1)
	{
		return ((IPersistenceContext)P_0).GetCollectionEntry((IPersistentCollection)P_1);
	}

	internal static object kXEPi5TVycubyGh3AQj(object P_0)
	{
		return ((CollectionEntry)P_0).get_Role();
	}

	internal static object WiZUADTAtwI6aml43c5(object P_0)
	{
		return ((CollectionEntry)P_0).get_Snapshot();
	}

	internal static void mt4xamTGYGrcSZFWnKt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
