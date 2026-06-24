// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.RootCodeItemCollectionNH
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  [Serializable]
  public class RootCodeItemCollectionNH : XmlSerializableType<RootCodeItemCollection>
  {
    internal static RootCodeItemCollectionNH r5MmFEZY1VG0r9kCigk;

    protected override void SaveObjectToStream(Stream stream, RootCodeItemCollection obj)
    {
      int num1 = 2;
      XmlWriter writer;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_3;
          case 2:
            writer = XmlWriter.Create(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          default:
            goto label_11;
        }
      }
label_12:
      return;
label_11:
      return;
label_3:
      try
      {
        ClassSerializationHelper.SerializeObjectByXml((object) new RootCodeItemCollectionNH.Container()
        {
          RootItem = obj
        }, writer);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (writer == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
        else
          goto label_13;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_13:
        RootCodeItemCollectionNH.eJtNm5ZsnrRclDgHJ77((object) writer);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    protected override RootCodeItemCollection LoadObjectFromStream(Stream stream)
    {
      int num1 = 2;
      XmlTextReader reader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            reader = new XmlTextReader(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      RootCodeItemCollection rootItem;
      try
      {
        rootItem = ((RootCodeItemCollectionNH.Container) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<RootCodeItemCollectionNH.Container>.Raw, (XmlReader) reader)).RootItem;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (reader == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
        else
          goto label_8;
label_7:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_8:
        RootCodeItemCollectionNH.eJtNm5ZsnrRclDgHJ77((object) reader);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        {
          num3 = 1;
          goto label_7;
        }
        else
          goto label_7;
      }
label_12:
      return rootItem;
    }

    public RootCodeItemCollectionNH()
    {
      RootCodeItemCollectionNH.MdUGWSZcTnwLfYrxOlW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void eJtNm5ZsnrRclDgHJ77([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool zcN1hFZLqE3swKFkO5Q() => RootCodeItemCollectionNH.r5MmFEZY1VG0r9kCigk == null;

    internal static RootCodeItemCollectionNH tTrAkUZUtuNR3HdS3lE() => RootCodeItemCollectionNH.r5MmFEZY1VG0r9kCigk;

    internal static void MdUGWSZcTnwLfYrxOlW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Контейнер для списка ссылок на веб-сборки</summary>
    [Component]
    public class Container : IXsiRoot
    {
      private static RootCodeItemCollectionNH.Container e4O0TVfxFZinURDf0qGw;

      /// <summary>Элементы</summary>
      public RootCodeItemCollection RootItem
      {
        get => this.\u003CRootItem\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CRootItem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public Container()
      {
        RootCodeItemCollectionNH.Container.vs9CTbfxodrSR5fNjOtt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool OHtvc2fxBKMheY0glfgI() => RootCodeItemCollectionNH.Container.e4O0TVfxFZinURDf0qGw == null;

      internal static RootCodeItemCollectionNH.Container gertiqfxWD8p6eQgMq42() => RootCodeItemCollectionNH.Container.e4O0TVfxFZinURDf0qGw;

      internal static void vs9CTbfxodrSR5fNjOtt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    /// <summary>Соглашение для типа "RootCodeItem" для NHibernate</summary>
    public class Convention : AutoRegisterUserTypeConvention<RootCodeItemCollectionNH>
    {
      private static RootCodeItemCollectionNH.Convention hSVUd2fxbyEF8HeKa10K;

      public Convention()
      {
        RootCodeItemCollectionNH.Convention.f1XcUYfxEuW0Tgfr4UjI();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void f1XcUYfxEuW0Tgfr4UjI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool mPcEsSfxhMlF0CKyuopn() => RootCodeItemCollectionNH.Convention.hSVUd2fxbyEF8HeKa10K == null;

      internal static RootCodeItemCollectionNH.Convention kxRrXQfxGjmdM61LrQCs() => RootCodeItemCollectionNH.Convention.hSVUd2fxbyEF8HeKa10K;
    }
  }
}
