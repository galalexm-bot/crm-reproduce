// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.EntityMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Mappings
{
  internal class EntityMetadataMap : NamedMetadataMap<EntityMetadata>
  {
    internal static EntityMetadataMap nEm3Q2hbLV9sSqLk874x;

    public EntityMetadataMap()
    {
      EntityMetadataMap.wSps1EhbcPi6WookGukD();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) EntityMetadataMap.bDZF7FhbzBwV15xVERNh(-710283084 ^ -537863435 ^ 173783437));
      int num1 = 10;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), (string) EntityMetadataMap.bDZF7FhbzBwV15xVERNh(-675505729 ^ -675523737));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityMetadata, Guid>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression1, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_TypeUid))), parameterExpression1));
            num1 = 3;
            continue;
          case 2:
            ParameterExpression parameterExpression2 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(typeof (EntityMetadata), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(-1426456882 ^ 2009939514 ^ -583792084));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityMetadata, bool>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression2, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_Hierarchical))), parameterExpression2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1925118608 << 2 ^ -889511784));
            // ISSUE: method reference
            Expression<Func<EntityMetadata, System.Collections.Generic.List<TableView>>> property1 = Expression.Lambda<Func<EntityMetadata, System.Collections.Generic.List<TableView>>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression3, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (ClassMetadata.get_TableViews))), parameterExpression3);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_5;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_5 = mapping1 = (Action<IPropertyMapper>) (p => p.Type<TableViewsNHType>());
            }
            else
              goto label_27;
label_16:
            this.Property<System.Collections.Generic.List<TableView>>(property1, mapping1);
            num1 = 4;
            continue;
label_27:
            mapping1 = action1;
            goto label_16;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = Expression.Parameter(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647927058));
            // ISSUE: method reference
            Expression<Func<EntityMetadata, DataClassMetadata>> property2 = Expression.Lambda<Func<EntityMetadata, DataClassMetadata>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityMetadata.get_ViewModelMetadata))), parameterExpression4);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_7;
            Action<IPropertyMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_7 = mapping2 = (Action<IPropertyMapper>) (p => p.Type<XmlSerializableType<DataClassMetadata>>());
            }
            else
              goto label_28;
label_19:
            this.Property<DataClassMetadata>(property2, mapping2);
            num1 = 8;
            continue;
label_28:
            mapping2 = action2;
            goto label_19;
          case 5:
            goto label_23;
          case 6:
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1470998129 - 231418599 ^ 1239593298));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<EntityMetadata, string>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression5, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityMetadata.get_TableName))), parameterExpression5), (Action<IPropertyMapper>) (p =>
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
                    EntityMetadataMap.\u003C\u003Ec.QBE3bjCrasI7X42fYYOb((object) p, (int) byte.MaxValue);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
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
          case 7:
            ParameterExpression parameterExpression6 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(typeof (EntityMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979500902));
            // ISSUE: method reference
            this.Property<short>(Expression.Lambda<Func<EntityMetadata, short>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression6, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_LastTableNumber))), parameterExpression6));
            num1 = 15;
            continue;
          case 8:
            ParameterExpression parameterExpression7 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(typeof (EntityMetadata), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(~-306453669 ^ 306501244));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityMetadata, Guid>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression7, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (ClassMetadata.get_TitlePropertyUid))), parameterExpression7));
            num1 = 6;
            continue;
          case 9:
            // ISSUE: type reference
            ParameterExpression parameterExpression8 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(-244066886 - -48452443 ^ -195566643));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityMetadata, Guid>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression8, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_IsGroupPropertyUid))), parameterExpression8));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 14;
            continue;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression9 = Expression.Parameter(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), (string) EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1033719030 - 2012070891 ^ -978369581));
            // ISSUE: method reference
            Expression<Func<EntityMetadata, string>> property3 = Expression.Lambda<Func<EntityMetadata, string>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression9, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ClassMetadata.get_Namespace))), parameterExpression9);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action3 = EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IPropertyMapper> mapping3;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_1 = mapping3 = (Action<IPropertyMapper>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Length(int.MaxValue);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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
              goto label_29;
label_13:
            this.Property<string>(property3, mapping3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 16 : 16;
            continue;
label_29:
            mapping3 = action3;
            goto label_13;
          case 11:
            // ISSUE: type reference
            ParameterExpression parameterExpression10 = Expression.Parameter(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597026926));
            // ISSUE: method reference
            this.Set<TablePartMetadata>(Expression.Lambda<Func<EntityMetadata, IEnumerable<TablePartMetadata>>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression10, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityMetadata.get_EntityTableParts))), parameterExpression10), (Action<ISetPropertiesMapper<EntityMetadata, TablePartMetadata>>) (c =>
            {
              c.Cascade(Cascade.All);
              c.Key((Action<IKeyMapper<EntityMetadata>>) (k => k.Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138592646))));
            }), (Action<ICollectionElementRelation<TablePartMetadata>>) (m => m.OneToMany()));
            num1 = 5;
            continue;
          case 12:
            // ISSUE: type reference
            ParameterExpression parameterExpression11 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1242972401 >> 4 ^ 77704919));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<EntityMetadata, bool>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression11, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityMetadata.get_Filterable))), parameterExpression11));
            num1 = 2;
            continue;
          case 13:
            ParameterExpression parameterExpression12 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(typeof (EntityMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837648733));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityMetadata, Guid>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression12, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_ParentPropertyUid))), parameterExpression12));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 9 : 2;
            continue;
          case 14:
            // ISSUE: type reference
            ParameterExpression parameterExpression13 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979199767));
            // ISSUE: method reference
            Expression<Func<EntityMetadata, IEnumerable<EntityPropertyMetadata>>> property4 = Expression.Lambda<Func<EntityMetadata, IEnumerable<EntityPropertyMetadata>>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression13, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_EntityProperties))), parameterExpression13);
            // ISSUE: reference to a compiler-generated field
            Action<ICollectionElementRelation<EntityPropertyMetadata>> action4 = EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_21;
            Action<ICollectionElementRelation<EntityPropertyMetadata>> mapping4;
            if (action4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_21 = mapping4 = (Action<ICollectionElementRelation<EntityPropertyMetadata>>) (m => m.OneToMany());
            }
            else
              goto label_30;
