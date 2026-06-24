// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.TypeSerializationItemDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Common
{
  /// <summary>Элемент описания данных</summary>
  [DataContract]
  [Serializable]
  public sealed class TypeSerializationItemDescriptor : ICloneable
  {
    private static TypeSerializationItemDescriptor EOg6pufVdyqJ505uhLE4;

    public TypeSerializationItemDescriptor()
    {
      TypeSerializationItemDescriptor.d0WAKvfVgUcr90gb5lxy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Descriptor = new TypeSerializationDescriptor();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Имя свойства</summary>
    [DataMember]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Описание значения свойства</summary>
    [DataMember]
    public TypeSerializationDescriptor Descriptor
    {
      get => this.\u003CDescriptor\u003Ek__BackingField;
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
              this.\u003CDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    public override string ToString()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(this.Name))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (string) TypeSerializationItemDescriptor.V6LT0yfVjATvrosCFgZf(TypeSerializationItemDescriptor.FxubwafV5iOfp53Afdey(95909607 + 343705423 ^ 439795636), (object) this.Name, (object) this.Descriptor);
label_5:
      return this.Descriptor.ToString();
    }

    public TypeSerializationItemDescriptor Clone() => (TypeSerializationItemDescriptor) ((ICloneable) this).Clone();

    /// <summary>
    /// Создает новый объект, который является копией текущего экземпляра.
    /// </summary>
    /// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
    object ICloneable.Clone()
    {
      TypeSerializationItemDescriptor serializationItemDescriptor = new TypeSerializationItemDescriptor();
      TypeSerializationItemDescriptor.C2iApRfVY5KnqgGxHE1y((object) serializationItemDescriptor, (object) this.Name);
      TypeSerializationItemDescriptor.Enu7p6fVU7WtIy38wiAh((object) serializationItemDescriptor, TypeSerializationItemDescriptor.r3CtPEfVLn3qJ8IP2tHL((object) this.Descriptor));
      return (object) serializationItemDescriptor;
    }

    internal static void d0WAKvfVgUcr90gb5lxy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GjnQHMfVlpecfg29J45A() => TypeSerializationItemDescriptor.EOg6pufVdyqJ505uhLE4 == null;

    internal static TypeSerializationItemDescriptor teAhfQfVrDUdJU739aET() => TypeSerializationItemDescriptor.EOg6pufVdyqJ505uhLE4;

    internal static object FxubwafV5iOfp53Afdey(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object V6LT0yfVjATvrosCFgZf([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void C2iApRfVY5KnqgGxHE1y([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Name = (string) obj1;

    internal static object r3CtPEfVLn3qJ8IP2tHL([In] object obj0) => (object) ((TypeSerializationDescriptor) obj0).Clone();

    internal static void Enu7p6fVU7WtIy38wiAh([In] object obj0, [In] object obj1) => ((TypeSerializationItemDescriptor) obj0).Descriptor = (TypeSerializationDescriptor) obj1;
  }
}
