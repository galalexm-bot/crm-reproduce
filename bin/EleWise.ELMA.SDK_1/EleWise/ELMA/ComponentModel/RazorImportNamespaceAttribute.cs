// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.RazorImportNamespaceAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class RazorImportNamespaceAttribute : Attribute
  {
    internal static RazorImportNamespaceAttribute dIemrPfvXsZRVjGPA4H2;

    public RazorImportNamespaceAttribute(string name)
    {
      RazorImportNamespaceAttribute.sK7gg5fvnBPuZHDFiZ3q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Name = name;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    internal static void sK7gg5fvnBPuZHDFiZ3q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HYrxxvfvTT2S4VyFAfDE() => RazorImportNamespaceAttribute.dIemrPfvXsZRVjGPA4H2 == null;

    internal static RazorImportNamespaceAttribute u4oAOmfvkg85nywmYBrh() => RazorImportNamespaceAttribute.dIemrPfvXsZRVjGPA4H2;
  }
}
