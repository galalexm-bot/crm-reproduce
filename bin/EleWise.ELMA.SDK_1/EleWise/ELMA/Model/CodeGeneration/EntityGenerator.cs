// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EntityGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор кода сущности на основе метаданных</summary>
  public class EntityGenerator : ClassGenerator
  {
    protected EntityMetadata metadata;
    protected const string CoreEntity = "EleWise.ELMA.Core.Model.Entities.Entity";
    protected const string PROP_TYPE_UID = "TypeUid";
    public const string FILTER_POSTFIX = "Filter";
    protected const string RES_FILTER_PROPERTY_PREFIX = "FP_";
    private static EntityGenerator kbJOjVh46eb27EitZRWa;

    /// <summary>Получить имя типа действий для метаданных сущности</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <returns>Имя типа действий</returns>
    public static string GetActionsTypeName(EntityMetadata entityMetadata) => (string) EntityGenerator.YgAF88h47bK52hNKwHkw((object) entityMetadata) + (string) EntityGenerator.Lure5ih4xuXECmddpOn0(95909607 + 343705423 ^ 439388690);

    /// <summary>Внутренняя инициализация</summary>
    /// <param name="metadata">Метаданные</param>
    protected override void InitInternal(IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityGenerator.a31mADh4mAyn0MqGCXIw(metadata is EntityMetadata, EntityGenerator.Lure5ih4xuXECmddpOn0(-1872275253 >> 6 ^ -29169323));
            num = 4;
            continue;
          case 2:
            EntityGenerator.DaDv3eh40sQ322l76aZb((object) metadata, EntityGenerator.Lure5ih4xuXECmddpOn0(1819636893 << 3 ^ 1672211926));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            base.InitInternal(metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          default:
            this.metadata = (EntityMetadata) metadata;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сгенерировать дополнительные файлы</summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => base.GenerateAdditionalFilesInternal().Concat<GeneratedFileInfo>(this.GenerateActions()).Concat<GeneratedFileInfo>(this.WritePermissionClass()).If<GeneratedFileInfo>(this.metadata.ViewModelMetadata != null, (Func<IEnumerable<GeneratedFileInfo>, IEnumerable<GeneratedFileInfo>>) (files => files.Concat<GeneratedFileInfo>(this.GenerateViewModelMetadataResource())));

    protected ITypeDescriptor GetIdTypeDescriptor(Guid typeUid) => (ITypeDescriptor) EntityGenerator.dXBXQDh4MfTwOTiQ9YJO(EntityGenerator.xDsK1Rh4yIVqvV4PvIE1(), typeUid);

    /// <summary>Сгенерировать основной файл</summary>
    protected override IEnumerable<ISyntaxNode> GenerateMainFile() => base.GenerateMainFile().If<ISyntaxNode>(this.metadata.IsInterfaceType, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (n => n.Concat<ISyntaxNode>(this.WriteFilterInterface()))).If<ISyntaxNode>(!this.metadata.IsInterfaceType, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (n => n.Concat<ISyntaxNode>(this.WriteFilterClass()))).Concat<ISyntaxNode>(this.WriteTablePartClasses());

    /// <summary>Записать используемые пространства имен</summary>
    protected override IEnumerable<ISyntaxNode> GetNamespaces() => base.GetNamespaces().Concat<ISyntaxNode>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541802045).NamespaceImportDeclaration());

    /// <summary>Получить описание типа идентификатора</summary>
    /// <returns></returns>
    protected ITypeDescriptor GetIdTypeDescriptor()
    {
      int num = 1;
      ITypeDescriptor idTypeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870906615));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_10;
          case 3:
            goto label_5;
          case 4:
            idTypeDescriptor = this.GetIdTypeDescriptor(this.metadata.IdTypeUid);
            num = 6;
            continue;
          case 5:
            goto label_9;
          case 6:
            if (idTypeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
              continue;
            }
            goto label_9;
          default:
            if (!EntityGenerator.R3QjKTh4dJc43SLGVFkn(EntityGenerator.bMoiflh49hGNPYf30f54((object) this.metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 4;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      throw new CodeGenerationException(EleWise.ELMA.SR.T((string) EntityGenerator.Lure5ih4xuXECmddpOn0(-2107978722 ^ -2108049296)));
label_9:
      throw new CodeGenerationException(EleWise.ELMA.SR.T((string) EntityGenerator.Lure5ih4xuXECmddpOn0(372753449 ^ 372551809), (object) EntityGenerator.bMoiflh49hGNPYf30f54((object) this.metadata)));
label_10:
      return idTypeDescriptor;
    }

    /// <summary>Записать класс сущности</summary>
    protected virtual ISyntaxNode GetBasicEntity(ISyntaxNode idTypeRef) => EleWise.ELMA.SDK.TypeOf.Entity1.Raw.CreateTypeSyntax(idTypeRef);

    /// <summary>Получить ссылку на базовый класс</summary>
    /// <returns>Объявление класса</returns>
    protected override ISyntaxNode GetBaseClass()
    {
      int num = 4;
      ISyntaxNode propertyTypeReference;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyTypeReference = ((ITypeGenerationInfo) this.GetIdTypeDescriptor()).GetPropertyTypeReference((ClassMetadata) this.metadata, (PropertyMetadata) null, false);
            num = 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!EntityGenerator.lchJ5Mh4rEikjPPyyE7c(EntityGenerator.NiD7lIh4lrZSiVhJIdCw((object) this.metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 4:
            EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, EntityGenerator.Lure5ih4xuXECmddpOn0(-1824388195 ^ -1824374109));
            num = 3;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return (ISyntaxNode) EntityGenerator.x2q7tCh4Lnqj9XJOt3m5((object) this, (object) propertyTypeReference);
label_6:
      if (!(EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, this.metadata.BaseClassUid) is EntityMetadata entityMetadata))
        throw new CodeGenerationException((string) EntityGenerator.si7jdTh4jjc6VeHqnL2f(EntityGenerator.Lure5ih4xuXECmddpOn0(-740338220 ^ -740548316), EntityGenerator.OdisQ5h45npiCgl1fSk1((object) this.metadata), (object) this.metadata.BaseClassUid));
      return ((string) EntityGenerator.ooTnNAh4YFoC7vNBaXJU((object) entityMetadata)).CreateTypeSyntax();
    }

    /// <summary>Получить список ссылок на реализуемые интерфейсы</summary>
    protected override IEnumerable<ISyntaxNode> GetBaseInterfaces() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CGetBaseInterfaces\u003Ed__15(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать атрибуты класса</summary>
    /// <param name="type">Объявление класса</param>
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num1 = 24;
      while (true)
      {
        int num2 = num1;
        List<ISyntaxNode> attributes;
        EntityMetadata entityMetadata1;
        List<PropertiesContainer>.Enumerator enumerator1;
        TablePartMetadata metadata;
        List<Guid>.Enumerator enumerator2;
        Guid guid;
        List<TablePartMetadata>.Enumerator enumerator3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EntityGenerator.R3QjKTh4dJc43SLGVFkn(this.metadata.BaseClassUid, Guid.Empty))
              {
                num2 = 50;
                continue;
              }
              goto case 42;
            case 2:
              enumerator3 = this.metadata.TableParts.GetEnumerator();
              num2 = 40;
              continue;
            case 3:
              type.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num2 = 5;
              continue;
            case 4:
              attributes.Add(TypeOf<SaveHistoryAttribute>.Raw.CreateAttribute());
              num2 = 59;
              continue;
            case 5:
              goto label_125;
            case 6:
            case 58:
              if (!this.metadata.InstancePermissionsSupport)
              {
                num2 = 67;
                continue;
              }
              goto case 22;
            case 7:
            case 66:
label_4:
              if (!this.HasFilterClass)
              {
                num2 = 74;
                continue;
              }
              goto case 21;
            case 8:
              try
              {
label_68:
                if (enumerator2.MoveNext())
                  goto label_73;
                else
                  goto label_69;
label_67:
                Guid current;
                EntityMetadata entityMetadata2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc((object) entityMetadata2.FullTypeName)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 3;
                      continue;
                    case 2:
                      if (entityMetadata2 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 4:
                      entityMetadata2 = (EntityMetadata) EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 0;
                      continue;
                    case 5:
                      goto label_73;
                    case 6:
                      goto label_4;
                    default:
                      goto label_68;
                  }
                }
label_69:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 6 : 0;
                goto label_67;
label_73:
                current = enumerator2.Current;
                num3 = 4;
                goto label_67;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 9:
              attributes.Add(TypeOf<ActionsTypeAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc((object) this.ActionsTypeName)));
              num2 = 72;
              continue;
            case 10:
              goto label_114;
            case 11:
            case 56:
label_22:
              if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) this.metadata) == EntityMetadataType.InterfaceExtension)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 11 : 37;
                continue;
              }
              goto case 31;
            case 12:
              if (!metadata.Required)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 12 : 14;
                continue;
              }
              goto label_98;
            case 13:
            case 41:
              if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) this.metadata) == EntityMetadataType.Entity)
              {
                num2 = 29;
                continue;
              }
              goto case 35;
            case 14:
            case 71:
              List<ISyntaxNode> syntaxNodeList1 = attributes;
              Type raw1 = TypeOf<TablePartInfoAttribute>.Raw;
              Dictionary<string, object> source = new Dictionary<string, object>();
              object key1 = EntityGenerator.Lure5ih4xuXECmddpOn0(-812025778 ^ -811987682);
              guid = EntityGenerator.r009cKh6Iy1mTS1Pt4VZ((object) metadata);
              string str1 = guid.ToString();
              source.Add((string) key1, (object) str1);
              string key2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408857522);
              guid = metadata.TablePartPropertyUid;
              string str2 = guid.ToString();
              source.Add(key2, (object) str2);
              source.Add((string) EntityGenerator.Lure5ih4xuXECmddpOn0(-2112703338 ^ -2112765640), EntityGenerator.D5wmwih6VIVUZtd3Dw6I((object) metadata));
              KeyValuePair<string, object>[] array = source.ToArray<KeyValuePair<string, object>>();
              object obj = EntityGenerator.d086YZh6S8PE6NleXWpm(raw1, (object) array);
              syntaxNodeList1.Add((ISyntaxNode) obj);
              num2 = 25;
              continue;
            case 15:
              goto label_91;
            case 16:
              if (metadata != null)
              {
                num2 = 47;
                continue;
              }
              goto case 61;
            case 17:
              if (this.metadata.Type != EntityMetadataType.InterfaceExtension)
              {
                num2 = 64;
                continue;
              }
              goto case 30;
            case 18:
              attributes.Add(TypeOf<FilterableAttribute>.Raw.CreateAttribute());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            case 19:
            case 29:
              if (!EntityGenerator.fJFNPuh6FvsiF3bUBWnM((object) this.metadata))
              {
                num2 = 28;
                continue;
              }
              goto case 4;
            case 20:
            case 48:
              if (EntityGenerator.pq9CMRh6WsZg7okAShQk((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 18;
                continue;
              }
              goto default;
            case 21:
              attributes.Add(TypeOf<FilterTypeAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc((object) this.FilterClassName)));
              num2 = 63;
              continue;
            case 22:
            case 49:
              attributes.Add(TypeOf<InstancePermissionAttribute>.Raw.CreateAttribute((object) EntityGenerator.J5cfJyh6EplgSseCSRxo((object) this.metadata), EntityGenerator.vi6JO1h6hMuHWZAOrpIl((object) this.metadata), (object) this.metadata.PermissionsPropertyName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 6 : 17;
              continue;
            case 23:
              Contract.NotNull((object) this.metadata, (string) EntityGenerator.Lure5ih4xuXECmddpOn0(-477139494 ^ -477158172));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 73 : 22;
              continue;
            case 24:
              EntityGenerator.DaDv3eh40sQ322l76aZb((object) type, EntityGenerator.Lure5ih4xuXECmddpOn0(1642859704 ^ 1642856602));
              num2 = 23;
              continue;
            case 25:
              if (!EntityGenerator.yI8YoVh6RiCrKxSPiCIK(EntityGenerator.CoKCyAh6i5WxjfPAC5hR((object) metadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 19 : 43;
                continue;
              }
              goto case 61;
            case 26:
              goto label_14;
            case 27:
              enumerator2 = this.metadata.ImplementedExtensionUids.GetEnumerator();
              num2 = 8;
              continue;
            case 28:
            case 59:
              if (EntityGenerator.Ni8eI1h6BLd27aPseTRl((object) this.metadata) == CopyAction.Default)
              {
                num2 = 20;
                continue;
              }
              goto label_114;
            case 30:
            case 51:
              if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) this.metadata) == EntityMetadataType.InterfaceImplementation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 43 : 68;
                continue;
              }
              goto case 7;
            case 31:
label_116:
              if (EntityGenerator.KQ4Qd1h6qETRKbfcpTLS((object) this.metadata) != null)
              {
                num2 = 54;
                continue;
              }
              goto case 3;
            case 32:
            case 62:
              if (this.metadata.ImplementedExtensionUids == null)
              {
                num2 = 66;
                continue;
              }
              goto case 27;
            case 33:
              if (EntityGenerator.Q6JfWth6fICcfyNxn948((object) this.metadata))
              {
                num2 = 52;
                continue;
              }
              goto case 30;
            case 34:
              goto label_115;
            case 35:
              attributes.Add(TypeOf<EntityMetadataTypeAttribute>.Raw.CreateAttribute((object) this.metadata.Type));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 19 : 12;
              continue;
            case 36:
              attributes.Add(TypeOf<EntityAttribute>.Raw.CreateAttribute(EntityGenerator.FWJOG3h4U2n29mDVeeBb((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 34 : 1;
              continue;
            case 37:
              if (this.metadata.PropertiesDiffContainer.Count > 0)
              {
                num2 = 57;
                continue;
              }
              goto case 31;
            case 38:
              List<ISyntaxNode> syntaxNodeList2 = attributes;
              Type raw2 = TypeOf<ImplementationUidAttribute>.Raw;
              object[] objArray1 = new object[1];
              guid = this.metadata.ImplementationUid;
              objArray1[0] = (object) guid.ToString();
              ISyntaxNode attribute1 = raw2.CreateAttribute(objArray1);
              syntaxNodeList2.Add(attribute1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            case 39:
              goto label_19;
            case 40:
              try
              {
label_82:
                if (enumerator3.MoveNext())
                  goto label_85;
                else
                  goto label_83;
label_81:
                TablePartMetadata current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_82;
                    case 2:
                      goto label_85;
                    case 3:
                      goto label_22;
                    default:
                      attributes.Add(TypeOf<TablePartAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc(EntityGenerator.OdisQ5h45npiCgl1fSk1((object) current))));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                      continue;
                  }
                }
label_83:
                num5 = 3;
                goto label_81;
label_85:
                current = enumerator3.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                {
                  num5 = 0;
                  goto label_81;
                }
                else
                  goto label_81;
              }
              finally
              {
                enumerator3.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 42:
            case 44:
              if (!EntityGenerator.A0d4wah6bhh3eKnPqO7v((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 4 : 6;
                continue;
              }
              goto label_14;
            case 43:
              attributes.Add(TypeOf<OnChangeScriptNameAttribute>.Raw.CreateAttribute(EntityGenerator.CoKCyAh6i5WxjfPAC5hR((object) metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 13 : 61;
              continue;
            case 45:
              if (!EntityGenerator.g2o0Nnh4cEmdfTaEry3N((object) this.metadata))
              {
                num2 = 41;
                continue;
              }
              goto label_91;
            case 46:
              if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) this.metadata) == EntityMetadataType.InterfaceImplementation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 38 : 38;
                continue;
              }
              goto case 1;
            case 47:
              attributes.Add(TypeOf<OrderAttribute>.Raw.CreateAttribute((object) EntityGenerator.W6pqiph6ubpTQyqOWjiU((object) metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 12 : 2;
              continue;
            case 50:
              if (EntityGenerator.DBqUGph6oX9DJSNosyQr((object) this.metadata))
              {
                num2 = 44;
                continue;
              }
              goto case 69;
            case 52:
              List<ISyntaxNode> syntaxNodeList3 = attributes;
              Type raw3 = TypeOf<HierarchicalAttribute>.Raw;
              object[] objArray2 = new object[3]
              {
                (object) EntityGenerator.mOKlJSh6QIed4wrMvLSH((object) this.metadata),
                null,
                null
              };
              guid = this.metadata.ParentPropertyUid;
              objArray2[1] = (object) guid.ToString();
              string str3;
              if (!(EntityGenerator.TCDAm3h6C36JI6eDx6ql((object) this.metadata) != Guid.Empty))
              {
                str3 = (string) null;
              }
              else
              {
                guid = EntityGenerator.TCDAm3h6C36JI6eDx6ql((object) this.metadata);
                str3 = guid.ToString();
              }
              objArray2[2] = (object) str3;
              ISyntaxNode attribute2 = raw3.CreateAttribute(objArray2);
              syntaxNodeList3.Add(attribute2);
              num2 = 51;
              continue;
            case 53:
              if (!string.IsNullOrWhiteSpace(this.metadata.PermissionsPropertyName))
              {
                num2 = 22;
                continue;
              }
              goto case 17;
            case 54:
              attributes.Add(TypeOf<ViewModelMetadataAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc((object) this.metadata.TypeName), (object) this.GetViewModelMetadataResourceName()));
              num2 = 3;
              continue;
            case 55:
              attributes.Add(TypeOf<ShowInCatalogListAttribute>.Raw.CreateAttribute((object) EntityGenerator.IMO1HHh4sxFwjRpX5gxV((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 24 : 45;
              continue;
            case 57:
              enumerator1 = this.metadata.PropertiesDiffContainer.GetEnumerator();
              num2 = 65;
              continue;
            case 60:
              attributes = new List<ISyntaxNode>();
              num2 = 36;
              continue;
            case 61:
              if (this.metadata.TableParts == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 9 : 11;
                continue;
              }
              goto case 2;
            case 63:
            case 74:
              if (EntityGenerator.cFEgrCh6ZNxfQR4UcOWO((object) this))
              {
                num2 = 9;
                continue;
              }
              goto case 72;
            case 64:
              if (!EntityGenerator.R3QjKTh4dJc43SLGVFkn(EntityGenerator.NiD7lIh4lrZSiVhJIdCw((object) this.metadata), Guid.Empty))
              {
                num2 = 30;
                continue;
              }
              goto case 33;
            case 65:
              try
              {
label_40:
                if (enumerator1.MoveNext())
                  goto label_42;
                else
                  goto label_41;
label_38:
                string str4;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      attributes.Add(TypeOf<OverrideExtensibleClassPropertyAttribute>.Raw.CreateAttribute((object) str4));
                      num7 = 2;
                      continue;
                    case 2:
                      goto label_40;
                    case 3:
                      goto label_116;
                    default:
                      goto label_42;
                  }
                }
label_41:
                num7 = 3;
                goto label_38;
label_42:
                str4 = ClassSerializationHelper.SerializeObjectByXml((object) enumerator1.Current);
                num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                {
                  num7 = 1;
                  goto label_38;
                }
                else
                  goto label_38;
              }
              finally
              {
                enumerator1.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 67:
              if (!EntityGenerator.gNSUMRh6GQkf3lB0kT0R(EntityGenerator.vi6JO1h6hMuHWZAOrpIl((object) this.metadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 49 : 13;
                continue;
              }
              goto case 53;
            case 68:
              entityMetadata1 = (EntityMetadata) EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, EntityGenerator.zRrt6ih6vwMl5uTCobf5((object) this.metadata));
              num2 = 70;
              continue;
            case 69:
              attributes.Add(TypeOf<NonUniqueAttribute>.Raw.CreateAttribute());
              num2 = 42;
              continue;
            case 70:
              if (entityMetadata1 == null)
              {
                num2 = 62;
                continue;
              }
              goto label_19;
            case 72:
              metadata = this.metadata as TablePartMetadata;
              num2 = 16;
              continue;
            case 73:
              base.WriteTypeAttributes(type);
              num2 = 60;
              continue;
            case 75:
              goto label_98;
            default:
              if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) this.metadata) != EntityMetadataType.Interface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 11 : 46;
                continue;
              }
              goto case 38;
          }
        }
label_14:
        attributes.Add(TypeOf<CacheEntityAttribute>.Raw.CreateAttribute());
        num1 = 58;
        continue;
label_19:
        attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute(EntityGenerator.k41Lnah68679sJSS8mHc((object) entityMetadata1.FullTypeName)));
        num1 = 32;
        continue;
label_91:
        attributes.Add(TypeOf<HideChildItemsTabAttribute>.Raw.CreateAttribute((object) EntityGenerator.g2o0Nnh4cEmdfTaEry3N((object) this.metadata)));
        num1 = 13;
        continue;
label_98:
        attributes.Add(TypeOf<RequiredAttribute>.Raw.CreateAttribute((object) true));
        num1 = 71;
        continue;
label_114:
        attributes.Add(TypeOf<CopyActionAttribute>.Raw.CreateAttribute((object) EntityGenerator.Ni8eI1h6BLd27aPseTRl((object) this.metadata)));
        num1 = 48;
        continue;
label_115:
        List<ISyntaxNode> syntaxNodeList4 = attributes;
        Type raw4 = TypeOf<IdTypeAttribute>.Raw;
        object[] objArray3 = new object[1];
        guid = EntityGenerator.bMoiflh49hGNPYf30f54((object) this.metadata);
        objArray3[0] = (object) guid.ToString();
        ISyntaxNode attribute3 = raw4.CreateAttribute(objArray3);
        syntaxNodeList4.Add(attribute3);
        num1 = 55;
      }
label_125:;
    }

    /// <summary>Получить имя типа сущности</summary>
    /// <returns></returns>
    protected string GetEntityTypeName(int? tableNumber = null) => this.metadata.FullTypeName + (!tableNumber.HasValue ? "" : z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516841328) + (object) tableNumber.Value);

    /// <summary>Получить ссылку на тип сущности</summary>
    /// <returns></returns>
    protected ISyntaxNode GetEntityTypeRef(int? tableNumber = null) => this.GetEntityTypeName(tableNumber).CreateTypeSyntax();

    /// <inheritdoc />
    protected override IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) EntityDescriptor.RunWithCheckSoftDeletable<ISyntaxNode[]>((Func<ISyntaxNode[]>) (() => base.GetMembers().ToArray<ISyntaxNode>()));

    /// <summary>Записать свойства класса</summary>
    protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements) => base.GetProperties(ctorStatements).If<ISyntaxNode>(this.NeedWriteTypeUidProperty && !this.metadata.IsInterfaceType, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (m => m.Concat<ISyntaxNode>(this.WriteTypeUidProperty()))).Concat<ISyntaxNode>(this.WriteTablePartProperties(ctorStatements)).If<ISyntaxNode>(this.metadata is TablePartMetadata && !this.metadata.IsInterfaceType, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (m => m.Concat<ISyntaxNode>(this.WriteTablePartParentProperty())));

    /// <summary>Нужно ли писать свойство TypeUid</summary>
    protected virtual bool NeedWriteTypeUidProperty
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!this.metadata.AllowCreateHeirs)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return EntityGenerator.lchJ5Mh4rEikjPPyyE7c(EntityGenerator.NiD7lIh4lrZSiVhJIdCw((object) this.metadata), Guid.Empty);
label_3:
        return true;
      }
    }

    /// <summary>
    /// Записать свойство "TypeUid" (идентификатор типа сущности)
    /// </summary>
    protected virtual IEnumerable<ISyntaxNode> WriteTypeUidProperty() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteTypeUidProperty\u003Ed__23(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Получить имя таблицы для класса сущности (части сущности)
    /// </summary>
    /// <param name="tableNumber">Номер таблицы калсса части сущности</param>
    /// <returns>Имя таблицы для класса сущности (части сущности)</returns>
    protected virtual string GetTableName(int? tableNumber) => NHibernateClassMapping.GetTableName(this.metadata, tableNumber);

    /// <summary>Записать атрибуты свойства</summary>
    /// <param name="property">Объявление свойства</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="resourcePrefix">Префикс для ресурса</param>
    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num = 12;
      EntityPropertyMetadata propertyMetadata1;
      List<ISyntaxNode> attributes;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 17:
            if (EntityGenerator.YtpVcWh6kTcVJnnKf7vZ((object) propertyMetadata1))
            {
              num = 19;
              continue;
            }
            goto case 6;
          case 2:
            propertyMetadata1 = propertyMetadata as EntityPropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 5;
            continue;
          case 3:
            List<ISyntaxNode> syntaxNodeList = attributes;
            Type raw = TypeOf<EntityPropertyAttribute>.Raw;
            ISyntaxNode[] syntaxNodeArray;
            if (propertyMetadata1.TableNumber <= 0)
              syntaxNodeArray = new ISyntaxNode[0];
            else
              syntaxNodeArray = new ISyntaxNode[1]
              {
                ((ISyntaxNode) EntityGenerator.Sre7cih6O15bF5sQn1b0((object) EntityGenerator.cyDidrh6nI2htiXI4dgL((object) propertyMetadata1))).AttributeArgument((string) EntityGenerator.Lure5ih4xuXECmddpOn0(1505778440 - 1981636111 ^ -475952859))
              };
            object[] objArray = (object[]) syntaxNodeArray;
            ISyntaxNode attribute = raw.CreateAttribute(objArray);
            syntaxNodeList.Add(attribute);
            num = 14;
            continue;
          case 4:
            if (EntityGenerator.CtAqYEh6KYMhne8E1xYM((object) propertyMetadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 7;
              continue;
            }
            goto case 8;
          case 5:
            if (propertyMetadata1 != null)
            {
              attributes = new List<ISyntaxNode>();
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 15 : 15;
            continue;
          case 6:
            if (((EntityPropertyMetadata) propertyMetadata).Filterable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 7:
            attributes.Add(TypeOf<FastSearchAttribute>.Raw.CreateAttribute((object) propertyMetadata1.InFastSearch));
            num = 8;
            continue;
          case 8:
            if (EntityGenerator.f38vJUh6Xt2Q4wTcWZsN((object) propertyMetadata1))
            {
              num = 18;
              continue;
            }
            goto case 10;
          case 9:
            goto label_12;
          case 10:
            if (!EntityGenerator.KqOoB4h6TcEqWiiB9H52((object) propertyMetadata1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            }
            goto case 16;
          case 11:
            EntityGenerator.DaDv3eh40sQ322l76aZb((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113881425));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 13 : 12;
            continue;
          case 12:
            Contract.ArgumentNotNull((object) property, (string) EntityGenerator.Lure5ih4xuXECmddpOn0(-70007027 ^ -70066677));
            num = 11;
            continue;
          case 13:
            base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
            continue;
          case 14:
            property.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
            num = 9;
            continue;
          case 15:
            goto label_6;
          case 16:
            attributes.Add(TypeOf<InputAttribute>.Raw.CreateAttribute((object) EntityGenerator.KqOoB4h6TcEqWiiB9H52((object) propertyMetadata1)));
            num = 17;
            continue;
          case 18:
            attributes.Add(TypeOf<ShowInTableAttribute>.Raw.CreateAttribute((object) EntityGenerator.f38vJUh6Xt2Q4wTcWZsN((object) propertyMetadata1)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 7 : 10;
            continue;
          case 19:
            attributes.Add(TypeOf<OutputAttribute>.Raw.CreateAttribute((object) propertyMetadata1.Output));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 6 : 5;
            continue;
          default:
            attributes.Add(TypeOf<FilterableAttribute>.Raw.CreateAttribute());
            num = 3;
            continue;
        }
      }
label_12:
      return;
label_6:;
    }

    /// <summary>Записать ресурсы класса</summary>
    protected override IEnumerable<ISyntaxTrivia> Resources()
    {
      Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470458464));
      return base.Resources().If<ISyntaxTrivia>(this.HasFilterClass, (Func<IEnumerable<ISyntaxTrivia>, IEnumerable<ISyntaxTrivia>>) (m => m.Concat<ISyntaxTrivia>(this.metadata.Filter.Properties.SelectMany<PropertyMetadata, ISyntaxTrivia>((Func<PropertyMetadata, IEnumerable<ISyntaxTrivia>>) (propertyMetadata => this.PropertyResources(propertyMetadata))))));
    }

    /// <summary>Есть ли класс фильтра</summary>
    protected virtual bool HasFilterClass
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, EntityGenerator.Lure5ih4xuXECmddpOn0(1242972401 >> 4 ^ 77671729));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.metadata.Filterable;
      }
    }

    /// <summary>Есть ли класс фильтра</summary>
    protected virtual string FilterClassName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, EntityGenerator.Lure5ih4xuXECmddpOn0(-2107978722 ^ -2107996896));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) EntityGenerator.OdisQ5h45npiCgl1fSk1((object) this.metadata) + (string) EntityGenerator.Lure5ih4xuXECmddpOn0(1654249598 >> 2 ^ 413545763);
      }
    }

    /// <summary>Базовый класс фильтра</summary>
    protected virtual ISyntaxNode GetBasicFilter() => (ISyntaxNode) EntityGenerator.g9T6J9h62yV8JfUcvYSo(TypeOf<Filter>.Raw);

    /// <summary>Записать класс фильтра</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteFilterInterface() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteFilterInterface\u003Ed__32(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить базовый класс фильтра</summary>
    /// <param name="attributes">Список атрибутов для заполнения</param>
    /// <param name="interfaceTypes">Список реализуемых интерфейсов для заполнения</param>
    protected virtual ISyntaxNode WriteFilterClassByBaseClass(
      List<ISyntaxNode> attributes,
      List<ISyntaxNode> interfaceTypes)
    {
      EntityMetadata entityMetadata = (EntityMetadata) null;
      if (this.metadata.BaseClassUid != Guid.Empty)
      {
        entityMetadata = this.GetMetadata(this.metadata.BaseClassUid) as EntityMetadata;
        while (entityMetadata != null && !entityMetadata.Filterable)
          entityMetadata = entityMetadata.BaseClassUid != Guid.Empty ? this.GetMetadata(entityMetadata.BaseClassUid) as EntityMetadata : (EntityMetadata) null;
      }
      ISyntaxNode syntaxNode = entityMetadata != null ? (entityMetadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011281)).CreateTypeSyntax() : this.GetBasicFilter();
      if (this.metadata.Type == EntityMetadataType.InterfaceImplementation)
      {
        string interfaceTypeName = this.GetInterfaceTypeName();
        if (interfaceTypeName != null)
        {
          interfaceTypes.Add((interfaceTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461641381)).CreateTypeSyntax());
          attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((object) (interfaceTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011281)).TypeOfExpression()));
        }
        if (this.metadata.ImplementedExtensionUids != null)
        {
          foreach (Guid implementedExtensionUid in this.metadata.ImplementedExtensionUids)
          {
            if (this.GetMetadata(implementedExtensionUid) is EntityMetadata metadata && metadata.Filterable)
            {
              interfaceTypes.Add((metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411212655)).CreateTypeSyntax());
              attributes.Add(TypeOf<ImplementAttribute>.Raw.CreateAttribute((object) (metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082381860)).TypeOfExpression()));
            }
          }
        }
      }
      return syntaxNode;
    }

    /// <summary>Добавить атрибут FilterForAttribute фильтру</summary>
    protected virtual IEnumerable<ISyntaxNode> FilterForAttribute() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CFilterForAttribute\u003Ed__34(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить полное имя интерфейса</summary>
    protected virtual string GetInterfaceTypeName()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_4;
          case 2:
            goto label_5;
          case 4:
            if (!(EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, EntityGenerator.zRrt6ih6vwMl5uTCobf5((object) this.metadata)) is EntityMetadata entityMetadata))
            {
              num = 3;
              continue;
            }
            break;
        }
        if (EntityGenerator.pq9CMRh6WsZg7okAShQk((object) entityMetadata))
          num = 2;
        else
          break;
      }
