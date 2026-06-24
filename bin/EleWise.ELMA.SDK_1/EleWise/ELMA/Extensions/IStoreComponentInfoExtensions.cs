// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.IStoreComponentInfoExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging;
using NuGet;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>
  /// Методы расширения для <see cref="T:EleWise.ELMA.Packaging.IStoreComponentInfo" />.
  /// </summary>
  internal static class IStoreComponentInfoExtensions
  {
    internal static IStoreComponentInfoExtensions bdg8UKGpOYyyDl7QIufV;

    /// <summary>Может ли компонент быть установлен или обновлён?</summary>
    /// <param name="componentInfo">Информация о компоненте.</param>
    /// <returns><c>true</c> - может, <c>false</c> - не может.</returns>
    public static bool CanBeInstalledOrUpdated(this IStoreComponentInfo componentInfo)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (!IStoreComponentInfoExtensions.ydthX7Gp1UpSqNuEImsk(IStoreComponentInfoExtensions.GIOjXCGpPP5vnmjRmndR((object) componentInfo), (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (IStoreComponentInfoExtensions.vEYmo1Gp32pBkrcHeK1P(IStoreComponentInfoExtensions.OljFVRGpNjLNqndWxXi4((object) componentInfo), (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 2;
              continue;
            }
            goto label_6;
          case 4:
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return IStoreComponentInfoExtensions.vfnrkiGppTa7KUq7CU7t((object) componentInfo.InstalledVersion, IStoreComponentInfoExtensions.OljFVRGpNjLNqndWxXi4((object) componentInfo));
label_7:
      return true;
    }

    internal static object GIOjXCGpPP5vnmjRmndR([In] object obj0) => (object) ((IStoreComponentInfo) obj0).InstalledVersion;

    internal static bool ydthX7Gp1UpSqNuEImsk([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 == (SemanticVersion) obj1;

    internal static object OljFVRGpNjLNqndWxXi4([In] object obj0) => (object) ((IStoreComponentInfo) obj0).LastVersion;

    internal static bool vEYmo1Gp32pBkrcHeK1P([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 != (SemanticVersion) obj1;

    internal static bool vfnrkiGppTa7KUq7CU7t([In] object obj0, [In] object obj1) => (SemanticVersion) obj0 < (SemanticVersion) obj1;

    internal static bool gHtrrxGp2dlgetE31wbv() => IStoreComponentInfoExtensions.bdg8UKGpOYyyDl7QIufV == null;

    internal static IStoreComponentInfoExtensions sdypNwGpeNBWOjrBPWKG() => IStoreComponentInfoExtensions.bdg8UKGpOYyyDl7QIufV;
  }
}
