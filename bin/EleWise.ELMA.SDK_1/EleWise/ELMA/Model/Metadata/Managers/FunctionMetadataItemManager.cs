// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.FunctionMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Actors;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер метаданных функций</summary>
  internal class FunctionMetadataItemManager : 
    EntityManager<FunctionMetadataItem, long>,
    IFunctionMetadataItemManager,
    IEntityManager<FunctionMetadataItem, long>,
    IEntityManager<FunctionMetadataItem>,
    IEntityManager
  {
    private static readonly SyntaxTrivia[] ArgWrapIndent;
    private readonly FetchOptions fetchOptions;
    private readonly IFunctionMetadataItemHeaderManager headerManager;
    private readonly ScriptModuleManager scriptModuleManager;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;
    internal static FunctionMetadataItemManager lQKG4GbcfF1fO1GFIUIZ;

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовков метаданных функций</param>
    /// <param name="scriptModuleManager">Менеджер скриптов</param>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="eventHandlerSubscribeService">Сервис для ручной подписки на события</param>
    public FunctionMetadataItemManager(
      IFunctionMetadataItemHeaderManager headerManager,
      ScriptModuleManager scriptModuleManager,
      IActorModelRuntime actorModelRuntime,
      IEventHandlerSubscribeService eventHandlerSubscribeService)
    {
      FunctionMetadataItemManager.CejwKybcvWdLSGXffTxq();
      this.fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, (string) FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(1012087039 ^ 1012124163));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.headerManager = headerManager;
            num = 4;
            continue;
          case 3:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 4:
            this.scriptModuleManager = scriptModuleManager;
            num = 3;
            continue;
          default:
            this.eventHandlerSubscribeService = eventHandlerSubscribeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Экземпляр менеджера</summary>
    public static FunctionMetadataItemManager Instance => Locator.GetServiceNotNull<FunctionMetadataItemManager>();

    /// <inheritdoc />
    [Transaction]
    public virtual FunctionMetadataItem Create(Guid moduleUid, Guid group, string displayName)
    {
      int num = 6;
      FunctionMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata.ReturnType = new TypeSignature();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            metadata.NamespaceForDisplay = (string) FunctionMetadataItemManager.DKXOCnbcum5V1r0RpOfA(FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(1917256330 ^ 1917061698));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          case 4:
            metadata.DisplayName = displayName;
            num = 7;
            continue;
          case 5:
            metadata.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 4 : 4;
            continue;
          case 6:
            metadata = new FunctionMetadata(moduleUid);
            num = 5;
            continue;
          case 7:
            FunctionMetadataItemManager.MdVl44bcZmefXd4rF9cN((object) metadata, (object) displayName.ToTranslitIdent());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
            continue;
          default:
            FunctionMetadataItemManager.vvlugabcIqLjPwYtV0x1((object) metadata, (object) new TypeSignature());
            num = 3;
            continue;
        }
      }
