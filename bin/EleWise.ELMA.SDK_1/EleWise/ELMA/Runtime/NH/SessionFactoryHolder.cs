// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionFactoryHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Сервис для хранения фабрики сессий. Нужен для того, чтобы можно было динамически переконфигурировать NHibernate.
  /// </summary>
  public class SessionFactoryHolder
  {
    private ILogger logger;
    private ISessionFactory sessionFactory;
    private Configuration configuration;
    private Timer checkSessionFactoryTimer;
    private readonly PublishCacheContext.Local<SessionFactoryHolder.FreeObject> freeObject;
    private readonly List<(WeakReference<SessionFactoryHolder.FreeObject> sessionFactory, IList<string> regions)> freeObjects;
    private readonly ContextVars.Local<bool> isPublication;
    private List<NHManagerRegisterParams> registerParams;
    private static SessionFactoryHolder KFeOlYW6Xw17mCqEX2Mw;

    /// <summary>Ctor</summary>
    /// <param name="configuration">Конфигурация</param>
    public SessionFactoryHolder(NHibernate.Cfg.Configuration configuration)
    {
      SessionFactoryHolder.E9UNGUW6nTvHG2rnaIdH();
      // ISSUE: type reference
      this.logger = (ILogger) SessionFactoryHolder.fgK3cmW62JS2q2V0k0nh(SessionFactoryHolder.Ck0ZTBW6Okdv8D9TotVx(__typeref (SessionFactoryHolder)));
      this.freeObjects = new List<(WeakReference<SessionFactoryHolder.FreeObject>, IList<string>)>();
      this.isPublication = new ContextVars.Local<bool>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.freeObject = new PublishCacheContext.Local<SessionFactoryHolder.FreeObject>(new Func<SessionFactoryHolder.FreeObject, SessionFactoryHolder.FreeObject>(this.PublicationStart), new Action<SessionFactoryHolder.FreeObject>(this.PublicationEnd), new Action<SessionFactoryHolder.FreeObject>(this.PublicationEnd), new Action<SessionFactoryHolder.FreeObject>(this.SessionFactoryClear));
            num = 3;
            continue;
          case 2:
            SessionFactoryHolder.WDUppGW6P4k01IRLKRdC((object) configuration, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(1819636893 << 3 ^ 1672112106));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            this.configuration = (Configuration) configuration;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Фабрика сессий</summary>
    public ISessionFactory SessionFactory
    {
      get => this.sessionFactory;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.sessionFactory = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 2:
              SessionFactoryHolder.WDUppGW6P4k01IRLKRdC((object) value, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106499406));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Конфигурация</summary>
    public NHibernate.Cfg.Configuration Configuration
    {
      get => (NHibernate.Cfg.Configuration) this.configuration;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              SessionFactoryHolder.WDUppGW6P4k01IRLKRdC((object) value, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(-1380439818 << 3 ^ 1841368774));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              this.configuration = (Configuration) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Создать фабрику сессий</summary>
    internal void CreateSessionFactory()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SessionFactoryHolder.jfqOuaW61i8oQyKjRyZ6((object) this.logger, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(-1217523399 ^ -1217645921));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            SessionFactoryHolder.Eu5Gn5W63IQZjOoTr2FI(SessionFactoryHolder.W9i5EbW6NTRsY28SiRmb((object) this.sessionFactory), true);
            num = 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            SessionFactoryHolder.jfqOuaW61i8oQyKjRyZ6((object) this.logger, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(~541731958 ^ -541593507));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 3;
            continue;
          default:
            this.sessionFactory = this.configuration.BuildSessionFactory();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Разрегистрация типов и пересоздание фабрики сессий</summary>
    /// <param name="parameters">Параметры для регистрации менеджера NHibernate</param>
    internal void UpdateConfiguration(NHManagerRegisterParams parameters)
    {
      int num1 = 6;
      List<(WeakReference<SessionFactoryHolder.FreeObject>, IList<string>)> freeObjects1;
      bool lockTaken;
      List<string> stringList;
      while (true)
      {
        switch (num1)
        {
          case 1:
            SessionFactoryHolder.jfqOuaW61i8oQyKjRyZ6((object) this.logger, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(1461625753 ^ 1461487501));
            num1 = 11;
            continue;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 10 : 10;
            continue;
          case 3:
label_42:
            freeObjects1 = this.freeObjects;
            num1 = 2;
            continue;
          case 4:
label_25:
            if (this.isPublication.Value)
            {
              num1 = 7;
              continue;
            }
            goto case 9;
          case 5:
            if (this.isPublication.Value)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 6:
            if (SessionFactoryHolder.YngqrkW6pWTB2bQC8tum((object) parameters))
            {
              num1 = 5;
              continue;
            }
            goto label_35;
          case 7:
            goto label_22;
          case 8:
            goto label_31;
          case 9:
            List<NHManagerRegisterParams> registerParams = this.registerParams;
            if (registerParams == null)
            {
              num1 = 13;
              continue;
            }
            // ISSUE: explicit non-virtual call
            __nonvirtual (registerParams.Add(parameters));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 7 : 8;
            continue;
          case 10:
            try
            {
              Monitor.Enter((object) freeObjects1, ref lockTaken);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 5:
                    if (!this.logger.IsInfoEnabled())
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 6;
                      continue;
                    }
                    goto case 2;
                  case 2:
                    this.logger.InfoFormat((string) SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(277947046 - -1479185048 ^ 1756991874), (object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106516538), (IEnumerable<string>) stringList));
                    num2 = 11;
                    continue;
                  case 3:
                    if (this.checkSessionFactoryTimer == null)
                    {
                      num2 = 6;
                      continue;
                    }
                    goto label_25;
                  case 4:
                  case 9:
                    List<(WeakReference<SessionFactoryHolder.FreeObject>, IList<string>)> freeObjects2 = this.freeObjects;
                    PublishCacheContext.Local<SessionFactoryHolder.FreeObject> freeObject1 = this.freeObject;
                    SessionFactoryHolder.FreeObject freeObject2 = new SessionFactoryHolder.FreeObject();
                    freeObject2.Regions = stringList;
                    SessionFactoryHolder.FreeObject target = freeObject2;
                    freeObject1.Value = freeObject2;
                    (WeakReference<SessionFactoryHolder.FreeObject>, IList<string>) valueTuple = (new WeakReference<SessionFactoryHolder.FreeObject>(target), (IList<string>) stringList);
                    freeObjects2.Add(valueTuple);
                    num2 = 5;
                    continue;
                  case 6:
                    this.checkSessionFactoryTimer = new Timer(new TimerCallback(this.CheckSessionFactory), (object) null, SessionFactoryHolder.NXqLuAW6w8BcecJia4Hs(1.0), SessionFactoryHolder.NXqLuAW6w8BcecJia4Hs(1.0));
                    num2 = 10;
                    continue;
                  case 7:
                  case 11:
                    SessionFactoryHolder.AT0A8QW6tZF8o7DFqtFB((object) NHCacheWrapper.DisableCache((IList<string>) stringList));
                    num2 = 3;
                    continue;
                  case 8:
                    this.freeObject.Value.Regions.AddRange((IEnumerable<string>) stringList);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
                    continue;
                  case 10:
                    goto label_25;
                  default:
                    if (this.freeObject.Value == null)
                    {
                      num2 = 9;
                      continue;
                    }
                    goto case 8;
                }
              }
            }
            finally
            {
              if (lockTaken)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_21;
                    default:
                      SessionFactoryHolder.NfNCFDW64svkyUcJYy0Z((object) freeObjects1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_21:;
            }
          case 11:
            stringList = new List<string>();
            num1 = 14;
            continue;
          case 12:
            goto label_41;
          case 13:
            goto label_47;
          case 14:
            try
            {
              this.configuration.UpdateSessionFactory(this.SessionFactory, parameters.CreateModelMapper(), (IList<string>) stringList);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_42;
                  default:
                    this.logger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909301539));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_37;
                  default:
                    SessionFactoryHolder.SoE66XW6D9gj8VJ9dtv3((object) this.logger, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(-1876063057 ^ -1875924947), (object) ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
                    continue;
                }
              }
label_37:
              throw;
            }
          default:
            List<NHManagerRegisterParams> managerRegisterParamsList = Interlocked.Exchange<List<NHManagerRegisterParams>>(ref this.registerParams, (List<NHManagerRegisterParams>) null);
            managerRegisterParamsList.ForEach(new Action<NHManagerRegisterParams>(parameters.Add));
            SessionFactoryHolder.v5lQ5rW6aQlqfJxdVkqV((object) managerRegisterParamsList);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
        }
      }
