using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

internal interface ICommonEditEntityWorkflowElement
{
	bool SelectForm { get; set; }

	Guid FormUid { get; set; }

	bool TypeFromVar { get; set; }

	Guid TypeVar { get; set; }

	List<Guid> Vars { get; set; }

	Guid Type { get; set; }
}
internal static class ICommonEditEntityWorkflowElementExtensions
{
	internal static ICommonEditEntityWorkflowElementExtensions XdNY4EZvXdnMCuwKD1a0;

	public static IEntity ExtractFromInstance(this ICommonEditEntityWorkflowElement element, IWorkflowInstance instance)
	{
		int num = 6;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		List<Guid> vars = default(List<Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					break;
				case 3:
					_003C_003Ec__DisplayClass0_.res = null;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					return _003C_003Ec__DisplayClass0_.res;
				case 5:
					_003C_003Ec__DisplayClass0_.instance = instance;
					num2 = 3;
					continue;
				case 4:
					if (vars == null)
					{
						return _003C_003Ec__DisplayClass0_.res;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					vars = element.Vars;
					num2 = 4;
					continue;
				case 1:
					vars.ForEach(_003C_003Ec__DisplayClass0_._003CExtractFromInstance_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			num = 5;
		}
	}

	public static void SetToInstance(this ICommonEditEntityWorkflowElement element, IWorkflowInstance instance, IEntity val)
	{
		int num = 3;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		List<Guid> vars = default(List<Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 2;
					continue;
				case 6:
					vars = element.Vars;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass1_.val = val;
					num2 = 6;
					continue;
				case 4:
					break;
				case 2:
					_003C_003Ec__DisplayClass1_.instance = instance;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				default:
					if (vars == null)
					{
						return;
					}
					num2 = 4;
					continue;
				}
				break;
			}
			vars.ForEach(_003C_003Ec__DisplayClass1_._003CSetToInstance_003Eb__0);
			num = 5;
		}
	}

	public static Guid GetEntityType(this ICommonEditEntityWorkflowElement element, WorkflowInstanceContext context)
	{
		//Discarded unreachable code: IL_007d, IL_00a1, IL_011b, IL_012a
		int num = 2;
		Guid guid = default(Guid);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					guid = ((ReferenceOnEntityType)obj).TypeUid;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					if (obj != null)
					{
						num = 4;
						break;
					}
					goto case 8;
				case 11:
					if (!(obj is ReferenceOnEntityType))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 5;
				case 6:
				case 12:
					return guid;
				case 8:
					return Guid.Empty;
				case 4:
					guid = new Guid(obj.ToString());
					num = 3;
					break;
				case 2:
					if (element != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 1:
					if (context != null)
					{
						num2 = 10;
						continue;
					}
					goto default;
				case 3:
					if (bjtUAXZvLwoQtKPgFoyt(guid, Guid.Empty))
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 6;
				case 7:
					return rKiKSkZvn5yNwapDBnmM(element);
				default:
					return Guid.Empty;
				case 10:
					if (gpPrbCZvDV1JyEumeRIH(element))
					{
						obj = NE4J6lZvHMj5os0hYJZv(context, element.TypeVar);
						num2 = 9;
					}
					else
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool PEftxIZvdpO6YxBq0SOA()
	{
		return XdNY4EZvXdnMCuwKD1a0 == null;
	}

	internal static ICommonEditEntityWorkflowElementExtensions uwqSpBZvuij7RvvIreC5()
	{
		return XdNY4EZvXdnMCuwKD1a0;
	}

	internal static bool gpPrbCZvDV1JyEumeRIH(object P_0)
	{
		return ((ICommonEditEntityWorkflowElement)P_0).TypeFromVar;
	}

	internal static Guid rKiKSkZvn5yNwapDBnmM(object P_0)
	{
		return ((ICommonEditEntityWorkflowElement)P_0).Type;
	}

	internal static object NE4J6lZvHMj5os0hYJZv(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static bool bjtUAXZvLwoQtKPgFoyt(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
