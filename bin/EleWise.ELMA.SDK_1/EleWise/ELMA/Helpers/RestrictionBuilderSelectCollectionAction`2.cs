// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionBuilderSelectCollectionAction`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Helpers
{
  public class RestrictionBuilderSelectCollectionAction<T, T1> : RestrictionBuilderSelectAction<T> where T1 : class
  {
    public RestrictionBuilderSelectCollectionAction(
      RestrictionBuilderSelectType<T> baseRestrictionBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(baseRestrictionBuilder);
    }

    public void UpdateMode(Func<T1, T1, bool> comparer = null)
    {
      if (comparer == null)
        return;
      this.restriction.CompareFunction = (Func<object, object, bool>) ((x, y) =>
      {
        int num = 5;
        T1 obj1;
        T1 obj2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if ((object) obj1 != null)
              {
                num = 2;
                continue;
              }
              goto label_7;
            case 2:
              goto label_6;
            case 3:
              if ((object) obj2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 4:
              obj1 = y as T1;
              num = 3;
              continue;
            case 5:
              obj2 = x as T1;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 4;
              continue;
            default:
              goto label_7;
          }
        }
label_6:
        return comparer(obj2, obj1);
label_7:
        return false;
      });
    }

    public void UpdateMode(CollectionUpdateMode mode, Func<T1, T1, bool> comparer = null)
    {
      this.restriction.CollectionUpdateMode = new CollectionUpdateMode?(mode);
      this.UpdateMode(comparer);
    }
  }
}