label_5:
      return this.Create(metadata, (FunctionMetadata) null, string.Empty, group);
    }

    /// <inheritdoc />
    [Transaction]
    public virtual FunctionMetadataItem Copy(Guid headerUid)
    {
      int num1 = 1;
      int num2;
      FunctionMetadataItem functionMetadataItem;
      FunctionMetadata metadata;
      string sourceCode;
      MetadataItemGroupUI metadataItemGroupUi;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = new Random().Next(0, 10000);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            FunctionMetadataItemHeader metadataItemHeader = this.headerManager.Load(headerUid);
            functionMetadataItem = (FunctionMetadataItem) FunctionMetadataItemManager.jhdePhbcVdYZ0Cp5c3of((object) metadataItemHeader);
            FunctionMetadata functionMetadata = (FunctionMetadata) FunctionMetadataItemManager.QWWp30bcSZfjSIpir9v5((object) functionMetadataItem);
            metadata = ClassSerializationHelper.CloneObjectByXml<FunctionMetadata>(functionMetadata);
            FunctionMetadataItemManager.H5cf2IbciySBDxJVg7Fn((object) metadata);
            FunctionMetadataItemManager.p4p39EbcRZNusj3Fst0a((object) metadata, (object) functionMetadata.Namespace);
            FunctionMetadataItemManager.MdVl44bcZmefXd4rF9cN((object) metadata, FunctionMetadataItemManager.Kie57wbcKt8gbqDDfZtf(FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(272623989 ^ 272570991), FunctionMetadataItemManager.EUyQ65bcqQUDL5FhoOXg((object) metadata), (object) num2));
            FunctionMetadataItemManager.fuiefHbcT4ECQLWTmk1D((object) metadata, FunctionMetadataItemManager.Kie57wbcKt8gbqDDfZtf(FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(1669212571 ^ 1669257857), FunctionMetadataItemManager.eDeZWMbcXIkFYspEYFv1((object) metadata), (object) num2));
            sourceCode = (string) FunctionMetadataItemManager.GB6hT7bcna9lTHBDgWXU(FunctionMetadataItemManager.DLohYjbckbKws7IevwbH((object) functionMetadataItem));
            metadataItemGroupUi = (MetadataItemGroupUI) FunctionMetadataItemManager.enef7abcOkH1f07NWCKw((object) metadataItemHeader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      return this.Create(metadata, (FunctionMetadata) FunctionMetadataItemManager.QWWp30bcSZfjSIpir9v5((object) functionMetadataItem), sourceCode, metadataItemGroupUi == null ? Guid.Empty : metadataItemGroupUi.Uid);
    }

    /// <inheritdoc />
    public override void Save(FunctionMetadataItem obj)
    {
      int num = 10;
      string errorMessage;
      FunctionMetadata metadata;
      IUser currentUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              if (FunctionMetadataItemManager.BHfEtEbc22NERYbH4lsB((object) obj) != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            }
            else
            {
              num = 3;
              continue;
            }
          case 2:
            goto label_9;
          case 3:
            goto label_2;
          case 4:
            goto label_12;
          case 5:
            goto label_19;
          case 6:
            base.Save(obj);
            num = 5;
            continue;
          case 7:
            goto label_5;
          case 8:
            FunctionMetadataItemManager.Cv9jnfbcNhbebRXBxpYr((object) obj, FunctionMetadataItemManager.ApL5nxbc1WjBb5pDVv9U());
            num = 6;
            continue;
          case 9:
            metadata = obj.Metadata as FunctionMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
          case 10:
            Contract.ArgumentNotNull((object) obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123673098));
            num = 9;
            continue;
          case 11:
            currentUser = ((IAuthenticationService) FunctionMetadataItemManager.nNElcRbceRNI7uXurI0p((object) this)).GetCurrentUser();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 12 : 5;
            continue;
          case 12:
            obj.CreationAuthorId = (long?) (currentUser != null ? FunctionMetadataItemManager.T5uq4UbcP0wftqV6vasG((object) currentUser) : (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 8 : 3;
            continue;
          default:
            if (this.headerManager.ValidateName(((Entity<long>) FunctionMetadataItemManager.BHfEtEbc22NERYbH4lsB((object) obj)).Id, (string) FunctionMetadataItemManager.EUyQ65bcqQUDL5FhoOXg((object) metadata), out errorMessage))
            {
              if (this.headerManager.ValidateDisplayName(((Entity<long>) FunctionMetadataItemManager.BHfEtEbc22NERYbH4lsB((object) obj)).Id, metadata.DisplayName, out errorMessage))
              {
                num = 11;
                continue;
              }
              goto label_12;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 0;
              continue;
            }
        }
      }
label_19:
      return;
label_2:
      throw new Exception(EleWise.ELMA.SR.T((string) FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(-345420348 ^ -345391530), FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(-1638402543 ^ -1638596917)));
label_5:
      throw new InvalidOperationException(errorMessage);
label_9:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852898824), (object) metadata.DisplayName, FunctionMetadataItemManager.EUyQ65bcqQUDL5FhoOXg((object) metadata)));
label_12:
      throw new InvalidOperationException(errorMessage);
    }

    /// <inheritdoc />
    public virtual UIMetadataPublishResult Publish(Guid headerUid, string comment)
    {
      int num = 1;
      TaskAwaiter<UIMetadataPublishResult> awaiter;
      while (true)
      {
        switch (num)
        {
          case 1:
            awaiter = this.PublishAsync(headerUid, comment).GetAwaiter();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return awaiter.GetResult();
    }

    /// <inheritdoc />
    string IFunctionMetadataItemManager.UpdateScriptCode(
      FunctionMetadata newMetadata,
      FunctionMetadata oldMetadata,
      string newSource)
    {
      return FunctionMetadataItemManager.UpdateScriptCode(newMetadata, oldMetadata, newSource);
    }

    /// <inheritdoc />
    GenerateFunctionCodeResponse IFunctionMetadataItemManager.GenerateCode(
      GenerateFunctionCodeRequest request)
    {
      return (GenerateFunctionCodeResponse) FunctionMetadataItemManager.e07IPWbc3NCviUyTaurv((object) request);
    }

    /// <inheritdoc />
    public IEnumerable<FunctionMetadataItem> GetCandidates(Guid headerUid) => (IEnumerable<FunctionMetadataItem>) this.CreateCriteria(this.fetchOptions, this.ImplementationType).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539405565), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765830210), JoinType.LeftOuterJoin).Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514966549), (object) headerUid)).Add((ICriterion) Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70044175))).List<FunctionMetadataItem>();

    /// <summary>Обновить код функции</summary>
    /// <param name="newMetadata">Новые метаданные</param>
    /// <param name="oldMetadata">Старые метаданные</param>
    /// <param name="newSource">Исходный код функции</param>
    public static string UpdateScriptCode(
      FunctionMetadata newMetadata,
      FunctionMetadata oldMetadata,
      string newSource)
    {
      int num = 1;
      GenerateFunctionCodeRequest functionCodeRequest1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionMetadataItemManager.GA2ZWWbcpHt2W0Yc1wSQ((object) newMetadata, FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(-53329496 >> 4 ^ -3265308));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
          case 9:
            goto label_4;
          case 3:
          case 7:
            functionCodeRequest1.GenerateFullSourceCode = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 1;
            continue;
          case 4:
            if (oldMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 2;
              continue;
            }
            goto case 3;
          case 5:
          case 6:
            FunctionMetadataItemManager.RIOMdvbctvdG6wEEfJWF((object) functionCodeRequest1, FunctionMetadataItemManager.EUyQ65bcqQUDL5FhoOXg((object) oldMetadata));
            num = 12;
            continue;
          case 8:
            if (FunctionMetadataItemManager.urZIACbcDAEwUdujsr2u((object) newSource))
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 10:
            functionCodeRequest1.GenerateParameterType = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 9 : 3;
            continue;
          case 11:
            functionCodeRequest1.GenerateReturnType = true;
            num = 10;
            continue;
          case 12:
            FunctionMetadataItemManager.Jx6CHwbcwfnKcTpyFxdF((object) functionCodeRequest1, true);
            num = 11;
            continue;
          default:
            GenerateFunctionCodeRequest functionCodeRequest2 = new GenerateFunctionCodeRequest();
            FunctionMetadataItemManager.P36oLKbcajyN2bdPlerI((object) functionCodeRequest2, (object) newMetadata);
            functionCodeRequest2.SourceCode = newSource;
            functionCodeRequest1 = functionCodeRequest2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 8 : 5;
            continue;
        }
      }
