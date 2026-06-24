// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.GuidDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Уникальный идентификатор (GUID)"</summary>
  public class GuidDescriptor : CLRTypeDescriptor<Guid, GuidSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    private static GuidDescriptor E5XhJsodcRii9vYOEG8V;

    /// <summary>Uid типа</summary>
    public override Guid Uid => GuidDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Уникальный идентификатор (GUID)"</summary>
    public override string Name => (string) GuidDescriptor.du4GRbolWlDxiwNYSFyM(GuidDescriptor.tZI2D7olBTW3o3QCYMpY(964881585 - -1459193222 ^ -1870883693)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121057541);

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
      int num1 = 1;
      GuidSettings guidSettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (val != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_12;
            case 3:
              goto label_18;
            case 4:
              goto label_3;
            case 5:
              guidSettings = (GuidSettings) GuidDescriptor.XrOuDZolbUuiUckLVt9b((object) propertyMetadata);
              num2 = 7;
              continue;
            case 6:
              goto label_10;
            case 7:
              if (guidSettings != null)
              {
                num2 = 3;
                continue;
              }
              goto label_17;
            case 8:
              if (!propertyMetadata.Nullable)
              {
                num2 = 5;
                continue;
              }
              goto label_10;
            case 9:
              if (propertyMetadata != null)
              {
                num2 = 8;
                continue;
              }
              goto label_12;
            case 10:
              goto label_17;
            default:
              goto label_6;
          }
        }
label_6:
        if (!GuidDescriptor.uCpA9aoloja16fkb8UX7((object) this, (object) propertyMetadata, val))
          num1 = 9;
        else
          break;
      }
label_3:
      return true;
label_10:
      return false;
label_12:
      return true;
label_17:
      return true;
label_18:
      object obj = val;
      Guid? defaultValue = guidSettings.DefaultValue;
      // ISSUE: variable of a boxed type
      __Boxed<Guid> local = (System.ValueType) (!defaultValue.HasValue ? Guid.Empty : defaultValue.GetValueOrDefault());
      return obj.Equals((object) local);
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
      int num1 = 1;
      GuidSettings guidSettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Guid? defaultValue;
          Guid empty;
          int num3;
          switch (num2)
          {
            case 1:
              GuidDescriptor.ahKwn5olhD8QsUJnQSsN((object) propertyMetadata, GuidDescriptor.tZI2D7olBTW3o3QCYMpY(--1333735954 ^ 1333754688));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            case 2:
              defaultValue = guidSettings.DefaultValue;
              num2 = 11;
              continue;
            case 3:
              goto label_15;
            case 4:
              goto label_12;
            case 5:
              if (defaultValue.HasValue)
              {
                if (defaultValue.HasValue)
                {
                  num2 = 7;
                  continue;
                }
                goto case 10;
              }
              else
              {
                num2 = 6;
                continue;
              }
            case 6:
              num3 = 1;
              break;
            case 7:
              num3 = GuidDescriptor.E59efLolG7YDTaSfQwKL(defaultValue.GetValueOrDefault(), empty) ? 1 : 0;
              break;
            case 8:
              defaultValue = guidSettings.DefaultValue;
              num2 = 12;
              continue;
            case 9:
              goto label_10;
            case 10:
              num3 = 0;
              break;
            case 11:
              empty = Guid.Empty;
              num2 = 5;
              continue;
            case 12:
              if (defaultValue.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 1;
                continue;
              }
              goto label_10;
            default:
              if (forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 3;
                continue;
              }
              guidSettings = (GuidSettings) GuidDescriptor.XrOuDZolbUuiUckLVt9b((object) propertyMetadata);
              num2 = 4;
              continue;
          }
          if (num3 == 0)
            num2 = 9;
          else
            goto label_11;
        }
label_12:
        if (guidSettings != null)
          num1 = 8;
        else
          break;
      }
label_10:
      return (ISyntaxNode) null;
label_11:
      return guidSettings.DefaultValue.CreateGuidExpression();
