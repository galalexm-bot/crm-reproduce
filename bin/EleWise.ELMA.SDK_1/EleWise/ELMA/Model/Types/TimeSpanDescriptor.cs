// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TimeSpanDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Временной интервал"</summary>
  [Component(Order = 700)]
  public class TimeSpanDescriptor : 
    CLRTypeDescriptor<TimeSpan, TimeSpanSettings>,
    IConvertableTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{C503AE0F-D260-4173-B52B-63E9158F3D7D}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static TimeSpanDescriptor uEYyQnol2SI1fXkCx9CG;

    /// <summary>Uid типа</summary>
    public override Guid Uid => TimeSpanDescriptor.UID;

    /// <summary>Имя "Временной интервал"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) TimeSpanDescriptor.BgM9nQol1UT0TJxalwPW(-1824388195 ^ -1824484347));

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 6;
      TimeSpan? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 3:
            goto label_10;
          case 4:
            goto label_9;
          case 5:
            goto label_2;
          case 6:
            if (propertyMetadata != null)
            {
              if ((TimeSpanSettings) TimeSpanDescriptor.q2lEWUolN5xQKK4KvnJl((object) propertyMetadata) == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
                continue;
              }
              nullable = (TimeSpan?) val;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 5 : 4;
            continue;
          default:
            if (!TimeSpanDescriptor.fX84VLol3ohxwWSW4EmP(nullable.Value, TimeSpan.MinValue))
            {
              num = 3;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      return true;
label_5:
      return true;
label_9:
      return true;
label_10:
      return false;
    }

    public virtual object ConvertFrom(object value, PropertyMetadata propertyMetadata)
    {
      int num = 2;
      TimeSpanHolder timeSpanHolder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_15;
          case 2:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
            }
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 6 : 4;
              continue;
            }
            goto label_9;
          case 3:
            goto label_7;
          case 4:
            goto label_9;
          case 5:
            timeSpanHolder = (TimeSpanHolder) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 3;
            continue;
          case 6:
            if (!TimeSpanDescriptor.IPl99HolpwSsCbR6WqD5(value.GetType(), typeof (TimeSpan)))
            {
              num = 7;
              continue;
            }
            goto label_9;
          case 7:
            // ISSUE: type reference
            if (value.GetType() == TimeSpanDescriptor.piRTuNolaEigyj9k4ruu(__typeref (long)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            }
            if (!TimeSpanDescriptor.IPl99HolpwSsCbR6WqD5(value.GetType(), typeof (TimeSpanHolder)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 8 : 2;
              continue;
            }
            goto case 5;
          case 8:
            goto label_8;
          default:
            goto label_12;
        }
      }
label_7:
      return (object) timeSpanHolder.Value;
label_8:
      return (object) null;
label_9:
      return value;
label_12:
      return (object) new TimeSpan((long) value);
label_15:
      throw new ArgumentNullException((string) TimeSpanDescriptor.BgM9nQol1UT0TJxalwPW(1178210108 ^ 1178224238));
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Int64);
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new TimeSpanPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public TimeSpanDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TimeSpanDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TimeSpanDescriptor.UID = new Guid((string) TimeSpanDescriptor.BgM9nQol1UT0TJxalwPW(901793403 ^ 901962171));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object BgM9nQol1UT0TJxalwPW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool opax3Dole3LMOcLuEuxk() => TimeSpanDescriptor.uEYyQnol2SI1fXkCx9CG == null;

    internal static TimeSpanDescriptor OXveOLolPA630iMqPbCi() => TimeSpanDescriptor.uEYyQnol2SI1fXkCx9CG;

    internal static object q2lEWUolN5xQKK4KvnJl([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool fX84VLol3ohxwWSW4EmP([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 == obj1;

    internal static bool IPl99HolpwSsCbR6WqD5([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type piRTuNolaEigyj9k4ruu([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}
