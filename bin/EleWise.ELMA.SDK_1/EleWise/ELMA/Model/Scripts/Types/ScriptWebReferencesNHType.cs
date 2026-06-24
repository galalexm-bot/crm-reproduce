// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.ScriptWebReferencesNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;

namespace EleWise.ELMA.Model.Scripts.Types
{
  /// <summary>Тип "Список ссылок на веб-сервисы" для NHibernate</summary>
  [Serializable]
  public class ScriptWebReferencesNHType : XmlSerializableType<List<ScriptWebReference>>
  {
    internal static ScriptWebReferencesNHType I1W8Skbk0PQOOK4TK5dg;

    protected override void SaveObjectToStream(Stream stream, List<ScriptWebReference> obj)
    {
      using (XmlWriter writer = XmlWriter.Create(stream))
        ClassSerializationHelper.SerializeObjectByXml((object) new ScriptWebReferencesNHType.Container()
        {
          Items = obj
        }, writer, false);
    }

    protected override List<ScriptWebReference> LoadObjectFromStream(Stream stream)
    {
      using (XmlReader reader = XmlReader.Create(stream))
        return ((ScriptWebReferencesNHType.Container) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<ScriptWebReferencesNHType.Container>.Raw, reader, false))?.Items;
    }

    public ScriptWebReferencesNHType()
    {
      ScriptWebReferencesNHType.gwCdXqbkMaeYMukTeTF6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void gwCdXqbkMaeYMukTeTF6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rPOec2bkmdlRTnAEfvU4() => ScriptWebReferencesNHType.I1W8Skbk0PQOOK4TK5dg == null;

    internal static ScriptWebReferencesNHType zaCSeBbkyKRUHCxHZ46u() => ScriptWebReferencesNHType.I1W8Skbk0PQOOK4TK5dg;

    /// <summary>Контейнер для списка ссылок на веб-сборки</summary>
    public class Container
    {
      internal static ScriptWebReferencesNHType.Container dPMYa6C3wMIVgU8lKEh5;

      /// <summary>Элементы</summary>
      public List<ScriptWebReference> Items { get; set; }

      public Container()
      {
        ScriptWebReferencesNHType.Container.tIVyB0C3HEdlMK7Edrax();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void tIVyB0C3HEdlMK7Edrax() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool QdOUmVC34Ua5N7D0J3Gc() => ScriptWebReferencesNHType.Container.dPMYa6C3wMIVgU8lKEh5 == null;

      internal static ScriptWebReferencesNHType.Container MFdn2IC36EotyZa2SZh3() => ScriptWebReferencesNHType.Container.dPMYa6C3wMIVgU8lKEh5;
    }

    /// <summary>
    /// Соглашение для типа "Список ссылок на веб-сервисы" для NHibernate
    /// </summary>
    public class Convention : AutoRegisterUserTypeConvention<ScriptWebReferencesNHType>
    {
      internal static ScriptWebReferencesNHType.Convention WqIL0YC3A5juJgmu7X2k;

      public Convention()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool g0IXw4C37GS3ngHdOeJc() => ScriptWebReferencesNHType.Convention.WqIL0YC3A5juJgmu7X2k == null;

      internal static ScriptWebReferencesNHType.Convention Xww1OnC3xfQjYLrbDnXf() => ScriptWebReferencesNHType.Convention.WqIL0YC3A5juJgmu7X2k;
    }
  }
}
