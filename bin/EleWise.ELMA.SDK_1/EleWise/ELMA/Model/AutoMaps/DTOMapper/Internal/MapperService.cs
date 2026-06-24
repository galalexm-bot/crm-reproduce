// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.MapperService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Mappers;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>Сервис маппинга</summary>
  [Service(Type = ComponentType.Server)]
  internal sealed class MapperService : AbstractMapperService, IModuleMapperService, IMapperService
  {
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private IEnumerable<IInternalMapperConfiguration> moduleMappers;
    private static MapperService vGQ6puh0StQrbiHBLvSP;

    /// <summary>Ctor</summary>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    public MapperService(IModuleMetadataLoader moduleMetadataLoader)
    {
      MapperService.NuT0xch0qCEpVTDqQ4U3();
      // ISSUE: explicit constructor call
      base.\u002Ector(moduleMetadataLoader);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список мапперов модулей</summary>
    IEnumerable<IInternalMapperConfiguration> IModuleMapperService.ModuleMappers
    {
      get => this.moduleMappers;
      set => this.moduleMappers = value;
    }

    /// <summary>Инициализировать</summary>
    protected override void Init()
    {
      int num1 = 2;
      MapperService mapperService;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            mapperService = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.moduleMappers == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
              continue;
            }
            goto label_68;
          case 3:
            goto label_6;
          case 4:
            goto label_69;
          default:
            lockTaken = false;
            num1 = 3;
            continue;
        }
      }
label_69:
      return;
label_68:
      return;
label_6:
      try
      {
        Monitor.Enter((object) mapperService, ref lockTaken);
        int num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num2 = 0;
        ISearchMetadataService service;
        List<IInternalMapperConfiguration> systemMappers;
        MetadataMapperConfigurator mapperConfigurator1;
        TypeSettingsMapperConfigurator mapperConfigurator2;
        MetadataServiceContext metadataServiceContext;
        List<IInternalMapperConfiguration> moduleMapperConfigurations;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
                IEnumerator<Guid> enumerator = ModuleMetadataItemHeaderManager.DesignerModules.GetEnumerator();
                int num3 = 3;
                int index;
                ModuleVersion[] orAdd;
                ModuleMetadataItem moduleMetadataItem1;
                ModuleVersion moduleVersion;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      LoadMapper(moduleMetadataItem1);
                      num3 = 6;
                      continue;
                    case 2:
                      index = 0;
                      num3 = 7;
                      continue;
                    case 3:
                      try
                      {
label_43:
                        if (MapperService.gFec9Kh0ThsxoKkVxMsu((object) enumerator))
                          goto label_42;
                        else
                          goto label_44;
label_36:
                        ModuleMetadataItem moduleMetadataItem2;
                        Guid current;
                        ModuleMetadataItemHeader metadataItemHeader;
                        int num4;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              moduleMetadataItem2 = (ModuleMetadataItem) MapperService.BdpCbqh0X0FO9B3lnRlb((object) metadataItemHeader);
                              num4 = 7;
                              continue;
                            case 3:
                              metadataItemHeader = ((AbstractNHEntityManager<ModuleMetadataItemHeader, long>) MapperService.L1N7Uph0KHlnrSeL894C()).LoadOrNull(current);
                              num4 = 5;
                              continue;
                            case 4:
                              goto label_30;
                            case 5:
                              if (metadataItemHeader == null)
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                                continue;
                              }
                              goto case 1;
                            case 6:
                              goto label_42;
                            case 7:
                              if (moduleMetadataItem2 == null)
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 2;
                                continue;
                              }
                              goto case 9;
                            case 9:
                              LoadMapper(moduleMetadataItem2);
                              num4 = 8;
                              continue;
                            default:
                              goto label_43;
                          }
                        }
label_42:
                        current = enumerator.Current;
                        num4 = 3;
                        goto label_36;
label_44:
                        num4 = 4;
                        goto label_36;
                      }
                      finally
                      {
                        if (enumerator != null)
                        {
                          int num5 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                            num5 = 0;
                          while (true)
                          {
                            switch (num5)
                            {
                              case 1:
                                goto label_52;
                              default:
                                MapperService.XCkf6oh0kOYjyn0JwDOr((object) enumerator);
                                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                                continue;
                            }
                          }
                        }
label_52:;
                      }
                    case 4:
