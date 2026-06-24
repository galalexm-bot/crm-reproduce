// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.ModelRegistrarImpl
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Hubs;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Managers
{
  internal class ModelRegistrarImpl : 
    LicensedUnitBase,
    IWorkplaceLicenseInfoOwner,
    ILicensedUnit,
    IActivationTokenContainer
  {
    private static ILogger publishLogger;
    public const string CompiledModelBaseDir = "CompiledModel";
    private static readonly Guid securityAssemblyUid;
    private readonly IDictionary<Guid, Type> _typesByUid;
    private readonly IDictionary<Guid, Type> _removedTypes;
    private readonly IDictionary<Guid, IMetadata> _metadataList;
    private readonly IDictionary<Guid, IMetadata> _metadataParents;
    private IEnumerable<AssemblyModelsMetadata> _previousAsmModelsMetadataList;
    private readonly IDictionary<string, AssemblyModelsMetadata> _asmModelsMetadataDict;
    private readonly ISet<Guid> configUids;
    private readonly List<Assembly> _modelAssemblies;
    private readonly Dictionary<(Guid, Guid), ITypeDescriptor> _typeDescriptorsByUid;
    private readonly Dictionary<Type, ITypeDescriptor> _typeDescriptorsByType;
    private readonly ISet<Type> registeredTypes;
    [ThreadStatic]
    private ISet<Guid> resolvingTypeUids;
    /// <summary>Плоское представление дерева метаданных</summary>
    private Dictionary<EntityMetadata, int> metadataIndexTree;
    private SessionFactoryHolder sessionFactoryHolder;
    private bool initialized;
    private bool licensingInitialized;
    private string lastAppliedActKey;
    private string registrationKey;
    private ConcurrentLicenseInfo licenseInfo;
    private LicenseStatus initializedStatus;
    private static ModelRegistrarImpl AooqRUhEIeI5n6Mpant1;

    uint IWorkplaceLicenseInfoOwner.UsedLicenseCount => ModelRegistrarImpl.pG9VjJhEXu7I2ZLyhrZ3((object) (IWorkplaceLicenseInfoOwner) ModelRegistrarImpl.LBmBFrhEKAAtgIukDOCQ((object) (ILicensedModuleAssembly) ModelRegistrarImpl.fTxXPfhEqYpAM5v2up7W(ModelRegistrarImpl.X95t0nhERmiTkRBTIGSO(ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()), ModelRegistrarImpl.securityAssemblyUid)));

    /// <summary>Зарегистрировать</summary>
    /// <param name="parameters">Параметры для регистрации</param>
    public void Register(ModelRegistrar r, NHManagerRegisterParams parameters)
    {
      int num1 = 9;
      IDisposable disposable1;
      DateTime dateTime1;
      ModelRegistrarImpl modelRegistrarImpl;
      NHManagerRegisterParams parameters1;
      while (true)
      {
        int num2 = num1;
        DateTime now;
        while (true)
        {
          LicenseStatus status;
          DateTime? expirationDate;
          switch (num2)
          {
            case 1:
              if (!expirationDate.HasValue)
              {
                num2 = 10;
                continue;
              }
              goto label_238;
            case 2:
              goto label_230;
            case 3:
              goto label_235;
            case 4:
              disposable1 = (IDisposable) ModelRegistrarImpl.da0jhhhEnHZHVHZn1IHW();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            case 5:
              DateTime date1 = now.Date;
              now = expirationDate.Value;
              DateTime date2 = now.Date;
              if (ModelRegistrarImpl.gqLemFhETc963syN82Z2(date1, date2))
              {
                num2 = 7;
                continue;
              }
              goto case 10;
            case 6:
              goto label_238;
            case 7:
              goto label_5;
            case 8:
              modelRegistrarImpl = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 8 : 12;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 10:
              dateTime1 = ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 4;
              continue;
            case 11:
              if (status != LicenseStatus.DateExpired)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 3;
                continue;
              }
              break;
            case 12:
              parameters1 = parameters;
              num2 = 13;
              continue;
            case 13:
              this.DecodeActivationKey(this.lastAppliedActKey, out status, out ushort _, out ushort _, out byte _, out byte _, out expirationDate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 11 : 14;
              continue;
            case 14:
              if (status != LicenseStatus.Activated)
              {
                num2 = 11;
                continue;
              }
              break;
            default:
              goto label_16;
          }
          if (status != LicenseStatus.DateExpired)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
          else
            goto label_5;
        }
label_238:
        now = DateTime.Now;
        num1 = 5;
      }
label_230:
      return;
label_5:
      throw new LicenseExpiredException(__ModuleInfo.UID);
label_16:
      try
      {
        MetadataServiceContext metadataServiceContext = new MetadataServiceContext((IMetadataService) r);
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              try
              {
                IRuntimeApplication serviceNotNull1 = Locator.GetServiceNotNull<IRuntimeApplication>();
                int num4 = 6;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                  num4 = 15;
                while (true)
                {
                  int num5;
                  ModelRegistrarImpl.PublicationEventHandler publicationEventHandler;
                  IDisposable disposable2;
                  DateTime dateTime2;
                  IStartInformation startInformation;
                  List<MemoryStream> pdbRaws;
                  IEnumerator<AssemblyModelsMetadata> enumerator1;
                  int setting;
                  List<Assembly> assemblies;
                  DbPreUpdater dbPreUpdater;
                  IEnumerable<AssemblyModelsMetadata> source1;
                  IEnumerator<Type> enumerator2;
                  int num6;
                  switch (num4)
                  {
                    case 1:
                      publicationEventHandler = new ModelRegistrarImpl.PublicationEventHandler();
                      num5 = 4;
                      break;
                    case 2:
                      if (ModelRegistrarImpl.Bmp32thEA1hdepj1Chu9((object) Locator.GetServiceNotNull<IDynamicPublicationService>()))
                      {
                        num4 = 31;
                        continue;
                      }
                      goto case 37;
                    case 3:
                      startInformation = (IStartInformation) ModelRegistrarImpl.uGTM6NhEP1WTivFv8sgr(13.0, ModelRegistrarImpl.hgIkSShEeHFSirvB1wg6(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-342626196 - 1290888215 ^ -1633571869)));
                      num4 = 17;
                      continue;
                    case 4:
                      disposable2 = (IDisposable) ModelRegistrarImpl.E5fXP0hE4wBb7JxGRnsP((object) Locator.GetServiceNotNull<IEventHandlerSubscribeService>(), (object) publicationEventHandler);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 7 : 12;
                      continue;
                    case 5:
                      try
                      {
label_165:
                        if (ModelRegistrarImpl.JilRh4hEcsSIxTlIWqPc((object) enumerator2))
                          goto label_163;
                        else
                          goto label_166;
label_162:
                        Type current;
                        int num7;
                        while (true)
                        {
                          switch (num7)
                          {
                            case 1:
                              goto label_146;
                            case 2:
                              goto label_165;
                            case 3:
                              goto label_163;
                            default:
                              parameters1.Add(current);
                              num7 = 2;
                              continue;
                          }
                        }
label_163:
                        current = enumerator2.Current;
                        num7 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
                        {
                          num7 = 0;
                          goto label_162;
                        }
                        else
                          goto label_162;
label_166:
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                        goto label_162;
                      }
                      finally
                      {
                        int num8;
                        if (enumerator2 == null)
                          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                        else
                          goto label_171;
label_170:
                        switch (num8)
                        {
                          case 1:
                            break;
                          default:
                        }
label_171:
                        ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator2);
                        num8 = 2;
                        goto label_170;
                      }
                    case 6:
                      try
                      {
label_40:
                        if (ModelRegistrarImpl.JilRh4hEcsSIxTlIWqPc((object) enumerator1))
                          goto label_48;
                        else
                          goto label_41;
label_31:
                        AssemblyModelsMetadata current;
                        int num9;
                        while (true)
                        {
                          int num10;
                          Assembly assembly;
                          string str;
                          int num11;
                          int num12;
                          switch (num9)
                          {
                            case 1:
                              goto label_143;
                            case 2:
label_35:
                              this.ConfigurationScriptsErrors = (string) ModelRegistrarImpl.FiqTxthEsrhBCZS0r4kR(ModelRegistrarImpl.EfHg8RhElrHjJPIViysi((object) current), ModelRegistrarImpl.qGHMbhhEUpDZSh3FLHPo());
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 4 : 1;
                              continue;
                            case 3:
                              num11 = 0;
                              goto label_62;
                            case 4:
                            case 9:
                            case 13:
                              goto label_40;
                            case 5:
                              if (!ModelRegistrarImpl.oHZ0mMhEjj8uA3MtknRU(ModelRegistrarImpl.OIrrekhEJr8xYG18WsJf((object) current), ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(222162814 ^ 222160154)))
                              {
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 7;
                                continue;
                              }
                              goto case 15;
                            case 6:
                              num12 = 0;
                              goto label_66;
                            case 7:
                            case 14:
                              if (!ModelRegistrarImpl.tVofbYhELfbcXgg38gWJ(ModelRegistrarImpl.OIrrekhEJr8xYG18WsJf((object) current), ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1710575414 ^ -1710589364)))
                              {
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 15 : 16;
                                continue;
                              }
                              goto case 22;
                            case 8:
                              Directory.CreateDirectory(str);
                              num9 = 18;
                              continue;
                            case 10:
                            case 18:
                              ModelRegistrarImpl.wtBPlmhEdc7QFZsF41cb(ModelRegistrarImpl.M4Bho7hEylM5d6QSLLKm((object) str, ModelRegistrarImpl.tcbG00hE9RUI5mfHviBO(ModelRegistrarImpl.OIrrekhEJr8xYG18WsJf((object) current), ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1710575414 ^ -1710492560))), ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) current), TimeSpan.FromSeconds(1.0), setting);
                              num9 = 27;
                              continue;
                            case 11:
                              pdbRaws.Add((MemoryStream) ModelRegistrarImpl.Wl7JVPhEgcxNIjiA2Pl0((object) current));
                              num9 = 13;
                              continue;
                            case 12:
                              if (ModelRegistrarImpl.zucfSrhEMNClQwH8Outc((object) str))
                              {
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 10;
                                continue;
                              }
                              goto case 8;
                            case 15:
                              ModelRegistrarImpl.MVVdaLhEY32cKChTO0gG((object) assembly);
                              num9 = 14;
                              continue;
                            case 17:
                              str = (string) ModelRegistrarImpl.M4Bho7hEylM5d6QSLLKm(ModelRegistrarImpl.dYKhTQhEmRiOvikgv19S(ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3315336));
                              num10 = 12;
                              break;
                            case 19:
label_32:
                              assembly = (Assembly) ModelRegistrarImpl.gB9hkNhE52D7axtIfSwc((object) current.AssemblyRawStream, ModelRegistrarImpl.Wl7JVPhEgcxNIjiA2Pl0((object) current));
                              num9 = 5;
                              continue;
                            case 20:
                              this.ConfigurationScriptsRecompileRequired = true;
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 24 : 3;
                              continue;
                            case 21:
                              IOExtensions.WriteAllBytesWithAttempts(Path.Combine(str, (string) ModelRegistrarImpl.OIrrekhEJr8xYG18WsJf((object) current) + (string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1822890472 ^ -1822922666)), (Stream) ModelRegistrarImpl.EfHg8RhElrHjJPIViysi((object) current), TimeSpan.FromSeconds(1.0), setting);
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 19;
                              continue;
                            case 22:
                              ((ComponentManager) ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()).RegisterAssembly(assembly);
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                              continue;
                            case 23:
                              if (ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) current) != null)
                              {
                                num10 = 17;
                                break;
                              }
                              goto case 26;
                            case 24:
                              object obj1 = ModelRegistrarImpl.EfHg8RhElrHjJPIViysi((object) current);
                              if (obj1 == null)
                              {
                                num9 = 6;
                                continue;
                              }
                              num12 = ModelRegistrarImpl.xq8EYQhErJrawiw2AFnv(obj1) > 0L ? 1 : 0;
                              goto label_66;
                            case 25:
                              goto label_48;
                            case 26:
                              if (ModelRegistrarImpl.oHZ0mMhEjj8uA3MtknRU((object) current.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239593228)))
                              {
                                num9 = 20;
                                continue;
                              }
                              goto label_40;
                            case 27:
                              object obj2 = ModelRegistrarImpl.EfHg8RhElrHjJPIViysi((object) current);
                              if (obj2 == null)
                              {
                                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 1;
                                continue;
                              }
                              num11 = ModelRegistrarImpl.xq8EYQhErJrawiw2AFnv(obj2) > 0L ? 1 : 0;
                              goto label_62;
                            default:
                              assemblies.Add(assembly);
                              num9 = 11;
                              continue;
                          }
                          num9 = num10;
                          continue;
label_62:
                          if (num11 != 0)
                          {
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 7 : 21;
                            continue;
                          }
                          goto label_32;
label_66:
                          if (num12 == 0)
                            num9 = 9;
                          else
                            goto label_35;
                        }
label_41:
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 0;
                        goto label_31;
label_48:
                        current = enumerator1.Current;
                        num9 = 23;
                        goto label_31;
                      }
                      finally
                      {
                        int num13;
                        if (enumerator1 == null)
                          num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
                        else
                          goto label_71;
label_70:
                        switch (num13)
                        {
                          case 1:
                          case 2:
                        }
label_71:
                        ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator1);
                        num13 = 2;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                        {
                          num13 = 0;
                          goto label_70;
                        }
                        else
                          goto label_70;
                      }
                    case 7:
                      startInformation = (IStartInformation) ModelRegistrarImpl.uGTM6NhEP1WTivFv8sgr(1.0, ModelRegistrarImpl.hgIkSShEeHFSirvB1wg6(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-345420348 ^ -345347406)));
                      num4 = 13;
                      continue;
                    case 8:
                      ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), ModelRegistrarImpl.VprG0OhEpIdm4mYL18WY(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1113862659 ^ 1114053327), (object) (int) (ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH() - dateTime2).TotalMilliseconds, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1199946765 ^ 1199884337)));
                      num4 = 42;
                      continue;
                    case 9:
label_143:
                      parameters1.Add<AssemblyModelsMetadataMap>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 30 : 5;
                      continue;
                    case 10:
                      ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), ModelRegistrarImpl.VprG0OhEpIdm4mYL18WY(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1505778440 - 1981636111 ^ -475933027), (object) (int) ModelRegistrarImpl.hB6xcphE3RLmeOMZs7uV(ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH(), dateTime2).TotalMilliseconds, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1253244298 - 1829393894 ^ -576072808)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 34;
                      continue;
                    case 11:
label_154:
                      ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), ModelRegistrarImpl.VprG0OhEpIdm4mYL18WY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218759498), (object) (int) ModelRegistrarImpl.hB6xcphE3RLmeOMZs7uV(DateTime.Now, dateTime2).TotalMilliseconds, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672138964)));
                      num4 = 45;
                      continue;
                    case 12:
                      try
                      {
                        IActorModelRuntime serviceNotNull2 = Locator.GetServiceNotNull<IActorModelRuntime>();
                        int num14 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                          num14 = 0;
                        switch (num14)
                        {
                          default:
                            try
                            {
                              TaskAwaiter<bool> awaiter = serviceNotNull2.GetActor<IPublicationActor>(Guid.Empty).PublicationStarted().GetAwaiter();
                              int num15 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                                num15 = 0;
                              while (true)
                              {
                                switch (num15)
                                {
                                  case 1:
                                    goto label_100;
                                  case 2:
                                    startInformation = StartInformation.Operation(14.0, EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917070004)));
                                    num15 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                                    continue;
                                  case 3:
                                    goto label_148;
                                  default:
                                    if (awaiter.GetResult())
                                    {
                                      num15 = 2;
                                      continue;
                                    }
                                    goto label_148;
                                }
                              }
label_100:
                              try
                              {
                                ModelRegistrarImpl.z5ygoDhE6VihNm5EdJHJ((object) publicationEventHandler);
                                int num16 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
                                  num16 = 0;
                                switch (num16)
                                {
                                  default:
                                    goto label_148;
                                }
                              }
                              finally
                              {
                                int num17;
                                if (startInformation == null)
                                  num17 = 2;
                                else
                                  goto label_106;
label_105:
                                switch (num17)
                                {
                                  case 1:
                                  case 2:
                                }
label_106:
                                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) startInformation);
                                num17 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                                {
                                  num17 = 1;
                                  goto label_105;
                                }
                                else
                                  goto label_105;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num18 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                                num18 = 1;
                              while (true)
                              {
                                switch (num18)
                                {
                                  case 1:
                                    ModelRegistrarImpl.WrFJrwhEH8iRcUc13Z7K(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), (object) ex);
                                    num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                                    continue;
                                  default:
                                    goto label_148;
                                }
                              }
                            }
                        }
                      }
                      finally
                      {
                        if (disposable2 != null)
                        {
                          int num19 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
                            num19 = 0;
                          while (true)
                          {
                            switch (num19)
                            {
                              case 1:
                                goto label_118;
                              default:
                                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) disposable2);
                                num19 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
                                continue;
                            }
                          }
                        }
label_118:;
                      }
                    case 13:
                      try
                      {
                        this._previousAsmModelsMetadataList = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.Runned);
                        int num20 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                          num20 = 0;
                        switch (num20)
                        {
                          default:
                            goto label_201;
                        }
                      }
                      finally
                      {
                        int num21;
                        if (startInformation == null)
                          num21 = 2;
                        else
                          goto label_125;
label_124:
                        switch (num21)
                        {
                          case 1:
                          case 2:
                        }
label_125:
                        startInformation.Dispose();
                        num21 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                        {
                          num21 = 0;
                          goto label_124;
                        }
                        else
                          goto label_124;
                      }
                    case 14:
                      try
                      {
                        this.BuildHubsAssembly();
                        int num22 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                          num22 = 1;
                        while (true)
                        {
                          switch (num22)
                          {
                            case 1:
                              ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU((object) Logger.Log, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173671359) + (object) (int) ModelRegistrarImpl.hB6xcphE3RLmeOMZs7uV(ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH(), dateTime2).TotalMilliseconds + z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405760119)));
                              num22 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_150;
                          }
                        }
                      }
                      finally
                      {
                        if (startInformation != null)
                        {
                          int num23 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                            num23 = 0;
                          while (true)
                          {
                            switch (num23)
                            {
                              case 1:
                                goto label_88;
                              default:
                                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) startInformation);
                                num23 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
                                continue;
                            }
                          }
                        }
label_88:;
                      }
                    case 15:
                      dbPreUpdater = (DbPreUpdater) ModelRegistrarImpl.URcIOQhEOaIf6vKOwdeg((object) serviceNotNull1);
                      num5 = 21;
                      break;
                    case 16:
