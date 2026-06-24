using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagrams;

public static class HintDrawElementHelper
{
	public static Type[] GetAvaiableOutputElementTypes<TSource>()
	{
		return GetAvaiableOutputElementTypes(typeof(TSource));
	}

	public static Type[] GetAvaiableOutputElementTypes(Type sourceType)
	{
		return (from e in ComponentManager.Current.GetExtensionPoints<IHintDrawElementExtension>()
			where e.SourceElementType.IsAssignableFrom(sourceType)
			select e).SelectMany((IHintDrawElementExtension e) => e.TargetElementTypes).ToArray();
	}
}
