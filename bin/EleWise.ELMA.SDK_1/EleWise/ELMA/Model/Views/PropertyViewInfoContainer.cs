// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PropertyViewInfoContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Контейнер информации о свойствах на форме</summary>
  public sealed class PropertyViewInfoContainer
  {
    private readonly Dictionary<string, PropertyViewInfo> dict;
    internal static PropertyViewInfoContainer bkqI0koR8Ykmk1LeMVFV;

    /// <summary>Ctor</summary>
    /// <param name="classMetadata">Метаданные</param>
    public PropertyViewInfoContainer(ClassMetadata classMetadata)
    {
      PropertyViewInfoContainer.pHDpD1oRIbVvOCfbl64N();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num1 = 6;
      List<PropertyMetadata>.Enumerator enumerator1;
      IEnumerator<IPropertyMetadata> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator2 = tablePartContainer.TableParts.OfType<IPropertyMetadata>().GetEnumerator();
            num1 = 2;
            continue;
          case 2:
            goto label_19;
          case 3:
            enumerator1 = classMetadata.Properties.GetEnumerator();
            num1 = 8;
            continue;
          case 4:
            goto label_32;
          case 5:
            goto label_27;
          case 6:
            PropertyViewInfoContainer.n9OWoloRSoqABV0eVopm((object) classMetadata, PropertyViewInfoContainer.LkBWhIoRVHWuRLFQjXlX(1574260816 ^ 1574395572));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 4;
            continue;
          case 7:
            this.dict = new Dictionary<string, PropertyViewInfo>();
            num1 = 3;
            continue;
          case 8:
            try
            {
label_10:
              if (enumerator1.MoveNext())
                goto label_9;
              else
                goto label_11;
label_7:
              PropertyMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_17;
                  case 2:
                    goto label_10;
                  case 3:
                    Dictionary<string, PropertyViewInfo> dict = this.dict;
                    object key = PropertyViewInfoContainer.Vg0oGnoRitsDZ1dcpvqA((object) current);
                    PropertyViewInfo propertyViewInfo = new PropertyViewInfo();
                    PropertyViewInfoContainer.aGo3BZoRqERvvV5fJe7S((object) propertyViewInfo, PropertyViewInfoContainer.i0m7pkoRRPI3Fm0tjvvn((object) current));
                    dict.Add((string) key, propertyViewInfo);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 0;
                    continue;
                  default:
                    goto label_9;
                }
              }
label_9:
              current = enumerator1.Current;
              num2 = 3;
              goto label_7;
label_11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              goto label_7;
            }
            finally
            {
              enumerator1.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          default:
label_17:
            if (!(classMetadata is ITablePartContainer tablePartContainer))
            {
              num1 = 4;
              continue;
            }
            goto case 1;
        }
      }
label_32:
      return;
label_27:
      return;
label_19:
      try
      {
label_22:
        if (PropertyViewInfoContainer.SdccUhoRKci0551xMVce((object) enumerator2))
          goto label_24;
        else
          goto label_23;
label_20:
        IPropertyMetadata current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_24;
            case 2:
              goto label_21;
            case 3:
              goto label_22;
            default:
              Dictionary<string, PropertyViewInfo> dict = this.dict;
              string name = current.Name;
              PropertyViewInfo propertyViewInfo = new PropertyViewInfo();
              PropertyViewInfoContainer.aGo3BZoRqERvvV5fJe7S((object) propertyViewInfo, current.PropertyUid);
              dict.Add(name, propertyViewInfo);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 3 : 3;
              continue;
          }
        }
label_21:
        return;
label_23:
        num4 = 2;
        goto label_20;
label_24:
        current = enumerator2.Current;
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        {
          num4 = 0;
          goto label_20;
        }
        else
          goto label_20;
      }
      finally
      {
        if (enumerator2 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_34;
              default:
                PropertyViewInfoContainer.M2u0yloRXwbaPrhDQ9Ub((object) enumerator2);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_34:;
      }
    }

    /// <summary>Получить информацию о свойстве по имени</summary>
    /// <param name="name">Имя свойства</param>
    /// <returns>Информация о свойстве</returns>
    public PropertyViewInfo Get(string name)
    {
      int num = 1;
      PropertyViewInfo propertyViewInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.dict.TryGetValue(name, out propertyViewInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return propertyViewInfo;
    }

    /// <summary>Получить всю информацию о свойствах на форме</summary>
    /// <returns>Вся информация о свойствах на форме</returns>
    public ICollection<PropertyViewInfo> GetAll() => (ICollection<PropertyViewInfo>) this.dict.Values.ToList<PropertyViewInfo>();

    internal static void pHDpD1oRIbVvOCfbl64N() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object LkBWhIoRVHWuRLFQjXlX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void n9OWoloRSoqABV0eVopm([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object Vg0oGnoRitsDZ1dcpvqA([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid i0m7pkoRRPI3Fm0tjvvn([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void aGo3BZoRqERvvV5fJe7S([In] object obj0, Guid value) => ((PropertyViewInfo) obj0).Uid = value;

    internal static bool SdccUhoRKci0551xMVce([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void M2u0yloRXwbaPrhDQ9Ub([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool Xp3T8foRZ5Ei7AtFHcMr() => PropertyViewInfoContainer.bkqI0koR8Ykmk1LeMVFV == null;

    internal static PropertyViewInfoContainer Eg4UWNoRu7mqlWaieghP() => PropertyViewInfoContainer.bkqI0koR8Ykmk1LeMVFV;
  }
}
