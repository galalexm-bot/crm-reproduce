using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

[Component(Order = 100)]
internal class OvertimeWorkLogExtension : IOvertimeWorkLogWithDraftsExtension
{
	public WorkLogSettingsModule WorkLogSettingsModule { get; set; }

	public WorkLogItemManager WorkLogItemManager { get; set; }

	public IEnumerable<WorkLogItemModel> SupportedModels(IEnumerable<WorkLogItemModel> models)
	{
		return models.ToList();
	}

	public IDictionary<WorkLogItemModel, string> OvertimeDescriptionMap(IEnumerable<WorkLogItemModel> workLogItemModels, IEnumerable<long> selectedIds, bool includeDraft = true)
	{
		if (workLogItemModels == null)
		{
			return new Dictionary<WorkLogItemModel, string>();
		}
		WorkLogSettings workLogSettings = WorkLogSettingsModule.Settings;
		IEnumerable<long> usersListNotAffectLimitationWorkLog = from u in WorkLogHelper.GetUsersByAllKindId(workLogSettings.UsersListNotAffectLimitationWorkLogIds, workLogSettings.GroupListNotAffectLimitationWorkLogIds, workLogSettings.OrganizationItemListNotAffectLimitationWorkLogIds)
			select u.Id;
		List<WorkLogItemModel> defferedWorkLogItemModels = new List<WorkLogItemModel>();
		Dictionary<WorkLogItemModel, string> result = workLogItemModels.ToDictionary((WorkLogItemModel k) => k, delegate(WorkLogItemModel v)
		{
			IWorkLogItem workLogItem = v.WorkLogItem;
			if (workLogItem == null)
			{
				return null;
			}
			if ((workLogItem.CreationAuthor == null || !usersListNotAffectLimitationWorkLog.Contains(workLogItem.CreationAuthor.Id)) && workLogSettings.LimitDayReport > 0 && workLogSettings.DisableOvertime && workLogSettings.LimitDayReport > 0)
			{
				DateTime date = DateTime.Now.Date;
				DateTime dateTime = new DateTime(workLogItem.Date.Year, workLogItem.Date.Month, workLogItem.Date.Day);
				if ((date - dateTime).TotalDays >= (double)workLogSettings.LimitDayReport)
				{
					return SR.T("Нельзя подавать трудозатраты позднее {0} дней.", workLogSettings.LimitDayReport);
				}
			}
			if (workLogSettings.LimitDayHours > 0 && workLogItem.FactWorkTime.HasValue)
			{
				defferedWorkLogItemModels.Add(v);
			}
			return null;
		});
		ProcessDefferedWorkLogItemModels(defferedWorkLogItemModels, selectedIds, result, includeDraft);
		return result;
	}

	private void ProcessDefferedWorkLogItemModels(List<WorkLogItemModel> workLogItemModels, IEnumerable<long> selectedIds, Dictionary<WorkLogItemModel, string> result, bool includeDraft)
	{
		if (!workLogItemModels.Any())
		{
			return;
		}
		DateTime value = workLogItemModels.Min((WorkLogItemModel w) => w.WorkLogItem.Date);
		DateTime value2 = workLogItemModels.Max((WorkLogItemModel w) => w.WorkLogItem.Date);
		Dictionary<DateTime, long> groupedWorkLogItems = (from i in workLogItemModels
			group i by i.WorkLogItem.Date).ToDictionary((IGrouping<DateTime, WorkLogItemModel> g) => g.Key, (IGrouping<DateTime, WorkLogItemModel> v) => v.Sum((WorkLogItemModel w) => w.WorkLogItem.GetActualWorkTime().TotalMinutes));
		IWorkLogObjectSearchFilter workLogObjectSearchFilter = InterfaceActivator.Create<IWorkLogObjectSearchFilter>();
		workLogObjectSearchFilter.DisableSecurity = true;
		List<IUser> workLogItemAuthors = new List<IUser> { workLogItemModels.FirstOrDefault().WorkLogItem.CreationAuthor };
		IWorkLogItemSearchFilter workLogItemSearchFilter = (IWorkLogItemSearchFilter)workLogObjectSearchFilter;
		workLogItemSearchFilter.OnlyMy = true;
		workLogItemSearchFilter.ShowDraft = true;
		workLogItemSearchFilter.WorkLogItemDate = new RelativeDateTime(value, value2);
		workLogItemSearchFilter.ExcludeIds = workLogItemModels.Select((WorkLogItemModel i) => i.WorkLogItem.Id).ToList();
		List<IWorkLogItemSearchFilter> list = new List<IWorkLogItemSearchFilter>();
		InstanceOf<IWorkLogItemSearchFilter> instanceOf = new InstanceOf<IWorkLogItemSearchFilter>();
		instanceOf.New.WorkLogItemAuthors = workLogItemAuthors;
		instanceOf.New.WorkLogItemStatuses = new List<WorkLogItemStatus>
		{
			WorkLogItemStatus.New,
			WorkLogItemStatus.Confirm
		};
		instanceOf.New.ShowDraft = true;
		instanceOf.New.DisableSecurity = true;
		list.Add(instanceOf.New);
		workLogItemSearchFilter.FilterList = list;
		if (includeDraft)
		{
			List<IWorkLogItemSearchFilter> filterList = workLogItemSearchFilter.FilterList;
			InstanceOf<IWorkLogItemSearchFilter> instanceOf2 = new InstanceOf<IWorkLogItemSearchFilter>();
			instanceOf2.New.WorkLogItemAuthors = workLogItemAuthors;
			instanceOf2.New.WorkLogItemStatus = WorkLogItemStatus.Draft;
			instanceOf2.New.ShowDraft = true;
			instanceOf2.New.DisableSecurity = true;
			instanceOf2.New.Ids = selectedIds?.ToList();
			filterList.Add(instanceOf2.New);
		}
		workLogItemSearchFilter.WorkLogItemAuthors = new List<IUser> { workLogItemModels.FirstOrDefault().WorkLogItem.CreationAuthor };
		Dictionary<DateTime, WorkTime> sumDict = WorkLogItemManager.LoadWorkLogItemsSumGroupBy((IWorkLogItem w) => w.Date, workLogItemSearchFilter);
		workLogItemModels.ForEach(delegate(WorkLogItemModel w)
		{
			long num = (sumDict.ContainsKey(w.WorkLogItem.Date) ? sumDict[w.WorkLogItem.Date].TotalMinutes : 0);
			num += (groupedWorkLogItems.ContainsKey(w.WorkLogItem.Date) ? groupedWorkLogItems[w.WorkLogItem.Date] : 0);
			WorkLogSettings settings = WorkLogSettingsModule.Settings;
			if (num > settings.LimitDayHours * 60 && settings.DisableOvertime)
			{
				result[w] = SR.T("Нельзя подавать трудозатраты за день с общим временем больше {0} ч. Всего за день {1}", settings.LimitDayHours, new WorkTime(num).ToString());
			}
		});
	}
}
