// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.TypeSettingsNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Model.Mappings
{
  [Serializable]
  public class TypeSettingsNHType : XmlSerializableType<TypeSettings>
  {
    private static ConcurrentDictionary<string, Type> settingsTypes;
    private static TypeSettingsNHType NIBfndhhEySYDQ3ojsLf;

    protected override void SaveObjectToStream(Stream stream, TypeSettings obj)
    {
      int num1 = 1;
      StreamWriter streamWriter;
      while (true)
      {
        switch (num1)
        {
          case 1:
            streamWriter = new StreamWriter(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_23;
          default:
            goto label_2;
        }
      }
label_23:
      return;
label_2:
      try
      {
        TypeSettingsNHType.xPSnT3hhCdIGR8G2u93H((object) streamWriter, (object) obj.GetType().Name);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num2 = 0;
        XmlWriter writer;
        while (true)
        {
          switch (num2)
          {
            case 1:
              writer = (XmlWriter) TypeSettingsNHType.RmCyQohhv7j0ZrZ1MNWq((object) streamWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        try
        {
          ClassSerializationHelper.SerializeObjectByXml((object) obj, writer);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          int num4;
          if (writer == null)
            num4 = 2;
          else
            goto label_16;
label_13:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_16:
          TypeSettingsNHType.p8lJI2hh8l09EBvE3ebk((object) writer);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          {
            num4 = 0;
            goto label_13;
          }
          else
            goto label_13;
        }
      }
      finally
      {
        if (streamWriter != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_25;
              default:
                TypeSettingsNHType.p8lJI2hh8l09EBvE3ebk((object) streamWriter);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_25:;
      }
    }

    protected override TypeSettings LoadObjectFromStream(Stream stream) => (TypeSettings) TypeSettingsNHType.XGV75JhhZbKncT40MLiP((object) stream);

    public static TypeSettings LoadTypeSettings(Stream stream)
    {
      int num1 = 1;
      StreamReader streamReader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            streamReader = new StreamReader(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_27;
          default:
            goto label_3;
        }
      }
label_3:
      TypeSettings typeSettings;
      try
      {
        string str = (string) TypeSettingsNHType.WlZ3o2hhuZfU9KE4FhC3((object) streamReader);
        int num2 = 3;
        XmlTextReader reader;
        Type orAdd;
        while (true)
        {
          switch (num2)
          {
            case 1:
              streamReader.CheckAndCorrectInternalBOMSymbols();
              num2 = 2;
              continue;
            case 2:
              reader = new XmlTextReader((TextReader) streamReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            case 3:
              ConcurrentDictionary<string, Type> settingsTypes = TypeSettingsNHType.settingsTypes;
              string key = str;
              // ISSUE: reference to a compiler-generated field
              Func<string, Type> func = TypeSettingsNHType.\u003C\u003Ec.\u003C\u003E9__3_0;
              Func<string, Type> valueFactory;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                TypeSettingsNHType.\u003C\u003Ec.\u003C\u003E9__3_0 = valueFactory = (Func<string, Type>) (name =>
                {
                  int num3 = 2;
                  string name1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        name1 = name;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: type reference
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  Type type = ((IEnumerable<Type>) TypeSettingsNHType.\u003C\u003Ec.d0sGZYCrjmec1pis0uB7(TypeSettingsNHType.\u003C\u003Ec.ULmJFVCr5PCObIVnolYb())).Where<Type>((Func<Type, bool>) (t => TypeSettingsNHType.\u003C\u003Ec.hCldELCrLx7qD8tZYSp2(__typeref (TypeSettings)).IsAssignableFrom(t))).FirstOrDefault<Type>((Func<Type, bool>) (t => TypeSettingsNHType.\u003C\u003Ec__DisplayClass3_0.jVfKHICr9Lgeu70iIeGu(TypeSettingsNHType.\u003C\u003Ec__DisplayClass3_0.UOmZpACrJJ4Zgo5NMDgc((object) t), (object) name1)));
                  // ISSUE: reference to a compiler-generated method
                  return !TypeSettingsNHType.\u003C\u003Ec.JsnTXsCrYaoIOcF2LJqW(type, (Type) null) ? type : throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082167482), (object) name1));
                });
              }
              else
                goto label_28;
label_10:
              orAdd = settingsTypes.GetOrAdd(key, valueFactory);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
              continue;
label_28:
              valueFactory = func;
              goto label_10;
            default:
              goto label_11;
          }
        }
label_11:
        try
        {
          typeSettings = (TypeSettings) ClassSerializationHelper.DeserializeObjectByXml(orAdd, (XmlReader) reader);
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
            num4 = 0;
          switch (num4)
          {
          }
        }
        finally
        {
          if (reader != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
              num5 = 1;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  reader.Dispose();
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_20;
              }
            }
          }
label_20:;
        }
      }
      finally
      {
        int num6;
        if (streamReader == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
        else
          goto label_24;
label_23:
        switch (num6)
        {
          case 2:
            break;
          default:
        }
label_24:
        TypeSettingsNHType.p8lJI2hh8l09EBvE3ebk((object) streamReader);
        num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        {
          num6 = 0;
          goto label_23;
        }
        else
          goto label_23;
      }
label_27:
      return typeSettings;
    }

    public TypeSettingsNHType()
    {
      TypeSettingsNHType.fxck99hhI7AEt8KSQEe1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TypeSettingsNHType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeSettingsNHType.fxck99hhI7AEt8KSQEe1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TypeSettingsNHType.settingsTypes = new ConcurrentDictionary<string, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void xPSnT3hhCdIGR8G2u93H([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static object RmCyQohhv7j0ZrZ1MNWq([In] object obj0) => (object) XmlWriter.Create((TextWriter) obj0);

    internal static void p8lJI2hh8l09EBvE3ebk([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool fjGY29hhfhmh1YcNjRTq() => TypeSettingsNHType.NIBfndhhEySYDQ3ojsLf == null;

    internal static TypeSettingsNHType OxKEcwhhQEsYB0Wb6T3q() => TypeSettingsNHType.NIBfndhhEySYDQ3ojsLf;

    internal static object XGV75JhhZbKncT40MLiP([In] object obj0) => (object) TypeSettingsNHType.LoadTypeSettings((Stream) obj0);

    internal static object WlZ3o2hhuZfU9KE4FhC3([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static void fxck99hhI7AEt8KSQEe1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>
    /// Convention for NHibernate custom type TypeSettingsNHType
    /// </summary>
    public class Convention : AutoRegisterUserTypeConvention<TypeSettingsNHType>
    {
      private static TypeSettingsNHType.Convention YEqLB6CrHXOvSk4EMnjk;

      public Convention()
      {
        TypeSettingsNHType.Convention.eE3i3vCrx70x7xSnWYxH();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void eE3i3vCrx70x7xSnWYxH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool gLtRkLCrA6C2qFLrrCaL() => TypeSettingsNHType.Convention.YEqLB6CrHXOvSk4EMnjk == null;

      internal static TypeSettingsNHType.Convention JkskBECr7wjs3V2dNpyS() => TypeSettingsNHType.Convention.YEqLB6CrHXOvSk4EMnjk;
    }
  }
}
