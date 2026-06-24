// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ImportEntityPreSaveData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.Links;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Вспомогательный класс для передачи информации об импортируемых метаданных между ConfigurationImportExecutor и действиями по импорту сущностей (IEntityImportSaveActions).
  /// Создается и используется на этапе импорта перед сохранением сущностей.
  /// </summary>
  public class ImportEntityPreSaveData
  {
    internal static ImportEntityPreSaveData NKmlpMEm1l9uGAay8iBM;

    /// <summary>Ctor</summary>
    /// <param name="serviceData">Данные словаря ServiceData из config.xml</param>
    /// <param name="systemMessages">Список системных сообщений импорта</param>
    /// <param name="metadataUidInModules">Список Uid'ов типов объектов (сущностей), метаданные которых импортируются с модулем</param>
    /// <param name="mergeReplace">Заменяемые Uid'ов и Name'ов метаданных, свойств и блоков</param>
    /// <param name="linksDictionary">Список ссылок для восстановления сущностей</param>
    public ImportEntityPreSaveData(
      Dictionary<string, string> serviceData,
      List<DeploySystemMessage> systemMessages,
      MergeReplace mergeReplace,
      LinksDictionary linksDictionary)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289413250));
      Contract.ArgumentNotNull((object) systemMessages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281557118));
      Contract.ArgumentNotNull((object) linksDictionary, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124354516));
      this.ServiceData = serviceData;
      this.SystemMessages = systemMessages;
      this.MergeReplace = mergeReplace ?? new MergeReplace();
      this.LinksDictionary = linksDictionary;
    }

    /// <summary>Данные словаря ServiceData из config.xml</summary>
    public Dictionary<string, string> ServiceData { get; private set; }

    /// <summary>Список системных сообщений импорта</summary>
    public List<DeploySystemMessage> SystemMessages { get; private set; }

    /// <summary>
    /// Заменяемые Uid'ов и Name'ов метаданных, свойств и блоков
    /// </summary>
    public MergeReplace MergeReplace
    {
      get => this.\u003CMergeReplace\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMergeReplace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Список ссылок для восстановления сущностей</summary>
    public LinksDictionary LinksDictionary
    {
      get => this.\u003CLinksDictionary\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLinksDictionary\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static bool LOoWVoEmN5MxxEnj8DaQ() => ImportEntityPreSaveData.NKmlpMEm1l9uGAay8iBM == null;

    internal static ImportEntityPreSaveData Gr39dEEm340rUVM8YuIG() => ImportEntityPreSaveData.NKmlpMEm1l9uGAay8iBM;
  }
}
