// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.DoubleTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class DoubleTypeEncrypter : BaseTypeEncrypter
  {
    internal static DoubleTypeEncrypter UD84cKoYRl9FZdqJJSlm;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return DoubleTypeEncrypter.ygnJmloYTYvXrnOy0BVW(DoubleTypeEncrypter.QC6TVwoYXrVMbS6nXEJ8((object) propertyMetadata1), DoubleDescriptor.UID);
label_4:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            if (DoubleTypeEncrypter.OS9G7doYklWwc5FI7l6N((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return string.Empty;
label_3:
      return base.ObjectToString((object) Convert.ToDouble(obj), propertyMetadata);
label_4:
      return base.ObjectToString(obj, propertyMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_6;
            case 3:
              if (DoubleTypeEncrypter.OS9G7doYklWwc5FI7l6N((object) (PropertyMetadata) propertyMetadata))
                goto case 4;
              else
                goto label_4;
            case 4:
              if (!DoubleTypeEncrypter.ck6GGWoYnD7dZbPsLt6R((object) obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_4:
        num1 = 2;
      }
label_5:
      return (object) null;
label_6:
      return (object) DoubleTypeEncrypter.KfFjLuoYOFbtxtBFqZwC((object) obj);
    }

    public DoubleTypeEncrypter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid QC6TVwoYXrVMbS6nXEJ8([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool ygnJmloYTYvXrnOy0BVW([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool wp2oyjoYqWForfdEq0Qi() => DoubleTypeEncrypter.UD84cKoYRl9FZdqJJSlm == null;

    internal static DoubleTypeEncrypter ydHN8JoYKpmiL4uiUnlN() => DoubleTypeEncrypter.UD84cKoYRl9FZdqJJSlm;

    internal static bool OS9G7doYklWwc5FI7l6N([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool ck6GGWoYnD7dZbPsLt6R([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static double KfFjLuoYOFbtxtBFqZwC([In] object obj0) => Convert.ToDouble((string) obj0);
  }
}
