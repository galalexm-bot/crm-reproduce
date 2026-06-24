// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.PropertyFormItemData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.API.Models
{
  /// <summary>
  /// Данные для элемента формы (параметры отображения свойства). Используется в WebAPI
  /// </summary>
  public class PropertyFormItemData
  {
    private static PropertyFormItemData wYFVhJfNcmeilXtQpiCG;

    /// <summary>Имя свойства</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Описание</summary>
    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор типа</summary>
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор подтипа</summary>
    public Guid SubTypeUid
    {
      get => this.\u003CSubTypeUid\u003Ek__BackingField;
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
              this.\u003CSubTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    /// <summary>Настройки свойства</summary>
    public TypeSettings Settings
    {
      get => this.\u003CSettings\u003Ek__BackingField;
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
              this.\u003CSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    /// <summary>Обязательно для заполнения</summary>
    public bool Required
    {
      get => this.\u003CRequired\u003Ek__BackingField;
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
              this.\u003CRequired\u003Ek__BackingField = value;
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

    /// <summary>Только для чтения</summary>
    public bool ReadOnly
    {
      get => this.\u003CReadOnly\u003Ek__BackingField;
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
              this.\u003CReadOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>Видимость</summary>
    public bool Visible
    {
      get => this.\u003CVisible\u003Ek__BackingField;
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
              this.\u003CVisible\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>
    /// Используется пользовательское предстваление для отображения
    /// </summary>
    public bool CustomView
    {
      get => this.\u003CCustomView\u003Ek__BackingField;
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
              this.\u003CCustomView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Не показываеть свойство, если оно не заполнено</summary>
    public bool HideEmpty
    {
      get => this.\u003CHideEmpty\u003Ek__BackingField;
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
              this.\u003CHideEmpty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>
    /// Уникальный идентификатор провайдера фильтрации значений
    /// </summary>
    public Guid FilterProviderUid
    {
      get => this.\u003CFilterProviderUid\u003Ek__BackingField;
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
              this.\u003CFilterProviderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>Данные для провайдера фильтрации значений</summary>
    public string FilterProviderData
    {
      get => this.\u003CFilterProviderData\u003Ek__BackingField;
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
              this.\u003CFilterProviderData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Список вложенных элементов формы</summary>
    public List<PropertyFormItemData> Items { get; set; }

    public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_10;
          case 1:
            TypeSerializationDescriptorBuilder descriptorBuilder1 = builder.ItemWithDescriptor((string) PropertyFormItemData.Names.Name, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s(PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3(PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(--1867379187 ^ 1867473231))), PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (string)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            object displayName = PropertyFormItemData.Names.DisplayName;
            // ISSUE: reference to a compiler-generated field
            Action<TypeSerializationDescriptorBuilder> action1 = PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_1;
            Action<TypeSerializationDescriptorBuilder> builder1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_1 = builder1 = (Action<TypeSerializationDescriptorBuilder>) (i =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s(PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3(PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(1021410165 ^ 1021401313))), PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (string)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_16;
label_4:
            TypeSerializationDescriptorBuilder descriptorBuilder2 = descriptorBuilder1.ItemWithDescriptor((string) displayName, builder1);
            object description = PropertyFormItemData.Names.Description;
            // ISSUE: reference to a compiler-generated field
            Action<TypeSerializationDescriptorBuilder> action2 = PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_2;
            Action<TypeSerializationDescriptorBuilder> builder2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_2 = builder2 = (Action<TypeSerializationDescriptorBuilder>) (i =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s((object) i.Description((string) PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397275008))), PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (string)))).Optional();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_15;
label_6:
            TypeSerializationDescriptorBuilder descriptorBuilder3 = descriptorBuilder2.ItemWithDescriptor((string) description, builder2).ItemWithDescriptor((string) PropertyFormItemData.Names.TypeUid, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(~-397266137 ^ 397139322)))).Type(typeof (Guid));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.SubTypeUid, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s(PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3(PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(333888594 ^ 1075625116 ^ 1409028384))), PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (Guid)))).Optional();
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            object settings = PropertyFormItemData.Names.Settings;
            // ISSUE: reference to a compiler-generated field
            Action<TypeSerializationDescriptorBuilder> action3 = PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_5;
            Action<TypeSerializationDescriptorBuilder> builder3;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_5 = builder3 = (Action<TypeSerializationDescriptorBuilder>) (i =>
              {
                int num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s(PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3(PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(2045296739 + 1688595713 ^ -561463312))), typeof (WebData))).Optional();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_14;
label_9:
            TypeSerializationDescriptorBuilder descriptorBuilder4 = descriptorBuilder3.ItemWithDescriptor((string) settings, builder3).ItemWithDescriptor((string) PropertyFormItemData.Names.Required, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num8 = 1;
              while (true)
              {
                switch (num8)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s((object) i.Description(EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(322893104 - -1992822529 ^ -1979640013))), typeof (bool))).Optional();
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.ReadOnly, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num9 = 1;
              while (true)
              {
                switch (num9)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(-1852837372 ^ -1853234842)))).Type(PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (bool))).Optional();
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.Visible, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num10 = 1;
              while (true)
              {
                switch (num10)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(-649342099 - -1150814748 ^ 501599849)))).Type(typeof (bool)).Optional();
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            object customView = PropertyFormItemData.Names.CustomView;
            // ISSUE: reference to a compiler-generated field
            Action<TypeSerializationDescriptorBuilder> action4 = PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_9;
            Action<TypeSerializationDescriptorBuilder> builder4;
            if (action4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__57_9 = builder4 = (Action<TypeSerializationDescriptorBuilder>) (i =>
              {
                int num11 = 1;
                while (true)
                {
                  switch (num11)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.jNy8JBZWv9JHQk4u6G3s(PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, PropertyFormItemData.\u003C\u003Ec.yGC5ScZWf9nfaixW7hQ3((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138830888))), PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (bool)))).Optional();
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_13;
label_12:
            descriptorBuilder4.ItemWithDescriptor((string) customView, builder4).ItemWithDescriptor((string) PropertyFormItemData.Names.HideEmpty, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num12 = 1;
              while (true)
              {
                switch (num12)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(--1867379187 ^ 1867244867)))).Type(typeof (bool)).Optional();
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.FilterProviderUid, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num13 = 1;
              while (true)
              {
                switch (num13)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(1994213607 >> 4 ^ 124502442)))).Type(typeof (Guid)).Optional();
                    num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.FilterProviderData, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num14 = 1;
              while (true)
              {
                switch (num14)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647514716)))).Type(PropertyFormItemData.\u003C\u003Ec.rKw23WZWCuhIKJFN00cB(__typeref (string))).Optional();
                    num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            })).ItemWithDescriptor((string) PropertyFormItemData.Names.Items, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num15 = 1;
              while (true)
              {
                switch (num15)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) PropertyFormItemData.\u003C\u003Ec.qokZiwZWQhfaSWOPZbcj((object) i, (object) EleWise.ELMA.SR.T((string) PropertyFormItemData.\u003C\u003Ec.NCt9LZZWEYDvcbgHsdYy(-643786247 ^ -643396587)))).Optional();
                    num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
