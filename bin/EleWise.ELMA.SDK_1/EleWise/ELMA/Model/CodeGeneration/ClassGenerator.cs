// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ClassGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Генератор кода класса на основе метаданных</summary>
  public class ClassGenerator : CodeGenerator
  {
    protected ClassMetadata metadata;
    private Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>> formsByUniqueName;
    private static ClassGenerator sg6Oj4htn5SWvaiyPVCq;

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
            ClassGenerator.eAlyp5ht1g7TvtQKEQef(metadata is ClassMetadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(1917256330 ^ 1917088568));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 2:
            ClassGenerator.tq2tKWhtPEt6RG6iKHvJ((object) metadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(95909607 + 343705423 ^ 439596808));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            this.metadata = (ClassMetadata) metadata;
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сгенерировать основной файл</summary>
    /// <returns>Информация о сгенерированном файле</returns>
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
            ClassGenerator.pNMkSmhtNeKYL7DK2m1V((object) this.metadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(44884861 ^ 44870211));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      GeneratedFileInfo mainFileHelper;
      return mainFileHelper;
label_3:
      try
      {
        ISyntaxNode[] syntaxNodeArray = this.GetNamespaces().Concat<ISyntaxNode>(this.GenerateMainFile()).ToArray<ISyntaxNode>();
        int num2 = 5;
        string name;
        IEnumerable<ISyntaxTrivia> syntaxTrivias;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ClassGenerator.J1CTcvhtpYGPrvUtpJrr((object) name))
              {
                num2 = 8;
                continue;
              }
              goto case 4;
            case 2:
              goto label_2;
            case 3:
              if (syntaxTrivias.Any<ISyntaxTrivia>())
              {
                num2 = 9;
                continue;
              }
              goto case 6;
            case 4:
              syntaxNodeArray = new ISyntaxNode[1]
              {
                name.NamespaceDeclaration(syntaxNodeArray)
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 5:
              name = (string) ClassGenerator.FxRu3lht3umYonoYh6Ru((object) this);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
              continue;
            case 6:
            case 7:
            case 8:
              mainFileHelper = this.GenerateMainFileHelper((IEnumerable<ISyntaxNode>) syntaxNodeArray, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            case 9:
              ((IEnumerable<ISyntaxNode>) syntaxNodeArray).Last<ISyntaxNode>().TextCommentsTrailing(syntaxTrivias);
              num2 = 6;
              continue;
            case 10:
              syntaxTrivias = this.WriteLocalizationResources();
              num2 = 3;
              continue;
            default:
              if (!((IEnumerable<ISyntaxNode>) syntaxNodeArray).Any<ISyntaxNode>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 7;
                continue;
              }
              goto case 10;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new CodeGenerationException(EleWise.ELMA.SR.T((string) ClassGenerator.VdcgsShteZAQpyeZuYHT(647913418 ^ 647836852), (object) this.metadata.TypeName), ex);
        }
      }
    }

    /// <summary>Сгенерировать дополнительные файлы</summary>
    protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal() => this.GenerateImageResources().Concat<GeneratedFileInfo>(this.GenerateCustomCodeResources()).Concat<GeneratedFileInfo>(this.GenerateFormsResources());

    /// <summary>Получить пространство имён</summary>
    /// <returns>Пространство имён</returns>
    protected virtual string GetNamespace() => (string) ClassGenerator.Sjk3yShtav14CZmnwK6I((object) this.metadata);

    /// <summary>Получить описатель типа данных</summary>
    /// <param name="typeUid">Уникальный идентификатор типа</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описатель типа данных</returns>
    protected virtual ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid) => ((IMetadataService) ClassGenerator.mZMePEhtDXl5jLTpGd7k()).GetTypeDescriptor(typeUid, subTypeUid);

    /// <summary>Сгенерировать основной файл</summary>
    protected virtual IEnumerable<ISyntaxNode> GenerateMainFile() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CGenerateMainFile\u003Ed__6(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить модификатор доступа основного класса</summary>
    /// <returns>Модификатор доступа</returns>
    protected virtual Accessibility GetMainClassAccessibility() => Accessibility.Public;

    /// <summary>Записать используемые пространства имен</summary>
    /// <example>yield return "System".NamespaceImportDeclaration();</example>
    protected virtual IEnumerable<ISyntaxNode> GetNamespaces() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CGetNamespaces\u003Ed__8(-2);

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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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
    /// <param name="type">Объявление класса</param>
    protected virtual void WriteTypeAttributes(ISyntaxNode type)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        List<string>.Enumerator enumerator1;
        List<FormViewItem>.Enumerator enumerator2;
        Func<string, string> func;
        List<MetadataImage>.Enumerator enumerator3;
        List<FormViewItemTransformation>.Enumerator enumerator4;
        List<Tuple<ViewType, Guid, Guid, Guid, Guid, bool>>.Enumerator enumerator5;
        List<FormView>.Enumerator enumerator6;
        Guid guid;
        List<TableView>.Enumerator enumerator7;
        Dictionary<Guid, string>.Enumerator enumerator8;
        List<ISyntaxNode> attributes;
        ClassGenerator classGenerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              classGenerator = this;
              num2 = 39;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
            case 3:
              if (this.metadata.Forms == null)
              {
                num2 = 10;
                continue;
              }
              goto case 11;
            case 4:
              attributes.Add(TypeOf<AllowCreateHeirsAttribute>.Raw.CreateAttribute((object) this.metadata.AllowCreateHeirs));
              num2 = 13;
              continue;
            case 5:
              if (ClassGenerator.tlvw5shtwyjc7tM1mXxF(this.metadata.BaseClassUid, Guid.Empty))
              {
                num2 = 37;
                continue;
              }
              goto case 22;
            case 6:
              enumerator5 = ((ClassDefaultForms) ClassGenerator.VRhT9whtLUd14lhllOpt((object) this.metadata)).ToDictionary().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 7:
              attributes.Add(TypeOf<ShowInTypeTreeAttribute>.Raw.CreateAttribute((object) false));
              num2 = 58;
              continue;
            case 8:
              if (this.metadata.ImplementedInterfaces != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 56 : 21;
                continue;
              }
              goto case 30;
            case 9:
            case 13:
              attributes.Add(TypeOf<DisplayFormatAttribute>.Raw.CreateAttribute(ClassGenerator.frOtbWhtHdTOBfOBMcZG((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 21 : 14;
              continue;
            case 10:
            case 44:
label_43:
              if (this.metadata.FormTransformations != null)
              {
                num2 = 51;
                continue;
              }
              goto case 47;
            case 11:
              enumerator2 = this.metadata.Forms.GetEnumerator();
              num2 = 35;
              continue;
            case 12:
              attributes.Add(TypeOf<CustomCodeAttribute>.Raw.CreateAttribute(ClassGenerator.Q0wLochtJoSj9VPdneTQ(ClassGenerator.N8Q14chtM7HmW6L9Xnnw((object) this.metadata)), (object) this.GetCustomCodeResourceName()));
              num2 = 23;
              continue;
            case 14:
              if (ClassGenerator.IYtegGhtmC4eb2Q0IsrY((object) this.metadata.OnViewLoadScriptName))
              {
                num2 = 19;
                continue;
              }
              goto case 48;
            case 15:
              try
              {
label_105:
                if (enumerator4.MoveNext())
                  goto label_108;
                else
                  goto label_106;
label_102:
                FormViewItemTransformation current;
                string str;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      attributes.Add(TypeOf<FormTransformationAttribute>.Raw.CreateAttribute((object) ((string) ClassGenerator.N8Q14chtM7HmW6L9Xnnw((object) this.metadata)).TypeOfExpression(), (object) this.GetFormResourceName(str)));
                      num3 = 5;
                      continue;
                    case 2:
                      this.formsByUniqueName[str] = new Tuple<FormViewItem, FormViewItemTransformation>((FormViewItem) null, current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
                      continue;
                    case 3:
                      str = func(current.FormName);
                      num3 = 2;
                      continue;
                    case 4:
                      goto label_72;
                    case 5:
                      goto label_105;
                    default:
                      goto label_108;
                  }
                }
label_106:
                num3 = 4;
                goto label_102;
label_108:
                current = enumerator4.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                {
                  num3 = 3;
                  goto label_102;
                }
                else
                  goto label_102;
              }
              finally
              {
                enumerator4.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 16:
              enumerator6 = this.metadata.FormViews.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 15 : 18;
              continue;
            case 17:
            case 19:
              if (this.metadata.Images != null)
              {
                num2 = 40;
                continue;
              }
              goto case 49;
            case 18:
              try
              {
label_157:
                if (enumerator6.MoveNext())
                  goto label_156;
                else
                  goto label_158;
label_154:
                string str;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_157;
                    case 2:
                      goto label_156;
                    case 3:
                      attributes.Add(TypeOf<FormViewAttribute>.Raw.CreateAttribute((object) str));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
                      continue;
                    default:
                      goto label_22;
                  }
                }
label_156:
                str = ClassSerializationHelper.SerializeObjectByXml((object) enumerator6.Current);
                num5 = 3;
                goto label_154;
label_158:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                goto label_154;
              }
              finally
              {
                enumerator6.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 20:
            case 45:
label_45:
              if (ClassGenerator.J1CTcvhtpYGPrvUtpJrr(ClassGenerator.tPnASehtcHiPEhZNvI3d((object) this.metadata)))
              {
                num2 = 38;
                continue;
              }
              goto case 60;
            case 21:
              if (ClassGenerator.tlvw5shtwyjc7tM1mXxF(ClassGenerator.TeJXtIhtAfdprL7QyyTD((object) this.metadata), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 36 : 5;
                continue;
              }
              goto case 54;
            case 22:
              if (!ClassGenerator.mRJjjGht6iYw3qBUFomI((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 9 : 5;
                continue;
              }
              goto case 4;
            case 23:
              if (ClassGenerator.aPJh7uhtYeGwoEUVnC5c((object) this.metadata) != ClassFormsScheme.Simple)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 4 : 24;
                continue;
              }
              goto case 6;
            case 24:
              attributes.Add(TypeOf<ClassFormsSchemeAttribute>.Raw.CreateAttribute((object) ClassGenerator.aPJh7uhtYeGwoEUVnC5c((object) this.metadata)));
              num2 = 6;
              continue;
            case 25:
              if (ClassGenerator.M1jMvEhtteFad8CuYl9r((object) this.metadata) <= 0L)
                goto case 5;
              else
                goto label_67;
            case 26:
              attributes.Add(TypeOf<ScriptModuleAttribute>.Raw.CreateAttribute(ClassGenerator.tvfCSYht0wKLa85Mnr1m((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 14 : 0;
              continue;
            case 27:
              func = (Func<string, string>) (formName =>
              {
                int num7 = 5;
                string name;
                while (true)
                {
                  int num8 = num7;
                  string source;
                  char ch;
                  int num9;
                  int index;
                  char[] chArray;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        ClassGenerator.\u003C\u003Ec__DisplayClass10_0.sLrJFpvXqPo6RdVMyCKV((object) source, (object) ch.ToString(), (object) string.Empty);
                        num8 = 14;
                        continue;
                      case 2:
                        if (!source.Contains<char>(ch))
                        {
                          num8 = 17;
                          continue;
                        }
                        goto case 1;
                      case 3:
                      case 13:
                        goto label_26;
                      case 4:
                        source = formName;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 11;
                        continue;
                      case 5:
                        num8 = 4;
                        continue;
                      case 6:
                      case 8:
                        if (index >= chArray.Length)
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 7 : 1;
                          continue;
                        }
                        goto case 18;
                      case 7:
                        if (string.IsNullOrWhiteSpace(source))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 8 : 16;
                          continue;
                        }
                        goto case 19;
                      case 9:
                        source = string.Empty;
                        num8 = 12;
                        continue;
                      case 10:
                        num9 = 0;
                        num8 = 15;
                        continue;
                      case 11:
                        if (source == null)
                        {
                          num8 = 9;
                          continue;
                        }
                        goto case 12;
                      case 12:
                        // ISSUE: reference to a compiler-generated method
                        chArray = (char[]) ClassGenerator.\u003C\u003Ec__DisplayClass10_0.gJfewLvXRZtEDk53CfTp();
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                        continue;
                      case 14:
                      case 17:
                        ++index;
                        num8 = 8;
                        continue;
                      case 15:
                      case 20:
                        if (classGenerator.formsByUniqueName.Keys.Any<string>((Func<string, bool>) (k => k.Equals(name, StringComparison.CurrentCultureIgnoreCase))))
                        {
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 2;
                          continue;
                        }
                        goto label_11;
                      case 16:
                        // ISSUE: reference to a compiler-generated method
                        source = (string) ClassGenerator.\u003C\u003Ec__DisplayClass10_0.eYI54ovXK7qfUZhPfnZd(-710283084 ^ -537863435 ^ 173643173);
                        num8 = 19;
                        continue;
                      case 18:
                        ch = chArray[index];
                        num8 = 2;
                        continue;
                      case 19:
                        name = source;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 10 : 10;
                        continue;
                      case 21:
                        // ISSUE: reference to a compiler-generated method
                        name = (string) ClassGenerator.\u003C\u003Ec__DisplayClass10_0.hIVh67vXXiwvcv5uTiIv((object) source, (object) num9);
                        num8 = 20;
                        continue;
                      case 22:
                        goto label_11;
                      default:
                        index = 0;
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 3 : 6;
                        continue;
                    }
                  }
label_26:
                  ++num9;
                  num7 = 21;
                }
label_11:
                return name;
              });
              num2 = 3;
              continue;
            case 28:
              attributes.Add(TypeOf<GroupIdAttribute>.Raw.CreateAttribute((object) ClassGenerator.M1jMvEhtteFad8CuYl9r((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 5;
              continue;
            case 29:
            case 58:
              if (!ClassGenerator.ncraIuhtxJpPAokamIF6((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 42 : 0;
                continue;
              }
              goto case 8;
            case 30:
label_50:
              if (!string.IsNullOrEmpty((string) ClassGenerator.tvfCSYht0wKLa85Mnr1m((object) this.metadata)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 26 : 17;
                continue;
              }
              goto case 14;
            case 31:
            case 38:
              goto label_114;
            case 32:
              goto label_162;
            case 33:
              goto label_41;
            case 34:
              try
              {
label_125:
                if (enumerator3.MoveNext())
                  goto label_127;
                else
                  goto label_126;
label_121:
                List<object> objectList;
                MetadataImage current;
                int num10;
                while (true)
                {
                  switch (num10)
                  {
                    case 1:
                      goto label_20;
                    case 2:
                      goto label_127;
                    case 3:
                      objectList = new List<object>();
                      num10 = 8;
                      continue;
                    case 4:
                      objectList.Add((object) true);
                      num10 = 10;
                      continue;
                    case 5:
                      objectList.Add((object) ClassGenerator.MHK43Nht9m4W4g9dfKFX((object) current));
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 6 : 9;
                      continue;
                    case 6:
                      goto label_125;
                    case 7:
                      objectList.Add(ClassGenerator.MHK43Nht9m4W4g9dfKFX((object) current) == ImageFormatType.IconPack ? ClassGenerator.fFxHQahtraSc8p9xawBK(ClassGenerator.PsGVRMhtdZpcXttVAixR(), ClassGenerator.k5AGvphtlUb8HHDOwdXv((object) current)) : (object) this.GetImageResourceName(current));
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                      continue;
                    case 8:
                      objectList.Add(ClassGenerator.Q0wLochtJoSj9VPdneTQ(ClassGenerator.N8Q14chtM7HmW6L9Xnnw((object) this.metadata)));
                      num10 = 7;
                      continue;
                    case 9:
                      if (ClassGenerator.dKTU9Oht5IlT3DnXO81i((object) current))
                      {
                        num10 = 4;
                        continue;
                      }
                      goto case 10;
                    case 10:
                      attributes.Add(TypeOf<ImageAttribute>.Raw.CreateAttribute(objectList.ToArray()));
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 6 : 6;
                      continue;
                    default:
                      objectList.Add((object) ClassGenerator.KbgUrdhtg5VDBlZeQ3cB((object) current));
                      num10 = 5;
                      continue;
                  }
                }
label_126:
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
                goto label_121;
label_127:
                current = enumerator3.Current;
                num10 = 3;
                goto label_121;
              }
              finally
              {
                enumerator3.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 35:
              try
              {
label_30:
                if (enumerator2.MoveNext())
                  goto label_26;
                else
                  goto label_31;
label_25:
                FormViewItem current;
                string str;
                int num12;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      this.formsByUniqueName[str] = new Tuple<FormViewItem, FormViewItemTransformation>(current, (FormViewItemTransformation) null);
                      num12 = 4;
                      continue;
                    case 2:
                      goto label_43;
                    case 3:
                      goto label_30;
                    case 4:
                      attributes.Add(TypeOf<FormAttribute>.Raw.CreateAttribute(ClassGenerator.Q0wLochtJoSj9VPdneTQ(ClassGenerator.N8Q14chtM7HmW6L9Xnnw((object) this.metadata)), (object) this.GetFormResourceName(str)));
                      num12 = 3;
                      continue;
                    case 5:
                      goto label_26;
                    default:
                      str = func((string) ClassGenerator.lXrOdIhtsGddsTHs67yF((object) current));
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
                      continue;
                  }
                }
label_26:
                current = enumerator2.Current;
                num12 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                {
                  num12 = 0;
                  goto label_25;
                }
                else
                  goto label_25;
label_31:
                num12 = 2;
                goto label_25;
              }
              finally
              {
                enumerator2.Dispose();
                int num13 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
                  num13 = 0;
                switch (num13)
                {
                  default:
                }
              }
            case 36:
              List<ISyntaxNode> syntaxNodeList1 = attributes;
              Type raw1 = TypeOf<TitlePropertyAttribute>.Raw;
              object[] objArray1 = new object[1];
              guid = ClassGenerator.TeJXtIhtAfdprL7QyyTD((object) this.metadata);
              objArray1[0] = (object) guid.ToString();
              ISyntaxNode attribute1 = raw1.CreateAttribute(objArray1);
              syntaxNodeList1.Add(attribute1);
              num2 = 54;
              continue;
            case 37:
              List<ISyntaxNode> syntaxNodeList2 = attributes;
              Type raw2 = TypeOf<BaseClassAttribute>.Raw;
              object[] objArray2 = new object[1];
              guid = ClassGenerator.SD0aOEht40ZjKfIhihlC((object) this.metadata);
              objArray2[0] = (object) guid.ToString();
              ISyntaxNode attribute2 = raw2.CreateAttribute(objArray2);
              syntaxNodeList2.Add(attribute2);
              num2 = 22;
              continue;
            case 39:
              Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978337739));
              num2 = 43;
              continue;
            case 40:
              enumerator3 = this.metadata.Images.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 34 : 24;
              continue;
            case 41:
              try
              {
label_80:
                if (enumerator7.MoveNext())
                  goto label_78;
                else
                  goto label_81;
label_76:
                string str;
                int num14;
                while (true)
                {
                  switch (num14)
                  {
                    case 1:
                      goto label_80;
                    case 2:
                      goto label_78;
                    case 3:
                      goto label_45;
                    default:
                      attributes.Add(TypeOf<TableViewAttribute>.Raw.CreateAttribute((object) str));
                      num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_78:
                str = ClassSerializationHelper.SerializeObjectByXml((object) enumerator7.Current);
                num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                {
                  num14 = 0;
                  goto label_76;
                }
                else
                  goto label_76;
label_81:
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 1;
                goto label_76;
              }
              finally
              {
                enumerator7.Dispose();
                int num15 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                  num15 = 0;
                switch (num15)
                {
                  default:
                }
              }
            case 42:
              goto label_42;
            case 43:
              goto label_119;
            case 46:
              enumerator7 = this.metadata.TableViews.GetEnumerator();
              num2 = 41;
              continue;
            case 47:
label_72:
              if (this.metadata.FormViews != null)
              {
                num2 = 16;
                continue;
              }
              goto case 52;
            case 48:
              attributes.Add(TypeOf<OnViewLoadScriptNameAttribute>.Raw.CreateAttribute(ClassGenerator.sR47Zfhtyh6lG13xQwsK((object) this.metadata)));
              num2 = 17;
              continue;
            case 49:
label_20:
              if (ClassGenerator.TCwS2Nhtj4wZDrW5IG7J((object) this))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 12 : 12;
                continue;
              }
              goto case 23;
            case 50:
              try
              {
label_5:
                if (enumerator1.MoveNext())
                  goto label_7;
                else
                  goto label_6;
label_4:
                string current;
                int num16;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                      attributes.Add(TypeOf<InterfaceImplementationAttribute>.Raw.CreateAttribute((object) current));
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
                      continue;
                    case 2:
                      goto label_5;
                    case 3:
                      goto label_7;
                    default:
                      goto label_50;
                  }
                }
label_6:
                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
                goto label_4;
label_7:
                current = enumerator1.Current;
                num16 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                {
                  num16 = 1;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              finally
              {
                enumerator1.Dispose();
                int num17 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                  num17 = 0;
                switch (num17)
                {
                  default:
                }
              }
            case 51:
              enumerator4 = this.metadata.FormTransformations.GetEnumerator();
              num2 = 15;
              continue;
            case 52:
label_22:
              if (this.metadata.TableViews == null)
              {
                num2 = 45;
                continue;
              }
              goto case 46;
            case 53:
label_57:
              ClassGenerator.J9DywShtUTMb2UbvKW2T((object) this.formsByUniqueName);
              num2 = 27;
              continue;
            case 54:
              if (ClassGenerator.yWaSNNht7BH3CPvFPSQG((object) this.metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 14 : 29;
                continue;
              }
              goto case 7;
            case 55:
              try
              {
label_142:
                if (enumerator8.MoveNext())
                  goto label_144;
                else
                  goto label_143;
label_141:
                KeyValuePair<Guid, string> current;
                int num18;
                while (true)
                {
                  switch (num18)
                  {
                    case 1:
                      goto label_57;
                    case 2:
                      List<ISyntaxNode> syntaxNodeList3 = attributes;
                      Type raw3 = TypeOf<DefaultFormSettingAttribute>.Raw;
                      object[] objArray3 = new object[2];
                      guid = current.Key;
                      objArray3[0] = (object) guid.ToString();
                      objArray3[1] = (object) current.Value;
                      ISyntaxNode attribute3 = raw3.CreateAttribute(objArray3);
                      syntaxNodeList3.Add(attribute3);
                      num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_144;
                    default:
                      goto label_142;
                  }
                }
label_143:
                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                goto label_141;
label_144:
                current = enumerator8.Current;
                num18 = 2;
                goto label_141;
              }
              finally
              {
                enumerator8.Dispose();
                int num19 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                  num19 = 0;
                switch (num19)
                {
                  default:
                }
              }
            case 56:
              enumerator1 = this.metadata.ImplementedInterfaces.GetEnumerator();
              num2 = 50;
              continue;
            case 57:
label_139:
              enumerator8 = this.metadata.DefaultForms.FormSettingsToDictionary().GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 55 : 9;
              continue;
            case 59:
              EleWise.ELMA.SR.RunWithFutureTranslate((System.Action) (() =>
              {
                int num20 = 3;
                while (true)
                {
                  switch (num20)
                  {
                    case 0:
                      goto label_7;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      attributes.Add(TypeOf<DescriptionAttribute>.Raw.CreateAttribute(ClassGenerator.\u003C\u003Ec__DisplayClass10_0.vky9lGvXib1T3hRBsf3S(ClassGenerator.\u003C\u003Ec__DisplayClass10_0.QN99KevXVJWihihBwEFQ((object) classGenerator.metadata))));
                      num20 = 4;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (ClassGenerator.\u003C\u003Ec__DisplayClass10_0.gbrTeEvXS1ClnXiJsJlp(ClassGenerator.\u003C\u003Ec__DisplayClass10_0.QN99KevXVJWihihBwEFQ((object) classGenerator.metadata)))
                      {
                        num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      attributes.Add(TypeOf<DisplayNameAttribute>.Raw.CreateAttribute((object) EleWise.ELMA.SR.T((string) ClassGenerator.\u003C\u003Ec__DisplayClass10_0.OoEe9WvXIP1aeksBHxsu((object) classGenerator.metadata))));
                      num20 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 2;
                      continue;
                    case 4:
                      goto label_2;
                    default:
                      goto label_8;
                  }
                }
label_7:
                return;
label_2:
                return;
label_8:;
              }), false);
              num2 = 25;
              continue;
            case 60:
              attributes.Add(TypeOf<NamespaceForDisplayAttribute>.Raw.CreateAttribute(ClassGenerator.tPnASehtcHiPEhZNvI3d((object) this.metadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 31 : 3;
              continue;
            default:
              try
              {
label_92:
                if (enumerator5.MoveNext())
                  goto label_90;
                else
                  goto label_93;
label_89:
                Tuple<ViewType, Guid, Guid, Guid, Guid, bool> current;
                int num21;
                while (true)
                {
                  switch (num21)
                  {
                    case 1:
                      goto label_139;
                    case 2:
                      goto label_92;
                    case 3:
                      List<ISyntaxNode> syntaxNodeList4 = attributes;
                      Type raw4 = TypeOf<DefaultFormAttribute>.Raw;
                      object[] objArray4 = new object[6];
                      objArray4[0] = (object) current.Item1;
                      guid = current.Item2;
                      objArray4[1] = (object) guid.ToString();
                      guid = current.Item3;
                      objArray4[2] = (object) guid.ToString();
                      guid = current.Item4;
                      objArray4[3] = (object) guid.ToString();
                      guid = current.Item5;
                      objArray4[4] = (object) guid.ToString();
                      objArray4[5] = (object) current.Item6;
                      ISyntaxNode attribute4 = raw4.CreateAttribute(objArray4);
                      syntaxNodeList4.Add(attribute4);
                      num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 2;
                      continue;
                    default:
                      goto label_90;
                  }
                }
label_90:
                current = enumerator5.Current;
                num21 = 3;
                goto label_89;
label_93:
                num21 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                goto label_89;
              }
              finally
              {
                enumerator5.Dispose();
                int num22 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                  num22 = 0;
                switch (num22)
                {
                  default:
                }
              }
          }
        }
label_41:
        attributes = new List<ISyntaxNode>();
        num1 = 59;
        continue;
label_42:
        attributes.Add(TypeOf<ShowInDesignerAttribute>.Raw.CreateAttribute((object) false));
        num1 = 8;
        continue;
label_67:
        num1 = 28;
        continue;
label_114:
        type.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
        num1 = 32;
        continue;
label_119:
        this.WriteBasicAttributes(type);
        num1 = 33;
      }
label_162:;
    }

    /// <summary>Получить ссылку на базовый класс</summary>
    /// <returns>Объявление класса</returns>
    protected virtual ISyntaxNode GetBaseClass()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ClassGenerator.ePRdAxhtzt8JSDGHcZqU(ClassGenerator.SD0aOEht40ZjKfIhihlC((object) this.metadata), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            ClassGenerator.pNMkSmhtNeKYL7DK2m1V((object) this.metadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(572119659 - -337058038 ^ 909163103));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return (ISyntaxNode) null;
label_6:
      return ClassGenerator.mYwTsvhwFAn1MgQn0jye((object) this, ClassGenerator.SD0aOEht40ZjKfIhihlC((object) this.metadata)) is ClassMetadata classMetadata ? ((string) ClassGenerator.BfZGlBhwWBu1DAk4K0G3((object) classMetadata)).CreateTypeSyntax() : throw new CodeGenerationException((string) ClassGenerator.myYI4FhwBsZd9USZckQl(ClassGenerator.VdcgsShteZAQpyeZuYHT(~-397266137 ^ 397327664), ClassGenerator.N8Q14chtM7HmW6L9Xnnw((object) this.metadata), (object) ClassGenerator.SD0aOEht40ZjKfIhihlC((object) this.metadata)));
    }

    /// <summary>Получить список ссылок на реализуемые интерфейсы</summary>
    protected virtual IEnumerable<ISyntaxNode> GetBaseInterfaces() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CGetBaseInterfaces\u003Ed__12(-2)
    {
      \u003C\u003E4__this = this
    };

    protected virtual Accessibility CtorAccessibility() => Accessibility.Public;

    protected virtual IEnumerable<ISyntaxNode> CtorParameters() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CCtorParameters\u003Ed__14(-2);

    protected virtual IEnumerable<ISyntaxNode> BaseConstructorArgs() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CBaseConstructorArgs\u003Ed__15(-2);

    protected string FieldName(PropertyMetadata propertyMetadata) => (string) ClassGenerator.EH4qFThwh5epgu9TLVKv(ClassGenerator.VdcgsShteZAQpyeZuYHT(-218496594 ^ -218493484), ClassGenerator.J4ica4hwb9lPD2lmGB7L(ClassGenerator.GcbmFRhwobpG82RPSoYj((object) propertyMetadata)));

    /// <summary>Записать конструкторы</summary>
    /// <param name="ctorStatements">Действия конструктора</param>
    protected virtual IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements) => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CGetCtors\u003Ed__17(-2)
    {
      \u003C\u003E4__this = this,
      \u003C\u003E3__ctorStatements = ctorStatements
    };

    /// <summary>Записать члены класса</summary>
    protected virtual IEnumerable<ISyntaxNode> GetMembers() => (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CGetMembers\u003Ed__18(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать метод "ToString"</summary>
    protected virtual ISyntaxNode ToStringMethod()
    {
      int num = 3;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            propertyMetadata = this.metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => ClassGenerator.ePRdAxhtzt8JSDGHcZqU(ClassGenerator.pF5JbEhwEukfysKlQfD6((object) p), this.metadata.TitlePropertyUid)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 3:
            Contract.NotNull((object) this.metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138940730));
            num = 2;
            continue;
          default:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (ISyntaxNode) null;
label_3:
      return ((string) ClassGenerator.VdcgsShteZAQpyeZuYHT(1925118608 << 2 ^ -889677702)).MethodDeclaration(returnType: TypeOf<string>.Raw.CreateTypeSyntax(), accessibility: Accessibility.Public, modifiers: DeclarationModifiers.Override, statements: (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        ((ISyntaxNode) ClassGenerator.yGfcbfhwGBZvIx3mXw6i(ClassGenerator.GcbmFRhwobpG82RPSoYj((object) propertyMetadata))).ReturnStatement()
      });
    }

    /// <summary>Записать свойства класса</summary>
    protected virtual IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements) => this.metadata.Properties.EmptyIfNull<PropertyMetadata>().SelectMany<PropertyMetadata, ISyntaxNode>((Func<PropertyMetadata, IEnumerable<ISyntaxNode>>) (propertyMetadata => this.WriteProperty(propertyMetadata, ctorStatements)));

    /// <summary>Записать выражение геттера свойства</summary>
    /// <param name="typeDescr">Дескриптор типа</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля</param>
    protected virtual IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(
      ITypeGenerationInfo typeDescr,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      IEnumerable<ISyntaxNode> getterExpressions = typeDescr.GetPropertyGetterExpressions(this.metadata, propertyMetadata, fieldName);
      if (getterExpressions != null)
        return getterExpressions;
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        fieldName.IdentifierName().ReturnStatement()
      };
    }

    /// <summary>Записать выражение сеттера свойства</summary>
    /// <param name="typeDescr">Дескриптор типа</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля</param>
    protected virtual IEnumerable<ISyntaxNode> GetPropertySetterExpressions(
      ITypeGenerationInfo typeDescr,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      IEnumerable<ISyntaxNode> setterExpressions = typeDescr.GetPropertySetterExpressions(this.metadata, propertyMetadata, fieldName);
      if (setterExpressions != null)
        return setterExpressions;
      return (IEnumerable<ISyntaxNode>) new ISyntaxNode[1]
      {
        fieldName.IdentifierName().AssignmentStatement(SyntaxGeneratorExtensions.Value)
      };
    }

    /// <summary>Записать свойство класса</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual IEnumerable<ISyntaxNode> WriteProperty(
      PropertyMetadata propertyMetadata,
      List<ISyntaxNode> ctorStatements,
      bool writeAttributes = true,
      Action<ISyntaxNode> propertyAction = null)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CWriteProperty\u003Ed__23(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__propertyMetadata = propertyMetadata,
        \u003C\u003E3__ctorStatements = ctorStatements,
        \u003C\u003E3__writeAttributes = writeAttributes,
        \u003C\u003E3__propertyAction = propertyAction
      };
    }

    /// <summary>Объявить свойство</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="propertyType">Тип свойства</param>
    /// <param name="getAccessorStatements">Выражение получения значения свойства</param>
    /// <param name="setAccessorStatements">Выражение установки значения свойства</param>
    /// <returns>Сгенерированное свойство</returns>
    protected virtual ISyntaxNode PropertyDeclaration(
      PropertyMetadata propertyMetadata,
      ISyntaxNode propertyType,
      IEnumerable<ISyntaxNode> getAccessorStatements = null,
      IEnumerable<ISyntaxNode> setAccessorStatements = null)
    {
      return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements);
    }

    /// <summary>
    /// Генерировать дополнительные члены класса для описанного свойства
    /// </summary>
    /// <param name="typeDescr">Генератор свойств с заданым типом</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Выражения</returns>
    protected virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      ITypeGenerationInfo typeDescr,
      PropertyMetadata propertyMetadata)
    {
      return typeDescr.GetAdditionalTypeMembers(this.metadata, propertyMetadata);
    }

    /// <summary>Получить выражение для инициализации свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="typeDescriptor">Экземпляр интерфейса описания типа данных</param>
    /// <returns></returns>
    protected virtual ISyntaxNode GetPropertyInitExpression(
      PropertyMetadata propertyMetadata,
      ITypeGenerationInfo typeDescriptor)
    {
      return typeDescriptor.GetPropertyInitExpression(this.metadata, propertyMetadata);
    }

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="typeDescriptor">Экземпляр интерфейса описания типа данных</param>
    /// <returns></returns>
    protected virtual ISyntaxNode GetPropertyTypeReference(
      PropertyMetadata propertyMetadata,
      ITypeGenerationInfo typeDescriptor)
    {
      return typeDescriptor.GetPropertyTypeReference(this.metadata, propertyMetadata, false);
    }

    /// <summary>Записать комментарии к свойству</summary>
    /// <param name="property">Объявление свойства</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual void WritePropertyComments(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.XmlComments(property, (NamedDocumentedMetadata) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Записать атрибуты локализуемого свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="resourcePrefix">Префикс для ресурса</param>
    /// <returns>Атрибуты</returns>
    protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationAttributes(
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      return this.WritePropertyLocalizationDisplayNameAttribute(propertyMetadata, resourcePrefix).Concat<ISyntaxNode>(this.WritePropertyLocalizationDescriptionAttribute(propertyMetadata, resourcePrefix));
    }

    /// <summary>
    /// Записать атрибут отображаемого имени локализуемого свойства
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="resourcePrefix">Префикс для ресурса</param>
    /// <returns>Атрибут</returns>
    protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationDisplayNameAttribute(
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      // ISSUE: reference to a compiler-generated method
      return (IEnumerable<ISyntaxNode>) EleWise.ELMA.SR.RunWithFutureTranslate<ISyntaxNode[]>((Func<ISyntaxNode[]>) (() => new ISyntaxNode[1]
      {
        TypeOf<DisplayNameAttribute>.Raw.CreateAttribute((object) EleWise.ELMA.SR.T((string) ClassGenerator.\u003C\u003Ec__DisplayClass30_0.pOeb3DvTnpd4C2pT6iKW((object) propertyMetadata)))
      }), false);
    }

    /// <summary>Записать атрибут описания локализуемого свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="resourcePrefix">Префикс для ресурса</param>
    /// <returns>Атрибут</returns>
    protected virtual IEnumerable<ISyntaxNode> WritePropertyLocalizationDescriptionAttribute(
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return !string.IsNullOrEmpty(propertyMetadata.Description) ? (IEnumerable<ISyntaxNode>) EleWise.ELMA.SR.RunWithFutureTranslate<ISyntaxNode[]>((Func<ISyntaxNode[]>) (() => new ISyntaxNode[1]
      {
        TypeOf<DescriptionAttribute>.Raw.CreateAttribute(ClassGenerator.\u003C\u003Ec__DisplayClass31_0.EKuPImvT17JFvtuvh2If(ClassGenerator.\u003C\u003Ec__DisplayClass31_0.ql7Q1KvTP3jop6mcBey3((object) propertyMetadata)))
      }), false) : Enumerable.Empty<ISyntaxNode>();
    }

    /// <summary>Записать атрибуты свойства</summary>
    /// <param name="property">Объявление свойства</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="resourcePrefix">Префикс для ресурса</param>
    protected virtual void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
      int num1 = 15;
      while (true)
      {
        int num2 = num1;
        List<ISyntaxNode> attributes;
        XmlWriter xmlWriter;
        List<string> stringList1;
        PropertyMetadataAdditionalAttribute[] additionalAttributeArray;
        int index;
        Guid guid;
        StringBuilder stringBuilder1;
        Dictionary<string, object> settingsValuePairs;
        List<ViewAttribute>.Enumerator enumerator1;
        PropertyCalculateType propertyCalculateType;
        List<PropertyHandlerInfo>.Enumerator enumerator2;
        PropertyMetadataAdditionalAttribute additionalAttribute;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ClassGenerator.tlvw5shtwyjc7tM1mXxF(ClassGenerator.l4EBRthwC9BulqwuRhWo((object) propertyMetadata), Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 72 : 51;
                continue;
              }
              goto label_48;
            case 2:
              if (ClassGenerator.bu6o3uhwZxt6Y8ZnT2GX((object) propertyMetadata))
              {
                num2 = 65;
                continue;
              }
              goto case 11;
            case 3:
            case 16:
            case 53:
            case 63:
              if (ClassGenerator.lySRbihwqMnXRPLXOus7((object) propertyMetadata) == null)
                goto case 27;
              else
                goto label_111;
            case 4:
            case 48:
              List<string> stringList2 = new List<string>();
              guid = propertyMetadata.TypeUid;
              stringList2.Add(guid.ToString());
              stringList1 = stringList2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
              continue;
            case 5:
              propertyCalculateType = ClassGenerator.q93c0vhwS8B6iYhSnRU0((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 38 : 11;
              continue;
            case 6:
              if (ClassGenerator.OrWvZphwpNGbMHYgmOxj((object) propertyMetadata) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 13;
                continue;
              }
              goto case 7;
            case 7:
              property.AddAttributes((IEnumerable<ISyntaxNode>) attributes);
              num2 = 61;
              continue;
            case 8:
              List<ISyntaxNode> syntaxNodeList1 = attributes;
              Type raw1 = TypeOf<TypeFilterPropertyResolverAttribute>.Raw;
              object[] objArray1 = new object[1];
              guid = ClassGenerator.a4X2uEhw342gn0pZsKkP((object) propertyMetadata);
              objArray1[0] = (object) guid.ToString();
              ISyntaxNode attribute1 = raw1.CreateAttribute(objArray1);
              syntaxNodeList1.Add(attribute1);
              num2 = 6;
              continue;
            case 9:
            case 50:
label_22:
              if (ClassGenerator.IYtegGhtmC4eb2Q0IsrY(ClassGenerator.Tpcp9RhwNj0BrqUJeYR0((object) propertyMetadata)))
              {
                num2 = 21;
                continue;
              }
              goto case 42;
            case 10:
              goto label_18;
            case 11:
              attributes.Add(TypeOf<NotNullAttribute>.Raw.CreateAttribute());
              num2 = 44;
              continue;
            case 12:
              goto label_34;
            case 13:
              if (ClassGenerator.OrWvZphwpNGbMHYgmOxj((object) propertyMetadata).Length != 0)
              {
                num2 = 17;
                continue;
              }
              goto case 7;
            case 14:
              List<ISyntaxNode> syntaxNodeList2 = attributes;
              Type raw2 = TypeOf<UidAttribute>.Raw;
              object[] objArray2 = new object[1];
              guid = ClassGenerator.pF5JbEhwEukfysKlQfD6((object) propertyMetadata);
              objArray2[0] = (object) guid.ToString();
              ISyntaxNode attribute2 = raw2.CreateAttribute(objArray2);
              syntaxNodeList2.Add(attribute2);
              num2 = 73;
              continue;
            case 15:
              attributes = new List<ISyntaxNode>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 12 : 14;
              continue;
            case 17:
              stringBuilder1 = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 55 : 64;
              continue;
            case 18:
              if (ClassGenerator.rw6vWkhwTneH91YvZgws((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 36 : 4;
                continue;
              }
              goto case 70;
            case 19:
              List<ISyntaxNode> syntaxNodeList3 = attributes;
              Type raw3 = TypeOf<OwnerPropertyUidAttribute>.Raw;
              object[] objArray3 = new object[1];
              guid = ClassGenerator.bPIOF6hwIyDOa67rvhwy((object) propertyMetadata);
              objArray3[0] = (object) guid.ToString();
              ISyntaxNode attribute3 = raw3.CreateAttribute(objArray3);
              syntaxNodeList3.Add(attribute3);
              num2 = 4;
              continue;
            case 20:
            case 35:
              if (index < additionalAttributeArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 30;
                continue;
              }
              goto case 7;
            case 21:
            case 60:
              if (ClassGenerator.tlvw5shtwyjc7tM1mXxF(ClassGenerator.a4X2uEhw342gn0pZsKkP((object) propertyMetadata), Guid.Empty))
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            case 22:
              attributes.Add(TypeOf<CalculateTypeAttribute>.Raw.CreateAttribute((object) ClassGenerator.q93c0vhwS8B6iYhSnRU0((object) propertyMetadata)));
              num2 = 5;
              continue;
            case 23:
              if (ClassGenerator.KDHWnihwKamsA0gWYVBf((object) propertyMetadata) <= 0)
              {
                num2 = 24;
                continue;
              }
              goto case 47;
            case 24:
            case 68:
              if (ClassGenerator.KsPOq2hwXfMmEH2P8KtB((object) propertyMetadata) != LineAlignment.Left)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 12 : 5;
                continue;
              }
              goto case 18;
            case 25:
              if (!((PropertyViewSettings) ClassGenerator.zKluDOhwO9SlL4fv3IP4((object) propertyMetadata)).Attributes.Any<ViewAttribute>())
                goto case 9;
              else
                goto label_101;
            case 26:
              if (propertyCalculateType != PropertyCalculateType.SQLFormula)
              {
                num2 = 53;
                continue;
              }
              goto case 46;
            case 27:
              attributes.AddRange(this.WritePropertyLocalizationAttributes(propertyMetadata, resourcePrefix));
              num2 = 23;
              continue;
            case 28:
            case 36:
              if (!ClassGenerator.EHbkqkhwkdjDD0Ee66oc((object) propertyMetadata))
              {
                num2 = 75;
                continue;
              }
              goto case 37;
            case 29:
              if (!ClassGenerator.tlvw5shtwyjc7tM1mXxF(propertyMetadata.OwnerPropertyUid, Guid.Empty))
              {
                num2 = 48;
                continue;
              }
              goto case 19;
            case 30:
            case 34:
              additionalAttribute = additionalAttributeArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 62 : 9;
              continue;
            case 31:
            case 44:
            case 51:
              if (ClassGenerator.ejeFAChwu4BfIBS624G9((object) propertyMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 56 : 49;
                continue;
              }
              goto case 49;
            case 32:
              settingsValuePairs = propertyMetadata.Settings.GetSettingsValuePairs();
              num2 = 54;
              continue;
            case 33:
              enumerator1 = propertyMetadata.ViewSettings.Attributes.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 58 : 57;
              continue;
            case 37:
              enumerator2 = propertyMetadata.Handlers.GetEnumerator();
              num2 = 52;
              continue;
            case 38:
              if (propertyCalculateType == PropertyCalculateType.CSScript)
                goto case 41;
              else
                goto label_103;
            case 39:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 20 : 6;
              continue;
            case 40:
            case 59:
              if (!ClassGenerator.Hvog6Jhw8qGrwl2s4TXn(ClassGenerator.bxRpBOhwvwfWierUTHpv((object) this, ClassGenerator.ibYO0khwQP5DbPvZMaOP((object) propertyMetadata), ClassGenerator.l4EBRthwC9BulqwuRhWo((object) propertyMetadata))))
              {
                num2 = 51;
                continue;
              }
              goto case 2;
            case 41:
              attributes.Add(TypeOf<CalculateScriptAttribute>.Raw.CreateAttribute(ClassGenerator.tOylMohwiSH6RXJAX27n((object) propertyMetadata)));
              num2 = 3;
              continue;
            case 42:
              attributes.Add(TypeOf<OnChangeScriptNameAttribute>.Raw.CreateAttribute(ClassGenerator.Tpcp9RhwNj0BrqUJeYR0((object) propertyMetadata)));
              num2 = 60;
              continue;
            case 43:
              goto label_48;
            case 45:
            case 72:
              attributes.Add(TypeOf<PropertyAttribute>.Raw.CreateAttribute((object[]) ClassGenerator.bt4R6ghwVvGFkuksgW2C((object) stringList1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 69;
              continue;
            case 46:
              attributes.Add(TypeOf<SQLFormulaAttribute>.Raw.CreateAttribute(ClassGenerator.IgVjjPhwRDTtvHaLdttq((object) propertyMetadata)));
              num2 = 63;
              continue;
            case 47:
              if (ClassGenerator.KDHWnihwKamsA0gWYVBf((object) propertyMetadata) != 200)
              {
                num2 = 66;
                continue;
              }
              goto case 24;
            case 49:
              if (propertyMetadata.IsSystem)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 76 : 66;
                continue;
              }
              goto case 29;
            case 52:
              try
              {
label_52:
                if (enumerator2.MoveNext())
                  goto label_55;
                else
                  goto label_53;
label_51:
                PropertyHandlerInfo current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_55;
                    case 2:
                      List<ISyntaxNode> syntaxNodeList4 = attributes;
                      Type raw4 = TypeOf<PropertyHandlerAttribute>.Raw;
                      object[] objArray4 = new object[1];
                      guid = ClassGenerator.LquInyhwnyIhGbQ2EPAO((object) current);
                      objArray4[0] = (object) guid.ToString();
                      ISyntaxNode attribute4 = raw4.CreateAttribute(objArray4);
                      syntaxNodeList4.Add(attribute4);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 3;
                      continue;
                    case 3:
                      goto label_52;
                    default:
                      goto label_89;
                  }
                }
label_53:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                goto label_51;
label_55:
                current = enumerator2.Current;
                num3 = 2;
                goto label_51;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 54:
              attributes.Add(ClassGenerator.lySRbihwqMnXRPLXOus7((object) propertyMetadata).GetType().CreateAttribute(settingsValuePairs.ToArray<KeyValuePair<string, object>>()));
              num2 = 74;
              continue;
            case 55:
label_113:
              attributes.Add(TypeOf<PropertyMetadataAdditionalAttributesAttribute>.Raw.CreateAttribute((object) stringBuilder1.ToString()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 10 : 4;
              continue;
            case 56:
              attributes.Add(TypeOf<RequiredAttribute>.Raw.CreateAttribute((object) ClassGenerator.ejeFAChwu4BfIBS624G9((object) propertyMetadata)));
              num2 = 49;
              continue;
            case 57:
              attributes.Add(TypeOf<OrderAttribute>.Raw.CreateAttribute((object) propertyMetadata.Order));
              num2 = 40;
              continue;
            case 58:
              try
              {
label_82:
                if (enumerator1.MoveNext())
                  goto label_80;
                else
                  goto label_83;
label_78:
                ViewAttribute current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_22;
                    case 2:
                      attributes.Add((ISyntaxNode) ClassGenerator.OoNP6ahw1n7pxm1u3ihd(TypeOf<ViewAttribute>.Raw, (object) new Dictionary<string, object>()
                      {
                        {
                          (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(1251470110 >> 2 ^ 312940063),
                          (object) current.ViewType
                        },
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122088524),
                          (object) ClassGenerator.EUIjt8hw29olmWp9eTJf((object) current)
                        },
                        {
                          (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(-1350312861 << 3 ^ 2082312570),
                          (object) ClassGenerator.GOHa5FhweHT3d7T5DNrI((object) current)
                        },
                        {
                          (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(-1939377524 ^ -1939603210),
                          (object) ClassGenerator.nv9r5WhwPHc02coEbfS2((object) current)
                        }
                      }.ToArray<KeyValuePair<string, object>>()));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_80;
                    default:
                      goto label_82;
                  }
                }
label_80:
                current = enumerator1.Current;
                num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                {
                  num5 = 2;
                  goto label_78;
                }
                else
                  goto label_78;
label_83:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
                goto label_78;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 61:
              goto label_116;
            case 62:
              List<ISyntaxNode> syntaxNodeList5 = attributes;
              object attributeTypeName = ClassGenerator.bmWHQAhw6ParTD6EifCf((object) additionalAttribute);
              IEnumerable<Parameter> source = ((IEnumerable<Parameter>) additionalAttribute.Parameters).EmptyIfNull<Parameter>();
              // ISSUE: reference to a compiler-generated field
              Func<Parameter, ISyntaxNode> func = ClassGenerator.\u003C\u003Ec.\u003C\u003E9__32_0;
              Func<Parameter, ISyntaxNode> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ClassGenerator.\u003C\u003Ec.\u003C\u003E9__32_0 = selector = (Func<Parameter, ISyntaxNode>) (p => ((ISyntaxNode) ClassGenerator.\u003C\u003Ec.MyAfcJvKdth5sSyrJPDh(ClassGenerator.\u003C\u003Ec.DFgBblvK9do4UA4Hj0Qg((object) p))).AttributeArgument((string) ClassGenerator.\u003C\u003Ec.xQRGt0vKlid3p9X7DywU((object) p)));
              }
              else
                goto label_119;
label_118:
              object[] array = (object[]) source.Select<Parameter, ISyntaxNode>(selector).ToArray<ISyntaxNode>();
              ISyntaxNode attribute5 = ((string) attributeTypeName).CreateAttribute(array);
              syntaxNodeList5.Add(attribute5);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 25 : 67;
              continue;
label_119:
              selector = func;
              goto label_118;
            case 64:
              StringBuilder stringBuilder2 = stringBuilder1;
              XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
              xmlWriterSettings.Indent = true;
              xmlWriterSettings.IndentChars = (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(1051276242 - 990076387 ^ 61253473);
              xmlWriterSettings.NewLineChars = (string) ClassGenerator.dkhSv5hwaGmgq6eSYcoF();
              ClassGenerator.Y8pxRZhwD6nfmHRdZLE2((object) xmlWriterSettings, true);
              xmlWriter = (XmlWriter) ClassGenerator.bGk8ZjhwtMaoQDocsh23((object) stringBuilder2, (object) xmlWriterSettings);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            case 65:
              attributes.Add(TypeOf<CanBeNullAttribute>.Raw.CreateAttribute());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 31 : 22;
              continue;
            case 66:
              attributes.Add(TypeOf<TableColumnWidthAttribute>.Raw.CreateAttribute((object) ClassGenerator.KDHWnihwKamsA0gWYVBf((object) propertyMetadata)));
              num2 = 68;
              continue;
            case 67:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 12 : 35;
              continue;
            case 69:
              if (ClassGenerator.q93c0vhwS8B6iYhSnRU0((object) propertyMetadata) == PropertyCalculateType.None)
              {
                num2 = 16;
                continue;
              }
              goto case 22;
            case 70:
              attributes.Add(TypeOf<SortableAttribute>.Raw.CreateAttribute((object) propertyMetadata.Sortable));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 12 : 28;
              continue;
            case 71:
label_89:
              if (ClassGenerator.zKluDOhwO9SlL4fv3IP4((object) propertyMetadata) == null)
              {
                num2 = 9;
                continue;
              }
              goto case 25;
            case 73:
              if (ClassGenerator.lvgQnthwfJmW1h41ZU5i((object) propertyMetadata) == 0)
              {
                num2 = 59;
                continue;
              }
              goto case 57;
            case 74:
              attributes.AddRange(this.WriteValidatePropertyAttributes(propertyMetadata));
              num2 = 27;
              continue;
            case 75:
              attributes.Add(TypeOf<GroupableAttribute>.Raw.CreateAttribute((object) ClassGenerator.EHbkqkhwkdjDD0Ee66oc((object) propertyMetadata)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 36 : 37;
              continue;
            case 76:
              attributes.Add(TypeOf<SystemPropertyAttribute>.Raw.CreateAttribute());
              num2 = 29;
              continue;
            default:
              try
              {
                ClassGenerator.id2d5xhwwfJ7QrxOKpgU((object) new XmlSerializer(TypeOf<PropertyMetadataAdditionalAttribute[]>.Raw), (object) xmlWriter, ClassGenerator.OrWvZphwpNGbMHYgmOxj((object) propertyMetadata));
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                    goto label_113;
                }
              }
              finally
              {
                int num8;
                if (xmlWriter == null)
                  num8 = 2;
                else
                  goto label_14;
label_13:
                switch (num8)
                {
                  case 1:
                  case 2:
                }
label_14:
                ClassGenerator.jXy9hnhw4a8UFbBG9sJd((object) xmlWriter);
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                {
                  num8 = 1;
                  goto label_13;
                }
                else
                  goto label_13;
              }
          }
        }
label_18:
        additionalAttributeArray = (PropertyMetadataAdditionalAttribute[]) ClassGenerator.OrWvZphwpNGbMHYgmOxj((object) propertyMetadata);
        num1 = 39;
        continue;
label_34:
        attributes.Add(TypeOf<TableCellAlignmentAttribute>.Raw.CreateAttribute((object) ClassGenerator.KsPOq2hwXfMmEH2P8KtB((object) propertyMetadata)));
        num1 = 18;
        continue;
label_48:
        List<string> stringList3 = stringList1;
        guid = ClassGenerator.l4EBRthwC9BulqwuRhWo((object) propertyMetadata);
        string str = guid.ToString();
        stringList3.Add(str);
        num1 = 45;
        continue;
label_101:
        num1 = 33;
        continue;
label_103:
        num1 = 26;
        continue;
label_111:
        num1 = 32;
      }
label_116:;
    }

    /// <summary>Записать атрибуты валидации</summary>
    /// <param name="propertyMetadata"></param>
    protected virtual IEnumerable<ISyntaxNode> WriteValidatePropertyAttributes(
      PropertyMetadata propertyMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new ClassGenerator.\u003CWriteValidatePropertyAttributes\u003Ed__33(-2)
      {
        \u003C\u003E3__propertyMetadata = propertyMetadata
      };
    }

    /// <summary>Получить описание типа свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Описание типа свойства</returns>
    /// <exception cref="T:EleWise.ELMA.Exceptions.CodeGenerationException">Если тип не задан или не найден</exception>
    protected ITypeDescriptor GetPropertyTypeDescriptor(PropertyMetadata propertyMetadata)
    {
      int num = 4;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (typeDescriptor == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          case 3:
            if (!ClassGenerator.ePRdAxhtzt8JSDGHcZqU(ClassGenerator.ibYO0khwQP5DbPvZMaOP((object) propertyMetadata), Guid.Empty))
            {
              num = 5;
              continue;
            }
            goto label_5;
          case 4:
            ClassGenerator.tq2tKWhtPEt6RG6iKHvJ((object) propertyMetadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(-2138160520 ^ -2138174678));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 3 : 0;
            continue;
          case 5:
            typeDescriptor = this.GetTypeDescriptor(ClassGenerator.ibYO0khwQP5DbPvZMaOP((object) propertyMetadata), propertyMetadata.SubTypeUid);
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      throw new CodeGenerationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139004562), ClassGenerator.GcbmFRhwobpG82RPSoYj((object) propertyMetadata)));
label_7:
      throw new CodeGenerationException(EleWise.ELMA.SR.T((string) ClassGenerator.VdcgsShteZAQpyeZuYHT(-244066886 - -48452443 ^ -195798075), ClassGenerator.GcbmFRhwobpG82RPSoYj((object) propertyMetadata), (object) ClassGenerator.ibYO0khwQP5DbPvZMaOP((object) propertyMetadata)));
label_8:
      return typeDescriptor;
    }

    /// <summary>Получить тип связи</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Тип связи или <c>null</c></returns>
    protected RelationType? GetRelationType(PropertyMetadata propertyMetadata) => propertyMetadata.Settings is IRelationTypeSettings settings ? new RelationType?(settings.RelationType) : new RelationType?();

    /// <summary>Записать ресурсы локализации</summary>
    protected virtual IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
    {
      List<ISyntaxTrivia> list = this.Resources().ToList<ISyntaxTrivia>();
      if (!list.Any<ISyntaxTrivia>())
        return Enumerable.Empty<ISyntaxTrivia>();
      list.Insert(0, string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397204288)).TextComment());
      return (IEnumerable<ISyntaxTrivia>) list;
    }

    /// <summary>Записать ресурсы класса</summary>
    protected virtual IEnumerable<ISyntaxTrivia> Resources() => (IEnumerable<ISyntaxTrivia>) new ClassGenerator.\u003CResources\u003Ed__37(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Записать ресурсы типа свойства</summary>
    /// <param name="propertyMetadata"></param>
    protected virtual IEnumerable<ISyntaxTrivia> PropertyResources(PropertyMetadata propertyMetadata)
    {
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813618819));
      return this.PropertyTypeResources(propertyMetadata);
    }

    /// <summary>Записать ресурсы типа свойства</summary>
    /// <param name="propertyMetadata"></param>
    protected virtual IEnumerable<ISyntaxTrivia> PropertyTypeResources(
      PropertyMetadata propertyMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxTrivia>) new ClassGenerator.\u003CPropertyTypeResources\u003Ed__39(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__propertyMetadata = propertyMetadata
      };
    }

    /// <summary>Сгенерировать дополнительные файлы с ресурсами иконок</summary>
    protected virtual IEnumerable<GeneratedFileInfo> GenerateImageResources() => (IEnumerable<GeneratedFileInfo>) new ClassGenerator.\u003CGenerateImageResources\u003Ed__40(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>
    /// Сгенерировать дополнительные файлы с ресурсами для форм и преобразований форм
    /// </summary>
    protected virtual IEnumerable<GeneratedFileInfo> GenerateFormsResources() => (IEnumerable<GeneratedFileInfo>) new ClassGenerator.\u003CGenerateFormsResources\u003Ed__42(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить расширение для файла ресурса формы</summary>
    /// <param name="formUniquieName">Имя формы, уникальное в пределах данного объекта метаданных</param>
    /// <returns>Расширение для файла ресурса иконки</returns>
    protected string GetFormResourceExtension(string formUniquieName)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!ClassGenerator.IYtegGhtmC4eb2Q0IsrY(ClassGenerator.BguOTUhwHOFef222T1tF((object) this.generationParams)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 1;
              continue;
            }
            goto label_5;
          case 3:
            Contract.ArgumentNotNull((object) formUniquieName, (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(--1418440330 ^ 1418255762));
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      string str1 = "";
      goto label_7;
label_6:
      str1 = (string) ClassGenerator.VdcgsShteZAQpyeZuYHT(--1333735954 ^ 1333733590) + (string) ClassGenerator.BguOTUhwHOFef222T1tF((object) this.generationParams);
label_7:
      string str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875968107);
      string str3 = formUniquieName;
      object obj = ClassGenerator.VdcgsShteZAQpyeZuYHT(-867826612 ^ -867792382);
      return (string) ClassGenerator.aIReK2hwA61N6SNBxCja((object) str1, (object) str2, (object) str3, obj);
    }

    /// <summary>Получить имя для ресурсного файла формы</summary>
    /// <param name="formUniquieName">Имя формы, уникальное в пределах данного объекта метаданных</param>
    /// <returns>Имя для ресурсного файла формы</returns>
    protected string GetFormResourceName(string formUniquieName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ClassGenerator.tq2tKWhtPEt6RG6iKHvJ((object) formUniquieName, ClassGenerator.VdcgsShteZAQpyeZuYHT(-1921202237 ^ -1921010469));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) ClassGenerator.aIReK2hwA61N6SNBxCja(ClassGenerator.rJCFDqhw7vgb9xDRJ6Mo((object) this.generationParams), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281840004), ClassGenerator.xCkuMDhw0ZhbFWYa7UJb((object) Path.GetFileName((string) ClassGenerator.toULW8hwxNHePeTZ2bTL((object) this.generationParams))), (object) this.GetFormResourceExtension(formUniquieName));
    }

    /// <summary>Есть ли кастомный код</summary>
    protected virtual bool HasCustomCode
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (string.IsNullOrEmpty(this.metadata.CustomCode))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            case 3:
              ClassGenerator.pNMkSmhtNeKYL7DK2m1V((object) this.metadata, ClassGenerator.VdcgsShteZAQpyeZuYHT(-2112703338 ^ -2112684632));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return !string.IsNullOrEmpty(((string) ClassGenerator.lDXcKYhwmODm5Ai41a68((object) this.metadata)).Trim((char[]) ClassGenerator.ENV2gYhwy8GJrUc5MUMF(ClassGenerator.VdcgsShteZAQpyeZuYHT(95909607 + 343705423 ^ 439593082))));
label_3:
        return false;
      }
    }

    /// <summary>
    /// Сгенерировать дополнительный файл с ресурсом кастомного кода
    /// </summary>
    protected virtual IEnumerable<GeneratedFileInfo> GenerateCustomCodeResources() => (IEnumerable<GeneratedFileInfo>) new ClassGenerator.\u003CGenerateCustomCodeResources\u003Ed__47(-2)
    {
      \u003C\u003E4__this = this
    };

    /// <summary>Получить расширение для файла кастомного кода</summary>
    /// <param name="forCompile">True, если файл для компиляции. False - если файл для шаблона (ресурса).</param>
    /// <returns>Расширение для файла кастомного кода</returns>
    protected string GetCustomCodeFileExtension(bool forCompile)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ClassGenerator.IYtegGhtmC4eb2Q0IsrY((object) this.generationParams.Prefix))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      object obj1 = (object) "";
      goto label_6;
label_5:
      obj1 = ClassGenerator.EH4qFThwh5epgu9TLVKv(ClassGenerator.VdcgsShteZAQpyeZuYHT(-1886646897 ^ -1886644405), ClassGenerator.BguOTUhwHOFef222T1tF((object) this.generationParams));
label_6:
      object obj2 = ClassGenerator.VdcgsShteZAQpyeZuYHT(-882126494 ^ -882127962);
      object obj3 = !forCompile ? ClassGenerator.VdcgsShteZAQpyeZuYHT(-867826612 ^ -867862778) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606846354);
      object obj4 = ClassGenerator.VdcgsShteZAQpyeZuYHT(-2138160520 ^ -2138088650);
      return (string) ClassGenerator.aIReK2hwA61N6SNBxCja(obj1, obj2, obj3, obj4);
    }

    /// <summary>Получить имя для ресурсного файла кастомного кода</summary>
    /// <returns>Имя для ресурсного файла кастомного кода</returns>
    protected string GetCustomCodeResourceName() => (string) ClassGenerator.aIReK2hwA61N6SNBxCja(ClassGenerator.rJCFDqhw7vgb9xDRJ6Mo((object) this.generationParams), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87864935), ClassGenerator.xCkuMDhw0ZhbFWYa7UJb((object) Path.GetFileName((string) ClassGenerator.toULW8hwxNHePeTZ2bTL((object) this.generationParams))), (object) this.GetCustomCodeFileExtension(false));

    public ClassGenerator()
    {
      ClassGenerator.p6rq8DhwM6Feyssg4xYB();
      this.formsByUniqueName = new Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object VdcgsShteZAQpyeZuYHT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void tq2tKWhtPEt6RG6iKHvJ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void eAlyp5ht1g7TvtQKEQef(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static bool wI392qhtOpbMw9Vb8fQ2() => ClassGenerator.sg6Oj4htn5SWvaiyPVCq == null;

    internal static ClassGenerator vgIZrZht27qliCCFZP2r() => ClassGenerator.sg6Oj4htn5SWvaiyPVCq;

    internal static void pNMkSmhtNeKYL7DK2m1V([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static object FxRu3lht3umYonoYh6Ru([In] object obj0) => (object) ((ClassGenerator) obj0).GetNamespace();

    internal static bool J1CTcvhtpYGPrvUtpJrr([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static object Sjk3yShtav14CZmnwK6I([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static object mZMePEhtDXl5jLTpGd7k() => (object) MetadataServiceContext.Service;

    internal static long M1jMvEhtteFad8CuYl9r([In] object obj0) => ((ClassMetadata) obj0).GroupId;

    internal static bool tlvw5shtwyjc7tM1mXxF([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid SD0aOEht40ZjKfIhihlC([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static bool mRJjjGht6iYw3qBUFomI([In] object obj0) => ((ClassMetadata) obj0).AllowCreateHeirs;

    internal static object frOtbWhtHdTOBfOBMcZG([In] object obj0) => (object) ((ClassMetadata) obj0).DisplayFormat;

    internal static Guid TeJXtIhtAfdprL7QyyTD([In] object obj0) => ((ClassMetadata) obj0).TitlePropertyUid;

    internal static bool yWaSNNht7BH3CPvFPSQG([In] object obj0) => ((ClassMetadata) obj0).ShowInTypeTree;

    internal static bool ncraIuhtxJpPAokamIF6([In] object obj0) => ((ClassMetadata) obj0).ShowInDesigner;

    internal static object tvfCSYht0wKLa85Mnr1m([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static bool IYtegGhtmC4eb2Q0IsrY([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object sR47Zfhtyh6lG13xQwsK([In] object obj0) => (object) ((ClassMetadata) obj0).OnViewLoadScriptName;

    internal static object N8Q14chtM7HmW6L9Xnnw([In] object obj0) => (object) ((ClassMetadata) obj0).TypeName;

    internal static object Q0wLochtJoSj9VPdneTQ([In] object obj0) => (object) ((string) obj0).TypeOfExpression();

    internal static ImageFormatType MHK43Nht9m4W4g9dfKFX([In] object obj0) => ((MetadataImage) obj0).Format;

    internal static object PsGVRMhtdZpcXttVAixR() => (object) Encoding.UTF8;

    internal static object k5AGvphtlUb8HHDOwdXv([In] object obj0) => (object) ((MetadataImage) obj0).Data;

    internal static object fFxHQahtraSc8p9xawBK([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static int KbgUrdhtg5VDBlZeQ3cB([In] object obj0) => ((MetadataImage) obj0).Size;

    internal static bool dKTU9Oht5IlT3DnXO81i([In] object obj0) => ((MetadataImage) obj0).IsDefault;

    internal static bool TCwS2Nhtj4wZDrW5IG7J([In] object obj0) => ((ClassGenerator) obj0).HasCustomCode;

    internal static ClassFormsScheme aPJh7uhtYeGwoEUVnC5c([In] object obj0) => ((ClassMetadata) obj0).FormsScheme;

    internal static object VRhT9whtLUd14lhllOpt([In] object obj0) => (object) ((ClassMetadata) obj0).DefaultForms;

    internal static void J9DywShtUTMb2UbvKW2T([In] object obj0) => ((Dictionary<string, Tuple<FormViewItem, FormViewItemTransformation>>) obj0).Clear();

    internal static object lXrOdIhtsGddsTHs67yF([In] object obj0) => (object) ((ViewItem) obj0).Name;

    internal static object tPnASehtcHiPEhZNvI3d([In] object obj0) => (object) ((ClassMetadata) obj0).NamespaceForDisplay;

    internal static bool ePRdAxhtzt8JSDGHcZqU([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object mYwTsvhwFAn1MgQn0jye([In] object obj0, Guid uid) => (object) ((CodeGenerator) obj0).GetMetadata(uid);

    internal static object myYI4FhwBsZd9USZckQl([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object BfZGlBhwWBu1DAk4K0G3([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object GcbmFRhwobpG82RPSoYj([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object J4ica4hwb9lPD2lmGB7L([In] object obj0) => (object) ((string) obj0).ToLowerFirstChar();

    internal static object EH4qFThwh5epgu9TLVKv([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object yGfcbfhwGBZvIx3mXw6i([In] object obj0) => (object) ((string) obj0).IdentifierName();

    internal static Guid pF5JbEhwEukfysKlQfD6([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static int lvgQnthwfJmW1h41ZU5i([In] object obj0) => ((PropertyMetadata) obj0).Order;

    internal static Guid ibYO0khwQP5DbPvZMaOP([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static Guid l4EBRthwC9BulqwuRhWo([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object bxRpBOhwvwfWierUTHpv([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((ClassGenerator) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool Hvog6Jhw8qGrwl2s4TXn([In] object obj0) => ((ITypeDescriptor) obj0).CanBeNullable;

    internal static bool bu6o3uhwZxt6Y8ZnT2GX([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool ejeFAChwu4BfIBS624G9([In] object obj0) => ((PropertyMetadata) obj0).Required;

    internal static Guid bPIOF6hwIyDOa67rvhwy([In] object obj0) => ((PropertyMetadata) obj0).OwnerPropertyUid;

    internal static object bt4R6ghwVvGFkuksgW2C([In] object obj0) => (object) ((List<string>) obj0).ToArray();

    internal static PropertyCalculateType q93c0vhwS8B6iYhSnRU0([In] object obj0) => ((PropertyMetadata) obj0).CalculateType;

    internal static object tOylMohwiSH6RXJAX27n([In] object obj0) => (object) ((PropertyMetadata) obj0).CalculateScript;

    internal static object IgVjjPhwRDTtvHaLdttq([In] object obj0) => (object) ((PropertyMetadata) obj0).SQLFormula;

    internal static object lySRbihwqMnXRPLXOus7([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static int KDHWnihwKamsA0gWYVBf([In] object obj0) => ((PropertyMetadata) obj0).TableColumnWidth;

    internal static LineAlignment KsPOq2hwXfMmEH2P8KtB([In] object obj0) => ((PropertyMetadata) obj0).TableCellAlignment;

    internal static bool rw6vWkhwTneH91YvZgws([In] object obj0) => ((PropertyMetadata) obj0).Sortable;

    internal static bool EHbkqkhwkdjDD0Ee66oc([In] object obj0) => ((PropertyMetadata) obj0).Groupable;

    internal static Guid LquInyhwnyIhGbQ2EPAO([In] object obj0) => ((PropertyHandlerInfo) obj0).HandlerUid;

    internal static object zKluDOhwO9SlL4fv3IP4([In] object obj0) => (object) ((PropertyMetadata) obj0).ViewSettings;

    internal static ItemType EUIjt8hw29olmWp9eTJf([In] object obj0) => ((ViewAttribute) obj0).ItemType;

    internal static Visibility GOHa5FhweHT3d7T5DNrI([In] object obj0) => ((ViewAttribute) obj0).Visibility;

    internal static bool nv9r5WhwPHc02coEbfS2([In] object obj0) => ((ViewAttribute) obj0).ReadOnly;

    internal static object OoNP6ahw1n7pxm1u3ihd(Type attributeType, [In] object obj1) => (object) attributeType.CreateAttribute((KeyValuePair<string, object>[]) obj1);

    internal static object Tpcp9RhwNj0BrqUJeYR0([In] object obj0) => (object) ((PropertyMetadata) obj0).OnChangeScriptName;

    internal static Guid a4X2uEhw342gn0pZsKkP([In] object obj0) => ((PropertyMetadata) obj0).TypeResolver;

    internal static object OrWvZphwpNGbMHYgmOxj([In] object obj0) => (object) ((PropertyMetadata) obj0).AdditionalAttributes;

    internal static object dkhSv5hwaGmgq6eSYcoF() => (object) Environment.NewLine;

    internal static void Y8pxRZhwD6nfmHRdZLE2([In] object obj0, [In] bool obj1) => ((XmlWriterSettings) obj0).OmitXmlDeclaration = obj1;

    internal static object bGk8ZjhwtMaoQDocsh23([In] object obj0, [In] object obj1) => (object) XmlWriter.Create((StringBuilder) obj0, (XmlWriterSettings) obj1);

    internal static void id2d5xhwwfJ7QrxOKpgU([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlSerializer) obj0).Serialize((XmlWriter) obj1, obj2);

    internal static void jXy9hnhw4a8UFbBG9sJd([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object bmWHQAhw6ParTD6EifCf([In] object obj0) => (object) ((PropertyMetadataAdditionalAttribute) obj0).AddtibuteName;

    internal static object BguOTUhwHOFef222T1tF([In] object obj0) => (object) ((GenerationParams) obj0).Prefix;

    internal static object aIReK2hwA61N6SNBxCja(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object rJCFDqhw7vgb9xDRJ6Mo([In] object obj0) => (object) ((GenerationParams) obj0).Namespace;

    internal static object toULW8hwxNHePeTZ2bTL([In] object obj0) => (object) ((GenerationParams) obj0).FileName;

    internal static object xCkuMDhw0ZhbFWYa7UJb([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static object lDXcKYhwmODm5Ai41a68([In] object obj0) => (object) ((ClassMetadata) obj0).CustomCode;

    internal static object ENV2gYhwy8GJrUc5MUMF([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static void p6rq8DhwM6Feyssg4xYB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object rqfT1ghwJLGaZuUtUlwo([In] object obj0) => (object) ((string) obj0).TextComment();
  }
}
