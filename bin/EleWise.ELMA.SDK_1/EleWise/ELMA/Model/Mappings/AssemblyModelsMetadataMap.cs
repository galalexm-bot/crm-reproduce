// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.AssemblyModelsMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  public class AssemblyModelsMetadataMap : ClassMapping<AssemblyModelsMetadata>
  {
    internal static AssemblyModelsMetadataMap yArMTNhhVvoJoMeGJDoY;

    public AssemblyModelsMetadataMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) AssemblyModelsMetadataMap.HS0DoohhX7XNEKEXjAgN(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), AssemblyModelsMetadataMap.eVcOevhhRs5mmyUabyjj(825385222 ^ 825404382));
            // ISSUE: method reference
            Expression<Func<AssemblyModelsMetadata, MemoryStream>> property1 = Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression) AssemblyModelsMetadataMap.uC2jklhhkhtVWNN61rxh((object) parameterExpression1, (object) (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_DocumentationRawStream))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_13;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_13 = mapping1 = (Action<IPropertyMapper>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.wvkFLTCgWIBi7UqXsLJh((object) p, int.MaxValue);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object) null);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 3;
                      continue;
                    case 3:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.KUMAXjCgoXU1IH2I5bId((object) p, AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(-105199646 ^ -105154868));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 1;
                      continue;
                  }
                }
label_2:;
              });
            }
            else
              goto label_4;
label_20:
            this.Property<MemoryStream>(property1, mapping1);
            num1 = 4;
            continue;
label_4:
            mapping1 = action1;
            goto label_20;
          case 2:
            ParameterExpression parameterExpression2;
            // ISSUE: method reference
            this.Property<MemoryStream>(Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression) AssemblyModelsMetadataMap.uC2jklhhkhtVWNN61rxh((object) parameterExpression2, (object) (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_DebugRawStream))), parameterExpression2), (Action<IPropertyMapper>) (p =>
            {
              int num3 = 2;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    AssemblyModelsMetadataMap.\u003C\u003Ec.KUMAXjCgoXU1IH2I5bId((object) p, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413648645));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    AssemblyModelsMetadataMap.\u003C\u003Ec.wvkFLTCgWIBi7UqXsLJh((object) p, int.MaxValue);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
                    continue;
                  case 3:
                    goto label_2;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    AssemblyModelsMetadataMap.\u003C\u003Ec.AdVPuLCgbxrZy7cYf9xy((object) p, NHProviderDependentUserTypes.Get<StreamNHType>(), (object) null);
                    num3 = 3;
                    continue;
                }
              }
label_2:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
          case 3:
            AssemblyModelsMetadataMap.NN2bNQhhq5lTZaXJhdOm((object) this, AssemblyModelsMetadataMap.eVcOevhhRs5mmyUabyjj(-649342099 - -1150814748 ^ 501378387));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 6 : 8;
            continue;
          case 4:
            goto label_18;
          case 5:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) AssemblyModelsMetadataMap.HS0DoohhX7XNEKEXjAgN(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), AssemblyModelsMetadataMap.eVcOevhhRs5mmyUabyjj(-710283084 ^ -537863435 ^ 173662361));
            // ISSUE: method reference
            this.Property<AssemblyModelsMetadataStatus>(Expression.Lambda<Func<AssemblyModelsMetadata, AssemblyModelsMetadataStatus>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_Status))), parameterExpression3), (Action<IPropertyMapper>) (p =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Column((Action<IColumnMapper>) (c =>
                    {
                      int num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 0:
                            goto label_2;
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            c.SqlType((string) AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(-2138160520 ^ -2138256050));
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_4;
                        }
                      }
label_2:
                      return;
label_4:;
                    }));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 7;
            continue;
          case 6:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = Expression.Parameter(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757118438));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<AssemblyModelsMetadata, string>>((Expression) AssemblyModelsMetadataMap.uC2jklhhkhtVWNN61rxh((object) parameterExpression4, (object) (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_Name))), parameterExpression4), (Action<IPropertyMapper>) (p =>
            {
              int num7 = 2;
              while (true)
              {
                switch (num7)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487278026));
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    AssemblyModelsMetadataMap.\u003C\u003Ec.wvkFLTCgWIBi7UqXsLJh((object) p, int.MaxValue);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_2:
              return;
label_5:;
            }));
            num1 = 5;
            continue;
          case 7:
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) AssemblyModelsMetadataMap.HS0DoohhX7XNEKEXjAgN(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439563502));
            // ISSUE: method reference
            Expression<Func<AssemblyModelsMetadata, MemoryStream>> property2 = Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression) AssemblyModelsMetadataMap.uC2jklhhkhtVWNN61rxh((object) parameterExpression5, (object) (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_MetadataStream))), parameterExpression5);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_7;
            Action<IPropertyMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_7 = mapping2 = (Action<IPropertyMapper>) (p =>
              {
                int num8 = 3;
                while (true)
                {
                  switch (num8)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object) null);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.KUMAXjCgoXU1IH2I5bId((object) p, AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(-281842504 ^ -281814406));
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
                      continue;
                    case 3:
                      p.Length(int.MaxValue);
                      num8 = 2;
                      continue;
                    default:
                      goto label_6;
                  }
                }
