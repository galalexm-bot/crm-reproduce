using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public class MetadataItemGroupDTOManager : DTOManager, IMetadataItemGroupDTOManager, IConfigurationService
{
	internal static MetadataItemGroupDTOManager FeQ7ZWb5I9G3wOVxRB6j;

	public MetadataItemGroupManager MetadataItemGroupManager => Locator.GetServiceNotNull<MetadataItemGroupManager>();

	public virtual MetadataItemGroupDTO LoadRootGroup()
	{
		//Discarded unreachable code: IL_00f7, IL_0105, IL_01b4, IL_01d3, IL_01e2, IL_020f, IL_021e
		int num = 2;
		int num2 = num;
		MetadataItemGroupDTO metadataItemGroupDTO = default(MetadataItemGroupDTO);
		IEnumerator<IMetadataItemGroup> enumerator = default(IEnumerator<IMetadataItemGroup>);
		MetadataItemGroupDTO item = default(MetadataItemGroupDTO);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				MetadataItemGroupManager metadataItemGroupManager = MetadataItemGroupManager;
				ParameterExpression parameterExpression = (ParameterExpression)IxNFJab5qH4FeOKxOedn(TnYek9b5ifQBBS59a6M7(typeof(IMetadataItemGroup).TypeHandle), dwPbJ9b5RljwmRyvELcE(-2106517564 ^ -2106466236));
				ICollection<IMetadataItemGroup> collection = metadataItemGroupManager.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal((Expression)v6I5yRb5XCc1CCLrfJvH(parameterExpression, (MethodInfo)LtRKieb5K59fRoSQ56oY((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)d59fVFb5TtJd65lY2FTG(null, TnYek9b5ifQBBS59a6M7(typeof(object).TypeHandle))), new ParameterExpression[1] { parameterExpression }));
				metadataItemGroupDTO = new MetadataItemGroupDTO
				{
					Name = SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A57FCC)),
					DisplayName = SR.M((string)dwPbJ9b5RljwmRyvELcE(--1360331293 ^ 0x51179E9B))
				};
				enumerator = collection.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				return metadataItemGroupDTO;
			case 1:
				try
				{
					while (true)
					{
						IL_0178:
						int num3;
						if (!ECsMi6b5k6wpm4sLWhOy(enumerator))
						{
							num3 = 3;
							goto IL_0109;
						}
						goto IL_0123;
						IL_0109:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return metadataItemGroupDTO;
							case 2:
								break;
							case 1:
								metadataItemGroupDTO.SubGroups.Add(item);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								goto IL_0178;
							}
							break;
						}
						goto IL_0123;
						IL_0123:
						item = Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(enumerator.Current, new MetadataItemGroupDTO());
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num3 = 1;
						}
						goto IL_0109;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num4 = 2;
						}
						goto IL_01b8;
					}
					goto IL_01ed;
					IL_01ed:
					q6o3iwb5nujFhx8Vq06p(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num4 = 0;
					}
					goto IL_01b8;
					IL_01b8:
					switch (num4)
					{
					default:
						goto end_IL_0193;
					case 2:
						goto end_IL_0193;
					case 1:
						break;
					case 0:
						goto end_IL_0193;
					}
					goto IL_01ed;
					end_IL_0193:;
				}
			}
		}
	}

	public virtual IEnumerable<MetadataItemGroupDTO> GetChildGroups(long parentGroupId)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.parentGroup = ((parentGroupId > 0) ? MetadataItemGroupManager.Load(parentGroupId) : null);
		MetadataItemGroupManager metadataItemGroupManager = MetadataItemGroupManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C946234));
		return (from g in metadataItemGroupManager.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(g)).ToList();
	}

	private void GetChilds(long parentGroupId, List<MetadataItemGroupDTO> childs)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.parentGroupId = parentGroupId;
		CS_0024_003C_003E8__locals0.childs = childs;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals0.childs == null)
		{
			CS_0024_003C_003E8__locals0.childs = new List<MetadataItemGroupDTO>();
		}
		if (!CS_0024_003C_003E8__locals0.childs.All((MetadataItemGroupDTO r) => r.Id != CS_0024_003C_003E8__locals0.parentGroupId))
		{
			return;
		}
		_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
		_003C_003Ec__DisplayClass4_.parentGroup = ((CS_0024_003C_003E8__locals0.parentGroupId > 0) ? MetadataItemGroupManager.Load(CS_0024_003C_003E8__locals0.parentGroupId) : null);
		if (_003C_003Ec__DisplayClass4_.parentGroup == null)
		{
			return;
		}
		MetadataItemGroupManager metadataItemGroupManager = MetadataItemGroupManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMetadataItemGroup), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837659653));
		List<MetadataItemGroupDTO> list = (from g in metadataItemGroupManager.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass4_, typeof(_003C_003Ec__DisplayClass4_1)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(g)).ToList();
		if (!list.Any())
		{
			return;
		}
		list.ForEach(delegate(MetadataItemGroupDTO g)
		{
			int num = 4;
			_003C_003Ec__DisplayClass4_2 _003C_003Ec__DisplayClass4_2 = default(_003C_003Ec__DisplayClass4_2);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						break;
					case 1:
						return;
					case 6:
						CS_0024_003C_003E8__locals0.childs.Add(_003C_003Ec__DisplayClass4_2.g);
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 4;
						}
						continue;
					case 2:
						CS_0024_003C_003E8__locals0._003C_003E4__this.GetChilds(_003C_003Ec__DisplayClass4_2.g.Id, CS_0024_003C_003E8__locals0.childs);
						num2 = 6;
						continue;
					case 3:
						_003C_003Ec__DisplayClass4_2.g = g;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						if (!CS_0024_003C_003E8__locals0.childs.All(_003C_003Ec__DisplayClass4_2._003CGetChilds_003Eb__4))
						{
							return;
						}
						num2 = 2;
						continue;
					case 5:
						CS_0024_003C_003E8__locals0.childs.ForEach(delegate(MetadataItemGroupDTO c)
						{
							int num3 = 1;
							int num4 = num3;
							_003C_003Ec__DisplayClass4_3 _003C_003Ec__DisplayClass4_3 = default(_003C_003Ec__DisplayClass4_3);
							while (true)
							{
								switch (num4)
								{
								case 4:
									CS_0024_003C_003E8__locals0.childs.Add(_003C_003Ec__DisplayClass4_3.c);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
									{
										num4 = 2;
									}
									break;
								case 3:
									if (!CS_0024_003C_003E8__locals0.childs.All(_003C_003Ec__DisplayClass4_3._003CGetChilds_003Eb__6))
									{
										return;
									}
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
									{
										num4 = 3;
									}
									break;
								default:
									_003C_003Ec__DisplayClass4_3.c = c;
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
									{
										num4 = 0;
									}
									break;
								case 1:
									_003C_003Ec__DisplayClass4_3 = new _003C_003Ec__DisplayClass4_3();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
									{
										num4 = 0;
									}
									break;
								case 2:
									return;
								}
							}
						});
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				_003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_2();
				num = 3;
			}
		});
	}

	public virtual IEnumerable<MetadataItemGroupDTO> GetNestedChildGroups(long parentGroupId)
	{
		if (((parentGroupId > 0) ? MetadataItemGroupManager.Load(parentGroupId) : null) == null)
		{
			return new List<MetadataItemGroupDTO>();
		}
		List<MetadataItemGroupDTO> list = new List<MetadataItemGroupDTO>();
		GetChilds(parentGroupId, list);
		return list;
	}

	public virtual MetadataItemGroupDTO Save(MetadataItemGroupDTO group)
	{
		int num = 3;
		int num2 = num;
		IMetadataItemGroup metadataItemGroup = default(IMetadataItemGroup);
		while (true)
		{
			switch (num2)
			{
			case 6:
				metadataItemGroup.Refresh();
				num2 = 4;
				break;
			case 4:
				if (YHZDpjb52hg9xQibJ37q(metadataItemGroup) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 7:
				return Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(metadataItemGroup, group);
			case 2:
				zyBtIhb5OLwmdcCNSPjl(metadataItemGroup);
				num2 = 6;
				break;
			case 1:
				metadataItemGroup.Parent.Refresh();
				num2 = 5;
				break;
			default:
				bZU6ZQb5PpJD7HOLblAt(dwPbJ9b5RljwmRyvELcE(0x76DD48E ^ 0x76F22D8));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				uaVYZmb5eGNiHGKuxLXV(Locator.GetService<IContextBoundVariableService>(), dwPbJ9b5RljwmRyvELcE(-398663332 ^ -398584054));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				metadataItemGroup = Mapper.Map<MetadataItemGroupDTO, IMetadataItemGroup>(group);
				num2 = 2;
				break;
			}
		}
	}

	public virtual void Delete(long groupId)
	{
		int num = 1;
		int num2 = num;
		IMetadataItemGroup metadataItemGroup = default(IMetadataItemGroup);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadataItemGroup = MetadataItemGroupManager.LoadOrNull(groupId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				MetadataItemGroupManager.Delete(metadataItemGroup);
				num2 = 3;
				continue;
			case 3:
				return;
			}
			if (metadataItemGroup == null)
			{
				return;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num2 = 1;
			}
		}
	}

	public MetadataItemGroupDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TNBQPqb51BaVH45fnWgE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type TnYek9b5ifQBBS59a6M7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dwPbJ9b5RljwmRyvELcE(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object IxNFJab5qH4FeOKxOedn(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object LtRKieb5K59fRoSQ56oY(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object v6I5yRb5XCc1CCLrfJvH(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object d59fVFb5TtJd65lY2FTG(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static bool ECsMi6b5k6wpm4sLWhOy(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void q6o3iwb5nujFhx8Vq06p(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool mdc97Rb5Vx0HwFD93Mfq()
	{
		return FeQ7ZWb5I9G3wOVxRB6j == null;
	}

	internal static MetadataItemGroupDTOManager UP1DjJb5SY0OyA5NlQ2O()
	{
		return FeQ7ZWb5I9G3wOVxRB6j;
	}

	internal static void zyBtIhb5OLwmdcCNSPjl(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object YHZDpjb52hg9xQibJ37q(object P_0)
	{
		return ((IMetadataItemGroup)P_0).Parent;
	}

	internal static void uaVYZmb5eGNiHGKuxLXV(object P_0, object P_1)
	{
		((IAbstractBoundVariableService)P_0).Remove((string)P_1);
	}

	internal static void bZU6ZQb5PpJD7HOLblAt(object P_0)
	{
		CallContext.FreeNamedDataSlot((string)P_0);
	}

	internal static void TNBQPqb51BaVH45fnWgE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
