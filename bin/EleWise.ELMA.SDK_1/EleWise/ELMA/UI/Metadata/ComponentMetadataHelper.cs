// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ComponentMetadataHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Помощник для метаданных компонентов</summary>
  public static class ComponentMetadataHelper
  {
    private static ComponentMetadataHelper ji301KBbD4gw8vmtCKYp;

    /// <summary>Имя клиентской сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="version">Версия</param>
    /// <returns>Имя клиентской сборки</returns>
    public static string ClientAssemblyName(ComponentMetadata metadata, string version = null)
    {
      object obj1 = ComponentMetadataHelper.VObwLjBb4qLfSgdo6wmC(1051276242 - 990076387 ^ 61161293);
      object obj2 = ComponentMetadataHelper.ClJ2IsBb6iHUJM7OGNAF((object) metadata);
      object obj3 = ComponentMetadataHelper.VObwLjBb4qLfSgdo6wmC(-1852837372 ^ -1852834178);
      string str1 = version;
      string str2 = str1 == null ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751138000) : str1;
      return (string) ComponentMetadataHelper.eG9AN4BbAaXOt4Au4Hh4(ComponentMetadataHelper.EaVTeOBbHV8R9GV0g903(obj1, obj2, obj3, (object) str2), '.', '_');
    }

    /// <summary>Имя серверной сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя серверной сборки</returns>
    public static string ServerAssemblyName(ComponentMetadata metadata) => (string) ComponentMetadataHelper.VObwLjBb4qLfSgdo6wmC(--1418440330 ^ 1418413096) + (string) ComponentMetadataHelper.ClJ2IsBb6iHUJM7OGNAF((object) metadata);

    internal static object VObwLjBb4qLfSgdo6wmC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ClJ2IsBb6iHUJM7OGNAF([In] object obj0) => (object) ((ComponentMetadata) obj0).FullTypeName;

    internal static object EaVTeOBbHV8R9GV0g903(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object eG9AN4BbAaXOt4Au4Hh4([In] object obj0, [In] char obj1, [In] char obj2) => (object) ((string) obj0).Replace(obj1, obj2);

    internal static bool zNvun1BbtBLsjUlYc8AX() => ComponentMetadataHelper.ji301KBbD4gw8vmtCKYp == null;

    internal static ComponentMetadataHelper UURMo9Bbw8COXdUOMKlh() => ComponentMetadataHelper.ji301KBbD4gw8vmtCKYp;
  }
}
