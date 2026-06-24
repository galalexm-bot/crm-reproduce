using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types;

[ExtensionPoint(ComponentType.All)]
public interface IEntityType
{
	List<Guid> Types { get; }
}
