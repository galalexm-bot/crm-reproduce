// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Infrastructure.Workspace
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.OmniSharp.Infrastructure
{
  /// <summary>Рабочее пространство OmniSharp</summary>
  internal class Workspace : IDisposable
  {
    private static readonly string[] ValidChangeReferenceCommands;
    private static readonly WebExceptionStatus[] TransientFailures;
    private readonly TimeSpan defaultInterval;
    private readonly HashSet<string> addedAssembliesSync;
    private readonly HashSet<string> addedWebReferencesSync;
    private readonly ConcurrentQueue<ReferenceOperation> referenceQueue;
    private string key;
    private volatile bool isCreated;
    private volatile bool mustRestoreReferences;
    private readonly SimpleWebClient client;
    private readonly IConnectionMonitor monitor;
    private readonly ILogger logger;
    private readonly string project;
    private System.Threading.Timer tracker;
    internal static Workspace PJZWkFWrt9yxZJyj9Dy5;

    /// <summary>Ctor</summary>
    /// <param name="fileName">Путь к редактируемому файлу</param>
    /// <param name="projectPath">Путь к папке с редактиремым проектом</param>
    /// <param name="csprojPathProvider">Провайдер пути к файлу csproj-проекта</param>
    /// <param name="client">Веб-клиент, нацеленный на веб-службу omnisharp</param>
    /// <param name="monitor">Монитор состояния соединения с omnisharp</param>
    /// <param name="logger">Логгер</param>
    public Workspace(
      string fileName,
      string projectPath,
      Func<string, string> csprojPathProvider,
      SimpleWebClient client,
      IConnectionMonitor monitor,
      ILogger logger)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.defaultInterval = TimeSpan.FromSeconds(2.0);
      this.addedAssembliesSync = new HashSet<string>();
      this.addedWebReferencesSync = new HashSet<string>();
      this.referenceQueue = new ConcurrentQueue<ReferenceOperation>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) csprojPathProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867499493));
      this.FileName = fileName;
      this.ProjectFolder = projectPath;
      this.ProjectPath = csprojPathProvider(projectPath);
      this.client = client;
      this.logger = logger;
      this.monitor = monitor;
      this.project = new DirectoryInfo(projectPath).Name;
      this.tracker = new System.Threading.Timer(new TimerCallback(this.Synchronize));
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            System.Threading.Timer tracker = this.tracker;
            if (tracker == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            }
            Workspace.IIISocWr6kl7SeUAo5X0((object) tracker);
            num = 3;
            continue;
          case 2:
            goto label_5;
          default:
            this.tracker = (System.Threading.Timer) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
            continue;
        }
      }
label_5:;
    }

    /// <summary>Путь к редактируемому файлу</summary>
    public string FileName { get; }

    /// <summary>Ключ рабочей области, выданный сервером OmniSharp</summary>
    public string Key => this.key;

    /// <summary>Путь к папке редактируемого проекта</summary>
    public string ProjectFolder { get; }

    /// <summary>Путь к файлу csproj редактируемого проекта</summary>
    public string ProjectPath { get; }

    /// <summary>Создать рабочее пространство на сервере OmniSharp</summary>
    /// <returns>Задача по созданию рабочего пространства</returns>
    public async Task<bool> Create()
    {
      int num1 = 4;
      int num2;
      bool result1;
      Workspace workspace;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_50:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 2 : 5;
            continue;
          case 2:
            goto label_49;
          case 3:
            workspace = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 3;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 2;
            continue;
          default:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
              else
                goto label_7;
label_5:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (!Workspace.\u003CCreate\u003Ed__31.IQAy5QQc4hrdcmU53uq2((object) workspace))
                    {
                      num3 = 2;
                      continue;
                    }
                    goto case 5;
                  case 2:
                  case 3:
                    goto label_7;
                  case 4:
                    goto label_50;
                  case 5:
                    result1 = true;
                    num3 = 4;
                    continue;
                  default:
                    goto label_11;
                }
              }
