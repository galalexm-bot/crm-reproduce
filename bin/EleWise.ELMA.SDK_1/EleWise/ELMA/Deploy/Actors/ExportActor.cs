// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ExportActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models.Certificates;
using EleWise.ELMA.Deploy.Utils;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Актор экспорта конфигурации</summary>
  internal sealed class ExportActor : Actor, IExportActor, IActorWithGuidKey, IActor
  {
    private readonly IAuthenticationService authenticationService;
    private List<DeployLogMessage> log;
    private bool isStarted;
    private CancellationTokenSource cts;
    private Task externalTask;
    private static ExportActor z8trq1EzeLm76r4spNGQ;

    /// <summary>Ctor</summary>
    /// <param name="authenticationService">Сервис аутентификации</param>
    public ExportActor(IAuthenticationService authenticationService)
    {
      ExportActor.VRQCuVEzN0y2eg7jRBDq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.authenticationService = authenticationService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override Task OnDeactivateAsync()
    {
      int num = 1;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      ExportActor.\u003COnDeactivateAsync\u003Ed__6 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
            continue;
          case 4:
            tBuilder.Start<ExportActor.\u003COnDeactivateAsync\u003Ed__6>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 5;
            continue;
          case 5:
            goto label_3;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ExportActor.mOgZECEz3n6reY6VqAGI();
            num = 3;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count) => this.log == null ? Task.FromResult<IEnumerable<DeployLogMessage>>(Enumerable.Empty<DeployLogMessage>()) : Task.FromResult<IEnumerable<DeployLogMessage>>(DeployUtils.SafeSkip<DeployLogMessage>(this.log, offset, count));

    /// <inheritdoc />
    public Task Export(ConfigExportSettings settings) => this.Export(settings, (byte[]) null, (string) null);

    /// <inheritdoc />
    public Task Export(ConfigExportSettings settings, byte[] certificate, string password)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        CSPCertificateContainer certificateContainer;
        ExportActor exportActor;
        ConfigExportSettings settings1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              this.log = new List<DeployLogMessage>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 5;
              continue;
            case 3:
              goto label_8;
            case 4:
              certificateContainer = certificate == null ? (CSPCertificateContainer) null : new CSPCertificateContainer(certificate, password);
              num2 = 6;
              continue;
            case 5:
              goto label_11;
            case 6:
              this.externalTask = this.RunExternalTask((Func<Task>) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  IRunExportParameters parameters;
                  RunExportParameters exportParameters;
                  switch (num3)
                  {
                    case 1:
                      if (certificateContainer != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      exportParameters = new RunExportParameters(exportActor.authenticationService.GetCurrentUser().GetId() as long?, exportActor.log, exportActor.cts.Token);
                      break;
                    case 3:
                      new ConfigExport(settings1).RunExport(parameters);
                      num3 = 4;
                      continue;
                    case 4:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      exportParameters = (RunExportParameters) new RunBpmAppExportParameters((ICertificateContainer) certificateContainer, exportActor.authenticationService.GetCurrentUser().GetId() as long?, exportActor.log, ExportActor.\u003C\u003Ec__DisplayClass9_0.Kgokrn8MXqhsEbReLU2S((object) exportActor.cts));
                      break;
                  }
                  parameters = (IRunExportParameters) exportParameters;
                  num3 = 3;
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                return (Task) ExportActor.\u003C\u003Ec__DisplayClass9_0.GtNLdo8MTQdZGu88hyMF();
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 10 : 10;
              continue;
            case 7:
              exportActor = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 9:
              this.isStarted = true;
              num2 = 2;
              continue;
            case 10:
              goto label_7;
            default:
              settings1 = settings;
              num2 = 3;
              continue;
          }
        }
label_8:
        if (!this.isStarted)
        {
          num1 = 9;
          continue;
        }
        goto label_12;
label_11:
        this.cts = new CancellationTokenSource();
        num1 = 4;
      }
label_7:
      return (Task) ExportActor.Fp6st4EzpG35g49wBONT();
label_12:
      return (Task) ExportActor.Fp6st4EzpG35g49wBONT();
    }

    internal static void VRQCuVEzN0y2eg7jRBDq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool E2GqLHEzP6sCRC0bcN2j() => ExportActor.z8trq1EzeLm76r4spNGQ == null;

    internal static ExportActor Fd7YixEz1TbFBvUee2mm() => ExportActor.z8trq1EzeLm76r4spNGQ;

    internal static AsyncTaskMethodBuilder mOgZECEz3n6reY6VqAGI() => AsyncTaskMethodBuilder.Create();

    internal static object Fp6st4EzpG35g49wBONT() => (object) Task.CompletedTask;
  }
}
