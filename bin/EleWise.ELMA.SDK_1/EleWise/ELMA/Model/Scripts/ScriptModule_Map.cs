// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptModule_Map
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  internal class ScriptModule_Map : ClassMapping<ScriptModule>
  {
    internal static ScriptModule_Map nrshfpbqexNO9eS52XXg;

    public ScriptModule_Map()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (string) ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-1120607109 - 305487170 ^ -1426108959));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression1, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ScriptMetodsList))), parameterExpression1), (Action<IPropertyMapper>) (p =>
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
                    ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-2107978722 ^ -2108029242));
            // ISSUE: method reference
            Expression<Func<ScriptModule, System.Collections.Generic.List<ScriptMethodDeclaration>>> property1 = Expression.Lambda<Func<ScriptModule, System.Collections.Generic.List<ScriptMethodDeclaration>>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_ScriptMethods))), parameterExpression2);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_26;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_26 = mapping1 = (Action<IPropertyMapper>) (m => m.Type<ScriptMethodDeclarationNHType>());
            }
            else
              goto label_20;
label_30:
            this.Property<System.Collections.Generic.List<ScriptMethodDeclaration>>(property1, mapping1);
            num1 = 10;
            continue;
label_20:
            mapping1 = action1;
            goto label_30;
          case 3:
            ScriptModule_Map.r2yxM8bq3mFLfEp0Y1Av((object) this, ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(1051802738 - -1831968059 ^ -1411240131));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 21 : 19;
            continue;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099733105));
            // ISSUE: method reference
            Expression<Func<ScriptModule, RootCodeItemCollection>> property2 = Expression.Lambda<Func<ScriptModule, RootCodeItemCollection>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_CodeItems))), parameterExpression3);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_24;
            Action<IPropertyMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_24 = mapping2 = (Action<IPropertyMapper>) (m => m.Type<RootCodeItemCollectionNH>());
            }
            else
              goto label_46;
label_27:
            this.Property<RootCodeItemCollection>(property2, mapping2);
            num1 = 2;
            continue;
label_46:
            mapping2 = action2;
            goto label_27;
          case 5:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(1461825605 - 1531863589 ^ -70023944));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ElmaReferences))), parameterExpression4), (Action<IPropertyMapper>) (p =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    p.Length(int.MaxValue);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  default:
                    // ISSUE: type reference
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ScriptModule_Map.\u003C\u003Ec.Dhh7jOCNImjhH2JbgdHV((object) p, ScriptModule_Map.\u003C\u003Ec.oDZApZCNuYRCisQrukCN(__typeref (ScriptModule_Map.ElmaReferences_Acessor)));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
                    continue;
                }
              }
label_2:;
            }));
            num2 = 16;
            break;
          case 6:
            ParameterExpression parameterExpression5 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(typeof (ScriptModule), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-542721635 ^ -542739643));
            // ISSUE: method reference
            this.Property<System.Collections.Generic.List<AssemblyReference>>(Expression.Lambda<Func<ScriptModule, System.Collections.Generic.List<AssemblyReference>>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression5, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_LocalReferences))), parameterExpression5), (Action<IPropertyMapper>) (m => m.Type<AssemblyReferenceNHType>()));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 20 : 1;
            continue;
          case 7:
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837648733));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_SourceCode))), parameterExpression6), (Action<IPropertyMapper>) (p =>
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
                    ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
            continue;
          case 8:
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-812025778 ^ -812010858));
            // ISSUE: method reference
            this.ManyToOne<ScriptModule>(Expression.Lambda<Func<ScriptModule, ScriptModule>>((Expression) Expression.Property((Expression) parameterExpression7, (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_Draft))), parameterExpression7));
            num1 = 19;
            continue;
          case 9:
            // ISSUE: type reference
            ParameterExpression parameterExpression8 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(1242972401 >> 4 ^ 77704919));
            // ISSUE: method reference
            this.Property<object>(Expression.Lambda<Func<ScriptModule, object>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression8, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_Dependencies))), parameterExpression8), (Action<IPropertyMapper>) (m => m.Type<XmlObjectSerializableType>()));
            num1 = 8;
            continue;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression9 = Expression.Parameter(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (string) ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(95909607 + 343705423 ^ 439563502));
            // ISSUE: method reference
            Expression<Func<ScriptModule, string>> property3 = Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression9, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_AssemblyName))), parameterExpression9);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action3 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_28;
            Action<IPropertyMapper> mapping3;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_28 = mapping3 = (Action<IPropertyMapper>) (p =>
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
                      ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
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
label_33:
            this.Property<string>(property3, mapping3);
            num1 = 17;
            continue;
label_47:
            mapping3 = action3;
            goto label_33;
          case 11:
            ParameterExpression parameterExpression10 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(typeof (ScriptModule), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867250355));
            // ISSUE: method reference
            this.Property<byte[]>(Expression.Lambda<Func<ScriptModule, byte[]>>((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_AssemblyRaw))), parameterExpression10), (Action<IPropertyMapper>) (m => m.Type<FixedBinaryUserType>()));
            num1 = 12;
            continue;
          case 12:
            ParameterExpression parameterExpression11 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(typeof (ScriptModule), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606602300));
            // ISSUE: method reference
            Expression<Func<ScriptModule, byte[]>> property4 = Expression.Lambda<Func<ScriptModule, byte[]>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression11, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_DebugRaw))), parameterExpression11);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action4 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_36;
            Action<IPropertyMapper> mapping4;
            if (action4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_36 = mapping4 = (Action<IPropertyMapper>) (m => m.Type<FixedBinaryUserType>());
            }
            else
              goto label_48;
