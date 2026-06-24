// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Bytecode;
using NHibernate.Criterion;
using NHibernate.Properties;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  [Serializable]
  public class AliasToBeanResultTransformer : IResultTransformer
  {
    private ConstructorInfo constructor;
    private readonly IPropertyAccessor propertyAccessor;
    private Type resultClass;
    private Dictionary<Type, (ISetter[] setters, Type[] types)> settersDict;
    private List<KeyValuePair<string, string>> collectionProperties;
    internal static AliasToBeanResultTransformer SbUN4MWwctUX4cPeBsdI;

    public AliasToBeanResultTransformer(Type resultClass)
    {
      AliasToBeanResultTransformer.l2jVVfW4BmC5Vy0I0GUZ();
      this.settersDict = new Dictionary<Type, (ISetter[], Type[])>();
      this.collectionProperties = new List<KeyValuePair<string, string>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (!AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(resultClass, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 8 : 9;
              continue;
            }
            goto label_3;
          case 3:
            goto label_3;
          case 4:
          case 6:
            this.propertyAccessor = (IPropertyAccessor) new EntityPropertyAccessor(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 7;
            continue;
          case 5:
            this.constructor = resultClass.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, Type.EmptyTypes, (ParameterModifier[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_9;
          case 8:
            if (!resultClass.IsClass)
            {
              num = 6;
              continue;
            }
            goto label_7;
          case 9:
            this.resultClass = resultClass;
            num = 5;
            continue;
          default:
            if (!AliasToBeanResultTransformer.Jypf7NW4b8wRma5mm8GE((object) this.constructor, (object) null))
            {
              num = 4;
              continue;
            }
            goto case 8;
        }
      }
label_9:
      return;
label_3:
      throw new ArgumentNullException((string) AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(322893104 - -1992822529 ^ -1979374217));
label_7:
      throw new ArgumentException((string) AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(-1380439818 << 3 ^ 1841522384), (string) AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(1470440286 ^ 1470562840));
    }

    public virtual IList TransformList(IList collection)
    {
      int num1 = 1;
      IMetadataRuntimeService service1;
      List<KeyValuePair<string, string>>.Enumerator enumerator1;
      ISession session;
      ITransformationProvider service2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (AliasToBeanResultTransformer.icvAraW4h3YtJYXr2IiJ((object) this.collectionProperties) != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto label_72;
          case 2:
            service2 = Locator.GetService<ITransformationProvider>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 3 : 7;
            continue;
          case 3:
            goto label_72;
          case 4:
            service1 = Locator.GetService<IMetadataRuntimeService>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
          case 5:
            goto label_76;
          case 6:
            goto label_3;
          case 7:
            enumerator1 = this.collectionProperties.GetEnumerator();
            num1 = 6;
            continue;
          default:
            session = (ISession) AliasToBeanResultTransformer.kO7tvZW4Gljol1qyDr9s((object) Locator.GetService<ISessionProvider>(), (object) "");
            num1 = 4;
            continue;
        }
      }
label_3:
      try
      {
label_7:
        if (enumerator1.MoveNext())
          goto label_9;
        else
          goto label_8;
label_4:
        IEnumerator enumerator2;
        int num2;
        KeyValuePair<string, string> collectionProperty;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_76;
            case 2:
              enumerator2 = (IEnumerator) AliasToBeanResultTransformer.VHbhwyW4EOw1ZiYlAmkD((object) collection);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_9;
            case 4:
              collectionProperty = enumerator1.Current;
              num2 = 2;
              continue;
            case 5:
              goto label_7;
            default:
              goto label_10;
          }
        }
label_10:
        try
        {
label_45:
          if (AliasToBeanResultTransformer.GmLHJvW41xkMnDcFQ26c((object) enumerator2))
            goto label_21;
          else
            goto label_46;
label_12:
          int num3;
          int num4 = num3;
label_13:
          object obj1;
          object obj2;
          EntityMetadata entityMetadata;
          PropertyMetadata propertyMetadata1;
          PropertyMetadata propertyMetadata2;
          PropertyMetadata propertyMetadata3;
          Type typeByUid;
          PropertyInfo property;
          bool flag;
          Func<ICollection<object>> func1;
          ConstructorInfo constructor;
          Type[] genericArguments;
          EntityMetadata metadata;
          object obj3;
          EntitySettings settings;
          ICriteria crit;
          PropertyInfo propertyInfo;
          while (true)
          {
            switch (num4)
            {
              case 1:
              case 7:
              case 24:
              case 28:
              case 33:
              case 35:
                goto label_45;
              case 2:
                goto label_21;
              case 3:
                if (AliasToBeanResultTransformer.dyor5uW4VnL1vO7i00JZ((object) settings) == RelationType.ManyToMany)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 24 : 37;
                  continue;
                }
                goto case 32;
              case 4:
                if (genericArguments.Length == 0)
                {
                  num4 = 35;
                  continue;
                }
                goto case 5;
              case 5:
                // ISSUE: type reference
                // ISSUE: type reference
                constructor = AliasToBeanResultTransformer.qr6GjHW4OFaA6xQGOR3l(__typeref (LazyHashedSet<>)).MakeGenericType(genericArguments).GetConstructor(new Type[1]
                {
                  AliasToBeanResultTransformer.qr6GjHW4OFaA6xQGOR3l(__typeref (Func<ICollection<object>>))
                });
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 41 : 25;
                continue;
              case 6:
                AliasToBeanResultTransformer.uKtBQMW4kBaKiORLTOZC((object) crit, (object) propertyMetadata3.Name, AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(-2099751081 ^ -2099612373));
                num4 = 11;
                continue;
              case 8:
                settings = (EntitySettings) AliasToBeanResultTransformer.EC84S4W4ZrLmwNPFLktC((object) propertyMetadata2);
                num4 = 9;
                continue;
              case 9:
                typeByUid = service1.GetTypeByUid(AliasToBeanResultTransformer.bXT2dPW4ueVFtwROiJ9W((object) propertyMetadata2));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                continue;
              case 10:
                if (!AliasToBeanResultTransformer.YAFkWCW48Z1LW2im9vj2((object) propertyInfo, (object) null))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                  continue;
                }
                goto case 40;
              case 11:
                AliasToBeanResultTransformer.noT9jIW4TYVHGyTIh2BO((object) crit, AliasToBeanResultTransformer.M3mBhxW4n26btH84xD5Y(AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(516838154 ^ 516714892), obj3));
                num4 = 34;
                continue;
              case 12:
                obj3 = property.GetValue(obj1, (object[]) null);
                num4 = 10;
                continue;
              case 13:
                if (AliasToBeanResultTransformer.Fi2BHrW4vDXKP1rQkReS((object) property, (object) null))
                {
                  num4 = 28;
                  continue;
                }
                goto case 12;
              case 14:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata1 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_2.ThYHKaQlZmryqwLp2dBQ(AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_2.MCsFwOQlv00LCLlR2PqB((object) p), AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_2.ghrWa3Ql8aXq390Ymhrm((object) settings))));
                num4 = 22;
                continue;
              case 15:
                flag = false;
                num4 = 25;
                continue;
              case 16:
                if (propertyMetadata3 != null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 6 : 5;
                  continue;
                }
                goto label_45;
              case 17:
                obj2 = AliasToBeanResultTransformer.umRXpIW4e86OLcRmk8eX((object) constructor, (object) new object[1]
                {
                  (object) func1
                });
                num4 = 20;
                continue;
              case 18:
                func1 = (Func<ICollection<object>>) (() => (ICollection<object>) crit.List().Cast<object>().ToList<object>());
                num4 = 17;
                continue;
              case 19:
                property = obj1.GetType().GetProperty((string) AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(-1426456882 ^ 2009939514 ^ -583777878));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 13 : 6;
                continue;
              case 20:
                goto label_14;
              case 21:
                goto label_7;
              case 22:
                if (propertyMetadata1 == null)
                {
                  num4 = 33;
                  continue;
                }
                goto case 31;
              case 23:
                num4 = 8;
                continue;
              case 25:
                if (AliasToBeanResultTransformer.dyor5uW4VnL1vO7i00JZ((object) settings) == RelationType.ManyToManyInverse)
                {
                  num4 = 14;
                  continue;
                }
                goto case 3;
              case 26:
              case 34:
                genericArguments = propertyInfo.PropertyType.GetGenericArguments();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 0;
                continue;
              case 27:
                List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses((ClassMetadata) metadata);
                baseClasses.Add((ClassMetadata) metadata);
                Func<ClassMetadata, bool> func;
                Func<ClassMetadata, bool> func2 = func;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (baseClasses.Any<ClassMetadata>(func2 == null ? (func = (Func<ClassMetadata, bool>) (c => AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_0.GhSgCNQlFQgkOLoagapO(AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_0.mSAdQQQdzIn5oPPwQsss((object) c), (object) collectionProperty.Key))) : func2))
                {
                  num4 = 30;
                  continue;
                }
                goto label_45;
              case 29:
                num4 = 42;
                continue;
              case 30:
                propertyInfo = (PropertyInfo) AliasToBeanResultTransformer.Fds08qW4CdHaQmJwmrfC(obj1.GetType(), (object) collectionProperty.Value);
                num4 = 19;
                continue;
              case 31:
                settings = (EntitySettings) AliasToBeanResultTransformer.EC84S4W4ZrLmwNPFLktC((object) propertyMetadata1);
                num4 = 38;
                continue;
              case 32:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata3 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_2.ThYHKaQlZmryqwLp2dBQ(p.Uid, AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_2.ghrWa3Ql8aXq390Ymhrm((object) settings))));
                num4 = 16;
                continue;
              case 36:
                if (propertyMetadata2 != null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 23;
                  continue;
                }
                goto label_45;
              case 37:
                goto label_60;
              case 38:
                flag = true;
                num4 = 3;
                continue;
              case 39:
                crit = (ICriteria) AliasToBeanResultTransformer.drkn88W4IfumbFFW9iqI((object) session, typeByUid);
                num4 = 15;
                continue;
              case 40:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyMetadata2 = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_1.SmiAfvQlGE1j79y3L1wi(AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass7_1.Fop4rRQlhGrALtQpv6Db((object) p), (object) propertyInfo.Name)));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 31 : 36;
                continue;
              case 41:
                if (!AliasToBeanResultTransformer.bPOZlAW42Goe6toveDbO((object) constructor, (object) null))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 7 : 7;
                  continue;
                }
                goto case 18;
              case 42:
                metadata = (EntityMetadata) MetadataLoader.LoadMetadata(AliasToBeanResultTransformer.iUAx1dW4QXZxCxdSIy5Y(obj1.GetType()));
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 27 : 4;
                continue;
              default:
                entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(propertyMetadata2.SubTypeUid);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 30 : 39;
                continue;
            }
          }
