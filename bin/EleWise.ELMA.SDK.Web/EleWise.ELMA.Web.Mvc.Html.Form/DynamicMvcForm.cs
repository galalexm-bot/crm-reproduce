using System;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class DynamicMvcForm : IDisposable
{
	private readonly MvcForm mvcForm;

	private readonly DynamicFormRenderer renderer;

	internal DynamicMvcForm(MvcForm mvcForm, DynamicFormRenderer renderer)
	{
		this.mvcForm = mvcForm;
		this.renderer = renderer;
	}

	public void Dispose()
	{
		renderer.Dispose();
		mvcForm.Dispose();
	}
}