label_2:
                return;
label_6:;
              });
            }
            else
              goto label_21;
label_11:
            this.Property<MemoryStream>(property2, mapping2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
label_21:
            mapping2 = action2;
            goto label_11;
          case 8:
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) AssemblyModelsMetadataMap.HS0DoohhX7XNEKEXjAgN(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), AssemblyModelsMetadataMap.eVcOevhhRs5mmyUabyjj(~-306453669 ^ 306501244));
            // ISSUE: method reference
            Expression<Func<AssemblyModelsMetadata, long>> idProperty = Expression.Lambda<Func<AssemblyModelsMetadata, long>>((Expression) AssemblyModelsMetadataMap.uC2jklhhkhtVWNN61rxh((object) parameterExpression6, (object) (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_Id))), parameterExpression6);
            // ISSUE: reference to a compiler-generated field
            Action<IIdMapper> action3 = AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IIdMapper> idMapper;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1 = idMapper = (Action<IIdMapper>) (p =>
              {
                int num9 = 1;
                while (true)
                {
                  switch (num9)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.fVV3NlCgB29Wecfml8Id((object) p, AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(1319452732 ^ 1319432422), AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(-1886646897 ^ -1886614319));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
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
              goto label_22;
label_6:
            this.Id<long>(idProperty, idMapper);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 6;
            continue;
label_22:
            idMapper = action3;
            goto label_6;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) AssemblyModelsMetadataMap.HS0DoohhX7XNEKEXjAgN(AssemblyModelsMetadataMap.K1KKtrhhKdcRlH9ltqc7(__typeref (AssemblyModelsMetadata)), AssemblyModelsMetadataMap.eVcOevhhRs5mmyUabyjj(-787452571 ^ -787437635));
            // ISSUE: method reference
            Expression<Func<AssemblyModelsMetadata, MemoryStream>> property3 = Expression.Lambda<Func<AssemblyModelsMetadata, MemoryStream>>((Expression) Expression.Property((Expression) parameterExpression7, (MethodInfo) AssemblyModelsMetadataMap.KuuJFmhhTCgXZFDdfbqs(__methodref (AssemblyModelsMetadata.get_AssemblyRawStream))), parameterExpression7);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action4 = AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_9;
            Action<IPropertyMapper> mapping3;
            if (action4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyModelsMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_9 = mapping3 = (Action<IPropertyMapper>) (p =>
              {
                int num10 = 3;
                while (true)
                {
                  switch (num10)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Type(NHProviderDependentUserTypes.Get<StreamNHType>(), (object) null);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.KUMAXjCgoXU1IH2I5bId((object) p, AssemblyModelsMetadataMap.\u003C\u003Ec.fjblpyCgFlyHjdFuCmTP(-1886646897 ^ -1886536561));
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
                      continue;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      AssemblyModelsMetadataMap.\u003C\u003Ec.wvkFLTCgWIBi7UqXsLJh((object) p, int.MaxValue);
                      num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 0;
                      continue;
                    default:
                      goto label_6;
                  }
                }
label_2:
                return;
label_6:;
              });
            }
            else
              goto label_13;
label_15:
            this.Property<MemoryStream>(property3, mapping3);
            num1 = 2;
            continue;
label_13:
            mapping3 = action4;
            goto label_15;
        }
      }
label_18:;
    }

    internal static object eVcOevhhRs5mmyUabyjj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void NN2bNQhhq5lTZaXJhdOm([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<AssemblyModelsMetadata>) obj0).Table((string) obj1));

    internal static Type K1KKtrhhKdcRlH9ltqc7([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object HS0DoohhX7XNEKEXjAgN([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object KuuJFmhhTCgXZFDdfbqs([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object uC2jklhhkhtVWNN61rxh([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool iiYcIFhhSWSkdvKse3Zh() => AssemblyModelsMetadataMap.yArMTNhhVvoJoMeGJDoY == null;

    internal static AssemblyModelsMetadataMap cSlpwEhhi54gvGChMYjZ() => AssemblyModelsMetadataMap.yArMTNhhVvoJoMeGJDoY;
  }
}