label_22:
      return;
label_31:
      return;
label_41:
      return;
label_47:
      return;
label_35:;
    }

    private SessionFactoryHolder.FreeObject PublicationStart(SessionFactoryHolder.FreeObject _)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.isPublication.Value = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 2:
            Interlocked.Exchange<List<NHManagerRegisterParams>>(ref this.registerParams, new List<NHManagerRegisterParams>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (SessionFactoryHolder.FreeObject) null;
    }

    private void PublicationEnd(SessionFactoryHolder.FreeObject _)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
          case 3:
            this.isPublication.Value = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            List<NHManagerRegisterParams> managerRegisterParamsList = Interlocked.Exchange<List<NHManagerRegisterParams>>(ref this.registerParams, (List<NHManagerRegisterParams>) null);
            if (managerRegisterParamsList == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
              continue;
            }
            // ISSUE: explicit non-virtual call
            __nonvirtual (managerRegisterParamsList.Clear());
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_6:
      return;
label_4:;
    }

    private void SessionFactoryClear(SessionFactoryHolder.FreeObject freeObject)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SessionFactoryHolder.sp021FW66tA3A6GrTAYU((object) freeObject, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 2:
              if (freeObject != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
                continue;
              }
              goto label_8;
            case 3:
              goto label_3;
            default:
              goto label_7;
          }
        }
