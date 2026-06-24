// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeValueValidatorInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Validation
{
  [Component]
  public class RangeValueValidatorInfo : IValidatorInfo
  {
    internal static RangeValueValidatorInfo si0VNsogy8ywvsnLMMaY;

    public Type AttributeType => RangeValueValidatorInfo.JXpVMwog9mOsFKCywKtQ(__typeref (RangeValueAttribute));

    public Type ValidatorType => typeof (RangeValueValidator);

    public RangeValueValidatorInfo()
    {
      RangeValueValidatorInfo.TqxQoyogdvfinPu52rfh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type JXpVMwog9mOsFKCywKtQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void TqxQoyogdvfinPu52rfh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LVMVSJogMyxORN9aFXR9() => RangeValueValidatorInfo.si0VNsogy8ywvsnLMMaY == null;

    internal static RangeValueValidatorInfo ucXTLvogJP7nMN5Ov7bQ() => RangeValueValidatorInfo.si0VNsogy8ywvsnLMMaY;
  }
}