label_11:
              try
              {
                int num4;
                if (num2 != 0)
                  num4 = 5;
                else
                  goto label_28;
label_14:
                int num5 = num4;
label_15:
                TaskAwaiter<Dictionary<string, string>> taskAwaiter;
                TaskAwaiter<Dictionary<string, string>> awaiter;
                Dictionary<string, string> result2;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num5 = 10;
                      continue;
                    case 3:
                      workspace.isCreated = true;
                      num5 = 15;
                      continue;
                    case 4:
                      goto label_28;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      workspace.CheckIfOffline((string) Workspace.\u003CCreate\u003Ed__31.L5U0I6Qc6Cel1oUkpGMA(-1822890472 ^ -1822907284));
                      num5 = 6;
                      continue;
                    case 6:
                      awaiter = workspace.SendCreateWorkspaceCommand().GetAwaiter();
                      num5 = 7;
                      continue;
                    case 7:
                      if (!awaiter.IsCompleted)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 10;
                    case 8:
                      goto label_50;
                    case 9:
                      taskAwaiter = new TaskAwaiter<Dictionary<string, string>>();
                      num5 = 2;
                      continue;
                    case 10:
                      result2 = awaiter.GetResult();
                      num5 = 12;
                      continue;
                    case 11:
                      goto label_46;
                    case 12:
                      // ISSUE: reference to a compiler-generated method
                      workspace.key = result2[(string) Workspace.\u003CCreate\u003Ed__31.L5U0I6Qc6Cel1oUkpGMA(-1445902765 ^ -1980277732 ^ 539202921)];
                      num5 = 3;
                      continue;
                    case 13:
                      result1 = true;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 8 : 6;
                      continue;
                    case 14:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<string, string>>, Workspace.\u003CCreate\u003Ed__31>(ref awaiter, this);
                      num5 = 11;
                      continue;
                    case 15:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      workspace.PrintInfo((string) Workspace.\u003CCreate\u003Ed__31.L5U0I6Qc6Cel1oUkpGMA(-1088304168 ^ -1088321108), (string) Workspace.\u003CCreate\u003Ed__31.P17gOGQcHq6RYVuipIoO(Workspace.\u003CCreate\u003Ed__31.L5U0I6Qc6Cel1oUkpGMA(-1255365154 ^ 596875508 ^ -1766149528), (object) workspace.key, Workspace.\u003CCreate\u003Ed__31.L5U0I6Qc6Cel1oUkpGMA(236071375 ^ 236074129)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 13 : 4;
                      continue;
                    default:
                      goto label_25;
                  }
                }
label_46:
                return;
label_25:
                taskAwaiter = awaiter;
                num4 = 14;
                goto label_14;
label_28:
                awaiter = taskAwaiter;
                num5 = 9;
                goto label_15;
              }
              catch (TransientWorkspaceError ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_50;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      Workspace.\u003CCreate\u003Ed__31.yfYWCuQcAWQ6q2kN0qDH((object) workspace);
                      num6 = 3;
                      continue;
                    case 3:
                      result1 = false;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                      continue;
                    default:
                      workspace.PrintTransientWorkspaceError(ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 1;
                      continue;
                  }
                }
              }
              catch (FatalWorkspaceError ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      workspace.PrintFatalWorkspaceError(ex);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_42;
                  }
                }
label_42:
                throw;
              }
label_7:
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
              {
                num3 = 0;
                goto label_5;
              }
              else
                goto label_5;
            }
            catch (Exception ex)
            {
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                num8 = 0;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_40;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = 2;
                    continue;
                }
              }
label_40:
              return;
            }
        }
      }
label_49:;
    }

    /// <summary>Сделать запрос информации по коду</summary>
    /// <param name="request">Запрос</param>
    /// <returns>Ответ на запрос в виде асинхронной задачи</returns>
    public Task<string> Query(OmniSharpRequest request)
    {
      if (this.IsWorkspaceCreated)
      {
        if (!this.IsOffline)
        {
          try
          {
            string data = this.ProduceCodeQueryPostData(request);
            return this.client.Post(request.Command, data);
          }
          catch (WebException ex)
          {
            return Task.FromResult<string>(string.Empty);
          }
        }
      }
      return Task.FromResult<string>(string.Empty);
    }

    /// <summary>Добавить сборки в рабочую область</summary>
    /// <param name="assembliesPath">Набор путей к добавляемым сборками</param>
    /// <param name="webReferencesPath">Набор путей к добавляемым исходным файлам веб-сервисов</param>
    /// <returns>Задача по добавлению сборок в рабочее пространство</returns>
    public Task<bool> AddReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      return this.ChangeReferences(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654179687), assembliesPath, webReferencesPath);
    }

    /// <summary>Убрать сборки из рабочей области</summary>
    /// <param name="assembliesPath">Набор путей к удаляемым сборками</param>
    /// <param name="webReferencesPath">Набор путей к удаляемым исходным файлам веб-сервисов</param>
    /// <returns>Задача по удалению сборок в рабочее пространство</returns>
    public Task<bool> RemoveReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      return this.ChangeReferences(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629710016), assembliesPath, webReferencesPath);
    }

    /// <summary>
    /// Принудительно пересоздать (восстановить) рабочее пространство по имеющимся локально данным
    /// </summary>
    public void ForceRestore()
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              this.key = string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 3;
              continue;
            case 3:
              this.PrintDebug((string) Workspace.gc0w6NWrHZY3thQRLmHi(236071375 ^ 235937605), (Func<string>) (() => (string) Workspace.gc0w6NWrHZY3thQRLmHi(1669371371 ^ 1669509089) + this.FormatChangeReferencesCommand((string) Workspace.gc0w6NWrHZY3thQRLmHi(-1487388570 ^ -1487248548), (IEnumerable<string>) this.addedAssembliesSync, (IEnumerable<string>) this.addedWebReferencesSync)));
              num2 = 4;
              continue;
            case 4:
              this.ScheduleNextSync();
              num2 = 6;
              continue;
            case 6:
              goto label_11;
            case 7:
              if (this.addedWebReferencesSync.Count <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
                continue;
              }
              break;
            case 8:
              if (this.addedAssembliesSync.Count <= 0)
                goto case 7;
              else
                goto label_8;
            case 9:
              this.isCreated = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 8;
              continue;
          }
          this.mustRestoreReferences = true;
          num2 = 5;
        }
