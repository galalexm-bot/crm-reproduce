// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.DTO.Models.BPMAppDTO
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.BPMApps.DTO.Models
{
  [Serializable]
  public class BPMAppDTO : EntityDTO<long>, ISerializable
  {
    internal static BPMAppDTO hWpPpqfnAmXqOEQLKdRq;

    public BPMAppDTO()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Уникальный идентификатор</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор</summary>
    public string AppId
    {
      get => this.\u003CAppId\u003Ek__BackingField;
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
              this.\u003CAppId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
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

    /// <summary>Название</summary>
    public string Title
    {
      get => this.\u003CTitle\u003Ek__BackingField;
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
              this.\u003CTitle\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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

    /// <summary>Манифест компонента</summary>
    public ElmaStoreComponentManifest ComponentManifest
    {
      get => this.\u003CComponentManifest\u003Ek__BackingField;
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
              this.\u003CComponentManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Манифест BPM App</summary>
    public BPMAppManifest AppManifest
    {
      get => this.\u003CAppManifest\u003Ek__BackingField;
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
              this.\u003CAppManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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

    /// <summary>Манифест BPM App</summary>
    public BPMAppFakeManifest AppFakeManifest
    {
      get => this.\u003CAppFakeManifest\u003Ek__BackingField;
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
              this.\u003CAppFakeManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
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

    /// <summary>Установлен</summary>
    public bool Installed
    {
      get => this.\u003CInstalled\u003Ek__BackingField;
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
              this.\u003CInstalled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Файл иконки</summary>
    public byte[] IconData
    {
      get => this.\u003CIconData\u003Ek__BackingField;
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
              this.\u003CIconData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>Имя файла иконки</summary>
    public string IconFileName
    {
      get => this.\u003CIconFileName\u003Ek__BackingField;
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
              this.\u003CIconFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
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

    /// <summary>Отпечатки сертификатов</summary>
    public string[] CertificateThumbprints
    {
      get => this.\u003CCertificateThumbprints\u003Ek__BackingField;
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
              this.\u003CCertificateThumbprints\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

    protected BPMAppDTO(SerializationInfo info, StreamingContext context)
    {
      BPMAppDTO.sUlZJrfn0MW4K5vTCqHT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      string xml;
      object obj;
      IEnumerator<PropertyInfo> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_23;
          case 1:
            obj = ClassSerializationHelper.DeserializeObjectByXml(this.GetType(), xml);
            num1 = 2;
            continue;
          case 2:
            if (obj != null)
            {
              num1 = 4;
              continue;
            }
            goto label_17;
          case 3:
            xml = (string) BPMAppDTO.jr4LWqfnmUnrjZnIbcup((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889502008), typeof (string));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
          case 4:
            PropertyInfo[] properties = obj.GetType().GetProperties();
            // ISSUE: reference to a compiler-generated field
            Func<PropertyInfo, bool> func = BPMAppDTO.\u003C\u003Ec.\u003C\u003E9__41_0;
            Func<PropertyInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              BPMAppDTO.\u003C\u003Ec.\u003C\u003E9__41_0 = predicate = (Func<PropertyInfo, bool>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      if (!p.CanRead)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!BPMAppDTO.\u003C\u003Ec.mBmoPO8zvAdpoAePIKql((object) p))
                      {
                        num2 = 4;
                        continue;
                      }
                      goto label_6;
                    case 3:
                      goto label_6;
                    default:
                      goto label_7;
                  }
                }
label_6:
                return AttributeHelper<XmlIgnoreAttribute>.GetAttribute((MemberInfo) p, true) == null;
label_7:
                return false;
              });
            }
            else
              goto label_26;
label_25:
            enumerator = ((IEnumerable<PropertyInfo>) properties).Where<PropertyInfo>(predicate).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 5;
            continue;
label_26:
            predicate = func;
            goto label_25;
          case 5:
            goto label_4;
          default:
            goto label_12;
        }
      }
label_23:
      return;
label_12:
      return;
label_4:
      try
      {
label_7:
        if (BPMAppDTO.HUnsZ1fnJ0qtmBoHQUiK((object) enumerator))
          goto label_9;
        else
          goto label_8;
label_5:
        PropertyInfo current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_9;
            case 2:
              BPMAppDTO.WiEFwofnM46GOWk1g9q8((object) current, (object) this, BPMAppDTO.fRKAeRfnygZoPfhB74vn((object) current, obj, (object) null), (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_8:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 3 : 2;
        goto label_5;
label_9:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        {
          num3 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_19;
              default:
                BPMAppDTO.nQwHPQfn9325gVa8pjgA((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_19:;
      }
label_17:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            BPMAppDTO.ETtpcsfnll2fqpmUEAGE((object) info, BPMAppDTO.WAr9Lrfnd6mDTnY8v0qg(~538519529 ^ -538544994), (object) ClassSerializationHelper.SerializeObjectByXml((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool mK7fuLfn7SufrGgHbNVE() => BPMAppDTO.hWpPpqfnAmXqOEQLKdRq == null;

    internal static BPMAppDTO bhLNZ2fnxegxa3P4g2YK() => BPMAppDTO.hWpPpqfnAmXqOEQLKdRq;

    internal static void sUlZJrfn0MW4K5vTCqHT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object jr4LWqfnmUnrjZnIbcup([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static object fRKAeRfnygZoPfhB74vn([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void WiEFwofnM46GOWk1g9q8([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool HUnsZ1fnJ0qtmBoHQUiK([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void nQwHPQfn9325gVa8pjgA([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object WAr9Lrfnd6mDTnY8v0qg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ETtpcsfnll2fqpmUEAGE([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
