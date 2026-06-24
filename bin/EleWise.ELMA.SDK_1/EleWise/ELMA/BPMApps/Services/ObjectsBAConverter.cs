// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.ObjectsBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  [Component(Order = 200)]
  public class ObjectsBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid exportCatalogsUid;
    private static readonly Guid exportEnumsUid;
    internal static ObjectsBAConverter O3g4Upf2atdcvnyh6sLy;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        ObjectsExportSetting objectsExportSetting;
        ObjectsBAChapter objectsBaChapter1;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (ObjectsBAConverter.CBUBk5f2x6mUhTk1q1dq((object) objectsBaChapter1.SysCatalogs) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 26 : 30;
                continue;
              }
              goto case 24;
            case 2:
            case 12:
              if (ObjectsBAConverter.kevtUBf2H1xmF1uV1ODA((object) objectsExportSetting))
              {
                num2 = 17;
                continue;
              }
              goto case 18;
            case 3:
            case 29:
              if (objectsBaChapter1.Catalogs != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 31 : 5;
                continue;
              }
              goto case 27;
            case 4:
            case 32:
              if (objectsExportSetting.DataClasses == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 29 : 17;
                continue;
              }
              goto case 28;
            case 5:
            case 19:
            case 30:
              ObjectsBAConverter.adH1dEf2mJXPPhiXmSBl((object) bpmAppManifest, (object) objectsBaChapter1);
              num2 = 9;
              continue;
            case 6:
              if (objectsBaChapter1.DataClasses != null)
              {
                num2 = 8;
                continue;
              }
              goto label_28;
            case 7:
              ObjectsBAConverter.h5aAlPf2AMj9y6qmoNno((object) bpmAppManifest, ObjectsBAConverter.exportCatalogsUid, ObjectsBAConverter.kevtUBf2H1xmF1uV1ODA((object) objectsExportSetting));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 24 : 33;
              continue;
            case 8:
              if (objectsBaChapter1.DataClasses.Count > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 10 : 19;
                continue;
              }
              goto label_35;
            case 9:
              goto label_41;
            case 10:
              objectsExportSetting = obj as ObjectsExportSetting;
              num2 = 23;
              continue;
            case 11:
              if (settings.CustomSettings.TryGetValue(ObjectsExportConsts.ExportExtensionUid, out obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 5 : 10;
                continue;
              }
              goto label_53;
            case 13:
              goto label_9;
            case 14:
              if (objectsExportSetting.Enums == null)
              {
                num2 = 4;
                continue;
              }
              goto case 21;
            case 15:
              ObjectsBAConverter.JIgIjUf24NXQhX5cbspv((object) settings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917315076));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 11 : 10;
              continue;
            case 16:
              ObjectsBAConverter.JIgIjUf24NXQhX5cbspv((object) bpmAppManifest, ObjectsBAConverter.iyUFHOf2w3mGFdFRIwR8(1505778440 - 1981636111 ^ -475548565));
              num2 = 15;
              continue;
            case 17:
              if (objectsExportSetting.SysCatalogs != null)
                goto case 25;
              else
                goto label_37;
            case 18:
            case 36:
              bpmAppManifest.SetFlag(ObjectsBAConverter.exportEnumsUid, objectsExportSetting.ExportEnums);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 20:
              ObjectsBAChapter objectsBaChapter2 = new ObjectsBAChapter();
              ObjectsBAConverter.oo2qfBf26ccKRDxBMWMn((object) objectsBaChapter2, ObjectsExportConsts.ExportExtensionUid);
              objectsBaChapter1 = objectsBaChapter2;
              num2 = 7;
              continue;
            case 21:
              ObjectsBAChapter objectsBaChapter3 = objectsBaChapter1;
              List<Guid> enums = objectsExportSetting.Enums;
              // ISSUE: reference to a compiler-generated field
              Func<Guid, EnumBAItem> func1 = ObjectsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_2;
              Func<Guid, EnumBAItem> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ObjectsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_2 = selector1 = (Func<Guid, EnumBAItem>) (uid =>
                {
                  EnumBAItem bpmAppManifest1 = new EnumBAItem();
                  // ISSUE: reference to a compiler-generated method
                  ObjectsBAConverter.\u003C\u003Ec.BYQ7Y58z9vnQw1jpTIfY((object) bpmAppManifest1, uid);
                  return bpmAppManifest1;
                });
              }
              else
                goto label_60;
