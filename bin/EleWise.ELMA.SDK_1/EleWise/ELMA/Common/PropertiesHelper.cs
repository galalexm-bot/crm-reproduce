// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.PropertiesHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common
{
  /// <summary>
  /// Класс хелпера для загрузки/выгрузки свойств объекта из сериализуемого контейнера
  /// </summary>
  public class PropertiesHelper
  {
    private Func<PropertyInfo, bool> condition;
    internal static PropertiesHelper BDkuDPfVEYDjJMeUetNn;

    /// <summary>Тип объекта</summary>
    public Type Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    /// <summary>Геттеры</summary>
    public Dictionary<string, Func<object, object>> GetActions { get; private set; }

    /// <summary>Сеттеры</summary>
    public Dictionary<string, Action<object, object>> SetActions { get; private set; }

    /// <summary>Список всех свойств</summary>
    public PropertyInfo[] PropertyInfos
    {
      get => this.\u003CPropertyInfos\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPropertyInfos\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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
    /// Условие выбора свойств для компиляции геттеров и сеттеров
    /// </summary>
    public Func<PropertyInfo, bool> Condition
    {
      get => this.condition;
      private set
      {
        this.condition = value;
        foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) this.PropertyInfos).Where<PropertyInfo>((Func<PropertyInfo, bool>) (propertyInfo => this.condition(propertyInfo))))
        {
          this.GetActions[propertyInfo.Name] = this.GetValueGetter(propertyInfo);
          this.SetActions[propertyInfo.Name] = this.GetValueSetter(propertyInfo);
        }
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="type"></param>
    public PropertiesHelper(Type type)
    {
      PropertiesHelper.Hm3wnCfVCwKCxlPw8tOe();
      this.condition = (Func<PropertyInfo, bool>) (a => true);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Type = type;
            num = 2;
            continue;
          case 2:
            this.GetActions = new Dictionary<string, Func<object, object>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 3:
            this.PropertyInfos = (PropertyInfo[]) PropertiesHelper.PLETk9fVvI8e9USCHH5h(this.Type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
            num = 4;
            continue;
          case 4:
            goto label_3;
          default:
            this.SetActions = new Dictionary<string, Action<object, object>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    public PropertiesHelper(
      Type type,
      Expression<Func<PropertyInfo, bool>> propertiesSelectCondition)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(type);
      this.Condition = propertiesSelectCondition != null ? propertiesSelectCondition.Compile() : (Func<PropertyInfo, bool>) (a => true);
    }

    /// <summary>
    /// Записать значения свойств объекта obj, удовлетворяющих условию Condition, в контейнер properties
    /// </summary>
    /// <param name="properties"></param>
    /// <param name="obj"></param>
    public void GetValues(PropertiesContainer properties, object obj)
    {
      int num1 = 2;
      Dictionary<string, Func<object, object>>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.GetActions.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_16:
      return;
label_12:
      return;
label_2:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_4;
        else
          goto label_11;
label_3:
        KeyValuePair<string, Func<object, object>> current;
        int num2;
        while (true)
        {
          Func<object, object> func;
          switch (num2)
          {
            case 1:
              if (func == null)
              {
                num2 = 6;
                continue;
              }
              break;
            case 2:
            case 6:
              goto label_10;
            case 3:
              goto label_9;
            case 4:
              func = current.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
            case 5:
              goto label_4;
          }
          properties[current.Key] = func(obj.CastAs(this.Type));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 1;
        }
label_9:
        return;
label_4:
        current = enumerator.Current;
        num2 = 4;
        goto label_3;
label_11:
        num2 = 3;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>
    /// Записать значения свойств из контейнера properties в объект obj, если свойства obj удовлетворяют условию Condition
    /// </summary>
    /// <param name="properties"></param>
    /// <param name="obj"></param>
    public void SetValues(PropertiesContainer properties, object obj)
    {
      int num1 = 2;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_2;
          case 2:
            enumerator = properties.GetProperties().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_16:
      return;
label_11:
      return;
label_2:
      try
      {
label_4:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_5;
label_3:
        string current;
        Action<object, object> action;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_10;
            case 3:
              action(PropertiesHelper.bsvjAMfV8UpZoYKiXZyo(obj, this.Type), PropertiesHelper.H5TG8QfVZqp7IbCPTVVf((object) properties, (object) current));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_6;
            case 5:
              if (!this.SetActions.TryGetValue(current, out action))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            default:
              goto label_4;
          }
        }
label_6:
        return;
label_5:
        num2 = 4;
        goto label_3;
label_10:
        current = enumerator.Current;
        num2 = 5;
        goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_18;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_18:;
      }
    }

    /// <summary>Получить геттер для свойства</summary>
    /// <param name="propertyInfo"></param>
    /// <returns></returns>
    protected virtual Func<object, object> GetValueGetter(PropertyInfo propertyInfo)
    {
      if (!propertyInfo.CanRead)
        return (Func<object, object>) null;
      return ((Expression<Func<object, object>>) (obj => (object) Expression.Call((Expression) Expression.Convert(obj, this.Type), propertyInfo.GetGetMethod()))).Compile();
    }

    /// <summary>Получить сеттер для свойства</summary>
    /// <param name="propertyInfo"></param>
    /// <returns></returns>
    protected virtual Action<object, object> GetValueSetter(PropertyInfo propertyInfo)
    {
      if (!propertyInfo.CanWrite)
        return (Action<object, object>) null;
      ParameterExpression parameterExpression1;
      ParameterExpression parameterExpression2;
      return Expression.Lambda<Action<object, object>>((Expression) Expression.Call((Expression) Expression.Convert((Expression) parameterExpression1, this.Type), propertyInfo.GetSetMethod(), (Expression) Expression.Convert((Expression) parameterExpression2, propertyInfo.PropertyType)), parameterExpression1, parameterExpression2).Compile();
    }

    internal static bool HqJAU2fVfNCsA2QGIJsC() => PropertiesHelper.BDkuDPfVEYDjJMeUetNn == null;

    internal static PropertiesHelper ESf4ctfVQUwLWmIeytDp() => PropertiesHelper.BDkuDPfVEYDjJMeUetNn;

    internal static void Hm3wnCfVCwKCxlPw8tOe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object PLETk9fVvI8e9USCHH5h(Type type, BindingFlags bindingAttr) => (object) type.GetReflectionProperties(bindingAttr);

    internal static object bsvjAMfV8UpZoYKiXZyo([In] object obj0, Type neededType) => obj0.CastAs(neededType);

    internal static object H5TG8QfVZqp7IbCPTVVf([In] object obj0, [In] object obj1) => ((PropertiesContainer) obj0)[(string) obj1];
  }
}
