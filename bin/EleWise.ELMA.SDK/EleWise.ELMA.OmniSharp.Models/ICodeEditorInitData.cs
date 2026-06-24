namespace EleWise.ELMA.OmniSharp.Models;

public interface ICodeEditorInitData
{
	string FileName { get; }

	string MethodName { get; }

	string ClassName { get; }

	string SourceCode { get; }

	string ProjectName { get; }
}
