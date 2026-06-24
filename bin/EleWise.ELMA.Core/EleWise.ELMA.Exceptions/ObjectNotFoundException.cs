using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Exceptions;

public class ObjectNotFoundException : SystemException
{
	private readonly string _003CObjectName_003Ek__BackingField;

	private readonly object _003CObjectId_003Ek__BackingField;

	public string ObjectName => _003CObjectName_003Ek__BackingField;

	public object ObjectId => _003CObjectId_003Ek__BackingField;

	protected static string MessageNamedObjectNotFound => SR.T("Объект \"{0}\" не найден");

	protected static string MessageObjectNotFound => SR.T("Объект не найден");

	public ObjectNotFoundException()
		: base(MessageObjectNotFound)
	{
	}

	public ObjectNotFoundException(string objectName)
		: this(objectName, string.Format(MessageNamedObjectNotFound, (object)objectName))
	{
	}

	public ObjectNotFoundException(string objectName, string message)
		: base(message)
	{
		_003CObjectName_003Ek__BackingField = objectName;
	}

	public ObjectNotFoundException(string objectName, object objectId)
		: this(objectName, objectId, string.Format(MessageNamedObjectNotFound, (object)string.Concat((object)objectName, (object)":", objectId)))
	{
	}

	public ObjectNotFoundException(string objectName, object objectId, string message)
		: base(message)
	{
		_003CObjectName_003Ek__BackingField = objectName;
		_003CObjectId_003Ek__BackingField = objectId;
	}
}
