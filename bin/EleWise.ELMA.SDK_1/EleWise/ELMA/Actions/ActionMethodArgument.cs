// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionMethodArgument
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Actions
{
  /// <summary>Описание данных для аргумента действия</summary>
  [Serializable]
  public class ActionMethodArgument
  {
    private readonly string _name;
    private readonly Type _argumentType;
    private static ActionMethodArgument rLWXD9fwKboQFwTdVcmM;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public ActionMethodArgument(string name, Type argumentType)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._argumentType = argumentType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
            continue;
          default:
            this._name = name;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Название аргумента</summary>
    public string Name => this._name;

    /// <summary>Тип аргумента</summary>
    public Type ArgumentType => this._argumentType;

    internal static bool VwnDw7fwXEh2NEUq58e0() => ActionMethodArgument.rLWXD9fwKboQFwTdVcmM == null;

    internal static ActionMethodArgument ic9e1ZfwTVR2EI7hYvUp() => ActionMethodArgument.rLWXD9fwKboQFwTdVcmM;
  }
}
