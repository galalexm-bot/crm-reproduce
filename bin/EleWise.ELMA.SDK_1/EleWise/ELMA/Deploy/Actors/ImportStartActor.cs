// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Actors.ImportStartActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Deploy.Actors
{
  /// <summary>Актор управления запуском импорта</summary>
  internal sealed class ImportStartActor : Actor, IImportStartActor, IActorWithGuidKey, IActor
  {
    /// <summary>Идентификатор актора</summary>
    internal static readonly Guid ActorId;
    /// <summary>
    /// Ключ записи текущего идентификатора импорта в BlobStore
    /// </summary>
    private static readonly string CurrentImportIdKey;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IBLOBStore blobStore;
    private Guid currentImportId;
    private bool idIsSaved;
    internal static ImportStartActor ykDXcKEz9rUdfKbxRwKZ;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="blobStore">Хранилище бинарных данных</param>
    public ImportStartActor(IActorModelRuntime actorModelRuntime, IBLOBStore blobStore)
    {
      ImportStartActor.Iu1bKFEzrMsYyTYru75T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.blobStore = blobStore;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      ImportStartActor.\u003COnActivateAsync\u003Ed__7 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ImportStartActor.LcvEbiEzg9J8mdciJDBE();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 2;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            tBuilder.Start<ImportStartActor.\u003COnActivateAsync\u003Ed__7>(ref stateMachine);
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 5;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public override Task OnDeactivateAsync()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.idIsSaved)
            {
              num = 5;
              continue;
            }
            goto label_2;
          case 2:
            ImportStartActor.KO5F0LEzj7dacLHPsu6f((object) this.blobStore, (object) ImportStartActor.CurrentImportIdKey, (object) this.currentImportId.ToByteArray());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 2;
            continue;
          case 3:
            if (ImportStartActor.peq2cNEz5flJfs4YTI0g(this.currentImportId, Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 5:
            ImportStartActor.pXalejEzYWqDYSJidDh3((object) this.blobStore, (object) ImportStartActor.CurrentImportIdKey);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public async Task<Guid> Import(IImportSettings settings)
    {
      int num1 = 1;
      int num2;
      Guid currentImportId;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
label_39:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 3 : 3;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(currentImportId);
            num1 = 4;
            continue;
          case 4:
            goto label_38;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 10;
              else
                goto label_13;
label_5:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ImportStartActor.\u003CImport\u003Ed__9.KUkO6F8MNJrpmZpv3ijp((object) this.CheckHasOngoingImport());
                    num3 = 12;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ImportStartActor.\u003CImport\u003Ed__9.KUkO6F8MNJrpmZpv3ijp(ImportStartActor.\u003CImport\u003Ed__9.GpRnvr8MpVcmfYhOI6rX((object) this.actorModelRuntime.GetActor<IImportExecutorActor>(this.currentImportId), (object) settings));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 17;
                    continue;
                  case 4:
                    goto label_39;
                  case 5:
                    goto label_13;
                  case 6:
                  case 23:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 12 : 13;
                    continue;
                  case 7:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 23;
                    continue;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImportStartActor.\u003CImport\u003Ed__9>(ref awaiter, this);
                    num3 = 24;
                    continue;
                  case 9:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 7 : 1;
                    continue;
                  case 10:
                    if (num2 != 1)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
                      continue;
                    }
                    goto case 22;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImportStartActor.\u003CImport\u003Ed__9>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 10 : 15;
                    continue;
                  case 12:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 6;
                      continue;
                    }
                    goto case 3;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    this.currentImportId = ImportStartActor.\u003CImport\u003Ed__9.d6vkb68M3vbuticwUf6s();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
                    continue;
                  case 14:
                    currentImportId = this.currentImportId;
                    num3 = 4;
                    continue;
                  case 15:
                    goto label_35;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 21;
                    continue;
                  case 17:
                    taskAwaiter = awaiter;
                    num3 = 8;
                    continue;
                  case 18:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 20 : 20;
                    continue;
                  case 19:
                    taskAwaiter = new TaskAwaiter();
                    num3 = 18;
                    continue;
                  case 20:
                    awaiter.GetResult();
                    num3 = 14;
                    continue;
                  case 21:
                    taskAwaiter = awaiter;
                    num3 = 11;
                    continue;
                  case 22:
                    awaiter = taskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 19 : 16;
                    continue;
                  case 24:
                    goto label_31;
                  default:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = 16;
                      continue;
                    }
                    goto case 20;
                }
              }
