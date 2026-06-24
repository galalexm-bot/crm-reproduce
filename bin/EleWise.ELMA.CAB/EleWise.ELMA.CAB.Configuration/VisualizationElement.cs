using System;
using System.ComponentModel;
using System.Configuration;

namespace EleWise.ELMA.CAB.Configuration;

public class VisualizationElement : ConfigurationElement
{
	[TypeConverter(typeof(TypeNameConverter))]
	[ConfigurationProperty("type", IsKey = true, IsRequired = true)]
	public Type Type
	{
		get
		{
			return (Type)base["type"];
		}
		set
		{
			base["type"] = value;
		}
	}
}
