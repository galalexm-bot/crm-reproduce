using System;
using System.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Models.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models.ConditionTable.Operations;

[Component]
internal class EQLOperation : IOperation
{
	public static readonly Guid UID;

	internal static EQLOperation jWO83OOQLb0cSZ1apigU;

	public virtual Guid Uid => UID;

	public virtual string Name => SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A961E1));

	public virtual string Description => (string)toiuPWOQjXnClegBsOPJ(UauUaeOQWD7NeGWqsFUf(0x17F0C5A2 ^ 0x17F2E2A2));

	public bool CanShow => true;

	public string OperationString => string.Empty;

	public virtual TypeOperationEnum OperationType => TypeOperationEnum.EQL;

	public bool CanExecute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_00c9
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return right is IEntity;
				case 1:
					return true;
				default:
					return false;
				case 4:
					if (!(left is IEnumerable))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 2:
					if (right is IEnumerable)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 5;
				case 3:
					if (!(left is IEntity))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public bool Execute(ITypeDescriptor descriptor, object left, object right)
	{
		//Discarded unreachable code: IL_007d, IL_0145, IL_0154, IL_01d3, IL_024f, IL_025e, IL_0270, IL_027f, IL_028f, IL_029e
		int num = 2;
		IEntity entity = default(IEntity);
		IEntity entity2 = default(IEntity);
		IEntity[] array2 = default(IEntity[]);
		IEntity[] array3 = default(IEntity[]);
		IEntity[] array = default(IEntity[]);
		int num3 = default(int);
		IEntity firstEntity = default(IEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					return Compare(entity, entity2, array2);
				case 22:
					array3 = array;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
					if (entity != null)
					{
						num2 = 10;
						continue;
					}
					goto case 20;
				case 9:
					num3 = 0;
					num2 = 7;
					continue;
				case 20:
					throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647669262), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F570E5)));
				case 10:
				case 16:
					entity2 = right as IEntity;
					num2 = 5;
					continue;
				case 11:
					break;
				case 7:
				case 8:
					if (num3 >= array3.Length)
					{
						num2 = 12;
						continue;
					}
					break;
				case 2:
					entity = left as IEntity;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					array = (left as IEnumerable).CastToArrayOrNull<IEntity>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					array2 = (right as IEnumerable).CastToArrayOrNull<IEntity>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 15;
					}
					continue;
				case 14:
					if (entity2 != null)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 18;
				case 15:
					if (array2 != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 3:
					if (Compare(firstEntity, entity2, array2))
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 19;
				case 12:
					return true;
				case 19:
					return false;
				case 13:
					num3++;
					num2 = 8;
					continue;
				default:
					if (array != null)
					{
						num2 = 16;
						continue;
					}
					goto case 6;
				case 18:
					throw new Exception((string)JixvDYOQRhdfI9atETQ0(UauUaeOQWD7NeGWqsFUf(0x651FE29D ^ 0x651DC50F), new object[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431876914) }));
				case 4:
				case 17:
					if (entity == null)
					{
						num2 = 22;
						continue;
					}
					goto case 21;
				}
				break;
			}
			firstEntity = array3[num3];
			num = 3;
		}
	}

	private bool Compare(IEntity firstEntity, IEntity secondEntity, IEntity[] secondOperandArray)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0, IL_0190, IL_0211, IL_0220, IL_0230, IL_023f, IL_026a, IL_0281, IL_0294, IL_02a3, IL_02b3, IL_02c2, IL_0310, IL_031f, IL_0376
		int num = 13;
		int num2 = num;
		IEntity[] array = default(IEntity[]);
		IComparable comparable3 = default(IComparable);
		IComparable comparable = default(IComparable);
		int num5 = default(int);
		IEntity entity = default(IEntity);
		Type type = default(Type);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				array = secondOperandArray;
				num2 = 3;
				continue;
			case 8:
				if (comparable3 == null)
				{
					num2 = 7;
					continue;
				}
				if (oNDpAYOQqH0xp60CbQvG(comparable, comparable3) != 0)
				{
					num2 = 10;
					continue;
				}
				goto case 2;
			case 7:
				return false;
			case 18:
				comparable3 = RQPVtbOQ6eylZhAMN3o1(secondEntity) as IComparable;
				num2 = 8;
				continue;
			case 17:
				if (comparable != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 14;
			default:
				if (num5 < array.Length)
				{
					num2 = 15;
					continue;
				}
				goto case 10;
			case 5:
			case 15:
				entity = array[num5];
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 19;
				}
				continue;
			case 3:
				num5 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 0;
				}
				continue;
			case 14:
				return false;
			case 1:
				if (secondEntity != null)
				{
					num2 = 18;
					continue;
				}
				type = RQPVtbOQ6eylZhAMN3o1(firstEntity).GetType();
				num2 = 4;
				continue;
			case 19:
				try
				{
					IComparable comparable2 = Convert.ChangeType(RQPVtbOQ6eylZhAMN3o1(entity), type) as IComparable;
					int num3 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							if (comparable2 == null)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 4;
						case 2:
							result = true;
							num3 = 5;
							continue;
						case 4:
							if (comparable.CompareTo(comparable2) == 0)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
								{
									num3 = 2;
								}
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							break;
						case 5:
							return result;
						}
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 13:
				if (firstEntity == null)
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 10:
			case 11:
			case 12:
				return false;
			case 2:
				return true;
			case 6:
				num5++;
				num2 = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num2 = 9;
				}
				continue;
			case 9:
				break;
			}
			comparable = firstEntity.GetId() as IComparable;
			num2 = 17;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
			{
				num2 = 6;
			}
		}
	}

	public EQLOperation()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iJgnplOQ31b4PdlXmBD8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EQLOperation()
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)UauUaeOQWD7NeGWqsFUf(-1895853023 ^ -1895975975));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool dd57WDOQfcMgK6vkmF1x()
	{
		return jWO83OOQLb0cSZ1apigU == null;
	}

	internal static EQLOperation vRjJ9JOQ9swyqIxCDnKu()
	{
		return jWO83OOQLb0cSZ1apigU;
	}

	internal static object UauUaeOQWD7NeGWqsFUf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object toiuPWOQjXnClegBsOPJ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JixvDYOQRhdfI9atETQ0(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object RQPVtbOQ6eylZhAMN3o1(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static int oNDpAYOQqH0xp60CbQvG(object P_0, object P_1)
	{
		return ((IComparable)P_0).CompareTo(P_1);
	}

	internal static void iJgnplOQ31b4PdlXmBD8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
