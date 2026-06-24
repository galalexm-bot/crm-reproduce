// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.TypeSerializationDescriptorBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common
{
  /// <summary>
  /// Класс-построитель для создания описания <see cref="T:EleWise.ELMA.Common.TypeSerializationDescriptor" />
  /// </summary>
  public class TypeSerializationDescriptorBuilder
  {
    private readonly TypeSerializationDescriptor descriptor;
    internal static TypeSerializationDescriptorBuilder KA7YBOfVA3NUWkh0Ijxg;

    public TypeSerializationDescriptorBuilder()
    {
      TypeSerializationDescriptorBuilder.eJahdOfV0HAtNo5NCfSV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.descriptor = new TypeSerializationDescriptor();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public TypeSerializationDescriptorBuilder(TypeSerializationDescriptor descriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.descriptor = descriptor;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Условие для формирования описания</summary>
    /// <param name="condition">Условие для формирования описания</param>
    /// <param name="builder">Построитель описания элемента, вызывается в случае, если условие верно</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder If(
      bool condition,
      Action<TypeSerializationDescriptorBuilder> builder)
    {
      if (condition)
        builder(this);
      return this;
    }

    /// <summary>Задать описание данных</summary>
    /// <param name="description">Строковое описание данных</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Description(string description)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.descriptor.Description = description;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Указать тип значения</summary>
    /// <param name="type">Тип CLR</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Type(System.Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationDescriptorBuilder.KjXyuqfVmT8YE1dJEhZA((object) this.descriptor, type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Указать имя типа</summary>
    /// <param name="typeName">Имя типа</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Type(string typeName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.descriptor.TypeName = typeName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Указать, является ли массивом</summary>
    /// <param name="isArray">Признак, что элемент является массивом</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder IsArray(bool isArray = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationDescriptorBuilder.rSud15fVyfXWnS4MLNuk((object) this.descriptor, isArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>
    /// Указать, что элемент является массивом, и задать описание элемента
    /// </summary>
    /// <param name="builder">Построитель описания элемента</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder IsArray(
      Action<TypeSerializationDescriptorBuilder> builder)
    {
      this.descriptor.IsArray = true;
      this.ItemWithDescriptor((string) null, builder);
      return this;
    }

    /// <summary>
    /// Указывает, что элемент необязательный, и значение по умолчанию
    /// </summary>
    /// <param name="defaultValue">Значение по умолчанию</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Optional(object defaultValue = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationDescriptorBuilder.c8fCv8fVMiKhs9rqnSGB((object) this.descriptor, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TypeSerializationDescriptorBuilder.Ri8f3PfVJQOjSrNccQkx((object) this.descriptor, defaultValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return this;
    }

    /// <summary>Указывает, что элемент устаревший</summary>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Obsolete()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationDescriptorBuilder.PTPDlAfV9VoHFUEsnUDQ((object) this.descriptor, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Добавить вложенный элемент</summary>
    /// <param name="itemBuilder">Построитель для элемента</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Item(
      Action<TypeSerializationItemDescriptorBuilder> itemBuilder)
    {
      if (itemBuilder == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3644084));
      TypeSerializationItemDescriptor serializationItemDescriptor = new TypeSerializationItemDescriptor();
      itemBuilder(new TypeSerializationItemDescriptorBuilder(serializationItemDescriptor));
      this.descriptor.Items.Add(serializationItemDescriptor);
      return this;
    }

    /// <summary>Добавить вложенный элемент</summary>
    /// <param name="itemName">Имя элемента</param>
    /// <param name="builder">Построитель для описания элемента</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder ItemWithDescriptor(
      string itemName,
      Action<TypeSerializationDescriptorBuilder> builder)
    {
      if (builder == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909488657));
      TypeSerializationItemDescriptor serializationItemDescriptor = new TypeSerializationItemDescriptor()
      {
        Name = itemName
      };
      builder(new TypeSerializationDescriptorBuilder(serializationItemDescriptor.Descriptor));
      this.descriptor.Items.Add(serializationItemDescriptor);
      return this;
    }

    /// <summary>Добавить вложенный элемент</summary>
    /// <param name="item">Вложенный элемент</param>
    /// <returns>Построитель</returns>
    public TypeSerializationDescriptorBuilder Item(TypeSerializationItemDescriptor item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.descriptor.Items.Add(item);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Сформированный элемент описания</summary>
    public TypeSerializationDescriptor Descriptor => this.descriptor;

    internal static void eJahdOfV0HAtNo5NCfSV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zpi0JnfV7SJruRgoHSbl() => TypeSerializationDescriptorBuilder.KA7YBOfVA3NUWkh0Ijxg == null;

    internal static TypeSerializationDescriptorBuilder x8ObOAfVxRBZ15ZHNXmw() => TypeSerializationDescriptorBuilder.KA7YBOfVA3NUWkh0Ijxg;

    internal static void KjXyuqfVmT8YE1dJEhZA([In] object obj0, System.Type value) => ((TypeSerializationDescriptor) obj0).Type = value;

    internal static void rSud15fVyfXWnS4MLNuk([In] object obj0, bool value) => ((TypeSerializationDescriptor) obj0).IsArray = value;

    internal static void c8fCv8fVMiKhs9rqnSGB([In] object obj0, bool value) => ((TypeSerializationDescriptor) obj0).IsOptional = value;

    internal static void Ri8f3PfVJQOjSrNccQkx([In] object obj0, [In] object obj1) => ((TypeSerializationDescriptor) obj0).DefaultValue = obj1;

    internal static void PTPDlAfV9VoHFUEsnUDQ([In] object obj0, bool value) => ((TypeSerializationDescriptor) obj0).IsObsolete = value;
  }
}