label_35:
              return;
label_31:
              return;
label_13:
              awaiter = taskAwaiter;
              num3 = 9;
              goto label_5;
            }
            catch (Exception ex)
            {
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_30;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = 2;
                    continue;
                }
              }
label_30:
              return;
            }
          default:
            num1 = 5;
            continue;
        }
      }
label_38:;
    }

    /// <inheritdoc />
    public async Task<Guid> GetCurrentImportId()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        int num3;
        Guid result;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_34;
            case 1:
label_35:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 4;
              continue;
            case 2:
              num2 = 5;
              continue;
            case 3:
              goto label_3;
            case 4:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 5:
              try
              {
                int num4;
                if (num3 == 0)
                  num4 = 11;
                else
                  goto label_25;
label_7:
                int num5 = num4;
label_8:
                TaskAwaiter<bool> taskAwaiter;
                TaskAwaiter<bool> awaiter;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_11;
                    case 2:
                    case 10:
                      result = this.currentImportId;
                      num5 = 5;
                      continue;
                    case 3:
                      goto label_20;
                    case 4:
                      taskAwaiter = awaiter;
                      num5 = 7;
                      continue;
                    case 5:
                    case 9:
                      goto label_35;
                    case 6:
                      goto label_25;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ImportStartActor.\u003CGetCurrentImportId\u003Ed__10>(ref awaiter, this);
                      num5 = 13;
                      continue;
                    case 8:
                    case 17:
                      awaiter = this.actorModelRuntime.GetActor<IImportExecutorActor>(this.currentImportId).IsActive().GetAwaiter();
                      num5 = 16;
                      continue;
                    case 11:
                    case 12:
                      awaiter = taskAwaiter;
                      num5 = 18;
                      continue;
                    case 13:
                      goto label_27;
                    case 14:
                      this.currentImportId = Guid.Empty;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 10;
                      continue;
                    case 15:
                      if (awaiter.GetResult())
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
                        continue;
                      }
                      goto case 14;
                    case 16:
                      if (!awaiter.IsCompleted)
                      {
                        num5 = 3;
                        continue;
                      }
                      goto case 15;
                    case 18:
                      taskAwaiter = new TaskAwaiter<bool>();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                      continue;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num3 = -1;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 15 : 2;
                      continue;
                  }
                }
label_27:
                return;
label_20:
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num3 = 0;
                num4 = 4;
                goto label_7;
label_11:
                result = Guid.Empty;
                num5 = 9;
                goto label_8;
label_25:
                if (!(this.currentImportId == Guid.Empty))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 17 : 17;
                  goto label_8;
                }
                else
                  goto label_11;
              }
              catch (Exception ex)
              {
                int num6 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
                  num6 = 1;
                while (true)
                {
                  switch (num6)
                  {
                    case 0:
                      goto label_18;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 1;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_14;
                  }
                }
label_18:
                return;
label_14:
                return;
              }
            default:
              goto label_31;
          }
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 2;
      }
label_34:
      return;
