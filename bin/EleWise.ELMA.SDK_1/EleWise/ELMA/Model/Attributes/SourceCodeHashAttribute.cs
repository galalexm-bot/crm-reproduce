// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.SourceCodeHashAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает исходную сборку, на основе которой была сгенерирована динамическая сборка
  /// </summary>
  [Obsolete("Not used", true)]
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
  public class SourceCodeHashAttribute : Attribute
  {
    private string hashCode;
    internal static SourceCodeHashAttribute qGG4HJofjlGWNRZTHXN5;

    /// <summary>Ctor</summary>
    /// <param name="hashCode">Хэш-код</param>
    public SourceCodeHashAttribute(string hashCode)
    {
      SourceCodeHashAttribute.HZP6alofUFyYvihJEWCk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.hashCode = hashCode;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Хэш-код</summary>
    public string HashCode => this.hashCode;

    internal static void HZP6alofUFyYvihJEWCk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool trV7PFofYUCsrO8M2QwD() => SourceCodeHashAttribute.qGG4HJofjlGWNRZTHXN5 == null;

    internal static SourceCodeHashAttribute mRScIGofLPRqYCGfX3KT() => SourceCodeHashAttribute.qGG4HJofjlGWNRZTHXN5;
  }
}