label_74:
                      startInformation = (IStartInformation) ModelRegistrarImpl.uGTM6NhEP1WTivFv8sgr(99.0, (object) EleWise.ELMA.SR.M((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1819636893 << 3 ^ 1671990584)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 14;
                      continue;
                    case 17:
                      try
                      {
                        this.Init(parameters1, (IList<Assembly>) null);
                        int num24 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
                          num24 = 0;
                        switch (num24)
                        {
                          default:
                            goto label_154;
                        }
                      }
                      finally
                      {
                        if (startInformation != null)
                        {
                          int num25 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                            num25 = 0;
                          while (true)
                          {
                            switch (num25)
                            {
                              case 1:
                                goto label_137;
                              default:
                                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) startInformation);
                                num25 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
                                continue;
                            }
                          }
                        }
label_137:;
                      }
                    case 18:
                      ModelRegistrarImpl.XWlIc9hfBJ2poxTt2OPq(ModelRegistrarImpl.mwAKgLhfFsefQerrPsaa(), (object) (System.Action) (() =>
                      {
                        int num26 = 1;
                        while (true)
                        {
                          switch (num26)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              modelRegistrarImpl.BuildDynamicModelAssembly(parameters1);
                              num26 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num5 = 20;
                      break;
                    case 19:
label_146:
                      if (ModelRegistrarImpl.kEYJxVhEzDx31dO7Kgu0((object) assemblies) > 0)
                      {
                        num4 = 46;
                        continue;
                      }
                      goto case 42;
                    case 20:
                      ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), ModelRegistrarImpl.VprG0OhEpIdm4mYL18WY(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1886646897 ^ -1886444383), (object) (int) ModelRegistrarImpl.hB6xcphE3RLmeOMZs7uV(ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH(), dateTime2).TotalMilliseconds, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1886646897 ^ -1886553677)));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 22 : 35;
                      continue;
                    case 21:
                      if (dbPreUpdater != null)
                      {
                        num4 = 7;
                        continue;
                      }
                      goto label_155;
                    case 22:
                      ModelRegistrarImpl.NBV50xhEwZAEYM0FeJP0((object) dbPreUpdater);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 32 : 21;
                      continue;
                    case 23:
                      goto label_155;
                    case 24:
                      Locator.GetServiceNotNull<FindReferenceService>().AddMetadata(this._metadataList.Values.OfType<EntityMetadata>());
                      num4 = 10;
                      continue;
                    case 25:
                      setting = EleWise.ELMA.SR.GetSetting<int>((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(272623989 ^ 272417035), 30);
                      num4 = 2;
                      continue;
                    case 26:
label_150:
                      dateTime2 = ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 11 : 24;
                      continue;
                    case 27:
label_201:
                      dbPreUpdater.CheckMetadataList(this._previousAsmModelsMetadataList);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 36 : 25;
                      continue;
                    case 28:
                      pdbRaws = new List<MemoryStream>();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                      continue;
                    case 29:
                      source1 = source1.Where<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a =>
                      {
                        int num27 = 1;
                        while (true)
                        {
                          switch (num27)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (ModelRegistrarImpl.\u003C\u003Ec.kueh44CgljkbB8gL5kla(ModelRegistrarImpl.\u003C\u003Ec.WAmLM6Cg9xRNeYPmJPTH((object) a), ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(-1426456882 ^ 2009939514 ^ -583742832)))
                              {
                                num27 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_5;
                            default:
                              goto label_4;
                          }
                        }
label_4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return ModelRegistrarImpl.\u003C\u003Ec.kueh44CgljkbB8gL5kla(ModelRegistrarImpl.\u003C\u003Ec.WAmLM6Cg9xRNeYPmJPTH((object) a), ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(-1255365154 ^ 596875508 ^ -1765804116));
label_5:
                        return false;
                      })).Concat<AssemblyModelsMetadata>(this._previousAsmModelsMetadataList.Where<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a =>
                      {
                        int num28 = 1;
                        while (true)
                        {
                          switch (num28)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              if (!((string) ModelRegistrarImpl.\u003C\u003Ec.WAmLM6Cg9xRNeYPmJPTH((object) a) == (string) ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(1597012150 ^ 1597010642)))
                              {
                                num28 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                                continue;
                              }
                              goto label_3;
                            default:
                              goto label_2;
                          }
                        }
label_2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return ModelRegistrarImpl.\u003C\u003Ec.BoYxRTCgrm7g1xF6DCUf(ModelRegistrarImpl.\u003C\u003Ec.WAmLM6Cg9xRNeYPmJPTH((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70024026));
label_3:
                        return true;
                      })));
                      num4 = 33;
                      continue;
                    case 30:
                      IEnumerable<IEntityMappingProvider> extensionPoints = ((ComponentManager) ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()).GetExtensionPoints<IEntityMappingProvider>();
                      // ISSUE: reference to a compiler-generated field
                      Func<IEntityMappingProvider, IEnumerable<Type>> func1 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_6;
                      Func<IEntityMappingProvider, IEnumerable<Type>> selector;
                      if (func1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_6 = selector = (Func<IEntityMappingProvider, IEnumerable<Type>>) (p => p.GetMappingTypes());
                      }
                      else
                        goto label_239;
label_211:
                      enumerator2 = extensionPoints.SelectMany<IEntityMappingProvider, Type>(selector).GetEnumerator();
                      num4 = 5;
                      continue;
label_239:
                      selector = func1;
                      goto label_211;
                    case 31:
                      num6 = !serviceNotNull1.IsFirstServerInCluster ? 1 : 0;
                      goto label_206;
                    case 32:
                      if (!serviceNotNull1.IsFirstServerInCluster)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                        continue;
                      }
                      goto case 44;
                    case 33:
label_204:
                      enumerator1 = source1.GetEnumerator();
                      num4 = 6;
                      continue;
                    case 34:
                      NHManagerRegisterParams managerRegisterParams = parameters1;
                      IEnumerable<EntityMetadata> source2 = this._metadataList.Values.OfType<EntityMetadata>();
                      // ISSUE: reference to a compiler-generated field
                      Func<EntityMetadata, bool> func2 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_1;
                      Func<EntityMetadata, bool> predicate1;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_1 = predicate1 = (Func<EntityMetadata, bool>) (metadata =>
                        {
                          int num29 = 2;
                          while (true)
                          {
                            switch (num29)
                            {
                              case 1:
                                goto label_3;
                              case 2:
                                // ISSUE: reference to a compiler-generated method
                                if (ModelRegistrarImpl.\u003C\u003Ec.ogqkN3Cgggq2dPc9NYVn((object) metadata) == EntityMetadataType.Entity)
                                {
                                  num29 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
                                  continue;
                                }
                                goto label_2;
                              default:
                                goto label_2;
                            }
                          }
label_2:
                          // ISSUE: reference to a compiler-generated method
                          return ModelRegistrarImpl.\u003C\u003Ec.ogqkN3Cgggq2dPc9NYVn((object) metadata) == EntityMetadataType.InterfaceImplementation;
label_3:
                          return true;
                        });
                      }
                      else
                        goto label_241;
label_214:
                      // ISSUE: reference to a compiler-generated method
                      IEnumerable<Type> source3 = source2.Where<EntityMetadata>(predicate1).Select<EntityMetadata, Type>((Func<EntityMetadata, Type>) (metadata => modelRegistrarImpl._typesByUid[ModelRegistrarImpl.\u003C\u003Ec__DisplayClass6_0.NCUKxOCg0IZwgOydRYkC((object) metadata)]));
                      // ISSUE: reference to a compiler-generated field
                      Func<Type, bool> func3 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_3;
                      Func<Type, bool> predicate2;
                      if (func3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__6_3 = predicate2 = (Func<Type, bool>) (type => ModelRegistrarImpl.\u003C\u003Ec.t1nqPgCg5pyDvm924iYi(type) == (Type) null);
                      }
                      else
                        goto label_240;
label_216:
                      IEnumerable<Type> types = source3.Where<Type>(predicate2);
                      managerRegisterParams.AddNHibernateClassMappingRange(types);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 41 : 8;
                      continue;
label_240:
                      predicate2 = func3;
                      goto label_216;
label_241:
                      predicate1 = func2;
                      goto label_214;
                    case 35:
                      startInformation = (IStartInformation) ModelRegistrarImpl.uGTM6NhEP1WTivFv8sgr(99.0, ModelRegistrarImpl.hgIkSShEeHFSirvB1wg6(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1876063057 ^ -1875991239)));
                      num5 = 38;
                      break;
                    case 36:
                      dateTime2 = DateTime.Now;
                      num4 = 3;
                      continue;
                    case 37:
                      num6 = ModelRegistrarImpl.pwf3XNhExHw4JX2ZveYd((object) ((MetadataItemManager) ModelRegistrarImpl.efpZtQhE7Lpy90klgyZv()).GetRestartRequiredMetadataUids()) > 0 ? 1 : 0;
                      goto label_206;
                    case 38:
                      try
                      {
                        enumerator1 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.GlobalModule).GetEnumerator();
                        int num30 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                          num30 = 0;
                        switch (num30)
                        {
                          default:
                            try
                            {
label_183:
                              if (ModelRegistrarImpl.JilRh4hEcsSIxTlIWqPc((object) enumerator1))
                                goto label_181;
                              else
                                goto label_184;
label_178:
                              AssemblyModelsMetadata current;
                              Assembly assembly;
                              int num31;
                              while (true)
                              {
                                switch (num31)
                                {
                                  case 1:
                                    goto label_183;
                                  case 2:
                                    goto label_181;
                                  case 3:
                                    if (ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) current) != null)
                                    {
                                      num31 = 4;
                                      continue;
                                    }
                                    goto label_183;
                                  case 4:
                                    assembly = ComponentManager.LoadAssembly((MemoryStream) ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) current), (MemoryStream) ModelRegistrarImpl.Wl7JVPhEgcxNIjiA2Pl0((object) current));
                                    num31 = 5;
                                    continue;
                                  case 5:
                                    ModelRegistrarImpl.AEtwtkhfWC0U0uEK8v85(ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn(), (object) assembly);
                                    num31 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                                    continue;
                                  default:
                                    goto label_74;
                                }
                              }
label_181:
                              current = enumerator1.Current;
                              num31 = 3;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                              {
                                num31 = 0;
                                goto label_178;
                              }
                              else
                                goto label_178;
label_184:
                              num31 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                              goto label_178;
                            }
                            finally
                            {
                              int num32;
                              if (enumerator1 == null)
                                num32 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 0;
                              else
                                goto label_190;
label_189:
                              switch (num32)
                              {
                                case 1:
                                case 2:
                              }
label_190:
                              ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator1);
                              num32 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
                              {
                                num32 = 0;
                                goto label_189;
                              }
                              else
                                goto label_189;
                            }
                        }
                      }
                      finally
                      {
                        if (startInformation != null)
                        {
                          int num33 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                            num33 = 0;
                          while (true)
                          {
                            switch (num33)
                            {
                              case 1:
                                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) startInformation);
                                num33 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_198;
                            }
                          }
                        }
label_198:;
                      }
                    case 39:
                      assemblies = new List<Assembly>();
                      num4 = 28;
                      continue;
                    case 40:
                      ModelRegistrarImpl.oaG8mUhEtGIqnr5HeLQN((object) dbPreUpdater, (object) r);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 22 : 14;
                      continue;
                    case 41:
                      goto label_223;
                    case 42:
                      dateTime2 = ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH();
                      num5 = 18;
                      break;
                    case 43:
                      this.Init(parameters1, (IList<Assembly>) assemblies, pdbRaws: (IList<MemoryStream>) pdbRaws);
                      num4 = 8;
                      continue;
                    case 44:
label_148:
                      source1 = dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.Published);
                      num4 = 39;
                      continue;
                    case 45:
                      if (ModelRegistrarImpl.W2VonghEDp1sNQp329ks((object) dbPreUpdater))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 40 : 7;
                        continue;
                      }
                      goto case 32;
                    case 46:
                      dateTime2 = ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH();
                      num4 = 43;
                      continue;
                    default:
                      if (source1 != null)
                      {
                        num4 = 25;
                        continue;
                      }
                      goto case 9;
                  }
                  num4 = num5;
                  continue;
label_206:
                  if (num6 != 0)
                    num4 = 29;
                  else
                    goto label_204;
                }
label_155:
                throw new InvalidOperationException((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1319452732 ^ 1319528234));
              }
              finally
              {
                int num34;
                if (metadataServiceContext == null)
                  num34 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
                else
                  goto label_220;
label_219:
                switch (num34)
                {
                  case 1:
                  case 2:
                }
label_220:
                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) metadataServiceContext);
                num34 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                {
                  num34 = 1;
                  goto label_219;
                }
                else
                  goto label_219;
              }
            case 2:
              goto label_225;
            case 3:
label_223:
              ModelRegistrarImpl.krLxZlhfo1jHd6SdRGY3();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            default:
              ModelRegistrarImpl.V9eqT4hEaFyxG5KTYqNU((object) Logger.Log, ModelRegistrarImpl.VprG0OhEpIdm4mYL18WY(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-867826612 ^ -867881314), (object) (int) ModelRegistrarImpl.hB6xcphE3RLmeOMZs7uV(ModelRegistrarImpl.HwZMFShEk8CeWGj8sZKH(), dateTime1).TotalMilliseconds, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(979449278 ^ 979386754)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 2;
              continue;
          }
        }
label_225:
        return;
      }
      finally
      {
        if (disposable1 != null)
        {
          int num35 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
            num35 = 1;
          while (true)
          {
            switch (num35)
            {
              case 1:
                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) disposable1);
                num35 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              default:
                goto label_232;
            }
          }
        }
label_232:;
      }
label_235:
      throw new LicenseActivationRequiredException(__ModuleInfo.UID);
    }

    /// <summary>Получить родительский объект метаданных</summary>
    /// <param name="metadataUid">Уникальный идентификатор подчиненного объекта метаданных</param>
    /// <returns>Родительский объект метаданных или Null</returns>
    public IMetadata GetParentMetadata(Guid metadataUid)
    {
      int num = 3;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            this._metadataParents.TryGetValue(metadataUid, out metadata);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IMetadata) null;
label_4:
      return MetadataLoader.LoadMetadata(ModelRegistrarImpl.gFpNn3hfbtFM9pIpBFuP((object) metadata));
    }

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип</returns>
    public Type GetTypeByUid(Guid uid, bool loadImplementation = true)
    {
      Type typeByUidOrNull = this.GetTypeByUidOrNull(uid, loadImplementation);
      return !ModelRegistrarImpl.nVCrBKhfhn5vgCsEkxNR(typeByUidOrNull, (Type) null) ? typeByUidOrNull : throw new TypeNotFoundException(uid);
    }

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип. Если не найден, возвращается Null.</returns>
    public Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true)
    {
      int num1 = 5;
      Type t;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_11;
          case 2:
          case 8:
            if (this.resolvingTypeUids.Add(uid))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 6;
              continue;
            }
            goto case 12;
          case 3:
            goto label_12;
          case 4:
            goto label_52;
          case 5:
            if (ModelRegistrarImpl.i1dslmhfGaIQV5V3IBJA(uid, Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 4 : 1;
              continue;
            }
            if (!this._typesByUid.TryGetValue(uid, out t))
            {
              num1 = 7;
              continue;
            }
            goto case 12;
          case 6:
            try
            {
              IEnumerable<ITypeResolver> extensionPoints = ((ComponentManager) ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()).GetExtensionPoints<ITypeResolver>();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                num2 = 0;
              while (true)
              {
                int num3;
                IEnumerator<ITypeResolver> enumerator;
                switch (num2)
                {
                  case 1:
                    try
                    {
label_33:
                      if (enumerator.MoveNext())
                        goto label_23;
                      else
                        goto label_34;
label_22:
                      ITypeResolver current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                          case 5:
                            goto label_41;
                          case 2:
label_31:
                            if (ModelRegistrarImpl.S1SdV4hfCSkBSyri1HPC(t, (Type) null))
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
                              continue;
                            }
                            goto label_33;
                          case 3:
                            try
                            {
                              t = ModelRegistrarImpl.wEt5wShfEa8qi4IyHtVr((object) current, uid);
                              int num5 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                                num5 = 0;
                              switch (num5)
                              {
                                default:
                                  goto label_31;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num6 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
                                num6 = 0;
                              while (true)
                              {
                                switch (num6)
                                {
                                  case 1:
                                    goto label_31;
                                  default:
                                    ModelRegistrarImpl.UBkMgyhfQTI6aVNvhRiu(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), ModelRegistrarImpl.w8YUuXhffKXZjDWEUk3K((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011880921), (object) uid, (object) current.GetType().FullName), (object) ex);
                                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                                    continue;
                                }
                              }
                            }
                          case 4:
                            goto label_33;
                          default:
                            goto label_23;
                        }
                      }
label_23:
                      current = enumerator.Current;
                      num4 = 3;
                      goto label_22;
label_34:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 5;
                      goto label_22;
                    }
                    finally
                    {
                      int num7;
                      if (enumerator == null)
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 2 : 2;
                      else
                        goto label_38;
label_37:
                      switch (num7)
                      {
                        case 1:
                          break;
                        default:
                      }
label_38:
                      ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator);
                      num7 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                      {
                        num7 = 0;
                        goto label_37;
                      }
                      else
                        goto label_37;
                    }
                  case 2:
label_41:
                    this._typesByUid[uid] = t;
                    num3 = 5;
                    break;
                  case 3:
                    t = (Type) null;
                    num2 = 4;
                    continue;
                  case 4:
                    enumerator = extensionPoints.GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                    continue;
                  case 5:
                    goto label_50;
                  default:
                    if (extensionPoints != null)
                    {
                      num3 = 3;
                      break;
                    }
                    goto label_50;
                }
                num2 = num3;
              }
            }
            finally
            {
              this.resolvingTypeUids.Remove(uid);
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                num8 = 0;
              switch (num8)
              {
                default:
              }
            }
          case 7:
            if (this.resolvingTypeUids != null)
            {
              num1 = 8;
              continue;
            }
            goto case 11;
          case 9:
            goto label_9;
          case 10:
            if (this._removedTypes.TryGetValue(uid, out t))
            {
              num1 = 3;
              continue;
            }
            goto label_11;
          case 11:
            this.resolvingTypeUids = (ISet<Guid>) new HashSet<Guid>();
            num1 = 2;
            continue;
          case 12:
label_50:
            if (!ModelRegistrarImpl.nVCrBKhfhn5vgCsEkxNR(t, (Type) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          default:
            if (!loadImplementation)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 4 : 9;
              continue;
            }
            goto label_10;
        }
      }
label_9:
      return t;
label_10:
      return ModelRegistrarImpl.tqZmAZhfvGmcVTaD1kmJ(t);
label_11:
      return (Type) null;
label_12:
      return t;
