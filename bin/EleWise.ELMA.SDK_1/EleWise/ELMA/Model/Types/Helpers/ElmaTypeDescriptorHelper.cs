// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ElmaTypeDescriptorHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Types.Helpers
{
  /// <summary>Сервис работы с дескрипторами</summary>
  internal static class ElmaTypeDescriptorHelper
  {
    private static ConcurrentDictionary<Type, TypeConverter> convertersMap;
    private static ElmaTypeDescriptorHelper EndwQ8boi4dAATFaCiV4;

    /// <summary>Получить преобразователь по типу</summary>
    /// <param name="type">Тип</param>
    /// <returns>Конвертер</returns>
    public static TypeConverter GetConverter(Type type)
    {
      int num = 1;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            type1 = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      return ElmaTypeDescriptorHelper.convertersMap.GetOrAdd(type1, (Func<Type, TypeConverter>) (t => System.ComponentModel.TypeDescriptor.GetConverter(type1)));
    }

    static ElmaTypeDescriptorHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ElmaTypeDescriptorHelper.convertersMap = new ConcurrentDictionary<Type, TypeConverter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            ElmaTypeDescriptorHelper.aOYn26boKh7b8EXBaDLw();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool Y99KnwboRe0M7jbIbFdG() => ElmaTypeDescriptorHelper.EndwQ8boi4dAATFaCiV4 == null;

    internal static ElmaTypeDescriptorHelper BSSJuOboqN3jf0H1Wm3s() => ElmaTypeDescriptorHelper.EndwQ8boi4dAATFaCiV4;

    internal static void aOYn26boKh7b8EXBaDLw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
