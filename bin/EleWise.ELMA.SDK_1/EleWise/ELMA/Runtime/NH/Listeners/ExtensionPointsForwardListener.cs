// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.ExtensionPointsForwardListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>Основной листенер (асинхронная часть)</summary>
  [Serializable]
  internal class ExtensionPointsForwardListener : 
    IPostInsertEventListener,
    IPreInsertEventListener,
    IPostUpdateEventListener,
    IPreUpdateEventListener,
    IPostDeleteEventListener,
    IPreDeleteEventListener,
    IPreLoadEventListener,
    IFlushEventListener,
    IAutoFlushEventListener,
    IFlushEntityEventListener,
    IPostCollectionRemoveEventListener,
    IPostCollectionRecreateEventListener,
    IPostCollectionUpdateEventListener,
    IPreCollectionRemoveEventListener,
    IPreCollectionRecreateEventListener,
    IPreCollectionUpdateEventListener
  {
    [NonSerialized]
    private NestedScopeComponents<IEntityEventsListener> listeners;
    private static ExtensionPointsForwardListener XEQPKxWA3lYxX80yitWO;

    /// <inheritdoc />
    public Task OnAutoFlushAsync(AutoFlushEvent @event, CancellationToken cancellationToken) => Task.CompletedTask;

    /// <inheritdoc />
    public Task OnFlushAsync(FlushEvent @event, CancellationToken cancellationToken)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnFlushAsync\u003Ed__1 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tBuilder.Start<ExtensionPointsForwardListener.\u003COnFlushAsync\u003Ed__1>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 7 : 7;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 2;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = 2;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 4;
              continue;
            case 6:
              goto label_7;
            case 7:
              goto label_5;
            default:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
              continue;
          }
        }
label_7:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
        num1 = 3;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnFlushEntityAsync(FlushEntityEvent @event, CancellationToken cancellationToken) => (Task) ExtensionPointsForwardListener.mc0GvmWAtUXKTMpR7yDd();

    /// <inheritdoc />
    public Task OnPostDeleteAsync(PostDeleteEvent @event, CancellationToken cancellationToken)
    {
      int num = 5;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostDeleteAsync\u003Ed__3 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = 7;
            continue;
          case 3:
            tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostDeleteAsync\u003Ed__3>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.@event = @event;
            num = 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 2;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
            num = 6;
            continue;
          default:
            goto label_8;
        }
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPostInsertAsync(PostInsertEvent @event, CancellationToken cancellationToken)
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostInsertAsync\u003Ed__4 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
              num2 = 7;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 3;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 6;
              continue;
            case 6:
              tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostInsertAsync\u003Ed__4>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 5;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        stateMachine.cancellationToken = cancellationToken;
        num1 = 2;
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPostRecreateCollectionAsync(
      PostCollectionRecreateEvent @event,
      CancellationToken cancellationToken)
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostRecreateCollectionAsync\u003Ed__5 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.@event = @event;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 2;
            continue;
          case 4:
            tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostRecreateCollectionAsync\u003Ed__5>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 6 : 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 3 : 4;
            continue;
          case 6:
            goto label_8;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 5;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 7 : 2;
            continue;
        }
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPostRemoveCollectionAsync(
      PostCollectionRemoveEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostRemoveCollectionAsync\u003Ed__6 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostRemoveCollectionAsync\u003Ed__6>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_10;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = 6;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
              num2 = 2;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 5 : 0;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_10:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E1__state = -1;
        num1 = 7;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPostUpdateAsync(PostUpdateEvent @event, CancellationToken cancellationToken)
    {
      int num1 = 1;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostUpdateAsync\u003Ed__7 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 3;
              continue;
            case 3:
              goto label_6;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
              num2 = 5;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = 4;
              continue;
            case 7:
              goto label_10;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 6 : 4;
              continue;
          }
        }
label_6:
        tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostUpdateAsync\u003Ed__7>(ref stateMachine);
        num1 = 7;
      }