label_52:
      return (Type) null;
    }

    /// <summary>Получить метаданные по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public IMetadata GetMetadata(Guid uid, bool loadImplementation = true) => MetadataLoader.LoadMetadata(uid, loadImplementation: loadImplementation);

    /// <summary>Зарегистрировать типы с моделями.</summary>
    /// <remarks>
    /// Используется в любой момент после инициализации приложения.
    /// </remarks>
    /// <param name="types">Типы</param>
    /// <param name="entityNames">Имена сущнстей для переданных типов</param>
    /// <param name="registrationException">Действие, которое нужно выполнять при ошибке регистрации</param>
    /// <param name="asEntity">Регистрировать как сущность</param>
    public void RegisterTypes(
      IEnumerable<Type> types,
      IDictionary<Type, string> entityNames,
      Action<Type, Exception> registrationException,
      bool asEntity)
    {
      if (types == null || !types.Any<Type>())
        return;
      IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
      NHManagerRegisterParams parameters = new NHManagerRegisterParams()
      {
        Builder = new ContainerBuilder(),
        TransformationProvider = serviceNotNull.TransformationProvider
      };
      bool flag = false;
      foreach (Type type in types)
      {
        try
        {
          this.LoadMetadataInternal(type);
          string str;
          flag = this.RegisterTypeAsEntity(type, parameters, asEntity, entityNames == null || !entityNames.TryGetValue(type, out str) ? (string) null : str) | flag;
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870702159), (object) type.FullName), ex);
          if (registrationException != null)
            registrationException(type, ex);
        }
      }
      this.SessionFactoryHolder.UpdateConfiguration(parameters);
      if (!flag)
        return;
      this.UpdateIoC(parameters.Builder);
    }

    /// <summary>Зарегистрировать дельта-сборки и их метаданные</summary>
    /// <param name="result">Результат публикации</param>
    /// <param name="deltaMetadataList">Список дельта-метаданных</param>
    internal void LoadAndRegister(
      MetadataAssemblyPublishResult result,
      IEnumerable<IRootMetadata> deltaMetadataList)
    {
      if (ModelRegistrarImpl.publishLogger.IsTraceEnabled())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ModelRegistrarImpl.publishLogger.Trace((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638605393) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309826480), deltaMetadataList.Select<IRootMetadata, string>((Func<IRootMetadata, string>) (m => (string) ModelRegistrarImpl.\u003C\u003Ec.lLSCTDCgY3dCPBssMnHr((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858726817), (object) ModelRegistrarImpl.\u003C\u003Ec.VAlpu6CgjNuKM8mwO2Gg((object) m), (object) m))))));
      }
      AssemblyModelsMetadata assemblyModelsMetadata1;
      this._asmModelsMetadataDict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501471213), out assemblyModelsMetadata1);
      AssemblyModelsMetadata assemblyModelsMetadata2;
      this._asmModelsMetadataDict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521267602), out assemblyModelsMetadata2);
      ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146450217));
      string str1 = Path.Combine(ComponentManager.Current.WorkDirectory, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837681895));
      if (!Directory.Exists(str1))
        Directory.CreateDirectory(str1);
      IOExtensions.WriteAllBytesWithAttempts(Path.Combine(str1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727416990)), (Stream) result.ConfigurationAssembly.AssemblyRawStream, TimeSpan.FromSeconds(1.0), 15);
      if (result.DynamicAssembly != null)
        IOExtensions.WriteAllBytesWithAttempts(Path.Combine(str1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876049617)), (Stream) result.DynamicAssembly.AssemblyRawStream, TimeSpan.FromSeconds(1.0), 15);
      IEnumerable<Guid> array;
      using (new MetadataServiceContext((IMetadataService) new ExtendedMetadataService((IMetadataService) MetadataServiceContext.MetadataRuntimeService, (IEnumerable<IMetadata>) ((IEnumerable<IRootMetadata>) deltaMetadataList.OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => m.Type == EntityMetadataType.Interface)).Select<EntityMetadata, EntityMetadata>((Func<EntityMetadata, EntityMetadata>) (m =>
      {
        EntityMetadata entityMetadata = new EntityMetadata();
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ModelRegistrarImpl.\u003C\u003Ec.vXgTLhCgUmI44ZZJrSjs((object) entityMetadata, ModelRegistrarImpl.\u003C\u003Ec.w9fQ1hCgLFlF6HgG3hwv((object) m));
        // ISSUE: reference to a compiler-generated method
        ModelRegistrarImpl.\u003C\u003Ec.aZ9fLtCgs0fw9HdGMPIc((object) entityMetadata, EntityMetadataType.InterfaceImplementation);
        return entityMetadata;
      }))).Concat<IRootMetadata>(deltaMetadataList))))
        array = (IEnumerable<Guid>) deltaMetadataList.SelectMany<IRootMetadata, Guid>(new Func<IRootMetadata, IEnumerable<Guid>>(MetadataLoader.GetDependentMetadataUids)).Distinct<Guid>().ToArray<Guid>();
      Type type1;
      // ISSUE: object of a compiler-generated type is created
      List<\u003C\u003Ef__AnonymousType16<Type, Guid>> list = array.Select(uid => !this._typesByUid.TryGetValue(uid, out type1) || !(type1 != (Type) null) ? null : new \u003C\u003Ef__AnonymousType16<Type, Guid>(type1, uid)).Where(d => d != null).ToList();
      list.ForEach(d =>
      {
        FilterTypeAttribute reflectionCustomAttribute = d.type.GetReflectionCustomAttribute<FilterTypeAttribute>();
        PublishCacheContext.RemoveFromCache(d.type, d.uid);
        if (reflectionCustomAttribute == null)
          return;
        PublishCacheContext.RemoveFromCache(reflectionCustomAttribute.FilterType, d.uid);
      });
      IEnumerable<Type> changedTypes1;
      IEnumerable<Type> newTypes1;
      EntityDynamicGenerator.LoadDeltaAssembly(result.ConfigurationDeltaAssemblyRaw, out changedTypes1, out newTypes1);
      ComponentManager.UpdateAssemblyRaw(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87860935), false), result.ConfigurationAssembly.AssemblyRawStream);
      IEnumerable<Type> changedTypes2 = Enumerable.Empty<Type>();
      IEnumerable<Type> newTypes2 = Enumerable.Empty<Type>();
      if (result.DynamicAssembly != null)
      {
        EntityDynamicGenerator.LoadDeltaAssembly(result.DynamicDeltaAssemblyRaw, out changedTypes2, out newTypes2);
        ComponentManager.UpdateAssemblyRaw(ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218494080), false), result.DynamicAssembly.AssemblyRawStream);
      }
      ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461555179));
      List<Guid> guidList1 = new List<Guid>();
      List<Guid> guidList2 = new List<Guid>();
      // ISSUE: reference to a compiler-generated method
      HashSet<Guid> hashSet1 = deltaMetadataList.Where<IRootMetadata>((Func<IRootMetadata, bool>) (t =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (t is IDeltaRootMetadata)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return !(t is EntityMetadata);
label_3:
        return false;
      })).Select<IRootMetadata, Guid>((Func<IRootMetadata, Guid>) (m => ModelRegistrarImpl.\u003C\u003Ec.VAlpu6CgjNuKM8mwO2Gg((object) m))).ToHashSet<Guid>();
      HashSet<Type> hashSet2 = newTypes1.Concat<Type>(newTypes2).ToHashSet<Type>();
      HashSet<Type> hashSet3 = changedTypes1.Concat<Type>(changedTypes2).Concat<Type>((IEnumerable<Type>) hashSet2).ToHashSet<Type>();
      foreach (EntityMetadata entityMetadata in deltaMetadataList.OfType<EntityMetadata>())
      {
        if (entityMetadata.Type == EntityMetadataType.Interface)
          guidList1.Add(entityMetadata.Uid);
        else if (entityMetadata.Type == EntityMetadataType.InterfaceExtension)
          guidList2.Add(entityMetadata.BaseClassUid);
      }
      Dictionary<Guid, AbstractMetadata> dictionary1;
      if (assemblyModelsMetadata1 == null)
      {
        dictionary1 = (Dictionary<Guid, AbstractMetadata>) null;
      }
      else
      {
        AbstractMetadata[] source = assemblyModelsMetadata1.RestoreMetadata();
        // ISSUE: reference to a compiler-generated method
        dictionary1 = source != null ? ((IEnumerable<AbstractMetadata>) source).ToDictionary<AbstractMetadata, Guid>((Func<AbstractMetadata, Guid>) (m => ModelRegistrarImpl.\u003C\u003Ec.ODkKseCgcVmUcpuVTmxC((object) m))) : (Dictionary<Guid, AbstractMetadata>) null;
      }
      if (dictionary1 == null)
        dictionary1 = new Dictionary<Guid, AbstractMetadata>();
      Dictionary<Guid, AbstractMetadata> dictionary2 = dictionary1;
      foreach (Type type2 in newTypes1.Concat<Type>(changedTypes1))
      {
        bool flag = false;
        UidAttribute attribute1 = AttributeHelper<UidAttribute>.GetAttribute(type2, true);
        if (attribute1 != null)
        {
          flag = hashSet1.Contains(attribute1.Uid);
          if (flag)
            ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521326350), (object) type2.AssemblyQualifiedName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082328530));
          if (guidList1.Contains(attribute1.Uid))
          {
            ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710646216), (object) type2.Assembly);
            ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574337888), (object) type2.AssemblyQualifiedName, (object) attribute1.Uid);
            flag = true;
          }
        }
        BaseClassAttribute attribute2 = AttributeHelper<BaseClassAttribute>.GetAttribute(type2, true);
        if (attribute2 != null && guidList2.Contains(attribute2.BaseClassUid))
        {
          ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398472138), (object) type2.AssemblyQualifiedName);
          ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669137459), (object) type2.AssemblyQualifiedName, (object) attribute1.Uid);
          flag = true;
        }
        if (flag)
        {
          if (ModelRegistrarImpl.publishLogger.IsTraceEnabled())
            ModelRegistrarImpl.publishLogger.Trace((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29183857), (object) type2.AssemblyQualifiedName, type2 is TypeBuilder typeBuilder ? (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011881637), (object) typeBuilder.IsCreated()) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70194873), (object) type2.GetHashCode()));
          if (this.LoadMetadataInternal(type2) is AbstractMetadata abstractMetadata)
          {
            ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139013808), (object) type2.AssemblyQualifiedName);
            dictionary2[abstractMetadata.Uid] = abstractMetadata;
          }
        }
      }
      ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334922527));
      AssemblyModelsMetadata assemblyModelsMetadata3 = new AssemblyModelsMetadata()
      {
        Id = assemblyModelsMetadata1 != null ? assemblyModelsMetadata1.Id : 0L,
        Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837665249),
        AssemblyRawStream = result.ConfigurationAssembly.AssemblyRawStream,
        DocumentationRawStream = result.ConfigurationAssembly.DocumentationRawStream,
        Status = AssemblyModelsMetadataStatus.Runned
      };
      assemblyModelsMetadata3.SetMetadata(dictionary2.Values.ToArray<AbstractMetadata>());
      this._asmModelsMetadataDict[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638400907)] = assemblyModelsMetadata3;
      this.configUids.Clear();
      this.configUids.UnionWith((IEnumerable<Guid>) dictionary2.Keys);
      if (result.DynamicAssembly != null)
      {
        ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178148974));
        try
        {
          Dictionary<Guid, AbstractMetadata> dictionary3;
          if (assemblyModelsMetadata2 == null)
          {
            dictionary3 = (Dictionary<Guid, AbstractMetadata>) null;
          }
          else
          {
            AbstractMetadata[] source = assemblyModelsMetadata2.RestoreMetadata();
            // ISSUE: reference to a compiler-generated method
            dictionary3 = source != null ? ((IEnumerable<AbstractMetadata>) source).ToDictionary<AbstractMetadata, Guid>((Func<AbstractMetadata, Guid>) (m => ModelRegistrarImpl.\u003C\u003Ec.ODkKseCgcVmUcpuVTmxC((object) m))) : (Dictionary<Guid, AbstractMetadata>) null;
          }
          if (dictionary3 == null)
            dictionary3 = new Dictionary<Guid, AbstractMetadata>();
          Dictionary<Guid, AbstractMetadata> dictionary4 = dictionary3;
          foreach (Type type3 in newTypes2.Concat<Type>(changedTypes2))
          {
            if (!type3.IsInterface)
            {
              ImplementationUidAttribute attribute = AttributeHelper<ImplementationUidAttribute>.GetAttribute(type3, true);
              if (attribute != null)
              {
                ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647852128), (object) type3.AssemblyQualifiedName, (object) attribute.Uid);
                if (this.LoadMetadataInternal(type3) is AbstractMetadata abstractMetadata)
                {
                  ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289905960), (object) type3.AssemblyQualifiedName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234098462));
                  dictionary4[abstractMetadata.Uid] = abstractMetadata;
                }
              }
            }
          }
          AssemblyModelsMetadata assemblyModelsMetadata4 = new AssemblyModelsMetadata()
          {
            Id = assemblyModelsMetadata2 != null ? assemblyModelsMetadata2.Id : 0L,
            Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70005469),
            AssemblyRawStream = result.DynamicAssembly.AssemblyRawStream,
            DocumentationRawStream = result.DynamicAssembly.DocumentationRawStream,
            Status = AssemblyModelsMetadataStatus.Runned
          };
          assemblyModelsMetadata4.SetMetadata(dictionary4.Values.ToArray<AbstractMetadata>());
          this._asmModelsMetadataDict[z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405832293)] = assemblyModelsMetadata4;
        }
        catch (ReflectionTypeLoadException ex)
        {
          string str2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3271668), ((IEnumerable<Exception>) ex.LoaderExceptions).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
          Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979502496) + str2), (Exception) ex);
          throw;
        }
      }
      list.Where(d => !this._typesByUid.ContainsKey(d.uid)).ForEach(d => this.LoadMetadataInternal(d.type));
      this.RegisterDeltaTypes((ISet<Type>) hashSet3, (ISet<Type>) hashSet2);
    }

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList() => (IEnumerable<IMetadata>) this._metadataList.Values;

    /// <summary>Получить список метаданных моделей сборок</summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList() => (IEnumerable<AssemblyModelsMetadata>) this._asmModelsMetadataDict.Values;

    /// <summary>
    /// Получить список метаданных моделей сборок в предыдущий запуск приложения
    /// </summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList() => this._previousAsmModelsMetadataList;

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetTypeDescriptors() => (IEnumerable<ITypeDescriptor>) this._typeDescriptorsByUid.Values;

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
    {
      int num = 1;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._typeDescriptorsByUid.TryGetValue((typeUid, subTypeUid), out typeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_5;
          case 4:
            this._typeDescriptorsByUid.TryGetValue((typeUid, Guid.Empty), out typeDescriptor);
            num = 3;
            continue;
          default:
            if (typeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 2;
              continue;
            }
            goto case 4;
        }
      }
label_5:
      return typeDescriptor;
label_6:
      return typeDescriptor;
    }

    /// <summary>
    /// Получить описание типа данных по его типу CLR. Если не нашли - null
    /// </summary>
    /// <param name="runtimeType">Тип CLR</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
    {
      int num = 1;
      Type genericArgument;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._typeDescriptorsByType.TryGetValue(runtimeType, out typeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
          case 5:
            goto label_8;
          case 3:
            if (runtimeType.IsGenericType)
            {
              num = 6;
              continue;
            }
            goto label_8;
          case 6:
            // ISSUE: type reference
            if (!ModelRegistrarImpl.nVCrBKhfhn5vgCsEkxNR(runtimeType.GetGenericTypeDefinition(), ModelRegistrarImpl.HlH5dnhf8tQP4FsdRdNP(__typeref (Nullable<>))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 5;
              continue;
            }
            goto case 8;
          case 7:
            this._typeDescriptorsByType.TryGetValue(genericArgument, out typeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
            continue;
          case 8:
            genericArgument = runtimeType.GetGenericArguments()[0];
            num = 7;
            continue;
          default:
            if (typeDescriptor != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 4;
              continue;
            }
            goto case 3;
        }
      }
label_8:
      return typeDescriptor;
    }

    /// <summary>
    /// Получить описание типов данных, которые можно использовать для первичного ключа
    /// </summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors() => this._typeDescriptorsByUid.Values.Where<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t => ModelRegistrarImpl.\u003C\u003Ec.mir18ACgzCVeNNqA3dup((object) t)));

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
    {
      int num1 = 1;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              typeDescriptor = this.GetTypeDescriptor(typeUid, Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 2:
            case 3:
              goto label_7;
            case 4:
              goto label_3;
            default:
              if (typeDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 2;
                continue;
              }
              goto label_3;
          }
        }
label_3:
        if (!typeDescriptor.UseForId)
          num1 = 3;
        else
          goto label_8;
      }
label_7:
      return (ITypeDescriptor) null;
