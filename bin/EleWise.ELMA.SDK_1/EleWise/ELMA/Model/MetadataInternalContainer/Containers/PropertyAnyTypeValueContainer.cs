// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyAnyTypeValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers
{
  /// <summary>
  /// Контейнер-обертка хранения данных свойства контейнерного объекта AnyType типа
  /// </summary>
  internal class PropertyAnyTypeValueContainer : IPropertyDefaultValueContainer
  {
    private readonly object defaultValue;
    private readonly Type runtimeType;
    private IPropertyDefaultValueContainer propContainer;
    private static PropertyAnyTypeValueContainer Sfu5hwhWu8wkXdYpY4Rc;

    /// <summary>Ctor</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="defaultValue">Значение по умолчанию</param>
    public PropertyAnyTypeValueContainer(IPropertyMetadata propertyMetadata, object defaultValue = null)
    {
      PropertyAnyTypeValueContainer.zHTUf5hWSbr3wnRZuY5Q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 17;
      while (true)
      {
        Guid guid;
        switch (num)
        {
          case 1:
          case 2:
            if (PropertyAnyTypeValueContainer.t7ZI42hWq8UGLnEMkJ0D(this.runtimeType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 4 : 10;
              continue;
            }
            goto case 3;
          case 3:
          case 11:
          case 15:
            if (PropertyAnyTypeValueContainer.Txl1UQhWk9BHRJGpO8Vk(this.runtimeType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 16 : 3;
              continue;
            }
            goto case 13;
          case 4:
            this.runtimeType = ReflectionType.GetType((string) PropertyAnyTypeValueContainer.Oml4OfhWR64AnkUP4yQX((object) anyTypeSettings), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 12 : 1;
            continue;
          case 5:
            if (!(((IMetadataService) PropertyAnyTypeValueContainer.W1GpgrhWXaD7Ls9bWkDl()).GetTypeDescriptor(propertyMetadata.TypeUid, guid) is IRuntimeTypeDescriptor typeDescriptor))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 6 : 7;
              continue;
            }
            break;
          case 6:
            if (PropertyAnyTypeValueContainer.iAaMZYhWnIhRYVJ3q5ve((object) propertyMetadata1))
            {
              num = 14;
              continue;
            }
            goto case 13;
          case 7:
          case 9:
            if (!(guid != Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto case 19;
          case 8:
            this.runtimeType = Type.GetType(metadata.FullTypeName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 11 : 10;
            continue;
          case 10:
            if (((IMetadataService) PropertyAnyTypeValueContainer.W1GpgrhWXaD7Ls9bWkDl()).GetMetadata(guid) is ICodeItemMetadata metadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 8;
              continue;
            }
            goto case 3;
          case 12:
            if (!PropertyAnyTypeValueContainer.t7ZI42hWq8UGLnEMkJ0D(this.runtimeType, (Type) null))
            {
              num = 3;
              continue;
            }
            goto case 20;
          case 13:
            this.defaultValue = defaultValue;
            num = 18;
            continue;
          case 14:
            // ISSUE: type reference
            this.runtimeType = PropertyAnyTypeValueContainer.FHK2x1hWOZUU3pMU13Vk(__typeref (Nullable<>)).MakeGenericType(this.runtimeType);
            num = 13;
            continue;
          case 16:
            if (this.runtimeType.IsValueType)
            {
              num = 21;
              continue;
            }
            goto case 13;
          case 17:
            if (PropertyAnyTypeValueContainer.UhanTThWi5fxq17EG48k((object) propertyMetadata) is AnyTypeSettings anyTypeSettings)
            {
              num = 4;
              continue;
            }
            goto case 12;
          case 18:
            goto label_27;
          case 19:
            this.runtimeType = ((IMetadataRuntimeService) PropertyAnyTypeValueContainer.K9VluehWT6yJf3ELq5nC()).GetTypeByUidOrNull(guid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          case 20:
            guid = PropertyAnyTypeValueContainer.n9HZ2QhWK5PNjv6fURif((object) propertyMetadata);
            num = 5;
            continue;
          case 21:
            if (propertyMetadata is PropertyMetadata propertyMetadata1)
            {
              num = 6;
              continue;
            }
            goto case 13;
        }
        this.runtimeType = typeDescriptor.RuntimeType;
        num = 15;
      }
label_27:;
    }

    /// <summary>
    /// Инициализировать новый контейнер для свойства нового экземпляра контейнерного объекта
    /// </summary>
    IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.propContainer == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            Type type = typeof (PropertyValueContainer<>).MakeGenericType(this.runtimeType);
            object[] objArray;
            if (this.defaultValue == null)
              objArray = (object[]) null;
            else
              objArray = new object[1]{ this.defaultValue };
            this.propContainer = (IPropertyDefaultValueContainer) Activator.CreateInstance(type, objArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      return (IPropertyValueContainer) PropertyAnyTypeValueContainer.r98hfAhW2nkUjMtsi7n2((object) this.propContainer);
    }

    internal static void zHTUf5hWSbr3wnRZuY5Q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object UhanTThWi5fxq17EG48k([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static object Oml4OfhWR64AnkUP4yQX([In] object obj0) => (object) ((AnyTypeSettings) obj0).FullTypeName;

    internal static bool t7ZI42hWq8UGLnEMkJ0D([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Guid n9HZ2QhWK5PNjv6fURif([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object W1GpgrhWXaD7Ls9bWkDl() => (object) MetadataServiceContext.Service;

    internal static object K9VluehWT6yJf3ELq5nC() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static bool Txl1UQhWk9BHRJGpO8Vk([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool iAaMZYhWnIhRYVJ3q5ve([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static Type FHK2x1hWOZUU3pMU13Vk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool WAlGvchWIIIf2N6PTGjt() => PropertyAnyTypeValueContainer.Sfu5hwhWu8wkXdYpY4Rc == null;

    internal static PropertyAnyTypeValueContainer BePqEuhWVBnOcLH9gWU5() => PropertyAnyTypeValueContainer.Sfu5hwhWu8wkXdYpY4Rc;

    internal static object r98hfAhW2nkUjMtsi7n2([In] object obj0) => (object) ((IPropertyDefaultValueContainer) obj0).Initialize();
  }
}
