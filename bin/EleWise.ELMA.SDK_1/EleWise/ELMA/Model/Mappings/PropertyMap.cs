// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.PropertyMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Карта свойств</summary>
  /// <remarks>
  /// При использовании в <see cref="T:Element" /> необходимо реализовать интерфейс <see cref="T:IElementWithPropertyMap" />
  /// </remarks>
  [Serializable]
  public class PropertyMap : EntityDTO<long>
  {
    internal static PropertyMap sqqApahb3EpegqfooUyk;

    /// <summary>Левый класс</summary>
    [XmlElement("LeftClassUid")]
    public virtual Guid LeftClassUid
    {
      get => this.\u003CLeftClassUid\u003Ek__BackingField;
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
              this.\u003CLeftClassUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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

    /// <summary>Правый класс</summary>
    [XmlElement("RightClassUid")]
    public virtual Guid RightClassUid
    {
      get => this.\u003CRightClassUid\u003Ek__BackingField;
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
              this.\u003CRightClassUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    /// <summary>Элементы</summary>
    [XmlArray]
    public List<PropertyMapItem> Items { get; set; }

    /// <summary>Слияние изменений</summary>
    /// <param name="leftMetadata"></param>
    /// <param name="clause"></param>
    /// <returns></returns>
    public void Merge(ClassMetadata leftMetadata, Func<IPropertyMetadata, bool> clause)
    {
      List<Guid> guidList = new List<Guid>();
      PropertyMap.FillProperties(guidList, (object) leftMetadata, clause);
      this.Merge((IEnumerable<Guid>) guidList);
    }

    /// <summary>Слияние изменений</summary>
    /// <param name="uids">Идентификаторы свойств</param>
    /// <returns></returns>
    public void Merge(IEnumerable<Guid> uids)
    {
      this.Items.AddRange(uids.Where<Guid>((Func<Guid, bool>) (uid =>
      {
        int num = 2;
        Guid uid1;
        while (true)
        {
          switch (num)
          {
            case 1:
              uid1 = uid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            case 2:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return !this.Items.Any<PropertyMapItem>((Func<PropertyMapItem, bool>) (i => PropertyMap.\u003C\u003Ec__DisplayClass13_1.l0d3BFClgVZxFcSLUp8R(PropertyMap.\u003C\u003Ec__DisplayClass13_1.ipXagFClrW2UkZUvgXi0((object) i), uid1)));
      })).Select<Guid, PropertyMapItem>((Func<Guid, PropertyMapItem>) (uid =>
      {
        PropertyMapItem propertyMapItem = new PropertyMapItem();
        // ISSUE: reference to a compiler-generated method
        PropertyMap.\u003C\u003Ec.pJvO85CrWG1xjoJ9bpvB((object) propertyMapItem, uid);
        return propertyMapItem;
      })));
      this.Items.RemoveAll((Predicate<PropertyMapItem>) (i =>
      {
        int num = 1;
        PropertyMapItem i1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              i1 = i;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 2;
              continue;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return !uids.Any<Guid>((Func<Guid, bool>) (uid => PropertyMap.\u003C\u003Ec__DisplayClass13_2.I4uRNFClsrhoLJRNL2dR(uid, PropertyMap.\u003C\u003Ec__DisplayClass13_2.XHGVVpClUndMLKpF3IsD((object) i1))));
      }));
    }

    /// <summary>Создавть новую карту</summary>
    /// <param name="leftMetadata"></param>
    public void InitNew(ClassMetadata leftMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Merge(leftMetadata, (Func<IPropertyMetadata, bool>) null);
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

    /// <summary>Перевернуть маппинг</summary>
    /// <returns></returns>
    public PropertyMap Reverse()
    {
      PropertyMap propertyMap = new PropertyMap();
      propertyMap.LeftClassUid = PropertyMap.dy8lV2hbDlKoTEscHOt7((object) this);
      PropertyMap.XRxRIghbwq5OgnSSGvNt((object) propertyMap, PropertyMap.gvMlmPhbtBdYfVBffwMA((object) this));
      propertyMap.Items.AddRange(this.Items.Select<PropertyMapItem, PropertyMapItem>((Func<PropertyMapItem, PropertyMapItem>) (i =>
      {
        PropertyMapItem propertyMapItem = new PropertyMapItem();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMap.\u003C\u003Ec.pJvO85CrWG1xjoJ9bpvB((object) propertyMapItem, PropertyMap.\u003C\u003Ec.as75O8CrovPBuNLf8VBg((object) i));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMap.\u003C\u003Ec.BKdoCoCrhCJoSbbbgunk((object) propertyMapItem, PropertyMap.\u003C\u003Ec.ELXudVCrbLyEoejX2KCv((object) i));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMap.\u003C\u003Ec.pZ9PLgCrEbyhs8XNHCA4((object) propertyMapItem, PropertyMap.\u003C\u003Ec.OQCIbNCrGfKtla6Vcp0R((object) i));
        // ISSUE: reference to a compiler-generated method
        propertyMapItem.RightValue = PropertyMap.\u003C\u003Ec.kSVr66CrfZMXu67QVn57((object) i);
        propertyMapItem.ThisMarker = i.ThisMarker;
        propertyMapItem.ParentProperties = new List<PropertyMetadata>((IEnumerable<PropertyMetadata>) i.ParentProperties);
        return propertyMapItem;
      })));
      return propertyMap;
    }

    /// <summary>Конструктор</summary>
    public PropertyMap()
    {
      PropertyMap.KFAJrJhb4Z59x9AVltUW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<PropertyMapItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    private static void FillProperties(
      List<Guid> allUids,
      object m,
      Func<IPropertyMetadata, bool> clause)
    {
      // ISSUE: reference to a compiler-generated method
      allUids.AddRange(((ClassMetadata) m).Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (clause == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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
        return clause((IPropertyMetadata) p);
label_5:
        return true;
      })).Select<PropertyMetadata, Guid>((Func<PropertyMetadata, Guid>) (p => PropertyMap.\u003C\u003Ec.XoqqVsCrQuqMYBcRpfh3((object) p))));
      if (!(m is EntityMetadata entityMetadata))
        return;
      foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
      {
        if (clause == null || clause((IPropertyMetadata) tablePart))
        {
          allUids.Add(tablePart.TablePartPropertyUid);
          PropertyMap.FillProperties(allUids, (object) tablePart, clause);
        }
      }
    }

    internal static bool UMOG1chbpaOv92R2fasD() => PropertyMap.sqqApahb3EpegqfooUyk == null;

    internal static PropertyMap zhOaXbhbaI06wMfGsANM() => PropertyMap.sqqApahb3EpegqfooUyk;

    internal static Guid dy8lV2hbDlKoTEscHOt7([In] object obj0) => ((PropertyMap) obj0).RightClassUid;

    internal static Guid gvMlmPhbtBdYfVBffwMA([In] object obj0) => ((PropertyMap) obj0).LeftClassUid;

    internal static void XRxRIghbwq5OgnSSGvNt([In] object obj0, Guid value) => ((PropertyMap) obj0).RightClassUid = value;

    internal static void KFAJrJhb4Z59x9AVltUW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
