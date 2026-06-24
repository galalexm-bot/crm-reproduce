// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.SchedulerJobActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Актор-исполнитель работы планировщика</summary>
  internal sealed class SchedulerJobActor : 
    Actor,
    ISchedulerJobActor,
    IActorWithGuidCompoundKey,
    IActor
  {
    private readonly ISchedulerTaskManager schedulerTaskManager;
    private readonly ISchedulerJobRunInfoManager schedulerJobRunInfoManager;
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IEnumerable<ISchedulerJobRepository> schedulerJobRepositories;
    /// <summary>Флаг, отмечающий работу, которая не хранится в БД</summary>
    internal const string NonDbRepositoryJob = "NonDbRepositoryJob";
    /// <summary>Флаг, отмечающий работу, которая хранится в БД</summary>
    internal const string DbRepositoryJob = "DbRepositoryJob";
    internal static SchedulerJobActor GmuhUhBqk6F1QlXoPQ9C;

    /// <summary>Ctor</summary>
    /// <param name="schedulerTaskManager">Менеджер задач планировщика</param>
    /// <param name="schedulerJobRunInfoManager">Менеджер информации о запуске работы планировщика</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <param name="schedulerJobRepositories">Репозитории работ планировщика</param>
    public SchedulerJobActor(
      ISchedulerTaskManager schedulerTaskManager,
      ISchedulerJobRunInfoManager schedulerJobRunInfoManager,
      IRuntimeApplication runtimeApplication,
      IEnumerable<ISchedulerJobRepository> schedulerJobRepositories)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.schedulerTaskManager = schedulerTaskManager;
      this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
      this.runtimeApplication = runtimeApplication;
      this.schedulerJobRepositories = schedulerJobRepositories;
    }

    /// <inheritdoc />
    public Task Run() => this.RunInternal(false, SchedulerJobActor.ItLQZuBq2Ff06ViveePd());

    /// <inheritdoc />
    public Task ForceRunJob(Guid? jobUid = null, DateTime? now = null) => this.RunInternal(true, now ?? DateTime.Now, jobUid);

    /// <summary>
    /// Внутренняя логика запуска запланированной задачи в работу
    /// </summary>
    /// <param name="forceRunJob"><c>true</c> если принудительный запуск задачи в работу</param>
    /// <param name="currentDateTime">текущее время запуска</param>
    /// <param name="jobUid"><c>null</c> если требуется запустить все работы из запланированной задачи</param>
    /// <returns></returns>
    private async Task RunInternal(bool forceRunJob, DateTime currentDateTime, Guid? jobUid = null)
    {
      int num1 = 1;
      int num2;
      SchedulerJobActor schedulerJobActor1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
label_106:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 4;
            continue;
          case 3:
            goto label_103;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = 3;
            continue;
          case 5:
            try
            {
              int num3;
              switch (num2)
              {
                case 0:
                case 1:
                case 2:
label_5:
                  num3 = 4;
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 3;
                  break;
              }
              GuidCompoundKey actorKey;
              Guid? jobUid1;
              ISchedulerJob schedulerJob;
              SchedulerJobActor schedulerJobActor;
              DateTime currentDateTime1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_106;
                  case 2:
                    schedulerJobActor = this;
                    num3 = 7;
                    continue;
                  case 3:
                    num3 = 5;
                    continue;
                  case 4:
                    goto label_8;
                  case 5:
                    jobUid1 = jobUid;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 2;
                    continue;
                  case 6:
                    actorKey = schedulerJobActor1.GetPrimaryKey<GuidCompoundKey>();
                    num3 = 8;
                    continue;
                  case 7:
                    currentDateTime1 = currentDateTime;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                    continue;
                  case 8:
                    goto label_5;
                  default:
                    schedulerJob = (ISchedulerJob) null;
                    num3 = 6;
                    continue;
                }
              }
