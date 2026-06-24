// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.EntitySystemComponentConstants
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Components
{
  /// <summary>Константы системных компонентов сущностей</summary>
  public static class EntitySystemComponentConstants
  {
    /// <summary>Уникальный идентификатор компонента редактирования</summary>
    public const string EditUidStr = "{BF0C0B9A-1398-4232-85BC-A90BB0C1462E}";
    /// <summary>Уникальный идентификатор компонента редактирования</summary>
    public static Guid EditUid;
    /// <summary>Уникальный идентификатор компонента создания</summary>
    public const string CreateUidStr = "{4FC67649-1DDE-4BF7-964A-FAA2FE8D0F5F}";
    /// <summary>Уникальный идентификатор компонента создания</summary>
    public static Guid CreateUid;
    /// <summary>Уникальный идентификатор компонента просмотра</summary>
    public const string DisplayUidStr = "{91EC9919-1998-4D38-BF77-A906BD4C1F3F}";
    /// <summary>Уникальный идентификатор компонента просмотра</summary>
    public static Guid DisplayUid;
    /// <summary>
    /// Уникальный идентификатор компонента произвольной формы
    /// </summary>
    public const string CustomUidStr = "{378A94DF-CB1A-4416-89B9-B2C21A7E2726}";
    /// <summary>
    /// Уникальный идентификатор компонента произвольной формы
    /// </summary>
    public static Guid CustomUid;
    internal static EntitySystemComponentConstants sWQu2Ffhk2xJkIm46rTd;

    static EntitySystemComponentConstants()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntitySystemComponentConstants.EditUid = new Guid((string) EntitySystemComponentConstants.Tv7aGkfhe09jU0dut91m(-1998538950 ^ -1998219980));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 2;
            continue;
          case 2:
            EntitySystemComponentConstants.aTOaFLfh2tvJr84c63Ns();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
            continue;
          case 3:
            EntitySystemComponentConstants.CreateUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293499578));
            num = 4;
            continue;
          case 4:
            EntitySystemComponentConstants.DisplayUid = new Guid((string) EntitySystemComponentConstants.Tv7aGkfhe09jU0dut91m(1994213607 >> 4 ^ 124319264));
            num = 5;
            continue;
          case 5:
            EntitySystemComponentConstants.CustomUid = new Guid((string) EntitySystemComponentConstants.Tv7aGkfhe09jU0dut91m(-1217523399 ^ -1217711161));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    internal static void aTOaFLfh2tvJr84c63Ns() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Tv7aGkfhe09jU0dut91m(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool cu1j9EfhnykplvryPXU0() => EntitySystemComponentConstants.sWQu2Ffhk2xJkIm46rTd == null;

    internal static EntitySystemComponentConstants WSP3aQfhOKwHMWLnACex() => EntitySystemComponentConstants.sWQu2Ffhk2xJkIm46rTd;
  }
}
