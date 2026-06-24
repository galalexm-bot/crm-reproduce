// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CallContextSessionOwner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Владелец сессии NHibernate на основе контекста вызова. Позволяет работать с сессией в рамкаж жизненного цикла данного объекта.
  /// </summary>
  /// <remarks>
  /// Поддерживается провайдерами
  /// <see cref="T:EleWise.ELMA.Runtime.NH.SessionProviders.WebSessionProvider" /> и
  /// <see cref="T:EleWise.ELMA.Runtime.NH.SessionProviders.CallSessionProvider" />.
  /// Может использоваться внутри существующего владельца. В этом случае реальным владельцем сессии будет корневой объект.
  /// </remarks>
  /// <example>
  /// Пример использования:
  /// <code>
  /// using (CallContextSessionOwner.Create())
  /// {
  ///     var user = new User();
  ///     user.Name = "TestUser";
  ///     user.Save();
  /// }
  /// </code>
  /// </example>
  public sealed class CallContextSessionOwner : IDisposable
  {
    private static readonly ContextVars.Local<CallContextSessionOwner> current;
    private static readonly CallContextSessionOwner EmptyDisposable;
    private readonly bool isEmpty;
    private bool disposed;
    private readonly IDisposable elmaContext;
    private IDictionary<Guid, ISessionsContainer> sessionTable;
    private bool isExternalSessionTable;
    private static CallContextSessionOwner NxUwApW6AX5LB5SLSkSW;

    /// <summary>Текущий владелец</summary>
    public static CallContextSessionOwner Current => CallContextSessionOwner.current.Value;

    /// <summary>Ctor</summary>
    [Obsolete("Конструктор устарел и больше не используется. Используйте CallContextSessionOwner.Create()", true)]
    public CallContextSessionOwner()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(false);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Получить экземпляр <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" />
    /// </summary>
    /// <returns>Экземпляр <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" /></returns>
    public static CallContextSessionOwner Create()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (CallContextSessionOwner.current.Value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return CallContextSessionOwner.EmptyDisposable;
label_3:
      return new CallContextSessionOwner(false);
    }

    /// <summary>Словарь "Имя сессии-Сессия"</summary>
    public Dictionary<string, ISession> SessionTable => Locator.GetService<SessionProvider>().GetSessionTable();

    /// <summary>Получить словарь сессий</summary>
    internal IDictionary<Guid, ISessionsContainer> GetSessionTable() => CallContextSessionOwner.Current != null ? CallContextSessionOwner.Current.sessionTable : throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461487261));

    /// <summary>Уничтожить владельца</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Dispose(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Ctor</summary>
    /// <param name="emptyDisposable"><c>true</c> если требуется создать пустой объект</param>
    private CallContextSessionOwner(bool emptyDisposable)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.isEmpty)
            {
              num = 9;
              continue;
            }
            goto label_3;
          case 2:
            CallContextSessionOwner.current.Value = this;
            num = 7;
            continue;
          case 3:
          case 8:
            if (CallContextSessionOwner.current.Value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 5 : 5;
              continue;
            }
            goto case 2;
          case 4:
            this.isEmpty = emptyDisposable;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          case 5:
            goto label_10;
          case 6:
            goto label_2;
          case 7:
            this.sessionTable = (IDictionary<Guid, ISessionsContainer>) new Dictionary<Guid, ISessionsContainer>();
            num = 6;
            continue;
          case 9:
            if (ELMAContext.Initialized)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 3;
              continue;
            }
            break;
        }
        this.elmaContext = ELMAContext.Create();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 7;
      }
label_10:
      return;
label_2:
      return;
