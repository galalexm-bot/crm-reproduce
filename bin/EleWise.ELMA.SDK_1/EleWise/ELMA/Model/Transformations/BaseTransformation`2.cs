// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.BaseTransformation`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Transformations
{
  [Serializable]
  public abstract class BaseTransformation<TItem, TUid> : IXsiType where TItem : class
  {
    private static object VnTQbLWLzDEqn3bantr2;

    public TUid Uid { get; set; }

    public abstract void Apply(TItem rootItem);

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public virtual IEnumerable<string> GetLocalizableStrings() => LocalizableAttributeHelper.GetStrings((object) this);

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public virtual void ApplyLocalization() => LocalizableAttributeHelper.Localize((object) this);

    protected BaseTransformation()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JXWxlHWUFs5m8RBqVxll() => BaseTransformation<TItem, TUid>.VnTQbLWLzDEqn3bantr2 == null;

    internal static object UsoDdBWUBoQAGUmppWtF() => BaseTransformation<TItem, TUid>.VnTQbLWLzDEqn3bantr2;
  }
}