label_7:
        ThreadStarter.QueueThread(new WaitCallback(this.CheckSessionFactory), (object) this.checkSessionFactoryTimer);
        num1 = 3;
      }
label_3:
      return;
label_8:;
    }

    private void CheckSessionFactory(object sender)
    {
      int num1 = 3;
      List<(WeakReference<SessionFactoryHolder.FreeObject>, IList<string>)> freeObjects;
      bool lockTaken;
      // ISSUE: variable of a compiler-generated type
      SessionFactoryHolder.\u003C\u003Ec__DisplayClass20_0 cDisplayClass200;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = 4;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass200.\u003C\u003E4__this = this;
            num1 = 7;
            continue;
          case 3:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass200 = new SessionFactoryHolder.\u003C\u003Ec__DisplayClass20_0();
            num1 = 2;
            continue;
          case 4:
            try
            {
              Monitor.Enter((object) freeObjects, ref lockTaken);
              int num2 = 5;
              // ISSUE: variable of a compiler-generated type
              SessionFactoryHolder.\u003C\u003Ec__DisplayClass20_1 cDisplayClass201;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    SessionFactoryHolder.L4EfA2W6HHYjL5Zix3I6((object) this.checkSessionFactoryTimer);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 6 : 0;
                    continue;
                  case 2:
                    SessionFactoryHolder.jfqOuaW61i8oQyKjRyZ6((object) this.logger, SessionFactoryHolder.YeW5bJW6e0wXh80ohxQX(-1445902765 ^ -1980277732 ^ 539246247));
                    num2 = 4;
                    continue;
                  case 3:
                    goto label_28;
                  case 4:
                    GC.Collect();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 1;
                    continue;
                  case 5:
                    if (this.checkSessionFactoryTimer != null)
                    {
                      num2 = 11;
                      continue;
                    }
                    goto label_28;
                  case 6:
                    this.checkSessionFactoryTimer = (Timer) null;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 10 : 9;
                    continue;
                  case 7:
                  case 10:
                    // ISSUE: reference to a compiler-generated field
                    if (cDisplayClass201.needCollect)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 2;
                      continue;
                    }
                    goto label_28;
                  case 8:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass201.needCollect = false;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated field
                    cDisplayClass201.CS\u0024\u003C\u003E8__locals1 = cDisplayClass200;
                    num2 = 8;
                    continue;
                  case 11:
                    // ISSUE: object of a compiler-generated type is created
                    cDisplayClass201 = new SessionFactoryHolder.\u003C\u003Ec__DisplayClass20_1();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 9 : 9;
                    continue;
                  case 12:
                    if (this.freeObjects.Count != 0)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 4 : 7;
                      continue;
                    }
                    goto case 1;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    this.freeObjects.RemoveAll(new Predicate<(WeakReference<SessionFactoryHolder.FreeObject>, IList<string>)>(cDisplayClass201.\u003CCheckSessionFactory\u003Eb__0));
                    num2 = 12;
                    continue;
                }
              }
            }
            finally
            {
              if (lockTaken)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_24;
                    default:
                      SessionFactoryHolder.NfNCFDW64svkyUcJYy0Z((object) freeObjects);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_24:;
            }
          case 5:
label_28:
            // ISSUE: reference to a compiler-generated field
            NHCacheWrapper.EnableCache((IList<string>) cDisplayClass200.enableRegions).Wait();
            num1 = 6;
            continue;
          case 6:
            goto label_22;
          case 7:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass200.enableRegions = new List<string>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          default:
            freeObjects = this.freeObjects;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
        }
      }
label_22:;
    }

    internal static void E9UNGUW6nTvHG2rnaIdH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type Ck0ZTBW6Okdv8D9TotVx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object fgK3cmW62JS2q2V0k0nh(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static object YeW5bJW6e0wXh80ohxQX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void WDUppGW6P4k01IRLKRdC([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool cgZcOXW6T10CQGj4jgIo() => SessionFactoryHolder.KFeOlYW6Xw17mCqEX2Mw == null;

    internal static SessionFactoryHolder h46EhFW6k0QmBx8jFkSL() => SessionFactoryHolder.KFeOlYW6Xw17mCqEX2Mw;

    internal static void jfqOuaW61i8oQyKjRyZ6([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object W9i5EbW6NTRsY28SiRmb([In] object obj0) => (object) ((ISessionFactory) obj0).Statistics;

    internal static void Eu5Gn5W63IQZjOoTr2FI([In] object obj0, [In] bool obj1) => ((IStatistics) obj0).IsStatisticsEnabled = obj1;

    internal static bool YngqrkW6pWTB2bQC8tum([In] object obj0) => ((NHManagerRegisterParams) obj0).HasItems;

    internal static void v5lQ5rW6aQlqfJxdVkqV([In] object obj0) => ((List<NHManagerRegisterParams>) obj0).Clear();

    internal static void SoE66XW6D9gj8VJ9dtv3([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void AT0A8QW6tZF8o7DFqtFB([In] object obj0) => ((Task) obj0).Wait();

    internal static TimeSpan NXqLuAW6w8BcecJia4Hs([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static void NfNCFDW64svkyUcJYy0Z([In] object obj0) => Monitor.Exit(obj0);

    internal static void sp021FW66tA3A6GrTAYU([In] object obj0, bool value) => ((SessionFactoryHolder.FreeObject) obj0).Closed = value;

    internal static void L4EfA2W6HHYjL5Zix3I6([In] object obj0) => ((Timer) obj0).Dispose();

    private class FreeObject
    {
      private static object ojT4t1QlxQcCUpOMMZwZ;

      public bool Closed
      {
        get => this.\u003CClosed\u003Ek__BackingField;
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
                this.\u003CClosed\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

      public List<string> Regions { get; set; }

      public FreeObject()
      {
        SessionFactoryHolder.FreeObject.ArLY1BQlylEqhQABrPTh();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool YTGEhOQl0TPjLxfrhGmb() => SessionFactoryHolder.FreeObject.ojT4t1QlxQcCUpOMMZwZ == null;

      internal static SessionFactoryHolder.FreeObject HyvDieQlm9Qe82w95KvU() => (SessionFactoryHolder.FreeObject) SessionFactoryHolder.FreeObject.ojT4t1QlxQcCUpOMMZwZ;

      internal static void ArLY1BQlylEqhQABrPTh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
