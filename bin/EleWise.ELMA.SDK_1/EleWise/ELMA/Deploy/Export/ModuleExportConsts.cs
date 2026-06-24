// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ModuleExportConsts
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Константы для экспорта/импорта модулей</summary>
  public static class ModuleExportConsts
  {
    /// <summary>ContenType для пакета, содержащего модуль</summary>
    public const string ModulePacketContentType = "ModulePacket";
    /// <summary>Уникальный идентификатор важных данных импорта модуля</summary>
    public static Guid ModulePacketImportantDataUid;
    /// <summary>
    /// Уникальный илентификатор ключа данных серверного скрипт-модуля компонента
    /// </summary>
    public const string ModuleComponentScriptModuleKey = "ModuleComponentScriptModule";
    /// <summary>
    /// Уникальный илентификатор ключа данных клинетского скрипт-модуля компонента
    /// </summary>
    public const string ModuleComponentClientScriptModuleKey = "ModuleComponentClientScriptModule";
    /// <summary>
    /// Уникальный илентификатор ключа данных тестового скрипт-модуля компонента
    /// </summary>
    public const string ModuleComponentTestScriptModuleKey = "ModuleComponentTestScriptModule";
    /// <summary>
    /// Уникальный илентификатор ключа данных View скрипт-модуля компонента
    /// </summary>
    public const string ModuleComponentViewScriptModuleKey = "ModuleComponentViewScriptModule";
    /// <summary>
    /// Уникальный илентификатор ключа данных скрипт-модуля функции
    /// </summary>
    public const string ModuleFunctionScriptModuleKey = "ModuleFunctionScriptModule";
    /// <summary>
    /// Уникальный илентификатор ключа данных имени сборки модуля
    /// </summary>
    public const string ModuleAssemblyNameKey = "ModuleAssemblyName";
    /// <summary>
    /// Уникальный илентификатор ключа данных серверной сборки модуля
    /// </summary>
    public const string ModuleAssemblyRawKey = "ModuleAssemblyRaw";
    /// <summary>
    /// Уникальный илентификатор ключа данных серверной сборки для отладки
    /// </summary>
    public const string ModuleDebugRawKey = "ModuleDebugRaw";
    /// <summary>
    /// Уникальный илентификатор ключа данных клиентской сборки (dll)
    /// </summary>
    public const string ModuleClientRawKey = "ModuleClientRaw";
    /// <summary>
    /// Уникальный илентификатор ключа данных клиентской сборки (min.js)
    /// </summary>
    public const string ModuleClientAssemblyRawKey = "ModuleClientAssemblyRaw";
    /// <summary>
    /// Уникальный илентификатор ключа данных клиентской сборки (js)
    /// </summary>
    public const string ModuleClientDebugRawKey = "ModuleClientDebugRaw";
    /// <summary>Уникальный илентификатор ключа данных версии модуля</summary>
    public const string ModuleVersionKey = "ModuleVersion";
    internal static ModuleExportConsts U20nn7E5zhLmOhKontiK;

    static ModuleExportConsts()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ModuleExportConsts.ModulePacketImportantDataUid = new Guid((string) ModuleExportConsts.gd9HEJEjoF9TVSJFFE0J(2008901894 << 3 ^ -1108363600));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
            continue;
          case 2:
            ModuleExportConsts.FJ53hXEjWQD3cxAIl72B();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void FJ53hXEjWQD3cxAIl72B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object gd9HEJEjoF9TVSJFFE0J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool uvtpqgEjFBOZAnoHS9xY() => ModuleExportConsts.U20nn7E5zhLmOhKontiK == null;

    internal static ModuleExportConsts Mda6WjEjBIIbpNg0m5Un() => ModuleExportConsts.U20nn7E5zhLmOhKontiK;
  }
}
