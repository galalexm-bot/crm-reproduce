// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ExportImportService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Actors;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис импорта/экспорта</summary>
  [Service]
  internal sealed class ExportImportService : IExportImportService
  {
    private readonly IActorModelRuntime actorModelRuntime;
    internal static ExportImportService dqjUIVE6LhrRXqTyGKT2;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    public ExportImportService(IActorModelRuntime actorModelRuntime)
    {
      ExportImportService.keNkCiE6cXTx0onBEAFI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public async Task<Guid> Test(
      IConfigImportSettings settings,
      string activateKey = null,
      bool storeSettings = false)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        Guid result;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_29;
            case 1:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 5 : 3;
              continue;
            case 3:
              goto label_30;
            case 4:
label_3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            case 5:
              try
              {
                int num4;
                if (num3 == 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 12;
                else
                  goto label_16;
label_8:
                Guid testUid;
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (!awaiter.IsCompleted)
                      {
                        num4 = 8;
                        continue;
                      }
                      goto case 3;
                    case 2:
                      goto label_23;
                    case 3:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 5;
                      continue;
                    case 4:
                      goto label_3;
                    case 5:
                      result = testUid;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 4 : 3;
                      continue;
                    case 6:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportImportService.\u003CTest\u003Ed__2>(ref awaiter, this);
                      num4 = 2;
                      continue;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = 3;
                      continue;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 7 : 11;
                      continue;
                    case 9:
                    case 12:
                      awaiter = taskAwaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                      continue;
                    case 10:
                      goto label_16;
                    case 11:
                      taskAwaiter = awaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 5 : 6;
                      continue;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = ExportImportService.\u003CTest\u003Ed__2.wWgcLs81G6eHAG1S4oTu((object) this.GetTestActor().Test(testUid, settings, activateKey, storeSettings));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
                      continue;
                    default:
                      taskAwaiter = new TaskAwaiter();
                      num4 = 7;
                      continue;
                  }
                }
label_23:
                return;
label_16:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                testUid = ExportImportService.\u003CTest\u003Ed__2.JWrfrn81hLBgsZ9fQ4Wd(ExportImportService.\u003CTest\u003Ed__2.thMiYx81bVxgBt2CPPfa((object) settings));
                num4 = 13;
                goto label_8;
              }
              catch (Exception ex)
              {
                int num5 = 2;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_22;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_12;
                  }
                }
label_22:
                return;
label_12:
                return;
              }
            default:
              goto label_26;
          }
        }
label_30:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 2;
      }
label_29:
      return;
label_26:;
    }

    /// <inheritdoc />
    public async Task<Guid> TestModules(
      Guid testUid,
      IEnumerable<IConfigImportSettings> settings,
      string activateKey = null,
      bool storeSettings = false)
    {
      int num1 = 2;
      int num2;
      Guid result;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_27;
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 5 : 5;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
            continue;
          case 3:
label_2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 1;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 10;
              else
                goto label_18;
label_8:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 8;
                    continue;
                  case 2:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportImportService.\u003CTestModules\u003Ed__3>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 2;
                    continue;
                  case 4:
                    goto label_18;
                  case 5:
                    goto label_21;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                    continue;
                  case 7:
                    result = testUid;
                    num3 = 12;
                    continue;
                  case 8:
                  case 11:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 7 : 6;
                    continue;
                  case 9:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 6;
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ExportImportService.\u003CTestModules\u003Ed__3.pQjpry81CWhueOc4rGAo((object) this.GetTestActor().TestModules(testUid, settings, activateKey, storeSettings));
                    num3 = 9;
                    continue;
                  case 12:
                    goto label_2;
                  default:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 3;
                    continue;
                }
              }
label_21:
              return;
label_18:
              awaiter = taskAwaiter;
              num3 = 2;
              goto label_8;
            }
            catch (Exception ex)
            {
              int num4 = 2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                    continue;
                }
              }
label_19:
              return;
            }
          default:
            goto label_24;
        }
      }
label_27:
      return;
