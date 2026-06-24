// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Models.ComponentsExpiration
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.Packaging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Models
{
  /// <summary>
  /// Информация о завершении срока временной лицензии для подстановки в шаблон оповещения
  /// </summary>
  internal sealed class ComponentsExpiration
  {
    /// <summary>Список компонентов с истекающим сроком лицензии</summary>
    private readonly IEnumerable<IStoreComponentInfo> expiringComponents;
    /// <summary>
    /// Список пользователей в группе "Администраторы" для использования в качестве получателей оповещения
    /// </summary>
    private readonly IEnumerable<EleWise.ELMA.Security.IUser> adminGroup;
    internal static object WqVeOLAbsHDhbOfEpJD;

    /// <summary>ctor</summary>
    /// <param name="daysBeforeNotification">Количество дней до начала оповещений</param>
    /// <param name="userGroupManager">Менеджер групп пользователей</param>
    /// <param name="expirationInfoService">Сервис проверки лицензии</param>
    public ComponentsExpiration(
      UserGroupManager userGroupManager,
      ExpirationInfoService expirationInfoService,
      int daysBeforeNotification = 7)
    {
      TKW1L3mlUyvXmg29jA.RWk58XigPN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f48d22e37b594f439dff2aec8625848e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.adminGroup = this.ComputeAdminUsers(userGroupManager);
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.expiringComponents = this.ComputeStoreComponentInfos(expirationInfoService, daysBeforeNotification);
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_289810c0c3734c9ab735510ba793157a != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Получить список компонентов с истекающим сроком лицензии
    /// </summary>
    public IEnumerable<IStoreComponentInfo> ExpiringComponents => this.expiringComponents;

    /// <summary>
    /// Получить список пользователей в группе "Администраторы" для использования в качестве получателей оповещения
    /// </summary>
    public IEnumerable<EleWise.ELMA.Security.IUser> AdminGroup => this.adminGroup;

    /// <summary>
    /// Вычислить список компонентов с истекающим сроком лицензии
    /// </summary>
    /// <param name="expirationInfoService">Сервис проверки лицензии компонентов</param>
    /// <param name="daysBeforeNotification">Количество дней до начала оповещений</param>
    /// <returns>Список компонентов с истекающим сроком лицензии</returns>
    private IEnumerable<IStoreComponentInfo> ComputeStoreComponentInfos(
      ExpirationInfoService expirationInfoService,
      int daysBeforeNotification)
    {
      return expirationInfoService.GetExpiringComponents(daysBeforeNotification);
    }

    /// <summary>
    /// Вычислить список пользователей в группе "Администраторы"
    /// </summary>
    /// <param name="userGroupManager">Менеджер групп пользователей</param>
    /// <returns>Список пользователей в группе "Администраторы"</returns>
    private IEnumerable<EleWise.ELMA.Security.IUser> ComputeAdminUsers(
      UserGroupManager userGroupManager)
    {
      IUserGroup userGroup = userGroupManager.Load(SecurityConstants.AdminGroupUid);
      return (IEnumerable<EleWise.ELMA.Security.IUser>) userGroupManager.GetUsersByGroup(userGroup, new UserStatus[1]);
    }

    internal static bool qInW9LA3j9ZGyBDQCht() => ComponentsExpiration.WqVeOLAbsHDhbOfEpJD == null;

    internal static ComponentsExpiration dfIoTiAxpsUKHkppmih() => (ComponentsExpiration) ComponentsExpiration.WqVeOLAbsHDhbOfEpJD;
  }
}
