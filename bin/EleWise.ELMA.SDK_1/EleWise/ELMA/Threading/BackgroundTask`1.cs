// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.BackgroundTask`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Threading
{
  /// <summary>Фоновая задача с результатом.</summary>
  /// <typeparam name="T">Тип объекта результата.</typeparam>
  public class BackgroundTask<T> : BackgroundTask
  {
    private readonly Func<T> resultFactory;
    internal static object dDK14fBSjb6Ose8027GR;

    /// <summary>Ctor</summary>
    /// <param name="action">Действие выполняемое в рамках задачи</param>
    /// <param name="ownerType">Тип владельца</param>
    /// <param name="name">Название</param>
    /// <param name="description">Описание</param>
    /// <param name="useCallSessionOwner">Использовать сессию вызова владельца</param>
    /// <param name="handleExceptions">Перехватывать исключения</param>
    public BackgroundTask(
      Func<T> action,
      Type ownerType,
      string name,
      string description,
      bool useCallSessionOwner = true,
      bool handleExceptions = true)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(ownerType, name, description, useCallSessionOwner, handleExceptions);
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867131295));
      this.resultFactory = action;
    }

    /// <summary>
    /// Результат выполнения фоновой задачи <see cref="T:EleWise.ELMA.Threading.BackgroundTask`1" />.
    /// </summary>
    public T Result { get; protected set; }

    /// <summary>Выполнить делегат пользователя.</summary>
    protected override void ExecuteUserDelegate()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Result = this.resultFactory();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool S3K8O8BSY4b5QfBc7OBf() => BackgroundTask<T>.dDK14fBSjb6Ose8027GR == null;

    internal static object GspkDpBSL8e8UyC8EMTm() => BackgroundTask<T>.dDK14fBSjb6Ose8027GR;
  }
}
