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
public class ArtifactDataObjectShape : ArtifactTaskShape
{
	internal static ArtifactDataObjectShape l8Z62gOFDYBqylpo1Y5Y;

	protected virtual Color StartColor => aoyj2POFAkdV6wocaM3e();

	protected virtual Color EndColor => Color.White;

	protected virtual Color StrokeColor => cwLgvIOFffQbgMMxxFuB(178, 184, 192);

	protected virtual float StrokeWidth => 1f;

	protected virtual int ColorAlpha => 255;

	protected virtual float DefaultWidth => 196f;

	protected virtual float DefaultHeight => 80f;

	protected override void CreateDefaultLabels()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		NStyle val3 = default(NStyle);
		NBoundsLabel val2 = default(NBoundsLabel);
		NMargins val = default(NMargins);
		while (true)
		{
			switch (num2)
			{
			case 4:
				val3.set_TextStyle(new NTextStyle(new Font(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA7178FA), 12f), cwLgvIOFffQbgMMxxFuB(95, 95, 95)));
				num2 = 6;
				break;
			case 6:
				v9pBdwOFjSPqBu3q3pmP(PcDHu9OFWnhB6VOeJT5g(FNBvhIOF9k0OfaJiogqB(val3)), (VertAlign)1);
				num2 = 3;
				break;
			case 1:
				val3 = new NStyle();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				f3Py94OFRZFBV98vKyqo(PcDHu9OFWnhB6VOeJT5g(FNBvhIOF9k0OfaJiogqB(val3)), (HorzAlign)1);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 10;
				}
				break;
			case 10:
				hyMQAFOF6JpXrHkugRAS(FNBvhIOF9k0OfaJiogqB(val3), new NPointL(0, 0));
				num2 = 9;
				break;
			case 5:
				lbC7B2OFQreXg47f2oD7(((NShape)this).get_Labels(), GDUECWOFTYu3g2Y6Oyaa(val2));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				((NDiagramElementCollection)jSkNohOF3AJagLmPRiRr(this)).AddChild((INNode)(object)val2);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				val2 = new NBoundsLabel((string)u3McxaOFLV2wt1rqJXuC(-885093259 ^ -885195667), Guid.Empty, val);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				VTRAOHOFqKrjvAicxu8a(val2, val3);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 8:
				((NMargins)(ref val))._002Ector(30f, 10f, 0f, 0f);
				num2 = 7;
				break;
			}
		}
	}

	public ArtifactDataObjectShape()
	{
		//Discarded unreachable code: IL_002a
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 5;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
		{
			num = 5;
		}
		NAbilities protection = default(NAbilities);
		NCustomPath val = default(NCustomPath);
		NStyle val2 = default(NStyle);
		while (true)
		{
			switch (num)
			{
			case 10:
			{
				AddPorts(0f, 0f, DefaultWidth, DefaultHeight);
				int num2 = 2;
				num = num2;
				break;
			}
			case 11:
				e6DMRROFUVy9SyYCSUVT(this, protection);
				num = 10;
				break;
			case 7:
				T8n76LOFkyxm4ekVt2kM(sNJbvEOFMmAA50JJMebG(this), val);
				num = 6;
				break;
			case 3:
				return;
			case 13:
				val2.set_StrokeStyle(new NStrokeStyle(Color.Transparent));
				num = 4;
				break;
			case 4:
				tcmnThOFCPH1OkPkqINS(val2, (object)new NColorFillStyle(Color.Transparent));
				num = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num = 7;
				}
				break;
			case 1:
				val2 = new NStyle();
				num = 13;
				break;
			case 2:
				dqKF6lOFV7KGrPbX2v3S(this, (ShapeElementsMask)8);
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num = 0;
				}
				break;
			case 8:
				((NAbilities)(ref protection)).set_InplaceEdit(true);
				num = 11;
				break;
			case 6:
				((NAggregateModel)this).UpdateModelBounds();
				num = 9;
				break;
			case 12:
				((NStyleableElement)val).set_Style(val2);
				num = 7;
				break;
			case 5:
				val = new NCustomPath((GraphicsPath)w30MsCOFp92TfFXtgue5(0f, 0f, DefaultWidth, DefaultHeight), (PathType)1);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num = 1;
				}
				break;
			case 9:
				protection = ((NDiagramElement)this).get_Protection();
				num = 8;
				break;
			default:
				AddDecorator<ArtifactDataObjectDecorator>(DecoratorPosition.TopLeft);
				num = 3;
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
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
				UVmUhdOFGL9NaLBZyMTc(this, new NContentAlignment(ContentAlignment.MiddleLeft), u3McxaOFLV2wt1rqJXuC(--1756698829 ^ 0x68B442CD));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static GraphicsPath CreatePathBase(float x, float y, float w, float h)
	{
		int num = 1;
		int num2 = num;
		float num4 = default(float);
		float num3 = default(float);
		while (true)
		{
			switch (num2)
			{
			default:
				num4 = y + h;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				num3 = x + w;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				k7lkO5OF7YQ6oWWPEsjw(graphicsPath, num3, y, x, y);
				graphicsPath.AddLine(x, num4, num3, num4);
				N8uWGxOF2mUI3vpb8YlT(graphicsPath);
				return graphicsPath;
			}
			}
		}
	}

	public void AddDecorator<TDecorator>(DecoratorPosition position = DecoratorPosition.Center) where TDecorator : BaseDecorator, new()
	{
		AddDecorator(typeof(TDecorator), position);
	}

	public void AddDecorator(Type decoratorType, DecoratorPosition position = DecoratorPosition.Center)
	{
		//Discarded unreachable code: IL_0041, IL_00fe, IL_010d, IL_0118, IL_013f, IL_014e, IL_0218
		int num = 5;
		int num2 = num;
		BaseDecorator baseDecorator = default(BaseDecorator);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (bvF4esOFomP0Uf5HDmJG(this) == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 4:
			case 6:
				baseDecorator = (BaseDecorator)DWKAY5OFeah8c2SbWGMI(decoratorType);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				return;
			case 3:
				enumerator = (IEnumerator)ASCTIyOFFWULMYZiK8k5(((NShape)this).get_Decorators());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				T8n76LOFkyxm4ekVt2kM(bvF4esOFomP0Uf5HDmJG(this), baseDecorator);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				Ft0ouKOFNwtk4kepTlLS(baseDecorator, position);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 1;
				}
				break;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!mUQT0SOFadfPUZOqN03G(enumerator))
						{
							num3 = 3;
							goto IL_011c;
						}
						goto IL_0158;
						IL_011c:
						switch (num3)
						{
						case 4:
							return;
						case 1:
							break;
						default:
							continue;
						case 3:
							goto end_IL_0189;
						}
						goto IL_0158;
						IL_0158:
						if (E8GwCqOFIqL6S397t929(DqmSDwOFiQB2vW2Nobme(enumerator).GetType(), decoratorType))
						{
							return;
						}
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num3 = 0;
						}
						goto IL_011c;
						continue;
						end_IL_0189:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 2;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 1:
							wivFl7OFr2AJ4OkbhYZw(disposable);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
							{
								num5 = 0;
							}
							continue;
						case 2:
							if (disposable != null)
							{
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
								{
									num5 = 0;
								}
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 4;
			}
		}
	}

	protected override void UpdateElementReferences()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				AddDecorator<ArtifactDataObjectDecorator>(DecoratorPosition.TopLeft);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				RcZWAiOFxLNwJS4yJURD(bvF4esOFomP0Uf5HDmJG(this));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				((NCompositeShape)this).UpdateElementReferences();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				if (bvF4esOFomP0Uf5HDmJG(this) != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 4:
				return;
			}
		}
	}

	internal static object u3McxaOFLV2wt1rqJXuC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Color cwLgvIOFffQbgMMxxFuB(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static object FNBvhIOF9k0OfaJiogqB(object P_0)
	{
		return ((NStyle)P_0).get_TextStyle();
	}

	internal static object PcDHu9OFWnhB6VOeJT5g(object P_0)
	{
		return ((NTextStyle)P_0).get_StringFormatStyle();
	}

	internal static void v9pBdwOFjSPqBu3q3pmP(object P_0, VertAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_VertAlign(P_1);
	}

	internal static void f3Py94OFRZFBV98vKyqo(object P_0, HorzAlign P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NStringFormatStyle)P_0).set_HorzAlign(P_1);
	}

	internal static void hyMQAFOF6JpXrHkugRAS(object P_0, NPointL P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NTextStyle)P_0).set_Offset(P_1);
	}

	internal static void VTRAOHOFqKrjvAicxu8a(object P_0, object P_1)
	{
		((NStyleableElement)P_0).set_Style((NStyle)P_1);
	}

	internal static object jSkNohOF3AJagLmPRiRr(object P_0)
	{
		return ((NShape)P_0).get_Labels();
	}

	internal static Guid GDUECWOFTYu3g2Y6Oyaa(object P_0)
	{
		return ((NDiagramElement)P_0).get_UniqueId();
	}

	internal static void lbC7B2OFQreXg47f2oD7(object P_0, Guid P_1)
	{
		((NLabelCollection)P_0).set_DefaultLabelUniqueId(P_1);
	}

	internal static bool TFudj7OFnIfhFhq7R54x()
	{
		return l8Z62gOFDYBqylpo1Y5Y == null;
	}

	internal static ArtifactDataObjectShape wkVnLTOFHVn7ucmof1wZ()
	{
		return l8Z62gOFDYBqylpo1Y5Y;
	}

	internal static object w30MsCOFp92TfFXtgue5(float x, float y, float w, float h)
	{
		return CreatePathBase(x, y, w, h);
	}

	internal static void tcmnThOFCPH1OkPkqINS(object P_0, object P_1)
	{
		((NStyle)P_0).set_FillStyle((NFillStyle)P_1);
	}

	internal static object sNJbvEOFMmAA50JJMebG(object P_0)
	{
		return ((NCompositeShape)P_0).get_Primitives();
	}

	internal static void T8n76LOFkyxm4ekVt2kM(object P_0, object P_1)
	{
		((NDiagramElementCollection)P_0).AddChild((INNode)P_1);
	}

	internal static void e6DMRROFUVy9SyYCSUVT(object P_0, NAbilities P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((NDiagramElement)P_0).set_Protection(P_1);
	}

	internal static bool dqKF6lOFV7KGrPbX2v3S(object P_0, ShapeElementsMask P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NShape)P_0).CreateShapeElements(P_1);
	}

	internal static Color aoyj2POFAkdV6wocaM3e()
	{
		return Color.White;
	}

	internal static void UVmUhdOFGL9NaLBZyMTc(object P_0, NContentAlignment align, object P_2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		ShapeHelper.AddPort((NShape)P_0, align, (string)P_2);
	}

	internal static void k7lkO5OF7YQ6oWWPEsjw(object P_0, float P_1, float P_2, float P_3, float P_4)
	{
		((GraphicsPath)P_0).AddLine(P_1, P_2, P_3, P_4);
	}

	internal static void N8uWGxOF2mUI3vpb8YlT(object P_0)
	{
		((GraphicsPath)P_0).CloseAllFigures();
	}

	internal static object bvF4esOFomP0Uf5HDmJG(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object ASCTIyOFFWULMYZiK8k5(object P_0)
	{
		return ((NDiagramElementCollection)P_0).GetEnumerator();
	}

	internal static object DqmSDwOFiQB2vW2Nobme(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool E8GwCqOFIqL6S397t929(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool mUQT0SOFadfPUZOqN03G(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void wivFl7OFr2AJ4OkbhYZw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object DWKAY5OFeah8c2SbWGMI(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void Ft0ouKOFNwtk4kepTlLS(object P_0, DecoratorPosition value)
	{
		((BaseDecorator)P_0).Position = value;
	}

	internal static void RcZWAiOFxLNwJS4yJURD(object P_0)
	{
		((NDiagramElementCollection)P_0).RemoveAllChildren();
	}
}
