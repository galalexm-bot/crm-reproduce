// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.AssemblyInfoCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EleWise.ELMA.Runtime.Cache
{
  /// <summary>
  /// Информация о сборке. Нужна для оптимизации запуска приложения.
  /// </summary>
  public class AssemblyInfoCache
  {
    internal bool _changed;
    internal bool _typesChanged;
    internal ApplicationStartCache _owner;
    private static readonly Dictionary<Assembly, string> AssemblyHashes;
    private readonly Dictionary<string, TypeInfoCache> typesByName;
    private readonly Dictionary<Type, TypeInfoCache> types;
    private static AssemblyInfoCache tOFVXyWe4AiLlMxI349F;

    /// <summary>Имя сборки</summary>
    public string AssemblyName
    {
      get => this.\u003CAssemblyName\u003Ek__BackingField;
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
              this.\u003CAssemblyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <summary>Вычисленный хэш-код сборки</summary>
    public string HashCode
    {
      get => this.\u003CHashCode\u003Ek__BackingField;
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
              this.\u003CHashCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
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

    /// <summary>Содержит ли сборка компоненты</summary>
    public bool? IsComponentAssembly { get; set; }

    /// <summary>Информация о типах</summary>
    public TypeInfoCache[] TypeInfos
    {
      get => this.typesByName.Values.ToArray<TypeInfoCache>();
      set
      {
        int num1 = 6;
        while (true)
        {
          int num2 = num1;
          int index;
          TypeInfoCache typeInfoCache;
          while (true)
          {
            switch (num2)
            {
              case 1:
                index = 0;
                num2 = 7;
                continue;
              case 2:
              case 7:
                if (index < value.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 8;
                  continue;
                }
                goto label_9;
              case 3:
                goto label_10;
              case 4:
                goto label_4;
              case 5:
                AssemblyInfoCache.oqgNcYWe7rPQGZqYxyMr((object) this.types);
                num2 = 10;
                continue;
              case 6:
                AssemblyInfoCache.fR5V4mWeAgm6yZhgZsq5((object) this.typesByName);
                num2 = 5;
                continue;
              case 8:
              case 9:
                typeInfoCache = value[index];
                num2 = 11;
                continue;
              case 10:
                if (value != null)
                  goto case 1;
                else
                  goto label_13;
              case 11:
                this.typesByName[typeInfoCache.TypeName] = typeInfoCache;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                continue;
              case 12:
                ++index;
                num2 = 2;
                continue;
              default:
                typeInfoCache._owner = this;
                num2 = 12;
                continue;
            }
          }
label_13:
          num1 = 4;
        }
label_10:
        return;
label_4:
        return;
label_9:;
      }
    }

    /// <summary>Ctor</summary>
    public AssemblyInfoCache()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.typesByName = new Dictionary<string, TypeInfoCache>();
      this.types = new Dictionary<Type, TypeInfoCache>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="owner">Объект-владелец</param>
    /// <param name="assembly">Сборка</param>
    public AssemblyInfoCache(ApplicationStartCache owner, Assembly assembly)
    {
      AssemblyInfoCache.WsfuMkWexmKChycNN8b1();
      this.typesByName = new Dictionary<string, TypeInfoCache>();
      this.types = new Dictionary<Type, TypeInfoCache>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AssemblyName = ComponentManager.GetAssemblyShortName(assembly);
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.HashCode = AssemblyInfoCache.EvaluateHashCode(assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
          default:
            this._owner = owner;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Вычислить хэш-код сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns>Хэш-код</returns>
    internal static string EvaluateHashCode(Assembly assembly)
    {
      int num1 = 5;
      string hashCode;
      while (true)
      {
        int num2 = num1;
        MemoryStream memoryStream;
        FileStream fileStream;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (AssemblyInfoCache.cJKl0jWem6Z4EmTjYpXU((object) assembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 15 : 13;
                continue;
              }
              goto case 3;
            case 2:
            case 13:
            case 15:
              goto label_28;
            case 3:
              if (AssemblyInfoCache.E6kM2qWeM4KXH8b4UeOZ(AssemblyInfoCache.Y2tCxoWeyfqdZwY6kUje((object) assembly)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 2;
                continue;
              }
              goto case 12;
            case 4:
              memoryStream = (MemoryStream) AssemblyInfoCache.kxjPTBWe0pNAnh99I0l1((object) assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 11 : 10;
              continue;
            case 5:
              if (!AssemblyInfoCache.AssemblyHashes.TryGetValue(assembly, out hashCode))
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 6:
label_12:
              AssemblyInfoCache.AssemblyHashes[assembly] = hashCode;
              num2 = 9;
              continue;
            case 7:
              try
              {
                hashCode = (string) AssemblyInfoCache.jGk87nWedJdL3YBpq2Oh((object) fileStream);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_12;
                }
              }
              finally
              {
                if (fileStream != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        fileStream.Dispose();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_23;
                    }
                  }
                }
label_23:;
              }
            case 8:
              AssemblyInfoCache.hLxhASWelDvYklQ8EXmn((object) memoryStream, 0L, SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_11;
            case 10:
              fileStream = new FileStream(assembly.Location, FileMode.Open, FileAccess.Read);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 7 : 1;
              continue;
            case 11:
              if (memoryStream == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                continue;
              }
              goto case 8;
            case 12:
              if (AssemblyInfoCache.BOThlpWeJeLmtGpgVU5v(AssemblyInfoCache.Y2tCxoWeyfqdZwY6kUje((object) assembly)))
              {
                num2 = 10;
                continue;
              }
              goto label_28;
            case 14:
              goto label_3;
            default:
              goto label_10;
          }
        }
label_10:
        hashCode = (string) AssemblyInfoCache.jGk87nWedJdL3YBpq2Oh((object) memoryStream);
        num1 = 6;
      }
label_3:
      return hashCode;
label_11:
      return hashCode;
label_28:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939507074), AssemblyInfoCache.EnPkgGWe96XliKFMCuOj((object) assembly)));
    }

    /// <summary>Вычислить хэш-код сборки</summary>
    /// <param name="asmRaw">Бинарный код сборки</param>
    /// <returns>Хэш-код</returns>
    internal static string EvaluateHashCode(byte[] asmRaw)
    {
      int num1 = 1;
      SHA1 shA1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            shA1 = SHA1.Create();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_13;
          default:
            goto label_2;
        }
      }
label_2:
      string hashCode;
      try
      {
        byte[] numArray = (byte[]) AssemblyInfoCache.AAYImvWer37nRZUTKMkn((object) shA1, (object) asmRaw);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              hashCode = (string) AssemblyInfoCache.yqbtOnWe5pKeYXGwqpB7((object) asmRaw.Length, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939374346), AssemblyInfoCache.afKpf6WegdgNeR3K9uTL((object) numArray));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_13;
          }
        }
      }
      finally
      {
        int num3;
        if (shA1 == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
        else
          goto label_10;
label_9:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_10:
        AssemblyInfoCache.GCsBbWWejLEM7fNHX7FG((object) shA1);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
      }
label_13:
      return hashCode;
    }

    /// <summary>Вычислить хеш-код сборки</summary>
    /// <param name="assemblyStream">Поток, содержащий сборку</param>
    /// <returns>Хеш-код</returns>
    internal static string EvaluateHashCode(Stream assemblyStream)
    {
      int num1 = 1;
      SHA1 shA1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            shA1 = (SHA1) AssemblyInfoCache.queUw2WeYY7WcV8YLX7K();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_14;
          default:
            goto label_3;
        }
      }