label_44:
            this.Property<byte[]>(property4, mapping4);
            num1 = 9;
            continue;
label_48:
            mapping4 = action4;
            goto label_44;
          case 13:
            // ISSUE: type reference
            ParameterExpression parameterExpression12 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(92412609 - 1050237057 ^ -957871976));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression12, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ModuleTypeUid))), parameterExpression12));
            num1 = 22;
            continue;
          case 14:
            ParameterExpression parameterExpression13 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(typeof (ScriptModule), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-688192331 - 435440695 ^ -1123650906));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression13, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_Uid))), parameterExpression13));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 13 : 2;
            continue;
          case 15:
            // ISSUE: type reference
            ParameterExpression parameterExpression14 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(1113862659 ^ 1113913563));
            // ISSUE: method reference
            Expression<Func<ScriptModule, string>> property5 = Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression14, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_References))), parameterExpression14);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action5 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_14;
            Action<IPropertyMapper> mapping5;
            if (action5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_14 = mapping5 = (Action<IPropertyMapper>) (p =>
              {
                int num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: type reference
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ScriptModule_Map.\u003C\u003Ec.Dhh7jOCNImjhH2JbgdHV((object) p, ScriptModule_Map.\u003C\u003Ec.oDZApZCNuYRCisQrukCN(__typeref (ScriptModule_Map.References_Acessor)));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 2;
                      continue;
                  }
                }
label_2:;
              });
            }
            else
              goto label_49;
label_17:
            this.Property<string>(property5, mapping5);
            num1 = 5;
            continue;
label_49:
            mapping5 = action5;
            goto label_17;
          case 16:
            // ISSUE: type reference
            ParameterExpression parameterExpression15 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-675505729 ^ -675523737));
            // ISSUE: method reference
            Expression<Func<ScriptModule, System.Collections.Generic.List<ScriptWebReference>>> property6 = Expression.Lambda<Func<ScriptModule, System.Collections.Generic.List<ScriptWebReference>>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression15, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_WebReferences))), parameterExpression15);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action6 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_18;
            Action<IPropertyMapper> mapping6;
            if (action6 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_18 = mapping6 = (Action<IPropertyMapper>) (m => m.Type<ScriptWebReferencesNHType>());
            }
            else
              goto label_50;
label_22:
            this.Property<System.Collections.Generic.List<ScriptWebReference>>(property6, mapping6);
            num1 = 6;
            continue;
