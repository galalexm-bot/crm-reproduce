// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Models.MetadataItemDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata.DTO.Models
{
  /// <summary>DTO для элемента метаданных</summary>
  [Serializable]
  public class MetadataItemDTO : EntityDTO<long>, ISerializable
  {
    private static MetadataItemDTO MISZhXbgoTULVSqp9MoQ;

    /// <summary>Ctor</summary>
    public MetadataItemDTO()
    {
      MetadataItemDTO.ryHLubbgGHMMqMkibx4S();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Id заголовка</summary>
    public long HeaderId
    {
      get => this.\u003CHeaderId\u003Ek__BackingField;
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
              this.\u003CHeaderId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    /// <summary>Метаданные</summary>
    public IMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    /// <summary>Есть ли неопубликованные изменения</summary>
    public bool IsDirtyItem
    {
      get => this.\u003CIsDirtyItem\u003Ek__BackingField;
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
              this.\u003CIsDirtyItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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

    /// <summary>Id группы элементов метаданных</summary>
    public long HeaderGroupId
    {
      get => this.\u003CHeaderGroupId\u003Ek__BackingField;
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
              this.\u003CHeaderGroupId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>Дата создания</summary>
    public DateTime HeaderCreationDate
    {
      get => this.\u003CHeaderCreationDate\u003Ek__BackingField;
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
              this.\u003CHeaderCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора создания</summary>
    public long HeaderCreationAuthorId
    {
      get => this.\u003CHeaderCreationAuthorId\u003Ek__BackingField;
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
              this.\u003CHeaderCreationAuthorId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    /// <summary>Метка заголовка</summary>
    public string HeaderTag
    {
      get => this.\u003CHeaderTag\u003Ek__BackingField;
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
              this.\u003CHeaderTag\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Дата сохранения черновика</summary>
    public DateTime CreationDate
    {
      get => this.\u003CCreationDate\u003Ek__BackingField;
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
              this.\u003CCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора сохранения черновика</summary>
    public long CreationAuthorId
    {
      get => this.\u003CCreationAuthorId\u003Ek__BackingField;
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
              this.\u003CCreationAuthorId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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

    /// <summary>Дата сохранения опубликованной версии</summary>
    public DateTime PublishedCreationDate
    {
      get => this.\u003CPublishedCreationDate\u003Ek__BackingField;
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
              this.\u003CPublishedCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор автора сохранения опубликованной версии</summary>
    public long? PublishedCreationAuthorId { get; set; }

    /// <summary>Id опубликованной версии</summary>
    public long? PublishedId { get; set; }

    /// <summary>Модуль сценариев</summary>
    public ScriptModuleDTO ScriptModule
    {
      get => this.\u003CScriptModule\u003Ek__BackingField;
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
              this.\u003CScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    /// <summary>Клиентский модуль сценариев</summary>
    public ScriptModuleDTO ClientScriptModule
    {
      get => this.\u003CClientScriptModule\u003Ek__BackingField;
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
              this.\u003CClientScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    public override void CopyChanges(EntityDTO<long> saved)
    {
      base.CopyChanges(saved);
      if (!(saved is MetadataItemDTO metadataItemDto))
        return;
      this.Uid = metadataItemDto.Uid;
      if (this.ScriptModule == null || metadataItemDto.ScriptModule == null)
        return;
      this.ScriptModule.CopyChanges((EntityDTO<long>) metadataItemDto.ScriptModule);
    }

    /// <summary>Serialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Serialization context</param>
    protected MetadataItemDTO(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      while (true)
      {
        string xml;
        string typeName;
        Type type;
        IEnumerator<PropertyInfo> enumerator;
        switch (num1)
        {
          case 1:
label_24:
            typeName = (string) MetadataItemDTO.Q348swbgZPU03wbY94Jd((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16556507));
            num1 = 7;
            continue;
          case 2:
            this.Metadata = (IMetadata) ClassSerializationHelper.DeserializeObjectByXml(type, xml);
            num1 = 8;
            continue;
          case 3:
            xml = (string) MetadataItemDTO.Q348swbgZPU03wbY94Jd((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710619128));
            num1 = 2;
            continue;
          case 4:
            enumerator = this.GetSerializableProperties().GetEnumerator();
            num1 = 5;
            continue;
          case 5:
            try
            {
label_12:
              if (MetadataItemDTO.MtNIn0bgvcNwagivvPnu((object) enumerator))
                goto label_9;
              else
                goto label_13;
label_7:
              PropertyInfo current;
              object obj;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    MetadataItemDTO.GAVJ99bgCVBMsHp3Dl4D((object) current, (object) this, obj, (object) null);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 3;
                    continue;
                  case 2:
                    obj = MetadataItemDTO.HWgSi5bgQ3fSVDc0d8Hj((object) info, MetadataItemDTO.AUveFpbgEWql9Ze0752v((object) current), MetadataItemDTO.FwPPKKbgfQya1MB88ZNG((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
                    continue;
                  case 3:
                    goto label_12;
                  case 4:
                    goto label_24;
                  default:
                    goto label_9;
                }
              }
label_9:
              current = enumerator.Current;
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
              {
                num2 = 2;
                goto label_7;
              }
              else
                goto label_7;
label_13:
              num2 = 4;
              goto label_7;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              else
                goto label_18;
label_16:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_18:
              MetadataItemDTO.wd7bx5bg8cGm5o1m2h21((object) enumerator);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
              {
                num3 = 1;
                goto label_16;
              }
              else
                goto label_16;
            }
          case 6:
            goto label_23;
          case 7:
            if (MetadataItemDTO.pMNye2bguim4hay12Bgj((object) typeName))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 6;
              continue;
            }
            break;
          case 8:
            goto label_17;
        }
        type = Type.GetType(typeName);
        num1 = 3;
      }
label_23:
      return;
label_17:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IEnumerator<PropertyInfo> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
label_18:
              MetadataItemDTO.sGwVGrbgIcFpcQTs4e1H((object) info, MetadataItemDTO.JtYxVRbgV17PjpasSqpF(-1998538950 ^ -1998342152), this.Metadata != null ? (object) this.Metadata.GetType().AssemblyQualifiedName : (object) string.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
label_5:
                if (MetadataItemDTO.MtNIn0bgvcNwagivvPnu((object) enumerator))
                  goto label_8;
                else
                  goto label_6;
label_4:
                PropertyInfo current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      MetadataItemDTO.sGwVGrbgIcFpcQTs4e1H((object) info, (object) current.Name, current.GetValue((object) this, (object[]) null));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_8;
                    case 3:
                      goto label_18;
                    default:
                      goto label_5;
                  }
                }
label_6:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 3 : 3;
                goto label_4;
label_8:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
                {
                  num3 = 0;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        MetadataItemDTO.wd7bx5bg8cGm5o1m2h21((object) enumerator);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_16;
                    }
                  }
                }
label_16:;
              }
            case 3:
              enumerator = this.GetSerializableProperties().GetEnumerator();
              num2 = 2;
              continue;
            case 4:
              goto label_14;
            default:
              goto label_19;
          }
        }
label_19:
        info.AddValue((string) MetadataItemDTO.JtYxVRbgV17PjpasSqpF(1917256330 ^ 1917301832), this.Metadata != null ? (object) ClassSerializationHelper.SerializeObjectByXml((object) this.Metadata) : (object) (string) null);
        num1 = 4;
      }
label_14:;
    }

    private IEnumerable<PropertyInfo> GetSerializableProperties() => ((IEnumerable<PropertyInfo>) this.GetType().GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p =>
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            if (MetadataItemDTO.\u003C\u003Ec.ykVe2sC7x3ljwp0tyqLO((object) p))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 1;
              continue;
            }
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated method
            if (MetadataItemDTO.\u003C\u003Ec.I49Mw7C77Va0jPQv2Rb3((object) p))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          case 3:
            if (p.GetIndexParameters().Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return MetadataItemDTO.\u003C\u003Ec.GMPEtfC7yvdlstqXroiX(MetadataItemDTO.\u003C\u003Ec.M8UJqWC709k14GIT3ldt((object) p), MetadataItemDTO.\u003C\u003Ec.Xg1Dr4C7mlchYyKi8e5B(372753449 ^ 372732651));
label_3:
      return false;
    }));

    internal static void ryHLubbgGHMMqMkibx4S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool BGXunCbgb9PMF5aCE6iB() => MetadataItemDTO.MISZhXbgoTULVSqp9MoQ == null;

    internal static MetadataItemDTO UCSuDvbghL15UIVomLpt() => MetadataItemDTO.MISZhXbgoTULVSqp9MoQ;

    internal static object AUveFpbgEWql9Ze0752v([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type FwPPKKbgfQya1MB88ZNG([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object HWgSi5bgQ3fSVDc0d8Hj([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void GAVJ99bgCVBMsHp3Dl4D([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool MtNIn0bgvcNwagivvPnu([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void wd7bx5bg8cGm5o1m2h21([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object Q348swbgZPU03wbY94Jd([In] object obj0, [In] object obj1) => (object) ((SerializationInfo) obj0).GetString((string) obj1);

    internal static bool pMNye2bguim4hay12Bgj([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void sGwVGrbgIcFpcQTs4e1H([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static object JtYxVRbgV17PjpasSqpF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
