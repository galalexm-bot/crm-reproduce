using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class NotEqualsOperation : IOperation
{
	public static readonly Guid UID;

	internal static NotEqualsOperation gxnBsdOpTu3QFMKUUQev;

	public Guid Uid => UID;

	public string Name => (string)QxHUY5OpCG5Fqn8aOZm2(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30103530));

	public string Description => (string)QxHUY5OpCG5Fqn8aOZm2(RZU1X8OpMIXacjPxaOfE(-495296780 ^ -495422954));

	public bool CanShow => true;

	public string OperationString => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1394021518);

	public TypeOperationEnum OperationType => TypeOperationEnum.Primitive;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(left is IComparable))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return right is IComparable;
			default:
				return false;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0047, IL_00a9, IL_00b8, IL_00c8, IL_0195, IL_01a4
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				IComparable comparable = left as IComparable;
				int num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
				{
					num = 5;
				}
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					switch (num)
					{
					case 1:
						if (comparable != null)
						{
							num = 3;
							break;
						}
						goto default;
					case 5:
						comparable2 = right as IComparable;
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num = 1;
						}
						break;
					case 4:
						throw new Exception((string)Qt70XSOpkIf6K2Ab39lX(RZU1X8OpMIXacjPxaOfE(-1303601216 ^ -1303463160), new object[2]
						{
							comparable2,
							RZU1X8OpMIXacjPxaOfE(0x651FE29D ^ 0x651DCA2D)
						}));
					case 2:
						result = HAvRPTOpUPgoSMcq8Gpo(comparable, comparable2) != 0;
						num = 6;
						break;
					default:
						throw new Exception((string)Qt70XSOpkIf6K2Ab39lX(RZU1X8OpMIXacjPxaOfE(-25709590 ^ -25848030), new object[2]
						{
							comparable,
							RZU1X8OpMIXacjPxaOfE(0x2ACCDD87 ^ 0x2ACEF537)
						}));
					case 3:
						if (comparable2 != null)
						{
							num = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
							{
								num = 2;
							}
							break;
						}
						goto case 4;
					case 6:
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		default:
			return result;
		}
	}

	public NotEqualsOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zwCH2qOpVZcZPSSTw6yL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NotEqualsOperation()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)RZU1X8OpMIXacjPxaOfE(-763667953 ^ -763791545));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object QxHUY5OpCG5Fqn8aOZm2(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool LdBfJoOpQAAdj151PvkY()
	{
		return gxnBsdOpTu3QFMKUUQev == null;
	}

	internal static NotEqualsOperation JP4rehOppwcLnjNaG8RY()
	{
		return gxnBsdOpTu3QFMKUUQev;
	}

	internal static object RZU1X8OpMIXacjPxaOfE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Qt70XSOpkIf6K2Ab39lX(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static int HAvRPTOpUPgoSMcq8Gpo(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}

	internal static void zwCH2qOpVZcZPSSTw6yL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
