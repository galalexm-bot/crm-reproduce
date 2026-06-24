// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PublicApiNodeIgnoreAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
  public class PublicApiNodeIgnoreAttribute : Attribute
  {
    private string[] publicApiIgnoreNodes;
    internal static PublicApiNodeIgnoreAttribute XwA8tuoQU0aGoJD7V50F;

    public PublicApiNodeIgnoreAttribute(params string[] nodeId)
    {
      PublicApiNodeIgnoreAttribute.y88KxWoQz9R3RDZbOuXl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.publicApiIgnoreNodes = nodeId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string[] PublicApiIgnoreNodes
    {
      get => this.publicApiIgnoreNodes;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.publicApiIgnoreNodes = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    internal static void y88KxWoQz9R3RDZbOuXl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NtajtpoQsf91eNMolWLg() => PublicApiNodeIgnoreAttribute.XwA8tuoQU0aGoJD7V50F == null;

    internal static PublicApiNodeIgnoreAttribute rtYcX1oQclQABVkERSIF() => PublicApiNodeIgnoreAttribute.XwA8tuoQU0aGoJD7V50F;
  }
}
