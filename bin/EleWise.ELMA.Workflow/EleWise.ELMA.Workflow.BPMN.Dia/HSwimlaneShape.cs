using System;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

[Serializable]
public class HSwimlaneShape : SwimlaneShape
{
	public const float DEFAULT_WIDTH = 128f;

	public const float DEFAULT_HEIGHT = 240f;

	public const float DEFAULT_HEADER_WIDTH = 32f;

	internal static HSwimlaneShape xUcTC0Oa20B24vLEP8Qy;

	protected override GradientStyle HeaderGradientStyle => (GradientStyle)1;

	public HSwimlaneShape()
	{
		//Discarded unreachable code: IL_001a
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		vUevc3OaiGIlgyASlMef();
		base._002Ector();
		int num = 22;
		SwimlaneDecorator swimlaneDecorator = default(SwimlaneDecorator);
		NTextStyle val3 = default(NTextStyle);
		NRectanglePath val = default(NRectanglePath);
		HSwimlaneLabel hSwimlaneLabel = default(HSwimlaneLabel);
		NAbilities val2 = default(NAbilities);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 20:
				x0tU9XOrJcaX5pKidyUB(swimlaneDecorator, (32f - BWPcZGOrsB08Z2I6ndO7(swimlaneDecorator)) / 2f);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num = 1;
				}
				break;
			default:
				v9cETSOrvYCUEvJunCEg(ImkNZiOrZh30Iul4npld(this), val3);
				num = 15;
				break;
			case 1:
				vG4fUXOa47BkZkIq8VE7(S9psYqOrlQ87hgWR9VuT(this), swimlaneDecorator);
				num = 9;
				break;
			case 22:
			{
				NRectanglePath val4 = new NRectanglePath(0f, 0f, 32f, 240f);
				((NModel)val4).set_ResizeInAggregate((ResizeInAggregate)13);
				val = val4;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num = 3;
				}
				break;
			}
			case 7:
				tJEOgLOrOIVUneAfDfZw(val3, (object)new NFontStyle((string)vpOPejOazHiBY2NV8Tnp(this), EulbJEOrKv7XosrpfXqx(this)));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				uqkcAhOaSV95OaJubmX9(this);
				num = 4;
				break;
			case 8:
				c4gJbjOawc3P59aTWxWj(yqyT5qOaEyJiSvp4NFIC(this));
				num = 10;
				break;
			case 17:
				val3 = new NTextStyle();
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num = 4;
				}
				break;
			case 21:
				SnNMX3OaNa5kLKL9hQel(((NStyleableElement)val).get_Style(), GetHeaderFillStyle(SwimlaneType.Static));
				num = 13;
				break;
			case 25:
				ytfUIFOaeXaqyGd3wTaf(val, (object)new NStyle());
				num = 21;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num = 21;
				}
				break;
			case 10:
				hSwimlaneLabel = new HSwimlaneLabel("", Guid.Empty, NMargins.Empty);
				num = 18;
				break;
			case 24:
				BBocgYOah2UgViyxa4Fv(this, val2);
				num = 8;
				break;
			case 5:
				Us1tleOarC17NqKtasCF(val, new NPointF(0f, 120f));
				num = 25;
				break;
			case 9:
				return;
			case 4:
				((NShape)this).set_RouteObstacleType((RouteObstacleType)1);
				num = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num = 1;
				}
				break;
			case 6:
				val2 = dNVObsOa1dFtSgC7AUyF(this);
				num = 11;
				break;
			case 12:
				mlrIejOaaLkXa3qAVbj5(swimlaneDecorator, IIU68VOaIV9X9bGnJGlQ(0x6871CA ^ 0x6A0100));
				num = 16;
				break;
			case 16:
				swimlaneDecorator.Position = DecoratorPosition.TopLeft;
				num = 20;
				break;
			case 23:
				((NDiagramElementCollection)xBc6LkOaxECfNIygFlgN(this)).AddChild((INNode)new NPolylinePath((NPointF[])(object)new NPointF[4]
				{
					new NPointF(0f, 0f),
					new NPointF(128f, 0f),
					new NPointF(128f, 240f),
					new NPointF(0f, 240f)
				}));
				num2 = 2;
				goto IL_001f;
			case 14:
				swimlaneDecorator = new SwimlaneDecorator
				{
					RotationAngle = 90f
				};
				num2 = 12;
				goto IL_001f;
			case 18:
				vG4fUXOa47BkZkIq8VE7(((NShape)this).get_Labels(), hSwimlaneLabel);
				num = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num = 19;
				}
				break;
			case 13:
				((NDiagramElementCollection)((NCompositeShape)this).get_Primitives()).AddChild((INNode)(object)val);
				num = 19;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num = 23;
				}
				break;
			case 11:
				((NAbilities)(ref val2)).set_InplaceEdit(true);
				num = 24;
				break;
			case 15:
				iPTq3COr85uXWP9dGH26(ImkNZiOrZh30Iul4npld(this), VxBmnJOrYX7WJ0mY0gMm());
				num = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num = 13;
				}
				break;
			case 19:
				((NShape)this).get_Labels().set_DefaultLabelUniqueId(((NDiagramElement)hSwimlaneLabel).get_UniqueId());
				num = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num = 7;
				}
				break;
			case 3:
				{
					mlrIejOaaLkXa3qAVbj5(val, IIU68VOaIV9X9bGnJGlQ(0x1C7F6FED ^ 0x1C7D1F57));
					num = 5;
					break;
				}
				IL_001f:
				num = num2;
				break;
			}
		}
	}

	internal static void vUevc3OaiGIlgyASlMef()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object IIU68VOaIV9X9bGnJGlQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void mlrIejOaaLkXa3qAVbj5(object P_0, object P_1)
	{
		((NDiagramElement)P_0).set_Name((string)P_1);
	}

	internal static void Us1tleOarC17NqKtasCF(object P_0, NPointF P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_PinPoint(P_1);
	}

	internal static void ytfUIFOaeXaqyGd3wTaf(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static void SnNMX3OaNa5kLKL9hQel(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object xBc6LkOaxECfNIygFlgN(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static bool uqkcAhOaSV95OaJubmX9(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static NAbilities dNVObsOa1dFtSgC7AUyF(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void BBocgYOah2UgViyxa4Fv(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static object yqyT5qOaEyJiSvp4NFIC(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void c4gJbjOawc3P59aTWxWj(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static void vG4fUXOa47BkZkIq8VE7(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static object vpOPejOazHiBY2NV8Tnp(object P_0)
	{
		return ((SwimlaneShape)P_0).FontName;
	}

	internal static float EulbJEOrKv7XosrpfXqx(object P_0)
	{
		return ((SwimlaneShape)P_0).FontSize;
	}

	internal static void tJEOgLOrOIVUneAfDfZw(object P_0, object P_1)
	{
		((NTextStyle)P_0).set_FontStyle((NFontStyle)P_1);
	}

	internal static object ImkNZiOrZh30Iul4npld(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void v9cETSOrvYCUEvJunCEg(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object VxBmnJOrYX7WJ0mY0gMm()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static void iPTq3COr85uXWP9dGH26(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static float BWPcZGOrsB08Z2I6ndO7(object P_0)
	{
		return ((BaseDecorator)P_0).Width;
	}

	internal static void x0tU9XOrJcaX5pKidyUB(object P_0, float value)
	{
		((BaseDecorator)P_0).PaddingX = value;
	}

	internal static object S9psYqOrlQ87hgWR9VuT(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static bool yikwUhOao08EEiJYOdgO()
	{
		return xUcTC0Oa20B24vLEP8Qy == null;
	}

	internal static HSwimlaneShape mvxyRnOaFntDEpF1xcJ8()
	{
		return xUcTC0Oa20B24vLEP8Qy;
	}
}
