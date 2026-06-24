using System;
using System.Drawing;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Shapes;

public static class ShapeHelper
{
	public static readonly Color DefaultStrokeColor;

	private static ShapeHelper WGhNDh1tRsrwBWhXas8;

	public static NStrokeStyle DefaultStrokeStyle => new NStrokeStyle(0.75f, DefaultStrokeColor);

	public static NStrokeStyle DefaultThinStrokeStyle => new NStrokeStyle(0.5f, DefaultStrokeColor);

	public static NStrokeStyle DefaultThickStrokeStyle => new NStrokeStyle(1f, DefaultStrokeColor);

	public static void AddPorts(NShape shape, bool addIntermediate)
	{
		//Discarded unreachable code: IL_0061
		int num = 12;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					return;
				case 2:
					KkTgM01PxFVIwZgUAgI(shape, 50f, -25f, y1TU2c1gbpdoqZ1AppJ(0x738ABA6E ^ 0x738BE040));
					num2 = 6;
					break;
				case 8:
					if (!addIntermediate)
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 13:
					AddPort(shape, -50f, -25f, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17895377));
					num2 = 14;
					break;
				case 1:
					Cw6rkX1cZqVYSiKahs9(shape, ContentAlignment.MiddleRight, y1TU2c1gbpdoqZ1AppJ(-1050383744 ^ -1050333044));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					KkTgM01PxFVIwZgUAgI(shape, 25f, 50f, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638141820));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 3;
					}
					break;
				case 12:
					MGZFiN1B10RABv71KeS(shape, y1TU2c1gbpdoqZ1AppJ(0x70EBB9F3 ^ 0x70EAE3F3));
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 1;
					}
					break;
				case 14:
					KkTgM01PxFVIwZgUAgI(shape, -50f, 25f, y1TU2c1gbpdoqZ1AppJ(-106528299 ^ -106439805));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					KkTgM01PxFVIwZgUAgI(shape, -25f, -50f, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542106364));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					KkTgM01PxFVIwZgUAgI(shape, 50f, 25f, y1TU2c1gbpdoqZ1AppJ(0x65B7F624 ^ 0x65B6AC12));
					num2 = 9;
					break;
				default:
					Cw6rkX1cZqVYSiKahs9(shape, ContentAlignment.BottomCenter, y1TU2c1gbpdoqZ1AppJ(-197778752 ^ -197691182));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 15;
					}
					break;
				case 5:
					KkTgM01PxFVIwZgUAgI(shape, 25f, -50f, y1TU2c1gbpdoqZ1AppJ(0xF400DF8 ^ 0xF4157DE));
					num2 = 2;
					break;
				case 15:
					AddPort(shape, ContentAlignment.MiddleLeft, (string)y1TU2c1gbpdoqZ1AppJ(-11799394 ^ -11882874));
					num2 = 8;
					break;
				case 4:
					return;
				case 11:
					Cw6rkX1cZqVYSiKahs9(shape, ContentAlignment.TopCenter, y1TU2c1gbpdoqZ1AppJ(-135674354 ^ -135750648));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					KkTgM01PxFVIwZgUAgI(shape, -25f, 50f, y1TU2c1gbpdoqZ1AppJ(0xD305CC2 ^ 0xD3106FC));
					num2 = 7;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public static void AddPort(NShape shape, ContentAlignment align, string name)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				E0Dfl91X2e8kj55HeI1(shape, new NContentAlignment(align), name);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void AddPort(NShape shape, float percX, float percY, string name)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				E0Dfl91X2e8kj55HeI1(shape, new NContentAlignment(percX, percY), name);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void AddPort(NShape shape, NContentAlignment align, string name)
	{
		//Discarded unreachable code: IL_00aa
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0096: Expected O, but got Unknown
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					throw new ArgumentNullException((string)y1TU2c1gbpdoqZ1AppJ(--1212129906 ^ 0x483EF82C));
				case 1:
					if (vT9khI1dG5p91GKlSnk(shape) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					goto end_IL_0012;
				case 7:
					return;
				case 2:
					if (shape != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				default:
					shape.CreateShapeElements((ShapeElementsMask)2);
					num2 = 6;
					continue;
				case 4:
					XJysEc1uP7e62icfvLY(vT9khI1dG5p91GKlSnk(shape), true);
					num2 = 7;
					continue;
				case 6:
					break;
				}
				XJysEc1uP7e62icfvLY(shape.get_Ports(), false);
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			object obj = vT9khI1dG5p91GKlSnk(shape);
			NRotatedBoundsPort val = new NRotatedBoundsPort(J8aMC71DKxVaoV4EA5W(shape), align);
			nBLMJM1njfJP75C5pLu((object)val, name);
			gPpSWN1HhVUjhRurIJv(obj, (object)val);
			num = 4;
		}
	}

	public static void AddCenterPort(NShape shape, string name)
	{
		//Discarded unreachable code: IL_00f3, IL_0102
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0167: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		NDynamicPort val2 = default(NDynamicPort);
		while (true)
		{
			switch (num2)
			{
			case 2:
				f2U3IZ1LOurkVG5OeLt(shape, (ShapeElementsMask)2);
				num2 = 5;
				break;
			case 3:
				gPpSWN1HhVUjhRurIJv(vT9khI1dG5p91GKlSnk(shape), val2);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num2 = 9;
				}
				break;
			case 5:
				XJysEc1uP7e62icfvLY(vT9khI1dG5p91GKlSnk(shape), false);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				if (shape != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			default:
				throw new ArgumentNullException((string)y1TU2c1gbpdoqZ1AppJ(0xA7339EE ^ 0xA7263B0));
			case 6:
				if (vT9khI1dG5p91GKlSnk(shape) == null)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 1:
				return;
			case 9:
				XJysEc1uP7e62icfvLY(vT9khI1dG5p91GKlSnk(shape), true);
				num2 = 8;
				break;
			case 8:
				((NPortCollection)vT9khI1dG5p91GKlSnk(shape)).set_DefaultInwardPortUniqueId(J8aMC71DKxVaoV4EA5W(val2));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			{
				NDynamicPort val = new NDynamicPort(J8aMC71DKxVaoV4EA5W(shape), ContentAlignment.MiddleCenter, (DynamicPortGlueMode)3);
				nBLMJM1njfJP75C5pLu((object)val, name);
				val2 = val;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	static ShapeHelper()
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
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				DefaultStrokeColor = Color.DimGray;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool flTNNa1b8gpnJj6tcXO()
	{
		return WGhNDh1tRsrwBWhXas8 == null;
	}

	internal static ShapeHelper R5JbOP15FgbS2qTkGPC()
	{
		return WGhNDh1tRsrwBWhXas8;
	}

	internal static object y1TU2c1gbpdoqZ1AppJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void MGZFiN1B10RABv71KeS(object P_0, object P_1)
	{
		AddCenterPort((NShape)P_0, (string)P_1);
	}

	internal static void Cw6rkX1cZqVYSiKahs9(object P_0, ContentAlignment align, object P_2)
	{
		AddPort((NShape)P_0, align, (string)P_2);
	}

	internal static void KkTgM01PxFVIwZgUAgI(object P_0, float percX, float percY, object P_3)
	{
		AddPort((NShape)P_0, percX, percY, (string)P_3);
	}

	internal static void E0Dfl91X2e8kj55HeI1(object P_0, NContentAlignment align, object P_2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		AddPort((NShape)P_0, align, (string)P_2);
	}

	internal static object vT9khI1dG5p91GKlSnk(object P_0)
	{
		return ((NShape)P_0).get_Ports();
	}

	internal static void XJysEc1uP7e62icfvLY(object P_0, bool P_1)
	{
		((NDiagramElementCollection)P_0).set_AutoGenerateUniqueNames(P_1);
	}

	internal static Guid J8aMC71DKxVaoV4EA5W(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void nBLMJM1njfJP75C5pLu(object P_0, object P_1)
	{
		((NDiagramElement)P_0).set_Name((string)P_1);
	}

	internal static void gPpSWN1HhVUjhRurIJv(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool f2U3IZ1LOurkVG5OeLt(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}
}