label_24:;
    }

    /// <inheritdoc />
    public Task<Guid> Import(IImportSettings settings) => this.GetImportStartActor().Import(settings);

    /// <inheritdoc />
    public async Task<Guid> Export(ConfigExportSettings settings)
    {
      int num1 = 1;
      Guid result;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 2:
label_28:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 3 : 4;
            continue;
          case 3:
            goto label_27;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 3;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              else
                goto label_18;
label_7:
              Guid exportUid;
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportImportService.\u003CExport\u003Ed__5>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 5 : 5;
                    continue;
                  case 3:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = 12;
                      continue;
                    }
                    goto case 11;
                  case 4:
                    result = exportUid;
                    num3 = 13;
                    continue;
                  case 5:
                    goto label_24;
                  case 6:
                    goto label_18;
                  case 8:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 3;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ((Task) ExportImportService.\u003CExport\u003Ed__5.n3eYgv81IFKSnv1jNbZx((object) this.GetExportActor(exportUid), (object) settings)).GetAwaiter();
                    num3 = 3;
                    continue;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 11 : 3;
                    continue;
                  case 11:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 3 : 4;
                    continue;
                  case 12:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                    continue;
                  case 13:
                    goto label_28;
                  default:
                    awaiter = taskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 8 : 2;
                    continue;
                }
              }
label_24:
              return;
label_18:
              // ISSUE: reference to a compiler-generated method
              exportUid = ExportImportService.\u003CExport\u003Ed__5.iHVlZG81unrJkcSTOEly();
              num3 = 9;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_20;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = 2;
                    continue;
                }
              }
label_20:
              return;
            }
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 5 : 3;
            continue;
        }
      }
label_27:;
    }

    /// <inheritdoc />
    public async Task<Guid> Export(
      ConfigExportSettings settings,
      byte[] certificate,
      string password)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        Guid result;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_30;
            case 2:
              goto label_3;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 4 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 3;
        continue;
label_6:
        try
        {
          int num4;
          if (num3 == 0)
            num4 = 7;
          else
            goto label_12;
label_9:
          Guid exportUid;
          TaskAwaiter taskAwaiter;
          TaskAwaiter awaiter;
          while (true)
          {
            switch (num4)
            {
              case 1:
                if (!awaiter.IsCompleted)
                {
                  num4 = 6;
                  continue;
                }
                goto case 3;
              case 2:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = -1;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 3;
                continue;
              case 3:
                awaiter.GetResult();
                num4 = 10;
                continue;
              case 4:
                goto label_27;
              case 5:
                taskAwaiter = new TaskAwaiter();
                num4 = 2;
                continue;
              case 6:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 0;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 6 : 8;
                continue;
              case 7:
              case 12:
                awaiter = taskAwaiter;
                num4 = 5;
                continue;
              case 8:
                taskAwaiter = awaiter;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 9 : 3;
                continue;
              case 9:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportImportService.\u003CExport\u003Ed__6>(ref awaiter, this);
                num4 = 4;
                continue;
              case 10:
                result = exportUid;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              case 11:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                awaiter = ExportImportService.\u003CExport\u003Ed__6.lbylsr81KAt8Qx3INS2l(ExportImportService.\u003CExport\u003Ed__6.ImZeGa81qEl3lXOuQN3C((object) this.GetExportActor(exportUid), (object) settings, (object) certificate, (object) password));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
                continue;
              case 13:
                goto label_12;
              default:
                goto label_3;
            }
          }
label_27:
          return;
label_12:
          // ISSUE: reference to a compiler-generated method
          exportUid = ExportImportService.\u003CExport\u003Ed__6.gZyV1X81RhYxxYfKXh2w();
          num4 = 9;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          {
            num4 = 11;
            goto label_9;
          }
          else
            goto label_9;
        }
        catch (Exception ex)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.SetException(ex);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 2;
                continue;
              case 2:
                goto label_23;
              default:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = -2;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                continue;
            }
          }
label_23:
          return;
        }
      }
