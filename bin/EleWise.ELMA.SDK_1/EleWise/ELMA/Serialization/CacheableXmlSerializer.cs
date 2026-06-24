// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.CacheableXmlSerializer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Cache;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Класс для создания XML-сериализаторов с возможностью кэширования (для увеличения быстродействия)
  /// </summary>
  internal static class CacheableXmlSerializer
  {
    private static Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer> serializers;
    private static Dictionary<string, Assembly> assemblies;
    private static CacheableXmlSerializer nvehrCBdrUFLTQgtEimw;

    /// <summary>Создать сериализатор</summary>
    /// <param name="type">Тип</param>
    /// <param name="useExtra">Использовать дополнительные типы</param>
    /// <returns></returns>
    public static EleWise.ELMA.XmlSerializers.XmlSerializer Create(Type type, bool useExtra)
    {
      int num1 = 8;
      Type[] extraTypes;
      Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer> serializers;
      bool lockTaken1;
      EleWise.ELMA.XmlSerializers.XmlSerializer xmlSerializer1;
      string key1;
      string str1;
      while (true)
      {
        object obj1;
        object obj2;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_5;
          case 3:
            key1 = type.AssemblyQualifiedName + str1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 4:
            obj1 = (object) "";
            goto label_95;
          case 5:
            lockTaken1 = false;
            num1 = 2;
            continue;
          case 6:
            goto label_88;
          case 7:
            if (!useExtra)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 11 : 7;
              continue;
            }
            obj2 = CacheableXmlSerializer.kXRA5DBdLVlqunwS15wt(CacheableXmlSerializer.QGNJGGBdYKxSrt2Hhq0i());
            break;
          case 8:
            Contract.ArgumentNotNull((object) type, (string) CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(589593376 ^ -1977315327 ^ -1459558653));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 7 : 7;
            continue;
          case 9:
            if (!useExtra)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 4;
              continue;
            }
            obj1 = CacheableXmlSerializer.unNqCFBds5AxSA0vlQwW(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(964881585 - -1459193222 ^ -1870893211), (object) (extraTypes == null ? 0 : extraTypes.Length));
            goto label_95;
          case 10:
            goto label_89;
          case 11:
            obj2 = (object) null;
            break;
          case 12:
            if (CacheableXmlSerializer.YYgSbLBdUSiovoaHY15s())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 8 : 9;
              continue;
            }
            goto label_2;
          default:
            if (CacheableXmlSerializer.serializers.TryGetValue(key1, out xmlSerializer1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 9 : 10;
              continue;
            }
            serializers = CacheableXmlSerializer.serializers;
            num1 = 5;
            continue;
        }
        extraTypes = (Type[]) obj2;
        num1 = 12;
        continue;
label_95:
        str1 = (string) obj1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 3 : 2;
      }
label_2:
      return new EleWise.ELMA.XmlSerializers.XmlSerializer(type, CacheableXmlSerializer.GetOverrides((object) new Type[1]
      {
        type
      }, (IEnumerable<Type>) extraTypes), extraTypes, (XmlRootAttribute) null, (string) null, (string) null);
