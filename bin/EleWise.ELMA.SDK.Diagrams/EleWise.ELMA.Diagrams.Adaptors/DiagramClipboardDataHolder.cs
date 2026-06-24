using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Diagrams.Adaptors;

[Serializable]
public class DiagramClipboardDataHolder : ISerializable
{
	public Guid DocumentUniqueId { get; set; }

	public List<Element> Elements { get; set; }

	public DiagramClipboardDataHolder()
	{
		Elements = new List<Element>();
	}

	protected DiagramClipboardDataHolder(SerializationInfo info, StreamingContext context)
	{
		DiagramClipboardDataHolder diagramClipboardDataHolder = ClassSerializationHelper.DeserializeObjectByXml<DiagramClipboardDataHolder>(info.GetString("Elements"));
		DocumentUniqueId = diagramClipboardDataHolder.DocumentUniqueId;
		Elements = diagramClipboardDataHolder.Elements;
	}

	public void SaveToClipboard(string format)
	{
		try
		{
			DataObject dataObject = new DataObject();
			dataObject.SetData(format, this);
			Clipboard.SetDataObject(dataObject, copy: false);
		}
		catch (Exception exception)
		{
			Logger.Log.Warn("Clipboard error", exception);
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("Elements", ClassSerializationHelper.SerializeObjectByXml(this));
	}
}
