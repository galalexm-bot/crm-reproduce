using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class RangeOperation : IOperation
{
	public static readonly Guid UID;

	private static RangeOperation Rc0DNJOpAgBpcyYPIWgv;

	public Guid Uid => UID;

	public string Name => (string)lwYcreOpoZmjQgudRQcW(LBHI3pOp21a09lyHsQ7r(--1436248540 ^ 0x559940C6));

	public string Description => SR.T((string)LBHI3pOp21a09lyHsQ7r(-684210684 ^ -684332132));

	public string OperationString => string.Empty;

	public bool CanShow => true;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
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
		//Discarded unreachable code: IL_003b, IL_0064, IL_00d5, IL_00e4
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				Tuple<int, int> compareResultRangeOperation = GetCompareResultRangeOperation(left, right);
				int num = 2;
				while (true)
				{
					int num2;
					switch (num)
					{
					case 1:
						return result;
					default:
						num2 = ((compareResultRangeOperation.Item1 == 0) ? 1 : 0);
						break;
					case 2:
						if (compareResultRangeOperation.Item1 != 1)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
							{
								num = 0;
							}
							continue;
						}
						num2 = 1;
						break;
					}
					bool flag = compareResultRangeOperation.Item2 == -1 || compareResultRangeOperation.Item2 == 0;
					result = (byte)((uint)num2 & (flag ? 1u : 0u)) != 0;
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
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

	public static Tuple<int, int> GetCompareResultRangeOperation(object left, object right)
	{
		try
		{
			IComparable comparable = left as IComparable;
			if (comparable == null)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F516E94), comparable, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62834F0E)));
			}
			object[] array = (right as IEnumerable).CastToArrayOrNull<object>();
			if (array == null || array.Count() != 2)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574483813)));
			}
			object obj = array.ElementAt(0);
			object obj2 = array.ElementAt(1);
			IComparable comparable2 = obj as IComparable;
			IComparable comparable3 = obj2 as IComparable;
			if (comparable2 == null || comparable3 == null)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1002110678), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772734998)));
			}
			int item = comparable.CompareTo(comparable2);
			int item2 = comparable.CompareTo(comparable3);
			return new Tuple<int, int>(item, item2);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public RangeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RangeOperation()
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
				sAkucyOpF4XicwqjqZLC();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)LBHI3pOp21a09lyHsQ7r(-935313063 ^ -935170057));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object LBHI3pOp21a09lyHsQ7r(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lwYcreOpoZmjQgudRQcW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool zrNyW9OpGBfcrRMJjWwx()
	{
		return Rc0DNJOpAgBpcyYPIWgv == null;
	}

	internal static RangeOperation w3CbsIOp7gqqJTB0FyGc()
	{
		return Rc0DNJOpAgBpcyYPIWgv;
	}

	internal static void sAkucyOpF4XicwqjqZLC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
