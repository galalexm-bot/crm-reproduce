// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.AbstractEntitySystemComponentCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Абстрактный класс создания системных компонентов для сущностей
  /// </summary>
  internal abstract class AbstractEntitySystemComponentCreator : ISystemComponentCreator
  {
    private static readonly Guid EntityPropertyUid;
    /// <summary>Свойство "Идентификатор сущности"</summary>
    internal const string EntityIdProperty = "EntityId";
    /// <summary>Свойство "Тип сущности"</summary>
    internal const string EntityTypeUidProperty = "EntityTypeUid";
    /// <summary>Свойство "Идентификатор родительской сущности"</summary>
    internal const string ParentEntityIdProperty = "ParentEntityId";
    /// <summary>Свойство "Тип родительской сущности"</summary>
    internal const string ParentEntityTypeUidProperty = "ParentEntityTypeUid";
    /// <summary>Свойство "Иерархический"</summary>
    internal const string HierarchicalProperty = "Hierarchical";
    /// <summary>Свойство "Является группой"</summary>
    internal const string IsGroupProperty = "IsGroup";
    internal static AbstractEntitySystemComponentCreator znyihlfoGUfGsPHnLo5e;

    /// <summary>Служба аутентификации системы</summary>
    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Менеджер модулей сценариев</summary>
    public ScriptModuleManager ScriptModuleManager
    {
      get => this.\u003CScriptModuleManager\u003Ek__BackingField;
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
              this.\u003CScriptModuleManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Сервис компиляции компонента</summary>
    public IComponentAssemblyBuilderService ComponentAssemblyBuilderService
    {
      get => this.\u003CComponentAssemblyBuilderService\u003Ek__BackingField;
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
              this.\u003CComponentAssemblyBuilderService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    /// <summary>Сервис поиска метаданных</summary>
    public ISearchMetadataService SearchMetadataService
    {
      get => this.\u003CSearchMetadataService\u003Ek__BackingField;
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
              this.\u003CSearchMetadataService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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
    public ComponentMetadataItem Create() => this.CreateInternal();

    /// <summary>Уникальный идентификатор компонента</summary>
    protected abstract Guid ComponentUid { get; }

    /// <summary>Имя метаданных компонента</summary>
    protected abstract string ComponentMetadataName { get; }

    /// <summary>Отображаемое имя метаданных компонента</summary>
    protected abstract string ComponentDisplayName { get; }

    /// <summary>Тип представления</summary>
    protected abstract ViewType ViewType { get; }

    private ComponentMetadataItem CreateInternal()
    {
      int num1 = 12;
      ComponentMetadataItem componentMetadataItem1;
      while (true)
      {
        int num2 = num1;
        ComponentMetadata parameters;
        while (true)
        {
          ClassDeclarationSyntax declarationSyntax1;
          IUser user;
          ComponentMetadataItemHeader metadataItemHeader1;
          string str1;
          ComponentBuildAssemblyModel buildAssemblyModel;
          List<DataClassAssemblyInfo> list;
          ClassDeclarationSyntax declarationSyntax2;
          string str2;
          string str3;
          switch (num2)
          {
            case 1:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.ETv5JZfoXZqic2Hf7nMF());
              num2 = 24;
              continue;
            case 2:
              if (!AbstractEntitySystemComponentCreator.e3ux8Nfo2IdspTn8ZwNM((object) str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 25 : 21;
                continue;
              }
              goto case 8;
            case 3:
              if (declarationSyntax1 == null)
                goto case 8;
              else
                goto label_6;
            case 4:
              list = this.SearchMetadataService.GetPublishedDataClassAssemblies().ToList<DataClassAssemblyInfo>();
              num2 = 28;
              continue;
            case 5:
              declarationSyntax2 = (ClassDeclarationSyntax) null;
              goto label_41;
            case 6:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) this.CreateEntityProperty());
              num2 = 19;
              continue;
            case 7:
              str1 = (string) AbstractEntitySystemComponentCreator.r5oJEIfo3CFi4LbtdaDh((object) str1, declarationSyntax1.OpenBraceToken.FullSpan.End, AbstractEntitySystemComponentCreator.sqioyQfoNGI7QikBijGb());
              num2 = 8;
              continue;
            case 8:
              user = (IUser) AbstractEntitySystemComponentCreator.F7i4osfopDkuJGsUn4wK((object) this.AuthenticationService);
              num2 = 13;
              continue;
            case 9:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.tTFNujfokU8KoqeKBJQO());
              num2 = 14;
              continue;
            case 10:
              str2 = string.Empty;
              goto label_38;
            case 11:
              AbstractEntitySystemComponentCreator.dtVugsfoQK7I7Viet2IB((object) parameters);
              num2 = 21;
              continue;
            case 12:
              parameters = new ComponentMetadata(Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 10 : 11;
              continue;
            case 13:
              ComponentMetadataItem componentMetadataItem2 = new ComponentMetadataItem();
              AbstractEntitySystemComponentCreator.f8yPqQfoDWlDbEyq5LhL((object) componentMetadataItem2, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
              AbstractEntitySystemComponentCreator.R3nn8ofotxTeCSZwugUA((object) componentMetadataItem2, (object) parameters);
              componentMetadataItem2.CreationAuthorId = (long?) (user != null ? AbstractEntitySystemComponentCreator.jQAaSvfowc9vB02nqgUw((object) user) : (object) null);
              AbstractEntitySystemComponentCreator.G57w7efo6ERtk4TaB7qT((object) componentMetadataItem2, AbstractEntitySystemComponentCreator.vZedaPfo4vcLIGRpJ4to());
              AbstractEntitySystemComponentCreator.phcsY1foHJkeJ6nsqP6b((object) componentMetadataItem2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536744634));
              componentMetadataItem2.AssemblyName = (string) AbstractEntitySystemComponentCreator.d06wM9foAk3kg2e6Rxld((object) parameters);
              componentMetadataItem2.VersionNumber = new long?(1L);
              AbstractEntitySystemComponentCreator.nV49DnfoxDdWjIpkgJwE((object) componentMetadataItem2, AbstractEntitySystemComponentCreator.bK7FhAfo7Q5O34TSrl9P((object) parameters, (object) str1));
              componentMetadataItem1 = componentMetadataItem2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 22 : 26;
              continue;
            case 14:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.hVagDQfonbGnTNHoFceb());
              num2 = 16;
              continue;
            case 15:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.saOTsEfoqjvhQyXkQvMP());
              num2 = 6;
              continue;
            case 16:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.hmOwyjfoOWdZl1Gybc3e());
              num2 = 18;
              continue;
            case 17:
              AbstractEntitySystemComponentCreator.wttJvvfoZpxNOAZRy6jw((object) parameters, AbstractEntitySystemComponentCreator.fdo6pQfo8B0OCV6uQHZ2((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 29 : 7;
              continue;
            case 18:
              IScriptModuleType scriptModuleType = this.ScriptModuleManager.GetScriptModuleType(ComponentClientScriptModuleType.TypeUid);
              if (scriptModuleType == null)
              {
                num2 = 23;
                continue;
              }
              str3 = scriptModuleType.GenerateSourceCode((object) parameters);
              break;
            case 19:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk((object) parameters.Content)).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.N8V2TLfoKfrpEqXatM2k());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
            case 20:
              goto label_18;
            case 21:
              goto label_24;
            case 22:
              AbstractEntitySystemComponentCreator.BdJmqmfoUKKS2DePDGLv((object) this.ComponentAssemblyBuilderService, (object) buildAssemblyModel);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 20 : 20;
              continue;
            case 23:
              str3 = (string) null;
              break;
            case 24:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.bMafbrfoTn7NMTEOomsy());
              num2 = 9;
              continue;
            case 25:
              ClassDeclarationSyntax declarationSyntax3 = ((SyntaxNode) AbstractEntitySystemComponentCreator.LcypNZfo1wO90cNaVPiU((object) CSharpSyntaxTree.ParseText(str1, (CSharpParseOptions) AbstractEntitySystemComponentCreator.a5LNmkfoPsIkrvHeX6Dg(AbstractEntitySystemComponentCreator.cUlX0cfoe55ShqUDAjL2(), LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()), new CancellationToken())).DescendantNodes().OfType<ClassDeclarationSyntax>().ToList<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num3 = 1;
                SyntaxToken syntaxToken;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      syntaxToken = AbstractEntitySystemComponentCreator.MMKXttfbnYALFDFY2s41((object) q);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                return AbstractEntitySystemComponentCreator.jVa9AcfbOmdxFjLH8WYR((object) syntaxToken.ToString(), AbstractEntitySystemComponentCreator.fdo6pQfo8B0OCV6uQHZ2((object) this));
              }));
              if (declarationSyntax3 == null)
              {
                num2 = 5;
                continue;
              }
              declarationSyntax2 = declarationSyntax3.Members.OfType<ClassDeclarationSyntax>().FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num4 = 1;
                SyntaxToken syntaxToken;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken = AbstractEntitySystemComponentCreator.\u003C\u003Ec.W2pd1o89Kbsvys4WiPrF((object) q);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return syntaxToken.ToString() == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70099006);
              }));
              goto label_41;
            case 26:
              ComponentMetadataItemHeader metadataItemHeader2 = new ComponentMetadataItemHeader();
              AbstractEntitySystemComponentCreator.CZYa2RfomvDiKMmVUBmP((object) metadataItemHeader2, AbstractEntitySystemComponentCreator.pAVGuZfo0S0nWldtETDr((object) parameters));
              AbstractEntitySystemComponentCreator.BD6LOJfoMyCdh5o3nhwd((object) metadataItemHeader2, AbstractEntitySystemComponentCreator.PtgBpjfoykh2aUZJ61hP((object) parameters));
              AbstractEntitySystemComponentCreator.SYXpfAfo9IhQmFGcIiU4((object) metadataItemHeader2, AbstractEntitySystemComponentCreator.Icu5icfoJXnBdiVCSJlF((object) parameters));
              AbstractEntitySystemComponentCreator.gGgvLnfolKiIQ7yUcs7L((object) metadataItemHeader2, AbstractEntitySystemComponentCreator.erbbyKfodtnS7CRIwgva((object) parameters));
              AbstractEntitySystemComponentCreator.HKmd6UforAIpUBQd8Zsj((object) metadataItemHeader2, parameters.ModuleUid);
              metadataItemHeader2.CreationAuthorId = componentMetadataItem1.CreationAuthorId;
              AbstractEntitySystemComponentCreator.yIY00rfogMDxn6W3D2ok((object) metadataItemHeader2, componentMetadataItem1.CreationDate);
              metadataItemHeader2.Draft = componentMetadataItem1;
              AbstractEntitySystemComponentCreator.tuA0Z7fo52r7aQIbkoPH((object) metadataItemHeader2, (object) componentMetadataItem1);
              AbstractEntitySystemComponentCreator.WukmZOfoYyNBcOPLZobO((object) metadataItemHeader2, AbstractEntitySystemComponentCreator.NQaZQ9fojZZHiZc4LfPA((object) parameters));
              metadataItemHeader1 = metadataItemHeader2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 9 : 30;
              continue;
            case 27:
              ((ClassMetadata) AbstractEntitySystemComponentCreator.HUlWkVfoiOEIAbH1ynyk(AbstractEntitySystemComponentCreator.ooITjSfoSC1gs1K9sHOG((object) parameters))).Properties.Add((PropertyMetadata) AbstractEntitySystemComponentCreator.YcytbvfoRXqTOgpjYqB8());
              num2 = 15;
              continue;
            case 28:
              // ISSUE: reference to a compiler-generated method
              buildAssemblyModel = new ComponentBuildAssemblyModel(componentMetadataItem1, Enumerable.Empty<byte[]>(), list.Select<DataClassAssemblyInfo, byte[]>((Func<DataClassAssemblyInfo, byte[]>) (a => (byte[]) AbstractEntitySystemComponentCreator.\u003C\u003Ec.bAZkHc89XHw2V78MuAJq((object) a))), true);
              num2 = 22;
              continue;
            case 29:
              AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) parameters, AbstractEntitySystemComponentCreator.GFHcGlfouHVRMOoYrMpe((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 30:
              AbstractEntitySystemComponentCreator.qNCn5YfoLWqssbMu1yWi((object) componentMetadataItem1, (object) metadataItemHeader1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 4 : 2;
              continue;
            default:
              ((EventedList<ViewItem>) AbstractEntitySystemComponentCreator.XrKy6JfoVVebn1aZlGKA((object) parameters.Content.View)).Add((ViewItem) this.CreateObjectFormViewItem());
              num2 = 27;
              continue;
          }
          if (str3 == null)
          {
            num2 = 10;
            continue;
          }
          str2 = str3;
label_38:
          str1 = str2;
          num2 = 2;
          continue;
label_41:
          declarationSyntax1 = declarationSyntax2;
          num2 = 3;
        }
label_6:
        num1 = 7;
        continue;
label_24:
        AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) parameters, AbstractEntitySystemComponentCreator.qqiPi8foC03Ugh7eCWuk((object) this));
        num1 = 17;
      }
