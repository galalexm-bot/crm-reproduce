using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Artifacts;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams;

[Serializable]
[XmlRoot("BPMNDiagram")]
public class BPMNDiagram : WorkflowDiagram
{
	private bool boundsChangeCheckedEnabled;

	private static BPMNDiagram bYnZfyO7kvWlppjf7ws9;

	public bool BoundsChangeCheckedEnabled
	{
		get
		{
			return boundsChangeCheckedEnabled;
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
					return;
				case 1:
					boundsChangeCheckedEnabled = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public BPMNDiagram()
	{
		//Discarded unreachable code: IL_0036, IL_003b
		btT2dAO7Ar8paVPP0VNr();
		boundsChangeCheckedEnabled = true;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected BPMNDiagram(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0038, IL_003d
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		boundsChangeCheckedEnabled = true;
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override Element GetStartElement()
	{
		return base.Elements.FirstOrDefault((Element e) => e is StartEventElement);
	}

	public static BPMNDiagram Load(string fileName)
	{
		//Discarded unreachable code: IL_004c, IL_00a3, IL_00b2, IL_00d3, IL_00e2
		int num = 2;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		BPMNDiagram bPMNDiagram = default(BPMNDiagram);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					bPMNDiagram = (BPMNDiagram)vgPxTjO7GwI6Xs5aCwI4(fileStream);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => bPMNDiagram, 
						_ => bPMNDiagram, 
					};
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
						{
							num4 = 0;
						}
						goto IL_0088;
					}
					goto IL_00bd;
					IL_00bd:
					VR5VZ8O77JXlHESCxCKn(fileStream);
					int num5 = 2;
					num4 = num5;
					goto IL_0088;
					IL_0088:
					switch (num4)
					{
					default:
						goto end_IL_0063;
					case 0:
						goto end_IL_0063;
					case 1:
						break;
					case 2:
						goto end_IL_0063;
					}
					goto IL_00bd;
					end_IL_0063:;
				}
			default:
				return bPMNDiagram;
			case 2:
				fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static BPMNDiagram Load(byte[] xmlBytes)
	{
		//Discarded unreachable code: IL_004f, IL_0077, IL_00b7, IL_00c6, IL_00d2, IL_00e1
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		BPMNDiagram result = default(BPMNDiagram);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				memoryStream = (MemoryStream)JBP2eTO72PqCHh4mcpT3(xmlBytes, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				result = (BPMNDiagram)vgPxTjO7GwI6Xs5aCwI4(memoryStream);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (memoryStream == null)
				{
					num4 = 2;
					goto IL_007b;
				}
				goto IL_0091;
				IL_007b:
				switch (num4)
				{
				case 2:
					goto end_IL_0066;
				case 1:
					goto end_IL_0066;
				}
				goto IL_0091;
				IL_0091:
				((IDisposable)memoryStream).Dispose();
				num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num4 = 1;
				}
				goto IL_007b;
				end_IL_0066:;
			}
		}
	}

	public static BPMNDiagram Load(Stream stream)
	{
		return (BPMNDiagram)rTOMLbO7F4W9QaHINmZb(new XmlSerializer(uukuEZO7oAXbMh0RMr2f(typeof(BPMNDiagram).TypeHandle), ComponentManager.Current.GetXsiTypes()), stream);
	}

