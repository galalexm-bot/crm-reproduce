using System.Runtime.Serialization;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Models;

public sealed class PhoneWrapper : Entity
{
	private string _003CPhoneString_003Ek__BackingField;

	public string PhoneString
	{
		get
		{
			return _003CPhoneString_003Ek__BackingField;
		}
		set
		{
			_003CPhoneString_003Ek__BackingField = value;
		}
	}

	[OnDeserialized]
	public void OnDeserialized(object raw)
	{
		OnDeserializedMethod(raw);
	}
}
