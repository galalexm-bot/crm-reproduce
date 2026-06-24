using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Nullifier;

[ExtensionPoint(ComponentType.All)]
public interface IExclusionEntityNullifier
{
	List<Guid> SetExclusion();
}
