using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class ProcessHeaderMap : EntityDTOMap<IProcessHeader, ProcessHeaderDTO>
{
	internal static ProcessHeaderMap CGOwQ9SWCX2IJdG3Xam;

	protected override void InitMap(IMappingExpression<IProcessHeader, ProcessHeaderDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ProcessHeaderDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559A3076));
		map.ForMember<List<ProcessHeaderDTO>>(Expression.Lambda<Func<ProcessHeaderDTO, List<ProcessHeaderDTO>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IProcessHeader, ProcessHeaderDTO, List<ProcessHeaderDTO>>>)delegate(IMemberConfigurationExpression<IProcessHeader, ProcessHeaderDTO, List<ProcessHeaderDTO>> p)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA5B11E));
			p.MapFrom<List<ProcessHeaderDTO>>(Expression.Lambda<Func<IProcessHeader, List<ProcessHeaderDTO>>>(Expression.Call(Expression.Constant(this, typeof(ProcessHeaderMap)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<ProcessHeaderDTO, IProcessHeader> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F8ED2F));
		map.ForMember<IUser>(Expression.Lambda<Func<IProcessHeader, IUser>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IUser>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IUser> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213FE98F));
		map.ForMember<DateTime?>(Expression.Lambda<Func<IProcessHeader, DateTime?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, DateTime?>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, DateTime?> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716492739));
		map.ForMember<IWorkflowProcess>(Expression.Lambda<Func<IProcessHeader, IWorkflowProcess>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IWorkflowProcess>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IWorkflowProcess> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927576B));
		map.ForMember<IWorkflowProcess>(Expression.Lambda<Func<IProcessHeader, IWorkflowProcess>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IWorkflowProcess>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IWorkflowProcess> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -419967055));
		map.ForMember<ISet<IProcessHeader>>(Expression.Lambda<Func<IProcessHeader, ISet<IProcessHeader>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, ISet<IProcessHeader>>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, ISet<IProcessHeader>> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45864887));
		map.ForMember<WorkflowProcessStatus>(Expression.Lambda<Func<IProcessHeader, WorkflowProcessStatus>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, WorkflowProcessStatus>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, WorkflowProcessStatus> p)
		{
			p.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IProcessHeader), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776339194));
		map.ForMember<IProcessGroup>(Expression.Lambda<Func<IProcessHeader, IProcessGroup>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IProcessGroup>>)delegate(IMemberConfigurationExpression<ProcessHeaderDTO, IProcessHeader, IProcessGroup> p)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ProcessHeaderDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4942BA4E));
			p.MapFrom<IProcessGroup>(Expression.Lambda<Func<ProcessHeaderDTO, IProcessGroup>>(Expression.Call(Expression.Property(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityManager<IProcessGroup>).TypeHandle)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntityManager<IProcessGroup>).TypeHandle), Expression.Convert(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object))), new ParameterExpression[1] { parameterExpression2 }));
		});
		map.AfterMap((Action<ProcessHeaderDTO, IProcessHeader>)MapToHeader);
	}

	protected List<ProcessHeaderDTO> MapSubHeadersToDto(ISet<IProcessHeader> headers)
	{
		if (headers == null)
		{
			return null;
		}
		List<ProcessHeaderDTO> list = new List<ProcessHeaderDTO>();
		foreach (IProcessHeader header in headers)
		{
			list.Add(Mapper.Map<IProcessHeader, ProcessHeaderDTO>(header, new ProcessHeaderDTO()));
		}
		return list;
	}

	protected void MapToHeader(ProcessHeaderDTO dto, IProcessHeader header)
	{
		//Discarded unreachable code: IL_0084, IL_0156, IL_0207, IL_021a, IL_0229
		int num = 4;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		List<ProcessHeaderDTO>.Enumerator enumerator = default(List<ProcessHeaderDTO>.Enumerator);
		_003C_003Ec__DisplayClass3_2 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_2);
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					break;
				case 1:
					((IEnumerable<IProcessHeader>)header.SubHeaders).Where(_003C_003Ec__DisplayClass3_._003CMapToHeader_003Eb__0).ToList();
					num2 = 2;
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 6;
								goto IL_0092;
							}
							goto IL_019f;
							IL_0092:
							while (true)
							{
								switch (num3)
								{
								case 6:
									return;
								case 3:
								{
									header.SubHeaders.Add(Mapper.Map<ProcessHeaderDTO, IProcessHeader>(_003C_003Ec__DisplayClass3_2.headerDTO, EntityManager<IProcessHeader>.Instance.Create()));
									int num4 = 9;
									num3 = num4;
									continue;
								}
								default:
									_003C_003Ec__DisplayClass3_2.headerDTO = enumerator.Current;
									num3 = 8;
									continue;
								case 7:
									processHeader = ((IEnumerable<IProcessHeader>)header.SubHeaders).FirstOrDefault(_003C_003Ec__DisplayClass3_2._003CMapToHeader_003Eb__2);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									if (processHeader != null)
									{
										num3 = 5;
										continue;
									}
									break;
								case 4:
								case 9:
									break;
								case 5:
									Mapper.Map<ProcessHeaderDTO, IProcessHeader>(_003C_003Ec__DisplayClass3_2.headerDTO, processHeader);
									num3 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
									{
										num3 = 4;
									}
									continue;
								case 2:
									goto IL_019f;
								case 8:
									if (_003C_003Ec__DisplayClass3_2.headerDTO.Id == 0L)
									{
										num3 = 3;
										continue;
									}
									goto case 7;
								}
								break;
							}
							continue;
							IL_019f:
							_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_2();
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
							{
								num3 = 0;
							}
							goto IL_0092;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 4:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass3_.dto = dto;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			enumerator = _003C_003Ec__DisplayClass3_.dto.SubHeaders.GetEnumerator();
			num = 5;
		}
	}

	public ProcessHeaderMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EtZqZcS63FfQXJUcQZA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tI0jPbSjsU6AYy76bLY()
	{
		return CGOwQ9SWCX2IJdG3Xam == null;
	}

	internal static ProcessHeaderMap k6om25SRgC2N4KtiOpg()
	{
		return CGOwQ9SWCX2IJdG3Xam;
	}

	internal static void EtZqZcS63FfQXJUcQZA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