label_8:
              try
              {
                TaskAwaiter<ICollection<ISchedulerJob>> taskAwaiter1;
                TaskAwaiter taskAwaiter2;
                int num4;
                TaskAwaiter awaiter1;
                TaskAwaiter<ICollection<ISchedulerJob>> awaiter2;
                int num5;
                switch (num2)
                {
                  case 0:
label_42:
                    awaiter2 = taskAwaiter1;
                    num4 = 33;
                    break;
                  case 1:
label_17:
                    awaiter1 = taskAwaiter2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 54 : 14;
                    goto label_11;
                  case 2:
label_62:
                    awaiter1 = taskAwaiter2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 24 : 13;
                    goto label_11;
                  default:
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 0;
                    goto label_11;
                }
label_10:
                num5 = num4;
label_11:
                ISchedulerJobDbRepository schedulerJobDbRepository;
                IEnumerator<IJob> enumerator1;
                string stringKey;
                DateTime? nullable;
                IJob job1;
                ICollection<ISchedulerJob> result;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 4:
                    case 20:
                    case 36:
                    case 50:
                      goto label_106;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      SchedulerJobActor.\u003CRunInternal\u003Ed__9.ra7Y4fQZ6f9b0fNswDYt((object) (ISchedulerJobDb) schedulerJob);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 30 : 31;
                      continue;
                    case 3:
                    case 35:
                      result = awaiter2.GetResult();
                      num5 = 16;
                      continue;
                    case 5:
                      if (!jobUid1.HasValue)
                      {
                        num5 = 13;
                        continue;
                      }
                      goto label_71;
                    case 6:
                    case 41:
                      Func<IJob, bool> func;
                      // ISSUE: reference to a compiler-generated method
                      awaiter1 = SchedulerJobActor.\u003CRunInternal\u003Ed__9.xXxeEAQZmSHx6woU9mRN((object) schedulerJobActor1.RunExternalTask((Func<Task>) (() =>
                      {
                        int num6 = 2;
                        CallContextSessionOwner contextSessionOwner;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              goto label_3;
                            case 2:
                              contextSessionOwner = CallContextSessionOwner.Create();
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                              continue;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        return (Task) SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.f0IljcQZe9bh4Mmu2l9e();
label_3:
                        try
                        {
                          int num7;
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (!SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.N2XlHSQZnv6eB1optHdo((object) actorKey.StringKey, SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.lcCI52QZkAQZ5ph5jV6E(--1333735954 ^ 1333669064)))
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                          else
                            goto label_6;
label_5:
                          IJob job2;
                          while (true)
                          {
                            switch (num7)
                            {
                              case 2:
                                goto label_2;
                              case 3:
                                schedulerJobActor.RunJob(currentDateTime1, schedulerJob, job2);
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 0;
                                continue;
                              case 4:
                                goto label_6;
                              default:
                                ICollection<IJob> jobs = schedulerJob.Jobs;
                                Func<IJob, bool> func1 = func;
                                // ISSUE: reference to a compiler-generated method
                                Func<IJob, bool> predicate = func1 == null ? (func = (Func<IJob, bool>) (job => SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.a68Z0AQZPks6cU6TvbBc((object) job) == jobUid1.Value)) : func1;
                                job2 = jobs.First<IJob>(predicate);
                                num7 = 3;
                                continue;
                            }
                          }
label_6:
                          schedulerJob = schedulerJobActor.Reload(actorKey.GuidKey);
                          num7 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                          {
                            num7 = 1;
                            goto label_5;
                          }
                          else
                            goto label_5;
                        }
                        finally
                        {
                          if (contextSessionOwner != null)
                          {
                            int num8 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                              num8 = 0;
                            while (true)
                            {
                              switch (num8)
                              {
                                case 1:
                                  goto label_15;
                                default:
                                  contextSessionOwner.Dispose();
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_15:;
                        }
                      })));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 8 : 26;
                      continue;
                    case 7:
                    case 37:
                      awaiter1.GetResult();
                      num5 = 20;
                      continue;
                    case 8:
                      goto label_62;
                    case 9:
                      goto label_71;
                    case 10:
                      stringKey = actorKey.StringKey;
                      num5 = 25;
                      continue;
                    case 11:
                      if (job1 != null)
                        goto case 17;
                      else
                        goto label_67;
                    case 12:
                      if (forceRunJob)
                        goto case 5;
                      else
                        goto label_46;
                    case 13:
                      enumerator1 = schedulerJob.Jobs.GetEnumerator();
                      num5 = 47;
                      continue;
                    case 14:
                      if (!nullable.HasValue)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 4;
                        continue;
                      }
                      goto case 5;
                    case 15:
                    case 31:
                    case 56:
                      if (schedulerJob == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 27 : 36;
                        continue;
                      }
                      goto case 12;
                    case 16:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ISchedulerJob schedulerJob1 = result.FirstOrDefault<ISchedulerJob>((Func<ISchedulerJob, bool>) (job => SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.DgBeeNQZXjNV84avmNmr(SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.R2LiNSQZKJLZkuXHSggQ(SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.Ye7TFGQZqQV0cQGIOTUZ((object) job)), actorKey.GuidKey)));
                      if (schedulerJob1 == null)
                      {
                        ISchedulerJobDbRepository schedulerJobDbRepository1 = schedulerJobDbRepository;
                        ISchedulerTask task = schedulerJobActor1.schedulerTaskManager.Load(actorKey.GuidKey);
                        nullable = new DateTime?();
                        DateTime? customExecuteTime = nullable;
                        schedulerJob1 = schedulerJobDbRepository1.CreateSchedulerJob(task, customExecuteTime);
                      }
                      schedulerJob = schedulerJob1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
                      continue;
                    case 17:
                      ISchedulerJobRunInfoManager jobRunInfoManager1 = schedulerJobActor1.schedulerJobRunInfoManager;
                      // ISSUE: reference to a compiler-generated method
                      object obj1 = SchedulerJobActor.\u003CRunInternal\u003Ed__9.Vmn8jCQZHGhEEemXaDwl((object) schedulerJob);
                      IJob job3 = job1;
                      DateTime dateToRun1 = currentDateTime1;
                      JobResult jobResult1 = new JobResult();
                      // ISSUE: reference to a compiler-generated method
                      SchedulerJobActor.\u003CRunInternal\u003Ed__9.a8qkjtQZAuBeFvFSL2tr((object) jobResult1, JobStatus.Pending);
                      // ISSUE: reference to a compiler-generated method
                      SchedulerJobActor.\u003CRunInternal\u003Ed__9.pjVT1sQZ7J7AtVfs8JiK((object) jobRunInfoManager1, obj1, (object) job3, dateToRun1, (object) jobResult1);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 22 : 7;
                      continue;
                    case 18:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 2;
                      num5 = 21;
                      continue;
                    case 19:
                      goto label_17;
                    case 21:
                      taskAwaiter2 = awaiter1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 34;
                      continue;
                    case 22:
label_35:
                      if (jobUid1.HasValue)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 6 : 4;
                        continue;
                      }
                      goto case 48;
                    case 23:
                      taskAwaiter2 = awaiter1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                      continue;
                    case 24:
                      taskAwaiter2 = new TaskAwaiter();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 42 : 15;
                      continue;
                    case 25:
                      // ISSUE: reference to a compiler-generated method
                      if (SchedulerJobActor.\u003CRunInternal\u003Ed__9.tjRxQVQZwqPa2UXrc7XY((object) stringKey, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767659703)))
                      {
                        num5 = 32;
                        continue;
                      }
                      goto case 43;
                    case 26:
                      if (awaiter1.IsCompleted)
                      {
                        num5 = 38;
                        continue;
                      }
                      goto case 18;
                    case 27:
                    case 32:
                      IEnumerable<ISchedulerJobRepository> schedulerJobRepositories = schedulerJobActor1.schedulerJobRepositories;
                      // ISSUE: reference to a compiler-generated field
                      Func<ISchedulerJobRepository, bool> func2 = SchedulerJobActor.\u003C\u003Ec.\u003C\u003E9__9_0;
                      Func<ISchedulerJobRepository, bool> predicate1;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        SchedulerJobActor.\u003C\u003Ec.\u003C\u003E9__9_0 = predicate1 = (Func<ISchedulerJobRepository, bool>) (repository => !(repository is ISchedulerJobDbRepository));
                      }
                      else
                        goto label_108;
