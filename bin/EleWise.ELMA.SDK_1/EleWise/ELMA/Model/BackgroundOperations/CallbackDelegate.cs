// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.BackgroundOperations.CallbackDelegate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.BackgroundOperations
{
  /// <summary>Делегат обратного вызова.</summary>
  [Serializable]
  public class CallbackDelegate : ICallbackDelegate
  {
    private static CallbackDelegate bjJ6OLWckNstuikM1eOC;

    /// <summary>Ctor</summary>
    public CallbackDelegate()
    {
      CallbackDelegate.KS88AIWc2jkYJws5GZvB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DelegateSignature = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.ArgumentNames = new string[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имена аргументов в сигнатуре делегата.</summary>
    public string[] ArgumentNames
    {
      get => this.\u003CArgumentNames\u003Ek__BackingField;
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
              this.\u003CArgumentNames\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Строковое представление сигнатуры делегата.</summary>
    public string DelegateSignature
    {
      get => this.\u003CDelegateSignature\u003Ek__BackingField;
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
              this.\u003CDelegateSignature\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    internal static void KS88AIWc2jkYJws5GZvB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ROLWZ3Wcn7qSMxrFF8vw() => CallbackDelegate.bjJ6OLWckNstuikM1eOC == null;

    internal static CallbackDelegate vEkvg3WcODyOgVSrcgmY() => CallbackDelegate.bjJ6OLWckNstuikM1eOC;
  }
}
