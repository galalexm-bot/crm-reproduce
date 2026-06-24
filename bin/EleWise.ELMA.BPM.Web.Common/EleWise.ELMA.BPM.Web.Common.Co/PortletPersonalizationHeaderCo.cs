using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Forms;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class PortletPersonalizationHeaderColorUpdater : IFormBuilderModelUpdater
{
	public void AfterCreate(FormBuilderModel builderModel)
	{
	}

	public void BeforeRender(HtmlHelper html, FormBuilderModel builderModel)
	{
		if (builderModel.FormModel is IPortletPersonalization)
		{
			PropertyRowModel propertyRowModel = null;
			PropertyRowModel propertyRowModel2 = null;
			try
			{
				propertyRowModel = builderModel.GetPropertyRow("HeaderColor");
				propertyRowModel2 = builderModel.GetPropertyRow("TextHeaderColor");
			}
			catch (ArgumentException)
			{
			}
			if (propertyRowModel != null)
			{
				propertyRowModel.Driver.EditorAttributes.TemplateName = "StringColor";
			}
			if (propertyRowModel2 != null)
			{
				propertyRowModel2.Driver.EditorAttributes.TemplateName = "StringColor";
			}
		}
	}
}