label_13:
            builder4 = action4;
            goto label_12;
label_14:
            builder3 = action3;
            goto label_9;
label_15:
            builder2 = action2;
            goto label_6;
label_16:
            builder1 = action1;
            goto label_4;
          default:
            goto label_7;
        }
      }
label_10:
      return;
label_7:;
    }

    public WebData ToWebData()
    {
      int num1 = 30;
      Dictionary<string, object> dicObj;
      while (true)
      {
        int num2 = num1;
        SerializableDictionary<string, object> jsonObject;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 32:
              if (PropertyFormItemData.IX7BtBf3WMiW0nBdr7XG(this.FilterProviderUid, Guid.Empty))
              {
                num2 = 15;
                continue;
              }
              goto case 9;
            case 2:
              if (!this.CustomView)
              {
                num2 = 35;
                continue;
              }
              goto case 3;
            case 3:
              dicObj[(string) PropertyFormItemData.Names.CustomView] = (object) this.CustomView;
              num2 = 34;
              continue;
            case 4:
              if (!PropertyFormItemData.qHJW84f3B2ASZ0uIPaSU((object) this.Description))
              {
                num2 = 22;
                continue;
              }
              goto case 16;
            case 5:
              dicObj[(string) PropertyFormItemData.Names.SubTypeUid] = (object) this.SubTypeUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 20;
              continue;
            case 6:
            case 23:
            case 26:
              if (!this.Required)
              {
                num2 = 12;
                continue;
              }
              goto case 11;
            case 7:
              goto label_17;
            case 8:
              goto label_46;
            case 9:
              if (this.Items != null)
              {
                num2 = 25;
                continue;
              }
              goto label_17;
            case 10:
            case 20:
              if (this.Settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 26;
                continue;
              }
              goto case 19;
            case 11:
              dicObj[(string) PropertyFormItemData.Names.Required] = (object) this.Required;
              num2 = 33;
              continue;
            case 12:
            case 33:
              if (this.ReadOnly)
              {
                num2 = 36;
                continue;
              }
              goto default;
            case 13:
              if (!PropertyFormItemData.IX7BtBf3WMiW0nBdr7XG(this.FilterProviderUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                continue;
              }
              goto case 14;
            case 14:
              dicObj[(string) PropertyFormItemData.Names.FilterProviderUid] = (object) this.FilterProviderUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 32 : 14;
              continue;
            case 15:
              dicObj[(string) PropertyFormItemData.Names.FilterProviderData] = (object) this.FilterProviderData;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 9;
              continue;
            case 16:
              dicObj[(string) PropertyFormItemData.Names.TypeUid] = (object) this.TypeUid;
              num2 = 24;
              continue;
            case 17:
              this.Settings.SerializeToJsonObject(jsonObject);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 31 : 21;
              continue;
            case 18:
              dicObj[(string) PropertyFormItemData.Names.Settings] = (object) jsonObject;
              num2 = 6;
              continue;
            case 19:
              jsonObject = new SerializableDictionary<string, object>();
              num2 = 17;
              continue;
            case 21:
              dicObj[(string) PropertyFormItemData.Names.Visible] = (object) this.Visible;
              num2 = 2;
              continue;
            case 22:
              dicObj[(string) PropertyFormItemData.Names.Description] = (object) this.Description;
              num2 = 16;
              continue;
            case 24:
              if (!PropertyFormItemData.IX7BtBf3WMiW0nBdr7XG(this.SubTypeUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 10 : 6;
                continue;
              }
              goto case 5;
            case 25:
              if (PropertyFormItemData.l83Ii7f3bRRcJmsuD2fI((object) this.Items) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 5 : 8;
                continue;
              }
              goto label_17;
            case 27:
              dicObj[(string) PropertyFormItemData.Names.DisplayName] = (object) this.DisplayName;
              num2 = 4;
              continue;
            case 28:
              dicObj[(string) PropertyFormItemData.Names.HideEmpty] = (object) this.HideEmpty;
              num2 = 13;
              continue;
            case 29:
              dicObj[(string) PropertyFormItemData.Names.Name] = (object) this.Name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 27 : 16;
              continue;
            case 30:
              dicObj = new Dictionary<string, object>();
              num2 = 29;
              continue;
            case 31:
              if (PropertyFormItemData.XgLyv7f3oRR8vJxSMvS8((object) jsonObject) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 5 : 23;
                continue;
              }
              goto case 18;
            case 34:
            case 35:
              if (this.HideEmpty)
              {
                num2 = 28;
                continue;
              }
              goto case 13;
            case 36:
              dicObj[(string) PropertyFormItemData.Names.ReadOnly] = (object) this.ReadOnly;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            default:
              if (!this.Visible)
              {
                num2 = 21;
                continue;
              }
              goto case 2;
          }
        }
label_46:
        Dictionary<string, object> dictionary = dicObj;
        object items1 = PropertyFormItemData.Names.Items;
        List<PropertyFormItemData> items2 = this.Items;
        // ISSUE: reference to a compiler-generated field
        Func<PropertyFormItemData, WebData> func = PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__58_0;
        Func<PropertyFormItemData, WebData> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          PropertyFormItemData.\u003C\u003Ec.\u003C\u003E9__58_0 = selector = (Func<PropertyFormItemData, WebData>) (fi => (WebData) PropertyFormItemData.\u003C\u003Ec.XDGCrkZW8Iexb8MxTc55((object) fi));
        }
        else
          goto label_49;
label_48:
        SerializableList<object> serializableList = new SerializableList<object>((IEnumerable<object>) items2.Select<PropertyFormItemData, WebData>(selector));
        dictionary[(string) items1] = (object) serializableList;
        num1 = 7;
        continue;
label_49:
        selector = func;
        goto label_48;
      }
