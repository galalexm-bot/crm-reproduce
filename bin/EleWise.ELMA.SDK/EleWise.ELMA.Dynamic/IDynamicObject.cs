namespace EleWise.ELMA.Dynamic;

public interface IDynamicObject
{
	bool ContainsProperty(string name, bool ignoreCase = false);

	object GetPropertyValue(string name, bool ignoreCase = false);

	void SetPropertyValue(string name, object value, bool ignoreCase = false);
}
