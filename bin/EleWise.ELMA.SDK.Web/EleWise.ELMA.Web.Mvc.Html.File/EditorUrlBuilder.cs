using System.Web.Mvc;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Web.Mvc.Html.FileBrowser.Telerik;

public class EditorUrlBuilder : IEditorUrlBuilder
{
	private readonly IUrlGenerator urlGenerator;

	private readonly ViewContext viewContext;

	public EditorUrlBuilder(IUrlGenerator urlGenerator, ViewContext viewContext)
	{
		this.urlGenerator = urlGenerator;
		this.viewContext = viewContext;
	}

	public string PrepareUrl(INavigatable navigatable)
	{
		return NavigatableExtensions.GenerateUrl(navigatable, viewContext, urlGenerator);
	}
}
