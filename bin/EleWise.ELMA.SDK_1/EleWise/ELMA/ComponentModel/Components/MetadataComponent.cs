// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.Components.MetadataComponent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Events;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.ComponentModel.Components
{
  /// <summary>Компонент управления метаданными для рантайма</summary>
  internal class MetadataComponent : MemoryMetadataComponent
  {
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private readonly MetadataItemManager metadataItemManager;
    private readonly MetadataItemHeaderManager metadataItemHeaderManager;
    private readonly IComplexCacheService complexCacheService;
    private static MetadataComponent qbKlHYfu8WyGViFm3r8g;

    /// <summary>Ctor</summary>
    /// <param name="modelAssemblyName">Имя редактируемого проекта моделей</param>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
    /// <param name="metadataItemHeaderManager">Менеджер заголовков метаданных</param>
    /// <param name="complexCacheService">Составной кэш</param>
    /// <param name="eventHandlerSubscribeService">Сервис для ручной подписки на события</param>
    public MetadataComponent(
      string modelAssemblyName,
      IMetadataRuntimeService metadataRuntimeService,
      MetadataItemManager metadataItemManager,
      MetadataItemHeaderManager metadataItemHeaderManager,
      IComplexCacheService complexCacheService,
      IEventHandlerSubscribeService eventHandlerSubscribeService)
    {
      MetadataComponent.nphwH6fuIZAY8Zo8MUst();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            eventHandlerSubscribeService.Subscribe((IEventHandler) new MetadataComponent.MetadataPublishFinishedEventHandler(this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            this.metadataItemHeaderManager = metadataItemHeaderManager;
            num = 6;
            continue;
          case 3:
            MetadataComponent.owGQmQfuSOp0PpJVxeqT((object) modelAssemblyName, MetadataComponent.VbluF0fuVc0viuRjfEIQ(372753449 ^ 372659143));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 3 : 4;
            continue;
          case 4:
            this.ProjectName = modelAssemblyName;
            num = 7;
            continue;
          case 5:
            this.complexCacheService = complexCacheService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          case 6:
            this.metadataRuntimeService = metadataRuntimeService;
            num = 5;
            continue;
          case 7:
            this.metadataItemManager = metadataItemManager;
            num = 2;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:;
    }

    /// <inheritdoc />
    public override string ProjectName { get; }

    /// <inheritdoc />
    public override void SaveMetadata(IEnumerable<IMetadata> metadataList)
    {
      if (metadataList == null)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, IMetadataItem> currentItems = this.metadataItemHeaderManager.FindByIdArray(metadataList.Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => m.Uid)).ToArray<Guid>()).ToDictionary<IMetadataItemHeader, Guid, IMetadataItem>((Func<IMetadataItemHeader, Guid>) (h => MetadataComponent.\u003C\u003Ec.tMYSMP85NvXgkiQSrDnb((object) h)), (Func<IMetadataItemHeader, IMetadataItem>) (h => (IMetadataItem) MetadataComponent.\u003C\u003Ec.jZKRh8853oo0btqeUbe2((object) h)));
      this.metadataItemManager.Save((IEnumerable<IMetadataItem>) metadataList.Select<IMetadata, IMetadataItem>((Func<IMetadata, IMetadataItem>) (m =>
      {
        int num = 1;
        IMetadataItem metadataItem;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!currentItems.TryGetValue(m.Uid, out metadataItem))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              MetadataComponent.\u003C\u003Ec__DisplayClass4_0.RMMxC285OKHcQtdWmWo8((object) metadataItem, (object) m);
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              InstanceOf<IMetadataItem> instanceOf = new InstanceOf<IMetadataItem>();
              // ISSUE: reference to a compiler-generated method
              MetadataComponent.\u003C\u003Ec__DisplayClass4_0.eNf0Mw85nTXgMsqV325d((object) instanceOf.New, m.Uid);
              metadataItem = instanceOf.New;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return metadataItem;
      })).ToArray<IMetadataItem>());
      this.ClearCacheDraftItems();
      base.SaveMetadata(metadataList);
    }

    /// <inheritdoc />
    public override void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment)
    {
      if (metadataList == null || !metadataList.Any<IMetadata>())
        return;
      this.ValidateMetadataItem(metadataList);
      // ISSUE: reference to a compiler-generated method
      long[] array = this.metadataItemHeaderManager.FindByIdArray(metadataList.Select<IMetadata, Guid>((Func<IMetadata, Guid>) (m => MetadataComponent.\u003C\u003Ec.Ud8REm85pHbW3G04d8cq((object) m))).ToArray<Guid>()).Select<IMetadataItemHeader, long>((Func<IMetadataItemHeader, long>) (h => h.Id)).ToArray<long>();
      this.metadataItemManager.Publish(comment, array);
    }

    /// <inheritdoc />
    public override MetadataItemDTO GetMetadataItemDTO(IMetadata metadata) => throw new NotImplementedException();

    /// <inheritdoc />
    public override IEnumerable<MetadataItemDTO> GetMetadataItemDTOList() => throw new NotImplementedException();

    /// <inheritdoc />
    public override IMetadata GetMetadata(string projectName, Guid metadataUid)
    {
      int num = 1;
      IMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MetadataComponent.W4nVFffuiNeYAe0BSI4d((object) projectName, (object) this.ProjectName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            if (!this.DraftItems.TryGetValue(metadataUid, out metadata))
            {
              num = 3;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return metadata;
label_5:
      return base.GetMetadata(projectName, metadataUid);
    }

    /// <inheritdoc />
    public override IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited) => projectName == this.ProjectName && !inherited ? (IEnumerable<IMetadata>) this.DraftItems.Values : base.GetMetadataList(projectName, inherited);

    /// <inheritdoc />
    protected override void LoadProject()
    {
      int num1 = 1;
      bool flag;
      NamespaceMetadata namespaceMetadata;
      IEnumerator<AssemblyModelsMetadata> enumerator1;
      IEnumerator<string> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MetadataComponent.dfJtMKfuqmasOQkBfB2t((object) this, MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            MetadataComponent.X03Jh0fueb041JgoDhcH((object) namespaceMetadata, MetadataComponent.VbluF0fuVc0viuRjfEIQ(-1204263869 ^ -1341583247 ^ 137448030));
            num1 = 4;
            continue;
          case 3:
            try
            {
label_16:
              if (MetadataComponent.euhkaZfunRuUJ2wT1pll((object) enumerator1))
                goto label_26;
              else
                goto label_17;
label_7:
              AssemblyModelsMetadata current;
              AbstractMetadata abstractMetadata;
              int index;
              AbstractMetadata[] abstractMetadataArray1;
              AbstractMetadata[] abstractMetadataArray2;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_2;
                  case 2:
                    abstractMetadata = abstractMetadataArray2[index];
                    num2 = 5;
                    continue;
                  case 3:
                    index = 0;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 4;
                    continue;
                  case 4:
                  case 13:
                    if (index >= abstractMetadataArray2.Length)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 6;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    MetadataComponent.jK1u4OfukB2dZ3YpuqEr((object) this, MetadataComponent.UC2j1afuKMZ9fiXPgeEx((object) current), (object) abstractMetadata);
                    num2 = 16;
                    continue;
                  case 6:
                  case 15:
                    goto label_16;
                  case 8:
                    if (!MetadataComponent.W4nVFffuiNeYAe0BSI4d((object) current.Name, MetadataComponent.VbluF0fuVc0viuRjfEIQ(-867826612 ^ -867824030)))
                    {
                      num2 = 18;
                      continue;
                    }
                    goto case 14;
                  case 9:
                    MetadataComponent.dfJtMKfuqmasOQkBfB2t((object) this, MetadataComponent.UC2j1afuKMZ9fiXPgeEx((object) current));
                    num2 = 8;
                    continue;
                  case 10:
                  case 18:
                    MetadataComponent.T4YhtgfuXA1OKMEpUjdO((object) this, MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this), MetadataComponent.UC2j1afuKMZ9fiXPgeEx((object) current));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 7;
                    continue;
                  case 11:
                    if (abstractMetadataArray1 != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 17 : 15;
                      continue;
                    }
                    goto label_16;
                  case 12:
                    goto label_26;
                  case 14:
                    flag = true;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                    continue;
                  case 16:
                    ++index;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 13 : 6;
                    continue;
                  case 17:
                    abstractMetadataArray2 = abstractMetadataArray1;
                    num2 = 3;
                    continue;
                  case 19:
                    if (MetadataComponent.W4nVFffuiNeYAe0BSI4d(MetadataComponent.UC2j1afuKMZ9fiXPgeEx((object) current), MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 15 : 15;
                      continue;
                    }
                    goto case 9;
                  default:
                    abstractMetadataArray1 = (AbstractMetadata[]) MetadataComponent.K3WJUjfuT2Wh0B27wUjl((object) current);
                    num2 = 11;
                    continue;
                }
              }
label_17:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              goto label_7;
label_26:
              current = enumerator1.Current;
              num2 = 19;
              goto label_7;
            }
            finally
            {
              int num3;
              if (enumerator1 == null)
                num3 = 2;
              else
                goto label_31;
label_30:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_31:
              MetadataComponent.jHKKuJfuOK9pGJQApawE((object) enumerator1);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
              {
                num3 = 0;
                goto label_30;
              }
              else
                goto label_30;
            }
          case 4:
            namespaceMetadata.DisplayName = (string) MetadataComponent.u0ZZWOfuPAs1kUCBiaSd(MetadataComponent.VbluF0fuVc0viuRjfEIQ(-53329496 >> 4 ^ -3663608));
            num1 = 13;
            continue;
          case 5:
            IEnumerable<string> projectNames = this.ProjectNames;
            // ISSUE: reference to a compiler-generated field
            Func<string, bool> func = MetadataComponent.\u003C\u003Ec.\u003C\u003E9__10_1;
            Func<string, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              MetadataComponent.\u003C\u003Ec.\u003C\u003E9__10_1 = predicate = (Func<string, bool>) (n => MetadataComponent.\u003C\u003Ec.R2e94385D5V0WSmyrq6G((object) n, MetadataComponent.\u003C\u003Ec.uTWhlh85aslTPyAAQoVW(--1418440330 ^ 1418437796)));
            }
            else
              goto label_61;