label_30:;
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeploySystemMessage>> GetTestSystemMessages(
      Guid testUid,
      int offset,
      int count = 0)
    {
      return this.GetTestActor().GetSystemMessages(testUid, offset, count);
    }

    /// <inheritdoc />
    public Task<IEnumerable<DeploySystemMessage>> GetImportSystemMessages(
      Guid importUid,
      int offset,
      int count = 0)
    {
      return this.GetImportExecutorActor(importUid).GetSystemMessages(offset, count);
    }

    /// <inheritdoc />
    public Task<IEnumerable<TestImportMessages>> GetTestLog(Guid testId, int offset, int count = 0) => this.GetTestActor().GetLog(testId, offset, count);

    /// <inheritdoc />
    public Task<IEnumerable<DeployLogMessage>> GetImportLog(Guid importUid, int offset, int count = 0) => this.GetImportExecutorActor(importUid).GetLog(offset, count);

    /// <inheritdoc />
    public Task<IEnumerable<DeployLogMessage>> GetExportLog(Guid exportUid, int offset, int count = 0) => this.GetExportActor(exportUid).GetLog(offset, count);

    /// <inheritdoc />
    public Task<Guid> GetCurrentImportId() => this.GetImportStartActor().GetCurrentImportId();

    /// <inheritdoc />
    public Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings) => this.GetImportStartActor().ContinuedImport(settings);

    /// <inheritdoc />
    public async Task<Guid> ContinuedImport(IEnumerable<Guid> testUids)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        Guid result1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 3;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_75;
            case 5:
              try
              {
                int num4;
                if ((uint) num3 <= 1U)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 10 : 0;
                else
                  goto label_23;
label_9:
                List<IConfigImportSettings> list;
                IEnumerator<Guid> enumerator;
                TaskAwaiter<Guid> taskAwaiter1;
                TaskAwaiter<Guid> awaiter1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = 3;
                      continue;
                    case 2:
                      taskAwaiter1 = awaiter1;
                      num4 = 4;
                      continue;
                    case 3:
                    case 5:
                      result1 = awaiter1.GetResult();
                      num4 = 15;
                      continue;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, ExportImportService.\u003CContinuedImport\u003Ed__14>(ref awaiter1, this);
                      num4 = 11;
                      continue;
                    case 6:
                      awaiter1 = this.ContinuedImport((IEnumerable<IConfigImportSettings>) list).GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 9 : 1;
                      continue;
                    case 7:
                    case 10:
                      num4 = 12;
                      continue;
                    case 8:
                      taskAwaiter1 = new TaskAwaiter<Guid>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
                      continue;
                    case 9:
                      if (awaiter1.IsCompleted)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto case 18;
                    case 11:
                      goto label_72;
                    case 12:
                      try
                      {
                        int num5;
                        if (num3 != 0)
                          num5 = 22;
                        else
                          goto label_37;
label_27:
                        Guid testUid;
                        IConfigurationTestStartActor testActor;
                        TaskAwaiter<IConfigImportSettings[]> taskAwaiter2;
                        TaskAwaiter taskAwaiter3;
                        TaskAwaiter<IConfigImportSettings[]> awaiter2;
                        TaskAwaiter awaiter3;
                        IConfigImportSettings[] result2;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_68;
                            case 2:
                            case 12:
                              awaiter3.GetResult();
                              num5 = 24;
                              continue;
                            case 3:
                              taskAwaiter2 = new TaskAwaiter<IConfigImportSettings[]>();
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 1;
                              continue;
                            case 4:
                            case 11:
                              // ISSUE: reference to a compiler-generated method
                              if (!ExportImportService.\u003CContinuedImport\u003Ed__14.pkObZ281O703NogXtZKk((object) enumerator))
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 7 : 26;
                                continue;
                              }
                              goto case 10;
                            case 5:
                              taskAwaiter3 = awaiter3;
                              num5 = 30;
                              continue;
                            case 6:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = -1;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                              continue;
                            case 7:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IConfigImportSettings[]>, ExportImportService.\u003CContinuedImport\u003Ed__14>(ref awaiter2, this);
                              num5 = 15;
                              continue;
                            case 8:
                              awaiter3 = taskAwaiter3;
                              num5 = 29;
                              continue;
                            case 9:
                              if (awaiter3.IsCompleted)
                              {
                                num5 = 12;
                                continue;
                              }
                              goto case 19;
                            case 10:
                              testUid = enumerator.Current;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 25 : 5;
                              continue;
                            case 13:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = 0;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 16 : 20;
                              continue;
                            case 14:
                              // ISSUE: reference to a compiler-generated method
                              awaiter3 = ExportImportService.\u003CContinuedImport\u003Ed__14.CYf2UT81n59TbdNgpBKc((object) testActor.Clear(testUid));
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 9 : 3;
                              continue;
                            case 15:
                              goto label_66;
                            case 16:
                              goto label_37;
                            case 17:
                              awaiter2 = testActor.GetTestedSettingsWithCheck(testUid).GetAwaiter();
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 19 : 27;
                              continue;
                            case 19:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = 1;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 5 : 5;
                              continue;
                            case 20:
                              taskAwaiter2 = awaiter2;
                              num5 = 7;
                              continue;
                            case 21:
                              testUid = new Guid();
                              num5 = 11;
                              continue;
                            case 22:
                              if (num3 != 1)
                              {
                                num5 = 4;
                                continue;
                              }
                              goto case 8;
                            case 23:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = -1;
                              num5 = 2;
                              continue;
                            case 24:
                              testActor = (IConfigurationTestStartActor) null;
                              num5 = 21;
                              continue;
                            case 25:
                              testActor = this.GetTestActor();
                              num5 = 17;
                              continue;
                            case 26:
                              goto label_67;
                            case 27:
                              if (awaiter2.IsCompleted)
                              {
                                num5 = 18;
                                continue;
                              }
                              goto case 13;
                            case 28:
                              list.AddRange((IEnumerable<IConfigImportSettings>) result2);
                              num5 = 14;
                              continue;
                            case 29:
                              taskAwaiter3 = new TaskAwaiter();
                              num5 = 23;
                              continue;
                            case 30:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ExportImportService.\u003CContinuedImport\u003Ed__14>(ref awaiter3, this);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
                              continue;
                            default:
                              result2 = awaiter2.GetResult();
                              num5 = 28;
                              continue;
                          }
                        }
