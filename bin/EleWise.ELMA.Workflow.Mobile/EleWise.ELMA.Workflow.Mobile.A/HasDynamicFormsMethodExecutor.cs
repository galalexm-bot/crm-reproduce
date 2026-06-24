using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Service.v1;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.API;

internal sealed class HasDynamicFormsMethodExecutor : BaseHasDynamicFormMethod
{
	private ISecurityService securityService;

	internal const string MethodName = "HasDynamicForms";

	private ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("TaskIds", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Идентификаторы задачи")).IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ii)
		{
			ii.Name("Id").Descriptor(SR.T("Идентификатор задачи"));
		});
	}).Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Result", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.IsArray().Item(delegate(TypeSerializationItemDescriptorBuilder ii)
		{
			ii.Name("TaskId").Descriptor(SR.T("Идентификатор задачи"));
		}).Item(delegate(TypeSerializationItemDescriptorBuilder ii)
		{
			ii.Name("IsDynamic").Descriptor(SR.T("Есть ли динамика или кастомизация на форме задачи"));
		})
			.Description(SR.T("Результат выполнения. Список задач и значение динамики."));
	}).Descriptor;

	public static string Description => SR.T("Есть ли у процессных задач динамика или кастомизация на форме");

	public HasDynamicFormsMethodExecutor(WebData parameters)
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
		WebDataItem webDataItem = Parameters.FindItem("TaskIds");
		if (webDataItem == null || webDataItem.DataArray == null)
		{
			return false;
		}
		List<long> taskIds = new List<long>();
		WebData[] dataArray = webDataItem.DataArray;
		for (int i = 0; i < dataArray.Length; i++)
		{
			WebDataItem webDataItem2 = dataArray[i].FindItem("Id");
			if (webDataItem2 != null)
			{
				if (!long.TryParse(webDataItem2.Value, out var result))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Неверный формат идентификатора задачи, должен быть Int64"), 400);
				}
				if (result > 0)
				{
					taskIds.Add(result);
				}
			}
		}
		if (taskIds.Count > 0)
		{
			ICollection<ITaskBase> allTasks = null;
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				allTasks = TaskBaseManager.Instance.FindByIdArray(taskIds.ToArray());
			});
			if (allTasks != null)
			{
				foreach (IWorkflowTaskBase item in allTasks)
				{
					tasks.Add(item);
				}
				return true;
			}
		}
		return false;
	}

	protected override WebData FormatResult(Dictionary<long, bool> result)
	{
		List<WebData> list = new List<WebData>();
		foreach (KeyValuePair<long, bool> item in result)
		{
			list.Add(new WebData
			{
				Items = new WebDataItem[2]
				{
					new WebDataItem
					{
						Name = "TaskId",
						Value = item.Key.ToString()
					},
					new WebDataItem
					{
						Name = "IsDynamic",
						Value = item.Value.ToString()
					}
				}
			}.UpdateVersion());
		}
		WebData webData = new WebData();
		webData.Items = new WebDataItem[1]
		{
			new WebDataItem
			{
				DataArray = list.ToArray(),
				Name = "HasDynamicForms"
			}
		};
		return webData.UpdateVersion();
	}
}
