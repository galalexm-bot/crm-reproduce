// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Utils.DeployUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy.Utils
{
  /// <summary>Вспомогательные методы для экспорта/импорта</summary>
  public static class DeployUtils
  {
    /// <summary>Потокобезопасно получить часть данных из списка.</summary>
    /// <typeparam name="T">Тип элемента коллекции</typeparam>
    /// <param name="source">Исходный список</param>
    /// <param name="offset">Количество записей, которые нужно пропустить</param>
    /// <param name="count">Максимальное количество сообщений, которые надо получить. 0 - чтобы получить все</param>
    /// <remarks>Работает, если в коллекцию данные только добавляются, не удаляются</remarks>
    /// <returns>Список, который содержит оставшиеся записи из исходного списка</returns>
    internal static IEnumerable<T> SafeSkip<T>(List<T> source, int offset, int count)
    {
      if (source == null)
        return (IEnumerable<T>) null;
      int length = source.Count - offset;
      if (count > 0)
        length = Math.Min(length, count);
      if (length <= 0)
        return Enumerable.Empty<T>();
      T[] array = new T[length];
      source.CopyTo(offset, array, 0, length);
      return (IEnumerable<T>) array;
    }

    /// <summary>Сортировка по зависимостям для правильной установки</summary>
    /// <param name="manifests">Список манифестов</param>
    public static List<ElmaStoreComponentManifest> SortComponentsByDependencies(
      List<ElmaStoreComponentManifest> manifests)
    {
      return manifests.OrderByDependencies<ElmaStoreComponentManifest>((Func<ElmaStoreComponentManifest, ElmaStoreComponentManifest, bool>) ((left, right) =>
      {
        int num1 = 3;
        ElmaStoreComponentManifest right1;
        while (true)
        {
          List<ElmaStoreComponentDependency> componentDependencyList;
          switch (num1)
          {
            case 1:
              goto label_6;
            case 2:
              right1 = right;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 4 : 5;
              continue;
            case 3:
              num1 = 2;
              continue;
            case 4:
              goto label_7;
            case 5:
              if (left == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              }
              componentDependencyList = left.Dependencies;
              break;
            default:
              componentDependencyList = (List<ElmaStoreComponentDependency>) null;
              break;
          }
          if (componentDependencyList == null)
            num1 = 4;
          else
            break;
        }
label_6:
        return left.Dependencies.Any<ElmaStoreComponentDependency>((Func<ElmaStoreComponentDependency, bool>) (d =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (d != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 2:
                goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          object obj = (object) null;
          goto label_6;
label_5:
          // ISSUE: reference to a compiler-generated method
          obj = DeployUtils.\u003C\u003Ec__DisplayClass1_0.KvmkjF8292hguJNPYkC2((object) d);
label_6:
          string id = right1?.Id;
          // ISSUE: reference to a compiler-generated method
          return DeployUtils.\u003C\u003Ec__DisplayClass1_0.J9TggT82dsbUyBMEE2vE(obj, (object) id);
        }));
label_7:
        return false;
      })).ToList<ElmaStoreComponentManifest>();
    }
  }
}
