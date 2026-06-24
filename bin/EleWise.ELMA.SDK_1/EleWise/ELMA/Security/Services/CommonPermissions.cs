// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.CommonPermissions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Базовый набор привилегий</summary>
  [Component]
  public class CommonPermissions : IPermissionProvider
  {
    /// <summary>Идентификатор, для привилегии "Создание"</summary>
    public const string CreateId = "FED901DB-3E4A-4BF0-B3DD-5BD1CC0D7255";
    /// <summary>Идентификатор, для привилегии "Редактирование"</summary>
    public const string EditId = "DA114EB6-12E0-4AAF-B462-F5BBFC177FBD";
    /// <summary>Идентификатор, для привилегии "Просмотр"</summary>
    public const string ViewId = "2207FB22-04C9-42E5-B04F-F64144B88925";
    /// <summary>Идентификатор, для привилегии "Изменение привилегий"</summary>
    public const string GrantAccessId = "F883B9C0-55C6-4178-BF57-37315F723205";
    /// <summary>Идентификатор, для привилегии "Удаление"</summary>
    public const string DeleteId = "7D4D7B30-28BC-4A96-9DA9-A72654272386";
    /// <summary>
    /// Идентификатор, для привилегии "Администрирование системы"
    /// </summary>
    public const string AdminPermissionId = "7B1CC80C-1AD0-404A-8564-06DE4B269469";
    /// <summary>Привилегия "Администрирование системы"</summary>
    public static readonly Permission AdminPermission;
    /// <summary>
    /// Идентификатор, для привилегии "Доступ к Дизайнеру ELMA"
    /// </summary>
    public const string DesignerAccessPermissionId = "8DD067A9-9DDF-4FE7-9241-6989B59A6AEA";
    /// <summary>Привилегия "Доступ к Дизайнеру ELMA"</summary>
    public static readonly Permission DesignerAccessPermission;
    /// <summary>Создание</summary>
    public static readonly Permission Create;
    /// <summary>Редактирование, изменение</summary>
    public static readonly Permission Edit;
    /// <summary>Просмотр</summary>
    public static readonly Permission View;
    /// <summary>
    /// Изменение привилегий, возможность дать другим пользователям права
    /// </summary>
    public static readonly Permission GrantAccess;
    /// <summary>Удаление</summary>
    public static readonly Permission Delete;
    public const string TranslateSystemId = "691B08C2-088E-4E4A-BE73-40F68D4761EA";
    /// <summary>Привилегия "Перевод системы ELMA"</summary>
    public static readonly Permission TranslateSystemPermission;
    internal static CommonPermissions prEtllBsooRuTj1v7SSA;

    public IEnumerable<Permission> GetPermissions() => (IEnumerable<Permission>) new Permission[7]
    {
      CommonPermissions.Create,
      CommonPermissions.Edit,
      CommonPermissions.GrantAccess,
      CommonPermissions.View,
      CommonPermissions.AdminPermission,
      CommonPermissions.DesignerAccessPermission,
      CommonPermissions.TranslateSystemPermission
    };

    public IEnumerable<PermissionStereotype> GetPermissionStereotypes() => (IEnumerable<PermissionStereotype>) EleWise.ELMA.Helpers.EmptyArray<PermissionStereotype>.Instance;

    public List<string> LocalizedItemsNames => (List<string>) null;

    public List<string> LocalizedItemsDescriptions => (List<string>) null;

    public List<string> LocalizedItemsCategories => (List<string>) null;

    /// <summary>
    /// Возвращает соответстие привилегия - имя привилегии(на английском)
    /// </summary>
    /// <returns></returns>
    public Dictionary<Permission, string> GetPermissionNames() => new Dictionary<Permission, string>()
    {
      {
        CommonPermissions.Create,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979466186)
      },
      {
        CommonPermissions.Edit,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712437055)
      },
      {
        CommonPermissions.GrantAccess,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841315108)
      },
      {
        CommonPermissions.View,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304687481)
      },
      {
        CommonPermissions.AdminPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272536539)
      },
      {
        CommonPermissions.DesignerAccessPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812121442)
      },
      {
        CommonPermissions.TranslateSystemPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867139951)
      }
    };

    public CommonPermissions()
    {
      CommonPermissions.ldDFqLBsGYYjUL10essN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CommonPermissions()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            CommonPermissions.View = new Permission(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669289129), SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16702567)), "", (string) CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-1334993905 ^ -1335041865)), permissionType: PermissionType.Instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
            continue;
          case 2:
            CommonPermissions.GrantAccess = new Permission((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(1304605005 ^ 1304677599), (string) CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-53329496 >> 4 ^ -3384892)), "", SR.M((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(272623989 ^ 272537037)), permissionType: PermissionType.Instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 3:
            CommonPermissions.AdminPermission = (Permission) CommonPermissions.zXsIBBBsCQZijtScpJo0(CommonPermissions.k51thjBsQr7FJYQR6iaR(CommonPermissions.ReQoaOBsErCBguy0i1Hn(1319452732 ^ 1319385862), CommonPermissions.bFcreaBsfrGKamW2tuOv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514995887)), (object) "", CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(864270449 << 6 ^ -521260366))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 9;
            continue;
          case 4:
            CommonPermissions.ldDFqLBsGYYjUL10essN();
            num = 3;
            continue;
          case 5:
            CommonPermissions.Edit = new Permission((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(1669371371 ^ 1669458221), (string) CommonPermissions.bFcreaBsfrGKamW2tuOv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105137424)), "", SR.M((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(1925118608 << 2 ^ -889547016)), permissionType: PermissionType.Instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_2;
          case 7:
            CommonPermissions.TranslateSystemPermission = (Permission) ((PermissionBuilder) CommonPermissions.k51thjBsQr7FJYQR6iaR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113934953), CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(654297945 ^ 654226927)), CommonPermissions.bFcreaBsfrGKamW2tuOv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822844678)), CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-138018305 ^ -138006771)))).ModuleUid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475823159));
            num = 6;
            continue;
          case 8:
            CommonPermissions.Create = new Permission((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(-138018305 ^ -137921113), (string) CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-680446928 - -370807692 ^ -309708008)), "", (string) CommonPermissions.bFcreaBsfrGKamW2tuOv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470390246)), permissionType: PermissionType.EntityType);
            num = 5;
            continue;
          case 9:
            CommonPermissions.DesignerAccessPermission = (Permission) CommonPermissions.zXsIBBBsCQZijtScpJo0(CommonPermissions.k51thjBsQr7FJYQR6iaR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459515235), CommonPermissions.bFcreaBsfrGKamW2tuOv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146562261)), (object) "", CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-218496594 ^ -218399340))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 8 : 7;
            continue;
          default:
            CommonPermissions.Delete = new Permission((string) CommonPermissions.ReQoaOBsErCBguy0i1Hn(-643786247 ^ -643700749), (string) CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(--1360331293 ^ 1360297035)), "", (string) CommonPermissions.bFcreaBsfrGKamW2tuOv(CommonPermissions.ReQoaOBsErCBguy0i1Hn(-2106517564 ^ -2106561668)), permissionType: PermissionType.Instance);
            num = 7;
            continue;
        }
      }
label_2:;
    }

    internal static void ldDFqLBsGYYjUL10essN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DojjkpBsbcUvKYnf8gHY() => CommonPermissions.prEtllBsooRuTj1v7SSA == null;

    internal static CommonPermissions s0n285BshjyAJqRve2Sb() => CommonPermissions.prEtllBsooRuTj1v7SSA;

    internal static object ReQoaOBsErCBguy0i1Hn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object bFcreaBsfrGKamW2tuOv([In] object obj0) => (object) SR.M((string) obj0);

    internal static object k51thjBsQr7FJYQR6iaR(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) Permission.Create((string) obj0, (string) obj1, (string) obj2, (string) obj3);
    }

    internal static object zXsIBBBsCQZijtScpJo0([In] object obj0) => (object) (Permission) (PermissionBuilder) obj0;
  }
}
