#define TRACE
using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Artifacts;

public class ArtifactTaskShape : NCompositeShape, IDecoratableShape
{
	private static ArtifactTaskShape OPSqUbOhjDQgsx2A2tmJ;

	public virtual void UpdateDecorators(Element element)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				xCZVILOh3EDvJUZGi5qM(Vvu9PUOhqM2yV56Q20VP(this));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool CreateShapeElements(ShapeElementsMask shapeElements)
	{
		//Discarded unreachable code: IL_00cf, IL_0193, IL_01a2, IL_028c
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num5 = default(int);
		NDiagramElementCompositeImpl val = default(NDiagramElementCompositeImpl);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					((NShape)this).UpdateElementReferences();
					num2 = 5;
					continue;
				case 5:
					if ((int)shapeElements != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return true;
				case 2:
					fGjbKTOhGAD6LGQm9mym(this);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						int num3;
						if ((shapeElements & 8) == 0)
						{
							num3 = 2;
							goto IL_009c;
						}
						goto IL_016f;
						IL_009c:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto end_IL_009c;
							case 3:
								num5 = ((ArrayList)(object)val).Count - 1;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
								{
									num3 = 0;
								}
								continue;
							default:
								((NNodeCompositeImpl)val).InsertChild(num5, (INNode)(object)new PaintableDecoratorCollection());
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
								{
									num3 = 3;
								}
								continue;
							case 7:
							{
								object obj = u16XuAOhCEhr4yDta3TO(Ee6753OhQrWIGimDlBnh(this).GetField((string)LfsSsZOhpkJDVkxlSdTn(-1647793954 ^ -1647650662), BindingFlags.Instance | BindingFlags.NonPublic), this);
								val = (NDiagramElementCompositeImpl)((obj is NDiagramElementCompositeImpl) ? obj : null);
								int num4 = 5;
								num3 = num4;
								continue;
							}
							case 5:
								if (val != null)
								{
									num3 = 3;
									continue;
								}
								goto end_IL_009c;
							case 4:
								break;
							case 2:
								goto end_IL_009c;
							case 8:
								if (((NShape)this).get_Decorators() != null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 7;
							case 6:
								goto end_IL_009c;
							}
							goto IL_016f;
							continue;
							end_IL_009c:
							break;
						}
						goto end_IL_0086;
						IL_016f:
						shapeElements = (ShapeElementsMask)(shapeElements ^ 8);
						num3 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num3 = 0;
						}
						goto IL_009c;
						end_IL_0086:;
					}
					catch (Exception ex)
					{
						int num6 = 4;
						while (true)
						{
							switch (num6)
							{
							case 4:
							{
								PfEqrIOhU2dCSJwVygqU(TmSsN4OhkpRYVXwBch0B(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11959096), APoVBvOhMWAh3aooLTJl(ex)));
								int num7 = 2;
								num6 = num7;
								break;
							}
							case 2:
								Go1j7jOhVgAWHA88v5Bw(this);
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
								{
									num6 = 0;
								}
								break;
							default:
								jlmKqwOhA29HNKrpmeEB(this);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
								{
									num6 = 1;
								}
								break;
							case 1:
								result = false;
								num6 = 3;
								break;
							case 3:
								return result;
							}
						}
					}
					goto case 2;
				case 1:
					return hjgjcLOh7vVFvMTDe581(this, shapeElements);
				case 4:
					break;
				}
				break;
			}
			PcIU8FOhTiubeuwtVDSO(this, NDR.TransactionCreateShapeElements);
			num = 3;
		}
	}

	public ArtifactTaskShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		e3t36BOh2MrRmS2VbfwJ();
		((NCompositeShape)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Vvu9PUOhqM2yV56Q20VP(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static void xCZVILOh3EDvJUZGi5qM(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static bool g7i61cOhRCwrkjgai2sX()
	{
		return OPSqUbOhjDQgsx2A2tmJ == null;
	}

	internal static ArtifactTaskShape sOohOPOh67N7A7pefQrF()
	{
		return OPSqUbOhjDQgsx2A2tmJ;
	}

	internal static void PcIU8FOhTiubeuwtVDSO(object P_0, object P_1)
	{
		((NDiagramElement)P_0).StartTransaction((string)P_1);
	}

	internal static Type Ee6753OhQrWIGimDlBnh(object P_0)
	{
		return P_0.GetType();
	}

	internal static object LfsSsZOhpkJDVkxlSdTn(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object u16XuAOhCEhr4yDta3TO(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object APoVBvOhMWAh3aooLTJl(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object TmSsN4OhkpRYVXwBch0B(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void PfEqrIOhU2dCSJwVygqU(object P_0)
	{
		Trace.WriteLine((string)P_0);
	}

	internal static void Go1j7jOhVgAWHA88v5Bw(object P_0)
	{
		((NDiagramElement)P_0).Rollback();
	}

	internal static void jlmKqwOhA29HNKrpmeEB(object P_0)
	{
		((NShape)P_0).UpdateElementReferences();
	}

	internal static bool fGjbKTOhGAD6LGQm9mym(object P_0)
	{
		return ((NDiagramElement)P_0).Commit();
	}

	internal static bool hjgjcLOh7vVFvMTDe581(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static void e3t36BOh2MrRmS2VbfwJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
