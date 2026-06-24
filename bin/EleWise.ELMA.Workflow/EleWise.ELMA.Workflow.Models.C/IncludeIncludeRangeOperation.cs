using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class IncludeIncludeRangeOperation : IOperation
{
	public static readonly Guid UID;

	internal static IncludeIncludeRangeOperation EVVutpOQw6xVCrWRKP8K;

	public Guid Uid => UID;

	public string Name => (string)sAmjAaOpKfrp0k6q9t2t(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1841C905));

	public string Description => (string)sAmjAaOpKfrp0k6q9t2t(MOQQXjOpOvRh7uMx1Xik(0x141C968 ^ 0x143E046));

	public string OperationString => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA711394);

	public bool CanShow => false;

	public TypeOperationEnum OperationType => TypeOperationEnum.Range;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return right is IComparable;
			case 1:
				return false;
			case 2:
				if (!(left is IComparable))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_004b, IL_008b, IL_00d5, IL_00e4
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num = 0;
				}
				while (true)
				{
					int num2;
					switch (num)
					{
					case 1:
						return result;
					default:
						if (compareResultRangeOperation.Item1 != 1)
						{
							num = 2;
							continue;
						}
						num2 = 1;
						break;
					case 2:
						num2 = ((compareResultRangeOperation.Item1 == 0) ? 1 : 0);
						break;
					}
					bool flag = compareResultRangeOperation.Item2 == -1 || compareResultRangeOperation.Item2 == 0;
					result = (byte)((uint)num2 & (flag ? 1u : 0u)) != 0;
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
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

	public IncludeIncludeRangeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aXeOTWOpZxlVCN0DDuov();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IncludeIncludeRangeOperation()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801672027));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object sAmjAaOpKfrp0k6q9t2t(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool b7Vdr3OQ4qAaohaw1blZ()
	{
		return EVVutpOQw6xVCrWRKP8K == null;
	}

	internal static IncludeIncludeRangeOperation guFmdvOQzXF5o17Uw95r()
	{
		return EVVutpOQw6xVCrWRKP8K;
	}

	internal static object MOQQXjOpOvRh7uMx1Xik(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void aXeOTWOpZxlVCN0DDuov()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