label_10:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPostUpdateCollectionAsync(
      PostCollectionUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      int num = 6;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPostUpdateCollectionAsync\u003Ed__8 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 3;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.@event = @event;
            num = 2;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 5;
            continue;
          case 7:
            goto label_7;
          default:
            tBuilder.Start<ExtensionPointsForwardListener.\u003COnPostUpdateCollectionAsync\u003Ed__8>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 5 : 7;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public async Task<bool> OnPreDeleteAsync(
      PreDeleteEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 2;
      while (true)
      {
        int num2;
        bool result1;
        switch (num1)
        {
          case 1:
            num1 = 4;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 5;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 6;
              else
                goto label_8;
label_7:
              NestedSessionScope nestedSessionScope;
              bool flag1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    result1 = flag1;
                    num3 = 4;
                    continue;
                  case 2:
                    try
                    {
                      int num4;
                      if (num2 != 0)
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 3;
                      else
                        goto label_49;
label_14:
                      IEnumerator<IEntityEventsListener> enumerator;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_9;
                          case 2:
                            goto label_49;
                          case 3:
                            enumerator = this.EntityEventsListeners().GetEnumerator();
                            num4 = 2;
                            continue;
                          case 4:
label_48:
                            enumerator = (IEnumerator<IEntityEventsListener>) null;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                            continue;
                          default:
                            try
                            {
                              int num5;
                              if (num2 != 0)
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                              else
                                goto label_22;
label_19:
                              bool flag;
                              TaskAwaiter<bool> taskAwaiter;
                              IEntityEventsListener current;
                              TaskAwaiter<bool> awaiter;
                              bool result2;
                              while (true)
                              {
                                switch (num5)
                                {
                                  case 1:
                                    cancellationToken.ThrowIfCancellationRequested();
                                    num5 = 2;
                                    continue;
                                  case 2:
                                    if (current is IEntityEventsListenerAsync eventsListenerAsync)
                                    {
                                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 17 : 17;
                                      continue;
                                    }
                                    goto case 11;
                                  case 3:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003E1__state = num2 = 0;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 14 : 14;
                                    continue;
                                  case 4:
                                    goto label_22;
                                  case 5:
                                    result2 = awaiter.GetResult();
                                    num5 = 19;
                                    continue;
                                  case 6:
                                    goto label_48;
                                  case 7:
                                    taskAwaiter = new TaskAwaiter<bool>();
                                    num5 = 16;
                                    continue;
                                  case 8:
                                    awaiter = eventsListenerAsync.OnPreDeleteAsync(@event, cancellationToken).GetAwaiter();
                                    num5 = 15;
                                    continue;
                                  case 9:
                                    goto label_64;
                                  case 10:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9>(ref awaiter, this);
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 9;
                                    continue;
                                  case 11:
                                    // ISSUE: reference to a compiler-generated method
                                    flag1 |= ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9.bsSDQhQgrLKDAumMrLxS((object) current, (object) @event);
                                    num5 = 13;
                                    continue;
                                  case 14:
                                    taskAwaiter = awaiter;
                                    num5 = 10;
                                    continue;
                                  case 15:
                                    if (!awaiter.IsCompleted)
                                    {
                                      num5 = 3;
                                      continue;
                                    }
                                    goto case 5;
                                  case 16:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003E1__state = num2 = -1;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 5 : 0;
                                    continue;
                                  case 17:
                                    flag = flag1;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 8;
                                    continue;
                                  case 18:
                                    current = enumerator.Current;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
                                    continue;
                                  case 19:
                                    flag1 = flag | result2;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 12;
                                    continue;
                                  default:
                                    // ISSUE: reference to a compiler-generated method
                                    if (!ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9.GuxVnXQggM9SYU79268o((object) enumerator))
                                    {
                                      num5 = 6;
                                      continue;
                                    }
                                    goto case 18;
                                }
                              }
label_64:
                              return;
label_22:
                              awaiter = taskAwaiter;
                              num5 = 7;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                              {
                                num5 = 4;
                                goto label_19;
                              }
                              else
                                goto label_19;
                            }
                            finally
                            {
                              if (num2 < 0)
                              {
                                int num6 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
                                  num6 = 0;
                                while (true)
                                {
                                  switch (num6)
                                  {
                                    case 1:
                                      // ISSUE: reference to a compiler-generated method
                                      ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9.kfsfi7Qg5Iv4ZyC0hT3t((object) enumerator);
                                      num6 = 2;
                                      continue;
                                    case 2:
                                      goto label_47;
                                    default:
                                      if (enumerator != null)
                                      {
                                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                                        continue;
                                      }
                                      goto label_47;
                                  }
                                }
                              }
label_47:;
                            }
                        }
                      }
label_49:
                      num4 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
                      {
                        num4 = 0;
                        goto label_14;
                      }
                      else
                        goto label_14;
                    }
                    finally
                    {
                      if (num2 < 0)
                      {
                        int num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                          num7 = 0;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                            case 3:
                              goto label_58;
                            case 2:
                              // ISSUE: reference to a compiler-generated method
                              ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9.kfsfi7Qg5Iv4ZyC0hT3t((object) nestedSessionScope);
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
                              continue;
                            default:
                              if (nestedSessionScope == null)
                              {
                                num7 = 3;
                                continue;
                              }
                              goto case 2;
                          }
                        }
                      }
label_58:;
                    }
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.\u003COnPreDeleteAsync\u003Ed__9.HfonmBQglOHSdjHepjPm((object) @event.Session);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_68;
                  case 5:
