using System;
using System.ComponentModel;
using System.Configuration;

namespace EleWise.ELMA.CAB.Configuration;

public class ServiceElement : ParametersElement
{
	[ConfigurationProperty("serviceType", IsKey = true, IsRequired = true)]
	[TypeConverter(typeof(TypeNameConverter))]
	public Type ServiceType
	{
		get
		{
			return (Type)base["serviceType"];
		}
		set
		{
			base["serviceType"] = value;
		}
	}

	[ConfigurationProperty("instanceType", IsRequired = true)]
	[TypeConverter(typeof(TypeNameConverter))]
	public Type InstanceType
	{
		get
		{
			return (Type)base["instanceType"];
		}
		set
		{
			base["instanceType"] = value;
		}
	}
}