label_50:
            mapping6 = action6;
            goto label_22;
          case 17:
            // ISSUE: type reference
            ParameterExpression parameterExpression16 = Expression.Parameter(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (string) ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(1051802738 - -1831968059 ^ -1411247243));
            // ISSUE: method reference
            Expression<Func<ScriptModule, string>> property7 = Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression16, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ScriptModule.get_Namespace))), parameterExpression16);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action7 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_30;
            Action<IPropertyMapper> mapping7;
            if (action7 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_30 = mapping7 = (Action<IPropertyMapper>) (p =>
              {
                int num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
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
              goto label_51;
label_36:
            this.Property<string>(property7, mapping7);
            num1 = 18;
            continue;
label_51:
            mapping7 = action7;
            goto label_36;
          case 18:
            ParameterExpression parameterExpression17 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(typeof (ScriptModule), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825404382));
            // ISSUE: method reference
            Expression<Func<ScriptModule, string>> property8 = Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression17, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ClassName))), parameterExpression17);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action8 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_32;
            Action<IPropertyMapper> mapping8;
            if (action8 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_32 = mapping8 = (Action<IPropertyMapper>) (p =>
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
                      ScriptModule_Map.\u003C\u003Ec.dRGIFBCNZ5lf7S77bm8C((object) p, int.MaxValue);
                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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
              goto label_52;
label_39:
            this.Property<string>(property8, mapping8);
            num1 = 11;
            continue;
label_52:
            mapping8 = action8;
            goto label_39;
          case 19:
            goto label_42;
          case 20:
            ParameterExpression parameterExpression18;
            // ISSUE: method reference
            this.Property<System.Collections.Generic.List<AssemblyReference>>(Expression.Lambda<Func<ScriptModule, System.Collections.Generic.List<AssemblyReference>>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression18, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_GlobalScriptModules))), parameterExpression18), (Action<IPropertyMapper>) (m => m.Type<AssemblyReferenceNHType>()));
            num1 = 4;
            continue;
          case 21:
            // ISSUE: type reference
            ParameterExpression parameterExpression19 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(132912447 ^ 132964327));
            // ISSUE: method reference
            // ISSUE: type reference
            this.Id<long>(Expression.Lambda<Func<ScriptModule, long>>((Expression) Expression.Property((Expression) parameterExpression19, (MethodInfo) ScriptModule_Map.L7VMVtbqDPabDNDt7fZN(__methodref (Entity<long>.get_Id), __typeref (Entity<long>))), parameterExpression19), (Action<IIdMapper>) (p =>
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
                    ScriptModule_Map.\u003C\u003Ec.YTdj95CN8G6rhWPIZ4yP((object) p, ScriptModule_Map.\u003C\u003Ec.C9Z1JgCNvtPIjTooE6iO(-812025778 ^ -812020002), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538551992));
                    num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 13 : 14;
            continue;
          case 22:
            // ISSUE: type reference
            ParameterExpression parameterExpression20 = Expression.Parameter(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477124862));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<ScriptModule, Guid>>((Expression) Expression.Property((Expression) parameterExpression20, (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ObjectUid))), parameterExpression20));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 21 : 23;
            continue;
          case 23:
            // ISSUE: type reference
            ParameterExpression parameterExpression21 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459609095));
            // ISSUE: method reference
            Expression<Func<ScriptModule, string>> property9 = Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression21, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_ModuleName))), parameterExpression21);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action9 = ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_6;
            Action<IPropertyMapper> mapping9;
            if (action9 == null)
            {
              // ISSUE: reference to a compiler-generated field
              ScriptModule_Map.\u003C\u003Ec.\u003C\u003E9__0_6 = mapping9 = (Action<IPropertyMapper>) (p =>
              {
                int num11 = 1;
                while (true)
                {
                  switch (num11)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Length(int.MaxValue);
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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
              goto label_53;
label_11:
            this.Property<string>(property9, mapping9);
            num1 = 7;
            continue;
label_53:
            mapping9 = action9;
            goto label_11;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression22 = (ParameterExpression) ScriptModule_Map.zx7IgLbqabxmG3xBTd6C(ScriptModule_Map.wOgtIobqpiTqDgfkaxP2(__typeref (ScriptModule)), ScriptModule_Map.jfAnZ7bqNaMCC6sqg9Jb(-867826612 ^ -867774828));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<ScriptModule, string>>((Expression) ScriptModule_Map.smPd3mbqwG14oflpGnbH((object) parameterExpression22, (object) (MethodInfo) ScriptModule_Map.coSTalbqtsBZ8afVpKgY(__methodref (ScriptModule.get_CompiledFileName))), parameterExpression22), (Action<IPropertyMapper>) (p =>
            {
              int num12 = 1;
              while (true)
              {
                switch (num12)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Length(int.MaxValue);
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num2 = 15;
            break;
        }
        num1 = num2;
      }
label_42:;
    }

    internal static object jfAnZ7bqNaMCC6sqg9Jb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void r2yxM8bq3mFLfEp0Y1Av([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<ScriptModule>) obj0).Table((string) obj1));

    internal static Type wOgtIobqpiTqDgfkaxP2([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object zx7IgLbqabxmG3xBTd6C([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object L7VMVtbqDPabDNDt7fZN([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object coSTalbqtsBZ8afVpKgY([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object smPd3mbqwG14oflpGnbH([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool ecXh1UbqPmuj9TnjSkP9() => ScriptModule_Map.nrshfpbqexNO9eS52XXg == null;

    internal static ScriptModule_Map zsrA3Obq1x4XQAADH1nH() => ScriptModule_Map.nrshfpbqexNO9eS52XXg;

    private sealed class References_Acessor : IPropertyAccessor
    {
      private static object uxv823CNFqqeGXRxHp7x;

      public bool CanAccessThroughReflectionOptimizer => false;

      public IGetter GetGetter(Type theClass, string propertyName) => (IGetter) new ScriptModule_Map.References_Acessor.Getter();

      public ISetter GetSetter(Type theClass, string propertyName) => (ISetter) new ScriptModule_Map.References_Acessor.Setter();

      public References_Acessor()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool BZRMNhCNBsJehaZNZbXY() => ScriptModule_Map.References_Acessor.uxv823CNFqqeGXRxHp7x == null;

      internal static ScriptModule_Map.References_Acessor XnjjniCNW0YWiQKJ7VuR() => (ScriptModule_Map.References_Acessor) ScriptModule_Map.References_Acessor.uxv823CNFqqeGXRxHp7x;

      [Serializable]
      private sealed class Getter : IGetter
      {
        private static object Cm2rJFZV9U2g6TWwDKUe;

        public Type ReturnType => TypeOf<string>.Raw;

        public string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672092782);

        public MethodInfo Method => (MethodInfo) null;

        public object Get(object target) => ScriptModule_Map.References_Acessor.Getter.fQXNJhZVrOqcUfFs2FYI((object) (ScriptModule) target);

        public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => this.Get(owner);

        public Getter()
        {
          ScriptModule_Map.References_Acessor.Getter.gAF5H4ZVgAPe0h0KiwtD();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool JI2rp9ZVdHBeoruKosEl() => ScriptModule_Map.References_Acessor.Getter.Cm2rJFZV9U2g6TWwDKUe == null;

        internal static ScriptModule_Map.References_Acessor.Getter nUQO5jZVlNGIQsYna9SX() => (ScriptModule_Map.References_Acessor.Getter) ScriptModule_Map.References_Acessor.Getter.Cm2rJFZV9U2g6TWwDKUe;

        internal static object fQXNJhZVrOqcUfFs2FYI([In] object obj0) => (object) ((ScriptModule) obj0).References;

        internal static void gAF5H4ZVgAPe0h0KiwtD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }

      [Serializable]
      private sealed class Setter : ISetter
      {
        internal static object MF7KRSZV5aSg5qClDOGi;

        public string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392354);

        public MethodInfo Method => (MethodInfo) null;

        public void Set(object target, object value)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ScriptModule scriptModule = (ScriptModule) target;
                string str = (string) value;
                object obj = str != null ? ScriptModule_Map.References_Acessor.Setter.QfYTVYZVUxWrp2e37ga6((object) str, ScriptModule_Map.References_Acessor.Setter.wq7pnNZVLkgckQafkVEa(-53329496 >> 4 ^ -3470916), (object) "") : (object) null;
                ScriptModule_Map.References_Acessor.Setter.OZBal7ZVstRu6tW4ljUj((object) scriptModule, obj);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }

        public Setter()
        {
          ScriptModule_Map.References_Acessor.Setter.NDY1YMZVcyJc6gJlnpba();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool FE9u9aZVjrR56uQETvqk() => ScriptModule_Map.References_Acessor.Setter.MF7KRSZV5aSg5qClDOGi == null;

        internal static ScriptModule_Map.References_Acessor.Setter P2thJ5ZVYxGhfrBj05vN() => (ScriptModule_Map.References_Acessor.Setter) ScriptModule_Map.References_Acessor.Setter.MF7KRSZV5aSg5qClDOGi;

        internal static object wq7pnNZVLkgckQafkVEa(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object QfYTVYZVUxWrp2e37ga6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

        internal static void OZBal7ZVstRu6tW4ljUj([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).References = (string) obj1;

        internal static void NDY1YMZVcyJc6gJlnpba() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }
    }

    private sealed class ElmaReferences_Acessor : IPropertyAccessor
    {
      internal static object P1e5R2CNo5vbBtKdWTAJ;

      public bool CanAccessThroughReflectionOptimizer => false;

      public IGetter GetGetter(Type theClass, string propertyName) => (IGetter) new ScriptModule_Map.ElmaReferences_Acessor.Getter();

      public ISetter GetSetter(Type theClass, string propertyName) => (ISetter) new ScriptModule_Map.ElmaReferences_Acessor.Setter();

      public ElmaReferences_Acessor()
      {
        ScriptModule_Map.ElmaReferences_Acessor.sohh98CNGpjXXW5E53JO();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void sohh98CNGpjXXW5E53JO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool DKeE8FCNbj9j2kL5VyuJ() => ScriptModule_Map.ElmaReferences_Acessor.P1e5R2CNo5vbBtKdWTAJ == null;

      internal static ScriptModule_Map.ElmaReferences_Acessor kaXyoECNhlmPH5maqo9i() => (ScriptModule_Map.ElmaReferences_Acessor) ScriptModule_Map.ElmaReferences_Acessor.P1e5R2CNo5vbBtKdWTAJ;

      [Serializable]
      private sealed class Getter : IGetter
      {
        private static object sLuJlmZVzX59L2OtJwnh;

        public Type ReturnType => TypeOf<string>.Raw;

        public string PropertyName => (string) ScriptModule_Map.ElmaReferences_Acessor.Getter.QFPLDvZSWQ650WvVTp0y(-542721635 ^ -542703357);

        public MethodInfo Method => (MethodInfo) null;

        public object Get(object target) => (object) ((ScriptModule) target).ElmaReferences;

        public object GetForInsert(object owner, IDictionary mergeMap, ISessionImplementor session) => this.Get(owner);

        public Getter()
        {
          ScriptModule_Map.ElmaReferences_Acessor.Getter.ARtBv9ZSoLZQRpEO0uVT();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object QFPLDvZSWQ650WvVTp0y(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool cPM7rHZSFRwGpFj5b43G() => ScriptModule_Map.ElmaReferences_Acessor.Getter.sLuJlmZVzX59L2OtJwnh == null;

        internal static ScriptModule_Map.ElmaReferences_Acessor.Getter k6AxXJZSBlD16mtM0oHS() => (ScriptModule_Map.ElmaReferences_Acessor.Getter) ScriptModule_Map.ElmaReferences_Acessor.Getter.sLuJlmZVzX59L2OtJwnh;

        internal static void ARtBv9ZSoLZQRpEO0uVT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }

      [Serializable]
      private sealed class Setter : ISetter
      {
        internal static object UoT9TMZSbwjeR1TElPGY;

        public string PropertyName => (string) ScriptModule_Map.ElmaReferences_Acessor.Setter.RblgxvZSEAffq8bZHB30(964881585 - -1459193222 ^ -1870804311);

        public MethodInfo Method => (MethodInfo) null;

        public void Set(object target, object value)
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_4;
              case 1:
                ScriptModule scriptModule = (ScriptModule) target;
                string str1 = (string) value;
                string str2 = str1 == null ? (string) null : str1.Replace((string) ScriptModule_Map.ElmaReferences_Acessor.Setter.RblgxvZSEAffq8bZHB30(-2112703338 ^ -2112579280), "");
                scriptModule.ElmaReferences = str2;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
label_4:
          return;
label_2:;
        }

        public Setter()
        {
          ScriptModule_Map.ElmaReferences_Acessor.Setter.PT045JZSfYt1KVUu0Elw();
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static object RblgxvZSEAffq8bZHB30(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static bool ekkHEWZShfap7GTDn7VK() => ScriptModule_Map.ElmaReferences_Acessor.Setter.UoT9TMZSbwjeR1TElPGY == null;

        internal static ScriptModule_Map.ElmaReferences_Acessor.Setter gVXa4ZZSGC0eKSXm4osG() => (ScriptModule_Map.ElmaReferences_Acessor.Setter) ScriptModule_Map.ElmaReferences_Acessor.Setter.UoT9TMZSbwjeR1TElPGY;

        internal static void PT045JZSfYt1KVUu0Elw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      }
    }
  }
}
