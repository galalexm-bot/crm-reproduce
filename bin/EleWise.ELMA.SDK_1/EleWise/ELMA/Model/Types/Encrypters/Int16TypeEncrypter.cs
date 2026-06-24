// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.Int16TypeEncrypter
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
  public class Int16TypeEncrypter : BaseTypeEncrypter
  {
    internal static Int16TypeEncrypter JUF9LloLTt6p2H5IYYgb;

    public override bool CheckType(object obj, IMetadata propertyMetadata)
    {
      int num = 1;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (propertyMetadata1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return Int16TypeEncrypter.ljJoMBoLOOZrwBSKF6kP((object) propertyMetadata1) == Int16Descriptor.UID;
label_6:
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
            goto label_8;
          case 2:
            if (!((PropertyMetadata) propertyMetadata).Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return string.Empty;
label_7:
      return base.ObjectToString((object) Convert.ToInt16(obj), propertyMetadata);
label_8:
      return base.ObjectToString(obj, propertyMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty(obj))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 4:
            if (!Int16TypeEncrypter.c1tI81oL29lB4tHwjk3D((object) (PropertyMetadata) propertyMetadata))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_5;
        }
      }
label_4:
      return (object) null;
label_5:
      return (object) Convert.ToInt16(obj);
    }

    public Int16TypeEncrypter()
    {
      Int16TypeEncrypter.IJSLYnoLeor5JU6eE963();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid ljJoMBoLOOZrwBSKF6kP([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool rE2J4roLkuGwCoI890NW() => Int16TypeEncrypter.JUF9LloLTt6p2H5IYYgb == null;

    internal static Int16TypeEncrypter Gg2j0WoLnMjEI62PWutv() => Int16TypeEncrypter.JUF9LloLTt6p2H5IYYgb;

    internal static bool c1tI81oL29lB4tHwjk3D([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static void IJSLYnoLeor5JU6eE963() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
