using EleWise.ELMA.CodeAnalyzers.Model;

namespace EleWise.ELMA.CodeAnalyzers;

public interface IAnalyzerWithResult
{
	ICodeAnalyzerResult CodeAnalyzerResult { get; }
}
