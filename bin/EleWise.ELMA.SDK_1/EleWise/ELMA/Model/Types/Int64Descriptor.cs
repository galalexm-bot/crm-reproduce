// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int64Descriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Comparers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Целое число"</summary>
  [Component(Order = 400)]
  public class Int64Descriptor : CLRTypeDescriptor<long, Int64Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{D90A59AF-7E47-48C5-8C4C-DAD04834E6E3}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static Int64Descriptor GO2OagolMZiOnesQqTYj;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int64Descriptor.UID;

    /// <summary>Имя "Целое число"</summary>
    public override string Name => (string) Int64Descriptor.NaFKGaollLsfAQVTv8Qp(Int64Descriptor.ic3QVUoldXQpAlvFqSAs(1199946765 ^ 1200036993));

    /// <summary>Разрешить использовать для идентификатора сущности</summary>
    public override bool UseForId => true;

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
    {
      int num = 6;
      long? defaultValue;
      Int64Settings int64Settings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata == null)
            {
              num = 9;
              continue;
            }
            if (!Int64Descriptor.HDW66LolrUyaFB6TiaUb((object) propertyMetadata))
            {
              int64Settings = (Int64Settings) Int64Descriptor.zy5MUAolg57vBYkc9VNn((object) propertyMetadata);
              num = 2;
              continue;
            }
            num = 8;
            continue;
          case 2:
            if (int64Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 1;
              continue;
            }
            defaultValue = int64Settings.DefaultValue;
            num = 3;
            continue;
          case 3:
            if (!defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 12 : 7;
              continue;
            }
            goto case 11;
          case 4:
            goto label_15;
          case 5:
          case 10:
            goto label_6;
          case 6:
            if (val == null)
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 7:
            if (!this.IsEmpty(propertyMetadata, val))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 8:
            goto label_13;
          case 9:
            goto label_19;
          case 11:
            defaultValue = int64Settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 12:
            goto label_10;
          default:
            goto label_9;
        }
      }
label_6:
      return true;
label_9:
      return defaultValue.Equals(val);
label_10:
      return false;
label_13:
      return false;
label_15:
      return true;
label_19:
      return true;
    }

    /// <summary>
    /// Получить выражение инициализации свойства - в соответствии со значением по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num = 3;
      Int64Settings int64Settings;
      long? defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (!forFilter)
            {
              int64Settings = (Int64Settings) Int64Descriptor.zy5MUAolg57vBYkc9VNn((object) propertyMetadata);
              num = 7;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 5;
            continue;
          case 3:
            Int64Descriptor.oVolOJol5UfA5I6D3t09((object) propertyMetadata, Int64Descriptor.ic3QVUoldXQpAlvFqSAs(-951514650 ^ -951500620));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_8;
          case 5:
            goto label_4;
          case 6:
            defaultValue = int64Settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 7:
            if (int64Settings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 6 : 4;
              continue;
            }
            goto label_8;
          default:
            if (defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
              continue;
            }
            goto label_8;
        }
      }
label_4:
      return (ISyntaxNode) null;
label_8:
      return (ISyntaxNode) null;
label_9:
      return (ISyntaxNode) Int64Descriptor.uKie4uoljxZNljnotZBU((object) int64Settings.DefaultValue);
    }

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num1 = 9;
      long? nullable1;
      long? nullable2;
      while (true)
      {
        long? nullable3;
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            nullable1 = new long?();
            num1 = 10;
            continue;
          case 3:
            nullable1 = new long?();
            num1 = 5;
            continue;
          case 4:
            goto label_18;
          case 5:
            nullable3 = nullable1;
            goto label_21;
          case 6:
            if (propertyMetadata != null)
            {
              num1 = 7;
              continue;
            }
            break;
          case 7:
            if (Int64Descriptor.HDW66LolrUyaFB6TiaUb((object) propertyMetadata))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 8:
            if (forFilter)
            {
              num1 = 2;
              continue;
            }
            Int64Settings settings = (Int64Settings) propertyMetadata.Settings;
            if (settings == null)
            {
              num1 = 3;
              continue;
            }
            // ISSUE: explicit non-virtual call
            nullable3 = __nonvirtual (settings.DefaultValue);
            goto label_21;
          case 9:
            Int64Descriptor.oVolOJol5UfA5I6D3t09((object) propertyMetadata, Int64Descriptor.ic3QVUoldXQpAlvFqSAs(-1426456882 ^ 2009939514 ^ -583759450));
            num1 = 8;
            continue;
          case 10:
            nullable3 = nullable1;
            goto label_21;
          default:
            if (!nullable1.HasValue)
            {
              num1 = 4;
              continue;
            }
            goto label_22;
        }
        nullable1 = nullable2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
        continue;
