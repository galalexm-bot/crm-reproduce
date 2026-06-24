using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class ExcludeExcludeRangeOperation : IOperation
{
	public static readonly Guid UID;

	internal static ExcludeExcludeRangeOperation yrpVJJOQVlDX4w4UC8Jx;

	public Guid Uid => UID;

	public string Name => (string)AJBHx6OQ2eTeStsESxrE(nMYuE3OQ7BCa6pLJPBQk(0x3C1FFB55 ^ 0x3C1DD24F));

	public string Description => (string)AJBHx6OQ2eTeStsESxrE(nMYuE3OQ7BCa6pLJPBQk(0x1843E01F ^ 0x1841C931));

	public string OperationString => (string)nMYuE3OQ7BCa6pLJPBQk(0x17F0C5A2 ^ 0x17F2ECD0);

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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_005b, IL_0098, IL_00a7
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				Tuple<int, int> compareResultRangeOperation = RangeOperation.GetCompareResultRangeOperation(left, right);
				bool flag = compareResultRangeOperation.Item1 == 1;
				bool flag2 = compareResultRangeOperation.Item2 == -1;
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
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
					result = flag && flag2;
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
					{
						num = 0;
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

	public ExcludeExcludeRangeOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		w16l7lOQoDEnUV66rQ1m();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExcludeExcludeRangeOperation()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid((string)nMYuE3OQ7BCa6pLJPBQk(-261315199 ^ -261190405));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				w16l7lOQoDEnUV66rQ1m();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object nMYuE3OQ7BCa6pLJPBQk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AJBHx6OQ2eTeStsESxrE(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool zFoss2OQAgUc4b9iRwOR()
	{
		return yrpVJJOQVlDX4w4UC8Jx == null;
	}

	internal static ExcludeExcludeRangeOperation RGXDejOQGxVwgFG64Gt8()
	{
		return yrpVJJOQVlDX4w4UC8Jx;
	}

	internal static void w16l7lOQoDEnUV66rQ1m()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
