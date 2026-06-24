using System;

namespace EleWise.ELMA.Diagrams;

public abstract class HintDrawElementExtension<T> : IHintDrawElementExtension
{
	public Type SourceElementType => typeof(T);

	public abstract Type[] TargetElementTypes { get; }
}
