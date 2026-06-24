// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.HubBase`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Hubs
{
  /// <summary>
  /// Базовая реализация хабов. От этого класса должны наследоваться все пользовательские хабы
  /// </summary>
  /// <typeparam name="T">Тип клиента хаба</typeparam>
  public abstract class HubBase<T> : IHub, IDisposable where T : IClient
  {
    private static object WRJ9KAhgmVUqbXwthXPH;

    /// <summary>
    /// Типизированный объект, который представляет всех клиентов, подключенных к этому хабу (не к экземпляру хаба)
    /// </summary>
    public IHubCallerConnectionContextWrapper<T> Clients { get; set; }

    /// <summary>Информация о вызывающем контексте</summary>
    public IHubCallerContextWrapper Context
    {
      get => this.\u003CContext\u003Ek__BackingField;
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
              this.\u003CContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

    /// <summary>Менеджер управления группами</summary>
    public IGroupManagerWrapper Groups
    {
      get => this.\u003CGroups\u003Ek__BackingField;
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
              this.\u003CGroups\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
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

    /// <summary>
    /// Вызывается при подключении нового соединения к <see cref="T:EleWise.ELMA.Hubs.IHub" />.
    /// </summary>
    public virtual Task OnConnected() => Task.CompletedTask;

    /// <summary>
    /// Вызывается при переподключении к <see cref="T:EleWise.ELMA.Hubs.IHub" /> после таймаута
    /// </summary>
    public virtual Task OnReconnected() => Task.CompletedTask;

    /// <summary>
    /// Вызывается при корректном отключении от <see cref="T:EleWise.ELMA.Hubs.IHub" /> или из-за таймаута
    /// </summary>
    /// <param name="stopCalled">
    /// <c>true</c> если соединение было закрыто корректно.
    /// <c>false</c> если соединения было закрыто по таймауту.
    /// </param>
    public virtual Task OnDisconnected(bool stopCalled) => Task.CompletedTask;

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Dispose(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            GC.SuppressFinalize((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Уничтожить экземляр объекта</summary>
    /// <param name="disposing"><c>true</c> если операция вызывается не из финализатора объекта </param>
    protected virtual void Dispose(bool disposing)
    {
    }

    protected HubBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool axQUHJhgyKMwLrhoytnL() => HubBase<T>.WRJ9KAhgmVUqbXwthXPH == null;

    internal static object zpjRgbhgMh4rNU25iO95() => HubBase<T>.WRJ9KAhgmVUqbXwthXPH;
  }
}
