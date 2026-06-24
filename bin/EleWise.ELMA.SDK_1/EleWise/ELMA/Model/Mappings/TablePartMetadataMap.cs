// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.TablePartMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Маппинг NHibernate для TablePartMetadata</summary>
  public class TablePartMetadataMap : JoinedSubclassMapping<TablePartMetadata>
  {
    internal static TablePartMetadataMap TfWoFohbXHFrTePccPQK;

    /// <summary>Ctor</summary>
    public TablePartMetadataMap()
    {
      TablePartMetadataMap.Ke3ikEhbnp6P0OeKkGBl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.Table(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289701518));
            num1 = 7;
            continue;
          case 2:
            goto label_15;
          case 3:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(TablePartMetadataMap.eByR8uhb2JqGpXQ11Xl6(__typeref (TablePartMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323069674));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>((Expression) TablePartMetadataMap.r3KiEHhbNpXtWj7vZvRO((object) parameterExpression1, (object) (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_Input))), parameterExpression1));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(TablePartMetadataMap.eByR8uhb2JqGpXQ11Xl6(__typeref (TablePartMetadata)), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(372753449 ^ 372707057));
            // ISSUE: method reference
            this.ManyToOne<EntityMetadata>(Expression.Lambda<Func<TablePartMetadata, EntityMetadata>>((Expression) TablePartMetadataMap.r3KiEHhbNpXtWj7vZvRO((object) parameterExpression2, (object) (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_TablePartOwner))), parameterExpression2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 5 : 1;
            continue;
          case 5:
            ParameterExpression parameterExpression3 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(typeof (TablePartMetadata), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(~541731958 ^ -541779631));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<TablePartMetadata, Guid>>((Expression) TablePartMetadataMap.r3KiEHhbNpXtWj7vZvRO((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (TablePartMetadata.get_TablePartPropertyUid))), parameterExpression3));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 9;
            continue;
          case 6:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(TablePartMetadataMap.eByR8uhb2JqGpXQ11Xl6(__typeref (TablePartMetadata)), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(-649342099 - -1150814748 ^ 501421905));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_Required))), parameterExpression4));
            num1 = 3;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            Action<IKeyMapper<TablePartMetadata>> action1 = TablePartMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_0;
            Action<IKeyMapper<TablePartMetadata>> keyMapping;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              TablePartMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_0 = keyMapping = (Action<IKeyMapper<TablePartMetadata>>) (k => k.Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173648671)));
            }
            else
              goto label_19;
label_13:
            this.Key(keyMapping);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 11 : 9;
            continue;
label_19:
            keyMapping = action1;
            goto label_13;
          case 8:
            ParameterExpression parameterExpression5 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(typeof (TablePartMetadata), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(-2138160520 ^ -2138142560));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<TablePartMetadata, string>>((Expression) TablePartMetadataMap.r3KiEHhbNpXtWj7vZvRO((object) parameterExpression5, (object) (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_OnChangeScriptName))), parameterExpression5), (Action<IPropertyMapper>) (p =>
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
                    TablePartMetadataMap.\u003C\u003Ec.qw9gqVClxMAJ2MFh13r0((object) p, int.MaxValue);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 2;
            continue;
          case 9:
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(TablePartMetadataMap.eByR8uhb2JqGpXQ11Xl6(__typeref (TablePartMetadata)), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(-1088304168 ^ -1088356096));
            // ISSUE: method reference
            Expression<Func<TablePartMetadata, string>> property = Expression.Lambda<Func<TablePartMetadata, string>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_TablePartPropertyName))), parameterExpression6);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = TablePartMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_4;
            Action<IPropertyMapper> mapping;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              TablePartMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_4 = mapping = (Action<IPropertyMapper>) (p =>
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
                      TablePartMetadataMap.\u003C\u003Ec.qw9gqVClxMAJ2MFh13r0((object) p, int.MaxValue);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
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
              goto label_20;
label_17:
            this.Property<string>(property, mapping);
            num1 = 10;
            continue;
label_20:
            mapping = action2;
            goto label_17;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(TablePartMetadataMap.eByR8uhb2JqGpXQ11Xl6(__typeref (TablePartMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309621404));
            // ISSUE: method reference
            this.Property<int>(Expression.Lambda<Func<TablePartMetadata, int>>((Expression) Expression.Property((Expression) parameterExpression7, (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_Order))), parameterExpression7));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 6 : 2;
            continue;
          case 11:
            TablePartMetadataMap.vKSIDGhbOfTsmwQXriHD((object) this, false);
            num1 = 4;
            continue;
          default:
            ParameterExpression parameterExpression8 = (ParameterExpression) TablePartMetadataMap.owZMENhbPjFMSd21MZHp(typeof (TablePartMetadata), TablePartMetadataMap.X76q0Mhbe8DIYQC03KCe(~-306453669 ^ 306501244));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<TablePartMetadata, bool>>((Expression) TablePartMetadataMap.r3KiEHhbNpXtWj7vZvRO((object) parameterExpression8, (object) (MethodInfo) TablePartMetadataMap.CV3lh2hb14gjc7s2i3QC(__methodref (TablePartMetadata.get_Output))), parameterExpression8));
            num1 = 8;
            continue;
        }
      }
label_15:;
    }

    internal static void Ke3ikEhbnp6P0OeKkGBl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void vKSIDGhbOfTsmwQXriHD([In] object obj0, [In] bool obj1) => __nonvirtual (((JoinedSubclassCustomizer<TablePartMetadata>) obj0).Lazy(obj1));

    internal static Type eByR8uhb2JqGpXQ11Xl6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object X76q0Mhbe8DIYQC03KCe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object owZMENhbPjFMSd21MZHp([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object CV3lh2hb14gjc7s2i3QC([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object r3KiEHhbNpXtWj7vZvRO([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool KVLIsUhbTmLfX7bZnVAn() => TablePartMetadataMap.TfWoFohbXHFrTePccPQK == null;

    internal static TablePartMetadataMap eeY3X1hbk3lwRF1SaxIx() => TablePartMetadataMap.TfWoFohbXHFrTePccPQK;
  }
}
