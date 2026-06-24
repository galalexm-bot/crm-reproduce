using System.Drawing;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Swimlanes;

public abstract class SwimlaneShape : NCompositeShape
{
	protected const string HEADER_PRIMITIVE_NAME = "HEADER";

	protected const string ICON_PRIMITIVE_NAME = "ICON";

	private static readonly Color _staticStartColor;

	private static readonly Color _dynamicStartColor;

	private static readonly Color _dynamicScriptStartColor;

	private static readonly Color _businessRoleStartColor;

	private static readonly Color _staticIconColor;

	private static readonly Color _dynamicIconColor;

	private static readonly Color _dynamicScriptIconColor;

	private static readonly Color _businessRoleIconColor;

	private static SwimlaneShape l7Gj01OrDl6Zy29q0TUY;

	protected NRectanglePath Header
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				default:
					return (NRectanglePath)EyNR3xOrRxE1ML0up0sW(((NCompositeShape)this).get_Primitives(), ukUQAiOrjIQNo8LEiiHd(-63028171 ^ -63163249));
				case 1:
					if (X33nOyOrWjbIEMSp8OiX(this) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	protected SwimlaneDecorator Icon
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (FDaCWJOrLE4Vo0VGYGD8(this) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return (SwimlaneDecorator)(object)((NDiagramElementCollection)((NShape)this).get_Decorators()).GetChildByName((string)ukUQAiOrjIQNo8LEiiHd(-420003255 ^ -420138365));
				default:
					return null;
				}
			}
		}
	}

	protected abstract GradientStyle HeaderGradientStyle { get; }

	protected virtual Color StartColor => GetHeaderStartColor(SwimlaneType.Static);

	protected virtual float FontSize => 8f;

	protected virtual string FontName => (string)ukUQAiOrjIQNo8LEiiHd(-1108877388 ^ -1109020798);

	protected virtual FontStyle fontStyle => FontStyle.Bold | FontStyle.Italic;

	public SwimlaneShape()
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_008a, IL_0099
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		((NCompositeShape)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				if (FDaCWJOrLE4Vo0VGYGD8(this) != null)
				{
					num = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 1:
				break;
			case 2:
				return;
			case 3:
				return;
			}
			((NShape)this).CreateShapeElements((ShapeElementsMask)8);
			num = 3;
		}
	}

	public void UpdateHeaderStyle(SwimlaneType swimlaneType, bool iconVisible)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0149, IL_0158
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				if (Header == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 1;
			case 1:
				qEoFpaOr9An5gNLMtE8t(XHW0aMOrfplVHFtjMiVH(Header), GetHeaderFillStyle(swimlaneType));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 7;
				}
				continue;
			case 2:
				if (!iconVisible)
				{
					num2 = 8;
					continue;
				}
				break;
			case 4:
				return;
			case 8:
				Icon.ResetStyle();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
			case 7:
				if (Icon == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			}
			Icon.SetStyle((NFillStyle)(object)GetIconFillStyle(swimlaneType), GetIconStrokeStyle(swimlaneType));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
			{
				num2 = 4;
			}
		}
	}

	protected NGradientFillStyle GetHeaderFillStyle(SwimlaneType swimlaneType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		return new NGradientFillStyle(dwL96ZOr6hcmJowZZdPf(this), (GradientVariant)0, GetHeaderStartColor(swimlaneType), GetHeaderStartColor(swimlaneType));
	}

	protected NColorFillStyle GetIconFillStyle(SwimlaneType swimlaneType)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new NColorFillStyle(GetIconColor(swimlaneType));
	}

	protected NStrokeStyle GetIconStrokeStyle(SwimlaneType swimlaneType)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new NStrokeStyle(0.1f, GetIconColor(swimlaneType));
	}

	protected Color GetHeaderStartColor(SwimlaneType swimlaneType)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				switch (swimlaneType)
				{
				default:
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case SwimlaneType.Dynamic:
					break;
				case SwimlaneType.DynamicScript:
					return _dynamicScriptStartColor;
				case SwimlaneType.BusinessRole:
					return _businessRoleStartColor;
				}
				goto default;
			default:
				return _dynamicStartColor;
			case 1:
				{
					return _staticStartColor;
				}
				end_IL_0012:
				break;
			}
		}
	}

	protected Color GetIconColor(SwimlaneType swimlaneType)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return _dynamicIconColor;
			case 1:
				return _staticIconColor;
			case 2:
				{
					switch (swimlaneType)
					{
					case SwimlaneType.Dynamic:
						break;
					case SwimlaneType.DynamicScript:
						return _dynamicScriptIconColor;
					case SwimlaneType.BusinessRole:
						return _businessRoleIconColor;
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	static SwimlaneShape()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 8:
				_dynamicScriptIconColor = V1fnc0Or3GfgfHIgwa3l(95, 137, 197);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				_dynamicIconColor = V1fnc0Or3GfgfHIgwa3l(103, 173, 2);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				_dynamicScriptStartColor = V1fnc0Or3GfgfHIgwa3l(183, 219, 255);
				num2 = 3;
				break;
			case 5:
				_businessRoleIconColor = V1fnc0Or3GfgfHIgwa3l(95, 137, 197);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 2;
				}
				break;
			case 9:
				_dynamicStartColor = Color.FromArgb(210, 234, 153);
				num2 = 7;
				break;
			default:
				_staticStartColor = V1fnc0Or3GfgfHIgwa3l(225, 225, 225);
				num2 = 9;
				break;
			case 1:
				nPNuwGOrqpI0NyXelKvX();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_businessRoleStartColor = Color.FromArgb(176, 234, 255);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 6:
				_staticIconColor = V1fnc0Or3GfgfHIgwa3l(98, 100, 101);
				num2 = 4;
				break;
			}
		}
	}

	internal static object FDaCWJOrLE4Vo0VGYGD8(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static bool LSuKbFOrnxkJjiCUfLig()
	{
		return l7Gj01OrDl6Zy29q0TUY == null;
	}

	internal static SwimlaneShape rxvLVUOrH4mABI2xBlX9()
	{
		return l7Gj01OrDl6Zy29q0TUY;
	}

	internal static object XHW0aMOrfplVHFtjMiVH(object P_0)
	{
		return ((NStyleableElement)P_0).get_Style();
	}

	internal static void qEoFpaOr9An5gNLMtE8t(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object X33nOyOrWjbIEMSp8OiX(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static object ukUQAiOrjIQNo8LEiiHd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EyNR3xOrRxE1ML0up0sW(object P_0, object P_1)
	{
		return ((NDiagramElementCollection)P_0).GetChildByName((string)P_1);
	}

	internal static GradientStyle dwL96ZOr6hcmJowZZdPf(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((SwimlaneShape)P_0).HeaderGradientStyle;
	}

	internal static void nPNuwGOrqpI0NyXelKvX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Color V1fnc0Or3GfgfHIgwa3l(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}
}
