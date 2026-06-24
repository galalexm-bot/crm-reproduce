// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.FormMetadataItemManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Exceptions;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.UI.Managers
{
  public class FormMetadataItemManager : EntityManager<IFormMetadataItem, long>
  {
    internal static FormMetadataItemManager TeN5LxBv5FQspupXYM0m;

    public ILockManager LockManager
    {
      get => this.\u003CLockManager\u003Ek__BackingField;
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
              this.\u003CLockManager\u003Ek__BackingField = value;
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
    }

    public FormMetadataItemHeaderManager HeaderManager
    {
      get => this.\u003CHeaderManager\u003Ek__BackingField;
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
              this.\u003CHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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

    /// <summary>Точки расширения для работы с зависимостями форм</summary>
    public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

    /// <summary>Сервис для ограничения работы с зависимостями форм</summary>
    public IWorkWithFormDependeciesService WorkWithFormDependeciesService
    {
      get => this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField;
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
              this.\u003CWorkWithFormDependeciesService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    public override void Save(IFormMetadataItem obj)
    {
      int num1 = 12;
      string errorMessage;
      while (true)
      {
        int num2 = num1;
        IFormDependencyExtension dependencyExtension;
        FormMetadata metadata;
        IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (FormMetadataItemManager.bOwAMVB8C67BhhNVwipK(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj)) == null)
              {
                num2 = 27;
                continue;
              }
              goto case 2;
            case 2:
              FormMetadataItemManager.CR6ZyYB8uWdw8i1BiFdJ((object) obj.Header, FormMetadataItemManager.tgIFZGB8BpD5EZJlXtrp((object) metadata));
              num2 = 16;
              continue;
            case 3:
              if (FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj) != null)
              {
                num2 = 4;
                continue;
              }
              goto case 25;
            case 4:
            case 28:
              FormMetadataItemManager.IBM1A5B8fCTcjrvEa63o(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj), metadata.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 5:
              obj.CreationAuthorId = user == null ? new long?() : (long?) FormMetadataItemManager.Id2JFbB8GLbLmtxKS4EY((object) user);
              num2 = 3;
              continue;
            case 6:
              goto label_6;
            case 7:
              ((IFormMetadataItemHeader) FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj)).CreationAuthorId = user == null ? new long?() : (long?) FormMetadataItemManager.Id2JFbB8GLbLmtxKS4EY((object) user);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 6 : 22;
              continue;
            case 8:
              goto label_3;
            case 9:
              goto label_19;
            case 10:
              goto label_39;
            case 11:
              FormMetadataItemManager.C8oHhiBvcMtu08xrQ1MI(FormMetadataItemManager.VtkRN3BvsdgjsX4ggFGq((object) obj) != null, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405861767));
              num2 = 23;
              continue;
            case 12:
              FormMetadataItemManager.gQ0MnBBvUqfWMTCGSUPd((object) obj, FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(-1290212282 ^ -644262414 ^ 1786845756));
              num2 = 11;
              continue;
            case 13:
              IEnumerable<IFormDependencyExtension> dependencyExtensions = this.FormDependencyExtensions;
              // ISSUE: reference to a compiler-generated field
              Func<IFormDependencyExtension, bool> func = FormMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__16_0;
              Func<IFormDependencyExtension, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                FormMetadataItemManager.\u003C\u003Ec.\u003C\u003E9__16_0 = predicate = (Func<IFormDependencyExtension, bool>) (q => q is UIFormDependencyExtension);
              }
              else
                goto label_42;
label_41:
              dependencyExtension = dependencyExtensions.FirstOrDefault<IFormDependencyExtension>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 21 : 1;
              continue;
label_42:
              predicate = func;
              goto label_41;
            case 14:
              ((IFormMetadataItemHeader) FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj)).IsDirtyItem = true;
              num2 = 8;
              continue;
            case 15:
              obj.Header.Description = metadata.Description;
              num2 = 14;
              continue;
            case 16:
              FormMetadataItemManager.OGRwjEB8VpeJ0dZ0P4Ky(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj), FormMetadataItemManager.Rt7oqJB8IIR8kYbXjMxr((object) metadata));
              num2 = 15;
              continue;
            case 17:
              goto label_16;
            case 18:
              goto label_32;
            case 19:
              goto label_33;
            case 20:
              if (this.HeaderManager.ValidateName(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj) != null ? ((IEntity<long>) FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj)).Id : 0L, FormMetadataItemManager.y29hT7B8FsHxDTGk9Aqb((object) metadata), (string) FormMetadataItemManager.tgIFZGB8BpD5EZJlXtrp((object) metadata), out errorMessage))
              {
                num2 = 19;
                continue;
              }
              goto label_32;
            case 21:
              if (dependencyExtension != null)
              {
                dependencyExtension.GenerateNewDependencies((IMetadata) metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 6 : 4;
                continue;
              }
              num2 = 10;
              continue;
            case 22:
              FormMetadataItemManager.lncE2kB8ZF6TkGS259MO(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj), (object) obj);
              num2 = 2;
              continue;
            case 23:
              metadata = (FormMetadata) obj.Metadata;
              num2 = 20;
              continue;
            case 24:
              if (!FormMetadataItemManager.vhwZWYB8SmB6ASnx6RK7((object) this.WorkWithFormDependeciesService))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 13 : 13;
                continue;
              }
              goto label_37;
            case 25:
              FormMetadataItemManager.UEAdSFB8Emj9fvvsXies((object) obj, (object) InterfaceActivator.Create<IFormMetadataItemHeader>());
              num2 = 28;
              continue;
            case 26:
              FormMetadataItemManager.DGlLlcB8o3fRYAAJhEdT((object) obj, FormMetadataItemManager.cKFB4CB8WMHnv3aBNdm4());
              num2 = 9;
              continue;
            case 27:
              FormMetadataItemManager.LOTGdAB88O4aXWK6EI6R(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj), FormMetadataItemManager.iCi5IuB8v4xuCnkKXaua((object) obj));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 7 : 0;
              continue;
            case 29:
              goto label_12;
            default:
              FormMetadataItemManager.yAS8P8B8QritjEI3OujR(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj), FormMetadataItemManager.y29hT7B8FsHxDTGk9Aqb((object) metadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:
        base.Save(obj);
        num1 = 24;
        continue;
label_19:
        user = (IUser) FormMetadataItemManager.vDCll7B8hiZeS1beo9US(FormMetadataItemManager.Tf10cbB8bMMsYZcs08aR((object) this));
        num1 = 5;
        continue;
label_33:
        if (this.HeaderManager.ValidateDisplayName(FormMetadataItemManager.Ma08beBvzxBqHnYHbPYp((object) obj) == null ? 0L : obj.Header.Id, metadata.GetTypeUid(), metadata.DisplayName, out errorMessage))
          num1 = 26;
        else
          goto label_12;
      }
