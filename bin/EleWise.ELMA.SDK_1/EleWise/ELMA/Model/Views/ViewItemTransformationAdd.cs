// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemTransformationAdd
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  [Serializable]
  public class ViewItemTransformationAdd : ViewItemTransformation
  {
    internal static ViewItemTransformationAdd oU5RsJoPtBJSKbowNq1B;

    public ViewItem Item
    {
      get => this.\u003CItem\u003Ek__BackingField;
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
              this.\u003CItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    public Guid? BeforeItem { get; set; }

    public Guid? AfterItem { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeBeforeItem()
    {
      int num = 1;
      Guid? beforeItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            beforeItem = this.BeforeItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return beforeItem.HasValue;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeAfterItem()
    {
      int num = 1;
      Guid? afterItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            afterItem = this.AfterItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return afterItem.HasValue;
    }

    public override IEnumerable<string> GetLocalizableStrings()
    {
      IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
      List<string> stringList = new List<string>();
      if (this.Item != null)
        stringList = this.Item.GetLocalizableStrings().ToList<string>();
      List<string> second = stringList;
      return (IEnumerable<string>) localizableStrings.Union<string>((IEnumerable<string>) second).Distinct<string>().ToArray<string>();
    }

    public override void ApplyLocalization()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Item != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            base.ApplyLocalization();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            ViewItemTransformationAdd.CFsOf9oP6rEZKNDuHwjH((object) this.Item);
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    public override void Apply(ViewItem formViewItem)
    {
      int num = 1;
      TransformationViewItem instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            instance = Transformation<ViewItem, TransformationViewItem, Guid, Guid?>.Instance;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TransformationAdd<ViewItem, TransformationViewItem, Guid, Guid?, ViewItem>.StaticApply(formViewItem, this.Uid, instance.Clone(this.Item), this.BeforeItem, this.AfterItem, instance);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    public ViewItemTransformationAdd()
    {
      ViewItemTransformationAdd.eg0fV6oPHCeJmEDRIotx();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CJwnihoPw0NJ9XNBImuB() => ViewItemTransformationAdd.oU5RsJoPtBJSKbowNq1B == null;

    internal static ViewItemTransformationAdd ExaRoGoP4QgrvptfE5gJ() => ViewItemTransformationAdd.oU5RsJoPtBJSKbowNq1B;

    internal static void CFsOf9oP6rEZKNDuHwjH([In] object obj0) => ((ViewItem) obj0).ApplyLocalization();

    internal static void eg0fV6oPHCeJmEDRIotx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