	public void Save(string fileName)
	{
		//Discarded unreachable code: IL_004c, IL_0084, IL_00a3, IL_00cf, IL_00de
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Save(fileStream);
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				int num4;
				if (fileStream == null)
				{
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num4 = 0;
					}
					goto IL_0088;
				}
				goto IL_00ad;
				IL_00ad:
				VR5VZ8O77JXlHESCxCKn(fileStream);
				num4 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num4 = 1;
				}
				goto IL_0088;
				IL_0088:
				switch (num4)
				{
				default:
					goto end_IL_0063;
				case 0:
					goto end_IL_0063;
				case 2:
					break;
				case 1:
					goto end_IL_0063;
				}
				goto IL_00ad;
				end_IL_0063:;
			}
		}
	}

	public void Save(Stream stream)
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
				new XmlSerializer(uukuEZO7oAXbMh0RMr2f(typeof(BPMNDiagram).TypeHandle), (Type[])ggeJLyO7IjbjMBpFd2tb(or4DUiO7i6gS8l9UdeF8())).Serialize(stream, this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void AttachToEvents()
	{
		CYDvfUO7adg7m9uJ8qbZ(this);
	}

	protected override void SetDefaultDocumentStyles()
	{
		base.SetDefaultDocumentStyles();
	}

	public override bool checkTypeGroupArtifact(Element element)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (element is ArtifactGroupElement)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return true;
			}
		}
	}

	protected override void UpdateElementBounds(Element element, NShape shape, bool inserting)
	{
		//Discarded unreachable code: IL_005e, IL_006d
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					return;
				case 3:
					return;
				case 0:
					return;
				case 4:
					UpdateElementParent(element);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (element is SwimlaneElement)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 5:
					if (!(element is ArtefactElement))
					{
						if (inserting)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 4;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					wgG2N7O7r42xaoNM27CQ(this, element, shape, inserting);
					num2 = 5;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public override bool CanChangeElementBounds(NRectangleF rect, Element element, NShape shape)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return CanChangeElementBounds(rect, element, shape, null);
			case 1:
				if (!BoundsChangeCheckedEnabled)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool CanChangeElementBounds(NRectangleF rect, Element element, NShape shape, Dictionary<NShape, NRectangleF> newShapesBounds)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.newShapesBounds = newShapesBounds;
		CS_0024_003C_003E8__locals0.rect = rect;
		if (element is ArtefactElement)
		{
			return true;
		}
		if (element is Connector)
		{
			return base.CanChangeElementBounds(CS_0024_003C_003E8__locals0.rect, element, shape);
		}
		NRectangleF bounds = ((NModel)shape).get_Bounds();
		if (((NRectangleF)(ref bounds)).get_Size() == NSizeF.Empty && ((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).get_Size() != NSizeF.Empty)
		{
			return true;
		}
		CS_0024_003C_003E8__locals0.rect = new NRectangleF(((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).Round());
		List<Element> list = base.Elements.Where((Element e1) => e1 is SwimlaneElement).ToList();
		List<Element> second = base.Elements.Where((Element e1) => e1 is UnfoldedSubprocessElement).ToList();
		foreach (Element element2 in base.Elements)
		{
			if (element2 is Connector || element2 == element || element2 is ArtefactElement)
			{
				continue;
			}
			NRectangleF newBounds = GetNewBounds(element2, CS_0024_003C_003E8__locals0.newShapesBounds);
			if (element is SwimlaneElement)
			{
				if (element2 is SwimlaneElement && ((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).IntersectsWith(newBounds))
				{
					return false;
				}
				if (element2 is BPMNFlowElement bPMNFlowElement && bPMNFlowElement.ParentUid == element.Uid && !((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).Contains(newBounds))
				{
					return false;
				}
				continue;
			}
			if (element is UnfoldedSubprocessElement)
			{
				if (element2 is UnfoldedSubprocessElement && ((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).IntersectsWith(newBounds))
				{
					return false;
				}
				if (list.FirstOrDefault(delegate(Element e1)
				{
					//IL_0027: Unknown result type (might be due to invalid IL or missing references)
					//IL_003f: Unknown result type (might be due to invalid IL or missing references)
					//IL_0044: Unknown result type (might be due to invalid IL or missing references)
					int num3 = 1;
					int num4 = num3;
					NRectangleF newBounds3 = default(NRectangleF);
					while (true)
					{
						switch (num4)
						{
						default:
							return ((NRectangleF)(ref newBounds3)).Contains(CS_0024_003C_003E8__locals0.rect);
						case 1:
							newBounds3 = CS_0024_003C_003E8__locals0._003C_003E4__this.GetNewBounds(e1, CS_0024_003C_003E8__locals0.newShapesBounds);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}) == null)
				{
					return false;
				}
				continue;
			}
			if (element2 is SwimlaneElement || element2 is UnfoldedSubprocessElement)
			{
				if (((NRectangleF)(ref newBounds)).IntersectsWith(CS_0024_003C_003E8__locals0.rect) && !((NRectangleF)(ref newBounds)).Contains(CS_0024_003C_003E8__locals0.rect))
				{
					return false;
				}
			}
			else if (((NRectangleF)(ref CS_0024_003C_003E8__locals0.rect)).IntersectsWith(newBounds))
			{
				return false;
			}
			if (list.Union(second).FirstOrDefault(delegate(Element e1)
			{
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				int num = 1;
				int num2 = num;
				NRectangleF newBounds2 = default(NRectangleF);
				while (true)
				{
					switch (num2)
					{
					case 1:
						newBounds2 = CS_0024_003C_003E8__locals0._003C_003E4__this.GetNewBounds(e1, CS_0024_003C_003E8__locals0.newShapesBounds);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						return ((NRectangleF)(ref newBounds2)).Contains(CS_0024_003C_003E8__locals0.rect);
					}
				}
			}) == null)
			{
				return false;
			}
		}
		return base.CanChangeElementBounds(CS_0024_003C_003E8__locals0.rect, element, shape);
	}

	protected override void NodeMouseEnter(NNodeViewEventArgs args)
	{
		//Discarded unreachable code: IL_009a, IL_00db, IL_00ee
		int num = 2;
		int num2 = num;
		NShape val = default(NShape);
		while (true)
		{
			switch (num2)
			{
			default:
				if (vFaoMqO7e9w83YekKGkF(val) != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
			{
				INNode node = args.Node;
				val = (NShape)(object)((node is NShape) ? node : null);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 5:
				return;
			case 4:
				try
				{
					val.get_Ports().set_Visible(true);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					DAwEcYO7SD2ZEdsRFA3q(TkscosO7NWJ0VLrsNcCc(document));
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 3:
				VsMG2GO7xQtg3wC62Rlb(TkscosO7NWJ0VLrsNcCc(document));
				num2 = 4;
				break;
			case 1:
				if (val == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void NodeMouseLeave(NNodeViewEventArgs args)
	{
		//Discarded unreachable code: IL_007e, IL_00b0, IL_00f1, IL_0104, IL_0113, IL_0144
		int num = 2;
		int num2 = num;
		NShape val = default(NShape);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				if (vFaoMqO7e9w83YekKGkF(val) == null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 2:
			{
				INNode node = args.Node;
				val = (NShape)(object)((node is NShape) ? node : null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			case 4:
				return;
			case 5:
				try
				{
					KeYjpfO71bMLeqKbTeyq(vFaoMqO7e9w83YekKGkF(val), false);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					DAwEcYO7SD2ZEdsRFA3q(TkscosO7NWJ0VLrsNcCc(document));
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
				if (val == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 7;
			case 0:
				return;
			case 6:
				break;
			case 3:
				return;
			}
			VsMG2GO7xQtg3wC62Rlb(TkscosO7NWJ0VLrsNcCc(document));
			num2 = 5;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
			{
				num2 = 4;
			}
		}
	}

	protected override void OnConnectorPlugChanged(Connector connector, Plug oldPlug, bool isStartPlug)
	{
		//Discarded unreachable code: IL_00ec, IL_0122, IL_016f, IL_02cf, IL_02de, IL_030b
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_1);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_2 = default(_003C_003Ec__DisplayClass19_0);
		IConnectorStatus connectorStatus = default(IConnectorStatus);
		List<IConnectorStatus> list = default(List<IConnectorStatus>);
		IEnumerable<IConnectorStatus> extensionPoints = default(IEnumerable<IConnectorStatus>);
		while (true)
		{
			switch (num2)
			{
			case 21:
				if (_003C_003Ec__DisplayClass19_.count == 1)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 18;
			case 15:
				_003C_003Ec__DisplayClass19_2.modifedConnectorGuid = connector as FlowConnectorElement;
				num2 = 26;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 10;
				}
				break;
			default:
				if (connectorStatus != null)
				{
					num2 = 22;
					break;
				}
				return;
			case 25:
				return;
			case 24:
				_003C_003Ec__DisplayClass19_.count = a1M8cGO74LleVdi4GKta(((Element)euUJHKO7EjNfTWjkCEwU(_003C_003Ec__DisplayClass19_2.modifedConnectorGuid)).OutputConnectors);
				num2 = 3;
				break;
			case 22:
				aQFbLnO7zH8IA1AkyhZO(_003C_003Ec__DisplayClass19_2.modifedConnectorGuid, connectorStatus.Uid);
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 4;
				}
				break;
			case 11:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_1();
				num2 = 24;
				break;
			case 16:
				return;
			case 7:
				list = extensionPoints.Where(_003C_003Ec__DisplayClass19_2._003COnConnectorPlugChanged_003Eb__0).ToList();
				num2 = 14;
				break;
			case 2:
				if (_003C_003Ec__DisplayClass19_.count <= 2)
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			case 4:
				connectorStatus = list.FirstOrDefault(_003C_003Ec__DisplayClass19_._003COnConnectorPlugChanged_003Eb__4);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 13;
				}
				break;
			case 3:
				connectorStatus = null;
				num2 = 21;
				break;
			case 9:
				base.OnConnectorPlugChanged(connector, oldPlug, isStartPlug);
				num2 = 8;
				break;
			case 6:
				extensionPoints = ((ComponentManager)or4DUiO7i6gS8l9UdeF8()).GetExtensionPoints<IConnectorStatus>();
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 19;
				}
				break;
			case 23:
				return;
			case 14:
				if (YiWC1EO7wUD6dW4iWMZY(list) <= 0)
				{
					num2 = 16;
					break;
				}
				goto case 11;
			case 19:
				if (euUJHKO7EjNfTWjkCEwU(_003C_003Ec__DisplayClass19_2.modifedConnectorGuid) == null)
				{
					return;
				}
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				if (!(connector is FlowConnectorElement))
				{
					return;
				}
				num2 = 19;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num2 = 20;
				}
				break;
			case 18:
				if (_003C_003Ec__DisplayClass19_.count == 2)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 12:
				xoSaxAO2OvsVysILoVV1(_003C_003Ec__DisplayClass19_2.modifedConnectorGuid, bgas6RO2KnsoYUbh5wKT(connectorStatus));
				num2 = 23;
				break;
			case 20:
				_003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_0();
				num2 = 15;
				break;
			case 26:
				if (!oOy0EhO7hvHL487R1lok(_003C_003Ec__DisplayClass19_2.modifedConnectorGuid.Status, Guid.Empty))
				{
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
					{
						num2 = 25;
					}
					break;
				}
				goto case 6;
			case 5:
				connectorStatus = list.FirstOrDefault((IConnectorStatus ef) => _003C_003Ec.BKcoHhv0wTCFamw4vLe9(ef));
				num2 = 17;
				break;
			case 1:
				connectorStatus = list.FirstOrDefault((IConnectorStatus ef) => _003C_003Ec.HKlMLSv04kUG0e7Gk7jN(ef));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void UpdateElementParent(Element element)
	{
		//Discarded unreachable code: IL_0082, IL_0091, IL_00a2, IL_01d8, IL_01f7, IL_0223, IL_0232, IL_0353
		int num = 5;
		PointF cp = default(PointF);
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		RectangleF rectangleF = default(RectangleF);
		PointF pt = default(PointF);
		Element2D element2D = default(Element2D);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (element is BPMNFlowElement)
					{
						num2 = 3;
						break;
					}
					return;
				case 1:
					SetParentUidBySwimlane((BPMNFlowElement)element, cp);
					num2 = 7;
					break;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!lswbYgO2shAk1EkqW8Dw(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
								{
									num3 = 1;
								}
								goto IL_00b0;
							}
							goto IL_011f;
							IL_011f:
							bPMNFlowElement = (BPMNFlowElement)enumerator.Current;
							int num4 = 4;
							num3 = num4;
							goto IL_00b0;
							IL_00b0:
							while (true)
							{
								switch (num3)
								{
								case 5:
									JpTUhrO28h44532LJ1kT(bPMNFlowElement, AtDHCTO2YeOVSsilISG2(element));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto IL_011f;
								case 2:
									if (rectangleF.Contains(pt))
									{
										num3 = 5;
										continue;
									}
									break;
								case 4:
									pt = new PointF(aPV0wrO2vkcG0KwN1VOU(bPMNFlowElement).X + pjh5LiO2ZediJLDeNARY(bPMNFlowElement).Width / 2f, aPV0wrO2vkcG0KwN1VOU(bPMNFlowElement).Y + pjh5LiO2ZediJLDeNARY(bPMNFlowElement).Height / 2f);
									num3 = 2;
									continue;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
							{
								num5 = 0;
							}
							goto IL_01dc;
						}
						goto IL_0201;
						IL_0201:
						VR5VZ8O77JXlHESCxCKn(enumerator);
						num5 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
						{
							num5 = 1;
						}
						goto IL_01dc;
						IL_01dc:
						switch (num5)
						{
						default:
							goto end_IL_01b7;
						case 0:
							goto end_IL_01b7;
						case 2:
							break;
						case 1:
							goto end_IL_01b7;
						}
						goto IL_0201;
						end_IL_01b7:;
					}
				case 10:
					if (element2D != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 6;
						}
						break;
					}
					return;
				case 4:
					return;
				case 3:
					cp = new PointF(aPV0wrO2vkcG0KwN1VOU(element2D).X + pjh5LiO2ZediJLDeNARY(element2D).Width / 2f, element2D.Location.Y + pjh5LiO2ZediJLDeNARY(element2D).Height / 2f);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 1;
					}
					break;
				case 12:
					return;
				case 6:
					if (!(element is SwimlaneElement))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 9;
				case 5:
					if (!(element is ArtefactElement))
					{
						goto end_IL_0012;
					}
					num2 = 4;
					break;
				case 9:
					rectangleF = new RectangleF(element2D.Location, pjh5LiO2ZediJLDeNARY(element2D));
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 2;
					}
					break;
				case 7:
					return;
				case 11:
					enumerator = base.Elements.Where((Element e) => e is BPMNFlowElement).GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			element2D = element as Element2D;
			num = 10;
		}
	}

	private void SetParentUidBySwimlane(BPMNFlowElement element, PointF cp)
	{
		//Discarded unreachable code: IL_00da, IL_00e9
		int num = 3;
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
					num = 2;
					break;
				case 7:
					if (swimlaneElement == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 5:
					return;
				case 1:
					JpTUhrO28h44532LJ1kT(element, Guid.Empty);
					num = 4;
					break;
				default:
					element.ParentUid = AtDHCTO2YeOVSsilISG2(swimlaneElement);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass21_.cp = cp;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					return;
				case 6:
					swimlaneElement = ((IEnumerable<Element>)aQuGrbO2J8HPbtb9d2gE(this)).Where((Element e) => e is SwimlaneElement).Cast<SwimlaneElement>().FirstOrDefault(_003C_003Ec__DisplayClass21_._003CSetParentUidBySwimlane_003Eb__1);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	private NRectangleF GetNewBounds(Element e, Dictionary<NShape, NRectangleF> newShapesBounds)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (e == null || e.Shape == null)
		{
			return NRectangleF.Empty;
		}
		NRectangleF val = ((NModel)e.Shape).get_Bounds();
		if (newShapesBounds != null && newShapesBounds.TryGetValue(e.Shape, out var value))
		{
			val = value;
		}
		return new NRectangleF(((NRectangleF)(ref val)).Round());
	}

	internal static void btT2dAO7Ar8paVPP0VNr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Owg6L5O7UT5PYcHMMybY()
	{
		return bYnZfyO7kvWlppjf7ws9 == null;
	}

	internal static BPMNDiagram einVv4O7VTUQcfeYd2WV()
	{
		return bYnZfyO7kvWlppjf7ws9;
	}

	internal static object vgPxTjO7GwI6Xs5aCwI4(object P_0)
	{
		return Load((Stream)P_0);
	}

	internal static void VR5VZ8O77JXlHESCxCKn(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object JBP2eTO72PqCHh4mcpT3(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static Type uukuEZO7oAXbMh0RMr2f(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object rTOMLbO7F4W9QaHINmZb(object P_0, object P_1)
	{
		return ((XmlSerializer)P_0).Deserialize((Stream)P_1);
	}

	internal static object or4DUiO7i6gS8l9UdeF8()
	{
		return ComponentManager.Current;
	}

	internal static object ggeJLyO7IjbjMBpFd2tb(object P_0)
	{
		return ((ComponentManager)P_0).GetXsiTypes();
	}

	internal static void CYDvfUO7adg7m9uJ8qbZ(object P_0)
	{
		((Diagram)P_0).AttachToEvents();
	}

	internal static void wgG2N7O7r42xaoNM27CQ(object P_0, object P_1, object P_2, bool P_3)
	{
		((Diagram)P_0).UpdateElementBounds((Element)P_1, (NShape)P_2, P_3);
	}

	internal static object vFaoMqO7e9w83YekKGkF(object P_0)
	{
		return ((NShape)P_0).get_Ports();
	}

	internal static object TkscosO7NWJ0VLrsNcCc(object P_0)
	{
		return ((NDocument)P_0).get_HistoryService();
	}

	internal static void VsMG2GO7xQtg3wC62Rlb(object P_0)
	{
		((NService)P_0).Pause();
	}

	internal static void DAwEcYO7SD2ZEdsRFA3q(object P_0)
	{
		((NService)P_0).Resume();
	}

	internal static void KeYjpfO71bMLeqKbTeyq(object P_0, bool P_1)
	{
		((NPortCollection)P_0).set_Visible(P_1);
	}

	internal static bool oOy0EhO7hvHL487R1lok(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object euUJHKO7EjNfTWjkCEwU(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static int YiWC1EO7wUD6dW4iWMZY(object P_0)
	{
		return ((List<IConnectorStatus>)P_0).Count;
	}

	internal static int a1M8cGO74LleVdi4GKta(object P_0)
	{
		return ((List<Connector>)P_0).Count;
	}

	internal static void aQFbLnO7zH8IA1AkyhZO(object P_0, Guid value)
	{
		((FlowConnectorElement)P_0).Status = value;
	}

	internal static object bgas6RO2KnsoYUbh5wKT(object P_0)
	{
		return ((IConnectorStatus)P_0).DefaultConnectorDisplayName;
	}

	internal static void xoSaxAO2OvsVysILoVV1(object P_0, object P_1)
	{
		((Element)P_0).Name = (string)P_1;
	}

	internal static SizeF pjh5LiO2ZediJLDeNARY(object P_0)
	{
		return ((Element2D)P_0).Size;
	}

	internal static PointF aPV0wrO2vkcG0KwN1VOU(object P_0)
	{
		return ((Element2D)P_0).Location;
	}

	internal static Guid AtDHCTO2YeOVSsilISG2(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void JpTUhrO28h44532LJ1kT(object P_0, Guid value)
	{
		((BPMNFlowElement)P_0).ParentUid = value;
	}

	internal static bool lswbYgO2shAk1EkqW8Dw(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object aQuGrbO2J8HPbtb9d2gE(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}
}
