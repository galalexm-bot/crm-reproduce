using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams.Adaptors;
using EleWise.ELMA.Serialization;
using Nevron.Collections;
using Nevron.Diagram;
using Nevron.Diagram.Extensions;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public abstract class Diagram : ISerializable
{
	[NonSerialized]
	protected NDrawingDocument document;

	private bool elementReplacing;

	[XmlAttribute("Width")]
	public float Width { get; set; }

	[XmlAttribute("Height")]
	public float Height { get; set; }

	[XmlArray("Elements")]
	public ElementList Elements { get; set; }

	[XmlIgnore]
	public ISelectionProvider SelectionProvider { get; set; }

	[XmlIgnore]
	public bool DiagramLoaded { get; set; }

	public abstract string ClipboardFormatName { get; }

	[XmlIgnore]
	public NDrawingDocument Document
	{
		get
		{
			lock (this)
			{
				if (document == null)
				{
					LoadDocument();
				}
				return document;
			}
		}
	}

	public event EventHandler ElementInserted;

	public event EventHandler AfterElementInserted;

	public event EventHandler ElementRemoved;

	public Diagram()
	{
		Elements = new ElementList();
		Width = 1600f;
		Height = 1200f;
	}

	public void LoadDiagram()
	{
		lock (this)
		{
			foreach (Element element in Elements)
			{
				element.InputConnectors.Clear();
				element.OutputConnectors.Clear();
			}
			foreach (Connector item in Elements.Where((Element e) => e is Connector).Cast<Connector>())
			{
				item.StartElement = ((item.StartPlug != null) ? Elements[item.StartPlug.ElementUid] : null);
				if (item.StartElement != null)
				{
					item.StartElement.OutputConnectors.Add(item);
				}
				item.EndElement = ((item.EndPlug != null) ? Elements[item.EndPlug.ElementUid] : null);
				if (item.EndElement != null)
				{
					item.EndElement.InputConnectors.Add(item);
				}
			}
			DiagramLoaded = true;
		}
	}

	public void ReplaceElement(Element oldElement, Element newElement)
	{
		Contract.ArgumentNotNull(oldElement, "oldElement");
		Contract.ArgumentNotNull(newElement, "newElement");
		if (Elements.IndexOf(oldElement) < 0)
		{
			return;
		}
		bool flag = false;
		if (SelectionProvider != null && oldElement.Shape != null)
		{
			flag = SelectionProvider.IsNodeSelected((INNode)(object)oldElement.Shape);
		}
		((NService)((NDocument)document).get_HistoryService()).Pause();
		elementReplacing = true;
		try
		{
			Elements.Remove(oldElement);
			newElement.Uid = oldElement.Uid;
			NShape val = CreateElementShape(newElement);
			if (val != null)
			{
				document.get_ActiveLayer().AddChild((INNode)(object)val);
			}
			foreach (Connector inputConnector in oldElement.InputConnectors)
			{
				if (inputConnector.EndPlug != null)
				{
					inputConnector.EndElement = newElement;
					PlugConnectorShape(inputConnector, isStartPlug: false);
				}
			}
			foreach (Connector outputConnector in oldElement.OutputConnectors)
			{
				if (outputConnector.StartPlug != null)
				{
					outputConnector.StartElement = newElement;
					PlugConnectorShape(outputConnector, isStartPlug: true);
				}
			}
			oldElement.InputConnectors.Clear();
			oldElement.OutputConnectors.Clear();
			((NDiagramElement)oldElement.Shape).set_Tag((object)null);
			document.get_ActiveLayer().RemoveChild((INNode)(object)oldElement.Shape);
			if (flag && SelectionProvider != null && newElement.Shape != null)
			{
				SelectionProvider.SelectNode((INNode)(object)newElement.Shape);
			}
		}
		finally
		{
			elementReplacing = false;
			((NService)((NDocument)document).get_HistoryService()).Resume();
		}
	}

	public Image GetImage()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return new NImageExporter(Document).RenderToBitmap();
	}

	public Image GetImage(float scale)
	{
		Image image = GetImage();
		int width = (int)((float)image.Width * scale);
		int height = (int)((float)image.Height * scale);
		Bitmap bitmap = new Bitmap(width, height);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawImage(image, new Rectangle(0, 0, width, height));
		return bitmap;
	}

	protected virtual void LoadDocument()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		LoadDiagram();
		document = new NDrawingDocument();
		((NDocument)document).set_Tag((object)this);
		document.get_Settings().set_PastePositionMode((PastePositionMode)0);
		document.set_Width(Width);
		document.set_Height(Height);
		document.add_BoundsChanged(new NodeEventHandler(document_BoundsChanged));
		((CollectionBase)(object)((NDocument)document).get_DataObjectAdaptors()).Clear();
		CreateDataObjectAdaptors();
		SetDefaultDocumentStyles();
		document.get_RoutingManager().set_Enabled(false);
		document.get_BridgeManager().set_Enabled(false);
		foreach (Element element in Elements)
		{
			NShape val = CreateElementShape(element);
			if (val != null)
			{
				ExpandDiagramBoundsIfNeeded((NModel)(object)val);
				document.get_ActiveLayer().AddChild((INNode)(object)val);
			}
		}
		foreach (Connector item in Elements.Where((Element e) => e is Connector).Cast<Connector>())
		{
			PlugConnectorShape(item, isStartPlug: true);
			PlugConnectorShape(item, isStartPlug: false);
			ConnectorHV connectorHV = item as ConnectorHV;
			NShape shape = item.Shape;
			NRoutableConnector val2 = (NRoutableConnector)(object)((shape is NRoutableConnector) ? shape : null);
			if (connectorHV != null && val2 != null && connectorHV.Points != null)
			{
				((NPathShape)val2).set_Points(((IEnumerable<PointF>)connectorHV.Points).Select((Func<PointF, NPointF>)((PointF p) => new NPointF(p))).ToArray());
			}
		}
		document.get_RoutingManager().set_Enabled(true);
		document.get_BridgeManager().set_Enabled(true);
		document.get_BridgeManager().InvalidateAllBridges();
		document.get_RoutingManager().InvalidateRoutingGraphs();
		AttachToEvents();
	}

	private void document_BoundsChanged(NNodeEventArgs args)
	{
		Width = document.get_Width();
		Height = document.get_Height();
	}

	private void ExpandDiagramBoundsIfNeeded(NModel changedModel)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		NRectangleF bounds = changedModel.get_Bounds();
		if (((NRectangleF)(ref bounds)).get_Bottom() > document.get_Height() - 16f)
		{
			NDrawingDocument obj = document;
			bounds = changedModel.get_Bounds();
			obj.set_Height(((NRectangleF)(ref bounds)).get_Bottom() + 16f);
		}
		bounds = changedModel.get_Bounds();
		if (((NRectangleF)(ref bounds)).get_Right() > document.get_Width() - 16f)
		{
			NDrawingDocument obj2 = document;
			bounds = changedModel.get_Bounds();
			obj2.set_Width(((NRectangleF)(ref bounds)).get_Right() + 16f);
		}
	}

	protected virtual void SetDefaultDocumentStyles()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		INDiagramElement childByName = ((NDiagramElementCollection)document.get_StyleSheets()).GetChildByName(NDR.NameConnectorsStyleSheet, -1);
		NStyleSheet val = (NStyleSheet)(object)((childByName is NStyleSheet) ? childByName : null);
		NTextStyle val2 = new NTextStyle();
		val2.get_BackplaneStyle().set_Visible(true);
		val2.get_BackplaneStyle().get_StandardFrameStyle().set_InnerBorderWidth(new NLength(0));
		val.get_Style().set_TextStyle(val2);
		val.get_Style().set_StrokeStyle(new NStrokeStyle(1f, Color.Black));
		val.get_Style().get_StartArrowheadStyle().set_StrokeStyle(new NStrokeStyle(1f, Color.Black));
		val.get_Style().get_EndArrowheadStyle().set_StrokeStyle(new NStrokeStyle(1f, Color.Black));
		val = new NStyleSheet("SHAPE2D");
		val.get_Style().set_FillStyle((NFillStyle)new NColorFillStyle(Color.PapayaWhip));
		((NDiagramElementCollection)document.get_StyleSheets()).AddChild((INNode)(object)val);
		val = new NStyleSheet("ARROW", NDR.NameConnectorsStyleSheet);
		NTextStyle val3 = new NTextStyle();
		val3.get_FontStyle().InitFromFont(new Font("Segoe UI", 8f));
		val.get_Style().set_TextStyle(val3);
		((NDiagramElementCollection)document.get_StyleSheets()).AddChild((INNode)(object)val);
		NFrameStyle frameStyle = ((NDocument)document).get_BackgroundStyle().get_FrameStyle();
		NStandardFrameStyle val4 = (NStandardFrameStyle)(object)((frameStyle is NStandardFrameStyle) ? frameStyle : null);
		if (val4 != null)
		{
			val4.set_InnerBorderColor(Color.White);
			((NDocument)document).get_BackgroundStyle().set_FrameStyle((NFrameStyle)(object)val4);
		}
		if (document.get_RoutingManager() != null)
		{
			document.get_RoutingManager().set_MaxAvoidedGridObstacles(10000);
			document.get_RoutingManager().set_MaxAvoidedMeshObstacles(10000);
		}
	}

	protected virtual void CreateDataObjectAdaptors()
	{
		if (!string.IsNullOrEmpty(ClipboardFormatName))
		{
			DiagramClipboardAdaptor diagramClipboardAdaptor = new DiagramClipboardAdaptor(ClipboardFormatName);
			((NDocument)document).get_DataObjectAdaptors().Add((NDataObjectAdaptor)(object)diagramClipboardAdaptor);
		}
	}

	public virtual NShape CreateElementShape(Element element)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		ConnectorHV connectorHV = element as ConnectorHV;
		ShapeAttribute attribute = AttributeHelper<ShapeAttribute>.GetAttribute(element.GetType(), inherited: true);
		NShape val = null;
		if (connectorHV != null)
		{
			NPointF[] array = null;
			if (connectorHV.Points != null)
			{
				array = ((IEnumerable<PointF>)connectorHV.Points).Select((Func<PointF, NPointF>)((PointF p) => new NPointF(p))).ToArray();
			}
			NRoutableConnector val2 = ((attribute == null || !(attribute.ShapeType != null)) ? new NRoutableConnector(array) : ((array != null) ? ((NRoutableConnector)Activator.CreateInstance(attribute.ShapeType, array)) : ((NRoutableConnector)Activator.CreateInstance(attribute.ShapeType))));
			val = (NShape)(object)val2;
		}
		else if (attribute != null && attribute.ShapeType != null)
		{
			val = (NShape)Activator.CreateInstance(attribute.ShapeType);
		}
		if (val != null)
		{
			((NDiagramElement)val).set_Tag((object)element);
			val.set_Text(element.Name);
			element.Shape = val;
			if (element is Element2D element2D)
			{
				((NModel)val).SetBounds(new NRectangleF(element2D.Location.X, element2D.Location.Y, element2D.Size.Width, element2D.Size.Height));
			}
			ApplyShapeStyle(val);
		}
		return val;
	}

	protected virtual void ApplyShapeStyle(NShape shape)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (shape == null)
		{
			return;
		}
		NInteractionStyle interactionStyle = shape.get_InteractionStyle();
		((NInteractionStyle)(ref interactionStyle)).set_PinPoint(false);
		((NInteractionStyle)(ref interactionStyle)).set_Rotation(false);
		((NInteractionStyle)(ref interactionStyle)).set_ShapeControlPoints(false);
		((NInteractionStyle)(ref interactionStyle)).set_GeometryPoints(false);
		((NInteractionStyle)(ref interactionStyle)).set_Bounds(false);
		shape.set_InteractionStyle(interactionStyle);
		if (shape.get_Ports() != null)
		{
			shape.get_Ports().set_Visible(false);
		}
		NRoutableConnector val = (NRoutableConnector)(object)((shape is NRoutableConnector) ? shape : null);
		if (val != null)
		{
			val.set_RerouteAutomatically((RerouteAutomatically)2);
			NLabel defaultLabel = ((NShape)val).get_Labels().get_DefaultLabel();
			NLogicalLineLabel val2 = (NLogicalLineLabel)(object)((defaultLabel is NLogicalLineLabel) ? defaultLabel : null);
			if (val2 != null)
			{
				val2.set_UseLineOrientation(false);
			}
		}
	}

	public void PlugConnectorShape(Connector connector, bool isStartPlug)
	{
		if (connector.Shape == null)
		{
			return;
		}
		NPlug val = (NPlug)(isStartPlug ? ((object)connector.Shape.get_StartPlug()) : ((object)connector.Shape.get_EndPlug()));
		Plug plug = (isStartPlug ? connector.StartPlug : connector.EndPlug);
		if (plug == null || val == null)
		{
			return;
		}
		Element element = Elements[plug.ElementUid];
		if (element == null || element.Shape == null || element.Shape.get_Ports() == null)
		{
			return;
		}
		INDiagramElement childByName = ((NDiagramElementCollection)element.Shape.get_Ports()).GetChildByName(plug.PortName);
		NPort val2 = (NPort)(object)((childByName is NPort) ? childByName : null);
		if (val2 != null)
		{
			if (((NConnectionPoint)val).CanDisconnect())
			{
				((NConnectionPoint)val).Disconnect();
			}
			((NConnectionPoint)val).Connect(val2);
			if (element != null && element.Shape != null && ((NDiagramNode)connector.Shape).get_ZOrder() < ((NDiagramNode)element.Shape).get_ZOrder() && ((NDiagramNode)connector.Shape).get_ZOrder() >= 0)
			{
				((NDiagramNode)element.Shape).set_ZOrder(((NDiagramNode)connector.Shape).get_ZOrder());
			}
		}
	}

	protected virtual void AttachToEvents()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		((NNodeEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeInserted(new ChildNodeEventHandler(NodeInserted));
		((NNodeEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeRemoved(new ChildNodeEventHandler(NodeRemoved));
		((NNodeEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeRemoving(new ChildNodeCancelEventHandler(NodeRemoving));
		((NDiagramEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeBoundsChanged(new NodeEventHandler(NodeBoundsChanged));
		((NDiagramEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeBoundsChanging(new NodeBoundsCancelEventHandler(NodeBoundsChanging));
		((NNodeEventSinkService)((NDocument)document).get_EventSinkService()).add_NodePropertyChanged(new NodePropertyEventHandler(NodePropertyChanged));
		((NNodeEventSinkService)((NDocument)document).get_EventSinkService()).add_NodePropertyChanging(new NodePropertyCancelEventHandler(NodePropertyChanging));
		((NDocument)document).get_EventSinkService().add_Connected(new ConnectionEventHandler(NodeConnected));
		((NDocument)document).get_EventSinkService().add_Disconnecting(new ConnectionCancelEventHandler(NodeDisconnecting));
		((NDiagramEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeMouseEnter(new NodeViewEventHandler(NodeMouseEnter));
		((NDiagramEventSinkService)((NDocument)document).get_EventSinkService()).add_NodeMouseLeave(new NodeViewEventHandler(NodeMouseLeave));
	}

	protected virtual void DetatchFromEvents()
	{
	}

	protected void InvokeElementInserted(object sender, EventArgs e)
	{
		this.ElementInserted?.Invoke(sender, e);
	}

	protected void InvokeAfterElementInserted(object sender, EventArgs e)
	{
		this.AfterElementInserted?.Invoke(sender, e);
	}

	protected virtual void NodeInserted(NChildNodeEventArgs args)
	{
		ExtractShapeAndElement(args.Child, out var shape, out var element);
		if (shape != null && element != null)
		{
			ApplyShapeStyle(shape);
			if (Elements.Contains(element))
			{
				element = element.CopyElement();
				((NDiagramElement)shape).set_Tag((object)element);
			}
			element.Shape = shape;
			if (string.IsNullOrEmpty(element.Name))
			{
				element.GenerateName(this);
			}
			Elements.Add(element);
			shape.set_Text(element.Name);
			if (checkTypeGroupArtifact(element))
			{
				((NDiagramNode)shape).set_ZOrder(0);
				((NDiagramNode)shape).SendToBack();
			}
			InvokeElementInserted(element, EventArgs.Empty);
			UpdateElementBounds(element, shape, inserting: true);
			InvokeAfterElementInserted(element, EventArgs.Empty);
		}
	}

	public virtual bool checkTypeGroupArtifact(Element element)
	{
		return false;
	}

	protected void InvokeElementRemoved(object sender, EventArgs e)
	{
		this.ElementRemoved?.Invoke(sender, e);
	}

	protected virtual void NodeRemoving(NChildNodeCancelEventArgs args)
	{
	}

	protected virtual void NodeRemoved(NChildNodeEventArgs args)
	{
		ExtractShapeAndElement(args.Child, out var shape, out var element);
		if (shape == null || element == null)
		{
			return;
		}
		Elements.Remove(element);
		InvokeElementRemoved(element, EventArgs.Empty);
		if (element is Connector connector)
		{
			if (connector.StartElement != null && connector.StartElement.OutputConnectors.Contains(connector))
			{
				connector.StartElement.OutputConnectors.Remove(connector);
			}
			if (connector.EndElement != null && connector.EndElement.InputConnectors.Contains(connector))
			{
				connector.EndElement.InputConnectors.Remove(connector);
			}
		}
		foreach (Connector item in element.InputConnectors.ToList())
		{
			if (item.Shape != null && document.get_ActiveLayer().IndexOfChild((INNode)(object)item.Shape) >= 0)
			{
				document.get_ActiveLayer().RemoveChild((INNode)(object)item.Shape);
			}
		}
		foreach (Connector item2 in element.OutputConnectors.ToList())
		{
			if (item2.Shape != null && document.get_ActiveLayer().IndexOfChild((INNode)(object)item2.Shape) >= 0)
			{
				document.get_ActiveLayer().RemoveChild((INNode)(object)item2.Shape);
			}
		}
	}

	private void NodeBoundsChanging(NNodeBoundsCancelEventArgs args)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		ExtractShapeAndElement(((NNodeCancelEventArgs)args).Node, out var shape, out var element);
		if (shape != null && element != null)
		{
			ExpandDiagramBoundsIfNeeded((NModel)(object)shape);
			if (!CanChangeElementBounds(args.NewBounds, element, shape))
			{
				((CancelEventArgs)(object)args).Cancel = true;
			}
		}
	}

	private void NodeBoundsChanged(NNodeEventArgs args)
	{
		ExtractShapeAndElement(args.Node, out var shape, out var element);
		if (shape != null && element != null)
		{
			ExpandDiagramBoundsIfNeeded((NModel)(object)shape);
			ElementBoundsChanged(element, shape);
		}
	}

	protected virtual void ElementBoundsChanged(Element element, NShape shape)
	{
		UpdateElementBounds(element, shape, inserting: false);
	}

	public virtual bool CanChangeElementBounds(NRectangleF rect, Element element, NShape shape)
	{
		return true;
	}

	protected virtual void NodePropertyChanged(NNodePropertyEventArgs args)
	{
		INNode val = ((NNodeEventArgs)args).Node;
		while (val != null && !(val is NShape))
		{
			val = val.get_ParentNode();
		}
		ExtractShapeAndElement(val, out var shape, out var element);
		if (shape != null && element != null && args.PropertyName == "Text")
		{
			element.Name = shape.get_Text();
		}
	}

	protected virtual void NodePropertyChanging(NNodePropertyCancelEventArgs args)
	{
	}

	protected virtual void NodeConnected(NConnectionEventArgs args)
	{
		NShape nodeShape = GetNodeShape((INNode)(object)((NDocumentEventArgs)args).Document.GetElementFromUniqueId(args.UniqueId1));
		NRoutableConnector val = (NRoutableConnector)(object)((nodeShape is NRoutableConnector) ? nodeShape : null);
		NShape nodeShape2 = GetNodeShape((INNode)(object)((NDocumentEventArgs)args).Document.GetElementFromUniqueId(args.UniqueId2));
		NRoutableConnector val2 = (NRoutableConnector)(object)((nodeShape2 is NRoutableConnector) ? nodeShape2 : null);
		if (val != null)
		{
			val.Reroute();
		}
		if (val2 != null)
		{
			val2.Reroute();
		}
	}

	private void NodeDisconnecting(NConnectionCancelEventArgs args)
	{
		if (!elementReplacing && (((NList)((NElementHistoryService)((NDocument)document).get_HistoryService()).get_TransactionStack()).get_Count() <= 1 || !(((NOperationList)((NElementHistoryService)((NDocument)document).get_HistoryService()).get_TransactionStack()).get_Item(((NList)((NElementHistoryService)((NDocument)document).get_HistoryService()).get_TransactionStack()).get_Count() - 1).get_Description() == NDR.TransactionDisconnectPoints) || !(((NOperationList)((NElementHistoryService)((NDocument)document).get_HistoryService()).get_TransactionStack()).get_Item(((NList)((NElementHistoryService)((NDocument)document).get_HistoryService()).get_TransactionStack()).get_Count() - 2).get_Description() == NDR.TransactionConnectPoints)))
		{
			((CancelEventArgs)(object)args).Cancel = true;
		}
	}

	protected NShape GetNodeShape(INNode node)
	{
		if (node == null)
		{
			return null;
		}
		while (node != null && !(node is NShape))
		{
			node = node.get_ParentNode();
		}
		return (NShape)(object)((node is NShape) ? node : null);
	}

	protected virtual void NodeMouseEnter(NNodeViewEventArgs args)
	{
	}

	protected virtual void NodeMouseLeave(NNodeViewEventArgs args)
	{
	}

	protected void ExtractShapeAndElement(INNode node, out NShape shape, out Element element)
	{
		shape = (NShape)(object)((node is NShape) ? node : null);
		element = null;
		if (shape != null)
		{
			element = ((NDiagramElement)shape).get_Tag() as Element;
		}
	}

	protected Plug ConvertPlug(NPlug nPlug)
	{
		if (nPlug != null && ((NConnectionPoint)nPlug).get_InwardPort() != null)
		{
			NShape shape = ((NShapePoint)((NConnectionPoint)nPlug).get_InwardPort()).get_Shape();
			if (shape != null && ((NDiagramElement)shape).get_Tag() is Element element)
			{
				return new Plug
				{
					ElementUid = element.Uid,
					PortName = ((NDiagramElement)((NConnectionPoint)nPlug).get_InwardPort()).get_Name()
				};
			}
		}
		return null;
	}

	protected PointF[] ConvertPoints(NPointF[] points)
	{
		if (points == null)
		{
			return new PointF[0];
		}
		return points.Select((NPointF p) => new PointF(p.X, p.Y)).ToArray();
	}

	protected virtual void UpdateElementBounds(Element element, NShape shape, bool inserting)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (shape != null && element != null)
		{
			if (element is Element2D element2D)
			{
				element2D.Location = new PointF(((NModel)shape).get_Bounds().X, ((NModel)shape).get_Bounds().Y);
				element2D.Size = new SizeF(((NModel)shape).get_Bounds().Width, ((NModel)shape).get_Bounds().Height);
			}
			if (element is Connector connector)
			{
				UpdateConnectorBounds(connector);
				UpdateConnectorPlugs(connector, isStartPlug: true);
				UpdateConnectorPlugs(connector, isStartPlug: false);
			}
		}
	}

	protected virtual void UpdateConnectorBounds(Connector connector)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		NShape shape = connector.Shape;
		if (connector is ConnectorHV && shape is NRoutableConnector)
		{
			((ConnectorHV)connector).Points = ConvertPoints(((NPathShape)(NRoutableConnector)shape).get_Points());
		}
	}

	protected virtual void UpdateConnectorPlugs(Connector connector, bool isStartPlug)
	{
		NShape shape = connector.Shape;
		Plug plug = ConvertPlug((NPlug)(isStartPlug ? ((object)shape.get_StartPlug()) : ((object)shape.get_EndPlug())));
		Plug plug2 = (isStartPlug ? connector.StartPlug : connector.EndPlug);
		if ((plug == null && plug2 != null) || (plug != null && plug2 == null) || (plug != null && plug2 != null && (plug.ElementUid != plug2.ElementUid || plug.PortName != plug2.PortName)))
		{
			if (isStartPlug)
			{
				connector.StartPlug = plug;
				connector.StartElement = ((plug != null) ? Elements[plug.ElementUid] : null);
				if (connector.StartElement != null && connector.StartElement.Shape != null && ((NDiagramNode)shape).get_ZOrder() < ((NDiagramNode)connector.StartElement.Shape).get_ZOrder())
				{
					((NDiagramNode)connector.StartElement.Shape).set_ZOrder(((NDiagramNode)shape).get_ZOrder());
				}
			}
			else
			{
				connector.EndPlug = plug;
				connector.EndElement = ((plug != null) ? Elements[plug.ElementUid] : null);
			}
			OnConnectorPlugChanged(connector, plug2, isStartPlug);
		}
		else if (plug2 != null && plug != null && plug2.ElementUid == plug.ElementUid && (isStartPlug ? connector.StartElement : connector.EndElement) != null)
		{
			List<Connector> list = (isStartPlug ? connector.StartElement.OutputConnectors : connector.EndElement.InputConnectors);
			if (!list.Contains(connector))
			{
				list.Add(connector);
			}
		}
	}

	protected virtual void OnConnectorPlugChanged(Connector connector, Plug oldPlug, bool isStartPlug)
	{
		Plug plug = (isStartPlug ? connector.StartPlug : connector.EndPlug);
		if (oldPlug != null)
		{
			Element element = Elements[oldPlug.ElementUid];
			if (element != null)
			{
				(isStartPlug ? element.OutputConnectors : element.InputConnectors).Remove(connector);
			}
		}
		if (plug != null)
		{
			Element element2 = Elements[plug.ElementUid];
			if (element2 != null)
			{
				(isStartPlug ? element2.OutputConnectors : element2.InputConnectors).Add(connector);
			}
		}
	}

	protected Diagram(SerializationInfo info, StreamingContext context)
	{
		string xml = (string)info.GetValue("Diagram", typeof(string));
		object obj = ClassSerializationHelper.DeserializeObjectByXml(GetType(), xml);
		if (obj == null)
		{
			return;
		}
		foreach (PropertyInfo item in from p in obj.GetType().GetProperties()
			where p.CanRead && p.CanWrite && AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) == null
			select p)
		{
			item.SetValue(this, item.GetValue(obj, null), null);
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Diagram", ClassSerializationHelper.SerializeObjectByXml(this));
	}
}
