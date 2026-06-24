// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.EnumGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор кода для перечислений</summary>
  public class EnumGenerator : CodeGenerator
  {
    protected EnumMetadata metadata;
    private static EnumGenerator F4uuJchw9d55mZrUtmTW;

    protected override void InitInternal(IMetadata metadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            if (this.metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_9;
          case 3:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
              continue;
            }
            this.metadata = metadata as EnumMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_8:
      return;
label_2:
      return;
label_7:
      throw new ArgumentException((string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(-1978478350 ^ -1978555528), (string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(323422137 << 2 ^ 1293703130));
label_9:
      throw new ArgumentNullException((string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(1925118608 << 2 ^ -889478274));
    }

    protected override GeneratedFileInfo GenerateMainFileInternal()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            EnumGenerator.doaNqBhwg9PdEXneqtf7((object) this.metadata, EnumGenerator.SRd4GEhwrMIEjlABnrYS(1925118608 << 2 ^ -889478274));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
            continue;
          default:
            goto label_10;
        }
      }
label_3:
      GeneratedFileInfo mainFileHelper;
      try
      {
        mainFileHelper = this.GenerateMainFileHelper((string) EnumGenerator.nAaGjHhwYA3kEUnTCqBF(EnumGenerator.D0xPYHhw5mFoAsA7TrlC((object) this.generationParams.Prefix) ? (object) "" : EnumGenerator.nAaGjHhwYA3kEUnTCqBF(EnumGenerator.SRd4GEhwrMIEjlABnrYS(272623989 ^ 272626609), EnumGenerator.WWSDQ5hwjK0K0tYdoptP((object) this.generationParams)), EnumGenerator.SRd4GEhwrMIEjlABnrYS(-1852837372 ^ -1852904630)), (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
        {
          this.metadata.Namespace.NamespaceDeclaration(this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile()))
        }, (EnumGenerator.nN7QgDhwLj0lHDmHl3s4((object) this) ? 1 : 0) != 0);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487197416), EnumGenerator.u2iRMvhwUpeHfxy1qolW((object) this.metadata)), ex);
        }
      }
label_10:
      return mainFileHelper;
    }

    /// <summary>Сгенерировать дополнительные файлы</summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => this.GenerateImageResources();

    /// <summary>Получить используемые пространства имен</summary>
    /// <example>
    /// yield return generator.NamespaceImportDeclaration("System");
    /// </example>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CGetNamespaces\u003Ed__4(-2);

    /// <summary>Сгенерировать основной файл</summary>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CGenerateMainFile\u003Ed__5(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Создать объявление основного типа</summary>
    /// <returns>Объявление основного типа</returns>
    protected virtual ISyntaxNode CreateTypeDeclaration()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EnumGenerator.nN7QgDhwLj0lHDmHl3s4((object) this))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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
      return ((string) EnumGenerator.u2iRMvhwUpeHfxy1qolW((object) this.metadata)).EnumDeclaration(Accessibility.Public, members: this.Values());
