using System;
using System.ComponentModel;

namespace EleWise.ELMA.CAB;

public class StateChangedEventArgs : EventArgs
{
	public string Key { get; set; }

	[DefaultValue(null)]
	public object NewValue { get; set; }

	[DefaultValue(null)]
	public object OldValue { get; set; }

	public StateChangedEventArgs(string key, object newValue)
	{
		Key = key;
		NewValue = newValue;
	}

	public StateChangedEventArgs(string key, object newValue, object oldValue)
	{
		Key = key;
		NewValue = newValue;
		OldValue = oldValue;
	}
}
