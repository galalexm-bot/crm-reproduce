// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Attributes.StatelessWorkerAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ActorModel.Attributes
{
  /// <summary>
  /// Обозначает Актор, у которого нет внутреннего состояния и для которого допускаются множественные активации, т.е.
  /// допускается наличие в системе нескольких экземпляров одного и того же актора с тем же самым ключом.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class StatelessWorkerAttribute : Attribute
  {
    internal static StatelessWorkerAttribute elMWlNfDZHWd4v4MgWDl;

    public StatelessWorkerAttribute()
    {
      StatelessWorkerAttribute.pImbt8fDVJL7RO4wtWap();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void pImbt8fDVJL7RO4wtWap() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OwZHS9fDu3AXbheayV4H() => StatelessWorkerAttribute.elMWlNfDZHWd4v4MgWDl == null;

    internal static StatelessWorkerAttribute DZkGFifDIFViKZuhQbiM() => StatelessWorkerAttribute.elMWlNfDZHWd4v4MgWDl;
  }
}
