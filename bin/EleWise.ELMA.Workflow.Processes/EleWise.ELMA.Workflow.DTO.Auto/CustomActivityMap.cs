using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class CustomActivityMap : EntityDTOMap<ICustomActivity, CustomActivityDTO>, ICustomActivityMap
{
	private static CustomActivityMap nbEu6u4EEe3NmGF8Wlb;

	public Type EntityType => JmhMvb4ot9rdqMkJGMs(typeof(ICustomActivity).TypeHandle);

	public Type DTOType => typeof(CustomActivityDTO);

	protected override void InitMap(IMappingExpression<ICustomActivity, CustomActivityDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(CustomActivityDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3D87FABF ^ 0x3D879721));
		map.ForMember<CustomActivityParameters>(Expression.Lambda<Func<CustomActivityDTO, CustomActivityParameters>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ICustomActivity, CustomActivityDTO, CustomActivityParameters>>)delegate(IMemberConfigurationExpression<ICustomActivity, CustomActivityDTO, CustomActivityParameters> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ICustomActivity), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48B7D69C ^ 0x48B7BB34));
			a.MapFrom<CustomActivityParameters>(Expression.Lambda<Func<ICustomActivity, CustomActivityParameters>>(Expression.Call(Expression.Constant(this, typeof(CustomActivityMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
		parameterExpression = Expression.Parameter(typeof(CustomActivityDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE108112 ^ 0xE10EC8C));
		map.ForMember<UserDTO>(Expression.Lambda<Func<CustomActivityDTO, UserDTO>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ICustomActivity, CustomActivityDTO, UserDTO>>)delegate(IMemberConfigurationExpression<ICustomActivity, CustomActivityDTO, UserDTO> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<ICustomActivity, CustomActivityDTO>)MapCreationAuthorToDTO);
	}

	protected override void InitReverseMap(IMappingExpression<CustomActivityDTO, ICustomActivity> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ICustomActivity), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-402075023 ^ -402079745));
		map.ForMember<CustomActivityParameters>(Expression.Lambda<Func<ICustomActivity, CustomActivityParameters>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityDTO, ICustomActivity, CustomActivityParameters>>)delegate(IMemberConfigurationExpression<CustomActivityDTO, ICustomActivity, CustomActivityParameters> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(ICustomActivity), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351702578 ^ -351724480));
		map.ForMember<IUser>(Expression.Lambda<Func<ICustomActivity, IUser>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<CustomActivityDTO, ICustomActivity, IUser>>)delegate(IMemberConfigurationExpression<CustomActivityDTO, ICustomActivity, IUser> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<CustomActivityDTO, ICustomActivity>)MapContext);
	}

	protected virtual CustomActivityParameters CopyContextToDTO(CustomActivityParameters srcContext)
	{
		//Discarded unreachable code: IL_0088, IL_0097
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (srcContext != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 4:
				return null;
			case 1:
				yIdPjt43noN35ot3RV9(srcContext.Properties);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f1ba867523264a63932ee1e8d0cd4a24 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return Mapper.Map<CustomActivityParameters, CustomActivityParameters>(srcContext, new CustomActivityParameters());
			default:
				srcContext.Properties.AddRange((IEnumerable<PropertyMetadata>)srcContext.EntityProperties);
				num2 = 3;
				break;
			}
		}
	}

	private void MapContext(CustomActivityDTO dto, ICustomActivity ca)
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
				Vss4cX4FUiZ9lHC8gTL(ca, CopyContextToEntity((CustomActivityParameters)lPadlY4huF8aUEoIAWV(dto), (CustomActivityParameters)b8eHeU4xtXhi8vYP64L(ca)));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void MapCreationAuthorToDTO(ICustomActivity ca, CustomActivityDTO dto)
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
				O2lHwa4wR23ASKtHJa8(dto, Mapper.Map<IUser, UserDTO>((IUser)myKZgI48vOvY7jt1xSn(ca), new UserDTO()));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual CustomActivityParameters CopyContextToEntity(CustomActivityParameters srcContext, CustomActivityParameters result)
	{
		//Discarded unreachable code: IL_005a, IL_0069, IL_0138, IL_014b, IL_015a, IL_01a6, IL_01b0, IL_0276, IL_0289, IL_02d3, IL_02e2, IL_0395, IL_03a4, IL_0448, IL_045b, IL_048b, IL_04b3, IL_04c2, IL_05ab, IL_05e3, IL_05f2
		int num = 8;
		List<EntityPropertyMetadata>.Enumerator enumerator3 = default(List<EntityPropertyMetadata>.Enumerator);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		IEnumerator<EntityPropertyMetadata> enumerator2 = default(IEnumerator<EntityPropertyMetadata>);
		List<EntityPropertyMetadata> list = default(List<EntityPropertyMetadata>);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_2 = default(_003C_003Ec__DisplayClass9_0);
		EntityPropertyMetadata entityPropertyMetadata2 = default(EntityPropertyMetadata);
		_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					try
					{
						while (true)
						{
							int num12;
							if (!enumerator3.MoveNext())
							{
								int num11 = 2;
								num12 = num11;
								goto IL_0078;
							}
							goto IL_00d1;
							IL_0078:
							while (true)
							{
								switch (num12)
								{
								case 4:
									o3aVGe4qpZJVQmq73va(current);
									num12 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
									{
										num12 = 0;
									}
									continue;
								case 1:
									goto IL_00d1;
								case 3:
									((ICollection<EntityPropertyMetadata>)result.EntityProperties).Remove(current);
									num12 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
									{
										num12 = 4;
									}
									continue;
								case 2:
									return result;
								}
								break;
							}
							continue;
							IL_00d1:
							current = enumerator3.Current;
							num12 = 3;
							goto IL_0078;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num13 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
						{
							num13 = 0;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
				case 3:
					return result;
				case 7:
					return null;
				case 5:
					enumerator = srcContext.Properties.GetEnumerator();
					num2 = 11;
					break;
				case 11:
					try
					{
						while (true)
						{
							IL_0224:
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
								{
									num6 = 1;
								}
								goto IL_01b4;
							}
							goto IL_01ea;
							IL_01ea:
							entityPropertyMetadata = (EntityPropertyMetadata)enumerator.Current;
							num6 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
							{
								num6 = 0;
							}
							goto IL_01b4;
							IL_01b4:
							while (true)
							{
								switch (num6)
								{
								case 3:
									srcContext.EntityProperties.Add(entityPropertyMetadata);
									num6 = 2;
									continue;
								case 4:
									break;
								default:
									entityPropertyMetadata.Owner = srcContext;
									num6 = 3;
									continue;
								case 2:
									goto IL_0224;
								case 1:
									return srcContext;
								}
								break;
							}
							goto IL_01ea;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
				default:
					enumerator2 = ((IEnumerable<EntityPropertyMetadata>)result.EntityProperties).GetEnumerator();
					num2 = 9;
					break;
				case 1:
					enumerator3 = list.GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
					{
						num2 = 13;
					}
					break;
				case 6:
					try
					{
						while (true)
						{
							int num8;
							if (!enumerator.MoveNext())
							{
								num8 = 6;
								goto IL_02f1;
							}
							goto IL_03d3;
							IL_02f1:
							while (true)
							{
								switch (num8)
								{
								default:
									Mapper.Map<EntityPropertyMetadata, EntityPropertyMetadata>(_003C_003Ec__DisplayClass9_2.epm, entityPropertyMetadata2);
									num8 = 5;
									continue;
								case 4:
								case 5:
									break;
								case 3:
									if (entityPropertyMetadata2 == null)
									{
										num8 = 1;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 != 0)
										{
											num8 = 1;
										}
										continue;
									}
									goto default;
								case 2:
									_003C_003Ec__DisplayClass9_2.epm = (EntityPropertyMetadata)enumerator.Current;
									num8 = 9;
									continue;
								case 9:
									entityPropertyMetadata2 = ((IEnumerable<EntityPropertyMetadata>)result.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass9_2._003CCopyContextToEntity_003Eb__0);
									num8 = 3;
									continue;
								case 8:
									goto IL_03d3;
								case 1:
									M5IXLe4sGbyoQfcSmCD(_003C_003Ec__DisplayClass9_2.epm, result);
									num8 = 7;
									continue;
								case 7:
									result.EntityProperties.Add(_003C_003Ec__DisplayClass9_2.epm);
									num8 = 4;
									continue;
								case 6:
									goto end_IL_033c;
								}
								break;
							}
							continue;
							IL_03d3:
							_003C_003Ec__DisplayClass9_2 = new _003C_003Ec__DisplayClass9_0();
							int num9 = 2;
							num8 = num9;
							goto IL_02f1;
							continue;
							end_IL_033c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 12:
					list = new List<EntityPropertyMetadata>();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					if (srcContext == null)
					{
						goto end_IL_0012;
					}
					if (result != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2e79a6d6eb444d33993dd78f88b64832 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 10;
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!lNIDyc42CFQCNU70NDL(enumerator2))
							{
								num3 = 2;
								goto IL_04d1;
							}
							goto IL_0574;
							IL_04d1:
							while (true)
							{
								switch (num3)
								{
								case 4:
									list.Add(_003C_003Ec__DisplayClass9_.epm);
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 != 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
								{
									_003C_003Ec__DisplayClass9_.epm = enumerator2.Current;
									int num4 = 5;
									num3 = num4;
									continue;
								}
								case 5:
									if (srcContext.Properties.FirstOrDefault(_003C_003Ec__DisplayClass9_._003CCopyContextToEntity_003Eb__1) == null)
									{
										num3 = 4;
										continue;
									}
									break;
								case 1:
									goto IL_0574;
								case 2:
									goto end_IL_0537;
								}
								break;
							}
							continue;
							IL_0574:
							_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1();
							num3 = 3;
							goto IL_04d1;
							continue;
							end_IL_0537:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									enumerator2.Dispose();
									num5 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 10:
					SDH8F14t2k1ANRdvC1d(srcContext.EntityProperties);
					num2 = 5;
					break;
				case 2:
					return srcContext;
				case 4:
					enumerator = srcContext.Properties.GetEnumerator();
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public CustomActivityMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OKxtTo4QvbLQRdKLYCh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type JmhMvb4ot9rdqMkJGMs(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void yIdPjt43noN35ot3RV9(object P_0)
	{
		((List<PropertyMetadata>)P_0).Clear();
	}

	internal static bool zRpJDp4CyElGPsmlRFt()
	{
		return nbEu6u4EEe3NmGF8Wlb == null;
	}

	internal static CustomActivityMap Yjranx4XEcfywYk3IdC()
	{
		return nbEu6u4EEe3NmGF8Wlb;
	}

	internal static object lPadlY4huF8aUEoIAWV(object P_0)
	{
		return ((CustomActivityDTO)P_0).Parameters;
	}

	internal static object b8eHeU4xtXhi8vYP64L(object P_0)
	{
		return ((ICustomActivity)P_0).Parameters;
	}

	internal static void Vss4cX4FUiZ9lHC8gTL(object P_0, object P_1)
	{
		((ICustomActivity)P_0).Parameters = (CustomActivityParameters)P_1;
	}

	internal static object myKZgI48vOvY7jt1xSn(object P_0)
	{
		return ((ICustomActivity)P_0).CreationAuthor;
	}

	internal static void O2lHwa4wR23ASKtHJa8(object P_0, object P_1)
	{
		((CustomActivityDTO)P_0).CreationAuthor = (UserDTO)P_1;
	}

	internal static void SDH8F14t2k1ANRdvC1d(object P_0)
	{
		((ICollection<EntityPropertyMetadata>)P_0).Clear();
	}

	internal static void M5IXLe4sGbyoQfcSmCD(object P_0, object P_1)
	{
		((EntityPropertyMetadata)P_0).Owner = (EntityMetadata)P_1;
	}

	internal static bool lNIDyc42CFQCNU70NDL(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void o3aVGe4qpZJVQmq73va(object P_0)
	{
		((Entity<long>)P_0).Delete();
	}

	internal static void OKxtTo4QvbLQRdKLYCh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