label_5:
      EleWise.ELMA.XmlSerializers.XmlSerializer xmlSerializer2;
      try
      {
        Monitor.Enter((object) serializers, ref lockTaken1);
        int num2 = 13;
        while (true)
        {
          Dictionary<string, Assembly> assemblies;
          Type[] types;
          Type[] source;
          bool lockTaken2;
          string key2;
          Assembly assembly;
          string str2;
          int num3;
          switch (num2)
          {
            case 1:
              goto label_66;
            case 2:
              if (CacheableXmlSerializer.assemblies.TryGetValue(key2, out assembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 15 : 6;
                continue;
              }
              goto case 16;
            case 3:
            case 5:
              str2 = CacheableXmlSerializer.GetXmlSerializerCacheKey(type, (object) extraTypes);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 9 : 22;
              continue;
            case 4:
            case 15:
label_60:
              if (CacheableXmlSerializer.tHY3yDBlZaeEtV3umLtK((object) assembly, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 1;
                continue;
              }
              xmlSerializer1 = (EleWise.ELMA.XmlSerializers.XmlSerializer) CacheableXmlSerializer.KBsJkgBlueU1YmebJNGa((object) assembly, type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 8 : 12;
              continue;
            case 6:
              types = source;
              num2 = 19;
              continue;
            case 7:
              xmlSerializer2 = xmlSerializer1;
              num2 = 18;
              continue;
            case 8:
              if (source != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 14 : 4;
                continue;
              }
              num3 = 0;
              break;
            case 9:
              source = (Type[]) CacheableXmlSerializer.M9YpqyBdcVZFRVbJgjUU(CacheableXmlSerializer.QGNJGGBdYKxSrt2Hhq0i());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 8 : 4;
              continue;
            case 10:
label_71:
              str2 = (string) CacheableXmlSerializer.qhi2f0Bdz10DVJI7pnZN(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(901793403 ^ 901854235), extraTypes != null ? CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(-2099751081 ^ -2099698397) : (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 6 : 5;
              continue;
            case 11:
              xmlSerializer2 = xmlSerializer1;
              num2 = 20;
              continue;
            case 12:
              CacheableXmlSerializer.serializers[key1] = xmlSerializer1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 7 : 2;
              continue;
            case 13:
              if (CacheableXmlSerializer.serializers.TryGetValue(key1, out xmlSerializer1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 11 : 11;
                continue;
              }
              goto case 9;
            case 14:
              num3 = ((IEnumerable<Type>) source).Contains<Type>(type) ? 1 : 0;
              break;
            case 16:
              assemblies = CacheableXmlSerializer.assemblies;
              num2 = 17;
              continue;
            case 17:
              lockTaken2 = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 21 : 11;
              continue;
            case 18:
            case 20:
              goto label_88;
            case 21:
              try
              {
                Monitor.Enter((object) assemblies, ref lockTaken2);
                int num4 = 7;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                  num4 = 9;
                string assemblyFileName;
                string str3;
                string str4;
                IEnumerator<string> enumerator;
                string serializerHashCode;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      if (!CacheableXmlSerializer.LAqqYYBlouq1seK5jaYT((object) assemblyFileName))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 5;
                    case 3:
                      str3 = (string) CacheableXmlSerializer.EHKdiPBlBuMhX3S901Re(CacheableXmlSerializer.uMBberBlFLbwLFS7Ywf1((object) ComponentManager.Current), CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(1925118608 << 2 ^ -889546556));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 8 : 7;
                      continue;
                    case 4:
                      assemblyFileName = (string) CacheableXmlSerializer.EHKdiPBlBuMhX3S901Re((object) str3, (object) str4);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                      continue;
                    case 5:
                      assembly = (Assembly) CacheableXmlSerializer.EW4UESBlbUOGoX5Pum03((object) assemblyFileName);
                      num4 = 11;
                      continue;
                    case 6:
                      str4 = (string) CacheableXmlSerializer.WnApWBBlWXK30aZ5LZCx((object) str2, CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(323422137 << 2 ^ 1293701434), (object) serializerHashCode, CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(333888594 ^ 1075625116 ^ 1408975988));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 1;
                      continue;
                    case 7:
                    case 11:
                      CacheableXmlSerializer.assemblies[key2] = assembly;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 10 : 14;
                      continue;
                    case 8:
                      serializerHashCode = CacheableXmlSerializer.GetSerializerHashCode((object) types, (object) extraTypes);
                      num4 = 6;
                      continue;
                    case 9:
                      if (!CacheableXmlSerializer.assemblies.TryGetValue(key2, out assembly))
                      {
                        num4 = 3;
                        continue;
                      }
                      goto label_60;
                    case 10:
                      try
                      {
label_37:
                        if (CacheableXmlSerializer.B9EwIiBlCqVLTQAItQur((object) enumerator))
                          goto label_29;
                        else
                          goto label_38;
label_28:
                        string current;
                        int num5;
                        switch (num5)
                        {
                          case 1:
                            break;
                          case 2:
                            goto label_37;
                          case 3:
                            try
                            {
                              File.Delete(current);
                              int num6 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                                num6 = 0;
                              switch (num6)
                              {
                                default:
                                  goto label_37;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num7 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                                num7 = 0;
                              while (true)
                              {
                                switch (num7)
                                {
                                  case 1:
                                    goto label_37;
                                  default:
                                    CacheableXmlSerializer.Cim1XCBlQ0vyYpvJKQHj(CacheableXmlSerializer.iNq5MKBlE9GCWkkMZw0v(), CacheableXmlSerializer.PR1RNQBlfKuv0gUi3YSi(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(1470440286 ^ 1470386584), (object) current), (object) ex);
                                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
                                    continue;
                                }
                              }
                            }
                          default:
                            goto label_24;
                        }
label_29:
                        current = enumerator.Current;
                        num5 = 3;
                        goto label_28;
label_38:
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                        goto label_28;
                      }
                      finally
                      {
                        if (enumerator != null)
                        {
                          int num8 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
                            num8 = 0;
                          while (true)
                          {
                            switch (num8)
                            {
                              case 1:
                                goto label_44;
                              default:
                                CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) enumerator);
                                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                                continue;
                            }
                          }
                        }
label_44:;
                      }
                    case 12:
                      enumerator = ((IEnumerable<string>) CacheableXmlSerializer.qTpdboBlGYfnahkViKEQ((object) str3, CacheableXmlSerializer.qhi2f0Bdz10DVJI7pnZN((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105138874)))).Union<string>((IEnumerable<string>) CacheableXmlSerializer.qTpdboBlGYfnahkViKEQ((object) str3, (object) (str2 + (string) CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(-1426456882 ^ 2009939514 ^ -583683520)))).GetEnumerator();
                      num4 = 10;
                      continue;
                    case 13:
label_24:
                      assembly = CacheableXmlSerializer.GenerateAssembly((object) assemblyFileName, (object) types, (object) extraTypes);
                      num4 = 7;
                      continue;
                    case 14:
                      goto label_60;
                    default:
                      if (CacheableXmlSerializer.j0ORf9BlhdZmIhB7jNHR((object) str3))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 10 : 12;
                        continue;
                      }
                      goto case 13;
                  }
                }
              }
              finally
              {
                int num9;
                if (!lockTaken2)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
                else
                  goto label_52;
label_51:
                switch (num9)
                {
                  case 1:
                  case 2:
                }
label_52:
                CacheableXmlSerializer.WwhBblBl82jrZS1x0lf8((object) assemblies);
                num9 = 2;
                goto label_51;
              }
            case 22:
              types = new Type[1]{ type };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            default:
              key2 = (string) CacheableXmlSerializer.qhi2f0Bdz10DVJI7pnZN((object) str2, (object) str1);
              num2 = 2;
              continue;
          }
          if (num3 == 0)
            num2 = 5;
          else
            goto label_71;
        }
label_66:
        throw new InvalidOperationException(EleWise.ELMA.SR.T((string) CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(~-122002947 ^ 121957682), (object) type.FullName));
      }
      finally
      {
        int num10;
        if (!lockTaken1)
          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
        else
          goto label_75;
label_74:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_75:
        CacheableXmlSerializer.WwhBblBl82jrZS1x0lf8((object) serializers);
        num10 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        {
          num10 = 0;
          goto label_74;
        }
        else
          goto label_74;
      }
label_88:
      return xmlSerializer2;
label_89:
      return xmlSerializer1;
    }

    private static string GetXmlSerializerCacheKey(Type type, object extraTypes)
    {
      int num1 = 2;
      SHA1 shA1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            shA1 = SHA1.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      string serializerCacheKey;
      return serializerCacheKey;
label_4:
      try
      {
        serializerCacheKey = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, Type), string>(CacheableXmlSerializer.HR7drMBlIWWf8YsmX5ld((object) Encoding.UTF8, (object) type.FullName), (shA1, type), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (SHA1, Type), string>(CacheableXmlSerializer.GetXmlSerializerCacheKeyAction)) + (extraTypes == null ? "" : z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538465694));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      finally
      {
        int num3;
        if (shA1 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_10:
        shA1.Dispose();
        num3 = 2;
        goto label_9;
      }
    }

    private static string GetXmlSerializerCacheKeyAction(
      object buffer,
      int offset,
      int length,
      (SHA1, Type) param)
    {
      (SHA1 shA1, Type type) = param;
      Encoding.UTF8.GetBytes(type.FullName, 0, type.FullName.Length, (byte[]) buffer, offset);
      return Convert.ToBase64String(shA1.ComputeHash((byte[]) buffer, offset, length)).Replace('/', '#');
    }

    private static string GetSerializerHashCode(object types, object extraTypes)
    {
      int num1 = 4;
      Type[] typeArray;
      List<Assembly> assemblyList;
      Type type1;
      int index;
      Type type2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            typeArray = (Type[]) extraTypes;
            num1 = 22;
            continue;
          case 2:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 14 : 1;
            continue;
          case 3:
            typeArray = (Type[]) types;
            num1 = 2;
            continue;
          case 4:
            assemblyList = new List<Assembly>();
            num1 = 3;
            continue;
          case 5:
            goto label_9;
          case 6:
            ++index;
            num1 = 20;
            continue;
          case 7:
            memoryStream = (MemoryStream) CacheableXmlSerializer.gbnwIHBlVh6EnbniIIK0();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 5;
            continue;
          case 8:
            goto label_3;
          case 9:
            assemblyList.Add(type2.Assembly);
            num1 = 6;
            continue;
          case 10:
          case 18:
            ++index;
            num1 = 15;
            continue;
          case 11:
          case 20:
            if (index < typeArray.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 12:
            if (extraTypes != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
              continue;
            }
            goto case 7;
          case 13:
            assemblyList.Add(type1.Assembly);
            num1 = 10;
            continue;
          case 14:
          case 15:
            if (index >= typeArray.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 10 : 12;
              continue;
            }
            goto case 16;
          case 16:
            type1 = typeArray[index];
            num1 = 21;
            continue;
          case 19:
            if (!assemblyList.Contains(type2.Assembly))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 9;
              continue;
            }
            goto case 6;
          case 21:
            if (assemblyList.Contains(type1.Assembly))
            {
              num1 = 18;
              continue;
            }
            goto case 13;
          case 22:
            index = 0;
            num1 = 11;
            continue;
          default:
            type2 = typeArray[index];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 19 : 10;
            continue;
        }
      }
