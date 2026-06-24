using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Orchard.Data.Bags.Serialization;

public class XmlSettingsSerializer : IBagSerializer, IDependency
{
	private const string Root = "Bag";

	public void Serialize(TextWriter tw, Bag o)
	{
		using XmlTextWriter xmlTextWriter = new XmlTextWriter(tw);
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("Bag");
		WriteGrappe(xmlTextWriter, o);
		xmlTextWriter.WriteEndDocument();
	}

	public Bag Deserialize(TextReader tr)
	{
		XmlTextReader xmlTextReader = new XmlTextReader(tr);
		Bag bag = new Bag();
		while (xmlTextReader.MoveToContent() == XmlNodeType.Element && xmlTextReader.LocalName == "Bag")
		{
			xmlTextReader.Read();
		}
		while (xmlTextReader.MoveToContent() == XmlNodeType.Element)
		{
			ReadElement(xmlTextReader, bag);
		}
		return bag;
	}

	private void ReadElement(XmlReader reader, Bag parent)
	{
		string name = XmlConvert.DecodeName(reader.LocalName);
		string text = reader["type"];
		if (text != null)
		{
			if (text == "Array")
			{
				parent.SetMember(name, ReadArray(reader));
				reader.Read();
			}
			else
			{
				SValue value = SConvert.XmlDecode((TypeCode)Enum.Parse(typeof(TypeCode), text), reader.ReadElementString());
				parent.SetMember(name, value);
			}
			return;
		}
		Bag bag = new Bag();
		reader.Read();
		parent.SetMember(name, bag);
		while (reader.MoveToContent() == XmlNodeType.Element)
		{
			ReadElement(reader, bag);
		}
		reader.Read();
	}

	public SArray ReadArray(XmlReader reader)
	{
		List<object> list = new List<object>();
		reader.Read();
		while (reader.MoveToContent() == XmlNodeType.Element && reader.LocalName == "Item")
		{
			dynamic val = new Bag();
			ReadElement(reader, val);
			list.Add(val.Item);
		}
		return new SArray(list.ToArray());
	}

	private void WriteGrappe(XmlWriter writer, Bag grappe)
	{
		foreach (KeyValuePair<string, ISItem> property in grappe._properties)
		{
			WriteAny(writer, property.Key, property.Value);
		}
	}

	private void WriteAny(XmlWriter writer, string name, object value)
	{
		if (value is Bag)
		{
			writer.WriteStartElement(XmlConvert.EncodeLocalName(name));
			WriteGrappe(writer, (Bag)value);
			writer.WriteEndElement();
		}
		if (value is SArray)
		{
			writer.WriteStartElement(XmlConvert.EncodeLocalName(name));
			writer.WriteAttributeString("type", "Array");
			ISItem[] values = ((SArray)value).Values;
			foreach (ISItem value2 in values)
			{
				WriteAny(writer, "Item", value2);
			}
			writer.WriteEndElement();
		}
		else if (value is SValue)
		{
			SValue sValue = (SValue)value;
			writer.WriteStartElement(XmlConvert.EncodeLocalName(name));
			writer.WriteAttributeString("type", Type.GetTypeCode(sValue.Value.GetType()).ToString());
			writer.WriteString(SConvert.XmlEncode(sValue.Value));
			writer.WriteEndElement();
		}
	}
}
