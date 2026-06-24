// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Abstractions.ServerPlacementPublishBuilderExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions
{
  /// <summary>
  /// Расширение для публикации действия на всех серверах кластера ELMA
  /// </summary>
  public static class ServerPlacementPublishBuilderExtension
  {
    /// <summary>Публикация действия на всех серверах кластера ELMA</summary>
    /// <typeparam name="T">Тип актора</typeparam>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <returns>Публикатор действия для актора <typeparamref name="T" /></returns>
    public static ServerPlacementPublishBuilderExtension.Publisher<T> For<T>(
      this IServerPlacementPublishService serverPlacementPublishService)
      where T : IServerPlacementActor
    {
      return new ServerPlacementPublishBuilderExtension.Publisher<T>(serverPlacementPublishService);
    }

    /// <summary>
    /// Публикатор действия для актора <typeparamref name="T" />
    /// </summary>
    /// <typeparam name="T">Тип актора</typeparam>
    public class Publisher<T> where T : IServerPlacementActor
    {
      private readonly IServerPlacementPublishService serverPlacementPublishService;
      private static object PrweYLZEwcchbMsfkpjc;

      /// <summary>ctor</summary>
      /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
      internal Publisher(
        IServerPlacementPublishService serverPlacementPublishService)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.serverPlacementPublishService = serverPlacementPublishService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <summary>Публикация действия на всех серверах кластера ELMA</summary>
      /// <param name="action">Действие</param>
      /// <param name="ignoreError">Игнорировать ошибки</param>
      /// <param name="errorAction">Действие при ошибке</param>
      public Task Publish(
        Func<T, Task> action,
        bool ignoreError = false,
        Action<Guid, Exception> errorAction = null)
      {
        return this.serverPlacementPublishService.Publish<T>(action, ignoreError, errorAction);
      }

      /// <summary>Публикация действия на всех серверах кластера ELMA</summary>
      /// <typeparam name="TRes">Тип результата</typeparam>
      /// <param name="action">Действие</param>
      /// <param name="ignoreError">Игнорировать ошибки</param>
      /// <param name="errorAction">Действие при ошибке</param>
      public Task<IReadOnlyDictionary<Guid, TRes>> Publish<TRes>(
        Func<T, Task<TRes>> action,
        bool ignoreError = false,
        Action<Guid, Exception> errorAction = null)
      {
        return this.serverPlacementPublishService.Publish<T, TRes>(action, ignoreError, errorAction);
      }

      internal static bool jAQ5TQZE4IG5Fb1CDnEE() => ServerPlacementPublishBuilderExtension.Publisher<T>.PrweYLZEwcchbMsfkpjc == null;

      internal static object U0bp0AZE6goFT1NSX9S3() => ServerPlacementPublishBuilderExtension.Publisher<T>.PrweYLZEwcchbMsfkpjc;
    }
  }
}
