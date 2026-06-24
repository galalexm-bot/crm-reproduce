using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.BPM.Web.Tasks.Portlets;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.Portlets;

[Component(Order = 500)]
public class RedirectSolveTaskAction : ISolveTaskAction
{
	public static Guid Uid = new Guid("{8B3EBF33-4558-4340-BC0F-0C92B76A9DA7}");

	public string ImageUrl => "#redirect.svg";

	public virtual string DisplayName => SR.T("Переназначить задачу");

	public virtual Guid ActionKey => Uid;

	public bool CheckType(ITaskBase task)
	{
		return true;
	}

	public virtual bool IsVisible(ITaskBase task, bool debugMode)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.task = task;
		CS_0024_003C_003E8__locals0.res = false;
		SolveTaskHelper.RunWithDebug("RedirectSolveTaskAction.IsVisible", debugMode, delegate
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(TaskBaseManager), "m");
			Expression<Action<TaskBaseManager>> expression = Expression.Lambda<Action<TaskBaseManager>>(Expression.Call(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(TaskBaseManager<ITaskBase>).TypeHandle), Expression.Property(Expression.MemberInit(Expression.New(typeof(InstanceOf<IReAssignActionModel>)), Expression.MemberBind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(InstanceOf<IReAssignActionModel>).TypeHandle), Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle))), Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Coalesce(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Coalesce(Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(null, FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(Expression.Field(Expression.Constant(CS_0024_003C_003E8__locals0, typeof(_003C_003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))))), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(InstanceOf<IReAssignActionModel>).TypeHandle))), new ParameterExpression[1] { parameterExpression });
			ActionDispatcherService serviceNotNull = Locator.GetServiceNotNull<ActionDispatcherService>();
			CS_0024_003C_003E8__locals0.res = CS_0024_003C_003E8__locals0.task.IsActive() && serviceNotNull.CheckAction(expression, CS_0024_003C_003E8__locals0.task.GetType());
		});
		return CS_0024_003C_003E8__locals0.res;
	}

	public virtual void RenderControls(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		SolveTaskBaseActionControlsModel model = new SolveTaskBaseActionControlsModel
		{
			Entity = task,
			Settings = settings
		};
		SolveTaskHelper.RunWithDebug("RedirectSolveTaskAction.RenderControls", settings.DebugMode, delegate
		{
			RenderPartialExtensions.RenderPartial(helper, "SolvePortlet/RedirectSolveTaskControls", (object)model);
		});
	}

	public string RenderAction(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Tasks" },
			{ "Entity.Id", task.Id },
			{ "RedirectHomeIfNullAfterAction", false }
		};
		return string.Format("refreshPopup('{0}', '{1}')", SolveTaskBaseActionControlsModel.ReassignTaskBaseActionPopup, helper.Url().Action("ReAssignTaskForm", "TaskBase", routeValueDictionary));
	}

	public bool IsScript(HtmlHelper helper, ITaskBase task, SolveTaskPortletPersonalization settings)
	{
		return true;
	}

	public void RenderPopups(HtmlHelper helper, bool debugMode)
	{
		SolveTaskHelper.RunWithDebug("RedirectSolveTaskAction.RenderPopups", debugMode, delegate
		{
			RenderAllPopups(helper);
		});
	}

	public static void RenderAllPopups(HtmlHelper helper)
	{
		helper.RegisterContent(SolveTaskBaseActionControlsModel.ReassignTaskBaseActionPopup, (dynamic d) => helper.PopupWindow(SolveTaskBaseActionControlsModel.ReassignTaskBaseActionPopup, SR.T("Изменение исполнителя задачи"), "", 550));
	}
}
