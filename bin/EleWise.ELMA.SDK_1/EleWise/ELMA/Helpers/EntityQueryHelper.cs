// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.EntityQueryHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Helpers
{
  public static class EntityQueryHelper
  {
    private static EntityQueryHelper HOGulQhUQFPUc347gbgh;

    /// <summary>Получить тип сущности</summary>
    /// <param name="type">Тип метаданных</param>
    /// <returns>Тип сущности для указанного типа метаданных</returns>
    public static Type GetUsableType(Type type)
    {
      int num = 2;
      EntityMetadata entityMetadata;
      Type usableType;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
            num = 4;
            continue;
          case 2:
            usableType = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          case 3:
            usableType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityQueryHelper.hSI23ehUZRIBAWo1n5EU((object) entityMetadata), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 4:
            if (entityMetadata == null)
            {
              num = 6;
              continue;
            }
            goto case 5;
          case 5:
            if (EntityQueryHelper.L00sMYhU8dBXUi2MryKd((object) entityMetadata) == EntityMetadataType.InterfaceImplementation)
            {
              num = 3;
              continue;
            }
            goto label_7;
          default:
            goto label_7;
        }
      }
label_7:
      return usableType;
    }

    private static IEntityFilter CreateFilter(
      Type entityType,
      object eqlQuery,
      Guid? filterProviderUid,
      object filterProviderData,
      object filterFields)
    {
      Type entityFilterType = ModelHelper.GetEntityFilterType(entityType);
      IEntityFilter filter1 = entityFilterType != (Type) null ? (IEntityFilter) InterfaceActivator.Create(entityFilterType) : (IEntityFilter) new Filter();
      if (filterProviderUid.HasValue)
      {
        // ISSUE: reference to a compiler-generated method
        IEntityFilterProvider entityFilterProvider = ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().FirstOrDefault<IEntityFilterProvider>((Func<IEntityFilterProvider, bool>) (p => EntityQueryHelper.\u003C\u003Ec__DisplayClass6_0.qHFx8bvymFrJmkJQFRF9(p.ProviderUid, filterProviderUid.Value)));
        if (entityFilterProvider != null)
        {
          IEntityFilter filter2 = entityFilterProvider.GetFilter(filterProviderUid.Value, filter1);
          if (filter2 != null)
            filter1 = filter2;
          entityFilterProvider.ApplyFilter(filter1, (string) filterProviderData);
        }
      }
      EntityQueryHelper.BindFilterFields(filter1, (string) filterFields);
      if (!string.IsNullOrEmpty((string) eqlQuery))
        filter1.Query = (string) eqlQuery;
      return filter1;
    }

    /// <summary>Биндинг свойств фильтра</summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="filterFields">Значения полей для фильтра сущности в формате: Property1:Значение1,Property2:Значение2</param>
    public static void BindFilterFields(IEntityFilter filter, string filterFields)
    {
      int num1 = 4;
      IEnumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_165;
            case 2:
              if (Regex.IsMatch(filterFields, (string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(993438473 ^ 993329673)))
              {
                num2 = 5;
                continue;
              }
              goto label_163;
            case 3:
              if (EntityQueryHelper.jtauMQhUuhCClCQPODVU((object) filterFields))
              {
                num2 = 7;
                continue;
              }
              goto case 2;
            case 4:
              goto label_172;
            case 5:
              enumerator1 = (IEnumerator) EntityQueryHelper.RHOSCthUSbLDGS8lgI8b(EntityQueryHelper.OAcW8DhUVNjhhqqRVMnX((object) filterFields, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978574437)));
              num2 = 6;
              continue;
            case 6:
              goto label_6;
            case 7:
              goto label_159;
            default:
              goto label_142;
          }
        }
label_172:
        if (filter != null)
          num1 = 3;
        else
          goto label_148;
      }
label_5:
      return;
label_165:
      return;
label_159:
      return;
label_142:
      return;
