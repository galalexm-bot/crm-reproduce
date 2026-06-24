// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Encrypters.EntityTypeEncrypter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Encrypters
{
  [Component(Order = 100)]
  public class EntityTypeEncrypter : BaseTypeEncrypter
  {
    private static EntityTypeEncrypter tBShx9oYaqDJLWVNmdFn;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 0;
              continue;
            }
            goto label_3;
          case 2:
            propertyMetadata1 = propertyMetadata as PropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
            continue;
          case 3:
            if (EntityTypeEncrypter.WiotpnoY4qqZeJu7T3m8(EntityTypeEncrypter.VtuoVloYwcPeE3bRFXjS((object) propertyMetadata1), Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return EntityTypeEncrypter.WYYsNCoY6S6PMmvhCJYA((object) propertyMetadata1) != EnumDescriptor.UID;
label_3:
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
            goto label_5;
          case 2:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return ClassSerializationHelper.SerializeObjectByXml((object) new EntityWrapper((IEntity) obj));
    }

    protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
    {
      int num = 8;
      // ISSUE: variable of a compiler-generated type
      EntityTypeEncrypter.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
      Type typeByUid;
      // ISSUE: variable of a compiler-generated type
      EntityTypeEncrypter.\u003C\u003Ec__DisplayClass2_1 cDisplayClass21;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            EntityTypeEncrypter.t9A9jRoY77ReSWDaDqdI((object) Locator.GetServiceNotNull<ISecurityService>(), (object) new System.Action(cDisplayClass21.\u003CGetObjectFromString\u003Eb__0));
            num = 4;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            if (cDisplayClass20.manager == null)
            {
              num = 12;
              continue;
            }
            goto case 5;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.entityWrapper = ClassSerializationHelper.DeserializeObjectByXml<EntityWrapper>(obj);
            num = 11;
            continue;
          case 4:
            goto label_8;
          case 5:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass21 = new EntityTypeEncrypter.\u003C\u003Ec__DisplayClass2_1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass21.res = (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          case 7:
            if (!string.IsNullOrEmpty(obj))
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 8:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass20 = new EntityTypeEncrypter.\u003C\u003Ec__DisplayClass2_0();
            num = 7;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.manager = (IEntityManager) EntityTypeEncrypter.hMRyetoYA1eyy4m3Udlc(typeByUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 2;
            continue;
          case 10:
            goto label_3;
          case 11:
            // ISSUE: reference to a compiler-generated field
            typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(EntityTypeEncrypter.so5sLPoYHVYkDUEiYDuT((object) cDisplayClass20.entityWrapper));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 9 : 0;
            continue;
          case 12:
            goto label_9;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass21.CS\u0024\u003C\u003E8__locals1 = cDisplayClass20;
            num = 6;
            continue;
        }
      }
label_3:
      return (object) null;
label_8:
      // ISSUE: reference to a compiler-generated field
      return cDisplayClass21.res;
label_9:
      return (object) null;
    }

    public EntityTypeEncrypter()
    {
      EntityTypeEncrypter.bDlFVuoYxLN6fIRGJinm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid VtuoVloYwcPeE3bRFXjS([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool WiotpnoY4qqZeJu7T3m8([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid WYYsNCoY6S6PMmvhCJYA([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool cKQKPOoYDqmXVo1YGQdy() => EntityTypeEncrypter.tBShx9oYaqDJLWVNmdFn == null;

    internal static EntityTypeEncrypter NVbZFGoYtwBB5oebNmS7() => EntityTypeEncrypter.tBShx9oYaqDJLWVNmdFn;

    internal static Guid so5sLPoYHVYkDUEiYDuT([In] object obj0) => ((EntityWrapper) obj0).TypeUid;

    internal static object hMRyetoYA1eyy4m3Udlc(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static void t9A9jRoY77ReSWDaDqdI([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void bDlFVuoYxLN6fIRGJinm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
