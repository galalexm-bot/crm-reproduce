using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class FullscreenViewItem : RootViewItem
{
	private bool _003CFullscreen_003Ek__BackingField;

	private bool _003CDestroyOnClose_003Ek__BackingField;

	[JsonIgnore]
	[DynamicProperty(false)]
	public bool Fullscreen
	{
		get
		{
			return _003CFullscreen_003Ek__BackingField;
		}
		set
		{
			_003CFullscreen_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool DestroyOnClose
	{
		get
		{
			return _003CDestroyOnClose_003Ek__BackingField;
		}
		set
		{
			_003CDestroyOnClose_003Ek__BackingField = value;
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
