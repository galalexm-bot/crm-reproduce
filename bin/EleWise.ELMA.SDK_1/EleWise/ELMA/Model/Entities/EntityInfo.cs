// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Информация о сущности</summary>
  [Serializable]
  public class EntityInfo : EntityInfoBase, ICloneable
  {
    internal static EntityInfo OyXTCthZTf6HEnAjeF7R;

    /// <summary>Идентификатор</summary>
    public string Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
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

    /// <summary>Уникальный идентификатор</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор типа объекта</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
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

    /// <summary>Заголовок</summary>
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
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

    public override string ToString() => (string) EntityInfo.qHdMuThZel0btuuAIJ5A((object) this.Id, EntityInfo.eqBJW4hZOZQx2d7WYRwu(132912447 ^ 132939115), EntityInfo.g42n80hZ2IeiB3MZwyVH((object) this.Title) ? (object) EleWise.ELMA.SR.Untitled : (object) this.Title);

    public virtual EntityInfo Clone()
    {
      EntityInfo entityInfo = new EntityInfo();
      EntityInfo.pINJrthZPhXg15ilP8ve((object) entityInfo, (object) this.Id);
      entityInfo.Uid = this.Uid;
      EntityInfo.YA9TRThZ1I45B1PNPQVl((object) entityInfo, this.TypeUid);
      entityInfo.Title = this.Title;
      return entityInfo;
    }

    object ICloneable.Clone() => EntityInfo.c4sx84hZNKCXoCD20T6q((object) this);

    public EntityInfo()
    {
      EntityInfo.iHxa0lhZ3vIQ98kb2Goy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SDyMJnhZkmsZlGHYPHAV() => EntityInfo.OyXTCthZTf6HEnAjeF7R == null;

    internal static EntityInfo kaHbV3hZnsKRoIaLXBGb() => EntityInfo.OyXTCthZTf6HEnAjeF7R;

    internal static object eqBJW4hZOZQx2d7WYRwu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool g42n80hZ2IeiB3MZwyVH([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object qHdMuThZel0btuuAIJ5A([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void pINJrthZPhXg15ilP8ve([In] object obj0, [In] object obj1) => ((EntityInfo) obj0).Id = (string) obj1;

    internal static void YA9TRThZ1I45B1PNPQVl([In] object obj0, Guid value) => ((EntityInfo) obj0).TypeUid = value;

    internal static object c4sx84hZNKCXoCD20T6q([In] object obj0) => (object) ((EntityInfo) obj0).Clone();

    internal static void iHxa0lhZ3vIQ98kb2Goy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
