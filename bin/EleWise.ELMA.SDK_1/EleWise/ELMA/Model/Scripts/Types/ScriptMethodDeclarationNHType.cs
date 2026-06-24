// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.ScriptMethodDeclarationNHType
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
  public class ScriptMethodDeclarationNHType : XmlSerializableType<List<ScriptMethodDeclaration>>
  {
    internal static ScriptMethodDeclarationNHType MCuHjWbTZAiFr8LAp4dP;

    protected override void SaveObjectToStream(Stream stream, List<ScriptMethodDeclaration> obj)
    {
      using (XmlWriter writer = XmlWriter.Create(stream))
        ClassSerializationHelper.SerializeObjectByXml((object) new ScriptMethodDeclarationNHType.Container()
        {
          Items = obj
        }, writer, false);
    }

    protected override List<ScriptMethodDeclaration> LoadObjectFromStream(Stream stream)
    {
      using (XmlReader reader = XmlReader.Create(stream))
        return ((ScriptMethodDeclarationNHType.Container) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<ScriptMethodDeclarationNHType.Container>.Raw, reader, false))?.Items;
    }

    public ScriptMethodDeclarationNHType()
    {
      ScriptMethodDeclarationNHType.Bm07LDbTVV6oNm3BU8he();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void Bm07LDbTVV6oNm3BU8he() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool QXKjv3bTuibelJXdMueJ() => ScriptMethodDeclarationNHType.MCuHjWbTZAiFr8LAp4dP == null;

    internal static ScriptMethodDeclarationNHType ABkF75bTInmqqiRorPWG() => ScriptMethodDeclarationNHType.MCuHjWbTZAiFr8LAp4dP;

    /// <summary>Контейнер для списка ссылок на веб-сборки</summary>
    public class Container
    {
      internal static ScriptMethodDeclarationNHType.Container XRDb1eCNcxEvi4lO2jpg;

      /// <summary>Элементы</summary>
      public List<ScriptMethodDeclaration> Items { get; set; }

      public Container()
      {
        ScriptMethodDeclarationNHType.Container.GkJpIFC3B5BMh4rXHOwG();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void GkJpIFC3B5BMh4rXHOwG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool WQRnUwCNzAowF35oqNNX() => ScriptMethodDeclarationNHType.Container.XRDb1eCNcxEvi4lO2jpg == null;

      internal static ScriptMethodDeclarationNHType.Container M4GMtMC3FpOJJLMGn1PL() => ScriptMethodDeclarationNHType.Container.XRDb1eCNcxEvi4lO2jpg;
    }

    /// <summary>
    /// Соглашение для типа "Список ссылок на веб-сервисы" для NHibernate
    /// </summary>
    public class Convention : AutoRegisterUserTypeConvention<ScriptMethodDeclarationNHType>
    {
      internal static ScriptMethodDeclarationNHType.Convention M22sqoC3WJFsFdi42B0b;

      public Convention()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool spbXLeC3oNWRYnMpiHy7() => ScriptMethodDeclarationNHType.Convention.M22sqoC3WJFsFdi42B0b == null;

      internal static ScriptMethodDeclarationNHType.Convention v8aXxKC3bDNssFmyAwNe() => ScriptMethodDeclarationNHType.Convention.M22sqoC3WJFsFdi42B0b;
    }
  }
}
