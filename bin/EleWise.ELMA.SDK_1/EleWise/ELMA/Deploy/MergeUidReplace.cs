// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.MergeUidReplace
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy
{
  /// <summary>
  /// Класс для описания списков заменяемых уникальных идентификаторов объектов
  /// </summary>
  internal class MergeUidReplace
  {
    private IDictionary<Guid, Guid> uidReplace;
    private static MergeUidReplace bHwFUgE2jnLNjWptqGhS;

    /// <summary>Точки расширения для замены Uid объектов</summary>
    public List<IUidReplaceExtension> UidReplaceExtensions { get; set; }

    /// <summary>Конструктор</summary>
    public MergeUidReplace()
    {
      MergeUidReplace.YaWCPgE2U22umV0RMCBA();
      this.uidReplace = (IDictionary<Guid, Guid>) new Dictionary<Guid, Guid>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            goto label_3;
          case 2:
            this.UidReplaceExtensions = ComponentManager.Current.GetExtensionPoints<IUidReplaceExtension>().ToList<IUidReplaceExtension>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
            continue;
          case 3:
            if (this.UidReplaceExtensions != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          default:
            goto label_8;
        }
      }
label_6:
      return;
label_3:
      return;
label_8:;
    }

    /// <summary>
    /// Инициализация класса
    /// <param name="reader">Средство для чтения</param>
    /// </summary>
    internal void Init(XmlReader reader)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Dictionary<string, Dictionary<string, object>> propValues;
          Dictionary<string, object> propValuesR;
          IEnumerator<IUidReplaceExtension> enumerator1;
          Guid typeUid;
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (MergeUidReplace.wnhBDPE2c8wIaaOMkDau((object) reader, MergeUidReplace.ASEyVBE2sTjUcT8d8ybj(-1334993905 ^ -1335021433)))
              {
                MergeUidReplace.vpJdaaE2zexH4XYxH116((object) reader);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 15 : 37;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 3:
              propValues = new Dictionary<string, Dictionary<string, object>>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 8 : 6;
              continue;
            case 4:
            case 33:
              if (MergeUidReplace.KdnYK5EeCnGJvaUb89VW((object) reader) == XmlNodeType.EndElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 26;
                continue;
              }
              goto case 5;
            case 5:
              if (!MergeUidReplace.XtwMRUEeB7XAEdM4FAi0((object) reader))
              {
                num2 = 27;
                continue;
              }
              goto case 36;
            case 6:
              goto label_72;
            case 7:
            case 15:
            case 29:
              reader.Skip();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 19 : 19;
              continue;
            case 8:
              propValues.Add(ConfigurationImportExecutor.RegularProperty, new Dictionary<string, object>());
              num2 = 16;
              continue;
            case 9:
            case 23:
              if (MergeUidReplace.KdnYK5EeCnGJvaUb89VW((object) reader) == XmlNodeType.EndElement)
              {
                num2 = 6;
                continue;
              }
              goto case 21;
            case 10:
              propValues = new EntityXmlSerializer().XmlEntityRead(reader, propValues, typeUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 31 : 40;
              continue;
            case 11:
              if (!MergeUidReplace.gIdfdPEeF6aHMRFKrG88((object) reader))
                goto case 30;
              else
                goto label_67;
            case 12:
              if (Guid.TryParse((string) MergeUidReplace.XbV0FyEehZSTmde0Pbll((object) reader, MergeUidReplace.ASEyVBE2sTjUcT8d8ybj(322893104 - -1992822529 ^ -1979234733)), out typeUid))
              {
                num2 = 18;
                continue;
              }
              break;
            case 13:
              int num3 = (int) MergeUidReplace.Ndaty3EeGOaND3Vf4JSF((object) reader);
              num2 = 3;
              continue;
            case 14:
            case 19:
              int num4 = (int) MergeUidReplace.Ndaty3EeGOaND3Vf4JSF((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 9 : 2;
              continue;
            case 16:
              propValues.Add(ConfigurationImportExecutor.XmlProperty, new Dictionary<string, object>());
              num2 = 10;
              continue;
            case 17:
              MergeUidReplace.vpJdaaE2zexH4XYxH116((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 32 : 31;
              continue;
            case 18:
              goto label_73;
            case 20:
              // ISSUE: reference to a compiler-generated method
              enumerator1 = this.UidReplaceExtensions.Where<IUidReplaceExtension>((Func<IUidReplaceExtension, bool>) (ex => MergeUidReplace.\u003C\u003Ec__DisplayClass6_0.Y7kgOK8T8yEARXH0ApI3((object) ex, typeUid))).GetEnumerator();
              num2 = 31;
              continue;
            case 21:
              if (MergeUidReplace.XtwMRUEeB7XAEdM4FAi0((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 31 : 35;
                continue;
              }
              goto case 7;
            case 24:
              goto label_22;
            case 25:
              if (reader.IsEmptyElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 26 : 29;
                continue;
              }
              goto case 17;
            case 26:
              goto label_29;
            case 28:
              int content1 = (int) reader.MoveToContent();
              num2 = 23;
              continue;
            case 30:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 34 : 9;
              continue;
            case 31:
              try
              {
label_47:
                if (MergeUidReplace.hLyWCSEeEQEQNg59tIwa((object) enumerator1))
                  goto label_49;
                else
                  goto label_48;
label_31:
                IDictionary<Guid, Guid> dictionary;
                IEnumerator<Guid> enumerator2;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      enumerator2 = dictionary.Keys.GetEnumerator();
                      num5 = 6;
                      continue;
                    case 2:
                      if (dictionary == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    case 3:
                      goto label_49;
                    case 4:
                      goto label_4;
                    case 6:
                      goto label_34;
                    default:
                      goto label_47;
                  }
                }
label_34:
                try
                {
label_38:
                  if (MergeUidReplace.hLyWCSEeEQEQNg59tIwa((object) enumerator2))
                    goto label_36;
                  else
                    goto label_39;
label_35:
                  Guid current;
                  int num6;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        this.SetUidReplace(current, dictionary[current]);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_36;
                      case 3:
                        goto label_47;
                      default:
                        goto label_38;
                    }
                  }
label_36:
                  current = enumerator2.Current;
                  num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  {
                    num6 = 1;
                    goto label_35;
                  }
                  else
                    goto label_35;
label_39:
                  num6 = 3;
                  goto label_35;
                }
                finally
                {
                  int num7;
                  if (enumerator2 == null)
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
                  else
                    goto label_44;
label_43:
                  switch (num7)
                  {
                    case 1:
                    case 2:
                  }
label_44:
                  MergeUidReplace.aHpc5oEefsEwiDfrOiae((object) enumerator2);
                  num7 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                  {
                    num7 = 1;
                    goto label_43;
                  }
                  else
                    goto label_43;
                }
label_48:
                num5 = 4;
                goto label_31;
label_49:
                dictionary = enumerator1.Current.Replace(propValuesR);
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                {
                  num5 = 2;
                  goto label_31;
                }
                else
                  goto label_31;
              }
              finally
              {
                int num8;
                if (enumerator1 == null)
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
                else
                  goto label_55;
label_54:
                switch (num8)
                {
                  case 2:
                    break;
                  default:
                }
label_55:
                enumerator1.Dispose();
                num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                {
                  num8 = 1;
                  goto label_54;
                }
                else
                  goto label_54;
              }
            case 32:
              int content2 = (int) reader.MoveToContent();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 4 : 0;
              continue;
            case 34:
              MergeUidReplace.pJvUQ7EebMwumqp7TRvd((object) reader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951497852));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 12 : 7;
              continue;
            case 35:
              if (!MergeUidReplace.m2P4MvEeoW9cskyaukA1(MergeUidReplace.cZA3agEeWcysTE0LId7v((object) reader), MergeUidReplace.ASEyVBE2sTjUcT8d8ybj(-2099751081 ^ -2099508933)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 11 : 15;
                continue;
              }
              goto case 25;
            case 36:
              if (!((string) MergeUidReplace.cZA3agEeWcysTE0LId7v((object) reader) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372480549)))
              {
                num2 = 38;
                continue;
              }
              goto case 11;
            case 37:
              if (!MergeUidReplace.gIdfdPEeF6aHMRFKrG88((object) reader))
              {
                reader.Read();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 10 : 28;
                continue;
              }
              num2 = 24;
              continue;
            case 39:
              int num9 = (int) MergeUidReplace.Ndaty3EeGOaND3Vf4JSF((object) reader);
              num2 = 33;
              continue;
            case 40:
              propValuesR = propValues[ConfigurationImportExecutor.RegularProperty];
              num2 = 20;
              continue;
          }
label_4:
          MergeUidReplace.IGO6PlEeQT8ZlWpkxpyh((object) reader);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 10 : 39;
        }
label_29:
        MergeUidReplace.vpJdaaE2zexH4XYxH116((object) reader);
        num1 = 14;
        continue;
label_67:
        num1 = 22;
        continue;
label_73:
        MergeUidReplace.vpJdaaE2zexH4XYxH116((object) reader);
        num1 = 13;
      }
label_9:
      return;
label_72:
      return;
label_22:;
    }

    /// <summary>
    /// Добавление уникального идентификатора объекта для замены
    /// </summary>
    /// <param name="uidFrom">Уникальный идентификатор объекта, который заменяем</param>
    /// <param name="uidTo">Уникальный идентификатор объекта, на который выполняем замену</param>
    /// <returns></returns>
    private void SetUidReplace(Guid uidFrom, Guid uidTo)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            this.uidReplace.Add(uidFrom, uidTo);
            num = 6;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (MergeUidReplace.aOGI6vEevtjcN43sbk9v(uidFrom, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 3;
              continue;
            }
            goto case 7;
          case 5:
            goto label_3;
          case 6:
            goto label_10;
          case 7:
            if (!MergeUidReplace.aOGI6vEevtjcN43sbk9v(uidTo, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            if (!this.uidReplace.ContainsKey(uidFrom))
            {
              num = 2;
              continue;
            }
            goto label_9;
        }
      }
label_7:
      return;
label_2:
      return;
label_3:
      return;
label_10:
      return;
label_9:
      return;
label_6:;
    }

    /// <summary>
    /// Получение замещающего значения уникального идентификатора объекта
    /// </summary>
    /// <param name="uidFrom">Уникальный идентификатор объекта</param>
    /// <returns></returns>
    internal Guid GetUidReplace(Guid uidFrom)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.uidReplace.ContainsKey(uidFrom))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return uidFrom;
