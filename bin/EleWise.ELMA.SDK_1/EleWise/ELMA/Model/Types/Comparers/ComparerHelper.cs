// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Comparers.ComparerHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Comparers
{
  public static class ComparerHelper
  {
    internal static ComparerHelper OvbxCboUZ755c59kIUi0;

    /// <summary>Создать сравниватель для свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Сравниватель</returns>
    internal static IComparer CreateComparer(this PropertyMetadata propertyMetadata)
    {
      int num1 = 6;
      LambdaExpression lambdaExpression;
      EntitySettings settings;
      Type typeByUid;
      ISortedProperty sortedProperty;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        PropertyMetadata property;
        EntityMetadata metadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              sortedProperty = ComparerHelper.cEF8neoUqVaE2kdv6rSh(ComparerHelper.wixK5ToUihlvO0uryjhF(), ComparerHelper.qHBuvFoURhH85EEeXUJQ((object) property), property.SubTypeUid) as ISortedProperty;
              num2 = 12;
              continue;
            case 2:
              if (metadata == null)
              {
                num2 = 13;
                continue;
              }
              goto case 3;
            case 3:
              property = RefTypeDescriptor<IEntity, EntitySettings>.FindProperty(metadata, ComparerHelper.A2qC42oUSL6ZdqB5Qn0N((object) settings), out EntityMetadata _);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
              continue;
            case 4:
              metadata = MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid, false) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
            case 5:
              if (!ComparerHelper.lVg0qqoUVUNPB8mmJnvP((object) settings))
              {
                num2 = 10;
                continue;
              }
              goto default;
            case 6:
              settings = (EntitySettings) propertyMetadata.Settings;
              num2 = 5;
              continue;
            case 7:
              if (ComparerHelper.giQuRYoUKs3AMEwTEP6s((object) sortedProperty))
              {
                num2 = 15;
                continue;
              }
              goto label_19;
            case 8:
              lambdaExpression = Expression.Lambda((Expression) ComparerHelper.rBAVtmoUO66bmMFe5s8l((object) parameterExpression, ComparerHelper.hn5vr0oUnR0M2flqaGZb((object) property)), parameterExpression);
              num2 = 9;
              continue;
            case 9:
              goto label_18;
            case 10:
            case 13:
            case 14:
              goto label_19;
            case 11:
              parameterExpression = (ParameterExpression) ComparerHelper.mf3fh5oUk76VQWehLvsx(typeByUid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487215126));
              num2 = 8;
              continue;
            case 12:
              if (sortedProperty != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 7 : 5;
                continue;
              }
              goto label_19;
            case 15:
              typeByUid = ((IMetadataRuntimeService) ComparerHelper.jaXspkoUXCoMxw4Oldc4()).GetTypeByUid(ComparerHelper.tN5IyToUTetwIBKRl2N2((object) metadata));
              num2 = 11;
              continue;
            default:
              if (ComparerHelper.A2qC42oUSL6ZdqB5Qn0N((object) settings) != Guid.Empty)
                goto case 4;
              else
                goto label_11;
          }
        }
label_11:
        num1 = 14;
      }
label_18:
      return (IComparer) ComparerHelper.jvmOdEoUe35AaPcsk8WN((object) sortedProperty, typeByUid, (object) lambdaExpression, ComparerHelper.Eyo6sEoU2MVt2VVReR78((object) settings));
label_19:
      return (IComparer) null;
    }

    public static IComparer Create(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyFunc != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            if (!ComparerHelper.l0qEaZoUP1G6Mvg56adU(sourceType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (IComparer) null;
label_3:
      // ISSUE: type reference
      return (IComparer) ComparerHelper.JZPuYGoU302LP2oKsDfb(ComparerHelper.q126pGoU12qUit2h5Qx1(__typeref (Comparer<,>)).MakeGenericType(sourceType, ComparerHelper.a1llixoUNnlXnCSbpuRD((object) propertyFunc)), (object) new object[2]
      {
        (object) propertyFunc,
        (object) order
      });
    }

    internal static bool lVg0qqoUVUNPB8mmJnvP([In] object obj0) => ((EntitySettings) obj0).CanSortProperty;

    internal static Guid A2qC42oUSL6ZdqB5Qn0N([In] object obj0) => ((EntitySettings) obj0).SortPropertyUid;

    internal static object wixK5ToUihlvO0uryjhF() => (object) MetadataServiceContext.Service;

    internal static Guid qHBuvFoURhH85EEeXUJQ([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object cEF8neoUqVaE2kdv6rSh([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static bool giQuRYoUKs3AMEwTEP6s([In] object obj0) => ((ISortedProperty) obj0).IsSupportSort();

    internal static object jaXspkoUXCoMxw4Oldc4() => (object) MetadataServiceContext.MetadataRuntimeService;

    internal static Guid tN5IyToUTetwIBKRl2N2([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object mf3fh5oUk76VQWehLvsx([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object hn5vr0oUnR0M2flqaGZb([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object rBAVtmoUO66bmMFe5s8l([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (string) obj1);

    internal static ListSortDirection Eyo6sEoU2MVt2VVReR78([In] object obj0) => ((EntitySettings) obj0).SortPropertyOrder;

    internal static object jvmOdEoUe35AaPcsk8WN(
      [In] object obj0,
      Type sourceType,
      [In] object obj2,
      ListSortDirection order)
    {
      return (object) ((ISortedProperty) obj0).GetComparer(sourceType, (LambdaExpression) obj2, order);
    }

    internal static bool Ke4VP7oUuRCNrx0GOG7Y() => ComparerHelper.OvbxCboUZ755c59kIUi0 == null;

    internal static ComparerHelper fJD8P3oUIRgBeKqALxLe() => ComparerHelper.OvbxCboUZ755c59kIUi0;

    internal static bool l0qEaZoUP1G6Mvg56adU([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type q126pGoU12qUit2h5Qx1([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type a1llixoUNnlXnCSbpuRD([In] object obj0) => ((LambdaExpression) obj0).ReturnType;

    internal static object JZPuYGoU302LP2oKsDfb([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);
  }
}
