using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal sealed class GlobalVariableOperation : IOperation
{
	public static readonly Guid UID;

	private static GlobalVariableOperation Gq02jAOQ0Zene0LPl5ZP;

	public Guid Uid => UID;

	public string Name => SR.T((string)KqIhXrOQtbvy9FtjyIK8(-135674354 ^ -135535748));

	public string Description => (string)uCJHWmOQbHRfow04lxD2(KqIhXrOQtbvy9FtjyIK8(-865213812 ^ -865089748));

	public string OperationString => "";

	public bool CanShow => true;

	public TypeOperationEnum OperationType => TypeOperationEnum.GlobalVariable;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(left is IEntity))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return right is IEntity;
			case 1:
				return false;
			}
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0075, IL_0191, IL_01a0
		bool result = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				IEntity entity = left as IEntity;
				int num = 5;
				IEntity entity2 = default(IEntity);
				while (true)
				{
					int num3;
					switch (num)
					{
					case 3:
						num3 = (QuZD5BOQcXfc2g7qRM9Y(entity).Equals(entity2.GetId()) ? 1 : 0);
						goto IL_016f;
					case 2:
						if (entity == null)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
							{
								num = 0;
							}
							break;
						}
						if (entity2 == null)
						{
							num = 4;
							break;
						}
						if (ncvrFROQBHk18TsTjm5Y(fPEpbPOQgKHcDl8qktO7(left).GetType(), fPEpbPOQgKHcDl8qktO7(right).GetType()))
						{
							num = 3;
							break;
						}
						num3 = 0;
						goto IL_016f;
					default:
						throw new ArgumentException((string)QPxdvXOQ5fCttqFj3jWt(KqIhXrOQtbvy9FtjyIK8(-22348816 ^ -22487240), new object[2]
						{
							left,
							KqIhXrOQtbvy9FtjyIK8(0x246EEF98 ^ 0x246CCA88)
						}));
					case 4:
						throw new ArgumentException((string)QPxdvXOQ5fCttqFj3jWt(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360538255), new object[2]
						{
							right,
							KqIhXrOQtbvy9FtjyIK8(0xA7339EE ^ 0xA711CFE)
						}));
					case 5:
					{
						entity2 = right as IEntity;
						int num2 = 2;
						num = num2;
						break;
					}
					case 1:
						{
							return result;
						}
						IL_016f:
						result = (byte)num3 != 0;
						num = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
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

	public GlobalVariableOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static GlobalVariableOperation()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				xIYDp2OQP3Tisb4dnKHK();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)KqIhXrOQtbvy9FtjyIK8(0x1C7F6FED ^ 0x1C7D49DB));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object KqIhXrOQtbvy9FtjyIK8(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jNff4COQygeiIvyU7QrH()
	{
		return Gq02jAOQ0Zene0LPl5ZP == null;
	}

	internal static GlobalVariableOperation A9eKUIOQmUJWl1Uw8YYe()
	{
		return Gq02jAOQ0Zene0LPl5ZP;
	}

	internal static object uCJHWmOQbHRfow04lxD2(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object QPxdvXOQ5fCttqFj3jWt(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object fPEpbPOQgKHcDl8qktO7(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static bool ncvrFROQBHk18TsTjm5Y(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object QuZD5BOQcXfc2g7qRM9Y(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void xIYDp2OQP3Tisb4dnKHK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