label_8:
      return typeDescriptor;
    }

    /// <summary>Выполнить действия при мягкой публикации метаданных</summary>
    /// <param name="metadata"></param>
    public void OnSoftPublished(ICollection<IRootMetadata> metadatas)
    {
      Type type;
      // ISSUE: object of a compiler-generated type is created
      List<\u003C\u003Ef__AnonymousType16<Type, Guid>> list = metadatas.SelectMany<IRootMetadata, Guid>(new Func<IRootMetadata, IEnumerable<Guid>>(MetadataLoader.GetDependentMetadataUids)).Distinct<Guid>().Select(uid => !this._typesByUid.TryGetValue(uid, out type) ? null : new \u003C\u003Ef__AnonymousType16<Type, Guid>(type, uid)).Where(d => d != null).ToList();
      list.ForEach(d =>
      {
        FilterTypeAttribute reflectionCustomAttribute = d.type.GetReflectionCustomAttribute<FilterTypeAttribute>();
        PublishCacheContext.RemoveFromCache(d.type, d.uid);
        if (reflectionCustomAttribute == null)
          return;
        PublishCacheContext.RemoveFromCache(reflectionCustomAttribute.FilterType, d.uid);
      });
      list.ForEach(d => this.LoadMetadataInternal(d.type));
      list.ForEach(d =>
      {
        if (!(MetadataLoader.LoadMetadata(d.type) is ICompositeMetadata metadata2))
          return;
        this.ProcessCompositeMetadata(d.type.Assembly, metadata2);
      });
      this._removedTypes.Where<KeyValuePair<Guid, Type>>((Func<KeyValuePair<Guid, Type>, bool>) (p => !this._typesByUid.ContainsKey(p.Key))).ForEach<KeyValuePair<Guid, Type>>((Action<KeyValuePair<Guid, Type>>) (p => this.LoadMetadataInternal(p.Value)));
      this._removedTypes.Clear();
    }

    /// <summary>
    /// Признак, что требуется перекомпиляция сценариев модели дизайнера
    /// </summary>
    public bool ConfigurationScriptsRecompileRequired
    {
      get => this.\u003CConfigurationScriptsRecompileRequired\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CConfigurationScriptsRecompileRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    /// <summary>Ошибки при компиляции сценариев</summary>
    public string ConfigurationScriptsErrors
    {
      get => this.\u003CConfigurationScriptsErrors\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CConfigurationScriptsErrors\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    /// <summary>Являются ли метаданные системными</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    public bool IsSystem(Guid typeUid)
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this._typesByUid.TryGetValue(typeUid, out type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (ModelRegistrarImpl.S1SdV4hfCSkBSyri1HPC(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return !this.configUids.Contains(typeUid);
label_3:
      return false;
    }

    /// <summary>Являются ли метаданные созданными в конфигурации</summary>
    /// <param name="typeUid">Идентификатор метаданных</param>
    public bool IsConfig(Guid typeUid)
    {
      int num = 3;
      while (true)
      {
        Type type;
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
          case 4:
            goto label_3;
          case 3:
            if (!this._typesByUid.TryGetValue(typeUid, out type))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
              continue;
            }
            break;
        }
        if (!ModelRegistrarImpl.S1SdV4hfCSkBSyri1HPC(type, (Type) null))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 4;
        else
          break;
      }
label_2:
      return this.configUids.Contains(typeUid);
label_3:
      return false;
    }

    /// <summary>Инициализация моделей из указанных сборок</summary>
    /// <param name="parameters">Параметры регистрации менеджера NHibernate</param>
    /// <param name="assemblies">Список сборок. Если null, то берутся все сборки, загруженные в текущий домен приложения</param>
    /// <param name="preparedModelsMetadata">Список с информацией о сборках из параметра <paramref name="assemblies" />, подготовленные предыдущий запуск системы. Используется для оптимизации запуска.</param>
    /// <param name="docRaws">Список документаций к сборкам</param>
    /// <param name="pdbRaws">Список pdb к сборкам</param>
    private void Init(
      NHManagerRegisterParams parameters,
      IList<Assembly> assemblies,
      IEnumerable<AssemblyModelsMetadata> preparedModelsMetadata = null,
      IList<MemoryStream> docRaws = null,
      IList<MemoryStream> pdbRaws = null)
    {
      DateTime now1 = DateTime.Now;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      assemblies = assemblies ?? (IList<Assembly>) ((IEnumerable<Assembly>) ComponentManager.GetAssemblies()).ToList<Assembly>().Where<Assembly>((Func<Assembly, bool>) (a => (string) ModelRegistrarImpl.\u003C\u003Ec.qGX9SoC5FunX93ScTHoA((object) a) != (string) ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(1597012150 ^ 1597010584))).ToList<Assembly>();
      this.RegisterTypeDescriptors(assemblies);
      DateTime now2 = DateTime.Now;
      EleWise.ELMA.SR.RunWithCulture(EleWise.ELMA.SR.KeyCultureInfo, (System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.InitModelsMetadata(assemblies, preparedModelsMetadata, docRaws, pdbRaws);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538580852), (object) (int) (DateTime.Now - now2).TotalMilliseconds));
      DateTime now3 = DateTime.Now;
      this.RegisterEntityManagers(parameters, assemblies);
      ILogger log1 = Logger.Log;
      string format1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574330498);
      TimeSpan timeSpan = DateTime.Now - now3;
      // ISSUE: variable of a boxed type
      __Boxed<int> totalMilliseconds1 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
      string message1 = string.Format(format1, (object) totalMilliseconds1);
      log1.Debug((object) message1);
      DateTime now4 = DateTime.Now;
      // ISSUE: reference to a compiler-generated method
      parameters.AddRange(ComponentManager.Current.GetExtensionPointTypes(typeof (IEntity)).Where<Type>((Func<Type, bool>) (type =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (assemblies.Contains(type.Assembly))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 3:
              if (assemblies != null)
              {
                num = 2;
                continue;
              }
              goto label_4;
            default:
              if (!type.ContainsGenericParameters)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return !type.IsAbstract;
label_3:
        return false;
label_4:
        return true;
      })).Select<Type, Type>((Func<Type, Type>) (type => ModelRegistrarImpl.GetClassMapType(type))).Where<Type>((Func<Type, bool>) (сlassMapType => ModelRegistrarImpl.\u003C\u003Ec.BqWU2rC5BwZGEPTtMcJK(сlassMapType, (Type) null))));
      ILogger log2 = Logger.Log;
      string format2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323272992);
      timeSpan = DateTime.Now - now4;
      // ISSUE: variable of a boxed type
      __Boxed<int> totalMilliseconds2 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
      string message2 = string.Format(format2, (object) totalMilliseconds2);
      log2.Debug((object) message2);
    }

    /// <summary>Инициализировать метаданные моделей</summary>
    /// <param name="assemblies">Список сборок</param>
    /// <param name="preparedModelsMetadata">Список с информацией о сборках из параметра <paramref name="assemblies" />, подготовленные предыдущий запуск системы. Используется для оптимизации запуска.</param>
    /// <param name="docRaws">Список документаций к сборкам</param>
    /// <param name="pdbRaws">Список pdb к сборкам</param>
    private void InitModelsMetadata(
      [NotNull] IList<Assembly> assemblies,
      IEnumerable<AssemblyModelsMetadata> preparedModelsMetadata,
      IList<MemoryStream> docRaws,
      IList<MemoryStream> pdbRaws)
    {
      Contract.ArgumentNotNull((object) assemblies, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317770926));
      ApplicationStartCache applicationStartCache = Locator.GetServiceNotNull<IRuntimeApplication>().ApplicationStartCache;
      foreach (Assembly assembly in (IEnumerable<Assembly>) assemblies)
      {
        if (AttributeHelper<ModelAssemblyAttribute>.GetAttribute(assembly) != null)
        {
          this._modelAssemblies.Add(assembly);
          Dictionary<Guid, IRootMetadata> metadataCache = (Dictionary<Guid, IRootMetadata>) null;
          Action<AssemblyModelsMetadata> action = (Action<AssemblyModelsMetadata>) (m =>
          {
            int num1 = 2;
            IEnumerator<IRootMetadata> enumerator;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_16;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  enumerator = ((IEnumerable) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass46_0.Oikqd6C5Z0Fd3aCZl9vI((object) m)).OfType<IRootMetadata>().GetEnumerator();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 3 : 1;
                  continue;
                case 2:
                  metadataCache = new Dictionary<Guid, IRootMetadata>();
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                  continue;
                case 3:
                  goto label_4;
                default:
                  goto label_11;
              }
            }
label_16:
            return;
label_11:
            return;
label_4:
            try
            {
label_7:
              // ISSUE: reference to a compiler-generated method
              if (ModelRegistrarImpl.\u003C\u003Ec__DisplayClass46_0.GjC89xC5IcxDTatpRQv6((object) enumerator))
                goto label_10;
              else
                goto label_8;
label_5:
              IRootMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_6;
                  case 1:
                    goto label_10;
                  case 2:
                    goto label_7;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    metadataCache[ModelRegistrarImpl.\u003C\u003Ec__DisplayClass46_0.PwBCeiC5uEb7xQQaex7J((object) current)] = current;
                    num2 = 2;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_6:
              return;
label_2:
              return;
label_8:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              goto label_5;
label_10:
              current = enumerator.Current;
              num2 = 3;
              goto label_5;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_18;
                  }
                }
              }
label_18:;
            }
          });
          string asmName = ComponentManager.GetAssemblyShortName(assembly);
          AssemblyModelsMetadata assemblyModelsMetadata1 = (AssemblyModelsMetadata) null;
          // ISSUE: reference to a compiler-generated method
          AssemblyModelsMetadata assemblyModelsMetadata2 = this._previousAsmModelsMetadataList.FirstOrDefault<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a => (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass46_0.WPnMm0C5VEMvSJvAHL0C((object) a) == asmName));
          AssemblyModelsMetadata assemblyModelsMetadata3 = (AssemblyModelsMetadata) null;
          if (!applicationStartCache.GetAssemblyInfo(assembly)._changed && assemblyModelsMetadata2 != null && assemblyModelsMetadata2.Status == AssemblyModelsMetadataStatus.Runned)
          {
            assemblyModelsMetadata1 = assemblyModelsMetadata2;
            if (assemblyModelsMetadata1 != null)
              action(assemblyModelsMetadata1);
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            assemblyModelsMetadata3 = preparedModelsMetadata != null ? preparedModelsMetadata.FirstOrDefault<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a => ModelRegistrarImpl.\u003C\u003Ec__DisplayClass46_0.Dr3vL9C5Sj0cUwDadWmU((object) a.Name, (object) asmName))) : (AssemblyModelsMetadata) null;
            if (assemblyModelsMetadata3 != null)
              action(assemblyModelsMetadata3);
          }
          List<AbstractMetadata> abstractMetadataList = new List<AbstractMetadata>();
          try
          {
            foreach (Type type in assembly.GetTypes())
            {
              if (this.LoadMetadataInternal(type, metadataCache) is AbstractMetadata abstractMetadata)
                abstractMetadataList.Add(abstractMetadata);
            }
          }
          catch (ReflectionTypeLoadException ex)
          {
            string str = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767798291), ((IEnumerable<Exception>) ex.LoaderExceptions).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
            Logger.Log.Error((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727420386) + assembly.FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574253422) + str), (Exception) ex);
            throw;
          }
          if (assemblyModelsMetadata1 == null)
          {
            assemblyModelsMetadata1 = new AssemblyModelsMetadata()
            {
              Id = assemblyModelsMetadata2 != null ? assemblyModelsMetadata2.Id : 0L,
              Name = asmName
            };
            byte[] buffer = ComponentManager.GetLoadedAssemblyRaw(assembly);
            MemoryStream destination1 = pdbRaws?[assemblies.IndexOf(assembly)];
            MemoryStream destination2 = docRaws?[assemblies.IndexOf(assembly)];
            if (buffer == null && !assembly.IsDynamic && assembly.Location != null && File.Exists(assembly.Location))
            {
              buffer = File.ReadAllBytes(assembly.Location);
              string path1 = Path.ChangeExtension(assembly.Location, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859022503));
              if (destination1 == null && File.Exists(path1))
              {
                using (FileStream fileStream = new FileStream(path1, FileMode.Open, FileAccess.Read))
                {
                  destination1 = MemoryHelper.GetMemoryStream((int) fileStream.Length);
                  fileStream.CopyTo((Stream) destination1);
                  destination1.Seek(0L, SeekOrigin.Begin);
                }
              }
              string path2 = Path.ChangeExtension(assembly.Location, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121192517));
              if (destination2 == null && File.Exists(path2))
              {
                using (FileStream fileStream = new FileStream(path2, FileMode.Open, FileAccess.Read))
                {
                  destination2 = MemoryHelper.GetMemoryStream((int) fileStream.Length);
                  fileStream.CopyTo((Stream) destination2);
                  destination2.Seek(0L, SeekOrigin.Begin);
                }
              }
            }
            if (buffer != null)
            {
              assemblyModelsMetadata1.AssemblyRawStream = MemoryHelper.GetMemoryStream(buffer.Length);
              assemblyModelsMetadata1.AssemblyRawStream.Write(buffer, 0, buffer.Length);
            }
            assemblyModelsMetadata1.DebugRawStream = destination1;
            assemblyModelsMetadata1.DocumentationRawStream = destination2;
            if (assemblyModelsMetadata3 != null)
              assemblyModelsMetadata1.MetadataStream = assemblyModelsMetadata3.MetadataStream;
            else
              assemblyModelsMetadata1.SetMetadata(abstractMetadataList.ToArray());
          }
          if (this._asmModelsMetadataDict.ContainsKey(asmName))
            Logger.Log.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998354778), (object) asmName);
          this._asmModelsMetadataDict.Add(asmName, assemblyModelsMetadata1);
          if (asmName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822888836))
          {
            this.configUids.Clear();
            this.configUids.UnionWith(((IEnumerable<AbstractMetadata>) assemblyModelsMetadata1.RestoreMetadata()).Select<AbstractMetadata, Guid>((Func<AbstractMetadata, Guid>) (m => m.Uid)));
          }
        }
      }
    }

    /// <summary>Загрузить метаданные для указанного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="metadataCache">Кэш с загруженными метаданными. Используется для оптимизации запуска приложения</param>
    /// <returns></returns>
    private IMetadata LoadMetadataInternal(Type type, Dictionary<Guid, IRootMetadata> metadataCache = null)
    {
      try
      {
        if (!type.IsInterface && type.IsAbstract || type.ContainsGenericParameters)
          return (IMetadata) null;
        MetadataTypeAttribute attribute1 = AttributeHelper<MetadataTypeAttribute>.GetAttribute(type, false);
        if (attribute1 == null || !typeof (AbstractMetadata).IsAssignableFrom(attribute1.MetadataType) || attribute1.MetadataType.IsDefined(typeof (PartialMetadataTypeAttribute), false) || attribute1.MetadataType.GetInterface(typeof (IRootMetadata).FullName) == (Type) null)
        {
          if (AttributeHelper<FilterForAttribute>.GetAttribute(type, true) != null && type.Assembly.IsDynamicAssembly())
            EntityDynamicProvider.AddType(type);
          return (IMetadata) null;
        }
        if (metadataCache != null)
        {
          UidAttribute attribute2 = AttributeHelper<UidAttribute>.GetAttribute(type, true);
          IRootMetadata metadata;
          if (attribute2 != null && metadataCache.TryGetValue(attribute2.Uid, out metadata))
            MetadataLoader.AddMetadataToCache(type, metadata, false);
        }
        IMetadata metadata1 = MetadataLoader.LoadMetadata(type, false, false);
        Type type1;
        if (this._typesByUid.TryGetValue(metadata1.Uid, out type1) && type1 != (Type) null)
          return (IMetadata) null;
        this._typesByUid[metadata1.Uid] = type;
        this._metadataList[metadata1.Uid] = metadata1;
        if (type.Assembly.IsDynamicAssembly())
          EntityDynamicProvider.AddType(type);
        if (metadata1 is ICompositeMetadata metadata2)
          this.ProcessCompositeMetadata(type.Assembly, metadata2);
        return metadata1;
      }
      catch (Exception ex)
      {
        throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124708492)), (object) type.AssemblyQualifiedName), ex);
      }
    }

    /// <summary>Обработать составные метаданные</summary>
    /// <param name="assembly">Сборка, в которой находится объект метаданных</param>
    /// <param name="metadata">Объект метаданных</param>
    private void ProcessCompositeMetadata(Assembly assembly, ICompositeMetadata metadata)
    {
      int num1 = 2;
      IEnumerator<IMetadata> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_26;
          case 1:
            goto label_2;
          case 2:
            enumerator = metadata.GetCompositeParts().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          default:
            goto label_21;
        }
      }
label_26:
      return;
label_21:
      return;
label_2:
      try
      {
label_13:
        if (ModelRegistrarImpl.JilRh4hEcsSIxTlIWqPc((object) enumerator))
          goto label_5;
        else
          goto label_14;
label_3:
        ICodeItemMetadata codeItemMetadata;
        Type type;
        IMetadata current;
        ICompositeMetadata metadata1;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (metadata1 != null)
              {
                num2 = 3;
                continue;
              }
              goto label_13;
            case 2:
              this._typesByUid[ModelRegistrarImpl.gFpNn3hfbtFM9pIpBFuP((object) current)] = type;
              num2 = 12;
              continue;
            case 3:
              this.ProcessCompositeMetadata(assembly, metadata1);
              num2 = 5;
              continue;
            case 4:
              goto label_8;
            case 5:
              goto label_13;
            case 6:
              this._metadataList[ModelRegistrarImpl.gFpNn3hfbtFM9pIpBFuP((object) current)] = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 7 : 3;
              continue;
            case 7:
              this._metadataParents[current.Uid] = (IMetadata) metadata;
              num2 = 10;
              continue;
            case 8:
              type = ModelRegistrarImpl.Wtt178hfZpB8Q7bU4fpj((object) assembly, (object) codeItemMetadata.FullTypeName);
              num2 = 9;
              continue;
            case 9:
              if (ModelRegistrarImpl.S1SdV4hfCSkBSyri1HPC(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 2;
                continue;
              }
              goto case 12;
            case 10:
              codeItemMetadata = current as ICodeItemMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 11:
              goto label_5;
            case 12:
            case 13:
              metadata1 = current as ICompositeMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
              continue;
            default:
              if (codeItemMetadata == null)
              {
                num2 = 13;
                continue;
              }
              goto case 8;
          }
        }
label_8:
        return;
label_5:
        current = enumerator.Current;
        num2 = 6;
        goto label_3;
