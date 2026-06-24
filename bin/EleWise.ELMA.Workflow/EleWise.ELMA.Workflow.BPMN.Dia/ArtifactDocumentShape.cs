using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;
using EleWise.ELMA.Workflow.Diagrams.Shapes;
using j3AmrhgkCleVTGdEwA;
using Nevron;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes;

[Serializable]
public class ArtifactDocumentShape : ArtifactTaskShape
{
	private static ArtifactDocumentShape X03Ax3OoaJ7CaKfpW5Cy;

	protected virtual Color StartColor => X1cpbKOFbK762pBR2B3q();

	protected virtual Color EndColor => X1cpbKOFbK762pBR2B3q();

	protected virtual Color StrokeColor => jDMWr9Oox6ZAkGtcTOed(178, 184, 192);

	protected virtual float StrokeWidth => 1f;

	protected virtual int ColorAlpha => 255;

	protected virtual float DefaultWidth => 196f;

	protected virtual float DefaultHeight => 80f;

	protected override void CreateDefaultLabels()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		NStyle val = default(NStyle);
		NBoundsLabel val2 = default(NBoundsLabel);
		NMargins val3 = default(NMargins);
		while (true)
		{
			switch (num2)
			{
			case 8:
				Lgm2OfOoSpbjqb8cQd1L(val, (object)new NTextStyle(new Font((string)JeJPHYOoNy5MVY5iy3CD(0x5F800F5B ^ 0x5F824E4F), 12f), jDMWr9Oox6ZAkGtcTOed(95, 95, 95)));
				num2 = 6;
				break;
			case 5:
				return;
			case 10:
				fP8EUHOo49sqbEtwb06L(((NShape)this).get_Labels(), ((NDiagramElement)val2).get_UniqueId());
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 3;
				}
				break;
			default:
				TGWCqKOowdEe9XWm8lsj(MbQ1jROo1J2wyCPC8uir(F4Nac3OoEnoIvtKTvALm(val)), (HorzAlign)1);
				num2 = 2;
				break;
			case 1:
				((NDiagramElementCollection)((NShape)this).get_Labels()).AddChild((INNode)(object)val2);
				num2 = 10;
				break;
			case 4:
				((NMargins)(ref val3))._002Ector(30f, 10f, 0f, 0f);
				num2 = 3;
				break;
			case 9:
				((NStyleableElement)val2).set_Style(val);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				val2 = new NBoundsLabel(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595E200E), Guid.Empty, val3);
				num2 = 7;
				break;
			case 2:
				((NTextStyle)F4Nac3OoEnoIvtKTvALm(val)).set_Offset(new NPointL(0, 0));
				num2 = 9;
				break;
			case 6:
				k6TiJMOoh27DZDuVvJ1F(MbQ1jROo1J2wyCPC8uir(val.get_TextStyle()), (VertAlign)1);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				val = new NStyle();
				num2 = 8;
				break;
			}
		}
	}

	public ArtifactDocumentShape()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		ahb0NVOozFF9E5E4bfpm();
		base._002Ector();
		int num = 10;
		NAbilities val3 = default(NAbilities);
		NStyle val2 = default(NStyle);
		NCustomPath val = default(NCustomPath);
		while (true)
		{
			switch (num)
			{
			case 8:
				BQmcceOFy5LgESCmM9fJ(this, val3);
				num = 12;
				break;
			case 2:
				RAN8ZNOFYYma4VQlCMbO(val2, (object)new NColorFillStyle(Color.Transparent));
				num = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num = 4;
				}
				break;
			case 12:
				AddPorts(0f, 0f, sp6oCvOFmPbarOn9fS6O(this), e2qwJOOFKnRQ2MamHFG7(this));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num = 0;
				}
				break;
			case 3:
				AddDecorator<ArtifactDocumentDecorator>(DecoratorPosition.TopLeft);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num = 1;
				}
				break;
			case 5:
				KT7oC6OFlvQnxZu32cR0(this);
				num = 4;
				break;
			case 10:
				val = new NCustomPath((GraphicsPath)VqTx8XOFOpAWhvIwv5Tv(0f, 0f, DefaultWidth, e2qwJOOFKnRQ2MamHFG7(this)), (PathType)1);
				num = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num = 1;
				}
				break;
			default:
				HtZwkPOFtAJIMB4kWBr5(this, (ShapeElementsMask)8);
				num = 3;
				break;
			case 1:
				return;
			case 9:
				ee6gaaOFv7cWOOWBV9Xy(val2, (object)new NStrokeStyle(HE53tyOFZ1mbxlBu3P1W()));
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num = 1;
				}
				break;
			case 13:
				((NAbilities)(ref val3)).set_InplaceEdit(true);
				num = 8;
				break;
			case 11:
				U9MriwOFJWUv5NRA7nac(l5fHvSOFsIqCQrglY5gZ(this), val);
				num = 5;
				break;
			case 4:
				val3 = MMQQbHOF0mIllsJmX6O8(this);
				num = 13;
				break;
			case 6:
				val2 = new NStyle();
				num = 9;
				break;
			case 7:
				W03xrtOF8AV5uC5KXML3(val, val2);
				num = 11;
				break;
			}
		}
	}

	public override void UpdateDecorators(Element element)
	{
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
				base.UpdateDecorators(element);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AddPorts(float x, float y, float w, float h)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
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
				GhHGgfOF5ajUfYk2qo4h(this, new NContentAlignment(ContentAlignment.MiddleLeft), JeJPHYOoNy5MVY5iy3CD(-949717965 ^ -949670349));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		int num = 2;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num4 = x + w;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				eNG9BGOFgcuHu1kfgu1U(graphicsPath, num4, y, x, y);
				eNG9BGOFgcuHu1kfgu1U(graphicsPath, x, num3, num4, num3);
				graphicsPath.CloseAllFigures();
				return graphicsPath;
			}
			case 1:
				num3 = y + h;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void AddDecorator<TDecorator>(DecoratorPosition position = DecoratorPosition.Center) where TDecorator : BaseDecorator, new()
	{
		AddDecorator(typeof(TDecorator), position);
	}

	public void AddDecorator(Type decoratorType, DecoratorPosition position = DecoratorPosition.Center)
	{
		//Discarded unreachable code: IL_0065, IL_0073, IL_00dd, IL_00ec, IL_011f, IL_016c, IL_017b
		int num = 6;
		int num2 = num;
		BaseDecorator baseDecorator = default(BaseDecorator);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				U9MriwOFJWUv5NRA7nac(HJE4sqOFBBjGSMkDWJan(this), baseDecorator);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
				{
					num2 = 3;
				}
				continue;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0077;
						}
						goto IL_0091;
						IL_0077:
						switch (num3)
						{
						case 2:
							break;
						default:
							continue;
						case 1:
							return;
						case 3:
							goto end_IL_00c2;
						}
						goto IL_0091;
						IL_0091:
						if (!hH8ym0OFPQQdUKH7b4PO(rlxG8dOFcv1sr4TRKVqc(enumerator).GetType(), decoratorType))
						{
							continue;
						}
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
						{
							num3 = 1;
						}
						goto IL_0077;
						continue;
						end_IL_00c2:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							hEGsRMOFXIR1Wm5oTJOq(disposable);
							num4 = 2;
							continue;
						default:
							if (disposable != null)
							{
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
				break;
			default:
				iXKpusOFuMnWEbBj9xgM(baseDecorator, position);
				num2 = 2;
				continue;
			case 5:
				enumerator = ((NDiagramElementCollection)HJE4sqOFBBjGSMkDWJan(this)).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				if (HJE4sqOFBBjGSMkDWJan(this) != null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 4:
				break;
			case 3:
				return;
			}
			baseDecorator = (BaseDecorator)KVvW5pOFd2u79UjI36i0(decoratorType);
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
			{
				num2 = 0;
			}
		}
	}

	protected override void UpdateElementReferences()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				AddDecorator<ArtifactDocumentDecorator>(DecoratorPosition.TopLeft);
				num2 = 4;
				break;
			case 2:
				if (HJE4sqOFBBjGSMkDWJan(this) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				((NCompositeShape)this).UpdateElementReferences();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				((NDiagramElementCollection)((NShape)this).get_Decorators()).RemoveAllChildren();
				num2 = 3;
				break;
			case 0:
				return;
			}
		}
	}

	internal static object JeJPHYOoNy5MVY5iy3CD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Color jDMWr9Oox6ZAkGtcTOed(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static void Lgm2OfOoSpbjqb8cQd1L(object P_0, object P_1)
	{
		((NStyle)P_0).set_TextStyle((NTextStyle)P_1);
	}

	internal static object MbQ1jROo1J2wyCPC8uir(object P_0)
	{
		return ((NTextStyle)P_0).get_StringFormatStyle();
	}

	internal static void k6TiJMOoh27DZDuVvJ1F(object P_0, VertAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_VertAlign(P_1);
	}

	internal static object F4Nac3OoEnoIvtKTvALm(object P_0)
	{
		return ((NStyle)P_0).get_TextStyle();
	}

	internal static void TGWCqKOowdEe9XWm8lsj(object P_0, HorzAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_HorzAlign(P_1);
	}

	internal static void fP8EUHOo49sqbEtwb06L(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static bool HwPJ8BOorN2YB1XLV8Ba()
	{
		return X03Ax3OoaJ7CaKfpW5Cy == null;
	}

	internal static ArtifactDocumentShape YPbXcBOoeXi64QsFfaiB()
	{
		return X03Ax3OoaJ7CaKfpW5Cy;
	}

	internal static void ahb0NVOozFF9E5E4bfpm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static float e2qwJOOFKnRQ2MamHFG7(object P_0)
	{
		return ((ArtifactDocumentShape)P_0).DefaultHeight;
	}

	internal static object VqTx8XOFOpAWhvIwv5Tv(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static Color HE53tyOFZ1mbxlBu3P1W()
	{
		return Color.Transparent;
	}

	internal static void ee6gaaOFv7cWOOWBV9Xy(object P_0, object P_1)
	{
		((NStyle)P_0).set_StrokeStyle((NStrokeStyle)P_1);
	}

	internal static void RAN8ZNOFYYma4VQlCMbO(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static void W03xrtOF8AV5uC5KXML3(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object l5fHvSOFsIqCQrglY5gZ(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void U9MriwOFJWUv5NRA7nac(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static bool KT7oC6OFlvQnxZu32cR0(object P_0)
	{
		return ((NAggregateModel)P_0).UpdateModelBounds();
	}

	internal static NAbilities MMQQbHOF0mIllsJmX6O8(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NDiagramElement)P_0).get_Protection();
	}

	internal static void BQmcceOFy5LgESCmM9fJ(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static float sp6oCvOFmPbarOn9fS6O(object P_0)
	{
		return ((ArtifactDocumentShape)P_0).DefaultWidth;
	}

	internal static bool HtZwkPOFtAJIMB4kWBr5(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static Color X1cpbKOFbK762pBR2B3q()
	{
		return Color.White;
	}

	internal static void GhHGgfOF5ajUfYk2qo4h(object P_0, NContentAlignment align, object P_2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		ShapeHelper.AddPort((NShape)P_0, align, (string)P_2);
	}

	internal static void eNG9BGOFgcuHu1kfgu1U(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static object HJE4sqOFBBjGSMkDWJan(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object rlxG8dOFcv1sr4TRKVqc(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool hH8ym0OFPQQdUKH7b4PO(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static void hEGsRMOFXIR1Wm5oTJOq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object KVvW5pOFd2u79UjI36i0(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void iXKpusOFuMnWEbBj9xgM(object P_0, DecoratorPosition value)
	{
		((BaseDecorator)P_0).Position = value;
	}
}
