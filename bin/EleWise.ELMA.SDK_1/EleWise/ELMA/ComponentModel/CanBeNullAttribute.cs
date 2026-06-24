// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.CanBeNullAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the value of the marked element could be <c>null</c> sometimes,
  /// so the check for <c>null</c> is necessary before its usage.
  /// </summary>
  /// <example><code>
  /// [CanBeNull] public object Test() { return null; }
  /// public void UseTest() {
  ///   var p = Test();
  ///   var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.Delegate)]
  public sealed class CanBeNullAttribute : Attribute
  {
    private static CanBeNullAttribute uSTkUyfEgxVlKSFr7aeg;

    public CanBeNullAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QEanMNfE5XFREAVRGMe7() => CanBeNullAttribute.uSTkUyfEgxVlKSFr7aeg == null;

    internal static CanBeNullAttribute l7oLKmfEjjaNv0JitEnW() => CanBeNullAttribute.uSTkUyfEgxVlKSFr7aeg;
  }
}