label_80:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      schedulerJob = schedulerJobRepositories.Where<ISchedulerJobRepository>(predicate1).SelectMany<ISchedulerJobRepository, ISchedulerJob>((Func<ISchedulerJobRepository, IEnumerable<ISchedulerJob>>) (repository => (IEnumerable<ISchedulerJob>) repository.GetSchedulerJobs())).FirstOrDefault<ISchedulerJob>((Func<ISchedulerJob, bool>) (job => SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.DgBeeNQZXjNV84avmNmr(SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.R2LiNSQZKJLZkuXHSggQ(SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.Ye7TFGQZqQV0cQGIOTUZ((object) job)), actorKey.GuidKey)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 15;
                      continue;
label_108:
                      predicate1 = func2;
                      goto label_80;
                    case 28:
                      goto label_100;
                    case 29:
                      goto label_96;
                    case 30:
                      if (awaiter2.IsCompleted)
                      {
                        num5 = 35;
                        continue;
                      }
                      goto case 53;
                    case 33:
                      taskAwaiter1 = new TaskAwaiter<ICollection<ISchedulerJob>>();
                      num5 = 46;
                      continue;
                    case 34:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SchedulerJobActor.\u003CRunInternal\u003Ed__9>(ref awaiter1, this);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 44 : 30;
                      continue;
                    case 38:
                    case 55:
                      awaiter1.GetResult();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                      continue;
                    case 39:
                      awaiter2 = schedulerJobDbRepository.GetSchedulerJobs(currentDateTime1).GetAwaiter();
                      num5 = 30;
                      continue;
                    case 40:
                      goto label_42;
                    case 42:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 55 : 11;
                      continue;
                    case 43:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!SchedulerJobActor.\u003CRunInternal\u003Ed__9.tjRxQVQZwqPa2UXrc7XY((object) stringKey, SchedulerJobActor.\u003CRunInternal\u003Ed__9.P0w56AQZ4yboxMpgbLAS(-97972138 ^ -98038132)))
                      {
                        num5 = 56;
                        continue;
                      }
                      goto case 58;
                    case 44:
                      goto label_90;
                    case 45:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 23 : 16;
                      continue;
                    case 46:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 3 : 0;
                      continue;
                    case 47:
                      try
                      {
label_22:
                        // ISSUE: reference to a compiler-generated method
                        if (SchedulerJobActor.\u003CRunInternal\u003Ed__9.AqxJtoQZxN7qKSXicOZL((object) enumerator1))
                          goto label_24;
                        else
                          goto label_23;
label_20:
                        IJob current;
                        int num9;
                        while (true)
                        {
                          switch (num9)
                          {
                            case 1:
                              goto label_35;
                            case 2:
                              goto label_22;
                            case 3:
                              ISchedulerJobRunInfoManager jobRunInfoManager2 = schedulerJobActor1.schedulerJobRunInfoManager;
                              // ISSUE: reference to a compiler-generated method
                              object obj2 = SchedulerJobActor.\u003CRunInternal\u003Ed__9.Vmn8jCQZHGhEEemXaDwl((object) schedulerJob);
                              IJob job4 = current;
                              DateTime dateToRun2 = currentDateTime1;
                              JobResult jobResult2 = new JobResult();
                              // ISSUE: reference to a compiler-generated method
                              SchedulerJobActor.\u003CRunInternal\u003Ed__9.a8qkjtQZAuBeFvFSL2tr((object) jobResult2, JobStatus.Pending);
                              // ISSUE: reference to a compiler-generated method
                              SchedulerJobActor.\u003CRunInternal\u003Ed__9.pjVT1sQZ7J7AtVfs8JiK((object) jobRunInfoManager2, obj2, (object) job4, dateToRun2, (object) jobResult2);
                              num9 = 2;
                              continue;
                            default:
                              goto label_24;
                          }
                        }
label_23:
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                        goto label_20;
label_24:
                        current = enumerator1.Current;
                        num9 = 3;
                        goto label_20;
                      }
                      finally
                      {
                        if (num2 < 0)
                        {
                          int num10 = 3;
                          while (true)
                          {
                            switch (num10)
                            {
                              case 2:
                                // ISSUE: reference to a compiler-generated method
                                SchedulerJobActor.\u003CRunInternal\u003Ed__9.FdwPqeQZ0HQFeU6FjGym((object) enumerator1);
                                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                                continue;
                              case 3:
                                if (enumerator1 == null)
                                {
                                  num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
                                  continue;
                                }
                                goto case 2;
                              default:
                                goto label_31;
                            }
                          }
                        }
label_31:;
                      }
                    case 48:
                      // ISSUE: reference to a compiler-generated method
                      awaiter1 = SchedulerJobActor.\u003CRunInternal\u003Ed__9.xXxeEAQZmSHx6woU9mRN((object) schedulerJobActor1.RunExternalTask((Func<Task>) (() =>
                      {
                        int num11 = 1;
                        CallContextSessionOwner contextSessionOwner;
                        while (true)
                        {
                          switch (num11)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              contextSessionOwner = (CallContextSessionOwner) SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.kFZ1DTQZTbe2CTIrnqub();
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                              continue;
                            case 2:
                              goto label_2;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        return (Task) SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.f0IljcQZe9bh4Mmu2l9e();
label_4:
                        try
                        {
                          int num12;
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          if (SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.N2XlHSQZnv6eB1optHdo((object) actorKey.StringKey, SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.lcCI52QZkAQZ5ph5jV6E(-2099751081 ^ -2099689075)))
                            num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                          else
                            goto label_8;
label_7:
                          while (true)
                          {
                            switch (num12)
                            {
                              case 1:
                                schedulerJob = schedulerJobActor.Reload(actorKey.GuidKey);
                                num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 2;
                                continue;
                              case 2:
                                goto label_8;
                              default:
                                goto label_11;
                            }
                          }
label_11:
                          IEnumerator<IJob> enumerator2;
                          try
                          {
label_15:
                            // ISSUE: reference to a compiler-generated method
                            if (SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.PJdmO0QZOdS3hYP0Agm3((object) enumerator2))
                              goto label_14;
                            else
                              goto label_16;
label_13:
                            IJob current;
                            int num13;
                            while (true)
                            {
                              switch (num13)
                              {
                                case 1:
                                  goto label_14;
                                case 2:
                                  goto label_2;
                                case 3:
                                  schedulerJobActor.RunJob(currentDateTime1, schedulerJob, current);
                                  num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                                  continue;
                                default:
                                  goto label_15;
                              }
                            }
label_14:
                            current = enumerator2.Current;
                            num13 = 3;
                            goto label_13;
label_16:
                            num13 = 2;
                            goto label_13;
                          }
                          finally
                          {
                            int num14;
                            if (enumerator2 == null)
                              num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                            else
                              goto label_21;
label_20:
                            switch (num14)
                            {
                              case 2:
                                break;
                              default:
                            }
label_21:
                            // ISSUE: reference to a compiler-generated method
                            SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.NydGYRQZ24BKeje67vZs((object) enumerator2);
                            num14 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
                            {
                              num14 = 0;
                              goto label_20;
                            }
                            else
                              goto label_20;
                          }
label_8:
                          enumerator2 = schedulerJob.Jobs.GetEnumerator();
                          num12 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                          {
                            num12 = 0;
                            goto label_7;
                          }
                          else
                            goto label_7;
                        }
                        finally
                        {
                          if (contextSessionOwner != null)
                          {
                            int num15 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                              num15 = 0;
                            while (true)
                            {
                              switch (num15)
                              {
                                case 1:
                                  goto label_29;
                                default:
                                  // ISSUE: reference to a compiler-generated method
                                  SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.NydGYRQZ24BKeje67vZs((object) contextSessionOwner);
                                  num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_29:;
                        }
                      })));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 49 : 9;
                      continue;
                    case 49:
                      if (awaiter1.IsCompleted)
                      {
                        num5 = 7;
                        continue;
                      }
                      goto case 45;
                    case 51:
                      // ISSUE: reference to a compiler-generated method
                      nullable = SchedulerHelper.GetDateTimeToRun((ITrigger) SchedulerJobActor.\u003CRunInternal\u003Ed__9.Vmn8jCQZHGhEEemXaDwl((object) schedulerJob), currentDateTime1, schedulerJobActor1.schedulerJobRunInfoManager, schedulerJobActor1.runtimeApplication);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 14 : 6;
                      continue;
                    case 52:
                      taskAwaiter1 = awaiter2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 57 : 52;
                      continue;
                    case 53:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 52 : 52;
                      continue;
                    case 54:
                      taskAwaiter2 = new TaskAwaiter();
                      num5 = 59;
                      continue;
                    case 57:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ICollection<ISchedulerJob>>, SchedulerJobActor.\u003CRunInternal\u003Ed__9>(ref awaiter2, this);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 28 : 22;
                      continue;
                    case 58:
                      schedulerJobDbRepository = schedulerJobActor1.schedulerJobRepositories.OfType<ISchedulerJobDbRepository>().First<ISchedulerJobDbRepository>();
                      num5 = 39;
                      continue;
                    case 59:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 37 : 22;
                      continue;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SchedulerJobActor.\u003CRunInternal\u003Ed__9>(ref awaiter1, this);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 29 : 10;
                      continue;
                  }
                }
label_100:
                return;
label_96:
                return;
label_90:
                return;
label_46:
                num4 = 51;
                goto label_10;
label_67:
                num4 = 50;
                goto label_10;
label_71:
                // ISSUE: reference to a compiler-generated method
                job1 = schedulerJob.Jobs.FirstOrDefault<IJob>((Func<IJob, bool>) (job => SchedulerJobActor.\u003C\u003Ec__DisplayClass9_0.DgBeeNQZXjNV84avmNmr(job.Id, jobUid1.Value)));
                num4 = 11;
                goto label_10;
              }
              finally
              {
                int num16;
                if (num2 >= 0)
                  num16 = 2;
                else
                  goto label_88;
label_86:
                switch (num16)
                {
                  case 1:
                  case 2:
                }
label_88:
                schedulerJobActor1.DeactivateOnIdle();
                num16 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                {
                  num16 = 1;
                  goto label_86;
                }
                else
                  goto label_86;
              }
            }
            catch (Exception ex)
            {
              int num17 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                num17 = 1;
              while (true)
              {
                switch (num17)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_87;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num17 = 2;
                    continue;
                }
              }
label_87:
              return;
            }
          default:
            schedulerJobActor1 = this;
            num1 = 5;
            continue;
        }
      }
