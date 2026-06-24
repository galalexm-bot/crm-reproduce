using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Html.Forms;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFormBuilderModelUpdater
{
	void BeforeRender(HtmlHelper html, FormBuilderModel builderModel);

	void AfterCreate(FormBuilderModel builderModel);
}
