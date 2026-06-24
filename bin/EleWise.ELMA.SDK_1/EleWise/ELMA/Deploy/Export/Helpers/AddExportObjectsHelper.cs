// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Helpers.AddExportObjectsHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Helpers
{
  /// <summary>Хелпер формирования пакетов</summary>
  public sealed class AddExportObjectsHelper
  {
    internal static AddExportObjectsHelper Yoq5AwELmKVTUWxFDfio;

    /// <summary>Добавление модулей сценариев</summary>
    /// <param name="packetMetadata">Пакет метаданных</param>
    /// <param name="serviceData">Реестр вспомогательных данных</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="header">Заголовок элемента метаданных</param>
    /// <param name="scriptModuleManager">Менеджер модулей сценариев</param>
    /// <param name="externalAssemblyManager">Менеджер внешних сборок</param>
    public static void AddScriptModules(
      ref PacketMetadata packetMetadata,
      ref Dictionary<string, object> serviceData,
      IGroupedMetadata metadata,
      IMetadataItemHeader header,
      ScriptModuleManager scriptModuleManager,
      ExternalAssemblyManager externalAssemblyManager)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PacketMetadata packetMetadata1 = packetMetadata;
            Dictionary<string, object> serviceData1 = serviceData;
            IGroupedMetadata groupedMetadata1 = metadata;
            ScriptModule scriptModule = ((IMetadataItem) AddExportObjectsHelper.J58oPvELJlG6wIfnTo1Q((object) header)).ScriptModule;
            object obj = AddExportObjectsHelper.wphrXqEL9tP9MCOxpPxk((object) header);
            object currentScriptModule1 = obj != null ? AddExportObjectsHelper.MtV8XAELdGX0hlkkwLFX(obj) : (object) null;
            object scriptModulePropertyName1 = AddExportObjectsHelper.LC98htELlFne3bBrMEOm(44884861 ^ 44832237);
            ScriptModuleManager scriptModuleManager1 = scriptModuleManager;
            ExternalAssemblyManager externalAssemblyManager1 = externalAssemblyManager;
            AddExportObjectsHelper.AddScriptModule(packetMetadata1, serviceData1, (IMetadata) groupedMetadata1, scriptModule, (ScriptModule) currentScriptModule1, (string) scriptModulePropertyName1, scriptModuleManager1, externalAssemblyManager1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PacketMetadata packetMetadata2 = packetMetadata;
            Dictionary<string, object> serviceData2 = serviceData;
            IGroupedMetadata groupedMetadata2 = metadata;
            object publishedScriptModule = AddExportObjectsHelper.Fshk90ELrutuA12pQjep(AddExportObjectsHelper.J58oPvELJlG6wIfnTo1Q((object) header));
            IMetadataItem current = header.Current;
            object currentScriptModule2 = current != null ? AddExportObjectsHelper.Fshk90ELrutuA12pQjep((object) current) : (object) null;
            object scriptModulePropertyName2 = AddExportObjectsHelper.LC98htELlFne3bBrMEOm(-1290212282 ^ -644262414 ^ 1786858594);
            ScriptModuleManager scriptModuleManager2 = scriptModuleManager;
            ExternalAssemblyManager externalAssemblyManager2 = externalAssemblyManager;
            AddExportObjectsHelper.AddScriptModule(packetMetadata2, serviceData2, (IMetadata) groupedMetadata2, (ScriptModule) publishedScriptModule, (ScriptModule) currentScriptModule2, (string) scriptModulePropertyName2, scriptModuleManager2, externalAssemblyManager2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Добавление модуля сценариев</summary>
    /// <param name="packetMetadata">Пакет метаданных</param>
    /// <param name="serviceData">Реестр вспомогательных данных</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="publishedScriptModule">Модуль сценариев опубликованная версия</param>
    /// <param name="currentScriptModule">Модуль сценариев черновик</param>
    /// <param name="scriptModulePropertyName">Имя свойства модуля сценариев</param>
    /// <param name="scriptModuleManager">Менеджер модулей сценариев</param>
    /// <param name="externalAssemblyManager">Менеджер внешних сборок</param>
    internal static void AddScriptModule(
      PacketMetadata packetMetadata,
      Dictionary<string, object> serviceData,
      IMetadata metadata,
      ScriptModule publishedScriptModule,
      ScriptModule currentScriptModule,
      string scriptModulePropertyName,
      ScriptModuleManager scriptModuleManager,
      ExternalAssemblyManager externalAssemblyManager)
    {
      if (publishedScriptModule == null)
        return;
      Guid? nullable = new Guid?();
      if (currentScriptModule != null)
      {
        AddExportObjectsHelper.AddScriptModule((object) packetMetadata, serviceData, (object) metadata, (object) currentScriptModule, (object) scriptModulePropertyName, (object) scriptModuleManager, (object) externalAssemblyManager);
        nullable = new Guid?(currentScriptModule.Uid);
      }
      packetMetadata.SubEntitiesBefore.Add((IEntity) publishedScriptModule, nullable);
    }

    private static void AddScriptModule(
      object packetMetadata,
      Dictionary<string, object> serviceData,
      object metadata,
      object currentScriptModule,
      object scriptModulePropertyName,
      object scriptModuleManager,
      object externalAssemblyManager)
    {
      ((ScriptModuleManager) scriptModuleManager).ConvertOldReferences((ScriptModule) currentScriptModule);
      string key1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289413710) + (object) ((ScriptModule) currentScriptModule).Uid;
      if (!serviceData.ContainsKey(key1))
        serviceData.Add(key1, (object) ((ScriptModule) currentScriptModule).Uid);
      if (((ScriptModule) currentScriptModule).GlobalScriptModules != null)
      {
        foreach (AssemblyReference globalScriptModule in ((ScriptModule) currentScriptModule).GlobalScriptModules)
        {
          string key2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178262998), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606735296), (object) globalScriptModule.Uid);
          if (!serviceData.ContainsKey(key2))
            serviceData.Add(key2, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712151847), (object) globalScriptModule.Uid, (object) globalScriptModule.Name));
        }
      }
      if (((ScriptModule) currentScriptModule).LocalReferences != null)
      {
        List<KeyValuePair<IEntity, Guid?>> list = ((PacketMetadata) packetMetadata).SubEntitiesBefore.ToList<KeyValuePair<IEntity, Guid?>>();
        foreach (AssemblyReference localReference in ((ScriptModule) currentScriptModule).LocalReferences)
        {
          IExternalAssembly key3 = ((AbstractNHEntityManager<IExternalAssembly, long>) externalAssemblyManager).LoadOrNull(localReference.Uid);
          if (key3 != null)
            list.Insert(0, new KeyValuePair<IEntity, Guid?>((IEntity) key3, new Guid?(key3.Uid)));
        }
        ((PacketMetadata) packetMetadata).SubEntitiesBefore = list.ToDictionary<KeyValuePair<IEntity, Guid?>, IEntity, Guid?>((Func<KeyValuePair<IEntity, Guid?>, IEntity>) (x => x.Key), (Func<KeyValuePair<IEntity, Guid?>, Guid?>) (x => x.Value));
      }
      ((PacketMetadata) packetMetadata).SubUserMetadataInfo[((IMetadata) metadata).Uid].ScriptModules.Add((string) scriptModulePropertyName, ((ScriptModule) currentScriptModule).Uid);
    }

    public AddExportObjectsHelper()
    {
      AddExportObjectsHelper.NrAxkAELgRFC7KbT5FMN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object J58oPvELJlG6wIfnTo1Q([In] object obj0) => (object) ((IMetadataItemHeader) obj0).Published;

    internal static object wphrXqEL9tP9MCOxpPxk([In] object obj0) => (object) ((IMetadataItemHeader) obj0).Current;

    internal static object MtV8XAELdGX0hlkkwLFX([In] object obj0) => (object) ((IMetadataItem) obj0).ScriptModule;

    internal static object LC98htELlFne3bBrMEOm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Fshk90ELrutuA12pQjep([In] object obj0) => (object) ((IMetadataItem) obj0).ClientScriptModule;

    internal static bool hedF4BELyPsc5tOurQ1N() => AddExportObjectsHelper.Yoq5AwELmKVTUWxFDfio == null;

    internal static AddExportObjectsHelper IJWpmsELMjn7ydXygsfe() => AddExportObjectsHelper.Yoq5AwELmKVTUWxFDfio;

    internal static void NrAxkAELgRFC7KbT5FMN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