label_4:
      return (string) null;
label_5:
      return (string) EntityGenerator.ooTnNAh4YFoC7vNBaXJU((object) entityMetadata);
    }

    /// <summary>Добавить описание фильтру</summary>
    /// <param name="filterType">Тип фильтра</param>
    protected virtual void FilterCommentSummary(ISyntaxNode filterType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            filterType.XmlComments(EleWise.ELMA.SR.T((string) EntityGenerator.Lure5ih4xuXECmddpOn0(44884861 ^ 45061771), EntityGenerator.R0b7OPh6eWsZfSPakY43((object) this.metadata.DisplayName)).SummaryComment());
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

    /// <summary>Записать конструкторы фильтра</summary>
    /// <param name="ctorStatements">Действия конструктора</param>
    protected virtual IEnumerable<ISyntaxNode> GetFilterCtors(List<ISyntaxNode> ctorStatements) => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CGetFilterCtors\u003Ed__37(-2)
    {
      \u003C\u003E3__ctorStatements = ctorStatements
    };

    /// <summary>Записать класс фильтра</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteFilterMembers()
    {
      List<ISyntaxNode> ctorStatements = this.metadata.IsInterfaceType ? (List<ISyntaxNode>) null : new List<ISyntaxNode>();
      // ISSUE: reference to a compiler-generated method
      List<ISyntaxNode> list = this.metadata.Properties.OfType<EntityPropertyMetadata>().Where<EntityPropertyMetadata>((Func<EntityPropertyMetadata, bool>) (p => EntityGenerator.\u003C\u003Ec.LqQIX4vOaTuqUiGt4HDG((object) p))).SelectMany<EntityPropertyMetadata, ISyntaxNode>((Func<EntityPropertyMetadata, IEnumerable<ISyntaxNode>>) (prop => this.FilterClassProperty((PropertyMetadata) prop, ctorStatements, false))).If<ISyntaxNode>(this.metadata.Filter != null && this.metadata.Filter.Properties != null, (Func<IEnumerable<ISyntaxNode>, IEnumerable<ISyntaxNode>>) (p => p.Concat<ISyntaxNode>(this.metadata.Filter.Properties.SelectMany<PropertyMetadata, ISyntaxNode>((Func<PropertyMetadata, IEnumerable<ISyntaxNode>>) (prop => this.FilterClassProperty(prop, ctorStatements, true)))))).ToList<ISyntaxNode>();
      return this.GetFilterCtors(ctorStatements).Concat<ISyntaxNode>((IEnumerable<ISyntaxNode>) list);
    }

    /// <summary>Записать класс фильтра</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteFilterClass() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteFilterClass\u003Ed__39(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Создать метаданные свойства фильтра по метаданым свойства
    /// </summary>
    /// <param name="filterType">Дескриптор свойства фильтра</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual PropertyMetadata CreateFilterPropertyMetadataFromProperty(
      ITypeDescriptor filterType,
      PropertyMetadata propertyMetadata)
    {
      PropertyMetadata metadataFromProperty = ClassSerializationHelper.CloneObjectByXml<PropertyMetadata>(propertyMetadata);
      metadataFromProperty.Required = false;
      EntityGenerator.KcmcKlh6Pb4kh04y3fEn((object) metadataFromProperty, true);
      EntityGenerator.Yhhs7bh6N1fPs6N300vQ((object) metadataFromProperty, EntityGenerator.V7TQiKh610rtlRy05g1s((object) filterType, (object) propertyMetadata));
      return metadataFromProperty;
    }

    /// <summary>Записываем свойство фильтра</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteFilterClassProperty(
      PropertyMetadata filterPropertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool isCustomProperty,
      ITypeDescriptor filterType)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteFilterClassProperty\u003Ed__41(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__filterPropertyMetadata = filterPropertyMetadata,
        \u003C\u003E3__ctorStatements = ctorStatements,
        \u003C\u003E3__isCustomProperty = isCustomProperty,
        \u003C\u003E3__filterType = filterType
      };
    }

    /// <summary>Свойство фильтра</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="ctorStatements">Тело конструктора</param>
    /// <param name="isCustomProperty">Является ли свойство кастомным (если False - то свойство из сущности)</param>
    /// <returns></returns>
    protected IEnumerable<ISyntaxNode> FilterClassProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool isCustomProperty)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CFilterClassProperty\u003Ed__42(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__propertyMetadata = propertyMetadata,
        \u003C\u003E3__ctorStatements = ctorStatements,
        \u003C\u003E3__isCustomProperty = isCustomProperty
      };
    }

    /// <summary>Есть ли класс привилегий</summary>
    [Obsolete("Не используется")]
    protected virtual bool HasPermissionClass
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765837804));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (EntityGenerator.NiD7lIh4lrZSiVhJIdCw((object) this.metadata) == Guid.Empty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        return EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata(this.metadata) != null;
label_6:
        return false;
      }
    }

    /// <summary>Записать классы для привилегий</summary>
    private IEnumerable<GeneratedFileInfo> WritePermissionClass()
    {
      Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867364557));
      TablePartMetadata metadataFromMetadata = EntityMetadataExtensions.GetActivePermissionMetadataFromMetadata(this.metadata);
      if (metadataFromMetadata == null)
        return Enumerable.Empty<GeneratedFileInfo>();
      metadataFromMetadata.Namespace = this.metadata.Namespace;
      EntityPermissionsGenerator permissionsGenerator = new EntityPermissionsGenerator(this.metadata);
      ((ICodeGenerator) permissionsGenerator).Metadata = (IMetadata) metadataFromMetadata;
      ((ICodeGenerator) permissionsGenerator).GenerationParams = this.generationParams.Clone();
      ((ICodeGenerator) permissionsGenerator).GenerationParams.Prefix += metadataFromMetadata.Name;
      return (IEnumerable<GeneratedFileInfo>) ((ICodeGenerator) permissionsGenerator).GenerateAdditionalFiles();
    }

    /// <summary>
    /// Есть ли тип (генерируется ли тип), содержащий действия с сущностью
    /// </summary>
    protected virtual bool HasActionsType
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, EntityGenerator.Lure5ih4xuXECmddpOn0(-1872275253 >> 6 ^ -29240227));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return this.HasActions(this.metadata);
      }
    }

    /// <summary>Имя класса, содержащего действия с сущностью</summary>
    protected string ActionsTypeName => (string) EntityGenerator.WLWaYhh637vbhDVYNLWI((object) this.metadata);

    /// <summary>
    /// Сгенерировать дополнительные файлы со списком действий
    /// </summary>
    protected virtual IEnumerable<GeneratedFileInfo> GenerateActions()
    {
      if (!this.HasActionsType)
        return Enumerable.Empty<GeneratedFileInfo>();
      string name = this.metadata.Actions.Name;
      string displayName = this.metadata.Actions.DisplayName;
      string str = this.metadata.Actions.Namespace;
      try
      {
        this.metadata.Actions.Name = this.ActionsTypeName;
        this.metadata.Actions.DisplayName = string.Format(EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712303005)), (object) this.metadata.DisplayName);
        this.metadata.Actions.Namespace = this.metadata.Namespace;
        EntityActionsGenerator actionsGenerator = new EntityActionsGenerator();
        actionsGenerator.EntityMetadata = this.metadata;
        ((ICodeGenerator) actionsGenerator).Metadata = (IMetadata) this.metadata.Actions;
        ((ICodeGenerator) actionsGenerator).GenerationParams = this.generationParams.Clone();
        ((ICodeGenerator) actionsGenerator).GenerationParams.Prefix = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3256258);
        return (IEnumerable<GeneratedFileInfo>) ((ICodeGenerator) actionsGenerator).Generate();
      }
      finally
      {
        this.metadata.Actions.Name = name;
        this.metadata.Actions.DisplayName = displayName;
        this.metadata.Actions.Namespace = str;
      }
    }

    /// <summary>Записать классы для блоков</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteTablePartClasses() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteTablePartClasses\u003Ed__51(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Создать генератор кода класса табличной части</summary>
    /// <returns>Генератор</returns>
    [Obsolete("Метод устарел", true)]
    protected virtual EntityGenerator CreateTablePartGenerator() => (EntityGenerator) EntityGenerator.TbfJJoh6pjUywntIw6Vm((object) this, (object) null);

    /// <summary>Создать генератор кода класса табличной части</summary>
    /// <param name="tablePart">Метаданные табличной части</param>
    protected virtual EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (tablePart != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          default:
            if (EntityGenerator.Uoe1NPh6aBaC3fYX4hQp((object) tablePart))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return (EntityGenerator) new EntityPermissionsGenerator(this.metadata);
label_7:
      return new EntityGenerator();
    }

    /// <summary>Записать класс для блока</summary>
    /// <param name="tablePart">Блок</param>
    protected virtual IEnumerable<ISyntaxNode> WriteTablePartClass(TablePartMetadata tablePart)
    {
      Contract.ArgumentNotNull((object) tablePart, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420970172));
      Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123618496));
      EntityGenerator tablePartGenerator = this.CreateTablePartGenerator(tablePart);
      ((ICodeGenerator) tablePartGenerator).GenerationParams = this.generationParams;
      ((ICodeGenerator) tablePartGenerator).Metadata = (IMetadata) tablePart;
      return tablePartGenerator.GenerateMainFile();
    }

    /// <summary>Записать свойства для блоков</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteTablePartProperties(
      List<ISyntaxNode> ctorStatements)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteTablePartProperties\u003Ed__55(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__ctorStatements = ctorStatements
      };
    }

    /// <summary>Записать свойство для блока</summary>
    /// <param name="tablePart">Блок</param>
    /// <param name="writeAttributes">Записать атрибуты свойства</param>
    protected virtual IEnumerable<ISyntaxNode> WriteTablePartProperty(
      TablePartMetadata tablePart,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true)
    {
      Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195600341));
      Contract.ArgumentNotNull((object) tablePart, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475952485));
      EntityPropertyTablePartMetadata propertyMetadata = new EntityPropertyTablePartMetadata(this.metadata, tablePart);
      return this.WriteProperty((PropertyMetadata) propertyMetadata, ctorStatements, writeAttributes, (Action<ISyntaxNode>) (property =>
      {
        int num = 1;
        List<ISyntaxNode> attributes;
        while (true)
        {
          switch (num)
          {
            case 1:
              attributes = new List<ISyntaxNode>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 2:
            case 4:
              attributes.Add(TypeOf<TablePartPropertyAttribute>.Raw.CreateAttribute());
              num = 6;
              continue;
            case 3:
              goto label_4;
            case 5:
              // ISSUE: reference to a compiler-generated method
              attributes.Add(TypeOf<UidAttribute>.Raw.CreateAttribute((object) EntityGenerator.\u003C\u003Ec__DisplayClass56_0.krDQVfvefThpXukGhRLL((object) propertyMetadata).ToString()));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 4;
              continue;
            case 6:
              property.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 3;
              continue;
            default:
              if (writeAttributes)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 2;
                continue;
              }
              goto case 5;
          }
        }
label_4:;
      }));
    }

    /// <summary>Записать свойство Parent в классе блока</summary>
    protected virtual IEnumerable<ISyntaxNode> WriteTablePartParentProperty() => (IEnumerable<ISyntaxNode>) new EntityGenerator.\u003CWriteTablePartParentProperty\u003Ed__57(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Сгенерировать файл с ресурсом для метаданных модели отображения
    /// </summary>
    /// <returns>Файл с ресурсом</returns>
    protected virtual GeneratedFileInfo GenerateViewModelMetadataResource()
    {
      GeneratedFileInfo metadataResource = new GeneratedFileInfo();
      metadataResource.Data = ClassSerializationHelper.SerializeObjectByXmlToBytes(EntityGenerator.KQ4Qd1h6qETRKbfcpTLS((object) this.metadata));
      metadataResource.Extension = this.GetViewModelMetadataResourceExtension();
      EntityGenerator.fic5keh6DCyqW3XvraM4((object) metadataResource, GeneratedFileType.EmbeddedResource);
      return metadataResource;
    }

    /// <summary>
    /// Получить расширение для ресурсного файла метаданных модели отображения
    /// </summary>
    /// <returns>Расширение ресурсного файла</returns>
    protected string GetViewModelMetadataResourceExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityGenerator.yI8YoVh6RiCrKxSPiCIK(EntityGenerator.AVWCCBh6tYpBuv2ZAZTi((object) this.generationParams)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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
      return (string) EntityGenerator.EUXaNeh6wZvisSB9qTMu(EntityGenerator.Lure5ih4xuXECmddpOn0(1021410165 ^ 1021403569), (object) this.generationParams.Prefix, EntityGenerator.Lure5ih4xuXECmddpOn0(-542721635 ^ -542781467));
label_5:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669587859);
    }

    /// <summary>
    /// Получить имя для ресурсного файла метаданных модели отображения
    /// </summary>
    /// <returns>Имя ресурсного файла</returns>
    protected string GetViewModelMetadataResourceName() => (string) EntityGenerator.d4Faq0h644Q5nnrCwAC2((object) this.generationParams) + (string) EntityGenerator.Lure5ih4xuXECmddpOn0(~1767720452 ^ -1767726273) + (string) EntityGenerator.T3BfNDh6HbViW6ej1xVP((object) Path.GetFileName((string) EntityGenerator.orVOBkh66X0ZYoQL964V((object) this.generationParams))) + this.GetViewModelMetadataResourceExtension();

    private bool HasCustomCodeInternal(EntityMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!string.IsNullOrEmpty((string) EntityGenerator.FmwvGsh6Ao0KWDFlsVto((object) metadata)))
            {
              num = 3;
              continue;
            }
            goto label_5;
          case 3:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return !string.IsNullOrEmpty(metadata.CustomCode.Trim(((string) EntityGenerator.Lure5ih4xuXECmddpOn0(1597012150 ^ 1596993274)).ToCharArray()));
