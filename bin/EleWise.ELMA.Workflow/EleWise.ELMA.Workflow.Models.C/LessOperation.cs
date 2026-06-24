using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class LessOperation : IOperation
{
	public static readonly Guid UID;

	internal static LessOperation dvYWv4OpvBSeUnr6pvaQ;

	public Guid Uid => UID;

	public string Name => (string)zZgVk3OpJAxETBb0oVgT(hwxWZ8Opsmu6mgGiIXRp(0x42311138 ^ 0x42333BEA));

	public string Description => (string)zZgVk3OpJAxETBb0oVgT(hwxWZ8Opsmu6mgGiIXRp(--1212129906 ^ 0x483D8890));

	public bool CanShow => true;

	public string OperationString => (string)hwxWZ8Opsmu6mgGiIXRp(-106528299 ^ -106434061);

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
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
		//Discarded unreachable code: IL_004a, IL_00f8, IL_0107, IL_016f, IL_017e
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num = 1;
				}
				IComparable comparable2 = default(IComparable);
				while (true)
				{
					switch (num)
					{
					case 3:
						return result;
					case 1:
						comparable2 = right as IComparable;
						num = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
						{
							num = 0;
						}
						break;
					case 4:
						throw new Exception((string)skdu0XOplMli6N4WU73I(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F516E94), new object[2]
						{
							comparable,
							hwxWZ8Opsmu6mgGiIXRp(-17847711 ^ -17988911)
						}));
					case 2:
						if (comparable2 == null)
						{
							num = 5;
							break;
						}
						result = comparable.CompareTo(comparable2) == -1;
						num = 3;
						break;
					default:
						if (comparable != null)
						{
							num = 2;
							break;
						}
						goto case 4;
					case 5:
						throw new Exception(SR.T((string)hwxWZ8Opsmu6mgGiIXRp(0x438A0E43 ^ 0x43882A8B), comparable2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49425E8B)));
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public LessOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		R5PMNtOp0Tgqfs9dBe89();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static LessOperation()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)hwxWZ8Opsmu6mgGiIXRp(0x2F44D93A ^ 0x2F46F21C));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object hwxWZ8Opsmu6mgGiIXRp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zZgVk3OpJAxETBb0oVgT(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool P3c1v1OpYutWVNuI5y9w()
	{
		return dvYWv4OpvBSeUnr6pvaQ == null;
	}

	internal static LessOperation ca6K3UOp8Yni007i0LKJ()
	{
		return dvYWv4OpvBSeUnr6pvaQ;
	}

	internal static object skdu0XOplMli6N4WU73I(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void R5PMNtOp0Tgqfs9dBe89()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
