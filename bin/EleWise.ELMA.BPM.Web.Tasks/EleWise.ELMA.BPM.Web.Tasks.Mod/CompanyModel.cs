using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class CompanyModel
{
	public long Count { get; set; }

	public long NewCount { get; set; }

	public long BirthDatesCount { get; set; }

	public IList<CompanyUser> ViewUsers { get; set; }

	public IList<IUser> NewUsers { get; set; }

	public KeyIndicator KeyFeature { get; set; }

	public SearchType SearchType { get; set; }

	public DateTime Period { get; set; }

	public CompanyModel()
	{
		KeyFeature = KeyIndicator.Discipline;
		SearchType = SearchType.Company;
		ViewUsers = new List<CompanyUser>();
		Period = DateTime.Now;
	}

	public CompanyModel(IEnumerable<IUser> users, KeyIndicator keyFeature, DateTime period)
	{
		CompanyModel companyModel = this;
		KeyFeature = keyFeature;
		Period = period;
		DateTime periodStart = new DateTime(period.Year, period.Month, 1);
		DateTime periodEnd = new DateTime(period.Year, period.Month, DateTime.DaysInMonth(period.Year, period.Month), 23, 59, 59);
		ViewUsers = new List<CompanyUser>();
		users.ToList().ForEach(delegate(IUser u)
		{
			CompanyUser companyUser = new CompanyUser
			{
				User = u,
				KeyFeature = keyFeature
			};
			switch (keyFeature)
			{
			case KeyIndicator.Discipline:
				companyUser.PerformanceDiscipline = TaskBaseManager.Instance.GetPerformanceDiscipline(u, periodStart, periodEnd, enableCache: false);
				break;
			case KeyIndicator.NumTasks:
			{
				ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
				taskBaseFilter.CompleteStatus = TaskCompleteStatus.Expired;
				taskBaseFilter.Executor = u;
				taskBaseFilter.NotShowInLists = false;
				taskBaseFilter.DisableSecurity = true;
				long first2 = TaskBaseManager.Instance.Count(taskBaseFilter);
				ITaskBaseFilter taskBaseFilter2 = InterfaceActivator.Create<ITaskBaseFilter>();
				taskBaseFilter2.CompleteStatus = TaskCompleteStatus.Active;
				taskBaseFilter2.Executor = u;
				taskBaseFilter2.NotShowInLists = false;
				taskBaseFilter2.DisableSecurity = true;
				long second2 = TaskBaseManager.Instance.Count(taskBaseFilter2);
				companyUser.NumTasks = new Pair<long, long>(first2, second2);
				break;
			}
			case KeyIndicator.WorkLog:
			{
				IWorkLogItemFilter workLogItemFilter = WorkLogItemManager.Instance.FilterForObject(new List<IUser> { u }, null, null, periodStart, periodEnd);
				workLogItemFilter.ObjectUids = new List<Guid>();
				foreach (List<Guid> item in from e in WorkLogExtensionHelper.ExtensionList()
					select e.EnabledObjectTypes())
				{
					workLogItemFilter.ObjectUids.AddRange(item);
				}
				List<IWorkLogItem> source = (List<IWorkLogItem>)WorkLogItemManager.Instance.Find(workLogItemFilter, FetchOptions.All);
				long first = source.Where((IWorkLogItem wi) => wi.Status == WorkLogItemStatus.Confirm).Sum((IWorkLogItem wi) => wi.ApprovalWorkTime.Value);
				long second = source.Where((IWorkLogItem wi) => wi.Status == WorkLogItemStatus.Unconfirm).Sum((IWorkLogItem wi) => wi.FactWorkTime.Value);
				companyUser.WorkLog = new Pair<long, long>(first, second);
				break;
			}
			}
			companyModel.ViewUsers.Add(companyUser);
		});
	}
}
