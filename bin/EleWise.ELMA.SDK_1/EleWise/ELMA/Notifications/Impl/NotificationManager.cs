// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Менеджер оповещений</summary>
  [Service(EnableInterceptors = false, Scope = ServiceScope.Shell, Type = ComponentType.WebServer)]
  public class NotificationManager : INotificationManager
  {
    private static TimeSpan totalGenTime;
    private static TimeSpan totalSendTime;
    private static NotificationManager TC080Kt0AmonHxDHw7r;

    /// <summary>Менеджер сообщений</summary>
    public IMessageManager MessageManager
    {
      get => this.\u003CMessageManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMessageManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Загрузчики шаблонов оповещений</summary>
    public IEnumerable<INotificationTemplateLoader> TemplateLoaders { get; set; }

    /// <summary>Сервис IContextBoundVariableService</summary>
    public IContextBoundVariableService ContextService
    {
      get => this.\u003CContextService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContextService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Сервис флагов функций</summary>
    public IFeatureFlagService FeatureFlagService
    {
      get => this.\u003CFeatureFlagService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFeatureFlagService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Отправить оповещение</summary>
    /// <param name="notification">Оповещение</param>
    public void Send(INotification notification)
    {
      int num = 2;
      ValueTask valueTask;
      ValueTaskAwaiter awaiter;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            awaiter = valueTask.GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 2;
            continue;
          case 2:
            valueTask = this.SendAsyncInternal(notification);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
            continue;
          case 3:
            awaiter.GetResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public Task SendAsync(INotification notification, CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 1;
      ValueTask valueTask;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueTask = this.SendAsyncInternal(notification, true, cancellationToken);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return valueTask.AsTask();
    }

    private ValueTask SendAsyncInternal(
      INotification notification,
      bool isAsync = false,
      CancellationToken cancellationToken = default (CancellationToken))
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      NotificationManager.\u003CSendAsyncInternal\u003Ed__18 stateMachine;
      AsyncValueTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.isAsync = isAsync;
            num = 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 5;
            continue;
          case 4:
            goto label_7;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 7;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = NotificationManager.zrTJ0XtMUXh67y1ReU1();
            num = 3;
            continue;
          case 7:
            tBuilder.Start<NotificationManager.\u003CSendAsyncInternal\u003Ed__18>(ref stateMachine);
            num = 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.notification = notification;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Добавить пользователя в "игнор-лист". Т.е. ему не будут отправляться оповещения.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>True, если пользователь успешно добавлен. False - если он уже был добавлен до этого.</returns>
    public bool AddUserToIgnoreList(IUser user)
    {
      int num1 = 3;
      List<long> ignoredUserIds;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = (long) NotificationManager.Yp0JyOtJEWot628TMuC((object) user);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (user == null)
            {
              num1 = 2;
              continue;
            }
            ignoredUserIds = this.GetIgnoredUserIds();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
            continue;
          case 4:
            goto label_10;
          case 5:
            goto label_8;
          case 6:
            ignoredUserIds.Add(num2);
            num1 = 5;
            continue;
          default:
            if (!ignoredUserIds.Contains(num2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 5 : 6;
              continue;
            }
            goto label_10;
        }
      }
label_4:
      return false;
label_8:
      return true;
label_10:
      return false;
    }

    /// <summary>Удалить пользователя из "игнор-листа".</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public void RemoveUserFromIgnoreList(IUser user)
    {
      int num1 = 3;
      List<long> ignoredUserIds;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ignoredUserIds.Contains(num2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            ignoredUserIds = this.GetIgnoredUserIds();
            num1 = 5;
            continue;
          case 3:
            if (user != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
              continue;
            }
            goto label_12;
          case 4:
            goto label_4;
          case 5:
            num2 = (long) NotificationManager.Yp0JyOtJEWot628TMuC((object) user);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_6;
          default:
            ignoredUserIds.Remove(num2);
            num1 = 4;
            continue;
        }
      }
label_4:
      return;
label_6:
      return;
label_2:
      return;
label_12:;
    }

    /// <summary>
    /// Добавить пользователя в список для принудительной отправки. Ему будут отправляться оповещения, даже если он является автором.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns>True, если пользователь успешно добавлен. False - если он уже был добавлен до этого.</returns>
    public bool AddUserToForceSendList(IUser user)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        List<long> forceSendUserIds;
        long num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (user != null)
              {
                forceSendUserIds = this.GetForceSendUserIds();
                num2 = 6;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_12;
            case 3:
              goto label_10;
            case 4:
              if (!forceSendUserIds.Contains(num3))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 2;
                continue;
              }
              goto label_11;
            case 5:
              goto label_11;
            case 6:
              num3 = (long) NotificationManager.Yp0JyOtJEWot628TMuC((object) user);
              num2 = 4;
              continue;
            default:
              goto label_6;
          }
        }
label_12:
        forceSendUserIds.Add(num3);
        num1 = 3;
      }
