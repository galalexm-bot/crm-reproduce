using System.Collections.Generic;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapRelationManyToMany : MapObject
{
	private Relation relation;

	private IList<MapObject> objects;

	public Relation Relation
	{
		get
		{
			if (DelegateObject != null)
			{
				return ((MapRelationManyToMany)DelegateObject).Relation;
			}
			return relation;
		}
		set
		{
			if (DelegateObject == null)
			{
				relation = value;
			}
			else
			{
				((MapRelationManyToMany)DelegateObject).Relation = value;
			}
		}
	}

	public IList<MapObject> Objects
	{
		get
		{
			if (DelegateObject != null)
			{
				return ((MapRelationManyToMany)DelegateObject).Objects;
			}
			return objects;
		}
		private set
		{
			if (DelegateObject == null)
			{
				objects = value;
			}
			else
			{
				((MapRelationManyToMany)DelegateObject).Objects = value;
			}
		}
	}

	public MapRelationManyToMany(Relation relation, IList<MapObject> objects)
		: base(relation.TargetObject.ObjectType)
	{
		Objects = objects;
		Relation = relation;
	}

	public override bool IsEmpty()
	{
		if (Objects != null)
		{
			return Objects.Count == 0;
		}
		return true;
	}

	public override string ToString()
	{
		return string.Format("{0}: (Relation: {1})", base.ObjectType.Name, (Objects != null) ? Objects.Count.ToString() : "null");
	}
}
