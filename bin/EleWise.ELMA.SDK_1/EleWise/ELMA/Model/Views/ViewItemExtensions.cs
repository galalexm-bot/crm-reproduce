// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  public static class ViewItemExtensions
  {
    private static ViewItemExtensions YhLCfmoKWWZ3Q35sl60i;

    /// <summary>Проверка ReadOnly у ViewItem, с учетом родителей</summary>
    /// <param name="viewItem">Элемент представления</param>
    /// <returns><c>true</c>, если элемент представления только для чтения</returns>
    public static bool IsReadOnly(this ViewItem viewItem)
    {
      int num = 1;
      bool? nullable1;
      bool? nullable2;
      while (true)
      {
        bool? nullable3;
        bool? nullable4;
        bool? nullable5;
        switch (num)
        {
          case 1:
            if (!(viewItem is IReadOnlyViewItem readOnlyViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            nullable4 = readOnlyViewItem.ReadOnly;
            break;
          case 2:
            if (nullable1.HasValue)
            {
              num = 3;
              continue;
            }
            goto label_6;
          case 3:
            goto label_7;
          case 4:
            goto label_6;
          case 5:
            if (!nullable2.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 5 : 7;
              continue;
            }
            goto label_8;
          case 6:
            nullable5 = nullable3;
            goto label_24;
          case 7:
            if (viewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 8 : 1;
              continue;
            }
            RootViewItem parent = viewItem.Parent;
            if (parent == null)
            {
              num = 9;
              continue;
            }
            nullable5 = new bool?(ViewItemExtensions.cUE0gIoKhxfZKHjPFU2E((object) parent));
            goto label_24;
          case 8:
            nullable3 = new bool?();
            num = 6;
            continue;
          case 9:
            nullable3 = new bool?();
            num = 11;
            continue;
          case 10:
            nullable4 = nullable1;
            break;
          case 11:
            nullable5 = nullable3;
            goto label_24;
          default:
            nullable1 = new bool?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 10 : 6;
            continue;
        }
        nullable2 = nullable4;
        num = 5;
        continue;
label_24:
        nullable1 = nullable5;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
      }
label_6:
      return false;
label_7:
      return nullable1.GetValueOrDefault();
label_8:
      return nullable2.GetValueOrDefault();
    }

    internal static bool cUE0gIoKhxfZKHjPFU2E([In] object obj0) => ((RootViewItem) obj0).IsReadOnly();

    internal static bool lJVLA7oKoGZ7ga97MSUN() => ViewItemExtensions.YhLCfmoKWWZ3Q35sl60i == null;

    internal static ViewItemExtensions BuODZWoKbHCaFEFNEjr3() => ViewItemExtensions.YhLCfmoKWWZ3Q35sl60i;
  }
}
