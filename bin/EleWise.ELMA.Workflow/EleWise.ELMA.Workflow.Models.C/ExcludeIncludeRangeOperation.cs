using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class ExcludeIncludeRangeOperation : IOperation
{
	public static readonly Guid UID;

	private static ExcludeIncludeRangeOperation g0elefOQFn1he77TxmID;

	public Guid Uid => UID;

	public string Name => (string)nQvmmqOQrmU8mU9jkI9L(BRn45rOQacoBBLNVMEjj(0x65B7F624 ^ 0x65B5DF3E));

	public string Description => (string)nQvmmqOQrmU8mU9jkI9L(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651DCBB3));

	public string OperationString => (string)BRn45rOQacoBBLNVMEjj(0x157D5AF4 ^ 0x157F733E);

	public bool CanShow => false;

	public TypeOperationEnum OperationType => TypeOperationEnum.Range;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (left is IComparable)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return right is IComparable;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_004b, IL_00af, IL_00be
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				Tuple<int, int> compareResultRangeOperation = RangeOperation.GetCompareResultRangeOperation(left, right);
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					}
					bool num2 = compareResultRangeOperation.Item1 == 1;
					bool flag = compareResultRangeOperation.Item2 == -1 || compareResultRangeOperation.Item2 == 0;
					result = num2 && flag;
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num = 1;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public ExcludeIncludeRangeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gpH158OQe4DwWTaD67MT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExcludeIncludeRangeOperation()
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
				gpH158OQe4DwWTaD67MT();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)BRn45rOQacoBBLNVMEjj(0x5F800F5B ^ 0x5F822689));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object BRn45rOQacoBBLNVMEjj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nQvmmqOQrmU8mU9jkI9L(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool NNkcOGOQisRCFZ7abexY()
	{
		return g0elefOQFn1he77TxmID == null;
	}

	internal static ExcludeIncludeRangeOperation LxFLTAOQI1tkph5FT4Cl()
	{
		return g0elefOQFn1he77TxmID;
	}

	internal static void gpH158OQe4DwWTaD67MT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
