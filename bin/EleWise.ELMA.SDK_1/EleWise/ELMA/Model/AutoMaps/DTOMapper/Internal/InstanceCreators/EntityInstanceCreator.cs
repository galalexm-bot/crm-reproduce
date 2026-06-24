// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators.EntityInstanceCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators
{
  /// <summary>Создать эекземпляров сущностей</summary>
  internal sealed class EntityInstanceCreator : DefaultInstanceCreator
  {
    internal static EntityInstanceCreator cMfGWhh0MYmOYDqsS0ln;

    /// <inheritdoc />
    public override bool CanCreateInstance(Type type) => TypeOf<IEntity>.Raw.IsAssignableFrom(type);

    /// <inheritdoc />
    public override object CreateInstance(DataClass dataClass, Type type)
    {
      int num1 = 6;
      IEntity instance1;
      IEntity instance2;
      DataClass dataClass1;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata;
        DataClassMetadata dataClassMetadata;
        IEntity entity;
        IEntityManager manager;
        Guid uid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              entity = (IEntity) null;
              num2 = 2;
              continue;
            case 2:
              uid = !(dataClass1.GetObject(EntityInstanceCreator.LxyyuSh0gHm3nl1gv5AA((object) dataClassMetadata), EntityInstanceCreator.LxyyuSh0gHm3nl1gv5AA((object) propertyMetadata)) is Guid guid) ? Guid.Empty : guid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 7;
              continue;
            case 3:
              goto label_24;
            case 4:
              goto label_11;
            case 5:
              dataClass1 = dataClass;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            case 6:
              num2 = 5;
              continue;
            case 7:
              EntityInstanceCreator.JcBlV4h058WpywWhNhGp((object) Locator.GetServiceNotNull<ISecurityService>(), (object) (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      entity = EntityInstanceCreator.\u003C\u003Ec__DisplayClass1_0.nYUFiKv4UhKOjDrRcPHg((object) manager, uid) as IEntity;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 13;
              continue;
            case 8:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 11 : 3;
                continue;
              }
              manager = (IEntityManager) EntityInstanceCreator.KYGTTeh0rCmY45AoWhsv(type);
              num2 = 15;
              continue;
            case 9:
              goto label_20;
            case 10:
              goto label_12;
            case 11:
              goto label_15;
            case 12:
              goto label_17;
            case 13:
              instance2 = entity;
              if (instance2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 14 : 6;
                continue;
              }
              goto label_22;
            case 14:
              goto label_3;
            case 15:
              if (manager != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
                continue;
              }
              goto label_20;
            default:
              if (!TypeOf<IMetadata>.Raw.IsAssignableFrom(type))
              {
                num2 = 10;
                continue;
              }
              goto label_11;
          }
        }
label_3:
        entity = instance1 = manager.Create() as IEntity;
        num1 = 3;
        continue;
label_12:
        // ISSUE: reference to a compiler-generated method
        dataClassMetadata = dataClass1.GetIncludes(false).First<DataClassMetadata>((Func<DataClassMetadata, bool>) (a => a.TypeRef == (string) EntityInstanceCreator.\u003C\u003Ec__DisplayClass1_0.GrX8Biv4Ljljlb92lBl6((object) dataClass1)));
        num1 = 12;
        continue;
label_17:
        propertyMetadata = (PropertyMetadata) EntityInstanceCreator.jHoB8Rh0lpkQQvudaRoe((object) dataClassMetadata);
        num1 = 8;
      }
label_22:
      return (object) instance2;
label_11:
      return EntityInstanceCreator.Ta4HNMh0dDiMRuv2o8rX(type);
label_15:
      return base.CreateInstance(dataClass1, type);
label_20:
      return base.CreateInstance(dataClass1, type);
label_24:
      return (object) instance1;
    }

    public EntityInstanceCreator()
    {
      EntityInstanceCreator.Bjbbhhh0j7fF7e4bAoaZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lWJ3HOh0JVlws5408DiX() => EntityInstanceCreator.cMfGWhh0MYmOYDqsS0ln == null;

    internal static EntityInstanceCreator XIVxMXh09W36xUUQ21Ja() => EntityInstanceCreator.cMfGWhh0MYmOYDqsS0ln;

    internal static object Ta4HNMh0dDiMRuv2o8rX([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object jHoB8Rh0lpkQQvudaRoe([In] object obj0) => (object) ((ClassMetadata) obj0).GetUidProperty();

    internal static object KYGTTeh0rCmY45AoWhsv(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static Guid LxyyuSh0gHm3nl1gv5AA([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void JcBlV4h058WpywWhNhGp([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void Bjbbhhh0j7fF7e4bAoaZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
