using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TasksModuleSettingsItemProvider : ITasksModuleSettingsItemProvider
{
	public IEnumerable<TasksModuleSettingsItem> GetItems(UrlHelper urlHelper)
	{
		return new List<TasksModuleSettingsItem>
		{
			new TasksModuleSettingsItem
			{
				Order = 10,
				Text = SR.T("Настройка модуля «Задачи»"),
				Description = SR.T("Настроить функционал модуля «Задачи»"),
				Image = "#setting_outline.svg",
				Url = urlHelper.Action("Index", "Settings", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					module = "EleWise.ELMA.Tasks",
					currentMenu = "tasks-admin-menu",
					title = SR.T("Настройка модуля «Задачи»"),
					moduleGuid = new Guid("1BEC7EA1-9B7C-492C-B2C4-AF6B418AC5AF")
				})
			},
			new TasksModuleSettingsItem
			{
				Order = 10,
				Text = SR.T("Настройка модуля «Трудозатраты»"),
				Description = SR.T("Настроить функционал модуля Трудозатраты"),
				Image = "#setting_outline.svg",
				Url = urlHelper.Action("Index", "Settings", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Common",
					module = "EleWise.ELMA.Tasks",
					currentMenu = "tasks-admin-menu",
					title = SR.T("Настройка модуля Трудозатраты"),
					moduleGuid = new Guid("0ac37901-8600-47a2-a240-3bc69aa75a36")
				})
			},
			new TasksModuleSettingsItem
			{
				Order = 10,
				Text = SR.T("Права доступа к модулю «Задачи»"),
				Description = SR.T("Настроить права доступа к модулю Задачи"),
				Image = "#access.svg",
				Url = urlHelper.Action("GlobalPermissions", "PermissionManagment", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Security",
					module = "EleWise.ELMA.BPM.Web.Tasks",
					currentMenu = "tasks-admin-menu",
					title = SR.T("Права доступа к модулю «Задачи»")
				})
			},
			new TasksModuleSettingsItem
			{
				Order = 20,
				Text = SR.T("Объекты трудозатрат"),
				Description = SR.T("Изменить список объектов, участвующих в формировании отчёта о трудозатратах"),
				Image = "#clock.svg",
				Url = urlHelper.Action("TypeSettings", "WorkLogReport", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				})
			},
			new TasksModuleSettingsItemCatalog<ITaskCategory>(urlHelper)
			{
				Order = 30,
				Text = SR.T("Категория задач"),
				Image = "#objects.svg"
			},
			new TasksModuleSettingsItemCatalog<IWorkLogActivity>(urlHelper)
			{
				Order = 40,
				Text = SR.T("Вид деятельности"),
				Url = urlHelper.Action("", "WorkLogActivity", (object)new
				{
					area = "EleWise.ELMA.BPM.Web.Tasks"
				}),
				Image = "#objects.svg"
			}
		};
	}
}