label_3:;
    }

    ~CallContextSessionOwner()
    {
      switch (1)
      {
        case 1:
          try
          {
            this.Dispose(false);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          finally
          {
            CallContextSessionOwner.b0k9IOW60JUitqHD11N9((object) this);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    /// <summary>Уничтожить владельца</summary>
    /// <param name="disposing"><c>true</c> если вызывается не из финализатора объекта</param>
    private void Dispose(bool disposing)
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_47;
          case 1:
            goto label_2;
          case 2:
            goto label_53;
          case 3:
            if (!this.disposed)
            {
              num1 = 5;
              continue;
            }
            goto label_41;
          case 4:
            if (!this.isEmpty)
            {
              num1 = 3;
              continue;
            }
            goto label_45;
          case 5:
            this.disposed = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          default:
            goto label_32;
        }
      }
label_47:
      return;
label_53:
      return;
label_32:
      return;
label_2:
      try
      {
        int num2;
        if (!disposing)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 5 : 4;
        else
          goto label_36;
label_4:
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_36;
            case 2:
              CallContextSessionOwner.BuVDBSW6mLNfPq5p3jrQ((object) elmaContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_20;
            case 4:
              if (!this.isExternalSessionTable)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 5:
              if (this.elmaContext is ELMAContext elmaContext)
              {
                num2 = 2;
                continue;
              }
              goto label_36;
            default:
              goto label_5;
          }
        }
label_20:
        return;
label_5:
        try
        {
          int num3;
          if (this.sessionTable == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 3 : 3;
          else
            goto label_10;
label_8:
          IEnumerator<ISessionsContainer> enumerator;
          while (true)
          {
            switch (num3)
            {
              case 1:
                try
                {
label_16:
                  if (CallContextSessionOwner.F1QaDpW6MQ7UG15EvdC4((object) enumerator))
                    goto label_18;
                  else
                    goto label_17;
label_14:
                  int num4;
                  switch (num4)
                  {
                    case 1:
                      goto label_18;
                    case 2:
                      goto label_12;
                    default:
                      goto label_16;
                  }
label_17:
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 2;
                  goto label_14;
label_18:
                  CallContextSessionOwner.ITZ00SW6yBQ95C16QoOt((object) enumerator.Current);
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                  {
                    num4 = 0;
                    goto label_14;
                  }
                  else
                    goto label_14;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_27;
                        default:
                          CallContextSessionOwner.AAf3H0W6J8qssniK8Mg8((object) enumerator);
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
                          continue;
                      }
                    }
                  }
label_27:;
                }
              case 2:
                goto label_28;
              case 3:
                goto label_25;
              case 4:
label_12:
                CallContextSessionOwner.KPFCHjW69EV4Ra28Tj48((object) this.sessionTable);
                num3 = 2;
                continue;
              default:
                goto label_10;
            }
          }
label_28:
          return;
label_25:
          return;
label_10:
          enumerator = this.sessionTable.Values.GetEnumerator();
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
          {
            num3 = 1;
            goto label_8;
          }
          else
            goto label_8;
        }
        finally
        {
          CallContextSessionOwner.current.Value = (CallContextSessionOwner) null;
          int num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
            num6 = 0;
          switch (num6)
          {
            default:
          }
        }
label_9:
        return;
label_36:
        if (CallContextSessionOwner.current.Value != this)
          return;
        num2 = 4;
        goto label_4;
      }
      finally
      {
        IDisposable elmaContext = this.elmaContext;
        int num7;
        if (elmaContext == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
        else
          goto label_48;
label_44:
        while (true)
        {
          switch (num7)
          {
            case 2:
              goto label_50;
            default:
              CallContextSessionOwner.So4ZBUW6dNWqDWZGYnuQ((object) this);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
              continue;
          }
        }
label_50:
label_48:
        CallContextSessionOwner.AAf3H0W6J8qssniK8Mg8((object) elmaContext);
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        {
          num7 = 0;
          goto label_44;
        }
        else
          goto label_44;
      }
label_45:
      return;
label_41:;
    }

    static CallContextSessionOwner()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            CallContextSessionOwner.current = new ContextVars.Local<CallContextSessionOwner>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            CallContextSessionOwner.DkOPjsW6loxgGstOSrPd();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            CallContextSessionOwner.EmptyDisposable = new CallContextSessionOwner(true);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool HRSt4ZW67qjypIunpKFC() => CallContextSessionOwner.NxUwApW6AX5LB5SLSkSW == null;

    internal static CallContextSessionOwner owUxsjW6xjr4GbFo3t6X() => CallContextSessionOwner.NxUwApW6AX5LB5SLSkSW;

    internal static void b0k9IOW60JUitqHD11N9([In] object obj0) => __nonvirtual (obj0.Finalize());

    internal static void BuVDBSW6mLNfPq5p3jrQ([In] object obj0) => ((ELMAContext) obj0).SetAsCurrent();

    internal static void ITZ00SW6yBQ95C16QoOt([In] object obj0) => ((ISessionsContainer) obj0).CloseAll();

    internal static bool F1QaDpW6MQ7UG15EvdC4([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void AAf3H0W6J8qssniK8Mg8([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void KPFCHjW69EV4Ra28Tj48([In] object obj0) => ((ICollection<KeyValuePair<Guid, ISessionsContainer>>) obj0).Clear();

    internal static void So4ZBUW6dNWqDWZGYnuQ([In] object obj0) => GC.SuppressFinalize(obj0);

    internal static void DkOPjsW6loxgGstOSrPd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