label_3:
      string hashCode;
      try
      {
        byte[] numArray = (byte[]) AssemblyInfoCache.hF1PPwWeLL5OQDq8NSMp((object) shA1, (object) assemblyStream);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              hashCode = (string) AssemblyInfoCache.yqbtOnWe5pKeYXGwqpB7((object) assemblyStream.Length, AssemblyInfoCache.vY5l1cWeUPmVWHqw89KG(1113862659 ^ 1113865849), AssemblyInfoCache.afKpf6WegdgNeR3K9uTL((object) numArray));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
      }
      finally
      {
        if (shA1 != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                shA1.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
label_14:
      return hashCode;
    }

    /// <summary>Получить (или создать) информацию о типе</summary>
    /// <param name="type">Тип</param>
    /// <returns></returns>
    public TypeInfoCache GetTypeInfo(Type type)
    {
      int num = 5;
      string fullName;
      TypeInfoCache typeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.typesByName[fullName] = typeInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 7 : 6;
            continue;
          case 2:
            this._typesChanged = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
            continue;
          case 3:
          case 4:
            goto label_6;
          case 5:
            if (this.types.TryGetValue(type, out typeInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 4 : 4;
              continue;
            }
            goto case 6;
          case 6:
            fullName = type.FullName;
            num = 8;
            continue;
          case 7:
            this.types[type] = typeInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 1;
            continue;
          case 8:
            if (!this.typesByName.TryGetValue(fullName, out typeInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          default:
            typeInfo = new TypeInfoCache(this, type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
            continue;
        }
      }
label_6:
      return typeInfo;
    }

    static AssemblyInfoCache()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AssemblyInfoCache.AssemblyHashes = new Dictionary<Assembly, string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool vwqgWyWe6nFjJBKjF8gH() => AssemblyInfoCache.tOFVXyWe4AiLlMxI349F == null;

    internal static AssemblyInfoCache ly2QBtWeHxdJiMIetsLP() => AssemblyInfoCache.tOFVXyWe4AiLlMxI349F;

    internal static void fR5V4mWeAgm6yZhgZsq5([In] object obj0) => ((Dictionary<string, TypeInfoCache>) obj0).Clear();

    internal static void oqgNcYWe7rPQGZqYxyMr([In] object obj0) => ((Dictionary<Type, TypeInfoCache>) obj0).Clear();

    internal static void WsfuMkWexmKChycNN8b1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object kxjPTBWe0pNAnh99I0l1([In] object obj0) => (object) ComponentManager.GetLoadedAssemblyRawAsStream((Assembly) obj0);

    internal static bool cJKl0jWem6Z4EmTjYpXU([In] object obj0) => ((Assembly) obj0).IsDynamic;

    internal static object Y2tCxoWeyfqdZwY6kUje([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool E6kM2qWeM4KXH8b4UeOZ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool BOThlpWeJeLmtGpgVU5v([In] object obj0) => File.Exists((string) obj0);

    internal static object EnPkgGWe96XliKFMCuOj([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object jGk87nWedJdL3YBpq2Oh([In] object obj0) => (object) AssemblyInfoCache.EvaluateHashCode((Stream) obj0);

    internal static long hLxhASWelDvYklQ8EXmn([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object AAYImvWer37nRZUTKMkn([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object afKpf6WegdgNeR3K9uTL([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static object yqbtOnWe5pKeYXGwqpB7([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    internal static void GCsBbWWejLEM7fNHX7FG([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object queUw2WeYY7WcV8YLX7K() => (object) SHA1.Create();

    internal static object hF1PPwWeLL5OQDq8NSMp([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object vY5l1cWeUPmVWHqw89KG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
