using System.Collections.Generic;

namespace EleWise.ELMA.Model.Transformations;

public interface IPropertiesContainer
{
	IEnumerable<string> GetProperties();

	object GetPropertyValue(string propertyName, object[] index);

	void SetPropertyValue(string propertyName, object[] index, object value);

	void RemoveProperty(string propertyName);

	bool IsEmpty();
}
