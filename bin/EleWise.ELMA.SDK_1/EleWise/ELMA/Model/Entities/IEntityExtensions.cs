// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.IEntityExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using Iesi.Collections.Generic;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  public static class IEntityExtensions
  {
    internal static IEntityExtensions TrjljRhuxd1wwxHJL7IW;

    public static bool Same<IdT>(this IEntity<IdT> same, IEntity<IdT> target) where IdT : struct
    {
      if (same == target)
        return true;
      return same != null && target != null && same.Id.Equals((object) target.Id);
    }

    /// <summary>Получить настройки свойства</summary>
    /// <typeparam name="TModel">Тип модели</typeparam>
    /// <typeparam name="TValue">Тип свойства</typeparam>
    /// <param name="expression">Выражение, описывающее свойство, для которого нужно получить настройки</param>
    /// <returns>Настройки свойства</returns>
    public static TypeSettings GetSettingsFor<TModel, TValue>(
      this TModel entity,
      Expression<Func<TModel, TValue>> expression)
      where TModel : IEntity
    {
      if ((object) entity == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146549881));
      IPropertyMetadata propertyMetadata = IEntityExtensions.GetPropertyMetadata(typeof (TModel), expression.Body);
      return entity.GetPropertySettings(propertyMetadata.PropertyUid);
    }

    /// <summary>Получить контейнер для операций с блоком</summary>
    /// <typeparam name="TModel">Тип модели</typeparam>
    /// <typeparam name="TItem">Тип элемента блока</typeparam>
    /// <param name="expression">Выражение, описывающее свойство, для которого нужно получить настройки</param>
    /// <returns>Настройки свойства</returns>
    public static TablePartExtensionsContainer<TItem> ForTablePart<TModel, TItem>(
      this TModel entity,
      Expression<Func<TModel, ISet<TItem>>> expression)
      where TModel : IEntity
      where TItem : IEntity
    {
      return new TablePartExtensionsContainer<TItem>((IEntity) entity);
    }

    internal static IPropertyMetadata GetPropertyMetadata(Type entityType, Expression expression)
    {
      int num = 6;
      PropertyMetadata propertyMetadata;
      ClassMetadata classMetadata;
      MemberExpression memberExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 2:
            goto label_14;
          case 3:
            goto label_9;
          case 4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            propertyMetadata = classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => IEntityExtensions.\u003C\u003Ec__DisplayClass3_0.WGfKVqCz7QMSRaTwkDAR(IEntityExtensions.\u003C\u003Ec__DisplayClass3_0.PxmmrXCz6e9KUXgH7VNq((object) p), IEntityExtensions.\u003C\u003Ec__DisplayClass3_0.FHStUQCzA4cL4lvH9PAm(IEntityExtensions.\u003C\u003Ec__DisplayClass3_0.TnotgDCzHYxyndq2lbAp((object) memberExpression)))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
            continue;
          case 5:
            if (entityType == (Type) null)
            {
              num = 2;
              continue;
            }
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 6:
            num = 5;
            continue;
          case 7:
            if (memberExpression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 4 : 3;
              continue;
            }
            goto label_10;
          case 8:
            goto label_8;
          case 9:
            goto label_10;
          default:
            memberExpression = expression as MemberExpression;
            num = 7;
            continue;
        }
      }
label_8:
      throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515069427), IEntityExtensions.vuWmPAhuyc7ewTPurIJR(333888594 ^ 1075625116 ^ 1408844636), IEntityExtensions.ExY4RVhuJCT5YK0e8K5y(IEntityExtensions.RABEEfhuMtMBuf1Ccgij((object) memberExpression))));
label_9:
      return (IPropertyMetadata) propertyMetadata;
label_10:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) IEntityExtensions.vuWmPAhuyc7ewTPurIJR(2045296739 + 1688595713 ^ -561197412), IEntityExtensions.vuWmPAhuyc7ewTPurIJR(-87337865 ^ -87549979)));
label_14:
      throw new ArgumentNullException((string) IEntityExtensions.vuWmPAhuyc7ewTPurIJR(1199946765 ^ 1199927193));
    }

    internal static object vuWmPAhuyc7ewTPurIJR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RABEEfhuMtMBuf1Ccgij([In] object obj0) => (object) ((MemberExpression) obj0).Member;

    internal static object ExY4RVhuJCT5YK0e8K5y([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool qYWDQWhu0xgkMYXwAWwu() => IEntityExtensions.TrjljRhuxd1wwxHJL7IW == null;

    internal static IEntityExtensions g3pUVuhumVGKOVLgjXWK() => IEntityExtensions.TrjljRhuxd1wwxHJL7IW;
  }
}
