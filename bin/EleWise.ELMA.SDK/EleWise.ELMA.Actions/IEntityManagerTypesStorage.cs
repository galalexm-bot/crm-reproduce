using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Actions;

public interface IEntityManagerTypesStorage
{
	[NotNull]
	IEnumerable<Type> GetManagerTypes();
}
