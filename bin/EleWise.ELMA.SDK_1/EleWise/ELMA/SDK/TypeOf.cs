// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.SDK.TypeOf
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Reflection.Extensions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.SDK
{
  /// <summary>typeof(T)</summary>
  public static class TypeOf
  {
    /// <summary>
    /// typeof(<see cref="T:EleWise.ELMA.Extensions.EnumerableExtensions" />)
    /// </summary>
    public static readonly RipeType EnumerableExtensions;
    /// <summary>
    /// typeof(<see cref="T:EleWise.ELMA.Services.Locator" />)
    /// </summary>
    public static readonly RipeType Locator;
    /// <summary>
    /// typeof(<see cref="T:EleWise.ELMA.Model.Services.InterfaceActivator" />)
    /// </summary>
    public static readonly RipeType InterfaceActivator;
    /// <summary>
    /// typeof(<see cref="!:Entity&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType Entity1;
    /// <summary>
    /// typeof(<see cref="!:EntityDynamic&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType EntityDynamic1;
    /// <summary>
    /// typeof(<see cref="!:EntityManager&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType EntityManager1;
    /// <summary>
    /// typeof(<see cref="!:EntityManager&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType EntityManager2;
    /// <summary>
    /// typeof(<see cref="!:EntityImplManager&lt;,,&gt;" />)
    /// </summary>
    public static readonly RipeType EntityImplManager3;
    /// <summary>
    /// typeof(<see cref="!:IEntity&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType IEntity1;
    /// <summary>
    /// typeof(<see cref="!:IEntityManager&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType IEntityManager1;
    /// <summary>
    /// typeof(<see cref="!:IEntityManager&lt;,&gt;" />)
    /// </summary>
    public static readonly RipeType IEntityManager2;
    /// <summary>
    /// typeof(<see cref="!:EnumBaseConverter&lt;&gt;" />)
    /// </summary>
    public static readonly RipeType EnumBaseConverter1;
    internal static TypeOf Dxrdpa27uMDej64mJNW;

    static TypeOf()
    {
      int num = 6;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            TypeOf.InterfaceActivator = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EleWise.ELMA.Model.Services.InterfaceActivator)));
            num = 3;
            continue;
          case 2:
            // ISSUE: type reference
            TypeOf.IEntityManager1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (IEntityManager<>)));
            num = 4;
            continue;
          case 3:
            // ISSUE: type reference
            TypeOf.Entity1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (Entity<>)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 11 : 12;
            continue;
          case 4:
            // ISSUE: type reference
            TypeOf.IEntityManager2 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (IEntityManager<,>)));
            num = 9;
            continue;
          case 5:
            TypeOf.EnumerableExtensions = typeof (EleWise.ELMA.Extensions.EnumerableExtensions).ToRipeType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 13 : 10;
            continue;
          case 6:
            TypeOf.h8IT8b2mlOIwoA9UfJt();
            num = 5;
            continue;
          case 7:
            goto label_2;
          case 8:
            TypeOf.EntityManager1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(typeof (EntityManager<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 9:
            // ISSUE: type reference
            TypeOf.EnumBaseConverter1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EnumBaseConverter<>)));
            num = 7;
            continue;
          case 10:
            // ISSUE: type reference
            TypeOf.EntityImplManager3 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EntityImplManager<,,>)));
            num = 11;
            continue;
          case 11:
            TypeOf.IEntity1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(typeof (IEntity<>));
            num = 2;
            continue;
          case 12:
            // ISSUE: type reference
            TypeOf.EntityDynamic1 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EntityDynamic<>)));
            num = 8;
            continue;
          case 13:
            // ISSUE: type reference
            TypeOf.Locator = TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EleWise.ELMA.Services.Locator)).ToRipeType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          default:
            // ISSUE: type reference
            TypeOf.EntityManager2 = (RipeType) TypeOf.BwTcTC2McFdZPr5MujO(TypeOf.utRnEh2ywFjdVTVnHEB(__typeref (EntityManager<,>)));
            num = 10;
            continue;
        }
      }
label_2:;
    }

    internal static void h8IT8b2mlOIwoA9UfJt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type utRnEh2ywFjdVTVnHEB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object BwTcTC2McFdZPr5MujO(Type type) => (object) type.ToRipeType();

    internal static bool vrxQQS2xAm9hQp8kb5Q() => TypeOf.Dxrdpa27uMDej64mJNW == null;

    internal static TypeOf jH8tjd20qXqZRehF5IY() => TypeOf.Dxrdpa27uMDej64mJNW;
  }
}