label_25:
            this.Set<EntityPropertyMetadata>(property4, (Action<ISetPropertiesMapper<EntityMetadata, EntityPropertyMetadata>>) (c =>
            {
              c.Cascade(Cascade.All);
              c.Key((Action<IKeyMapper<EntityMetadata>>) (k => k.Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317952096))));
            }), mapping4);
            num1 = 11;
            continue;
label_30:
            mapping4 = action4;
            goto label_25;
          case 15:
            // ISSUE: type reference
            ParameterExpression parameterExpression14 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1917256330 ^ 1917306962));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<EntityMetadata, Guid>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression14, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (ClassMetadata.get_BaseClassUid))), parameterExpression14));
            num1 = 12;
            continue;
          case 16:
            // ISSUE: type reference
            ParameterExpression parameterExpression15 = (ParameterExpression) EntityMetadataMap.WEB4vZhhWHwriNguiYVR(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1178210108 ^ 1178256868));
            // ISSUE: method reference
            this.Property<long>(Expression.Lambda<Func<EntityMetadata, long>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression15, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (ClassMetadata.get_GroupId))), parameterExpression15));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
            continue;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression16 = Expression.Parameter(EntityMetadataMap.b4bWw3hhFSVcGIyIWdaa(__typeref (EntityMetadata)), (string) EntityMetadataMap.bDZF7FhbzBwV15xVERNh(1142330761 ^ 1541959139 ^ 536752818));
            // ISSUE: method reference
            this.Property<HierarchyType>(Expression.Lambda<Func<EntityMetadata, HierarchyType>>((Expression) EntityMetadataMap.flqsMEhhBWsLl2KFgAgb((object) parameterExpression16, (object) (MethodInfo) EntityMetadataMap.anHMkhhhonn4GCS6NiKR(__methodref (EntityMetadata.get_HierarchyType))), parameterExpression16), (Action<IPropertyMapper>) (p =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_4;
                  case 1:
                    IPropertyMapper propertyMapper = p;
                    // ISSUE: reference to a compiler-generated field
                    Action<IColumnMapper> action5 = EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_25;
                    Action<IColumnMapper> columnMapper;
                    if (action5 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      EntityMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_25 = columnMapper = (Action<IColumnMapper>) (c =>
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
                              // ISSUE: reference to a compiler-generated method
                              EntityMetadataMap.\u003C\u003Ec.eWDGtoCrtQkO6BlckWcC((object) c, EntityMetadataMap.\u003C\u003Ec.bxy5tWCrD7Cj2FyqvhHh(-87337865 ^ -87434431));
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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
                      goto label_7;
label_6:
                    propertyMapper.Column(columnMapper);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                    continue;
label_7:
                    columnMapper = action5;
                    goto label_6;
                  default:
                    goto label_2;
                }
              }
label_4:
              return;
label_2:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 8 : 13;
            continue;
        }
      }
label_23:;
    }

    internal static void wSps1EhbcPi6WookGukD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object bDZF7FhbzBwV15xVERNh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type b4bWw3hhFSVcGIyIWdaa([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object flqsMEhhBWsLl2KFgAgb([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object WEB4vZhhWHwriNguiYVR([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object anHMkhhhonn4GCS6NiKR([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static bool ikRKGshbUm4kiRnPDaqI() => EntityMetadataMap.nEm3Q2hbLV9sSqLk874x == null;

    internal static EntityMetadataMap gMS6nShbsVgnwKW4aAOb() => EntityMetadataMap.nEm3Q2hbLV9sSqLk874x;
  }
}
