// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ModuleMetadataExtractorService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Packaging.Helper;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис извлечения данных о модулях из nuget пакетов</summary>
  [Service]
  internal sealed class ModuleMetadataExtractorService : IModuleMetadataExtractorService
  {
    /// <summary>Время выполнения повторных попыток</summary>
    private static readonly TimeSpan RetryTime;
    private readonly IExportImportFileManager exportImportFileManager;
    internal static ModuleMetadataExtractorService A9AurwE4Ay7EfKD7XUDW;

    /// <summary>Ctor</summary>
    /// <param name="exportImportFileManager">Интерфейс менеджера для работы с ExportImportFileService</param>
    public ModuleMetadataExtractorService(IExportImportFileManager exportImportFileManager)
    {
      ModuleMetadataExtractorService.ItRBSxE400eTBDP5LgPH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.exportImportFileManager = exportImportFileManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public IEnumerable<ModuleVersion> ExtractModules(IConfigImportSettings importSettings) => this.ExtractModules(this.exportImportFileManager.CreateZipFileName(importSettings.FileName));

    /// <inheritdoc />
    public IEnumerable<ModuleVersion> ExtractModules(string filePath)
    {
      List<ModuleVersion> modules = new List<ModuleVersion>();
      ComponentManager current = ComponentManager.Current;
      IEnumerable<string> activationKeys = (IEnumerable<string>) null;
      Func<DateTime?> getMainUnitExpiration = (Func<DateTime?>) null;
      if (current != null)
      {
        activationKeys = (IEnumerable<string>) current.LicenseManager.GetActivationKeys().Select<KeyValuePair<Guid, string>, string>((Func<KeyValuePair<Guid, string>, string>) (a => a.Value)).ToList<string>();
        getMainUnitExpiration = new Func<DateTime?>(current.ModuleManager.GetMainLicensedUnitExpiration);
      }
      List<string> packages;
      ElmaStoreComponentsBuilder.Read(filePath, activationKeys, getMainUnitExpiration, true, "", false, out packages, out Image _);
      foreach (string filePath1 in packages)
      {
        string tempUniqueFolder = ExportImportTempFolderHelper.GetTempUniqueFolder("");
        FSHelper.CreateDirectory(tempUniqueFolder, ModuleMetadataExtractorService.RetryTime);
        try
        {
          ZipPackage package = new ZipPackage(filePath1);
          foreach (IPackageFile libFile in package.GetLibFiles())
          {
            if (Path.GetFileNameWithoutExtension(libFile.Path).ToUpperInvariant() == package.Id.ToUpperInvariant() && Path.GetExtension(libFile.Path) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867745546))
            {
              string str = Path.Combine(tempUniqueFolder, Guid.NewGuid().ToString());
              using (Stream stream = libFile.GetStream())
              {
                using (FileStream destination = File.Create(str))
                  stream.CopyTo((Stream) destination);
              }
              ModuleInfoMetadata from = this.ExtractFrom(str);
              if (from != null)
              {
                Guid versionUid = ModuleVersionHeader.DefaultVersionUid(from.Uid, package.Version.Version);
                ModuleVersion moduleVersion = new ModuleVersion(from, new ModuleVersionHeader(from.GetSignature(), versionUid, from.Uid, package.Version.Version, ModuleStatus.Enabled));
                modules.Add(moduleVersion);
              }
            }
          }
        }
        finally
        {
          FSHelper.DeleteDirectory(tempUniqueFolder, true, ModuleMetadataExtractorService.RetryTime);
        }
      }
      return (IEnumerable<ModuleVersion>) modules;
    }

    /// <summary>Извлечь метаданные модуля</summary>
    private ModuleInfoMetadata ExtractFrom(string filePath)
    {
      int num1 = 2;
      AppDomain appDomain;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            appDomain = (AppDomain) ModuleMetadataExtractorService.NpqoJeE4dgqaV9u5c2Hn(ModuleMetadataExtractorService.zL8ApTE4yNKOpw5r1e0W((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669602313), (object) ModuleMetadataExtractorService.gVBn6aE4mKdWnc9XkF9h()), ModuleMetadataExtractorService.JrVn86E4JoV66DrWYYIk(ModuleMetadataExtractorService.zAAkHrE4MbeQfWsHPUKY()), ModuleMetadataExtractorService.UBFQ2RE49hAHby0jZSkR((object) AppDomain.CurrentDomain));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ModuleInfoMetadata from;
      return from;
label_4:
      try
      {
        // ISSUE: type reference
        from = (ModuleInfoMetadata) ModuleMetadataExtractorService.wMU3d6E45xj0tceMxSCc((object) (ModuleMetadataExtractorService.MetadataExtractorProxy) ModuleMetadataExtractorService.i6yH4EE4g47AvXlZZ1ir((object) appDomain, ModuleMetadataExtractorService.uAFkjFE4rXX9ZFthA91p((object) ModuleMetadataExtractorService.H19FiPE4lIXmQKjF7exe(__typeref (ModuleMetadataExtractorService.MetadataExtractorProxy)).Assembly), (object) typeof (ModuleMetadataExtractorService.MetadataExtractorProxy).FullName), (object) filePath);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        ModuleMetadataExtractorService.mlpjmoE4jCPdPwJYmhEY((object) appDomain);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    static ModuleMetadataExtractorService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleMetadataExtractorService.ItRBSxE400eTBDP5LgPH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleMetadataExtractorService.RetryTime = ModuleMetadataExtractorService.C1MmYVE4YJ6Ufm1COm7Y(1.0);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void ItRBSxE400eTBDP5LgPH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool T5EoyAE47FRoUFSFmOKo() => ModuleMetadataExtractorService.A9AurwE4Ay7EfKD7XUDW == null;

    internal static ModuleMetadataExtractorService HKXBy3E4xfxWQB0R0Qhl() => ModuleMetadataExtractorService.A9AurwE4Ay7EfKD7XUDW;

    internal static Guid gVBn6aE4mKdWnc9XkF9h() => Guid.NewGuid();

    internal static object zL8ApTE4yNKOpw5r1e0W([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object zAAkHrE4MbeQfWsHPUKY() => (object) AppDomain.CurrentDomain;

    internal static object JrVn86E4JoV66DrWYYIk([In] object obj0) => (object) ((AppDomain) obj0).Evidence;

    internal static object UBFQ2RE49hAHby0jZSkR([In] object obj0) => (object) ((AppDomain) obj0).SetupInformation;

    internal static object NpqoJeE4dgqaV9u5c2Hn([In] object obj0, [In] object obj1, [In] object obj2) => (object) AppDomain.CreateDomain((string) obj0, (Evidence) obj1, (AppDomainSetup) obj2);

    internal static Type H19FiPE4lIXmQKjF7exe([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object uAFkjFE4rXX9ZFthA91p([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object i6yH4EE4g47AvXlZZ1ir([In] object obj0, [In] object obj1, [In] object obj2) => ((AppDomain) obj0).CreateInstanceAndUnwrap((string) obj1, (string) obj2);

    internal static object wMU3d6E45xj0tceMxSCc([In] object obj0, [In] object obj1) => (object) ((ModuleMetadataExtractorService.MetadataExtractorProxy) obj0).ExtractFrom((string) obj1);

    internal static void mlpjmoE4jCPdPwJYmhEY([In] object obj0) => AppDomain.Unload((AppDomain) obj0);

    internal static TimeSpan C1MmYVE4YJ6Ufm1COm7Y([In] double obj0) => TimeSpan.FromMinutes(obj0);

    /// <summary>
    /// Класс для извлечения метаданных модулей внутри отдельного домена
    /// </summary>
    private class MetadataExtractorProxy : MarshalByRefObject
    {
      private static object hnKXsV8exmwHWO2OsRRQ;

      public ModuleInfoMetadata ExtractFrom(string filePath)
      {
        int num1 = 1;
        ModuleInfoMetadata moduleInfoMetadata;
        Assembly assembly;
        while (true)
        {
          switch (num1)
          {
            case 1:
              moduleInfoMetadata = new ModuleInfoMetadata();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_3;
            case 4:
              ModuleMetadataExtractorService.MetadataExtractorProxy.PbsCRd8eM2tS5DBfEvR1((object) new SimpleBoundVariableService());
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
              continue;
            default:
              assembly = (Assembly) ModuleMetadataExtractorService.MetadataExtractorProxy.EFTV378eyxaiWxuG0e5U((object) filePath);
              num1 = 4;
              continue;
          }
        }
label_3:
        ModuleInfoMetadata from;
        return from;
label_6:
        try
        {
          ModuleMetadataExtractorService.MetadataExtractorProxy.BymPVS8eJiXeKKb2i34B((object) moduleInfoMetadata, (object) assembly);
          int num2 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
            num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                from = moduleInfoMetadata;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
        }
        catch (InvalidOperationException ex)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                from = (ModuleInfoMetadata) null;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
        }
      }

      public MetadataExtractorProxy()
      {
        ModuleMetadataExtractorService.MetadataExtractorProxy.hsrv6p8e9oB1gRxbukxJ();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object EFTV378eyxaiWxuG0e5U([In] object obj0) => (object) Assembly.LoadFrom((string) obj0);

      internal static void PbsCRd8eM2tS5DBfEvR1([In] object obj0) => ContextVars.SetImpl((IContextBoundVariableService) obj0);

      internal static void BymPVS8eJiXeKKb2i34B([In] object obj0, [In] object obj1) => ((ModuleInfoMetadata) obj0).LoadFromAssembly((Assembly) obj1);

      internal static bool maUclA8e0qXFcScIVdli() => ModuleMetadataExtractorService.MetadataExtractorProxy.hnKXsV8exmwHWO2OsRRQ == null;

      internal static ModuleMetadataExtractorService.MetadataExtractorProxy Q90Dnb8emsEEUMnQ2G04() => (ModuleMetadataExtractorService.MetadataExtractorProxy) ModuleMetadataExtractorService.MetadataExtractorProxy.hnKXsV8exmwHWO2OsRRQ;

      internal static void hsrv6p8e9oB1gRxbukxJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
