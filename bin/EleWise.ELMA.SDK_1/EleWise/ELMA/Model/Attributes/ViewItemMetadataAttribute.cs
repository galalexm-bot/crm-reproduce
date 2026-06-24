// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ViewItemMetadataAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
  public class ViewItemMetadataAttribute : Attribute
  {
    private string uidStr;
    private Type type;
    private Guid? uid;
    internal static ViewItemMetadataAttribute B7Sc5tovfyamHatV4m9Z;

    public string UidStr
    {
      get
      {
        int num = 2;
        Guid uid;
        string uidStr;
        while (true)
        {
          switch (num)
          {
            case 1:
              uid = this.Uid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            case 2:
              uidStr = this.uidStr;
              if (uidStr == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return uidStr;
label_6:
        return uid.ToString();
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.type = (Type) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 3;
              continue;
            case 2:
              this.uidStr = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
              continue;
            case 3:
              this.uid = new Guid?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }
    }

    public Type Type
    {
      get
      {
        int num = 1;
        Type type;
        while (true)
        {
          switch (num)
          {
            case 1:
              type = this.type;
              if ((object) type == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return type;
label_5:
        return Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(this.Uid);
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.uidStr = (string) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              this.uid = new Guid?();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 0;
              continue;
            default:
              this.type = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 1;
              continue;
          }
        }
label_2:;
      }
    }

    public Guid Uid
    {
      get
      {
        int num = 5;
        Guid? uid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.uidStr != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 0;
                continue;
              }
              break;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              if (uid.HasValue)
              {
                num = 3;
                continue;
              }
              goto case 1;
            case 5:
              uid = this.uid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
              continue;
            case 6:
              goto label_4;
          }
          if (!ViewItemMetadataAttribute.qeAZLhovvyXrjP4YL9a6(this.type, (Type) null))
            num = 6;
          else
            goto label_5;
        }
label_4:
        return Guid.Empty;
label_5:
        return InterfaceActivator.UID(this.type, false);
label_6:
        return new Guid(this.uidStr);
label_7:
        return uid.GetValueOrDefault();
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.type = (Type) null;
              num = 3;
              continue;
            case 2:
              this.uidStr = (string) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
            case 3:
              this.uid = new Guid?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }
    }

    public static ICollection<Guid> GetUids(IMetadata metadata)
    {
      if (!(metadata is ClassMetadata))
      {
        if (metadata == null)
          return (ICollection<Guid>) null;
        return (ICollection<Guid>) new Guid[1]
        {
          metadata.Uid
        };
      }
      return (ICollection<Guid>) ((IEnumerable<IMetadata>) MetadataLoader.GetBaseClasses(metadata as ClassMetadata, false)).Union<IMetadata>((IEnumerable<IMetadata>) new IMetadata[1]
      {
        metadata
      }).SelectMany<IMetadata, Guid>((Func<IMetadata, IEnumerable<Guid>>) (m => !(m is EntityMetadata) ? (IEnumerable<Guid>) new Guid[1]
      {
        m.Uid
      } : (IEnumerable<Guid>) new Guid[2]
      {
        m.Uid,
        (m as EntityMetadata).ImplementationUid
      })).ToArray<Guid>();
    }

    public static bool IsAvailable<T>(IMetadata metadata) => ViewItemMetadataAttribute.IsAvailable(typeof (T), ViewItemMetadataAttribute.GetUids(metadata));

    public static bool IsAvailable(Type itemType, ICollection<Guid> uids)
    {
      ViewItemMetadataAttribute[] array = itemType.GetCustomAttributes(typeof (ViewItemMetadataAttribute), false).Cast<ViewItemMetadataAttribute>().ToArray<ViewItemMetadataAttribute>();
      if (!((IEnumerable<ViewItemMetadataAttribute>) array).Any<ViewItemMetadataAttribute>())
        return true;
      // ISSUE: reference to a compiler-generated method
      return uids != null && ((IEnumerable<ViewItemMetadataAttribute>) array).Any<ViewItemMetadataAttribute>((Func<ViewItemMetadataAttribute, bool>) (a => uids.Contains(ViewItemMetadataAttribute.\u003C\u003Ec__DisplayClass14_0.TqLAs6CGr1J8p6V0pgFy((object) a))));
    }

    public ViewItemMetadataAttribute()
    {
      ViewItemMetadataAttribute.a3VdxBov8HQ9aPynLJmB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool GQocu1ovQi6xUoJUYZgE() => ViewItemMetadataAttribute.B7Sc5tovfyamHatV4m9Z == null;

    internal static ViewItemMetadataAttribute y2xWbcovCfmvWxeeb0P6() => ViewItemMetadataAttribute.B7Sc5tovfyamHatV4m9Z;

    internal static bool qeAZLhovvyXrjP4YL9a6([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static void a3VdxBov8HQ9aPynLJmB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
