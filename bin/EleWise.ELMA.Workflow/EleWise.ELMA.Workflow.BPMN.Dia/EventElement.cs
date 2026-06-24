using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Diagram.Extensions;
using Nevron.GraphicsCore;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

[Serializable]
public abstract class EventElement : BPMNFlowElement
{
	private EventTrigger trigger;

	internal static EventElement pODJStZlGHav1b8lZ4jE;

	public EventTrigger Trigger
	{
		get
		{
			return trigger;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					XcwkeKZlokjK6US6oTiM(this);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 1:
					trigger = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string DefaultName => (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-197778752 ^ -197869916));

	public override string ChapterName => (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x4FD00585 ^ 0x4FD299F3));

	public override string HtmlHeader(ProcessContext context, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, GenerationSettings gs = null)
	{
		int num = 1;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stringBuilder = new StringBuilder();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					h7i4YuZlxUx4oZWAZsYo(stringBuilder, CKd8EXZlFyf9MP0ZWpYF(0x2F44D93A ^ 0x2F46A526));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return stringBuilder.ToString();
				case 6:
					h7i4YuZlxUx4oZWAZsYo(stringBuilder, CKd8EXZlFyf9MP0ZWpYF(0x157D5AF4 ^ 0x157F21CA));
					num = 4;
					break;
				case 3:
					h7i4YuZlxUx4oZWAZsYo(stringBuilder, CKd8EXZlFyf9MP0ZWpYF(-1539486135 ^ -1539511019));
					num2 = 5;
					continue;
				default:
					h7i4YuZlxUx4oZWAZsYo(stringBuilder, fhCotnZlN4WPabOuHvLX(new object[5]
					{
						CKd8EXZlFyf9MP0ZWpYF(--1212129906 ^ 0x483DD96A),
						((string)OjYMlVZlIpXZPwH3CSHd(Name) == "") ? B4kyJHZlrSXdbRAOBCOb(this) : YjsPjUZlafgJA9vrraIL(this),
						CKd8EXZlFyf9MP0ZWpYF(0x74AB4717 ^ 0x74A97DBB),
						z57HfGZleKrg6OR8wqgS(this),
						CKd8EXZlFyf9MP0ZWpYF(-1716629332 ^ -1716769912)
					}));
					num2 = 6;
					continue;
				case 4:
					stringBuilder.Append((string)t72ZtQZlEJJyHVdfto0G(MsxM6XZl1LfrIVX35hu0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763813485), EAlZdkZlS7K28cM7r4Eo(z57HfGZleKrg6OR8wqgS(this).ToString()), CKd8EXZlFyf9MP0ZWpYF(0x246EEF98 ^ 0x246C9468)), subFolders ? "" : tuwgZQZlhNI5uOgO0jyc(context.Uid.ToString(), CKd8EXZlFyf9MP0ZWpYF(-106528299 ^ -106647081), "")));
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public override string HtmlBody(Element element, List<ProcessContext> contexts, int orgStructVersion, bool subFolders, WorkflowDiagram diagram, IWorkflowProcess wp = null, GenerationSettings gs = null)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SwimlaneElement swimlane = GetSwimlane(diagram);
		if (swimlane != null && !string.IsNullOrEmpty(swimlane.Name))
		{
			string arg = HTMLUtility.InsertHyperLink(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7383CE87), swimlane.Uid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14229698), "")), swimlane.Name);
			stringBuilder.Append(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935149417), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4941621C)), arg));
		}
		if (!string.IsNullOrEmpty(element.Description))
		{
			stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F44DA8) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790358596)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651D9EF7) + element.Description);
		}
		return stringBuilder.ToString();
	}

	public override string HtmlFooter()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append((string)CKd8EXZlFyf9MP0ZWpYF(-1712492721 ^ -1712385501) + (string)aaoAllZlwE5y7h5JfRCw(this));
		h7i4YuZlxUx4oZWAZsYo(stringBuilder, CKd8EXZlFyf9MP0ZWpYF(-1386448964 ^ -1386345924));
		return stringBuilder.ToString();
	}

	public override Bitmap GetBitmap(WorkflowDiagram diagram, NShape shape)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		float num4 = default(float);
		float num5 = default(float);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = JeSoukZl4eBH5hWgBZEH(shape).Y - 1f;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num5 = ((NModel)shape).get_Bounds().X - 1f;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				float num3 = JeSoukZl4eBH5hWgBZEH(shape).X + JeSoukZl4eBH5hWgBZEH(shape).Width + 1f;
				Bitmap obj = new Bitmap(height: Convert.ToInt32(JeSoukZl4eBH5hWgBZEH(shape).Y + ((NModel)shape).get_Bounds().Height + 1f - num4), width: eeW46cZlz69bI5kdRT4j(num3 - num5));
				Graphics graphics = Graphics.FromImage(obj);
				NCanvas val = new NCanvas((NDrawingDocument)H8WxCLZ0KqwsRHSPvNkH(diagram));
				val.set_ViewportOrigin(new NPointF(num5, num4));
				fGy57hZ0O067qDt1JJRQ((object)val, graphics);
				return obj;
			}
			}
		}
	}

	protected string GetDayOfWeekName(DayOfWeek day)
	{
		//Discarded unreachable code: IL_0069, IL_0078
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				switch (day)
				{
				default:
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 1;
					}
					goto end_IL_0012;
				case DayOfWeek.Monday:
					break;
				case DayOfWeek.Tuesday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x6871CA ^ 0x6AED68));
				case DayOfWeek.Wednesday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-197778752 ^ -197869964));
				case DayOfWeek.Thursday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-682910880 ^ -683079774));
				case DayOfWeek.Friday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-39189604 ^ -39280824));
				case DayOfWeek.Saturday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(--601115071 ^ 0x23D6D559));
				case DayOfWeek.Sunday:
					return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x65B7F624 ^ 0x65B56ADC));
				}
				goto default;
			default:
				return SR.T((string)CKd8EXZlFyf9MP0ZWpYF(-1386448964 ^ -1386288332));
			case 1:
				{
					return (string)MsxM6XZl1LfrIVX35hu0(CKd8EXZlFyf9MP0ZWpYF(0x1927DA93 ^ 0x1926AAB5), xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-865213812 ^ -865108342)), CKd8EXZlFyf9MP0ZWpYF(-1712492721 ^ -1712514937));
				}
				end_IL_0012:
				break;
			}
		}
	}

	protected string GetDayOfWeekName(int i)
	{
		//Discarded unreachable code: IL_0151, IL_0160
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-763667953 ^ -763771257));
			case 1:
				return (string)MsxM6XZl1LfrIVX35hu0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657652221), xFxbuyZli6Vfll58gQEQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105761724)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D43E77));
			case 2:
				{
					switch (i)
					{
					case 0:
						break;
					case 1:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-2002063381 ^ -2002226359));
					case 2:
						return (string)xFxbuyZli6Vfll58gQEQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1599889692));
					case 3:
						return SR.T((string)CKd8EXZlFyf9MP0ZWpYF(-1776305410 ^ -1776474564));
					case 4:
						return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360568979));
					case 5:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x5BCD23A0 ^ 0x5BCFBF46));
					case 6:
						return SR.T((string)CKd8EXZlFyf9MP0ZWpYF(0x1EA50FCC ^ 0x1EA79334));
					default:
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 0;
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

	protected string GetMonthName(int monthNumber)
	{
		//Discarded unreachable code: IL_01d4, IL_01e3
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-885093259 ^ -885255833));
			default:
				return (string)MsxM6XZl1LfrIVX35hu0(CKd8EXZlFyf9MP0ZWpYF(0x37F755F5 ^ 0x37F625D3), SR.T((string)CKd8EXZlFyf9MP0ZWpYF(0x7381F16B ^ 0x73836D6D)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716639900));
			case 1:
				{
					switch (monthNumber)
					{
					case 1:
						break;
					case 2:
						return (string)xFxbuyZli6Vfll58gQEQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x43889361));
					case 3:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-135674354 ^ -135570630));
					case 4:
						return (string)xFxbuyZli6Vfll58gQEQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720622557));
					case 5:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-2077784392 ^ -2077942808));
					case 6:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x17F0C5A2 ^ 0x17F258F8));
					case 7:
						return (string)xFxbuyZli6Vfll58gQEQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75B84B3F));
					case 8:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-351369538 ^ -351527988));
					case 9:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-2002063381 ^ -2002226583));
					case 10:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(-495296780 ^ -495402142));
					case 11:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x69063C81 ^ 0x6904A129));
					case 12:
						return (string)xFxbuyZli6Vfll58gQEQ(CKd8EXZlFyf9MP0ZWpYF(0x4FD00585 ^ 0x4FD2983D));
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	protected EventElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UHiIrKZ0ZIP3wWat1RPX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void XcwkeKZlokjK6US6oTiM(object P_0)
	{
		((BPMNFlowElement)P_0).UpdateDecorators();
	}

	internal static bool IHlL58Zl7Bd9LCfEcyft()
	{
		return pODJStZlGHav1b8lZ4jE == null;
	}

	internal static EventElement uqZKMwZl2BywHnM0LLtL()
	{
		return pODJStZlGHav1b8lZ4jE;
	}

	internal static object CKd8EXZlFyf9MP0ZWpYF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xFxbuyZli6Vfll58gQEQ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object OjYMlVZlIpXZPwH3CSHd(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object YjsPjUZlafgJA9vrraIL(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object B4kyJHZlrSXdbRAOBCOb(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static Guid z57HfGZleKrg6OR8wqgS(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object fhCotnZlN4WPabOuHvLX(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object h7i4YuZlxUx4oZWAZsYo(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object EAlZdkZlS7K28cM7r4Eo(object P_0)
	{
		return HTMLUtility.MakeValidFileName((string)P_0);
	}

	internal static object MsxM6XZl1LfrIVX35hu0(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object tuwgZQZlhNI5uOgO0jyc(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object t72ZtQZlEJJyHVdfto0G(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object aaoAllZlwE5y7h5JfRCw(object P_0)
	{
		return ((BPMNFlowElement)P_0).GetConnectorsLink();
	}

	internal static NRectangleF JeSoukZl4eBH5hWgBZEH(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Bounds();
	}

	internal static int eeW46cZlz69bI5kdRT4j(float P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object H8WxCLZ0KqwsRHSPvNkH(object P_0)
	{
		return ((Diagram)P_0).Document;
	}

	internal static void fGy57hZ0O067qDt1JJRQ(object P_0, object P_1)
	{
		((NCanvas)P_0).RenderToGraphics((Graphics)P_1);
	}

	internal static void UHiIrKZ0ZIP3wWat1RPX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
