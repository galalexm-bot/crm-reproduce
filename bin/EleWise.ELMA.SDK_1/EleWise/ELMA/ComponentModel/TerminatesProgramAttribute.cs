// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.TerminatesProgramAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the marked method unconditionally terminates control flow execution.
  /// For example, it could unconditionally throw exception.
  /// </summary>
  [Obsolete("Use [ContractAnnotation('=> halt')] instead")]
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class TerminatesProgramAttribute : Attribute
  {
    private static TerminatesProgramAttribute H79oX3fCx9yeQqSGO2H6;

    public TerminatesProgramAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool GQypGkfC0ouWZiDcaC9h() => TerminatesProgramAttribute.H79oX3fCx9yeQqSGO2H6 == null;

    internal static TerminatesProgramAttribute y57RuWfCmsV9pbuwttdo() => TerminatesProgramAttribute.H79oX3fCx9yeQqSGO2H6;
  }
}
