// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.SimpleTypeDescriptor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Абстрактный класс тип данных, принадлежащего группе простых типов
  /// </summary>
  /// <typeparam name="T">Тип CLR</typeparam>
  /// <typeparam name="SettingsT">Тип настроек</typeparam>
  public abstract class SimpleTypeDescriptor<T, SettingsT> : SimpleTypeDescriptor<T>
  {
    private static object FUu5maol828stG7sZCuR;

    /// <summary>Тип настроек</summary>
    public override Type SettingsType => typeof (SettingsT);

    protected SimpleTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pH8dpvolZEABPhsexnHA() => SimpleTypeDescriptor<T, SettingsT>.FUu5maol828stG7sZCuR == null;

    internal static object mrTdHioluaWBCryuGifJ() => SimpleTypeDescriptor<T, SettingsT>.FUu5maol828stG7sZCuR;
  }
}
