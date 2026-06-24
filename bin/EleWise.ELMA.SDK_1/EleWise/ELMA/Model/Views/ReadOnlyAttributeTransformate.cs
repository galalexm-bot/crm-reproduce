// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ReadOnlyAttributeTransformate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views.Builders;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>
  /// Обновить значение атрибута "Только для чтения" у всех вложенных элементов в соответствии с глобальным признаком "Только для чтения" у данной формы
  /// </summary>
  [Component(Order = -2147483648)]
  public class ReadOnlyAttributeTransformate : IFormViewItemTransformate
  {
    internal static ReadOnlyAttributeTransformate Vynoj0okbKct9a5pvDNs;

    public FormViewItem Transformate(FormViewItem formViewItem, object model)
    {
      int num1 = 1;
      FormViewItem formViewItem1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (!formViewItem1.IsReadOnly())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
              continue;
            }
            goto label_7;
          default:
            formViewItem1 = formViewItem;
            num1 = 3;
            continue;
        }
      }
label_6:
      return formViewItem1;
label_7:
      return formViewItem1.Transformate((Action<FormViewItemTransformationBuilder<IEntity>>) (t =>
      {
        IEnumerable<PropertyViewItem> source = formViewItem1.GetAllItems().OfType<PropertyViewItem>();
        source.Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p =>
        {
          int num5 = 2;
          bool? nullable;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_5;
              case 2:
                // ISSUE: reference to a compiler-generated method
                object obj = ReadOnlyAttributeTransformate.\u003C\u003Ec.l8UF1mCEtoAJkZcNbS8l((object) p);
                if (obj == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
                  continue;
                }
                nullable = ((ViewAttributes) obj).ReadOnly;
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_4:
          return !nullable.HasValue;
label_5:
          return true;
        })).Each<PropertyViewItem>((Action<PropertyViewItem>) (p =>
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
                ViewItemTransformationBuilder<IEntity, PropertyViewItem> transformationBuilder = t.ForItem<PropertyViewItem>(ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.UbPqExCEOF8qC01NYC59((object) p));
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ParameterExpression parameterExpression = (ParameterExpression) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.GHNFaTCEPZKpFPqnHvXS(ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.blNEnoCE2axkE1vHBPW9(__typeref (PropertyViewItem)), ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.kF3NpDCEeiFIJ2KdVTKv(2008901894 << 3 ^ -1108421998));
                // ISSUE: method reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: method reference
                // ISSUE: reference to a compiler-generated method
                Expression<Func<PropertyViewItem, bool?>> property = Expression.Lambda<Func<PropertyViewItem, bool?>>((Expression) Expression.Property((Expression) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.gFWNKICE1uFqpZp1h5VW((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PropertyViewItem.get_Attributes))), (MethodInfo) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.uPBtp2CENLwEGbnx0HFM(__methodref (ViewAttributes.get_ReadOnly))), parameterExpression);
                bool? nullable = new bool?(true);
                transformationBuilder.SetPropertyValue<bool?>(property, nullable);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        // ISSUE: reference to a compiler-generated method
        source.Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (p => !ReadOnlyAttributeTransformate.\u003C\u003Ec.RO2aLwCEw1uduV3CdEYa((object) p))).Each<PropertyViewItem>((Action<PropertyViewItem>) (p =>
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
                ViewItemTransformationBuilder<IEntity, PropertyViewItem> transformationBuilder = t.ForItem<PropertyViewItem>(ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.UbPqExCEOF8qC01NYC59((object) p));
                // ISSUE: type reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                ParameterExpression parameterExpression = (ParameterExpression) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.GHNFaTCEPZKpFPqnHvXS(ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.blNEnoCE2axkE1vHBPW9(__typeref (PropertyViewItem)), ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.kF3NpDCEeiFIJ2KdVTKv(-643786247 ^ -643497125));
                // ISSUE: method reference
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                Expression<Func<PropertyViewItem, bool>> property = Expression.Lambda<Func<PropertyViewItem, bool>>((Expression) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.gFWNKICE1uFqpZp1h5VW((object) parameterExpression, (object) (MethodInfo) ReadOnlyAttributeTransformate.\u003C\u003Ec__DisplayClass0_1.uPBtp2CENLwEGbnx0HFM(__methodref (PropertyViewItem.get_EditableInTable))), parameterExpression);
                transformationBuilder.SetPropertyValue<bool>(property, false);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      }));
    }

    public ReadOnlyAttributeTransformate()
    {
      ReadOnlyAttributeTransformate.z0KbaxokE7dYIc2lQB44();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool HGyvEgokhNY8ldJS7U9e() => ReadOnlyAttributeTransformate.Vynoj0okbKct9a5pvDNs == null;

    internal static ReadOnlyAttributeTransformate IFwW4gokGEvAZGBVbJkJ() => ReadOnlyAttributeTransformate.Vynoj0okbKct9a5pvDNs;

    internal static void z0KbaxokE7dYIc2lQB44() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