label_8:
        num1 = 2;
      }
label_11:;
    }

    /// <summary>Изменить ссылки</summary>
    /// <param name="command">Команда (вид изменения)</param>
    /// <param name="assembliesPath">Набор путей сборками</param>
    /// <param name="webReferencesPath">Набор путей к исходным файлам веб-сервисов</param>
    /// <returns>Задача по изменению ссылок в рабочем простанстве, возвращает <c>true</c>, если изменение прошло успешно, в протитвном случае - <c>false</c></returns>
    /// <exception cref="T:System.ArgumentException">Передана неправильная/неизвестная команда</exception>
    public async Task<bool> ChangeReferences(
      string command,
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        bool result;
        Workspace workspace;
        switch (num1)
        {
          case 1:
            workspace = this;
            num1 = 4;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 5;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 3;
              else
                goto label_6;
label_4:
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    goto label_5;
                  case 3:
                    if (((IEnumerable<string>) Workspace.ValidChangeReferenceCommands).Contains<string>(command))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_6;
                }
              }
label_5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              throw new ArgumentException((string) Workspace.\u003CChangeReferences\u003Ed__36.dvbpNFQcmOKLtQKf5wna(-688192331 - 435440695 ^ -1123637984) + command + (string) Workspace.\u003CChangeReferences\u003Ed__36.dvbpNFQcmOKLtQKf5wna(-1710575414 ^ -1710276698));
label_10:
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = 9;
                else
                  goto label_20;
label_12:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Workspace.\u003CChangeReferences\u003Ed__36>(ref awaiter, this);
                      num4 = 10;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (Workspace.\u003CChangeReferences\u003Ed__36.SjaSn6Qcy7DnvhE68CHX((object) workspace))
                      {
                        num4 = 3;
                        continue;
                      }
                      // ISSUE: reference to a compiler-generated method
                      awaiter = Workspace.\u003CChangeReferences\u003Ed__36.EZW7GnQcMOgV5ovcAhAB((object) workspace.SendChangeReferencesCommand(command, assembliesPath, webReferencesPath));
                      num4 = 12;
                      continue;
                    case 3:
                      goto label_24;
                    case 4:
                      result = true;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 7 : 1;
                      continue;
                    case 5:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 11 : 6;
                      continue;
                    case 6:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 4 : 2;
                      continue;
                    case 7:
                      goto label_52;
                    case 8:
                    case 9:
                      awaiter = taskAwaiter;
                      num4 = 14;
                      continue;
                    case 10:
                      goto label_45;
                    case 11:
                      taskAwaiter = awaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
                      continue;
                    case 12:
                      if (!awaiter.IsCompleted)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 6;
                    case 13:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 6;
                      continue;
                    case 14:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 13;
                      continue;
                    default:
                      goto label_20;
                  }
                }
label_45:
                return;
label_24:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                throw new TransientWorkspaceError(workspace.FormatDebugMessage((string) Workspace.\u003CChangeReferences\u003Ed__36.dvbpNFQcmOKLtQKf5wna(1819636893 << 3 ^ 1672358700), (string) Workspace.\u003CChangeReferences\u003Ed__36.dvbpNFQcmOKLtQKf5wna(-1217523399 ^ -1217683759)));
label_20:
                // ISSUE: reference to a compiler-generated method
                workspace.CheckIfOffline((string) Workspace.\u003CChangeReferences\u003Ed__36.dvbpNFQcmOKLtQKf5wna(-1290212282 ^ -644262414 ^ 1787049584));
                num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                {
                  num4 = 0;
                  goto label_12;
                }
                else
                  goto label_12;
              }
              catch (TransientWorkspaceError ex)
              {
                int num5 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
                  num5 = 2;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      Workspace.\u003CChangeReferences\u003Ed__36.ehs3atQcJSn5LuJoyOIU((object) workspace);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_52;
                    case 3:
                      workspace.PrintTransientWorkspaceError(ex);
                      num5 = 4;
                      continue;
                    case 4:
                      workspace.EnqueueReferenceChanges(command, assembliesPath, webReferencesPath);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
                      continue;
                    default:
                      result = false;
                      num5 = 2;
                      continue;
                  }
                }
              }
              catch (FatalWorkspaceError ex)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_41;
                    default:
                      workspace.PrintFatalWorkspaceError(ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_41:
                throw;
              }
