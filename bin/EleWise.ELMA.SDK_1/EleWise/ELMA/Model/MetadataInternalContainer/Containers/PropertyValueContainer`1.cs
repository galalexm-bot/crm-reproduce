// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyValueContainer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер хранения данных свойства контейнерного объекта Объект или Простой тип
  /// </summary>
  public class PropertyValueContainer<T> : 
    IPropertyValueContainer<T>,
    IPropertyValueContainer,
    IPropertyDefaultValueContainer
  {
    private T value;
    internal Func<T> valueFactory;
    internal static object Wxsgp3hWLFV9BpSDsSWx;

    /// <summary>Ctor</summary>
    public PropertyValueContainer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="value">Объект контейнера</param>
    public PropertyValueContainer(T value)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.value = value;
    }

    /// <summary>Ctor</summary>
    /// <param name="valueFactory">Фабрика значения</param>
    public PropertyValueContainer(Func<T> valueFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.valueFactory = valueFactory;
    }

    T IPropertyValueContainer<T>.Get(object obj) => this.value;

    void IPropertyValueContainer<T>.Set(object obj, T value) => this.value = value;

    object IPropertyValueContainer.Get(object obj) => (object) this.value;

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
            this.value = (T) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    Type IPropertyValueContainer.PropertyType => TypeOf<T>.Raw;

    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.valueFactory == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      T obj = this.value;
      goto label_6;
label_5:
      obj = this.valueFactory();
label_6:
      return (IPropertyValueContainer) new PropertyValueContainer<T>(obj);
    }

    internal static bool o6E2b6hWUvkC58fkSYEV() => PropertyValueContainer<T>.Wxsgp3hWLFV9BpSDsSWx == null;

    internal static object y1SmJXhWsck5nVlIiXbW() => PropertyValueContainer<T>.Wxsgp3hWLFV9BpSDsSWx;
  }
}
