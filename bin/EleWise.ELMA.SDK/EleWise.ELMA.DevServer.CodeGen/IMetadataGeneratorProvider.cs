using System;

namespace EleWise.ELMA.DevServer.CodeGeneration;

[Obsolete("Не использовать! Указанный API не зафиксирован и может быть изменен или удален в любой момент!", false)]
public interface IMetadataGeneratorProvider
{
	Type MetadataType { get; }

	Type GeneratorType { get; }
}
