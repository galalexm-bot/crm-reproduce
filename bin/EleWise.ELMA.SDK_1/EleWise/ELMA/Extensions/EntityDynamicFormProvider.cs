// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.EntityDynamicFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  [Component]
  public class EntityDynamicFormProvider : IDynamicFormsProvider
  {
    public static readonly Guid UID;
    internal static EntityDynamicFormProvider ATSD1jG4uUuCpmFoqfG4;

    public Guid Uid => EntityDynamicFormProvider.UID;

    public Type GetEntityType(DynamicFormSettings settings)
    {
      int num1 = 2;
      Type typeByUid;
      while (true)
      {
        int num2 = num1;
        Guid result;
        IMetadataRuntimeService serviceNotNull;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              if (EntityDynamicFormProvider.YjmhDiG4Sfatwk7XhorN((object) settings.DynamicFormsProviderData))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
                continue;
              }
              goto label_14;
            case 3:
              typeByUid = serviceNotNull.GetTypeByUid(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 6;
              continue;
            case 4:
              goto label_9;
            case 5:
              if (Guid.TryParse((string) EntityDynamicFormProvider.OplRWZG4iXwCqRkGp3gN((object) settings), out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 3;
                continue;
              }
              goto label_7;
            case 6:
              if (!EntityDynamicFormProvider.MTPusAG4ROJCi20yP0Jl(typeByUid, (Type) null))
              {
                num2 = 4;
                continue;
              }
              goto label_10;
            default:
              goto label_7;
          }
        }
label_14:
        serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
        num1 = 5;
      }
label_7:
      return (Type) null;
label_9:
      return (Type) null;
label_10:
      return typeByUid.CastAsRealType<Type>();
label_13:
      return (Type) null;
    }

    public static string CreateData(IEntity entity, ViewType viewType, ItemType itemType)
    {
      int num = 1;
      Guid guid;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entity != null)
            {
              guid = InterfaceActivator.UID(entity.CastAsRealType<IEntity>().GetType());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) null;
label_6:
      return guid.ToString();
    }

    public string GetPropertyValueChangeScriptName(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string propertyName)
    {
      int num = 1;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        Guid uid;
        Type typeByUid;
        EntityMetadata entityMetadata;
        string propertyName1;
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 2:
            typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 7 : 6;
            continue;
          case 3:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 6 : 6;
              continue;
            }
            goto label_3;
          case 4:
            uid = new Guid(settings.DynamicFormsProviderData);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 0;
            continue;
          case 5:
            entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeByUid);
            break;
          case 6:
            goto label_2;
          case 7:
            if (entity == null)
            {
              num = 5;
              continue;
            }
            entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(entity.GetType());
            break;
          default:
            propertyName1 = propertyName;
            num = 4;
            continue;
        }
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass5_0.h5uviX8bsqY8LdATjjB4(EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass5_0.JQ9Gus8bUTuQ9hsxfd0R((object) p), (object) propertyName1)));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 3;
      }
label_2:
      return (string) null;