label_6:
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
              {
                num3 = 1;
                goto label_4;
              }
              else
                goto label_4;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = 2;
                    continue;
                  case 2:
                    goto label_39;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                    continue;
                }
              }
label_39:
              return;
            }
          case 5:
            goto label_48;
        }
label_52:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
      }
label_48:;
    }

    private async Task<Dictionary<string, string>> SendCreateWorkspaceCommand()
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        Dictionary<string, string> result1;
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 4;
            continue;
          case 4:
            goto label_37;
          case 5:
            try
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_7;
                  default:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                    continue;
                }
              }
label_7:
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = 3;
                else
                  goto label_10;
label_9:
                TaskAwaiter<string> taskAwaiter;
                string data;
                TaskAwaiter<string> awaiter;
                string result2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 7;
                      continue;
                    case 2:
                      goto label_24;
                    case 3:
                    case 14:
                      awaiter = taskAwaiter;
                      num4 = 8;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = this.client.Post((string) Workspace.\u003CSendCreateWorkspaceCommand\u003Ed__37.i3bYCqQcr5MBE97N7hYb(647913418 ^ 647745490), data).GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_34;
                    case 6:
                      Dictionary<string, string> dictionary = new JsonSerializer().Deserialize<Dictionary<string, string>>(result2);
                      if (dictionary == null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 1;
                        continue;
                      }
                      result1 = dictionary;
                      num4 = 9;
                      continue;
                    case 7:
                    case 11:
                      result2 = awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 6 : 3;
                      continue;
                    case 8:
                      taskAwaiter = new TaskAwaiter<string>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                      continue;
                    case 9:
                      goto label_38;
                    case 10:
                      taskAwaiter = awaiter;
                      num4 = 12;
                      continue;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Workspace.\u003CSendCreateWorkspaceCommand\u003Ed__37>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 5;
                      continue;
                    case 13:
                      goto label_10;
                    case 15:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = 10;
                      continue;
                    default:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 11;
                        continue;
                      }
                      goto case 15;
                  }
                }
label_34:
                return;
label_24:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                throw new TransientWorkspaceError(this.FormatDebugMessage((string) Workspace.\u003CSendCreateWorkspaceCommand\u003Ed__37.i3bYCqQcr5MBE97N7hYb(-1317790512 ^ -1317958512), (string) Workspace.\u003CSendCreateWorkspaceCommand\u003Ed__37.i3bYCqQcr5MBE97N7hYb(-1858887263 ^ -1858719271)));
label_10:
                data = this.ProduceInitWorkspacePostData();
                num4 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                {
                  num4 = 4;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              catch (WebException ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    // ISSUE: reference to a compiler-generated method
                    throw this.ConvertWebExceptionToWorkspaceError((string) Workspace.\u003CSendCreateWorkspaceCommand\u003Ed__37.i3bYCqQcr5MBE97N7hYb(-1317790512 ^ -1317958512), ex);
                }
              }
            }
            catch (Exception ex)
            {
              int num6 = 2;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_30;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_26;
                }
              }
label_30:
              return;
label_26:
              return;
            }
        }
label_38:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
      }
label_37:;
    }

    private async Task SendChangeReferencesCommand(
      string command,
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_57;
            case 3:
label_58:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 2 : 1;
              continue;
            case 4:
              try
              {
                int num4;
                if (num3 == 0)
                  num4 = 11;
                else
                  goto label_40;
label_5:
                Workspace workspace;
                string command1;
                IEnumerable<string> assembliesPath1;
                IEnumerable<string> webReferencesPath1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 7:
                      goto label_58;
                    case 2:
                    case 8:
                    case 10:
                    case 11:
                      num4 = 5;
                      continue;
                    case 3:
                      command1 = command;
                      num4 = 4;
                      continue;
                    case 4:
                      assembliesPath1 = assembliesPath;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_6;
                    case 6:
                      workspace = this;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 3;
                      continue;
                    case 9:
                      if (webReferencesPath1.Any<string>())
                      {
                        num4 = 10;
                        continue;
                      }
                      goto label_58;
                    case 12:
                      goto label_40;
                    case 13:
                      if (assembliesPath1.Any<string>())
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 2;
                        continue;
                      }
                      goto case 9;
                    default:
                      webReferencesPath1 = webReferencesPath;
                      num4 = 13;
                      continue;
                  }
                }
