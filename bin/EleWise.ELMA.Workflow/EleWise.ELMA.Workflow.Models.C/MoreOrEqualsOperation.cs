using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class MoreOrEqualsOperation : IOperation
{
	public static readonly Guid UID;

	internal static MoreOrEqualsOperation fFIOtQOpfocpW1VVn7iI;

	public Guid Uid => UID;

	public string Name => (string)kteuI1OpjekXyo4a2yMt(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772736248));

	public string Description => SR.T((string)kB5sHeOpRjjjNjb2AGMi(0x651FE29D ^ 0x651DC87F));

	public bool CanShow => true;

	public string OperationString => (string)kB5sHeOpRjjjNjb2AGMi(-432000546 ^ -431874648);

	public TypeOperationEnum OperationType => TypeOperationEnum.Primitive;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return right is IComparable;
			default:
				return false;
			case 1:
				if (!(left is IComparable))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_004a, IL_0081, IL_0090, IL_0138, IL_0196, IL_01d0, IL_01df
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				IComparable comparable = left as IComparable;
				int num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num = 1;
				}
				int num2 = default(int);
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					int num3;
					switch (num)
					{
					case 7:
						return result;
					case 3:
						if (comparable != null)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 8;
					case 6:
						if (num2 != 1)
						{
							num = 5;
							continue;
						}
						num3 = 1;
						break;
					case 4:
						throw new Exception((string)qlN8w7Op6y2MoPhAy0GD(kB5sHeOpRjjjNjb2AGMi(0x7AC609FE ^ 0x7AC42D36), new object[2]
						{
							comparable2,
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935171607)
						}));
					case 2:
						num2 = WVB6B1OpqEv86PdkIfJE(comparable, comparable2);
						num = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num = 0;
						}
						continue;
					case 8:
						throw new Exception((string)qlN8w7Op6y2MoPhAy0GD(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790361780), new object[2]
						{
							comparable,
							kB5sHeOpRjjjNjb2AGMi(-2057730233 ^ -2057588745)
						}));
					default:
						if (comparable2 != null)
						{
							num = 2;
							continue;
						}
						goto case 4;
					case 5:
						num3 = ((num2 == 0) ? 1 : 0);
						break;
					case 1:
						comparable2 = right as IComparable;
						num = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
						{
							num = 2;
						}
						continue;
					}
					result = (byte)num3 != 0;
					num = 7;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public MoreOrEqualsOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MoreOrEqualsOperation()
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
			case 2:
				GOmMEJOp3ncKX7gvV4qc();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495422838));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object kteuI1OpjekXyo4a2yMt(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool eKNnHKOp9dHM2jxiXFWo()
	{
		return fFIOtQOpfocpW1VVn7iI == null;
	}

	internal static MoreOrEqualsOperation UDtTTKOpWkeOPmoqSNqs()
	{
		return fFIOtQOpfocpW1VVn7iI;
	}

	internal static object kB5sHeOpRjjjNjb2AGMi(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qlN8w7Op6y2MoPhAy0GD(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static int WVB6B1OpqEv86PdkIfJE(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}

	internal static void GOmMEJOp3ncKX7gvV4qc()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
