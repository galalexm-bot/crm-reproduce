using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Mobile.API.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.API;

internal class StartableProcessesFromExternalAppsMethodExecutor : PublicServiceMethodExecutor
{
	private const string nameGroups = "Groups";

	private const string nameProcesses = "Processes";

	internal const string MethodName = "StartableProcessesFromExternalApps";

	public static string Description => SR.T("Загрузить список процессов, доступных для запуска из внешних приложений");

	public static TypeSerializationDescriptor ParametersDescriptor => new TypeSerializationDescriptorBuilder().Descriptor;

	public static TypeSerializationDescriptor ResultDescriptor => new TypeSerializationDescriptorBuilder().ItemWithDescriptor("Groups", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Массив из элементов с информацией о группах процессов")).IsArray(ProcessGroupInfo.GetDescriptor);
	}).ItemWithDescriptor("Processes", delegate(TypeSerializationDescriptorBuilder i)
	{
		i.Description(SR.T("Массив из элементов с информацией о процессах")).IsArray(EleWise.ELMA.Workflow.Mobile.API.Models.ProcessHeaderInfo.GetDescriptor);
	}).Descriptor;

	private bool AddGroup(Dictionary<long, ProcessGroupDTO> source, Dictionary<long, ProcessGroupDTO> destination, long groupId)
	{
		if (destination.ContainsKey(groupId))
		{
			return true;
		}
		if (!source.ContainsKey(groupId))
		{
			return false;
		}
		ProcessGroupDTO processGroupDTO = source[groupId];
		int num;
		if (processGroupDTO.ParentId != 0L)
		{
			num = (AddGroup(source, destination, processGroupDTO.ParentId) ? 1 : 0);
			if (num == 0)
			{
				goto IL_0042;
			}
		}
		else
		{
			num = 1;
		}
		destination.Add(groupId, processGroupDTO);
		goto IL_0042;
		IL_0042:
		return (byte)num != 0;
	}

	public StartableProcessesFromExternalAppsMethodExecutor(WebData parameters)
		: base(parameters)
	{
	}

	public override WebData Execute()
	{
		Dictionary<long, ProcessGroupDTO> allGroups = (from g in ProcessGroupManager.Instance.LoadGroupsTree()
			where !string.IsNullOrEmpty(g.Name)
			select g).ToDictionary((ProcessGroupDTO g) => g.Id);
		Dictionary<long, ProcessGroupDTO> groups = new Dictionary<long, ProcessGroupDTO>();
		WebData[] dataArray = (from h in ProcessHeaderManager.Instance.GetStartableProcesses()
			where !string.IsNullOrEmpty(h.Name) && h.RunByFromExternalSystem && (h.ParentGroup == null || AddGroup(allGroups, groups, h.ParentGroup.Id))
			select h into ph
			select new EleWise.ELMA.Workflow.Mobile.API.Models.ProcessHeaderInfo(ph).ToWebData()).ToArray();
		WebData webData = new WebData();
		webData.Items = new WebDataItem[2]
		{
			new WebDataItem
			{
				Name = "Groups",
				DataArray = groups.Values.Select((ProcessGroupDTO g) => new ProcessGroupInfo(g).ToWebData()).ToArray()
			},
			new WebDataItem
			{
				Name = "Processes",
				DataArray = dataArray
			}
		};
		return webData;
	}
}
