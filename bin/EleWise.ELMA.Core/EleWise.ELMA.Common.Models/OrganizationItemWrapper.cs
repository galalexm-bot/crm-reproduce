using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class OrganizationItemWrapper : Entity
{
	private OrganizationItemWrapper _003CParentItem_003Ek__BackingField;

	public OrganizationItemWrapper ParentItem
	{
		get
		{
			return _003CParentItem_003Ek__BackingField;
		}
		set
		{
			_003CParentItem_003Ek__BackingField = value;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
