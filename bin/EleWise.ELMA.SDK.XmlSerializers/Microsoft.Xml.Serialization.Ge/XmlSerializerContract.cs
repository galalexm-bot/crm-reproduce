using System;
using System.Collections;
using System.Xml.Serialization;
using EleWise.ELMA.Runtime.Cache;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public class XmlSerializerContract : XmlSerializerImplementation
{
	private Hashtable readMethods;

	private Hashtable writeMethods;

	private Hashtable typedSerializers;

	public override XmlSerializationReader Reader => new XmlSerializationReaderApplicationStartCache();

	public override XmlSerializationWriter Writer => new XmlSerializationWriterApplicationStartCache();

	public override Hashtable ReadMethods
	{
		get
		{
			if (readMethods == null)
			{
				Hashtable hashtable = new Hashtable();
				hashtable["EleWise.ELMA.Runtime.Cache.ApplicationStartCache::"] = "Read6_ApplicationStartCache";
				if (readMethods == null)
				{
					readMethods = hashtable;
				}
			}
			return readMethods;
		}
	}

	public override Hashtable WriteMethods
	{
		get
		{
			if (writeMethods == null)
			{
				Hashtable hashtable = new Hashtable();
				hashtable["EleWise.ELMA.Runtime.Cache.ApplicationStartCache::"] = "Write5_ApplicationStartCache";
				if (writeMethods == null)
				{
					writeMethods = hashtable;
				}
			}
			return writeMethods;
		}
	}

	public override Hashtable TypedSerializers
	{
		get
		{
			if (typedSerializers == null)
			{
				Hashtable hashtable = new Hashtable();
				hashtable.Add("EleWise.ELMA.Runtime.Cache.ApplicationStartCache::", new ApplicationStartCacheSerializer());
				if (typedSerializers == null)
				{
					typedSerializers = hashtable;
				}
			}
			return typedSerializers;
		}
	}

	public override bool CanSerialize(Type type)
	{
		if (type == typeof(ApplicationStartCache))
		{
			return true;
		}
		return false;
	}

	public override XmlSerializer GetSerializer(Type type)
	{
		if (type == typeof(ApplicationStartCache))
		{
			return new ApplicationStartCacheSerializer();
		}
		return null;
	}
}
