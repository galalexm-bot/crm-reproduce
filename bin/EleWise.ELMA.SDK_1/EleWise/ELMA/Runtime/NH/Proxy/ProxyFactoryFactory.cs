// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Proxy.ProxyFactoryFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Bytecode;
using NHibernate.Engine;
using NHibernate.Proxy;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Proxy
{
  /// <summary>Фабрика создания экземпляров IProxyFactory</summary>
  public class ProxyFactoryFactory : IProxyFactoryFactory
  {
    internal static ProxyFactoryFactory WJErgUWARJLn09EZrugl;

    IProxyValidator IProxyFactoryFactory.ProxyValidator => (IProxyValidator) new ProxyFactoryFactory.DynamicProxyTypeValidator();

    IProxyFactory IProxyFactoryFactory.BuildProxyFactory() => (IProxyFactory) new ProxyFactoryFactory.ProxyFactory();

    bool IProxyFactoryFactory.IsInstrumented(System.Type entityClass) => true;

    bool IProxyFactoryFactory.IsProxy(object obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (obj is IEntityProxy entityProxy)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return obj is INHibernateProxy;
label_5:
      return ProxyFactoryFactory.OC6gEGWAX0YfimWNibPA((object) entityProxy) != null;
    }

    public ProxyFactoryFactory()
    {
      ProxyFactoryFactory.Slj4m0WATdyL753cOYqO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object OC6gEGWAX0YfimWNibPA([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static bool p3OHO3WAqryiyeNrZUvw() => ProxyFactoryFactory.WJErgUWARJLn09EZrugl == null;

    internal static ProxyFactoryFactory BXvKYRWAKblqZwItpCY0() => ProxyFactoryFactory.WJErgUWARJLn09EZrugl;

    internal static void Slj4m0WATdyL753cOYqO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class DynamicProxyTypeValidator : DynProxyTypeValidator, IProxyValidator
    {
      private static object ebPikQQr7eqovFmrJXxZ;

      ICollection<string> IProxyValidator.ValidateType(System.Type type) => !TypeOf<IValueContainerObjectInternal>.Raw.IsAssignableFrom(type) ? this.ValidateType(type) : (ICollection<string>) null;

      public override bool IsProxeable(MethodInfo method)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (method != (MethodInfo) null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return base.IsProxeable(method);
label_5:
        return false;
      }

      public DynamicProxyTypeValidator()
      {
        ProxyFactoryFactory.DynamicProxyTypeValidator.O2ntajQrmYj1Yc7LJLT3();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool rDRGCvQrxx77Gl7qmKP1() => ProxyFactoryFactory.DynamicProxyTypeValidator.ebPikQQr7eqovFmrJXxZ == null;

      internal static ProxyFactoryFactory.DynamicProxyTypeValidator aG4051Qr01YhdV7snMgR() => (ProxyFactoryFactory.DynamicProxyTypeValidator) ProxyFactoryFactory.DynamicProxyTypeValidator.ebPikQQr7eqovFmrJXxZ;

      internal static void O2ntajQrmYj1Yc7LJLT3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    private class ProxyFactory : IProxyFactory
    {
      private object proxyFactory;
      private static object EynQfTQryGvpvY2U0QF0;

      public void PostInstantiate(
        string entityName,
        System.Type persistentClass,
        ISet<System.Type> interfaces,
        MethodInfo getIdentifierMethod,
        MethodInfo setIdentifierMethod,
        IAbstractComponentType componentIdType)
      {
        this.proxyFactory = TypeOf<IValueContainerObjectInternal>.Raw.IsAssignableFrom(persistentClass) ? (object) new ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory() : (object) new StaticProxyFactory();
        ((IProxyFactory) this.proxyFactory).PostInstantiate(entityName, persistentClass, interfaces, getIdentifierMethod, setIdentifierMethod, componentIdType);
      }

      public object GetFieldInterceptionProxy(object instanceToWrap) => ProxyFactoryFactory.ProxyFactory.FlovKtQr96QXFb3Jiope(this.proxyFactory);

      public INHibernateProxy GetProxy(object id, ISessionImplementor session) => ((IProxyFactory) this.proxyFactory).GetProxy(id, session);

      public ProxyFactory()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object FlovKtQr96QXFb3Jiope([In] object obj0) => ((IProxyFactory) obj0).GetFieldInterceptionProxy();

      internal static bool JWW9PlQrMlyxUrwYAnGi() => ProxyFactoryFactory.ProxyFactory.EynQfTQryGvpvY2U0QF0 == null;

      internal static ProxyFactoryFactory.ProxyFactory I0SO6RQrJk4i3XXZlL6T() => (ProxyFactoryFactory.ProxyFactory) ProxyFactoryFactory.ProxyFactory.EynQfTQryGvpvY2U0QF0;

      private class ValueContainerProxyFactory : IProxyFactory
      {
        private object entityName;
        private System.Type persistentClass;
        internal static object aYuTbRZuD9nqGtexpXQW;

        public object GetFieldInterceptionProxy(object instanceToWrap) => throw new NotImplementedException();

        public void PostInstantiate(
          string entityName,
          System.Type persistentClass,
          ISet<System.Type> interfaces,
          MethodInfo getIdentifierMethod,
          MethodInfo setIdentifierMethod,
          IAbstractComponentType componentIdType)
        {
          this.entityName = (object) entityName;
          this.persistentClass = persistentClass;
        }

        public INHibernateProxy GetProxy(object id, ISessionImplementor session) => (INHibernateProxy) ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.SYIBmEZu6tSyGVwV5dfI((object) (IEntityProxy) ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.Bhq1KyZu4HF3puJEkgGZ(this.persistentClass), (object) new ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.LazyInitializer(this.persistentClass, (string) this.entityName, id, session));

        public ValueContainerProxyFactory()
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object Bhq1KyZu4HF3puJEkgGZ([In] System.Type obj0) => Activator.CreateInstance(obj0);

        internal static object SYIBmEZu6tSyGVwV5dfI([In] object obj0, [In] object obj1) => (object) ((IEntityProxy) obj0).InitLazyInitializer((ILazyInitializer) obj1);

        internal static bool hQejL5ZutQsSiUTVBiHe() => ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.aYuTbRZuD9nqGtexpXQW == null;

        internal static ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory amD4Y2ZuwmBUh2Mh9MJX() => (ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory) ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.aYuTbRZuD9nqGtexpXQW;

        [Serializable]
        private class LazyInitializer : AbstractLazyInitializer
        {
          private static object PaBRlYZpnxoXaYmPWp14;

          public LazyInitializer(
            System.Type persistentClass,
            string entityName,
            object id,
            ISessionImplementor session)
          {
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            // ISSUE: explicit constructor call
            base.\u002Ector(entityName, id, session);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                default:
                  this.PersistentClass = persistentClass;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                  continue;
              }
            }
label_3:;
          }

          public override System.Type PersistentClass { get; }

          internal static bool QgvsKSZpOBUCVGjlpAjx() => ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.LazyInitializer.PaBRlYZpnxoXaYmPWp14 == null;

          internal static ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.LazyInitializer e12r5wZp2KRsnve6M1vH() => (ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.LazyInitializer) ProxyFactoryFactory.ProxyFactory.ValueContainerProxyFactory.LazyInitializer.PaBRlYZpnxoXaYmPWp14;
        }
      }
    }
  }
}