label_14:
          AliasToBeanResultTransformer.CJrLnmW4PU0iZ3y7MfoF((object) propertyInfo, obj1, obj2, (object) null);
          num3 = 24;
          goto label_12;
label_60:
          AliasToBeanResultTransformer.noT9jIW4TYVHGyTIh2BO((object) crit, AliasToBeanResultTransformer.eXfK8GW4XiMWmJmD8Fe6((object) string.Format((string) AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(236071375 ^ 235932611), (object) ((Dialect) AliasToBeanResultTransformer.dh55CKW4SlpTRJDXtQoK((object) service2)).QuoteIfNeeded(flag ? (string) AliasToBeanResultTransformer.yN0fvlW4iPxpVsWHuTPP((object) settings) : (string) AliasToBeanResultTransformer.O8WorIW4R1e3Wg9ejTOs((object) settings)), (object) ((Dialect) AliasToBeanResultTransformer.dh55CKW4SlpTRJDXtQoK((object) service2)).QuoteIfNeeded((string) AliasToBeanResultTransformer.fj99eNW4qAHaOptLgTyu((object) settings)), AliasToBeanResultTransformer.QsqJWwW4KlZgkOXF9JEl(AliasToBeanResultTransformer.dh55CKW4SlpTRJDXtQoK((object) service2), flag ? AliasToBeanResultTransformer.O8WorIW4R1e3Wg9ejTOs((object) settings) : (object) settings.ParentColumnName), obj3, AliasToBeanResultTransformer.QsqJWwW4KlZgkOXF9JEl(AliasToBeanResultTransformer.dh55CKW4SlpTRJDXtQoK((object) service2), AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(-1822890472 ^ -1822922938)))));
          num3 = 26;
          goto label_12;
