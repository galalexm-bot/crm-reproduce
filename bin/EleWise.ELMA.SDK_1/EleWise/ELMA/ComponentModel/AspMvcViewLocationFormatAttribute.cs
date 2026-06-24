// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspMvcViewLocationFormatAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
  public sealed class AspMvcViewLocationFormatAttribute : Attribute
  {
    internal static AspMvcViewLocationFormatAttribute htV2tsfQeQKB8aFX49xY;

    public AspMvcViewLocationFormatAttribute(string format)
    {
      AspMvcViewLocationFormatAttribute.KJLG3AfQNmHPdrIk5myN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Format = format;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public string Format
    {
      get => this.\u003CFormat\u003Ek__BackingField;
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
              this.\u003CFormat\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    internal static void KJLG3AfQNmHPdrIk5myN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UKesgJfQPdE2Bg5tCXdV() => AspMvcViewLocationFormatAttribute.htV2tsfQeQKB8aFX49xY == null;

    internal static AspMvcViewLocationFormatAttribute l2TSDffQ1DmMQNjNDbkA() => AspMvcViewLocationFormatAttribute.htV2tsfQeQKB8aFX49xY;
  }
}
