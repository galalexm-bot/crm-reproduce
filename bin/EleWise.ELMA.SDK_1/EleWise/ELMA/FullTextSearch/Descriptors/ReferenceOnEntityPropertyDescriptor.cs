// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.ReferenceOnEntityPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  public class ReferenceOnEntityPropertyDescriptor : FullTextPropertyDescriptor
  {
    private Func<IPropertyMetadata, string> indexFieldName;
    internal static ReferenceOnEntityPropertyDescriptor F07XTLGuFNBZHJoDUtgE;

    public ReferenceOnEntityPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      ReferenceOnEntityPropertyDescriptor.GGt2Y0GuoasfnYppRwxj();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.indexFieldName = (Func<IPropertyMetadata, string>) (propMd => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541813907), ReferenceOnEntityPropertyDescriptor.\u003C\u003Ec.BdC12pvYIlpeGFTn6Rsi((object) ReferenceOnEntityPropertyDescriptor.\u003C\u003Ec.bK0GEbvYuxK92webjGxq((object) propMd).ToString()), ReferenceOnEntityPropertyDescriptor.\u003C\u003Ec.mvY6h4vYVXKxeGMrtSPZ(1021410165 ^ 1021359617)));
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_5:
      return this.GetReIndexField(obj, propMd);
    }

    /// <inheritdoc />
    public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
    {
      FieldIndexList mappingField = new FieldIndexList();
      mappingField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      mappingField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) null, FullTextFieldType.String, FullTextFieldTag.Value));
      return mappingField;
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 5;
      ReferenceOnEntity referenceOnEntity;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
          case 4:
            goto label_8;
          case 3:
            if (obj == null)
            {
              num = 2;
              continue;
            }
            referenceOnEntity = obj as ReferenceOnEntity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 7 : 5;
            continue;
          case 5:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 4 : 4;
              continue;
            }
            goto case 3;
          case 6:
            if (ReferenceOnEntityPropertyDescriptor.if6UgRGubgERKwqeaSvD((object) referenceOnEntity) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 7:
            if (referenceOnEntity == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
              continue;
            }
            goto case 6;
          default:
            goto label_2;
        }
      }
label_2:
      FieldIndexList indexField = new FieldIndexList();
      indexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) ReferenceOnEntityPropertyDescriptor.if6UgRGubgERKwqeaSvD((object) referenceOnEntity).ToString(), FullTextFieldType.String));
      indexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), ReferenceOnEntityPropertyDescriptor.ocWljDGuGPQ2XL04fJYD((object) ReferenceOnEntityPropertyDescriptor.PFhd1HGuhbgm6DEEkL5f((object) referenceOnEntity).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876068633)), (object) referenceOnEntity.ObjectId), FullTextFieldType.String));
      return indexField;
label_3:
      return (FieldIndexList) null;
label_8:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (!(obj is ReferenceOnEntity))
            {
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            }
          case 3:
            goto label_8;
          case 4:
            if (propMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 3;
              continue;
            }
            goto case 2;
          default:
            goto label_7;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_7:
      FieldIndexList reIndexField = new FieldIndexList();
      reIndexField.Add(new FieldIndexListItem(this.ValueFieldName(propMd), (object) string.Empty, FullTextFieldType.String));
      reIndexField.Add(new FieldIndexListItem(this.indexFieldName(propMd), (object) string.Empty, FullTextFieldType.String));
      return reIndexField;
label_8:
      return new FieldIndexList();
    }

    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num = 5;
      ReferenceOnEntity referenceOnEntity;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (referenceOnEntity == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (ReferenceOnEntityPropertyDescriptor.if6UgRGubgERKwqeaSvD((object) referenceOnEntity) == null)
            {
              num = 6;
              continue;
            }
            goto label_2;
          case 4:
            goto label_8;
          case 5:
            if (value != null)
            {
              referenceOnEntity = value as ReferenceOnEntity;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return new FilterListItem(this.indexFieldName(propMd), new List<object>()
      {
        ReferenceOnEntityPropertyDescriptor.ocWljDGuGPQ2XL04fJYD((object) referenceOnEntity.ObjectTypeUId.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304578821)), (object) ReferenceOnEntityPropertyDescriptor.XYV6yPGuEiHUV2UU0ckQ((object) referenceOnEntity))
      }, FilterListItemType.Must, FullTextFieldType.String);
label_3:
      return (FilterListItem) null;
