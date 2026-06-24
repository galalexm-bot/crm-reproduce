// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.EntitiesManifestChapterCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Manifest
{
  [Component]
  public class EntitiesManifestChapterCreator : IManifestChapterCreator
  {
    internal static EntitiesManifestChapterCreator omh80QEpg4qx97uYgUF3;

    public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
    {
      int num1 = 3;
      List<PacketMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_50;
          case 1:
            goto label_40;
          case 2:
            goto label_49;
          case 3:
            if (settings.Manifest == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            }
            if (desc.ExportedPacketMetadatas == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 4:
            goto label_2;
          case 5:
            enumerator1 = desc.ExportedPacketMetadatas.GetEnumerator();
            num1 = 4;
            continue;
          default:
            goto label_38;
        }
      }
label_50:
      return;
label_40:
      return;
label_49:
      return;
label_38:
      return;
label_2:
      try
      {
label_22:
        if (enumerator1.MoveNext())
          goto label_4;
        else
          goto label_23;
label_3:
        PacketMetadata current1;
        IEnumerator<KeyValuePair<Guid, SubUserMetadataInfo>> enumerator2;
        List<IGroupedMetadata>.Enumerator enumerator3;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
label_21:
              enumerator2 = current1.SubUserMetadataInfo.GetEnumerator();
              num2 = 5;
              continue;
            case 3:
              goto label_44;
            case 4:
              enumerator3 = current1.SubSystemMetadata.GetEnumerator();
              num2 = 6;
              continue;
            case 5:
              goto label_6;
            case 6:
              try
              {
label_31:
                if (enumerator3.MoveNext())
                  goto label_27;
                else
                  goto label_32;
label_26:
                EntityMetadata current2;
                EntityManifest entityManifest1;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (current2 == null)
                      {
                        num3 = 6;
                        continue;
                      }
                      goto case 4;
                    case 2:
                      ((ElmaStoreComponentManifest) EntitiesManifestChapterCreator.gqUB8REaB47lbHxk1XlM((object) settings)).Entities.Add(entityManifest1);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_27;
                    case 4:
                      EntityManifest entityManifest2 = new EntityManifest();
                      EntitiesManifestChapterCreator.mZoyTIEpLinPY5TyFVra((object) entityManifest2, EntitiesManifestChapterCreator.SQMPCaEpYXpjJGtKONPC((object) current2));
                      EntitiesManifestChapterCreator.im1e9WEpU36VlgL1ewYD((object) entityManifest2, (object) current2.Namespace);
                      entityManifest2.Uid = EntitiesManifestChapterCreator.oMhK1WEps4hSyL7VeiNZ((object) current2);
                      EntitiesManifestChapterCreator.eXfu5YEpzWuSrby3gZsr((object) entityManifest2, EntitiesManifestChapterCreator.JfsD94EpcBELXYrfgZJS((object) current2));
                      EntitiesManifestChapterCreator.xfUZuSEaF1h4KWcwhTvq((object) entityManifest2, (object) current2.TableName);
                      entityManifest1 = entityManifest2;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 2;
                      continue;
                    case 5:
                      goto label_21;
                    default:
                      goto label_31;
                  }
                }
label_27:
                current2 = enumerator3.Current as EntityMetadata;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
                {
                  num3 = 1;
                  goto label_26;
                }
                else
                  goto label_26;
label_32:
                num3 = 5;
                goto label_26;
              }
              finally
              {
                enumerator3.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            default:
              goto label_4;
          }
        }
label_44:
        return;