label_55:
              List<EnumBAItem> list1 = enums.Select<Guid, EnumBAItem>(selector1).ToList<EnumBAItem>();
              objectsBaChapter3.Enums = list1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 19 : 32;
              continue;
label_60:
              selector1 = func1;
              goto label_55;
            case 22:
              if (ObjectsBAConverter.i5kYu2f204eh9N1mCifu((object) objectsBaChapter1.Enums) > 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 5 : 2;
                continue;
              }
              goto case 6;
            case 23:
              goto label_23;
            case 24:
            case 35:
              if (objectsBaChapter1.Enums == null)
                goto case 6;
              else
                goto label_12;
            case 25:
              objectsBaChapter1.SysCatalogs = objectsExportSetting.SysCatalogs.Select<Guid, EntityBAItem>((Func<Guid, EntityBAItem>) (uid =>
              {
                EntityBAItem bpmAppManifest2 = new EntityBAItem();
                // ISSUE: reference to a compiler-generated method
                ObjectsBAConverter.\u003C\u003Ec.BYQ7Y58z9vnQw1jpTIfY((object) bpmAppManifest2, uid);
                bpmAppManifest2.ExportData = true;
                return bpmAppManifest2;
              })).ToList<EntityBAItem>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 7 : 36;
              continue;
            case 26:
              objectsBaChapter1.Catalogs = objectsExportSetting.Catalogs.Select<KeyValuePair<Guid, bool>, EntityBAItem>((Func<KeyValuePair<Guid, bool>, EntityBAItem>) (c =>
              {
                return new EntityBAItem()
                {
                  Uid = c.Key,
                  ExportData = c.Value
                };
              })).ToList<EntityBAItem>();
              num2 = 12;
              continue;
            case 27:
              if (objectsBaChapter1.SysCatalogs == null)
              {
                num2 = 24;
                continue;
              }
              goto case 1;
            case 28:
              ObjectsBAChapter objectsBaChapter4 = objectsBaChapter1;
              List<Guid> dataClasses = objectsExportSetting.DataClasses;
              // ISSUE: reference to a compiler-generated field
              Func<Guid, DataClassBAItem> func2 = ObjectsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_3;
              Func<Guid, DataClassBAItem> selector2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ObjectsBAConverter.\u003C\u003Ec.\u003C\u003E9__0_3 = selector2 = (Func<Guid, DataClassBAItem>) (uid =>
                {
                  DataClassBAItem bpmAppManifest3 = new DataClassBAItem();
                  // ISSUE: reference to a compiler-generated method
                  ObjectsBAConverter.\u003C\u003Ec.BYQ7Y58z9vnQw1jpTIfY((object) bpmAppManifest3, uid);
                  return bpmAppManifest3;
                });
              }
              else
                goto label_22;
label_59:
              List<DataClassBAItem> list2 = dataClasses.Select<Guid, DataClassBAItem>(selector2).ToList<DataClassBAItem>();
              objectsBaChapter4.DataClasses = list2;
              num2 = 3;
              continue;
label_22:
              selector2 = func2;
              goto label_59;
            case 31:
              if (ObjectsBAConverter.CBUBk5f2x6mUhTk1q1dq((object) objectsBaChapter1.Catalogs) > 0)
                goto case 5;
              else
                goto label_27;
            case 33:
              if (!ObjectsBAConverter.kevtUBf2H1xmF1uV1ODA((object) objectsExportSetting))
              {
                num2 = 2;
                continue;
              }
              goto case 34;
            case 34:
              if (objectsExportSetting.Catalogs != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 20 : 26;
                continue;
              }
              goto case 2;
            case 37:
              goto label_57;
            default:
              if (ObjectsBAConverter.ljRpGHf27HC42UJ7EVlP((object) objectsExportSetting))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 11 : 14;
                continue;
              }
              goto case 4;
          }
        }
label_12:
        num1 = 22;
        continue;
label_23:
        if (objectsExportSetting != null)
        {
          num1 = 20;
          continue;
        }
        goto label_38;
label_27:
        num1 = 27;
        continue;
label_37:
        num1 = 18;
      }
label_41:
      return;
label_9:
      return;
label_57:
      return;
label_35:
      return;
label_53:
      return;
label_38:
      return;
label_28:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ObjectsExportSetting objectsExportSetting;
        List<EnumBAItem>.Enumerator enumerator1;
        ObjectsBAChapter chapter;
        List<EntityBAItem>.Enumerator enumerator2;
        List<DataClassBAItem>.Enumerator enumerator3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 23:
label_21:
              if (chapter.SysCatalogs == null)
              {
                num2 = 3;
                continue;
              }
              goto case 15;
            case 2:
              try
              {
label_52:
                if (enumerator2.MoveNext())
                  goto label_51;
                else
                  goto label_53;
label_49:
                EntityBAItem current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_21;
                    case 2:
                      objectsExportSetting.Catalogs[ObjectsBAConverter.PpV4ipf2MKYedgVOoMFj((object) current)] = ObjectsBAConverter.MyHoJwf2JmM0UfnGekwH((object) current);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_51;
                    default:
                      goto label_52;
                  }
                }
label_51:
                current = enumerator2.Current;
                num3 = 2;
                goto label_49;
label_53:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                goto label_49;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
            case 5:
label_72:
              objectsExportSetting.ExportEnums = ObjectsBAConverter.eOsKHGf29elH8aWmrBQd((object) bpmAppManifest, ObjectsBAConverter.exportEnumsUid, ObjectsBAConverter.ljRpGHf27HC42UJ7EVlP((object) objectsExportSetting));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 7 : 25;
              continue;
            case 4:
              if (chapter == null)
              {
                num2 = 16;
                continue;
              }
              goto label_18;
            case 6:
              ObjectsBAConverter.JIgIjUf24NXQhX5cbspv((object) settings, ObjectsBAConverter.iyUFHOf2w3mGFdFRIwR8(-1921202237 ^ -1921241779));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 18 : 6;
              continue;
            case 7:
              ObjectsBAConverter.JIgIjUf24NXQhX5cbspv((object) bpmAppManifest, ObjectsBAConverter.iyUFHOf2w3mGFdFRIwR8(-1998538950 ^ -1998192728));
              num2 = 6;
              continue;
            case 8:
              try
              {
label_32:
                if (enumerator3.MoveNext())
                  goto label_34;
                else
                  goto label_33;
label_30:
                DataClassBAItem current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_32;
                    case 2:
                      goto label_34;
                    case 3:
                      goto label_25;
                    default:
                      objectsExportSetting.DataClasses.Add(ObjectsBAConverter.PpV4ipf2MKYedgVOoMFj((object) current));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                      continue;
                  }
                }
label_33:
                num5 = 3;
                goto label_30;
label_34:
                current = enumerator3.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
                {
                  num5 = 0;
                  goto label_30;
                }
                else
                  goto label_30;
              }
              finally
              {
                enumerator3.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 9:
              goto label_23;
            case 10:
              objectsExportSetting.Catalogs = new SerializableDictionary<Guid, bool>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            case 11:
              objectsExportSetting.DataClasses = new List<Guid>();
              num2 = 21;
              continue;
            case 12:
              if (chapter.Catalogs == null)
              {
                num2 = 23;
                continue;
              }
              goto case 10;
            case 13:
              enumerator2 = chapter.SysCatalogs.GetEnumerator();
              num2 = 19;
              continue;
            case 14:
              objectsExportSetting.Enums = new List<Guid>();
              num2 = 9;
              continue;
            case 15:
              objectsExportSetting.SysCatalogs = new List<Guid>();
              num2 = 13;
              continue;
            case 16:
              goto label_71;
            case 17:
              ObjectsBAConverter.GQcp37f2ydhq7Rul1BIX((object) objectsExportSetting, bpmAppManifest.GetFlag(ObjectsBAConverter.exportCatalogsUid, ObjectsBAConverter.kevtUBf2H1xmF1uV1ODA((object) objectsExportSetting)));
              num2 = 12;
              continue;
            case 18:
              chapter = bpmAppManifest.GetChapter(ObjectsExportConsts.ExportExtensionUid) as ObjectsBAChapter;
              num2 = 4;
              continue;
            case 19:
              try
              {
label_65:
                if (enumerator2.MoveNext())
                  goto label_63;
                else
                  goto label_66;
label_61:
                EntityBAItem current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_63;
                    case 2:
                      goto label_65;
                    case 3:
                      goto label_72;
                    default:
                      objectsExportSetting.SysCatalogs.Add(current.Uid);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 2;
                      continue;
                  }
                }
label_63:
                current = enumerator2.Current;
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                {
                  num7 = 0;
                  goto label_61;
                }
                else
                  goto label_61;