label_3:
      string serializerHashCode;
      return serializerHashCode;
label_9:
      try
      {
        StreamWriter streamWriter = new StreamWriter((Stream) memoryStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              IEnumerator<Type> enumerator1 = ((IEnumerable<Type>) types).OrderBy<Type, string>((Func<Type, string>) (t => t.AssemblyQualifiedName), (IComparer<string>) CacheableXmlSerializer.wPDgR8BlSCHj9kSF7e0a()).GetEnumerator();
              int num3 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                num3 = 10;
              List<Assembly>.Enumerator enumerator2;
              IEnumerator<string> enumerator3;
              SHA1 shA1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    object source1 = extraTypes;
                    // ISSUE: reference to a compiler-generated field
                    Func<Type, string> func1 = CacheableXmlSerializer.\u003C\u003Ec.\u003C\u003E9__5_1;
                    Func<Type, string> selector;
                    if (func1 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      CacheableXmlSerializer.\u003C\u003Ec.\u003C\u003E9__5_1 = selector = (Func<Type, string>) (t => t.FullName);
                    }
                    else
                      goto label_27;
label_60:
                    IEnumerable<string> source2 = ((IEnumerable<Type>) source1).Select<Type, string>(selector);
                    // ISSUE: reference to a compiler-generated field
                    Func<string, string> func2 = CacheableXmlSerializer.\u003C\u003Ec.\u003C\u003E9__5_2;
                    Func<string, string> keySelector;
                    if (func2 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      CacheableXmlSerializer.\u003C\u003Ec.\u003C\u003E9__5_2 = keySelector = (Func<string, string>) (n => n);
                    }
                    else
                      goto label_28;
label_62:
                    enumerator3 = source2.OrderBy<string, string>(keySelector).GetEnumerator();
                    num3 = 8;
                    continue;
label_28:
                    keySelector = func2;
                    goto label_62;
label_27:
                    selector = func1;
                    goto label_60;
                  case 2:
                    try
                    {
label_36:
                      if (enumerator2.MoveNext())
                        goto label_38;
                      else
                        goto label_37;
label_35:
                      Assembly current;
                      int num4;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_36;
                          case 2:
                            CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, CacheableXmlSerializer.IwgmT7BlRssFLeUZB85s((object) current));
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
                            continue;
                          case 3:
                            goto label_38;
                          default:
                            goto label_32;
                        }
                      }