label_17:
      return new WebData((IDictionary<string, object>) dicObj);
    }

    public PropertyFormItemData()
    {
      PropertyFormItemData.xKNc5Mf3hwx2DyvTSEdN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool bTjvYIfNzkc5pT1KT2eC() => PropertyFormItemData.wYFVhJfNcmeilXtQpiCG == null;

    internal static PropertyFormItemData sOlPZNf3FuQ9DMkHVf2l() => PropertyFormItemData.wYFVhJfNcmeilXtQpiCG;

    internal static bool qHJW84f3B2ASZ0uIPaSU([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool IX7BtBf3WMiW0nBdr7XG([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int XgLyv7f3oRR8vJxSMvS8([In] object obj0) => ((Dictionary<string, object>) obj0).Count;

    internal static int l83Ii7f3bRRcJmsuD2fI([In] object obj0) => ((List<PropertyFormItemData>) obj0).Count;

    internal static void xKNc5Mf3hwx2DyvTSEdN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private static class Names
    {
      public static readonly object Name;
      public static readonly object DisplayName;
      public static readonly object Description;
      public static readonly object TypeUid;
      public static readonly object SubTypeUid;
      public static readonly object Settings;
      public static readonly object Required;
      public static readonly object ReadOnly;
      public static readonly object Visible;
      public static readonly object CustomView;
      public static readonly object HideEmpty;
      public static readonly object FilterProviderUid;
      public static readonly object FilterProviderData;
      public static readonly object Items;
      internal static object eowwtaZBjULBG7ryXQh6;

      static Names()
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          ParameterExpression parameterExpression1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                parameterExpression1 = Expression.Parameter(typeof (PropertyFormItemData), (string) PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(-1921202237 ^ -1921240493));
                num2 = 13;
                continue;
              case 2:
                // ISSUE: method reference
                PropertyFormItemData.Names.Name = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_Name))), parameterExpression1));
                num2 = 14;
                continue;
              case 3:
                goto label_16;
              case 4:
                goto label_3;
              case 5:
                goto label_18;
              case 6:
                parameterExpression1 = Expression.Parameter(typeof (PropertyFormItemData), (string) PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(-675505729 ^ -675517393));
                num2 = 17;
                continue;
              case 7:
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(typeof (PropertyFormItemData), PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(-1204263869 ^ -1341583247 ^ 137462178));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 2;
                continue;
              case 8:
                PropertyFormItemData.Names.Wrr2XeZBUDndRRS6ZrcV();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 7 : 1;
                continue;
              case 9:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(92412609 - 1050237057 ^ -957859888));
                num2 = 24;
                continue;
              case 10:
                // ISSUE: method reference
                PropertyFormItemData.Names.TypeUid = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.dnLcZIZWWN8V7YxQdoMK((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyFormItemData.get_TypeUid))), typeof (object)), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                continue;
              case 11:
                // ISSUE: method reference
                PropertyFormItemData.Names.Items = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_Items))), parameterExpression1));
                num2 = 4;
                continue;
              case 12:
                // ISSUE: method reference
                PropertyFormItemData.Names.Required = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Convert((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_Required))), typeof (object)), parameterExpression1));
                num2 = 21;
                continue;
              case 13:
                // ISSUE: method reference
                // ISSUE: type reference
                PropertyFormItemData.Names.SubTypeUid = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Convert((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_SubTypeUid))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
                num2 = 5;
                continue;
              case 14:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521213488));
                num2 = 29;
                continue;
              case 15:
                // ISSUE: method reference
                // ISSUE: type reference
                PropertyFormItemData.Names.HideEmpty = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.dnLcZIZWWN8V7YxQdoMK(PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_HideEmpty))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 6;
                continue;
              case 16:
                // ISSUE: type reference
                parameterExpression1 = Expression.Parameter(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951452554));
                num2 = 15;
                continue;
              case 17:
                // ISSUE: method reference
                // ISSUE: type reference
                PropertyFormItemData.Names.FilterProviderUid = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Convert((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_FilterProviderUid))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 26 : 1;
                continue;
              case 18:
                // ISSUE: method reference
                // ISSUE: type reference
                PropertyFormItemData.Names.Visible = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.dnLcZIZWWN8V7YxQdoMK(PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_Visible))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
                num2 = 22;
                continue;
              case 19:
                // ISSUE: type reference
                parameterExpression1 = Expression.Parameter(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), (string) PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(1113862659 ^ 1113900947));
                num2 = 10;
                continue;
              case 20:
                // ISSUE: method reference
                PropertyFormItemData.Names.Settings = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_Settings))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 16 : 27;
                continue;
              case 21:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(589593376 ^ -1977315327 ^ -1459609935));
                num2 = 3;
                continue;
              case 22:
                // ISSUE: type reference
                parameterExpression1 = Expression.Parameter(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), (string) PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(1033719030 - 2012070891 ^ -978355045));
                num2 = 25;
                continue;
              case 23:
                parameterExpression1 = Expression.Parameter(typeof (PropertyFormItemData), z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236117087));
                num2 = 18;
                continue;
              case 24:
                PropertyFormItemData.Names.Description = (object) LinqUtils.NameOf<PropertyFormItemData>((Expression<Func<PropertyFormItemData, object>>) (parameterExpression => parameterExpression.Description));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 18 : 19;
                continue;
              case 25:
                goto label_23;
              case 26:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501426201));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 15 : 28;
                continue;
              case 27:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(1574260816 ^ 1574282688));
                num2 = 12;
                continue;
              case 28:
                // ISSUE: method reference
                PropertyFormItemData.Names.FilterProviderData = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_FilterProviderData))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              case 29:
                goto label_25;
              default:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), PropertyFormItemData.Names.cqJ2P5ZBsnAst2Pxul1C(-342626196 - 1290888215 ^ -1633519163));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 11 : 4;
                continue;
            }
          }