label_68:
                        return;
label_66:
                        return;
label_37:
                        awaiter2 = taskAwaiter2;
                        num5 = 3;
                        goto label_27;
                      }
                      finally
                      {
                        int num6;
                        if (num3 >= 0)
                          num6 = 3;
                        else
                          goto label_62;
label_59:
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              goto label_62;
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              ExportImportService.\u003CContinuedImport\u003Ed__14.lvyH7U812YrbB1Ohsrut((object) enumerator);
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_64;
                          }
                        }
label_62:
                        if (enumerator != null)
                        {
                          num6 = 2;
                          goto label_59;
                        }
label_64:;
                      }
                    case 13:
                      enumerator = testUids.GetEnumerator();
                      num4 = 7;
                      continue;
                    case 14:
label_67:
                      enumerator = (IEnumerator<Guid>) null;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 6;
                      continue;
                    case 15:
                      goto label_4;
                    case 16:
                      goto label_21;
                    case 17:
                      goto label_23;
                    case 18:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 2;
                      num4 = 2;
                      continue;
                    default:
                      list = new List<IConfigImportSettings>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 13 : 8;
                      continue;
                  }
                }
label_72:
                return;
label_21:
                awaiter1 = taskAwaiter1;
                num4 = 8;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                {
                  num4 = 8;
                  goto label_9;
                }
                else
                  goto label_9;
label_23:
                if (num3 != 2)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                  goto label_9;
                }
                else
                  goto label_21;
              }
              catch (Exception ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
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
                      goto label_61;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_61:
                return;
              }
            default:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num2 = 4;
              continue;
          }
        }
label_6:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 2;
      }
label_75:;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid importUid)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        int num3;
        IEnumerable<BPMAppFakeManifest> result;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_25;
            case 1:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = 6;
                else
                  goto label_8;
label_6:
                TaskAwaiter<IEnumerable<BPMAppFakeManifest>> taskAwaiter;
                TaskAwaiter<IEnumerable<BPMAppFakeManifest>> awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_8;
                    case 2:
                      goto label_18;
                    case 3:
                      taskAwaiter = awaiter;
                      num4 = 4;
                      continue;
                    case 4:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<BPMAppFakeManifest>>, ExportImportService.\u003CGetImportManifests\u003Ed__15>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 1;
                      continue;
                    case 5:
                      goto label_3;
                    case 6:
                      awaiter = this.GetImportExecutorActor(importUid).GetFakeManifests().GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                      continue;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = 8;
                      continue;
                    case 8:
                      result = awaiter.GetResult();
                      num4 = 5;
                      continue;
                    case 9:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = 3;
                      continue;
                    case 10:
                      taskAwaiter = new TaskAwaiter<IEnumerable<BPMAppFakeManifest>>();
                      num4 = 7;
                      continue;
                    default:
                      if (!awaiter.IsCompleted)
                      {
                        num4 = 9;
                        continue;
                      }
                      goto case 8;
                  }
                }
