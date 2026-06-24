// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.EntityWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 100)]
  public class EntityWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static EntityWrapperDescriptor SGAyK1bQK9PLM3HKob4N;

    public Type OriginalType => typeof (IEntity);

    public Type WrapperType => EntityWrapperDescriptor.tuj9CXbQkZ4Sj8e1YOaW(__typeref (EntityWrapper));

    public object CreateWrapper(object obj) => (object) new EntityWrapper((IEntity) obj);

    public object GetObject(object wrapper)
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      EntityWrapperDescriptor.\u003C\u003Ec__DisplayClass5_1 cDisplayClass51;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        EntityWrapperDescriptor.\u003C\u003Ec__DisplayClass5_0 cDisplayClass50;
        Type typeByUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              // ISSUE: reference to a compiler-generated method
              EntityWrapperDescriptor.L9xEbBbQ2U0Sp2whRi2h((object) Locator.GetServiceNotNull<ISecurityService>(), (object) new System.Action(cDisplayClass51.\u003CGetObject\u003Eb__0));
              num2 = 9;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass50.info = (EntityWrapper) wrapper;
              num2 = 7;
              continue;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass50 = new EntityWrapperDescriptor.\u003C\u003Ec__DisplayClass5_0();
              num2 = 3;
              continue;
            case 5:
              goto label_14;
            case 6:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass50.manager == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 0;
                continue;
              }
              break;
            case 7:
              goto label_7;
            case 8:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass51.CS\u0024\u003C\u003E8__locals1 = cDisplayClass50;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
              continue;
            case 9:
              goto label_13;
            case 10:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass50.manager = (IEntityManager) EntityWrapperDescriptor.EYoghnbQOFbP6nE25QiC(typeByUid);
              num2 = 6;
              continue;
          }
          // ISSUE: object of a compiler-generated type is created
          cDisplayClass51 = new EntityWrapperDescriptor.\u003C\u003Ec__DisplayClass5_1();
          num2 = 8;
        }
label_7:
        // ISSUE: reference to a compiler-generated field
        typeByUid = Locator.GetService<IMetadataRuntimeService>().GetTypeByUid(EntityWrapperDescriptor.XIfIbZbQn8vrkJ18OreJ((object) cDisplayClass50.info));
        num1 = 10;
        continue;
label_9:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass51.res = (object) null;
        num1 = 2;
      }
label_13:
      // ISSUE: reference to a compiler-generated field
      return cDisplayClass51.res;
label_14:
      return (object) null;
    }

    public bool TestType(Type type) => false;

    public EntityWrapperDescriptor()
    {
      EntityWrapperDescriptor.JKCRkAbQeUQQmOFMvLlK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type tuj9CXbQkZ4Sj8e1YOaW([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool d4TTK0bQXhpn0gNUN6GI() => EntityWrapperDescriptor.SGAyK1bQK9PLM3HKob4N == null;

    internal static EntityWrapperDescriptor KFJu0FbQTPkiEn8Mwk4l() => EntityWrapperDescriptor.SGAyK1bQK9PLM3HKob4N;

    internal static Guid XIfIbZbQn8vrkJ18OreJ([In] object obj0) => ((EntityWrapper) obj0).TypeUid;

    internal static object EYoghnbQOFbP6nE25QiC(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static void L9xEbBbQ2U0Sp2whRi2h([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void JKCRkAbQeUQQmOFMvLlK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