label_6:
      return;
label_39:
      return;
label_16:
      return;
label_12:
      throw new InvalidOperationException(errorMessage);
label_37:
      return;
label_32:
      throw new InvalidOperationException(errorMessage);
    }

    /// <summary>Публиковать форму</summary>
    /// <param name="headerId">Идентификатор заголовка</param>
    /// <param name="comment">Комментарий</param>
    /// <param name="forEmulation">Публикация для эмуляции</param>
    [Transaction]
    public virtual void Publish(long headerId, string comment, bool forEmulation)
    {
      int num1 = 1;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            disposable = (IDisposable) FormMetadataItemManager.vPZkXMB8ROuLSaVLCV0u((object) this.LockManager, FormMetadataItemManager.EwOBJ9B8iuFaNLDMOhi0(FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(333888594 ^ 1075625116 ^ 1408956726), (object) headerId));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_108;
          default:
            goto label_3;
        }
      }
label_108:
      return;
label_3:
      try
      {
        int num2 = 44;
        while (true)
        {
          int num3;
          FormMetadata metadata;
          FormCodeCompiler formCodeCompiler;
          string assemblyName;
          ScriptModule module;
          MetadataServiceContext metadataServiceContext;
          IFormMetadataItem formMetadataItem1;
          ScriptModuleDTO source;
          Guid guid;
          long? nullable1;
          IFormMetadataItem formMetadataItem2;
          long? nullable2;
          IUser currentUser;
          ScriptModuleDTO scriptModuleDto;
          long? nullable3;
          ScriptModule scriptModule;
          FormDescriptorProvider descriptorProvider;
          IFormMetadataItemHeader header;
          switch (num2)
          {
            case 1:
              try
              {
                List<IMetadata> metadataList = new List<IMetadata>(metadata.GetMetadataToRegister());
                int num4 = 4;
                ScriptCompileResult scriptCompileResult;
                IEnumerator<ScriptCompileMessage> enumerator1;
                StringBuilder stringBuilder;
                List<EntityMetadata>.Enumerator enumerator2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      enumerator1 = scriptCompileResult.Messages.Where<ScriptCompileMessage>((Func<ScriptCompileMessage, bool>) (m => m.Type == ScriptCompileMessageType.Error)).GetEnumerator();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 10;
                      continue;
                    case 2:
                      stringBuilder = new StringBuilder();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 8;
                      continue;
                    case 3:
                      try
                      {
label_29:
                        if (enumerator2.MoveNext())
                          goto label_32;
                        else
                          goto label_30;
label_28:
                        EntityMetadata current;
                        int num5;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              goto label_32;
                            case 2:
                              goto label_37;
                            case 3:
                              this.AddContainedMetadata(current, metadataList);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_29;
                          }
                        }
label_30:
                        num5 = 2;
                        goto label_28;
label_32:
                        current = enumerator2.Current;
                        num5 = 3;
                        goto label_28;
                      }
                      finally
                      {
                        enumerator2.Dispose();
                        int num6 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                          num6 = 0;
                        switch (num6)
                        {
                          default:
                        }
                      }
                    case 4:
                      enumerator2 = metadataList.OfType<EntityMetadata>().ToList<EntityMetadata>().GetEnumerator();
                      num4 = 3;
                      continue;
                    case 5:
label_37:
                      formCodeCompiler = new FormCodeCompiler(assemblyName, metadata, module);
                      num4 = 7;
                      continue;
                    case 6:
                      if (!FormMetadataItemManager.o9NfYrB8khoa8cEu3fVb((object) scriptCompileResult))
                      {
                        num4 = 2;
                        continue;
                      }
                      goto label_91;
                    case 7:
                      scriptCompileResult = (ScriptCompileResult) FormMetadataItemManager.APU31aB8T3IdbWkLO3xY((object) formCodeCompiler);
                      num4 = 6;
                      continue;
                    case 8:
                      FormMetadataItemManager.uvaQwuB8ngiUZ06HIem4((object) stringBuilder, FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(-787452571 ^ -787441877));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
                      continue;
                    case 9:
label_26:
                      FormMetadataItemManager.u2mr9aB833B0jP6TNXRn(FormMetadataItemManager.Or96HcB8NmQwVZmqnsGQ((object) this), (object) stringBuilder.ToString());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                      continue;
                    case 10:
                      try
                      {
label_14:
                        if (enumerator1.MoveNext())
                          goto label_12;
                        else
                          goto label_15;
label_11:
                        ScriptCompileMessage current;
                        int num7;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_12;
                            case 2:
                              FormMetadataItemManager.uvaQwuB8ngiUZ06HIem4((object) stringBuilder, FormMetadataItemManager.yAa9J9B8PwI14VYCWnc3(FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(-16752921 ^ -16735077), (object) FormMetadataItemManager.Rw94nbB8Os6TVw0dQamG((object) current), (object) FormMetadataItemManager.Gjmp58B82oWKbFGgw3Hb((object) current), FormMetadataItemManager.IDUN9OB8e47HayMnQ5NV((object) current)));
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                              continue;
                            case 3:
                              goto label_26;
                            default:
                              goto label_14;
                          }
                        }
label_12:
                        current = enumerator1.Current;
                        num7 = 2;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                        {
                          num7 = 2;
                          goto label_11;
                        }
                        else
                          goto label_11;
label_15:
                        num7 = 3;
                        goto label_11;
                      }
                      finally
                      {
                        if (enumerator1 != null)
                        {
                          int num8 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                            num8 = 1;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                FormMetadataItemManager.qLeuBWB81grtuHyUPf29((object) enumerator1);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_22;
                            }
                          }
                        }
