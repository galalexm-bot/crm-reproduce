using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class ProcessContextDTOManager : DTOManager, IProcessContextDTOManager, IConfigurationService
{
	internal static ProcessContextDTOManager M01uBFNRiMTkcErxe7W;

	public ProcessContextManager ProcessContextManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessContextManager_003Ek__BackingField;
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
				case 1:
					_003CProcessContextManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual ProcessContext Load(Guid uid)
	{
		int num = 1;
		int num2 = num;
		ProcessContext processContext = default(ProcessContext);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Mapper.Map<ProcessContext, ProcessContext>(processContext, new ProcessContext());
			case 1:
				processContext = ProcessContextManager.Load(uid);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				CopyTableParts(processContext);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual ProcessContext LoadFullContext(long processHeadId)
	{
		//Discarded unreachable code: IL_007b, IL_008a
		int num = 1;
		int num2 = num;
		ProcessContext processContext = default(ProcessContext);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return new ProcessContext();
			case 2:
				CopyTableParts(processContext);
				num2 = 4;
				break;
			case 4:
				return Mapper.Map<ProcessContext, ProcessContext>(processContext, new ProcessContext());
			default:
				if (processContext != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				processContext = (ProcessContext)h5At1LNTWPZSwmF1H7X(((AbstractNHEntityManager<IProcessHeader, long>)Kep3jDN32Exi2u9xvW3()).Load(processHeadId));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IDictionary<ProcessInfoDTO, IEnumerable<ProcessPropertyInfoDTO>> GetChildPropertyNames(long processHeaderId)
	{
		return ProcessContextManager.GetChildPropertyNames(processHeaderId);
	}

	public virtual string AllHaveUids()
	{
		return (string)A6lrQVNpg5i4imsHPr9(THVjtcNQQLLb6H8aXpP());
	}

	public virtual void UpdateContextTableUids()
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
				wLyq4MNCdPT1xlnrCEU(ProcessContextManager);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CopyTableParts(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_006a, IL_0078, IL_012d, IL_0140
		int num = 4;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = metadata.TableParts.GetEnumerator();
				num2 = 2;
				break;
			case 4:
				tAnOp2NM7GAN4hl3OnT(metadata.Properties);
				num2 = 3;
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_00db:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
							{
								num3 = 1;
							}
							goto IL_007c;
						}
						goto IL_0096;
						IL_0096:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
						{
							num3 = 0;
						}
						goto IL_007c;
						IL_007c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							default:
								CopyTableParts(current);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								goto IL_00db;
							case 1:
								return;
							}
							break;
						}
						goto IL_0096;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			default:
				metadata.TableParts.AddRange((IEnumerable<TablePartMetadata>)metadata.EntityTableParts);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 3:
				metadata.Properties.AddRange((IEnumerable<PropertyMetadata>)metadata.EntityProperties);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				oxppcTNkoSyB7EalyRa(metadata.TableParts);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ProcessContextDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		t5fmesNU4ZJgbbpyKfC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool pE3cu0N6xOfyQ3CXgRJ()
	{
		return M01uBFNRiMTkcErxe7W == null;
	}

	internal static ProcessContextDTOManager nPb9GQNqoc3wK58HvOV()
	{
		return M01uBFNRiMTkcErxe7W;
	}

	internal static object Kep3jDN32Exi2u9xvW3()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object h5At1LNTWPZSwmF1H7X(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static object THVjtcNQQLLb6H8aXpP()
	{
		return ProcessContextManager.Instance;
	}

	internal static object A6lrQVNpg5i4imsHPr9(object P_0)
	{
		return ((ProcessContextManager)P_0).AllHaveUids();
	}

	internal static void wLyq4MNCdPT1xlnrCEU(object P_0)
	{
		((ProcessContextManager)P_0).UpdateContextTableUids();
	}

	internal static void tAnOp2NM7GAN4hl3OnT(object P_0)
	{
		((List<PropertyMetadata>)P_0).Clear();
	}

	internal static void oxppcTNkoSyB7EalyRa(object P_0)
	{
		((List<TablePartMetadata>)P_0).Clear();
	}

	internal static void t5fmesNU4ZJgbbpyKfC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
