// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Models.FormMetadataItemHeaderDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.DTO.Models
{
  [Serializable]
  public class FormMetadataItemHeaderDTO : EntityDTO<long>, ISerializable
  {
    private static FormMetadataItemHeaderDTO lquSQyJx0K31AVAVm6U;

    public FormMetadataItemHeaderDTO()
    {
      FormMetadataItemHeaderDTO.K5QNV6JyOXxwadXmHvO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Уникальный идентификатор</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>Наименование</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя</summary>
    public string DisplayName
    {
      get => this.\u003CDisplayName\u003Ek__BackingField;
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
              this.\u003CDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>ID группы</summary>
    public long? GroupId { get; set; }

    /// <summary>Дата создания</summary>
    public DateTime CreationDate
    {
      get => this.\u003CCreationDate\u003Ek__BackingField;
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
              this.\u003CCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора создания</summary>
    public long? CreationAuthorId { get; set; }

    /// <summary>Тип метаданных</summary>
    public Guid MetadataType
    {
      get => this.\u003CMetadataType\u003Ek__BackingField;
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
              this.\u003CMetadataType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Есть неопубликованные изменения</summary>
    public bool IsDirtyItem
    {
      get => this.\u003CIsDirtyItem\u003Ek__BackingField;
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
              this.\u003CIsDirtyItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

    /// <summary>ID черновика</summary>
    public long? DraftId { get; set; }

    /// <summary>Дата изменения</summary>
    public DateTime? Draft_CreationDate { get; set; }

    /// <summary>ID опубликованной версии</summary>
    public long? PublishedId { get; set; }

    /// <summary>Дата публикации</summary>
    public DateTime? Published_CreationDate { get; set; }

    public void CopyFrom(FormMetadataItemHeaderDTO header)
    {
      int num1 = 2;
      IEnumerator<PropertyInfo> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            enumerator = ((IEnumerable<PropertyInfo>) __nonvirtual (FormMetadataItemHeaderDTO.kF9jgTJMdX6n8eNadTW(__typeref (FormMetadataItemHeaderDTO)).GetProperties())).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
            {
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 2:
                    goto label_7;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (!FormMetadataItemHeaderDTO.\u003C\u003Ec.r4qL3Of58F6KAONVY9JL((object) p))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 4;
                  case 4:
                    if (!p.CanWrite)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                      continue;
                    }
                    goto label_6;
                  default:
                    goto label_6;
                }
              }
label_6:
              // ISSUE: reference to a compiler-generated method
              return FormMetadataItemHeaderDTO.\u003C\u003Ec.U1IBFgf5ZqSatEGnYyEY((object) p).Length == 0;
label_7:
              return false;
            })).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) header, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576189648));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_16;
          default:
            goto label_3;
        }
      }
label_16:
      return;
label_3:
      try
      {
label_6:
        if (FormMetadataItemHeaderDTO.xicJUpJdLAKoulkpXXp((object) enumerator))
          goto label_8;
        else
          goto label_7;
label_5:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_8;
            case 2:
              FormMetadataItemHeaderDTO.G4FY3QJ9nr06nDtmtWj((object) current, (object) this, FormMetadataItemHeaderDTO.CSo8TDJJLJynvpaY3mQ((object) current, (object) header, (object) null), (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_14;
            default:
              goto label_6;
          }
        }
label_14:
        return;
label_7:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 3;
        goto label_5;
label_8:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        {
          num3 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
        else
          goto label_15;
label_13:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_15:
        FormMetadataItemHeaderDTO.BOR48VJlROjNJ2Vwae7((object) enumerator);
        num4 = 2;
        goto label_13;
      }
    }

    protected FormMetadataItemHeaderDTO(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num1 = 1;
      string xml;
      IEnumerator<PropertyInfo> enumerator;
      object obj;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            // ISSUE: type reference
            xml = (string) FormMetadataItemHeaderDTO.jG1F4lJrWDWZWnWUUnR((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957845816), FormMetadataItemHeaderDTO.kF9jgTJMdX6n8eNadTW(__typeref (string)));
            num1 = 4;
            continue;
          case 2:
            enumerator = ((IEnumerable<PropertyInfo>) obj.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (FormMetadataItemHeaderDTO.\u003C\u003Ec.SylJaXf5u6GjWo7arjpa((object) p))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  case 2:
                    if (p.CanRead)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
                      continue;
                    }
                    goto label_3;
                  default:
                    goto label_2;
                }
              }
label_2:
              return AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) == null;
label_3:
              return false;
            })).GetEnumerator();
            num1 = 3;
            continue;
          case 3:
            goto label_5;
          case 4:
            obj = ClassSerializationHelper.DeserializeObjectByXml(FormMetadataItemHeaderDTO.L9cI3tJgB95vOAbZvAD((object) this), xml);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 5 : 5;
            continue;
          case 5:
            if (obj != null)
            {
              num1 = 2;
              continue;
            }
            goto label_17;
          default:
            goto label_13;
        }
      }
label_20:
      return;
label_13:
      return;
label_5:
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_9;
label_6:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_8;
            case 2:
              goto label_10;
            case 3:
              current.SetValue((object) this, FormMetadataItemHeaderDTO.CSo8TDJJLJynvpaY3mQ((object) current, obj, (object) null), (object[]) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            default:
              goto label_3;
          }
        }
label_7:
        return;
label_3:
        return;
label_9:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
        goto label_6;
label_10:
        current = enumerator.Current;
        num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num3 = 2;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = 2;
        else
          goto label_18;
label_16:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_18:
        FormMetadataItemHeaderDTO.BOR48VJlROjNJ2Vwae7((object) enumerator);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        {
          num4 = 1;
          goto label_16;
        }
        else
          goto label_16;
      }
label_17:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormMetadataItemHeaderDTO.YDG1dxJjgLo481dnAm3((object) info, FormMetadataItemHeaderDTO.FcWCK7J5c83NDq5SxeP(1917256330 ^ 1917300226), (object) ClassSerializationHelper.SerializeObjectByXml((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void K5QNV6JyOXxwadXmHvO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Pt6GraJ07CWNoW4v5PV() => FormMetadataItemHeaderDTO.lquSQyJx0K31AVAVm6U == null;

    internal static FormMetadataItemHeaderDTO at953uJmYWceNZQSU2w() => FormMetadataItemHeaderDTO.lquSQyJx0K31AVAVm6U;

    internal static Type kF9jgTJMdX6n8eNadTW([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object CSo8TDJJLJynvpaY3mQ([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void G4FY3QJ9nr06nDtmtWj([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool xicJUpJdLAKoulkpXXp([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void BOR48VJlROjNJ2Vwae7([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object jG1F4lJrWDWZWnWUUnR([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static Type L9cI3tJgB95vOAbZvAD([In] object obj0) => obj0.GetType();

    internal static object FcWCK7J5c83NDq5SxeP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void YDG1dxJjgLo481dnAm3([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
