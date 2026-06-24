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
public class VSwimlaneShape : SwimlaneShape
{
	public const float DEFAULT_WIDTH = 240f;

	public const float DEFAULT_HEIGHT = 128f;

	public const float DEFAULT_HEADER_HEIGHT = 32f;

	private static VSwimlaneShape MWOwmiOrrEJwDyTnC7QL;

	protected override GradientStyle HeaderGradientStyle => (GradientStyle)0;

	public VSwimlaneShape()
	{
		//Discarded unreachable code: IL_001e
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01bd: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		q0rfUiOrxWK6ONPABEBj();
		base._002Ector();
		int num = 8;
		SwimlaneDecorator swimlaneDecorator = default(SwimlaneDecorator);
		NAbilities protection = default(NAbilities);
		VSwimlaneLabel vSwimlaneLabel = default(VSwimlaneLabel);
		NRectanglePath val = default(NRectanglePath);
		NTextStyle val2 = default(NTextStyle);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					((NDiagramElement)swimlaneDecorator).set_Name((string)TjuT68Oe0tMsFah3mtoH(-39189604 ^ -39292074));
					num2 = 2;
					continue;
				case 13:
					protection = ((NDiagramElement)this).get_Protection();
					num2 = 20;
					continue;
				case 9:
					M2fKAjOetHJE1Qp7M8lJ(swimlaneDecorator, (32f - NT3lKgOem4S7JrjJWXbn(swimlaneDecorator)) / 2f);
					num2 = 5;
					continue;
				case 1:
					VU0XtwOelVh8071gvZvS(PFZ3TrOrhQdwpcO8vmNL(this), w0vsEUOeJZLRyyoOUVEy());
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 16;
					}
					continue;
				case 10:
					CRJWVsOrE9BOFWDaGE9X(dcUqKNOrzmb8iKP3rjbo(this), vSwimlaneLabel);
					num2 = 6;
					continue;
				case 15:
					((NModel)val).set_PinPoint(new NPointF(120f, 0f));
					num2 = 23;
					continue;
				case 18:
					val2 = new NTextStyle();
					num = 3;
					break;
				case 16:
					((NStyle)PFZ3TrOrhQdwpcO8vmNL(val)).set_FillStyle((NFillStyle)(object)GetHeaderFillStyle(SwimlaneType.Static));
					num2 = 12;
					continue;
				case 19:
					swimlaneDecorator = new SwimlaneDecorator();
					num2 = 17;
					continue;
				case 8:
				{
					NRectanglePath val3 = new NRectanglePath(0f, 0f, 240f, 32f);
					X88tnnOrSYpj5GgPD0bk((object)val3, (ResizeInAggregate)16);
					val = val3;
					num2 = 21;
					continue;
				}
				case 23:
					jkACWqOr1V7Sshni6vo6(val, (object)new NStyle());
					num2 = 16;
					continue;
				case 2:
					RlmoZNOeyedeegqRi4LG(swimlaneDecorator, DecoratorPosition.TopLeft);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					CRJWVsOrE9BOFWDaGE9X(((NShape)this).get_Decorators(), swimlaneDecorator);
					num = 25;
					break;
				case 11:
					TfeMEUOr4omqdLwZjnl2(this, (RouteObstacleType)1);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num2 = 13;
					}
					continue;
				case 25:
					return;
				default:
					zqBuhPOesvVhAmscP7YM(PFZ3TrOrhQdwpcO8vmNL(this), val2);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					((NAbilities)(ref protection)).set_InplaceEdit(true);
					num2 = 22;
					continue;
				case 12:
					CRJWVsOrE9BOFWDaGE9X(((NCompositeShape)this).get_Primitives(), val);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					vSwimlaneLabel = new VSwimlaneLabel("", Guid.Empty, NMargins.Empty);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 10;
					}
					continue;
				case 4:
					CRJWVsOrE9BOFWDaGE9X(((NCompositeShape)this).get_Primitives(), (object)new NPolylinePath((NPointF[])(object)new NPointF[4]
					{
						new NPointF(0f, 0f),
						new NPointF(0f, 128f),
						new NPointF(240f, 128f),
						new NPointF(240f, 0f)
					}));
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 8;
					}
					continue;
				case 3:
					v13v3nOe8ftZOZC0I0Lp(val2, (object)new NFontStyle((string)Tgk8n9OevQJ1oir0crtH(this), IAMtt0OeYJByhehkHC4M(this)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 0;
					}
					continue;
				case 22:
					((NDiagramElement)this).set_Protection(protection);
					num = 24;
					break;
				case 6:
					g6fLhlOeZOvOByGuqRrV(dcUqKNOrzmb8iKP3rjbo(this), UqZ0UyOeODbuZYGqYDoR(vSwimlaneLabel));
					num = 18;
					break;
				case 24:
					T0Cq0SOeKHZtIjYkNfuX(dcUqKNOrzmb8iKP3rjbo(this));
					num2 = 7;
					continue;
				case 14:
					WuDyLVOrwRkdQdFcrGYo(this);
					num2 = 11;
					continue;
				case 21:
					((NDiagramElement)val).set_Name(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077886974));
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
					{
						num2 = 13;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void q0rfUiOrxWK6ONPABEBj()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static void X88tnnOrSYpj5GgPD0bk(object P_0, ResizeInAggregate P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NModel)P_0).set_ResizeInAggregate(P_1);
	}

	internal static void jkACWqOr1V7Sshni6vo6(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object PFZ3TrOrhQdwpcO8vmNL(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void CRJWVsOrE9BOFWDaGE9X(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool WuDyLVOrwRkdQdFcrGYo(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static void TfeMEUOr4omqdLwZjnl2(object P_0, RouteObstacleType P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NShape)P_0).set_RouteObstacleType(P_1);
	}

	internal static object dcUqKNOrzmb8iKP3rjbo(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static void T0Cq0SOeKHZtIjYkNfuX(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}

	internal static Guid UqZ0UyOeODbuZYGqYDoR(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void g6fLhlOeZOvOByGuqRrV(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static object Tgk8n9OevQJ1oir0crtH(object P_0)
	{
		return ((SwimlaneShape)P_0).FontName;
	}

	internal static float IAMtt0OeYJByhehkHC4M(object P_0)
	{
		return ((SwimlaneShape)P_0).FontSize;
	}

	internal static void v13v3nOe8ftZOZC0I0Lp(object P_0, object P_1)
	{
		((NTextStyle)P_0).set_FontStyle((NFontStyle)P_1);
	}

	internal static void zqBuhPOesvVhAmscP7YM(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object w0vsEUOeJZLRyyoOUVEy()
	{
		return ShapeHelper.DefaultStrokeStyle;
	}

	internal static void VU0XtwOelVh8071gvZvS(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static object TjuT68Oe0tMsFah3mtoH(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RlmoZNOeyedeegqRi4LG(object P_0, DecoratorPosition value)
	{
		((BaseDecorator)P_0).Position = value;
	}

	internal static float NT3lKgOem4S7JrjJWXbn(object P_0)
	{
		return ((BaseDecorator)P_0).Height;
	}

	internal static void M2fKAjOetHJE1Qp7M8lJ(object P_0, float value)
	{
		((BaseDecorator)P_0).PaddingY = value;
	}

	internal static bool Ios7kxOre0FHUEElNS0w()
	{
		return MWOwmiOrrEJwDyTnC7QL == null;
	}

	internal static VSwimlaneShape nP6RooOrN4FkJySDM0c8()
	{
		return MWOwmiOrrEJwDyTnC7QL;
	}
}
