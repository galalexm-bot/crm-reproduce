// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.EnumTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class EnumTypeEncrypter : BaseTypeEncrypter
  {
    private static EnumTypeEncrypter zq0Iv7oY0YLJWdqxMr7S;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EnumTypeEncrypter.jMiSkToYMrMeUH4MQoi3((object) propertyMetadata1) == EnumDescriptor.UID;
label_5:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num1 = 4;
      EnumValueMetadata enumValueMetadata;
      int num2;
      while (true)
      {
        int num3 = num1;
        EnumMetadata metadata;
        PropertyMetadata propertyMetadata1;
        string sVal;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (EnumTypeEncrypter.IQdMOKoY9mXD4i2DfQyx((object) metadata) == EnumMetadataType.Enum)
                goto case 10;
              else
                goto label_8;
            case 2:
              goto label_11;
            case 3:
              propertyMetadata1 = (PropertyMetadata) propertyMetadata;
              num3 = 6;
              continue;
            case 4:
              num3 = 3;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              enumValueMetadata = metadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumTypeEncrypter.\u003C\u003Ec__DisplayClass1_0.Dnhe8BCqS3VytJ0EgodU((object) v.EnumValue.ToString(), (object) sVal)));
              num3 = 7;
              continue;
            case 6:
              metadata = (EnumMetadata) Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(EnumTypeEncrypter.FO3aZToYJ0PR37twvEZg((object) propertyMetadata1));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            case 7:
              if (enumValueMetadata != null)
              {
                num3 = 8;
                continue;
              }
              goto label_11;
            case 8:
              goto label_12;
            case 9:
              sVal = obj.ToString();
              num3 = 5;
              continue;
            case 10:
              num2 = EnumTypeEncrypter.Q0LAh7oYdI0gZiGV5mun(obj);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_8:
        num1 = 9;
      }
label_4:
      return num2.ToString();
label_11:
      return string.Empty;
label_12:
      return (string) EnumTypeEncrypter.TWwYIUoYlmcC6prViKw5((object) enumValueMetadata);
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num1 = 13;
      EnumMetadata metadata;
      EnumValueMetadata enumValueMetadata;
      Guid enumUid;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata1;
        int enumInt;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (enumValueMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              if (!EnumTypeEncrypter.aMt8dpoYg6N2Oa6FyPRa((object) obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 7 : 14;
                continue;
              }
              goto label_4;
            case 3:
              enumUid = new Guid(obj);
              num2 = 8;
              continue;
            case 4:
              goto label_4;
            case 5:
              if (EnumTypeEncrypter.IQdMOKoY9mXD4i2DfQyx((object) metadata) != EnumMetadataType.Enum)
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 6:
              if (!EnumTypeEncrypter.l3IrtloYryjfdEvoedtx((object) propertyMetadata1))
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 7:
            case 14:
              goto label_5;
            case 8:
              goto label_11;
            case 9:
              enumValueMetadata = metadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
              {
                int num3 = 1;
                int? intValue;
                int num4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      intValue = v.IntValue;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      num4 = enumInt;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 2;
                      continue;
                  }
                }
label_2:
                return intValue.GetValueOrDefault() == num4 & intValue.HasValue;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
              continue;
            case 10:
              num2 = 11;
              continue;
            case 11:
              enumInt = EnumTypeEncrypter.TafAUCoY5EIABoj1sqRN((object) obj);
              num2 = 9;
              continue;
            case 12:
              propertyMetadata1 = (PropertyMetadata) propertyMetadata;
              num2 = 6;
              continue;
            case 13:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 10 : 12;
              continue;
            default:
              goto label_8;
          }
        }
label_5:
        metadata = (EnumMetadata) Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(EnumTypeEncrypter.FO3aZToYJ0PR37twvEZg((object) propertyMetadata1));
        num1 = 5;
      }
label_4:
      return (object) null;
label_8:
      return (object) null;
label_9:
      return EnumTypeEncrypter.jn6CnhoYjNs7qVUiMA99((object) enumValueMetadata);
label_11:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return metadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumTypeEncrypter.\u003C\u003Ec__DisplayClass2_0.ivl8u4CqTjhjJZ80oxTS(EnumTypeEncrypter.\u003C\u003Ec__DisplayClass2_0.wXkJxnCqXZUXR5sRlk9l((object) v), enumUid))).EnumValue;
    }

    public EnumTypeEncrypter()
    {
      EnumTypeEncrypter.ekU0H8oYYM2ZBVajFhil();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid jMiSkToYMrMeUH4MQoi3([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool NKXfFloYmQUi5lmkpDhR() => EnumTypeEncrypter.zq0Iv7oY0YLJWdqxMr7S == null;

    internal static EnumTypeEncrypter sO7tLLoYywK26Nv0Cn5P() => EnumTypeEncrypter.zq0Iv7oY0YLJWdqxMr7S;

    internal static Guid FO3aZToYJ0PR37twvEZg([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static EnumMetadataType IQdMOKoY9mXD4i2DfQyx([In] object obj0) => ((EnumMetadata) obj0).Type;

    internal static int Q0LAh7oYdI0gZiGV5mun([In] object obj0) => Convert.ToInt32(obj0);

    internal static object TWwYIUoYlmcC6prViKw5([In] object obj0) => (object) ((AbstractMetadata) obj0).UidStr;

    internal static bool l3IrtloYryjfdEvoedtx([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool aMt8dpoYg6N2Oa6FyPRa([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int TafAUCoY5EIABoj1sqRN([In] object obj0) => Convert.ToInt32((string) obj0);

    internal static object jn6CnhoYjNs7qVUiMA99([In] object obj0) => ((EnumValueMetadata) obj0).EnumValue;

    internal static void ekU0H8oYYM2ZBVajFhil() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
