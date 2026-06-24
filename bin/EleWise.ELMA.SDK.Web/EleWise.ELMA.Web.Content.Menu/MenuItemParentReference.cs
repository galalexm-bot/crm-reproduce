using System;

namespace EleWise.ELMA.Web.Content.Menu;

[Serializable]
public class MenuItemParentReference
{
	public string Code { get; set; }

	public ContentActionReference Action { get; set; }

	public override string ToString()
	{
		return $"Code: {Code}, Action: ({Action})";
	}

	public override bool Equals(object obj)
	{
		if (!(obj is MenuItemParentReference menuItemParentReference))
		{
			return this == obj;
		}
		if (Code == menuItemParentReference.Code)
		{
			if (Action != null)
			{
				return Action.Equals(menuItemParentReference.Action);
			}
			return menuItemParentReference.Action == null;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((Code != null) ? Code.GetHashCode() : 0) * 397) ^ ((Action != null) ? Action.GetHashCode() : 0);
	}
}
