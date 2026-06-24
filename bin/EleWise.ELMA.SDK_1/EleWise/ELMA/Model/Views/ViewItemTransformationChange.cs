// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformationChange
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ViewItemTransformationChange : ViewItemTransformation
  {
    internal static ViewItemTransformationChange wkweMVoPAmbNaEmVKHmP;

    public string PropertyName
    {
      get => this.\u003CPropertyName\u003Ek__BackingField;
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
              this.\u003CPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    [XmlAttribute("Type")]
    [DefaultValue("")]
    public string TypeName
    {
      get => this.\u003CTypeName\u003Ek__BackingField;
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
              this.\u003CTypeName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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

    /// <summary>Признак, что свойство локализуемое</summary>
    [DefaultValue(false)]
    public bool Localizable
    {
      get => this.\u003CLocalizable\u003Ek__BackingField;
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
              this.\u003CLocalizable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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

    public override void Apply(ViewItem formViewItem)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ViewItem viewItem;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_4;
            case 3:
              goto label_14;
            case 4:
              goto label_15;
            case 5:
              if (viewItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 6:
              if (!(this.Value is ComputedValueTransformation valueTransformation))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 4;
                continue;
              }
              goto label_4;
            case 7:
              if (!ViewItemTransformationChange.dXtXFFoPmajob1g7B1HU((object) this.PropertyName, ViewItemTransformationChange.vZiceNoP0atY1sfKgrXT(44884861 ^ 44990639)))
              {
                TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApply(formViewItem, this.Uid, this.PropertyName, this.Value);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
              }
              num2 = 6;
              continue;
            default:
              valueTransformation.Apply((IList<ComputedValue>) viewItem.DynamicProperties);
              num2 = 3;
              continue;
          }
        }
label_4:
        viewItem = Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance.FindItem(formViewItem, this.Uid);
        num1 = 5;
      }
label_7:
      return;
label_14:
      return;
label_15:
      return;
label_3:;
    }

    /// <summary>
    /// Вычислить трансформацию для свойства <see cref="P:EleWise.ELMA.Model.Views.ViewItem.DynamicProperties" />
    /// </summary>
    /// <param name="viewItem">Измененный элемент формы</param>
    /// <param name="originalItem">Оригинальный элемент формы</param>
    /// <returns>Значение для трансофрмации изменения, или <see langword="null" />, если изменений нет</returns>
    internal static object CheckDynamicProperties(ViewItem viewItem, ViewItem originalItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (viewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      List<ComputedValue> items = (List<ComputedValue>) null;
      goto label_6;
label_5:
      items = viewItem.DynamicProperties;
label_6:
      List<ComputedValue> dynamicProperties = originalItem?.DynamicProperties;
      return (object) ComputedValueTransformation.CreateTransformation((IList<ComputedValue>) items, (IList<ComputedValue>) dynamicProperties);
    }

    /// <summary>
    /// Получить список локализуемых свойств данного элемента и всех внутренних
    /// </summary>
    /// <returns></returns>
    public override IEnumerable<string> GetLocalizableStrings()
    {
      List<string> allStrings = new List<string>();
      IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
      if (localizableStrings != null)
        allStrings.AddRange(localizableStrings);
      TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticGetLocalizableStrings(allStrings, this.Localizable, this.Value);
      return (IEnumerable<string>) allStrings;
    }

    /// <summary>Применить текущую локаль к локализуемым свойствам</summary>
    public override void ApplyLocalization()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Value = TransformationChange<ViewItem, TransformationViewItem, Guid, Guid?>.StaticApplyLocalization(this.Localizable, this.Value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            ViewItemTransformationChange.gfXSupoPyQnnlH2R9X2L((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public ViewItemTransformationChange()
    {
      ViewItemTransformationChange.LGUGgBoPMl8r18W3tyTo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool k1UCG0oP7JYNt4FBWlrr() => ViewItemTransformationChange.wkweMVoPAmbNaEmVKHmP == null;

    internal static ViewItemTransformationChange nscr0qoPxiRnGYsLOGJ0() => ViewItemTransformationChange.wkweMVoPAmbNaEmVKHmP;

    internal static object vZiceNoP0atY1sfKgrXT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool dXtXFFoPmajob1g7B1HU([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void gfXSupoPyQnnlH2R9X2L([In] object obj0) => __nonvirtual (((BaseTransformation<ViewItem, Guid>) obj0).ApplyLocalization());

    internal static void LGUGgBoPMl8r18W3tyTo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