label_14:
        num2 = 4;
        goto label_3;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_28;
              default:
                ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_28:;
      }
    }

    /// <summary>
    /// Зарегистрировать тип как сущность. Регистрирует метаданные типы, маппинги Nhibernate и менеджер сущности.
    /// </summary>
    /// <remarks>
    /// Используется для доконфигурирования Nhibernate после запуска. Например, для регистрации сущностей контекст процессов.
    /// </remarks>
    /// <param name="type">Тип</param>
    /// <param name="parameters">Параметры для регистрации менеджера NHibernate</param>
    /// <param name="asEntity">Регистрировать как сущность</param>
    /// <param name="tableNumber">Номер таблицы</param>
    /// <param name="dynamicInsert">Динамическое добавление в таблицу</param>
    /// <param name="dynamicUpdate">Динамическое обновление таблицы</param>
    /// <returns>Наличие изменений в ContainerBuilder</returns>
    private bool RegisterTypeAsEntity(
      Type type,
      NHManagerRegisterParams parameters,
      bool asEntity,
      string entityName = null,
      int? tableNumber = null,
      bool? dynamicInsert = null,
      bool? dynamicUpdate = null)
    {
      if (!typeof (IEntity).IsAssignableFrom(type))
        return false;
      bool? nullable1;
      if (asEntity && this.SessionFactoryHolder.SessionFactory.GetClassMetadata(type)?.MappedClass != type && MetadataLoader.LoadMetadata(type, false) is EntityMetadata entityMetadata && type.IsClass)
      {
        Locator.GetServiceNotNull<FindReferenceService>().AddMetadata((IEnumerable<EntityMetadata>) new EntityMetadata[1]
        {
          entityMetadata
        });
        if (!this.RegisterTypeMapByClassMap(type, parameters))
        {
          NHManagerRegisterParams managerRegisterParams = parameters;
          Type type1 = type;
          string entityName1 = entityName != type.FullName ? entityName : (string) null;
          int? tableNumber1 = tableNumber;
          bool? dynamicInsert1 = dynamicInsert;
          nullable1 = dynamicUpdate;
          bool? dynamicUpdate1;
          if (((int) nullable1 ?? (AttributeHelper<CompositeEntityPartAttribute>.GetAttributes(type, false).Count > 0 ? 1 : 0)) == 0)
          {
            nullable1 = new bool?();
            dynamicUpdate1 = nullable1;
          }
          else
            dynamicUpdate1 = new bool?(true);
          managerRegisterParams.AddNHibernateClassMapping(type1, entityName1, tableNumber1, dynamicInsert1, dynamicUpdate1);
        }
      }
      bool flag = this.registeredTypes.Add(type) && this.RegisterTypeDefaultManager(type, parameters.Builder);
      List<(Type, string, int?, bool?, bool?)> valueTupleList1 = new List<(Type, string, int?, bool?, bool?)>();
      foreach (CompositeEntityPartAttribute attribute in (IEnumerable<CompositeEntityPartAttribute>) AttributeHelper<CompositeEntityPartAttribute>.GetAttributes(type, false))
      {
        List<(Type, string, int?, bool?, bool?)> valueTupleList2 = valueTupleList1;
        Type entityType = attribute.EntityType;
        int? nullable2 = new int?(attribute.TableNumber);
        nullable1 = new bool?();
        bool? nullable3 = nullable1;
        bool? nullable4 = new bool?(true);
        (Type, string, int?, bool?, bool?) valueTuple = (entityType, (string) null, nullable2, nullable3, nullable4);
        valueTupleList2.Add(valueTuple);
      }
      foreach (TablePartAttribute attribute1 in (IEnumerable<TablePartAttribute>) AttributeHelper<TablePartAttribute>.GetAttributes(type, false))
      {
        string str = (string) null;
        TablePartInfoAttribute attribute2 = entityName != null ? AttributeHelper<TablePartInfoAttribute>.GetAttribute(attribute1.TablePartType, false) : (TablePartInfoAttribute) null;
        if (attribute2 != null)
          str = entityName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283382433) + attribute2.TablePartPropertyName;
        valueTupleList1.Add((attribute1.TablePartType, str, new int?(), new bool?(), new bool?()));
      }
      foreach ((Type, string, int?, bool?, bool?) valueTuple in valueTupleList1)
        flag = this.RegisterTypeAsEntity(valueTuple.Item1, parameters, asEntity, valueTuple.Item2, valueTuple.Item3, valueTuple.Item4, valueTuple.Item5) | flag;
      return flag;
    }

    /// <summary>
    /// Зарегистрировать маппинги Nhibernate по списку метаданных
    /// </summary>
    /// <remarks>
    /// Нельзя использовать на старте системы, только для дельта-публикации
    /// </remarks>
    /// <param name="types">Типы классов сущностей</param>
    /// <returns>Были ли изменения конфигурации</returns>
    private void RegisterTypeMapByMetadata(IEnumerable<Type> types)
    {
      Dictionary<Guid, EntityMetadata> dictionary = new Dictionary<Guid, EntityMetadata>();
      foreach (Type type in types.Where<Type>((Func<Type, bool>) (t => !t.IsInterface)))
      {
        UidAttribute attribute = AttributeHelper<UidAttribute>.GetAttribute(type, false);
        IMetadata metadata;
        if (attribute != null && this._metadataList.TryGetValue(attribute.Uid, out metadata) && metadata is EntityMetadata entityMetadata)
        {
          while (entityMetadata.BaseClassUid != Guid.Empty)
            entityMetadata = this._metadataList[entityMetadata.BaseClassUid] as EntityMetadata;
          dictionary[entityMetadata.Uid] = entityMetadata;
        }
      }
      List<EntityMetadata> metadataList = new List<EntityMetadata>();
      metadataList.AddRange((IEnumerable<EntityMetadata>) dictionary.Values);
      // ISSUE: reference to a compiler-generated method
      IEnumerable<EntityMetadata> allMetadataList = this._metadataList.Values.OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (md => ModelRegistrarImpl.\u003C\u003Ec.ogqkN3Cgggq2dPc9NYVn((object) md) == EntityMetadataType.InterfaceImplementation));
      dictionary.Values.ForEach<EntityMetadata>((Action<EntityMetadata>) (rootMetadata =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              metadataList.AddRange(this.GetMetadataChilds(rootMetadata, allMetadataList));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      if (!metadataList.Any<EntityMetadata>())
        return;
      IRuntimeApplication serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
      NHManagerRegisterParams parameters = new NHManagerRegisterParams()
      {
        Builder = new ContainerBuilder(),
        TransformationProvider = serviceNotNull.TransformationProvider
      };
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      parameters.AddNHibernateClassMappingRange(metadataList.OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (metadata =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (metadata.Type == EntityMetadataType.Entity)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return metadata.Type == EntityMetadataType.InterfaceImplementation;
label_5:
        return true;
      })).Select<EntityMetadata, Type>((Func<EntityMetadata, Type>) (metadata => this._typesByUid[ModelRegistrarImpl.\u003C\u003Ec__DisplayClass50_0.aK6aY5C5X6iFYZ8288Uk((object) metadata)])).Where<Type>((Func<Type, bool>) (type => ModelRegistrarImpl.\u003C\u003Ec.GyBGaZC5WZ5X5CwIdcby(ModelRegistrarImpl.\u003C\u003Ec.t1nqPgCg5pyDvm924iYi(type), (Type) null))).SelectMany<Type, Type>((Func<Type, IEnumerable<Type>>) (type => this.GetPartTypes(MetadataLoader.LoadMetadata(type, false) as ICompositeMetadata).Values.Prepend<Type>(type))));
      this.SessionFactoryHolder.UpdateConfiguration(parameters);
      Locator.GetServiceNotNull<FindReferenceService>().AddMetadata((IEnumerable<EntityMetadata>) metadataList);
    }

    /// <summary>Получить список метаданных-наследников</summary>
    private IEnumerable<EntityMetadata> GetMetadataChilds(
      EntityMetadata entityMetadata,
      IEnumerable<EntityMetadata> metadataList)
    {
      List<EntityMetadata> result = new List<EntityMetadata>();
      // ISSUE: reference to a compiler-generated method
      List<EntityMetadata> list = metadataList.Where<EntityMetadata>((Func<EntityMetadata, bool>) (metadata => metadata.BaseClassUid == ModelRegistrarImpl.\u003C\u003Ec__DisplayClass51_0.yxP7PAC5OLS1UIsqURmw((object) entityMetadata))).ToList<EntityMetadata>();
      result.AddRange((IEnumerable<EntityMetadata>) list);
      list.ForEach((Action<EntityMetadata>) (child =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              result.AddRange(this.GetMetadataChilds(child, metadataList));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return (IEnumerable<EntityMetadata>) result;
    }

    /// <summary>
    /// Зарегистрировать маппинги Nhibernate по классу мэппинга
    /// </summary>
    /// <remarks>
    /// Используется для доконфигурирования Nhibernate после запуска. Например, для регистрации сущностей контекст процессов.
    /// </remarks>
    /// <param name="type">Тип сущности</param>
    /// <param name="parameters">Параметры для регистрации менеджера NHibernate</param>
    private bool RegisterTypeMapByClassMap(Type type, NHManagerRegisterParams parameters)
    {
      int num = 1;
      Type type1;
      while (true)
      {
        switch (num)
        {
          case 1:
            type1 = ModelRegistrarImpl.JlTCquhfumknDMrpTWlR(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_5;
          default:
            if (ModelRegistrarImpl.nVCrBKhfhn5vgCsEkxNR(type1, (Type) null))
            {
              num = 3;
              continue;
            }
            parameters.Add(type1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 2;
            continue;
        }
      }
label_5:
      return false;
label_7:
      return true;
    }

    /// <summary>Зарегистрировать менеджер сущности по умолчанию</summary>
    /// <remarks>
    /// Используется для доконфигурирования Nhibernate после запуска. Например, для регистрации сущностей контекст процессов.
    /// </remarks>
    /// <param name="type">Тип сущности</param>
    /// <param name="updater">Сервис обновления контейнера Autofac</param>
    /// <returns>Наличие изменений в ContainerBuilder</returns>
    private bool RegisterTypeDefaultManager(Type type, ContainerBuilder updater)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        Type type1;
        IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar;
        DefaultManagerAttribute attribute;
        while (true)
        {
          switch (num2)
          {
            case 1:
              registrar = updater.RegisterType(type1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            case 2:
              if (!ModelRegistrarImpl.S1SdV4hfCSkBSyri1HPC(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 4;
                continue;
              }
              goto case 1;
            case 3:
              ModelRegistrarImpl.TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(registrar, type1);
              num2 = 6;
              continue;
            case 4:
              goto label_8;
            case 5:
              ((ComponentManager) ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn()).SetupInterceptors(type1, registrar);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 2 : 3;
              continue;
            case 6:
              goto label_7;
            case 7:
              if (attribute != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 9 : 2;
                continue;
              }
              goto label_8;
            case 8:
              attribute = AttributeHelper<DefaultManagerAttribute>.GetAttribute(type, true);
              num2 = 7;
              continue;
            case 9:
              type1 = ModelRegistrarImpl.GbMhblhfIMgpeDmufJyX((object) attribute, type);
              num2 = 2;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        registrar.As(type1);
        num1 = 5;
      }
label_7:
      return true;
label_8:
      return false;
    }

    /// <summary>Построить сборку с реализациями хабов</summary>
    private void BuildHubsAssembly()
    {
      int num1 = 5;
      byte[][] numArray;
      int index;
      Assembly assembly;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_7:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 3;
            continue;
          case 2:
            assembly = ComponentManager.LoadAssembly(numArray[index]);
            num1 = 6;
            continue;
          case 4:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 5:
            numArray = Locator.GetServiceNotNull<IBuildHubsAssemblyService>().BuildAssemblies();
            num1 = 4;
            continue;
          case 6:
            try
            {
              object source = ModelRegistrarImpl.UqibHohfVovHU8xcqoov((object) assembly);
              // ISSUE: reference to a compiler-generated field
              Func<Type, bool> func = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__54_0;
              Func<Type, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__54_0 = predicate = (Func<Type, bool>) (t =>
                {
                  int num2 = 1;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                        // ISSUE: type reference
                        // ISSUE: reference to a compiler-generated method
                        if (ModelRegistrarImpl.\u003C\u003Ec.Q8RknJC5oRq3KxHNvY0F(__typeref (IClient)).IsAssignableFrom(t))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_5;
                      case 2:
                        goto label_4;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        if (ModelRegistrarImpl.\u003C\u003Ec.BqWU2rC5BwZGEPTtMcJK(t.BaseType, (Type) null))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 1;
                          continue;
                        }
                        goto label_5;
                    }
                  }
label_4:
                  return t.BaseType.IsConstructedGenericType;
label_5:
                  return false;
                });
              }
              else
                goto label_48;
label_10:
              IEnumerator<Type> enumerator = ((IEnumerable<Type>) source).Where<Type>(predicate).GetEnumerator();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                num3 = 0;
              switch (num3)
              {
                case 1:
                  goto label_7;
                default:
                  try
                  {
label_30:
                    if (ModelRegistrarImpl.JilRh4hEcsSIxTlIWqPc((object) enumerator))
                      goto label_22;
                    else
                      goto label_31;
label_15:
                    ConstructorInfo constructorInfo;
                    Type clientType;
                    Type clientProxyType;
                    Func<object, IClient> wrapperFactory;
                    Type current;
                    Type[] genericArguments;
                    ParameterExpression parameterExpression;
                    int num4;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_22;
                        case 2:
                          if (genericArguments.Length == 2)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 6 : 4;
                            continue;
                          }
                          goto label_30;
                        case 3:
                          goto label_27;
                        case 4:
                          clientProxyType = genericArguments[1];
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 10;
                          continue;
                        case 5:
                          HubClientProxyHelper.AddProxy(clientType, clientProxyType, wrapperFactory);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 9 : 12;
                          continue;
                        case 6:
                          clientType = genericArguments[0];
                          num4 = 4;
                          continue;
                        case 7:
                          goto label_7;
                        case 8:
                          wrapperFactory = Expression.Lambda<Func<object, IClient>>((Expression) ModelRegistrarImpl.YHxmNOhfK9dsQZ1rwpgm((object) constructorInfo, (object) new Expression[1]
                          {
                            (Expression) ModelRegistrarImpl.K82ELyhfq2fpNNBNuZ3L((object) parameterExpression, clientProxyType)
                          }), parameterExpression).Compile();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 5;
                          continue;
                        case 9:
                          genericArguments = current.BaseType.GetGenericArguments();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 0;
                          continue;
                        case 10:
                          constructorInfo = ((IEnumerable<ConstructorInfo>) current.GetConstructors(BindingFlags.Instance | BindingFlags.Public)).FirstOrDefault<ConstructorInfo>();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 8 : 11;
                          continue;
                        case 11:
                          if (!ModelRegistrarImpl.Wsvw58hfSVmuBGiKAwiR((object) constructorInfo, (object) null))
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_27;
                        case 12:
                          goto label_30;
                        default:
                          // ISSUE: type reference
                          parameterExpression = (ParameterExpression) ModelRegistrarImpl.ChOnXUhfRhH8rLUrxc4F(ModelRegistrarImpl.HlH5dnhf8tQP4FsdRdNP(__typeref (object)));
                          num4 = 8;
                          continue;
                      }
                    }
label_27:
                    throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787259589), ModelRegistrarImpl.qWghdOhfiMb8tPkhytZn((object) current)));
label_22:
                    current = enumerator.Current;
                    num4 = 9;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                    {
                      num4 = 5;
                      goto label_15;
                    }
                    else
                      goto label_15;
label_31:
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 7;
                    goto label_15;
                  }
                  finally
                  {
                    int num5;
                    if (enumerator == null)
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                    else
                      goto label_35;
label_34:
                    switch (num5)
                    {
                      case 1:
                        break;
                      default:
                    }
label_35:
                    ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) enumerator);
                    num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                    {
                      num5 = 2;
                      goto label_34;
                    }
                    else
                      goto label_34;
                  }
              }
label_48:
              predicate = func;
              goto label_10;
            }
            catch (ReflectionTypeLoadException ex)
            {
              int num6 = 2;
              string str1;
              string str2;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    ModelRegistrarImpl.UBkMgyhfQTI6aVNvhRiu(ModelRegistrarImpl.ylU8LMhENJ3no4g00OBs(), (object) str2, (object) ex);
                    num6 = 3;
                    continue;
                  case 2:
                    string str3 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586406);
                    object source = ModelRegistrarImpl.VNt3C8hfXEX8VlqqbNII((object) ex);
                    // ISSUE: reference to a compiler-generated field
                    Func<Exception, string> func = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__54_1;
                    Func<Exception, string> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__54_1 = selector = (Func<Exception, string>) (e => e.ToString());
                    }
                    else
                      goto label_47;
label_45:
                    string[] array = ((IEnumerable<Exception>) source).Select<Exception, string>(selector).ToArray<string>();
                    str1 = (string) ModelRegistrarImpl.oyOQABhfT9E9uhgPKR45((object) str3, (object) array);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                    continue;
label_47:
                    selector = func;
                    goto label_45;
                  case 3:
                    goto label_46;
                  default:
                    str2 = (string) ModelRegistrarImpl.AJ6eCihfnWjLC60sx0wi(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(~-306453669 ^ 306654704), ModelRegistrarImpl.l2kem6hfkakMvFnQHapv((object) assembly), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44859459), (object) str1);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                    continue;
                }
              }
label_46:
              throw;
            }
          case 7:
            goto label_43;
          default:
            if (index >= numArray.Length)
            {
              num1 = 7;
              continue;
            }
            goto case 2;
        }
      }
label_43:;
    }

    /// <summary>Построить сборку динамических моделей</summary>
    /// <param name="parameters">Параметры регистрации менеджера NHibernate</param>
    private void BuildDynamicModelAssembly(NHManagerRegisterParams parameters)
    {
      int num1 = 29;
      while (true)
      {
        int num2 = num1;
        string str1;
        AssemblyModelsMetadata assemblyModelsMetadata1;
        MemoryStream memoryStream;
        IDynamicPublicationService dynamicPublicationService;
        while (true)
        {
          bool flag;
          AssemblyModelsMetadata assemblyModelsMetadata2;
          ICollection<EntityMetadata> entityMetadatas;
          MetadataServiceContext metadataServiceContext;
          MemoryStream documentationTemplateRaw;
          List<AssemblyModelsMetadata> list1;
          AssemblyModelsMetadata assemblyModelsMetadata3;
          DynamicModelAssemblyBuilder modelAssemblyBuilder;
          Assembly assembly1;
          Assembly assembly2;
          int num3;
          ApplicationStartCache applicationStartCache;
          IEnumerable<AssemblyModelsMetadata> oldAssemblyModels;
          ICollection<AssemblyModelsMetadata> newAssemblyModels;
          switch (num2)
          {
            case 1:
              ModelRegistrarImpl.BVq164hf129OL8G4SE5i((object) applicationStartCache, ModelRegistrarImpl.Bmp32thEA1hdepj1Chu9((object) dynamicPublicationService));
              num2 = 5;
              continue;
            case 2:
              oldAssemblyModels = this._previousAsmModelsMetadataList;
              num2 = 30;
              continue;
            case 3:
            case 6:
              modelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetEntityInterfaceTypes());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 8 : 5;
              continue;
            case 4:
              if (!this._asmModelsMetadataDict.TryGetValue((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-97972138 ^ -97969614), out assemblyModelsMetadata2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 3 : 2;
                continue;
              }
              goto case 56;
            case 5:
              newAssemblyModels = this._asmModelsMetadataDict.Values;
              num2 = 2;
              continue;
            case 7:
            case 10:
              memoryStream = (MemoryStream) ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) assemblyModelsMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 22 : 48;
              continue;
            case 8:
              modelAssemblyBuilder.RegisterTypes(DynamicModelAssemblyBuilder.GetAutoImplementTypes());
              num2 = 24;
              continue;
            case 9:
              modelAssemblyBuilder = new DynamicModelAssemblyBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488879643));
              num2 = 4;
              continue;
            case 11:
              if (ModelRegistrarImpl.zucfSrhEMNClQwH8Outc((object) str1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 18 : 61;
                continue;
              }
              goto case 26;
            case 12:
              memoryStream = (MemoryStream) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 52 : 43;
              continue;
            case 13:
              // ISSUE: reference to a compiler-generated method
              num3 = this._modelAssemblies.Any<Assembly>((Func<Assembly, bool>) (asm => ((AssemblyInfoCache) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.zfFvnHC5NPLswLXnnHf9((object) applicationStartCache, (object) asm))._changed)) ? 1 : 0;
              break;
            case 14:
            case 22:
              if (assemblyModelsMetadata1 == null)
              {
                num2 = 15;
                continue;
              }
              goto case 16;
            case 15:
            case 51:
            case 53:
            case 55:
              if (memoryStream != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 40 : 7;
                continue;
              }
              goto label_86;
            case 16:
              memoryStream = (MemoryStream) ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) assemblyModelsMetadata1);
              num2 = 23;
              continue;
            case 17:
              assembly2 = ComponentManager.LoadAssembly(memoryStream, (MemoryStream) null);
              num2 = 21;
              continue;
            case 18:
              this.Init(parameters, (IList<Assembly>) new Assembly[1]
              {
                assembly1
              });
              num2 = 35;
              continue;
            case 19:
              if (assemblyModelsMetadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                continue;
              }
              goto case 60;
            case 20:
              entityMetadatas = modelAssemblyBuilder.GetImplementationMetadataList();
              num2 = 58;
              continue;
            case 21:
              ModelRegistrarImpl.AEtwtkhfWC0U0uEK8v85(ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn(), (object) assembly2);
              num2 = 32;
              continue;
            case 23:
              documentationTemplateRaw = (MemoryStream) ModelRegistrarImpl.EfHg8RhElrHjJPIViysi((object) assemblyModelsMetadata1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 4 : 53;
              continue;
            case 24:
              modelAssemblyBuilder.PreviousAssemblyRawStream = assemblyModelsMetadata1 != null ? (MemoryStream) ModelRegistrarImpl.RK4bCNhE0d4G5UHXWjRX((object) assemblyModelsMetadata1) : (MemoryStream) (object) null;
              num2 = 19;
              continue;
            case 25:
              flag = true;
              num2 = 12;
              continue;
            case 26:
              Directory.CreateDirectory(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 43;
              continue;
            case 27:
              if (ModelRegistrarImpl.xq8EYQhErJrawiw2AFnv((object) documentationTemplateRaw) > 0L)
              {
                num2 = 36;
                continue;
              }
              goto case 17;
            case 28:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              assembly1 = ((IEnumerable<Assembly>) ModelRegistrarImpl.Wr7pl5hfOil7UYrISmCf()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a => ModelRegistrarImpl.\u003C\u003Ec.BoYxRTCgrm7g1xF6DCUf((object) ComponentManager.GetAssemblyShortName(a), ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(1012087039 ^ 1012085457))));
              num2 = 46;
              continue;
            case 29:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 28 : 20;
              continue;
            case 30:
              List<AssemblyModelsMetadata> list2 = newAssemblyModels.Where<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (m =>
              {
                int num4 = 1;
                AssemblyModelsMetadata m1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_4;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      if (m1.Name != (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(-70007027 ^ -70005399))
                      {
                        num4 = 4;
                        continue;
                      }
                      goto label_5;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.CYNtEaC5axh7rLNm2RHg(ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.zVllNcC5pJjnfhjoPt2q((object) m1), ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(-138018305 ^ -138015791)))
                      {
                        num4 = 5;
                        continue;
                      }
                      goto label_4;
                    case 5:
                      goto label_5;
                    default:
                      m1 = m;
                      num4 = 3;
                      continue;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return oldAssemblyModels.All<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (om => om.Name != (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_1.VxeosxC5x8cR5kgObOWb((object) m1)));
label_5:
                return false;
              })).ToList<AssemblyModelsMetadata>();
              list1 = oldAssemblyModels.Where<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (m =>
              {
                int num5 = 1;
                AssemblyModelsMetadata m2;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if ((string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.zVllNcC5pJjnfhjoPt2q((object) m2) != (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(-1858887263 ^ -1858884721))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 4;
                        continue;
                      }
                      goto label_9;
                    case 3:
                      goto label_9;
                    case 4:
                      goto label_8;
                    case 5:
                      // ISSUE: reference to a compiler-generated method
                      if (!ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.CYNtEaC5axh7rLNm2RHg((object) m2.Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3330434)))
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 3;
                        continue;
                      }
                      goto case 2;
                    default:
                      m2 = m;
                      num5 = 5;
                      continue;
                  }
                }
