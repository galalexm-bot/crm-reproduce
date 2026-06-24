using Bridge.Html5;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Serialization;

internal sealed class ExistReferenceResolver : IReferenceResolver
{
	private int referenceCount;

	private readonly WeakMap map = new WeakMap();

	public bool TryGetReference(object value, out string reference)
	{
		reference = "";
		if (value == null)
		{
			return false;
		}
		if (value.HasProperty("$id"))
		{
			object obj = value.get_Item("$id");
			if (obj == null)
			{
				return false;
			}
			string text = obj.ToString();
			if (string.IsNullOrWhiteSpace(text))
			{
				return false;
			}
			map.Set<object>(value, (object)text);
			reference = text;
			return false;
		}
		if (!map.Has<object>(value))
		{
			referenceCount--;
			reference = ((object)referenceCount).ToString();
			map.Set<object>(value, (object)reference);
			return false;
		}
		reference = (string)map.Get<object>(value);
		return true;
	}
}