label_37:
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
                      goto label_35;
label_38:
                      current = enumerator2.Current;
                      num4 = 2;
                      goto label_35;
                    }
                    finally
                    {
                      enumerator2.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                  case 3:
label_32:
                    if (extraTypes == null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 6;
                      continue;
                    }
                    goto case 1;
                  case 4:
                  case 6:
label_44:
                    CacheableXmlSerializer.TIssitBlqDaBkIVmbNTw((object) streamWriter);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                    continue;
                  case 5:
                    shA1 = (SHA1) CacheableXmlSerializer.ySb47kBlXlsQmARssaHe();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 7;
                    continue;
                  case 7:
                    goto label_63;
                  case 8:
                    try
                    {
label_20:
                      if (CacheableXmlSerializer.B9EwIiBlCqVLTQAItQur((object) enumerator3))
                        goto label_22;
                      else
                        goto label_21;
label_19:
                      string current;
                      int num6;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            goto label_44;
                          case 2:
                            goto label_22;
                          case 3:
                            streamWriter.WriteLine(current);
                            num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_20;
                        }
                      }
label_21:
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                      goto label_19;
label_22:
                      current = enumerator3.Current;
                      num6 = 3;
                      goto label_19;
                    }
                    finally
                    {
                      int num7;
                      if (enumerator3 == null)
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                      else
                        goto label_29;
label_26:
                      switch (num7)
                      {
                        case 1:
                          break;
                        default:
                      }
label_29:
                      CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) enumerator3);
                      num7 = 2;
                      goto label_26;
                    }
                  case 9:
label_16:
                    enumerator2 = assemblyList.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 2;
                    continue;
                  case 10:
                    try
                    {
label_50:
                      if (enumerator1.MoveNext())
                        goto label_47;
                      else
                        goto label_51;
label_46:
                      Type current;
                      int num8;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 1:
                            goto label_50;
                          case 2:
                            goto label_16;
                          case 3:
                            goto label_47;
                          default:
                            CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, (object) current.FullName);
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                            continue;
                        }
                      }
label_47:
                      current = enumerator1.Current;
                      num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                      {
                        num8 = 0;
                        goto label_46;
                      }
                      else
                        goto label_46;
label_51:
                      num8 = 2;
                      goto label_46;
                    }
                    finally
                    {
                      int num9;
                      if (enumerator1 == null)
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
                      else
                        goto label_55;
label_54:
                      switch (num9)
                      {
                        case 1:
                        case 2:
                      }
label_55:
                      CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) enumerator1);
                      num9 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                      {
                        num9 = 1;
                        goto label_54;
                      }
                      else
                        goto label_54;
                    }
                  default:
                    CacheableXmlSerializer.cpqaLOBlKXweDpVOtcFU((object) memoryStream, 0L, SeekOrigin.Begin);
                    num3 = 5;
                    continue;
                }
              }
