using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class AttachmentWrapper : Entity
{
	private BinaryFile _003CFile_003Ek__BackingField;

	private UserWrapper _003CCreationAuthor_003Ek__BackingField;

	private System.DateTime? _003CCreationDate_003Ek__BackingField;

	public BinaryFile File
	{
		get
		{
			return _003CFile_003Ek__BackingField;
		}
		set
		{
			_003CFile_003Ek__BackingField = value;
		}
	}

	public UserWrapper CreationAuthor
	{
		get
		{
			return _003CCreationAuthor_003Ek__BackingField;
		}
		set
		{
			_003CCreationAuthor_003Ek__BackingField = value;
		}
	}

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

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
