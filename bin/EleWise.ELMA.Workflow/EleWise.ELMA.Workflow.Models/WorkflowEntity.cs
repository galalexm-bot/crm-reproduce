using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public abstract class WorkflowEntity : CompositeEntity<long>
{
	private Type mainType;

	private EntityMetadata metadata;

	private Type[] types;

	internal IEntity[] loadedEntities;

	private IEntityManager[] managers;

	private ICompositeEntityManager compositeManager;

	private static WorkflowEntity xCHrAVOWkhsu31rBhUgm;

	protected override Type EntityImplementorType => mainType;

	public override long Id
	{
		get
		{
			//Discarded unreachable code: IL_008a, IL_0099, IL_00a8, IL_010e, IL_011d
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (loadedEntities.Length == 0)
					{
						num2 = 6;
						break;
					}
					goto case 4;
				case 4:
					if ((long)JnoFFjOWAp1ZOXsCKOOM(loadedEntities[0]) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 2:
					if (base.Id > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				default:
					return (long)JnoFFjOWAp1ZOXsCKOOM(loadedEntities[0]);
				case 1:
				case 5:
				case 6:
					return base.Id;
				case 7:
					if (loadedEntities == null)
					{
						num2 = 5;
						break;
					}
					goto case 3;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0081, IL_00b5, IL_00c4, IL_0139, IL_0148
			int num = 2;
			IEntity entity = default(IEntity);
			int num3 = default(int);
			IEntity[] array = default(IEntity[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						if (loadedEntities == null)
						{
							num2 = 3;
							continue;
						}
						goto case 4;
					case 9:
						zVxQBXOWGt5C8LRJOvSN(entity, value);
						num2 = 12;
						continue;
					case 3:
						return;
					case 8:
					case 11:
						if (num3 >= array.Length)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 10;
					case 10:
						entity = array[num3];
						num2 = 5;
						continue;
					case 6:
					case 12:
						num3++;
						num2 = 8;
						continue;
					case 4:
						array = loadedEntities;
						num = 7;
						break;
					case 2:
						base.Id = value;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num2 = 1;
						}
						continue;
					case 7:
						num3 = 0;
						num2 = 11;
						continue;
					case 0:
						return;
					case 5:
						if (entity == null)
						{
							num = 6;
							break;
						}
						goto case 9;
					}
					break;
				}
			}
		}
	}

	public override IEnumerable<IEntity> GetCompositeEntities()
	{
		return loadedEntities.Where((IEntity e) => e != null);
	}

	public override IEnumerable<IEntity> GetContainedEntities()
	{
		List<IEntity> list = new List<IEntity>();
		IEnumerable<IEntity> containedEntities = base.GetContainedEntities();
		if (containedEntities != null)
		{
			list.AddRange(containedEntities);
		}
		PropertyInfo reflectionProperty = GetType().GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111178433));
		if (reflectionProperty != null && reflectionProperty.GetValue(this, null) is IEntity entity)
		{
			list.Add(entity);
			IEnumerable<IEntity> containedEntities2 = entity.GetContainedEntities();
			if (containedEntities2 != null)
			{
				list.AddRange(containedEntities2);
			}
		}
		return list;
	}

	public override bool Equals(object obj)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_0111, IL_011b, IL_012a, IL_01da
		int num = 5;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		WorkflowEntity workflowEntity = default(WorkflowEntity);
		Type type2 = default(Type);
		object value = default(object);
		Type type = default(Type);
		object obj3 = default(object);
		while (true)
		{
			object obj2;
			switch (num2)
			{
			case 10:
				if (Jval07OWoUUR6wkFLyLQ(reflectionProperty, null))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 16;
			case 8:
				if (XWF12mOW2Uf8CqNBB5Zo(mainType, workflowEntity.mainType))
				{
					num2 = 9;
					continue;
				}
				goto case 15;
			case 13:
				if (!((PropertyInfo)P7pDXqOWiNDJdG5obHux(type2, YLD3i2OWFelKWow1CR3K(0x75BAD659 ^ 0x75BA9025)) != null))
				{
					num2 = 16;
					continue;
				}
				goto case 7;
			case 11:
				workflowEntity = (WorkflowEntity)obj;
				num2 = 8;
				continue;
			case 14:
				obj2 = null;
				break;
			case 7:
				value = reflectionProperty.GetValue(this, null);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (obj != null)
				{
					num2 = 6;
					continue;
				}
				goto case 14;
			case 2:
				if (XWF12mOW2Uf8CqNBB5Zo(type, type2))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 15;
			default:
				if (Id == workflowEntity.Id)
				{
					num2 = 12;
					continue;
				}
				goto case 16;
			case 5:
				type = GetType();
				num2 = 4;
				continue;
			case 1:
				obj3 = RPew8qOWIJWCbAS8Koip(reflectionProperty, this, null);
				num2 = 3;
				continue;
			case 12:
				reflectionProperty = type.GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947922153));
				num2 = 10;
				continue;
			case 9:
				if (!types.SequenceEqual(workflowEntity.types))
				{
					num2 = 15;
					continue;
				}
				goto default;
			case 3:
				return value.Equals(obj3);
			case 16:
				return loadedEntities.SequenceEqual(((WorkflowEntity)obj).loadedEntities);
			case 15:
				return Ogown0OWaJ8W8iM0CDiA(this, obj);
			case 6:
				obj2 = yHbYrXOW7ykAlLKxPEyk(obj);
				break;
			}
			type2 = (Type)obj2;
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
			{
				num2 = 1;
			}
		}
	}

	protected void Initialize(long id, Type mainType)
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
				Initialize(id, mainType, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void Initialize(long id, Type mainType, IEntity firstEntity)
	{
		//Discarded unreachable code: IL_00df, IL_01ae, IL_021a
		int num = 5;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					compositeManager = (ICompositeEntityManager)nsFYqOOWN1oAhnll9rkV(this);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					if (id > 0)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 8;
				case 10:
					types = (Type[])b3sOlnOWeGd2qwLKPiDc(mainType);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					k7ZpqnOWrwoVdo8JCej7(mainType, YLD3i2OWFelKWow1CR3K(0x5BCD23A0 ^ 0x5BCF26F8));
					num2 = 4;
					continue;
				case 17:
					loadedEntities[0] = firstEntity;
					num2 = 13;
					continue;
				case 3:
					return;
				case 13:
					return;
				case 4:
					goto end_IL_0012;
				case 2:
				case 7:
					if (num3 >= types.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 14:
					this.mainType = mainType;
					num2 = 10;
					continue;
				case 6:
					loadedEntities = new IEntity[types.Length];
					num2 = 19;
					continue;
				case 9:
					if (firstEntity == null)
					{
						return;
					}
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					if (!types[0].IsAssignableFrom(firstEntity.GetType()))
					{
						return;
					}
					num2 = 17;
					continue;
				case 1:
					return;
				case 16:
					if (types.Length == 0)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 15:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 2;
					}
					continue;
				case 19:
					managers = new IEntityManager[types.Length];
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 9;
					}
					continue;
				case 18:
					break;
				}
				loadedEntities[num3] = ((num3 == 0 && firstEntity != null && types[num3].IsAssignableFrom(firstEntity.GetType())) ? firstEntity : ((IEntity)Aui6TxOWxWK0JfFaTjOb(types[num3])));
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			Id = id;
			num = 14;
		}
	}

	protected abstract ICompositeEntityManager CreateCompositeManager();

	protected object GetPropertyValue(string uid)
	{
		return GetPropertyValueInternal(new Guid(uid));
	}

	protected object GetPropertyValueInternal(Guid uid)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_005f, IL_00ff, IL_010e
		int num = 7;
		int num2 = num;
		WorkflowEntity workflowEntity = default(WorkflowEntity);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 6:
				if (workflowEntity != null)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 2:
				throw new MetadataException((string)orxgpnOW12j1T15msucE(YLD3i2OWFelKWow1CR3K(-862330810 ^ -862198486), new object[2] { uid, mainType }));
			case 7:
				workflowEntity = this;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
			case 5:
				if (!workflowEntity.TryGetPropertyValue(uid, out result))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return result;
			default:
				workflowEntity = (WorkflowEntity)i7kJc7OWSSJ0nL33T3M1(workflowEntity);
				num2 = 3;
				break;
			}
		}
	}

	protected void SetPropertyValue(string uid, object value)
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
				SetPropertyValueInternal(new Guid(uid), value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void SetPropertyValueInternal(Guid uid, object value)
	{
		//Discarded unreachable code: IL_0049, IL_00d5, IL_00e4, IL_0118, IL_0127, IL_0137
		int num = 7;
		int num2 = num;
		WorkflowEntity workflowEntity = default(WorkflowEntity);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				if (!H3fcCqOWhZ5xYuSUhbmZ(workflowEntity, uid, value))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				if (workflowEntity != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 8;
			case 8:
				throw new MetadataException((string)orxgpnOW12j1T15msucE(YLD3i2OWFelKWow1CR3K(0x74AB4717 ^ 0x74A9427B), new object[2] { uid, mainType }));
			case 9:
				return;
			case 1:
				workflowEntity = workflowEntity.GetParentContext();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (!TrySetPropertyValue(uid, value))
				{
					num2 = 6;
					break;
				}
				return;
			case 3:
				return;
			case 6:
				workflowEntity = this;
				num2 = 5;
				break;
			}
		}
	}

	internal IEntity LoadEntity(int entityNumber)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				loadedEntities[entityNumber] = (IEntity)Aui6TxOWxWK0JfFaTjOb(types[entityNumber]);
				num2 = 4;
				break;
			case 4:
				return loadedEntities[entityNumber];
			case 3:
				if (loadedEntities[entityNumber] == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				if (loadedEntities[entityNumber] == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				loadedEntities[entityNumber] = ((Id > 0) ? ((IEntity)wq0rVfOWEo6OPW224O7A(GetManager(entityNumber), Id)) : null);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private IEntityManager GetManager(int entityNumber)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return managers[entityNumber];
			case 1:
				if (managers[entityNumber] != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			managers[entityNumber] = (IEntityManager)VXpaAXOWw5IouBv8U5YJ(compositeManager, types[entityNumber]);
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
			{
				num2 = 2;
			}
		}
	}

	private WorkflowEntity GetParentContext()
	{
		int num = 2;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Jval07OWoUUR6wkFLyLQ(reflectionProperty, null))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			case 2:
				reflectionProperty = yHbYrXOW7ykAlLKxPEyk(this).GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548AB864));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return reflectionProperty.GetValue(this, null) as WorkflowEntity;
			}
		}
	}

	private bool GetEntityAndProperty(Guid uid, out IEntity entity, out PropertyInfo propInfo)
	{
		//Discarded unreachable code: IL_007d, IL_010b, IL_0137, IL_017c, IL_018b, IL_0248, IL_02c9
		int num = 1;
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = default(_003C_003Ec__DisplayClass24_0);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		string text = default(string);
		int entityNumber = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				object obj;
				switch (num2)
				{
				case 12:
					tablePartMetadata = metadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CGetEntityAndProperty_003Eb__1);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
					return false;
				case 2:
					if (entityPropertyMetadata != null)
					{
						num2 = 10;
						continue;
					}
					goto case 8;
				case 5:
					throw new MetadataException((string)orxgpnOW12j1T15msucE(YLD3i2OWFelKWow1CR3K(0x3C1FFB55 ^ 0x3C1DFE8F), new object[2]
					{
						text,
						entity.GetType()
					}));
				case 16:
					return true;
				case 3:
					num3 = 0;
					break;
				case 13:
					metadata = (EntityMetadata)MetadataLoader.LoadMetadata(mainType);
					num2 = 21;
					continue;
				case 21:
					if (metadata == null)
					{
						num2 = 15;
						continue;
					}
					goto case 7;
				case 18:
					if (entityPropertyMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
						{
							num2 = 3;
						}
						continue;
					}
					num3 = d4ginYOWz4qMdACIMP1C(entityPropertyMetadata);
					break;
				case 1:
					_003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (entityPropertyMetadata != null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 22;
				case 14:
					entity = null;
					num2 = 6;
					continue;
				case 15:
					throw new MetadataException((string)orxgpnOW12j1T15msucE(YLD3i2OWFelKWow1CR3K(-1965291699 ^ -1965251691), new object[1] { mainType }));
				case 7:
					entityPropertyMetadata = (EntityPropertyMetadata)metadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass24_._003CGetEntityAndProperty_003Eb__0);
					num2 = 12;
					continue;
				case 20:
					if (metadata != null)
					{
						goto end_IL_0012;
					}
					goto case 13;
				case 17:
					if (!jT7RrWOjKiGfL7BPJ3gG(propInfo, null))
					{
						num2 = 16;
						continue;
					}
					goto case 5;
				case 22:
					if (tablePartMetadata == null)
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 2;
				case 9:
					propInfo = (PropertyInfo)P7pDXqOWiNDJdG5obHux(entity.GetType(), text);
					num2 = 17;
					continue;
				case 8:
					obj = kgVer8OW4FB2unB4UHsG(tablePartMetadata);
					goto IL_0308;
				default:
					_003C_003Ec__DisplayClass24_.uid = uid;
					num2 = 14;
					continue;
				case 6:
					propInfo = null;
					num2 = 20;
					continue;
				case 19:
					entity = LoadEntity(entityNumber);
					num2 = 9;
					continue;
				case 10:
					{
						obj = entityPropertyMetadata.Name;
						goto IL_0308;
					}
					IL_0308:
					text = (string)obj;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 8;
					}
					continue;
				}
				entityNumber = num3;
				num2 = 19;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	protected bool TryGetPropertyValue(Guid uid, out object result)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 2:
				result = null;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				if (GetEntityAndProperty(uid, out var entity, out var propInfo))
				{
					result = RPew8qOWIJWCbAS8Koip(propInfo, entity, null);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			}
			default:
				return true;
			}
		}
	}

	protected bool TrySetPropertyValue(Guid uid, object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!GetEntityAndProperty(uid, out var entity, out var propInfo))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 0;
					}
					break;
				}
				KUYPaeOjOBDhxDxFve08(propInfo, entity, value, null);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				return true;
			default:
				return false;
			}
		}
	}

	private static Type[] GetCompositeTypes(Type mainType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = default(_003C_003Ec__DisplayClass27_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass27_.mainType = mainType;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return ContextVars.GetOrAdd((string)gmEp3fOjZ1MMsYOxqDLp(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002196001), _003C_003Ec__DisplayClass27_.mainType.AssemblyQualifiedName), _003C_003Ec__DisplayClass27_._003CGetCompositeTypes_003Eb__0);
			case 1:
				_003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected WorkflowEntity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OQ2q8DOjvIHykcbyseVE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object JnoFFjOWAp1ZOXsCKOOM(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static bool UJoVdPOWUQOx5rsJto4K()
	{
		return xCHrAVOWkhsu31rBhUgm == null;
	}

	internal static WorkflowEntity tG4CIZOWVCjBVeVbAmgE()
	{
		return xCHrAVOWkhsu31rBhUgm;
	}

	internal static void zVxQBXOWGt5C8LRJOvSN(object P_0, object P_1)
	{
		((IIdentified)P_0).SetId(P_1);
	}

	internal static Type yHbYrXOW7ykAlLKxPEyk(object P_0)
	{
		return P_0.GetType();
	}

	internal static bool XWF12mOW2Uf8CqNBB5Zo(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool Jval07OWoUUR6wkFLyLQ(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object YLD3i2OWFelKWow1CR3K(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object P7pDXqOWiNDJdG5obHux(Type P_0, object P_1)
	{
		return P_0.GetReflectionProperty((string)P_1);
	}

	internal static object RPew8qOWIJWCbAS8Koip(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool Ogown0OWaJ8W8iM0CDiA(object P_0, object P_1)
	{
		return ((Entity<long>)P_0).Equals(P_1);
	}

	internal static void k7ZpqnOWrwoVdo8JCej7(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object b3sOlnOWeGd2qwLKPiDc(Type mainType)
	{
		return GetCompositeTypes(mainType);
	}

	internal static object nsFYqOOWN1oAhnll9rkV(object P_0)
	{
		return ((WorkflowEntity)P_0).CreateCompositeManager();
	}

	internal static object Aui6TxOWxWK0JfFaTjOb(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object i7kJc7OWSSJ0nL33T3M1(object P_0)
	{
		return ((WorkflowEntity)P_0).GetParentContext();
	}

	internal static object orxgpnOW12j1T15msucE(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static bool H3fcCqOWhZ5xYuSUhbmZ(object P_0, Guid uid, object P_2)
	{
		return ((WorkflowEntity)P_0).TrySetPropertyValue(uid, P_2);
	}

	internal static object wq0rVfOWEo6OPW224O7A(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Load(P_1);
	}

	internal static object VXpaAXOWw5IouBv8U5YJ(object P_0, Type P_1)
	{
		return ((ICompositeEntityManager)P_0).GetPartialManager(P_1);
	}

	internal static object kgVer8OW4FB2unB4UHsG(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static int d4ginYOWz4qMdACIMP1C(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).TableNumber;
	}

	internal static bool jT7RrWOjKiGfL7BPJ3gG(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static void KUYPaeOjOBDhxDxFve08(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object gmEp3fOjZ1MMsYOxqDLp(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void OQ2q8DOjvIHykcbyseVE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
