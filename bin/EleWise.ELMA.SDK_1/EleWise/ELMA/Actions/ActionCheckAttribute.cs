// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionCheckAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Actions
{
  /// <summary>
  /// Метод, отмеченный эти атрибутом реализует проверку доступности действия
  /// </summary>
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  [Serializable]
  public class ActionCheckAttribute : ActionImplAttribute
  {
    private static ActionCheckAttribute wxItXXfwLFGQjcTo82Sq;

    /// <summary>Конструктор</summary>
    /// <param name="actionTypeUid">Идентификатор для типа действия</param>
    public ActionCheckAttribute(string actionTypeUid)
    {
      ActionCheckAttribute.a4EfRWfwcYA7dfKYtOSq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Apply(actionTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Конструктор</summary>
    /// <param name="actionTypeUid">Идентификатор для типа действия</param>
    /// <param name="auditObjectUid">Идентификатор для объекта действия</param>
    public ActionCheckAttribute(string actionTypeUid, string auditObjectUid)
    {
      ActionCheckAttribute.a4EfRWfwcYA7dfKYtOSq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Apply(actionTypeUid, auditObjectUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void a4EfRWfwcYA7dfKYtOSq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kDSMrkfwU5f6yV7iqeqN() => ActionCheckAttribute.wxItXXfwLFGQjcTo82Sq == null;

    internal static ActionCheckAttribute CZvBd3fwsGBXL4UG8d4F() => ActionCheckAttribute.wxItXXfwLFGQjcTo82Sq;
  }
}
