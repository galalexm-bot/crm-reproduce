// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.TitlePropertyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут, указывающий свойство, содержащее отображаемое имя
  /// </summary>
  public class TitlePropertyAttribute : Attribute
  {
    private Guid uid;
    private static TitlePropertyAttribute lgVr89ou9PXT5c7MIReR;

    /// <summary>Конструктор</summary>
    /// <param name="uid">Уникальный идентификатор свойства в строковом формате</param>
    public TitlePropertyAttribute(string uid)
    {
      TitlePropertyAttribute.ADdWLUour8Ai0YYXVrCK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор свойства</summary>
    public Guid Uid
    {
      get => this.uid;
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
              this.uid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    internal static void ADdWLUour8Ai0YYXVrCK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Y0oktjoud1vN0ynFwfIh() => TitlePropertyAttribute.lgVr89ou9PXT5c7MIReR == null;

    internal static TitlePropertyAttribute zAdKSqoula3WT5tp0R5k() => TitlePropertyAttribute.lgVr89ou9PXT5c7MIReR;
  }
}