label_60:
            enumerator2 = projectNames.Where<string>(predicate).GetEnumerator();
            num1 = 12;
            continue;
label_61:
            predicate = func;
            goto label_60;
          case 6:
          case 17:
            MetadataComponent.RidwaDfuNdo2f9fuYh0C((object) this, MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 14 : 9;
            continue;
          case 7:
label_2:
            if (flag)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 5 : 3;
              continue;
            }
            goto case 9;
          case 8:
            MetadataComponent.aRHHqYfu2jNjnW0QLOJw((object) namespaceMetadata, MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 2;
            continue;
          case 9:
label_43:
            if (!this.DraftItems.Values.OfType<NamespaceMetadata>().All<NamespaceMetadata>((Func<NamespaceMetadata, bool>) (i => MetadataComponent.UQwBbkfuprLrxIV6in1n(MetadataComponent.DvKyQkfuD57tn9mUZGW4((object) i), MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this)))))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 17;
              continue;
            }
            goto case 15;
          case 10:
            namespaceMetadata.InitNew();
            num1 = 8;
            continue;
          case 11:
            enumerator1 = this.metadataRuntimeService.GetAssemblyModelsMetadataList().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 3;
            continue;
          case 12:
            try
            {
label_49:
              if (MetadataComponent.euhkaZfunRuUJ2wT1pll((object) enumerator2))
                goto label_48;
              else
                goto label_50;
label_46:
              string current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_49;
                  case 2:
                    goto label_43;
                  case 3:
                    MetadataComponent.T4YhtgfuXA1OKMEpUjdO((object) this, MetadataComponent.VbluF0fuVc0viuRjfEIQ(1021410165 ^ 1021407579), (object) current);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                    continue;
                  default:
                    goto label_48;
                }
              }
