using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class CustomColumnDescriptor : ICloneable
{
	[OptionalField]
	private string sortExpression;

	[OptionalField]
	private bool visible;

	public string UniqueName { get; set; }

	public string DisplayName { get; set; }

	public bool Sortable { get; set; }

	public string SortExpression
	{
		get
		{
			return sortExpression;
		}
		set
		{
			sortExpression = value;
		}
	}

	public bool Visible
	{
		get
		{
			return visible;
		}
		set
		{
			visible = value;
		}
	}

	public string GetDisplayName()
	{
		return SR.T(DisplayName);
	}

	public object Clone()
	{
		return new CustomColumnDescriptor
		{
			UniqueName = UniqueName,
			DisplayName = DisplayName,
			Sortable = Sortable,
			SortExpression = SortExpression,
			Visible = Visible
		};
	}
}
