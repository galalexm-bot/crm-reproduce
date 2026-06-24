// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Entities.EntityReferences
{
  /// <summary>Ссылка на тип объекта</summary>
  [Component]
  [TypeConverter(typeof (ReferenceOnEntityTypeConverter))]
  [XmlRoot("ReferenceOnEntityType")]
  [Serializable]
  public class ReferenceOnEntityType : IXsiType
  {
    internal static ReferenceOnEntityType PBHqDjhVBkVi5drTmMP0;

    /// <summary>Uid типа объекта</summary>
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

    /// <summary>Тип объекта</summary>
    [XmlIgnore]
    public Type EntityType
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (!ReferenceOnEntityType.iPBonjhVbf8P02uToOPs(this.TypeUid, Guid.Empty))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 2:
              goto label_12;
            case 3:
              goto label_4;
            case 4:
              goto label_5;
            default:
              num1 = 4;
              continue;
          }
        }
label_4:
        Type entityType;
        return entityType;
label_5:
        try
        {
          entityType = ((IMetadataRuntimeService) ReferenceOnEntityType.mnoP2ihVhmUgZVGLZmrc()).GetTypeByUid(this.TypeUid);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              goto label_4;
          }
        }
        catch (Exception ex)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                entityType = (Type) null;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
        }
label_12:
        return (Type) null;
      }
      set
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (ReferenceOnEntityType.WQ5qPihVGTSyx4Ai0PTI(value, (Type) null))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                continue;
              }
              goto label_17;
            case 2:
              goto label_18;
            default:
              goto label_3;
          }
        }
label_18:
        return;
label_3:
        try
        {
          IMetadata metadata = MetadataLoader.LoadMetadata(value);
          int num2 = 3;
          EntityMetadata entityMetadata;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_13;
              case 1:
                this.TypeUid = ReferenceOnEntityType.nWk9hihVfwCARpBjNrie((object) metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
                continue;
              case 2:
                goto label_7;
              case 3:
                entityMetadata = metadata as EntityMetadata;
                num2 = 4;
                continue;
              case 4:
                if (entityMetadata != null)
                {
                  num2 = 5;
                  continue;
                }
                goto case 1;
              case 5:
                this.TypeUid = ReferenceOnEntityType.kViebvhVErnxQUs7YPse((object) entityMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              default:
                goto label_6;
            }
          }
label_13:
          return;
label_7:
          return;
label_6:
          return;
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
            num3 = 0;
          switch (num3)
          {
            case 0:
              return;
            default:
              return;
          }
        }
label_17:;
      }
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (this == obj)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
              continue;
            }
            // ISSUE: type reference
            if (ReferenceOnEntityType.WQ5qPihVGTSyx4Ai0PTI(obj.GetType(), ReferenceOnEntityType.SdgueihVQLfEcgxdQ2L3(__typeref (ReferenceOnEntityType))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 0;
              continue;
            }
            goto label_8;
          case 3:
            if (obj != null)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_7:
      return false;
label_8:
      return ReferenceOnEntityType.iPBonjhVbf8P02uToOPs(((ReferenceOnEntityType) obj).TypeUid, this.TypeUid);
label_9:
      return true;
    }

    public override int GetHashCode()
    {
      int num = 1;
      Guid typeUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeUid = this.TypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return typeUid.ToString().GetHashCode();
    }

    /// <summary>Имя для отображения</summary>
    [XmlIgnore]
    public string DisplayName
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (this.EntityType != (Type) null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 2:
              goto label_15;
            default:
              goto label_4;
          }
        }
label_4:
        string displayName;
        try
        {
          ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.EntityType);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
            num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_16;
              case 2:
                if (classMetadata != null)
                {
                  num2 = 3;
                  continue;
                }
                goto label_15;
              case 3:
                displayName = (string) ReferenceOnEntityType.GrE941hVCjgfVLWwB1tD((object) classMetadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
                continue;
              default:
                goto label_15;
            }
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                displayName = (string) null;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_16:
        return displayName;
label_15:
        return "";
      }
    }

    /// <summary>Создать ссылку на тип объекта</summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ReferenceOnEntityType Create(Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!ReferenceOnEntityType.okaHUJhVvsXun0juJ07j(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (ReferenceOnEntityType) null;
label_3:
      return new ReferenceOnEntityType()
      {
        EntityType = type
      };
    }

    public override string ToString()
    {
      int num = 1;
      Guid typeUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeUid = this.TypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return typeUid.ToString();
    }

    public ReferenceOnEntityType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Vk6S93hVWbKqJZfb2LkQ() => ReferenceOnEntityType.PBHqDjhVBkVi5drTmMP0 == null;

    internal static ReferenceOnEntityType vcaReZhVorQBYEKhRW84() => ReferenceOnEntityType.PBHqDjhVBkVi5drTmMP0;

    internal static bool iPBonjhVbf8P02uToOPs([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object mnoP2ihVhmUgZVGLZmrc() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static bool WQ5qPihVGTSyx4Ai0PTI([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Guid kViebvhVErnxQUs7YPse([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Guid nWk9hihVfwCARpBjNrie([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static Type SdgueihVQLfEcgxdQ2L3([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object GrE941hVCjgfVLWwB1tD([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool okaHUJhVvsXun0juJ07j([In] Type obj0, [In] Type obj1) => obj0 == obj1;
  }
}
