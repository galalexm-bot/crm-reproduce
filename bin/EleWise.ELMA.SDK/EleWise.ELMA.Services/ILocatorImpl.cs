using System;

namespace EleWise.ELMA.Services;

public interface ILocatorImpl
{
	object GetService(Type type, string name);

	void AddService(Type type, object obj, bool resolveProperties);

	void RemoveService(Type type);
}