label_22:;
                      }
                    default:
                      goto label_41;
                  }
                }
label_41:
                throw new FormMetadataPublishingException(scriptCompileResult);
              }
              finally
              {
                if (metadataServiceContext != null)
                {
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
                    num9 = 0;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        goto label_47;
                      default:
                        FormMetadataItemManager.qLeuBWB81grtuHyUPf29((object) metadataServiceContext);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_47:;
              }
            case 2:
              FormMetadataItemManager.KrgnfLB87LblAeIcU8hR((object) header, (object) formMetadataItem1);
              num2 = 17;
              continue;
            case 3:
              scriptModuleDto = Mapper.Map<ScriptModule, ScriptModuleDTO>(formMetadataItem2.ScriptModule, new ScriptModuleDTO());
              goto label_95;
            case 4:
              descriptorProvider = Locator.GetServiceNotNull<FormDescriptorProvider>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 18 : 23;
              continue;
            case 5:
              IFormMetadataItem formMetadataItem3 = formMetadataItem1;
              long? nullable4;
              if (currentUser == null)
              {
                nullable2 = new long?();
                nullable4 = nullable2;
              }
              else
                nullable4 = (long?) FormMetadataItemManager.Id2JFbB8GLbLmtxKS4EY((object) currentUser);
              formMetadataItem3.CreationAuthorId = nullable4;
              num2 = 45;
              continue;
            case 6:
              FormMetadataItemManager.w5GQp7B8KJZpkdmSvBFN((object) source, Guid.NewGuid());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            case 7:
              metadata = (FormMetadata) ClassSerializationHelper.CloneObjectByXml<object>(FormMetadataItemManager.VtkRN3BvsdgjsX4ggFGq((object) formMetadataItem2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 12 : 27;
              continue;
            case 8:
              nullable3 = nullable2;
              goto label_93;
            case 9:
              scriptModuleDto = (ScriptModuleDTO) null;
              goto label_95;
            case 10:
              this.Session.Save((object) formMetadataItem1);
              num2 = 31;
              continue;
            case 11:
              formMetadataItem2 = (IFormMetadataItem) FormMetadataItemManager.bOwAMVB8C67BhhNVwipK((object) header);
              num3 = 30;
              break;
            case 12:
              header.IsDirtyItem = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 39;
              continue;
            case 13:
              nullable2 = new long?();
              num2 = 8;
              continue;
            case 14:
              guid = Guid.NewGuid();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 7 : 7;
              continue;
            case 15:
              FormMetadataItemManager.YG4OF8B8wNdxSNEm2Q2T((object) formMetadataItem1, (object) assemblyName);
              num2 = 20;
              continue;
            case 16:
              FormMetadataItemManager.MXhPAxB8D8BlvFldc1IO((object) formMetadataItem1, (object) comment);
              num2 = 26;
              continue;
            case 17:
            case 39:
              header.Save();
              num2 = 4;
              continue;
            case 18:
              FormMetadataItemManager.HsQPcLB80Y1ep2eJAN2M((object) Locator.GetServiceNotNull<IUnitOfWorkManager>(), (object) (System.Action) (() =>
              {
                int num10 = 1;
                while (true)
                {
                  switch (num10)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      descriptorProvider.UpdateCache(FormMetadataItemManager.\u003C\u003Ec__DisplayClass17_0.uJsad1QGTSdW1bnQkj34((object) header));
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 42;
              continue;
            case 19:
              FormMetadataItemManager.EqcyFaB8a32DGVATFEjx((object) formMetadataItem1, (object) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 22;
              continue;
            case 20:
              FormMetadataItemManager.z2iCGgB84skc0msBi1mI((object) formMetadataItem1, (object) formCodeCompiler.AssemblyRaw);
              num2 = 40;
              continue;
            case 21:
              scriptModule = (ScriptModule) null;
              goto label_97;
            case 22:
              FormMetadataItemManager.DGlLlcB8o3fRYAAJhEdT((object) formMetadataItem1, FormMetadataItemManager.cKFB4CB8WMHnv3aBNdm4());
              num3 = 5;
              break;
            case 23:
              FormMetadataItemManager.JK7RPhB8xMpUT91dvZtM((object) descriptorProvider, (object) formMetadataItem1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 18;
              continue;
            case 24:
              FormMetadataItemManager.Po8kyQB8pGNrVaDVu3ee((object) formMetadataItem1, guid);
              num2 = 19;
              continue;
            case 25:
              if (source != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 37 : 30;
                continue;
              }
              goto case 21;
            case 26:
              formMetadataItem1.VersionNumber = nullable1;
              num2 = 38;
              continue;
            case 27:
              metadata.GenerateNewUids();
              num2 = 34;
              continue;
            case 28:
              header = this.HeaderManager.Load(headerId);
              num2 = 11;
              continue;
            case 29:
label_91:
              formMetadataItem1 = this.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 24 : 14;
              continue;
            case 30:
              currentUser = ((IAuthenticationService) FormMetadataItemManager.Tf10cbB8bMMsYZcs08aR((object) this)).GetCurrentUser();
              num2 = 14;
              continue;
            case 31:
              if (!forEmulation)
              {
                num2 = 41;
                continue;
              }
              goto case 2;
            case 32:
              nullable3 = new long?(Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().GetPublishingVersionNumber(headerId));
              goto label_93;
            case 33:
              metadataServiceContext = new MetadataServiceContext((IMetadataService) new ExtendedMetadataService((IMetadataService) Locator.GetServiceNotNull<IMetadataRuntimeService>(), metadata.GetMetadataToRegister()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
              continue;
            case 34:
              if (FormMetadataItemManager.P7K0JoB8qOd1WAlJcL99((object) formMetadataItem2) != null)
              {
                num3 = 3;
                break;
              }
              goto case 9;
            case 35:
              FormMetadataItemManager.KrgnfLB87LblAeIcU8hR((object) header, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 3 : 12;
              continue;
            case 36:
              assemblyName = (string) FormMetadataItemManager.HuQrvsB8XAkVrnD4OGaW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586947), (object) guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121179203)));
              num2 = 33;
              continue;
            case 37:
              scriptModule = Mapper.Map<ScriptModuleDTO, ScriptModule>(source);
              goto label_97;
            case 38:
              FormMetadataItemManager.MXWbd2B8tvkXRx68VX4u((object) formMetadataItem1, (object) module);
              num2 = 15;
              continue;
            case 40:
              FormMetadataItemManager.qAZY8iB8HIHDYDQB4vkn((object) formMetadataItem1, FormMetadataItemManager.Ci8LoMB86tsHhRqnolFC((object) formCodeCompiler));
              num2 = 10;
              continue;
            case 41:
              FormMetadataItemManager.Oh0Ds8B8ADsKTxSs8iLl((object) header, (object) formMetadataItem1);
              num2 = 35;
              continue;
            case 42:
              goto label_105;
            case 43:
              if (source != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 6;
                continue;
              }
              goto case 25;
            case 44:
              if (!forEmulation)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 32 : 14;
                continue;
              }
              goto case 13;
            case 45:
              FormMetadataItemManager.UEAdSFB8Emj9fvvsXies((object) formMetadataItem1, (object) header);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 14 : 16;
              continue;
            default:
              source.Id = 0L;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 15 : 25;
              continue;
          }
label_5:
          num2 = num3;
          continue;
label_93:
          nullable1 = nullable3;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 26 : 28;
          continue;
label_95:
          source = scriptModuleDto;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 43 : 42;
          continue;
label_97:
          module = scriptModule;
          num3 = 36;
          goto label_5;
        }
label_105:;
      }
      finally
      {
        int num11;
        if (disposable == null)
          num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
        else
          goto label_106;
label_104:
        switch (num11)
        {
          case 1:
          case 2:
        }
label_106:
        disposable.Dispose();
        num11 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        {
          num11 = 2;
          goto label_104;
        }
        else
          goto label_104;
      }
    }

    public override ExportRuleList ExportRules()
    {
      int num = 2;
      ExportRuleList exportRuleList1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            exportRuleList1 = new ExportRuleList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 2:
            type = FormMetadataItemManager.Q0T5djB8mZjDE9n1piu7((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
            continue;
          case 3:
            ExportRuleList exportRuleList2 = exportRuleList1;
            ExportRule exportRule1 = new ExportRule();
            FormMetadataItemManager.chFEY6B8yjqOfHhrlZF9((object) exportRule1, type);
            ExportRule exportRule2 = exportRule1;
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(FormMetadataItemManager.y2fJctB8MUFfoSGBQvPA(__typeref (IFormMetadataItem)), (string) FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(694673736 ^ -23604109 ^ -672097905));
            // ISSUE: method reference
            string str1 = LinqUtils.NameOf<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression) FormMetadataItemManager.sTKdQVB8gAD18obJjeaX(FormMetadataItemManager.XQgUKcB8ls7oCID5jLVb((object) parameterExpression1, (object) (MethodInfo) FormMetadataItemManager.BksJRQB892jwWVoRx1oy(__methodref (IFormMetadataItem.get_Uid))), typeof (object)), parameterExpression1));
            exportRule2.PropertyName = str1;
            FormMetadataItemManager.g8o6EyB8d4T74lslREMD((object) exportRule1, ExportRuleType.Export);
            ExportRule exportRule3 = exportRule1;
            exportRuleList2.Add(exportRule3);
            num = 4;
            continue;
          case 4:
            goto label_5;
          case 5:
            ExportRuleList exportRuleList3 = exportRuleList1;
            ExportRule exportRule4 = new ExportRule();
            FormMetadataItemManager.chFEY6B8yjqOfHhrlZF9((object) exportRule4, type);
            ExportRule exportRule5 = exportRule4;
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) FormMetadataItemManager.YKCTIPB8JYPZ0F3fbTsp(FormMetadataItemManager.y2fJctB8MUFfoSGBQvPA(__typeref (IFormMetadataItem)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917300286));
            // ISSUE: method reference
            string str2 = LinqUtils.NameOf<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression) FormMetadataItemManager.XQgUKcB8ls7oCID5jLVb((object) parameterExpression2, (object) (MethodInfo) FormMetadataItemManager.BksJRQB892jwWVoRx1oy(__methodref (IFormMetadataItem.get_ScriptModule))), parameterExpression2));
            FormMetadataItemManager.w3ErYBB8ryJT1vpkOteV((object) exportRule5, (object) str2);
            FormMetadataItemManager.g8o6EyB8d4T74lslREMD((object) exportRule4, ExportRuleType.Export);
            ExportRule exportRule6 = exportRule4;
            exportRuleList3.Add(exportRule6);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 3;
            continue;
          case 6:
            ExportRuleList exportRuleList4 = exportRuleList1;
            ExportRule exportRule7 = new ExportRule();
            FormMetadataItemManager.chFEY6B8yjqOfHhrlZF9((object) exportRule7, type);
            ExportRule exportRule8 = exportRule7;
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) FormMetadataItemManager.YKCTIPB8JYPZ0F3fbTsp(FormMetadataItemManager.y2fJctB8MUFfoSGBQvPA(__typeref (IFormMetadataItem)), FormMetadataItemManager.WMT4wnBvLntouUFWrs7S(647913418 ^ 647951230));
            // ISSUE: method reference
            string str3 = LinqUtils.NameOf<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression) FormMetadataItemManager.XQgUKcB8ls7oCID5jLVb((object) parameterExpression3, (object) (MethodInfo) FormMetadataItemManager.BksJRQB892jwWVoRx1oy(__methodref (IFormMetadataItem.get_Metadata))), parameterExpression3));
            exportRule8.PropertyName = str3;
            FormMetadataItemManager.g8o6EyB8d4T74lslREMD((object) exportRule7, ExportRuleType.Export);
            ExportRule exportRule9 = exportRule7;
            exportRuleList4.Add(exportRule9);
            num = 5;
            continue;
          default:
            ExportRuleList exportRuleList5 = exportRuleList1;
            ExportRule exportRule10 = new ExportRule();
            FormMetadataItemManager.chFEY6B8yjqOfHhrlZF9((object) exportRule10, type);
            ExportRule exportRule11 = exportRule10;
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) FormMetadataItemManager.YKCTIPB8JYPZ0F3fbTsp(FormMetadataItemManager.y2fJctB8MUFfoSGBQvPA(__typeref (IFormMetadataItem)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477118098));
            // ISSUE: method reference
            string str4 = LinqUtils.NameOf<IFormMetadataItem>(Expression.Lambda<Func<IFormMetadataItem, object>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) FormMetadataItemManager.BksJRQB892jwWVoRx1oy(__methodref (IFormMetadataItem.get_Header))), parameterExpression4));
            exportRule11.PropertyName = str4;
            FormMetadataItemManager.g8o6EyB8d4T74lslREMD((object) exportRule10, ExportRuleType.Export);
            ExportRule exportRule12 = exportRule10;
            exportRuleList5.Add(exportRule12);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 6 : 6;
            continue;
        }
      }
