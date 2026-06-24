// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.PathReferenceAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that a parameter is a path to a file or a folder within a web project.
  /// Path can be relative or absolute, starting from web root (~).
  /// </summary>
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class PathReferenceAttribute : Attribute
  {
    internal static PathReferenceAttribute I21uKpffchjGiSRcJwEs;

    public PathReferenceAttribute()
    {
      PathReferenceAttribute.CTqGOhfQB1dyGUcRl9kk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PathReferenceAttribute([PathReference] string basePath)
    {
      PathReferenceAttribute.CTqGOhfQB1dyGUcRl9kk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.BasePath = basePath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string BasePath
    {
      get => this.\u003CBasePath\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CBasePath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void CTqGOhfQB1dyGUcRl9kk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JWOlRsffzwLCgswWvQt6() => PathReferenceAttribute.I21uKpffchjGiSRcJwEs == null;

    internal static PathReferenceAttribute B5O9ECfQFgs3lBs0YXiv() => PathReferenceAttribute.I21uKpffchjGiSRcJwEs;
  }
}
