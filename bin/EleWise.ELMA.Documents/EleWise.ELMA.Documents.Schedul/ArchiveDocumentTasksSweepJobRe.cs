using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Documents.Scheduling;

[Component(Type = ComponentType.WebServer)]
internal sealed class ArchiveDocumentTasksSweepJobRepository : ISchedulerJobRepository
{
	private class SchedulerJob : SchedulerJobBase
	{
		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public SchedulerJob(IProductionCalendarService productionCalendarService, ArchiveDocumentTasksSweepService archiveDocumentTasksSweepService, ThreadSubPool subPool)
		{
			Trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				RepeatSettings = new RepeatSettings
				{
					Enabled = true,
					RepeatEvery = TimeSpan.FromMinutes(10.0),
					RepeatTo = TimeSpan.FromHours(24.0)
				},
				StartDate = DateTime.Today
			}, productionCalendarService)
			{
				Id = new Guid("ccfb0485-3b1f-4e9c-830e-1146dc8c2398"),
				Name = SR.T("Триггер закрытия задач по архивированным документам")
			};
			int num = subPool.MaxThreadCount - subPool.ActiveThreadCount;
			IJob[] array2;
			if (num > 0)
			{
				IJob[] array = new Job[1]
				{
					new Job(archiveDocumentTasksSweepService, num, subPool)
				};
				array2 = array;
			}
			else
			{
				array2 = Array.Empty<IJob>();
			}
			Jobs = array2;
		}
	}

	private class Job : IJob
	{
		private readonly ArchiveDocumentTasksSweepService sweepService;

		private readonly int docCount;

		private readonly ThreadSubPool subPool;

		public Guid Id => new Guid("3664b1cd-d237-41a7-909e-6c3f777e3ff2");

		public string Name => SR.T("Закрытие задач по архивированным документам");

		public Image Icon => null;

		public Job(ArchiveDocumentTasksSweepService sweepService, int docCount, ThreadSubPool subPool)
		{
			this.sweepService = sweepService;
			this.docCount = docCount;
			this.subPool = subPool;
		}

		public JobResult Do(DateTime dateToRun)
		{
			int num = SR.GetSetting("ArchiveDocumentTasksSweeper.ProcessingCount", 100);
			if (num <= 0)
			{
				num = 100;
			}
			TimeSpan timeout = TimeSpan.FromHours(SR.GetSetting("ArchiveDocumentTasksSweeper.Timeout", 10));
			long[] firstQueuedDocumentIds = sweepService.GetFirstQueuedDocumentIds(docCount, timeout);
			foreach (long documentId in firstQueuedDocumentIds)
			{
				new DocumentTasksSweeper(sweepService, documentId, num, subPool).Sweep();
			}
			return new JobResult
			{
				Status = JobStatus.Success,
				NoSaveResult = true,
				Information = SR.T("Закрытие задач выполнено")
			};
		}
	}

	private class DocumentTasksSweeper
	{
		private readonly ArchiveDocumentTasksSweepService service;

		private readonly long documentId;

		private readonly int tasksCount;

		private readonly IThreadPool pool;

		public DocumentTasksSweeper(ArchiveDocumentTasksSweepService service, long documentId, int tasksCount, IThreadPool pool)
		{
			this.service = service;
			this.documentId = documentId;
			this.tasksCount = tasksCount;
			this.pool = pool;
		}

		public void Sweep()
		{
			pool.Queue(delegate
			{
				try
				{
					new BackgroundTask(delegate
					{
						try
						{
							service.ProcessTopDocumentTasks(documentId, tasksCount);
						}
						catch (Exception exception2)
						{
							Logger.Log.Warn("Cannot process document with id: " + documentId, exception2);
						}
					}, typeof(DocumentTasksSweeper), "Sweep", SR.T("Удаление задач документа {0}", documentId)).Execute();
				}
				catch (Exception exception)
				{
					Logger.Log.Warn("BackgroundTask executing failed for docId: " + documentId, exception);
				}
			});
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly ArchiveDocumentTasksSweepService archiveDocumentTasksSweepService;

	private ThreadSubPool subPool;

	public ArchiveDocumentTasksSweepJobRepository(IProductionCalendarService productionCalendarService, ArchiveDocumentTasksSweepService archiveDocumentTasksSweepService)
	{
		this.productionCalendarService = productionCalendarService;
		this.archiveDocumentTasksSweepService = archiveDocumentTasksSweepService;
		subPool = new ThreadSubPool("ArchiveDocumentTasksSweeper.MaxThreadCount", 1);
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new SchedulerJob[1]
		{
			new SchedulerJob(productionCalendarService, archiveDocumentTasksSweepService, subPool)
		};
	}
}
