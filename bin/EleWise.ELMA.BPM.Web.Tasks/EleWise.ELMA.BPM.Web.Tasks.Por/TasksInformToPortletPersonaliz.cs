using System;
using System.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

[Serializable]
public class TasksInformToPortletPersonalization : TasksPortletPersonalization
{
	[Personalization(PersonalizationScope.Shared)]
	[Category("Внешний вид")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(TasksInformToPortletPersonalization_SR), "P_HeaderColor")]
	public override string HeaderColor { get; set; }

	public override string ViewName => "MyTasksInformToPortlet";
}
internal static class TasksInformToPortletPersonalization_SR
{
	public static string P_OrderBy => SR.T("Сортировать по");

	public static string P_TaskAppearance => SR.T("Отображение задач");

	public static string P_HeaderColor => SR.T("Цвет заголовка");
}
