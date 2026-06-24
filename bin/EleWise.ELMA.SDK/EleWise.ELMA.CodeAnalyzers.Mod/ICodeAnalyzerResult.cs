using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CodeAnalyzers.Model;

public interface ICodeAnalyzerResult
{
	IDictionary<IMetadata, ICollection<IPropertyMetadata>> ReferenceMetadata { get; }
}
