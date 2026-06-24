// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ExportImportFileCleanerActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>
  /// Актор запуска очистки файлов в папке экспорта/импорта конфигураций
  /// </summary>
  internal sealed class ExportImportFileCleanerActor : 
    Actor,
    IExportImportFileCleanerActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly ILogger logger;
    private readonly IExportImportFileCleanerService exportImportFileCleanerService;
    /// <summary>Период срабатывания напоминания - раз в 4 часа</summary>
    private readonly TimeSpan reminderPeriod;
    private static ExportImportFileCleanerActor I1YvTSEcdYKoHS0yeHEy;

    /// <summary>Ctor</summary>
    /// <param name="loggerFactory">Фабрика логгеров</param>
    /// <param name="exportImportFileCleanerService">Сервис очистки файлов экспорта/импорта</param>
    public ExportImportFileCleanerActor(
      ILoggerFactory loggerFactory,
      IExportImportFileCleanerService exportImportFileCleanerService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.reminderPeriod = ExportImportFileCleanerActor.eZsD8cEcggmtRcjL5YK2(4.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.exportImportFileCleanerService = exportImportFileCleanerService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 1;
            continue;
          case 2:
            // ISSUE: type reference
            this.logger = loggerFactory.CreateLogger(ExportImportFileCleanerActor.TlwPjvEc5I3HQMZntNCR(__typeref (ExportImportFileCleanerActor)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Создаем на напоминание для актора. Будет запущено через 1 минуту. Повторный запуск через 4 часа
    /// </summary>
    public Task Start() => this.RegisterOrUpdateReminder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633187843), ExportImportFileCleanerActor.hZkLilEcjW3MKicZsk7x(1.0), this.reminderPeriod);

    /// <summary>
    /// Обработка напоминания. Запуск задачи очистки папки экспорта/импорта
    /// </summary>
    /// <param name="reminderName">Имя напоминания, на текущий момент обрабатывается только один тип напоминаний</param>
    public override Task ReceiveReminder(string reminderName)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.logger.InfoFormat((string) ExportImportFileCleanerActor.RRQ0HVEcLJxXDy2OxTol(ExportImportFileCleanerActor.oC9BceEcYbLrxJJOuN4q(-1921202237 ^ -1921397721)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.RunExternalTask((Func<Task>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    ExportImportFileCleanerActor.Tr4YG8EcsD2Kw0hJBhxG((object) this.exportImportFileCleanerService);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_3:
              return (Task) ExportImportFileCleanerActor.NhCT2nEcUywGnuXGOdDr();
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return (Task) ExportImportFileCleanerActor.NhCT2nEcUywGnuXGOdDr();
    }

    internal static TimeSpan eZsD8cEcggmtRcjL5YK2([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static Type TlwPjvEc5I3HQMZntNCR([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool xDj9MfEclt2OlGu9YdM3() => ExportImportFileCleanerActor.I1YvTSEcdYKoHS0yeHEy == null;

    internal static ExportImportFileCleanerActor fcb5seEcrAuJ1B5UDuDR() => ExportImportFileCleanerActor.I1YvTSEcdYKoHS0yeHEy;

    internal static TimeSpan hZkLilEcjW3MKicZsk7x([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object oC9BceEcYbLrxJJOuN4q(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RRQ0HVEcLJxXDy2OxTol([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object NhCT2nEcUywGnuXGOdDr() => (object) Task.CompletedTask;

    internal static void Tr4YG8EcsD2Kw0hJBhxG([In] object obj0) => ((IExportImportFileCleanerService) obj0).Execute();
  }
}