label_9:
                    nestedSessionScope = (NestedSessionScope) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                    continue;
                  case 6:
                    flag1 = false;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 3 : 3;
                    continue;
                  default:
                    goto label_8;
                }
              }
label_8:
              num3 = 2;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num8 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                num8 = 2;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_60;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
                    continue;
                }
              }
label_60:
              return;
            }
          case 5:
            goto label_67;
        }
label_68:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 3;
      }
label_67:;
    }

    /// <inheritdoc />
    public async Task<bool> OnPreInsertAsync(
      PreInsertEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      while (true)
      {
        int num2;
        bool result1;
        switch (num1)
        {
          case 1:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 3 : 1;
              else
                goto label_8;
label_7:
              NestedSessionScope nestedSessionScope;
              bool flag1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.\u003COnPreInsertAsync\u003Ed__10.tssFiFQgUrEF3U1mOkuv((object) @event.Session);
                    num3 = 7;
                    continue;
                  case 2:
label_61:
                    nestedSessionScope = (NestedSessionScope) null;
                    num3 = 5;
                    continue;
                  case 3:
                  case 7:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_3;
                  case 5:
                    result1 = flag1;
                    num3 = 4;
                    continue;
                  case 6:
                    goto label_8;
                  default:
                    try
                    {
                      int num4;
                      if (num2 != 0)
                        num4 = 4;
                      else
                        goto label_16;
label_13:
                      while (true)
                      {
                        IEnumerator<IEntityEventsListener> enumerator;
                        switch (num4)
                        {
                          case 1:
                            try
                            {
                              int num5;
                              if (num2 == 0)
                              {
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 4;
                                goto label_21;
                              }
                              else
                                goto label_40;
label_20:
                              int num6;
                              num5 = num6;
label_21:
                              bool flag;
                              TaskAwaiter<bool> taskAwaiter;
                              bool result2;
                              IEntityEventsListener current;
                              TaskAwaiter<bool> awaiter;
                              while (true)
                              {
                                switch (num5)
                                {
                                  case 1:
                                    cancellationToken.ThrowIfCancellationRequested();
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 10 : 7;
                                    continue;
                                  case 2:
                                    flag1 = flag | result2;
                                    num5 = 16;
                                    continue;
                                  case 3:
                                  case 15:
                                  case 16:
                                    goto label_40;
                                  case 4:
                                  case 13:
                                    goto label_29;
                                  case 5:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003E1__state = num2 = -1;
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 7;
                                    continue;
                                  case 6:
                                    goto label_66;
                                  case 7:
                                    goto label_37;
                                  case 8:
                                    goto label_14;
                                  case 9:
                                    goto label_24;
                                  case 10:
                                    if (!(current is IEntityEventsListenerAsync eventsListenerAsync))
                                    {
                                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                                      continue;
                                    }
                                    goto case 12;
                                  case 11:
                                    taskAwaiter = awaiter;
                                    num5 = 19;
                                    continue;
                                  case 12:
                                    flag = flag1;
                                    num5 = 20;
                                    continue;
                                  case 14:
                                    taskAwaiter = new TaskAwaiter<bool>();
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 5;
                                    continue;
                                  case 17:
                                    if (!awaiter.IsCompleted)
                                    {
                                      num5 = 21;
                                      continue;
                                    }
                                    goto label_37;
                                  case 19:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ExtensionPointsForwardListener.\u003COnPreInsertAsync\u003Ed__10>(ref awaiter, this);
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 5 : 6;
                                    continue;
                                  case 20:
                                    awaiter = eventsListenerAsync.OnPreInsertAsync(@event, cancellationToken).GetAwaiter();
                                    num5 = 17;
                                    continue;
                                  case 21:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003E1__state = num2 = 0;
                                    num5 = 11;
                                    continue;
                                  default:
                                    // ISSUE: reference to a compiler-generated method
                                    flag1 |= ExtensionPointsForwardListener.\u003COnPreInsertAsync\u003Ed__10.kUxSwCQgsUTtIIUZlAmb((object) current, (object) @event);
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 13 : 15;
                                    continue;
                                }
                              }
label_66:
                              return;
label_29:
                              awaiter = taskAwaiter;
                              num6 = 14;
                              goto label_20;
label_37:
                              result2 = awaiter.GetResult();
                              num6 = 2;
                              goto label_20;
label_24:
                              current = enumerator.Current;
                              num5 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                              {
                                num5 = 1;
                                goto label_21;
                              }
                              else
                                goto label_21;
label_40:
                              // ISSUE: reference to a compiler-generated method
                              if (!ExtensionPointsForwardListener.\u003COnPreInsertAsync\u003Ed__10.nJTNCaQgcD2LojYWweS3((object) enumerator))
                              {
                                num6 = 8;
                                goto label_20;
                              }
                              else
                                goto label_24;
                            }
                            finally
                            {
                              if (num2 < 0)
                              {
                                int num7 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
                                  num7 = 1;
                                while (true)
                                {
                                  switch (num7)
                                  {
                                    case 1:
                                      if (enumerator != null)
                                      {
                                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                                        continue;
                                      }
                                      goto label_49;
                                    case 2:
                                      goto label_49;
                                    default:
                                      // ISSUE: reference to a compiler-generated method
                                      ExtensionPointsForwardListener.\u003COnPreInsertAsync\u003Ed__10.AZ6NB8QgzmbRM4ZaNtr7((object) enumerator);
                                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 0;
                                      continue;
                                  }
                                }
                              }
label_49:;
                            }
                          case 2:
                            goto label_16;
                          case 3:
                            goto label_61;
                          case 4:
                            enumerator = this.EntityEventsListeners().GetEnumerator();
                            num4 = 2;
                            continue;
                        }
label_14:
                        enumerator = (IEnumerator<IEntityEventsListener>) null;
                        num4 = 3;
                      }
label_16:
                      num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                      {
                        num4 = 0;
                        goto label_13;
                      }
                      else
                        goto label_13;
                    }
                    finally
                    {
                      if (num2 < 0)
                      {
                        int num8 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                          num8 = 2;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 1:
                              goto label_57;
                            case 2:
                              if (nestedSessionScope != null)
                              {
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                                continue;
                              }
                              goto label_57;
                            default:
                              ((IDisposable) nestedSessionScope).Dispose();
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
                              continue;
                          }
                        }
                      }
label_57:;
                    }
                }
              }
