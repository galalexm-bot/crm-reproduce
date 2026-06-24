using System;
using System.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class ActionWizardItemAttribute : Attribute
{
	public string Image32 { get; set; }

	public int Order { get; set; }

	[DefaultValue(ActionWizardItemCategory.Action)]
	public ActionWizardItemCategory Category { get; set; }
}