label_6:
        try
        {
label_11:
          if (enumerator2.MoveNext())
            goto label_10;
          else
            goto label_12;
label_7:
          EntityManifest entityManifest3;
          EntityMetadata metadata;
          KeyValuePair<Guid, SubUserMetadataInfo> current3;
          int num5;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_11;
              case 2:
                goto label_10;
              case 3:
                ((ElmaStoreComponentManifest) EntitiesManifestChapterCreator.gqUB8REaB47lbHxk1XlM((object) settings)).Entities.Add(entityManifest3);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
                continue;
              case 4:
                goto label_22;
              case 5:
                metadata = current3.Value.Metadata as EntityMetadata;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              case 6:
                EntityManifest entityManifest4 = new EntityManifest();
                entityManifest4.Name = (string) EntitiesManifestChapterCreator.SQMPCaEpYXpjJGtKONPC((object) metadata);
                EntitiesManifestChapterCreator.im1e9WEpU36VlgL1ewYD((object) entityManifest4, EntitiesManifestChapterCreator.GkGZMxEaWFfaOltf5faU((object) metadata));
                EntitiesManifestChapterCreator.HiiSKgEaoNP1l2qQDqph((object) entityManifest4, EntitiesManifestChapterCreator.oMhK1WEps4hSyL7VeiNZ((object) metadata));
                EntitiesManifestChapterCreator.eXfu5YEpzWuSrby3gZsr((object) entityManifest4, (object) metadata.DisplayName);
                EntitiesManifestChapterCreator.xfUZuSEaF1h4KWcwhTvq((object) entityManifest4, EntitiesManifestChapterCreator.sKvwpTEabIsoHnaTUN3D((object) metadata));
                entityManifest3 = entityManifest4;
                num5 = 3;
                continue;
              default:
                if (metadata != null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 6;
                  continue;
                }
                goto label_11;
            }
          }
label_10:
          current3 = enumerator2.Current;
          num5 = 5;
          goto label_7;
label_12:
          num5 = 4;
          goto label_7;
        }
        finally
        {
          int num6;
          if (enumerator2 == null)
            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
          else
            goto label_19;
label_18:
          switch (num6)
          {
            case 1:
            case 2:
          }
label_19:
          EntitiesManifestChapterCreator.LBsPe9Eahh0UYNlMcGjF((object) enumerator2);
          num6 = 2;
          goto label_18;
        }
label_4:
        current1 = enumerator1.Current;
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        {
          num2 = 4;
          goto label_3;
        }
        else
          goto label_3;
label_23:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 3;
        goto label_3;
      }
      finally
      {
        enumerator1.Dispose();
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
          num7 = 0;
        switch (num7)
        {
          default:
        }
      }
    }

    public EntitiesManifestChapterCreator()
    {
      EntitiesManifestChapterCreator.LxROqAEaGn8S2JHF4QXW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object SQMPCaEpYXpjJGtKONPC([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void mZoyTIEpLinPY5TyFVra([In] object obj0, [In] object obj1) => ((EntityManifest) obj0).Name = (string) obj1;

    internal static void im1e9WEpU36VlgL1ewYD([In] object obj0, [In] object obj1) => ((EntityManifest) obj0).Namespace = (string) obj1;

    internal static Guid oMhK1WEps4hSyL7VeiNZ([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object JfsD94EpcBELXYrfgZJS([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void eXfu5YEpzWuSrby3gZsr([In] object obj0, [In] object obj1) => ((EntityManifest) obj0).DisplayName = (string) obj1;

    internal static void xfUZuSEaF1h4KWcwhTvq([In] object obj0, [In] object obj1) => ((EntityManifest) obj0).TableName = (string) obj1;

    internal static object gqUB8REaB47lbHxk1XlM([In] object obj0) => (object) ((ConfigExportSettings) obj0).Manifest;

    internal static object GkGZMxEaWFfaOltf5faU([In] object obj0) => (object) ((ClassMetadata) obj0).Namespace;

    internal static void HiiSKgEaoNP1l2qQDqph([In] object obj0, [In] Guid obj1) => ((EntityManifest) obj0).Uid = obj1;

    internal static object sKvwpTEabIsoHnaTUN3D([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static void LBsPe9Eahh0UYNlMcGjF([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool KB4VOWEp5CV6sn94KVaf() => EntitiesManifestChapterCreator.omh80QEpg4qx97uYgUF3 == null;

    internal static EntitiesManifestChapterCreator bT2mt6EpjF9Fo0lc4YRP() => EntitiesManifestChapterCreator.omh80QEpg4qx97uYgUF3;

    internal static void LxROqAEaGn8S2JHF4QXW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
