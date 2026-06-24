// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.NamespaceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Базовый класс с информацией о пространстве имен</summary>
  [Component]
  public abstract class NamespaceInfo : INamespaceInfo
  {
    internal static NamespaceInfo n8G0BLb7S9wBxOqOALR2;

    /// <summary>Пространство имен</summary>
    public virtual string Namespace => this.GetType().Namespace;

    /// <summary>Отображаемое название</summary>
    public abstract string DisplayName { get; }

    protected NamespaceInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sxD90Kb7iXQVToTRj6aE() => NamespaceInfo.n8G0BLb7S9wBxOqOALR2 == null;

    internal static NamespaceInfo xl7XJVb7RHfjY3Eqn5Js() => NamespaceInfo.n8G0BLb7S9wBxOqOALR2;
  }
}
