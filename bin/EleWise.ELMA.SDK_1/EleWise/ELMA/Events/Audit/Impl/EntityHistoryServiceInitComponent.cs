// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.EntityHistoryServiceInitComponent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  [Component]
  internal class EntityHistoryServiceInitComponent : IInitHandler
  {
    internal static EntityHistoryServiceInitComponent Dy7hyAGc92dEOhUN6o9a;

    public IEntityActionHistoryEventService Service
    {
      get => this.\u003CService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public void Init()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityHistoryServiceInitComponent.Un194fGcrmaEmViPKd9M((object) this.Service);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void InitComplete()
    {
    }

    public EntityHistoryServiceInitComponent()
    {
      EntityHistoryServiceInitComponent.ONX0bTGcghI21Kox4H0m();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool WrVcWHGcdm5KYC63Am9w() => EntityHistoryServiceInitComponent.Dy7hyAGc92dEOhUN6o9a == null;

    internal static EntityHistoryServiceInitComponent FIPVqjGclApXewEtyKou() => EntityHistoryServiceInitComponent.Dy7hyAGc92dEOhUN6o9a;

    internal static void Un194fGcrmaEmViPKd9M([In] object obj0) => ((IEntityActionHistoryEventService) obj0).Initialize();

    internal static void ONX0bTGcghI21Kox4H0m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
