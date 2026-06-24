// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.ChangeDatePropertyHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>Обработчик свойства "Дата изменения"</summary>
  [Component(Order = 200)]
  public class ChangeDatePropertyHandler : TypedPropertyHandler
  {
    /// <summary>UID данного обработчика</summary>
    public const string UID_S = "{12A6C5C4-12F8-4B2E-B7EA-5438974A2D25}";
    /// <summary>UID данного обработчика</summary>
    public static readonly Guid UID;
    private static ChangeDatePropertyHandler KhJjykWcW0VQ6wh7jZqL;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public override Guid Uid => ChangeDatePropertyHandler.UID;

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    public override string Name => EleWise.ELMA.SR.T((string) ChangeDatePropertyHandler.bNoD5BWchwFVKkDgODUL(-488881205 ^ -488766707));

    /// <summary>Uid типа, для которого предназначен обработчик</summary>
    protected override Guid? TypeUid => new Guid?(DateTimeDescriptor.UID);

    public ChangeDatePropertyHandler()
    {
      ChangeDatePropertyHandler.YRY3xdWcG0cCUaCjBYjB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ChangeDatePropertyHandler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ChangeDatePropertyHandler.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345306644));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object bNoD5BWchwFVKkDgODUL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool PAQqFOWcooeQOei5iFlW() => ChangeDatePropertyHandler.KhJjykWcW0VQ6wh7jZqL == null;

    internal static ChangeDatePropertyHandler pl6G4vWcbN8QIhke2MV6() => ChangeDatePropertyHandler.KhJjykWcW0VQ6wh7jZqL;

    internal static void YRY3xdWcG0cCUaCjBYjB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
