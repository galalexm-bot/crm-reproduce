// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntitySerializationSelector
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  public class EntitySerializationSelector
  {
    /// <summary>
    /// Имя свойства сущности, обозначающее строкое представление сущности
    /// </summary>
    public const string ToStringPropertyName = "$toString";
    private static EntitySerializationSelector UWjn7ABrFMbVIwYoIv9u;

    public static EntitySerializationSelector GetFromParent(
      EntitySerializationSelector parentSelector,
      string propertyName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentSelector.Properties == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 3;
              continue;
            }
            goto case 4;
          case 2:
            if (parentSelector != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          case 4:
            if (!parentSelector.Properties.ContainsKey(propertyName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (EntitySerializationSelector) null;
label_5:
      return parentSelector.Properties[propertyName];
    }

    public static EntitySerializationSelector CreateFromSelect(
      string selectPath,
      EntityMetadata entityMd)
    {
      int num = 29;
      EntitySerializationSelector fromSelect;
      string selectPath1;
      string rootPropertyName;
      while (true)
      {
        IPropertyMetadata propertyMetadata;
        var data;
        IMetadataRuntimeService serviceNotNull;
        int index;
        \u003C\u003Ef__AnonymousType20<string, string>[] array;
        EntityMetadata entityMetadata1;
        EntityMetadata entityMetadata2;
        switch (num)
        {
          case 1:
            fromSelect = new EntitySerializationSelector();
            num = 5;
            continue;
          case 2:
            fromSelect.SelectionMode = SelectionMode.All;
            num = 33;
            continue;
          case 3:
            goto label_35;
          case 4:
            goto label_48;
          case 5:
            if (!EntitySerializationSelector.QoV7OCBrblOuScDZy33Y((object) selectPath, EntitySerializationSelector.n15C9UBro8cWD09enG23(-867826612 ^ -867805668)))
            {
              num = 30;
              continue;
            }
            goto case 25;
          case 6:
            if (!EntitySerializationSelector.QoV7OCBrblOuScDZy33Y((object) rootPropertyName, EntitySerializationSelector.n15C9UBro8cWD09enG23(-281842504 ^ -281929276)))
            {
              num = 20;
              continue;
            }
            goto case 21;
          case 7:
            goto label_13;
          case 8:
            object source1 = EntitySerializationSelector.Qg0iasBrECsXqmTVodp5((object) selectPath, (object) new string[1]
            {
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813616417)
            }, StringSplitOptions.RemoveEmptyEntries);
            if (source1.Length != 0)
            {
              fromSelect.Properties = new Dictionary<string, EntitySerializationSelector>();
              EntitySerializationSelector.HVpE4jBrh7BQhlMFOsiJ((object) fromSelect, SelectionMode.ByName);
            }
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            // ISSUE: reference to a compiler-generated field
            Func<string, bool> func1 = EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<string, bool> predicate;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate = (Func<string, bool>) (p => !EntitySerializationSelector.\u003C\u003Ec.yyvlqcQ2sgMYs8cev2wE((object) p));
            }
            else
              goto label_62;
label_53:
            IEnumerable<string> source2 = ((IEnumerable<string>) source1).Where<string>(predicate);
            // ISSUE: reference to a compiler-generated field
            Func<string, string[]> func2 = EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_1;
            Func<string, string[]> selector1;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_1 = selector1 = (Func<string, string[]>) (p => (string[]) EntitySerializationSelector.\u003C\u003Ec.bqwamTQ2ztB9uevo0gPS((object) p, (object) new string[1]
              {
                (string) EntitySerializationSelector.\u003C\u003Ec.vP0I6JQ2ce5tqpwMjUf9(236071375 ^ 236080543)
              }, StringSplitOptions.RemoveEmptyEntries));
            }
            else
              goto label_2;
label_55:
            IEnumerable<string[]> source3 = source2.Select<string, string[]>(selector1);
            // ISSUE: reference to a compiler-generated field
            Func<string[], \u003C\u003Ef__AnonymousType19<string, string>> func3 = EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_2;
            Func<string[], \u003C\u003Ef__AnonymousType19<string, string>> selector2;
            if (func3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: object of a compiler-generated type is created
              EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_2 = selector2 = pl => new \u003C\u003Ef__AnonymousType19<string, string>(pl[0], string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398686964), pl.Length > 1 ? ((IEnumerable<string>) pl).Skip<string>(1).ToArray<string>() : new string[0]));
            }
            else
              goto label_4;
label_57:
            IEnumerable<IGrouping<string, \u003C\u003Ef__AnonymousType19<string, string>>> source4 = source3.Select(selector2).GroupBy(t => t.r);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, \u003C\u003Ef__AnonymousType19<string, string>>, \u003C\u003Ef__AnonymousType20<string, string>> func4 = EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_4;
            Func<IGrouping<string, \u003C\u003Ef__AnonymousType19<string, string>>, \u003C\u003Ef__AnonymousType20<string, string>> selector3;
            if (func4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: object of a compiler-generated type is created
              EntitySerializationSelector.\u003C\u003Ec.\u003C\u003E9__2_4 = selector3 = g => new \u003C\u003Ef__AnonymousType20<string, string>(g.Key, string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841370432), g.Select(t => t.s)));
            }
            else
              goto label_7;
