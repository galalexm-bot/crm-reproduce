using System;
using System.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class TasksPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.User)]
	[Category("Отображение задач")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(TasksPortletPersonalization_SR), "P_OrderBy")]
	public TasksPortletSortExpression SortSettings { get; set; }

	public virtual string ViewName => "MyTasksPortlet";
}