label_6:
                try
                {
                  int num5;
                  if (num3 != 0)
                    num5 = 12;
                  else
                    goto label_15;
label_9:
                  TaskAwaiter<string> taskAwaiter;
                  ReferenceResponse referenceResponse1;
                  TaskAwaiter<string> awaiter;
                  while (true)
                  {
                    int num6;
                    string data;
                    string result;
                    switch (num5)
                    {
                      case 1:
                        awaiter = this.client.Post(command1, data).GetAwaiter();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                        continue;
                      case 2:
                        ReferenceResponse referenceResponse2 = new JsonSerializer().Deserialize<ReferenceResponse>(result);
                        if (referenceResponse2 == null)
                        {
                          num5 = 15;
                          continue;
                        }
                        referenceResponse1 = referenceResponse2;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 7;
                        continue;
                      case 3:
                        goto label_51;
                      case 4:
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        if (!Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.a5jKHqQzB0hB9T5S3UFH((object) referenceResponse1))
                        {
                          num5 = 14;
                          continue;
                        }
                        goto label_31;
                      case 6:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        this.PrintDebug((string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(2045296739 + 1688595713 ^ -561300044), (Func<string>) (() => (string) Workspace.\u003C\u003Ec__DisplayClass38_0.yP9xWqQcLUglXarbcQQL(-1217523399 ^ -1217691245) + workspace.FormatChangeReferencesCommand(command1, assembliesPath1, webReferencesPath1)));
                        num5 = 9;
                        continue;
                      case 7:
                        // ISSUE: reference to a compiler-generated method
                        if (!Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.IUPfmvQzFdwBculakTqW((object) referenceResponse1))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 4;
                          continue;
                        }
                        goto case 6;
                      case 8:
                        taskAwaiter = new TaskAwaiter<string>();
                        num6 = 19;
                        break;
                      case 9:
                        this.MergeReferences(command1, assembliesPath1, webReferencesPath1);
                        num5 = 20;
                        continue;
                      case 10:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num3 = 0;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 13;
                        continue;
                      case 11:
                        goto label_15;
                      case 12:
                        data = this.ProduceReferencePostData(assembliesPath1, webReferencesPath1);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                        continue;
                      case 13:
                        taskAwaiter = awaiter;
                        num5 = 16;
                        continue;
                      case 14:
                        goto label_32;
                      case 15:
                        goto label_29;
                      case 16:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, Workspace.\u003CSendChangeReferencesCommand\u003Ed__38>(ref awaiter, this);
                        num5 = 3;
                        continue;
                      case 17:
                        result = awaiter.GetResult();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 2;
                        continue;
                      case 18:
                        goto label_31;
                      case 19:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num3 = -1;
                        num6 = 17;
                        break;
                      case 20:
                        goto label_58;
                      default:
                        if (!awaiter.IsCompleted)
                        {
                          num5 = 10;
                          continue;
                        }
                        goto case 17;
                    }
                    num5 = num6;
                  }
label_51:
                  return;
label_29:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new TransientWorkspaceError(this.FormatDebugMessage((string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(322893104 - -1992822529 ^ -1979542303), (string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(~-306453669 ^ 306285788)));
label_31:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new TransientWorkspaceError(this.FormatDebugMessage((string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(-1204263869 ^ -1341583247 ^ 137684194), (string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(277947046 - -1479185048 ^ 1757291572) + this.FormatChangeReferencesCommand(command1, assembliesPath1, webReferencesPath1)));
label_32:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  throw new FatalWorkspaceError(this.FormatDebugMessage((string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(-1487388570 ^ -1487023946), (string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.pOOJobQzWOe07XkUYjEf(Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(813604817 ^ 813371011), (object) this.FormatChangeReferencesCommand(command1, assembliesPath1, webReferencesPath1), Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(1917256330 ^ 1916965650), (object) referenceResponse1.Description)));
label_15:
                  awaiter = taskAwaiter;
                  num5 = 8;
                  goto label_9;
                }
                catch (WebException ex)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                    num7 = 0;
                  switch (num7)
                  {
                    default:
                      // ISSUE: reference to a compiler-generated method
                      throw this.ConvertWebExceptionToWorkspaceError((string) Workspace.\u003CSendChangeReferencesCommand\u003Ed__38.fSGossQczBgDP8uVsAXk(1819636893 << 3 ^ 1672361016), ex);
                  }
                }
label_40:
                num4 = 6;
                goto label_5;
              }
              catch (Exception ex)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                  num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_47;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 0;
                      continue;
                  }
                }
label_47:
                return;
              }
            case 5:
              goto label_54;
            default:
              goto label_55;
          }
        }