label_8:
              flag1 = false;
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
              {
                num3 = 1;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    goto label_62;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = 2;
                    continue;
                }
              }
label_62:
              return;
            }
          case 2:
            goto label_69;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 2;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 0;
            continue;
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 3;
      }
label_69:;
    }

    /// <inheritdoc />
    public Task OnPreLoadAsync(PreLoadEvent @event, CancellationToken cancellationToken) => (Task) ExtensionPointsForwardListener.mc0GvmWAtUXKTMpR7yDd();

    /// <inheritdoc />
    public Task OnPreRecreateCollectionAsync(
      PreCollectionRecreateEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPreRecreateCollectionAsync\u003Ed__12 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              tBuilder.Start<ExtensionPointsForwardListener.\u003COnPreRecreateCollectionAsync\u003Ed__12>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 2;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_9;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ExtensionPointsForwardListener.pobYAnWADVLpVodsckYD();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 7 : 3;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 6 : 0;
              continue;
          }
        }
label_9:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 4;
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task OnPreRemoveCollectionAsync(
      PreCollectionRemoveEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 7;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPreRemoveCollectionAsync\u003Ed__13 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 3;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 3 : 4;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              tBuilder.Start<ExtensionPointsForwardListener.\u003COnPreRemoveCollectionAsync\u003Ed__13>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.@event = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 6;
              continue;
            default:
              goto label_9;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        tBuilder = stateMachine.\u003C\u003Et__builder;
        num1 = 5;
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public async Task<bool> OnPreUpdateAsync(
      PreUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int num3;
        bool result1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_71;
            case 2:
label_5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num2 = 3;
              continue;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_3;
            default:
              try
              {
                int num4;
                if (num3 != 0)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                else
                  goto label_62;
label_10:
                NestedSessionScope nestedSessionScope;
                bool flag1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      try
                      {
                        int num5;
                        if (num3 != 0)
                          num5 = 2;
                        else
                          goto label_51;
label_17:
                        IEnumerator<IEntityEventsListener> enumerator;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_51;
                            case 2:
                              enumerator = this.EntityEventsListeners().GetEnumerator();
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                              continue;
                            case 3:
label_53:
                              enumerator = (IEnumerator<IEntityEventsListener>) null;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 4;
                              continue;
                            case 4:
                              goto label_11;
                            default:
                              try
                              {
                                int num6;
                                if (num3 == 0)
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 4 : 1;
                                else
                                  goto label_30;
label_22:
                                IEntityEventsListener current;
                                while (true)
                                {
                                  bool flag;
                                  TaskAwaiter<bool> taskAwaiter;
                                  int num7;
                                  TaskAwaiter<bool> awaiter;
                                  bool result2;
                                  switch (num6)
                                  {
                                    case 1:
                                      // ISSUE: reference to a compiler-generated method
                                      flag1 |= ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.LV8f7wQ5qHijvljr6io2((object) current, (object) @event);
                                      num6 = 19;
                                      continue;
                                    case 2:
                                      flag = flag1;
                                      num6 = 14;
                                      continue;
                                    case 3:
                                    case 12:
                                      result2 = awaiter.GetResult();
                                      num6 = 11;
                                      continue;
                                    case 4:
                                    case 7:
                                      awaiter = taskAwaiter;
                                      num6 = 16;
                                      continue;
                                    case 5:
                                      taskAwaiter = awaiter;
                                      num6 = 15;
                                      continue;
                                    case 6:
                                      goto label_53;
                                    case 8:
                                      goto label_29;
                                    case 9:
                                    case 13:
                                    case 19:
                                      goto label_30;
                                    case 10:
                                      cancellationToken.ThrowIfCancellationRequested();
                                      num6 = 17;
                                      continue;
                                    case 11:
                                      flag1 = flag | result2;
                                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 9 : 4;
                                      continue;
                                    case 14:
                                      awaiter = eventsListenerAsync.OnPreUpdateAsync(@event, cancellationToken).GetAwaiter();
                                      num7 = 21;
                                      break;
                                    case 15:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14>(ref awaiter, this);
                                      num6 = 18;
                                      continue;
                                    case 16:
                                      taskAwaiter = new TaskAwaiter<bool>();
                                      num7 = 20;
                                      break;
                                    case 17:
                                      if (current is IEntityEventsListenerAsync eventsListenerAsync)
                                      {
                                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
                                        continue;
                                      }
                                      goto case 1;
                                    case 18:
                                      goto label_68;
                                    case 20:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003E1__state = num3 = -1;
                                      num6 = 12;
                                      continue;
                                    case 21:
                                      if (awaiter.IsCompleted)
                                      {
                                        num6 = 3;
                                        continue;
                                      }
                                      goto default;
                                    default:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003E1__state = num3 = 0;
                                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 5;
                                      continue;
                                  }
                                  num6 = num7;
                                }
label_68:
                                return;
label_29:
                                current = enumerator.Current;
                                num6 = 10;
                                goto label_22;
label_30:
                                // ISSUE: reference to a compiler-generated method
                                if (!ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.YUKlxIQ5K1E2pupWOR1I((object) enumerator))
                                {
                                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 5 : 6;
                                  goto label_22;
                                }
                                else
                                  goto label_29;
                              }
                              finally
                              {
                                int num8;
                                if (num3 >= 0)
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                                else
                                  goto label_45;
label_44:
                                while (true)
                                {
                                  switch (num8)
                                  {
                                    case 1:
                                      goto label_45;
                                    case 2:
                                      // ISSUE: reference to a compiler-generated method
                                      ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.giS4HpQ5Xtq1323KnMLs((object) enumerator);
                                      num8 = 3;
                                      continue;
                                    default:
                                      goto label_49;
                                  }
                                }
label_45:
                                if (enumerator != null)
                                {
                                  num8 = 2;
                                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                                  {
                                    num8 = 2;
                                    goto label_44;
                                  }
                                  else
                                    goto label_44;
                                }
label_49:;
                              }
                          }
                        }
label_51:
                        num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                        {
                          num5 = 0;
                          goto label_17;
                        }
                        else
                          goto label_17;
                      }
                      finally
                      {
                        int num9;
                        if (num3 >= 0)
                          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
                        else
                          goto label_58;
label_56:
                        while (true)
                        {
                          switch (num9)
                          {
                            case 1:
                              goto label_58;
                            case 2:
                            case 3:
                              goto label_61;
                            default:
                              // ISSUE: reference to a compiler-generated method
                              ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.giS4HpQ5Xtq1323KnMLs((object) nestedSessionScope);
                              num9 = 3;
                              continue;
                          }
                        }
label_58:
                        if (nestedSessionScope != null)
                        {
                          num9 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
                          {
                            num9 = 0;
                            goto label_56;
                          }
                          else
                            goto label_56;
                        }
label_61:;
                      }
                    case 2:
label_11:
                      nestedSessionScope = (NestedSessionScope) null;
                      num4 = 3;
                      continue;
                    case 3:
                      result1 = flag1;
                      num4 = 6;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.jmUKKSQ5RvxckpgwTwno(ExtensionPointsForwardListener.\u003COnPreUpdateAsync\u003Ed__14.FENuNkQ5i8lS6WTk66iN((object) @event));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 5;
                      continue;
                    case 5:
                      goto label_62;
                    case 6:
                      goto label_5;
                    default:
                      flag1 = false;
                      num4 = 4;
                      continue;
                  }
                }