label_3:
      return this.uidReplace[uidFrom];
    }

    internal static void YaWCPgE2U22umV0RMCBA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Qdao74E2YR41KaBHn0yF() => MergeUidReplace.bHwFUgE2jnLNjWptqGhS == null;

    internal static MergeUidReplace XlbkyBE2Lvps522yGViS() => MergeUidReplace.bHwFUgE2jnLNjWptqGhS;

    internal static object ASEyVBE2sTjUcT8d8ybj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wnhBDPE2c8wIaaOMkDau([In] object obj0, [In] object obj1) => ((XmlReader) obj0).ReadToNextSibling((string) obj1);

    internal static bool vpJdaaE2zexH4XYxH116([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool gIdfdPEeF6aHMRFKrG88([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static bool XtwMRUEeB7XAEdM4FAi0([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object cZA3agEeWcysTE0LId7v([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool m2P4MvEeoW9cskyaukA1([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool pJvUQ7EebMwumqp7TRvd([In] object obj0, [In] object obj1) => ((XmlReader) obj0).MoveToAttribute((string) obj1);

    internal static object XbV0FyEehZSTmde0Pbll([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static XmlNodeType Ndaty3EeGOaND3Vf4JSF([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static bool hLyWCSEeEQEQNg59tIwa([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void aHpc5oEefsEwiDfrOiae([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void IGO6PlEeQT8ZlWpkxpyh([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType KdnYK5EeCnGJvaUb89VW([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool aOGI6vEevtjcN43sbk9v([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