label_163:
      return;
label_6:
      try
      {
label_155:
        if (EntityQueryHelper.pfDdNwhUxuZLfrN5KSfL((object) enumerator1))
          goto label_157;
        else
          goto label_156;
label_7:
        Match match;
        int num3;
        switch (num3)
        {
          case 0:
            return;
          case 1:
            try
            {
              IEnumerable<Match> source1 = ((IEnumerable) EntityQueryHelper.OAcW8DhUVNjhhqqRVMnX(EntityQueryHelper.sKGLFghUKsOnP6tHLLlF(EntityQueryHelper.HcI91RhUquhuIoTC1EJu(EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match), 1)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654073869))).OfType<Match>();
              // ISSUE: reference to a compiler-generated field
              Func<Match, string> func = EntityQueryHelper.\u003C\u003Ec.\u003C\u003E9__7_0;
              Func<Match, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EntityQueryHelper.\u003C\u003Ec.\u003C\u003E9__7_0 = selector = (Func<Match, string>) (m => (string) EntityQueryHelper.\u003C\u003Ec.xI6FDevydXDVaVDH16DI((object) m));
              }
              else
                goto label_174;
label_10:
              IEnumerable<string> strings = source1.Select<Match, string>(selector);
              object source2 = (object) filter;
              PropertyInfo propertyInfo = (PropertyInfo) null;
              string s = (string) null;
              IEnumerator<string> enumerator2 = strings.GetEnumerator();
              int num4 = 24;
              while (true)
              {
                int num5;
                ParameterInfo[] parameterInfoArray1;
                string str1;
                object obj1;
                MethodInfo method1;
                object obj2;
                object obj3;
                int result1;
                IEnumerable<object> source3;
                object obj4;
                ParameterInfo[] parameterInfoArray2;
                switch (num4)
                {
                  case 1:
                    if (source2 is IDictionary)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 16 : 10;
                      continue;
                    }
                    goto case 4;
                  case 2:
                    if (source2 is IEnumerable)
                    {
                      num5 = 15;
                      break;
                    }
                    goto label_155;
                  case 3:
                    parameterInfoArray2 = (ParameterInfo[]) null;
                    goto label_147;
                  case 4:
                    if (parameterInfoArray1 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 27 : 0;
                      continue;
                    }
                    goto case 19;
                  case 5:
                    ((ILogger) EntityQueryHelper.jIbJOrhUmqmoqQ0XdQ7a()).Warn((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459404647), (object) filter.GetType().CastAsRealType<Type>(), EntityQueryHelper.sKGLFghUKsOnP6tHLLlF(EntityQueryHelper.HcI91RhUquhuIoTC1EJu(EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match), 1)), EntityQueryHelper.sKGLFghUKsOnP6tHLLlF((object) ((GroupCollection) EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match))[7])));
                    num4 = 31;
                    continue;
                  case 6:
                    if (int.TryParse(s, out result1))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 13;
                      continue;
                    }
                    goto label_155;
                  case 7:
                    if (s != null)
                    {
                      num4 = 21;
                      continue;
                    }
                    goto case 5;
                  case 8:
                    if (parameterInfoArray1.Length == 2)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 17 : 13;
                      continue;
                    }
                    goto case 4;
                  case 9:
                    EntityQueryHelper.irtbeZhU0dcE6n93yItZ((object) (source2 as IDictionary), obj2, obj3);
                    num5 = 20;
                    break;
                  case 10:
                  case 33:
                    if (s == null)
                    {
                      num4 = 30;
                      continue;
                    }
                    goto case 2;
                  case 11:
                    obj3 = ((TypeConverter) EntityQueryHelper.sZe5nahUDFyHaQXokUoF(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray1[1]))).ConvertFrom((ITypeDescriptorContext) null, CultureInfo.InvariantCulture, (object) str1);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 9 : 0;
                    continue;
                  case 12:
                    EntityQueryHelper.LUvIg1hU3ZcgHCJT5ONl((object) propertyInfo, source2, obj4, (object) null);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 17 : 29;
                    continue;
                  case 13:
                    source3 = (source2 as IEnumerable).Cast<object>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 22 : 7;
                    continue;
                  case 14:
label_16:
                    if (source2 != null)
                    {
                      num4 = 18;
                      continue;
                    }
                    goto case 5;
                  case 15:
                    method1 = source2.GetType().GetMethod((string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1669371371 ^ 1669345751));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 25;
                    continue;
                  case 16:
                    if (parameterInfoArray1 != null)
                    {
                      num4 = 8;
                      continue;
                    }
                    goto case 4;
                  case 17:
                    obj2 = EntityQueryHelper.YshgJWhUwwBAyPJlKhnl(EntityQueryHelper.sZe5nahUDFyHaQXokUoF(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray1[0])), (object) null, EntityQueryHelper.j2em7ChUtKFETkaTikaM(), (object) s);
                    num4 = 11;
                    continue;
                  case 18:
                    if (!EntityQueryHelper.k0jJiYhU2joo9MHauUC8((object) propertyInfo, (object) null))
                    {
                      num4 = 7;
                      continue;
                    }
                    goto case 21;
                  case 19:
                    if (parameterInfoArray1.Length == 1)
                    {
                      num4 = 6;
                      continue;
                    }
                    goto label_155;
                  case 20:
                  case 27:
                  case 28:
                  case 29:
                  case 30:
                  case 31:
                    goto label_155;
                  case 21:
                    str1 = (string) EntityQueryHelper.bL9oCfhUOVEhoSCNsidt(EntityQueryHelper.bL9oCfhUOVEhoSCNsidt((object) ((string) EntityQueryHelper.sKGLFghUKsOnP6tHLLlF(EntityQueryHelper.HcI91RhUquhuIoTC1EJu(EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match), 7))).Replace((string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1470998129 - 231418599 ^ 1239535650), (string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(-1120607109 - 305487170 ^ -1426074167)), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1149433385 + 173655049 ^ 1323241858), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(516838154 ^ 516883016)), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(-53329496 >> 4 ^ -3327180), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1654249598 >> 2 ^ 413559145));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 16 : 26;
                    continue;
                  case 22:
                    if (result1 == source3.Count<object>())
                    {
                      num4 = 32;
                      continue;
                    }
                    goto label_155;
                  case 23:
                    method1.Invoke(source2, new object[1]
                    {
                      obj1
                    });
                    num4 = 28;
                    continue;
                  case 24:
                    try
                    {
label_39:
                      if (EntityQueryHelper.pfDdNwhUxuZLfrN5KSfL((object) enumerator2))
                        goto label_71;
                      else
                        goto label_40;
label_21:
                      int num6;
                      int num7 = num6;
label_22:
                      object key;
                      string str2;
                      IEnumerable<object> source4;
                      string str3;
                      while (true)
                      {
                        ParameterInfo[] parameterInfoArray3;
                        Type t;
                        MethodInfo method2;
                        Type genericTypeDefinition;
                        object obj5;
                        int result2;
                        object obj6;
                        object obj7;
                        object obj8;
                        object obj9;
                        switch (num7)
                        {
                          case 1:
                            method2 = source2.GetType().GetMethod((string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(589593376 ^ -1977315327 ^ -1459597539));
                            num7 = 2;
                            continue;
                          case 2:
                            if (!(method2 != (MethodInfo) null))
                            {
                              num7 = 27;
                              continue;
                            }
                            obj7 = EntityQueryHelper.aSla23hUpnf274kkMjA8((object) method2);
                            break;
                          case 3:
                            str3 = (string) null;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 23 : 33;
                            continue;
                          case 4:
                            if (s != null)
                            {
                              num7 = 13;
                              continue;
                            }
                            goto label_16;
                          case 5:
                            t = typeof (List<>).MakeGenericType(t.GetGenericArguments());
                            num7 = 32;
                            continue;
                          case 6:
                            // ISSUE: type reference
                            if (!EntityQueryHelper.DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, EntityQueryHelper.SM7T93hU1sUK9loCEARO(__typeref (ICollection<>))))
                            {
                              num7 = 44;
                              continue;
                            }
                            goto case 5;
                          case 7:
                            // ISSUE: type reference
                            if (!EntityQueryHelper.DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, EntityQueryHelper.SM7T93hU1sUK9loCEARO(__typeref (IEnumerable<>))))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 6;
                              continue;
                            }
                            goto case 5;
                          case 8:
                            if (source2 is IEnumerable)
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
                              continue;
                            }
                            goto case 25;
                          case 9:
                            obj8 = (object) null;
                            goto label_105;
                          case 10:
                          case 29:
                            goto label_16;
                          case 11:
                          case 36:
                            if (result2 < 0)
                            {
                              num7 = 52;
                              continue;
                            }
                            obj9 = source4.Skip<object>(result2).FirstOrDefault<object>();
                            goto label_103;
                          case 12:
                          case 58:
                            source2 = obj5;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 30 : 30;
                            continue;
                          case 13:
                          case 35:
                            goto label_39;
                          case 14:
                            if (!EntityQueryHelper.k0jJiYhU2joo9MHauUC8((object) propertyInfo, (object) null))
                              goto case 57;
                            else
                              goto label_49;
                          case 15:
                            if (EntityQueryHelper.qY9yl3hUTnhvroQi1qow((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951451890)))
                            {
                              num7 = 55;
                              continue;
                            }
                            goto case 14;
                          case 16:
                            if (int.TryParse(s, out result2))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 53 : 25;
                              continue;
                            }
                            goto case 23;
                          case 17:
                            t = EntityQueryHelper.oqqmoihUPTXM8Bem0aXj((object) propertyInfo);
                            num7 = 37;
                            continue;
                          case 18:
                            goto label_76;
                          case 19:
                            if (obj5 != null)
                            {
                              num7 = 58;
                              continue;
                            }
                            goto case 17;
                          case 20:
                            if (parameterInfoArray3.Length == 2)
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 38 : 11;
                              continue;
                            }
                            goto case 16;
                          case 21:
                            if (parameterInfoArray3 == null)
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 11 : 1;
                              continue;
                            }
                            goto case 22;
                          case 22:
                            if (parameterInfoArray3.Length == 1)
                            {
                              num7 = 50;
                              continue;
                            }
                            goto case 11;
                          case 23:
                            source2 = (object) null;
                            num7 = 29;
                            continue;
                          case 24:
                            goto label_68;
                          case 25:
                          case 30:
                          case 41:
                          case 46:
                            if (str2 == null)
                            {
                              num7 = 9;
                              continue;
                            }
                            obj8 = EntityQueryHelper.X0xN0jhUAlVi0Sps2B1M(source2.GetType(), (object) str2);
                            goto label_105;
                          case 26:
                          case 53:
                            goto label_35;
                          case 27:
                            obj7 = (object) null;
                            break;
                          case 28:
                            // ISSUE: type reference
                            t = EntityQueryHelper.SM7T93hU1sUK9loCEARO(__typeref (Dictionary<,>)).MakeGenericType(t.GetGenericArguments());
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 7 : 0;
                            continue;
                          case 31:
                            // ISSUE: type reference
                            if (genericTypeDefinition == EntityQueryHelper.SM7T93hU1sUK9loCEARO(__typeref (IDictionary<,>)))
                            {
                              num7 = 28;
                              continue;
                            }
                            goto case 7;
                          case 32:
                          case 34:
                            obj5 = InterfaceActivator.Create(t);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 40 : 51;
                            continue;
                          case 33:
                            if (EntityQueryHelper.xFJnnohUX1ZxmRGqI0S3((object) str2, EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(-1876063057 ^ -1876067763)))
                            {
                              num7 = 15;
                              continue;
                            }
                            goto case 14;
                          case 37:
                            if (t.IsGenericType)
                            {
                              num7 = 43;
                              continue;
                            }
                            goto case 32;
                          case 38:
                            key = EntityQueryHelper.YshgJWhUwwBAyPJlKhnl(EntityQueryHelper.sZe5nahUDFyHaQXokUoF(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray3[0])), (object) null, EntityQueryHelper.j2em7ChUtKFETkaTikaM(), (object) s);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 49;
                            continue;
                          case 39:
                            str2 = (string) null;
                            num7 = 14;
                            continue;
                          case 40:
                            obj6 = InterfaceActivator.Create(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray3[1]));
                            num7 = 48;
                            continue;
                          case 42:
                            source2 = obj6;
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 41 : 46;
                            continue;
                          case 43:
                            genericTypeDefinition = t.GetGenericTypeDefinition();
                            num7 = 31;
                            continue;
                          case 44:
                            // ISSUE: type reference
                            if (!EntityQueryHelper.DRT7guhUNJ0UJ3L0qYun(genericTypeDefinition, EntityQueryHelper.SM7T93hU1sUK9loCEARO(__typeref (IList<>))))
                            {
                              num7 = 34;
                              continue;
                            }
                            goto case 5;
                          case 45:
                            goto label_71;
                          case 47:
                            if (parameterInfoArray3 != null)
                            {
                              num7 = 20;
                              continue;
                            }
                            goto case 16;
                          case 48:
                            (source2 as IDictionary).Add(key, obj6);
                            num7 = 42;
                            continue;
                          case 49:
                            if (EntityQueryHelper.vUb5SbhU4dO86JkBwKue((object) (source2 as IDictionary), key))
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 18 : 11;
                              continue;
                            }
                            goto case 40;
                          case 50:
                            if (result2 == source4.Count<object>())
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 59 : 41;
                              continue;
                            }
                            goto case 11;
                          case 51:
                            EntityQueryHelper.LUvIg1hU3ZcgHCJT5ONl((object) propertyInfo, source2, obj5, (object) null);
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 12;
                            continue;
                          case 52:
                            obj9 = (object) null;
                            goto label_103;
                          case 54:
                            obj5 = EntityQueryHelper.qr8DiDhUeoNACFOlfMGL((object) propertyInfo, source2, (object) null);
                            num7 = 19;
                            continue;
                          case 55:
                            str3 = (string) EntityQueryHelper.bL9oCfhUOVEhoSCNsidt((object) ((string) EntityQueryHelper.bL9oCfhUOVEhoSCNsidt(EntityQueryHelper.pcPwQGhUnut1mpj7HstB((object) str2, 1, EntityQueryHelper.YxtcHJhUkYBd2ZCAcFvD((object) str2) - 2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408871254), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1505778440 - 1981636111 ^ -475919845))).Replace((string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1052221104 - 768835541 ^ 283620731), (string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1251470110 >> 2 ^ 312806447)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002653), EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(1251470110 >> 2 ^ 312862129));
                            num7 = 39;
                            continue;
                          case 56:
                            if (!EntityQueryHelper.D22mIBhU7KDJExIJFVpa((object) propertyInfo, (object) null))
                            {
                              num7 = 35;
                              continue;
                            }
                            goto case 4;
                          case 57:
                            if (s != null)
                            {
                              num7 = 8;
                              continue;
                            }
                            goto case 25;
                          case 59:
                            EntityQueryHelper.PRJmXVhUHcNXrRCVcbsP((object) method2, source2, (object) new object[1]
                            {
                              InterfaceActivator.Create(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray3[0]))
                            });
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 20 : 36;
                            continue;
                          case 60:
                            if (source2 != null)
                            {
                              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 39 : 41;
                              continue;
                            }
                            goto label_16;
                          default:
                            if (source2 is IDictionary)
                            {
                              num7 = 47;
                              continue;
                            }
                            goto case 16;
                        }
                        parameterInfoArray3 = (ParameterInfo[]) obj7;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                        continue;
