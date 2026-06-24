// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.AssemblyReferenceNHType
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
  [Serializable]
  public class AssemblyReferenceNHType : XmlSerializableType<List<AssemblyReference>>
  {
    internal static AssemblyReferenceNHType OlR5UfbTa7ufwpSBWskk;

    protected override void SaveObjectToStream(Stream stream, List<AssemblyReference> obj)
    {
      using (XmlWriter writer = XmlWriter.Create(stream))
        ClassSerializationHelper.SerializeObjectByXml((object) new AssemblyReferenceNHType.Container()
        {
          Items = obj
        }, writer);
    }

    protected override List<AssemblyReference> LoadObjectFromStream(Stream stream)
    {
      using (XmlReader reader = XmlReader.Create(stream))
        return ((AssemblyReferenceNHType.Container) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<AssemblyReferenceNHType.Container>.Raw, reader))?.Items;
    }

    public AssemblyReferenceNHType()
    {
      AssemblyReferenceNHType.qw8TkobTwW0bjvLkqTUE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void qw8TkobTwW0bjvLkqTUE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jR5W99bTDjL8992Aoky6() => AssemblyReferenceNHType.OlR5UfbTa7ufwpSBWskk == null;

    internal static AssemblyReferenceNHType tY1oX4bTtAcQYFIrvyMd() => AssemblyReferenceNHType.OlR5UfbTa7ufwpSBWskk;

    /// <summary>Контейнер для списка ссылок на веб-сборки</summary>
    public class Container
    {
      internal static AssemblyReferenceNHType.Container MDG9e1C3hgBZgLcVpFvM;

      /// <summary>Элементы</summary>
      public List<AssemblyReference> Items { get; set; }

      public Container()
      {
        AssemblyReferenceNHType.Container.p7S4gkC3f7dBewlxEbkX();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void p7S4gkC3f7dBewlxEbkX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sscPZUC3GXSV3CHnbnoa() => AssemblyReferenceNHType.Container.MDG9e1C3hgBZgLcVpFvM == null;

      internal static AssemblyReferenceNHType.Container Uu2bw5C3Ewhy76qOsmwG() => AssemblyReferenceNHType.Container.MDG9e1C3hgBZgLcVpFvM;
    }

    /// <summary>
    /// Соглашение для типа "Список ссылок на веб-сервисы" для NHibernate
    /// </summary>
    public class Convention : AutoRegisterUserTypeConvention<AssemblyReferenceNHType>
    {
      internal static AssemblyReferenceNHType.Convention AkqkukC3Qa2rW1C6PA4Q;

      public Convention()
      {
        AssemblyReferenceNHType.Convention.i0I8wjC38Y3cqY6lnYfg();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void i0I8wjC38Y3cqY6lnYfg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sjcwrPC3CIqSlEn3so2A() => AssemblyReferenceNHType.Convention.AkqkukC3Qa2rW1C6PA4Q == null;

      internal static AssemblyReferenceNHType.Convention fNb8YOC3vJSOJGAgiYZH() => AssemblyReferenceNHType.Convention.AkqkukC3Qa2rW1C6PA4Q;
    }
  }
}
