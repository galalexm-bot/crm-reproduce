using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html.Grids;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
internal class UserReplacementTaskGridPropertySettings : IReplacementTaskGridPropertySettings
{
	public void RenderColumns<T>(DynamicColumnsBuilder<T> columnsBuilder, IReplacementTask replacementTask) where T : class, IEntity
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		HtmlHelper val = null;
		foreach (PropertyMetadata item in from p in ReplacementTaskFilter.GetProperties<T>()
			select p.Key)
		{
			PropertyMetadata property = item;
			DynamicColumnBuilder<T> dynamicColumnBuilder = columnsBuilder.For(property);
			HtmlHelper html1;
			val = (html1 = (HtmlHelper)(((object)val) ?? ((object)(HtmlHelper)typeof(DynamicColumnBuilderBase).GetField("html", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField).GetValue(dynamicColumnBuilder))));
			dynamicColumnBuilder.Template(delegate(T m)
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002d: Expected O, but got Unknown
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Expected O, but got Unknown
				HtmlHelper obj = html1;
				ReplacementUserPropertyEditModel replacementUserPropertyEditModel = new ReplacementUserPropertyEditModel(replacementTask, m, property);
				ViewDataDictionary val2 = new ViewDataDictionary();
				TemplateInfo val3 = new TemplateInfo();
				val3.set_HtmlFieldPrefix(html1.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName(string.Concat("grid.", property.Uid, ".", m.GetId())));
				val2.set_TemplateInfo(val3);
				return PartialExtensions.Partial(obj, "Replacement/ReplacementUserPropertyEdit", (object)replacementUserPropertyEditModel, val2);
			}).Sortable(sortable: false).Required(required: true);
		}
	}
}
