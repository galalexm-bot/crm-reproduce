// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.TZSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EleWise.ELMA
{
  /// <summary>Настройки преобразования времени</summary>
  [Serializable]
  public sealed class TZSettings : ISerializable, IXmlSerializable
  {
    private static TZSettings c7PWgnCKJjQQedmMcdy;

    public TZSettings()
    {
      TZSettings.aBk3piCkYNXCyTplKJy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public TZSettings(TZSettings.TZType type, int offset)
    {
      TZSettings.aBk3piCkYNXCyTplKJy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Offset = offset;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
    }

    public TZSettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num1 = 1;
      switch (num1)
      {
        case 1:
          try
          {
            this.Type = (TZSettings.TZType) TZSettings.Vr3C5xCOyU9xE3TJW5R((object) info, TZSettings.EqMiVQCn5lCURYZYeZR(-649342099 - -1150814748 ^ 501474671));
            int num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
              num2 = 0;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_6;
                default:
                  this.Offset = TZSettings.Vr3C5xCOyU9xE3TJW5R((object) info, TZSettings.EqMiVQCn5lCURYZYeZR(-951514650 ^ -951504620));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
                  continue;
              }
            }
label_6:
            break;
          }
          catch (Exception ex)
          {
            int num3 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
              num3 = 0;
            switch (num3)
            {
              default:
                throw new InvalidOperationException((string) TZSettings.oMh1BiC2PZhjq9IcQ8a(TZSettings.EqMiVQCn5lCURYZYeZR(1597012150 ^ 1596998068)));
            }
          }
      }
    }

    /// <summary>Тип преобразования времени</summary>
    public TZSettings.TZType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Смещение часового пояса</summary>
    public int Offset
    {
      get => this.\u003COffset\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003COffset\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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

    private bool Equals(TZSettings other)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Type == TZSettings.KvG6lNCejSv788ePRRo((object) other))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.Offset == TZSettings.VDMcnYCP9H15ekToASp((object) other);
label_5:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if ((object) this == obj)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
              continue;
            }
            if ((object) (obj as TZSettings) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            if (obj != null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          case 4:
            goto label_6;
          case 5:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return this.Equals((TZSettings) obj);
label_5:
      return false;
label_6:
      return false;
label_9:
      return true;
    }

    public override int GetHashCode() => (int) this.Type * 397 ^ this.Offset.GetHashCode();

    public static bool operator ==(TZSettings left, TZSettings right) => TZSettings.NZ18kNC1dctm4u19D1F((object) left, (object) right);

    public static bool operator !=(TZSettings left, TZSettings right) => !TZSettings.NZ18kNC1dctm4u19D1F((object) left, (object) right);

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      switch (1)
      {
        case 1:
          try
          {
            TZSettings.xAp5SvCN5QarlTB6F2L((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218960300), (int) this.Type);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_4;
                default:
                  TZSettings.xAp5SvCN5QarlTB6F2L((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870902587), this.Offset);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
                  continue;
              }
            }
label_4:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              num = 0;
            switch (num)
            {
              default:
                throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108643508)));
            }
          }
      }
    }

    public XmlSchema GetSchema() => (XmlSchema) null;

    public void ReadXml(XmlReader reader)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            if (reader.IsEmptyElement)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
label_16:
            TZSettings.hIk6aPCDtQ53rpRs1w0((object) reader);
            num1 = 5;
            continue;
          case 4:
            TZSettings.klTrcvC3gfcbBSWYYBv((object) reader);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_9;
          default:
            try
            {
              this.Type = (TZSettings.TZType) TZSettings.fI4pd0Ca1PewOQPEaVv(TZSettings.DroV9JCpJWteN4r9e0t((object) reader, TZSettings.EqMiVQCn5lCURYZYeZR(1052221104 - 768835541 ^ 283387453)));
              int num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.Offset = Convert.ToInt32((string) TZSettings.DroV9JCpJWteN4r9e0t((object) reader, TZSettings.EqMiVQCn5lCURYZYeZR(-2138160520 ^ -2138146166)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_16;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  throw new InvalidOperationException((string) TZSettings.oMh1BiC2PZhjq9IcQ8a(TZSettings.EqMiVQCn5lCURYZYeZR(--1418440330 ^ 1418434440)));
              }
            }
        }
      }
label_13:
      return;
label_9:;
    }

    public void WriteXml(XmlWriter writer)
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            XmlWriter xmlWriter1 = writer;
            object obj = TZSettings.EqMiVQCn5lCURYZYeZR(-1380439818 << 3 ^ 1841397590);
            num2 = (int) this.Type;
            string str1 = num2.ToString();
            TZSettings.xybpCfCtH6UjkQbSA4H((object) xmlWriter1, obj, (object) str1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            XmlWriter xmlWriter2 = writer;
            string str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712486725);
            num2 = this.Offset;
            string str3 = num2.ToString();
            TZSettings.xybpCfCtH6UjkQbSA4H((object) xmlWriter2, (object) str2, (object) str3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void aBk3piCkYNXCyTplKJy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool kRZWZcCXrI86mg71t4h() => (object) TZSettings.c7PWgnCKJjQQedmMcdy == null;

    internal static TZSettings HsBqC1CTdScvbUkGUoE() => TZSettings.c7PWgnCKJjQQedmMcdy;

    internal static object EqMiVQCn5lCURYZYeZR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int Vr3C5xCOyU9xE3TJW5R([In] object obj0, [In] object obj1) => ((SerializationInfo) obj0).GetInt32((string) obj1);

    internal static object oMh1BiC2PZhjq9IcQ8a([In] object obj0) => (object) SR.T((string) obj0);

    internal static TZSettings.TZType KvG6lNCejSv788ePRRo([In] object obj0) => ((TZSettings) obj0).Type;

    internal static int VDMcnYCP9H15ekToASp([In] object obj0) => ((TZSettings) obj0).Offset;

    internal static bool NZ18kNC1dctm4u19D1F([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static void xAp5SvCN5QarlTB6F2L([In] object obj0, [In] object obj1, [In] int obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void klTrcvC3gfcbBSWYYBv([In] object obj0) => ((XmlReader) obj0).ReadStartElement();

    internal static object DroV9JCpJWteN4r9e0t([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).ReadElementString((string) obj1);

    internal static int fI4pd0Ca1PewOQPEaVv([In] object obj0) => int.Parse((string) obj0);

    internal static void hIk6aPCDtQ53rpRs1w0([In] object obj0) => ((XmlReader) obj0).ReadEndElement();

    internal static void xybpCfCtH6UjkQbSA4H([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlWriter) obj0).WriteElementString((string) obj1, (string) obj2);

    /// <summary>
    /// Тип преобразования времени при представлении пользователю и обратно при биндинге
    /// </summary>
    public enum TZType
    {
      /// <summary>Не преобразовывать</summary>
      WithoutOffset = -2, // 0xFFFFFFFE
      /// <summary>
      /// Преобразование времени с учетом произвольного смещения часового пояса
      /// </summary>
      Custom = -1, // 0xFFFFFFFF
      /// <summary>
      /// Преобразование времени с учетом часового пояса текущего пользователя
      /// </summary>
      Client = 0,
      /// <summary>
      /// Преобразование времени с учетом часового пояса приложения
      /// </summary>
      Runtime = 1,
      /// <summary>
      /// Преобразование времени с учетом часового пояса сервера
      /// </summary>
      Server = 2,
    }
  }
}
