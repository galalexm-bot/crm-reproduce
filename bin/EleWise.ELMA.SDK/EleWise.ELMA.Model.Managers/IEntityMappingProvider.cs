using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Managers;

[ExtensionPoint(ComponentType.Server)]
public interface IEntityMappingProvider
{
	IEnumerable<Type> GetMappingTypes();
}
