using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class LessOrEqualsOperation : IOperation
{
	public static readonly Guid UID;

	private static LessOrEqualsOperation QHmPd9OpyrtCJvxZST3C;

	public Guid Uid => UID;

	public string Name => (string)YMaSGsOpbi5vIBRRktoR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF6FA8E));

	public string Description => (string)YMaSGsOpbi5vIBRRktoR(C3Qxy8Op5c171gLfA3XN(0x1C7F6FED ^ 0x1C7D450F));

	public bool CanShow => true;

	public string OperationString => (string)C3Qxy8Op5c171gLfA3XN(0x1145BED7 ^ 0x1147954D);

	public TypeOperationEnum OperationType => TypeOperationEnum.Primitive;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0052, IL_0061
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
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
		//Discarded unreachable code: IL_0072, IL_014b, IL_015a, IL_01bb, IL_01ca
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				IComparable comparable = left as IComparable;
				int num = 2;
				int num2 = default(int);
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					int num3;
					int num4;
					switch (num)
					{
					case 3:
						return result;
					case 1:
						num3 = ((num2 == 0) ? 1 : 0);
						break;
					case 4:
						throw new Exception((string)ygWIBNOpgLnN7LEqwmrC(C3Qxy8Op5c171gLfA3XN(0x350C0E8 ^ 0x352E420), new object[2]
						{
							comparable2,
							C3Qxy8Op5c171gLfA3XN(0x5F534A5C ^ 0x5F5162EC)
						}));
					case 5:
						throw new Exception(SR.T((string)C3Qxy8Op5c171gLfA3XN(--1436248540 ^ 0x55994D14), comparable, C3Qxy8Op5c171gLfA3XN(0x101D10F ^ 0x103F9BF)));
					case 6:
						if (comparable2 != null)
						{
							num2 = lgppTZOpBpO51pLqnpRV(comparable, comparable2);
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
							{
								num = 0;
							}
							continue;
						}
						num4 = 4;
						goto IL_003a;
					case 2:
						comparable2 = right as IComparable;
						num4 = 7;
						goto IL_003a;
					case 7:
						if (comparable != null)
						{
							num = 6;
							continue;
						}
						goto case 5;
					default:
						{
							if (num2 != -1)
							{
								num = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
								{
									num = 1;
								}
								continue;
							}
							num3 = 1;
							break;
						}
						IL_003a:
						num = num4;
						continue;
					}
					result = (byte)num3 != 0;
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num = 3;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public LessOrEqualsOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HCDhyJOpcDFA6IKRUD4n();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static LessOrEqualsOperation()
	{
		int num = 2;
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
				UID = new Guid((string)C3Qxy8Op5c171gLfA3XN(0xB7793C9 ^ 0xB75B86B));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object YMaSGsOpbi5vIBRRktoR(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool TafHCfOpmkJfYarxmluG()
	{
		return QHmPd9OpyrtCJvxZST3C == null;
	}

	internal static LessOrEqualsOperation zWZU5rOptswAygLsfbid()
	{
		return QHmPd9OpyrtCJvxZST3C;
	}

	internal static object C3Qxy8Op5c171gLfA3XN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ygWIBNOpgLnN7LEqwmrC(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static int lgppTZOpBpO51pLqnpRV(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}

	internal static void HCDhyJOpcDFA6IKRUD4n()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
