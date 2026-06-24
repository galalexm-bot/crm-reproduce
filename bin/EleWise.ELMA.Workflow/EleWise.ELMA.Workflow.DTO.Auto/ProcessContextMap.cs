using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class ProcessContextMap : ProcessContextMap<ProcessContext>
{
	private static ProcessContextMap gVmk5OScqkgyiktaUQu;

	public ProcessContextMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		V3VArVSdZWKfwqk5P9u();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void V3VArVSdZWKfwqk5P9u()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool I5hIuBSPFdxp19JIMnD()
	{
		return gVmk5OScqkgyiktaUQu == null;
	}

	internal static ProcessContextMap eXR6VRSXiEDP5S8StyE()
	{
		return gVmk5OScqkgyiktaUQu;
	}
}
public abstract class ProcessContextMap<TContext> : SimpleMap<TContext, TContext> where TContext : EntityMetadata
{
	private static object dSa1IUSu6LNsxFWjSwX;

	protected override void InitMap(IMappingExpression<TContext, TContext> map)
	{
		base.InitMap(map);
		map.AfterMap((Action<TContext, TContext>)delegate(TContext c1, TContext c2)
		{
			if (c1 != null && c2 != null)
			{
				ConvertTableParts(c1.TableParts, c2.TableParts);
			}
		});
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x350CF52));
		map.ForMember<ISet<EntityPropertyMetadata>>(Expression.Lambda<Func<TContext, ISet<EntityPropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TContext, TContext, ISet<EntityPropertyMetadata>>>)delegate(IMemberConfigurationExpression<TContext, TContext, ISet<EntityPropertyMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495300274));
		map.ForMember<ISet<TablePartMetadata>>(Expression.Lambda<Func<TContext, ISet<TablePartMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TContext, TContext, ISet<TablePartMetadata>>>)delegate(IMemberConfigurationExpression<TContext, TContext, ISet<TablePartMetadata>> opt)
		{
			opt.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108881394));
		map.ForMember<List<PropertyMetadata>>(Expression.Lambda<Func<TContext, List<PropertyMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TContext, TContext, List<PropertyMetadata>>>)delegate(IMemberConfigurationExpression<TContext, TContext, List<PropertyMetadata>> opt)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(TContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F93963));
			opt.MapFrom<List<PropertyMetadata>>(Expression.Lambda<Func<TContext, List<PropertyMetadata>>>(Expression.Call(Expression.Constant(this, typeof(ProcessContextMap<TContext>)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(ProcessContextMap<TContext>).TypeHandle), parameterExpression2), new ParameterExpression[1] { parameterExpression2 }));
		});
		parameterExpression = Expression.Parameter(typeof(TContext), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7F6057));
		map.ForMember<List<TablePartMetadata>>(Expression.Lambda<Func<TContext, List<TablePartMetadata>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TContext, TContext, List<TablePartMetadata>>>)delegate(IMemberConfigurationExpression<TContext, TContext, List<TablePartMetadata>> opt)
		{
			opt.Ignore();
		});
	}

	private List<PropertyMetadata> ConvertProperties(TContext context)
	{
		List<PropertyMetadata> properties = context.Properties;
		if (properties == null)
		{
			return null;
		}
		List<PropertyMetadata> list = new List<PropertyMetadata>();
		foreach (PropertyMetadata item2 in properties)
		{
			if (item2 is EntityPropertyMetadata entityPropertyMetadata)
			{
				PropertyMetadata propertyMetadata = context.CreateProperty();
				EntityPropertyMetadata item = (EntityPropertyMetadata)Mapper.Map((object)entityPropertyMetadata, (object)propertyMetadata, propertyMetadata.GetType(), propertyMetadata.GetType());
				list.Add(item);
			}
		}
		return list;
	}

	private void ConvertTableParts(List<TablePartMetadata> src, List<TablePartMetadata> target)
	{
		if (src == null || target == null)
		{
			return;
		}
		target.Clear();
		foreach (TablePartMetadata item in src)
		{
			TablePartMetadata tablePartMetadata = ClassSerializationHelper.CloneObjectByXml(item);
			ResetIdsRecursive(tablePartMetadata);
			target.Add(tablePartMetadata);
		}
	}

	private void ResetIdsRecursive(TablePartMetadata tp)
	{
		//Discarded unreachable code: IL_0084, IL_0093, IL_0147, IL_015a, IL_0169, IL_0191, IL_01a0, IL_01ab, IL_023f, IL_0252
		int num = 2;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				tp.Id = 0L;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
				{
					num2 = 1;
				}
				continue;
			case 0:
				return;
			case 1:
				enumerator = tp.Properties.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_00f5:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
							{
								num5 = 0;
							}
							goto IL_00a2;
						}
						goto IL_00bc;
						IL_00bc:
						current = enumerator2.Current;
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num5 = 0;
						}
						goto IL_00a2;
						IL_00a2:
						while (true)
						{
							switch (num5)
							{
							case 3:
								return;
							case 1:
								break;
							default:
							{
								ResetIdsRecursive(current);
								int num6 = 2;
								num5 = num6;
								continue;
							}
							case 2:
								goto IL_00f5;
							}
							break;
						}
						goto IL_00bc;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 3:
				break;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
							{
								num3 = 1;
							}
							goto IL_01af;
						}
						goto IL_01eb;
						IL_01eb:
						enumerator.Current.Id = 0L;
						num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
						{
							num3 = 1;
						}
						goto IL_01af;
						IL_01af:
						switch (num3)
						{
						case 2:
							break;
						default:
							goto IL_01eb;
						case 1:
							goto end_IL_01c5;
						}
						continue;
						end_IL_01c5:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			}
			enumerator2 = tp.TableParts.GetEnumerator();
			num2 = 4;
		}
	}

	protected ProcessContextMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool TyhGo5SD1fGNlXcrtH9()
	{
		return dSa1IUSu6LNsxFWjSwX == null;
	}

	internal static object xfjxQGSnJIn4kmuhcUw()
	{
		return dSa1IUSu6LNsxFWjSwX;
	}
}
