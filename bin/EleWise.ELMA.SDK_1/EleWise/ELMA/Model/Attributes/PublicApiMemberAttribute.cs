// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PublicApiMemberAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
  public class PublicApiMemberAttribute : Attribute
  {
    internal static PublicApiMemberAttribute Ly5NAnoQyMFeCUjPKZ6x;

    /// <summary>Имя прокси-класса</summary>
    public string ProxyClassName
    {
      get => this.\u003CProxyClassName\u003Ek__BackingField;
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
              this.\u003CProxyClassName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Описание сервиса</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    /// <summary>Строка с примером</summary>
    public string ExampleCode
    {
      get => this.\u003CExampleCode\u003Ek__BackingField;
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
              this.\u003CExampleCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Указание вспомогательного класса или сервиса</summary>
    /// <param name="proxyClassName">Имя класса</param>
    /// <param name="description">Описание класса</param>
    public PublicApiMemberAttribute(string proxyClassName, string description, string exampleCode)
    {
      PublicApiMemberAttribute.fYetq9oQ9OYG92NTxGE3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Description = (string) PublicApiMemberAttribute.l0bg1SoQdJPBB1F4Wc8P((object) description);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 2;
            continue;
          case 2:
            this.ProxyClassName = proxyClassName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
            continue;
          case 3:
            this.ExampleCode = (string) PublicApiMemberAttribute.l0bg1SoQdJPBB1F4Wc8P((object) exampleCode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <summary>Базовый конструктор</summary>
    public PublicApiMemberAttribute()
    {
      PublicApiMemberAttribute.fYetq9oQ9OYG92NTxGE3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool hOkbl9oQMgsRZv5pVim9() => PublicApiMemberAttribute.Ly5NAnoQyMFeCUjPKZ6x == null;

    internal static PublicApiMemberAttribute b42QBZoQJMwfWMMMyWJC() => PublicApiMemberAttribute.Ly5NAnoQyMFeCUjPKZ6x;

    internal static void fYetq9oQ9OYG92NTxGE3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object l0bg1SoQdJPBB1F4Wc8P([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
