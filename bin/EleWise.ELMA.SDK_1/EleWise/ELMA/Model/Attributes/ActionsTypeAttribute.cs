// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ActionsTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает тип перечисления, содержащий действия с сущностью
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class ActionsTypeAttribute : Attribute
  {
    private Type actionsType;
    internal static ActionsTypeAttribute cIyIk8ovZfRQapQDO8iX;

    /// <summary>Ctor</summary>
    /// <param name="actionsType">Тип перечисления, содержащий действия с сущностью</param>
    public ActionsTypeAttribute(Type actionsType)
    {
      ActionsTypeAttribute.HjKtmjovV8ng2s43bxM3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.actionsType = actionsType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип перечисления, содержащий действия с сущностью</summary>
    public Type ActionsType => this.actionsType;

    internal static void HjKtmjovV8ng2s43bxM3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ohkTG0ovugCLe5ake9ZQ() => ActionsTypeAttribute.cIyIk8ovZfRQapQDO8iX == null;

    internal static ActionsTypeAttribute fKGPLXovIBy8sPEni0Et() => ActionsTypeAttribute.cIyIk8ovZfRQapQDO8iX;
  }
}