label_55:
        num1 = 4;
        continue;
label_57:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003Et__builder.SetResult();
        num1 = 5;
      }
label_54:;
    }

    private Exception ConvertWebExceptionToWorkspaceError(string function, WebException ex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (Workspace.qouvGNWrABv47kunaiC4((object) ex))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (Exception) new FatalWorkspaceError(this.FormatDebugMessage(function, (string) Workspace.gc0w6NWrHZY3thQRLmHi(44884861 ^ 45012443)), (Exception) ex);
label_5:
      return (Exception) new TransientWorkspaceError(this.FormatDebugMessage(function, (string) Workspace.G29aSnWrxRRO3Ia18qj6(Workspace.gc0w6NWrHZY3thQRLmHi(~-306453669 ^ 306588286), Workspace.mn9LykWr7JMjkaBkif6n((object) ex), Workspace.gc0w6NWrHZY3thQRLmHi(825385222 ^ 825392826))), (Exception) ex);
    }

    private void MergeReferences(
      string command,
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      if (command == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675369087))
      {
        this.addedAssembliesSync.AddRange<string>(assembliesPath);
        this.addedWebReferencesSync.AddRange<string>(webReferencesPath);
      }
      else
      {
        if (!(command == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638547341)))
          throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837807263) + command);
        assembliesPath.ForEach<string>((Action<string>) (m =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.addedAssembliesSync.Remove(m);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        webReferencesPath.ForEach<string>((Action<string>) (m =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.addedWebReferencesSync.Remove(m);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      }
      this.PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901935385), (Func<string>) (() => (string) Workspace.UJr8ntWrc0IgLewfmoev(Workspace.gc0w6NWrHZY3thQRLmHi(236071375 ^ 235934715), (object) this.FormatChangeReferencesCommand((string) Workspace.gc0w6NWrHZY3thQRLmHi(222162814 ^ 222284868), (IEnumerable<string>) this.addedAssembliesSync, (IEnumerable<string>) this.addedWebReferencesSync))));
    }

    private string ProduceInitWorkspacePostData() => (string) Workspace.G29aSnWrxRRO3Ia18qj6(Workspace.gc0w6NWrHZY3thQRLmHi(-345420348 ^ -345277888), (object) this.DoubleSlashes(this.ProjectFolder), Workspace.gc0w6NWrHZY3thQRLmHi(-1487388570 ^ -1487243268));

    private string ProduceCodeQueryPostData(OmniSharpRequest request)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) Workspace.v3YVr8WrMQ7iVyp3a7LX((object) new string[6]
            {
              str,
              (string) Workspace.gc0w6NWrHZY3thQRLmHi(-1886646897 ^ -1886504403),
              this.Key,
              (string) Workspace.gc0w6NWrHZY3thQRLmHi(694673736 ^ -23604109 ^ -672005389),
              this.DoubleSlashes(this.FileName),
              (string) Workspace.gc0w6NWrHZY3thQRLmHi(-1939377524 ^ -1939520234)
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            str = (string) Workspace.w5ccpXWryj3SUDd5gqH1(Workspace.k46qBVWr0c04wtpGJ9Bc((object) request), 0, Workspace.dquWXDWrm4xMaRGoCk0l(Workspace.k46qBVWr0c04wtpGJ9Bc((object) request)) - 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return str;
    }

    private string ProduceReferencePostData(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      string str1 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501452665), assembliesPath.Select<string, string>((Func<string, string>) (p => (string) Workspace.yNIofvWrzwPQB6mH69hN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138277866), (object) this.DoubleSlashes(p)))));
      string str2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70019587), webReferencesPath.Select<string, string>((Func<string, string>) (p => (string) Workspace.yNIofvWrzwPQB6mH69hN(Workspace.gc0w6NWrHZY3thQRLmHi(589593376 ^ -1977315327 ^ -1459433137), (object) this.DoubleSlashes(p)))));
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710717150) + this.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16619799) + this.DoubleSlashes(this.ProjectPath) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281979776) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606795404) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574398158);
    }

    private string DoubleSlashes(string path) => (string) Workspace.JYUNUXWrJDLRYEo3Uxur((object) path, Workspace.gc0w6NWrHZY3thQRLmHi(-1445902765 ^ -1980277732 ^ 539362617), Workspace.gc0w6NWrHZY3thQRLmHi(-138018305 ^ -138010927));

    private void Synchronize(object state)
    {
      int num = 4;
      AsyncVoidMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      Workspace.\u003CSynchronize\u003Ed__45 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 1;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = Workspace.bx00wIWr9UeXGHwMPZMt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 2;
            continue;
          case 5:
            tBuilder.Start<Workspace.\u003CSynchronize\u003Ed__45>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    private Task RestoreReferences()
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      Workspace.\u003CRestoreReferences\u003Ed__46 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 3;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = Workspace.Kmw4VxWrdkD7jRyNunxG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 1;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            tBuilder.Start<Workspace.\u003CRestoreReferences\u003Ed__46>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private Task SendReferences()
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      Workspace.\u003CSendReferences\u003Ed__47 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 5;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = Workspace.Kmw4VxWrdkD7jRyNunxG();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 2;
            continue;
          case 4:
            goto label_4;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            tBuilder.Start<Workspace.\u003CSendReferences\u003Ed__47>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 4 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Было ли подтверждено создание рабочей области сервером OmniSharp?
    /// </summary>
    protected virtual bool IsWorkspaceCreated => this.isCreated;

    /// <summary>Находится ли сервер OmniSharp офлайн?</summary>
    protected bool IsOffline => Workspace.oi9jylWrlitQZ77KgioG((object) this.monitor);

    private bool MustRestoreReferences => this.mustRestoreReferences;

    /// <summary>
    /// Имеются ли несинхронизированные элементы в рабочем пространстве?
    /// Полностью ли готово рабочее пространство к работе?
    /// </summary>
    protected virtual bool HasUnsyncItems
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.IsWorkspaceCreated)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 2:
              goto label_6;
            case 4:
              if (this.MustRestoreReferences)
              {
                num = 3;
                continue;
              }
              goto label_6;
            default:
              goto label_7;
          }
        }
