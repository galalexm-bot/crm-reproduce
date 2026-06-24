// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.WorkTimeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Интервал рабочего времени"</summary>
  [Component(Order = 1000)]
  public class WorkTimeDescriptor : 
    CLRTypeDescriptor<WorkTime, WorkTimeSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{CDD9F627-2A60-4E36-9C10-ECB492B1ADAD}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static WorkTimeDescriptor lGD6BaoHT8qkmWmT2pXS;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            mapper.Type<WorkTimeNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 2:
            WorkTimeDescriptor.NaljXuoHOAUbAvFGVnMv((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => WorkTimeDescriptor.UID;

    /// <summary>Имя "Интервал рабочего времени"</summary>
    public override string Name => (string) WorkTimeDescriptor.NhT5SWoHewpEu5IRo52c(WorkTimeDescriptor.rr8qlJoH2hJDDG7cTMtf(--1867379187 ^ 1867477067));

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 2;
      long? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            }
            goto label_13;
          case 2:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            }
            goto label_13;
          case 3:
            goto label_2;
          case 4:
            goto label_6;
          case 5:
            goto label_10;
          case 6:
            if (nullable.HasValue)
            {
              num = 9;
              continue;
            }
            goto label_6;
          case 7:
            nullable = (long?) (WorkTime) val;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 6;
            continue;
          case 8:
            goto label_13;
          case 9:
            WorkTimeDescriptor.IwVGoGoH1muYsaVG9qiv((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 5 : 5;
            continue;
          default:
            if ((WorkTimeSettings) WorkTimeDescriptor.VD9jHvoHPLntNkRyUNiM((object) propertyMetadata) != null)
            {
              num = 7;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return true;
label_6:
      return true;
label_10:
      return false;
label_13:
      return true;
    }

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num1 = 15;
      long? defaultValue;
      long num2;
      while (true)
      {
        int num3 = num1;
        WorkTimeSettings workTimeSettings;
        while (true)
        {
          WorkTime workTime;
          long num4;
          switch (num3)
          {
            case 1:
              num4 = workTime.Value;
              break;
            case 2:
              goto label_17;
            case 3:
              if (propertyMetadata == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 2;
                continue;
              }
              if (WorkTimeDescriptor.IwVGoGoH1muYsaVG9qiv((object) propertyMetadata))
              {
                num3 = 16;
                continue;
              }
              goto label_16;
            case 4:
              if (!defaultValue.HasValue)
              {
                num3 = 13;
                continue;
              }
              goto case 17;
            case 5:
            case 14:
              goto label_10;
            case 6:
              if (workTimeSettings == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              }
              // ISSUE: type reference
              if (WorkTimeDescriptor.GJ4mQvoH3pWUoQ1OiuVc(val.GetType(), WorkTimeDescriptor.C2IPeSoHN3XEAAEm6KCj(__typeref (WorkTime))))
              {
                workTime = (WorkTime) val;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
              }
              num3 = 7;
              continue;
            case 7:
              if (WorkTimeDescriptor.GJ4mQvoH3pWUoQ1OiuVc(val.GetType(), typeof (long)))
              {
                num3 = 12;
                continue;
              }
              goto case 8;
            case 8:
              num4 = 0L;
              break;
            case 9:
              defaultValue = workTimeSettings.DefaultValue;
              num3 = 4;
              continue;
            case 10:
              goto label_6;
            case 11:
              if (!this.IsEmpty(propertyMetadata, val))
              {
                num3 = 3;
                continue;
              }
              goto label_10;
            case 12:
              num4 = (long) val;
              break;
            case 13:
              goto label_7;
            case 15:
              if (val == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 14 : 14;
                continue;
              }
              goto case 11;
            case 16:
              goto label_15;
            case 17:
              defaultValue = workTimeSettings.DefaultValue;
              num3 = 10;
              continue;
            default:
              goto label_28;
          }
          num2 = num4;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 9 : 2;
        }
label_16:
        workTimeSettings = (WorkTimeSettings) WorkTimeDescriptor.VD9jHvoHPLntNkRyUNiM((object) propertyMetadata);
        num1 = 6;
      }
label_6:
      return defaultValue.Equals((object) num2);
label_7:
      return false;
label_10:
      return true;
label_15:
      return false;
label_17:
      return true;
label_28:
      return true;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      WorkTimeSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            forFilterProperty = (WorkTimeSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            forFilterProperty.DefaultValue = new long?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
            continue;
          default:
            if (forFilterProperty != null)
            {
              num = 3;
              continue;
            }
            goto label_3;
        }
      }
label_3:
      return (TypeSettings) forFilterProperty;
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata"></param>
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
        int num = 2;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new WorkTimePropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public WorkTimeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static WorkTimeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            WorkTimeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633677893));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void NaljXuoHOAUbAvFGVnMv([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<WorkTime>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool pbVBhooHkTvWwKfvrSjQ() => WorkTimeDescriptor.lGD6BaoHT8qkmWmT2pXS == null;

    internal static WorkTimeDescriptor peHnOqoHnkASnxB5dq0y() => WorkTimeDescriptor.lGD6BaoHT8qkmWmT2pXS;

    internal static object rr8qlJoH2hJDDG7cTMtf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NhT5SWoHewpEu5IRo52c([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object VD9jHvoHPLntNkRyUNiM([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool IwVGoGoH1muYsaVG9qiv([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type C2IPeSoHN3XEAAEm6KCj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool GJ4mQvoH3pWUoQ1OiuVc([In] Type obj0, [In] Type obj1) => obj0 == obj1;
  }
}
