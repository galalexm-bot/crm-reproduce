using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Serialization;
using Nevron.Diagram;

namespace EleWise.ELMA.Diagrams;

[Serializable]
[XmlRoot("Element")]
[Component(InjectProerties = false)]
public class Element : ICloneable, IElement, IXsiType
{
	private List<Connector> outputConnectors = new List<Connector>();

	private List<Connector> inputConnectors = new List<Connector>();

	private NShape shape;

	private string name = "";

	[XmlAttribute("Uid")]
	public Guid Uid { get; set; }

	[XmlElement("Name")]
	[DefaultValue("")]
	public virtual string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (!(name == value))
			{
				name = value;
				if (shape != null && shape.get_Text() != value)
				{
					shape.set_Text(value);
				}
			}
		}
	}

	[XmlIgnore]
	public string LocalizableName => SR.T(Name);

	[XmlElement("Description")]
	[DefaultValue("")]
	public string Description { get; set; }

	[XmlIgnore]
	public string LocalizableDescription => SR.T(Description);

	[XmlArray]
	public ElementExtendedSettings ExtendedSettings { get; set; }

	[XmlIgnore]
	public NShape Shape
	{
		get
		{
			return shape;
		}
		set
		{
			if (shape != value)
			{
				NShape oldShape = shape;
				shape = value;
				OnShapeChanged(oldShape, shape);
			}
		}
	}

	[XmlIgnore]
	public List<Connector> OutputConnectors
	{
		get
		{
			return outputConnectors;
		}
		set
		{
		}
	}

	[XmlIgnore]
	public List<Connector> InputConnectors
	{
		get
		{
			return inputConnectors;
		}
		set
		{
		}
	}

	[XmlIgnore]
	public virtual bool OutputCancel => false;

	[XmlIgnore]
	public virtual bool ValidateContextVariables => true;

	public virtual string DefaultName => null;

	public virtual bool IsDefaultNameWithIncrement => true;

	public Element()
	{
		Description = "";
		ExtendedSettings = new ElementExtendedSettings();
	}

	public virtual void InitNew()
	{
		Uid = Guid.NewGuid();
	}

	public virtual object Clone()
	{
		return this;
	}

	public Element CopyElement()
	{
		Element element = ClassSerializationHelper.CloneObjectByXml(this);
		element.Uid = Guid.NewGuid();
		element.OnCopied();
		return element;
	}

	public virtual void GenerateName(Diagram diagram)
	{
		if (string.IsNullOrEmpty(DefaultName))
		{
			return;
		}
		if (IsDefaultNameWithIncrement)
		{
			int num = 0;
			string name = null;
			while (name == null || diagram.Elements.Any((Element e) => e.Name == name))
			{
				num++;
				name = DefaultName + " " + num;
			}
			Name = name;
		}
		else
		{
			Name = DefaultName;
		}
	}

	public void CopyFrom(Element element)
	{
		if (element == null)
		{
			return;
		}
		PropertyInfo[] properties = element.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			PropertyInfo property = GetType().GetProperty(propertyInfo.Name);
			if (property != null && property.CanWrite && propertyInfo.CanRead && property.PropertyType.IsAssignableFrom(propertyInfo.PropertyType))
			{
				object value = propertyInfo.GetValue(element, null);
				property.SetValue(this, value, null);
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(Name))
		{
			return base.ToString();
		}
		return Name;
	}

	public virtual void OnCopied(Dictionary<Guid, Element> copiedElements = null)
	{
		Uid = Guid.NewGuid();
		if (copiedElements != null)
		{
			Func<List<Connector>, List<Connector>> func = (List<Connector> list) => (from c in list.Select(delegate(Connector c)
				{
					copiedElements.TryGetValue(c.Uid, out var value);
					return value as Connector;
				})
				where c != null
				select c).ToList();
			inputConnectors = func(InputConnectors);
			outputConnectors = func(OutputConnectors);
		}
		else
		{
			InputConnectors.Clear();
			OutputConnectors.Clear();
		}
	}

	protected virtual void OnShapeChanged(NShape oldShape, NShape newShape)
	{
		if (newShape != null && newShape.get_Text() != name)
		{
			newShape.set_Text(name);
		}
	}
}
