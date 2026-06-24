using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class EqualsOperation : IOperation
{
	public static readonly Guid UID;

	internal static EqualsOperation NniXm2OQTn75aiR4eCCt;

	public Guid Uid => UID;

	public string Name => (string)K9PsbiOQMiQbgZoXcUiA(n36SmZOQCMTLPSbyaXia(-420003255 ^ -420124159));

	public string Description => (string)K9PsbiOQMiQbgZoXcUiA(n36SmZOQCMTLPSbyaXia(-197778752 ^ -197916010));

	public bool CanShow => true;

	public string OperationString => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17834589);

	public TypeOperationEnum OperationType => TypeOperationEnum.Primitive;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_002d, IL_003c
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
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
		//Discarded unreachable code: IL_003a, IL_0065, IL_0074, IL_017b, IL_018a
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				IComparable comparable = left as IComparable;
				int num = 5;
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					case 5:
						comparable2 = right as IComparable;
						num = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
						{
							num = 3;
						}
						break;
					case 3:
						throw new Exception((string)QyqaKfOQkKaIy90lyidR(n36SmZOQCMTLPSbyaXia(-763667953 ^ -763789625), new object[2]
						{
							comparable2,
							n36SmZOQCMTLPSbyaXia(0x5DB28AD2 ^ 0x5DB0A262)
						}));
					default:
						throw new Exception((string)QyqaKfOQkKaIy90lyidR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1136F608), new object[2]
						{
							comparable,
							n36SmZOQCMTLPSbyaXia(-2122743969 ^ -2122622993)
						}));
					case 2:
						if (comparable2 != null)
						{
							result = FDA5ojOQUIW9XyRNQi83(comparable, comparable2) == 0;
							num = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
							{
								num = 1;
							}
						}
						else
						{
							num = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
							{
								num = 3;
							}
						}
						break;
					case 4:
						if (comparable != null)
						{
							num = 2;
							break;
						}
						goto default;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public EqualsOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EqualsOperation()
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
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)n36SmZOQCMTLPSbyaXia(-63028171 ^ -63148801));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object n36SmZOQCMTLPSbyaXia(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object K9PsbiOQMiQbgZoXcUiA(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool GDFeLUOQQ16Cv93HVrIu()
	{
		return NniXm2OQTn75aiR4eCCt == null;
	}

	internal static EqualsOperation EHb2cLOQpf8GQqFaSlqI()
	{
		return NniXm2OQTn75aiR4eCCt;
	}

	internal static object QyqaKfOQkKaIy90lyidR(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static int FDA5ojOQUIW9XyRNQi83(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}
}
