using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Constants;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class ObservedContextPropertyListener : PostFlushEventListener
{
	private static ObservedContextPropertyListener d1bSUC6lqBvSQFBUfsn;

	public IEnumerable<IWorkflowContextPropertyObserver> Observers { get; set; }

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_012a, IL_0139, IL_016c, IL_02ad, IL_02df, IL_034c, IL_035b, IL_03d6, IL_048d, IL_049c, IL_0538, IL_05bc, IL_05dc, IL_0630, IL_063f
		int num = 30;
		DataRow dataRow = default(DataRow);
		IEntity<long> entity = default(IEntity<long>);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		Type type = default(Type);
		string text = default(string);
		DataTable orAdd = default(DataTable);
		string[] array3 = default(string[]);
		IEntity<long>[] array = default(IEntity<long>[]);
		IEntity<long>[] array2 = default(IEntity<long>[]);
		IWorkflowInstanceContext workflowInstanceContext = default(IWorkflowInstanceContext);
		int num5 = default(int);
		EntitySettings entitySettings = default(EntitySettings);
		int num3 = default(int);
		long id = default(long);
		int num4 = default(int);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 26:
					qBKx3B6DT9cyZd42d1H(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, entity.Id);
					num = 33;
					break;
				case 40:
					_003C_003Ec__DisplayClass4_.propMd = (PropertyMetadata)qDXylU6BhTi19L5ZuG2(type, text, false);
					num2 = 7;
					continue;
				case 34:
					dataRow = orAdd.NewRow();
					num2 = 36;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 27;
					}
					continue;
				case 31:
					if (entity == null)
					{
						num2 = 13;
						continue;
					}
					goto case 26;
				case 35:
					array3 = (string[])fadUxj6gqSnCLyfUWyg(((AbstractPostDatabaseOperationEvent)@event).get_Persister());
					num2 = 45;
					continue;
				case 1:
				case 38:
					array = array2;
					num2 = 42;
					continue;
				case 3:
					qBKx3B6DT9cyZd42d1H(dataRow, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74AB1FBD), workflowInstanceContext.WorkflowInstance.Id);
					num2 = 32;
					continue;
				case 32:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(-11799394 ^ -11824880), Q3kgH86nYF2ZFHJFfVl(_003C_003Ec__DisplayClass4_.propMd));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 0;
					}
					continue;
				case 30:
					workflowInstanceContext = (IWorkflowInstanceContext)NKO69M6mtrVe0Iqe94C(((AbstractPostDatabaseOperationEvent)@event).get_Entity());
					num2 = 29;
					continue;
				case 10:
					array2 = new IEntity<long>[1] { ((object[])AhL7mF6X8yA2QruaUkm(@event))[num5] as IEntity<long> };
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 40;
					}
					continue;
				case 20:
					if (entitySettings == null)
					{
						num = 43;
						break;
					}
					goto case 39;
				case 14:
					obj = null;
					goto IL_06c9;
				case 22:
					type = workflowInstanceContext.CastAsRealType().GetType();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 35;
					}
					continue;
				case 28:
				case 46:
					if (num3 < array.Length)
					{
						num2 = 11;
						continue;
					}
					goto case 23;
				case 27:
					return;
				case 7:
					if (_003C_003Ec__DisplayClass4_.propMd == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 15;
				case 16:
					dataRow[(string)vXqiaa6uIXgWxM9ZKJw(-961162596 ^ -961188496)] = _003C_003Ec__DisplayClass4_.propMd.SubTypeUid;
					num2 = 49;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 6;
					}
					continue;
				case 21:
				case 33:
					((DataRowCollection)LgwkbB6LDpeQZe2GU9l(orAdd)).Add(dataRow);
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 7;
					}
					continue;
				case 44:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(0x2269BD32 ^ 0x226902D2), _003C_003Ec__DisplayClass4_.propMd.TypeUid);
					num2 = 16;
					continue;
				case 36:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(0x2269BD32 ^ 0x2269FBD4), id);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 44;
					}
					continue;
				case 5:
					if (entity != null)
					{
						num2 = 17;
						continue;
					}
					goto case 14;
				case 25:
					num3++;
					num2 = 46;
					continue;
				case 42:
					num3 = 0;
					num = 28;
					break;
				case 37:
					if (entitySettings.RelationType == RelationType.OneToOne)
					{
						num2 = 10;
						continue;
					}
					goto case 24;
				case 12:
					return;
				case 49:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(0x614274E3 ^ 0x6142647B), workflowInstanceContext.GetId());
					num2 = 3;
					continue;
				case 11:
				case 41:
					entity = array[num3];
					num2 = 5;
					continue;
				case 2:
				case 8:
					text = array3[num4];
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
				case 9:
					if (num4 >= array3.Length)
					{
						return;
					}
					num2 = 2;
					continue;
				case 23:
				case 43:
				case 48:
					num4++;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					entitySettings = THe4wW6c9yqiZUjLRCZ(_003C_003Ec__DisplayClass4_.propMd) as EntitySettings;
					num2 = 20;
					continue;
				case 45:
					num4 = 0;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
				case 47:
					qBKx3B6DT9cyZd42d1H(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, DBNull.Value);
					num2 = 21;
					continue;
				case 29:
					if (workflowInstanceContext != null)
					{
						id = ((IEntity<long>)KtqnsH65utv8BLIcAMc(RkvABH6bxtJy7H5k5Uu(jkgcQc6tZ4qC0kvCUBk(workflowInstanceContext)))).Id;
						num2 = 18;
					}
					else
					{
						num2 = 27;
					}
					continue;
				case 39:
					num5 = Array.IndexOf((string[])fadUxj6gqSnCLyfUWyg(xR5RbN6PH1nuQnBFNwn(@event)), text);
					num2 = 37;
					continue;
				case 15:
					if (Observers.FirstOrDefault(_003C_003Ec__DisplayClass4_._003COnPostInsert_003Eb__1) != null)
					{
						num2 = 19;
						continue;
					}
					goto case 23;
				case 24:
					array2 = (@event.get_State()[num5] as IEnumerable).CastToArrayOrNull<IEntity<long>>();
					num2 = 38;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 31;
					}
					continue;
				case 18:
					orAdd = ContextVars.GetOrAdd(ObjectStartableByRouteConstant.InsertKey, delegate
					{
						DataTable dataTable = new DataTable((string)_003C_003Ec.iTugMXZUep3RStaoURRm(--1212129906 ^ 0x483FC66A));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(dataTable.Columns, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542172676), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(long).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), _003C_003Ec.iTugMXZUep3RStaoURRm(-772614310 ^ -772642630), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(Guid).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), _003C_003Ec.iTugMXZUep3RStaoURRm(-1028861977 ^ -1028886517), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(Guid).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351365594), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(long).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), _003C_003Ec.iTugMXZUep3RStaoURRm(0x7AC609FE ^ 0x7AC65154), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(long).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F44BCB4), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(Guid).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), ObservedContextPropertyConsts.Fields.ObjectOI, typeof(long));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), ObservedContextPropertyConsts.Fields.ObjectTU, typeof(Guid));
						return dataTable;
					});
					num2 = 22;
					continue;
				case 17:
					obj = (EntityMetadata)XqaVrg6dmcYapCmrqmb(entity.CastAsRealType().GetType(), false, true);
					goto IL_06c9;
				default:
					{
						dataRow[ObservedContextPropertyConsts.Fields.ObjectTU] = ((entityMetadata != null) ? MVjO1w6Hb9XMu1iMXKd(entityMetadata) : Guid.Empty);
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 31;
						}
						continue;
					}
					IL_06c9:
					entityMetadata = (EntityMetadata)obj;
					num2 = 34;
					continue;
				}
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_018a, IL_02be, IL_0385, IL_03db, IL_03ea, IL_03fa, IL_0409, IL_0485, IL_048f, IL_0515, IL_0582, IL_0591, IL_05a1
		int num = 44;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		IEntity<long> entity2 = default(IEntity<long>);
		int num4 = default(int);
		IWorkflowInstanceContext workflowInstanceContext = default(IWorkflowInstanceContext);
		string text = default(string);
		IEntity<long> entity = default(IEntity<long>);
		DataRow dataRow = default(DataRow);
		EntitySettings entitySettings = default(EntitySettings);
		DataTable orAdd = default(DataTable);
		int num3 = default(int);
		string[] propertyNames = default(string[]);
		long id = default(long);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 11:
					if (_003C_003Ec__DisplayClass5_.propMd != null)
					{
						num = 30;
						break;
					}
					goto default;
				case 16:
					entity2 = ((object[])Y9jNxh6WHx03A5Dm6ap(@event))[num4] as IEntity<long>;
					num2 = 17;
					continue;
				case 27:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 12;
					continue;
				case 42:
					return;
				case 12:
					_003C_003Ec__DisplayClass5_.propMd = (PropertyMetadata)qDXylU6BhTi19L5ZuG2(workflowInstanceContext.CastAsRealType().GetType(), text, false);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					if (entity2 != null)
					{
						num2 = 45;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 36;
				case 18:
					if (entity != null)
					{
						num2 = 41;
						continue;
					}
					goto case 46;
				case 46:
					qBKx3B6DT9cyZd42d1H(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, DBNull.Value);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 2;
					}
					continue;
				case 33:
					num4 = Array.IndexOf((string[])fadUxj6gqSnCLyfUWyg(xR5RbN6PH1nuQnBFNwn(@event)), text);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					if (QQc23F6RuQmBJbcZSxs(entity) == entity2.GetId())
					{
						num2 = 14;
						continue;
					}
					goto case 5;
				case 36:
					if (entity != null)
					{
						num2 = 22;
						continue;
					}
					goto default;
				case 17:
					entity = ((object[])BcS62H6jwtwSmwGRjyo(@event))[num4] as IEntity<long>;
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 32;
					}
					continue;
				case 5:
				case 45:
					if (entity != null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 38;
				case 26:
					if (E0AZCU69IPUg5Uvf67A(entitySettings) == RelationType.OneToOne)
					{
						num2 = 33;
						continue;
					}
					goto default;
				case 43:
					if (workflowInstanceContext != null)
					{
						num = 39;
						break;
					}
					return;
				case 4:
				case 19:
					((DataRowCollection)LgwkbB6LDpeQZe2GU9l(orAdd)).Add(dataRow);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 40;
					}
					continue;
				case 9:
				case 14:
					if (entity == null)
					{
						num2 = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 36;
				case 41:
					qBKx3B6DT9cyZd42d1H(dataRow, ObservedContextPropertyConsts.Fields.ObjectOI, entity.Id);
					num2 = 19;
					continue;
				case 32:
					if (entity == null)
					{
						num2 = 9;
						continue;
					}
					goto case 10;
				default:
					num3++;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					entitySettings = THe4wW6c9yqiZUjLRCZ(_003C_003Ec__DisplayClass5_.propMd) as EntitySettings;
					num2 = 7;
					continue;
				case 23:
					dataRow = (DataRow)JFW3bc66Gf4YQSi8lGX(orAdd);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 28;
					}
					continue;
				case 22:
					if (entity2 == null)
					{
						num = 5;
						break;
					}
					goto default;
				case 29:
				case 31:
					text = propertyNames[num3];
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 7;
					}
					continue;
				case 15:
					num3 = 0;
					num2 = 24;
					continue;
				case 28:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(-772614310 ^ -772632132), id);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return;
				case 39:
					id = ((IEntity<long>)KtqnsH65utv8BLIcAMc(RkvABH6bxtJy7H5k5Uu(jkgcQc6tZ4qC0kvCUBk(workflowInstanceContext)))).Id;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 6;
					}
					continue;
				case 38:
					obj = null;
					goto IL_066b;
				case 35:
					qBKx3B6DT9cyZd42d1H(dataRow, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106503077), Q3kgH86nYF2ZFHJFfVl(_003C_003Ec__DisplayClass5_.propMd));
					num2 = 20;
					continue;
				case 44:
					workflowInstanceContext = (IWorkflowInstanceContext)NKO69M6mtrVe0Iqe94C(zbZkkP6f2Z4XatxHAXN(@event));
					num2 = 43;
					continue;
				case 1:
					qBKx3B6DT9cyZd42d1H(dataRow, vXqiaa6uIXgWxM9ZKJw(0x6F6D7B44 ^ 0x6F6D6BDC), QQc23F6RuQmBJbcZSxs(workflowInstanceContext));
					num2 = 35;
					continue;
				case 25:
					propertyNames = ((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames();
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 11;
					}
					continue;
				case 30:
					if (Observers.FirstOrDefault(_003C_003Ec__DisplayClass5_._003COnPostUpdate_003Eb__1) == null)
					{
						num2 = 34;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 2;
				case 7:
					if (entitySettings == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 26;
				case 3:
				case 24:
					if (num3 >= propertyNames.Length)
					{
						return;
					}
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 29;
					}
					continue;
				case 10:
					if (entity2 != null)
					{
						num = 13;
						break;
					}
					goto case 9;
				case 6:
					orAdd = ContextVars.GetOrAdd(ObjectStartableByRouteConstant.UpdateKey, delegate
					{
						DataTable dataTable = new DataTable((string)_003C_003Ec.iTugMXZUep3RStaoURRm(0x614CF569 ^ 0x614C9171));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39172742), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(long).TypeHandle));
						dataTable.Columns.Add((string)_003C_003Ec.iTugMXZUep3RStaoURRm(0x614CF569 ^ 0x614CE5F1), typeof(long));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(dataTable.Columns, _003C_003Ec.iTugMXZUep3RStaoURRm(0x6CC04061 ^ 0x6CC025EF), _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(Guid).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(dataTable.Columns, ObservedContextPropertyConsts.Fields.ObjectTU, _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(Guid).TypeHandle));
						_003C_003Ec.Kgvcf9ZUx0cTvlIyP1Rg(_003C_003Ec.W8VTmTZUSmjtUNgec5Tl(dataTable), ObservedContextPropertyConsts.Fields.ObjectOI, _003C_003Ec.K9h4MiZUNvTqjpBvHCIT(typeof(long).TypeHandle));
						return dataTable;
					});
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 25;
					}
					continue;
				case 37:
					obj = (EntityMetadata)XqaVrg6dmcYapCmrqmb(entity.CastAsRealType().GetType(), false, true);
					goto IL_066b;
				case 20:
					{
						dataRow[ObservedContextPropertyConsts.Fields.ObjectTU] = entityMetadata?.ImplementationUid ?? Guid.Empty;
						num2 = 18;
						continue;
					}
					IL_066b:
					entityMetadata = (EntityMetadata)obj;
					num2 = 23;
					continue;
				}
				break;
			}
		}
	}

	internal static IWorkflowInstanceContext GetContext(object entity)
	{
		int num = 4;
		int num2 = num;
		Type type = default(Type);
		ICompositeWorkflowInstanceContext compositeWorkflowInstanceContext = default(ICompositeWorkflowInstanceContext);
		object obj = default(object);
		IWorkflowInstanceContext workflowInstanceContext = default(IWorkflowInstanceContext);
		IEntityManager entityManager = default(IEntityManager);
		while (true)
		{
			switch (num2)
			{
			case 2:
				type = D5XwbO6q4QVtZ81TqrQ(AttributeHelper<CompositeRootEntityAttribute>.GetAttribute(compositeWorkflowInstanceContext.GetType().CastAsRealType(), inherited: false));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				obj = QQc23F6RuQmBJbcZSxs(compositeWorkflowInstanceContext);
				num2 = 9;
				break;
			case 3:
				if (workflowInstanceContext == null)
				{
					num2 = 8;
					break;
				}
				goto case 6;
			case 4:
				workflowInstanceContext = entity as IWorkflowInstanceContext;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				compositeWorkflowInstanceContext = entity as ICompositeWorkflowInstanceContext;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				if (obj != null)
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 7:
				entityManager = (IEntityManager)ILKKeB6QbhxxoGJbZsJ(j3rQXX63TRJ4s3SHnef(typeof(IEntityManager<>).TypeHandle).MakeGenericType(LUn93x6Tdp95hQ4MgIC(type)));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return workflowInstanceContext;
			default:
				if (entityManager != null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 6;
			case 5:
				workflowInstanceContext = vURiUK6pbSdy4xfUB1F(entityManager, obj) as IWorkflowInstanceContext;
				num2 = 6;
				break;
			case 1:
				if (compositeWorkflowInstanceContext != null)
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	public ObservedContextPropertyListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kss6yn6CPdtFVwemsUC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object NKO69M6mtrVe0Iqe94C(object P_0)
	{
		return GetContext(P_0);
	}

	internal static object jkgcQc6tZ4qC0kvCUBk(object P_0)
	{
		return ((IWorkflowInstanceContext)P_0).WorkflowInstance;
	}

	internal static object RkvABH6bxtJy7H5k5Uu(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object KtqnsH65utv8BLIcAMc(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object fadUxj6gqSnCLyfUWyg(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object qDXylU6BhTi19L5ZuG2(Type P_0, object P_1, bool P_2)
	{
		return InterfaceActivator.LoadPropertyMetadata(P_0, (string)P_1, P_2);
	}

	internal static object THe4wW6c9yqiZUjLRCZ(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object xR5RbN6PH1nuQnBFNwn(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object AhL7mF6X8yA2QruaUkm(object P_0)
	{
		return ((PostInsertEvent)P_0).get_State();
	}

	internal static object XqaVrg6dmcYapCmrqmb(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object vXqiaa6uIXgWxM9ZKJw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void qBKx3B6DT9cyZd42d1H(object P_0, object P_1, object P_2)
	{
		((DataRow)P_0)[(string)P_1] = P_2;
	}

	internal static Guid Q3kgH86nYF2ZFHJFfVl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid MVjO1w6Hb9XMu1iMXKd(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static object LgwkbB6LDpeQZe2GU9l(object P_0)
	{
		return ((DataTable)P_0).Rows;
	}

	internal static bool yKpTJB60VkSUqK81nis()
	{
		return d1bSUC6lqBvSQFBUfsn == null;
	}

	internal static ObservedContextPropertyListener p4xlVV6yihhEarKJNIy()
	{
		return d1bSUC6lqBvSQFBUfsn;
	}

	internal static object zbZkkP6f2Z4XatxHAXN(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static RelationType E0AZCU69IPUg5Uvf67A(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object Y9jNxh6WHx03A5Dm6ap(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_OldState();
	}

	internal static object BcS62H6jwtwSmwGRjyo(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_State();
	}

	internal static object QQc23F6RuQmBJbcZSxs(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object JFW3bc66Gf4YQSi8lGX(object P_0)
	{
		return ((DataTable)P_0).NewRow();
	}

	internal static Type D5XwbO6q4QVtZ81TqrQ(object P_0)
	{
		return ((CompositeRootEntityAttribute)P_0).RootType;
	}

	internal static Type j3rQXX63TRJ4s3SHnef(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Type LUn93x6Tdp95hQ4MgIC(Type P_0)
	{
		return P_0.GetTypeWithoutProxy();
	}

	internal static object ILKKeB6QbhxxoGJbZsJ(Type P_0)
	{
		return Locator.GetService(P_0);
	}

	internal static object vURiUK6pbSdy4xfUB1F(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static void kss6yn6CPdtFVwemsUC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
