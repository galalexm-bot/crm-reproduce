using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.BPMN.DTO.Models;
using EleWise.ELMA.Workflow.BPMN.Managers;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.DTO.AutoMaps;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.DTO.AutoMaps;

public class BPMNProcessMap : WorkflowProcessMap<IBPMNProcess, BPMNProcessDTO>
{
	internal static BPMNProcessMap bjLDbnO7Bi8ofXNOBji9;

	protected override void InitMap(IMappingExpression<IBPMNProcess, BPMNProcessDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(BPMNProcessDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1360975921));
		map.ForMember<List<ResponsibilityMatrixItemDTO>>(Expression.Lambda<Func<BPMNProcessDTO, List<ResponsibilityMatrixItemDTO>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IBPMNProcess, BPMNProcessDTO, List<ResponsibilityMatrixItemDTO>>>)delegate(IMemberConfigurationExpression<IBPMNProcess, BPMNProcessDTO, List<ResponsibilityMatrixItemDTO>> mo)
		{
			mo.ResolveUsing<List<ResponsibilityMatrixItemDTO>>((Func<IBPMNProcess, List<ResponsibilityMatrixItemDTO>>)MapResponsibilityMatrixToDto);
		});
	}

	protected override void InitReverseMap(IMappingExpression<BPMNProcessDTO, IBPMNProcess> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IBPMNProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF5CDD6));
		map.ForMember<ISet<IResponsibilityMatrixItem>>(Expression.Lambda<Func<IBPMNProcess, ISet<IResponsibilityMatrixItem>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<BPMNProcessDTO, IBPMNProcess, ISet<IResponsibilityMatrixItem>>>)delegate(IMemberConfigurationExpression<BPMNProcessDTO, IBPMNProcess, ISet<IResponsibilityMatrixItem>> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<BPMNProcessDTO, IBPMNProcess>)MapResponsibilityMatrix);
	}

	protected void MapResponsibilityMatrix(BPMNProcessDTO dto, IBPMNProcess process)
	{
		//Discarded unreachable code: IL_0073, IL_0098, IL_00a7, IL_01d3, IL_0215, IL_030c, IL_031f
		int num = 8;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		List<ResponsibilityMatrixItemDTO>.Enumerator enumerator = default(List<ResponsibilityMatrixItemDTO>.Enumerator);
		IResponsibilityMatrixItem responsibilityMatrixItem2 = default(IResponsibilityMatrixItem);
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		_003C_003Ec__DisplayClass2_2 _003C_003Ec__DisplayClass2_2 = default(_003C_003Ec__DisplayClass2_2);
		List<IResponsibilityMatrixItem> list = default(List<IResponsibilityMatrixItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (_003C_003Ec__DisplayClass2_.dto != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 8:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num = 7;
					break;
				case 9:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 15;
								goto IL_00b6;
							}
							goto IL_0278;
							IL_00b6:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 12:
									if (responsibilityMatrixItem2 == null)
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 4;
								case 14:
									YN100mO7uXvAmTOZjLRt(responsibilityMatrixItem2, process);
									num3 = 13;
									continue;
								case 3:
									responsibilityMatrixItem.BPMNProcess = process;
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									responsibilityMatrixItem2 = ((IEnumerable<IResponsibilityMatrixItem>)process.ResponsibilityMatrix).FirstOrDefault(_003C_003Ec__DisplayClass2_2._003CMapResponsibilityMatrix_003Eb__2);
									num4 = 12;
									goto IL_00b2;
								default:
									responsibilityMatrixItem2 = ResponsibilityMatrixItemManager.Instance.LoadOrNull(_003C_003Ec__DisplayClass2_2.itemDTO.Id);
									num3 = 10;
									continue;
								case 10:
									if (responsibilityMatrixItem2 == null)
									{
										num3 = 4;
										continue;
									}
									goto case 9;
								case 13:
								case 16:
									break;
								case 8:
									responsibilityMatrixItem = Mapper.Map<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem>(_003C_003Ec__DisplayClass2_2.itemDTO, ((AbstractNHEntityManager<IResponsibilityMatrixItem, long>)QXLVmPO7dQs6vUNNHWDv()).Create());
									num3 = 3;
									continue;
								case 4:
								case 6:
									if (responsibilityMatrixItem2 != null)
									{
										num3 = 5;
										continue;
									}
									break;
								case 9:
									process.ResponsibilityMatrix.Add(responsibilityMatrixItem2);
									num3 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
									{
										num3 = 6;
									}
									continue;
								case 1:
									process.ResponsibilityMatrix.Add(responsibilityMatrixItem);
									num3 = 16;
									continue;
								case 5:
									Mapper.Map<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem>(_003C_003Ec__DisplayClass2_2.itemDTO, responsibilityMatrixItem2);
									num3 = 14;
									continue;
								case 17:
									goto IL_0278;
								case 11:
									_003C_003Ec__DisplayClass2_2.itemDTO = enumerator.Current;
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
									{
										num3 = 7;
									}
									continue;
								case 7:
									if (_003C_003Ec__DisplayClass2_2.itemDTO.Id == 0L)
									{
										num4 = 8;
										goto IL_00b2;
									}
									goto case 2;
								case 15:
									return;
									IL_00b2:
									num3 = num4;
									continue;
								}
								break;
							}
							continue;
							IL_0278:
							_003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_2();
							num3 = 11;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
							{
								num3 = 9;
							}
							goto IL_00b6;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 1:
					process.ResponsibilityMatrix.RemoveAll((ICollection<IResponsibilityMatrixItem>)list);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
					{
						num2 = 2;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass2_.dto = dto;
					num = 3;
					break;
				case 4:
					MiGPEKO7XIlWokbas7h9(process.ResponsibilityMatrix);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					return;
				case 6:
					enumerator = _003C_003Ec__DisplayClass2_.dto.ResponsibilityMatrix.GetEnumerator();
					num2 = 9;
					continue;
				case 2:
					return;
				case 5:
					list = ((IEnumerable<IResponsibilityMatrixItem>)process.ResponsibilityMatrix).Where(_003C_003Ec__DisplayClass2_._003CMapResponsibilityMatrix_003Eb__0).ToList();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (process == null)
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	protected List<ResponsibilityMatrixItemDTO> MapResponsibilityMatrixToDto(IBPMNProcess process)
	{
		List<ResponsibilityMatrixItemDTO> list = new List<ResponsibilityMatrixItemDTO>();
		foreach (IResponsibilityMatrixItem item2 in (IEnumerable<IResponsibilityMatrixItem>)process.ResponsibilityMatrix)
		{
			ResponsibilityMatrixItemDTO item = Mapper.Map<IResponsibilityMatrixItem, ResponsibilityMatrixItemDTO>(item2, new ResponsibilityMatrixItemDTO());
			list.Add(item);
		}
		return list;
	}

	public BPMNProcessMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mlVesQO7D9Ztlvxh53EZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void MiGPEKO7XIlWokbas7h9(object P_0)
	{
		((ICollection<IResponsibilityMatrixItem>)P_0).Clear();
	}

	internal static object QXLVmPO7dQs6vUNNHWDv()
	{
		return ResponsibilityMatrixItemManager.Instance;
	}

	internal static void YN100mO7uXvAmTOZjLRt(object P_0, object P_1)
	{
		((IResponsibilityMatrixItem)P_0).BPMNProcess = (IBPMNProcess)P_1;
	}

	internal static bool VLLjbBO7cOq7BBNwpaf4()
	{
		return bjLDbnO7Bi8ofXNOBji9 == null;
	}

	internal static BPMNProcessMap ALwl2iO7PaVdsF1nveKp()
	{
		return bjLDbnO7Bi8ofXNOBji9;
	}

	internal static void mlVesQO7D9Ztlvxh53EZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
public abstract class BPMNProcessMap<TProcess, TProcessDTO> : WorkflowProcessMap<TProcess, TProcessDTO> where TProcess : class, IBPMNProcess where TProcessDTO : BPMNProcessDTO
{
	internal static object cu27RcO7nRiXacHsQTve;

	protected BPMNProcessMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AivrSAO7Hp7u09DXYkNT()
	{
		return cu27RcO7nRiXacHsQTve == null;
	}

	internal static object uxoFxdO7LJLO03LT6WWJ()
	{
		return cu27RcO7nRiXacHsQTve;
	}
}
