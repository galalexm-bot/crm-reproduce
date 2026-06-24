using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Models;

public class StartRouteInfo : FormViewModel, IStartRouteInfo
{
	internal class __Resources_StartRouteInfo
	{
		public static string P_Name_DisplayName => SR.T("Название экземпляра процесса");

		public static string P_ProcessHeaderId_DisplayName => SR.T("Процесс");

		public static string P_ContextVar_DisplayName => SR.T("Контекстная переменная");
	}

	private StartRouteInfoComponent component;

	public Guid ObjectType { get; set; }

	public string PopupId { get; set; }

	public string StartEventPopupId { get; set; }

	public RelationType? RelationType { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(__Resources_StartRouteInfo), "P_ContextVar_DisplayName")]
	public Guid ContextVar { get; set; }

	public bool ContexVarSelector { get; set; }

	public long ContexVarCount { get; set; }

	public string Caption { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(__Resources_StartRouteInfo), "P_ProcessHeaderId_DisplayName")]
	public IProcessHeader ProcessHeader { get; set; }

	public List<long> Objects { get; set; }

	[Required(true)]
	[RequiredField]
	[DisplayName(typeof(__Resources_StartRouteInfo), "P_Name_DisplayName")]
	public string Name { get; set; }

	public bool AskNameOnStart { get; set; }

	public List<IEntity<long>> ObjectList => component.ObjectList;

	public string ContextVarName => component.ContextVarName;

	public string ContextVarSystemName => component.ContextVarSystemName;

	public RelationType ContextVarRelationType => component.ContextVarRelationType;

	public StartRouteInfo()
	{
		base.PostAction = "StartRoute";
		base.PostController = "WorkflowInstance";
		base.PostArea = "EleWise.ELMA.Workflow.Web";
		Objects = new List<long>();
		component = new StartRouteInfoComponent(this);
		AskNameOnStart = true;
		StartEventPopupId = Guid.NewGuid().ToString().Replace("-", "");
	}

	public string InitName()
	{
		if (ObjectList.Count == 1)
		{
			Name = ObjectList.First().ToString();
		}
		return Name;
	}
}
