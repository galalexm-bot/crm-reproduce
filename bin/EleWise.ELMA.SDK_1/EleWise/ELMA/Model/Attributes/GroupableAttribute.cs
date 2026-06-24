// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.GroupableAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает доступность группировки</summary>
  public class GroupableAttribute : Attribute
  {
    private bool groupable;
    private static GroupableAttribute KyZcguo8VYuqVbsmsD46;

    /// <summary>Ctor</summary>
    /// <param name="groupable">Доступность группировки</param>
    public GroupableAttribute(bool groupable)
    {
      GroupableAttribute.lcyYJ5o8RYHTfLpXL7uY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.groupable = groupable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Доступность группировки</summary>
    public bool Groupable => this.groupable;

    internal static void lcyYJ5o8RYHTfLpXL7uY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ieSB0Fo8SsqwPvD0IdmI() => GroupableAttribute.KyZcguo8VYuqVbsmsD46 == null;

    internal static GroupableAttribute FYJiv4o8inAlw2PWleAL() => GroupableAttribute.KyZcguo8VYuqVbsmsD46;
  }
}
