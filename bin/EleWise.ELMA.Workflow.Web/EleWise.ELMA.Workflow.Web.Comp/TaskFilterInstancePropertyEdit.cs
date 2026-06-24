using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component]
public class TaskFilterInstancePropertyEditorExtension : IFilterPropertyEditorExtension
{
	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		return property.PropertyUid == TaskFilterInstancePropertyExtension.IsInstanceTaskPropertyUid;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		object obj = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId") : string.Empty);
		string postfix = ((obj != null) ? obj.ToString().Replace("-", "m") : "");
		bool flag = (filterModel.Filter as IWorkflowTaskBaseFilter).InstanceFilter is IWorkflowInstanceFilter;
		string fullHtmlFieldId = ((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId("InstanceFilterCheckBox");
		string arg = (flag ? ("<script>\r\n            $(document).ready(function () { \r\n                if (localStorage.getItem('" + fullHtmlFieldId + "')) {\r\n                    localStorage.removeItem('" + fullHtmlFieldId + "');\r\n                    return;\r\n                }\r\n                localStorage.setItem('" + fullHtmlFieldId + "', true);\r\n                FilterFieldsRefresh" + postfix + "(null, this); });\r\n            </script>") : "");
		return MvcHtmlString.Create(string.Format("{0}{1}{2}", ((HtmlHelper)(object)html).ModernCheckBoxFor("InstanceFilterCheckBox", renderUncheckedInput: false, generateIdByName: true).Checked(flag).Attributes(delegate(HtmlAttributes a)
		{
			a.onclick = string.Format("$('#{0}').val(this.checked?'{1}':'{2}');FilterFieldsRefresh{3}(null, this);", ((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId("InstanceFilter.__TypeName"), InterfaceActivator.TypeOf<IWorkflowInstanceFilter>().AssemblyQualifiedName, typeof(Filter).AssemblyQualifiedName, postfix);
		})
			.ToHtmlString(), flag ? null : InputExtensions.Hidden((HtmlHelper)(object)html, "InstanceFilter.__TypeName"), arg));
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}
}
