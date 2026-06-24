using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Components;

[Component(Type = ComponentType.WebServer)]
public class CurrencyExchangeDailyUpdater : ISchedulerJobRepository
{
	private class CurrencyExchangeDailyJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			public Guid Id => new Guid("6140B33F-A714-4BF6-9DC2-437556690E54");

			public string Name => SR.T("Обновление курсов валют");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				CurrencyExchangeImportSettings settings = Locator.GetServiceNotNull<CurrencyExchangeImportModule>().Settings;
				List<CurrencyImportGridRowModel> regularImportItems = RegularCurrencyRateImportManager.Instance.GetAllRowsForGrid().ToList();
				if (regularImportItems.Any())
				{
					EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.AdminUserUid);
					List<string> messages = new List<string>();
					Locator.GetServiceNotNull<ISecurityService>().RunByUser(user, delegate
					{
						messages = CurrencyImportHelper.UpdateCurrenciesRates(regularImportItems, settings.ValueStorage, DateTime.Now, DateTime.Now).ToList();
					});
					if (messages.Any())
					{
						return new JobResult
						{
							Status = JobStatus.Errors,
							Information = SR.T("Ошибка обновления курса валют"),
							ErrorDescription = messages.ToSeparatedString("\n")
						};
					}
					return new JobResult
					{
						Status = JobStatus.Success,
						Information = SR.T("Курсы валют обновлены")
					};
				}
				return new JobResult
				{
					Status = JobStatus.Success,
					Information = SR.T("Не найдено валют для обновления курсов")
				};
			}
		}

		private readonly ITrigger _trigger;

		private ICollection<IJob> _jobs;

		public override ITrigger Trigger => _trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public CurrencyExchangeDailyJob()
		{
			CurrencyExchangeImportSettings settings = Locator.GetServiceNotNull<CurrencyExchangeImportModule>().Settings;
			_trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				RepeatSettings = new RepeatSettings
				{
					Enabled = false
				},
				StartDate = settings.UpdateTimeForDailyRates
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер автоматического обновления курсов валют"),
				Id = new Guid("E4297A7F-742E-4733-97E6-9CDF366C99C5")
			};
			_jobs = new List<IJob>
			{
				new JobImpl()
			};
		}
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new CurrencyExchangeDailyJob()
		};
	}
}
