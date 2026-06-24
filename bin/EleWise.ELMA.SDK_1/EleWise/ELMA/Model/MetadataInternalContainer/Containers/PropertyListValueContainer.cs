// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyListValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>Контейнер коллекций</summary>
  internal sealed class PropertyListValueContainer : 
    PropertyCollectionValueContainer,
    IPropertyDefaultValueContainer
  {
    private static PropertyListValueContainer zyUim8hWmY24q73Xp3tf;

    /// <summary>Ctor</summary>
    /// <param name="tTarget">Тип интерфейса сущности</param>
    public PropertyListValueContainer(Type tTarget)
    {
      PropertyListValueContainer.tvf7eNhWJN4tWXcpSWZA();
      // ISSUE: explicit constructor call
      base.\u002Ector(tTarget);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
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
            type = PropertyListValueContainer.Y4tdU7hW9d9Vtl0IQ1NA(__typeref (PropertyListValueContainer.NestedDefaultValueContainer<>)).MakeGenericType(this.tTarget);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 0;
            continue;
          case 2:
            if (this.propContainer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            this.propContainer = (IPropertyDefaultValueContainer) Activator.CreateInstance(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (IPropertyValueContainer) PropertyListValueContainer.ei452lhWd64yiK8egK1A((object) this.propContainer);
    }

    internal static void tvf7eNhWJN4tWXcpSWZA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool diuBgYhWyXviH4RGZx4I() => PropertyListValueContainer.zyUim8hWmY24q73Xp3tf == null;

    internal static PropertyListValueContainer r4aoSuhWMACw83NhMMMe() => PropertyListValueContainer.zyUim8hWmY24q73Xp3tf;

    internal static Type Y4tdU7hW9d9Vtl0IQ1NA([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ei452lhWd64yiK8egK1A([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();

    private new class NestedDefaultValueContainer<T> : IPropertyDefaultValueContainer
    {
      private static object y1hxBoCdz6WgbxxSqHab;

      /// <summary>
      /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
      /// </summary>
      IPropertyValueContainer IPropertyDefaultValueContainer.Initialize() => (IPropertyValueContainer) new PropertyValueContainer<List<T>>(new List<T>());

      public NestedDefaultValueContainer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool xxlO1dClF5Pnrl1GLSbp() => PropertyListValueContainer.NestedDefaultValueContainer<T>.y1hxBoCdz6WgbxxSqHab == null;

      internal static object WUDpKYClBpS8OiYCoN5J() => PropertyListValueContainer.NestedDefaultValueContainer<T>.y1hxBoCdz6WgbxxSqHab;
    }
  }
}
