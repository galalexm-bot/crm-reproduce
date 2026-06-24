using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.Models.Wizard;

namespace EleWise.ELMA.Web.Mvc.Html.Wizard;

public class WizardBuilder
{
	protected HtmlHelper html { get; set; }

	protected WizardModel wizrad { get; set; }

	public WizardBuilder(HtmlHelper html, string wizardName)
	{
		this.html = html;
		wizrad = new WizardModel(wizardName);
	}

	public WizardBuilder Items(Action<WizradItemBuilder> itemsBuilder)
	{
		WizradItemBuilder obj = new WizradItemBuilder(html, wizrad);
		itemsBuilder(obj);
		return this;
	}

	public WizardBuilder ControllerName(string controllerName)
	{
		wizrad.ControllerName = controllerName;
		return this;
	}

	public WizardBuilder ActionName(string actionName)
	{
		wizrad.ActionName = actionName;
		return this;
	}

	public WizardBuilder Url(string url)
	{
		wizrad.Url = url;
		return this;
	}

	public WizardBuilder RenderForm(bool val)
	{
		wizrad.RenderForm = val;
		return this;
	}

	public WizardBuilder FormName(string name)
	{
		wizrad.FormName = name;
		return this;
	}

	public virtual MvcHtmlString Render()
	{
		(from s in ComponentManager.Current.GetExtensionPoints<IWizardStep>()
			where s.Wizard.Equals(wizrad.Name, StringComparison.OrdinalIgnoreCase)
			select s).ToList().ForEach(delegate(IWizardStep s)
		{
			WizardItem step = s.GetStep(html);
			if (step != null)
			{
				if (!s.Index.HasValue || s.Index.Value < 0 || s.Index.Value >= wizrad.Items.Count)
				{
					wizrad.Items.Add(step);
				}
				else
				{
					wizrad.Items.Insert(s.Index.Value, step);
				}
			}
		});
		return PartialExtensions.Partial(html, "Templates/Wizard", (object)wizrad);
	}

	public override string ToString()
	{
		return string.Empty;
	}

	public WizardBuilder CssClass(string cssClass)
	{
		wizrad.CssClass = cssClass;
		return this;
	}
}
