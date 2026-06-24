// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertySetValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер-обертка хранения данных свойства контейнерного объекта Список объектов
  /// </summary>
  internal class PropertySetValueContainer : IPropertyDefaultValueContainer
  {
    private readonly PropertyMetadata propertyMetadata;
    private readonly Type tInterface;
    private readonly bool forFilter;
    private IPropertyDefaultValueContainer propContainer;
    private static PropertySetValueContainer Wp6F1PhWc2jDP69Nrcgp;

    /// <summary>Ctor</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="tInterface">Тип интерфейса сущности</param>
    /// <param name="forFilter"><c>true</c> если для фильтра</param>
    public PropertySetValueContainer(
      PropertyMetadata propertyMetadata,
      Type tInterface,
      bool forFilter)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.tInterface = tInterface;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.propertyMetadata = propertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
            continue;
          default:
            this.forFilter = forFilter;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
    /// </summary>
    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num = 4;
      Type typeByUid;
      Type type1;
      Type type2;
      IComparer comparer;
      while (true)
      {
        switch (num)
        {
          case 1:
            comparer = this.propertyMetadata.CreateComparer();
            num = 2;
            continue;
          case 2:
            this.propContainer = (IPropertyDefaultValueContainer) Activator.CreateInstance(type2, (object) comparer);
            num = 9;
            continue;
          case 3:
          case 9:
          case 10:
            goto label_10;
          case 4:
            if (this.propContainer != null)
            {
              num = 3;
              continue;
            }
            goto case 8;
          case 5:
            // ISSUE: type reference
            type1 = PropertySetValueContainer.aONSGShoBoa7HkN7FVSL(__typeref (PropertySetValueContainer.NestedDefaultValueContainer<>)).MakeGenericType(this.tInterface);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 6;
            continue;
          case 6:
            this.propContainer = (IPropertyDefaultValueContainer) PropertySetValueContainer.qhsr7LhoWWP82joOqVR4(type1);
            num = 10;
            continue;
          case 7:
            typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(PropertySetValueContainer.s2nFLphooeXTdrpuiSY3((object) this.propertyMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 8:
            if (this.forFilter)
            {
              num = 5;
              continue;
            }
            goto case 7;
          default:
            // ISSUE: type reference
            type2 = PropertySetValueContainer.aONSGShoBoa7HkN7FVSL(__typeref (PropertySetValueContainer.NestedDefaultValueContainer<,>)).MakeGenericType(typeByUid, this.tInterface);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
            continue;
        }
      }
label_10:
      return this.propContainer.Initialize();
    }

    internal static bool m1OLGbhWzbL9MkNOBHl5() => PropertySetValueContainer.Wp6F1PhWc2jDP69Nrcgp == null;

    internal static PropertySetValueContainer QpQn3whoFvMtaxTMoNGV() => PropertySetValueContainer.Wp6F1PhWc2jDP69Nrcgp;

    internal static Type aONSGShoBoa7HkN7FVSL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object qhsr7LhoWWP82joOqVR4([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static Guid s2nFLphooeXTdrpuiSY3([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    private class NestedValueContainer<TClass, TInterface> : 
      IPropertyValueContainer<Iesi.Collections.Generic.ISet<TClass>>,
      IPropertyValueContainer
      where TClass : class
      where TInterface : class
    {
      private Iesi.Collections.Generic.ISet<TClass> value;
      private static object OOytdmClWRq3JKOSC4x8;

      internal NestedValueContainer(Iesi.Collections.Generic.ISet<TClass> value)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.Set((object) null, value);
      }

      public Iesi.Collections.Generic.ISet<TClass> Get(object obj) => this.value;

      public void Set(object obj, Iesi.Collections.Generic.ISet<TClass> value) => this.value = WrappedSetHelper.Wrap<TClass, TInterface>(value);

      object IPropertyValueContainer.Get(object obj) => (object) this.Get(obj);

      void IPropertyValueContainer.Set(object obj, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Set(obj, (Iesi.Collections.Generic.ISet<TClass>) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      Type IPropertyValueContainer.PropertyType => TypeOf<Iesi.Collections.Generic.ISet<TClass>>.Raw;

      internal static bool tyrhIuClo7TPQJbDFFJt() => PropertySetValueContainer.NestedValueContainer<TClass, TInterface>.OOytdmClWRq3JKOSC4x8 == null;

      internal static object RnAsCQClb5hCr5sWu2fd() => PropertySetValueContainer.NestedValueContainer<TClass, TInterface>.OOytdmClWRq3JKOSC4x8;
    }

    private class NestedDefaultValueContainer<TClass, TInterface> : IPropertyDefaultValueContainer
      where TClass : class
      where TInterface : class
    {
      private readonly IComparer<TClass> comparer;
      private static object EMBF9xClhc9RAtBfWgCk;

      public NestedDefaultValueContainer(IComparer<TClass> comparer)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.comparer = comparer;
      }

      /// <summary>
      /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
      /// </summary>
      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
      {
        int num = 3;
        Iesi.Collections.Generic.ISet<TClass> set1;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              set1 = (Iesi.Collections.Generic.ISet<TClass>) new HashedSet<TClass>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 4 : 1;
              continue;
            case 3:
              if (this.comparer == null)
              {
                num = 2;
                continue;
              }
              break;
            case 4:
              goto label_7;
          }
          set1 = (Iesi.Collections.Generic.ISet<TClass>) new IesiSortedSet<TClass>(this.comparer);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
        }
label_6:
        Iesi.Collections.Generic.ISet<TClass> set2 = set1;
        goto label_8;
label_7:
        set2 = set1;
label_8:
        return (IPropertyValueContainer) new PropertySetValueContainer.NestedValueContainer<TClass, TInterface>(set2);
      }

      internal static bool CNsShRClGOEn82xm5j6o() => PropertySetValueContainer.NestedDefaultValueContainer<TClass, TInterface>.EMBF9xClhc9RAtBfWgCk == null;

      internal static object fPr1iNClE2N7gQDjOebi() => PropertySetValueContainer.NestedDefaultValueContainer<TClass, TInterface>.EMBF9xClhc9RAtBfWgCk;
    }

    private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer where T : class
    {
      private static object VKoJnKClficuaYw508JS;

      /// <summary>
      /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
      /// </summary>
      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyValueContainer<Iesi.Collections.Generic.ISet<T>>((Iesi.Collections.Generic.ISet<T>) new HashedSet<T>());

      public NestedDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool zrrC8oClQq2PDbUOVLdD() => PropertySetValueContainer.NestedDefaultValueContainer<T>.VKoJnKClficuaYw508JS == null;

      internal static object tymcqVClCJtOcVEOFDvr() => PropertySetValueContainer.NestedDefaultValueContainer<T>.VKoJnKClficuaYw508JS;
    }
  }
}
