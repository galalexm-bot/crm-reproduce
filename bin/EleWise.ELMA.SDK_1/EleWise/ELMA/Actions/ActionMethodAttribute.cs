// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionMethodAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Actions
{
  /// <summary>Метод, отмеченный эти атрибутом реализует действие</summary>
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
  [Serializable]
  public class ActionMethodAttribute : ActionImplAttribute
  {
    private static ActionMethodAttribute uGQPbGfwgSoecZML9boZ;

    /// <summary>Конструктор</summary>
    /// <param name="actionTypeUid">Идентификатор для типа действия</param>
    public ActionMethodAttribute(string actionTypeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Apply(actionTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Конструктор</summary>
    /// <param name="actionTypeUid">Идентификатор для типа действия</param>
    /// <param name="auditObjectUid">Идентификатор для объекта действия</param>
    public ActionMethodAttribute(string actionTypeUid, string auditObjectUid)
    {
      ActionMethodAttribute.HrGMZ2fwYK5jp9EBVawf();
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
            this.Apply(actionTypeUid, auditObjectUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool qq1SULfw5J85vVHrdlX4() => ActionMethodAttribute.uGQPbGfwgSoecZML9boZ == null;

    internal static ActionMethodAttribute Utsx4ifwjRMJL9AGAULW() => ActionMethodAttribute.uGQPbGfwgSoecZML9boZ;

    internal static void HrGMZ2fwYK5jp9EBVawf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