label_103:
                        source2 = obj9;
                        num7 = 60;
                        continue;
label_105:
                        propertyInfo = (PropertyInfo) obj8;
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 24 : 20;
                      }
label_35:
                      source4 = (source2 as IEnumerable).Cast<object>();
                      num6 = 21;
                      goto label_21;
label_49:
                      num6 = 54;
                      goto label_21;
label_68:
                      s = str3;
                      num6 = 56;
                      goto label_21;
label_76:
                      source2 = EntityQueryHelper.Ai7d8LhU6KCmMGn7OMGu((object) (source2 as IDictionary), key);
                      num6 = 25;
                      goto label_21;
label_40:
                      num6 = 10;
                      goto label_21;
label_71:
                      str2 = enumerator2.Current;
                      num7 = 3;
                      goto label_22;
                    }
                    finally
                    {
                      int num8;
                      if (enumerator2 == null)
                        num8 = 2;
                      else
                        goto label_109;
label_108:
                      switch (num8)
                      {
                        case 1:
                        case 2:
                      }
label_109:
                      enumerator2.Dispose();
                      num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                      {
                        num8 = 1;
                        goto label_108;
                      }
                      else
                        goto label_108;
                    }
                  case 25:
                    if (!(method1 != (MethodInfo) null))
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 0;
                      continue;
                    }
                    parameterInfoArray2 = method1.GetParameters();
                    goto label_147;
                  case 26:
                    if (!EntityQueryHelper.k0jJiYhU2joo9MHauUC8((object) propertyInfo, (object) null))
                    {
                      num4 = 10;
                      continue;
                    }
                    goto default;
                  case 32:
                    obj1 = ((TypeConverter) EntityQueryHelper.sZe5nahUDFyHaQXokUoF(EntityQueryHelper.yk9bV7hUaceTdtvtKrFO((object) parameterInfoArray1[0]))).ConvertFrom((ITypeDescriptorContext) null, (CultureInfo) EntityQueryHelper.j2em7ChUtKFETkaTikaM(), (object) str1);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 16 : 23;
                    continue;
                  default:
                    obj4 = EntityQueryHelper.YshgJWhUwwBAyPJlKhnl((object) TypeDescriptor.GetConverter(EntityQueryHelper.oqqmoihUPTXM8Bem0aXj((object) propertyInfo)), (object) null, EntityQueryHelper.j2em7ChUtKFETkaTikaM(), (object) str1);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 6 : 12;
                    continue;
                }
                num4 = num5;
                continue;
