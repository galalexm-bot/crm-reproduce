// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntitySerializationFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Serialization
{
  public class EntitySerializationFunctions
  {
    internal static EntitySerializationFunctions jZrwQEBljB57v1RKldYc;

    /// <summary>
    /// Фильтр текущего сериализуемого свойства. Вернуть <c>true</c> если надо применять функцию сериализации
    /// </summary>
    public Func<object, ClassMetadata, PropertyMetadata, EntitySerializationSettings, bool> Filter { get; set; }

    /// <summary>Функция сериализации</summary>
    public Func<ISerializableTypeDescriptor, object, ClassMetadata, PropertyMetadata, EntitySerializationSettings, IDictionary<string, object>> Serialize { get; set; }

    /// <summary>
    /// Функция создания копии для новых настроек сериализации. Используется при рекурсивном разборе свойств по селектору
    /// </summary>
    public Func<EntitySerializationFunctions, object, ClassMetadata, IPropertyMetadata, EntitySerializationSettings, EntitySerializationSettings, EntitySerializationFunctions> CopyForSettings { get; set; }

    public EntitySerializationFunctions()
    {
      EntitySerializationFunctions.SubniiBlUtO4ZIWqjMWS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void SubniiBlUtO4ZIWqjMWS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JKanKkBlYUhRIPw84MVt() => EntitySerializationFunctions.jZrwQEBljB57v1RKldYc == null;

    internal static EntitySerializationFunctions uMCx7QBlLM4Dc9AyRH6g() => EntitySerializationFunctions.jZrwQEBljB57v1RKldYc;
  }
}
