// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.StringKeyLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Базовый класс для реализаций точек расширения, работающих со строковыми ключами
  /// </summary>
  public abstract class StringKeyLinkedFinder : LinkedFinderBase
  {
    private static StringKeyLinkedFinder cmvLmhfGQlF40nQX4cjT;

    /// <summary>Получение данных по идентификатору</summary>
    /// <param name="uidStr">Идентификатор искомых данных</param>
    /// <param name="context">Контекст проверки</param>
    /// <returns>Данные</returns>
    protected abstract object GetDataWithUidStr(string uidStr, LinkedObjectsContext context);

    /// <inheritdoc />
    protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context) => (IMetadata) null;

    /// <summary>Получить данные из контекста проверки</summary>
    /// <param name="uidStr">Ид данных</param>
    /// <param name="context">Контекст проверки</param>
    /// <returns>Данные</returns>
    protected object GetData(string uidStr, LinkedObjectsContext context)
    {
      int num1 = 7;
      object data;
      while (true)
      {
        int num2 = num1;
        string uidStr1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (data == null)
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 2:
            case 9:
              goto label_14;
            case 3:
              data = StringKeyLinkedFinder.ytgksEfG8vZgt31qfX4B((object) this, (object) uidStr1, (object) context);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_8;
            case 5:
              context.LoadedWithStringKey[uidStr1] = data;
              num2 = 2;
              continue;
            case 6:
              uidStr1 = uidStr;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              goto label_15;
            default:
              if (!context.LoadedWithStringKey.TryGetValue(uidStr1, out data))
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (context.AllObjects.OfType<StringKeyLinkedObject>().FirstOrDefault<StringKeyLinkedObject>((Func<StringKeyLinkedObject, bool>) (m => StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass2_0.k0J4yq8dk9kN0aKlFvIP(StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass2_0.auiDtg8dTYyYksDxGv2I((object) m), (object) uidStr1))) != null)
                  goto case 3;
                else
                  goto label_10;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 4;
                continue;
              }
          }
        }
label_10:
        num1 = 8;
      }
label_8:
      return data;
label_14:
      return data;
label_15:
      return (object) null;
    }

    /// <summary>
    /// Заполнить контекст проверки и результат. Отмечает элемент как связанный
    /// </summary>
    /// <param name="resultObj">Результат проверки</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="uidStr">Ид данных</param>
    protected void FillStrObj(
      FindLinkedObjectsResult resultObj,
      LinkedObjectsContext context,
      string uidStr)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IEnumerable<StringKeyLinkedObject> source1;
        IEnumerable<StringKeyLinkedObject> source2;
        string uidStr1;
        StringKeyLinkedObject obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              obj = source1.First<StringKeyLinkedObject>((Func<StringKeyLinkedObject, bool>) (item => StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.G0k1WN8d1lHQMrnTgCeK(StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.A5Hfea8dPLGC7wXRiFna((object) item), (object) uidStr1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (source2.All<StringKeyLinkedObject>((Func<StringKeyLinkedObject, bool>) (md => StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.M9HdxQ8dNFGkCRraWxcy(StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.A5Hfea8dPLGC7wXRiFna((object) md), (object) uidStr1))))
              {
                num2 = 11;
                continue;
              }
              goto label_20;
            case 3:
              resultObj.AddedObjects.Add((ILinkedObject) obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 4 : 4;
              continue;
            case 4:
              context.CheckedObjects.Add((ILinkedObject) obj);
              num2 = 5;
              continue;
            case 5:
              goto label_3;
            case 6:
              source1 = context.AllObjects.OfType<StringKeyLinkedObject>();
              num2 = 10;
              continue;
            case 7:
              uidStr1 = uidStr;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 2;
              continue;
            case 8:
              num2 = 7;
              continue;
            case 9:
              resultObj.LinkedObjects.Add((ILinkedObject) obj);
              num2 = 3;
              continue;
            case 10:
              source2 = context.CheckedObjects.OfType<StringKeyLinkedObject>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 12 : 7;
              continue;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            case 12:
              goto label_11;
            default:
              // ISSUE: reference to a compiler-generated method
              if (resultObj.LinkedObjects.OfType<StringKeyLinkedObject>().All<StringKeyLinkedObject>((Func<StringKeyLinkedObject, bool>) (item => item.UidStr != (string) StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_1.zmnqc28dtsTOdW1IgYkW((object) obj))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 9;
                continue;
              }
              goto case 3;
          }
        }
label_11:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (source1.Any<StringKeyLinkedObject>((Func<StringKeyLinkedObject, bool>) (item => StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.G0k1WN8d1lHQMrnTgCeK(StringKeyLinkedFinder.\u003C\u003Ec__DisplayClass3_0.A5Hfea8dPLGC7wXRiFna((object) item), (object) uidStr1))))
          num1 = 2;
        else
          goto label_19;
      }
label_3:
      return;
label_19:
      return;
label_20:;
    }

    protected StringKeyLinkedFinder()
    {
      StringKeyLinkedFinder.IcmCNyfGZljXfgfp3FKq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ytgksEfG8vZgt31qfX4B([In] object obj0, [In] object obj1, [In] object obj2) => ((StringKeyLinkedFinder) obj0).GetDataWithUidStr((string) obj1, (LinkedObjectsContext) obj2);

    internal static bool tdaIqSfGCnlLc8clY96Y() => StringKeyLinkedFinder.cmvLmhfGQlF40nQX4cjT == null;

    internal static StringKeyLinkedFinder hu2G5AfGvngErH3ZyHrr() => StringKeyLinkedFinder.cmvLmhfGQlF40nQX4cjT;

    internal static void IcmCNyfGZljXfgfp3FKq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