label_3:
      return (string) EntityDynamicFormProvider.Jje7rVG4qEYOpnUDxYN6((object) propertyMetadata);
    }

    public void ExecuteScript(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string scriptName,
      DynamicFormResultData resultData)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        ClassMetadata classMetadata;
        IEntity entity1;
        IEntityScriptingService serviceNotNull;
        Dictionary<string, object> parameters;
        IEntity entity2;
        Guid tpPropUid;
        RootViewItem formView;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              if (formView != null)
              {
                parameters = new Dictionary<string, object>();
                num2 = 8;
                continue;
              }
              num2 = 3;
              continue;
            case 3:
              goto label_9;
            case 4:
            case 13:
              if (entity1 != entity)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 22 : 15;
                continue;
              }
              goto case 24;
            case 5:
              if (serviceNotNull != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 15 : 11;
                continue;
              }
              goto label_34;
            case 6:
              tpPropUid = EntityDynamicFormProvider.f4yLI2G4KKi9SYs6NvMV((object) (ITablePartMetadata) classMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 6 : 10;
              continue;
            case 7:
              if (entity2 == null)
                goto case 4;
              else
                goto label_29;
            case 8:
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_35;
            case 10:
              goto label_13;
            case 11:
              entity1 = entity;
              num2 = 19;
              continue;
            case 12:
            case 20:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 6;
              continue;
            case 14:
              goto label_7;
            case 15:
              formView = view;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
              continue;
            case 16:
              if (entity != null)
              {
                serviceNotNull = Locator.GetServiceNotNull<IEntityScriptingService>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 5 : 5;
                continue;
              }
              num2 = 9;
              continue;
            case 17:
              num2 = 16;
              continue;
            case 18:
            case 19:
              if (!(classMetadata is ITablePartMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 13 : 12;
                continue;
              }
              goto case 7;
            case 21:
              // ISSUE: reference to a compiler-generated method
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(EntityDynamicFormProvider.GvEOBTG4Tn2Zq8BWrnEK((object) classMetadata.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass6_1.ODKHp38hCPNThCkQouKm((object) p) == tpPropUid))));
              num2 = 18;
              continue;
            case 22:
              goto label_21;
            case 23:
              entity1 = entity2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 19 : 21;
              continue;
            case 24:
              serviceNotNull.ExecuteScript(entity1, scriptName, parameters, (Func<string, Type, object>) ((name, type) =>
              {
                int num3 = 2;
                IMetadata metadata;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 6:
                      goto label_9;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass6_0.l1rLHB8hWpWSMVCo6Q6n((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841413206)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 5;
                    case 3:
                      metadata = MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 0;
                      continue;
                    case 4:
                      goto label_8;
                    case 5:
                      if (type.IsGenericType)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_9;
                    default:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass6_0.z5ySlW8hbP7xZuMH0TRi(type.GetGenericTypeDefinition(), EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass6_0.InsVD78hoyDRy8cwtrsc(__typeref (FormViewBuilder<>))))
                      {
                        num3 = 6;
                        continue;
                      }
                      goto case 3;
                  }
                }
label_8:
                // ISSUE: reference to a compiler-generated method
                return EntityDynamicFormProvider.\u003C\u003Ec__DisplayClass6_0.mtc8Fd8hhGqKDyvbagIC(type, (object) new object[2]
                {
                  (object) formView,
                  (object) metadata
                });
label_9:
                return (object) null;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
              continue;
            case 25:
              if (entity2 != null)
              {
                num2 = 23;
                continue;
              }
              goto case 21;
            default:
              entity2 = entity;
              num2 = 11;
              continue;
          }
        }
label_13:
        entity2 = (IEntity) EntityDynamicFormProvider.BAVxS9G4XvbyRrFaBa3w((object) entity2, tpPropUid);
        num1 = 25;
        continue;
label_21:
        parameters[(string) EntityDynamicFormProvider.XTab79G4kkO8Iipm4Ct9(-675505729 ^ -675532351)] = (object) entity;
        num1 = 24;
        continue;
label_29:
        num1 = 12;
      }
label_11:
      return;
label_9:
      return;
label_35:
      return;
label_7:
      return;
label_34:;
    }

    public EntityDynamicFormProvider()
    {
      EntityDynamicFormProvider.sesTenG4nH01CMyEYIA9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityDynamicFormProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityDynamicFormProvider.UID = new Guid((string) EntityDynamicFormProvider.XTab79G4kkO8Iipm4Ct9(654297945 ^ 654062701));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityDynamicFormProvider.sesTenG4nH01CMyEYIA9();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool YjmhDiG4Sfatwk7XhorN([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object OplRWZG4iXwCqRkGp3gN([In] object obj0) => (object) ((DynamicFormSettings) obj0).DynamicFormsProviderData;

    internal static bool MTPusAG4ROJCi20yP0Jl([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool pyVTg5G4IiRADRk5Oiun() => EntityDynamicFormProvider.ATSD1jG4uUuCpmFoqfG4 == null;

    internal static EntityDynamicFormProvider ca2TUuG4V9Ys5dHPFElF() => EntityDynamicFormProvider.ATSD1jG4uUuCpmFoqfG4;

    internal static object Jje7rVG4qEYOpnUDxYN6([In] object obj0) => (object) ((PropertyMetadata) obj0).OnChangeScriptName;

    internal static Guid f4yLI2G4KKi9SYs6NvMV([In] object obj0) => ((ITablePartMetadata) obj0).ParentPropertyUid;

    internal static object BAVxS9G4XvbyRrFaBa3w([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static Guid GvEOBTG4Tn2Zq8BWrnEK([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object XTab79G4kkO8Iipm4Ct9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void sesTenG4nH01CMyEYIA9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
