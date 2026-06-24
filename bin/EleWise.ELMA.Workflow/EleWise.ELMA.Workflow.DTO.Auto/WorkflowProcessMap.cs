using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class WorkflowProcessMap : WorkflowProcessMap<IWorkflowProcess, WorkflowProcessDTO>
{
	internal static WorkflowProcessMap qUwIoJSia0fPahvVfKG;

	public WorkflowProcessMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BHA6M4Sr41I9hPQ7Rab();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void BHA6M4Sr41I9hPQ7Rab()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Xhv06jSI9FBLWDXxn4l()
	{
		return qUwIoJSia0fPahvVfKG == null;
	}

	internal static WorkflowProcessMap rW0NXPSaT5KpRohBAod()
	{
		return qUwIoJSia0fPahvVfKG;
	}
}
public abstract class WorkflowProcessMap<TProcess, TProcessDTO> : BidirectionalMap<TProcess, TProcessDTO>, IWorkflowProcessMap where TProcess : class, IWorkflowProcess where TProcessDTO : WorkflowProcessDTO
{
	internal static object sUpSN3SeDYU6uAM06V8;

	public Type EntityType => typeof(TProcess);

	public Type DTOType => typeof(TProcessDTO);

	protected override void InitMap(IMappingExpression<TProcess, TProcessDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1144E77D));
		map.ForMember<WorkflowProcessDTO>(Expression.Lambda<Func<TProcessDTO, WorkflowProcessDTO>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, WorkflowProcessDTO>>)delegate(IMemberConfigurationExpression<TProcess, TProcessDTO, WorkflowProcessDTO> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D51015));
		map.ForMember<ProcessContext>(Expression.Lambda<Func<TProcessDTO, ProcessContext>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessContext>>)delegate(IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessContext> a)
		{
			ParameterExpression parameterExpression4 = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057790615));
			a.MapFrom<ProcessContext>(Expression.Lambda<Func<TProcess, ProcessContext>>(Expression.Call(Expression.Constant(this, typeof(WorkflowProcessMap<TProcess, TProcessDTO>)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(WorkflowProcessMap<TProcess, TProcessDTO>).TypeHandle), Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression4 }));
		});
		parameterExpression = Expression.Parameter(typeof(TProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C67640B));
		map.ForMember<ProcessInstanceMetricsContainer>(Expression.Lambda<Func<TProcessDTO, ProcessInstanceMetricsContainer>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessInstanceMetricsContainer>>)delegate(IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessInstanceMetricsContainer> a)
		{
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122816655));
			a.MapFrom<ProcessInstanceMetricsContainer>(Expression.Lambda<Func<TProcess, ProcessInstanceMetricsContainer>>(Expression.Call(Expression.Constant(this, typeof(WorkflowProcessMap<TProcess, TProcessDTO>)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(WorkflowProcessMap<TProcess, TProcessDTO>).TypeHandle), Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression3 }));
		});
		parameterExpression = Expression.Parameter(typeof(TProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B60A72B));
		map.ForMember<ProcessMetricsContainer>(Expression.Lambda<Func<TProcessDTO, ProcessMetricsContainer>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessMetricsContainer>>)delegate(IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessMetricsContainer> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B404E3));
			a.MapFrom<ProcessMetricsContainer>(Expression.Lambda<Func<TProcess, ProcessMetricsContainer>>(Expression.Call(Expression.Constant(this, typeof(WorkflowProcessMap<TProcess, TProcessDTO>)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(WorkflowProcessMap<TProcess, TProcessDTO>).TypeHandle), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
		map.AfterMap((Action<TProcess, TProcessDTO>)delegate(TProcess p, TProcessDTO dto)
		{
			if (dto.ContextViewScheme == null)
			{
				dto.ContextViewScheme = new ProcessContextViewScheme();
			}
			if (dto.NamingScheme == null)
			{
				dto.NamingScheme = new InstanceNamingScheme();
			}
			if (dto.Regulation == null)
			{
				dto.Regulation = new ProcessRegulation();
			}
		});
	}

	protected override void InitReverseMap(IMappingExpression<TProcessDTO, TProcess> map)
	{
		base.InitReverseMap(map);
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ConstructUsing((Func<TProcess, TProcessDTO>)(object)(Func<TProcessDTO, TProcess>)((TProcessDTO ctor) => LoadOrCreateEntity(ctor)));
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614C43CD));
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ForMember<DateTime?>((Expression<Func<TProcessDTO, DateTime?>>)(object)Expression.Lambda<Func<TProcess, DateTime?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, DateTime?>>)(Action<IMemberConfigurationExpression<TProcessDTO, TProcess, DateTime?>>)delegate(IMemberConfigurationExpression<TProcessDTO, TProcess, DateTime?> a)
		{
			((IMemberConfigurationExpression<TProcess, TProcessDTO, DateTime?>)(object)a).Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F682E4));
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ForMember<ProcessContext>((Expression<Func<TProcessDTO, ProcessContext>>)(object)Expression.Lambda<Func<TProcess, ProcessContext>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessContext>>)(Action<IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessContext>>)delegate(IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessContext> a)
		{
			((IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessContext>)(object)a).Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516532914));
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ForMember<ProcessInstanceMetricsContainer>((Expression<Func<TProcessDTO, ProcessInstanceMetricsContainer>>)(object)Expression.Lambda<Func<TProcess, ProcessInstanceMetricsContainer>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessInstanceMetricsContainer>>)(Action<IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessInstanceMetricsContainer>>)delegate(IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessInstanceMetricsContainer> a)
		{
			((IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessInstanceMetricsContainer>)(object)a).Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108907760));
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ForMember<ProcessMetricsContainer>((Expression<Func<TProcessDTO, ProcessMetricsContainer>>)(object)Expression.Lambda<Func<TProcess, ProcessMetricsContainer>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessMetricsContainer>>)(Action<IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessMetricsContainer>>)delegate(IMemberConfigurationExpression<TProcessDTO, TProcess, ProcessMetricsContainer> a)
		{
			((IMemberConfigurationExpression<TProcess, TProcessDTO, ProcessMetricsContainer>)(object)a).Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(TProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050354652));
		((IMappingExpression<TProcess, TProcessDTO>)(object)map).ForMember<IWorkflowProcess>((Expression<Func<TProcessDTO, IWorkflowProcess>>)(object)Expression.Lambda<Func<TProcess, IWorkflowProcess>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<TProcess, TProcessDTO, IWorkflowProcess>>)(Action<IMemberConfigurationExpression<TProcessDTO, TProcess, IWorkflowProcess>>)delegate(IMemberConfigurationExpression<TProcessDTO, TProcess, IWorkflowProcess> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(TProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438B57E9));
			((IMemberConfigurationExpression<TProcess, TProcessDTO, IWorkflowProcess>)(object)a).MapFrom<IWorkflowProcess>((Expression<Func<TProcess, IWorkflowProcess>>)(object)Expression.Lambda<Func<TProcessDTO, IWorkflowProcess>>(Expression.Condition(Expression.GreaterThan(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant(0L, typeof(long))), Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IWorkflowProcess>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IWorkflowProcess>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), Expression.Constant(null, typeof(IWorkflowProcess))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected virtual TProcess LoadOrCreateEntity(TProcessDTO dto)
	{
		TProcess val = WorkflowProcessManager.GetManager<TProcess>().LoadOrNull(dto.Id);
		if (val == null)
		{
			val = InterfaceActivator.Create<TProcess>();
		}
		val.Context = (ProcessContext)CopyContextToEntity(dto.Context, val.Context);
		if (dto.InstanceMetrics != null)
		{
			val.InstanceMetrics = (ProcessInstanceMetricsContainer)CopyContextToEntity(dto.InstanceMetrics, val.InstanceMetrics);
		}
		if (dto.ProcessMetrics != null)
		{
			val.ProcessMetrics = (ProcessMetricsContainer)CopyContextToEntity(dto.ProcessMetrics, val.ProcessMetrics);
		}
		return val;
	}

	protected virtual TProcessDTO CopProcessToDTO(TProcess process)
	{
		if (process == null || process.Parent == null)
		{
			return null;
		}
		TProcessDTO val = (TProcessDTO)Activator.CreateInstance(typeof(TProcessDTO));
		return Mapper.Map<IWorkflowProcess, TProcessDTO>(process.Parent, val);
	}

	protected virtual ProcessContext CopyContextToDTO(ProcessContext srcContext)
	{
		//Discarded unreachable code: IL_0078, IL_0087
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				ProcessContext processContext = Mapper.Map<ProcessContext, ProcessContext>(srcContext, new ProcessContext());
				processContext.CreateAndCheckDefaultProperties();
				processContext.ViewModelMetadata = CopyViewModelMetadata(srcContext.ViewModelMetadata);
				return processContext;
			}
			default:
				return null;
			case 1:
				CopyTableParts(srcContext);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				if (srcContext != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	protected virtual ProcessInstanceMetricsContainer CopyMetricToDTO(ProcessInstanceMetricsContainer srcContext)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (srcContext == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					srcContext.Properties.Clear();
					num2 = 3;
				}
				break;
			default:
				return null;
			case 2:
			{
				ProcessInstanceMetricsContainer processInstanceMetricsContainer = Mapper.Map<ProcessInstanceMetricsContainer, ProcessInstanceMetricsContainer>(srcContext, new ProcessInstanceMetricsContainer());
				processInstanceMetricsContainer.CreateAndCheckDefaultProperties();
				return processInstanceMetricsContainer;
			}
			case 3:
				srcContext.Properties.AddRange((IEnumerable<PropertyMetadata>)srcContext.EntityProperties);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual ProcessMetricsContainer CopyIndicatorsToDTO(ProcessMetricsContainer srcContext)
	{
		//Discarded unreachable code: IL_006c, IL_007b
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (srcContext != null)
					{
						num2 = 2;
						continue;
					}
					goto default;
				default:
					return null;
				case 2:
					break;
				case 1:
					return Mapper.Map<ProcessMetricsContainer, ProcessMetricsContainer>(srcContext, new ProcessMetricsContainer());
				case 4:
					srcContext.Properties.AddRange((IEnumerable<PropertyMetadata>)srcContext.EntityProperties);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			srcContext.Properties.Clear();
			num = 4;
		}
	}

	protected virtual EntityMetadata CopyContextToEntity(EntityMetadata srcContext, EntityMetadata result)
	{
		//Discarded unreachable code: IL_00a1, IL_0107, IL_0116, IL_0121, IL_0160, IL_016f, IL_02a8, IL_02b7, IL_02ee, IL_0301, IL_0355, IL_044d, IL_048d, IL_049c, IL_04a8, IL_04dd, IL_05a7, IL_06a9, IL_06bc, IL_06cb, IL_06fa, IL_0709, IL_0714, IL_07e4, IL_07f7, IL_087b, IL_088a, IL_0895, IL_0974, IL_0987, IL_0996, IL_09a7, IL_0a8b, IL_0a9e, IL_0ad1, IL_0ae0, IL_0aeb, IL_0bab, IL_0bbe, IL_0caf, IL_0d47, IL_0d56, IL_0dda, IL_0e12
		int num = 21;
		IEnumerator<EntityPropertyMetadata> enumerator = default(IEnumerator<EntityPropertyMetadata>);
		List<TablePartMetadata>.Enumerator enumerator4 = default(List<TablePartMetadata>.Enumerator);
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_4 = default(_003C_003Ec__DisplayClass11_0);
		EntityPropertyMetadata entityPropertyMetadata2 = default(EntityPropertyMetadata);
		List<TablePartMetadata> list2 = default(List<TablePartMetadata>);
		IEnumerator<TablePartMetadata> enumerator3 = default(IEnumerator<TablePartMetadata>);
		_003C_003Ec__DisplayClass11_3 _003C_003Ec__DisplayClass11_2 = default(_003C_003Ec__DisplayClass11_3);
		_003C_003Ec__DisplayClass11_2 _003C_003Ec__DisplayClass11_3 = default(_003C_003Ec__DisplayClass11_2);
		TablePartMetadata tablePartMetadata3 = default(TablePartMetadata);
		TablePartMetadata tablePartMetadata2 = default(TablePartMetadata);
		TablePartMetadata current3 = default(TablePartMetadata);
		List<EntityPropertyMetadata> list = default(List<EntityPropertyMetadata>);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		TablePartMetadata current2 = default(TablePartMetadata);
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		List<EntityPropertyMetadata>.Enumerator enumerator5 = default(List<EntityPropertyMetadata>.Enumerator);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return srcContext;
				case 31:
					enumerator = ((IEnumerable<EntityPropertyMetadata>)result.EntityProperties).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					enumerator4 = srcContext.TableParts.GetEnumerator();
					num2 = 29;
					continue;
				case 30:
					try
					{
						while (true)
						{
							IL_020c:
							int num21;
							if (!enumerator2.MoveNext())
							{
								num21 = 9;
								goto IL_0125;
							}
							goto IL_01eb;
							IL_0125:
							while (true)
							{
								switch (num21)
								{
								default:
									_003C_003Ec__DisplayClass11_4.epm = (EntityPropertyMetadata)enumerator2.Current;
									num21 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
									{
										num21 = 7;
									}
									continue;
								case 1:
									result.EntityProperties.Add(_003C_003Ec__DisplayClass11_4.epm);
									num21 = 3;
									continue;
								case 6:
									_003C_003Ec__DisplayClass11_4.epm.Owner = result;
									num21 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
									{
										num21 = 0;
									}
									continue;
								case 5:
									break;
								case 3:
								case 4:
									goto IL_020c;
								case 7:
									entityPropertyMetadata2 = ((IEnumerable<EntityPropertyMetadata>)result.EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass11_4._003CCopyContextToEntity_003Eb__0);
									num21 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
									{
										num21 = 2;
									}
									continue;
								case 2:
									if (entityPropertyMetadata2 != null)
									{
										num21 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
										{
											num21 = 10;
										}
										continue;
									}
									goto case 6;
								case 8:
								case 10:
									Mapper.Map((object)_003C_003Ec__DisplayClass11_4.epm, (object)entityPropertyMetadata2, _003C_003Ec__DisplayClass11_4.epm.GetType(), entityPropertyMetadata2.GetType());
									num21 = 4;
									continue;
								case 9:
									goto end_IL_020c;
								}
								break;
							}
							goto IL_01eb;
							IL_01eb:
							_003C_003Ec__DisplayClass11_4 = new _003C_003Ec__DisplayClass11_0();
							num21 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
							{
								num21 = 0;
							}
							goto IL_0125;
							continue;
							end_IL_020c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num22 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 16:
					((ICollection<TablePartMetadata>)srcContext.EntityTableParts).Clear();
					num2 = 14;
					continue;
				case 6:
					enumerator4 = list2.GetEnumerator();
					num2 = 26;
					continue;
				case 19:
					result.TableName = srcContext.TableName;
					num2 = 18;
					continue;
				case 3:
				case 18:
					return result;
				case 15:
					try
					{
						while (true)
						{
							IL_03f9:
							int num13;
							if (!enumerator3.MoveNext())
							{
								num13 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
								{
									num13 = 0;
								}
								goto IL_0363;
							}
							goto IL_03bc;
							IL_03bc:
							_003C_003Ec__DisplayClass11_2 = new _003C_003Ec__DisplayClass11_3();
							num13 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
							{
								num13 = 1;
							}
							goto IL_0363;
							IL_0363:
							while (true)
							{
								switch (num13)
								{
								case 3:
									if (srcContext.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass11_2._003CCopyContextToEntity_003Eb__3) == null)
									{
										num13 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
										{
											num13 = 0;
										}
										continue;
									}
									goto IL_03f9;
								case 4:
									break;
								default:
								{
									list2.Add(_003C_003Ec__DisplayClass11_2.tp);
									int num14 = 5;
									num13 = num14;
									continue;
								}
								case 5:
									goto IL_03f9;
								case 1:
									_003C_003Ec__DisplayClass11_2.tp = enumerator3.Current;
									num13 = 3;
									continue;
								case 2:
									goto end_IL_03f9;
								}
								break;
							}
							goto IL_03bc;
							continue;
							end_IL_03f9:
							break;
						}
					}
					finally
					{
						int num15;
						if (enumerator3 == null)
						{
							num15 = 2;
							goto IL_0451;
						}
						goto IL_0467;
						IL_0451:
						switch (num15)
						{
						default:
							goto end_IL_043c;
						case 1:
							break;
						case 2:
							goto end_IL_043c;
						case 0:
							goto end_IL_043c;
						}
						goto IL_0467;
						IL_0467:
						enumerator3.Dispose();
						num15 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num15 = 0;
						}
						goto IL_0451;
						end_IL_043c:;
					}
					goto case 6;
				case 23:
					if (!(srcContext is ProcessInstanceMetricsContainer))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 5;
				case 17:
					try
					{
						while (true)
						{
							IL_05eb:
							int num18;
							if (!enumerator4.MoveNext())
							{
								num18 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
								{
									num18 = 5;
								}
								goto IL_04eb;
							}
							goto IL_05c2;
							IL_05c2:
							_003C_003Ec__DisplayClass11_3 = new _003C_003Ec__DisplayClass11_2();
							num18 = 3;
							goto IL_04eb;
							IL_04eb:
							while (true)
							{
								switch (num18)
								{
								case 6:
									tablePartMetadata3 = ((IEnumerable<TablePartMetadata>)result.EntityTableParts).FirstOrDefault(_003C_003Ec__DisplayClass11_3._003CCopyContextToEntity_003Eb__2);
									num18 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
									{
										num18 = 0;
									}
									continue;
								case 8:
									CopyContextToEntity(_003C_003Ec__DisplayClass11_3.tp, tablePartMetadata3);
									num18 = 10;
									continue;
								default:
									tablePartMetadata2 = (TablePartMetadata)CopyContextToEntity(_003C_003Ec__DisplayClass11_3.tp, null);
									num18 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
									{
										num18 = 1;
									}
									continue;
								case 4:
									if (tablePartMetadata3 == null)
									{
										num18 = 11;
										continue;
									}
									goto case 2;
								case 7:
									break;
								case 1:
									result.EntityTableParts.Add(tablePartMetadata2);
									num18 = 9;
									continue;
								case 9:
								case 10:
									goto IL_05eb;
								case 11:
									_003C_003Ec__DisplayClass11_3.tp.TablePartOwner = result;
									num18 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
									{
										num18 = 0;
									}
									continue;
								case 3:
									_003C_003Ec__DisplayClass11_3.tp = enumerator4.Current;
									num18 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
									{
										num18 = 6;
									}
									continue;
								case 2:
								{
									Mapper.Map<TablePartMetadata, TablePartMetadata>(_003C_003Ec__DisplayClass11_3.tp, tablePartMetadata3);
									int num19 = 8;
									num18 = num19;
									continue;
								}
								case 5:
									goto end_IL_05eb;
								}
								break;
							}
							goto IL_05c2;
							continue;
							end_IL_05eb:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num20 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num20 = 0;
						}
						switch (num20)
						{
						case 0:
							break;
						}
					}
					goto case 11;
				case 8:
					if (string.IsNullOrEmpty(result.TableName))
					{
						num = 19;
						break;
					}
					goto case 3;
				case 26:
					try
					{
						while (true)
						{
							int num16;
							if (!enumerator4.MoveNext())
							{
								num16 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
								{
									num16 = 1;
								}
								goto IL_0718;
							}
							goto IL_0784;
							IL_0784:
							current3 = enumerator4.Current;
							num16 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
							{
								num16 = 1;
							}
							goto IL_0718;
							IL_0718:
							while (true)
							{
								switch (num16)
								{
								case 3:
									((ICollection<TablePartMetadata>)result.EntityTableParts).Remove(current3);
									num16 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
									{
										num16 = 4;
									}
									continue;
								case 2:
									break;
								default:
									goto IL_0784;
								case 4:
									current3.Delete();
									num16 = 2;
									continue;
								case 1:
									goto end_IL_075e;
								}
								break;
							}
							continue;
							end_IL_075e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num17 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
					goto case 22;
				case 7:
					list = new List<EntityPropertyMetadata>();
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 31;
					}
					continue;
				case 21:
					if (srcContext == null)
					{
						num2 = 20;
						continue;
					}
					if (result != null)
					{
						result.TitlePropertyUid = srcContext.TitlePropertyUid;
						num2 = 4;
						continue;
					}
					num = 28;
					break;
				case 27:
					if (srcContext.TableParts != null)
					{
						num2 = 12;
						continue;
					}
					goto case 22;
				case 22:
					if (!(srcContext is ProcessMetricsContainer))
					{
						num2 = 23;
						continue;
					}
					goto case 5;
				case 28:
					((ICollection<EntityPropertyMetadata>)srcContext.EntityProperties).Clear();
					num2 = 25;
					continue;
				case 29:
					try
					{
						while (true)
						{
							IL_090a:
							int num11;
							if (!enumerator4.MoveNext())
							{
								num11 = 5;
								goto IL_0899;
							}
							goto IL_08bb;
							IL_0899:
							while (true)
							{
								switch (num11)
								{
								case 5:
									return srcContext;
								case 3:
									break;
								case 2:
									tablePartMetadata = (TablePartMetadata)CopyContextToEntity(current2, null);
									num11 = 4;
									continue;
								default:
									current2.TablePartOwner = srcContext;
									num11 = 2;
									continue;
								case 1:
									goto IL_090a;
								case 4:
									srcContext.EntityTableParts.Add(tablePartMetadata);
									num11 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
									{
										num11 = 0;
									}
									continue;
								}
								break;
							}
							goto IL_08bb;
							IL_08bb:
							current2 = enumerator4.Current;
							num11 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
							{
								num11 = 0;
							}
							goto IL_0899;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
				case 24:
					try
					{
						while (true)
						{
							IL_0a11:
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
								{
									num8 = 3;
								}
								goto IL_09b5;
							}
							goto IL_09d3;
							IL_09d3:
							entityPropertyMetadata = (EntityPropertyMetadata)enumerator2.Current;
							int num9 = 4;
							num8 = num9;
							goto IL_09b5;
							IL_09b5:
							while (true)
							{
								switch (num8)
								{
								case 2:
									break;
								case 4:
									entityPropertyMetadata.Owner = srcContext;
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
									{
										num8 = 0;
									}
									continue;
								case 1:
									goto IL_0a11;
								default:
									srcContext.EntityProperties.Add(entityPropertyMetadata);
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
									{
										num8 = 1;
									}
									continue;
								case 3:
									goto end_IL_0a11;
								}
								break;
							}
							goto IL_09d3;
							continue;
							end_IL_0a11:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 2:
					enumerator5 = list.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_0b69:
							int num6;
							if (!enumerator5.MoveNext())
							{
								num6 = 2;
								goto IL_0aef;
							}
							goto IL_0b56;
							IL_0aef:
							while (true)
							{
								switch (num6)
								{
								default:
									current.Delete();
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num6 = 1;
									}
									continue;
								case 4:
									((ICollection<EntityPropertyMetadata>)result.EntityProperties).Remove(current);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
									{
										num6 = 0;
									}
									continue;
								case 3:
									break;
								case 1:
									goto IL_0b69;
								case 2:
									goto end_IL_0b69;
								}
								break;
							}
							goto IL_0b56;
							IL_0b56:
							current = enumerator5.Current;
							num6 = 4;
							goto IL_0aef;
							continue;
							end_IL_0b69:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator5).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 27;
				case 5:
					if (string.IsNullOrEmpty(result.Name))
					{
						num2 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 8;
				case 12:
					enumerator4 = srcContext.TableParts.GetEnumerator();
					num2 = 17;
					continue;
				case 13:
					enumerator3 = ((IEnumerable<TablePartMetadata>)result.EntityTableParts).GetEnumerator();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 15;
					}
					continue;
				case 4:
					enumerator2 = srcContext.Properties.GetEnumerator();
					num2 = 30;
					continue;
				case 9:
					result.Name = srcContext.Name;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 3;
					}
					continue;
				case 25:
					enumerator2 = srcContext.Properties.GetEnumerator();
					num = 24;
					break;
				case 11:
					list2 = new List<TablePartMetadata>();
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 7;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
								{
									num3 = 4;
								}
								goto IL_0cbd;
							}
							goto IL_0d31;
							IL_0d31:
							_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_1();
							num3 = 4;
							goto IL_0cbd;
							IL_0cbd:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 5:
									break;
								case 4:
									_003C_003Ec__DisplayClass11_.epm = enumerator.Current;
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto IL_0d31;
								default:
									if (srcContext.Properties.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CCopyContextToEntity_003Eb__1) != null)
									{
										int num4 = 5;
										num3 = num4;
										continue;
									}
									goto case 2;
								case 2:
									list.Add(_003C_003Ec__DisplayClass11_.epm);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
									{
										num3 = 1;
									}
									continue;
								case 6:
									goto end_IL_0ce3;
								}
								break;
							}
							continue;
							end_IL_0ce3:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									enumerator.Dispose();
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
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
					goto case 2;
				case 20:
					return null;
				}
				break;
			}
		}
	}

	private void CopyTableParts(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_00da, IL_00e9, IL_00f4, IL_0199, IL_01ac
		int num = 6;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					metadata.Properties.AddRange((IEnumerable<PropertyMetadata>)metadata.EntityProperties);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 1:
					enumerator = metadata.TableParts.GetEnumerator();
					num2 = 4;
					continue;
				case 6:
					metadata.Properties.Clear();
					num2 = 5;
					continue;
				case 3:
					metadata.TableParts.AddRange((IEnumerable<TablePartMetadata>)metadata.EntityTableParts);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
								{
									num3 = 1;
								}
								goto IL_00f8;
							}
							goto IL_0138;
							IL_0138:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00f8;
							IL_00f8:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 1:
									break;
								default:
									goto IL_0138;
								case 3:
									CopyTableParts(current);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
			metadata.TableParts.Clear();
			num = 3;
		}
	}

	private DataClassMetadata CopyViewModelMetadata(DataClassMetadata dataClassMetadata)
	{
		return ClassSerializationHelper.CloneObjectByXml(dataClassMetadata);
	}

	protected WorkflowProcessMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lSLyjsSNpdqaN8vacJZ()
	{
		return sUpSN3SeDYU6uAM06V8 == null;
	}

	internal static object DZHA0ASxGJQ57fqCxb4()
	{
		return sUpSN3SeDYU6uAM06V8;
	}
}