label_21:
          obj1 = AliasToBeanResultTransformer.ooogC5W4ffNkmWMVQKnW((object) enumerator2);
          num4 = 29;
          goto label_13;
label_46:
          num3 = 21;
          goto label_12;
        }
        finally
        {
          IDisposable disposable = enumerator2 as IDisposable;
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (disposable != null)
                {
                  num5 = 2;
                  continue;
                }
                goto label_67;
              case 2:
                AliasToBeanResultTransformer.hFMMIaW4NSjNln6lXp9D((object) disposable);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
              default:
                goto label_67;
            }
          }
label_67:;
        }
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
        goto label_4;
label_9:
        num2 = 4;
        goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
label_72:
      return collection;
label_76:
      return collection;
    }

    public virtual object TransformTuple(object[] tuple, string[] aliases)
    {
      int num1 = 1;
      List<string> stringList1;
      while (true)
      {
        List<string> stringList2;
        switch (num1)
        {
          case 1:
            if (aliases == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
              continue;
            }
            stringList2 = new List<string>((IEnumerable<string>) aliases);
            break;
          case 2:
            goto label_146;
          case 3:
            goto label_2;
          default:
            stringList2 = new List<string>();
            break;
        }
        stringList1 = stringList2;
        num1 = 3;
      }
label_2:
      object target;
      try
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        int index1 = stringList1.FindIndex((Predicate<string>) (a => ((StringComparer) AliasToBeanResultTransformer.\u003C\u003Ec.vuXVc9QlPHUDr3xdVQ9y()).Compare(a, (string) AliasToBeanResultTransformer.\u003C\u003Ec.gTT8BQQl19TYHuNcGRYV(2008901894 << 3 ^ -1108425420)) == 0));
        int num2 = 67;
        while (true)
        {
          int num3;
          ISetter setter1;
          object v;
          ISetter[] setterArray1;
          int index2;
          Type typeByUid;
          Type t;
          Type type1;
          ConstructorInfo constructorInfo;
          IMetadataRuntimeService service;
          EntityMetadata entityMetadata;
          int index3;
          byte[] b;
          (ISetter[] setters, Type[] types) tuple1;
          Guid uid;
          Type[] typeArray1;
          Type type2;
          bool flag;
          int num4;
          object obj1;
          string resClassName1;
          string propertyName1;
          string resClassName2;
          string propertyName2;
          switch (num2)
          {
            case 1:
              propertyName1 = CustomPropertyProjection.GetExpressionFromString(aliases[index3], out resClassName1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 23 : 46;
              continue;
            case 2:
              typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 14 : 8;
              continue;
            case 3:
              Dictionary<Type, (ISetter[], Type[])> settersDict1 = this.settersDict;
              Type type3 = t;
              Type key1 = (object) type3 == null ? this.resultClass : type3;
              (ISetter[], Type[]) valueTuple = (setterArray1, typeArray1);
              settersDict1.Add(key1, valueTuple);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 34 : 83;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
              continue;
            case 5:
              if (AliasToBeanResultTransformer.bPOZlAW42Goe6toveDbO((object) constructorInfo, (object) null))
              {
                num2 = 39;
                continue;
              }
              goto case 9;
            case 6:
              Type type4 = type2;
              Type c = t;
              if ((object) c == null)
                c = this.resultClass;
              if (!type4.IsAssignableFrom(c))
              {
                num2 = 29;
                continue;
              }
              goto case 18;
            case 7:
              if (!AliasToBeanResultTransformer.clAWPvW4mYpngSlfHxxi(type1))
              {
                num2 = 30;
                continue;
              }
              goto case 20;
            case 8:
            case 84:
              Dictionary<Type, (ISetter[], Type[])> settersDict2 = this.settersDict;
              Type key2 = t;
              if ((object) key2 == null)
                key2 = this.resultClass;
              if (!settersDict2.ContainsKey(key2))
              {
                num2 = 78;
                continue;
              }
              goto case 5;
            case 9:
              if (AliasToBeanResultTransformer.bPOZlAW42Goe6toveDbO((object) this.constructor, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 13 : 25;
                continue;
              }
              goto case 23;
            case 10:
              typeArray1 = new Type[aliases.Length];
              num3 = 3;
              break;
            case 11:
              if (AliasToBeanResultTransformer.VsC7TxW43wrjXn6fAWJ5(type2, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 6;
                continue;
              }
              goto case 29;
            case 12:
              // ISSUE: reference to a compiler-generated method
              entityMetadata = service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => (string) AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass8_0.USq2PDQlirxOXdDVBWm4((object) m) == resClassName2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 49 : 7;
              continue;
            case 13:
              if (!AliasToBeanResultTransformer.D97k2JW4pVloGwJ1IK6W((object) resClassName2))
              {
                num2 = 19;
                continue;
              }
              goto case 27;
            case 14:
              if (AliasToBeanResultTransformer.VsC7TxW43wrjXn6fAWJ5(typeByUid, (Type) null))
              {
                num2 = 48;
                continue;
              }
              goto case 8;
            case 15:
              if (!type1.IsGenericType)
              {
                num2 = 31;
                continue;
              }
              goto case 35;
            case 16:
              num4 = AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(Enum.GetUnderlyingType(type1), v.GetType()) ? 1 : 0;
              goto label_137;
            case 17:
              try
              {
                Type type5 = t;
                int num5;
                if ((object) type5 == null)
                  num5 = 5;
                else
                  goto label_45;
label_40:
                PropertyInfo propertyInfo;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                    case 4:
                      goto label_8;
                    case 2:
                      ISetter[] setterArray2 = setterArray1;
                      int index4 = index2;
                      IPropertyAccessor propertyAccessor = this.propertyAccessor;
                      Type type6 = t;
                      if ((object) type6 == null)
                        type6 = this.resultClass;
                      object obj2 = AliasToBeanResultTransformer.iF0dDWW4401GLUiVwxmQ((object) propertyInfo);
                      object obj3 = AliasToBeanResultTransformer.XvmH9yW4t29pLJtQnebc((object) propertyAccessor, type6, obj2);
                      setterArray2[index4] = (ISetter) obj3;
                      num5 = 3;
                      continue;
                    case 3:
                      typeArray1[index2] = AliasToBeanResultTransformer.hdusqUW46NbFHdm0IlV8((object) propertyInfo);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                      continue;
                    case 5:
                      goto label_44;
                    default:
                      if (!AliasToBeanResultTransformer.YAFkWCW48Z1LW2im9vj2((object) propertyInfo, (object) null))
                      {
                        num5 = 4;
                        continue;
                      }
                      goto case 2;
                  }
                }
label_44:
                type5 = this.resultClass;
label_45:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                propertyInfo = ((IEnumerable<PropertyInfo>) type5.GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)).FirstOrDefault<PropertyInfo>((Func<PropertyInfo, bool>) (p => AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass8_0.nZcGpgQlqKJGMw72Ew3U(AliasToBeanResultTransformer.\u003C\u003Ec__DisplayClass8_0.cX6dopQlRSJQgVZ5T65i((object) p), (object) propertyName2, StringComparison.InvariantCultureIgnoreCase)));
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                {
                  num5 = 0;
                  goto label_40;
                }
                else
                  goto label_40;
              }
              catch
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_8;
                }
              }
            case 18:
            case 22:
              num2 = 74;
              continue;
            case 19:
              service = Locator.GetService<IMetadataRuntimeService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 77 : 15;
              continue;
            case 20:
            case 37:
              num4 = 1;
              goto label_137;
            case 21:
              v = tuple[index3];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 19 : 56;
              continue;
            case 23:
              if (AliasToBeanResultTransformer.VsC7TxW43wrjXn6fAWJ5(t, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 59 : 35;
                continue;
              }
              goto case 61;
            case 24:
              type1 = tuple1.types[index3];
              num2 = 87;
              continue;
            case 25:
              obj1 = AliasToBeanResultTransformer.umRXpIW4e86OLcRmk8eX((object) this.constructor, (object) null);
              goto label_134;
            case 26:
            case 52:
              if (index2 >= aliases.Length)
              {
                num3 = 5;
                break;
              }
              goto case 38;
            case 27:
            case 43:
              if (propertyName2 == null)
              {
                num2 = 34;
                continue;
              }
              goto case 86;
            case 28:
              t = typeByUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 8 : 0;
              continue;
            case 29:
              if (AliasToBeanResultTransformer.DCpoVlW4DEnGW8wUYGX6((object) resClassName2, (object) this.resultClass.Name))
              {
                num2 = 22;
                continue;
              }
              goto case 34;
            case 30:
              if (v != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 72 : 46;
                continue;
              }
              goto case 65;
            case 31:
            case 64:
            case 73:
              setter1.Set(target, v);
              num2 = 55;
              continue;
            case 32:
            case 40:
            case 45:
              if (AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(type1, (Type) null))
              {
                num2 = 37;
                continue;
              }
              goto case 42;
            case 33:
              uid = new Guid(tuple[index1].ToString());
              num2 = 2;
              continue;
            case 34:
            case 50:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 25 : 26;
              continue;
            case 35:
              // ISSUE: type reference
              if (!AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(type1.GetGenericTypeDefinition(), AliasToBeanResultTransformer.qr6GjHW4OFaA6xQGOR3l(__typeref (Iesi.Collections.Generic.ISet<>))))
              {
                num2 = 73;
                continue;
              }
              goto case 4;
            case 36:
              AliasToBeanResultTransformer.ipwS1rW40RDhAydB4esg((object) setter1, target, (object) new Guid(b));
              num3 = 53;
              break;
            case 38:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 81 : 66;
              continue;
            case 39:
              obj1 = constructorInfo.Invoke((object[]) null);
              goto label_134;
            case 41:
            case 53:
            case 55:
            case 82:
            case 85:
              ++index3;
              num2 = 66;
              continue;
            case 42:
              if (v == null)
              {
                num2 = 7;
                continue;
              }
              goto case 30;
            case 44:
              // ISSUE: type reference
              if (!AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(type1, AliasToBeanResultTransformer.qr6GjHW4OFaA6xQGOR3l(__typeref (Guid))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 75 : 5;
                continue;
              }
              goto case 36;
            case 46:
              if (this.collectionProperties.Any<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (p => p.Key == resClassName1 && p.Value == propertyName1)))
              {
                num3 = 85;
                break;
              }
              goto case 71;
            case 47:
              type2 = service.GetTypeByUid(AliasToBeanResultTransformer.OnUrfOW4ajMJ2h3cesPs((object) entityMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 43 : 35;
              continue;
            case 48:
              constructorInfo = typeByUid.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, Type.EmptyTypes, (ParameterModifier[]) null);
              num2 = 28;
              continue;
            case 49:
              if (entityMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 27 : 12;
                continue;
              }
              goto case 47;
            case 51:
              index3 = 0;
              num2 = 57;
              continue;
            case 54:
              propertyName2 = CustomPropertyProjection.GetExpressionFromString(aliases[index2], out resClassName2);
              num2 = 68;
              continue;
            case 56:
              setter1 = tuple1.setters[index3];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 24 : 10;
              continue;
            case 57:
            case 66:
              if (index3 >= aliases.Length)
              {
                num2 = 70;
                continue;
              }
              goto case 21;
            case 58:
label_12:
              if (setterArray1[index2] == null)
              {
                num2 = 17;
                continue;
              }
              goto case 63;
            case 59:
              obj1 = NHibernate.Cfg.Environment.BytecodeProvider.ObjectsFactory.CreateInstance(AliasToBeanResultTransformer.n9yNWLW47ZLhFx1E3fcu(t), true);
              goto label_134;
            case 60:
              if (index1 >= 0)
              {
                num2 = 79;
                continue;
              }
              goto case 8;
            case 61:
              obj1 = AliasToBeanResultTransformer.nHJWA8W4xBFTggF3QXEK(AliasToBeanResultTransformer.L3YmviW4ADjtBYg8Flmd(AliasToBeanResultTransformer.AkNtr9W4HhI4dtgQtLtx()), AliasToBeanResultTransformer.n9yNWLW47ZLhFx1E3fcu(this.resultClass), true);
              goto label_134;
            case 62:
              t = (Type) null;
              num2 = 60;
              continue;
            case 63:
label_8:
              ISetter setter2 = setterArray1[index2];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 50 : 12;
              continue;
            case 65:
              if (v != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto label_81;
            case 67:
              constructorInfo = (ConstructorInfo) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 62 : 34;
              continue;
            case 68:
              type2 = (Type) null;
              num2 = 13;
              continue;
            case 69:
              if (b == null)
              {
                num2 = 40;
                continue;
              }
              goto case 44;
            case 70:
              goto label_146;
            case 71:
              this.collectionProperties.Add(new KeyValuePair<string, string>(resClassName1, propertyName1));
              num2 = 41;
              continue;
            case 72:
              if (this.IsCompatible(ref v, type1))
              {
                num3 = 20;
                break;
              }
              goto case 65;
            case 74:
              try
              {
                ISetter[] setterArray3 = setterArray1;
                int index5 = index2;
                IPropertyAccessor propertyAccessor1 = this.propertyAccessor;
                Type type7 = t;
                if ((object) type7 == null)
                  type7 = this.resultClass;
                string str1 = propertyName2;
                object obj4 = AliasToBeanResultTransformer.XvmH9yW4t29pLJtQnebc((object) propertyAccessor1, type7, (object) str1);
                setterArray3[index5] = (ISetter) obj4;
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      Type[] typeArray2 = typeArray1;
                      int index6 = index2;
                      IPropertyAccessor propertyAccessor2 = this.propertyAccessor;
                      Type type8 = t;
                      Type type9 = (object) type8 == null ? this.resultClass : type8;
                      string str2 = propertyName2;
                      Type returnType = ((IGetter) AliasToBeanResultTransformer.TUIp52W4wRnh0mwV4g6Q((object) propertyAccessor2, type9, (object) str2)).ReturnType;
                      typeArray2[index6] = returnType;
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_12;
                  }
                }
              }
              catch
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                    goto label_12;
                }
              }
            case 75:
              // ISSUE: type reference
              if (!AliasToBeanResultTransformer.zsjG9CW4WaMipc9tDsy1(type1, AliasToBeanResultTransformer.qr6GjHW4OFaA6xQGOR3l(__typeref (Guid?))))
              {
                num2 = 45;
                continue;
              }
              goto case 36;
            case 76:
              Dictionary<Type, (ISetter[] setters, Type[] types)> settersDict3 = this.settersDict;
              Type type10 = t;
              Type key3 = (object) type10 == null ? this.resultClass : type10;
              tuple1 = settersDict3[key3];
              num2 = 51;
              continue;
            case 77:
              if (service != null)
              {
                num3 = 12;
                break;
              }
              goto case 27;
            case 78:
              setterArray1 = new ISetter[aliases.Length];
              num2 = 10;
              continue;
            case 79:
              if (tuple[index1] == null)
              {
                num2 = 84;
                continue;
              }
              goto case 33;
            case 80:
              if (!(setter1 != null & flag))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 11 : 82;
                continue;
              }
              goto case 15;
            case 81:
              resClassName2 = "";
              num3 = 54;
              break;
            case 83:
              index2 = 0;
              num2 = 52;
              continue;
            case 86:
              if (AliasToBeanResultTransformer.D97k2JW4pVloGwJ1IK6W((object) resClassName2))
              {
                num2 = 18;
                continue;
              }
              goto case 11;
            case 87:
              b = v as byte[];
              num2 = 69;
              continue;
            default:
              if (type1.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 7 : 16;
                continue;
              }
              goto label_81;
          }