label_62:
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                {
                  num4 = 1;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              catch (Exception ex)
              {
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num10 = 0;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 2;
                      continue;
                    case 2:
                      goto label_64;
                    default:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                      continue;
                  }
                }
label_64:
                return;
              }
          }
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        num3 = (^this).\u003C\u003E1__state;
        num1 = 4;
      }
label_71:;
    }

    /// <inheritdoc />
    public Task OnPreUpdateCollectionAsync(
      PreCollectionUpdateEvent @event,
      CancellationToken cancellationToken)
    {
      int num = 7;
      // ISSUE: variable of a compiler-generated type
      ExtensionPointsForwardListener.\u003COnPreUpdateCollectionAsync\u003Ed__15 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 5 : 3;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.cancellationToken = cancellationToken;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 2;
            continue;
          case 5:
            tBuilder.Start<ExtensionPointsForwardListener.\u003COnPreUpdateCollectionAsync\u003Ed__15>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.@event = @event;
            num = 3;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 4;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private IEnumerable<IEntityEventsListener> EntityEventsListeners()
    {
      if (this.listeners == null)
      {
        lock (this)
        {
          if (this.listeners == null)
            this.listeners = new NestedScopeComponents<IEntityEventsListener>(ServiceScope.Shell);
        }
      }
      return this.listeners.Available ? this.listeners.Value : (IEnumerable<IEntityEventsListener>) EleWise.ELMA.Helpers.EmptyArray<IEntityEventsListener>.Instance;
    }

    private static NestedSessionScope NestedSession(object session) => new NestedSessionScope((ISession) session, "");

    public void OnPreLoad(PreLoadEvent @event)
    {
    }

    public bool OnPreInsert(PreInsertEvent @event)
    {
      int num1 = 4;
      NestedSessionScope nestedSessionScope;
      bool veto;
      PreInsertEvent event1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_14;
            case 3:
              goto label_16;
            case 4:
              num2 = 3;
              continue;
            case 5:
              veto = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            default:
              nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT((object) event1.Session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 1 : 1;
              continue;
          }
        }
label_16:
        event1 = @event;
        num1 = 5;
      }