label_59:
            array = source4.Select(selector3).ToArray();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 35 : 20;
            continue;
label_7:
            selector3 = func4;
            goto label_59;
label_4:
            selector2 = func3;
            goto label_57;
label_2:
            selector1 = func2;
            goto label_55;
label_62:
            predicate = func1;
            goto label_53;
          case 9:
          case 23:
          case 31:
          case 33:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 10:
            goto label_28;
          case 11:
            if (!(propertyMetadata is TablePartMetadata))
            {
              num = 22;
              continue;
            }
            entityMetadata2 = propertyMetadata as EntityMetadata;
            break;
          case 12:
            fromSelect.Properties.Add(rootPropertyName, (EntitySerializationSelector) EntitySerializationSelector.Q8f3S9Br8uO2HRre8aFK((object) selectPath1, (object) entityMetadata1));
            num = 23;
            continue;
          case 13:
            if (entityMetadata1 == null)
            {
              num = 19;
              continue;
            }
            goto case 12;
          case 14:
          case 16:
            data = array[index];
            num = 36;
            continue;
          case 15:
            if (EntitySerializationSelector.QoV7OCBrblOuScDZy33Y((object) rootPropertyName, EntitySerializationSelector.n15C9UBro8cWD09enG23(572119659 - -337058038 ^ 909156657)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 2;
              continue;
            }
            goto case 6;
          case 17:
            goto label_9;
          case 18:
            if (propertyMetadata != null)
            {
              selectPath1 = data.SelectPath;
              num = 11;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 8 : 17;
            continue;
          case 19:
            if (!EntitySerializationSelector.IcNJICBrGPXwynum58Td((object) selectPath1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 7 : 0;
              continue;
            }
            fromSelect.Properties.Add(rootPropertyName, new EntitySerializationSelector()
            {
              SelectionMode = SelectionMode.Default
            });
            num = 31;
            continue;
          case 20:
          case 24:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata = entityMd.GetPropertiesAndTableParts().FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => EntitySerializationSelector.\u003C\u003Ec__DisplayClass2_0.o6O9K3Q25YclBjYZoca2(EntitySerializationSelector.\u003C\u003Ec__DisplayClass2_0.L2qvflQ2gMCq2Tb4StMO((object) p), (object) rootPropertyName)));
            num = 18;
            continue;
          case 21:
            Dictionary<string, EntitySerializationSelector> properties = fromSelect.Properties;
            string key = rootPropertyName;
            EntitySerializationSelector serializationSelector = new EntitySerializationSelector();
            EntitySerializationSelector.HVpE4jBrh7BQhlMFOsiJ((object) serializationSelector, SelectionMode.Default);
            properties.Add(key, serializationSelector);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 7 : 9;
            continue;
          case 22:
            entityMetadata2 = serviceNotNull.GetMetadata(EntitySerializationSelector.XoQJC0BrCSTKVHfnUAe3((object) propertyMetadata)) as EntityMetadata;
            break;
          case 25:
            EntitySerializationSelector.HVpE4jBrh7BQhlMFOsiJ((object) fromSelect, SelectionMode.All);
            num = 3;
            continue;
          case 27:
            EntitySerializationSelector.HVpE4jBrh7BQhlMFOsiJ((object) fromSelect, SelectionMode.Default);
            num = 4;
            continue;
          case 28:
            goto label_40;
          case 29:
            if (selectPath == null)
            {
              num = 28;
              continue;
            }
            if (entityMd != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            }
            goto label_28;
          case 30:
            if (!EntitySerializationSelector.IcNJICBrGPXwynum58Td((object) selectPath))
            {
              num = 8;
              continue;
            }
            goto case 27;
          case 32:
            rootPropertyName = data.Root;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 15 : 2;
            continue;
          case 34:
            goto label_33;
          case 35:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 26 : 16;
            continue;
          case 36:
            num = 32;
            continue;
          default:
            if (index < array.Length)
            {
              num = 16;
              continue;
            }
            goto label_33;
        }
        entityMetadata1 = entityMetadata2;
        num = 13;
      }
