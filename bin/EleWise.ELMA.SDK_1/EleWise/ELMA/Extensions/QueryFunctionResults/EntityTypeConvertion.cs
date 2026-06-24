// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.QueryFunctionResults.EntityTypeConvertion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.QueryFunctionResults
{
  /// <summary>Конвертер для сущностей</summary>
  [Component]
  public class EntityTypeConvertion : IQueryTypeConvertion
  {
    internal static EntityTypeConvertion vmke9hGmKaAqLoq1OJr3;

    /// <inheritdoc />
    public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType) => EntityTypeConvertion.WJoh7kGmkTn5s54iSVuY(__typeref (IEntity)).IsAssignableFrom(valueType);

    /// <inheritdoc />
    public object ConvertValue(EntityMetadata metadata, string propName, object value) => EntityTypeConvertion.Mgp9u3Gmnfc50n89HZKF((object) (IEntity) value);

    public EntityTypeConvertion()
    {
      EntityTypeConvertion.HpWgJGGmOsNIL2i4ERkM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type WJoh7kGmkTn5s54iSVuY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool TYGY82GmXAtnTyrk7HgT() => EntityTypeConvertion.vmke9hGmKaAqLoq1OJr3 == null;

    internal static EntityTypeConvertion VepC1aGmTtVrGLJvTMte() => EntityTypeConvertion.vmke9hGmKaAqLoq1OJr3;

    internal static object Mgp9u3Gmnfc50n89HZKF([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void HpWgJGGmOsNIL2i4ERkM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
