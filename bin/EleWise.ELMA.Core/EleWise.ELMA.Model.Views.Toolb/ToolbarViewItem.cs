using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Views.Toolbar;

public sealed class ToolbarViewItem : RootViewItem
{
	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is GroupViewItem;
	}

	[OnSerialized]
	public void OnSerializedMethod(UnknownObjectWrapper raw)
	{
		raw.Value.SetAndCreatePlainPropertyValue("$type", "EleWise.ELMA.Model.Views.Toolbar.Toolbar");
		raw.Value.SetAndCreatePlainPropertyValue("Visible", (!Hide).ToString());
	}

	[OnDeserialized]
	private void OnDeserializedMethod(object raw)
	{
		bool flag = default(bool);
		if (bool.TryParse(raw.GetPlainPropertyValue("Visible")?.ToString(), ref flag))
		{
			Hide = !flag;
		}
	}
}
