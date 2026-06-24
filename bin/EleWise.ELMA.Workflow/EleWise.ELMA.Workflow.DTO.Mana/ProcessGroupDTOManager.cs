using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class ProcessGroupDTOManager : DTOManager, IProcessGroupDTOManager, IConfigurationService
{
	private static ProcessGroupDTOManager aKRmneNVuSNM8SntyiJ;

	public ProcessGroupManager ProcessGroupManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessGroupManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CProcessGroupManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual ProcessGroupDTO LoadRootGroup(long updateProcess = 0L)
	{
		int num = 2;
		int num2 = num;
		ProcessGroupDTO processGroupDTO2 = default(ProcessGroupDTO);
		IEnumerable<IProcessGroup> subGroups = default(IEnumerable<IProcessGroup>);
		IEnumerable<IProcessHeader> processHeads = default(IEnumerable<IProcessHeader>);
		while (true)
		{
			switch (num2)
			{
			default:
				return processGroupDTO2;
			case 2:
			{
				ProcessGroupDTO processGroupDTO = new ProcessGroupDTO();
				PSScbhNoedUmXR3TCAK(processGroupDTO, VVZ4O7N2CZBiTUgLeis(jYH0KON7FFZwyj6pVJC(0xD305CC2 ^ 0xD310BE0)));
				processGroupDTO2 = processGroupDTO;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				subGroups = ProcessGroupManager.LoadRootGroups();
				num2 = 4;
				break;
			case 3:
				FillGroupChilds(processGroupDTO2, subGroups, processHeads, updateProcess);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				processHeads = ProcessHeaderManager.LoadRootProcessHeads();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public virtual ProcessGroupDTO LoadRootGroupByRuntime(RuntimeVersion? runtimeVersion = null)
	{
		ProcessGroupDTO processGroupDTO = new ProcessGroupDTO
		{
			Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980621562))
		};
		IEnumerable<IProcessGroup> subGroups = ProcessGroupManager.LoadRootGroups();
		IEnumerable<IProcessHeader> processHeads = ((!runtimeVersion.HasValue) ? ProcessHeaderManager.LoadRootProcessHeads() : ProcessHeaderManager.LoadRootProcessHeads(runtimeVersion.Value));
		FillGroupChilds(processGroupDTO, subGroups, processHeads, 0L);
		return processGroupDTO;
	}

	public virtual IEnumerable<ProcessGroupDTO> GetChildGroups(long parentGroupId)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.parentGroup = ((parentGroupId > 0) ? ProcessGroupManager.Load(parentGroupId) : null);
		ProcessGroupManager processGroupManager = ProcessGroupManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684241930));
		return (from g in processGroupManager.Find(Expression.Lambda<Func<IProcessGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IProcessGroup, ProcessGroupDTO>(g)).ToList();
	}

	public virtual IEnumerable<ProcessGroupDTO> GetNestedChildGroups(long parentGroupId)
	{
		if (((parentGroupId > 0) ? ProcessGroupManager.Load(parentGroupId) : null) == null)
		{
			return new List<ProcessGroupDTO>();
		}
		List<ProcessGroupDTO> list = new List<ProcessGroupDTO>();
		GetChilds(parentGroupId, list);
		return list;
	}

	private void GetChilds(long parentGroupId, List<ProcessGroupDTO> childs)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.parentGroupId = parentGroupId;
		CS_0024_003C_003E8__locals0.childs = childs;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		if (CS_0024_003C_003E8__locals0.childs == null)
		{
			CS_0024_003C_003E8__locals0.childs = new List<ProcessGroupDTO>();
		}
		if (!CS_0024_003C_003E8__locals0.childs.All((ProcessGroupDTO r) => r.Id != CS_0024_003C_003E8__locals0.parentGroupId))
		{
			return;
		}
		_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
		_003C_003Ec__DisplayClass4_.parentGroup = ((CS_0024_003C_003E8__locals0.parentGroupId > 0) ? ProcessGroupManager.Load(CS_0024_003C_003E8__locals0.parentGroupId) : null);
		if (_003C_003Ec__DisplayClass4_.parentGroup == null)
		{
			return;
		}
		ProcessGroupManager processGroupManager = ProcessGroupManager;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IProcessGroup), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B617373));
		List<ProcessGroupDTO> list = (from g in processGroupManager.Find(Expression.Lambda<Func<IProcessGroup, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass4_, typeof(_003C_003Ec__DisplayClass4_1)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
			select Mapper.Map<IProcessGroup, ProcessGroupDTO>(g)).ToList();
		if (!list.Any())
		{
			return;
		}
		list.ForEach(delegate(ProcessGroupDTO g)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass4_2 _003C_003Ec__DisplayClass4_2 = default(_003C_003Ec__DisplayClass4_2);
			while (true)
			{
				switch (num2)
				{
				default:
					CS_0024_003C_003E8__locals0._003C_003E4__this.GetChilds(_003C_003Ec__DisplayClass4_2.g.Id, CS_0024_003C_003E8__locals0.childs);
					num2 = 3;
					break;
				case 4:
					return;
				case 1:
					_003C_003Ec__DisplayClass4_2.g = g;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_2();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if (!CS_0024_003C_003E8__locals0.childs.All(_003C_003Ec__DisplayClass4_2._003CGetChilds_003Eb__4))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					CS_0024_003C_003E8__locals0.childs.Add(_003C_003Ec__DisplayClass4_2.g);
					num2 = 6;
					break;
				case 6:
					CS_0024_003C_003E8__locals0.childs.ForEach(delegate(ProcessGroupDTO c)
					{
						//Discarded unreachable code: IL_008d, IL_009c
						int num3 = 2;
						int num4 = num3;
						_003C_003Ec__DisplayClass4_3 _003C_003Ec__DisplayClass4_3 = default(_003C_003Ec__DisplayClass4_3);
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 4:
								CS_0024_003C_003E8__locals0.childs.Add(_003C_003Ec__DisplayClass4_3.c);
								num4 = 3;
								break;
							case 0:
								return;
							case 3:
								return;
							case 5:
								if (!CS_0024_003C_003E8__locals0.childs.All(_003C_003Ec__DisplayClass4_3._003CGetChilds_003Eb__6))
								{
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 4;
							case 1:
								_003C_003Ec__DisplayClass4_3.c = c;
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
								{
									num4 = 5;
								}
								break;
							case 2:
								_003C_003Ec__DisplayClass4_3 = new _003C_003Ec__DisplayClass4_3();
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
								{
									num4 = 0;
								}
								break;
							}
						}
					});
					num2 = 4;
					break;
				}
			}
		});
	}

	public virtual ProcessGroupDTO Save(ProcessGroupDTO group)
	{
		int num = 3;
		int num2 = num;
		IProcessGroup processGroup = default(IProcessGroup);
		while (true)
		{
			switch (num2)
			{
			case 2:
				TykJVeNFg9CmIEc8DAN(processGroup);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				return Mapper.Map<IProcessGroup, ProcessGroupDTO>(processGroup, group);
			default:
				JJjxbsNInp28xir4BEe(h6PG3VNigyZCpVToskW(processGroup));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (h6PG3VNigyZCpVToskW(processGroup) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				processGroup = Mapper.Map<ProcessGroupDTO, IProcessGroup>(group);
				num2 = 2;
				break;
			}
		}
	}

	public virtual void Delete(long groupId)
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
				lOoMYgNaYMXo3v9n8q8(ProcessGroupManager, groupId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void FindHeader(IProcessHeader header, long id, List<IProcessHeader> result)
	{
		if (header.Id == id)
		{
			result.Add(header);
		}
		if (result.Count > 0)
		{
			return;
		}
		foreach (IProcessHeader item in (IEnumerable<IProcessHeader>)header.SubHeaders)
		{
			FindHeader(item, id, result);
		}
	}

	private void FillGroupChilds(ProcessGroupDTO groupDto, IEnumerable<IProcessGroup> subGroups, IEnumerable<IProcessHeader> processHeads, long updateProcess = 0L)
	{
		foreach (IProcessGroup subGroup in subGroups)
		{
			ProcessGroupDTO item = Mapper.Map<IProcessGroup, ProcessGroupDTO>(subGroup, new ProcessGroupDTO());
			groupDto.SubGroups.Add(item);
		}
		foreach (IProcessHeader processHead in processHeads)
		{
			if (updateProcess > 0)
			{
				List<IProcessHeader> list = new List<IProcessHeader>();
				FindHeader(processHead, updateProcess, list);
				if (list.Count > 0)
				{
					list[0].Refresh();
				}
			}
			ProcessHeaderDTO item2 = Mapper.Map<IProcessHeader, ProcessHeaderDTO>(processHead, new ProcessHeaderDTO());
			groupDto.Processes.Add(item2);
		}
	}

	public ProcessGroupDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MYauCFNrwuXTvRxcR7N();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jYH0KON7FFZwyj6pVJC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VVZ4O7N2CZBiTUgLeis(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void PSScbhNoedUmXR3TCAK(object P_0, object P_1)
	{
		((ProcessGroupDTO)P_0).Name = (string)P_1;
	}

	internal static bool HkjfXcNAnf0KwdateoL()
	{
		return aKRmneNVuSNM8SntyiJ == null;
	}

	internal static ProcessGroupDTOManager qqloeZNGoTZY4jFEI6c()
	{
		return aKRmneNVuSNM8SntyiJ;
	}

	internal static void TykJVeNFg9CmIEc8DAN(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object h6PG3VNigyZCpVToskW(object P_0)
	{
		return ((IProcessGroup)P_0).Parent;
	}

	internal static void JJjxbsNInp28xir4BEe(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static void lOoMYgNaYMXo3v9n8q8(object P_0, long groupId)
	{
		((ProcessGroupManager)P_0).Delete(groupId);
	}

	internal static void MYauCFNrwuXTvRxcR7N()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
