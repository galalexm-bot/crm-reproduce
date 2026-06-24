// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyCaptionViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Элемент отображения заголовка свойства</summary>
  [DisplayName(typeof (__Resources_PropertyCaptionViewItem), "DisplayName")]
  [Serializable]
  public class PropertyCaptionViewItem : PropertyViewItem
  {
    internal static PropertyCaptionViewItem GReLEloO5DIEhrOQPWHl;

    public override bool IsMainPropertyViewItem()
    {
      int num1 = 2;
      PropertyViewItem[] array;
      while (true)
      {
        int num2 = num1;
        Guid[] fullProperyUid;
        while (true)
        {
          FormViewItem formViewItem1;
          switch (num2)
          {
            case 1:
              if (!PropertyCaptionViewItem.LaowYBoOLLV8s5O7fkp5((object) this))
              {
                formViewItem1 = this.FormViewItem;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 12 : 12;
                continue;
              }
              num2 = 6;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
            case 3:
              if (array.Length == 0)
              {
                num2 = 9;
                continue;
              }
              goto default;
            case 4:
              if (array[0] == this)
              {
                num2 = 10;
                continue;
              }
              break;
            case 5:
              if (array.OfType<PropertyCaptionViewItem>().FirstOrDefault<PropertyCaptionViewItem>() == this)
              {
                num2 = 11;
                continue;
              }
              goto label_29;
            case 6:
              goto label_12;
            case 7:
              goto label_5;
            case 8:
              FormViewItem formViewItem2 = formViewItem1;
              // ISSUE: reference to a compiler-generated field
              Func<ViewItem, bool> func1 = PropertyCaptionViewItem.\u003C\u003Ec.\u003C\u003E9__0_1;
              Func<ViewItem, bool> deepCondition;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                PropertyCaptionViewItem.\u003C\u003Ec.\u003C\u003E9__0_1 = deepCondition = (Func<ViewItem, bool>) (i =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        if (!(i is PropertyViewItem))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  return !PropertyCaptionViewItem.\u003C\u003Ec.DDhWXbCfR0PRlQ4iqMVw((object) i);
label_5:
                  return true;
                });
              }
              else
                goto label_30;
label_23:
              array = formViewItem2.FindItems(false, (Func<ViewItem, bool>) (i => i is PropertyViewItem), deepCondition).Cast<PropertyViewItem>().Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
              {
                int num4 = 3;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      if (p.Hide)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_4;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (!PropertyCaptionViewItem.\u003C\u003Ec__DisplayClass0_0.iPCfM2CfuvPMWveOvfKY((object) p))
                      {
                        num4 = 2;
                        continue;
                      }
                      goto label_4;
                    default:
                      goto label_5;
                  }
                }
label_4:
                return ((IEnumerable<Guid>) fullProperyUid).SequenceEqual<Guid>(p.FullProperyUid());
label_5:
                return false;
              })).ToArray<PropertyViewItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 2;
              continue;
label_30:
              deepCondition = func1;
              goto label_23;
            case 9:
            case 10:
              goto label_24;
            case 11:
              goto label_28;
            case 12:
              if (formViewItem1 == null)
              {
                num2 = 7;
                continue;
              }
              goto label_6;
            default:
              if (array.Length == 1)
              {
                num2 = 4;
                continue;
              }
              break;
          }
          PropertyViewItem[] source = array;
          // ISSUE: reference to a compiler-generated field
          Func<PropertyViewItem, bool> func2 = PropertyCaptionViewItem.\u003C\u003Ec.\u003C\u003E9__0_3;
          Func<PropertyViewItem, bool> predicate;
          if (func2 == null)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            PropertyCaptionViewItem.\u003C\u003Ec.\u003C\u003E9__0_3 = predicate = (Func<PropertyViewItem, bool>) (p => !PropertyCaptionViewItem.\u003C\u003Ec.cshSvjCfqMjmM35MHZrA((object) p));
          }
          else
            goto label_21;
label_27:
          array = ((IEnumerable<PropertyViewItem>) source).Where<PropertyViewItem>(predicate).ToArray<PropertyViewItem>();
          num2 = 5;
          continue;
label_21:
          predicate = func2;
          goto label_27;
        }
label_6:
        fullProperyUid = this.FullProperyUid().ToArray<Guid>();
        num1 = 8;
      }
label_5:
      return true;
label_12:
      return false;
label_24:
      return true;
label_28:
      return ((IEnumerable<PropertyViewItem>) array).FirstOrDefault<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
      {
        int num5 = 2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_3;
            case 2:
              if (p is PropertyCaptionViewItem)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return !(p is PropertyDescriptionViewItem);
label_3:
        return false;
      })) is PropertyValueViewItem;
label_29:
      return false;
    }

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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
      return PropertyCaptionViewItem.pinHe2oOUdy53W8FhX8N((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => false;

    public PropertyCaptionViewItem()
    {
      PropertyCaptionViewItem.ThQltwoOsXtSo3ftAJd5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LaowYBoOLLV8s5O7fkp5([In] object obj0) => ((RootViewItem) obj0).IsReadOnly();

    internal static bool qeXG1GoOjUiriLXCXVrh() => PropertyCaptionViewItem.GReLEloO5DIEhrOQPWHl == null;

    internal static PropertyCaptionViewItem ObTHD0oOYZQGchFGdOZD() => PropertyCaptionViewItem.GReLEloO5DIEhrOQPWHl;

    internal static bool pinHe2oOUdy53W8FhX8N([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void ThQltwoOsXtSo3ftAJd5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