label_8:
                // ISSUE: reference to a compiler-generated method
                return newAssemblyModels.All<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (om => ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_2.fG8lmuC5MRnFsSUDeOSc((object) om.Name, (object) m2.Name)));
label_9:
                return false;
              })).ToList<AssemblyModelsMetadata>();
              if (ModelRegistrarImpl.tG1UTShfNT8wvqKuxjPr((object) list2) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 41 : 1;
                continue;
              }
              goto case 25;
            case 31:
              flag = assemblyModelsMetadata1 == null;
              num2 = 50;
              continue;
            case 32:
              NHManagerRegisterParams parameters1 = parameters;
              Assembly[] assemblies = new Assembly[1]
              {
                assembly2
              };
              AssemblyModelsMetadata[] preparedModelsMetadata;
              if (assemblyModelsMetadata3 == null)
                preparedModelsMetadata = (AssemblyModelsMetadata[]) null;
              else
                preparedModelsMetadata = new AssemblyModelsMetadata[1]
                {
                  assemblyModelsMetadata3
                };
              MemoryStream[] docRaws = new MemoryStream[1]
              {
                documentationTemplateRaw
              };
              this.Init(parameters1, (IList<Assembly>) assemblies, (IEnumerable<AssemblyModelsMetadata>) preparedModelsMetadata, (IList<MemoryStream>) docRaws);
              num2 = 49;
              continue;
            case 33:
              goto label_49;
            case 34:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 42 : 3;
                continue;
              }
              goto case 1;
            case 35:
              goto label_82;
            case 36:
              DynamicModelAssemblyBuilder.SaveDocumentation(documentationTemplateRaw, str1);
              num2 = 17;
              continue;
            case 37:
              entityMetadatas = (ICollection<EntityMetadata>) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 54 : 43;
              continue;
            case 38:
              try
              {
                IStartInformation startInformation = (IStartInformation) ModelRegistrarImpl.uGTM6NhEP1WTivFv8sgr(39.0, (object) EleWise.ELMA.SR.M((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-649342099 - -1150814748 ^ 501280583)));
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    try
                    {
                      memoryStream = modelAssemblyBuilder.BuildAssemblyToStream((Action<ModelAssemblyBuilder>) (b =>
                      {
                        int num8 = 2;
                        while (true)
                        {
                          switch (num8)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.uoVynmC5DL9h6RqJy7n1((object) b, ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(~289714581 ^ -289717234));
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
                              continue;
                            case 2:
                              b.AddDefaultReferences();
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                              continue;
                            case 3:
                              b.GenerateAssemblyInfo((Func<string, string>) (a =>
                              {
                                int num9 = 1;
                                string str3;
                                while (true)
                                {
                                  switch (num9)
                                  {
                                    case 1:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      str3 = (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.JhFIqjC5tLyfdW6tNmaF((object) ((string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.JhFIqjC5tLyfdW6tNmaF((object) a, ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(1304605005 ^ 1304896251), ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(-630932142 - 1120244082 ^ -1751178802))).Replace((string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(333888594 ^ 1075625116 ^ 1409258692), ConfigurationModelAssemblyBuilder.Version.ToString()), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333437984), (object) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.H7wwL6C5w76QSMl5nQaF().ToString());
                                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                                      continue;
                                    case 2:
                                      // ISSUE: reference to a compiler-generated method
                                      str3 += (string) ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.OEhXWmC53CVZPK0XqmbM(-1598106783 - -968262081 ^ -630133558);
                                      num9 = 3;
                                      continue;
                                    case 3:
                                      goto label_3;
                                    default:
                                      // ISSUE: reference to a compiler-generated method
                                      if (ModelRegistrarImpl.\u003C\u003Ec__DisplayClass55_0.sH9YjRC54JWcMIruB3cn((object) dynamicPublicationService))
                                      {
                                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 2;
                                        continue;
                                      }
                                      goto label_3;
                                  }
                                }
label_3:
                                return str3;
                              }));
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_6;
                          }
                        }
label_2:
                        return;
label_6:;
                      }));
                      int num10 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                        num10 = 1;
                      while (true)
                      {
                        switch (num10)
                        {
                          case 1:
                            documentationTemplateRaw = (MemoryStream) ModelRegistrarImpl.CX5PulhfDoGDrQDPxsdG((object) modelAssemblyBuilder);
                            num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_18;
                        }
                      }
                    }
                    finally
                    {
                      if (startInformation != null)
                      {
                        int num11 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                          num11 = 1;
                        while (true)
                        {
                          switch (num11)
                          {
                            case 1:
                              ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) startInformation);
                              num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_39;
                          }
                        }
                      }
label_39:;
                    }
                }
              }
              finally
              {
                if (metadataServiceContext != null)
                {
                  int num12 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
                    num12 = 0;
                  while (true)
                  {
                    switch (num12)
                    {
                      case 1:
                        goto label_45;
                      default:
                        ModelRegistrarImpl.khgNxJhE13keHsOYC8wd((object) metadataServiceContext);
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_45:;
              }
            case 39:
              goto label_90;
            case 40:
              str1 = (string) ModelRegistrarImpl.M4Bho7hEylM5d6QSLLKm(ModelRegistrarImpl.dYKhTQhEmRiOvikgv19S((object) ComponentManager.Current), ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-35995181 ^ -36008783));
              num2 = 11;
              continue;
            case 41:
              if (list1.Count > 0)
              {
                num2 = 25;
                continue;
              }
              goto case 12;
            case 42:
              if (ModelRegistrarImpl.e2ZmhihfP8jeVLp8mMmq((object) applicationStartCache) == dynamicPublicationService.Enable)
              {
                num2 = 13;
                continue;
              }
              num3 = 1;
              break;
            case 43:
            case 61:
              goto label_87;
            case 44:
              assemblyModelsMetadata3 = (AssemblyModelsMetadata) null;
              num2 = 37;
              continue;
            case 45:
              ModelRegistrarImpl.AEtwtkhfWC0U0uEK8v85(ModelRegistrarImpl.Sts3SxhEijg8pQXRUhEn(), (object) assembly1);
              num2 = 18;
              continue;
            case 46:
              if (!ModelRegistrarImpl.nXhtpehf2rXE0fovMO40((object) assembly1, (object) null))
              {
                num2 = 39;
                continue;
              }
              goto case 45;
            case 47:
              if (documentationTemplateRaw != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 27 : 1;
                continue;
              }
              goto case 17;
            case 48:
              documentationTemplateRaw = assemblyModelsMetadata1.DocumentationRawStream;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 45 : 55;
              continue;
            case 49:
              goto label_88;
            case 50:
              applicationStartCache = (ApplicationStartCache) ModelRegistrarImpl.Sy81uGhfeIrcBD4lpNhc((object) Locator.GetServiceNotNull<IRuntimeApplication>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 33 : 6;
              continue;
            case 52:
              documentationTemplateRaw = (MemoryStream) null;
              num2 = 44;
              continue;
            case 54:
              if (flag)
                goto case 9;
              else
                goto label_70;
            case 56:
              modelAssemblyBuilder.RegisterConfigurationMetadataList((IEnumerable<IMetadata>) ModelRegistrarImpl.iJYS7ihf397WGdKkIr4t((object) assemblyModelsMetadata2));
              num2 = 6;
              continue;
            case 57:
              metadataServiceContext = new MetadataServiceContext((IMetadataService) new ConfigurationModelBuilderMetadataService(Locator.GetServiceNotNull<IMetadataRuntimeService>(), (IEnumerable<IMetadata>) entityMetadatas));
              num2 = 38;
              continue;
            case 58:
              if (ModelRegistrarImpl.rhfAaIhfaKlXCrPZMiP7((object) entityMetadatas) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 57 : 27;
                continue;
              }
              goto case 15;
            case 59:
label_18:
              Locator.GetServiceNotNull<IModelAssemblyBuilderHandler>().DynamicModelAssemblyBuilt((IEnumerable<EntityMetadata>) entityMetadatas);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 51 : 13;
              continue;
            case 60:
              if (ModelRegistrarImpl.XTGhC3hfp93ohNu6VfIJ((object) modelAssemblyBuilder))
                goto default;
              else
                goto label_72;
            default:
              assemblyModelsMetadata3 = (AssemblyModelsMetadata) null;
              num2 = 20;
              continue;
          }
          flag = num3 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
        }
label_49:
        dynamicPublicationService = Locator.GetServiceNotNull<IDynamicPublicationService>();
        num1 = 34;
        continue;
label_70:
        num1 = 14;
        continue;
label_72:
        num1 = 10;
        continue;
label_87:
        IOExtensions.WriteAllBytesWithAttempts(Path.Combine(str1, (string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1426456882 ^ 2009939514 ^ -583758476)), (Stream) memoryStream, ModelRegistrarImpl.de1BAwhft2mQC7GHpLeG(1.0), EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561150694), 30));
        num1 = 47;
        continue;
label_90:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        assemblyModelsMetadata1 = this._previousAsmModelsMetadataList.FirstOrDefault<AssemblyModelsMetadata>((Func<AssemblyModelsMetadata, bool>) (a => ModelRegistrarImpl.\u003C\u003Ec.BoYxRTCgrm7g1xF6DCUf((object) a.Name, ModelRegistrarImpl.\u003C\u003Ec.JoOdLdCgdlyxJl4cN6px(1819636893 << 3 ^ 1672195782))));
        num1 = 31;
      }
label_82:
      return;
label_88:
      return;
label_86:;
    }

    /// <summary>Зарегистрировать менеджеры сущностей</summary>
    /// <param name="parameters">Параметры для регистрации</param>
    /// <param name="assemblies">Список сборок из которых нужно регистрировать менеджеры</param>
    internal void RegisterEntityManagers(
      NHManagerRegisterParams parameters,
      IList<Assembly> assemblies)
    {
      DateTime now1 = DateTime.Now;
      Type type1 = typeof (IEntityManager<>);
      IEnumerable<Type> types = ComponentManager.Current.GetExtensionPointTypes(type1).Where<Type>((Func<Type, bool>) (t =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (assemblies == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return assemblies.Contains(t.Assembly);
label_3:
        return true;
      }));
      Dictionary<Type, Type> entityManagerTypesMap = new Dictionary<Type, Type>();
      foreach (Type type2 in types)
      {
        if (!type2.IsGenericTypeDefinition)
        {
          Type type3 = type2.GetInterface(type1.FullName);
          if (type3 != (Type) null && type3.IsGenericType && !type3.IsGenericTypeDefinition && type3.GetGenericTypeDefinition() == type1)
          {
            Type genericArgument = type3.GetGenericArguments()[0];
            EntityMetadataTypeAttribute attribute = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(genericArgument, false);
            if (attribute != null && attribute.Type == EntityMetadataType.InterfaceExtension && type2.GetInterface(typeof (IEntityExtensionManager<,,>).FullName) == (Type) null)
              throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586686)), (object) typeof (IEntityExtensionManager<,,>).FullName));
            entityManagerTypesMap[genericArgument] = type2;
          }
        }
      }
      foreach (Type entityType in ComponentManager.Current.GetExtensionPointTypes(typeof (IEntity)).Where<Type>((Func<Type, bool>) (t =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (assemblies == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return assemblies.Contains(t.Assembly);
label_3:
        return true;
      })).Where<Type>((Func<Type, bool>) (t => !t.ContainsGenericParameters)))
        this.CreateTypeDefaultManager(entityType, entityManagerTypesMap);
      ILogger log1 = Logger.Log;
      string format1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939586796);
      TimeSpan timeSpan = DateTime.Now - now1;
      // ISSUE: variable of a boxed type
      __Boxed<int> totalMilliseconds1 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
      string message1 = string.Format(format1, (object) totalMilliseconds1);
      log1.Debug((object) message1);
      DateTime now2 = DateTime.Now;
      this.RegisterEntityManagerTypesInIoc(entityManagerTypesMap, parameters.Builder);
      ILogger log2 = Logger.Log;
      string format2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516776170);
      timeSpan = DateTime.Now - now2;
      // ISSUE: variable of a boxed type
      __Boxed<int> totalMilliseconds2 = (System.ValueType) (int) timeSpan.TotalMilliseconds;
      // ISSUE: variable of a boxed type
      __Boxed<int> count = (System.ValueType) entityManagerTypesMap.Count;
      string message2 = string.Format(format2, (object) totalMilliseconds2, (object) count);
      log2.Debug((object) message2);
      DateTime now3 = DateTime.Now;
      foreach (Type type4 in ComponentManager.Current.GetExtensionPointTypes(typeof (IManager)).Where<Type>((Func<Type, bool>) (t =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (assemblies != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return assemblies.Contains(t.Assembly);
label_5:
        return true;
      })).Where<Type>((Func<Type, bool>) (t => !t.ContainsGenericParameters)))
      {
        IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar = parameters.Builder.RegisterType(type4);
        registrar.As(type4);
        ComponentManager.Current.SetupInterceptors(type4, registrar);
        ModelRegistrarImpl.TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(registrar, type4);
      }
      Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867880932), (object) (int) (DateTime.Now - now3).TotalMilliseconds));
    }

    private void CreateTypeDefaultManager(
      Type entityType,
      Dictionary<Type, Type> entityManagerTypesMap)
    {
      if (entityManagerTypesMap == null)
        entityManagerTypesMap = new Dictionary<Type, Type>();
      if (entityManagerTypesMap.ContainsKey(entityType))
        return;
      EntityMetadataTypeAttribute attribute1 = AttributeHelper<EntityMetadataTypeAttribute>.GetAttribute(entityType, false);
      ImplementationUidAttribute attribute2 = AttributeHelper<ImplementationUidAttribute>.GetAttribute(entityType, false);
      BaseClassAttribute attribute3 = AttributeHelper<BaseClassAttribute>.GetAttribute(entityType, false);
      Type typeByUid1;
      if (attribute1 != null && attribute2 != null && attribute1.Type == EntityMetadataType.InterfaceImplementation && (typeByUid1 = this.GetTypeByUid(attribute2.Uid, false)) != (Type) null)
      {
        Type entityIdType = ModelHelper.GetEntityIdType(entityType);
        entityManagerTypesMap[entityType] = typeof (EntityImplManager<,,>).MakeGenericType(entityType, typeByUid1, entityIdType);
        DefaultManagerAttribute attribute4 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, true);
        if (attribute4 == null)
          return;
        entityManagerTypesMap[entityType] = attribute4.GetManagerType(entityType);
      }
      else
      {
        Type typeByUid2;
        if (attribute1 != null && attribute3 != null && attribute1.Type == EntityMetadataType.InterfaceExtension && (typeByUid2 = this.GetTypeByUid(attribute3.BaseClassUid, false)) != (Type) null)
        {
          Type entityIdType = ModelHelper.GetEntityIdType(entityType);
          entityManagerTypesMap[entityType] = typeof (EntityExtensionManager<,,>).MakeGenericType(typeByUid2, entityType, entityIdType);
        }
        else
        {
          DefaultManagerAttribute attribute5 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(entityType, true);
          if (attribute5 == null && entityType.IsInterface)
          {
            Type type = (Type) null;
            foreach (Type c in ((IEnumerable<Type>) entityType.GetInterfaces()).Where<Type>((Func<Type, bool>) (intf => AttributeHelper<DefaultManagerAttribute>.GetAttribute(intf, false) != null)))
            {
              if (type == (Type) null || type.IsAssignableFrom(c))
                type = c;
            }
            if (type != (Type) null)
              attribute5 = AttributeHelper<DefaultManagerAttribute>.GetAttribute(type, false);
          }
          if (attribute5 == null)
            return;
          Type managerType = attribute5.GetManagerType(entityType);
          if (!(managerType != (Type) null))
            return;
          entityManagerTypesMap[entityType] = managerType;
        }
      }
    }

    /// <summary>
    /// Зарегистрировать менеджер сущности (если он таковым является)
    /// </summary>
    /// <param name="registrar">Регистратор</param>
    /// <param name="managerType">Тип менеджера</param>
    /// <returns></returns>
    private static IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> TryRegisterAsEntityManager<TLimit, TActivatorData, TRegistrationStyle>(
      IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> registrar,
      Type managerType)
    {
      List<Type> typeList = new List<Type>();
      typeList.AddRange((IEnumerable<Type>) managerType.GetInterfaces());
      if (typeList.Count > 0)
        registrar.As(typeList.ToArray()).PropertiesAutowired<TLimit, TActivatorData, TRegistrationStyle>(PropertyWiringOptions.AllowCircularDependencies);
      registrar.SetScope<TLimit, TActivatorData, TRegistrationStyle>(ServiceScope.Application);
      return registrar;
    }

    /// <summary>Зарегистрировать описания типов данных</summary>
    private void RegisterTypeDescriptors(IList<Assembly> assemblies)
    {
      foreach (ITypeDescriptor extensionPoint in ComponentManager.Current.GetExtensionPoints<ITypeDescriptor>())
      {
        if (assemblies == null || assemblies.Contains(extensionPoint.GetType().Assembly))
        {
          this._typeDescriptorsByUid[(extensionPoint.Uid, extensionPoint.SubTypeUid)] = extensionPoint;
          if (extensionPoint is IRuntimeTypeDescriptor runtimeTypeDescriptor && runtimeTypeDescriptor.IsRuntimeType)
            this._typeDescriptorsByType[runtimeTypeDescriptor.RuntimeType] = extensionPoint;
        }
      }
    }

    /// <summary>Получить все типы составных сущностей</summary>
    private Dictionary<Guid, Type> GetPartTypes(ICompositeMetadata metadata)
    {
      Dictionary<Guid, Type> collection = new Dictionary<Guid, Type>();
      if (metadata != null)
      {
        foreach (IMetadata compositePart in metadata.GetCompositeParts())
        {
          Type type;
          if (compositePart is ICodeItemMetadata && this._typesByUid.TryGetValue(compositePart.Uid, out type))
            collection.Add(((ITablePartMetadata) compositePart).TablePartPropertyUid, type);
          collection.AddRange<KeyValuePair<Guid, Type>>((IEnumerable<KeyValuePair<Guid, Type>>) this.GetPartTypes(compositePart as ICompositeMetadata));
        }
      }
      return collection;
    }

    /// <summary>Регистрация пар дельта-типов</summary>
    private void RegisterDeltaTypes(ISet<Type> deltaTypes, ISet<Type> newTypesToRegister)
    {
      ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461557053));
      this._removedTypes.Where<KeyValuePair<Guid, Type>>((Func<KeyValuePair<Guid, Type>, bool>) (p => !deltaTypes.Contains(p.Value))).ForEach<KeyValuePair<Guid, Type>>((Action<KeyValuePair<Guid, Type>>) (p =>
      {
        ModelRegistrarImpl.publishLogger.TraceFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309396148), (object) p.Value.AssemblyQualifiedName);
        this.LoadMetadataInternal(p.Value);
      }));
      this._removedTypes.Clear();
      if (deltaTypes.Count == 0)
        return;
      lock (this.registeredTypes)
      {
        bool flag = false;
        ContainerBuilder containerBuilder = new ContainerBuilder();
        ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671940105));
        foreach (Type type in (IEnumerable<Type>) newTypesToRegister)
        {
          if ((!type.IsAbstract && type.IsClass || type.IsInterface || type.IsValueType && !type.IsEnum) && !type.ContainsGenericParameters && ComponentManager.Current.IsComponentType(type))
          {
            flag = true;
            ComponentManager.Current.ProcessComponent(type, (object) null, containerBuilder, (Func<ServiceScope?, bool>) (_ => false));
          }
          if (!type.IsAbstract && type.IsClass && !type.ContainsGenericParameters && ComponentManager.Current.IsServiceType(type))
          {
            flag = true;
            ComponentManager.Current.ProcessService(type, containerBuilder, (Func<ServiceScope?, bool>) (_ => false));
          }
        }
        foreach (Type deltaType in (IEnumerable<Type>) deltaTypes)
        {
          if (!deltaType.IsAbstract && deltaType.IsClass && !deltaType.ContainsGenericParameters)
          {
            object[] customAttributes = deltaType.GetReflectionCustomAttributes(typeof (ImplementAttribute), false);
            if (customAttributes.Length != 0)
            {
              flag = true;
              // ISSUE: reference to a compiler-generated method
              containerBuilder.RegisterType(deltaType).As(deltaType).As(customAttributes.Cast<ImplementAttribute>().Select<ImplementAttribute, Type>((Func<ImplementAttribute, Type>) (a => ModelRegistrarImpl.\u003C\u003Ec.fTn7vIC5buHK5LjD1oRs((object) a))).ToArray<Type>());
              foreach (ImplementAttribute implementAttribute in customAttributes)
                ComponentManager.Current.AddToExtensionPointTypesMap(implementAttribute.InterfaceType, deltaType);
            }
            else if (newTypesToRegister.Contains(deltaType) && deltaType.GetReflectionCustomAttributes(typeof (EntityAttribute), false).Length != 0)
            {
              flag = true;
              containerBuilder.RegisterType(deltaType).As(deltaType);
            }
          }
        }
        ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675304277));
        Dictionary<Type, Type> entityManagerTypesMap = new Dictionary<Type, Type>();
        foreach (Type entityType in newTypesToRegister.Where<Type>((Func<Type, bool>) (t =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (!t.ContainsGenericParameters)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              default:
                goto label_2;
            }
          }
label_2:
          return TypeOf<IEntity>.Raw.IsAssignableFrom(t);
label_3:
          return false;
        })))
          this.CreateTypeDefaultManager(entityType, entityManagerTypesMap);
        if (entityManagerTypesMap.Count > 0)
        {
          flag = true;
          this.RegisterEntityManagerTypesInIoc(entityManagerTypesMap, containerBuilder);
        }
        ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470502612));
        this.RegisterTypeMapByMetadata((IEnumerable<Type>) deltaTypes);
        if (flag)
        {
          ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218762378));
          this.UpdateIoC(containerBuilder);
        }
      }
      ModelRegistrarImpl.publishLogger.Info((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787261261));
    }

    /// <summary>Обновление контейнера IoC</summary>
    private void UpdateIoC(ContainerBuilder updater)
    {
      int num1 = 2;
      IContainer container;
      bool lockTaken;
      IContainer serviceNotNull;
      while (true)
      {
        switch (num1)
        {
          case 1:
            container = serviceNotNull;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<IContainer>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_10;
          default:
            lockTaken = false;
            num1 = 3;
            continue;
        }
      }
label_10:
      return;
label_2:
      try
      {
        Monitor.Enter((object) container, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            default:
              ModelRegistrarImpl.QI4ba9hfwsCMmvuax3P0((object) updater, (object) serviceNotNull);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
        else
          goto label_11;
label_8:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_11:
        Monitor.Exit((object) container);
        num3 = 2;
        goto label_8;
      }
    }

    /// <summary>Регистрация менеджеров в IoC-контейнере</summary>
    private void RegisterEntityManagerTypesInIoc(
      Dictionary<Type, Type> entityManagerTypesMap,
      ContainerBuilder updater)
    {
      foreach (KeyValuePair<Type, Type> entityManagerTypes in entityManagerTypesMap)
      {
        IRegistrationBuilder<object, ConcreteReflectionActivatorData, SingleRegistrationStyle> registrar = updater.RegisterType(entityManagerTypes.Value);
        registrar.As(entityManagerTypes.Value);
        if (entityManagerTypes.Value.GetGenericArguments().Length != 3 || entityManagerTypes.Value.GetGenericTypeDefinition() != typeof (EntityImplManager<,,>))
          ComponentManager.Current.SetupInterceptors(entityManagerTypes.Value, registrar);
        ModelRegistrarImpl.TryRegisterAsEntityManager<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(registrar, entityManagerTypes.Value);
      }
    }

    private static Type GetClassMapType(Type type)
    {
      Type classMapType;
      switch (1)
      {
        case 1:
          try
          {
            ClassMapAttribute attribute = AttributeHelper<ClassMapAttribute>.GetAttribute(type, false);
            int num;
            if (attribute == null)
              num = 2;
            else
              goto label_10;
label_4:
            Type c;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                case 2:
                  goto label_9;
                case 3:
                case 5:
                  classMapType = c;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                  continue;
                case 4:
                  if (TypeOf<IConformistHoldersProvider>.Raw.IsAssignableFrom(c))
                  {
                    num = 3;
                    continue;
                  }
                  break;
              }
              c = (Type) null;
              num = 5;
            }
label_9:
            Type type1 = (Type) null;
            goto label_11;
label_10:
            type1 = attribute.MapType;
label_11:
            c = type1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 3;
            goto label_4;
          }
          catch (FileNotFoundException ex)
          {
            if (ModelRegistrarImpl.eOsjDphf4p3AjPuLK26i((object) ex.FileName, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-70007027 ^ -70192867)))
            {
              int num = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                num = 0;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    goto label_1;
                  case 2:
                    goto label_17;
                  default:
                    classMapType = (Type) null;
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
label_17:
            throw;
          }
      }
