// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.LinqTunnelAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that method is pure LINQ method, with postponed enumeration (like Enumerable.Select,
  /// .Where). This annotation allows inference of [InstantHandle] annotation for parameters
  /// of delegate type by analyzing LINQ method chains.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class LinqTunnelAttribute : Attribute
  {
    internal static LinqTunnelAttribute tlI8p7fCy8E13RMIxoFI;

    public LinqTunnelAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VXRyIWfCM3XK90CNvWJn() => LinqTunnelAttribute.tlI8p7fCy8E13RMIxoFI == null;

    internal static LinqTunnelAttribute dnqQ9WfCJ6eMQoUMa8Do() => LinqTunnelAttribute.tlI8p7fCy8E13RMIxoFI;
  }
}