label_6:
      return false;
label_10:
      return true;
label_11:
      return false;
    }

    /// <summary>
    /// Удалить пользователя из списка для принудительной отправки.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public void RemoveUserFromForceSendList(IUser user)
    {
      int num1 = 3;
      List<long> forceSendUserIds;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_10;
          case 2:
            forceSendUserIds = this.GetForceSendUserIds();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 4;
            continue;
          case 3:
            if (user != null)
            {
              num1 = 2;
              continue;
            }
            goto label_2;
          case 4:
            num2 = (long) NotificationManager.Yp0JyOtJEWot628TMuC((object) user);
            num1 = 6;
            continue;
          case 5:
            goto label_8;
          case 6:
            if (!forceSendUserIds.Contains(num2))
            {
              num1 = 5;
              continue;
            }
            goto case 7;
          case 7:
            forceSendUserIds.Remove(num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          default:
            goto label_13;
        }
      }
label_5:
      return;
label_10:
      return;
label_8:
      return;
label_13:
      return;
label_2:;
    }

    /// <summary>Добавить пользователя в список для отправки</summary>
    /// <param name="users">Пользователи</param>
    public void AddUsersToAdditionalSendList(IEnumerable<IUser> users)
    {
      List<IUser> additionalSendUsers = this.GetAdditionalSendUsers();
      foreach (IUser user in users)
      {
        if (!additionalSendUsers.Contains(user))
          additionalSendUsers.Add(user);
      }
    }

    internal List<long> GetIgnoredUserIds() => this.ContextService.GetOrAdd<List<long>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306484476), (Func<List<long>>) (() => new List<long>()));

    internal List<long> GetForceSendUserIds() => this.ContextService.GetOrAdd<List<long>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36026101), (Func<List<long>>) (() => new List<long>()));

    /// <summary>Получить список пользователей для отправки</summary>
    internal List<IUser> GetAdditionalSendUsers() => this.ContextService.GetOrAdd<List<IUser>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372723063), (Func<List<IUser>>) (() => new List<IUser>()));

    public NotificationManager()
    {
      NotificationManager.Jm8kJtt9IH3hqgkRxEC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static NotificationManager()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationManager.totalGenTime = TimeSpan.Zero;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            NotificationManager.Jm8kJtt9IH3hqgkRxEC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            NotificationManager.totalSendTime = TimeSpan.Zero;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool hlAOMMtmkiWTlQxqnjN() => NotificationManager.TC080Kt0AmonHxDHw7r == null;

    internal static NotificationManager QM4IoBtyAg8QIHdOBGZ() => NotificationManager.TC080Kt0AmonHxDHw7r;

    internal static AsyncValueTaskMethodBuilder zrTJ0XtMUXh67y1ReU1() => AsyncValueTaskMethodBuilder.Create();

    internal static object Yp0JyOtJEWot628TMuC([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void Jm8kJtt9IH3hqgkRxEC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