label_18:
      return componentMetadataItem1;
    }

    private ObjectFormViewItem CreateObjectFormViewItem()
    {
      ObjectFormViewItem objectFormViewItem = new ObjectFormViewItem();
      AbstractEntitySystemComponentCreator.yW1YNwfosHg6yHbrZ9n7((object) objectFormViewItem, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      AbstractEntitySystemComponentCreator.H8AwNBfozEKkdbG36aul((object) objectFormViewItem, AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(~-397266137 ^ 396943256));
      objectFormViewItem.Type = AbstractEntitySystemComponentCreator.AslFOmfbFpIHdnBdF5ox((object) this);
      AbstractEntitySystemComponentCreator.o6qp64fbB0cVJEb5i3Bj((object) objectFormViewItem, AbstractEntitySystemComponentCreator.EntityPropertyUid);
      AbstractEntitySystemComponentCreator.rJTh5DfbWwKWlQYr8iKs((object) objectFormViewItem, ViewItemLoadingType.AsyncLoading);
      return objectFormViewItem;
    }

    private static ViewModelPropertyMetadata CreateEntityIdProperty()
    {
      ViewModelPropertyMetadata entityIdProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) entityIdProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      entityIdProperty.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883147114);
      entityIdProperty.DisplayName = EleWise.ELMA.SR.T((string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-740338220 ^ -740669766));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) entityIdProperty, Int64Descriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) entityIdProperty, Guid.Empty);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) entityIdProperty, true);
      entityIdProperty.IsSystem = true;
      AbstractEntitySystemComponentCreator.svrE7vfbGnAts1d6jPIt((object) entityIdProperty, false);
      return entityIdProperty;
    }

    private static ViewModelPropertyMetadata CreateEntityTypeUidProperty()
    {
      ViewModelPropertyMetadata entityTypeUidProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) entityTypeUidProperty, Guid.NewGuid());
      entityTypeUidProperty.Name = (string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-675505729 ^ -675706335);
      AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) entityTypeUidProperty, AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(694673736 ^ -23604109 ^ -671799673)));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) entityTypeUidProperty, GuidDescriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) entityTypeUidProperty, Guid.Empty);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) entityTypeUidProperty, true);
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) entityTypeUidProperty, true);
      AbstractEntitySystemComponentCreator.svrE7vfbGnAts1d6jPIt((object) entityTypeUidProperty, false);
      return entityTypeUidProperty;
    }

    private static ViewModelPropertyMetadata CreateHierarchicalProperty()
    {
      ViewModelPropertyMetadata hierarchicalProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) hierarchicalProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      hierarchicalProperty.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979640754);
      hierarchicalProperty.DisplayName = (string) AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978153766));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) hierarchicalProperty, BoolDescriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) hierarchicalProperty, Guid.Empty);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) hierarchicalProperty, true);
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) hierarchicalProperty, true);
      AbstractEntitySystemComponentCreator.svrE7vfbGnAts1d6jPIt((object) hierarchicalProperty, true);
      return hierarchicalProperty;
    }

    private static ViewModelPropertyMetadata CreateParentEntityIdProperty()
    {
      ViewModelPropertyMetadata entityIdProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) entityIdProperty, Guid.NewGuid());
      AbstractEntitySystemComponentCreator.wttJvvfoZpxNOAZRy6jw((object) entityIdProperty, AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(~-122002947 ^ 121670212));
      AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) entityIdProperty, AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-2092274397 << 4 ^ 883148374)));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) entityIdProperty, Int64Descriptor.UID);
      entityIdProperty.SubTypeUid = Guid.Empty;
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) entityIdProperty, true);
      entityIdProperty.IsSystem = true;
      AbstractEntitySystemComponentCreator.svrE7vfbGnAts1d6jPIt((object) entityIdProperty, true);
      return entityIdProperty;
    }

    private static ViewModelPropertyMetadata CreateParentEntityTypeUidProperty()
    {
      ViewModelPropertyMetadata entityTypeUidProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) entityTypeUidProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      AbstractEntitySystemComponentCreator.wttJvvfoZpxNOAZRy6jw((object) entityTypeUidProperty, AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(333888594 ^ 1075625116 ^ 1409225854));
      AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) entityTypeUidProperty, AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(1581325282 << 3 ^ -233976660)));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) entityTypeUidProperty, GuidDescriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) entityTypeUidProperty, Guid.Empty);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) entityTypeUidProperty, true);
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) entityTypeUidProperty, true);
      entityTypeUidProperty.Nullable = true;
      return entityTypeUidProperty;
    }

    private static ViewModelPropertyMetadata CreateIsGroupProperty()
    {
      ViewModelPropertyMetadata isGroupProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) isGroupProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      isGroupProperty.Name = (string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-1350312861 << 3 ^ 2082230280);
      isGroupProperty.DisplayName = (string) AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122118566));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) isGroupProperty, BoolDescriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) isGroupProperty, Guid.Empty);
      isGroupProperty.Input = true;
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) isGroupProperty, true);
      AbstractEntitySystemComponentCreator.svrE7vfbGnAts1d6jPIt((object) isGroupProperty, true);
      return isGroupProperty;
    }

    private ViewModelPropertyMetadata CreateEntityProperty()
    {
      ViewModelPropertyMetadata entityProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) entityProperty, AbstractEntitySystemComponentCreator.EntityPropertyUid);
      AbstractEntitySystemComponentCreator.wttJvvfoZpxNOAZRy6jw((object) entityProperty, AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(1253244298 - 1829393894 ^ -575818882));
      AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) entityProperty, AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-606654180 ^ -606984726)));
      entityProperty.Description = (string) AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-1824388195 ^ -1824055657));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) entityProperty, AnyTypeDescriptor.UID);
      AnyTypeSettings anyTypeSettings = new AnyTypeSettings();
      AbstractEntitySystemComponentCreator.i0F1IgfbQVMP70tgPn6V((object) anyTypeSettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957491418));
      AbstractEntitySystemComponentCreator.Rw14dUfbCDGnxYeu4Q2P((object) entityProperty, (object) anyTypeSettings);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) entityProperty, false);
      entityProperty.IsSystem = true;
      AbstractEntitySystemComponentCreator.aAAMw7fbvpb2ySOjZjr0((object) entityProperty, true);
      AbstractEntitySystemComponentCreator.pAyR3Jfb87pUqLN4XiLr((object) entityProperty, (object) this.CreateEntityComputedValue());
      return entityProperty;
    }

    private static ViewModelPropertyMetadata CreateFormUidProperty()
    {
      ViewModelPropertyMetadata formUidProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) formUidProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      formUidProperty.Name = (string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-630932142 - 1120244082 ^ -1751499186);
      formUidProperty.DisplayName = (string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(1021410165 ^ 1021603509);
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) formUidProperty, StringDescriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) formUidProperty, Guid.Empty);
      AbstractEntitySystemComponentCreator.eJp8MEfbhbDgqk5sP902((object) formUidProperty, true);
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) formUidProperty, true);
      formUidProperty.Nullable = false;
      return formUidProperty;
    }

    private static ViewModelPropertyMetadata CreateHideModeProperty()
    {
      ViewModelPropertyMetadata hideModeProperty = new ViewModelPropertyMetadata();
      AbstractEntitySystemComponentCreator.NVQyd6fovb3uVBndeirl((object) hideModeProperty, AbstractEntitySystemComponentCreator.q1IxisfoacGFQYahAXQA());
      AbstractEntitySystemComponentCreator.wttJvvfoZpxNOAZRy6jw((object) hideModeProperty, AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(572119659 - -337058038 ^ 909501811));
      AbstractEntitySystemComponentCreator.aS8rnNfoIJQyBqtd4Z5N((object) hideModeProperty, AbstractEntitySystemComponentCreator.wmT44HfbEU6yfHxBk3Fv(AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-1217523399 ^ -1217722593)));
      AbstractEntitySystemComponentCreator.MYBI6nfboc68ayWwkTaC((object) hideModeProperty, Int32Descriptor.UID);
      AbstractEntitySystemComponentCreator.SJoiwqfbb36s9SBfqmCp((object) hideModeProperty, Guid.Empty);
      hideModeProperty.Input = true;
      hideModeProperty.Nullable = false;
      AbstractEntitySystemComponentCreator.FjA1Ekfbf0dcnUBWaQLX((object) hideModeProperty, true);
      return hideModeProperty;
    }

    private ComputedValue CreateEntityComputedValue()
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            ScriptMethodInfo scriptMethodInfo = new ScriptMethodInfo();
            AbstractEntitySystemComponentCreator.oRrK8wfbZnxv5D7psw8v((object) scriptMethodInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104869496));
            AbstractEntitySystemComponentCreator.FSmd95fbuCAF3TkwqldR((object) scriptMethodInfo, CodeType.Client);
            AbstractEntitySystemComponentCreator.sHmvupfbIUM2l01XViD1((object) scriptMethodInfo, AbstractEntitySystemComponentCreator.qqiPi8foC03Ugh7eCWuk((object) this));
            str = (string) AbstractEntitySystemComponentCreator.SiYfcQfbVbdOd1TfFkC8((object) scriptMethodInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ComputedValue entityComputedValue = new ComputedValue();
      AbstractEntitySystemComponentCreator.kMtqdOfbSBlAVrCoWKuE((object) entityComputedValue, ComputedValueType.Function);
      AbstractEntitySystemComponentCreator.RIpIXffbi7JMRV7jYnMx((object) entityComputedValue, (object) str);
      return entityComputedValue;
    }

    private static string GetEntityMethod() => z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87669283);

    private static ScriptModule CreateScriptModule(object metadata, object sourceCode)
    {
      ScriptModule scriptModule = new ScriptModule();
      AbstractEntitySystemComponentCreator.kSvOAOfbRXnvhgEDEksy((object) scriptModule, (object) ((NamedMetadata) metadata).Name);
      scriptModule.ModuleName = ((NamedMetadata) metadata).Name;
      AbstractEntitySystemComponentCreator.bNlcmKfbqeIfM5pHlYpv((object) scriptModule, (object) ComponentMetadataHelper.ClientAssemblyName((ComponentMetadata) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541771431)));
      scriptModule.ModuleTypeUid = ComponentClientScriptModuleType.TypeUid;
      AbstractEntitySystemComponentCreator.ExTQWEfbKFnuoc0qFkc6((object) scriptModule, sourceCode);
      AbstractEntitySystemComponentCreator.J40k7HfbXm9ryrJKjJDb((object) scriptModule, (object) string.Empty);
      AbstractEntitySystemComponentCreator.Q1fGXNfbTXQs1N4aAO2q((object) scriptModule, (object) ((ComponentMetadata) metadata).Namespace);
      return scriptModule;
    }

    protected AbstractEntitySystemComponentCreator()
    {
      AbstractEntitySystemComponentCreator.Xqy67cfbkyvFIXCgwRGp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AbstractEntitySystemComponentCreator()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AbstractEntitySystemComponentCreator.EntityPropertyUid = new Guid((string) AbstractEntitySystemComponentCreator.Gktyjpfocp29nKGmfuqt(-1120607109 - 305487170 ^ -1426417491));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool drIF2xfoEqxKhRi81sww() => AbstractEntitySystemComponentCreator.znyihlfoGUfGsPHnLo5e == null;

    internal static AbstractEntitySystemComponentCreator cBRI4FfofeI0L8vFpZbJ() => AbstractEntitySystemComponentCreator.znyihlfoGUfGsPHnLo5e;

    internal static void dtVugsfoQK7I7Viet2IB([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static Guid qqiPi8foC03Ugh7eCWuk([In] object obj0) => ((AbstractEntitySystemComponentCreator) obj0).ComponentUid;

    internal static void NVQyd6fovb3uVBndeirl([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object fdo6pQfo8B0OCV6uQHZ2([In] object obj0) => (object) ((AbstractEntitySystemComponentCreator) obj0).ComponentMetadataName;

    internal static void wttJvvfoZpxNOAZRy6jw([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object GFHcGlfouHVRMOoYrMpe([In] object obj0) => (object) ((AbstractEntitySystemComponentCreator) obj0).ComponentDisplayName;

    internal static void aS8rnNfoIJQyBqtd4Z5N([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object XrKy6JfoVVebn1aZlGKA([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static object ooITjSfoSC1gs1K9sHOG([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object HUlWkVfoiOEIAbH1ynyk([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object YcytbvfoRXqTOgpjYqB8() => (object) AbstractEntitySystemComponentCreator.CreateEntityIdProperty();

    internal static object saOTsEfoqjvhQyXkQvMP() => (object) AbstractEntitySystemComponentCreator.CreateEntityTypeUidProperty();

    internal static object N8V2TLfoKfrpEqXatM2k() => (object) AbstractEntitySystemComponentCreator.CreateHierarchicalProperty();

    internal static object ETv5JZfoXZqic2Hf7nMF() => (object) AbstractEntitySystemComponentCreator.CreateIsGroupProperty();

    internal static object bMafbrfoTn7NMTEOomsy() => (object) AbstractEntitySystemComponentCreator.CreateParentEntityIdProperty();

    internal static object tTFNujfokU8KoqeKBJQO() => (object) AbstractEntitySystemComponentCreator.CreateParentEntityTypeUidProperty();

    internal static object hVagDQfonbGnTNHoFceb() => (object) AbstractEntitySystemComponentCreator.CreateFormUidProperty();

    internal static object hmOwyjfoOWdZl1Gybc3e() => (object) AbstractEntitySystemComponentCreator.CreateHideModeProperty();

    internal static bool e3ux8Nfo2IdspTn8ZwNM([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object cUlX0cfoe55ShqUDAjL2() => (object) CSharpParseOptions.Default;

    internal static object a5LNmkfoPsIkrvHeX6Dg([In] object obj0, [In] LanguageVersion obj1) => (object) ((CSharpParseOptions) obj0).WithLanguageVersion(obj1);

    internal static object LcypNZfo1wO90cNaVPiU([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetRoot(obj1);

    internal static object sqioyQfoNGI7QikBijGb() => (object) AbstractEntitySystemComponentCreator.GetEntityMethod();

    internal static object r5oJEIfo3CFi4LbtdaDh([In] object obj0, [In] int obj1, [In] object obj2) => (object) ((string) obj0).Insert(obj1, (string) obj2);

    internal static object F7i4osfopDkuJGsUn4wK([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static Guid q1IxisfoacGFQYahAXQA() => Guid.NewGuid();

    internal static void f8yPqQfoDWlDbEyq5LhL([In] object obj0, Guid value) => ((ComponentMetadataItem) obj0).Uid = value;

    internal static void R3nn8ofotxTeCSZwugUA([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Metadata = obj1;

    internal static object jQAaSvfowc9vB02nqgUw([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static DateTime vZedaPfo4vcLIGRpJ4to() => DateTime.Now;

    internal static void G57w7efo6ERtk4TaB7qT([In] object obj0, DateTime value) => ((ComponentMetadataItem) obj0).CreationDate = value;

    internal static void phcsY1foHJkeJ6nsqP6b([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).AssemblyVersion = (string) obj1;

    internal static object d06wM9foAk3kg2e6Rxld([In] object obj0) => (object) ComponentMetadataHelper.ServerAssemblyName((ComponentMetadata) obj0);

    internal static object bK7FhAfo7Q5O34TSrl9P([In] object obj0, [In] object obj1) => (object) AbstractEntitySystemComponentCreator.CreateScriptModule(obj0, obj1);

    internal static void nV49DnfoxDdWjIpkgJwE([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).ClientScriptModule = (ScriptModule) obj1;

    internal static Guid pAVGuZfo0S0nWldtETDr([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void CZYa2RfomvDiKMmVUBmP([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).Uid = value;

    internal static object PtgBpjfoykh2aUZJ61hP([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void BD6LOJfoMyCdh5o3nhwd([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object Icu5icfoJXnBdiVCSJlF([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void SYXpfAfo9IhQmFGcIiU4([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object erbbyKfodtnS7CRIwgva([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void gGgvLnfolKiIQ7yUcs7L([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Description = (string) obj1;

    internal static void HKmd6UforAIpUBQd8Zsj([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).ModuleUid = value;

    internal static void yIY00rfogMDxn6W3D2ok([In] object obj0, DateTime value) => ((ComponentMetadataItemHeader) obj0).CreationDate = value;

    internal static void tuA0Z7fo52r7aQIbkoPH([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Published = (ComponentMetadataItem) obj1;

    internal static Guid NQaZQ9fojZZHiZc4LfPA([In] object obj0) => ((ComponentMetadata) obj0).GetMetadataTypeUid();

    internal static void WukmZOfoYyNBcOPLZobO([In] object obj0, Guid value) => ((ComponentMetadataItemHeader) obj0).MetadataTypeUid = value;

    internal static void qNCn5YfoLWqssbMu1yWi([In] object obj0, [In] object obj1) => ((ComponentMetadataItem) obj0).Header = (ComponentMetadataItemHeader) obj1;

    internal static void BdJmqmfoUKKS2DePDGLv([In] object obj0, [In] object obj1) => ((IComponentAssemblyBuilderService) obj0).Build((ComponentBuildAssemblyModel) obj1);

    internal static void yW1YNwfosHg6yHbrZ9n7([In] object obj0, Guid value) => ((ViewItem) obj0).Uid = value;

    internal static object Gktyjpfocp29nKGmfuqt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void H8AwNBfozEKkdbG36aul([In] object obj0, [In] object obj1) => ((ViewItem) obj0).Name = (string) obj1;

    internal static ViewType AslFOmfbFpIHdnBdF5ox([In] object obj0) => ((AbstractEntitySystemComponentCreator) obj0).ViewType;

    internal static void o6qp64fbB0cVJEb5i3Bj([In] object obj0, Guid value) => ((ObjectFormViewItem) obj0).ContextPropertyUid = value;

    internal static void rJTh5DfbWwKWlQYr8iKs([In] object obj0, ViewItemLoadingType value) => ((ObjectFormViewItem) obj0).LoadingType = value;

    internal static void MYBI6nfboc68ayWwkTaC([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static void SJoiwqfbb36s9SBfqmCp([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static void eJp8MEfbhbDgqk5sP902([In] object obj0, bool value) => ((ViewModelPropertyMetadata) obj0).Input = value;

    internal static void svrE7vfbGnAts1d6jPIt([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static object wmT44HfbEU6yfHxBk3Fv([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void FjA1Ekfbf0dcnUBWaQLX([In] object obj0, bool value) => ((PropertyMetadata) obj0).IsSystem = value;

    internal static void i0F1IgfbQVMP70tgPn6V([In] object obj0, [In] object obj1) => ((AnyTypeSettings) obj0).FullTypeName = (string) obj1;

    internal static void Rw14dUfbCDGnxYeu4Q2P([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static void aAAMw7fbvpb2ySOjZjr0([In] object obj0, bool value) => ((ViewModelPropertyMetadata) obj0).ClientOnly = value;

    internal static void pAyR3Jfb87pUqLN4XiLr([In] object obj0, [In] object obj1) => ((ViewModelPropertyMetadata) obj0).ComputedValue = (ComputedValue) obj1;

    internal static void oRrK8wfbZnxv5D7psw8v([In] object obj0, [In] object obj1) => ((ScriptMethodInfo) obj0).Name = (string) obj1;

    internal static void FSmd95fbuCAF3TkwqldR([In] object obj0, CodeType value) => ((ScriptMethodInfo) obj0).CodeType = value;

    internal static void sHmvupfbIUM2l01XViD1([In] object obj0, Guid value) => ((ScriptMethodInfo) obj0).MetadataUid = value;

    internal static object SiYfcQfbVbdOd1TfFkC8([In] object obj0) => (object) ScriptMethodInfoHelper.Serialize((ScriptMethodInfo) obj0);

    internal static void kMtqdOfbSBlAVrCoWKuE([In] object obj0, ComputedValueType value) => ((ComputedValue) obj0).ComputedValueType = value;

    internal static void RIpIXffbi7JMRV7jYnMx([In] object obj0, [In] object obj1) => ((ComputedValue) obj0).MethodName = (string) obj1;

    internal static void kSvOAOfbRXnvhgEDEksy([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ClassName = (string) obj1;

    internal static void bNlcmKfbqeIfM5pHlYpv([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyName = (string) obj1;

    internal static void ExTQWEfbKFnuoc0qFkc6([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).SourceCode = (string) obj1;

    internal static void J40k7HfbXm9ryrJKjJDb([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).References = (string) obj1;

    internal static void Q1fGXNfbTXQs1N4aAO2q([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).Namespace = (string) obj1;

    internal static void Xqy67cfbkyvFIXCgwRGp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static SyntaxToken MMKXttfbnYALFDFY2s41([In] object obj0) => ((BaseTypeDeclarationSyntax) obj0).Identifier;

    internal static bool jVa9AcfbOmdxFjLH8WYR([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
