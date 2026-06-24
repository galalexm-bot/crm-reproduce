// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ObjectsExportConsts
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Константы для экспорта</summary>
  public static class ObjectsExportConsts
  {
    /// <summary>
    /// Uid реализации точки расширения конфигурации экспорта объектов
    /// </summary>
    public static readonly Guid ExportExtensionUid;
    public static readonly Guid ExportExtensionUidEntity;
    public static readonly Guid ExportExtensionUidEnum;
    /// <summary>Идентификатор раздела датаклассов</summary>
    public static readonly Guid ExportExtensionUidDataClass;
    /// <summary>Ключ публикации датаклассов</summary>
    internal const string KeyPublishDataClass = "KeyPublishDataClass";
    private static ObjectsExportConsts rcOBjfEYT4K22DtIdrZD;

    static ObjectsExportConsts()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            ObjectsExportConsts.ExportExtensionUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 653970289));
            num = 4;
            continue;
          case 2:
            ObjectsExportConsts.OhEp1fEYODF59iHuAUFv();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
            continue;
          case 3:
            ObjectsExportConsts.ExportExtensionUidDataClass = new Guid((string) ObjectsExportConsts.hqB7rvEY2kYYepFE5bvb(--1418440330 ^ 1418637190));
            num = 5;
            continue;
          case 4:
            ObjectsExportConsts.ExportExtensionUidEntity = new Guid((string) ObjectsExportConsts.hqB7rvEY2kYYepFE5bvb(~210725948 ^ -210398281));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            ObjectsExportConsts.ExportExtensionUidEnum = new Guid((string) ObjectsExportConsts.hqB7rvEY2kYYepFE5bvb(~289714581 ^ -289517910));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void OhEp1fEYODF59iHuAUFv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object hqB7rvEY2kYYepFE5bvb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool sYlu4bEYkMbtcpq2EsVC() => ObjectsExportConsts.rcOBjfEYT4K22DtIdrZD == null;

    internal static ObjectsExportConsts iUjXZiEYnbrl33UMtKgD() => ObjectsExportConsts.rcOBjfEYT4K22DtIdrZD;
  }
}
