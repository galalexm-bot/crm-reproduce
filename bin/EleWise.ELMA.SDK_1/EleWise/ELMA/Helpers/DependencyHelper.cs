// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.DependencyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Signatures;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Хелпер зависимостей</summary>
  public static class DependencyHelper
  {
    /// <summary>Объединить списки зависимостей</summary>
    /// <remarks>
    /// Вернется новый экземпляр списка зависимостей. Переданные списки не будут изменены
    /// </remarks>
    /// <param name="dependencies">Список зависимостей</param>
    /// <typeparam name="T">Тип зависимости</typeparam>
    /// <returns>Новый список зависимостей</returns>
    public static IEnumerable<T> CombineDependencies<T>(IEnumerable<T> dependencies) where T : Dependency
    {
      List<T> objList = new List<T>();
      foreach (T dependency1 in dependencies)
      {
        T dependency = dependency1;
        T obj = objList.Find((Predicate<T>) (a => a.HeaderUid == dependency.HeaderUid));
        if ((object) obj == null)
        {
          objList.Add(dependency);
        }
        else
        {
          if (string.IsNullOrWhiteSpace(obj.Name) && !string.IsNullOrWhiteSpace(((T) dependency).Name))
            obj.Name = ((T) dependency).Name;
          if (string.IsNullOrWhiteSpace(obj.DisplayName) && !string.IsNullOrWhiteSpace(((T) dependency).DisplayName))
            obj.DisplayName = ((T) dependency).DisplayName;
        }
      }
      return (IEnumerable<T>) objList;
    }

    /// <summary>Объединить списки зависимостей от класса</summary>
    /// <remarks>
    /// Вернется новый экземпляр списка зависимостей. Переданные списки не будут изменены
    /// </remarks>
    /// <param name="dependencies">Список зависимостей</param>
    /// <typeparam name="T">Тип зависимости от класса</typeparam>
    /// <returns>Новый список зависимостей</returns>
    public static IEnumerable<T> CombineClassDependencies<T>(IEnumerable<T> dependencies) where T : ClassDependency
    {
      List<T> objList = new List<T>();
      foreach (T dependency1 in dependencies)
      {
        T dependency = dependency1;
        T obj = objList.Find((Predicate<T>) (a => a.HeaderUid == dependency.HeaderUid));
        if ((object) obj == null)
        {
          objList.Add(dependency);
        }
        else
        {
          if (string.IsNullOrWhiteSpace(obj.Name) && !string.IsNullOrWhiteSpace(((T) dependency).Name))
            obj.Name = ((T) dependency).Name;
          if (string.IsNullOrWhiteSpace(obj.DisplayName) && !string.IsNullOrWhiteSpace(((T) dependency).DisplayName))
            obj.DisplayName = ((T) dependency).DisplayName;
          foreach (PropertySignature property in ((T) dependency).Properties)
          {
            PropertySignature dependencyProperty = property;
            if (obj.Properties.Find((Predicate<PropertySignature>) (a =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    if (a.Uid == dependencyProperty.Uid)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  case 2:
                    goto label_2;
                  default:
                    goto label_3;
                }
              }
label_2:
              return a.Name == dependencyProperty.Name;
label_3:
              return true;
            })) == null)
              obj.Properties.Add(dependencyProperty);
          }
        }
      }
      return (IEnumerable<T>) objList;
    }
  }
}
