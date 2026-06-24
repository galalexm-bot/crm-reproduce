using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.WebCompiler;

public class WebCompileFileError
{
	public string GeneratedCode { get; private set; }

	public List<WebCompileDiagnostic> Errors { get; private set; }

	public WebCompileFileError(string generatedCode)
	{
		GeneratedCode = generatedCode;
		Errors = new List<WebCompileDiagnostic>();
	}

	public override string ToString()
	{
		WebCompileDiagnostic webCompileDiagnostic = Errors.FirstOrDefault();
		if (webCompileDiagnostic == null)
		{
			return "";
		}
		return string.Concat(webCompileDiagnostic, (Errors.Count > 1) ? "..." : "");
	}
}