label_1:
      return classMapType;
    }

    private SessionFactoryHolder SessionFactoryHolder
    {
      get
      {
        int num = 1;
        SessionFactoryHolder serviceNotNull;
        SessionFactoryHolder sessionFactoryHolder;
        while (true)
        {
          switch (num)
          {
            case 1:
              sessionFactoryHolder = this.sessionFactoryHolder;
              if (sessionFactoryHolder == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.sessionFactoryHolder = serviceNotNull = Locator.GetServiceNotNull<SessionFactoryHolder>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return sessionFactoryHolder;
label_6:
        return serviceNotNull;
      }
    }

    protected override ushort GetDbLicenseCount() => 0;

    Guid ILicensedUnit.RegistrationKeyMethodUid => new Guid((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1858887263 ^ -1858874475));

    string ILicensedUnit.GetRegistrationKey()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.InitLicense();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.registrationKey;
    }

    void ILicensedUnit.ApplyActivationKey(string key)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          LicenseStatus status;
          ushort licCount1;
          ushort privilegeLicCount1;
          DateTime? expirationDate1;
          byte licType1;
          byte licSubType1;
          DateTime? expirationDate2;
          ushort licCount2;
          byte licType2;
          byte licSubType2;
          byte num3;
          byte num4;
          ushort privilegeLicCount2;
          int num5;
          int num6;
          switch (num2)
          {
            case 0:
              goto label_38;
            case 1:
              if (ModelRegistrarImpl.gqLemFhETc963syN82Z2(expirationDate1.Value, expirationDate2.Value))
              {
                num2 = 13;
                continue;
              }
              break;
            case 2:
              if (licType1 != (byte) 2)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 7 : 24;
                continue;
              }
              num5 = 1;
              goto label_57;
            case 3:
              goto label_44;
            case 4:
              if ((int) licSubType1 >= (int) licSubType2)
              {
                if (licType1 != (byte) 1)
                {
                  num2 = 29;
                  continue;
                }
                goto case 15;
              }
              else
              {
                num2 = 7;
                continue;
              }
            case 5:
              if ((int) licSubType1 <= (int) licSubType2)
              {
                num2 = 4;
                continue;
              }
              goto case 17;
            case 6:
              goto label_52;
            case 7:
              goto label_17;
            case 8:
              if ((int) num3 >= (int) num4)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 23 : 12;
                continue;
              }
              goto case 26;
            case 9:
              if (this.DecodeActivationKey(key, out status, out licCount1, out privilegeLicCount1, out licType1, out licSubType1, out expirationDate1))
              {
                if (this.lastAppliedActKey == null)
                {
                  num2 = 14;
                  continue;
                }
                this.DecodeActivationKey(this.lastAppliedActKey, out LicenseStatus _, out licCount2, out privilegeLicCount2, out licType2, out licSubType2, out expirationDate2);
                num2 = 2;
                continue;
              }
              num2 = 19;
              continue;
            case 10:
              this.InitLicense();
              num2 = 9;
              continue;
            case 11:
              goto label_22;
            case 12:
              if ((int) privilegeLicCount1 <= (int) privilegeLicCount2)
              {
                num2 = 21;
                continue;
              }
              goto case 22;
            case 13:
            case 28:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 6;
              continue;
            case 14:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 18;
              continue;
            case 15:
              if (expirationDate1.HasValue)
              {
                num2 = 20;
                continue;
              }
              break;
            case 16:
              num6 = (int) licType2;
              goto label_59;
            case 17:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 27;
              continue;
            case 18:
              goto label_49;
            case 19:
              goto label_14;
            case 20:
              if (expirationDate2.HasValue)
                goto case 1;
              else
                goto label_8;
            case 21:
              goto label_9;
            case 22:
label_27:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = 3;
              continue;
            case 23:
              if ((int) num3 <= (int) num4)
              {
                num2 = 5;
                continue;
              }
              goto label_47;
            case 24:
              num5 = (int) licType1;
              goto label_57;
            case 25:
              if ((int) licCount1 == (int) licCount2)
              {
                num2 = 12;
                continue;
              }
              goto label_48;
            case 26:
              this.SetLastAppliedKey(key, status, licCount1, privilegeLicCount1, expirationDate1, licType1, licSubType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 27:
              goto label_31;
            case 29:
              if (licType1 == (byte) 2)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 15 : 5;
                continue;
              }
              break;
            case 30:
              if (licType2 != (byte) 2)
              {
                num2 = 16;
                continue;
              }
              num6 = 1;
              goto label_59;
            default:
              goto label_20;
          }
          if ((int) licCount1 <= (int) licCount2)
          {
            num2 = 25;
            continue;
          }
          goto label_27;
label_57:
          num3 = (byte) num5;
          num2 = 30;
          continue;
label_59:
          num4 = (byte) num6;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 7 : 8;
        }
label_8:
        num1 = 28;
      }
label_38:
      return;
label_44:
      return;
label_52:
      return;
label_17:
      return;
label_22:
      return;
label_49:
      return;
label_14:
      return;
label_9:
      return;
label_31:
      return;
label_20:
      return;
label_48:
      return;
label_47:;
    }

    void ILicensedUnit.CompleteLicensingInitialize()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.licensingInitialized = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 3:
            this.InitLicense();
            num = 2;
            continue;
          default:
            this.initializedStatus = ModelRegistrarImpl.pqimPUhf6YWUW2yVLWik((object) this.licenseInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    ILicenseInfo ILicensedUnit.GetLicenseInfo()
    {
      int num1 = 1;
      ushort dbLicenseCount;
      WorkplaceLicenseInfo licenseInfo;
      uint? workplaceCount;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.InitLicense();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            workplaceCount = licenseInfo.WorkplaceCount;
            num1 = 10;
            continue;
          case 3:
          case 9:
          case 11:
            goto label_7;
          case 4:
            int num2 = (int) dbLicenseCount;
            workplaceCount = licenseInfo.WorkplaceCount;
            int num3 = (int) workplaceCount.Value;
            if ((uint) num2 < (uint) num3)
            {
              num1 = 6;
              continue;
            }
            goto label_7;
          case 5:
            if (licenseInfo == null)
            {
              num1 = 11;
              continue;
            }
            goto case 12;
          case 6:
          case 7:
            licenseInfo.WorkplaceCount = new uint?((uint) dbLicenseCount);
            num1 = 3;
            continue;
          case 8:
            if (dbLicenseCount <= (ushort) 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 8 : 9;
              continue;
            }
            goto case 2;
          case 10:
            if (!workplaceCount.HasValue)
            {
              num1 = 7;
              continue;
            }
            goto case 4;
          case 12:
            dbLicenseCount = this.GetDbLicenseCount();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 8;
            continue;
          default:
            licenseInfo = (WorkplaceLicenseInfo) this.licenseInfo;
            num1 = 5;
            continue;
        }
      }
label_7:
      return (ILicenseInfo) this.licenseInfo;
    }

    void ILicensedUnit.UpdateLicenseInfo()
    {
      int num = 3;
      LicenseStatus status;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.DecodeActivationKey(this.lastAppliedActKey, out status, out ushort _, out ushort _, out byte _, out byte _, out DateTime? _);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 3:
            this.InitLicense();
            num = 2;
            continue;
          default:
            this.licenseInfo.Status = status;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    byte[] ILicensedUnit.GetActivationToken() => (byte[]) null;

    ActivationToken IActivationTokenContainer.GetActivationToken() => (ActivationToken) null;

    private void InitLicense()
    {
      int num1 = 1;
      bool lockTaken;
      ModelRegistrarImpl modelRegistrarImpl;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_21;
          case 1:
            if (!this.initialized)
            {
              modelRegistrarImpl = this;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            lockTaken = false;
            num1 = 4;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_19;
        }
      }
label_21:
      return;
label_3:
      return;
label_19:
      return;
label_7:
      try
      {
        Monitor.Enter((object) modelRegistrarImpl, ref lockTaken);
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.registrationKey = (string) ModelRegistrarImpl.D08CImhfHyXgSSwGlqMr((ushort) 1);
              num2 = 4;
              continue;
            case 2:
              goto label_15;
            case 3:
              if (this.initialized)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            case 4:
              ConcurrentLicenseInfo concurrentLicenseInfo = new ConcurrentLicenseInfo((object) this);
              ModelRegistrarImpl.CJ5OXGhfAjPy4RoqMw7D((object) concurrentLicenseInfo, LicenseStatus.NotActivated);
              this.licenseInfo = concurrentLicenseInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_10;
            default:
              this.initialized = true;
              num2 = 5;
              continue;
          }
        }
label_15:
        return;
label_10:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
        else
          goto label_20;
label_18:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_20:
        ModelRegistrarImpl.CsYqvohf7XEKwOQ02YBd((object) modelRegistrarImpl);
        num3 = 2;
        goto label_18;
      }
    }

    private static string GenerateRegistrationKey(ushort algorithm)
    {
      int num = 4;
      string str1;
      string str2;
      uint hnH;
      uint hnL;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = (string) ModelRegistrarImpl.tcbG00hE9RUI5mfHviBO(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(516838154 ^ 516836486), (object) str1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
          case 9:
            if (ModelRegistrarImpl.rPsUdMhfx5xoOjZloj6i((object) str2) >= 10)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 6;
              continue;
            }
            goto case 5;
          case 3:
            str2 = hnH.ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 6;
            continue;
          case 4:
            LicensedUnitBase.GHN(out hnH, out hnL);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 3 : 0;
            continue;
          case 5:
            str2 = (string) ModelRegistrarImpl.tcbG00hE9RUI5mfHviBO(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(516838154 ^ 516836486), (object) str2);
            num = 9;
            continue;
          case 7:
            goto label_8;
          case 8:
            str1 = hnL.ToString();
            num = 2;
            continue;
          default:
            if (str1.Length >= 10)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 7;
              continue;
            }
            goto case 1;
        }
      }
label_8:
      return (string) ModelRegistrarImpl.I4tox1hf0PCbTAyAnoup(ModelRegistrarImpl.tcbG00hE9RUI5mfHviBO((object) str2, (object) str1));
    }

    private static string FormatKey(object key)
    {
      int num1 = 5;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int index;
        char[] chArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
            case 6:
              ModelRegistrarImpl.w9gn6chfyeFQwxgLoZ2p((object) stringBuilder, chArray[index]);
              num2 = 14;
              continue;
            case 3:
            case 9:
              if (index <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
                continue;
              }
              goto case 8;
            case 4:
              goto label_3;
            case 5:
              if (key != null)
              {
                stringBuilder = new StringBuilder();
                num2 = 12;
                continue;
              }
              goto label_15;
            case 7:
              goto label_5;
            case 8:
              if (index % 5 != 0)
              {
                num2 = 2;
                continue;
              }
              goto case 13;
            case 10:
            case 11:
              if (index < chArray.Length)
              {
                num2 = 9;
                continue;
              }
              goto label_5;
            case 12:
              chArray = (char[]) ModelRegistrarImpl.ylLCqThfma6DuURpdN0j(key);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
              continue;
            case 13:
              ModelRegistrarImpl.w9gn6chfyeFQwxgLoZ2p((object) stringBuilder, '-');
              num2 = 6;
              continue;
            case 14:
              ++index;
              num2 = 10;
              continue;
            default:
              index = 0;
              num2 = 11;
              continue;
          }
        }
label_15:
        num1 = 4;
      }
label_3:
      return string.Empty;
label_5:
      return stringBuilder.ToString();
    }

    private bool DecodeLastActivationKey(
      out LicenseStatus status,
      out ushort licCount,
      out ushort privilegeLicCount,
      out byte licType,
      out byte licSubType,
      out DateTime? expirationDate)
    {
      return this.DecodeActivationKey(this.lastAppliedActKey, out status, out licCount, out privilegeLicCount, out licType, out licSubType, out expirationDate);
    }

    private bool DecodeActivationKey(
      string key,
      out LicenseStatus status,
      out ushort licCount,
      out ushort privilegeLicCount,
      out byte licType,
      out byte licSubType,
      out DateTime? expirationDate)
    {
      int num1 = 6;
      bool flag;
      while (true)
      {
        int num2 = num1;
        uint hnH;
        uint hnL;
        while (true)
        {
          switch (num2)
          {
            case 1:
              key = ((string) ModelRegistrarImpl.rrfTO6hfMDvqmf4gOhAx(ModelRegistrarImpl.rrfTO6hfMDvqmf4gOhAx(ModelRegistrarImpl.rrfTO6hfMDvqmf4gOhAx((object) key, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413562995), (object) ""), ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-1146510045 ^ -1146491903), (object) ""), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576145394), (object) "")).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979245879), "").Replace((string) ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(1925118608 << 2 ^ -889457180), "");
              num2 = 4;
              continue;
            case 2:
              if (key != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                continue;
              }
              goto case 8;
            case 3:
              try
              {
                int num3 = (int) uint.Parse((string) ModelRegistrarImpl.tylfvfhfJi5EvwAF0dQr((object) key, 0, 10));
                uint num4 = ModelRegistrarImpl.kfGRYohf9CMyBJoUuVbJ(ModelRegistrarImpl.tylfvfhfJi5EvwAF0dQr((object) key, 10, 10));
                int num5 = ~(int) hnH;
                if (num3 == num5)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
                    num6 = 1;
                  ushort num7;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        if ((int) num4 == ~(int) hnL)
                        {
                          num6 = 5;
                          continue;
                        }
                        goto label_33;
                      case 2:
                        goto label_33;
                      case 3:
                        if ((int) num7 < (int) licCount)
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 10 : 5;
                          continue;
                        }
                        goto case 7;
                      case 4:
                        licType = byte.MaxValue;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                        continue;
                      case 5:
                        status = LicenseStatus.Activated;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 8 : 4;
                        continue;
                      case 6:
                        if (num7 > (ushort) 0)
                        {
                          num6 = 3;
                          continue;
                        }
                        goto case 7;
                      case 7:
                        flag = true;
                        num6 = 9;
                        continue;
                      case 8:
                        licCount = (ushort) 65000;
                        num6 = 4;
                        continue;
                      case 9:
                        goto label_8;
                      case 10:
                        licCount = num7;
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 3;
                        continue;
                      default:
                        num7 = ModelRegistrarImpl.RpGkAahfdtIjA4x3Y64Y((object) this);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 6;
                        continue;
                    }
                  }
                }
                else
                  goto case 8;
              }
              catch (Exception ex)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                  num8 = 0;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_33;
                    default:
                      ModelRegistrarImpl.UBkMgyhfQTI6aVNvhRiu((object) Logger.Log, ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-710283084 ^ -537863435 ^ 173677687), (object) ex);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
                      continue;
                  }
                }
              }
            case 4:
              if (ModelRegistrarImpl.rPsUdMhfx5xoOjZloj6i((object) key) == 20)
              {
                num2 = 10;
                continue;
              }
              goto case 8;
            case 5:
              expirationDate = new DateTime?();
              num2 = 12;
              continue;
            case 6:
              this.InitLicense();
              num2 = 5;
              continue;
            case 7:
              licType = (byte) 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            case 8:
