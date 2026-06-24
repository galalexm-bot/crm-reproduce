// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.EntityPropertyMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  public class EntityPropertyMetadataMap : NamedMetadataMap<EntityPropertyMetadata>
  {
    internal static EntityPropertyMetadataMap zRlRtQhb9Funarv0nH6M;

    public EntityPropertyMetadataMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(222162814 ^ 222218990));
      int num1 = 7;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633532275));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_Sortable))), parameterExpression1));
            num1 = 14;
            continue;
          case 2:
            ParameterExpression parameterExpression2 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-488881205 ^ -488863469));
            // ISSUE: method reference
            this.Property<int>(Expression.Lambda<Func<EntityPropertyMetadata, int>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyMetadata.get_TableColumnWidth))), parameterExpression2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 19;
            continue;
          case 3:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = Expression.Parameter(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475908575));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<EntityPropertyMetadata, string>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression3, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_SQLFormula))), parameterExpression3), (Action<IPropertyMapper>) (p =>
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
                    EntityPropertyMetadataMap.\u003C\u003Ec.w6LGaOCre0yvZnERkoxo((object) p, int.MaxValue);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 0;
            continue;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(1021410165 ^ 1021424045));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression4, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_InFastSearch))), parameterExpression4));
            num1 = 21;
            continue;
          case 5:
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(322893104 - -1992822529 ^ -1979199767));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, string>> property1 = Expression.Lambda<Func<EntityPropertyMetadata, string>>((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_CalculateScript))), parameterExpression5);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_13;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_13 = mapping1 = (Action<IPropertyMapper>) (p =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Length(int.MaxValue);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
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
              goto label_44;
label_29:
            this.Property<string>(property1, mapping1);
            num2 = 23;
            break;
label_44:
            mapping1 = action1;
            goto label_29;
          case 6:
            goto label_41;
          case 7:
            ParameterExpression parameterExpression6;
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, EntityMetadata>> property2 = Expression.Lambda<Func<EntityPropertyMetadata, EntityMetadata>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression6, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_Owner))), parameterExpression6);
            // ISSUE: reference to a compiler-generated field
            Action<IManyToOneMapper> action2 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IManyToOneMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1 = mapping2 = (Action<IManyToOneMapper>) (p =>
              {
                int num5 = 1;
                while (true)
                {
                  switch (num5)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      p.Column((string) EntityPropertyMetadataMap.\u003C\u003Ec.YY6ogXCr2VpCppILkm0x(-2099751081 ^ -2099384793));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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
              goto label_45;
label_21:
            this.ManyToOne<EntityMetadata>(property2, mapping2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 4 : 10;
            continue;
label_45:
            mapping2 = action2;
            goto label_21;
          case 8:
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(1319452732 ^ 1319471844));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression7, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityPropertyMetadata.get_Input))), parameterExpression7));
            num1 = 15;
            continue;
          case 9:
            ParameterExpression parameterExpression8 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757118438));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, PropertyViewSettings>> property3 = Expression.Lambda<Func<EntityPropertyMetadata, PropertyViewSettings>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression8, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyMetadata.get_ViewSettings))), parameterExpression8);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action3 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_17;
            Action<IPropertyMapper> mapping3;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_17 = mapping3 = (Action<IPropertyMapper>) (p => p.Type<XmlObjectSerializableType>());
            }
            else
              goto label_46;
label_32:
            this.Property<PropertyViewSettings>(property3, mapping3);
            num1 = 17;
            continue;