label_15:
      return (ISyntaxNode) null;
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
      int num1 = 5;
      Guid guid1;
      Guid? nullable1;
      Guid? nullable2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          GuidSettings settings;
          int num3;
          Guid? nullable3;
          switch (num2)
          {
            case 1:
              if (GuidDescriptor.kQg2jaolESC4QXPNKWWv((object) propertyMetadata))
              {
                num2 = 9;
                continue;
              }
              goto case 16;
            case 2:
              goto label_3;
            case 3:
              if (propertyMetadata != null)
                goto case 1;
              else
                goto label_17;
            case 4:
              settings = (GuidSettings) propertyMetadata.Settings;
              num2 = 20;
              continue;
            case 5:
              GuidDescriptor.ahKwn5olhD8QsUJnQSsN((object) propertyMetadata, GuidDescriptor.tZI2D7olBTW3o3QCYMpY(-97972138 ^ -97953532));
              num2 = 4;
              continue;
            case 6:
              guid1 = Guid.Empty;
              num2 = 12;
              continue;
            case 7:
              nullable1 = settings.DefaultValue;
              num2 = 6;
              continue;
            case 8:
              if (!nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 11 : 11;
                continue;
              }
              goto label_34;
            case 9:
              goto label_9;
            case 10:
              num3 = 0;
              break;
            case 11:
              goto label_22;
            case 12:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                continue;
              }
              goto case 15;
            case 13:
              num3 = nullable1.GetValueOrDefault() != guid1 ? 1 : 0;
              break;
            case 14:
            case 19:
            case 21:
              nullable1 = new Guid?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 15 : 18;
              continue;
            case 15:
              num3 = 1;
              break;
            case 16:
              nullable1 = nullable2;
              num2 = 8;
              continue;
            case 17:
              if (settings != null)
                goto case 7;
              else
                goto label_24;
            case 18:
              nullable3 = nullable1;
              goto label_33;
            case 20:
              if (forFilter)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 21;
                continue;
              }
              goto case 17;
            default:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 13 : 13;
                continue;
              }
              goto case 10;
          }
          if (num3 == 0)
          {
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 10 : 14;
            continue;
          }
          nullable3 = settings.DefaultValue;
label_33:
          nullable2 = nullable3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 3;
        }
label_17:
        num1 = 16;
        continue;
label_22:
        guid1 = new Guid();
        num1 = 2;
        continue;
label_24:
        num1 = 19;
      }
label_3:
      Guid guid2 = guid1;
      goto label_35;
label_9:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<Guid?>(nullable2);
label_34:
      guid2 = nullable1.GetValueOrDefault();
label_35:
      return (IPropertyDefaultValueContainer) new PropertyValueContainer<Guid>(guid2);
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 2;
      GuidSettings forFilterProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (forFilterProperty == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 4 : 4;
              continue;
            }
            break;
          case 2:
            forFilterProperty = (GuidSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
          case 3:
          case 4:
            goto label_3;
        }
        forFilterProperty.DefaultValue = new Guid?();
        num = 3;
      }
label_3:
      return (TypeSettings) forFilterProperty;
    }

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Guid);
    }

    /// <inheritdoc />
    protected override object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      Guid? defaultValue;
      while (true)
      {
        int num2 = num1;
        GuidSettings guidSettings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (guidSettings != null)
              {
                num2 = 5;
                continue;
              }
              goto label_9;
            case 2:
              guidSettings = GuidDescriptor.XrOuDZolbUuiUckLVt9b((object) propertyMetadata) as GuidSettings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_9;
            case 4:
              goto label_11;
            case 5:
              defaultValue = guidSettings.DefaultValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            default:
              if (!defaultValue.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_6:
        defaultValue = guidSettings.DefaultValue;
        num1 = 4;
      }
label_9:
      Guid empty = Guid.Empty;
      goto label_12;
label_11:
      empty = defaultValue.Value;
label_12:
      return (object) empty;
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
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new GuidPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
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

    public GuidDescriptor()
    {
      GuidDescriptor.PoVZpKolf6cw8TOwAloA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static GuidDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            GuidDescriptor.UID = new Guid((string) GuidDescriptor.tZI2D7olBTW3o3QCYMpY(1051276242 - 990076387 ^ 61295311));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 2:
            GuidDescriptor.PoVZpKolf6cw8TOwAloA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object tZI2D7olBTW3o3QCYMpY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object du4GRbolWlDxiwNYSFyM([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool QUN7cjodzYXeVw2yVsgx() => GuidDescriptor.E5XhJsodcRii9vYOEG8V == null;

    internal static GuidDescriptor e6sAelolFZnXns09fKts() => GuidDescriptor.E5XhJsodcRii9vYOEG8V;

    internal static bool uCpA9aoloja16fkb8UX7([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static object XrOuDZolbUuiUckLVt9b([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static void ahKwn5olhD8QsUJnQSsN([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool E59efLolG7YDTaSfQwKL([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool kQg2jaolESC4QXPNKWWv([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void PoVZpKolf6cw8TOwAloA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