label_4:
      return ((GenerateFunctionCodeResponse) FunctionMetadataItemManager.e07IPWbc3NCviUyTaurv((object) functionCodeRequest1)).SourceCode;
    }

    /// <summary>Сгенерировать код для функции</summary>
    /// <param name="request">Запрос на генерацию кода функции</param>
    /// <returns>Ответа при генерации кода для функции</returns>
    public static GenerateFunctionCodeResponse GenerateCode(GenerateFunctionCodeRequest request)
    {
      int num1 = 8;
      GenerateFunctionCodeResponse code;
      while (true)
      {
        int num2 = num1;
        MethodDeclarationSyntax declarationSyntax1;
        ParameterListSyntax syntax;
        MethodDeclarationSyntax declarationSyntax2;
        while (true)
        {
          ParameterSyntax parameterSyntax;
          string typeName1;
          TypeSyntax typeSyntax;
          TypeSyntax node;
          ClassDeclarationSyntax declarationSyntax3;
          SyntaxToken syntaxToken1;
          ClassDeclarationSyntax[] array;
          FunctionMetadata functionMetadata;
          string typeName2;
          SeparatedSyntaxList<ParameterSyntax> parameters;
          SyntaxTrivia[] syntaxTriviaArray1;
          SyntaxTrivia[] syntaxTriviaArray2;
          string newName;
          string oldName;
          switch (num2)
          {
            case 1:
              if (declarationSyntax1 != null)
              {
                num2 = 44;
                continue;
              }
              goto label_34;
            case 2:
              parameterSyntax = parameters.FirstOrDefault();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 25 : 29;
              continue;
            case 3:
              if (FunctionMetadataItemManager.cvgCPrbcMH6i1ayCmdIk((object) request))
              {
                num2 = 40;
                continue;
              }
              goto case 12;
            case 4:
            case 5:
            case 17:
              goto label_18;
            case 6:
              oldName = (string) FunctionMetadataItemManager.jNBxPEbcmhlYBHPhLKai((object) request.OldName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751265732));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 10 : 27;
              continue;
            case 7:
              GenerateFunctionCodeResponse functionCodeResponse = new GenerateFunctionCodeResponse();
              FunctionMetadataItemManager.ij2hpXbcHwf5SrTUIOcj((object) functionCodeResponse, FunctionMetadataItemManager.V6qHrObc6w4hZY5Rj0Is((object) request));
              code = functionCodeResponse;
              num2 = 21;
              continue;
            case 8:
              functionMetadata = (FunctionMetadata) FunctionMetadataItemManager.ONJ1L0bc4QpwLDOhaZTg((object) request);
              num2 = 7;
              continue;
            case 9:
              goto label_21;
            case 10:
              if (declarationSyntax3 != null)
              {
                num2 = 36;
                continue;
              }
              goto label_12;
            case 11:
              if (FunctionMetadataItemManager.bUnCYbbcr6o8gsRvIUHZ((object) typeName1, FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(95909607 + 343705423 ^ 439435786)))
              {
                num2 = 20;
                continue;
              }
              goto case 42;
            case 12:
              if (!request.GenerateParameterType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 33 : 0;
                continue;
              }
              goto case 23;
            case 13:
              declarationSyntax3 = ((IEnumerable<ClassDeclarationSyntax>) array).FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num3 = 1;
                SyntaxToken syntaxToken2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken2 = FunctionMetadataItemManager.\u003C\u003Ec__DisplayClass19_0.N0rrcZCMjahlURKP3tW4((object) q);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                return syntaxToken2.ToString() == newName;
              }));
              num2 = 26;
              continue;
            case 14:
              declarationSyntax1 = declarationSyntax1.ReplaceNode<MethodDeclarationSyntax>((SyntaxNode) declarationSyntax1.ReturnType, (SyntaxNode) ((TypeSyntax) FunctionMetadataItemManager.Lg5E7nbc9mlw3nvJQx5F((object) typeName2, 0, true)).WithTriviaFrom<TypeSyntax>((SyntaxNode) FunctionMetadataItemManager.WKXCHZbcdUlrXuAgpa3Y((object) declarationSyntax1)));
              num2 = 12;
              continue;
            case 15:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 16:
              typeSyntax = SyntaxFactory.ParseTypeName(typeName1).WithTriviaFrom<TypeSyntax>((SyntaxNode) parameterSyntax.Type);
              num2 = 34;
              continue;
            case 18:
              goto label_44;
            case 19:
            case 46:
              IEnumerable<MethodDeclarationSyntax> source = root1.DescendantNodes().OfType<MethodDeclarationSyntax>();
              // ISSUE: reference to a compiler-generated field
              Func<MethodDeclarationSyntax, bool> func = FunctionMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__19_0;
              Func<MethodDeclarationSyntax, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                FunctionMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__19_0 = predicate = (Func<MethodDeclarationSyntax, bool>) (q =>
                {
                  int num4 = 1;
                  SyntaxToken syntaxToken3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        syntaxToken3 = FunctionMetadataItemManager.\u003C\u003Ec.hBEOsKCJGGunAgDIU98F((object) q);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  return FunctionMetadataItemManager.\u003C\u003Ec.Tuw0HnCJERJyBIHJ9abL((object) syntaxToken3.ToString(), FunctionMetadataItemManager.\u003C\u003Ec.pqg2yBCJbcix5gP6ovVv(-420743386 ^ -420917930));
                });
              }
              else
                goto label_65;
label_62:
              declarationSyntax1 = source.FirstOrDefault<MethodDeclarationSyntax>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
              continue;
