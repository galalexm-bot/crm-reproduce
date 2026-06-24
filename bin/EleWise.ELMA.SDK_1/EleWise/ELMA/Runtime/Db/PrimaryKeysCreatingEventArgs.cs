// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.PrimaryKeysCreatingEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>Параметры события перед созданием первичного ключей</summary>
  public class PrimaryKeysCreatingEventArgs : EventArgs
  {
    private static PrimaryKeysCreatingEventArgs D5CWjEWiEN35hmuSsnqa;

    public bool SkipCreateKeys
    {
      get => this.\u003CSkipCreateKeys\u003Ek__BackingField;
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
              this.\u003CSkipCreateKeys\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    public PrimaryKeysCreatingEventArgs()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lvKjj5WifkQxe2xwf4gp() => PrimaryKeysCreatingEventArgs.D5CWjEWiEN35hmuSsnqa == null;

    internal static PrimaryKeysCreatingEventArgs GjVIKDWiQeyZi0nX7rk4() => PrimaryKeysCreatingEventArgs.D5CWjEWiEN35hmuSsnqa;
  }
}
