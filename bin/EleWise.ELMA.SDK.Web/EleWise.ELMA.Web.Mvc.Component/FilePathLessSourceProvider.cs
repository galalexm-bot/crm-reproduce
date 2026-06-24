using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
internal sealed class FilePathLessSourceProvider : ILayoutLessSourceProvider, IAbstractLessSourceProvider
{
	public const string PathAreaName = "FilePathLessSourceProviderArea";

	public string Area => "FilePathLessSourceProviderArea";

	public string ContentPath => string.Empty;

	public string FileName => string.Empty;
}