label_65:
              predicate = func;
              goto label_62;
            case 20:
              syntax = ((ParameterListSyntax) FunctionMetadataItemManager.RQgNFLbcg5Jkq3mlRoZr((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153885645), 0, (object) null, true)).WithTriviaFrom<ParameterListSyntax>((SyntaxNode) FunctionMetadataItemManager.j458a8bc5WSuNEMEPGCG((object) declarationSyntax1));
              num2 = 4;
              continue;
            case 21:
              if (!FunctionMetadataItemManager.grfnEtbcAQabW4ni1MK5((object) request))
              {
                if (FunctionMetadataItemManager.DRpHXdbc0wYmU4c7WLkO((object) CSharpSyntaxTree.ParseText((string) FunctionMetadataItemManager.V6qHrObc6w4hZY5Rj0Is((object) request), ((CSharpParseOptions) FunctionMetadataItemManager.DQncOsbcxvyAtgUJM0qF()).WithLanguageVersion(LanguageVersion.CSharp7), "", (Encoding) null, (ImmutableDictionary<string, ReportDiagnostic>) null, new CancellationToken()), new CancellationToken()) is CompilationUnitSyntax root1)
                {
                  if (!request.GenerateName)
                  {
                    num2 = 19;
                    continue;
                  }
                  goto case 15;
                }
                else
                {
                  num2 = 48;
                  continue;
                }
              }
              else
                goto label_54;
            case 22:
              if (FunctionMetadataItemManager.xiW9brbcYcbosb0ab4Y5((object) ((SyntaxNode) FunctionMetadataItemManager.WKXCHZbcdUlrXuAgpa3Y((object) declarationSyntax1)).GetText()) + ((SourceText) FunctionMetadataItemManager.bdSqR6bcLJAqH2T5fSce((object) node, (object) null, SourceHashAlgorithm.Sha1)).Length > 91)
              {
                num2 = 32;
                continue;
              }
              goto case 43;
            case 23:
              typeName1 = FunctionScriptModuleType.GetTypeName((TypeSignature) FunctionMetadataItemManager.cSwmx6bclvl0ZNIVssFm((object) functionMetadata));
              num2 = 11;
              continue;
            case 24:
              node = (TypeSyntax) FunctionMetadataItemManager.Lg5E7nbc9mlw3nvJQx5F((object) typeName1, 0, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 16 : 22;
              continue;
            case 25:
              if (declarationSyntax3 != null)
              {
                num2 = 49;
                continue;
              }
              goto case 30;
            case 26:
              if (declarationSyntax3 == null)
              {
                num2 = 35;
                continue;
              }
              goto case 19;
            case 27:
              declarationSyntax3 = ((IEnumerable<ClassDeclarationSyntax>) array).FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num5 = 1;
                SyntaxToken identifier;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      identifier = q.Identifier;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                return FunctionMetadataItemManager.\u003C\u003Ec__DisplayClass19_1.KyKlUpCMcjE5iTxiQ5jk((object) identifier.ToString(), (object) oldName);
              }));
              num2 = 25;
              continue;
            case 28:
              syntaxToken1 = FunctionMetadataItemManager.tQOqKAbcUnWGHD9ETs7T(FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(572119659 - -337058038 ^ 909268717));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 27 : 31;
              continue;
            case 29:
              if (parameterSyntax == null)
                goto case 24;
              else
                goto label_4;
            case 30:
              declarationSyntax3 = ((IEnumerable<ClassDeclarationSyntax>) array).FirstOrDefault<ClassDeclarationSyntax>((Func<ClassDeclarationSyntax, bool>) (q =>
              {
                int num6 = 1;
                SyntaxToken syntaxToken4;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      syntaxToken4 = FunctionMetadataItemManager.\u003C\u003Ec.dDCHR1CJorRwT2mfZXnB((object) q);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_3;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return FunctionMetadataItemManager.\u003C\u003Ec.gpWphQCJhrrc5B4pXaMd((object) syntaxToken4.ToString(), FunctionMetadataItemManager.\u003C\u003Ec.pqg2yBCJbcix5gP6ovVv(1917998801 >> 2 ^ 479621224));
              }));
              num2 = 10;
              continue;
            case 31:
              syntax = SyntaxFactory.ParameterList(SyntaxFactory.SingletonSeparatedList<ParameterSyntax>((ParameterSyntax) FunctionMetadataItemManager.J9YXRObcjJT2bai2YaLt((object) SyntaxFactory.Parameter(syntaxToken1.WithLeadingTrivia(SyntaxFactory.Space)), (object) node.WithLeadingTrivia<TypeSyntax>(syntaxTriviaArray1))));
              num2 = 17;
              continue;
            case 32:
              syntaxTriviaArray2 = FunctionMetadataItemManager.ArgWrapIndent;
              break;
            case 33:
            case 38:
              root1 = root1.ReplaceNode<CompilationUnitSyntax>((SyntaxNode) declarationSyntax2, (SyntaxNode) declarationSyntax1.WithTriviaFrom<MethodDeclarationSyntax>((SyntaxNode) declarationSyntax2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 25 : 41;
              continue;
            case 34:
              syntax = ((ParameterListSyntax) FunctionMetadataItemManager.j458a8bc5WSuNEMEPGCG((object) declarationSyntax2)).WithParameters(SyntaxFactory.SingletonSeparatedList<ParameterSyntax>((ParameterSyntax) FunctionMetadataItemManager.J9YXRObcjJT2bai2YaLt((object) parameterSyntax, (object) typeSyntax)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 5 : 5;
              continue;
            case 35:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 6;
              continue;
            case 36:
            case 49:
              CompilationUnitSyntax root2 = root1;
              SyntaxToken oldToken = FunctionMetadataItemManager.I6Ug48bcykCNgOtwGKrD((object) declarationSyntax3);
              syntaxToken1 = SyntaxFactory.Identifier(newName);
              SyntaxToken newToken = syntaxToken1.WithTriviaFrom(FunctionMetadataItemManager.I6Ug48bcykCNgOtwGKrD((object) declarationSyntax3));
              root1 = root2.ReplaceToken<CompilationUnitSyntax>(oldToken, newToken);
              num2 = 46;
              continue;
            case 37:
              array = root1.DescendantNodes().OfType<ClassDeclarationSyntax>().ToArray<ClassDeclarationSyntax>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 9 : 13;
              continue;
            case 39:
              goto label_34;
            case 40:
              typeName2 = FunctionScriptModuleType.GetTypeName((TypeSignature) FunctionMetadataItemManager.tfaYOMbcJ22Uh9QrEOPB((object) functionMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 7 : 14;
              continue;
            case 41:
              FunctionMetadataItemManager.ij2hpXbcHwf5SrTUIOcj((object) code, (object) root1.ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 18 : 5;
              continue;
            case 42:
              parameters = ((BaseParameterListSyntax) FunctionMetadataItemManager.j458a8bc5WSuNEMEPGCG((object) declarationSyntax2)).Parameters;
              num2 = 2;
              continue;
            case 43:
              syntaxTriviaArray2 = Array.Empty<SyntaxTrivia>();
              break;
            case 44:
              declarationSyntax2 = declarationSyntax1;
              num2 = 3;
              continue;
            case 45:
              goto label_12;
            case 47:
              FunctionMetadataItemManager.ij2hpXbcHwf5SrTUIOcj((object) code, FunctionMetadataItemManager.GxORaXbc7xgsJYIDgOX3((object) functionMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 9;
              continue;
            case 48:
              goto label_6;
            default:
              newName = (string) FunctionMetadataItemManager.jNBxPEbcmhlYBHPhLKai((object) functionMetadata.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317603060));
              num2 = 37;
              continue;
          }
          syntaxTriviaArray1 = syntaxTriviaArray2;
          num2 = 28;
        }
label_4:
        num1 = 16;
        continue;
label_18:
        declarationSyntax1 = declarationSyntax1.ReplaceNode<MethodDeclarationSyntax>((SyntaxNode) FunctionMetadataItemManager.j458a8bc5WSuNEMEPGCG((object) declarationSyntax1), (SyntaxNode) syntax.WithTriviaFrom<ParameterListSyntax>((SyntaxNode) FunctionMetadataItemManager.j458a8bc5WSuNEMEPGCG((object) declarationSyntax2)));
        num1 = 38;
        continue;
label_54:
        num1 = 47;
      }
label_6:
      return code;
label_12:
      return code;
label_21:
      return code;
label_34:
      return code;
label_44:
      return code;
    }

    private FunctionMetadataItem Create(
      FunctionMetadata metadata,
      FunctionMetadata oldMetadata,
      string sourceCode,
      Guid group)
    {
      int num1 = 25;
      FunctionMetadataItem functionMetadataItem;
      while (true)
      {
        int num2 = num1;
        ScriptModule scriptModule;
        FunctionMetadataItemHeader metadataItemHeader;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              FunctionMetadataItemManager.yqf0bgbzW13inkYJt43n((object) scriptModule, FunctionMetadataItemManager.WbEgr1bzBQE6bL9VUs1j((object) metadata));
              num2 = 18;
              continue;
            case 2:
              goto label_8;
            case 3:
              metadataItemHeader.CreationAuthorId = functionMetadataItem.CreationAuthorId;
              num2 = 26;
              continue;
            case 4:
              metadataItemHeader = this.headerManager.Create();
              num2 = 5;
              continue;
            case 5:
              FunctionMetadataItemManager.BxMeUMbzETN5lxT5wOsW((object) metadataItemHeader, metadata.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 20;
              continue;
            case 6:
              FunctionMetadataItemManager.g5OuvobzF7FmjWiHa9qD((object) scriptModule, FunctionMetadataItemManager.kR7iKcbczBYIFFp2ph3P((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
              continue;
            case 7:
              FunctionMetadataItemManager.Coh7NxbzGY1FA3FVxruP((object) functionMetadataItem, (object) scriptModule);
              num2 = 4;
              continue;
            case 8:
              metadataItemHeader.Description = (string) FunctionMetadataItemManager.Gh2oiJbzQPTMhyvJdsHY((object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 9 : 3;
              continue;
            case 9:
              FunctionMetadataItemManager.yuNZxIbzvLLaLPQ5fIg4((object) metadataItemHeader, FunctionMetadataItemManager.voitfwbzCyv01BNYytRE((object) metadata));
              num2 = 3;
              continue;
            case 10:
              FunctionMetadataItemManager.AL1rYTbzZIFVQpt0UymB((object) metadataItemHeader, (object) functionMetadataItem);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 12 : 13;
              continue;
            case 11:
              FunctionMetadataItemManager.MVNjxfbzIgWqvGa4rqe6((object) functionMetadataItem, (object) metadataItemHeader);
              num2 = 21;
              continue;
            case 12:
              goto label_14;
            case 13:
              metadataItemHeader.Group = ((AbstractNHEntityManager<MetadataItemGroupUI, long>) FunctionMetadataItemManager.f1Erxfbzufh49gR057AP()).LoadOrNull(group);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 11 : 4;
              continue;
            case 14:
              scriptModule.ModuleTypeUid = FunctionScriptModuleType.UID;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 6 : 5;
              continue;
            case 15:
              metadata.ScriptUid = new Guid?(FunctionMetadataItemManager.uXMByjbcc3icJHo44J8e((object) scriptModule));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 9 : 14;
              continue;
            case 16:
              FunctionMetadataItemManager.GxUkxrbzfZHyTJcs36xy((object) metadataItemHeader, FunctionMetadataItemManager.eDeZWMbcXIkFYspEYFv1((object) metadata));
              num2 = 8;
              continue;
            case 17:
              user = (IUser) FunctionMetadataItemManager.JPDxwLbcs8ndEeB54h9B(FunctionMetadataItemManager.nNElcRbceRNI7uXurI0p((object) this));
              num2 = 19;
              continue;
            case 18:
              FunctionMetadataItemManager.aHMQJxbzbDxZ70Bnt5ce((object) scriptModule, FunctionMetadataItemManager.oFJ8vobzoAwH26uvQoeN((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 10 : 23;
              continue;
            case 19:
              functionMetadataItem.CreationAuthorId = (long?) (user != null ? FunctionMetadataItemManager.T5uq4UbcP0wftqV6vasG((object) user) : (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 22 : 19;
              continue;
            case 20:
              metadataItemHeader.Name = metadata.Name;
              num2 = 16;
              continue;
            case 21:
              base.Save(functionMetadataItem);
              num2 = 2;
              continue;
            case 22:
              FunctionMetadataItemManager.Cv9jnfbcNhbebRXBxpYr((object) functionMetadataItem, DateTime.Now);
              num2 = 12;
              continue;
            case 23:
              scriptModule.ModuleName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195813323);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 24:
              functionMetadataItem.Metadata = (object) metadata;
              num2 = 17;
              continue;
            case 25:
              functionMetadataItem = this.Create();
              num2 = 24;
              continue;
            case 26:
              FunctionMetadataItemManager.dI02Zcbz8mXZraZ5eMFu((object) metadataItemHeader, functionMetadataItem.CreationDate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 9 : 10;
              continue;
            default:
              scriptModule.SourceCode = (string) FunctionMetadataItemManager.RZyM27bzhlxV8KYWAnqV((object) metadata, (object) oldMetadata, (object) sourceCode);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 5;
              continue;
          }
        }
label_14:
        scriptModule = this.scriptModuleManager.Create();
        num1 = 15;
      }
label_8:
      return functionMetadataItem;
    }

    /// <summary>Опубликовать функцию</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="comment">Комментарий</param>
    /// <returns>Результат публикации</returns>
    private async Task<UIMetadataPublishResult> PublishAsync(Guid headerUid, string comment)
    {
      int num1 = 1;
      int num2;
      UIMetadataPublishResult result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
              int num3;
              switch (num2)
              {
                case 0:
                case 1:
label_10:
                  num3 = 3;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                  {
                    num3 = 1;
                    break;
                  }
                  break;
                default:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
                  break;
              }
              FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler handler;
              IDisposable disposable;
              IFunctionMetadataPublishingActor actor;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    actor = this.actorModelRuntime.GetActor<IFunctionMetadataPublishingActor>(headerUid);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    disposable = (IDisposable) FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21.P2SuP9CJvi4D65Npg104((object) this.eventHandlerSubscribeService, (object) handler);
                    num3 = 4;
                    continue;
                  case 3:
                    goto label_12;
                  case 4:
                    goto label_10;
                  default:
                    handler = new FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler(actor, headerUid);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
                    continue;
                }
              }
label_12:
              try
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
label_16:
                try
                {
                  int num5;
                  if (num2 != 0)
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                  else
                    goto label_37;
label_20:
                  TaskAwaiter taskAwaiter1;
                  TaskAwaiter awaiter1;
                  while (true)
                  {
                    TaskAwaiter<UIMetadataPublishResult> taskAwaiter2;
                    int num6;
                    TaskAwaiter<UIMetadataPublishResult> awaiter2;
                    switch (num5)
                    {
                      case 1:
                        if (num2 != 1)
                        {
                          num5 = 11;
                          continue;
                        }
                        goto case 6;
                      case 2:
                      case 20:
                        result = awaiter2.GetResult();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 15 : 7;
                        continue;
                      case 3:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 12 : 0;
                        continue;
                      case 4:
                        awaiter2 = handler.Wait.GetAwaiter();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                        continue;
                      case 5:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 1;
                        num5 = 19;
                        continue;
                      case 6:
                        awaiter2 = taskAwaiter2;
                        num5 = 18;
                        continue;
                      case 7:
                        goto label_59;
                      case 8:
                        goto label_54;
                      case 9:
                        taskAwaiter1 = new TaskAwaiter();
                        num5 = 14;
                        continue;
                      case 10:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 20;
                        continue;
                      case 11:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        awaiter1 = FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21.BnZPIXCJZ3sP6nRbykC3(FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21.SRblXrCJ856EHLATAfCv((object) actor, (object) comment));
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 22;
                        continue;
                      case 12:
                        taskAwaiter1 = awaiter1;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 11 : 17;
                        continue;
                      case 13:
                        awaiter1.GetResult();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 4 : 4;
                        continue;
                      case 14:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num5 = 13;
                        continue;
                      case 15:
                        goto label_63;
                      case 16:
                        goto label_37;
                      case 17:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21>(ref awaiter1, this);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 7 : 6;
                        continue;
                      case 18:
                        taskAwaiter2 = new TaskAwaiter<UIMetadataPublishResult>();
                        num5 = 10;
                        continue;
                      case 19:
                        taskAwaiter2 = awaiter2;
                        num6 = 21;
                        break;
                      case 21:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UIMetadataPublishResult>, FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21>(ref awaiter2, this);
                        num6 = 8;
                        break;
                      case 22:
                        if (!awaiter1.IsCompleted)
                        {
                          num5 = 3;
                          continue;
                        }
                        goto case 13;
                      default:
                        if (awaiter2.IsCompleted)
                        {
                          num5 = 2;
                          continue;
                        }
                        goto case 5;
                    }
                    num5 = num6;
                  }
label_59:
                  return;
label_54:
                  return;
label_37:
                  awaiter1 = taskAwaiter1;
                  num5 = 9;
                  goto label_20;
                }
                catch (NoServerCompatibleWithActorException ex)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                    num7 = 0;
                  switch (num7)
                  {
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      throw new NoServerCompatibleWithActorException((string) FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21.soJSMpCJIFwhyvcdBT0f(FunctionMetadataItemManager.\u003CPublishAsync\u003Ed__21.XN1JMbCJuKD2wFu04Bt0(1917998801 >> 2 ^ 479328688)), (Exception) ex);
                  }
                }
              }
              finally
              {
                if (num2 < 0)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        disposable.Dispose();
                        num8 = 2;
                        continue;
                      case 2:
                      case 3:
                        goto label_56;
                      default:
                        if (disposable == null)
                        {
                          num8 = 3;
                          continue;
                        }
                        goto case 1;
                    }
                  }
                }
label_56:;
              }
            }
            catch (Exception ex)
            {
              int num9 = 2;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    goto label_51;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
                    continue;
                }
              }
label_51:
              return;
            }
          case 3:
label_63:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 5 : 5;
            continue;
          case 4:
            goto label_62;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 4;
            continue;
          default:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 1;
            continue;
        }
      }
label_62:;
    }

    static FunctionMetadataItemManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionMetadataItemManager.CejwKybcvWdLSGXffTxq();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FunctionMetadataItemManager.ArgWrapIndent = new SyntaxTrivia[2]
            {
              FunctionMetadataItemManager.UrlFM6bzVFL703PVOoTv(),
              FunctionMetadataItemManager.aNDgUnbzSefgvk3NIi7c(FunctionMetadataItemManager.Tp0tH9bc8XtUgQlOpZEU(-1858887263 ^ -1859052055))
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void CejwKybcvWdLSGXffTxq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Tp0tH9bc8XtUgQlOpZEU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool rJrMewbcQUktLJ2NFgEC() => FunctionMetadataItemManager.lQKG4GbcfF1fO1GFIUIZ == null;

    internal static FunctionMetadataItemManager RIMwxobcCIeLj29BV0mw() => FunctionMetadataItemManager.lQKG4GbcfF1fO1GFIUIZ;

    internal static void MdVl44bcZmefXd4rF9cN([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object DKXOCnbcum5V1r0RpOfA([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void vvlugabcIqLjPwYtV0x1([In] object obj0, [In] object obj1) => ((FunctionMetadata) obj0).ParameterType = (TypeSignature) obj1;

    internal static object jhdePhbcVdYZ0Cp5c3of([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Draft;

    internal static object QWWp30bcSZfjSIpir9v5([In] object obj0) => ((FunctionMetadataItem) obj0).Metadata;

    internal static void H5cf2IbciySBDxJVg7Fn([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static void p4p39EbcRZNusj3Fst0a([In] object obj0, [In] object obj1) => ((FunctionMetadata) obj0).Namespace = (string) obj1;

    internal static object EUyQ65bcqQUDL5FhoOXg([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object Kie57wbcKt8gbqDDfZtf([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object eDeZWMbcXIkFYspEYFv1([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void fuiefHbcT4ECQLWTmk1D([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object DLohYjbckbKws7IevwbH([In] object obj0) => (object) ((FunctionMetadataItem) obj0).ScriptModule;

    internal static object GB6hT7bcna9lTHBDgWXU([In] object obj0) => (object) ((ScriptModule) obj0).SourceCode;

    internal static object enef7abcOkH1f07NWCKw([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Group;

    internal static object BHfEtEbc22NERYbH4lsB([In] object obj0) => (object) ((FunctionMetadataItem) obj0).Header;

    internal static object nNElcRbceRNI7uXurI0p([In] object obj0) => (object) ((EntityManager<FunctionMetadataItem, long>) obj0).AuthenticationService;

    internal static object T5uq4UbcP0wftqV6vasG([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static DateTime ApL5nxbc1WjBb5pDVv9U() => DateTime.Now;

    internal static void Cv9jnfbcNhbebRXBxpYr([In] object obj0, DateTime value) => ((FunctionMetadataItem) obj0).CreationDate = value;

    internal static object e07IPWbc3NCviUyTaurv([In] object obj0) => (object) FunctionMetadataItemManager.GenerateCode((GenerateFunctionCodeRequest) obj0);

    internal static void GA2ZWWbcpHt2W0Yc1wSQ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void P36oLKbcajyN2bdPlerI([In] object obj0, [In] object obj1) => ((GenerateFunctionCodeRequest) obj0).Function = (FunctionMetadata) obj1;

    internal static bool urZIACbcDAEwUdujsr2u([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void RIOMdvbctvdG6wEEfJWF([In] object obj0, [In] object obj1) => ((GenerateFunctionCodeRequest) obj0).OldName = (string) obj1;

    internal static void Jx6CHwbcwfnKcTpyFxdF([In] object obj0, bool value) => ((GenerateFunctionCodeRequest) obj0).GenerateName = value;

    internal static object ONJ1L0bc4QpwLDOhaZTg([In] object obj0) => (object) ((GenerateFunctionCodeRequest) obj0).Function;

    internal static object V6qHrObc6w4hZY5Rj0Is([In] object obj0) => (object) ((GenerateFunctionCodeRequest) obj0).SourceCode;

    internal static void ij2hpXbcHwf5SrTUIOcj([In] object obj0, [In] object obj1) => ((GenerateFunctionCodeResponse) obj0).SourceCode = (string) obj1;

    internal static bool grfnEtbcAQabW4ni1MK5([In] object obj0) => ((GenerateFunctionCodeRequest) obj0).GenerateFullSourceCode;

    internal static object GxORaXbc7xgsJYIDgOX3([In] object obj0) => (object) FunctionScriptModuleType.GenerateSourceCode((FunctionMetadata) obj0);

    internal static object DQncOsbcxvyAtgUJM0qF() => (object) CSharpParseOptions.Default;

    internal static object DRpHXdbc0wYmU4c7WLkO([In] object obj0, [In] CancellationToken obj1) => (object) ((SyntaxTree) obj0).GetRoot(obj1);

    internal static object jNBxPEbcmhlYBHPhLKai([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static SyntaxToken I6Ug48bcykCNgOtwGKrD([In] object obj0) => ((BaseTypeDeclarationSyntax) obj0).Identifier;

    internal static bool cvgCPrbcMH6i1ayCmdIk([In] object obj0) => ((GenerateFunctionCodeRequest) obj0).GenerateReturnType;

    internal static object tfaYOMbcJ22Uh9QrEOPB([In] object obj0) => (object) ((FunctionMetadata) obj0).ReturnType;

    internal static object Lg5E7nbc9mlw3nvJQx5F([In] object obj0, [In] int obj1, [In] bool obj2) => (object) SyntaxFactory.ParseTypeName((string) obj0, obj1, obj2);

    internal static object WKXCHZbcdUlrXuAgpa3Y([In] object obj0) => (object) ((MethodDeclarationSyntax) obj0).ReturnType;

    internal static object cSwmx6bclvl0ZNIVssFm([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static bool bUnCYbbcr6o8gsRvIUHZ([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object RQgNFLbcg5Jkq3mlRoZr([In] object obj0, [In] int obj1, [In] object obj2, [In] bool obj3) => (object) SyntaxFactory.ParseParameterList((string) obj0, obj1, (ParseOptions) obj2, obj3);

    internal static object j458a8bc5WSuNEMEPGCG([In] object obj0) => (object) ((BaseMethodDeclarationSyntax) obj0).ParameterList;

    internal static object J9YXRObcjJT2bai2YaLt([In] object obj0, [In] object obj1) => (object) ((ParameterSyntax) obj0).WithType((TypeSyntax) obj1);

    internal static int xiW9brbcYcbosb0ab4Y5([In] object obj0) => ((SourceText) obj0).Length;

    internal static object bdSqR6bcLJAqH2T5fSce([In] object obj0, [In] object obj1, [In] SourceHashAlgorithm obj2) => (object) ((SyntaxNode) obj0).GetText((Encoding) obj1, obj2);

    internal static SyntaxToken tQOqKAbcUnWGHD9ETs7T([In] object obj0) => SyntaxFactory.Identifier((string) obj0);

    internal static object JPDxwLbcs8ndEeB54h9B([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static Guid uXMByjbcc3icJHo44J8e([In] object obj0) => ((ScriptModule) obj0).Uid;

    internal static object kR7iKcbczBYIFFp2ph3P([In] object obj0) => (object) FunctionMetadataHelper.ExecutorName((FunctionMetadata) obj0);

    internal static void g5OuvobzF7FmjWiHa9qD([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ClassName = (string) obj1;

    internal static object WbEgr1bzBQE6bL9VUs1j([In] object obj0) => (object) FunctionMetadataHelper.ServerAssemblyName((FunctionMetadata) obj0);

    internal static void yqf0bgbzW13inkYJt43n([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyName = (string) obj1;

    internal static object oFJ8vobzoAwH26uvQoeN([In] object obj0) => (object) ((FunctionMetadata) obj0).Namespace;

    internal static void aHMQJxbzbDxZ70Bnt5ce([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).Namespace = (string) obj1;

    internal static object RZyM27bzhlxV8KYWAnqV([In] object obj0, [In] object obj1, [In] object obj2) => (object) FunctionMetadataItemManager.UpdateScriptCode((FunctionMetadata) obj0, (FunctionMetadata) obj1, (string) obj2);

    internal static void Coh7NxbzGY1FA3FVxruP([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static void BxMeUMbzETN5lxT5wOsW([In] object obj0, Guid value) => ((FunctionMetadataItemHeader) obj0).Uid = value;

    internal static void GxUkxrbzfZHyTJcs36xy([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static object Gh2oiJbzQPTMhyvJdsHY([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static Guid voitfwbzCyv01BNYytRE([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void yuNZxIbzvLLaLPQ5fIg4([In] object obj0, Guid value) => ((FunctionMetadataItemHeader) obj0).ModuleUid = value;

    internal static void dI02Zcbz8mXZraZ5eMFu([In] object obj0, DateTime value) => ((FunctionMetadataItemHeader) obj0).CreationDate = value;

    internal static void AL1rYTbzZIFVQpt0UymB([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Draft = (FunctionMetadataItem) obj1;

    internal static object f1Erxfbzufh49gR057AP() => (object) MetadataItemGroupUIManager.Instance;

    internal static void MVNjxfbzIgWqvGa4rqe6([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).Header = (FunctionMetadataItemHeader) obj1;

    internal static SyntaxTrivia UrlFM6bzVFL703PVOoTv() => SyntaxFactory.LineFeed;

    internal static SyntaxTrivia aNDgUnbzSefgvk3NIi7c([In] object obj0) => SyntaxFactory.Whitespace((string) obj0);

    /// <summary>Событие публикации функции</summary>
    private sealed class FunctionMetadataPublishingEventHandler : 
      IFunctionMetadataPublishingEventHandler,
      IEventHandler
    {
      private readonly object actor;
      private readonly Guid headerUid;
      private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;
      internal static object Wm5CcaCMx2y2QgiybsE5;

      /// <summary>Ctor</summary>
      /// <param name="actor">Актор публикации</param>
      /// <param name="headerUid">Уникальный идентификатор заголовка функции</param>
      public FunctionMetadataPublishingEventHandler(
        IFunctionMetadataPublishingActor actor,
        Guid headerUid)
      {
        FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.Ba73XgCMyOhPUp5H78wy();
        this.taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.actor = (object) actor;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              continue;
            default:
              this.headerUid = headerUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public Task Complete(Guid functionMetadataUid, UIMetadataPublishResult result)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.ibq4bmCMM9HTVhZLtRea(this.headerUid, functionMetadataUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              this.taskCompletionSource.TrySetResult(result);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_4;
          }
        }
label_4:
        return (Task) FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.ibag4PCMJXeSkrKZ4wB5();
label_6:
        return (Task) FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.Os6HM7CM9NYkvJSeo7kS(this.actor);
      }

      /// <inheritdoc />
      public Task Error(Guid functionMetadataUid, Exception exception)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.ibq4bmCMM9HTVhZLtRea(this.headerUid, functionMetadataUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            case 3:
              goto label_6;
            default:
              FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.iNQmORCMdAo9NhRPpukO((object) this.taskCompletionSource, (object) exception);
              num = 3;
              continue;
          }
        }
label_4:
        return (Task) FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.ibag4PCMJXeSkrKZ4wB5();
label_6:
        return (Task) FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.Os6HM7CM9NYkvJSeo7kS(this.actor);
      }

      /// <summary>Задача ожидания завершения публикации</summary>
      public Task<UIMetadataPublishResult> Wait => this.taskCompletionSource.Task;

      internal static void Ba73XgCMyOhPUp5H78wy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool kBok6kCM0AQTGhGYByr8() => FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.Wm5CcaCMx2y2QgiybsE5 == null;

      internal static FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler xXBAsjCMmXqvygcjpcRC() => (FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler) FunctionMetadataItemManager.FunctionMetadataPublishingEventHandler.Wm5CcaCMx2y2QgiybsE5;

      internal static bool ibq4bmCMM9HTVhZLtRea([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static object ibag4PCMJXeSkrKZ4wB5() => (object) Task.CompletedTask;

      internal static object Os6HM7CM9NYkvJSeo7kS([In] object obj0) => (object) ((IFunctionMetadataPublishingActor) obj0).PublishComplete();

      internal static bool iNQmORCMdAo9NhRPpukO([In] object obj0, [In] object obj1) => ((TaskCompletionSource<UIMetadataPublishResult>) obj0).TrySetException((Exception) obj1);
    }
  }
}
