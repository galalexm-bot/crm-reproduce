// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Components.ObjectsPublishedExportCheckingRule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Export.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Components
{
  /// <summary>
  /// Правило проверки на наличие опубликованной версии для справочников
  /// </summary>
  [Component]
  public class ObjectsPublishedExportCheckingRule : IExportCheckingRule
  {
    /// <summary>Менеджер заголовков метаданных</summary>
    private MetadataItemHeaderManager metadataItemHeaderManager;
    internal static ObjectsPublishedExportCheckingRule TFtZmuEsEYyyRauJukNK;

    /// <summary>Ctor</summary>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    public ObjectsPublishedExportCheckingRule(
      MetadataItemHeaderManager metadataItemHeaderManager)
    {
      ObjectsPublishedExportCheckingRule.Af8cDbEsC9P9A1yCns4t();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataItemHeaderManager = metadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public virtual IExportCheckingResult Check(IExportCheckingContext context)
    {
      int num = 1;
      object obj;
      BaseExportCheckingResult result;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) context, (string) ObjectsPublishedExportCheckingRule.GrcF5yEsv4NSsnalqLuD(-1638402543 ^ -1638419961));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
          case 8:
            goto label_7;
          case 4:
            if (!((ConfigExportSettings) ObjectsPublishedExportCheckingRule.K67Y8tEs8LXR28FYZAEQ((object) context)).CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out obj))
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            if (obj is ObjectsExportSetting objectsExportSetting)
            {
              num = 6;
              continue;
            }
            goto label_7;
          case 6:
            if (objectsExportSetting.Catalogs == null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 7:
            SerializableDictionary<Guid, bool> catalogs = objectsExportSetting.Catalogs;
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<Guid, bool>, Guid> func = ObjectsPublishedExportCheckingRule.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<KeyValuePair<Guid, bool>, Guid> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              ObjectsPublishedExportCheckingRule.\u003C\u003Ec.\u003C\u003E9__2_0 = selector = (Func<KeyValuePair<Guid, bool>, Guid>) (catalog => catalog.Key);
            }
            else
              goto label_14;
label_13:
            this.Check(catalogs.Select<KeyValuePair<Guid, bool>, Guid>(selector), result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
label_14:
            selector = func;
            goto label_13;
          default:
            result = new BaseExportCheckingResult();
            num = 4;
            continue;
        }
      }
label_7:
      return (IExportCheckingResult) result;
    }

    /// <summary>Шаблон текста ошибки</summary>
    /// <param name="displayName">Имя метаданных</param>
    protected virtual string PublishedMissed(string displayName) => EleWise.ELMA.SR.T((string) ObjectsPublishedExportCheckingRule.GrcF5yEsv4NSsnalqLuD(1251470110 >> 2 ^ 312537743), (object) displayName);

    /// <summary>Проверка на наличие опубликованной версии</summary>
    /// <param name="uids">Список идентификаторов метаданных</param>
    /// <param name="result">Результат проверки</param>
    protected void Check(IEnumerable<Guid> uids, BaseExportCheckingResult result) => uids.ForEach<Guid>((Action<Guid>) (uid =>
    {
      int num = 6;
      IMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            ObjectsPublishedExportCheckingRule.\u003C\u003Ec__DisplayClass4_0.v1Zbra8mkRIs0cJHU9dD((object) result, ExportCheckingMessageType.Error, ObjectsPublishedExportCheckingRule.\u003C\u003Ec__DisplayClass4_0.zpeNIY8mTHhQppeBIUYr((object) this, ObjectsPublishedExportCheckingRule.\u003C\u003Ec__DisplayClass4_0.GS85I58mXFICv57O5Nsc((object) metadataItemHeader)), uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
            continue;
          case 5:
            if (metadataItemHeader == null)
            {
              num = 3;
              continue;
            }
            goto default;
          case 6:
            metadataItemHeader = this.metadataItemHeaderManager.LoadOrNull(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 5;
            continue;
          default:
            if (metadataItemHeader.Published != null)
            {
              num = 2;
              continue;
            }
            goto case 4;
        }
      }
label_9:
      return;
label_4:
      return;
label_2:;
    }));

    internal static void Af8cDbEsC9P9A1yCns4t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eJswADEsf4NSWSo0YQ9B() => ObjectsPublishedExportCheckingRule.TFtZmuEsEYyyRauJukNK == null;

    internal static ObjectsPublishedExportCheckingRule v4X43qEsQIyY4XwCye1a() => ObjectsPublishedExportCheckingRule.TFtZmuEsEYyyRauJukNK;

    internal static object GrcF5yEsv4NSsnalqLuD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object K67Y8tEs8LXR28FYZAEQ([In] object obj0) => (object) ((IExportCheckingContext) obj0).Settings;
  }
}
