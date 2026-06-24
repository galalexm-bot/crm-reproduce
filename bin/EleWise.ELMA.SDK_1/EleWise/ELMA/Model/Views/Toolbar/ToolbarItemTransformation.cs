// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ToolbarItemTransformation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Transformations.Struct;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  /// <summary>
  /// Класс описания трансформаций для наборов главных страниц интерфейса
  /// </summary>
  [XmlInclude(typeof (ToolbarItemTransformationMove))]
  [XmlInclude(typeof (ToolbarItemTransformationAdd))]
  [XmlInclude(typeof (ToolbarItemTransformationHide))]
  [XmlInclude(typeof (ToolbarItemTransformationChange))]
  [Serializable]
  public class ToolbarItemTransformation : 
    Transformation<ToolbarItem, ToolbarItemTransformation, Guid, ToolbarItemTransformationAdd, ToolbarItemTransformationMove, ToolbarItemTransformationHide, ToolbarItemTransformationChange>
  {
    internal static ToolbarItemTransformation EtgjtKowCbxvZiIenrbC;

    protected internal override IList<ToolbarItem> GetSubItems(ToolbarItem item) => !(item is RootToolbarItem rootToolbarItem) ? (IList<ToolbarItem>) new ToolbarItem[0] : (IList<ToolbarItem>) rootToolbarItem.Items;

    protected internal override Guid GetUid(ToolbarItem item) => ToolbarItemTransformation.lS5do2owZFA6py6K3fRE((object) item);

    protected internal override bool IsHide(ToolbarItem item) => false;

    protected internal override void SetHide(ToolbarItem parentItem, ToolbarItem item, bool hide = true)
    {
      int num1 = 5;
      RootToolbarItem rootToolbarItem1;
      RootToolbarItem rootToolbarItem2;
      ToolbarItemTransformation itemTransformation;
      ToolbarItem item1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_10;
          case 1:
            if (rootToolbarItem2 != null)
            {
              num1 = 7;
              continue;
            }
            goto case 9;
          case 2:
            rootToolbarItem2 = parentItem as RootToolbarItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
          case 3:
            item1 = item;
            num1 = 2;
            continue;
          case 4:
            itemTransformation = this;
            num1 = 3;
            continue;
          case 5:
            num1 = 4;
            continue;
          case 6:
            if (rootToolbarItem1 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 8;
              continue;
            }
            goto case 10;
          case 7:
            ((EventedList<ToolbarItem>) ToolbarItemTransformation.NVufKCowuxqlE0lKpnbs((object) rootToolbarItem2)).Remove(item1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 7 : 9;
            continue;
          case 8:
            goto label_2;
          case 9:
            rootToolbarItem1 = item1 as RootToolbarItem;
            num1 = 6;
            continue;
          case 10:
            ((IEnumerable<ToolbarItem>) ((IEnumerable<ToolbarItem>) ToolbarItemTransformation.NVufKCowuxqlE0lKpnbs((object) rootToolbarItem1)).ToArray<ToolbarItem>()).Each<ToolbarItem>((Action<ToolbarItem>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    itemTransformation.SetHide(item1, i, true);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_15;
        }
      }
label_10:
      return;
label_2:
      return;
label_15:;
    }

    protected internal override ToolbarItem CreateCopy(ToolbarItem item)
    {
      int num = 3;
      RootToolbarItem rootToolbarItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (rootToolbarItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            rootToolbarItem = item as RootToolbarItem;
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return this.Clone(item);
label_6:
      return (ToolbarItem) ToolbarItemTransformation.zsyPMYowIxg8GiFafxVk((object) rootToolbarItem);
    }

    protected internal override ToolbarItem Clone(ToolbarItem item) => ClassSerializationHelper.CloneObjectByXml<ToolbarItem>(item);

    public ToolbarItemTransformation()
    {
      ToolbarItemTransformation.EES5AbowVFugADU04Lyh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid lS5do2owZFA6py6K3fRE([In] object obj0) => ((ToolbarItem) obj0).Uid;

    internal static object NVufKCowuxqlE0lKpnbs([In] object obj0) => (object) ((RootToolbarItem) obj0).Items;

    internal static bool B4UNdfowvQtdr4iQe40k() => ToolbarItemTransformation.EtgjtKowCbxvZiIenrbC == null;

    internal static ToolbarItemTransformation Lk9LMHow8TdQbJqlOb3L() => ToolbarItemTransformation.EtgjtKowCbxvZiIenrbC;

    internal static object zsyPMYowIxg8GiFafxVk([In] object obj0) => (object) ((RootToolbarItem) obj0).CreateCopy();

    internal static void EES5AbowVFugADU04Lyh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
