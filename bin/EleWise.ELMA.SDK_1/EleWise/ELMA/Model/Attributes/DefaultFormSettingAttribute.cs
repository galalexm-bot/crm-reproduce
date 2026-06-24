// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DefaultFormSettingAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Настройки форм по умолчанию</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class DefaultFormSettingAttribute : Attribute
  {
    private Guid uid;
    private string value;
    internal static DefaultFormSettingAttribute K31MR3oQNri6ZNa7MCLL;

    public DefaultFormSettingAttribute(string uid, string value)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.uid = new Guid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          default:
            this.value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    public Guid Uid => this.uid;

    public string Value => this.value;

    internal static bool QdOhKpoQ3WQ6w3hCZlfI() => DefaultFormSettingAttribute.K31MR3oQNri6ZNa7MCLL == null;

    internal static DefaultFormSettingAttribute NqXy9RoQpIjTA5iJ4M5w() => DefaultFormSettingAttribute.K31MR3oQNri6ZNa7MCLL;
  }
}
