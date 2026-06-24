using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EleWise.ELMA.Serialization;
using Nevron;
using Nevron.Diagram;
using Nevron.Reflection;

namespace EleWise.ELMA.Diagrams.Adaptors;

[Serializable]
public class DiagramClipboardAdaptor : NDataObjectAdaptor
{
	[NonSerialized]
	[NReferenceField]
	private NDrawingDocument document;

	private readonly string format;

	public NDrawingDocument Document => document;

	public Diagram Diagram
	{
		get
		{
			if (document == null)
			{
				return null;
			}
			return ((NDocument)document).get_Tag() as Diagram;
		}
	}

	public DiagramClipboardAdaptor(string format)
	{
		this.format = format;
	}

	public override void UpdateReferences(INReferenceProvider provider)
	{
		if (provider != null)
		{
			ref NDrawingDocument reference = ref document;
			object obj = provider.ProvideReference(typeof(NDrawingDocument));
			reference = (NDrawingDocument)((obj is NDrawingDocument) ? obj : null);
		}
		else
		{
			document = null;
		}
		((NDataObjectAdaptor)this).UpdateReferences(provider);
	}

	public override bool CanAdapt(IDataObject dataObject)
	{
		return dataObject.GetDataPresent(format);
	}

	public override object Adapt(IDataObject dataObject)
	{
		if (!((NDataObjectAdaptor)this).CanAdapt(dataObject))
		{
			return null;
		}
		if (dataObject.GetDataPresent(format))
		{
			if (!(dataObject.GetData(format) is DiagramClipboardDataHolder obj))
			{
				return null;
			}
			return AdaptShapeDescriptor(ClassSerializationHelper.CloneObjectByXml(obj));
		}
		return null;
	}

	protected virtual NDrawingDataObject AdaptShapeDescriptor(DiagramClipboardDataHolder holder)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		if (holder == null || holder.Elements == null || holder.Elements.Count == 0 || Diagram == null)
		{
			return null;
		}
		List<INDiagramElement> list = new List<INDiagramElement>();
		Dictionary<Guid, Element> dictionary = new Dictionary<Guid, Element>();
		foreach (Element element in holder.Elements)
		{
			dictionary[element.Uid] = element;
			element.Uid = Guid.NewGuid();
		}
		foreach (Element element2 in holder.Elements)
		{
			element2.OnCopied(dictionary);
			NShape item = Diagram.CreateElementShape(element2);
			list.Add((INDiagramElement)(object)item);
		}
		NDrawingDataObject val = new NDrawingDataObject((NDrawingDocument)null, list.ToArray());
		val.set_DocumentUniqueId(holder.DocumentUniqueId);
		return val;
	}
}