label_63:
              try
              {
                serializerHashCode = (string) CacheableXmlSerializer.iUupafBlkZudIdWlGYq7((object) Convert.ToBase64String((byte[]) CacheableXmlSerializer.Ydd4mhBlTMW2J1NbeYqa((object) shA1, (object) memoryStream)));
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                    goto label_3;
                }
              }
              finally
              {
                int num11;
                if (shA1 == null)
                  num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                else
                  goto label_69;
label_68:
                switch (num11)
                {
                  case 2:
                    break;
                  default:
                }
label_69:
                CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) shA1);
                num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                {
                  num11 = 0;
                  goto label_68;
                }
                else
                  goto label_68;
              }
            }
            finally
            {
              if (streamWriter != null)
              {
                int num12 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
                  num12 = 1;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      streamWriter.Dispose();
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_77;
                  }
                }
              }
label_77:;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num13 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
            num13 = 1;
          while (true)
          {
            switch (num13)
            {
              case 1:
                CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) memoryStream);
                num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              default:
                goto label_83;
            }
          }
        }
label_83:;
      }
    }

    private static EleWise.ELMA.XmlSerializers.XmlAttributeOverrides GetOverrides(
      object types,
      IEnumerable<Type> extraTypes)
    {
      List<Type> source = new List<Type>();
      foreach (Type type1 in (Type[]) types)
      {
        if (typeof (IEnumerable).IsAssignableFrom(type1) && type1.IsGenericType)
        {
          Type type2 = type1.GetInterface(typeof (IEnumerable<>).Name);
          if (type2 != (Type) null)
          {
            Type genericArgument = type2.GetGenericArguments()[0];
            source.Add(genericArgument);
            continue;
          }
        }
        source.Add(type1);
      }
      if (extraTypes != null)
      {
        foreach (Type extraType in extraTypes)
        {
          if (!source.Contains(extraType))
            source.Add(extraType);
        }
      }
      EleWise.ELMA.XmlSerializers.XmlAttributeOverrides overrides = new EleWise.ELMA.XmlSerializers.XmlAttributeOverrides();
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: object of a compiler-generated type is created
      source.SelectMany(t => ((IEnumerable<PropertyInfo>) t.GetReflectionProperties()).Select(p => new \u003C\u003Ef__AnonymousType17<PropertyInfo, XmlForceElementAttribute, XmlForceArrayAttribute, ForceDefaultValueAttribute>(p, AttributeHelper<XmlForceElementAttribute>.GetAttribute((MemberInfo) p, true), AttributeHelper<XmlForceArrayAttribute>.GetAttribute((MemberInfo) p, true), AttributeHelper<ForceDefaultValueAttribute>.GetAttribute((MemberInfo) p, true))).Where(i => i.elementAttribute != null || i.forceArrayAttribute != null || i.defaultValueAttribute != null).Select(i => new \u003C\u003Ef__AnonymousType18<Type, PropertyInfo, XmlForceElementAttribute, XmlForceArrayAttribute, ForceDefaultValueAttribute>(t, i.property, i.elementAttribute, i.forceArrayAttribute, i.defaultValueAttribute))).Each(i =>
      {
        EleWise.ELMA.XmlSerializers.XmlAttributes attributes = new EleWise.ELMA.XmlSerializers.XmlAttributes();
        if (i.elementAttribute != null)
          attributes.XmlElements.Add((XmlElementAttribute) i.elementAttribute);
        if (i.forceArrayAttribute != null)
          attributes.XmlArray = (XmlArrayAttribute) i.forceArrayAttribute;
        if (i.defaultValueAttribute != null)
          attributes.XmlDefaultValue = i.defaultValueAttribute.Value;
        overrides.Add(i.type, i.property.Name, attributes);
      });
      return overrides;
    }

    private static Assembly GenerateAssembly(
      object assemblyFileName,
      object types,
      object extraTypes)
    {
      int num1 = 17;
      Type[] typeArray;
      int index1;
      Assembly assembly;
      DateTime dateTime;
      FileStream fileStream;
      while (true)
      {
        int num2 = num1;
        Type type;
        EleWise.ELMA.XmlSerializers.XmlTypeMapping xmlTypeMapping;
        while (true)
        {
          int index2;
          EleWise.ELMA.XmlSerializers.XmlReflectionImporter reflectionImporter;
          List<EleWise.ELMA.XmlSerializers.XmlMapping> xmlMappingList;
          CompilerParameters compilerParameters1;
          string str;
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
            case 9:
              CompilerParameters compilerParameters2 = new CompilerParameters();
              CacheableXmlSerializer.FVJcYEBl1BvB5iyV2Gxj((object) compilerParameters2, false);
              CacheableXmlSerializer.paI3q1BlNyKXddlyQ5pp((object) compilerParameters2, assemblyFileName);
              compilerParameters1 = compilerParameters2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 18 : 1;
              continue;
            case 3:
            case 5:
              if (index1 >= typeArray.Length)
              {
                num2 = 8;
                continue;
              }
              goto case 28;
            case 4:
              index1 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 3 : 0;
              continue;
            case 6:
              goto label_70;
            case 7:
              if (CacheableXmlSerializer.j0ORf9BlhdZmIhB7jNHR((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 9;
                continue;
              }
              goto case 11;
            case 8:
              str = (string) CacheableXmlSerializer.AUs90SBleHgLjmXyOA92(assemblyFileName);
              num2 = 7;
              continue;
            case 10:
              ++index1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 5 : 0;
              continue;
            case 11:
              CacheableXmlSerializer.rZgj9fBlPQWI3PuHkvRO((object) str);
              num2 = 2;
              continue;
            case 12:
              goto label_5;
            case 13:
              if (extraTypes != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 8 : 29;
                continue;
              }
              goto case 21;
            case 14:
              goto label_64;
            case 15:
            case 27:
              if (index2 >= extraTypes.Length)
              {
                num2 = 21;
                continue;
              }
              break;
            case 16:
              if (types.Length != 0)
              {
                num2 = 24;
                continue;
              }
              goto label_72;
            case 17:
              if (types != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 16;
                continue;
              }
              goto label_7;
            case 18:
              dateTime = CacheableXmlSerializer.o3xeYlBl3hDoaAIFNBSh();
              num2 = 23;
              continue;
            case 19:
              xmlTypeMapping = (EleWise.ELMA.XmlSerializers.XmlTypeMapping) CacheableXmlSerializer.PYPt1UBlOvZoagcP6oEZ((object) reflectionImporter, type, (object) null, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 4 : 6;
              continue;
            case 20:
              goto label_15;
            case 21:
              xmlMappingList = new List<EleWise.ELMA.XmlSerializers.XmlMapping>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 12 : 9;
              continue;
            case 22:
              fileStream = (FileStream) CacheableXmlSerializer.x2MwQfBla6Pd5WIIGxwv((object) Path.ChangeExtension((string) assemblyFileName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088374722)));
              num2 = 20;
              continue;
            case 23:
              assembly = (Assembly) CacheableXmlSerializer.msh3O0BlpHN5IKrNWxDR(types, (object) xmlMappingList.ToArray(), (object) compilerParameters1);
              num2 = 22;
              continue;
            case 24:
              reflectionImporter = new EleWise.ELMA.XmlSerializers.XmlReflectionImporter(CacheableXmlSerializer.GetOverrides(types, (IEnumerable<Type>) extraTypes), (string) null);
              num2 = 13;
              continue;
            case 25:
              goto label_72;
            case 26:
              ++index2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 15;
              continue;
            case 28:
              type = typeArray[index1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 16 : 19;
              continue;
            case 29:
              index2 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 10 : 27;
              continue;
            case 30:
              xmlMappingList.Add((EleWise.ELMA.XmlSerializers.XmlMapping) xmlTypeMapping);
              num2 = 10;
              continue;
          }
          CacheableXmlSerializer.ns0kPTBlncfruGigfpj3((object) reflectionImporter, (Type) extraTypes[index2]);
          num2 = 26;
        }
label_5:
        typeArray = (Type[]) types;
        num1 = 4;
        continue;
label_70:
        CacheableXmlSerializer.WBwj8tBl2rLgXvGpDAnF((object) xmlTypeMapping, (object) type.FullName);
        num1 = 30;
      }
label_7:
      throw new ArgumentNullException((string) CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(1917256330 ^ 1917259432));
label_15:
      try
      {
        StreamWriter streamWriter = new StreamWriter((Stream) fileStream);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, CacheableXmlSerializer.unNqCFBds5AxSA0vlQwW(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(2045296739 + 1688595713 ^ -560996720), (object) CacheableXmlSerializer.o3xeYlBl3hDoaAIFNBSh()));
              int num4 = 12;
              Type type1;
              Type type2;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(-951514650 ^ -951550558));
                    num4 = 17;
                    continue;
                  case 2:
                    index1 = 0;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 11 : 14;
                    continue;
                  case 3:
                    typeArray = (Type[]) extraTypes;
                    num4 = 16;
                    continue;
                  case 4:
                    CacheableXmlSerializer.jmjb4sBlwj2hF786x8x8((object) streamWriter);
                    num4 = 22;
                    continue;
                  case 5:
                  case 9:
                    if (index1 >= typeArray.Length)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 4 : 8;
                      continue;
                    }
                    goto case 15;
                  case 6:
                    ++index1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 4 : 5;
                    continue;
                  case 7:
                    if (extraTypes.Length != 0)
                    {
                      num4 = 4;
                      continue;
                    }
                    goto label_64;
                  case 8:
                  case 20:
                    goto label_64;
                  case 10:
                    type2 = typeArray[index1];
                    num4 = 13;
                    continue;
                  case 11:
                    if (extraTypes == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 20 : 14;
                      continue;
                    }
                    goto case 7;
                  case 12:
                    CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, CacheableXmlSerializer.peVDE9BltfyWJARQtui7(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(-281842504 ^ -281929554), (object) (int) CacheableXmlSerializer.TAkpgLBlDrMcW9CH2Uqt(CacheableXmlSerializer.o3xeYlBl3hDoaAIFNBSh(), dateTime).TotalMilliseconds, CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(1033719030 - 2012070891 ^ -978387657)));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
                    continue;
                  case 13:
                    CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, (object) type2.AssemblyQualifiedName);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 19 : 0;
                    continue;
                  case 14:
                  case 18:
                    if (index1 >= typeArray.Length)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 11 : 10;
                      continue;
                    }
                    goto case 10;
                  case 15:
                    type1 = typeArray[index1];
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 21 : 6;
                    continue;
                  case 16:
                    index1 = 0;
                    num4 = 9;
                    continue;
                  case 17:
                    typeArray = (Type[]) types;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
                    continue;
                  case 19:
                    ++index1;
                    num4 = 18;
                    continue;
                  case 21:
                    CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, (object) type1.AssemblyQualifiedName);
                    num4 = 6;
                    continue;
                  case 22:
                    CacheableXmlSerializer.aJVoqtBliNRtbrhGsbin((object) streamWriter, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108722578));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 3 : 0;
                    continue;
                  default:
                    CacheableXmlSerializer.jmjb4sBlwj2hF786x8x8((object) streamWriter);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num5;
              if (streamWriter == null)
                num5 = 2;
              else
                goto label_47;
