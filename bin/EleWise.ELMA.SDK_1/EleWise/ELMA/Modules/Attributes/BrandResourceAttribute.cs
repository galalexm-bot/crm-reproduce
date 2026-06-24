// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Modules.Attributes.BrandResourceAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Modules.Attributes
{
  /// <summary>
  /// Указывает ресурс (изображение) который относится к бренду
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public class BrandResourceAttribute : Attribute
  {
    private string resourceFullName;
    private string _resourceName;
    private static BrandResourceAttribute yYIRMnp5EGVwWCtGeh1;

    public BrandResourceAttribute(string resourceFullName, string resourceName)
    {
      BrandResourceAttribute.UtSmQ3pLjWPs3ZVlnSE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.resourceFullName = resourceFullName;
            num = 2;
            continue;
          case 2:
            this._resourceName = resourceName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Полное имя ресурса ресурса</summary>
    public string ResourceFullName => this.resourceFullName;

    /// <summary>Название ресурса</summary>
    public string ResourceName => this._resourceName;

    internal static void UtSmQ3pLjWPs3ZVlnSE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SqY8TapjQCZFITgNW87() => BrandResourceAttribute.yYIRMnp5EGVwWCtGeh1 == null;

    internal static BrandResourceAttribute si1vJJpYEaZu9OWZ1SV() => BrandResourceAttribute.yYIRMnp5EGVwWCtGeh1;
  }
}
