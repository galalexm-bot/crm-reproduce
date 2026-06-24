using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class CustomFormViewsModel
{
	public long CustomPropCount;

	public bool HasCommonView;

	public FormView FormView;

	public MvcHtmlString CustomView;
}
