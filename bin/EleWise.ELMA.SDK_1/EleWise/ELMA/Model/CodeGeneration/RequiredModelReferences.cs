// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.RequiredModelReferences
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>
  /// Описывает ссылки на сборки, требуемые для проекта с моделями
  /// </summary>
  public static class RequiredModelReferences
  {
    private static RequiredModelReferences.ReferenceInfo[] references;
    private static RequiredModelReferences lRD1BshaLvHy9MQYOCxN;

    /// <summary>Список требуемых сборок</summary>
    public static IEnumerable<RequiredModelReferences.ReferenceInfo> References => (IEnumerable<RequiredModelReferences.ReferenceInfo>) RequiredModelReferences.references;

    static RequiredModelReferences()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            RequiredModelReferences.eiZXPQhachPGxfFrWjCY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RequiredModelReferences.references = new RequiredModelReferences.ReferenceInfo[7]
            {
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(--1418440330 ^ 1418371284)),
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(-1146510045 ^ -1146561891)),
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(-1710575414 ^ -1710502126)),
              new RequiredModelReferences.ReferenceInfo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304637803)),
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(-441065788 ^ -2092910478 ^ 1727363242), false),
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(~538519529 ^ -538592024), false),
              new RequiredModelReferences.ReferenceInfo((string) RequiredModelReferences.iC7J3whaz577iFShWjiQ(-606654180 ^ -606712186), false)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void eiZXPQhachPGxfFrWjCY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object iC7J3whaz577iFShWjiQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool eIwmmmhaUeipeGZHPh61() => RequiredModelReferences.lRD1BshaLvHy9MQYOCxN == null;

    internal static RequiredModelReferences YxNCMbhaseIPGMj85ZV9() => RequiredModelReferences.lRD1BshaLvHy9MQYOCxN;

    /// <summary>Информация о ссылаемой сборке</summary>
    public class ReferenceInfo
    {
      private string name;
      private bool isSystem;
      private static RequiredModelReferences.ReferenceInfo SMWQmmvRAuH7B34OG3cf;

      /// <summary>Имя сборки</summary>
      public string Name => this.name;

      /// <summary>
      /// Является ли сборка системной (входил ли в .NET Framework 4.0)
      /// </summary>
      public bool IsSystem => this.isSystem;

      internal ReferenceInfo(string name, bool isSystem = true)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.isSystem = isSystem;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
              continue;
            default:
              this.name = name;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      internal static bool uLuO5EvR77OOKigZnpw6() => RequiredModelReferences.ReferenceInfo.SMWQmmvRAuH7B34OG3cf == null;

      internal static RequiredModelReferences.ReferenceInfo HG99hZvRxljNu9cr9dHW() => RequiredModelReferences.ReferenceInfo.SMWQmmvRAuH7B34OG3cf;
    }
  }
}
