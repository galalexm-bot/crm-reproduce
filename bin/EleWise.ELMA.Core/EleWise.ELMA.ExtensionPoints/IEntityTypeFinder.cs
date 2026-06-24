using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
[Obsolete]
public interface IEntityTypeFinder
{
	System.Type GetRealType(object json);
}
