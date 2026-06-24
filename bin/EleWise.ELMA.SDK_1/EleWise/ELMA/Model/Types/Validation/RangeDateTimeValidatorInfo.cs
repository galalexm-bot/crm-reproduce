// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RangeDateTimeValidatorInfo
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
  public class RangeDateTimeValidatorInfo : IValidatorInfo
  {
    internal static RangeDateTimeValidatorInfo xPryoKognZrNa4AgMSYt;

    public Type AttributeType => typeof (RangeDateTimeAttribute);

    public Type ValidatorType => RangeDateTimeValidatorInfo.VSiLlBogeSKuhZ0D1Ofi(__typeref (RangeDateTimeValidator));

    public RangeDateTimeValidatorInfo()
    {
      RangeDateTimeValidatorInfo.QjgelWogPFCxCSkK3PWk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type VSiLlBogeSKuhZ0D1Ofi([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void QjgelWogPFCxCSkK3PWk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool oLaZYXogOXiKA6Y9KS98() => RangeDateTimeValidatorInfo.xPryoKognZrNa4AgMSYt == null;

    internal static RangeDateTimeValidatorInfo WraXZoog2EErMnOdgsDo() => RangeDateTimeValidatorInfo.xPryoKognZrNa4AgMSYt;
  }
}