label_9:
      throw new ArgumentOutOfRangeException((string) EntitySerializationSelector.n15C9UBro8cWD09enG23(372753449 ^ 372683129), (string) EntitySerializationSelector.YEueUNBrQ1JM1h5Qq0h0(EntitySerializationSelector.n15C9UBro8cWD09enG23(1642859704 ^ 1642953002), (object) rootPropertyName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3386958), EntitySerializationSelector.xCPj4qBrffKC0HQOIpJn((object) entityMd)));
label_13:
      throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138097880), (string) EntitySerializationSelector.HcmSmNBrvpke5QCFHISR(EntitySerializationSelector.n15C9UBro8cWD09enG23(-1876063057 ^ -1876100739), (object) selectPath1, EntitySerializationSelector.n15C9UBro8cWD09enG23(-1710575414 ^ -1710504654)));
label_28:
      throw new ArgumentNullException((string) EntitySerializationSelector.n15C9UBro8cWD09enG23(-1839087379 - 334718690 ^ 2121215843));
label_33:
      return fromSelect;
label_35:
      return fromSelect;
label_40:
      throw new ArgumentNullException((string) EntitySerializationSelector.n15C9UBro8cWD09enG23(~210725948 ^ -210639213));
label_48:
      return fromSelect;
    }

    public Dictionary<string, EntitySerializationSelector> Properties { get; set; }

    public SelectionMode SelectionMode
    {
      get => this.\u003CSelectionMode\u003Ek__BackingField;
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
              this.\u003CSelectionMode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    public EntitySerializationSelector GetSelector(string propertyName)
    {
      int num1 = 1;
      object selector;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.SelectionMode == SelectionMode.Default)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
                continue;
              }
              if (this.SelectionMode == SelectionMode.ByName)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
                continue;
              }
              goto label_7;
            case 2:
              goto label_6;
            case 3:
              goto label_14;
            case 4:
              selector = EntitySerializationSelector.n68csQBrZp5xR1102QdW((object) this, (object) propertyName);
              if (selector == null)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            default:
              goto label_9;
          }
        }
label_7:
        if (this.SelectionMode == SelectionMode.All)
          num1 = 4;
        else
          goto label_15;
      }
label_6:
      return (EntitySerializationSelector) EntitySerializationSelector.n68csQBrZp5xR1102QdW((object) this, (object) propertyName);
label_9:
      return (EntitySerializationSelector) null;
label_3:
      return (EntitySerializationSelector) selector;
label_14:
      return new EntitySerializationSelector()
      {
        SelectionMode = SelectionMode.Default
      };
label_15:
      return (EntitySerializationSelector) null;
    }

    public EntitySerializationSelector()
    {
      EntitySerializationSelector.GDrwFEBruSRMCKZRtdKX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EHTpqNBrByqjDQld5Xuj() => EntitySerializationSelector.UWjn7ABrFMbVIwYoIv9u == null;

    internal static EntitySerializationSelector q0qNAJBrWuVBvZIfp9gt() => EntitySerializationSelector.UWjn7ABrFMbVIwYoIv9u;

    internal static object n15C9UBro8cWD09enG23(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QoV7OCBrblOuScDZy33Y([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void HVpE4jBrh7BQhlMFOsiJ([In] object obj0, SelectionMode value) => ((EntitySerializationSelector) obj0).SelectionMode = value;

    internal static bool IcNJICBrGPXwynum58Td([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Qg0iasBrECsXqmTVodp5([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object xCPj4qBrffKC0HQOIpJn([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object YEueUNBrQ1JM1h5Qq0h0(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static Guid XoQJC0BrCSTKVHfnUAe3([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static object HcmSmNBrvpke5QCFHISR([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object Q8f3S9Br8uO2HRre8aFK([In] object obj0, [In] object obj1) => (object) EntitySerializationSelector.CreateFromSelect((string) obj0, (EntityMetadata) obj1);

    internal static object n68csQBrZp5xR1102QdW([In] object obj0, [In] object obj1) => (object) EntitySerializationSelector.GetFromParent((EntitySerializationSelector) obj0, (string) obj1);

    internal static void GDrwFEBruSRMCKZRtdKX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