label_48:
              current = enumerator2.Current;
              num4 = 3;
              goto label_46;
label_50:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 0;
              goto label_46;
            }
            finally
            {
              int num5;
              if (enumerator2 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
              else
                goto label_54;
label_53:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_54:
              enumerator2.Dispose();
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
              {
                num5 = 0;
                goto label_53;
              }
              else
                goto label_53;
            }
          case 13:
            MetadataComponent.OOARYQfu1q9oOXix92AF((object) namespaceMetadata, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 16 : 7;
            continue;
          case 14:
            goto label_58;
          case 15:
            namespaceMetadata = new NamespaceMetadata();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 10 : 9;
            continue;
          case 16:
            this.SaveMetadata((IMetadata) namespaceMetadata);
            num1 = 6;
            continue;
          default:
            flag = false;
            num1 = 11;
            continue;
        }
      }
label_58:;
    }

    /// <inheritdoc />
    protected override void AddOrReplaceMetadata(string projectName, IMetadata metadata)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            this.lastMetadataUpdate = MetadataComponent.Yujoevfu3CZPuDhGQtkZ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          case 2:
            base.AddOrReplaceMetadata(projectName, metadata);
            num = 3;
            continue;
          case 3:
          case 4:
            this.ClearCacheDraftItems();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
            continue;
          case 5:
            if (!(projectName != (string) MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this)))
            {
              num = 4;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
      }
