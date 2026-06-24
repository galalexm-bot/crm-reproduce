// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ActionInputComputedValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <inheritdoc cref="T:EleWise.ELMA.Model.Views.IActionInputComputedValue" />
  [Serializable]
  public class ActionInputComputedValue : 
    InputComputedValue,
    IActionInputComputedValue,
    IInputComputedValue,
    IComputedValue
  {
    internal static ActionInputComputedValue KpTa4woiKDgATjIHuAxX;

    /// <inheritdoc />
    public TypeSignature ReturnType
    {
      get => this.\u003CReturnType\u003Ek__BackingField;
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
              this.\u003CReturnType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public TypeSignature ParameterType
    {
      get => this.\u003CParameterType\u003Ek__BackingField;
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
              this.\u003CParameterType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
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

    public ActionInputComputedValue()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      this.\u003CReturnType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: reference to a compiler-generated field
      this.\u003CParameterType\u003Ek__BackingField = new TypeSignature();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DYoVTEoiXgVO0cUPxXZ3() => ActionInputComputedValue.KpTa4woiKDgATjIHuAxX == null;

    internal static ActionInputComputedValue BtFO0QoiTSP3uLF0JAJb() => ActionInputComputedValue.KpTa4woiKDgATjIHuAxX;
  }
}