label_103:;
    }

    /// <summary>Загрузить задачу из БД</summary>
    /// <param name="taskId">Идентификатор задачи</param>
    private ISchedulerJob Reload(Guid taskId) => this.schedulerJobRepositories.OfType<ISchedulerJobDbRepository>().Single<ISchedulerJobDbRepository>().CreateSchedulerJob(this.schedulerTaskManager.Load(taskId));

    /// <summary>
    /// Выполнить задачу из запланированной работы планировщика
    /// </summary>
    /// <param name="currentDateTime">Текущая дата/время</param>
    /// <param name="schedulerJob">Запланированная работы планировщика</param>
    /// <param name="job">Задача</param>
    private void RunJob(DateTime currentDateTime, ISchedulerJob schedulerJob, IJob job)
    {
      int num1 = 2;
      DateTime now;
      JobResult result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            now = DateTime.Now;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
            continue;
          case 2:
            ISchedulerJobRunInfoManager jobRunInfoManager = this.schedulerJobRunInfoManager;
            object obj = SchedulerJobActor.Y8WVmLBqeJrDckNy8pkn((object) schedulerJob);
            IJob job1 = job;
            DateTime dateToRun = currentDateTime;
            JobResult result2 = new JobResult();
            SchedulerJobActor.Iok6WvBqPRkf1UhlBNJP((object) result2, JobStatus.Working);
            jobRunInfoManager.SetResult((ITrigger) obj, job1, dateToRun, result2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          case 3:
            this.schedulerJobRunInfoManager.SetResult((ITrigger) SchedulerJobActor.Y8WVmLBqeJrDckNy8pkn((object) schedulerJob), job, now, new DateTime?(now), result1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 0;
            continue;
          case 4:
            goto label_10;
          case 5:
label_14:
            this.RefreshSchedulerJobImpl(schedulerJob);
            num1 = 3;
            continue;
          default:
            try
            {
              result1 = job.Do(now);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_14;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    JobResult jobResult = new JobResult();
                    SchedulerJobActor.Iok6WvBqPRkf1UhlBNJP((object) jobResult, JobStatus.Fail);
                    SchedulerJobActor.DPFuDSBq1RF6covn40Wg((object) jobResult, (object) ex.ToString());
                    result1 = jobResult;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_14;
                }
              }
            }
        }
      }
