using System;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class ObjectId : MapObject
{
	private object id;

	private bool saved;

	public object Id
	{
		get
		{
			if (DelegateObject != null)
			{
				return ((ObjectId)DelegateObject).Id;
			}
			return id;
		}
		set
		{
			if (DelegateObject == null)
			{
				id = value;
			}
			else
			{
				((ObjectId)DelegateObject).Id = value;
			}
		}
	}

	public bool Saved
	{
		get
		{
			if (DelegateObject != null)
			{
				return ((ObjectId)DelegateObject).Saved;
			}
			return saved;
		}
		set
		{
			if (DelegateObject == null)
			{
				saved = value;
			}
			else
			{
				((ObjectId)DelegateObject).Saved = value;
			}
		}
	}

	public ObjectId(Type objectType)
		: base(objectType)
	{
	}

	public override bool IsEmpty()
	{
		return Id == null;
	}

	public override string ToString()
	{
		return string.Format("{0}: {1}", base.ObjectType.Name, Id ?? "null");
	}
}