label_18:
                return;
label_8:
                awaiter = taskAwaiter;
                num4 = 10;
                goto label_6;
              }
              catch (Exception ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                  num5 = 0;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = 2;
                      continue;
                    case 2:
                      goto label_14;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
                      continue;
                  }
                }
label_14:
                return;
              }
            case 2:
label_3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = 5;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_27;
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            default:
              goto label_22;
          }
        }
label_27:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 3;
      }
label_25:
      return;
label_22:;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<BPMAppFakeManifest>> GetTestManifests(IEnumerable<Guid> testUids)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          IEnumerable<BPMAppFakeManifest> result1;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_51;
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 2;
              continue;
            case 5:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 3 : 4;
                else
                  goto label_38;
label_6:
                List<BPMAppFakeManifest> list;
                IEnumerator<Guid> enumerator;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_38;
                    case 2:
                      enumerator = testUids.GetEnumerator();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                      continue;
                    case 3:
                      result1 = (IEnumerable<BPMAppFakeManifest>) list;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 0;
                      continue;
                    case 4:
                      list = new List<BPMAppFakeManifest>();
                      num4 = 5;
                      continue;
                    case 5:
                      this.GetTestActor();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 2;
                      continue;
                    case 6:
                      goto label_53;
                    case 7:
label_40:
                      enumerator = (IEnumerator<Guid>) null;
                      num4 = 3;
                      continue;
                    default:
                      try
                      {
                        int num5;
                        if (num3 != 0)
                          num5 = 4;
                        else
                          goto label_26;
label_10:
                        int num6 = num5;
label_11:
                        List<BPMAppFakeManifest> bpmAppFakeManifestList;
                        TaskAwaiter<BPMAppFakeManifest[]> taskAwaiter;
                        Guid current;
                        TaskAwaiter<BPMAppFakeManifest[]> awaiter;
                        BPMAppFakeManifest[] result2;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = 0;
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 6 : 11;
                              continue;
                            case 2:
                              goto label_48;
                            case 3:
                              goto label_40;
                            case 4:
                            case 10:
                              // ISSUE: reference to a compiler-generated method
                              if (!ExportImportService.\u003CGetTestManifests\u003Ed__16.cSQTg181aNntCbfSJ6f7((object) enumerator))
                              {
                                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 3 : 0;
                                continue;
                              }
                              goto case 13;
                            case 5:
                              goto label_26;
                            case 6:
                            case 9:
                              result2 = awaiter.GetResult();
                              num6 = 15;
                              continue;
                            case 7:
                              bpmAppFakeManifestList = list;
                              num6 = 12;
                              continue;
                            case 8:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num3 = -1;
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 6 : 4;
                              continue;
                            case 11:
                              taskAwaiter = awaiter;
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 14;
                              continue;
                            case 12:
                              awaiter = this.GetTestActor().GetFakeManifest(current).GetAwaiter();
                              num6 = 16;
                              continue;
                            case 13:
                              current = enumerator.Current;
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 7 : 7;
                              continue;
                            case 14:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BPMAppFakeManifest[]>, ExportImportService.\u003CGetTestManifests\u003Ed__16>(ref awaiter, this);
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
                              continue;
                            case 15:
                              bpmAppFakeManifestList.AddRange((IEnumerable<BPMAppFakeManifest>) result2);
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 17;
                              continue;
                            case 16:
                              if (!awaiter.IsCompleted)
                                goto case 1;
                              else
                                goto label_19;
                            case 17:
                              bpmAppFakeManifestList = (List<BPMAppFakeManifest>) null;
                              num6 = 10;
                              continue;
                            default:
                              taskAwaiter = new TaskAwaiter<BPMAppFakeManifest[]>();
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 8;
                              continue;
                          }
                        }
