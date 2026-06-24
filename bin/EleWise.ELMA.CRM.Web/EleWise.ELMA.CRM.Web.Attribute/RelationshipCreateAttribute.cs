using System;

namespace EleWise.ELMA.CRM.Web.Attributes;

public class RelationshipCreateAttribute : Attribute
{
	public string Name { get; set; }

	public string ImageUrl { get; set; }

	public string SmallImageUrl { get; set; }

	public bool ToActions { get; set; }

	public RelationshipCreateAttribute()
	{
		ToActions = false;
	}
}
