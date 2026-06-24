using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class DocumentWrapper : Entity
{
	private System.DateTime? _003CCreationDate_003Ek__BackingField;

	private Entity _003CCurrentVersion_003Ek__BackingField;

	public System.DateTime? CreationDate
	{
		get
		{
			return _003CCreationDate_003Ek__BackingField;
		}
		set
		{
			_003CCreationDate_003Ek__BackingField = value;
		}
	}

	public Entity CurrentVersion
	{
		get
		{
			return _003CCurrentVersion_003Ek__BackingField;
		}
		set
		{
			_003CCurrentVersion_003Ek__BackingField = value;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