label_46:
            mapping3 = action3;
            goto label_32;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression9 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-1998538950 ^ -1998553630));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityPropertyMetadata, Guid>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression9, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_TypeUid))), parameterExpression9));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 22 : 0;
            continue;
          case 11:
            // ISSUE: type reference
            ParameterExpression parameterExpression10 = Expression.Parameter(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479485804));
            // ISSUE: method reference
            this.Property<int>(Expression.Lambda<Func<EntityPropertyMetadata, int>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression10, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_TableNumber))), parameterExpression10));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 23 : 25;
            continue;
          case 12:
            ParameterExpression parameterExpression11 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765804046));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, string>> property4 = Expression.Lambda<Func<EntityPropertyMetadata, string>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression11, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_RelationTableName))), parameterExpression11);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action4 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_33;
            Action<IPropertyMapper> mapping4;
            if (action4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_33 = mapping4 = (Action<IPropertyMapper>) (p =>
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
                      EntityPropertyMetadataMap.\u003C\u003Ec.w6LGaOCre0yvZnERkoxo((object) p, int.MaxValue);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
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
              goto label_47;
label_43:
            this.Property<string>(property4, mapping4);
            num1 = 6;
            continue;
label_47:
            mapping4 = action4;
            goto label_43;
          case 13:
            // ISSUE: type reference
            ParameterExpression parameterExpression12 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-1872275253 >> 6 ^ -29272133));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, string>> property5 = Expression.Lambda<Func<EntityPropertyMetadata, string>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression12, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_OnChangeScriptName))), parameterExpression12);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action5 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_25;
            Action<IPropertyMapper> mapping5;
            if (action5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_25 = mapping5 = (Action<IPropertyMapper>) (p =>
              {
                int num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      EntityPropertyMetadataMap.\u003C\u003Ec.w6LGaOCre0yvZnERkoxo((object) p, int.MaxValue);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
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
              goto label_48;
label_39:
            this.Property<string>(property5, mapping5);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 4 : 4;
            continue;
label_48:
            mapping5 = action5;
            goto label_39;
          case 14:
            // ISSUE: type reference
            ParameterExpression parameterExpression13 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-1204263869 ^ -1341583247 ^ 137477866));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression13, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyMetadata.get_Groupable))), parameterExpression13));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 13 : 0;
            continue;
          case 15:
            ParameterExpression parameterExpression14 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824341691));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression14, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityPropertyMetadata.get_Output))), parameterExpression14));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 5 : 11;
            continue;
          case 16:
            // ISSUE: type reference
            ParameterExpression parameterExpression15 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(1051802738 - -1831968059 ^ -1411247243));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression15, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_Nullable))), parameterExpression15));
            num2 = 24;
            break;
          case 17:
            ParameterExpression parameterExpression16 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(864270449 << 6 ^ -521218408));
            // ISSUE: method reference
            this.Property<int>(Expression.Lambda<Func<EntityPropertyMetadata, int>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression16, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_Order))), parameterExpression16));
            num1 = 2;
            continue;
          case 18:
            // ISSUE: type reference
            ParameterExpression parameterExpression17 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(813604817 ^ 813585673));
            // ISSUE: method reference
            this.Property<TypeSettings>(Expression.Lambda<Func<EntityPropertyMetadata, TypeSettings>>((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_Settings))), parameterExpression17), (Action<IPropertyMapper>) (p => p.Type<TypeSettingsNHType>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 13 : 16;
            continue;
          case 19:
            // ISSUE: type reference
            ParameterExpression parameterExpression18 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(1470998129 - 231418599 ^ 1239593298));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, LineAlignment>> property6 = Expression.Lambda<Func<EntityPropertyMetadata, LineAlignment>>((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyMetadata.get_TableCellAlignment))), parameterExpression18);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action6 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_21;
            Action<IPropertyMapper> mapping6;
            if (action6 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_21 = mapping6 = (Action<IPropertyMapper>) (p =>
              {
                int num9 = 1;
                while (true)
                {
                  switch (num9)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Column((Action<IColumnMapper>) (c =>
                      {
                        int num10 = 1;
                        while (true)
                        {
                          switch (num10)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              EntityPropertyMetadataMap.\u003C\u003Ec.ICO96wCrPGtXm7SsWYyE((object) c, EntityPropertyMetadataMap.\u003C\u003Ec.YY6ogXCr2VpCppILkm0x(-1350312861 << 3 ^ 2082237486));
                              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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
              goto label_49;
label_35:
            this.Property<LineAlignment>(property6, mapping6);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
            continue;
label_49:
            mapping6 = action6;
            goto label_35;
          case 20:
            ParameterExpression parameterExpression19 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867774828));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityPropertyMetadata, Guid>>((Expression) Expression.Property((Expression) parameterExpression19, (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_OwnerPropertyUid))), parameterExpression19));
            num1 = 9;
            continue;
          case 21:
            ParameterExpression parameterExpression20 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-882126494 ^ -882172998));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression20, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_ShowInTable))), parameterExpression20));
            num1 = 8;
            continue;
          case 22:
            // ISSUE: type reference
            ParameterExpression parameterExpression21 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420790786));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityPropertyMetadata, Guid>>((Expression) Expression.Property((Expression) parameterExpression21, (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_SubTypeUid))), parameterExpression21));
            num1 = 18;
            continue;
          case 23:
            // ISSUE: type reference
            ParameterExpression parameterExpression22 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335011625));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression22, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_IsSystem))), parameterExpression22));
            num1 = 20;
            continue;
          case 24:
            ParameterExpression parameterExpression23 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(typeof (EntityPropertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021424045));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression23, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_Required))), parameterExpression23));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 25:
            // ISSUE: type reference
            ParameterExpression parameterExpression24 = (ParameterExpression) EntityPropertyMetadataMap.VFMeJyhbY1OAMDiLdlok(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(-1255365154 ^ 596875508 ^ -1765804046));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityPropertyMetadata, bool>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression24, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (EntityPropertyMetadata.get_Filterable))), parameterExpression24));
            num1 = 12;
            continue;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression25 = Expression.Parameter(EntityPropertyMetadataMap.kILdkHhbjeYJvknulpbs(__typeref (EntityPropertyMetadata)), (string) EntityPropertyMetadataMap.KiGSfXhbrTh7oLU9ymMj(1581325282 << 3 ^ -234351160));
            // ISSUE: method reference
            Expression<Func<EntityPropertyMetadata, PropertyCalculateType>> property7 = Expression.Lambda<Func<EntityPropertyMetadata, PropertyCalculateType>>((Expression) EntityPropertyMetadataMap.QltPQahb5ZgKMofxwkIU((object) parameterExpression25, (object) (MethodInfo) EntityPropertyMetadataMap.f0W9FUhbgbR6hDHsKQeA(__methodref (PropertyMetadata.get_CalculateType))), parameterExpression25);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action7 = EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_9;
            Action<IPropertyMapper> mapping7;
            if (action7 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityPropertyMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_9 = mapping7 = (Action<IPropertyMapper>) (p =>
              {
                int num12 = 1;
                while (true)
                {
                  switch (num12)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Column((Action<IColumnMapper>) (c =>
                      {
                        int num13 = 1;
                        while (true)
                        {
                          switch (num13)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              c.SqlType((string) EntityPropertyMetadataMap.\u003C\u003Ec.YY6ogXCr2VpCppILkm0x(1514961705 ^ 1515123743));
                              num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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
              goto label_37;
label_25:
            this.Property<PropertyCalculateType>(property7, mapping7);
            num1 = 3;
            continue;
label_37:
            mapping7 = action7;
            goto label_25;
        }
        num1 = num2;
      }
label_41:;
    }

    internal static object KiGSfXhbrTh7oLU9ymMj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object f0W9FUhbgbR6hDHsKQeA([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object QltPQahb5ZgKMofxwkIU([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type kILdkHhbjeYJvknulpbs([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object VFMeJyhbY1OAMDiLdlok([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static bool dhOwCYhbdZ9TFPl8ri5o() => EntityPropertyMetadataMap.zRlRtQhb9Funarv0nH6M == null;

    internal static EntityPropertyMetadataMap Lymm5Mhbl3usp2Lxm3OR() => EntityPropertyMetadataMap.zRlRtQhb9Funarv0nH6M;
  }
}