label_33:
              status = LicenseStatus.NotActivated;
              num2 = 11;
              continue;
            case 9:
              goto label_9;
            case 10:
              LicensedUnitBase.GHN(out hnH, out hnL);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 3 : 3;
              continue;
            case 11:
              licCount = (ushort) 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 7;
              continue;
            case 12:
              licSubType = (byte) 0;
              num2 = 9;
              continue;
            default:
              goto label_7;
          }
        }
label_9:
        privilegeLicCount = (ushort) 0;
        num1 = 2;
      }
label_7:
      return false;
label_8:
      return flag;
    }

    private void SetLastAppliedKey(
      string key,
      LicenseStatus newStatus,
      ushort newLicCount,
      ushort newPrivilegeCount,
      DateTime? newExpirationDate,
      byte newLicType,
      byte newSubType)
    {
      this.lastAppliedActKey = key;
      if (this.licensingInitialized && newStatus == LicenseStatus.Activated && this.initializedStatus != LicenseStatus.Activated)
        this.licenseInfo.Status = LicenseStatus.NeedRestart;
      else
        this.licenseInfo.Status = newStatus;
      this.licenseInfo.LicenseType = newLicType;
      this.licenseInfo.IsConcurrent = newSubType == (byte) 1;
      this.licenseInfo.WorkplaceCount = newLicCount >= (ushort) 65000 ? new uint?() : new uint?((uint) newLicCount);
      this.licenseInfo.PrivilegeCount = newPrivilegeCount >= (ushort) 65000 ? new uint?() : new uint?((uint) newPrivilegeCount);
      this.licenseInfo.TrialExpiration = newExpirationDate;
    }

    public ModelRegistrarImpl()
    {
      ModelRegistrarImpl.Yx3YPghfl6nsek2iUuj1();
      // ISSUE: reference to a compiler-generated field
      Action<IDictionary<Guid, Type>, Type, Guid> action1 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_0;
      Action<IDictionary<Guid, Type>, Type, Guid> remove1;
      if (action1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_0 = remove1 = (Action<IDictionary<Guid, Type>, Type, Guid>) ((c, _, uid) => c.Remove(uid));
      }
      else
        goto label_16;
label_2:
      this._typesByUid = PublishCacheContext.CreateCache<Guid, Type>(remove1);
      this._removedTypes = PublishCacheContext.CreateCache<Guid, Type>((Action<IDictionary<Guid, Type>, Type, Guid>) ((c, type, uid) =>
      {
        if (TypeOf<IEntityFilter>.Raw.IsAssignableFrom(type))
          return;
        c[uid] = type;
      }));
      // ISSUE: reference to a compiler-generated field
      Action<IDictionary<Guid, IMetadata>, Type, Guid> action2 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_2;
      Action<IDictionary<Guid, IMetadata>, Type, Guid> remove2;
      if (action2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_2 = remove2 = (Action<IDictionary<Guid, IMetadata>, Type, Guid>) ((c, _, uid) => c.Remove(uid));
      }
      else
        goto label_15;
label_5:
      this._metadataList = PublishCacheContext.CreateCache<Guid, IMetadata>(remove2);
      this._metadataParents = PublishCacheContext.CreateCache<Guid, IMetadata>((Action<IDictionary<Guid, IMetadata>, Type, Guid>) ((c, _, uid) => c.Remove(uid)));
      // ISSUE: reference to a compiler-generated field
      Action<IDictionary<string, AssemblyModelsMetadata>, Type, Guid> action3 = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_4;
      Action<IDictionary<string, AssemblyModelsMetadata>, Type, Guid> remove3;
      if (action3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_4 = remove3 = (Action<IDictionary<string, AssemblyModelsMetadata>, Type, Guid>) ((c, t, u) => { });
      }
      else
        goto label_3;
label_8:
      this._asmModelsMetadataDict = PublishCacheContext.CreateCache<string, AssemblyModelsMetadata>(remove3);
      // ISSUE: reference to a compiler-generated field
      Func<ISet<Guid>, ISet<Guid>> func = ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_5;
      Func<ISet<Guid>, ISet<Guid>> clone;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        ModelRegistrarImpl.\u003C\u003Ec.\u003C\u003E9__91_5 = clone = (Func<ISet<Guid>, ISet<Guid>>) (c => (ISet<Guid>) new HashSet<Guid>((IEnumerable<Guid>) c));
      }
      else
        goto label_6;
label_11:
      this.configUids = PublishCacheContext.CreateCache<Guid>(clone);
      this._modelAssemblies = new List<Assembly>();
      this._typeDescriptorsByUid = new Dictionary<(Guid, Guid), ITypeDescriptor>();
      this._typeDescriptorsByType = new Dictionary<Type, ITypeDescriptor>();
      this.registeredTypes = (ISet<Type>) new HashSet<Type>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
        case 0:
          return;
        default:
          return;
      }
label_6:
      clone = func;
      goto label_11;
label_3:
      remove3 = action3;
      goto label_8;
label_15:
      remove2 = action2;
      goto label_5;
label_16:
      remove1 = action1;
      goto label_2;
    }

    static ModelRegistrarImpl()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ModelRegistrarImpl.publishLogger = (ILogger) ModelRegistrarImpl.KnONIkhfrALglGWycAdB(ModelRegistrarImpl.DXCyuKhE2myPrbWWHu8M(-2106517564 ^ -2106456060));
            num = 3;
            continue;
          case 2:
            ModelRegistrarImpl.Yx3YPghfl6nsek2iUuj1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
            continue;
          case 3:
            ModelRegistrarImpl.securityAssemblyUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099551987));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object Sts3SxhEijg8pQXRUhEn() => (object) ComponentManager.Current;

    internal static object X95t0nhERmiTkRBTIGSO([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object fTxXPfhEqYpAM5v2up7W([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static object LBmBFrhEKAAtgIukDOCQ([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static uint pG9VjJhEXu7I2ZLyhrZ3([In] object obj0) => ((IWorkplaceLicenseInfoOwner) obj0).UsedLicenseCount;

    internal static bool dNRqOvhEV0WY1pLZZ3cv() => ModelRegistrarImpl.AooqRUhEIeI5n6Mpant1 == null;

    internal static ModelRegistrarImpl nIKRVmhESm4OrmMkI7mO() => ModelRegistrarImpl.AooqRUhEIeI5n6Mpant1;

    internal static bool gqLemFhETc963syN82Z2([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static DateTime HwZMFShEk8CeWGj8sZKH() => DateTime.Now;

    internal static object da0jhhhEnHZHVHZn1IHW() => (object) PublishCacheContext.Create();

    internal static object URcIOQhEOaIf6vKOwdeg([In] object obj0) => (object) ((IRuntimeApplication) obj0).DbPreUpdater;

    internal static object DXCyuKhE2myPrbWWHu8M(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hgIkSShEeHFSirvB1wg6([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object uGTM6NhEP1WTivFv8sgr(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static void khgNxJhE13keHsOYC8wd([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object ylU8LMhENJ3no4g00OBs() => (object) Logger.Log;

    internal static TimeSpan hB6xcphE3RLmeOMZs7uV([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static object VprG0OhEpIdm4mYL18WY([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static void V9eqT4hEaFyxG5KTYqNU([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static bool W2VonghEDp1sNQp329ks([In] object obj0) => ((DbPreUpdater) obj0).NeedRecompileConfigurationModel;

    internal static void oaG8mUhEtGIqnr5HeLQN([In] object obj0, [In] object obj1) => ((DbPreUpdater) obj0).RecompileConfigurationModel((IMetadataRuntimeService) obj1);

    internal static void NBV50xhEwZAEYM0FeJP0([In] object obj0) => ((DbPreUpdater) obj0).DeletePreparedModelConfiguration();

    internal static object E5fXP0hE4wBb7JxGRnsP([In] object obj0, [In] object obj1) => (object) ((IEventHandlerSubscribeService) obj0).Subscribe((IEventHandler) obj1);

    internal static void z5ygoDhE6VihNm5EdJHJ([In] object obj0) => ((ModelRegistrarImpl.PublicationEventHandler) obj0).Wait();

    internal static void WrFJrwhEH8iRcUc13Z7K([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static bool Bmp32thEA1hdepj1Chu9([In] object obj0) => ((IDynamicPublicationService) obj0).Enable;

    internal static object efpZtQhE7Lpy90klgyZv() => (object) MetadataItemManager.Instance;

    internal static int pwf3XNhExHw4JX2ZveYd([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static object RK4bCNhE0d4G5UHXWjRX([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).AssemblyRawStream;

    internal static object dYKhTQhEmRiOvikgv19S([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static object M4Bho7hEylM5d6QSLLKm([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool zucfSrhEMNClQwH8Outc([In] object obj0) => Directory.Exists((string) obj0);

    internal static object OIrrekhEJr8xYG18WsJf([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static object tcbG00hE9RUI5mfHviBO([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void wtBPlmhEdc7QFZsF41cb(
      [In] object obj0,
      [In] object obj1,
      TimeSpan interval,
      int attemptCount)
    {
      IOExtensions.WriteAllBytesWithAttempts((string) obj0, (Stream) obj1, interval, attemptCount);
    }

    internal static object EfHg8RhElrHjJPIViysi([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DocumentationRawStream;

    internal static long xq8EYQhErJrawiw2AFnv([In] object obj0) => ((Stream) obj0).Length;

    internal static object Wl7JVPhEgcxNIjiA2Pl0([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).DebugRawStream;

    internal static object gB9hkNhE52D7axtIfSwc([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((MemoryStream) obj0, (MemoryStream) obj1);

    internal static bool oHZ0mMhEjj8uA3MtknRU([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void MVVdaLhEY32cKChTO0gG([In] object obj0) => ConfigurationModelAssemblyBuilder.InitVersion((Assembly) obj0);

    internal static bool tVofbYhELfbcXgg38gWJ([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object qGHMbhhEUpDZSh3FLHPo() => (object) Encoding.UTF8;

    internal static object FiqTxthEsrhBCZS0r4kR([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static bool JilRh4hEcsSIxTlIWqPc([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static int kEYJxVhEzDx31dO7Kgu0([In] object obj0) => ((List<Assembly>) obj0).Count;

    internal static object mwAKgLhfFsefQerrPsaa() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static void XWlIc9hfBJ2poxTt2OPq([In] object obj0, [In] object obj1) => EleWise.ELMA.SR.RunWithCulture((CultureInfo) obj0, (System.Action) obj1);

    internal static object AEtwtkhfWC0U0uEK8v85([In] object obj0, [In] object obj1) => (object) ((ComponentManager) obj0).RegisterAssembly((Assembly) obj1);

    internal static void krLxZlhfo1jHd6SdRGY3() => PublishCacheContext.Complete();

    internal static Guid gFpNn3hfbtFM9pIpBFuP([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static bool nVCrBKhfhn5vgCsEkxNR([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool i1dslmhfGaIQV5V3IBJA([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Type wEt5wShfEa8qi4IyHtVr([In] object obj0, Guid uid) => ((ITypeResolver) obj0).GetTypeByUid(uid);

    internal static object w8YUuXhffKXZjDWEUk3K([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void UBkMgyhfQTI6aVNvhRiu([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool S1SdV4hfCSkBSyri1HPC([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type tqZmAZhfvGmcVTaD1kmJ(Type t) => InterfaceActivator.TypeOf(t);

    internal static Type HlH5dnhf8tQP4FsdRdNP([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type Wtt178hfZpB8Q7bU4fpj([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetReflectionType((string) obj1);

    internal static Type JlTCquhfumknDMrpTWlR(Type type) => ModelRegistrarImpl.GetClassMapType(type);

    internal static Type GbMhblhfIMgpeDmufJyX([In] object obj0, Type objectType) => ((DefaultManagerAttribute) obj0).GetManagerType(objectType);

    internal static object UqibHohfVovHU8xcqoov([In] object obj0) => (object) ((Assembly) obj0).GetTypes();

    internal static bool Wsvw58hfSVmuBGiKAwiR([In] object obj0, [In] object obj1) => (ConstructorInfo) obj0 == (ConstructorInfo) obj1;

    internal static object qWghdOhfiMb8tPkhytZn([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object ChOnXUhfRhH8rLUrxc4F([In] Type obj0) => (object) Expression.Parameter(obj0);

    internal static object K82ELyhfq2fpNNBNuZ3L([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object YHxmNOhfK9dsQZ1rwpgm([In] object obj0, [In] object obj1) => (object) Expression.New((ConstructorInfo) obj0, (Expression[]) obj1);

    internal static object VNt3C8hfXEX8VlqqbNII([In] object obj0) => (object) ((ReflectionTypeLoadException) obj0).LoaderExceptions;

    internal static object oyOQABhfT9E9uhgPKR45([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object l2kem6hfkakMvFnQHapv([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object AJ6eCihfnWjLC60sx0wi(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object Wr7pl5hfOil7UYrISmCf() => (object) ComponentManager.GetAssemblies();

    internal static bool nXhtpehf2rXE0fovMO40([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object Sy81uGhfeIrcBD4lpNhc([In] object obj0) => (object) ((IRuntimeApplication) obj0).ApplicationStartCache;

    internal static bool e2ZmhihfP8jeVLp8mMmq([In] object obj0) => ((ApplicationStartCache) obj0).DynamicPublication;

    internal static void BVq164hf129OL8G4SE5i([In] object obj0, bool value) => ((ApplicationStartCache) obj0).DynamicPublication = value;

    internal static int tG1UTShfNT8wvqKuxjPr([In] object obj0) => ((List<AssemblyModelsMetadata>) obj0).Count;

    internal static object iJYS7ihf397WGdKkIr4t([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static bool XTGhC3hfp93ohNu6VfIJ([In] object obj0) => ((DynamicModelAssemblyBuilder) obj0).HasChanges();

    internal static int rhfAaIhfaKlXCrPZMiP7([In] object obj0) => ((ICollection<EntityMetadata>) obj0).Count;

    internal static object CX5PulhfDoGDrQDPxsdG([In] object obj0) => (object) ((DynamicModelAssemblyBuilder) obj0).DocumentationRawStream;

    internal static TimeSpan de1BAwhft2mQC7GHpLeG([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static void QI4ba9hfwsCMmvuax3P0([In] object obj0, [In] object obj1) => ((ContainerBuilder) obj0).Update((IContainer) obj1);

    internal static bool eOsjDphf4p3AjPuLK26i([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static LicenseStatus pqimPUhf6YWUW2yVLWik([In] object obj0) => ((LicenseInfo) obj0).Status;

    internal static object D08CImhfHyXgSSwGlqMr(ushort algorithm) => (object) ModelRegistrarImpl.GenerateRegistrationKey(algorithm);

    internal static void CJ5OXGhfAjPy4RoqMw7D([In] object obj0, LicenseStatus value) => ((LicenseInfo) obj0).Status = value;

    internal static void CsYqvohf7XEKwOQ02YBd([In] object obj0) => Monitor.Exit(obj0);

    internal static int rPsUdMhfx5xoOjZloj6i([In] object obj0) => ((string) obj0).Length;

    internal static object I4tox1hf0PCbTAyAnoup([In] object obj0) => (object) ModelRegistrarImpl.FormatKey(obj0);

    internal static object ylLCqThfma6DuURpdN0j([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object w9gn6chfyeFQwxgLoZ2p([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object rrfTO6hfMDvqmf4gOhAx([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object tylfvfhfJi5EvwAF0dQr([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static uint kfGRYohf9CMyBJoUuVbJ([In] object obj0) => uint.Parse((string) obj0);

    internal static ushort RpGkAahfdtIjA4x3Y64Y([In] object obj0) => ((LicensedUnitBase) obj0).GetDbLicenseCount();

    internal static void Yx3YPghfl6nsek2iUuj1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object KnONIkhfrALglGWycAdB([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    /// <summary>Наборы типов интерфейс/динамик-интерфейс/класс</summary>
    private class EntityTypesSet
    {
      internal static object UftMuuCgN2qaGcUZy4Mn;

      public EntityTypesSet(Guid uid)
      {
        ModelRegistrarImpl.EntityTypesSet.LbgOQmCgaZAgn1Agmxcw();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.Uid = uid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

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

      public Type IntfType
      {
        get => this.\u003CIntfType\u003Ek__BackingField;
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
                this.\u003CIntfType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

      public Type ImplType
      {
        get => this.\u003CImplType\u003Ek__BackingField;
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
                this.\u003CImplType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

      public Type ExtType
      {
        get => this.\u003CExtType\u003Ek__BackingField;
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
                this.\u003CExtType\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

      internal static void LbgOQmCgaZAgn1Agmxcw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool qcBCxvCg37H3pA38GLEs() => ModelRegistrarImpl.EntityTypesSet.UftMuuCgN2qaGcUZy4Mn == null;

      internal static ModelRegistrarImpl.EntityTypesSet enMNlRCgp9MXEgeLT7Jf() => (ModelRegistrarImpl.EntityTypesSet) ModelRegistrarImpl.EntityTypesSet.UftMuuCgN2qaGcUZy4Mn;
    }

    private class PublicationEventHandler : IPublicationEventHandler, IEventHandler
    {
      private readonly TaskCompletionSource<bool> waitPublication;
      internal static object k2eFTiCgD0WY5xi47bI6;

      public void Complete(Guid publicationToken)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.waitPublication.TrySetResult(true);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Error(Guid publicationToken, Exception exception)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.waitPublication.TrySetResult(false);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Wait()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ModelRegistrarImpl.PublicationEventHandler.YaHr02Cg48WoDYLVYhNe((object) this.waitPublication.Task);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public PublicationEventHandler()
      {
        ModelRegistrarImpl.PublicationEventHandler.ILYbKhCg6CgxiE2ygmL5();
        this.waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool xBq2x7Cgt6BSbPjf4rfC() => ModelRegistrarImpl.PublicationEventHandler.k2eFTiCgD0WY5xi47bI6 == null;

      internal static ModelRegistrarImpl.PublicationEventHandler CXTO1lCgwqF9XG7rGUQj() => (ModelRegistrarImpl.PublicationEventHandler) ModelRegistrarImpl.PublicationEventHandler.k2eFTiCgD0WY5xi47bI6;

      internal static void YaHr02Cg48WoDYLVYhNe([In] object obj0) => ((Task) obj0).Wait();

      internal static void ILYbKhCg6CgxiE2ygmL5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
