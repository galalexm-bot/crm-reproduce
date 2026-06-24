namespace EleWise.ELMA.BPM.Web.Common.Models;

public class SelectableGridCheckBoxModel
{
	public string SelectableGridProviderData { get; internal set; }

	public string PropertyName { get; internal set; }

	public object Property { get; internal set; }

	public object RowObject { get; internal set; }

	internal bool EqualsFor(SelectableGridCheckBoxModel obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (SelectableGridProviderData == obj.SelectableGridProviderData && PropertyName == obj.PropertyName)
		{
			if (Property != null || obj.Property != null)
			{
				if (Property != null)
				{
					return Property.Equals(obj.Property);
				}
				return false;
			}
			return true;
		}
		return false;
	}
}
