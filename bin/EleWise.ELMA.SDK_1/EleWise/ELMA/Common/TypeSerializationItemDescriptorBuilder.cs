// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.TypeSerializationItemDescriptorBuilder
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
  /// Класс-построитель для создания описания <see cref="T:EleWise.ELMA.Common.TypeSerializationItemDescriptor" />
  /// </summary>
  public class TypeSerializationItemDescriptorBuilder
  {
    private readonly TypeSerializationItemDescriptor item;
    private static TypeSerializationItemDescriptorBuilder vcJCNffVsiKQmmRpv12q;

    public TypeSerializationItemDescriptorBuilder(TypeSerializationItemDescriptor item)
    {
      TypeSerializationItemDescriptorBuilder.tqTCw0fSFSlsrcIfl4MC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          default:
            if (item != null)
            {
              this.item = item;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:
      return;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874051115));
    }

    /// <summary>Задать имя свойства</summary>
    /// <param name="name">Имя свойства</param>
    /// <returns></returns>
    public TypeSerializationItemDescriptorBuilder Name(string name)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationItemDescriptorBuilder.iD7XWCfSBbTkTacEmCGq((object) this.item, (object) name);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this;
    }

    /// <summary>Задать описание</summary>
    /// <param name="description">Строковое описание</param>
    /// <returns></returns>
    public TypeSerializationItemDescriptorBuilder Descriptor(string description)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationItemDescriptorBuilder.HsOh3YfSWAfN3dQCileU((object) this.item.Descriptor, (object) description);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Задать описание</summary>
    /// <param name="descriptor">Элемент описания</param>
    /// <returns></returns>
    public TypeSerializationItemDescriptorBuilder Descriptor(TypeSerializationDescriptor descriptor)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSerializationItemDescriptorBuilder.S9Cka5fSo30Wtf0bgure((object) this.item, (object) descriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this;
    }

    /// <summary>Задать описание</summary>
    /// <param name="descriptorBuilder">Построитель для элемента описания</param>
    /// <returns></returns>
    public TypeSerializationItemDescriptorBuilder Descriptor(
      Action<TypeSerializationDescriptorBuilder> descriptorBuilder)
    {
      if (descriptorBuilder == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372409779));
      descriptorBuilder(new TypeSerializationDescriptorBuilder(this.item.Descriptor));
      return this;
    }

    /// <summary>Сформированный элемент описания</summary>
    public TypeSerializationItemDescriptor Item => this.item;

    internal static void tqTCw0fSFSlsrcIfl4MC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool koXyXifVcsQK6qpKrJC7() => TypeSerializationItemDescriptorBuilder.vcJCNffVsiKQmmRpv12q == null;

    internal static TypeSerializationItemDescriptorBuilder YjmrJDfVzp0QhSjVEfMK() => TypeSerializationItemDescriptorBuilder.vcJCNffVsiKQmmRpv12q;

    internal static void iD7XWCfSBbTkTacEmCGq([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Name = (string) obj1;

    internal static void HsOh3YfSWAfN3dQCileU([In] object obj0, [In] object obj1) => ((TypeSerializationDescriptor) obj0).Description = (string) obj1;

    internal static void S9Cka5fSo30Wtf0bgure([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Descriptor = (TypeSerializationDescriptor) obj1;
  }
}
