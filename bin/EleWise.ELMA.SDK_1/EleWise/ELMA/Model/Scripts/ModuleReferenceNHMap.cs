// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ModuleReferenceNHMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// NHibernate mapper для <see cref="T:EleWise.ELMA.Model.Scripts.ModuleReference" />
  /// </summary>
  internal sealed class ModuleReferenceNHMap : ClassMapping<ModuleReference>
  {
    internal static ModuleReferenceNHMap TFkCh8bVmUPkMoASMn4P;

    /// <summary>Ctor</summary>
    public ModuleReferenceNHMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_9;
          case 2:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) ModuleReferenceNHMap.r1oVi9bVlcvi8woawKZN(ModuleReferenceNHMap.yU2O37bV96h9qnFFmfSb(__typeref (ModuleReference)), ModuleReferenceNHMap.nxA6d3bVdi3Z1xU0LE2Y(-2107978722 ^ -2108029242));
            // ISSUE: method reference
            Expression<Func<ModuleReference, Guid>> idProperty = Expression.Lambda<Func<ModuleReference, Guid>>((Expression) ModuleReferenceNHMap.G320eXbVrv7GuimdqPFx((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ModuleReference.get_MetadataUid))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IIdMapper> action1 = ModuleReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IIdMapper> idMapper;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ModuleReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_1 = idMapper = (Action<IIdMapper>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      p.Generator((IGeneratorDef) ModuleReferenceNHMap.\u003C\u003Ec.aOmTERCPHgdmpQGNRpaZ());
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_12;
label_7:
            this.Id<Guid>(idProperty, idMapper);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 3 : 4;
            continue;
label_12:
            idMapper = action1;
            goto label_7;
          case 3:
            // ISSUE: reference to a compiler-generated field
            Action<ICacheMapper> action2 = ModuleReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_3;
            Action<ICacheMapper> cacheMapping;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ModuleReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_3 = cacheMapping = (Action<ICacheMapper>) (c =>
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
                      ModuleReferenceNHMap.\u003C\u003Ec.yhvEoPCPAHvrnBj8Z2gk((object) c, (object) CacheUsage.ReadWrite);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_13;
label_11:
            this.Cache(cacheMapping);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
label_13:
            cacheMapping = action2;
            goto label_11;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) ModuleReferenceNHMap.r1oVi9bVlcvi8woawKZN(ModuleReferenceNHMap.yU2O37bV96h9qnFFmfSb(__typeref (ModuleReference)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319471844));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<ModuleReference, Guid>>((Expression) ModuleReferenceNHMap.G320eXbVrv7GuimdqPFx((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ModuleReference.get_ModuleUid))), parameterExpression2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 3;
            continue;
          default:
            ModuleReferenceNHMap.WUuvPUbVJUuGu0JIRZrb((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1114011113));
            num1 = 2;
            continue;
        }
      }
label_9:;
    }

    internal static void WUuvPUbVJUuGu0JIRZrb([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<ModuleReference>) obj0).Table((string) obj1));

    internal static Type yU2O37bV96h9qnFFmfSb([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object nxA6d3bVdi3Z1xU0LE2Y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object r1oVi9bVlcvi8woawKZN([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object G320eXbVrv7GuimdqPFx([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool l3dqd6bVy6QXDDF2ehcO() => ModuleReferenceNHMap.TFkCh8bVmUPkMoASMn4P == null;

    internal static ModuleReferenceNHMap rkB4PJbVM4eei59y5iGm() => ModuleReferenceNHMap.TFkCh8bVmUPkMoASMn4P;
  }
}