label_147:
                parameterInfoArray1 = parameterInfoArray2;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
              }
label_174:
              selector = func;
              goto label_10;
            }
            catch (Exception ex)
            {
              int num9 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
                num9 = 0;
              while (true)
              {
                switch (num9)
                {
                  case 1:
                    EntityQueryHelper.abbtdohUy96KhQhbgxHs(EntityQueryHelper.jIbJOrhUmqmoqQ0XdQ7a(), (object) EleWise.ELMA.SR.T((string) EntityQueryHelper.yMuYLNhUIyYVKnh00LDw(-244066886 - -48452443 ^ -195788115), (object) filter.GetType().CastAsRealType<Type>(), (object) ((Capture) EntityQueryHelper.HcI91RhUquhuIoTC1EJu(EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match), 1)).Value, EntityQueryHelper.sKGLFghUKsOnP6tHLLlF(EntityQueryHelper.HcI91RhUquhuIoTC1EJu(EntityQueryHelper.UJMGuQhURgRghmI2xVno((object) match), 7))), (object) ex);
                    num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_155;
                }
              }
            }
          case 2:
            goto label_155;
          case 3:
            goto label_157;
          default:
            return;
        }
label_156:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
        goto label_7;
label_157:
        match = (Match) EntityQueryHelper.BBpFGvhUitqSs1OyMpjk((object) enumerator1);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        {
          num3 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        int num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
          num10 = 1;
        while (true)
        {
          switch (num10)
          {
            case 1:
              if (disposable == null)
              {
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              EntityQueryHelper.sufPKohUMuaxjDDNdmZp((object) disposable);
              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 0;
              continue;
            default:
              goto label_168;
          }
        }
label_168:;
      }
label_148:;
    }

    /// <summary>
    /// Получить количество сущностей при помощи фильтра на языке EQL
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="eqlQuery">Запрос на языке EQL</param>
    /// <returns>Количество сущностей</returns>
    public static long CountAllEntitiesWithFilter(Type entityType, string eqlQuery) => EntityQueryHelper.CountAllEntitiesWithFilter(entityType, eqlQuery, new Guid?(), (string) null, (string) null);

    /// <summary>
    /// Получить количество сущностей при помощи фильтра на языке EQL
    /// </summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="eqlQuery">Запрос на языке EQL</param>
    /// <returns>Количество сущностей</returns>
    public static long CountAllEntitiesWithFilter(
      Type entityType,
      string eqlQuery,
      Guid? filterProviderUid,
      string filterProviderData,
      string filterFields)
    {
      IEntityManager entityManager = ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(entityType));
      if (entityManager == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289694576), (object) entityType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870880349));
      IEntityFilter filter = EntityQueryHelper.CreateFilter(entityType, (object) eqlQuery, filterProviderUid, (object) filterProviderData, (object) filterFields);
      return entityManager.Count(filter);
    }

    /// <summary>Выбрать сущности при помощи фильтра на языке EQL</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="eqlQuery">Запрос на языке EQL</param>
    /// <returns>Массив выбранных сущностей</returns>
    public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(
      Type entityType,
      string eqlQuery,
      string sort,
      int limit,
      int offset)
    {
      return EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, new Guid?(), (string) null, (string) null);
    }

    /// <summary>Выбрать сущности при помощи фильтра на языке EQL</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="eqlQuery">Запрос на языке EQL</param>
    /// <returns>Массив выбранных сущностей</returns>
    public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(
      Type entityType,
      string eqlQuery,
      string sort,
      int limit,
      int offset,
      Guid? filterProviderUid,
      string filterProviderData)
    {
      return EntityQueryHelper.QueryAllEntitiesWithFilter(entityType, eqlQuery, sort, limit, offset, filterProviderUid, filterProviderData, (string) null);
    }

    /// <summary>Выбрать сущности при помощи фильтра на языке EQL</summary>
    /// <param name="entityType">Тип сущности</param>
    /// <param name="eqlQuery">Запрос на языке EQL</param>
    /// <returns>Массив выбранных сущностей</returns>
    public static IEnumerable<IEntity> QueryAllEntitiesWithFilter(
      Type entityType,
      string eqlQuery,
      string sort,
      int limit,
      int offset,
      Guid? filterProviderUid,
      string filterProviderData,
      string filterFields)
    {
      IEntityManager entityManager = ModelHelper.GetEntityManager(EntityQueryHelper.GetUsableType(entityType));
      if (entityManager == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304585143), (object) entityType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312813907));
      IEntityFilter filter = EntityQueryHelper.CreateFilter(entityType, (object) eqlQuery, filterProviderUid, (object) filterProviderData, (object) filterFields);
      FetchOptions fetchOptions = new FetchOptions(offset, limit, sort);
      if (!string.IsNullOrWhiteSpace(sort))
      {
        string[] strArray = sort.Split(';');
        if (strArray.Length > 1)
        {
          foreach (string str in strArray)
          {
            ListSortDirection sortDirection = ListSortDirection.Descending;
            string sortExpression;
            if (str.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638615039), StringComparison.OrdinalIgnoreCase))
            {
              sortDirection = ListSortDirection.Descending;
              sortExpression = str.Remove(str.Length - 5);
            }
            else
              sortExpression = !str.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45067619), StringComparison.OrdinalIgnoreCase) ? str : str.Remove(str.Length - 4);
            fetchOptions.SortDescriptors.Add(new FetchOptionsSortDescriptor(sortExpression, sortDirection));
          }
        }
      }
      return entityManager.Find(filter, fetchOptions).Cast<IEntity>();
    }

    internal static EntityMetadataType L00sMYhU8dBXUi2MryKd([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid hSI23ehUZRIBAWo1n5EU([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static bool OnsA1DhUCqHIGCLcyj27() => EntityQueryHelper.HOGulQhUQFPUc347gbgh == null;

    internal static EntityQueryHelper rq9SqjhUv7Ayg4fpiZVQ() => EntityQueryHelper.HOGulQhUQFPUc347gbgh;

    internal static bool jtauMQhUuhCClCQPODVU([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object yMuYLNhUIyYVKnh00LDw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OAcW8DhUVNjhhqqRVMnX([In] object obj0, [In] object obj1) => (object) Regex.Matches((string) obj0, (string) obj1);

    internal static object RHOSCthUSbLDGS8lgI8b([In] object obj0) => (object) ((MatchCollection) obj0).GetEnumerator();

    internal static object BBpFGvhUitqSs1OyMpjk([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object UJMGuQhURgRghmI2xVno([In] object obj0) => (object) ((Match) obj0).Groups;

    internal static object HcI91RhUquhuIoTC1EJu([In] object obj0, [In] int obj1) => (object) ((GroupCollection) obj0)[obj1];

    internal static object sKGLFghUKsOnP6tHLLlF([In] object obj0) => (object) ((Capture) obj0).Value;

    internal static bool xFJnnohUX1ZxmRGqI0S3([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool qY9yl3hUTnhvroQi1qow([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static int YxtcHJhUkYBd2ZCAcFvD([In] object obj0) => ((string) obj0).Length;

    internal static object pcPwQGhUnut1mpj7HstB([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object bL9oCfhUOVEhoSCNsidt([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool k0jJiYhU2joo9MHauUC8([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object qr8DiDhUeoNACFOlfMGL([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static Type oqqmoihUPTXM8Bem0aXj([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type SM7T93hU1sUK9loCEARO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool DRT7guhUNJ0UJ3L0qYun([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void LUvIg1hU3ZcgHCJT5ONl([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object aSla23hUpnf274kkMjA8([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type yk9bV7hUaceTdtvtKrFO([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static object sZe5nahUDFyHaQXokUoF([In] Type obj0) => (object) TypeDescriptor.GetConverter(obj0);

    internal static object j2em7ChUtKFETkaTikaM() => (object) CultureInfo.InvariantCulture;

    internal static object YshgJWhUwwBAyPJlKhnl(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((TypeConverter) obj0).ConvertFrom((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3);
    }

    internal static bool vUb5SbhU4dO86JkBwKue([In] object obj0, [In] object obj1) => ((IDictionary) obj0).Contains(obj1);

    internal static object Ai7d8LhU6KCmMGn7OMGu([In] object obj0, [In] object obj1) => ((IDictionary) obj0)[obj1];

    internal static object PRJmXVhUHcNXrRCVcbsP([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static object X0xN0jhUAlVi0Sps2B1M(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool D22mIBhU7KDJExIJFVpa([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool pfDdNwhUxuZLfrN5KSfL([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void irtbeZhU0dcE6n93yItZ([In] object obj0, [In] object obj1, [In] object obj2) => ((IDictionary) obj0).Add(obj1, obj2);

    internal static object jIbJOrhUmqmoqQ0XdQ7a() => (object) Logger.Log;

    internal static void abbtdohUy96KhQhbgxHs([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void sufPKohUMuaxjDDNdmZp([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