label_8:
      return;
label_2:;
    }

    /// <inheritdoc />
    protected override void RemoveMetadata(string projectName, IMetadata metadata)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.lastMetadataUpdate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            base.RemoveMetadata(projectName, metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 4:
            if (MetadataComponent.UQwBbkfuprLrxIV6in1n((object) projectName, MetadataComponent.So5RY7fuRJwoQRaIsMiB((object) this)))
            {
              num = 3;
              continue;
            }
            break;
        }
        this.ClearCacheDraftItems();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
      }
label_2:;
    }

    private void ValidateMetadataItem(IEnumerable<IMetadata> metadataList)
    {
      foreach (IEntityMetadata entityMetadata in metadataList.OfType<IEntityMetadata>())
      {
        IEnumerable<IPropertyMetadata> propertiesAndTableParts = entityMetadata.GetPropertiesAndTableParts();
        List<MetadataItemValidationError> itemValidationErrorList = new List<MetadataItemValidationError>();
        foreach (IValidatableMetadata validatableMetadata in propertiesAndTableParts.OfType<IValidatableMetadata>())
        {
          MetadataItemValidationError[] source = validatableMetadata.Validate();
          if (source != null && source.Length != 0)
            itemValidationErrorList.AddSequense<MetadataItemValidationError>((IEnumerable<MetadataItemValidationError>) source);
        }
        if (itemValidationErrorList.Count > 0)
        {
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.AppendLine(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479707602)));
          string str = entityMetadata is NamedMetadata namedMetadata ? namedMetadata.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218540776) + (object) entityMetadata.Uid;
          stringBuilder.Append(str);
          if (itemValidationErrorList.Count == 1)
          {
            stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173621781));
            stringBuilder.AppendLine(itemValidationErrorList.ElementAt<MetadataItemValidationError>(0).Message);
          }
          else
          {
            stringBuilder.AppendLine(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113940801));
            foreach (MetadataItemValidationError itemValidationError in itemValidationErrorList)
            {
              stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87351979));
              stringBuilder.AppendLine(itemValidationError.Message);
            }
          }
          throw new MetadataPublishingException(stringBuilder.ToString())
          {
            ValidationErrors = itemValidationErrorList.ToArray()
          };
        }
      }
    }

    private IDictionary<Guid, IMetadata> DraftItems => (IDictionary<Guid, IMetadata>) this.complexCacheService.GetOrAdd<Dictionary<Guid, IMetadata>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153759739), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124315958), (Func<Dictionary<Guid, IMetadata>>) (() => this.metadataItemManager.FindDraftItems().Select<IMetadataItem, object>((Func<IMetadataItem, object>) (i => i.Metadata)).OfType<IMetadata>().ToDictionary<IMetadata, Guid>((Func<IMetadata, Guid>) (m => MetadataComponent.\u003C\u003Ec.Ud8REm85pHbW3G04d8cq((object) m)))));

    private void ClearCacheDraftItems()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataComponent.MIEl0lfua4Yqnh1Ey7xW((object) this.complexCacheService, MetadataComponent.VbluF0fuVc0viuRjfEIQ(1597012150 ^ 1597326606));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void nphwH6fuIZAY8Zo8MUst() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object VbluF0fuVc0viuRjfEIQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void owGQmQfuSOp0PpJVxeqT([In] object obj0, [In] object obj1) => Contract.NotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool l5rMT2fuZiPYYiDNKDZ6() => MetadataComponent.qbKlHYfu8WyGViFm3r8g == null;

    internal static MetadataComponent kevyPQfuuFvt3JDlJUS1() => MetadataComponent.qbKlHYfu8WyGViFm3r8g;

    internal static bool W4nVFffuiNeYAe0BSI4d([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object So5RY7fuRJwoQRaIsMiB([In] object obj0) => (object) ((AbstractMetadataEditorComponent) obj0).ProjectName;

    internal static void dfJtMKfuqmasOQkBfB2t([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).AddProject((string) obj1);

    internal static object UC2j1afuKMZ9fiXPgeEx([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).Name;

    internal static void T4YhtgfuXA1OKMEpUjdO([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).AddProjectReference((string) obj1, (string) obj2);

    internal static object K3WJUjfuT2Wh0B27wUjl([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

    internal static void jK1u4OfukB2dZ3YpuqEr([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).AddOrReplaceMetadata((string) obj1, (IMetadata) obj2);

    internal static bool euhkaZfunRuUJ2wT1pll([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void jHKKuJfuOK9pGJQApawE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void aRHHqYfu2jNjnW0QLOJw([In] object obj0, [In] object obj1) => ((NamespaceMetadata) obj0).Namespace = (string) obj1;

    internal static void X03Jh0fueb041JgoDhcH([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object u0ZZWOfuPAs1kUCBiaSd([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void OOARYQfu1q9oOXix92AF([In] object obj0, bool value) => ((NamespaceMetadata) obj0).AllowCreateModels = value;

    internal static void RidwaDfuNdo2f9fuYh0C([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).CurrentProjectName = (string) obj1;

    internal static DateTime Yujoevfu3CZPuDhGQtkZ() => DateTime.Now;

    internal static bool UQwBbkfuprLrxIV6in1n([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void MIEl0lfua4Yqnh1Ey7xW([In] object obj0, [In] object obj1) => ((IComplexCacheService) obj0).RefreshTimestamp((string) obj1);

    internal static object DvKyQkfuD57tn9mUZGW4([In] object obj0) => (object) ((NamespaceMetadata) obj0).Namespace;

    private sealed class MetadataPublishFinishedEventHandler : 
      IMetadataPublishFinishedEventHandler,
      IEventHandler
    {
      private readonly object metadataComponent;
      private static object taxwnX85fnV6XHbOR0bn;

      public MetadataPublishFinishedEventHandler(MetadataComponent metadataComponent)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.metadataComponent = (object) metadataComponent;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      public void PublishExecuted(MetadataPublishedEventArgs e)
      {
        int num1 = 11;
        while (true)
        {
          int num2 = num1;
          AbstractMetadata abstractMetadata;
          while (true)
          {
            IEnumerator<string> enumerator;
            AbstractMetadata[] abstractMetadataArray1;
            AbstractMetadata[] abstractMetadataArray2;
            int index;
            AssemblyModelsMetadata assemblyModelsMetadata;
            switch (num2)
            {
              case 1:
                IEnumerable<string> projectNames = ((AbstractMetadataEditorComponent) this.metadataComponent).ProjectNames;
                // ISSUE: reference to a compiler-generated field
                Func<string, bool> func = MetadataComponent.MetadataPublishFinishedEventHandler.\u003C\u003Ec.\u003C\u003E9__2_0;
                Func<string, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  MetadataComponent.MetadataPublishFinishedEventHandler.\u003C\u003Ec.\u003C\u003E9__2_0 = predicate = (Func<string, bool>) (n => n != z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413563953));
                }
                else
                  goto label_13;
label_42:
                enumerator = projectNames.Where<string>(predicate).GetEnumerator();
                num2 = 18;
                continue;
label_13:
                predicate = func;
                goto label_42;
              case 2:
                if (abstractMetadataArray1 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 4 : 15;
                  continue;
                }
                goto case 6;
              case 3:
                index = 0;
                num2 = 12;
                continue;
              case 4:
              case 9:
                abstractMetadata = abstractMetadataArray2[index];
                num2 = 13;
                continue;
              case 5:
                ++index;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 17 : 8;
                continue;
              case 6:
                abstractMetadataArray2 = abstractMetadataArray1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 3 : 2;
                continue;
              case 8:
                MetadataComponent.MetadataPublishFinishedEventHandler.O4o9wa85ZGWREqj3cKDU(this.metadataComponent, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108655586));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
                continue;
              case 10:
                assemblyModelsMetadata = (AssemblyModelsMetadata) null;
                break;
              case 11:
                object obj = MetadataComponent.MetadataPublishFinishedEventHandler.XjhiJ885vRInsuVcGnX8((object) e);
                if (obj == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 5 : 10;
                  continue;
                }
                assemblyModelsMetadata = ((MetadataAssemblyPublishResult) obj).DynamicAssembly;
                break;
              case 12:
              case 17:
                if (index < abstractMetadataArray2.Length)
                {
                  num2 = 4;
                  continue;
                }
                goto label_33;
              case 13:
                goto label_25;
              case 14:
                goto label_40;
              case 15:
                goto label_23;
              case 16:
                if (MetadataComponent.MetadataPublishFinishedEventHandler.NRNNFD858qivhU58S2d3(this.metadataComponent, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107980240)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                  continue;
                }
                goto case 8;
              case 18:
                try
                {
label_7:
                  if (MetadataComponent.MetadataPublishFinishedEventHandler.Vla2lS85Iuvl8GpLBjNn((object) enumerator))
                    goto label_5;
                  else
                    goto label_8;
label_4:
                  string current;
                  int num3;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        MetadataComponent.MetadataPublishFinishedEventHandler.B1x1gb85uIQuP7VFBCpr(this.metadataComponent, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576148086), (object) current);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                        continue;
                      case 3:
                        goto label_28;
                      default:
                        goto label_7;
                    }
                  }
label_5:
                  current = enumerator.Current;
                  num3 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                  {
                    num3 = 2;
                    goto label_4;
                  }
                  else
                    goto label_4;
label_8:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 3;
                  goto label_4;
                }
                finally
                {
                  int num4;
                  if (enumerator == null)
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
                  else
                    goto label_14;
label_12:
                  switch (num4)
                  {
                    case 2:
                      break;
                    default:
                  }
label_14:
                  MetadataComponent.MetadataPublishFinishedEventHandler.qH2fVy85VY4yik6wInOv((object) enumerator);
                  num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                  {
                    num4 = 0;
                    goto label_12;
                  }
                  else
                    goto label_12;
                }
              default:
label_28:
                abstractMetadataArray1 = (AbstractMetadata[]) MetadataComponent.MetadataPublishFinishedEventHandler.FNWCIC85icnHIsPHJW6q(MetadataComponent.MetadataPublishFinishedEventHandler.CtlDyQ85SqTXKX0GCnsj(MetadataComponent.MetadataPublishFinishedEventHandler.XjhiJ885vRInsuVcGnX8((object) e)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 2;
                continue;
            }
            if (assemblyModelsMetadata != null)
              num2 = 16;
            else
              goto label_29;
          }
label_25:
          MetadataComponent.MetadataPublishFinishedEventHandler.udeZoM85qMHRORHfDl3h(this.metadataComponent, MetadataComponent.MetadataPublishFinishedEventHandler.qTaboq85RUayxNsPSkfS(87862435 ^ 87860877), (object) abstractMetadata);
          num1 = 5;
        }
label_40:
        return;
label_23:
        return;
label_33:
        return;
label_29:;
      }

      internal static bool hYCOMi85QP3t2s5H5oaC() => MetadataComponent.MetadataPublishFinishedEventHandler.taxwnX85fnV6XHbOR0bn == null;

      internal static MetadataComponent.MetadataPublishFinishedEventHandler Us7BuE85CjPke8H9E19A() => (MetadataComponent.MetadataPublishFinishedEventHandler) MetadataComponent.MetadataPublishFinishedEventHandler.taxwnX85fnV6XHbOR0bn;

      internal static object XjhiJ885vRInsuVcGnX8([In] object obj0) => (object) ((MetadataPublishedEventArgs) obj0).PublishResult;

      internal static bool NRNNFD858qivhU58S2d3([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).ProjectExists((string) obj1);

      internal static void O4o9wa85ZGWREqj3cKDU([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).AddProject((string) obj1);

      internal static void B1x1gb85uIQuP7VFBCpr([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).AddProjectReference((string) obj1, (string) obj2);

      internal static bool Vla2lS85Iuvl8GpLBjNn([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void qH2fVy85VY4yik6wInOv([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static object CtlDyQ85SqTXKX0GCnsj([In] object obj0) => (object) ((MetadataAssemblyPublishResult) obj0).DynamicAssembly;

      internal static object FNWCIC85icnHIsPHJW6q([In] object obj0) => (object) ((AssemblyModelsMetadata) obj0).RestoreMetadata();

      internal static object qTaboq85RUayxNsPSkfS(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void udeZoM85qMHRORHfDl3h([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).AddOrReplaceMetadata((string) obj1, (IMetadata) obj2);
    }
  }
}