label_21:
        nullable2 = nullable3;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 1;
      }
label_8:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<long?>(nullable2);
label_18:
      long num2 = 0;
      goto label_23;
label_22:
      num2 = nullable1.GetValueOrDefault();
label_23:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<long>(num2);
    }

    /// <summary>Поддерживается ли автоинкремент</summary>
    public override bool AutoIncrementSupported => true;

    /// <summary>Uid типа, определяющего фильтр для данного свойства</summary>
    public override Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
    {
      int num = 5;
      while (true)
      {
        Int64Settings int64Settings1;
        Int64Settings int64Settings2;
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            if (int64Settings1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 6;
              continue;
            }
            goto label_10;
          case 3:
            int64Settings2 = (Int64Settings) null;
            break;
          case 4:
            int64Settings2 = (Int64Settings) Int64Descriptor.zy5MUAolg57vBYkc9VNn((object) propertyMetadata);
            break;
          case 5:
            if (propertyMetadata != null)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 6:
            if (Int64Descriptor.exLgY0olYyE6j715KHxo((object) int64Settings1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
            }
            goto label_9;
          default:
            goto label_9;
        }
        int64Settings1 = int64Settings2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 2;
      }
label_9:
      return Int64Descriptor.UID;
label_10:
      return Int64RangeDescriptor.UID;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 2;
      Int64Settings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (forFilterProperty != null)
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 2:
            forFilterProperty = (Int64Settings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
            continue;
          case 3:
            forFilterProperty.DefaultValue = new long?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    public override IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) Int64Descriptor.H6T7nColLtUsyVZj41FY(sourceType, (object) propertyFunc, order);
    }

    public override bool IsSupportSort() => true;

    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Int64);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      Int64Settings int64Settings;
      long? defaultValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (int64Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 3;
              continue;
            }
            goto case 6;
          case 2:
            int64Settings = Int64Descriptor.zy5MUAolg57vBYkc9VNn((object) propertyMetadata) as Int64Settings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
            continue;
          case 3:
          case 5:
            goto label_4;
          case 4:
            if (!defaultValue.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 5 : 0;
              continue;
            }
            defaultValue = int64Settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 6:
            defaultValue = int64Settings.DefaultValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 4 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_4:
      long dbDefaultValue = 0;
      goto label_11;
label_10:
      dbDefaultValue = defaultValue.Value;
label_11:
      return (object) dbDefaultValue;
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
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new Int64PropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
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

    public Int64Descriptor()
    {
      Int64Descriptor.U9XYJqolUDb2souvepdA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int64Descriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Int64Descriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16581055));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object ic3QVUoldXQpAlvFqSAs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NaFKGaollLsfAQVTv8Qp([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool S6UqO1olJj6DcsnbJV0F() => Int64Descriptor.GO2OagolMZiOnesQqTYj == null;

    internal static Int64Descriptor HYpAVHol9rEqqtbeYqLe() => Int64Descriptor.GO2OagolMZiOnesQqTYj;

    internal static bool HDW66LolrUyaFB6TiaUb([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static object zy5MUAolg57vBYkc9VNn([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static void oVolOJol5UfA5I6D3t09([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object uKie4uoljxZNljnotZBU([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static bool exLgY0olYyE6j715KHxo([In] object obj0) => ((Int64Settings) obj0).RangeInFilter;

    internal static object H6T7nColLtUsyVZj41FY(
      Type sourceType,
      [In] object obj1,
      ListSortDirection order)
    {
      return (object) ComparerHelper.Create(sourceType, (LambdaExpression) obj1, order);
    }

    internal static void U9XYJqolUDb2souvepdA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
