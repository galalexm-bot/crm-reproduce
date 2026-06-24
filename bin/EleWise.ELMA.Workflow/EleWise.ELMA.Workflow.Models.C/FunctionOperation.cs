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
internal sealed class FunctionOperation : IOperation
{
	public static readonly Guid UID;

	internal static FunctionOperation dG4DntOQKeRwkebAls9t;

	public Guid Uid => UID;

	public string Name => (string)MbFyxjOQvqvPQh1qHN8g(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498687657));

	public string Description => (string)MbFyxjOQvqvPQh1qHN8g(zd4vGmOQYZQd1pRMvhCu(-935313063 ^ -935172613));

	public string OperationString => "";

	public bool CanShow => true;

	public TypeOperationEnum OperationType => TypeOperationEnum.Function;

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
				return right is IEntity;
			default:
				return false;
			case 1:
				if (!(left is IEntity))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
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
		//Discarded unreachable code: IL_004a, IL_00a3, IL_00b2, IL_012d, IL_0153, IL_015d, IL_01f8, IL_0207
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				IEntity entity = left as IEntity;
				int num = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num = 2;
				}
				IEntity entity2 = default(IEntity);
				while (true)
				{
					int num2;
					switch (num)
					{
					case 5:
						return result;
					case 6:
						entity2 = right as IEntity;
						num = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
						{
							num = 4;
						}
						continue;
					case 4:
						if (entity != null)
						{
							num = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
							{
								num = 0;
							}
							continue;
						}
						goto case 3;
					case 3:
						throw new ArgumentException((string)WlqhD6OQ8qCcFOS4pGTT(zd4vGmOQYZQd1pRMvhCu(0x361628FF ^ 0x36140C37), new object[2]
						{
							left,
							zd4vGmOQYZQd1pRMvhCu(--1418337216 ^ 0x54883ED0)
						}));
					default:
						if (entity2 != null)
						{
							num = 2;
							continue;
						}
						goto case 1;
					case 8:
						num2 = (gXpmauOQlZGARJPFrilr(entity).Equals(entity2.GetId()) ? 1 : 0);
						break;
					case 1:
						throw new ArgumentException((string)WlqhD6OQ8qCcFOS4pGTT(zd4vGmOQYZQd1pRMvhCu(-708128192 ^ -708249976), new object[2]
						{
							right,
							zd4vGmOQYZQd1pRMvhCu(0x2269BD32 ^ 0x226B9822)
						}));
					case 2:
						if (!KvKN57OQJRvLGVqYByfB(EGgHWaOQsj1ArNQZ91cL(left).GetType(), right.CastAsRealType().GetType()))
						{
							num = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
							{
								num = 1;
							}
							continue;
						}
						goto case 8;
					case 7:
						num2 = 0;
						break;
					}
					result = (byte)num2 != 0;
					num = 5;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}

	public FunctionOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FunctionOperation()
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x226B9810));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object MbFyxjOQvqvPQh1qHN8g(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool fCsll1OQO3ILNgn3sjU1()
	{
		return dG4DntOQKeRwkebAls9t == null;
	}

	internal static FunctionOperation U55p7LOQZtppOeS4diS6()
	{
		return dG4DntOQKeRwkebAls9t;
	}

	internal static object zd4vGmOQYZQd1pRMvhCu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WlqhD6OQ8qCcFOS4pGTT(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object EGgHWaOQsj1ArNQZ91cL(object P_0)
	{
		return P_0.CastAsRealType();
	}

	internal static bool KvKN57OQJRvLGVqYByfB(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object gXpmauOQlZGARJPFrilr(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}
}
