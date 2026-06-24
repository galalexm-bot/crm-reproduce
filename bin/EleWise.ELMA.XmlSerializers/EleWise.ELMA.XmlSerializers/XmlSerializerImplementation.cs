using System;
using System.Collections;

namespace EleWise.ELMA.XmlSerializers;

public abstract class XmlSerializerImplementation
{
	public virtual XmlSerializationReader Reader
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public virtual XmlSerializationWriter Writer
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public virtual Hashtable ReadMethods
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public virtual Hashtable WriteMethods
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public virtual Hashtable TypedSerializers
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public virtual bool CanSerialize(Type type)
	{
		throw new NotSupportedException();
	}

	public virtual XmlSerializer GetSerializer(Type type)
	{
		throw new NotSupportedException();
	}
}
