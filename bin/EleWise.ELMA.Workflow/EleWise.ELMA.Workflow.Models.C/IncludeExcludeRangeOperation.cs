using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class IncludeExcludeRangeOperation : IOperation
{
	public static readonly Guid UID;

	internal static IncludeExcludeRangeOperation CwX0RfOQNG6TZoOhvQJU;

	public Guid Uid => UID;

	public string Name => SR.T((string)mFZUyrOQ1JPeLAu6nkuE(-1716458555 ^ -1716337953));

	public string Description => (string)OwHeaeOQhbxg0yIWV3m3(mFZUyrOQ1JPeLAu6nkuE(0x361628FF ^ 0x361401D1));

	public string OperationString => (string)mFZUyrOQ1JPeLAu6nkuE(-1895853023 ^ -1895973373);

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
			default:
				return right is IComparable;
			case 1:
				if (!(left is IComparable))
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0048, IL_0071, IL_00bf, IL_00ce
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				Tuple<int, int> compareResultRangeOperation = RangeOperation.GetCompareResultRangeOperation(left, right);
				int num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num = 1;
				}
				while (true)
				{
					int num2;
					bool flag;
					switch (num)
					{
					case 2:
						num2 = ((compareResultRangeOperation.Item1 == 0) ? 1 : 0);
						goto IL_008e;
					case 1:
						if (compareResultRangeOperation.Item1 != 1)
						{
							num = 2;
							break;
						}
						num2 = 1;
						goto IL_008e;
					default:
						return result;
					case 0:
						{
							return result;
						}
						IL_008e:
						flag = compareResultRangeOperation.Item2 == -1;
						result = (byte)((uint)num2 & (flag ? 1u : 0u)) != 0;
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num = 0;
						}
						break;
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

	public IncludeExcludeRangeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Hvfn4FOQEA4euqbiw4bd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static IncludeExcludeRangeOperation()
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
				Hvfn4FOQEA4euqbiw4bd();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)mFZUyrOQ1JPeLAu6nkuE(-22348816 ^ -22490662));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object mFZUyrOQ1JPeLAu6nkuE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool YBulcGOQx9WVSgoMPG8l()
	{
		return CwX0RfOQNG6TZoOhvQJU == null;
	}

	internal static IncludeExcludeRangeOperation MgQKIOOQSt5UCRSaahBy()
	{
		return CwX0RfOQNG6TZoOhvQJU;
	}

	internal static object OwHeaeOQhbxg0yIWV3m3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Hvfn4FOQEA4euqbiw4bd()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
