// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionPermissionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions
{
  /// <summary>
  /// Атрибут, позволяющий привязать к методу проверку привилегий
  /// </summary>
  public class ActionPermissionAttribute : Attribute
  {
    private readonly Guid permissionId;
    private Permission permission;
    internal static ActionPermissionAttribute xBcPYOfwkOt370txWLXK;

    /// <summary>Конструктор</summary>
    /// <param name="permissionId">Идентификатор проверяемой привилегии</param>
    public ActionPermissionAttribute(Guid permissionId)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.permissionId = permissionId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор проверяемой привилегии</summary>
    public Guid PermissionId => this.permissionId;

    /// <summary>Проверяемая привилегия</summary>
    public Permission Permission => this.permission;

    /// <summary>Конструктор</summary>
    /// <param name="permissionId">Идентификатор проверяемой привилегии</param>
    public ActionPermissionAttribute(string permissionId)
    {
      ActionPermissionAttribute.vnkYDofw2gmx5RZmGORT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.permissionId = ActionPermissionAttribute.emWr3jfwepUUlAtdrByw((object) permissionId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Проверить, доступна ля связанная привилегия для текущего пользователя
    /// </summary>
    /// <returns><c>true</c>, если привилегия доступна</returns>
    /// <exception cref="T:System.InvalidOperationException">Невозможно найти привилегию по Id</exception>
    /// <exception cref="T:System.InvalidOperationException">Невозможно определить текущего пользователя</exception>
    public bool CheckPermissionCurrentUser()
    {
      int num = 1;
      IPermissionManagmentService serviceNotNull1;
      while (true)
      {
        switch (num)
        {
          case 1:
            serviceNotNull1 = Locator.GetServiceNotNull<IPermissionManagmentService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ISecurityService serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
      this.permission = serviceNotNull1.GetPermission(this.permissionId);
      Permission permission = !(this.permission == (Permission) null) ? this.permission : throw new InvalidOperationException(ActionPermissionAttribute.klKtodfw15P1gHIZffWC(ActionPermissionAttribute.o9MeYvfwPlqr67p8egSe(-1822890472 ^ -1822574494)).ToString() + (object) this.permissionId);
      return ActionPermissionAttribute.FqVWsffwN0Orp4SIHNk9((object) serviceNotNull2, (object) permission);
    }

    internal static bool tFVawBfwnIQKcHkM5vD1() => ActionPermissionAttribute.xBcPYOfwkOt370txWLXK == null;

    internal static ActionPermissionAttribute RKK9BsfwOGta6sydO1sw() => ActionPermissionAttribute.xBcPYOfwkOt370txWLXK;

    internal static void vnkYDofw2gmx5RZmGORT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Guid emWr3jfwepUUlAtdrByw([In] object obj0) => Guid.Parse((string) obj0);

    internal static object o9MeYvfwPlqr67p8egSe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object klKtodfw15P1gHIZffWC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool FqVWsffwN0Orp4SIHNk9([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);
  }
}
