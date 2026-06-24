using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit;

[Component]
public class EntityUpdateByWorkflowTaskCollector : BaseEntityActionHistoryCollectorRelated
{
	private EntityActionHistoryManager entityActionHistoryManager;

	private readonly Guid collectorGuid;

	public static readonly string UID;

	private static EntityUpdateByWorkflowTaskCollector iXSlQ7ZDjAAhjm3Pf0oj;

	public EntityUpdateByWorkflowTaskCollector(EntityActionHistoryManager entityActionHistoryManager)
	{
		//Discarded unreachable code: IL_003f, IL_0044
		PjITf8ZDqew9PcUppCyq();
		collectorGuid = new Guid(UID);
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.entityActionHistoryManager = entityActionHistoryManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.actionObject = actionObject;
		_003C_003Ec__DisplayClass4_.id = id;
		List<EntityActionEventArgs> list = new List<EntityActionEventArgs>();
		using IEnumerator<HistoryCollectorRelatedModel> enumerator = relatedObjectList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass4_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass4_;
			CS_0024_003C_003E8__locals0.related = enumerator.Current;
			if (!(CS_0024_003C_003E8__locals0.related.CollectorGuid == collectorGuid))
			{
				continue;
			}
			EntityActionEventArgs[] array = relatedEventList.Where(delegate(EntityActionEventArgs @event)
			{
				int num = 3;
				int num2 = num;
				Guid guid = default(Guid);
				while (true)
				{
					switch (num2)
					{
					case 5:
						guid = _003C_003Ec__DisplayClass4_1.X4dt1ev9raY0qUSnFGVe(@event.Action);
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 1;
						}
						break;
					case 6:
						if (guid.Equals(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.actionObject))
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_009d;
					case 1:
						return guid.Equals(DefaultEntityActions.UpdateGuid);
					case 3:
						guid = _003C_003Ec__DisplayClass4_1.NG0rgmv9oN4IKNkC9SfT(@event);
						num2 = 2;
						break;
					case 2:
						if (guid.Equals(_003C_003Ec__DisplayClass4_1.gRW3vTv9FBkTyQl60bPb(CS_0024_003C_003E8__locals0.related)))
						{
							num2 = 4;
							break;
						}
						goto IL_009d;
					case 4:
						guid = _003C_003Ec__DisplayClass4_1.Ddv9Fpv9i6dS2jmkW1MB(@event.Metadata);
						num2 = 6;
						break;
					default:
						{
							if ((long)_003C_003Ec__DisplayClass4_1.UvW55qv9aO8tWMSDofuA(_003C_003Ec__DisplayClass4_1.DTfhv1v9Imfp6fSesm9R(@event)) == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.id)
							{
								num2 = 5;
								break;
							}
							goto IL_009d;
						}
						IL_009d:
						return false;
					}
				}
			}).ToArray();
			foreach (EntityActionEventArgs entityActionEventArgs in array)
			{
				entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001970402)] = UID;
				entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111072139)] = CS_0024_003C_003E8__locals0.related;
				list.Add(entityActionEventArgs);
			}
		}
		return list;
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.id = id;
		CS_0024_003C_003E8__locals0.actionObject = actionObject;
		Guid targetType = InterfaceActivator.UID<IWorkflowTask>();
		List<HistoryCollectorRelatedModel> list = entityActionHistoryManager.GetUpdateHistoryInSameUnitOfWorkWithType(CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.actionObject, targetType, DefaultEntityActions.UpdateGuid).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539919173)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002031633)).Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F70D8A)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F461A30))
			.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708308642)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050236514)) }).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryCollectorRelatedModel)))
			.List<HistoryCollectorRelatedModel>()
			.Where(delegate(HistoryCollectorRelatedModel a)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (_003C_003Ec__DisplayClass5_0.Yp9L1Sv91PDwdbvU01Ms(a) == CS_0024_003C_003E8__locals0.id)
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return _003C_003Ec__DisplayClass5_0.ublSh4v9hiXNdRr5p3R9(a.EntityTypeUid, CS_0024_003C_003E8__locals0.actionObject);
					}
				}
			})
			.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			list[i].CollectorGuid = collectorGuid;
		}
		return list;
	}

	static EntityUpdateByWorkflowTaskCollector()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PjITf8ZDqew9PcUppCyq();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF42CEC4);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void PjITf8ZDqew9PcUppCyq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool BJ5POaZDRAhpYi1s5nLY()
	{
		return iXSlQ7ZDjAAhjm3Pf0oj == null;
	}

	internal static EntityUpdateByWorkflowTaskCollector mnF1wKZD6UkOXocY5rsP()
	{
		return iXSlQ7ZDjAAhjm3Pf0oj;
	}
}