label_30:
                      orAdd = this.PublishedModules.GetOrAdd(Guid.Empty, (Func<Guid, ModuleVersion[]>) (g => this.moduleMetadataLoader.GetAllDefaultVersions((IEnumerable<Guid>) ModuleMetadataItemHeaderManager.DesignerModules).ToArray<ModuleVersion>()));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
                      continue;
                    case 5:
                      moduleVersion = orAdd[index];
                      num3 = 9;
                      continue;
                    case 6:
                    case 10:
                      ++index;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                      continue;
                    case 8:
                      if (moduleMetadataItem1 == null)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto case 1;
                    case 9:
                      moduleMetadataItem1 = ((AbstractNHEntityManager<ModuleMetadataItem, long>) MapperService.JF2lSqh0naxOHvUWo4Wv()).LoadOrNull(MapperService.yr7R7Vh02Ngdn5x3xYQa(MapperService.yp226wh0OlsQghG75GsR((object) moduleVersion)));
                      num3 = 8;
                      continue;
                    case 11:
                      goto label_61;
                    default:
                      if (index >= orAdd.Length)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 11 : 4;
                        continue;
                      }
                      goto case 5;
                  }
                }
              }
              finally
              {
                int num6;
                if (metadataServiceContext == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
                else
                  goto label_58;
label_56:
                switch (num6)
                {
                  case 1:
                    break;
                  default:
                }
label_58:
                MapperService.XCkf6oh0kOYjyn0JwDOr((object) metadataServiceContext);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                {
                  num6 = 0;
                  goto label_56;
                }
                else
                  goto label_56;
              }
            case 2:
              goto label_64;
            case 3:
              mapperConfigurator1 = new MetadataMapperConfigurator(service);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 16 : 11;
              continue;
            case 4:
              mapperConfigurator2 = new TypeSettingsMapperConfigurator(service);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 14 : 18;
              continue;
            case 5:
              if (this.moduleMappers == null)
              {
                num2 = 8;
                continue;
              }
              goto label_57;
            case 6:
              MapperService.rDmNvoh01aBy9lkVYklp((object) this.PublishedModules);
              num2 = 17;
              continue;
            case 7:
            case 10:
label_61:
              systemMappers = new List<IInternalMapperConfiguration>();
              num2 = 3;
              continue;
            case 8:
              moduleMapperConfigurations = new List<IInternalMapperConfiguration>();
              num2 = 11;
              continue;
            case 9:
              MapperService.pj8687h0PO9HBDiO4QSc((object) this.mappersByTypeAndUidCache);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            case 11:
              service = Locator.GetService<ISearchMetadataService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 4 : 12;
              continue;
            case 12:
              if (service == null)
              {
                num2 = 7;
                continue;
              }
              goto case 13;
            case 13:
              metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) service.GetPublishedDataClasses());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
              continue;
            case 14:
              MapperService.R5otNMh0ewZI2IbO3hwp((object) this.mappersByUidCache);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 9 : 9;
              continue;
            case 15:
              this.mappers = (ICollection<IInternalMapperConfiguration>) new MappersCollection((ICollection<IInternalMapperConfiguration>) moduleMapperConfigurations, (ICollection<IInternalMapperConfiguration>) systemMappers);
              num2 = 14;
              continue;
            case 16:
              systemMappers.AddRange(mapperConfigurator1.Init());
              num2 = 4;
              continue;
            case 17:
              this.moduleMappers = (IEnumerable<IInternalMapperConfiguration>) moduleMapperConfigurations;
              num2 = 2;
              continue;
            case 18:
              systemMappers.AddRange(mapperConfigurator2.Init());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 5 : 15;
              continue;
            default:
              this.mappersByTypeRef.Clear();
              num2 = 6;
              continue;
          }
        }
label_64:
        return;
