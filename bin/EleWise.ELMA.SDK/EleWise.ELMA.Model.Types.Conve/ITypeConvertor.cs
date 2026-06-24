using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Types.Convertors;

[ExtensionPoint(ComponentType.All)]
public interface ITypeConvertor
{
	List<Guid> SourceTypeUids { get; }

	List<Guid> TargetTypeUids { get; }

	object DoConvert(object obj);
}