label_48:
                        return;
label_19:
                        num5 = 9;
                        goto label_10;
label_26:
                        awaiter = taskAwaiter;
                        num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                        {
                          num6 = 0;
                          goto label_11;
                        }
                        else
                          goto label_11;
                      }
                      finally
                      {
                        int num7;
                        if (num3 >= 0)
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
                        else
                          goto label_33;
label_31:
                        while (true)
                        {
                          switch (num7)
                          {
                            case 2:
                              enumerator.Dispose();
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                              continue;
                            case 3:
                              goto label_33;
                            default:
                              goto label_36;
                          }
                        }
label_33:
                        if (enumerator != null)
                        {
                          num7 = 2;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                          {
                            num7 = 0;
                            goto label_31;
                          }
                          else
                            goto label_31;
                        }
label_36:;
                      }
                  }
                }
label_38:
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                {
                  num4 = 0;
                  goto label_6;
                }
                else
                  goto label_6;
              }
              catch (Exception ex)
              {
                int num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                  num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_44;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num8 = 2;
                      continue;
                  }
                }
label_44:
                return;
              }
          }
label_53:
          // ISSUE: explicit reference operation
          // ISSUE: reference to a compiler-generated field
          (^this).\u003C\u003E1__state = -2;
          num2 = 4;
        }
label_3:
        num1 = 5;
      }
label_51:;
    }

    /// <summary>Импорт требует перезагрузки</summary>
    /// <param name="importUid">Идентификатор сессии импорта</param>
    public async Task<bool> ImportNeedRestart(Guid importUid)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        bool result1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_37;
            case 2:
label_38:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 3 : 2;
              continue;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_5;
            default:
              try
              {
                int num4;
                if (num3 != 0)
                {
                  num4 = 6;
                  goto label_10;
                }
                else
                  goto label_23;
label_9:
                int num5;
                num4 = num5;
label_10:
                TaskAwaiter<IEnumerable<DeployLogMessage>> taskAwaiter;
                TaskAwaiter<IEnumerable<DeployLogMessage>> awaiter;
                while (true)
                {
                  List<DeployLogMessage> list;
                  List<DeployLogMessage> deployLogMessageList;
                  IEnumerable<DeployLogMessage> result2;
                  int num6;
                  switch (num4)
                  {
                    case 1:
                      deployLogMessageList = (List<DeployLogMessage>) null;
                      num4 = 2;
                      continue;
                    case 2:
                      DeployLogMessage deployLogMessage = list.FirstOrDefault<DeployLogMessage>();
                      if (deployLogMessage == null)
                      {
                        num4 = 13;
                        continue;
                      }
                      num6 = deployLogMessage.NeedRestart ? 1 : 0;
                      break;
                    case 3:
                    case 11:
                      result2 = awaiter.GetResult();
                      num4 = 16;
                      continue;
                    case 4:
                      goto label_23;
                    case 5:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 3;
                        continue;
                      }
                      goto case 15;
                    case 6:
                      list = new List<DeployLogMessage>();
                      num4 = 8;
                      continue;
                    case 7:
                      taskAwaiter = new TaskAwaiter<IEnumerable<DeployLogMessage>>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                      continue;
                    case 8:
                      deployLogMessageList = list;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 7 : 12;
                      continue;
                    case 9:
                      goto label_17;
                    case 10:
                      goto label_38;
                    case 12:
                      awaiter = this.GetImportExecutorActor(importUid).GetLastLog(1).GetAwaiter();
                      num4 = 5;
                      continue;
                    case 13:
                      num6 = 0;
                      break;
                    case 14:
                      taskAwaiter = awaiter;
                      num4 = 9;
                      continue;
                    case 15:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = 0;
                      num4 = 14;
                      continue;
                    case 16:
                      deployLogMessageList.AddRange(result2);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
                      continue;
                    case 17:
                      goto label_34;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 11 : 11;
                      continue;
                  }
                  result1 = num6 != 0;
                  num4 = 10;
                }
label_34:
                return;
label_17:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<DeployLogMessage>>, ExportImportService.\u003CImportNeedRestart\u003Ed__17>(ref awaiter, this);
                num5 = 17;
                goto label_9;