label_5:
      return false;
    }

    private IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources(
      EntityMetadata metadata,
      bool isInterfaceType)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<GeneratedFileInfo>) new EntityGenerator.\u003CGenerateCustomCodeResources\u003Ed__62(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__metadata = metadata,
        \u003C\u003E3__isInterfaceType = isInterfaceType
      };
    }

    /// <summary>Есть ли кастомный код</summary>
    protected override bool HasCustomCode
    {
      get
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_10;
              case 2:
                goto label_8;
              case 3:
                if (this.HasCustomCodeInternal(this.metadata))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
                  continue;
                }
                break;
              case 4:
                goto label_7;
            }
            if (this.metadata.ImplementedExtensionUids != null)
              num2 = 2;
            else
              goto label_9;
          }
label_7:
          EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) this.metadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501454007));
          num1 = 3;
        }
label_8:
        return this.metadata.ImplementedExtensionUids.Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (extUid => (EntityMetadata) this.GetMetadata(extUid))).Any<EntityMetadata>(new Func<EntityMetadata, bool>(this.HasCustomCodeInternal));
label_9:
        return false;
label_10:
        return true;
      }
    }

    /// <summary>
    /// Сгенерировать дополнительный файл с ресурсом кастомного кода
    /// </summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources()
    {
      Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082384422));
      return this.GenerateCustomCodeResources(this.metadata, this.metadata.IsInterfaceType).If<GeneratedFileInfo>(this.metadata.ImplementedExtensionUids != null, (Func<IEnumerable<GeneratedFileInfo>, IEnumerable<GeneratedFileInfo>>) (r => r.Concat<GeneratedFileInfo>(this.metadata.ImplementedExtensionUids.Select<Guid, EntityMetadata>((Func<Guid, EntityMetadata>) (extUid => (EntityMetadata) EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, extUid))).SelectMany<EntityMetadata, GeneratedFileInfo>((Func<EntityMetadata, IEnumerable<GeneratedFileInfo>>) (m => this.GenerateCustomCodeResources(m, this.metadata.IsInterfaceType))))));
    }

    private bool HasActions(EntityMetadata entityMetadata)
    {
      int num = 6;
      EntityMetadata entityMetadata1;
      while (true)
      {
        EntityMetadata entityMetadata2;
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            goto label_14;
          case 3:
            goto label_11;
          case 4:
            if (EntityGenerator.Ty8KOGh6x2jaBbQrkSoO((object) ((EnumMetadata) EntityGenerator.nO92cfh67aF9xBRZAxBV((object) entityMetadata)).Values) > 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 2 : 1;
              continue;
            }
            break;
          case 5:
            if (EntityGenerator.eJjCAEh4z69gYosmRvfM((object) entityMetadata) != EntityMetadataType.InterfaceImplementation)
            {
              if (entityMetadata.Actions != null)
              {
                num = 4;
                continue;
              }
              break;
            }
            num = 7;
            continue;
          case 6:
            EntityGenerator.mFmaRqh4JG13Q1JZSJYF((object) entityMetadata, EntityGenerator.Lure5ih4xuXECmddpOn0(813604817 ^ 813436959));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 5;
            continue;
          case 7:
            goto label_4;
          case 8:
label_17:
            entityMetadata2 = (EntityMetadata) null;
            goto label_19;
          case 9:
            entityMetadata2 = (EntityMetadata) EntityGenerator.UVUZlXh4gO4ZKuJ4pbkr((object) this, entityMetadata.BaseClassUid);
            goto label_19;
          default:
            if (entityMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 0;
              continue;
            }
            goto label_10;
        }
        if (EntityGenerator.NiD7lIh4lrZSiVhJIdCw((object) entityMetadata) != Guid.Empty)
        {
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 9 : 6;
          continue;
        }
        goto label_17;
label_19:
        entityMetadata1 = entityMetadata2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
      }