label_31:;
    }

    /// <inheritdoc />
    public async Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings)
    {
      int num1 = 5;
      int num2;
      Guid currentImportId;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_44:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_43;
          case 3:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 21;
              else
                goto label_27;
label_8:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                int num4;
                switch (num3)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 15;
                    continue;
                  case 2:
                    awaiter.GetResult();
                    num3 = 6;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    awaiter = ImportStartActor.\u003CContinuedImport\u003Ed__11.YgbLMy8MHyPq3oeGnPex((object) this.actorModelRuntime.GetActor<IImportExecutorActor>(this.currentImportId).ContinuedImport(settings));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 8;
                    continue;
                  case 4:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
                    continue;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImportStartActor.\u003CContinuedImport\u003Ed__11>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 25 : 24;
                    continue;
                  case 6:
                    this.currentImportId = Guid.NewGuid();
                    num4 = 3;
                    break;
                  case 7:
                    awaiter = this.CheckHasOngoingImport().GetAwaiter();
                    num3 = 13;
                    continue;
                  case 8:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 16;
                  case 9:
                    taskAwaiter = awaiter;
                    num3 = 24;
                    continue;
                  case 11:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 10;
                    continue;
                  case 12:
                    currentImportId = this.currentImportId;
                    num4 = 18;
                    break;
                  case 13:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 2;
                  case 14:
                  case 21:
                    awaiter = taskAwaiter;
                    num3 = 20;
                    continue;
                  case 15:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 4;
                    continue;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 1;
                    num3 = 9;
                    continue;
                  case 17:
                    taskAwaiter = new TaskAwaiter();
                    num4 = 11;
                    break;
                  case 18:
                    goto label_44;
                  case 19:
                    goto label_27;
                  case 20:
                    taskAwaiter = new TaskAwaiter();
                    num3 = 4;
                    continue;
                  case 22:
                    goto label_12;
                  case 23:
                    goto label_40;
                  case 24:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ImportStartActor.\u003CContinuedImport\u003Ed__11>(ref awaiter, this);
                    num3 = 23;
                    continue;
                  case 25:
                    goto label_36;
                  default:
                    awaiter.GetResult();
                    num3 = 12;
                    continue;
                }
                num3 = num4;
              }
label_40:
              return;
label_36:
              return;
label_12:
              awaiter = taskAwaiter;
              num3 = 17;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
              {
                num3 = 9;
                goto label_8;
              }
              else
                goto label_8;
label_27:
              if (num2 != 1)
              {
                num3 = 7;
                goto label_8;
              }
              else
                goto label_12;
            }
            catch (Exception ex)
            {
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_19;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_18;
                }
              }
label_19:
              return;
label_18:
              return;
            }
          case 4:
            num1 = 3;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 4;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(currentImportId);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 2;
            continue;
        }
      }
label_43:;
    }

    /// <inheritdoc />
    public Task ContinueImport()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.currentImportId = ImportStartActor.pRLoZ9EzUQiwMIgop8GL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            if (ImportStartActor.Ni9qBfEzLq62IMu7j7GO(this.currentImportId, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (Task) ImportStartActor.NgbmIGEzs4DtA0edWW6f((object) this.actorModelRuntime.GetActor<IImportExecutorActor>(this.currentImportId));
    }

    /// <summary>Проверка, есть ли активная сессия импорта</summary>
    private Task CheckHasOngoingImport()
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      ImportStartActor.\u003CCheckHasOngoingImport\u003Ed__13 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            tBuilder.Start<ImportStartActor.\u003CCheckHasOngoingImport\u003Ed__13>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ImportStartActor.LcvEbiEzg9J8mdciJDBE();
            num = 5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 3 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    static ImportStartActor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ImportStartActor.ActorId = Guid.Empty;
            num = 3;
            continue;
          case 2:
            ImportStartActor.Iu1bKFEzrMsYyTYru75T();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          case 3:
            ImportStartActor.CurrentImportIdKey = (string) ImportStartActor.yyJaJCEzcfYPLZIW1aY6(-710283084 ^ -537863435 ^ 173810791);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void Iu1bKFEzrMsYyTYru75T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool anjq5rEzdjDfJBTum1RJ() => ImportStartActor.ykDXcKEz9rUdfKbxRwKZ == null;

    internal static ImportStartActor HmCqyCEzlmXNSqCwb9sZ() => ImportStartActor.ykDXcKEz9rUdfKbxRwKZ;

    internal static AsyncTaskMethodBuilder LcvEbiEzg9J8mdciJDBE() => AsyncTaskMethodBuilder.Create();

    internal static bool peq2cNEz5flJfs4YTI0g([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void KO5F0LEzj7dacLHPsu6f([In] object obj0, [In] object obj1, [In] object obj2) => ((IBLOBStore) obj0).Save((string) obj1, (byte[]) obj2);

    internal static void pXalejEzYWqDYSJidDh3([In] object obj0, [In] object obj1) => ((IBLOBStore) obj0).Remove((string) obj1);

    internal static bool Ni9qBfEzLq62IMu7j7GO([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid pRLoZ9EzUQiwMIgop8GL() => Guid.NewGuid();

    internal static object NgbmIGEzs4DtA0edWW6f([In] object obj0) => (object) ((IImportExecutorActor) obj0).ContinueImport();

    internal static object yyJaJCEzcfYPLZIW1aY6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
