// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RequiredFieldValidatorInfo
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
  public class RequiredFieldValidatorInfo : IValidatorInfo
  {
    private static RequiredFieldValidatorInfo nrmuKco5SZpnu28tamnq;

    public Type AttributeType => RequiredFieldValidatorInfo.DJ6y9bo5qauNTMNyoCjU(__typeref (RequiredFieldAttribute));

    public Type ValidatorType => RequiredFieldValidatorInfo.DJ6y9bo5qauNTMNyoCjU(__typeref (RequiredFieldValidator));

    public RequiredFieldValidatorInfo()
    {
      RequiredFieldValidatorInfo.vN5fvYo5Kh24LBN3Diko();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type DJ6y9bo5qauNTMNyoCjU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void vN5fvYo5Kh24LBN3Diko() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool z3wn01o5i3BxStySiNlQ() => RequiredFieldValidatorInfo.nrmuKco5SZpnu28tamnq == null;

    internal static RequiredFieldValidatorInfo SyZ4p1o5RVNVvdwnD3Ak() => RequiredFieldValidatorInfo.nrmuKco5SZpnu28tamnq;
  }
}