label_4:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                veto |= ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass20_0.os5gsDQ5aYaNXY8niMHe((object) l, (object) event1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_12;
              default:
                ((IDisposable) nestedSessionScope).Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_12:;
      }
label_14:
      return veto;
    }

    public bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num1 = 4;
      NestedSessionScope nestedSessionScope;
      bool veto;
      PreUpdateEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_5;
          case 3:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 5;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            veto = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          default:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT((object) event1.Session);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
            continue;
        }
      }
label_5:
      return veto;
label_6:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                veto |= ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass21_0.aj15nsQ56GqvdOXnAZm7((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_5;
        }
      }
      finally
      {
        int num4;
        if (nestedSessionScope == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
        else
          goto label_12;
label_11:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_12:
        ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
        num4 = 2;
        goto label_11;
      }
    }

    public virtual bool OnPreDelete(PreDeleteEvent @event)
    {
      int num1 = 5;
      NestedSessionScope nestedSessionScope;
      bool veto;
      PreDeleteEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            veto = false;
            num1 = 3;
            continue;
          case 3:
            nestedSessionScope = ExtensionPointsForwardListener.NestedSession(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
            continue;
          case 4:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 2;
            continue;
          case 5:
            num1 = 4;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                veto |= l.OnPreDelete(event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        int num4;
        if (nestedSessionScope == null)
          num4 = 2;
        else
          goto label_11;
label_10:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_11:
        ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        {
          num4 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
label_14:
      return veto;
    }

    public virtual void OnPostInsert(PostInsertEvent @event)
    {
      int num1 = 2;
      NestedSessionScope nestedSessionScope;
      PostInsertEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_14;
          default:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
            num1 = 3;
            continue;
        }
      }
label_14:
      return;
label_5:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass23_0.qPRuOsQ5MjSENZtrTi8l((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ((IDisposable) nestedSessionScope).Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    public virtual void OnPostUpdate(PostUpdateEvent @event)
    {
      int num1 = 2;
      NestedSessionScope nestedSessionScope;
      PostUpdateEvent event1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_16;
            case 1:
              goto label_4;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            case 3:
              nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
              num2 = 4;
              continue;
            case 4:
              goto label_7;
            default:
              goto label_11;
          }
        }
label_4:
        event1 = @event;
        num1 = 3;
      }
label_16:
      return;
label_11:
      return;
label_7:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass24_0.zAhnhcQ5rJ9RZia928wS((object) l, (object) event1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_18;
              default:
                ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_18:;
      }
    }

    public virtual void OnPostDelete(PostDeleteEvent @event)
    {
      int num1 = 3;
      NestedSessionScope nestedSessionScope;
      PostDeleteEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            goto label_2;
          case 2:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 4;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 2;
            continue;
          case 4:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_13:
      return;
label_10:
      return;
label_2:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass25_0.ju8D2OQ5LgcAGZZx4uqA((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        int num4;
        if (nestedSessionScope == null)
          num4 = 2;
        else
          goto label_11;
label_9:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_11:
        ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        {
          num4 = 0;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    public void OnFlush(FlushEvent @event)
    {
      int num1 = 3;
      NestedSessionScope nestedSessionScope;
      FlushEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_11;
          default:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
            continue;
        }
      }
label_11:
      return;
label_2:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass26_0.ExSgccQjF5MyFwanDEPr((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_13;
              default:
                ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_13:;
      }
    }

    public void OnPostRemoveCollection(PostCollectionRemoveEvent @event)
    {
      int num1 = 4;
      NestedSessionScope nestedSessionScope;
      PostCollectionRemoveEvent event1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_13;
            case 3:
              event1 = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_16;
            default:
              nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
          }
        }
label_16:
        num1 = 3;
      }
label_13:
      return;
label_4:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass27_0.cjPcD2Qjh2rAQPkmKdH5((object) l, (object) event1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    public void OnPostRecreateCollection(PostCollectionRecreateEvent @event)
    {
      int num1 = 1;
      NestedSessionScope nestedSessionScope;
      PostCollectionRecreateEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            goto label_3;
          case 4:
            nestedSessionScope = ExtensionPointsForwardListener.NestedSession((object) event1.Session);
            num1 = 3;
            continue;
          default:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 4;
            continue;
        }
      }
label_12:
      return;
label_3:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                l.OnPostRecreateCollection(event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ((IDisposable) nestedSessionScope).Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              default:
                goto label_14;
            }
          }
        }
