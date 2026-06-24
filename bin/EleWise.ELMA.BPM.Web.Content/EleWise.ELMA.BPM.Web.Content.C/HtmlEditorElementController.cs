using System.IO;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Content.Extensions;
using EleWise.ELMA.BPM.Web.Content.LinkTypeProviders;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Web.Mvc.Html;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Content.Controllers;

public class HtmlEditorElementController : BPMController
{
	private readonly HtmlContentActionRenderer htmlContentActionRenderer;

	public HtmlEditorElementController(HtmlContentActionRenderer htmlContentActionRenderer)
	{
		this.htmlContentActionRenderer = htmlContentActionRenderer;
	}

	public ActionResult ViewStyle(string wizardId)
	{
		HtmlEditorElementStyleModel htmlEditorElementStyleModel = new HtmlEditorElementStyleModel
		{
			WizardId = wizardId
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)htmlEditorElementStyleModel);
	}

	[HttpPost]
	public ActionResult GetHtmlStringEditorContent(GetHtmlStringContentRequest request)
	{
		StringBuilder tinyMCESetupContent = GetTinyMCESetupContent();
		HtmlHelper htmlHelper = GetHtmlHelper();
		htmlHelper.IgnoreZones(request.RegisteredZones);
		ActionWizardSettings settings = new ActionWizardSettings
		{
			PopupId = "HtmlElementWizardPopup",
			AppearanceStepUrl = ((Controller)this).get_Url().Action("ViewStyle", "HtmlEditorElement", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Content"
			}),
			OnComplete = "insertElement"
		};
		tinyMCESetupContent.Append(((object)htmlHelper.RegisterActionWizard(settings)).ToString());
		tinyMCESetupContent.Append(htmlHelper.RegisterImageBrowser());
		AppendDefaultContent(tinyMCESetupContent, htmlHelper);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			Html = tinyMCESetupContent.ToString()
		});
	}

	[HttpPost]
	public ActionResult GetHtmlStringDisplayContent(GetHtmlStringContentRequest request)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		if (request.HtmlValue != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			HtmlHelper htmlHelper = GetHtmlHelper();
			htmlHelper.IgnoreZones(request.RegisteredZones);
			stringBuilder.Append(htmlContentActionRenderer.PrepareMarkup(request.HtmlValue, htmlHelper));
			AppendDefaultContent(stringBuilder, htmlHelper);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				Html = stringBuilder.ToString()
			});
		}
		return (ActionResult)new EmptyResult();
	}

	private StringBuilder GetTinyMCESetupContent()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		using StringWriter stringWriter = new StringWriter();
		ViewEngineResult val = ViewEngines.get_Engines().FindPartialView(((ControllerBase)this).get_ControllerContext(), "TinyMCESetupContent");
		ViewContext val2 = new ViewContext(((ControllerBase)this).get_ControllerContext(), val.get_View(), ((ControllerBase)this).get_ViewData(), ((ControllerBase)this).get_TempData(), (TextWriter)stringWriter);
		val.get_View().Render(val2, (TextWriter)stringWriter);
		val.get_ViewEngine().ReleaseView(((ControllerBase)this).get_ControllerContext(), val.get_View());
		return stringWriter.GetStringBuilder();
	}

	private void AppendDefaultContent(StringBuilder builder, HtmlHelper html)
	{
		builder.Append(html.RenderForZone("DefaultContentZone"));
		string value = HtmlHelperExtension.Telerik(html).ScriptRegistrar().jQuery(false)
			.OutputScriptFiles(false)
			.ToHtmlString();
		builder.Append(value);
	}
}
