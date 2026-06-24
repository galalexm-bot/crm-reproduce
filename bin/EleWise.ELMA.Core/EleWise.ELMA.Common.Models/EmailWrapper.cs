using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class EmailWrapper : Entity
{
	private string _003CEmailString_003Ek__BackingField;

	public string EmailString
	{
		get
		{
			return _003CEmailString_003Ek__BackingField;
		}
		set
		{
			_003CEmailString_003Ek__BackingField = value;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
