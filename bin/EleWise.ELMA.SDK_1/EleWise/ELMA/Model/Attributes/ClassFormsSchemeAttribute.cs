// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ClassFormsSchemeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает схему настроек форм класса</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class ClassFormsSchemeAttribute : Attribute
  {
    private ClassFormsScheme scheme;
    private static ClassFormsSchemeAttribute x5hbCYoCVLZ0ltimylVU;

    public ClassFormsSchemeAttribute(ClassFormsScheme scheme)
    {
      ClassFormsSchemeAttribute.qPOlgWoCR1OIqQsL2RC2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.scheme = scheme;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Схема</summary>
    public ClassFormsScheme Scheme => this.scheme;

    internal static void qPOlgWoCR1OIqQsL2RC2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Xgj4vpoCSoVM85HY2hmu() => ClassFormsSchemeAttribute.x5hbCYoCVLZ0ltimylVU == null;

    internal static ClassFormsSchemeAttribute GnYaoYoCiR0DjSts2qsh() => ClassFormsSchemeAttribute.x5hbCYoCVLZ0ltimylVU;
  }
}