label_5:
      return ((string) EnumGenerator.u2iRMvhwUpeHfxy1qolW((object) this.metadata)).ClassDeclaration(Accessibility.Public, baseType: (ISyntaxNode) EnumGenerator.xeTkGxhwsPh1Kuspx0Nb((object) this), members: this.Values());
    }

    /// <summary>Записать комментарии к классу</summary>
    /// <param name="type">Объявление класса</param>
    protected virtual void WriteComments(ISyntaxNode type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.XmlComments(type, (NamedDocumentedMetadata) this.metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Записать атрибуты класса</summary>
    /// <param name="declaration">Объявление класса</param>
    protected virtual void WriteTypeAttributes(ISyntaxNode declaration)
    {
      int num1 = 31;
      while (true)
      {
        int num2 = num1;
        List<MetadataImage>.Enumerator enumerator;
        Guid? defaultValueUid;
        Guid guid;
        ISyntaxNode syntaxNode;
        List<ISyntaxNode> attributes;
        EnumGenerator enumGenerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EnumGenerator.D53H9dh4oMUqwD1JmOYp((object) this.metadata))
                goto case 16;
              else
                goto label_29;
            case 3:
            case 29:
              if (this.metadata.GroupId > 0L)
              {
                num2 = 38;
                continue;
              }
              goto case 26;
            case 4:
            case 32:
            case 35:
              if (this.metadata.Images != null)
              {
                num2 = 9;
                continue;
              }
              goto case 34;
            case 5:
              if (!EnumGenerator.ERLDmvh4BkdT4hNoCA47(this.metadata.BaseTypeUid, Guid.Empty))
              {
                num2 = 29;
                continue;
              }
              goto label_20;
            case 6:
              attributes.Add(TypeOf<TypeConverterAttribute>.Raw.CreateAttribute((object) syntaxNode));
              num2 = 7;
              continue;
            case 7:
              attributes.Add(TypeOf<SerializableAttribute>.Raw.CreateAttribute());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 5 : 4;
              continue;
            case 8:
              EleWise.ELMA.SR.RunWithFutureTranslate((System.Action) (() =>
              {
                int num3 = 4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_7;
                    case 2:
                      goto label_2;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (string.IsNullOrEmpty((string) EnumGenerator.\u003C\u003Ec__DisplayClass8_0.JnMbEtvkli9PQ4gXDiZn((object) enumGenerator.metadata)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
                        continue;
                      }
                      break;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      attributes.Add(TypeOf<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.Raw.CreateAttribute(EnumGenerator.\u003C\u003Ec__DisplayClass8_0.j46Z7mvkdHVuWiU7mgWw(EnumGenerator.\u003C\u003Ec__DisplayClass8_0.LRCNGWvk9m7AdoKyCXik((object) enumGenerator.metadata))));
                      num3 = 3;
                      continue;
                  }
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  attributes.Add(TypeOf<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.Raw.CreateAttribute(EnumGenerator.\u003C\u003Ec__DisplayClass8_0.j46Z7mvkdHVuWiU7mgWw(EnumGenerator.\u003C\u003Ec__DisplayClass8_0.JnMbEtvkli9PQ4gXDiZn((object) enumGenerator.metadata))));
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
                }
label_7:
                return;
label_2:;
              }), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 27;
              continue;
            case 9:
              enumerator = this.metadata.Images.GetEnumerator();
              num2 = 36;
              continue;
            case 10:
              if (!defaultValueUid.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 20 : 35;
                continue;
              }
              goto case 13;
            case 11:
              declaration.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 19 : 21;
              continue;
            case 12:
              goto label_20;
            case 13:
              defaultValueUid = this.metadata.DefaultValueUid;
              num2 = 15;
              continue;
            case 14:
              List<ISyntaxNode> syntaxNodeList1 = attributes;
              Type raw1 = TypeOf<DefaultValueUidAttribute>.Raw;
              object[] objArray1 = new object[1];
              defaultValueUid = this.metadata.DefaultValueUid;
              guid = defaultValueUid.Value;
              objArray1[0] = (object) guid.ToString();
              ISyntaxNode attribute1 = raw1.CreateAttribute(objArray1);
              syntaxNodeList1.Add(attribute1);
              num2 = 32;
              continue;
            case 15:
              if (!EnumGenerator.ERLDmvh4BkdT4hNoCA47(defaultValueUid.Value, Guid.Empty))
              {
                num2 = 4;
                continue;
              }
              goto case 14;
            case 16:
              defaultValueUid = this.metadata.DefaultValueUid;
              num2 = 10;
              continue;
            case 17:
              goto label_62;
            case 18:
              attributes = new List<ISyntaxNode>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 28 : 8;
              continue;
            case 19:
              attributes.Add(TypeOf<ShowInDesignerAttribute>.Raw.CreateAttribute((object) false));
              num2 = 16;
              continue;
            case 20:
              attributes.Add(TypeOf<EnumMetadataTypeAttribute>.Raw.CreateAttribute((object) EnumGenerator.fl1RjWhwcai7HVJQPWHC((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            case 21:
              goto label_58;
            case 22:
              goto label_14;
            case 23:
              List<ISyntaxNode> syntaxNodeList2 = attributes;
              Type raw2 = TypeOf<UidAttribute>.Raw;
              object[] objArray2 = new object[1];
              guid = this.metadata.Uid;
              objArray2[0] = (object) guid.ToString();
              ISyntaxNode attribute2 = raw2.CreateAttribute(objArray2);
              syntaxNodeList2.Add(attribute2);
              num2 = 8;
              continue;
            case 24:
            case 37:
              if (EnumGenerator.HF5WmLh4ZOg5ZNJo8K1I((object) attributes) > 0)
                goto case 11;
              else
                goto label_65;
            case 25:
              goto label_17;
            case 26:
              if (!this.metadata.ShowInTypeTree)
              {
                num2 = 39;
                continue;
              }
              goto case 1;
            case 27:
              if (this.metadata.Type == EnumMetadataType.Enum)
              {
                num2 = 2;
                continue;
              }
              goto case 20;
            case 28:
              attributes.Add(TypeOf<MetadataTypeAttribute>.Raw.CreateAttribute((object) this.metadata.GetType()));
              num2 = 23;
              continue;
            case 30:
              enumGenerator = this;
              num2 = 25;
              continue;
            case 31:
              goto label_11;
            case 33:
              attributes.Add(TypeOf<NamespaceForDisplayAttribute>.Raw.CreateAttribute(EnumGenerator.wdPVkRh48xZB4NsIwglk((object) this.metadata)));
              num2 = 37;
              continue;
            case 34:
label_25:
              if (this.metadata.NamespaceForDisplay.IsNullOrWhiteSpace())
              {
                num2 = 24;
                continue;
              }
              goto case 33;
            case 36:
              try
              {
label_48:
                if (enumerator.MoveNext())
                  goto label_54;
                else
                  goto label_49;
label_44:
                MetadataImage current;
                List<object> objectList;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      objectList.Add((object) EnumGenerator.rGNOkEh4QxM4MWrVjtCb((object) current));
                      num4 = 9;
                      continue;
                    case 2:
                      objectList.Add(EnumGenerator.ixLfGDh4b8SVgA4M3PJI(EnumGenerator.u2iRMvhwUpeHfxy1qolW((object) this.metadata)));
                      num4 = 7;
                      continue;
                    case 3:
                    case 10:
                      attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute((object[]) EnumGenerator.gTc0Uoh4vp75NopPRTti((object) objectList)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 4 : 1;
                      continue;
                    case 4:
                      goto label_48;
                    case 5:
                      goto label_25;
                    case 6:
                      objectList.Add((object) true);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 10 : 9;
                      continue;
                    case 7:
                      objectList.Add(EnumGenerator.qdHcDNh4hRbv2QeSaF3C((object) current) == ImageFormatType.IconPack ? EnumGenerator.LTmdCbh4f6IusWYhsUAo(EnumGenerator.atNAOeh4GrdshVMyckWm(), EnumGenerator.OeBy38h4E3tT5XIgA37t((object) current)) : (object) this.GetImageResourceName(current));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
                      continue;
                    case 8:
                      if (!EnumGenerator.JxUvWZh4CuiDP54BmpLH((object) current))
                      {
                        num4 = 3;
                        continue;
                      }
                      goto case 6;
                    case 9:
                      objectList.Add((object) EnumGenerator.qdHcDNh4hRbv2QeSaF3C((object) current));
                      num4 = 8;
                      continue;
                    case 11:
                      goto label_54;
                    default:
                      objectList = new List<object>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 2 : 2;
                      continue;
                  }
                }
label_49:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 1;
                goto label_44;
label_54:
                current = enumerator.Current;
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                {
                  num4 = 0;
                  goto label_44;
                }
                else
                  goto label_44;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 38:
              attributes.Add(TypeOf<GroupIdAttribute>.Raw.CreateAttribute((object) this.metadata.GroupId));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 8 : 26;
              continue;
            case 39:
              attributes.Add(TypeOf<ShowInTypeTreeAttribute>.Raw.CreateAttribute((object) false));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
              continue;
            default:
              if (EnumGenerator.fl1RjWhwcai7HVJQPWHC((object) this.metadata) == EnumMetadataType.ExtendableEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 22 : 4;
                continue;
              }
              goto case 5;
          }
        }
label_11:
        num1 = 30;
        continue;
label_14:
        syntaxNode = (ISyntaxNode) EnumGenerator.Jrj6dQh4FOO9x0ghJhLE((object) EleWise.ELMA.SDK.TypeOf.EnumBaseConverter1.Raw.CreateTypeSyntax((ISyntaxNode) EnumGenerator.MnqvvIhwz128Fy6nZpHu((object) this.metadata.FullTypeName)));
        num1 = 6;
        continue;
label_17:
        EnumGenerator.doaNqBhwg9PdEXneqtf7((object) this.metadata, EnumGenerator.SRd4GEhwrMIEjlABnrYS(-1886646897 ^ -1886632783));
        num1 = 18;
        continue;
label_20:
        List<ISyntaxNode> syntaxNodeList3 = attributes;
        Type raw3 = TypeOf<BaseClassAttribute>.Raw;
        object[] objArray3 = new object[1];
        guid = EnumGenerator.jG7Zy3h4WVKcwwQUJqvx((object) this.metadata);
        objArray3[0] = (object) guid.ToString();
        ISyntaxNode attribute3 = raw3.CreateAttribute(objArray3);
        syntaxNodeList3.Add(attribute3);
        num1 = 3;
        continue;
label_29:
        num1 = 19;
        continue;
label_65:
        num1 = 17;
      }
label_62:
      return;
label_58:;
    }

    /// <summary>Записать значения перечисления</summary>
    protected virtual IEnumerable<ISyntaxNode> Values() => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CValues\u003Ed__9(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать конструктор</summary>
    protected virtual ISyntaxNode Ctor() => SyntaxGeneratorExtensions.ConstructorDeclaration(this.CtorParameters(), EnumGenerator.MJTQVUh4uXAKyHFhcPxN((object) this), baseConstructorArguments: this.BaseCtorArguments()).XmlComments(((string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(-1837662597 ^ -1837888105)).SummaryComment());

    /// <summary>Видимость конструктора</summary>
    protected virtual Accessibility CtorAccessibility()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EnumGenerator.fl1RjWhwcai7HVJQPWHC((object) this.metadata) != EnumMetadataType.EnumExtension)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return Accessibility.Public;
label_3:
      return Accessibility.Protected;
    }

    /// <summary>Записать параметры конструктора</summary>
    protected virtual IEnumerable<ISyntaxNode> CtorParameters() => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CCtorParameters\u003Ed__12(-2);

    /// <summary>Записать аргументы вызова базового конструктора</summary>
    protected virtual IEnumerable<ISyntaxNode> BaseCtorArguments() => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CBaseCtorArguments\u003Ed__13(-2);

    /// <summary>Записать конструктор для десериализации</summary>
    protected virtual ISyntaxNode DeserializationCtor()
    {
      int num = 1;
      ISyntaxNode[] parameters;
      ISyntaxNode[] baseConstructorArguments;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.metadata.Type == EnumMetadataType.ExtendableEnum)
            {
              parameters = new ISyntaxNode[2]
              {
                ((string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(-688192331 - 435440695 ^ -1123627720)).ParameterDeclaration<SerializationInfo>(),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77668377).ParameterDeclaration<StreamingContext>()
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            baseConstructorArguments = new ISyntaxNode[2]
            {
              (ISyntaxNode) EnumGenerator.jk2DEOh4I8NBP0m35cEU(EnumGenerator.SRd4GEhwrMIEjlABnrYS(2045296739 + 1688595713 ^ -561063902)),
              ((string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(~1767720452 ^ -1767703059)).IdentifierName()
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (ISyntaxNode) null;
label_4:
      return SyntaxGeneratorExtensions.ConstructorDeclaration((IEnumerable<ISyntaxNode>) parameters, Accessibility.Protected, baseConstructorArguments: (IEnumerable<ISyntaxNode>) baseConstructorArguments).XmlComments(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909344921).SummaryComment());
    }

    /// <summary>Записать значение перечисления</summary>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    protected virtual IEnumerable<ISyntaxNode> Value(EnumValueMetadata valueMetadata) => (IEnumerable<ISyntaxNode>) new EnumGenerator.\u003CValue\u003Ed__15(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__valueMetadata = valueMetadata
    };

    /// <summary>Записать комментарии к свойству</summary>
    /// <param name="field">Объявление значения перечисления</param>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    protected virtual void WriteValueComments(ISyntaxNode field, EnumValueMetadata valueMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.XmlComments(field, (NamedDocumentedMetadata) valueMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Записать атрибуты свойства</summary>
    /// <param name="field">Объявление значения перечисления</param>
    /// <param name="valueMetadata">Метаданные значения перечисления</param>
    protected virtual void WriteValueAttributes(ISyntaxNode field, EnumValueMetadata valueMetadata)
    {
      int num1 = 24;
      while (true)
      {
        int num2 = num1;
        StringBuilder stringBuilder1;
        int index;
        EnumMetadataAdditionalAttribute[] additionalAttributeArray;
        XmlWriter xmlWriter;
        List<MetadataImage>.Enumerator enumerator;
        EnumMetadataAdditionalAttribute additionalAttribute;
        List<ISyntaxNode> attributes;
        EnumValueMetadata valueMetadata1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EleWise.ELMA.SR.RunWithFutureTranslate((System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  int num4 = num3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        attributes.Add(TypeOf<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.Raw.CreateAttribute(EnumGenerator.\u003C\u003Ec__DisplayClass17_0.L5lfJsvnakulkWHE2mff((object) valueMetadata1.DisplayName)));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        attributes.Add(TypeOf<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.Raw.CreateAttribute(EnumGenerator.\u003C\u003Ec__DisplayClass17_0.L5lfJsvnakulkWHE2mff(EnumGenerator.\u003C\u003Ec__DisplayClass17_0.v8o2FjvnDaXK8v8NvPEx((object) valueMetadata1))));
                        num4 = 3;
                        continue;
                      case 3:
                        goto label_8;
                      case 4:
                        goto label_3;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!EnumGenerator.\u003C\u003Ec__DisplayClass17_0.UkOsGPvntK13xi2ydJy4(EnumGenerator.\u003C\u003Ec__DisplayClass17_0.v8o2FjvnDaXK8v8NvPEx((object) valueMetadata1)))
                          goto case 2;
                        else
                          goto label_7;
                    }
                  }
label_7:
                  num3 = 4;
                }
label_8:
                return;
label_3:;
              }), false);
              num2 = 5;
              continue;
            case 2:
label_4:
              if (valueMetadata1.AdditionalAttributes == null)
              {
                num2 = 14;
                continue;
              }
              goto case 6;
            case 3:
              attributes.Add(TypeOf<ViewAttribute>.Raw.CreateAttribute((object) EnumGenerator.w9op5sh4SJWyCxaZG6rm((object) valueMetadata1)));
              num2 = 21;
              continue;
            case 4:
              try
              {
label_42:
                if (enumerator.MoveNext())
                  goto label_34;
                else
                  goto label_43;
label_33:
                MetadataImage current;
                List<object> objectList;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      objectList.Add((object) true);
                      num5 = 9;
                      continue;
                    case 2:
                      goto label_4;
                    case 3:
                      objectList.Add((object) EnumGenerator.rGNOkEh4QxM4MWrVjtCb((object) current));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 8;
                      continue;
                    case 4:
                      goto label_42;
                    case 5:
                      goto label_34;
                    case 6:
                      objectList.Add(current.Format == ImageFormatType.IconPack ? EnumGenerator.LTmdCbh4f6IusWYhsUAo(EnumGenerator.atNAOeh4GrdshVMyckWm(), (object) current.Data) : (object) this.GetImageResourceName(current, valueMetadata1.Name));
                      num5 = 3;
                      continue;
                    case 7:
                      objectList = new List<object>();
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 10 : 1;
                      continue;
                    case 8:
                      objectList.Add((object) EnumGenerator.qdHcDNh4hRbv2QeSaF3C((object) current));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 11 : 7;
                      continue;
                    case 10:
                      objectList.Add(EnumGenerator.ixLfGDh4b8SVgA4M3PJI(EnumGenerator.u2iRMvhwUpeHfxy1qolW((object) this.metadata)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 1;
                      continue;
                    case 11:
                      if (!EnumGenerator.JxUvWZh4CuiDP54BmpLH((object) current))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    default:
                      attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute((object[]) EnumGenerator.gTc0Uoh4vp75NopPRTti((object) objectList)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 4;
                      continue;
                  }
                }
label_34:
                current = enumerator.Current;
                num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                {
                  num5 = 7;
                  goto label_33;
                }
                else
                  goto label_33;
label_43:
                num5 = 2;
                goto label_33;
              }
              finally
              {
                enumerator.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 5:
              if (valueMetadata1.Visibility != Visibility.Visible)
              {
                num2 = 3;
                continue;
              }
              goto case 21;
            case 6:
              stringBuilder1 = new StringBuilder();
              num2 = 12;
              continue;
            case 7:
              attributes.Add(TypeOf<UidAttribute>.Raw.CreateAttribute((object) EnumGenerator.vLRrXwh4VpsxDSyaRZnU((object) valueMetadata1).ToString()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            case 8:
              index = 0;
              num2 = 22;
              continue;
            case 9:
              attributes = new List<ISyntaxNode>();
              num2 = 7;
              continue;
            case 10:
            case 19:
              additionalAttribute = additionalAttributeArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 13 : 5;
              continue;
            case 11:
            case 22:
              if (index < additionalAttributeArray.Length)
              {
                num2 = 19;
                continue;
              }
              goto case 14;
            case 12:
              StringBuilder stringBuilder2 = stringBuilder1;
              XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
              EnumGenerator.JZGg4Lh4ipsbn6CZh1Eq((object) xmlWriterSettings, true);
              xmlWriterSettings.IndentChars = (string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(-1998538950 ^ -1998338636);
              EnumGenerator.ul9BZbh4qYImhIS8xsTh((object) xmlWriterSettings, EnumGenerator.AW8C0vh4RjHppeXMr9iZ());
              EnumGenerator.IY9tosh4KQMpW8g8mySa((object) xmlWriterSettings, true);
              xmlWriter = (XmlWriter) EnumGenerator.m36wOUh4XL3YA6Uqv0ss((object) stringBuilder2, (object) xmlWriterSettings);
              num2 = 17;
              continue;
            case 13:
              goto label_55;
            case 14:
            case 15:
              field.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 16 : 6;
              continue;
            case 16:
              goto label_54;
            case 17:
              try
              {
                EnumGenerator.zhNDdIh4ktKVXc2CPglS((object) new XmlSerializer(TypeOf<EnumMetadataAdditionalAttribute[]>.Raw), (object) xmlWriter, EnumGenerator.nZFbm9h4TtkT6VlBV2S9((object) valueMetadata1));
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    goto label_3;
                }
              }
              finally
              {
                int num8;
                if (xmlWriter == null)
                  num8 = 2;
                else
                  goto label_16;
label_15:
                switch (num8)
                {
                  case 1:
                    break;
                  default:
                }
label_16:
                EnumGenerator.xuoq6yh4n6vpdbVcxkhc((object) xmlWriter);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                {
                  num8 = 0;
                  goto label_15;
                }
                else
                  goto label_15;
              }
            case 18:
label_3:
              attributes.Add(TypeOf<EnumMetadataAdditionalAttributesAttribute>.Raw.CreateAttribute((object) stringBuilder1.ToString()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            case 20:
              ++index;
              num2 = 11;
              continue;
            case 21:
              if (valueMetadata1.Images != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 16 : 25;
                continue;
              }
              goto case 2;
            case 23:
              valueMetadata1 = valueMetadata;
              num2 = 9;
              continue;
            case 24:
              num2 = 23;
              continue;
            case 25:
              enumerator = valueMetadata1.Images.GetEnumerator();
              num2 = 4;
              continue;
            default:
              additionalAttributeArray = (EnumMetadataAdditionalAttribute[]) EnumGenerator.nZFbm9h4TtkT6VlBV2S9((object) valueMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 8 : 7;
              continue;
          }
        }
label_55:
        attributes.Add(((string) EnumGenerator.xLA0jXh4O8tqkSpdD2K8((object) additionalAttribute)).CreateAttribute(((IEnumerable<EnumParameter>) EnumGenerator.sIChcsh42TENHjcqBEUq((object) additionalAttribute)).EmptyIfNull<EnumParameter>().Select<EnumParameter, object>((Func<EnumParameter, object>) (p =>
        {
          int num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (EnumGenerator.\u003C\u003Ec.DeAVYMvn7dMnjfKagXKB(EnumGenerator.\u003C\u003Ec.J13I64vnABGBYwEYEp43((object) p)))
                {
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_2;
              default:
                goto label_3;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return (object) ((ISyntaxNode) EnumGenerator.\u003C\u003Ec.AnHK9dvn028s3epcWfHR(EnumGenerator.\u003C\u003Ec.B8HIPuvnxNVtMcnHaKqJ((object) p))).AttributeArgument((string) EnumGenerator.\u003C\u003Ec.J13I64vnABGBYwEYEp43((object) p));
label_3:
          return p.Value;
        })).ToArray<object>()));
        num1 = 20;
      }
label_54:;
    }

    /// <summary>
    /// Получить ссылку на базовый класс расширяемого перечисления
    /// </summary>
    /// <returns>Ссылка на базовый класс расширяемого перечисления</returns>
    protected virtual ISyntaxNode GetBaseClass()
    {
      int num1 = 1;
      EnumMetadata enumMetadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EnumMetadata enumMetadata2;
          switch (num2)
          {
            case 1:
              Contract.NotNull((object) this.metadata, (string) EnumGenerator.SRd4GEhwrMIEjlABnrYS(-35995181 ^ -36009747));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            case 2:
              enumMetadata2 = (EnumMetadata) null;
              break;
            case 3:
              goto label_4;
            case 4:
              goto label_7;
            default:
              if (!EnumGenerator.ERLDmvh4BkdT4hNoCA47(EnumGenerator.jG7Zy3h4WVKcwwQUJqvx((object) this.metadata), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 1;
                continue;
              }
              enumMetadata2 = (EnumMetadata) this.GetMetadata(EnumGenerator.jG7Zy3h4WVKcwwQUJqvx((object) this.metadata));
              break;
          }
          enumMetadata1 = enumMetadata2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 3;
        }
label_4:
        if (enumMetadata1 == null)
          num1 = 4;
        else
          goto label_8;
      }
label_7:
      return (ISyntaxNode) EnumGenerator.U0NnLoh4eZJRBUTXRdSG(TypeOf<EnumBase>.Raw);
label_8:
      return enumMetadata1.FullTypeName.CreateTypeSyntax();
    }

    /// <summary>Является ли перечисление расширяемым</summary>
    protected virtual bool IsExtendable
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.metadata.Type != EnumMetadataType.EnumExtension)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return EnumGenerator.fl1RjWhwcai7HVJQPWHC((object) this.metadata) == EnumMetadataType.ExtendableEnum;
label_3:
        return true;
      }
    }

    /// <summary>Сгенерировать дополнительные файлы с ресурсами иконок</summary>
    protected virtual IEnumerable<GeneratedFileInfo> GenerateImageResources() => (IEnumerable<GeneratedFileInfo>) new EnumGenerator.\u003CGenerateImageResources\u003Ed__21(-2)
    {
      \u003C\u003E4__this = this
    };

    public EnumGenerator()
    {
      EnumGenerator.Gmtgefh4PClpSawQuq7V();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object SRd4GEhwrMIEjlABnrYS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool VqqAhKhwd6d9CxVLL1mv() => EnumGenerator.F4uuJchw9d55mZrUtmTW == null;

    internal static EnumGenerator pFkHB5hwle9rABbUAcxV() => EnumGenerator.F4uuJchw9d55mZrUtmTW;

    internal static void doaNqBhwg9PdEXneqtf7([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static bool D0xPYHhw5mFoAsA7TrlC([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object WWSDQ5hwjK0K0tYdoptP([In] object obj0) => (object) ((GenerationParams) obj0).Prefix;

    internal static object nAaGjHhwYA3kEUnTCqBF([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool nN7QgDhwLj0lHDmHl3s4([In] object obj0) => ((EnumGenerator) obj0).IsExtendable;

    internal static object u2iRMvhwUpeHfxy1qolW([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object xeTkGxhwsPh1Kuspx0Nb([In] object obj0) => (object) ((EnumGenerator) obj0).GetBaseClass();

    internal static EnumMetadataType fl1RjWhwcai7HVJQPWHC([In] object obj0) => ((EnumMetadata) obj0).Type;

    internal static object MnqvvIhwz128Fy6nZpHu([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object Jrj6dQh4FOO9x0ghJhLE([In] object obj0) => (object) ((ISyntaxNode) obj0).TypeOfExpression();

    internal static bool ERLDmvh4BkdT4hNoCA47([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid jG7Zy3h4WVKcwwQUJqvx([In] object obj0) => ((EnumMetadata) obj0).BaseTypeUid;

    internal static bool D53H9dh4oMUqwD1JmOYp([In] object obj0) => ((EnumMetadata) obj0).ShowInDesigner;

    internal static object ixLfGDh4b8SVgA4M3PJI([In] object obj0) => (object) ((string) obj0).TypeOfExpression();

    internal static ImageFormatType qdHcDNh4hRbv2QeSaF3C([In] object obj0) => ((MetadataImage) obj0).Format;

    internal static object atNAOeh4GrdshVMyckWm() => (object) Encoding.UTF8;

    internal static object OeBy38h4E3tT5XIgA37t([In] object obj0) => (object) ((MetadataImage) obj0).Data;

    internal static object LTmdCbh4f6IusWYhsUAo([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static int rGNOkEh4QxM4MWrVjtCb([In] object obj0) => ((MetadataImage) obj0).Size;

    internal static bool JxUvWZh4CuiDP54BmpLH([In] object obj0) => ((MetadataImage) obj0).IsDefault;

    internal static object gTc0Uoh4vp75NopPRTti([In] object obj0) => (object) ((List<object>) obj0).ToArray();

    internal static object wdPVkRh48xZB4NsIwglk([In] object obj0) => (object) ((EnumMetadata) obj0).NamespaceForDisplay;

    internal static int HF5WmLh4ZOg5ZNJo8K1I([In] object obj0) => ((List<ISyntaxNode>) obj0).Count;

    internal static Accessibility MJTQVUh4uXAKyHFhcPxN([In] object obj0) => ((EnumGenerator) obj0).CtorAccessibility();

    internal static object jk2DEOh4I8NBP0m35cEU([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static Guid vLRrXwh4VpsxDSyaRZnU([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Visibility w9op5sh4SJWyCxaZG6rm([In] object obj0) => ((EnumValueMetadata) obj0).Visibility;

    internal static void JZGg4Lh4ipsbn6CZh1Eq([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).Indent = obj1;

    internal static object AW8C0vh4RjHppeXMr9iZ() => (object) Environment.NewLine;

    internal static void ul9BZbh4qYImhIS8xsTh([In] object obj0, [In] object obj1) => ((XmlWriterSettings) obj0).NewLineChars = (string) obj1;

    internal static void IY9tosh4KQMpW8g8mySa([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).OmitXmlDeclaration = obj1;

    internal static object m36wOUh4XL3YA6Uqv0ss([In] object obj0, [In] object obj1) => (object) XmlWriter.Create((StringBuilder) obj0, (XmlWriterSettings) obj1);

    internal static object nZFbm9h4TtkT6VlBV2S9([In] object obj0) => (object) ((EnumValueMetadata) obj0).AdditionalAttributes;

    internal static void zhNDdIh4ktKVXc2CPglS([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlSerializer) obj0).Serialize((XmlWriter) obj1, obj2);

    internal static void xuoq6yh4n6vpdbVcxkhc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object xLA0jXh4O8tqkSpdD2K8([In] object obj0) => (object) ((EnumMetadataAdditionalAttribute) obj0).AddtibuteName;

    internal static object sIChcsh42TENHjcqBEUq([In] object obj0) => (object) ((EnumMetadataAdditionalAttribute) obj0).Parameters;

    internal static object U0NnLoh4eZJRBUTXRdSG(Type type) => (object) type.CreateTypeSyntax();

    internal static void Gmtgefh4PClpSawQuq7V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
