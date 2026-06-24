using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class DocumentAttachmentWrapper : Entity
{
	private DocumentWrapper _003CDocument_003Ek__BackingField;

	private UserWrapper _003CCreationAuthor_003Ek__BackingField;

	private System.DateTime? _003CCreationDate_003Ek__BackingField;

	public DocumentWrapper Document
	{
		get
		{
			return _003CDocument_003Ek__BackingField;
		}
		set
		{
			_003CDocument_003Ek__BackingField = value;
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
