using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Web.Service.v1;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.API;

internal sealed class HasDynamicFormMethodExecutor : BaseHasDynamicFormMethod
{
	private ISecurityService securityService;

	internal const string MethodName = "HasDynamicForm";

	private ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("TaskId", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификатор задачи")).Type(typeof(long));
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Результат выполнения. True, если есть динамика или кастомизация на форме и False, если нет."));
	}).Descriptor;

	public static string Description => SR.T("Есть ли у процессной задачи динамика или кастомизация на форме");

	public HasDynamicFormMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	protected override bool GetTasks(out IList<IWorkflowTaskBase> tasks)
	{
		tasks = new List<IWorkflowTaskBase>();
		if (Parameters == null || Parameters.Items == null)
		{
			return false;
		}
		WebDataItem webDataItem = Parameters.FindItem("TaskId");
		if (webDataItem == null || string.IsNullOrEmpty(webDataItem.Value))
		{
			return false;
		}
		if (!long.TryParse(webDataItem.Value, out var taskId))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
		}
		IWorkflowTaskBase task = null;
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			task = TaskBaseManager.Instance.Load(taskId) as IWorkflowTaskBase;
		});
		if (task != null)
		{
			tasks.Add(task);
		}
		return true;
	}

	protected override WebData FormatResult(Dictionary<long, bool> result)
	{
		if (result == null || result.Count == 0)
		{
			return GetError();
		}
		return new WebData(new Dictionary<string, object> { 
		{
			"Result",
			result.First().Value
		} }).UpdateVersion();
	}
}