label_14:;
      }
    }

    public void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
    {
      int num1 = 4;
      NestedSessionScope nestedSessionScope;
      PostCollectionUpdateEvent event1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_3;
            case 2:
              nestedSessionScope = ExtensionPointsForwardListener.NestedSession(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_18;
            case 4:
              num2 = 3;
              continue;
            default:
              goto label_11;
          }
        }
label_18:
        event1 = @event;
        num1 = 2;
      }
label_12:
      return;
label_11:
      return;
label_3:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                l.OnPostUpdateCollection(event1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        int num5;
        if (nestedSessionScope == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 1;
        else
          goto label_13;
label_10:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_13:
        ((IDisposable) nestedSessionScope).Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        {
          num5 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    public void OnPreRemoveCollection(PreCollectionRemoveEvent @event)
    {
      int num1 = 2;
      NestedSessionScope nestedSessionScope;
      PreCollectionRemoveEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            event1 = @event;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT(ExtensionPointsForwardListener.y6df2aWA66OIejtGAaL1((object) event1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 3;
            continue;
          default:
            goto label_13;
        }
      }
label_16:
      return;
label_13:
      return;
label_5:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass30_0.r9OIfOQjiaaS5EUegVm3((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        int num4;
        if (nestedSessionScope == null)
          num4 = 2;
        else
          goto label_14;
label_12:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_14:
        ((IDisposable) nestedSessionScope).Dispose();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        {
          num4 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    public void OnPreRecreateCollection(PreCollectionRecreateEvent @event)
    {
      int num1 = 4;
      NestedSessionScope nestedSessionScope;
      PreCollectionRecreateEvent event1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT((object) event1.Session);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_16;
            case 4:
              num2 = 3;
              continue;
            default:
              goto label_3;
          }
        }
label_16:
        event1 = @event;
        num1 = 2;
      }
label_13:
      return;
label_3:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass31_0.ugp7aBQjTUT7Mw0BL8hS((object) l, (object) event1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
          num4 = 0;
        switch (num4)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    public void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
    {
      int num1 = 1;
      NestedSessionScope nestedSessionScope;
      PreCollectionUpdateEvent event1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            nestedSessionScope = (NestedSessionScope) ExtensionPointsForwardListener.heRTiAWAwLahmturwMLT((object) event1.Session);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 3;
            continue;
          case 3:
            goto label_4;
          case 4:
            goto label_13;
          default:
            event1 = @event;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 0;
            continue;
        }
      }
label_13:
      return;
label_4:
      try
      {
        this.EntityEventsListeners().ForEach<IEntityEventsListener>((Action<IEntityEventsListener>) (l =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                ExtensionPointsForwardListener.\u003C\u003Ec__DisplayClass32_0.unoQJDQjeIhrOtCAgsSA((object) l, (object) event1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      finally
      {
        if (nestedSessionScope != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ExtensionPointsForwardListener.VXU2B2WA4mbbvrl2iXwL((object) nestedSessionScope);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    public void OnAutoFlush(AutoFlushEvent @event)
    {
    }

    public void OnFlushEntity(FlushEntityEvent @event)
    {
    }

    public ExtensionPointsForwardListener()
    {
      ExtensionPointsForwardListener.kmFQ45WAH00Y1gwdnaHC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static AsyncTaskMethodBuilder pobYAnWADVLpVodsckYD() => AsyncTaskMethodBuilder.Create();

    internal static bool Kd8NKvWApP1dTjhGi7h3() => ExtensionPointsForwardListener.XEQPKxWA3lYxX80yitWO == null;

    internal static ExtensionPointsForwardListener Efwd6jWAaJKZna3OuvjM() => ExtensionPointsForwardListener.XEQPKxWA3lYxX80yitWO;

    internal static object mc0GvmWAtUXKTMpR7yDd() => (object) Task.CompletedTask;

    internal static object heRTiAWAwLahmturwMLT([In] object obj0) => (object) ExtensionPointsForwardListener.NestedSession(obj0);

    internal static void VXU2B2WA4mbbvrl2iXwL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object y6df2aWA66OIejtGAaL1([In] object obj0) => (object) ((AbstractEvent) obj0).Session;

    internal static void kmFQ45WAH00Y1gwdnaHC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
