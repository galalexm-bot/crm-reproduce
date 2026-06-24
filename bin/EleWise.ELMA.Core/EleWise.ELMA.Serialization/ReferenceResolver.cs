using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Serialization;

internal sealed class ReferenceResolver : IReferenceResolver
{
	private int referenceCount;

	private WeakMap map;

	public bool TryGetReference(object value, out string reference)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		reference = "";
		if (value == null)
		{
			return false;
		}
		if (map == null)
		{
			map = new WeakMap();
		}
		if (!map.Has<object>(value))
		{
			referenceCount++;
			reference = Script.Write<string>("this.referenceCount.toString()", new object[0]);
			map.Set<object>(value, (object)reference);
			return false;
		}
		reference = (string)map.Get<object>(value);
		return true;
	}
}