label_57:

        void LoadMapper(ModuleMetadataItem moduleMetadataItem)
        {
          int num1 = 5;
          Assembly assembly;
          while (true)
          {
            switch (num1)
            {
              case 1:
                goto label_29;
              case 2:
                assembly = (Assembly) MapperService.CqK2D0h0tIms1nbIQNNX((object) moduleMetadataItem.AssemblyRaw, MapperService.C5h50hh0D6wD04h6lOWC((object) moduleMetadataItem));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_3;
              case 4:
                if (MapperService.G5KEhXh0aJISfCKq4eMJ((object) assembly, (object) null))
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 2;
                  continue;
                }
                break;
              case 5:
                assembly = (Assembly) MapperService.sedid3h0pCLtm8aYY7LJ((object) ScriptExecutionHandlerHelper.CreateFullAssemblyName(moduleMetadataItem.AssemblyName, (string) MapperService.oP4RNXh0N2giDif6aSeV((object) moduleMetadataItem), (string) MapperService.ll0IZMh03EUWPNsLasTl(1917998801 >> 2 ^ 479481938), (string) MapperService.ll0IZMh03EUWPNsLasTl(~1767720452 ^ -1767724771)), true);
                num1 = 4;
                continue;
            }
            num1 = 3;
          }
label_29:
          return;
label_3:
          try
          {
            object source = MapperService.HrEIWwh0wZw73otfnkSl((object) assembly);
            // ISSUE: reference to a compiler-generated field
            Func<Type, bool> func = MapperService.\u003C\u003Ec.\u003C\u003E9__6_2;
            Func<Type, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: type reference
              // ISSUE: reference to a compiler-generated method
              MapperService.\u003C\u003Ec.\u003C\u003E9__6_2 = predicate = (Func<Type, bool>) (type => MapperService.\u003C\u003Ec.jsuyYcv4gaKNxaYIvIWu(__typeref (IInternalMapperConfiguration)).IsAssignableFrom(type));
            }
            else
              goto label_38;
label_5:
            IEnumerator<Type> enumerator = ((IEnumerable<Type>) source).Where<Type>(predicate).GetEnumerator();
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
              num2 = 1;
            switch (num2)
            {
              case 0:
                return;
              case 1:
                try
                {
label_10:
                  if (MapperService.gFec9Kh0ThsxoKkVxMsu((object) enumerator))
                    goto label_13;
                  else
                    goto label_11;
label_9:
                  IMapperConfiguration mapperConfiguration;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_13;
                      case 2:
                        moduleMapperConfigurations.Add((IInternalMapperConfiguration) mapperConfiguration);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                        continue;
                      case 3:
                        mapperConfiguration.InitMap();
                        num3 = 5;
                        continue;
                      case 4:
                        goto label_20;
                      case 5:
                        mapperConfiguration.InitMapReverse();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 2;
                        continue;
                      default:
                        goto label_10;
                    }
                  }
label_20:
                  return;
label_11:
                  num3 = 4;
                  goto label_9;
label_13:
                  mapperConfiguration = (IMapperConfiguration) MapperService.XuyNkuh04fNLDA2Yw7gW(enumerator.Current);
                  num3 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
                  {
                    num3 = 3;
                    goto label_9;
                  }
                  else
                    goto label_9;
                }
                finally
                {
                  int num4;
                  if (enumerator == null)
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                  else
                    goto label_22;
label_19:
                  switch (num4)
                  {
                    case 2:
                      break;
                    default:
                  }
label_22:
                  MapperService.XCkf6oh0kOYjyn0JwDOr((object) enumerator);
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                  {
                    num4 = 1;
                    goto label_19;
                  }
                  else
                    goto label_19;
                }
              default:
                return;
            }
label_38:
            predicate = func;
            goto label_5;
          }
          catch (ReflectionTypeLoadException ex)
          {
            int num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
              num5 = 1;
            string str1;
            string str2;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  str1 = (string) MapperService.gLjHjmh060ZrZ6VTspP4(MapperService.ll0IZMh03EUWPNsLasTl(-420743386 ^ -420952272), (object) ((IEnumerable<Exception>) ex.LoaderExceptions).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 2;
                  continue;
                case 2:
                  goto label_33;
                case 3:
                  str2 = (string) MapperService.C3Mm83h0HT39yMTRCoW0((object) new object[4]
                  {
                    MapperService.ll0IZMh03EUWPNsLasTl(92412609 - 1050237057 ^ -957615340),
                    (object) assembly,
                    MapperService.ll0IZMh03EUWPNsLasTl(323422137 << 2 ^ 1293703110),
                    (object) str1
                  });
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                  continue;
                default:
                  MapperService.oBO5boh07dMbbmsTdLf0(MapperService.o4IuJih0A6x9jpLVcfaA(), (object) str2, (object) ex);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 1;
                  continue;
              }
            }
