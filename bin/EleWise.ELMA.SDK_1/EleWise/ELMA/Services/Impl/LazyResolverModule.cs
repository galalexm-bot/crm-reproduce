// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.LazyResolverModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Impl
{
  /// <summary>Модуль ленивого разрешения зависимостей</summary>
  public class LazyResolverModule : Module
  {
    internal static LazyResolverModule dIfCxWBMbVKhP4GKTKv7;

    /// <inheritdoc />
    protected override void Load(ContainerBuilder builder)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            builder.RegisterGeneric(LazyResolverModule.OI6vfvBMEhhc12NXp0tj(__typeref (LazyResolverModule.AutofacEnumerableLazyResolver<>))).As(typeof (IEnumerableLazy<>)).InstancePerDependency();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            builder.RegisterGeneric(LazyResolverModule.OI6vfvBMEhhc12NXp0tj(__typeref (LazyResolverModule.AutofacLazyResolver<>))).As(typeof (ILazy<>)).InstancePerDependency();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            LazyResolverModule.Th6VpUBMffs8ODdwAkH2((object) this, (object) builder);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    public LazyResolverModule()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type OI6vfvBMEhhc12NXp0tj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void Th6VpUBMffs8ODdwAkH2([In] object obj0, [In] object obj1) => __nonvirtual (((Module) obj0).Load((ContainerBuilder) obj1));

    internal static bool aUo0N3BMhacU6cckEdpN() => LazyResolverModule.dIfCxWBMbVKhP4GKTKv7 == null;

    internal static LazyResolverModule VPSa46BMGwUawbTmQ6mk() => LazyResolverModule.dIfCxWBMbVKhP4GKTKv7;

    /// <inheritdoc />
    private class AutofacLazyResolver<T> : ILazy<T> where T : class
    {
      private readonly IContainer container;
      private T value;
      private static object aQwLjvQONKDCcynek78O;

      /// <summary>ctor</summary>
      /// <param name="container">Контейнер Autofac</param>
      public AutofacLazyResolver(IContainer container)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.container = container;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <inheritdoc />
      public bool IsRegistered
      {
        get
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if ((object) this.value == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              default:
                goto label_4;
            }
          }
label_4:
          return this.container.IsRegistered<T>();
label_5:
          return true;
        }
      }

      /// <inheritdoc />
      public T Value => this.value ?? (this.value = this.container.Resolve<T>());

      internal static bool pOk01mQO3ZER1OVANMfk() => LazyResolverModule.AutofacLazyResolver<T>.aQwLjvQONKDCcynek78O == null;

      internal static object CsfGdjQOpxXiItA8eMIl() => LazyResolverModule.AutofacLazyResolver<T>.aQwLjvQONKDCcynek78O;
    }

    /// <inheritdoc />
    private class AutofacEnumerableLazyResolver<T> : IEnumerableLazy<T>, ILazy<IEnumerable<T>> where T : class
    {
      private readonly IContainer container;
      private IEnumerable<T> value;
      internal static object ApMrBwQOajBE0dpIe2eZ;

      /// <summary>ctor</summary>
      /// <param name="container">Контейнер Autofac</param>
      public AutofacEnumerableLazyResolver(IContainer container)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.container = container;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public bool IsRegistered
      {
        get
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!this.value.Any<T>())
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
                  continue;
                }
                goto label_7;
              case 2:
                if (this.value != null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
                  continue;
                }
                goto label_6;
              default:
                goto label_6;
            }
          }
label_6:
          return this.container.IsRegistered<T>();
label_7:
          return true;
        }
      }

      /// <inheritdoc />
      public IEnumerable<T> Value
      {
        get
        {
          if (this.value != null)
            return this.value;
          IEnumerable<T> source = this.container.Resolve<IEnumerable<T>>();
          if (source.Any<T>())
            this.value = source;
          return source;
        }
      }

      internal static bool iC8NLZQODIdwtkFJW92W() => LazyResolverModule.AutofacEnumerableLazyResolver<T>.ApMrBwQOajBE0dpIe2eZ == null;

      internal static object OxEWQqQOtqvjVDoXWlWw() => LazyResolverModule.AutofacEnumerableLazyResolver<T>.ApMrBwQOajBE0dpIe2eZ;
    }
  }
}