label_46:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_47:
              CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) streamWriter);
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              {
                num5 = 0;
                goto label_46;
              }
              else
                goto label_46;
            }
        }
      }
      finally
      {
        if (fileStream != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                CacheableXmlSerializer.dhJ96gBlvRnqWEZeobHV((object) fileStream);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              default:
                goto label_55;
            }
          }
        }
label_55:;
      }
label_64:
      return assembly;
label_72:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408988030));
    }

    private static EleWise.ELMA.XmlSerializers.XmlSerializer Create(object asm, Type type) => (EleWise.ELMA.XmlSerializers.XmlSerializer) CacheableXmlSerializer.gr1xFVBlHsBhshVc3dEj(CacheableXmlSerializer.Kc0AJLBl6bBArH8gscno(CacheableXmlSerializer.zH77UnBl4rZtcACFr5fI(asm)), (object) type.FullName);

    private static EleWise.ELMA.XmlSerializers.XmlSerializerImplementation GetContract(
      object assembly)
    {
      return (EleWise.ELMA.XmlSerializers.XmlSerializerImplementation) CacheableXmlSerializer.LB0BQpBl770wx1XOWxjT(CacheableXmlSerializer.gpbXjeBlAjXtJFEjNMLJ(assembly, CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(~-397266137 ^ 397195426)));
    }

    private static Type GetTypeFromAssembly(object assembly, object typeName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeName = CacheableXmlSerializer.qhi2f0Bdz10DVJI7pnZN(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(-2112703338 ^ -2112634818), typeName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      Type type = CacheableXmlSerializer.m6kbwWBlxOVyHEOujuSg(assembly, typeName);
      return !CacheableXmlSerializer.LPJFKdBl03vfKnMbhvV8(type, (Type) null) ? type : throw new InvalidOperationException((string) CacheableXmlSerializer.h1QfPfBlyJoEVEHVfM7g(CacheableXmlSerializer.Coy0hNBdj97c31UViEMh(--1360331293 ^ 1360295701), typeName, CacheableXmlSerializer.SHw9wABlmEwZv0AyxrZm(assembly)));
    }

    static CacheableXmlSerializer()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CacheableXmlSerializer.pGbkVFBlMfV6yvnAcFsE();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            CacheableXmlSerializer.assemblies = new Dictionary<string, Assembly>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 2 : 2;
            continue;
          default:
            CacheableXmlSerializer.serializers = new Dictionary<string, EleWise.ELMA.XmlSerializers.XmlSerializer>();
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static object Coy0hNBdj97c31UViEMh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QGNJGGBdYKxSrt2Hhq0i() => (object) ComponentManager.Current;

    internal static object kXRA5DBdLVlqunwS15wt([In] object obj0) => (object) ((ComponentManager) obj0).GetXsiTypes();

    internal static bool YYgSbLBdUSiovoaHY15s() => ComponentManager.Initialized;

    internal static object unNqCFBds5AxSA0vlQwW([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static object M9YpqyBdcVZFRVbJgjUU([In] object obj0) => (object) ((ComponentManager) obj0).GetXsiRoots();

    internal static object qhi2f0Bdz10DVJI7pnZN([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object uMBberBlFLbwLFS7Ywf1([In] object obj0) => (object) ((ComponentManager) obj0).WorkDirectory;

    internal static object EHKdiPBlBuMhX3S901Re([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object WnApWBBlWXK30aZ5LZCx(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static bool LAqqYYBlouq1seK5jaYT([In] object obj0) => File.Exists((string) obj0);

    internal static object EW4UESBlbUOGoX5Pum03([In] object obj0) => (object) Assembly.LoadFrom((string) obj0);

    internal static bool j0ORf9BlhdZmIhB7jNHR([In] object obj0) => Directory.Exists((string) obj0);

    internal static object qTpdboBlGYfnahkViKEQ([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object iNq5MKBlE9GCWkkMZw0v() => (object) Logger.Log;

    internal static object PR1RNQBlfKuv0gUi3YSi([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void Cim1XCBlQ0vyYpvJKQHj([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool B9EwIiBlCqVLTQAItQur([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void dhJ96gBlvRnqWEZeobHV([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void WwhBblBl82jrZS1x0lf8([In] object obj0) => Monitor.Exit(obj0);

    internal static bool tHY3yDBlZaeEtV3umLtK([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object KBsJkgBlueU1YmebJNGa([In] object obj0, Type type) => (object) CacheableXmlSerializer.Create(obj0, type);

    internal static bool AJ8MbRBdgvqmPc2ihAW6() => CacheableXmlSerializer.nvehrCBdrUFLTQgtEimw == null;

    internal static CacheableXmlSerializer ES4cDfBd5gPKlK43MXqy() => CacheableXmlSerializer.nvehrCBdrUFLTQgtEimw;

    internal static int HR7drMBlIWWf8YsmX5ld([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);

    internal static object gbnwIHBlVh6EnbniIIK0() => (object) MemoryHelper.GetMemoryStream();

    internal static object wPDgR8BlSCHj9kSF7e0a() => (object) StringComparer.InvariantCulture;

    internal static void aJVoqtBliNRtbrhGsbin([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static object IwgmT7BlRssFLeUZB85s([In] object obj0) => (object) AssemblyInfoCache.EvaluateHashCode((Assembly) obj0);

    internal static void TIssitBlqDaBkIVmbNTw([In] object obj0) => ((TextWriter) obj0).Flush();

    internal static long cpqaLOBlKXweDpVOtcFU([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object ySb47kBlXlsQmARssaHe() => (object) SHA1.Create();

    internal static object Ydd4mhBlTMW2J1NbeYqa([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object iUupafBlkZudIdWlGYq7([In] object obj0) => (object) ((string) obj0).Base64StringToValidFileName();

    internal static void ns0kPTBlncfruGigfpj3([In] object obj0, [In] Type obj1) => ((EleWise.ELMA.XmlSerializers.XmlReflectionImporter) obj0).IncludeType(obj1);

    internal static object PYPt1UBlOvZoagcP6oEZ([In] object obj0, [In] Type obj1, [In] object obj2, [In] object obj3) => (object) ((EleWise.ELMA.XmlSerializers.XmlReflectionImporter) obj0).ImportTypeMapping(obj1, (XmlRootAttribute) obj2, (string) obj3);

    internal static void WBwj8tBl2rLgXvGpDAnF([In] object obj0, [In] object obj1) => ((EleWise.ELMA.XmlSerializers.XmlMapping) obj0).SetKey((string) obj1);

    internal static object AUs90SBleHgLjmXyOA92([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object rZgj9fBlPQWI3PuHkvRO([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static void FVJcYEBl1BvB5iyV2Gxj([In] object obj0, [In] bool obj1) => ((CompilerParameters) obj0).GenerateInMemory = obj1;

    internal static void paI3q1BlNyKXddlyQ5pp([In] object obj0, [In] object obj1) => ((CompilerParameters) obj0).OutputAssembly = (string) obj1;

    internal static DateTime o3xeYlBl3hDoaAIFNBSh() => DateTime.Now;

    internal static object msh3O0BlpHN5IKrNWxDR([In] object obj0, [In] object obj1, [In] object obj2) => (object) EleWise.ELMA.XmlSerializers.XmlSerializer.GenerateSerializer((Type[]) obj0, (EleWise.ELMA.XmlSerializers.XmlMapping[]) obj1, (CompilerParameters) obj2);

    internal static object x2MwQfBla6Pd5WIIGxwv([In] object obj0) => (object) File.Create((string) obj0);

    internal static TimeSpan TAkpgLBlDrMcW9CH2Uqt([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static object peVDE9BltfyWJARQtui7([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static void jmjb4sBlwj2hF786x8x8([In] object obj0) => ((TextWriter) obj0).WriteLine();

    internal static object zH77UnBl4rZtcACFr5fI([In] object obj0) => (object) CacheableXmlSerializer.GetContract(obj0);

    internal static object Kc0AJLBl6bBArH8gscno([In] object obj0) => (object) ((EleWise.ELMA.XmlSerializers.XmlSerializerImplementation) obj0).TypedSerializers;

    internal static object gr1xFVBlHsBhshVc3dEj([In] object obj0, [In] object obj1) => ((Hashtable) obj0)[obj1];

    internal static Type gpbXjeBlAjXtJFEjNMLJ([In] object obj0, [In] object obj1) => CacheableXmlSerializer.GetTypeFromAssembly(obj0, obj1);

    internal static object LB0BQpBl770wx1XOWxjT([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static Type m6kbwWBlxOVyHEOujuSg([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool LPJFKdBl03vfKnMbhvV8([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object SHw9wABlmEwZv0AyxrZm([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object h1QfPfBlyJoEVEHVfM7g([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void pGbkVFBlMfV6yvnAcFsE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