label_33:
            throw;
          }
        }
      }
      finally
      {
        int num7;
        if (!lockTaken)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 0;
        else
          goto label_70;
label_67:
        switch (num7)
        {
          case 1:
          case 2:
        }
label_70:
        Monitor.Exit((object) mapperService);
        num7 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        {
          num7 = 0;
          goto label_67;
        }
        else
          goto label_67;
      }
    }

    internal static void NuT0xch0qCEpVTDqQ4U3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sk9xEbh0ibVclc4duuqg() => MapperService.vGQ6puh0StQrbiHBLvSP == null;

    internal static MapperService YIliVdh0R4jxh9OdyRor() => MapperService.vGQ6puh0StQrbiHBLvSP;

    internal static object L1N7Uph0KHlnrSeL894C() => (object) ModuleMetadataItemHeaderManager.Instance;

    internal static object BdpCbqh0X0FO9B3lnRlb([In] object obj0) => (object) ((ModuleMetadataItemHeader) obj0).Published;

    internal static bool gFec9Kh0ThsxoKkVxMsu([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void XCkf6oh0kOYjyn0JwDOr([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object JF2lSqh0naxOHvUWo4Wv() => (object) ModuleMetadataItemManager.Instance;

    internal static object yp226wh0OlsQghG75GsR([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static Guid yr7R7Vh02Ngdn5x3xYQa([In] object obj0) => ((ModuleVersionHeader) obj0).VersionUid;

    internal static void R5otNMh0ewZI2IbO3hwp([In] object obj0) => ((ConcurrentDictionary<Guid, IInternalMapperConfiguration>) obj0).Clear();

    internal static void pj8687h0PO9HBDiO4QSc([In] object obj0) => ((ConcurrentDictionary<(Type, Guid), ISet<IInternalMapperConfiguration>>) obj0).Clear();

    internal static void rDmNvoh01aBy9lkVYklp([In] object obj0) => ((ConcurrentDictionary<Guid, ModuleVersion[]>) obj0).Clear();

    internal static object oP4RNXh0N2giDif6aSeV([In] object obj0) => (object) ((ModuleMetadataItem) obj0).Version;

    internal static object ll0IZMh03EUWPNsLasTl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sedid3h0pCLtm8aYY7LJ([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static bool G5KEhXh0aJISfCKq4eMJ([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object C5h50hh0D6wD04h6lOWC([In] object obj0) => (object) ((ModuleMetadataItem) obj0).DebugRaw;

    internal static object CqK2D0h0tIms1nbIQNNX([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((byte[]) obj0, (byte[]) obj1);

    internal static object HrEIWwh0wZw73otfnkSl([In] object obj0) => (object) ((Assembly) obj0).GetTypes();

    internal static object XuyNkuh04fNLDA2Yw7gW([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object gLjHjmh060ZrZ6VTspP4([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object C3Mm83h0HT39yMTRCoW0([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static object o4IuJih0A6x9jpLVcfaA() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void oBO5boh07dMbbmsTdLf0([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    /// <summary>Handler для сброса мапперов при публикации сущностей</summary>
    [Component]
    private class EntityPublishRefreshMappersHandler : IPublicationEventHandler, IEventHandler
    {
      private readonly object mapperService;
      internal static object fc1Oylv47XVUuvjZanap;

      /// <summary>Ctor</summary>
      /// <param name="mapperService">Сервис маппинга</param>
      public EntityPublishRefreshMappersHandler(MapperService mapperService)
      {
        MapperService.EntityPublishRefreshMappersHandler.N5rtQ3v4mitvxVEeO451();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.mapperService = (object) mapperService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
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
              ((MapperService) this.mapperService).moduleMappers = (IEnumerable<IInternalMapperConfiguration>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public void Error(Guid publicationToken, Exception exception)
      {
      }

      internal static void N5rtQ3v4mitvxVEeO451() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool zh2NF5v4xxUj961wITkv() => MapperService.EntityPublishRefreshMappersHandler.fc1Oylv47XVUuvjZanap == null;

      internal static MapperService.EntityPublishRefreshMappersHandler ihVug1v40Ow1UvESiQSg() => (MapperService.EntityPublishRefreshMappersHandler) MapperService.EntityPublishRefreshMappersHandler.fc1Oylv47XVUuvjZanap;
    }
  }
}