label_8:
      return (FilterListItem) null;
    }

    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      this.indexFieldName(propMd)
    };

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 1;
      long result1;
      Guid result2;
      PropertyInfo propertyCached;
      WebDataItem webDataItem;
      string input;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_31;
          case 1:
            if (obj == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 2:
            if (ReferenceOnEntityPropertyDescriptor.LXRl5sGuZeAC09r8kxlc(ReferenceOnEntityPropertyDescriptor.nMoXnvGu8OyqlCC4P0UD((object) webDataItem)) <= 32)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 7 : 0;
              continue;
            }
            goto case 13;
          case 3:
            if (!((string) ReferenceOnEntityPropertyDescriptor.CSQuHmGuCbB3JdchPrxp((object) webDataItem) != this.indexFieldName(propMd)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 8 : 0;
              continue;
            }
            goto label_9;
          case 4:
            goto label_18;
          case 5:
            if (Guid.TryParse(input, out result2))
            {
              num1 = 11;
              continue;
            }
            goto label_41;
          case 6:
            if (propMd != null)
            {
              propertyCached = obj.GetType().GetPropertyCached((string) ReferenceOnEntityPropertyDescriptor.uRuB36Gufo7Q36G9cdhI((object) propMd));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 6 : 10;
              continue;
            }
            num1 = 12;
            continue;
          case 7:
            goto label_22;
          case 8:
            if (!ReferenceOnEntityPropertyDescriptor.tFb5pNGuvcRVL9Gcnyca((object) webDataItem.Value))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 2;
              continue;
            }
            goto label_2;
          case 9:
            goto label_42;
          case 10:
            webDataItem = value as WebDataItem;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 16 : 3;
            continue;
          case 11:
            goto label_4;
          case 12:
            goto label_25;
          case 13:
            input = (string) ReferenceOnEntityPropertyDescriptor.nDV4ihGuuYOhnJtjHW0t(ReferenceOnEntityPropertyDescriptor.nMoXnvGu8OyqlCC4P0UD((object) webDataItem), 0, 32);
            num1 = 15;
            continue;
          case 14:
            if (webDataItem != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 3;
              continue;
            }
            goto label_13;
          case 15:
            if (long.TryParse(((string) ReferenceOnEntityPropertyDescriptor.nMoXnvGu8OyqlCC4P0UD((object) webDataItem)).Substring(32), out result1))
            {
              num1 = 5;
              continue;
            }
            goto label_3;
          case 16:
            if (!ReferenceOnEntityPropertyDescriptor.verwxKGuQy3KWNwQcrKJ((object) propertyCached, (object) null))
            {
              num1 = 14;
              continue;
            }
            goto label_7;
          default:
            goto label_15;
        }
      }
label_31:
      return;
label_18:
      return;
label_22:
      return;
label_42:
      return;
label_25:
      return;
label_15:
      return;
label_4:
      try
      {
        ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity(result1, result2);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_43;
            case 1:
              propertyCached.SetValue(obj, (object) referenceOnEntity, (object[]) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_44;
          }
        }
label_43:
        return;
label_44:
        return;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_45;
            case 1:
              Logger.Log.Warn(ReferenceOnEntityPropertyDescriptor.s9Krv0GuI6eiU67t9QEU(-1852837372 ^ -1853081364), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            default:
              goto label_46;
          }
        }
label_45:
        return;
label_46:
        return;
      }
label_3:
      return;
label_13:
      return;
label_2:
      return;
label_41:
      return;
label_9:
      return;
label_7:;
    }

    internal static void GGt2Y0GuoasfnYppRwxj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool qFpT4OGuBXPMh2lQyhf7() => ReferenceOnEntityPropertyDescriptor.F07XTLGuFNBZHJoDUtgE == null;

    internal static ReferenceOnEntityPropertyDescriptor TRKc7DGuWeeINPbXrdJo() => ReferenceOnEntityPropertyDescriptor.F07XTLGuFNBZHJoDUtgE;

    internal static object if6UgRGubgERKwqeaSvD([In] object obj0) => (object) ((ReferenceOnEntity) obj0).Object;

    internal static Guid PFhd1HGuhbgm6DEEkL5f([In] object obj0) => ((ReferenceOnEntity) obj0).ObjectTypeUId;

    internal static object ocWljDGuGPQ2XL04fJYD([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static long XYV6yPGuEiHUV2UU0ckQ([In] object obj0) => ((ReferenceOnEntity) obj0).ObjectId;

    internal static object uRuB36Gufo7Q36G9cdhI([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool verwxKGuQy3KWNwQcrKJ([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object CSQuHmGuCbB3JdchPrxp([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static bool tFb5pNGuvcRVL9Gcnyca([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object nMoXnvGu8OyqlCC4P0UD([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static int LXRl5sGuZeAC09r8kxlc([In] object obj0) => ((string) obj0).Length;

    internal static object nDV4ihGuuYOhnJtjHW0t([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object s9Krv0GuI6eiU67t9QEU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
