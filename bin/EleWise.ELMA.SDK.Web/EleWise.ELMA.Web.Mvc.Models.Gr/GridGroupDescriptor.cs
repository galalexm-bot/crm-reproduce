using System;
using System.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Models.Grids;

[Serializable]
public class GridGroupDescriptor : IEquatable<GridGroupDescriptor>, ICloneable
{
	public string Member { get; set; }

	public ListSortDirection SortDirection { get; set; }

	public override bool Equals(object obj)
	{
		return Equals(obj as GridGroupDescriptor);
	}

	public bool Equals(GridGroupDescriptor other)
	{
		if (other != null && Member == other.Member)
		{
			return SortDirection == other.SortDirection;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Member != null) ? Member.GetHashCode() : 0) * 397) ^ (int)SortDirection;
	}

	public object Clone()
	{
		return new GridGroupDescriptor
		{
			Member = Member,
			SortDirection = SortDirection
		};
	}
}