label_23:
                awaiter = taskAwaiter;
                num5 = 7;
                goto label_9;
              }
              catch (Exception ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_30;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num7 = 2;
                      continue;
                  }
                }
label_30:
                return;
              }
          }
        }
label_5:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 4;
      }
label_37:;
    }

    /// <inheritdoc />
    public void ClearTestData(Guid testUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExportImportService.l2QYpgE6zS3AVbR1oAN3((object) this.GetTestActor(), testUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int num3;
        IEnumerable<IImportSettings> result;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num3 = (^this).\u003C\u003E1__state;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 2;
              continue;
            case 3:
label_3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 2 : 2;
              continue;
            case 4:
              goto label_26;
            case 5:
              try
              {
                int num4;
                if (num3 == 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 2 : 1;
                else
                  goto label_17;
label_7:
                TaskAwaiter<IConfigImportSettings[]> awaiter;
                while (true)
                {
                  TaskAwaiter<IConfigImportSettings[]> taskAwaiter;
                  switch (num4)
                  {
                    case 1:
                      goto label_3;
                    case 2:
                    case 3:
                      awaiter = taskAwaiter;
                      num4 = 4;
                      continue;
                    case 4:
                      taskAwaiter = new TaskAwaiter<IConfigImportSettings[]>();
                      num4 = 8;
                      continue;
                    case 5:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 6;
                        continue;
                      }
                      break;
                    case 6:
                    case 11:
                      result = (IEnumerable<IImportSettings>) awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
                      continue;
                    case 7:
                      goto label_17;
                    case 8:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 11 : 6;
                      continue;
                    case 9:
                      taskAwaiter = awaiter;
                      num4 = 12;
                      continue;
                    case 10:
                      goto label_23;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IConfigImportSettings[]>, ExportImportService.\u003CGetImportSettings\u003Ed__19>(ref awaiter, this);
                      num4 = 10;
                      continue;
                  }
                  // ISSUE: explicit reference operation
                  // ISSUE: reference to a compiler-generated field
                  (^this).\u003C\u003E1__state = num3 = 0;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 9 : 7;
                }
label_23:
                return;
label_17:
                awaiter = this.GetTestActor().GetTestedSettings(testUid).GetAwaiter();
                num4 = 5;
                goto label_7;
              }
              catch (Exception ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
                  num5 = 2;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_19;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_16;
                  }
                }
label_19:
                return;
label_16:
                return;
              }
            default:
              goto label_4;
          }
        }
label_4:
        num1 = 5;
      }
label_26:;
    }

    /// <inheritdoc />
    public Task<string> GetTestedAppId(Guid testUid) => this.GetTestActor().GetAppId(testUid);

    /// <inheritdoc />
    public Task ContinueImport() => this.GetImportStartActor().ContinueImport();

    private IConfigurationTestStartActor GetTestActor() => this.actorModelRuntime.GetActor<IConfigurationTestStartActor>(ConfigurationTestStartActor.ActorId);

    private IImportStartActor GetImportStartActor() => this.actorModelRuntime.GetActor<IImportStartActor>(ImportStartActor.ActorId);

    private IImportExecutorActor GetImportExecutorActor(Guid importUid) => this.actorModelRuntime.GetActor<IImportExecutorActor>(importUid);

    private IExportActor GetExportActor(Guid exportUid) => this.actorModelRuntime.GetActor<IExportActor>(exportUid);

    /// <inheritdoc />
    public Task<IContinuedImportState> GetImportState(Guid importUid) => this.GetImportExecutorActor(importUid).GetImportState();

    /// <inheritdoc />
    public Task<IReadOnlyCollection<Guid>> GetTestedModules() => this.GetTestActor().GetTestedModules();

    internal static void keNkCiE6cXTx0onBEAFI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kEF0J7E6U4CH2Hpm6rXc() => ExportImportService.dqjUIVE6LhrRXqTyGKT2 == null;

    internal static ExportImportService DcoXXBE6sj84mEAdA2qf() => ExportImportService.dqjUIVE6LhrRXqTyGKT2;

    internal static object l2QYpgE6zS3AVbR1oAN3([In] object obj0, Guid testUid) => (object) ((IConfigurationTestStartActor) obj0).Clear(testUid);
  }
}
