using System.Web.Mvc;

namespace EleWise.ELMA.Model.Views;

public interface IFormNotifier
{
	void Information(string text);

	void Information(MvcHtmlString text);

	void Warning(string text);

	void Warning(MvcHtmlString text);

	void Error(string text);

	void Error(MvcHtmlString text);
}
