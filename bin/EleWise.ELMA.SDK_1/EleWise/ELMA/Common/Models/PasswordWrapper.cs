// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.PasswordWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common.Models
{
  /// <summary>Обертка для работы с хешем пароля</summary>
  public class PasswordWrapper
  {
    private PasswordInfo info;
    private static PasswordWrapper vQPqaSfSn55Q6je3p0D4;

    /// <summary>Ctor</summary>
    /// <param name="info">Контейнер хэша</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    internal PasswordWrapper(PasswordInfo info, PropertyMetadata propertyMetadata)
    {
      PasswordWrapper.xpt07gfSeihco9diZIRh();
      // ISSUE: explicit constructor call
      this.\u002Ector(info, PasswordWrapper.dxns67fSPaTEkwaBqVM8((object) propertyMetadata) as PasswordSettings);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="info">Контейнер хэша</param>
    /// <param name="settings">Настройки свойства</param>
    internal PasswordWrapper(PasswordInfo info, PasswordSettings settings)
    {
      PasswordWrapper.xpt07gfSeihco9diZIRh();
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
            this.info = info;
            num = 3;
            continue;
          case 3:
            if (settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            info.InitPasswordResolver(new Guid?(PasswordWrapper.r9Dq9efS10dOf6IWC9DE((object) settings)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Проверка на валидность пароля</summary>
    /// <param name="password">Пароль</param>
    /// <returns></returns>
    public bool Check(string password) => PasswordWrapper.DfULDefSNydr1QvvDX42((object) this.info, (object) password);

    /// <summary>
    /// Получить пароль (зависит от реализации)
    /// Если это хэш, то возвращается сам хэш
    /// </summary>
    /// <returns></returns>
    public string GetPassword() => this.info.GetPassword();

    internal static void xpt07gfSeihco9diZIRh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object dxns67fSPaTEkwaBqVM8([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool YvcJeJfSORgWy0GGuQTF() => PasswordWrapper.vQPqaSfSn55Q6je3p0D4 == null;

    internal static PasswordWrapper Jbc5dffS21nRc8Q2xWVw() => PasswordWrapper.vQPqaSfSn55Q6je3p0D4;

    internal static Guid r9Dq9efS10dOf6IWC9DE([In] object obj0) => ((PasswordSettings) obj0).PasswordType;

    internal static bool DfULDefSNydr1QvvDX42([In] object obj0, [In] object obj1) => ((PasswordInfo) obj0).Check((string) obj1);
  }
}
