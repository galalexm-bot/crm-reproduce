using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Diagrams;

[Serializable]
public class Connector : Element
{
	[XmlElement("StartPlug")]
	public Plug StartPlug { get; set; }

	[XmlElement("EndPlug")]
	public Plug EndPlug { get; set; }

	[XmlIgnore]
	public Element StartElement { get; set; }

	[XmlIgnore]
	public Element EndElement { get; set; }

	public override void OnCopied(Dictionary<Guid, Element> copiedElements = null)
	{
		base.OnCopied(copiedElements);
		Func<Plug, Element> func = delegate(Plug plug)
		{
			Element value = null;
			if (copiedElements != null)
			{
				copiedElements.TryGetValue(plug.ElementUid, out value);
			}
			return value;
		};
		if (StartPlug != null)
		{
			StartElement = func(StartPlug);
			if (StartElement != null)
			{
				StartPlug.ElementUid = StartElement.Uid;
			}
			else
			{
				StartPlug = null;
			}
		}
		if (EndPlug != null)
		{
			EndElement = func(EndPlug);
			if (EndElement != null)
			{
				EndPlug.ElementUid = EndElement.Uid;
			}
			else
			{
				EndPlug = null;
			}
		}
	}
}
