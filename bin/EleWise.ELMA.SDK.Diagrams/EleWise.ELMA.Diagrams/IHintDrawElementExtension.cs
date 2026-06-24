using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Diagrams;

[ExtensionPoint(ComponentType.All)]
public interface IHintDrawElementExtension
{
	Type SourceElementType { get; }

	Type[] TargetElementTypes { get; }
}
