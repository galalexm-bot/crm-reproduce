// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Import.FormItemImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Deploy.Import
{
  /// <summary>Действия для импорта элемента формы</summary>
  public class FormItemImportSaveActions : EntityImportSaveActions
  {
    public static readonly Guid UID;
    private static FormItemImportSaveActions HV0ynhlRS2TiJm84Zc5;

    public override bool IsSupported(Guid typeGuid) => typeGuid == FormItemImportSaveActions.UID;

    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      IFormMetadataItem formMetadataItem = entity as IFormMetadataItem;
      // ISSUE: reference to a compiler-generated method
      Func<string, TestImportMessages> func = (Func<string, TestImportMessages>) (e => new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FormItemImportSaveActions.\u003C\u003Ec.YTT0qcfjW3qPtj2aPOaQ(589593376 ^ -1977315327 ^ -1459338357), (object) e)));
      if (formMetadataItem == null)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643816689));
        return new List<TestImportMessages>()
        {
          func(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87824337)))
        };
      }
      if (formMetadataItem.Header == null)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87298083));
        return new List<TestImportMessages>()
        {
          func(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606630616)))
        };
      }
      if (!(formMetadataItem.Metadata is FormMetadata metadata))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998582956));
        return new List<TestImportMessages>()
        {
          func(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218928222)))
        };
      }
      metadata.Name = formMetadataItem.Header.Name;
      metadata.DisplayName = formMetadataItem.Header.DisplayName;
      return new List<TestImportMessages>();
    }

    public FormItemImportSaveActions()
    {
      FormItemImportSaveActions.tsbv7flXvww9WZPaAYD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FormItemImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormItemImportSaveActions.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867780324));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool Vfmmg4lq1p9gPuYiYYU() => FormItemImportSaveActions.HV0ynhlRS2TiJm84Zc5 == null;

    internal static FormItemImportSaveActions ltgC1wlKpXAghJh2YEO() => FormItemImportSaveActions.HV0ynhlRS2TiJm84Zc5;

    internal static void tsbv7flXvww9WZPaAYD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
