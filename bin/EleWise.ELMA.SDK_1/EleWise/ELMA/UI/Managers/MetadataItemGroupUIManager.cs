// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.MetadataItemGroupUIManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Менеджер группы компонента</summary>
  internal class MetadataItemGroupUIManager : 
    EntityManager<MetadataItemGroupUI, long>,
    IMetadataItemGroupUIManager,
    IEntityManager<MetadataItemGroupUI, long>,
    IEntityManager<MetadataItemGroupUI>,
    IEntityManager
  {
    private static MetadataItemGroupUIManager HkN5ZbBf4VMQ8JotsZO4;

    /// <summary>Экземпляр менеджера</summary>
    public static MetadataItemGroupUIManager Instance => Locator.GetServiceNotNull<MetadataItemGroupUIManager>();

    /// <inheritdoc />
    [Transaction]
    public virtual MetadataItemGroupUI Create(
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      string displayName,
      string name)
    {
      int num1 = 10;
      MetadataItemGroupUI metadataItemGroupUi;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MetadataItemGroupUIManager.CKCVSZBfJCbOL1k1HBfR((object) metadataItemGroupUi, typeUid);
              num2 = 4;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_10;
            case 4:
              goto label_8;
            case 5:
              metadataItemGroupUi = this.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 6:
              MetadataItemGroupUIManager.BfnBedBfxmJWxoFh5fGc((object) name, MetadataItemGroupUIManager.jtxpfLBfAK08TYkHcmso(-1876063057 ^ -1876066119));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 0;
              continue;
            case 7:
              MetadataItemGroupUIManager.YjJDNTBfmQ9TtRQgLQG5((object) metadataItemGroupUi, (object) displayName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 2;
              continue;
            case 8:
              MetadataItemGroupUIManager.hkmsyOBfMqyqIEKnUp7r((object) metadataItemGroupUi, moduleUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 0;
              continue;
            case 9:
              MetadataItemGroupUIManager.BfnBedBfxmJWxoFh5fGc((object) displayName, MetadataItemGroupUIManager.jtxpfLBfAK08TYkHcmso(~541731958 ^ -541776967));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 6;
              continue;
            case 10:
              MetadataItemGroupUIManager.iqrjWHBf7M62UF3bTuOa(typeUid != Guid.Empty, MetadataItemGroupUIManager.jtxpfLBfAK08TYkHcmso(-606654180 ^ -606609692));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 9 : 6;
              continue;
            default:
              MetadataItemGroupUIManager.qjNgPwBf0nsCke9sU5bx((object) metadataItemGroupUi, (object) name);
              num2 = 7;
              continue;
          }
        }
label_5:
        MetadataItemGroupUIManager.SAy9fyBfyMgICUAiDpcQ((object) metadataItemGroupUi, (object) this.LoadOrNull(groupUid));
        num1 = 8;
        continue;
label_8:
        this.Save(metadataItemGroupUi);
        num1 = 3;
      }
label_10:
      return metadataItemGroupUi;
    }

    /// <inheritdoc />
    [Transaction]
    public virtual MetadataItemGroupUI Edit(
      Guid uid,
      Guid typeUid,
      Guid moduleUid,
      Guid groupUid,
      string displayName,
      string name)
    {
      int num = 6;
      MetadataItemGroupUI metadataItemGroupUi;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataItemGroupUIManager.SAy9fyBfyMgICUAiDpcQ((object) metadataItemGroupUi, (object) this.LoadOrNull(groupUid));
            num = 4;
            continue;
          case 2:
            metadataItemGroupUi.Name = name;
            num = 7;
            continue;
          case 3:
            metadataItemGroupUi.ModuleUid = moduleUid;
            num = 2;
            continue;
          case 4:
            MetadataItemGroupUIManager.CKCVSZBfJCbOL1k1HBfR((object) metadataItemGroupUi, typeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 5:
            MetadataItemGroupUIManager.D2ydIXBf97UfytWwQGa1((object) metadataItemGroupUi, MetadataItemGroupUIManager.jtxpfLBfAK08TYkHcmso(-1939377524 ^ -1939373370));
            num = 3;
            continue;
          case 6:
            metadataItemGroupUi = this.LoadOrNull(uid);
            num = 5;
            continue;
          case 7:
            MetadataItemGroupUIManager.YjJDNTBfmQ9TtRQgLQG5((object) metadataItemGroupUi, (object) displayName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
            continue;
          case 8:
            goto label_8;
          default:
            this.Save(metadataItemGroupUi);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 8 : 4;
            continue;
        }
      }
label_8:
      return metadataItemGroupUi;
    }

    public MetadataItemGroupUIManager()
    {
      MetadataItemGroupUIManager.VgpdYxBfds18tj4GDknm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jtxpfLBfAK08TYkHcmso(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void iqrjWHBf7M62UF3bTuOa(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static void BfnBedBfxmJWxoFh5fGc([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static void qjNgPwBf0nsCke9sU5bx([In] object obj0, [In] object obj1) => ((MetadataItemGroupUI) obj0).Name = (string) obj1;

    internal static void YjJDNTBfmQ9TtRQgLQG5([In] object obj0, [In] object obj1) => ((MetadataItemGroupUI) obj0).DisplayName = (string) obj1;

    internal static void SAy9fyBfyMgICUAiDpcQ([In] object obj0, [In] object obj1) => ((MetadataItemGroupUI) obj0).Parent = (MetadataItemGroupUI) obj1;

    internal static void hkmsyOBfMqyqIEKnUp7r([In] object obj0, Guid value) => ((MetadataItemGroupUI) obj0).ModuleUid = value;

    internal static void CKCVSZBfJCbOL1k1HBfR([In] object obj0, Guid value) => ((MetadataItemGroupUI) obj0).MetadataTypeUid = value;

    internal static bool UUH1QtBf6Kj9j02OT5BO() => MetadataItemGroupUIManager.HkN5ZbBf4VMQ8JotsZO4 == null;

    internal static MetadataItemGroupUIManager pUtNj7BfH9PKZ4i01KK2() => MetadataItemGroupUIManager.HkN5ZbBf4VMQ8JotsZO4;

    internal static void D2ydIXBf97UfytWwQGa1([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void VgpdYxBfds18tj4GDknm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