label_3:
          num2 = num3;
          continue;
label_81:
          num4 = 0;
          goto label_137;
label_134:
          target = obj1;
          num3 = 76;
          goto label_3;
label_137:
          flag = num4 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 28 : 80;
        }
      }
      catch (InstantiationException ex)
      {
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num9 = 0;
        switch (num9)
        {
          default:
            throw new HibernateException((string) AliasToBeanResultTransformer.nCsKAlW4y9Y3IyonjtOd((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123771672), (object) this.resultClass), (Exception) ex);
        }
      }
      catch (MethodAccessException ex)
      {
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
          num10 = 0;
        switch (num10)
        {
          default:
            throw new HibernateException((string) AliasToBeanResultTransformer.nCsKAlW4y9Y3IyonjtOd(AliasToBeanResultTransformer.DhoOTWW4oy6kWawS3xbo(589593376 ^ -1977315327 ^ -1459435081), (object) this.resultClass), (Exception) ex);
        }
      }
label_146:
      return target;
    }

    private bool IsCompatible(ref object v, Type propType)
    {
      int num1 = 2;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propType = AliasToBeanResultTransformer.ebSw4MW4MOEag92iIt3d(propType);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            flag = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_18;
          default:
            goto label_3;
        }
      }
label_3:
      try
      {
        flag = v.GetType().IsCompatibleWith(propType);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              v = AliasToBeanResultTransformer.i7XMW2W4JcoR0te0Jtdg(v, propType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_18;
            case 3:
              if (v != null)
              {
                num2 = 4;
                continue;
              }
              goto label_18;
            case 4:
              if (!flag)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                continue;
              }
              goto label_18;
            default:
              flag = true;
              num2 = 2;
              continue;
          }
        }
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_18;
            default:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_18:
      return flag;
    }

    internal static void l2jVVfW4BmC5Vy0I0GUZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zsjG9CW4WaMipc9tDsy1([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object DhoOTWW4oy6kWawS3xbo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Jypf7NW4b8wRma5mm8GE([In] object obj0, [In] object obj1) => (ConstructorInfo) obj0 == (ConstructorInfo) obj1;

    internal static bool lAgvM4Wwzx8uB3v3HHP5() => AliasToBeanResultTransformer.SbUN4MWwctUX4cPeBsdI == null;

    internal static AliasToBeanResultTransformer RDcqEvW4Fl2LjxCWeFAL() => AliasToBeanResultTransformer.SbUN4MWwctUX4cPeBsdI;

    internal static int icvAraW4h3YtJYXr2IiJ([In] object obj0) => ((List<KeyValuePair<string, string>>) obj0).Count;

    internal static object kO7tvZW4Gljol1qyDr9s([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object VHbhwyW4EOw1ZiYlAmkD([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object ooogC5W4ffNkmWMVQKnW([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static Type iUAx1dW4QXZxCxdSIy5Y(Type type) => type.GetTypeWithoutProxy();

    internal static object Fds08qW4CdHaQmJwmrfC(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool Fi2BHrW4vDXKP1rQkReS([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool YAFkWCW48Z1LW2im9vj2([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object EC84S4W4ZrLmwNPFLktC([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static Guid bXT2dPW4ueVFtwROiJ9W([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object drkn88W4IfumbFFW9iqI([In] object obj0, [In] Type obj1) => (object) ((ISession) obj0).CreateCriteria(obj1);

    internal static RelationType dyor5uW4VnL1vO7i00JZ([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static object dh55CKW4SlpTRJDXtQoK([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object yN0fvlW4iPxpVsWHuTPP([In] object obj0) => (object) ((EntitySettings) obj0).ParentColumnName;

    internal static object O8WorIW4R1e3Wg9ejTOs([In] object obj0) => (object) ((EntitySettings) obj0).ChildColumnName;

    internal static object fj99eNW4qAHaOptLgTyu([In] object obj0) => (object) ((EntitySettings) obj0).RelationTableName;

    internal static object QsqJWwW4KlZgkOXF9JEl([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object eXfK8GW4XiMWmJmD8Fe6([In] object obj0) => (object) Expression.Sql((string) obj0);

    internal static object noT9jIW4TYVHGyTIh2BO([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object uKtBQMW4kBaKiORLTOZC([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2);

    internal static object M3mBhxW4n26btH84xD5Y([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static Type qr6GjHW4OFaA6xQGOR3l([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool bPOZlAW42Goe6toveDbO([In] object obj0, [In] object obj1) => (ConstructorInfo) obj0 != (ConstructorInfo) obj1;

    internal static object umRXpIW4e86OLcRmk8eX([In] object obj0, [In] object obj1) => ((ConstructorInfo) obj0).Invoke((object[]) obj1);

    internal static void CJrLnmW4PU0iZ3y7MfoF([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool GmLHJvW41xkMnDcFQ26c([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void hFMMIaW4NSjNln6lXp9D([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool VsC7TxW43wrjXn6fAWJ5([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static bool D97k2JW4pVloGwJ1IK6W([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Guid OnUrfOW4ajMJ2h3cesPs([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool DCpoVlW4DEnGW8wUYGX6([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object XvmH9yW4t29pLJtQnebc([In] object obj0, [In] Type obj1, [In] object obj2) => (object) ((IPropertyAccessor) obj0).GetSetter(obj1, (string) obj2);

    internal static object TUIp52W4wRnh0mwV4g6Q([In] object obj0, [In] Type obj1, [In] object obj2) => (object) ((IPropertyAccessor) obj0).GetGetter(obj1, (string) obj2);

    internal static object iF0dDWW4401GLUiVwxmQ([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Type hdusqUW46NbFHdm0IlV8([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object AkNtr9W4HhI4dtgQtLtx() => (object) NHibernate.Cfg.Environment.BytecodeProvider;

    internal static object L3YmviW4ADjtBYg8Flmd([In] object obj0) => (object) ((IBytecodeProvider) obj0).ObjectsFactory;

    internal static Type n9yNWLW47ZLhFx1E3fcu(Type t) => InterfaceActivator.TypeOf(t);

    internal static object nHJWA8W4xBFTggF3QXEK([In] object obj0, [In] Type obj1, [In] bool obj2) => ((IObjectsFactory) obj0).CreateInstance(obj1, obj2);

    internal static void ipwS1rW40RDhAydB4esg([In] object obj0, [In] object obj1, [In] object obj2) => ((ISetter) obj0).Set(obj1, obj2);

    internal static bool clAWPvW4mYpngSlfHxxi(Type type) => type.IsAssignableFromNull();

    internal static object nCsKAlW4y9Y3IyonjtOd([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Type ebSw4MW4MOEag92iIt3d(Type type) => type.GetNonNullableType();

    internal static object i7XMW2W4JcoR0te0Jtdg([In] object obj0, [In] Type obj1) => Convert.ChangeType(obj0, obj1);
  }
}