label_5:
      return exportRuleList1;
    }

    private void AddContainedMetadata(EntityMetadata metadata, List<IMetadata> metadataList)
    {
      foreach (TablePartMetadata tablePart in metadata.TableParts)
      {
        metadataList.Add((IMetadata) tablePart);
        this.AddContainedMetadata((EntityMetadata) tablePart, metadataList);
      }
    }

    public FormMetadataItemManager()
    {
      FormMetadataItemManager.Aew2n7B85VFvGCTylfOB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool IVUYsKBvjTL3cMM7EZjC() => FormMetadataItemManager.TeN5LxBv5FQspupXYM0m == null;

    internal static FormMetadataItemManager tcnGB1BvYbKg5fJNvxTq() => FormMetadataItemManager.TeN5LxBv5FQspupXYM0m;

    internal static object WMT4wnBvLntouUFWrs7S(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gQ0MnBBvUqfWMTCGSUPd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object VtkRN3BvsdgjsX4ggFGq([In] object obj0) => ((IFormMetadataItem) obj0).Metadata;

    internal static void C8oHhiBvcMtu08xrQ1MI(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object Ma08beBvzxBqHnYHbPYp([In] object obj0) => (object) ((IFormMetadataItem) obj0).Header;

    internal static Guid y29hT7B8FsHxDTGk9Aqb([In] object obj0) => ((FormMetadata) obj0).GetTypeUid();

    internal static object tgIFZGB8BpD5EZJlXtrp([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static DateTime cKFB4CB8WMHnv3aBNdm4() => DateTime.Now;

    internal static void DGlLlcB8o3fRYAAJhEdT([In] object obj0, DateTime value) => ((IFormMetadataItem) obj0).CreationDate = value;

    internal static object Tf10cbB8bMMsYZcs08aR([In] object obj0) => (object) ((EntityManager<IFormMetadataItem, long>) obj0).AuthenticationService;

    internal static object vDCll7B8hiZeS1beo9US([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static object Id2JFbB8GLbLmtxKS4EY([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void UEAdSFB8Emj9fvvsXies([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).Header = (IFormMetadataItemHeader) obj1;

    internal static void IBM1A5B8fCTcjrvEa63o([In] object obj0, Guid value) => ((IFormMetadataItemHeader) obj0).Uid = value;

    internal static void yAS8P8B8QritjEI3OujR([In] object obj0, Guid value) => ((IFormMetadataItemHeader) obj0).MetadataType = value;

    internal static object bOwAMVB8C67BhhNVwipK([In] object obj0) => (object) ((IFormMetadataItemHeader) obj0).Draft;

    internal static DateTime iCi5IuB8v4xuCnkKXaua([In] object obj0) => ((IFormMetadataItem) obj0).CreationDate;

    internal static void LOTGdAB88O4aXWK6EI6R([In] object obj0, DateTime value) => ((IFormMetadataItemHeader) obj0).CreationDate = value;

    internal static void lncE2kB8ZF6TkGS259MO([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).Draft = (IFormMetadataItem) obj1;

    internal static void CR6ZyYB8uWdw8i1BiFdJ([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object Rt7oqJB8IIR8kYbXjMxr([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void OGRwjEB8VpeJ0dZ0P4Ky([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).DisplayName = (string) obj1;

    internal static bool vhwZWYB8SmB6ASnx6RK7([In] object obj0) => ((IWorkWithFormDependeciesService) obj0).IsActive();

    internal static object EwOBJ9B8iuFaNLDMOhi0([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object vPZkXMB8ROuLSaVLCV0u([In] object obj0, [In] object obj1) => (object) ((ILockManager) obj0).Lock((string) obj1);

    internal static object P7K0JoB8qOd1WAlJcL99([In] object obj0) => (object) ((IFormMetadataItem) obj0).ScriptModule;

    internal static void w5GQp7B8KJZpkdmSvBFN([In] object obj0, Guid value) => ((ScriptModuleDTO) obj0).Uid = value;

    internal static object HuQrvsB8XAkVrnD4OGaW([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object APU31aB8T3IdbWkLO3xY([In] object obj0) => (object) ((ScriptCompiler) obj0).Compile();

    internal static bool o9NfYrB8khoa8cEu3fVb([In] object obj0) => ((ScriptCompileResult) obj0).Success;

    internal static object uvaQwuB8ngiUZ06HIem4([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static int Rw94nbB8Os6TVw0dQamG([In] object obj0) => ((ScriptCompileMessage) obj0).Line;

    internal static int Gjmp58B82oWKbFGgw3Hb([In] object obj0) => ((ScriptCompileMessage) obj0).Column;

    internal static object IDUN9OB8e47HayMnQ5NV([In] object obj0) => (object) ((ScriptCompileMessage) obj0).Message;

    internal static object yAa9J9B8PwI14VYCWnc3(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void qLeuBWB81grtuHyUPf29([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object Or96HcB8NmQwVZmqnsGQ([In] object obj0) => (object) ((EntityManager<IFormMetadataItem, long>) obj0).Logger;

    internal static void u2mr9aB833B0jP6TNXRn([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static void Po8kyQB8pGNrVaDVu3ee([In] object obj0, Guid value) => ((IFormMetadataItem) obj0).Uid = value;

    internal static void EqcyFaB8a32DGVATFEjx([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).Metadata = obj1;

    internal static void MXhPAxB8D8BlvFldc1IO([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).Comment = (string) obj1;

    internal static void MXWbd2B8tvkXRx68VX4u([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).ScriptModule = (ScriptModule) obj1;

    internal static void YG4OF8B8wNdxSNEm2Q2T([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).AssemblyName = (string) obj1;

    internal static void z2iCGgB84skc0msBi1mI([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).AssemblyRaw = (byte[]) obj1;

    internal static object Ci8LoMB86tsHhRqnolFC([In] object obj0) => (object) ((AssemblyBuilder) obj0).DebugRaw;

    internal static void qAZY8iB8HIHDYDQB4vkn([In] object obj0, [In] object obj1) => ((IFormMetadataItem) obj0).DebugRaw = (byte[]) obj1;

    internal static void Oh0Ds8B8ADsKTxSs8iLl([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).Published = (IFormMetadataItem) obj1;

    internal static void KrgnfLB87LblAeIcU8hR([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).Emulation = (IFormMetadataItem) obj1;

    internal static object JK7RPhB8xMpUT91dvZtM([In] object obj0, [In] object obj1) => (object) ((FormDescriptorProvider) obj0).CreateDescriptor((IFormMetadataItem) obj1);

    internal static void HsQPcLB80Y1ep2eJAN2M([In] object obj0, [In] object obj1) => ((IUnitOfWorkManager) obj0).RegisterPostCommitAction((System.Action) obj1);

    internal static Type Q0T5djB8mZjDE9n1piu7([In] object obj0) => ((EntityManager<IFormMetadataItem, long>) obj0).ImplementationType;

    internal static void chFEY6B8yjqOfHhrlZF9([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static Type y2fJctB8MUFfoSGBQvPA([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YKCTIPB8JYPZ0F3fbTsp([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object BksJRQB892jwWVoRx1oy([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static void g8o6EyB8d4T74lslREMD([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static object XQgUKcB8ls7oCID5jLVb([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static void w3ErYBB8ryJT1vpkOteV([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static object sTKdQVB8gAD18obJjeaX([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static void Aew2n7B85VFvGCTylfOB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