label_66:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 3 : 3;
                goto label_61;
              }
              finally
              {
                enumerator2.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 20:
              try
              {
label_6:
                if (enumerator1.MoveNext())
                  goto label_8;
                else
                  goto label_7;
label_4:
                EnumBAItem current;
                int num9;
                while (true)
                {
                  switch (num9)
                  {
                    case 1:
                      goto label_8;
                    case 2:
                      objectsExportSetting.Enums.Add(ObjectsBAConverter.PpV4ipf2MKYedgVOoMFj((object) current));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                      continue;
                    case 3:
                      goto label_40;
                    default:
                      goto label_6;
                  }
                }
label_7:
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 3;
                goto label_4;
label_8:
                current = enumerator1.Current;
                num9 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                {
                  num9 = 0;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              finally
              {
                enumerator1.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
            case 21:
              enumerator3 = chapter.DataClasses.GetEnumerator();
              num2 = 8;
              continue;
            case 22:
            case 28:
label_40:
              if (chapter.DataClasses == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 24;
                continue;
              }
              goto case 11;
            case 24:
            case 27:
label_25:
              settings.CustomSettings[ObjectsExportConsts.ExportExtensionUid] = (object) objectsExportSetting;
              num2 = 26;
              continue;
            case 25:
              if (chapter.Enums == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 28 : 12;
                continue;
              }
              goto case 14;
            case 26:
              goto label_17;
            default:
              enumerator2 = chapter.Catalogs.GetEnumerator();
              num2 = 2;
              continue;
          }
        }
label_18:
        objectsExportSetting = new ObjectsExportSetting();
        num1 = 17;
        continue;
label_23:
        enumerator1 = chapter.Enums.GetEnumerator();
        num1 = 20;
      }
label_71:
      return;
label_17:;
    }

    public ObjectsBAConverter()
    {
      ObjectsBAConverter.zAXW4Uf2dMtnKcjLtEx2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ObjectsBAConverter()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ObjectsBAConverter.zAXW4Uf2dMtnKcjLtEx2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            ObjectsBAConverter.exportEnumsUid = new Guid((string) ObjectsBAConverter.iyUFHOf2w3mGFdFRIwR8(-1978478350 ^ -1978164832));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 3 : 2;
            continue;
          case 3:
            goto label_2;
          default:
            ObjectsBAConverter.exportCatalogsUid = new Guid((string) ObjectsBAConverter.iyUFHOf2w3mGFdFRIwR8(1142330761 ^ 1541959139 ^ 536588648));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object iyUFHOf2w3mGFdFRIwR8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void JIgIjUf24NXQhX5cbspv([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void oo2qfBf26ccKRDxBMWMn([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static bool kevtUBf2H1xmF1uV1ODA([In] object obj0) => ((ObjectsExportSetting) obj0).ExportCatalogs;

    internal static void h5aAlPf2AMj9y6qmoNno([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static bool ljRpGHf27HC42UJ7EVlP([In] object obj0) => ((ObjectsExportSetting) obj0).ExportEnums;

    internal static int CBUBk5f2x6mUhTk1q1dq([In] object obj0) => ((List<EntityBAItem>) obj0).Count;

    internal static int i5kYu2f204eh9N1mCifu([In] object obj0) => ((List<EnumBAItem>) obj0).Count;

    internal static void adH1dEf2mJXPPhiXmSBl([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool vApeiPf2DKlE88H1XWmC() => ObjectsBAConverter.O3g4Upf2atdcvnyh6sLy == null;

    internal static ObjectsBAConverter bH8A23f2tJWvoabiWPia() => ObjectsBAConverter.O3g4Upf2atdcvnyh6sLy;

    internal static void GQcp37f2ydhq7Rul1BIX([In] object obj0, bool value) => ((ObjectsExportSetting) obj0).ExportCatalogs = value;

    internal static Guid PpV4ipf2MKYedgVOoMFj([In] object obj0) => ((BPMAppManifestItem) obj0).Uid;

    internal static bool MyHoJwf2JmM0UfnGekwH([In] object obj0) => ((EntityBAItem) obj0).ExportData;

    internal static bool eOsKHGf29elH8aWmrBQd([In] object obj0, Guid uid, bool defaultValue) => ((BPMAppManifest) obj0).GetFlag(uid, defaultValue);

    internal static void zAXW4Uf2dMtnKcjLtEx2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
