// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.AssemblyModelsMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные сборки с моделями</summary>
  [Serializable]
  public class AssemblyModelsMetadata : IDisposable, ICloneable
  {
    [NonSerialized]
    private AbstractMetadata[] cachedMetadata;
    [NonSerialized]
    private bool disposed;
    internal static AssemblyModelsMetadata LcLJ9rbxOCqs1wB7jQIR;

    /// <summary>Идентификатор</summary>
    public virtual long Id
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Имя сборки</summary>
    public virtual string Name
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

    /// <summary>Статус</summary>
    public virtual AssemblyModelsMetadataStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
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
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>Метаданные модели в заархивированном виде</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Свойство устарело и больше не используется. Используйте MetadataStream", true)]
    public virtual byte[] Metadata
    {
      get
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              obj = AssemblyModelsMetadata.i7pAvcbxPyO6vRWWKN7L((object) this);
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (byte[]) null;
label_5:
        return ((MemoryStream) obj).ToArray();
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              AssemblyModelsMetadata.f7fL0jbx10vrbrbhwpSx((object) this, (object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              if (value != null)
              {
                AssemblyModelsMetadata.f7fL0jbx10vrbrbhwpSx((object) this, AssemblyModelsMetadata.cjVe1ybxNhC3hfy5rUWu(value.Length));
                num = 3;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            case 3:
              AssemblyModelsMetadata.L6OZAZbx3RLU03QPOZYj((object) this.MetadataStream, (object) value, 0, value.Length);
              num = 5;
              continue;
            case 4:
              goto label_2;
            case 5:
              AssemblyModelsMetadata.UNGAlkbxp1OVV5rYKHDy(AssemblyModelsMetadata.i7pAvcbxPyO6vRWWKN7L((object) this), 0L, SeekOrigin.Begin);
              num = 4;
              continue;
            default:
              goto label_10;
          }
        }
label_5:
        return;
label_2:
        return;
label_10:;
      }
    }

    /// <summary>Поток метаданных модели в заархивированном виде</summary>
    public virtual MemoryStream MetadataStream
    {
      get => this.\u003CMetadataStream\u003Ek__BackingField;
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
              this.\u003CMetadataStream\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    /// <summary>Список локализированной документации</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Not used", true)]
    public virtual IEnumerable<EleWise.ELMA.Model.Metadata.LocalizedXmlDocumentation> LocalizedXmlDocumentation
    {
      get => Enumerable.Empty<EleWise.ELMA.Model.Metadata.LocalizedXmlDocumentation>();
      set
      {
      }
    }

    /// <summary>Бинарный код сборки</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Свойство устарело и больше не используется. Используйте AssemblyRawStream", true)]
    public virtual byte[] AssemblyRaw
    {
      get
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              obj = AssemblyModelsMetadata.d1cfxkbxagOZjCwdOFhW((object) this);
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (byte[]) null;
label_5:
        return ((MemoryStream) obj).ToArray();
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              AssemblyModelsMetadata.okbplGbxDw50ltCiFt92((object) this, (object) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 3 : 5;
              continue;
            case 2:
              if (value != null)
              {
                AssemblyModelsMetadata.okbplGbxDw50ltCiFt92((object) this, AssemblyModelsMetadata.cjVe1ybxNhC3hfy5rUWu(value.Length));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
              continue;
            case 3:
              ((Stream) AssemblyModelsMetadata.d1cfxkbxagOZjCwdOFhW((object) this)).Seek(0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 4 : 4;
              continue;
            case 4:
              goto label_6;
            case 5:
              goto label_2;
            default:
              AssemblyModelsMetadata.L6OZAZbx3RLU03QPOZYj(AssemblyModelsMetadata.d1cfxkbxagOZjCwdOFhW((object) this), (object) value, 0, value.Length);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 3;
              continue;
          }
        }
label_6:
        return;
label_2:;
      }
    }

    /// <summary>Поток бинарного кода сборки</summary>
    public virtual MemoryStream AssemblyRawStream
    {
      get => this.\u003CAssemblyRawStream\u003Ek__BackingField;
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
              this.\u003CAssemblyRawStream\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    /// <summary>Бинарный код сборки для отладки</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Свойство устарело и больше не используется. Используйте DebugRawStream", true)]
    public virtual byte[] DebugRaw
    {
      get
      {
        int num = 1;
        MemoryStream debugRawStream;
        while (true)
        {
          switch (num)
          {
            case 1:
              debugRawStream = this.DebugRawStream;
              if (debugRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (byte[]) null;
label_5:
        return (byte[]) AssemblyModelsMetadata.eGWrdHbxtPZf38tuqAlx((object) debugRawStream);
      }
      set
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_3;
              case 1:
                AssemblyModelsMetadata.L6OZAZbx3RLU03QPOZYj((object) this.DebugRawStream, (object) value, 0, value.Length);
                num2 = 4;
                continue;
              case 2:
                this.DebugRawStream = (MemoryStream) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              case 3:
                if (value != null)
                {
                  this.DebugRawStream = (MemoryStream) AssemblyModelsMetadata.cjVe1ybxNhC3hfy5rUWu(value.Length);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
                  continue;
                }
                goto label_8;
              case 4:
                AssemblyModelsMetadata.UNGAlkbxp1OVV5rYKHDy(AssemblyModelsMetadata.aj6SlgbxwD1RH70RAkYV((object) this), 0L, SeekOrigin.Begin);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 3 : 5;
                continue;
              case 5:
                goto label_4;
              default:
                goto label_11;
            }
          }
label_8:
          num1 = 2;
        }
label_3:
        return;
label_4:
        return;
label_11:;
      }
    }

    /// <summary>Поток бинарного кода сборки для отладки</summary>
    public virtual MemoryStream DebugRawStream
    {
      get => this.\u003CDebugRawStream\u003Ek__BackingField;
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
              this.\u003CDebugRawStream\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Содержимое файла документации (XML)</summary>
    [Obsolete("Свойство устарело и больше не используется. Используйте DocumentationRawStream", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual byte[] DocumentationRaw
    {
      get
      {
        int num = 1;
        object obj;
        while (true)
        {
          switch (num)
          {
            case 1:
              obj = AssemblyModelsMetadata.iNyuUMbx4p5Mk9JKpG3i((object) this);
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (byte[]) null;
label_5:
        return (byte[]) AssemblyModelsMetadata.eGWrdHbxtPZf38tuqAlx(obj);
      }
      set
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              AssemblyModelsMetadata.L6OZAZbx3RLU03QPOZYj(AssemblyModelsMetadata.iNyuUMbx4p5Mk9JKpG3i((object) this), (object) value, 0, value.Length);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 2;
              continue;
            case 2:
              AssemblyModelsMetadata.UNGAlkbxp1OVV5rYKHDy(AssemblyModelsMetadata.iNyuUMbx4p5Mk9JKpG3i((object) this), 0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 3;
              continue;
            case 3:
              goto label_3;
            case 4:
              this.DocumentationRawStream = (MemoryStream) AssemblyModelsMetadata.cjVe1ybxNhC3hfy5rUWu(value.Length);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
              continue;
            case 5:
              if (value != null)
              {
                num = 4;
                continue;
              }
              break;
            case 6:
              goto label_4;
          }
          this.DocumentationRawStream = (MemoryStream) null;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 6;
        }
label_3:
        return;
label_4:;
      }
    }

    /// <summary>Поток файла документации (XML)</summary>
    public virtual MemoryStream DocumentationRawStream
    {
      get => this.\u003CDocumentationRawStream\u003Ek__BackingField;
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
              this.\u003CDocumentationRawStream\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    /// <summary>Восстановить модель метаданных</summary>
    /// <returns>Массив объектов метаданных</returns>
    public virtual AbstractMetadata[] RestoreMetadata()
    {
      int num1 = 3;
      MetadataContainer container;
      string xml;
      while (true)
      {
        switch (num1)
        {
          case 2:
            if (AssemblyModelsMetadata.i7pAvcbxPyO6vRWWKN7L((object) this) != null)
            {
              num1 = 8;
              continue;
            }
            goto label_13;
          case 3:
            num1 = 2;
            continue;
          case 4:
            if (!xml.Contains((string) AssemblyModelsMetadata.GRhQvybxAXcqB1hPpEQt(-281842504 ^ -281963300)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
              continue;
            }
            goto case 11;
          case 5:
            AssemblyModelsMetadata.cMMFeTbx7PbHSRaFtNlc((object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    container = ClassSerializationHelper.DeserializeObjectByXml<MetadataContainer>(xml);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 9;
            continue;
          case 6:
            goto label_12;
          case 7:
            goto label_2;
          case 8:
            if (AssemblyModelsMetadata.dLF4oqbx6a7S5DMLf8Ff((object) this.MetadataStream) != 0L)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 10;
              continue;
            }
            goto label_13;
          case 9:
            this.cachedMetadata = (AbstractMetadata[]) AssemblyModelsMetadata.R1jdmhbxx3WlbCk1uOWf((object) container);
            num1 = 6;
            continue;
          case 10:
            if (this.cachedMetadata == null)
            {
              xml = (string) AssemblyModelsMetadata.HqR1HtbxHa4Mg70ogrL4((object) this.MetadataStream, (object) Encoding.UTF8);
              num1 = 4;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 7;
            continue;
          case 11:
            xml = xml.Replace((string) AssemblyModelsMetadata.GRhQvybxAXcqB1hPpEQt(1251470110 >> 2 ^ 312935075), (string) AssemblyModelsMetadata.GRhQvybxAXcqB1hPpEQt(~1767720452 ^ -1767882405));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          case 12:
            goto label_13;
          default:
            container = (MetadataContainer) null;
            num1 = 5;
            continue;
        }
      }
label_2:
      return this.cachedMetadata;
label_12:
      return this.cachedMetadata;
label_13:
      return Array.Empty<AbstractMetadata>();
    }

    /// <summary>Установтиь модель метаданных в свойство Metadata</summary>
    /// <param name="metadata">Массив объектов метаданных</param>
    public virtual void SetMetadata(AbstractMetadata[] metadata)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MetadataContainer container = new MetadataContainer()
            {
              Metadata = metadata
            };
            EleWise.ELMA.SR.LocalizableString.RunWithSRLocalizer((System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    AssemblyModelsMetadata.\u003C\u003Ec__DisplayClass44_0.T8wjdyC41jjyHEeRgZPC((object) this, (object) ClassSerializationHelper.SerializeObjectByXmlToMemoryStream((object) container));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.cachedMetadata = metadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Оператор преобразования типа <see cref="T:EleWise.ELMA.Model.Metadata.AssemblyModelsMetadata" /> в <see cref="!:IRootMetadata[]" />
    /// </summary>
    /// <param name="assemblyModelsMetadata">Метаданные сборки с моделями</param>
    public static explicit operator IRootMetadata[](AssemblyModelsMetadata assemblyModelsMetadata) => assemblyModelsMetadata.RestoreMetadata().Cast<IRootMetadata>().ToArray<IRootMetadata>();

    /// <summary>
    /// Оператор преобразования типа <see cref="!:IRootMetadata[]" /> в <see cref="T:EleWise.ELMA.Model.Metadata.AssemblyModelsMetadata" />
    /// </summary>
    /// <param name="metadata">Метаданные</param>
    public static explicit operator AssemblyModelsMetadata(IRootMetadata[] metadata)
    {
      AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata();
      AssemblyModelsMetadata.xVX5xibx0Q6Fxg2iGIeU((object) assemblyModelsMetadata, (object) metadata.Cast<AbstractMetadata>().ToArray<AbstractMetadata>());
      return assemblyModelsMetadata;
    }

    /// <inheritdoc />
    public virtual void Dispose()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              object obj1 = AssemblyModelsMetadata.d1cfxkbxagOZjCwdOFhW((object) this);
              if (obj1 == null)
              {
                num2 = 9;
                continue;
              }
              AssemblyModelsMetadata.ayw9c9bxmPEJMq1VMpMi(obj1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 6;
              continue;
            case 2:
              goto label_7;
            case 3:
              goto label_12;
            case 4:
            case 11:
              object obj2 = AssemblyModelsMetadata.i7pAvcbxPyO6vRWWKN7L((object) this);
              if (obj2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 3;
                continue;
              }
              AssemblyModelsMetadata.ayw9c9bxmPEJMq1VMpMi(obj2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            case 5:
              this.disposed = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            case 6:
              if (!this.disposed)
              {
                num2 = 5;
                continue;
              }
              goto label_15;
            case 7:
            case 10:
              MemoryStream documentationRawStream = this.DocumentationRawStream;
              if (documentationRawStream == null)
              {
                num2 = 4;
                continue;
              }
              AssemblyModelsMetadata.ayw9c9bxmPEJMq1VMpMi((object) documentationRawStream);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 11 : 2;
              continue;
            case 8:
            case 9:
              MemoryStream debugRawStream = this.DebugRawStream;
              if (debugRawStream != null)
              {
                AssemblyModelsMetadata.ayw9c9bxmPEJMq1VMpMi((object) debugRawStream);
                num2 = 7;
                continue;
              }
              goto label_4;
            default:
              goto label_18;
          }
        }
label_4:
        num1 = 10;
      }
label_20:
      return;
label_7:
      return;
label_12:
      return;
label_18:
      return;
label_15:;
    }

    /// <inheritdoc />
    public virtual object Clone()
    {
      AssemblyModelsMetadata assemblyModelsMetadata = new AssemblyModelsMetadata();
      AssemblyModelsMetadata.pOlT1ibxMXYxxNmF2bYP((object) assemblyModelsMetadata, AssemblyModelsMetadata.Yp8iOObxyCQxZDnI1yWZ((object) this));
      AssemblyModelsMetadata.k1rp6Mbx9aZmJO619Ugi((object) assemblyModelsMetadata, AssemblyModelsMetadata.EuQZWybxJuxZLH9M4Cc4((object) this));
      AssemblyModelsMetadata.okbplGbxDw50ltCiFt92((object) assemblyModelsMetadata, (object) ((MemoryStream) AssemblyModelsMetadata.d1cfxkbxagOZjCwdOFhW((object) this)).CloneMemoryStream());
      AssemblyModelsMetadata.AJHLM9bxlOU7JTjcUeOg((object) assemblyModelsMetadata, AssemblyModelsMetadata.vxcd6lbxdrqTeMteIcZq(AssemblyModelsMetadata.aj6SlgbxwD1RH70RAkYV((object) this)));
      AssemblyModelsMetadata.SPGOpJbxrGmEIFedZuJk((object) assemblyModelsMetadata, AssemblyModelsMetadata.vxcd6lbxdrqTeMteIcZq((object) this.DocumentationRawStream));
      AssemblyModelsMetadata.f7fL0jbx10vrbrbhwpSx((object) assemblyModelsMetadata, (object) ((MemoryStream) AssemblyModelsMetadata.i7pAvcbxPyO6vRWWKN7L((object) this)).CloneMemoryStream());
      return (object) assemblyModelsMetadata;
    }

    public AssemblyModelsMetadata()
    {
      AssemblyModelsMetadata.j8m2Wlbxg8bKxECa2id9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lGV0scbx25IAtBQgoWgW() => AssemblyModelsMetadata.LcLJ9rbxOCqs1wB7jQIR == null;

    internal static AssemblyModelsMetadata VM4MGtbxexH25EJ5438O() => AssemblyModelsMetadata.LcLJ9rbxOCqs1wB7jQIR;

    internal static object i7pAvcbxPyO6vRWWKN7L([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).MetadataStream;

    internal static void f7fL0jbx10vrbrbhwpSx([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).MetadataStream = (MemoryStream) obj1;

    internal static object cjVe1ybxNhC3hfy5rUWu(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static void L6OZAZbx3RLU03QPOZYj([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

    internal static long UNGAlkbxp1OVV5rYKHDy([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object d1cfxkbxagOZjCwdOFhW([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static void okbplGbxDw50ltCiFt92([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).AssemblyRawStream = (MemoryStream) obj1;

    internal static object eGWrdHbxtPZf38tuqAlx([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object aj6SlgbxwD1RH70RAkYV([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DebugRawStream;

    internal static object iNyuUMbx4p5Mk9JKpG3i([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DocumentationRawStream;

    internal static long dLF4oqbx6a7S5DMLf8Ff([In] object obj0) => ((Stream) obj0).Length;

    internal static object HqR1HtbxHa4Mg70ogrL4([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static object GRhQvybxAXcqB1hPpEQt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void cMMFeTbx7PbHSRaFtNlc([In] object obj0) => EleWise.ELMA.SR.LocalizableString.RunWithSRLocalizer((System.Action) obj0);

    internal static object R1jdmhbxx3WlbCk1uOWf([In] object obj0) => (object) ((MetadataContainer) obj0).Metadata;

    internal static void xVX5xibx0Q6Fxg2iGIeU([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).SetMetadata((AbstractMetadata[]) obj1);

    internal static void ayw9c9bxmPEJMq1VMpMi([In] object obj0) => __nonvirtual (((Stream) obj0).Dispose());

    internal static long Yp8iOObxyCQxZDnI1yWZ([In] object obj0) => ((AssemblyModelsMetadata) obj0).Id;

    internal static void pOlT1ibxMXYxxNmF2bYP([In] object obj0, long value) => ((AssemblyModelsMetadata) obj0).Id = value;

    internal static object EuQZWybxJuxZLH9M4Cc4([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static void k1rp6Mbx9aZmJO619Ugi([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).Name = (string) obj1;

    internal static object vxcd6lbxdrqTeMteIcZq([In] object obj0) => (object) ((MemoryStream) obj0).CloneMemoryStream();

    internal static void AJHLM9bxlOU7JTjcUeOg([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).DebugRawStream = (MemoryStream) obj1;

    internal static void SPGOpJbxrGmEIFedZuJk([In] object obj0, [In] object obj1) => ((AssemblyModelsMetadata) obj0).DocumentationRawStream = (MemoryStream) obj1;

    internal static void j8m2Wlbxg8bKxECa2id9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
