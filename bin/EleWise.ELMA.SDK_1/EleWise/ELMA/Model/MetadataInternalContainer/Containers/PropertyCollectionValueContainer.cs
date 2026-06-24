// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyCollectionValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>Контейнер коллекций</summary>
  internal class PropertyCollectionValueContainer : IPropertyDefaultValueContainer
  {
    protected internal readonly Type tTarget;
    protected IPropertyDefaultValueContainer propContainer;
    private static PropertyCollectionValueContainer w3mCR2hWNDgAauov65TH;

    /// <summary>Ctor</summary>
    /// <param name="tTarget">Тип интерфейса сущности</param>
    public PropertyCollectionValueContainer(Type tTarget)
    {
      PropertyCollectionValueContainer.V2HlJ0hWaGWfhp6B0u2v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.tTarget = tTarget;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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
    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num = 2;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            type = PropertyCollectionValueContainer.NgngUShWDWiS8c86t2Kc(__typeref (PropertyCollectionValueContainer.NestedDefaultValueContainer<>)).MakeGenericType(this.tTarget);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 3 : 1;
            continue;
          case 2:
            if (this.propContainer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            this.propContainer = (IPropertyDefaultValueContainer) PropertyCollectionValueContainer.vnNxWJhWtXkbIiSL2fBL(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IPropertyValueContainer) PropertyCollectionValueContainer.kNnw4jhWwXWWwNOe0BZN((object) this.propContainer);
    }

    internal static void V2HlJ0hWaGWfhp6B0u2v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool I4BK7HhW3jmFNGoiDmT6() => PropertyCollectionValueContainer.w3mCR2hWNDgAauov65TH == null;

    internal static PropertyCollectionValueContainer mMKX4MhWpfMEV2gO24DC() => PropertyCollectionValueContainer.w3mCR2hWNDgAauov65TH;

    internal static Type NgngUShWDWiS8c86t2Kc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object vnNxWJhWtXkbIiSL2fBL([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object kNnw4jhWwXWWwNOe0BZN([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

    private class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer
    {
      private static object YhjwSBCdwUAebSKLQghb;

      /// <summary>
      /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
      /// </summary>
      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (TypeOf<IEntity>.Raw.IsAssignableFrom(TypeOf<T>.Raw))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (IPropertyValueContainer) new PropertyValueContainer<ICollection<T>>((ICollection<T>) new HashedSet<T>());
label_5:
        return (IPropertyValueContainer) new PropertyValueContainer<ICollection<T>>((ICollection<T>) new List<T>());
      }

      public NestedDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool xtC02UCd4x59Zf2U3TAM() => PropertyCollectionValueContainer.NestedDefaultValueContainer<T>.YhjwSBCdwUAebSKLQghb == null;

      internal static object uGHnIWCd6RwRLI3R2Oi6() => PropertyCollectionValueContainer.NestedDefaultValueContainer<T>.YhjwSBCdwUAebSKLQghb;
    }
  }
}
