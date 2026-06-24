// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.BlobDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Бинарные данные"</summary>
  public class BlobDescriptor : CLRTypeDescriptor<byte[], BlobSettings>, IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{1911B22D-0CE2-4743-832F-6A44CB0357FE}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static BlobDescriptor bpEZ4Vo7ENUYtkDTs3bF;

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
          case 1:
            mapper.Type<FixedBinaryUserType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          case 2:
            BlobDescriptor.urjxZVo7CgHuL6QDGbyH((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            mapper.Length(int.MaxValue);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => BlobDescriptor.UID;

    /// <summary>Имя "Бинарные данные"</summary>
    public override string Name => (string) BlobDescriptor.coDbkYo78ehpTeK21EjB(BlobDescriptor.DyeBhlo7via361CO4kUw(1051802738 - -1831968059 ^ -1411358767));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="valueType"></param>
    /// <param name="settings"></param>
    /// <returns></returns>
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (value is byte[])
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (object) null;
label_5:
      return BlobDescriptor.zPA71Ho7ZAa8b8Ys3mj4((object) BitConverter.ToString((byte[]) value), BlobDescriptor.DyeBhlo7via361CO4kUw(1253244298 - 1829393894 ^ -576149048), (object) "");
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 8;
      byte[] numArray;
      while (true)
      {
        int length;
        string str;
        int index;
        switch (num)
        {
          case 1:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            index = 0;
            num = 6;
            continue;
          case 3:
          case 5:
            numArray[index] = BlobDescriptor.SR9wE4o7iVGFnORNPR5O(BlobDescriptor.E7Zv7Fo7SKKMhKvKsDdq((object) str, index * 2, 2), 16);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
            continue;
          case 4:
            goto label_16;
          case 7:
            goto label_19;
          case 8:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 7 : 7;
              continue;
            }
            if (!(deserializeToType == (Type) null))
            {
              // ISSUE: type reference
              if (BlobDescriptor.HNIRtUo7I3YZVYKHDGYj(deserializeToType, BlobDescriptor.oJspKro7uFr0cRY86MHX(__typeref (byte[]))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 8 : 10;
                continue;
              }
              break;
            }
            num = 4;
            continue;
          case 9:
            length = BlobDescriptor.K1yldjo7VjYZF7ty3Afn((object) str) / 2;
            num = 11;
            continue;
          case 10:
            // ISSUE: type reference
            if (BlobDescriptor.HNIRtUo7I3YZVYKHDGYj(deserializeToType, BlobDescriptor.oJspKro7uFr0cRY86MHX(__typeref (object))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 12 : 12;
              continue;
            }
            break;
          case 11:
            numArray = new byte[length];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
            continue;
          case 12:
            goto label_3;
          case 13:
            goto label_15;
          default:
            if (index < length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 2;
              continue;
            }
            goto label_15;
        }
        str = value.ToString();
        num = 9;
      }
label_3:
      throw new ArgumentOutOfRangeException((string) BlobDescriptor.DyeBhlo7via361CO4kUw(-420743386 ^ -420757854), (string) BlobDescriptor.coDbkYo78ehpTeK21EjB(BlobDescriptor.DyeBhlo7via361CO4kUw(1232639661 >> 3 ^ 153982027)));
label_15:
      return (object) numArray;
label_16:
      throw new ArgumentNullException((string) BlobDescriptor.DyeBhlo7via361CO4kUw(-1710575414 ^ -1710556850));
label_19:
      throw new ArgumentNullException((string) BlobDescriptor.DyeBhlo7via361CO4kUw(-35995181 ^ -36009819));
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary, int.MaxValue);
    }

    public BlobDescriptor()
    {
      BlobDescriptor.F938Hwo7RVNUFhxmD0tR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static BlobDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BlobDescriptor.UID = new Guid((string) BlobDescriptor.DyeBhlo7via361CO4kUw(~210725948 ^ -210627375));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 2:
            BlobDescriptor.F938Hwo7RVNUFhxmD0tR();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void urjxZVo7CgHuL6QDGbyH([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<byte[]>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool W28pCdo7ffeWYOSjGBJF() => BlobDescriptor.bpEZ4Vo7ENUYtkDTs3bF == null;

    internal static BlobDescriptor AI8Nmxo7QA5chlb8bSJy() => BlobDescriptor.bpEZ4Vo7ENUYtkDTs3bF;

    internal static object DyeBhlo7via361CO4kUw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object coDbkYo78ehpTeK21EjB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object zPA71Ho7ZAa8b8Ys3mj4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static Type oJspKro7uFr0cRY86MHX([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool HNIRtUo7I3YZVYKHDGYj([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static int K1yldjo7VjYZF7ty3Afn([In] object obj0) => ((string) obj0).Length;

    internal static object E7Zv7Fo7SKKMhKvKsDdq([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static byte SR9wE4o7iVGFnORNPR5O([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static void F938Hwo7RVNUFhxmD0tR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
