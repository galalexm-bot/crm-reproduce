// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.MethodMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  internal class MethodMessage : BaseMessage, ISourceMessage
  {
    internal static MethodMessage Axhh99EiqlMYxV5OspqB;

    /// <summary>Тип владельца</summary>
    public Type ExecutedType
    {
      get => this.\u003CExecutedType\u003Ek__BackingField;
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
              this.\u003CExecutedType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    /// <summary>Информация о методе</summary>
    public MethodInfo ExecutedMethod
    {
      get => this.\u003CExecutedMethod\u003Ek__BackingField;
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
              this.\u003CExecutedMethod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    public MethodMessage()
    {
      MethodMessage.vZZo0UEiThKQxXc9nCu5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cFkTrPEiKiI2syXraOxj() => MethodMessage.Axhh99EiqlMYxV5OspqB == null;

    internal static MethodMessage petAGfEiXxOnrD24cUu2() => MethodMessage.Axhh99EiqlMYxV5OspqB;

    internal static void vZZo0UEiThKQxXc9nCu5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