label_10:;
    }

    /// <summary>Обновить запланированную работу планировщика из БД</summary>
    /// <param name="schedulerJob">Запланированная работа планировщика</param>
    private void RefreshSchedulerJobImpl(ISchedulerJob schedulerJob)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (!(schedulerJob is ISchedulerJobDb schedulerJobDb))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
              continue;
            }
            goto case 3;
          case 3:
            schedulerJobDb.Refresh();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    internal static DateTime ItLQZuBq2Ff06ViveePd() => DateTime.Now;

    internal static bool w2iRhhBqn7rXFVxMr6kR() => SchedulerJobActor.GmuhUhBqk6F1QlXoPQ9C == null;

    internal static SchedulerJobActor v3MY6lBqO9i8t6eEq6vx() => SchedulerJobActor.GmuhUhBqk6F1QlXoPQ9C;

    internal static object Y8WVmLBqeJrDckNy8pkn([In] object obj0) => (object) ((ISchedulerJob) obj0).Trigger;

    internal static void Iok6WvBqPRkf1UhlBNJP([In] object obj0, JobStatus value) => ((JobResult) obj0).Status = value;

    internal static void DPFuDSBq1RF6covn40Wg([In] object obj0, [In] object obj1) => ((JobResult) obj0).ErrorDescription = (string) obj1;
  }
}