label_16:
          // ISSUE: method reference
          // ISSUE: type reference
          PropertyFormItemData.Names.ReadOnly = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.dnLcZIZWWN8V7YxQdoMK((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_ReadOnly))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
          num1 = 23;
          continue;
label_18:
          // ISSUE: type reference
          parameterExpression1 = (ParameterExpression) PropertyFormItemData.Names.peqy9XZBc1qmQSMTBJnr(PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (PropertyFormItemData)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138130456));
          num1 = 20;
          continue;
label_23:
          // ISSUE: method reference
          // ISSUE: type reference
          PropertyFormItemData.Names.CustomView = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_CustomView))), PropertyFormItemData.Names.upMAZlZWFuHm1A8ZDAKr(__typeref (object))), parameterExpression1));
          num1 = 16;
          continue;
label_25:
          // ISSUE: method reference
          PropertyFormItemData.Names.DisplayName = (object) LinqUtils.NameOf<PropertyFormItemData>(Expression.Lambda<Func<PropertyFormItemData, object>>((Expression) PropertyFormItemData.Names.RsDXxyZWBgZACmrxVC7k((object) parameterExpression1, (object) (MethodInfo) PropertyFormItemData.Names.Pk8mnKZBzZtxlvEjS1w1(__methodref (PropertyFormItemData.get_DisplayName))), parameterExpression1));
          num1 = 9;
        }
label_3:;
      }

      internal static void Wrr2XeZBUDndRRS6ZrcV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object cqJ2P5ZBsnAst2Pxul1C(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object peqy9XZBc1qmQSMTBJnr([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

      internal static object Pk8mnKZBzZtxlvEjS1w1([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

      internal static Type upMAZlZWFuHm1A8ZDAKr([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object RsDXxyZWBgZACmrxVC7k([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

      internal static object dnLcZIZWWN8V7YxQdoMK([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

      internal static bool fkkn87ZBY5BClSMf8UyP() => PropertyFormItemData.Names.eowwtaZBjULBG7ryXQh6 == null;

      internal static PropertyFormItemData.Names uYuKtjZBL2ZFNU7fye82() => (PropertyFormItemData.Names) PropertyFormItemData.Names.eowwtaZBjULBG7ryXQh6;
    }
  }
}
