// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.PostFlushActionRunner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  [Component]
  public class PostFlushActionRunner : IUnitOfWorkEventListener
  {
    private readonly IContextBoundVariableService contextBoundVariableService;
    private static PostFlushActionRunner B3Ex1rWMdmJi19nJsoy4;

    public PostFlushActionRunner(
      IContextBoundVariableService contextBoundVariableService)
    {
      PostFlushActionRunner.bjNFJbWMgDlwWAgdNq3W();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    private IDictionary<string, System.Action> Actions => (IDictionary<string, System.Action>) this.contextBoundVariableService.GetOrAdd<Dictionary<string, System.Action>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153952971), (Func<Dictionary<string, System.Action>>) (() => new Dictionary<string, System.Action>()));

    public void Add(System.Action action)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Actions.Add(PostFlushActionRunner.bcv3XBWMj0LsE8A9cGea().ToString(), action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 3;
            continue;
          case 2:
            if (action != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:
      throw new ArgumentNullException((string) PostFlushActionRunner.dvPEGYWM5NyPDyndoSaN(1505778440 - 1981636111 ^ -475798259));
    }

    public void Add(string key, System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (key == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            }
            if (action != null)
            {
              if (this.Actions.ContainsKey(key))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 2;
                continue;
              }
              goto case 3;
            }
            else
            {
              num = 5;
              continue;
            }
          case 2:
            goto label_12;
          case 3:
            this.Actions.Add(key, action);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 4 : 1;
            continue;
          case 4:
            goto label_2;
          case 5:
            goto label_5;
          default:
            goto label_8;
        }
      }
label_12:
      return;
label_2:
      return;
label_5:
      throw new ArgumentNullException((string) PostFlushActionRunner.dvPEGYWM5NyPDyndoSaN(-606654180 ^ -606721816));
label_8:
      throw new ArgumentNullException((string) PostFlushActionRunner.dvPEGYWM5NyPDyndoSaN(-1638402543 ^ -1638497871));
    }

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            IDictionary<string, System.Action> actions = this.Actions;
            // ISSUE: reference to a compiler-generated field
            Action<KeyValuePair<string, System.Action>> action1 = PostFlushActionRunner.\u003C\u003Ec.\u003C\u003E9__9_0;
            Action<KeyValuePair<string, System.Action>> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PostFlushActionRunner.\u003C\u003Ec.\u003C\u003E9__9_0 = action2 = (Action<KeyValuePair<string, System.Action>>) (p => p.Value());
            }
            else
              goto label_7;
label_6:
            actions.ForEach<KeyValuePair<string, System.Action>>(action2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
label_7:
            action2 = action1;
            goto label_6;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:;
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PostFlushActionRunner.WVoqGOWMYZIWhqpp0Vgq((object) this.Actions);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void bjNFJbWMgDlwWAgdNq3W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YcyFg9WMlvus6CURyUV4() => PostFlushActionRunner.B3Ex1rWMdmJi19nJsoy4 == null;

    internal static PostFlushActionRunner kN5uSrWMrHPZkpF3YPsg() => PostFlushActionRunner.B3Ex1rWMdmJi19nJsoy4;

    internal static object dvPEGYWM5NyPDyndoSaN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid bcv3XBWMj0LsE8A9cGea() => Guid.NewGuid();

    internal static void WVoqGOWMYZIWhqpp0Vgq([In] object obj0) => ((ICollection<KeyValuePair<string, System.Action>>) obj0).Clear();
  }
}