label_6:
        return this.HasUnsyncReferences;
label_7:
        return true;
      }
    }

    /// <summary>Имеются ли несинхронизированные ссылки?</summary>
    protected virtual bool HasUnsyncReferences => !Workspace.R2yOCdWrr0jf1fV3Oja0((object) this.referenceQueue);

    private bool IsReferencesSyncingNow => ((IEnumerable<ReferenceOperation>) this.referenceQueue.ToArray()).Any<ReferenceOperation>((Func<ReferenceOperation, bool>) (m => m.IsSyncingNow));

    /// <summary>Запланировать следующую попытку синхронизации</summary>
    protected virtual void ScheduleNextSync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PrintDebug((string) Workspace.gc0w6NWrHZY3thQRLmHi(-1426456882 ^ 2009939514 ^ -583600036), z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405714055));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Workspace.BdX57lWrgrdwJ22Ptnw8((object) this.tracker, this.defaultInterval, Timeout.InfiniteTimeSpan);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Поставить в очередь изменения в ссылках</summary>
    /// <param name="command">Команда (вид изменения)</param>
    /// <param name="assembliesPath">Пути к сборкам</param>
    /// <param name="webReferencesPath">Пути к веб-сервисам</param>
    protected virtual void EnqueueReferenceChanges(
      string command,
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath)
    {
      string[] assemblies = assembliesPath.ToArray<string>();
      string[] webServices = webReferencesPath.ToArray<string>();
      if (assemblies.Length == 0 && webServices.Length == 0)
      {
        this.PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317657560), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767866159));
      }
      else
      {
        this.referenceQueue.Enqueue(new ReferenceOperation(command, (IEnumerable<string>) assemblies, (IEnumerable<string>) webServices));
        // ISSUE: reference to a compiler-generated method
        this.PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824509083), (Func<string>) (() => (string) Workspace.\u003C\u003Ec__DisplayClass61_0.i2BxmgQz3iKqPtZNWcNN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012312985), (object) this.FormatChangeReferencesCommand(command, (IEnumerable<string>) assemblies, (IEnumerable<string>) webServices))));
      }
    }

    private void CheckIfOffline(string function)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.IsOffline)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new TransientWorkspaceError(this.FormatDebugMessage(function, (string) Workspace.gc0w6NWrHZY3thQRLmHi(654297945 ^ 654176823)));
    }

    private void PrintInfo(string function, string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Workspace.faZBriWr5JQyUW3kHJnQ((object) this.logger, (object) this.FormatDebugMessage(function, message));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void PrintDebug(string function, Func<string> messageProvider)
    {
      if (!this.logger.IsDebugEnabled())
        return;
      this.logger.Debug((object) this.FormatDebugMessage(function, messageProvider()));
    }

    private void PrintTransientWorkspaceError(TransientWorkspaceError ex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Workspace.aInAj4WrjhfXjlECi9Bt((object) this.logger, Workspace.mn9LykWr7JMjkaBkif6n((object) ex));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void PrintFatalWorkspaceError(FatalWorkspaceError ex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Workspace.YYtZY5WrYxrPtD8GQ1ZC((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889596966), (object) ex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void PrintDebug(string function, string message)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        string message1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              this.PrintDebug(function, (Func<string>) (() => message1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        message1 = message;
        num1 = 3;
      }
label_3:;
    }

    private string FormatDebugMessage(string function, string message) => (string) Workspace.v3YVr8WrMQ7iVyp3a7LX((object) new string[6]
    {
      (string) Workspace.gc0w6NWrHZY3thQRLmHi(1819636893 << 3 ^ 1672060192),
      this.project,
      z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283518735),
      function,
      (string) Workspace.gc0w6NWrHZY3thQRLmHi(-2112703338 ^ -2112693054),
      message
    });

    private string FormatChangeReferencesCommand(
      string command,
      IEnumerable<string> assemblies,
      IEnumerable<string> webServices)
    {
      string str1 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882146414), assemblies.Select<string, string>(new Func<string, string>(Path.GetFileName)));
      string str2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405818043), webServices.Select<string, string>(new Func<string, string>(Path.GetFileName)));
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993301225) + command + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787002970) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87987551) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776);
    }

    private static bool IsTransientConnectionFailure(object exception) => ((IEnumerable<WebExceptionStatus>) Workspace.TransientFailures).Contains<WebExceptionStatus>(Workspace.Ax0GxhWrLdYpwDtIb0Px(exception));

    static Workspace()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Workspace.upmYGMWrUS2RTp6A80xY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            WebExceptionStatus[] webExceptionStatusArray = new WebExceptionStatus[3];
            // ISSUE: field reference
            Workspace.EFYcZAWrslFlrEMB7RAl((object) webExceptionStatusArray, __fieldref (\u003CPrivateImplementationDetails\u003E.\u00323F556ED03524B5E14A0522DA771D850BDB0C4CE));
            Workspace.TransientFailures = webExceptionStatusArray;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            Workspace.ValidChangeReferenceCommands = new string[2]
            {
              (string) Workspace.gc0w6NWrHZY3thQRLmHi(1251470110 >> 2 ^ 312986873),
              (string) Workspace.gc0w6NWrHZY3thQRLmHi(964881585 - -1459193222 ^ -1870773163)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void IIISocWr6kl7SeUAo5X0([In] object obj0) => ((System.Threading.Timer) obj0).Dispose();

    internal static bool hjr0rbWrwQVhdmGvt3oZ() => Workspace.PJZWkFWrt9yxZJyj9Dy5 == null;

    internal static Workspace pJ8rK9Wr4bM1xXlL0RbP() => Workspace.PJZWkFWrt9yxZJyj9Dy5;

    internal static object gc0w6NWrHZY3thQRLmHi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool qouvGNWrABv47kunaiC4([In] object obj0) => Workspace.IsTransientConnectionFailure(obj0);

    internal static object mn9LykWr7JMjkaBkif6n([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object G29aSnWrxRRO3Ia18qj6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object k46qBVWr0c04wtpGJ9Bc([In] object obj0) => (object) ((OmniSharpRequest) obj0).PostData;

    internal static int dquWXDWrm4xMaRGoCk0l([In] object obj0) => ((string) obj0).Length;

    internal static object w5ccpXWryj3SUDd5gqH1([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object v3YVr8WrMQ7iVyp3a7LX([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object JYUNUXWrJDLRYEo3Uxur([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static AsyncVoidMethodBuilder bx00wIWr9UeXGHwMPZMt() => AsyncVoidMethodBuilder.Create();

    internal static AsyncTaskMethodBuilder Kmw4VxWrdkD7jRyNunxG() => AsyncTaskMethodBuilder.Create();

    internal static bool oi9jylWrlitQZ77KgioG([In] object obj0) => ((IConnectionMonitor) obj0).IsOffline;

    internal static bool R2yOCdWrr0jf1fV3Oja0([In] object obj0) => ((ConcurrentQueue<ReferenceOperation>) obj0).IsEmpty;

    internal static bool BdX57lWrgrdwJ22Ptnw8([In] object obj0, [In] TimeSpan obj1, [In] TimeSpan obj2) => ((System.Threading.Timer) obj0).Change(obj1, obj2);

    internal static void faZBriWr5JQyUW3kHJnQ([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static void aInAj4WrjhfXjlECi9Bt([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void YYtZY5WrYxrPtD8GQ1ZC([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static WebExceptionStatus Ax0GxhWrLdYpwDtIb0Px([In] object obj0) => ((WebException) obj0).Status;

    internal static void upmYGMWrUS2RTp6A80xY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void EFYcZAWrslFlrEMB7RAl([In] object obj0, [In] RuntimeFieldHandle obj1) => RuntimeHelpers.InitializeArray((Array) obj0, obj1);

    internal static object UJr8ntWrc0IgLewfmoev([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object yNIofvWrzwPQB6mH69hN([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);
  }
}
