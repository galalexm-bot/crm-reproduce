// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.MoneyTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component]
  public class MoneyTypeEncrypter : BaseTypeEncrypter
  {
    private static MoneyTypeEncrypter melx6SoL3MsR8KB4N8TO;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return MoneyTypeEncrypter.yC6JVNoLtfVZC8NE1wqJ(MoneyTypeEncrypter.zYV4PsoLDtrT1aVKMu3Q((object) propertyMetadata1), MoneyDescriptor.UID);
label_6:
      return false;
    }

    protected override string ObjectToString(object obj, IMetadata propertyMetadata)
    {
      int num = 3;
      Money? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            nullable = (Money?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            if (MoneyTypeEncrypter.LIVRb4oLwWZUAvqo0vI2((object) (PropertyMetadata) propertyMetadata))
            {
              num = 2;
              continue;
            }
            goto label_5;
          case 4:
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassSerializationHelper.SerializeObjectByXml((object) new MoneyWrapper(nullable.Value));
label_5:
      return ClassSerializationHelper.SerializeObjectByXml((object) new MoneyWrapper((Money) obj));
label_6:
      return string.Empty;
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!((PropertyMetadata) propertyMetadata).Nullable)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_4;
        }
        if (MoneyTypeEncrypter.yDFnfeoL4emH5H3O4m9E((object) obj))
          num = 3;
        else
          goto label_5;
      }
label_4:
      return (object) null;
label_5:
      return (object) MoneyTypeEncrypter.KQZSoJoL6r79BDoTqsR3((object) ClassSerializationHelper.DeserializeObjectByXml<MoneyWrapper>(obj));
    }

    public MoneyTypeEncrypter()
    {
      MoneyTypeEncrypter.mqJ0V1oLHw9280bsTYav();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid zYV4PsoLDtrT1aVKMu3Q([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool yC6JVNoLtfVZC8NE1wqJ([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool YfRCDZoLpiXolxSpSYKf() => MoneyTypeEncrypter.melx6SoL3MsR8KB4N8TO == null;

    internal static MoneyTypeEncrypter bfj8FeoLadCMIKCpU4Qw() => MoneyTypeEncrypter.melx6SoL3MsR8KB4N8TO;

    internal static bool LIVRb4oLwWZUAvqo0vI2([In] object obj0) => ((PropertyMetadata) obj0).Nullable;

    internal static bool yDFnfeoL4emH5H3O4m9E([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Money KQZSoJoL6r79BDoTqsR3([In] object obj0) => ((MoneyWrapper) obj0).Value;

    internal static void mqJ0V1oLHw9280bsTYav() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
