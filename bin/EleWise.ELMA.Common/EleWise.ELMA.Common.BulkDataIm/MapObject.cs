using System;
using EleWise.ELMA.Common.BulkDataImport.Exceptions;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapObject
{
	private object target;

	protected MapObject DelegateObject;

	public Type ObjectType { get; private set; }

	public object Target
	{
		get
		{
			if (DelegateObject != null)
			{
				return DelegateObject.Target;
			}
			return target;
		}
		set
		{
			if (DelegateObject == null)
			{
				target = value;
			}
			else
			{
				DelegateObject.Target = value;
			}
		}
	}

	public MapObject(Type objectType)
	{
		ObjectType = objectType;
	}

	public void SetDelegate(MapObject delegateObject)
	{
		if (delegateObject != null && (delegateObject.ObjectType != ObjectType || delegateObject.GetType() != GetType()))
		{
			throw new MapObjectInvalidWrongException(SR.T("Нельзя установить замещающий объект другого типа"));
		}
		DelegateObject = delegateObject;
	}

	public virtual bool IsEmpty()
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		if (DelegateObject == null)
		{
			return base.Equals(obj);
		}
		return DelegateObject.Equals(obj);
	}

	public override int GetHashCode()
	{
		if (DelegateObject == null)
		{
			return base.GetHashCode();
		}
		return DelegateObject.GetHashCode();
	}

	public override string ToString()
	{
		return ObjectType.Name;
	}
}
