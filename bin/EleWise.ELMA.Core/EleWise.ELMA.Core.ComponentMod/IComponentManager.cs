using System;
using System.Reflection;

namespace EleWise.ELMA.Core.ComponentModel;

public interface IComponentManager
{
	void Init(Assembly[] assemblies);

	System.Type[] GetTypes(System.Type type);
}
