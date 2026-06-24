using System.ComponentModel;

namespace EleWise.ELMA.Services;

[EditorBrowsable(EditorBrowsableState.Never)]
public interface IConfigurationScriptsErrorService
{
	bool Validate(string code);

	string GetFileAbsolutePath();

	string GetErrors();

	bool IsValidCurrent();
}