label_4:
      return false;
label_10:
      return false;
label_11:
      return this.HasActions(entityMetadata1);
label_14:
      return true;
    }

    public EntityGenerator()
    {
      EntityGenerator.aiiu0Lh60e1Iio1oBB0r();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object YgAF88h47bK52hNKwHkw([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object Lure5ih4xuXECmddpOn0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool fUdH8Ph4HKGjw1wMCraF() => EntityGenerator.kbJOjVh46eb27EitZRWa == null;

    internal static EntityGenerator RkR66ph4AQ626BUFvHGk() => EntityGenerator.kbJOjVh46eb27EitZRWa;

    internal static void DaDv3eh40sQ322l76aZb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void a31mADh4mAyn0MqGCXIw(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object xDsK1Rh4yIVqvV4PvIE1() => (object) MetadataServiceContext.Service;

    internal static object dXBXQDh4MfTwOTiQ9YJO([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static void mFmaRqh4JG13Q1JZSJYF([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static Guid bMoiflh49hGNPYf30f54([In] object obj0) => ((EntityMetadata) obj0).IdTypeUid;

    internal static bool R3QjKTh4dJc43SLGVFkn([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid NiD7lIh4lrZSiVhJIdCw([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool lchJ5Mh4rEikjPPyyE7c([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object UVUZlXh4gO4ZKuJ4pbkr([In] object obj0, Guid uid) => (object) ((CodeGenerator) obj0).GetMetadata(uid);

    internal static object OdisQ5h45npiCgl1fSk1([In] object obj0) => (object) ((ClassMetadata) obj0).TypeName;

    internal static object si7jdTh4jjc6VeHqnL2f([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object ooTnNAh4YFoC7vNBaXJU([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object x2q7tCh4Lnqj9XJOt3m5([In] object obj0, [In] object obj1) => (object) ((EntityGenerator) obj0).GetBasicEntity((ISyntaxNode) obj1);

    internal static object FWJOG3h4U2n29mDVeeBb([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool IMO1HHh4sxFwjRpX5gxV([In] object obj0) => ((EntityMetadata) obj0).ShowInCatalogList;

    internal static bool g2o0Nnh4cEmdfTaEry3N([In] object obj0) => ((EntityMetadata) obj0).HideChildItemsTab;

    internal static EntityMetadataType eJjCAEh4z69gYosmRvfM([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static bool fJFNPuh6FvsiF3bUBWnM([In] object obj0) => ((EntityMetadata) obj0).SaveHistory;

    internal static CopyAction Ni8eI1h6BLd27aPseTRl([In] object obj0) => ((EntityMetadata) obj0).CopyAction;

    internal static bool pq9CMRh6WsZg7okAShQk([In] object obj0) => ((EntityMetadata) obj0).Filterable;

    internal static bool DBqUGph6oX9DJSNosyQr([In] object obj0) => ((EntityMetadata) obj0).IsUnique;

    internal static bool A0d4wah6bhh3eKnPqO7v([In] object obj0) => ((EntityMetadata) obj0).CacheEntity;

    internal static object vi6JO1h6hMuHWZAOrpIl([In] object obj0) => (object) ((EntityMetadata) obj0).PermissionsMetadataName;

    internal static bool gNSUMRh6GQkf3lB0kT0R([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static bool J5cfJyh6EplgSseCSRxo([In] object obj0) => ((EntityMetadata) obj0).InstancePermissionsSupport;

    internal static bool Q6JfWth6fICcfyNxn948([In] object obj0) => ((EntityMetadata) obj0).Hierarchical;

    internal static HierarchyType mOKlJSh6QIed4wrMvLSH([In] object obj0) => ((EntityMetadata) obj0).HierarchyType;

    internal static Guid TCDAm3h6C36JI6eDx6ql([In] object obj0) => ((EntityMetadata) obj0).IsGroupPropertyUid;

    internal static Guid zRrt6ih6vwMl5uTCobf5([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static object k41Lnah68679sJSS8mHc([In] object obj0) => (object) ((string) obj0).TypeOfExpression();

    internal static bool cFEgrCh6ZNxfQR4UcOWO([In] object obj0) => ((EntityGenerator) obj0).HasActionsType;

    internal static int W6pqiph6ubpTQyqOWjiU([In] object obj0) => ((TablePartMetadata) obj0).Order;

    internal static Guid r009cKh6Iy1mTS1Pt4VZ([In] object obj0) => ((EntityMetadata) obj0).ParentPropertyUid;

    internal static object D5wmwih6VIVUZtd3Dw6I([In] object obj0) => (object) ((TablePartMetadata) obj0).TablePartPropertyName;

    internal static object d086YZh6S8PE6NleXWpm(Type attributeType, [In] object obj1) => (object) attributeType.CreateAttribute((KeyValuePair<string, object>[]) obj1);

    internal static object CoKCyAh6i5WxjfPAC5hR([In] object obj0) => (object) ((TablePartMetadata) obj0).OnChangeScriptName;

    internal static bool yI8YoVh6RiCrKxSPiCIK([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object KQ4Qd1h6qETRKbfcpTLS([In] object obj0) => (object) ((EntityMetadata) obj0).ViewModelMetadata;

    internal static bool CtAqYEh6KYMhne8E1xYM([In] object obj0) => ((EntityPropertyMetadata) obj0).InFastSearch;

    internal static bool f38vJUh6Xt2Q4wTcWZsN([In] object obj0) => ((EntityPropertyMetadata) obj0).ShowInTable;

    internal static bool KqOoB4h6TcEqWiiB9H52([In] object obj0) => ((EntityPropertyMetadata) obj0).Input;

    internal static bool YtpVcWh6kTcVJnnKf7vZ([In] object obj0) => ((EntityPropertyMetadata) obj0).Output;

    internal static int cyDidrh6nI2htiXI4dgL([In] object obj0) => ((EntityPropertyMetadata) obj0).TableNumber;

    internal static object Sre7cih6O15bF5sQn1b0([In] object obj0) => (object) obj0.CreateSyntaxNode();

    internal static object g9T6J9h62yV8JfUcvYSo(Type type) => (object) type.CreateTypeSyntax();

    internal static object R0b7OPh6eWsZfSPakY43([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void KcmcKlh6Pb4kh04y3fEn([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static object V7TQiKh610rtlRy05g1s([In] object obj0, [In] object obj1) => (object) ((ITypeDescriptor) obj0).CreateSettingsForFilterProperty((PropertyMetadata) obj1);

    internal static void Yhhs7bh6N1fPs6N300vQ([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static object WLWaYhh637vbhDVYNLWI([In] object obj0) => (object) EntityGenerator.GetActionsTypeName((EntityMetadata) obj0);

    internal static object TbfJJoh6pjUywntIw6Vm([In] object obj0, [In] object obj1) => (object) ((EntityGenerator) obj0).CreateTablePartGenerator((TablePartMetadata) obj1);

    internal static bool Uoe1NPh6aBaC3fYX4hQp([In] object obj0) => ((EntityMetadata) obj0).IsActivePermissionMetadata();

    internal static void fic5keh6DCyqW3XvraM4([In] object obj0, GeneratedFileType value) => ((GeneratedFileInfo) obj0).Type = value;

    internal static object AVWCCBh6tYpBuv2ZAZTi([In] object obj0) => (object) ((GenerationParams) obj0).Prefix;

    internal static object EUXaNeh6wZvisSB9qTMu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object d4Faq0h644Q5nnrCwAC2([In] object obj0) => (object) ((GenerationParams) obj0).Namespace;

    internal static object orVOBkh66X0ZYoQL964V([In] object obj0) => (object) ((GenerationParams) obj0).FileName;

    internal static object T3BfNDh6HbViW6ej1xVP([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object FmwvGsh6Ao0KWDFlsVto([In] object obj0) => (object) ((ClassMetadata) obj0).CustomCode;

    internal static object nO92cfh67aF9xBRZAxBV([In] object obj0) => (object) ((EntityMetadata) obj0).Actions;

    internal static int Ty8KOGh6x2jaBbQrkSoO([In] object obj0) => ((List<EnumValueMetadata>) obj0).Count;

    internal static void aiiu0Lh60e1Iio1oBB0r() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
