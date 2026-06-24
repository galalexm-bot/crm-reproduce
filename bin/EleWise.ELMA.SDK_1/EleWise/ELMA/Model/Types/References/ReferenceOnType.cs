// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.References.ReferenceOnType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.References
{
  /// <summary>Ссылка на тип</summary>
  [XmlRoot("ReferenceOnType")]
  [Serializable]
  public sealed class ReferenceOnType : IXsiType
  {
    internal static ReferenceOnType T4DExtoUF5T5ytyZt2Z5;

    /// <summary>Конструктор</summary>
    public ReferenceOnType()
    {
      ReferenceOnType.IRFrVPoUowuWaOGjyrYh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    public ReferenceOnType(Guid typeUid)
    {
      ReferenceOnType.IRFrVPoUowuWaOGjyrYh();
      // ISSUE: explicit constructor call
      this.\u002Ector(typeUid, Guid.Empty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    public ReferenceOnType(Guid typeUid, Guid subTypeUid)
    {
      ReferenceOnType.IRFrVPoUowuWaOGjyrYh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.TypeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.SubTypeUid = subTypeUid;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Uid дескриптора</summary>
    [XmlElement("TypeUid")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
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

    /// <summary>Uid подтипа дескриптора</summary>
    [XmlElement("SubTypeUid")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override string ToString()
    {
      int num = 2;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            obj = (object) null;
            break;
          case 2:
            ITypeDescriptor typeDescriptor = this.GetTypeDescriptor();
            if (typeDescriptor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
              continue;
            }
            obj = ReferenceOnType.TsqeHioUbqcT30m7XgPH((object) typeDescriptor);
            break;
          default:
            goto label_9;
        }
        if (obj == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
        else
          break;
      }
      return (string) obj;
label_9:
      return string.Empty;
    }

    /// <inheritdoc />
    public override bool Equals(object o)
    {
      int num = 1;
      ReferenceOnType referenceOnType;
      while (true)
      {
        switch (num)
        {
          case 1:
            referenceOnType = o as ReferenceOnType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            if (ReferenceOnType.jKUhbXoUhA2jwWQCIsPB(this.TypeUid, referenceOnType.TypeUid))
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 3:
            goto label_7;
          default:
            if (referenceOnType != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
              continue;
            }
            goto label_8;
        }
      }
label_7:
      return ReferenceOnType.jKUhbXoUhA2jwWQCIsPB(this.SubTypeUid, referenceOnType.SubTypeUid);
label_8:
      return false;
    }

    /// <inheritdoc />
    public override int GetHashCode() => ReferenceOnType.BsVH9LoUGPlCkT8qYspO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998456866), (object) this.TypeUid, (object) this.SubTypeUid).GetHashCode();

    internal static void IRFrVPoUowuWaOGjyrYh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ypkLkSoUB3YKWX66sqPj() => ReferenceOnType.T4DExtoUF5T5ytyZt2Z5 == null;

    internal static ReferenceOnType C7YfMboUWo0fF5ftwrkE() => ReferenceOnType.T4DExtoUF5T5ytyZt2Z5;

    internal static object TsqeHioUbqcT30m7XgPH([In] object obj0) => (object) ((ITypeDescriptor) obj0).Name;

    internal static bool jKUhbXoUhA2jwWQCIsPB([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object BsVH9LoUGPlCkT8qYspO([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);
  }
}
