// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.FullTextSearchObjectContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System.Dynamic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Обертка передачи информации об объекте в полнотекстовом поиске
  /// </summary>
  internal sealed class FullTextSearchObjectContainer : IFullTextSearchObjectContainer
  {
    internal static FullTextSearchObjectContainer qR6V9UGiHfVjmuq1QmH7;

    /// <inheritdoc />
    public IFullTextSearchObject SearchObject
    {
      get => this.\u003CSearchObject\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSearchObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public IEntity IndexedObject
    {
      get => this.\u003CIndexedObject\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CIndexedObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public ExpandoObject Properties
    {
      get => this.\u003CProperties\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CProperties\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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

    public FullTextSearchObjectContainer()
    {
      FullTextSearchObjectContainer.l2w0kNGixq7NfQxVVP7C();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BMU2JdGiAej1utTEfhWO() => FullTextSearchObjectContainer.qR6V9UGiHfVjmuq1QmH7 == null;

    internal static FullTextSearchObjectContainer dEYi6JGi7e1crU5GyJDH() => FullTextSearchObjectContainer.qR6V9UGiHfVjmuq1QmH7;

    internal static void l2w0kNGixq7NfQxVVP7C() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
