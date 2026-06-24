// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizationHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace EleWise.ELMA.Globalization
{
  /// <summary>Описание перевода</summary>
  [Serializable]
  public class LocalizationHolder
  {
    public const string HolderTemplate = "SRString:{0}:{1}:{2}";
    private object _sinchObjs;
    private Dictionary<string, string> _cache;
    internal static LocalizationHolder ymdk8gGhsskcwF28v8Aa;

    /// <summary>Ctor</summary>
    public LocalizationHolder()
    {
      LocalizationHolder.VWXUOXGGFuOkNlqpQ1M4();
      this._sinchObjs = new object();
      this._cache = new Dictionary<string, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Templates = new List<TemplateDescription>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          default:
            this.Files = new List<LocalizationFile>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Название</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
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

    /// <summary>Шаблоны локали (папочка Templates)</summary>
    public List<TemplateDescription> Templates { get; set; }

    /// <summary>Файлы локализации</summary>
    public List<LocalizationFile> Files { get; set; }

    /// <summary>Получить перевод</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public string T(string key)
    {
      int num1 = 6;
      List<LocalizationFile>.Enumerator enumerator;
      string str1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.Files.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_24;
          case 3:
            if (!this._cache.TryGetValue(key1, out str1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            }
            goto label_24;
          case 4:
            goto label_3;
          case 5:
            key1 = key;
            num1 = 3;
            continue;
          case 6:
            num1 = 5;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return (string) null;
label_5:
      string str2;
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_12;
label_7:
        PoLineDescriptor poLineDescriptor;
        string str3;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            case 2:
              str3 = (string) LocalizationHolder.jPl69FGGBXtIf1TkGWO0((object) poLineDescriptor);
              num2 = 5;
              continue;
            case 3:
              if (poLineDescriptor != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
                continue;
              }
              goto label_11;
            case 4:
              goto label_4;
            case 5:
              this._cache[key1] = str3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_15;
            case 7:
              goto label_3;
            default:
              str2 = str3;
              num2 = 4;
              continue;
          }
        }
label_12:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 7;
        goto label_7;
label_15:
        ConcurrentBag<PoLineDescriptor> resources = enumerator.Current.Resources;
        Func<PoLineDescriptor, bool> func;
        Func<PoLineDescriptor, bool> func1 = func;
        Func<PoLineDescriptor, bool> predicate = func1 == null ? (func = (Func<PoLineDescriptor, bool>) (r => r.Key.Equals(key1, StringComparison.Ordinal))) : func1;
        poLineDescriptor = resources.FirstOrDefault<PoLineDescriptor>(predicate);
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        {
          num2 = 3;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_4:
      return str2;
label_24:
      return str1;
    }

    /// <summary>Добавить ресурс в файл</summary>
    /// <param name="file"></param>
    public void AddResourceToFile(
      string file,
      PoLineDescriptor line,
      out LocalizationFile localizationFile)
    {
      int num = 4;
      string file1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            localizationFile = this.Files.FirstOrDefault<LocalizationFile>((Func<LocalizationFile, bool>) (f => LocalizationHolder.\u003C\u003Ec__DisplayClass15_0.mXu4K3vrbjQELAe6FWGi(LocalizationHolder.\u003C\u003Ec__DisplayClass15_0.hPHX5Tvrog6aeCyMs7UE((object) f), (object) file1, StringComparison.OrdinalIgnoreCase)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
            continue;
          case 3:
            file1 = file;
            num = 2;
            continue;
          case 4:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 3;
            continue;
          case 5:
            goto label_2;
          default:
            if (localizationFile != null)
            {
              localizationFile.Resources.Add(line);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            }
            num = 5;
            continue;
        }
      }
label_3:
      return;
label_2:;
    }

    /// <summary>Установить новый перевод</summary>
    /// <param name="key"></param>
    /// <param name="val"></param>
    public void SetTranslate(string key, string val, out List<LocalizationFile> file)
    {
      int num1 = 5;
      List<LocalizationFile>.Enumerator enumerator1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_32;
          case 2:
            enumerator1 = this.Files.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 3:
            file = new List<LocalizationFile>();
            num1 = 2;
            continue;
          case 4:
            key1 = key;
            num1 = 3;
            continue;
          case 5:
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_32:
      return;
label_2:
      try
      {
label_25:
        if (enumerator1.MoveNext())
          goto label_23;
        else
          goto label_26;
label_4:
        LocalizationFile current1;
        IEnumerator<PoLineDescriptor> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_28;
            case 2:
              goto label_25;
            case 3:
              goto label_5;
            case 4:
              goto label_23;
            default:
              ConcurrentBag<PoLineDescriptor> resources = current1.Resources;
              Func<PoLineDescriptor, bool> func;
              Func<PoLineDescriptor, bool> func1 = func;
              Func<PoLineDescriptor, bool> predicate = func1 == null ? (func = (Func<PoLineDescriptor, bool>) (r => r.Key.Equals(key1, StringComparison.Ordinal))) : func1;
              enumerator2 = resources.Where<PoLineDescriptor>(predicate).GetEnumerator();
              num2 = 3;
              continue;
          }
        }
label_28:
        return;
label_5:
        try
        {
label_12:
          if (LocalizationHolder.JDSNW0GGbNrxJ6LmUUjN((object) enumerator2))
            goto label_9;
          else
            goto label_13;
label_6:
          PoLineDescriptor current2;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                LocalizationHolder.F3BbSrGGovE6ZP5KLoc0((object) current2, false);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 2;
                continue;
              case 2:
                LocalizationHolder.aOZ0bZGGWlPH8YLRriLs((object) current2, (object) val);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              case 3:
                this._cache[key1] = val;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 2 : 6;
                continue;
              case 4:
                goto label_12;
              case 5:
                goto label_25;
              case 6:
                file.Add(current1);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 4;
                continue;
              case 7:
                goto label_9;
              default:
                if (current2.IsFuzzy)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                  continue;
                }
                goto case 3;
            }
          }
label_9:
          current2 = enumerator2.Current;
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
          {
            num3 = 2;
            goto label_6;
          }
          else
            goto label_6;
label_13:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 4 : 5;
          goto label_6;
        }
        finally
        {
          int num4;
          if (enumerator2 == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
          else
            goto label_20;
label_19:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_20:
          LocalizationHolder.e5aY0fGGhyBwpXUEbVyB((object) enumerator2);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
          {
            num4 = 2;
            goto label_19;
          }
          else
            goto label_19;
        }
label_23:
        current1 = enumerator1.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_26:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
        goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Установка приоритета для строки ресурса</summary>
    /// <param name="key"></param>
    /// <param name="val"></param>
    /// <param name="file"></param>
    public void SetPriority(string key, bool val, out List<LocalizationFile> file)
    {
      int num1 = 5;
      List<LocalizationFile>.Enumerator enumerator1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = this.Files.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            file = new List<LocalizationFile>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_29;
          case 4:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 1;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 4 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_29:
      return;
label_4:
      try
      {
label_22:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_23;
label_6:
        LocalizationFile current;
        IEnumerator<PoLineDescriptor> enumerator2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_25;
            case 1:
              goto label_8;
            case 2:
              goto label_7;
            case 3:
              goto label_22;
            case 4:
              // ISSUE: reference to a compiler-generated method
              enumerator2 = current.Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => LocalizationHolder.\u003C\u003Ec__DisplayClass17_0.V1TGcOvrva6NbL97mCRj((object) r.Key, (object) key1, StringComparison.Ordinal))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            default:
              goto label_18;
          }
        }
label_25:
        return;
label_18:
        return;
label_8:
        try
        {
label_13:
          if (LocalizationHolder.JDSNW0GGbNrxJ6LmUUjN((object) enumerator2))
            goto label_10;
          else
            goto label_14;
label_9:
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                file.Add(current);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_10;
              case 3:
                goto label_22;
              default:
                goto label_13;
            }
          }
label_10:
          LocalizationHolder.BAtHgqGGGOYcxTXapULw((object) enumerator2.Current, val);
          num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
          {
            num3 = 1;
            goto label_9;
          }
          else
            goto label_9;
label_14:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 3 : 1;
          goto label_9;
        }
        finally
        {
          int num4;
          if (enumerator2 == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
          else
            goto label_19;
label_17:
          switch (num4)
          {
            case 2:
              break;
            default:
          }
label_19:
          LocalizationHolder.e5aY0fGGhyBwpXUEbVyB((object) enumerator2);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          {
            num4 = 0;
            goto label_17;
          }
          else
            goto label_17;
        }
label_7:
        current = enumerator1.Current;
        num2 = 4;
        goto label_6;
label_23:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
        goto label_6;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Установить флаг неточного перевода</summary>
    /// <param name="key"></param>
    /// <param name="val"></param>
    /// <param name="file"></param>
    public void SetFuzzy(string key, bool val, out List<LocalizationFile> file)
    {
      int num1 = 2;
      List<LocalizationFile>.Enumerator enumerator1;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 5;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_28;
          case 4:
            enumerator1 = this.Files.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
            continue;
          case 5:
            file = new List<LocalizationFile>();
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_28:
      return;
label_2:
      try
      {
label_21:
        if (enumerator1.MoveNext())
          goto label_19;
        else
          goto label_22;
label_4:
        IEnumerator<PoLineDescriptor> enumerator2;
        LocalizationFile current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_24;
            case 1:
              goto label_21;
            case 2:
              goto label_5;
            case 3:
              goto label_19;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              enumerator2 = current.Resources.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => LocalizationHolder.\u003C\u003Ec__DisplayClass18_0.s1rndbvrV6b6fIGQLPxh(LocalizationHolder.\u003C\u003Ec__DisplayClass18_0.fbKJaRvrI9ouvtlbWA6S((object) r), (object) key1, StringComparison.Ordinal))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
              continue;
            default:
              goto label_16;
          }
        }
label_24:
        return;
label_16:
        return;
label_5:
        try
        {
label_10:
          if (enumerator2.MoveNext())
            goto label_7;
          else
            goto label_11;
label_6:
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_21;
              case 2:
                goto label_10;
              case 3:
                file.Add(current);
                num3 = 2;
                continue;
              default:
                goto label_7;
            }
          }
label_7:
          LocalizationHolder.F3BbSrGGovE6ZP5KLoc0((object) enumerator2.Current, val);
          num3 = 3;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
          {
            num3 = 0;
            goto label_6;
          }
          else
            goto label_6;
label_11:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
          goto label_6;
        }
        finally
        {
          if (enumerator2 != null)
          {
            int num4 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  enumerator2.Dispose();
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_18;
              }
            }
          }
label_18:;
        }
label_19:
        current = enumerator1.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num2 = 4;
          goto label_4;
        }
        else
          goto label_4;
label_22:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Статистика перевода</summary>
    public LocalizationStatistic Statistic
    {
      get => this.\u003CStatistic\u003Ek__BackingField;
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
              this.\u003CStatistic\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Обновить статистику</summary>
    public void RefreshStatistic()
    {
      int num1 = 2;
      object sinchObjs;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            lockTaken = false;
            num1 = 3;
            continue;
          case 2:
            sinchObjs = this._sinchObjs;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:
      return;
label_3:
      try
      {
        Monitor.Enter(sinchObjs, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            default:
              this.Statistic = (LocalizationStatistic) LocalizationHolder.mIrKkSGGEHFLsEiRIFtP((object) this, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
          }
        }
label_6:;
      }
      finally
      {
        if (lockTaken)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_15;
              default:
                LocalizationHolder.Vq2xFbGGfXopoVwHvFRj(sinchObjs);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_15:;
      }
    }

    public static LocalizationStatistic GetStatistic(LocalizationHolder holder, PoLineFilter filter)
    {
      int num1 = 17;
      LocalizationStatistic statistic;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<LocalizationFile>.Enumerator enumerator;
          List<LocalizationFile> localizationFileList;
          PoLineFilter filter1;
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              localizationFileList = holder.Files.Where<LocalizationFile>((Func<LocalizationFile, bool>) (f => ((string) LocalizationHolder.\u003C\u003Ec__DisplayClass24_0.CjoNTIvrKcd5UCvoky48((object) f)).Equals(filter1.FileName, StringComparison.OrdinalIgnoreCase))).ToList<LocalizationFile>();
              break;
            case 2:
              statistic.TranslatedWords = statistic.TranslatedWordsByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (tw => tw.Value));
              num2 = 22;
              continue;
            case 3:
              LocalizationHolder.NsehwFGGShtui6qS5jjM((object) statistic, LocalizationHolder.qyRdk3GGVxtHOjFdsN4R(LocalizationHolder.NkyqEVGGuM9LUCArKZQZ((object) statistic) > 0L ? LocalizationHolder.Murt8YGGIcGKN2aFPGeT((object) statistic) * 100L / LocalizationHolder.NkyqEVGGuM9LUCArKZQZ((object) statistic) : 0L));
              num2 = 9;
              continue;
            case 4:
              goto label_6;
            case 5:
              LocalizationHolder.qJswHXGGK3aKY8uSKZgL((object) statistic, statistic.FuzzyWordsByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (w => w.Value)));
              num2 = 13;
              continue;
            case 6:
              if (filter1 != null)
                goto case 20;
              else
                goto label_10;
            case 7:
              try
              {
label_21:
                if (enumerator.MoveNext())
                  goto label_19;
                else
                  goto label_22;
label_14:
                LocalizationFile current;
                int num3;
                while (true)
                {
                  List<PoLineDescriptor> source1;
                  long num4;
                  int num5;
                  long num6;
                  long num7;
                  long num8;
                  long num9;
                  List<PoLineDescriptor> list1;
                  long num10;
                  List<PoLineDescriptor> poLineDescriptorList;
                  switch (num3)
                  {
                    case 1:
                      List<PoLineDescriptor> source2 = source1;
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, long> func1 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_13;
                      Func<PoLineDescriptor, long> selector1;
                      if (func1 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_13 = selector1 = (Func<PoLineDescriptor, long>) (r => LocalizationStatistic.CountWords((string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)));
                      }
                      else
                        goto label_3;
label_34:
                      num6 = source2.Sum<PoLineDescriptor>(selector1);
                      num3 = 14;
                      continue;
label_3:
                      selector1 = func1;
                      goto label_34;
                    case 2:
                      statistic.HighPriorityByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), (long) list1.Count);
                      num3 = 16;
                      continue;
                    case 3:
                      statistic.CharsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), num9);
                      num3 = 15;
                      continue;
                    case 4:
                      statistic.StringsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), (long) LocalizationHolder.T8XhNIGG8AC2LnT9eiAQ((object) source1));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
                      continue;
                    case 5:
                      statistic.HighPriorityWordsByFile.Add(current.Name, num4);
                      num3 = 6;
                      continue;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      num10 = list1.Sum<PoLineDescriptor>((Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.I6o531vr2ud2LaLHCpL8(LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r))));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 3 : 18;
                      continue;
                    case 7:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      List<PoLineDescriptor> list2 = source1.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => !LocalizationHolder.\u003C\u003Ec.kAe6tuvreGVbFQC7WMdb(LocalizationHolder.\u003C\u003Ec.N6YjT2vrPb6Ysw8yl2cw((object) r)))).ToList<PoLineDescriptor>();
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, long> func2 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_17;
                      Func<PoLineDescriptor, long> selector2;
                      if (func2 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_17 = selector2 = (Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.H1JeSPvr1V1BU38oB10g(LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)));
                      }
                      else
                        goto label_88;
label_39:
                      long num11 = list2.Sum<PoLineDescriptor>(selector2);
                      statistic.TranslatedWordsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), num11);
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, long> func3 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_18;
                      Func<PoLineDescriptor, long> selector3;
                      if (func3 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_18 = selector3 = (Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.I6o531vr2ud2LaLHCpL8((object) r.Key));
                      }
                      else
                        goto label_87;
label_41:
                      num8 = list2.Sum<PoLineDescriptor>(selector3);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 21 : 19;
                      continue;
label_87:
                      selector3 = func3;
                      goto label_41;
label_88:
                      selector2 = func2;
                      goto label_39;
                    case 8:
                      poLineDescriptorList = current.Resources.ToList<PoLineDescriptor>();
                      break;
                    case 9:
                      statistic.TranslatedByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), (long) num5);
                      num3 = 7;
                      continue;
                    case 10:
                      goto label_21;
                    case 11:
                      List<PoLineDescriptor> source3 = source1;
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, bool> func4 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_20;
                      Func<PoLineDescriptor, bool> predicate1;
                      if (func4 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_20 = predicate1 = (Func<PoLineDescriptor, bool>) (r => LocalizationHolder.\u003C\u003Ec.luU4IXvrNCLcOtkw1pxa((object) r));
                      }
                      else
                        goto label_90;
label_48:
                      List<PoLineDescriptor> list3 = source3.Where<PoLineDescriptor>(predicate1).ToList<PoLineDescriptor>();
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, long> func5 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_21;
                      Func<PoLineDescriptor, long> selector4;
                      if (func5 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_21 = selector4 = (Func<PoLineDescriptor, long>) (r => LocalizationStatistic.CountWords((string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)));
                      }
                      else
                        goto label_89;
label_50:
                      long num12 = list3.Sum<PoLineDescriptor>(selector4);
                      statistic.FuzzyWordsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), num12);
                      // ISSUE: reference to a compiler-generated method
                      num7 = list3.Sum<PoLineDescriptor>((Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.I6o531vr2ud2LaLHCpL8((object) r.Key)));
                      num3 = 17;
                      continue;
label_89:
                      selector4 = func5;
                      goto label_50;
label_90:
                      predicate1 = func4;
                      goto label_48;
                    case 12:
                      statistic.ProgressByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), Convert.ToInt32(LocalizationHolder.T8XhNIGG8AC2LnT9eiAQ((object) source1) <= 0 ? 0 : num5 * 100 / source1.Count));
                      num3 = 24;
                      continue;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      num9 = source1.Sum<PoLineDescriptor>((Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.I6o531vr2ud2LaLHCpL8(LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r))));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 2;
                      continue;
                    case 14:
                      statistic.WordsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), num6);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 7 : 13;
                      continue;
                    case 15:
                      // ISSUE: reference to a compiler-generated method
                      num5 = source1.Count<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => !LocalizationHolder.\u003C\u003Ec.kAe6tuvreGVbFQC7WMdb((object) r.Value)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 9 : 6;
                      continue;
                    case 16:
                      List<PoLineDescriptor> source4 = list1;
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, long> func6 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_24;
                      Func<PoLineDescriptor, long> selector5;
                      if (func6 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_24 = selector5 = (Func<PoLineDescriptor, long>) (r => LocalizationHolder.\u003C\u003Ec.H1JeSPvr1V1BU38oB10g(LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)));
                      }
                      else
                        goto label_91;
label_54:
                      num4 = source4.Sum<PoLineDescriptor>(selector5);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 5;
                      continue;
label_91:
                      selector5 = func6;
                      goto label_54;
                    case 17:
                      statistic.FuzzyCharsByFile.Add(current.Name, num7);
                      num3 = 23;
                      continue;
                    case 18:
                      statistic.HighPriorityCharsByFile.Add((string) LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current), num10);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 10 : 6;
                      continue;
                    case 19:
                      poLineDescriptorList = LocalizationFile.ApplyFilter((IEnumerable<PoLineDescriptor>) current.Resources, filter1);
                      break;
                    case 20:
                      goto label_62;
                    case 21:
                      statistic.TranslatedCharsByFile.Add(current.Name, num8);
                      num3 = 12;
                      continue;
                    case 22:
                      if (filter1 == null)
                      {
                        num3 = 8;
                        continue;
                      }
                      goto case 19;
                    case 23:
                      // ISSUE: reference to a compiler-generated method
                      list1 = source1.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => !LocalizationHolder.\u003C\u003Ec.rhbfoAvr3KQiAZ5OVEEM((object) r))).ToList<PoLineDescriptor>();
                      num3 = 2;
                      continue;
                    case 24:
                      SerializableDictionary<string, long> fuzzyByFile = statistic.FuzzyByFile;
                      object key = LocalizationHolder.nivQGPGGvhHVYgLrgE0B((object) current);
                      List<PoLineDescriptor> source5 = source1;
                      // ISSUE: reference to a compiler-generated field
                      Func<PoLineDescriptor, bool> func7 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_19;
                      Func<PoLineDescriptor, bool> predicate2;
                      if (func7 == null)
                      {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated method
                        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_19 = predicate2 = (Func<PoLineDescriptor, bool>) (r => LocalizationHolder.\u003C\u003Ec.luU4IXvrNCLcOtkw1pxa((object) r));
                      }
                      else
                        goto label_93;
label_45:
                      long num13 = (long) source5.Count<PoLineDescriptor>(predicate2);
                      fuzzyByFile.Add((string) key, num13);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 11;
                      continue;
label_93:
                      predicate2 = func7;
                      goto label_45;
                    default:
                      goto label_19;
                  }
                  source1 = poLineDescriptorList;
                  num3 = 4;
                }
label_19:
                current = enumerator.Current;
                num3 = 22;
                goto label_14;
label_22:
                num3 = 20;
                goto label_14;
              }
              finally
              {
                enumerator.Dispose();
                int num14 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                  num14 = 0;
                switch (num14)
                {
                  default:
                }
              }
            case 8:
            case 19:
              localizationFileList = holder.Files;
              break;
            case 9:
              statistic.TotalFuzzy = statistic.FuzzyByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (f => f.Value));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            case 10:
              LocalizationHolder.VHPAwfGGTJdSopTLUT3l((object) statistic, statistic.HighPriorityWordsByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (w => w.Value)));
              num2 = 21;
              continue;
            case 11:
              statistic = new LocalizationStatistic();
              num2 = 6;
              continue;
            case 12:
              LocalizationStatistic localizationStatistic1 = statistic;
              SerializableDictionary<string, long> charsByFile = statistic.CharsByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func8 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_5;
              Func<KeyValuePair<string, long>, long> selector6;
              if (func8 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_5 = selector6 = (Func<KeyValuePair<string, long>, long>) (c => c.Value);
              }
              else
                goto label_94;
label_71:
              long num15 = charsByFile.Sum<KeyValuePair<string, long>>(selector6);
              LocalizationHolder.WUATp2GGRfwNURipDvGn((object) localizationStatistic1, num15);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 0;
              continue;
label_94:
              selector6 = func8;
              goto label_71;
            case 13:
              LocalizationStatistic localizationStatistic2 = statistic;
              SerializableDictionary<string, long> fuzzyCharsByFile = statistic.FuzzyCharsByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func9 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_9;
              Func<KeyValuePair<string, long>, long> selector7;
              if (func9 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_9 = selector7 = (Func<KeyValuePair<string, long>, long>) (w => w.Value);
              }
              else
                goto label_95;
label_79:
              long num16 = fuzzyCharsByFile.Sum<KeyValuePair<string, long>>(selector7);
              LocalizationHolder.aFhLhEGGXLpuvlvSKvdx((object) localizationStatistic2, num16);
              num2 = 18;
              continue;
label_95:
              selector7 = func9;
              goto label_79;
            case 14:
label_62:
              LocalizationStatistic localizationStatistic3 = statistic;
              SerializableDictionary<string, long> stringsByFile = statistic.StringsByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func10 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_1;
              Func<KeyValuePair<string, long>, long> selector8;
              if (func10 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_1 = selector8 = (Func<KeyValuePair<string, long>, long>) (f => f.Value);
              }
              else
                goto label_92;
label_64:
              long num17 = stringsByFile.Sum<KeyValuePair<string, long>>(selector8);
              localizationStatistic3.TotalStrings = num17;
              num2 = 15;
              continue;
label_92:
              selector8 = func10;
              goto label_64;
            case 15:
              LocalizationHolder.Tp9kpOGGZgKdi5DChnvF((object) statistic, statistic.TranslatedByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (f => f.Value)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 3 : 2;
              continue;
            case 16:
              filter1 = filter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 11 : 6;
              continue;
            case 17:
              num2 = 16;
              continue;
            case 18:
              LocalizationStatistic localizationStatistic4 = statistic;
              SerializableDictionary<string, long> highPriorityByFile = statistic.HighPriorityByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func11 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_10;
              Func<KeyValuePair<string, long>, long> selector9;
              if (func11 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_10 = selector9 = (Func<KeyValuePair<string, long>, long>) (w => w.Value);
              }
              else
                goto label_96;
label_82:
              long num18 = highPriorityByFile.Sum<KeyValuePair<string, long>>(selector9);
              localizationStatistic4.TotalHighStrings = num18;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 10 : 5;
              continue;
label_96:
              selector9 = func11;
              goto label_82;
            case 20:
              if (!LocalizationHolder.VN3F2wGGC1N1yZN7et8b(LocalizationHolder.ap1pouGGQ9D5RelvYWe9((object) filter1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                continue;
              }
              goto case 8;
            case 21:
              LocalizationStatistic localizationStatistic5 = statistic;
              SerializableDictionary<string, long> priorityCharsByFile = statistic.HighPriorityCharsByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func12 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_12;
              Func<KeyValuePair<string, long>, long> selector10;
              if (func12 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_12 = selector10 = (Func<KeyValuePair<string, long>, long>) (w => w.Value);
              }
              else
                goto label_97;
label_86:
              long num19 = priorityCharsByFile.Sum<KeyValuePair<string, long>>(selector10);
              LocalizationHolder.yEOaM2GGkwvExi81MkAX((object) localizationStatistic5, num19);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 4 : 4;
              continue;
label_97:
              selector10 = func12;
              goto label_86;
            case 22:
              LocalizationStatistic localizationStatistic6 = statistic;
              SerializableDictionary<string, long> translatedCharsByFile = statistic.TranslatedCharsByFile;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, long>, long> func13 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_7;
              Func<KeyValuePair<string, long>, long> selector11;
              if (func13 == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__24_7 = selector11 = (Func<KeyValuePair<string, long>, long>) (tc => tc.Value);
              }
              else
                goto label_98;
label_75:
              long num20 = translatedCharsByFile.Sum<KeyValuePair<string, long>>(selector11);
              LocalizationHolder.nhmNkoGGqEDWdhUEeyNN((object) localizationStatistic6, num20);
              num2 = 5;
              continue;
label_98:
              selector11 = func13;
              goto label_75;
            default:
              LocalizationHolder.Q369UUGGi9h9H9TpL8Q0((object) statistic, statistic.WordsByFile.Sum<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, long>) (w => w.Value)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 9 : 12;
              continue;
          }
          enumerator = localizationFileList.GetEnumerator();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 7 : 7;
        }
label_10:
        num1 = 19;
      }
label_6:
      return statistic;
    }

    protected static List<PoLineDescriptor> GetDescriptors(
      PoLineFilter filter,
      LocalizationHolder mainHolder,
      LocalizationHolder joinHolder)
    {
      // ISSUE: reference to a compiler-generated method
      List<PoLineDescriptor> list = (filter == null || string.IsNullOrEmpty(filter.FileName) ? (IEnumerable<LocalizationFile>) mainHolder.Files : (IEnumerable<LocalizationFile>) mainHolder.Files.Where<LocalizationFile>((Func<LocalizationFile, bool>) (f => f.Name.Equals((string) LocalizationHolder.\u003C\u003Ec__DisplayClass25_0.sovh3fvr6h7qJGiC79Fe((object) filter), StringComparison.OrdinalIgnoreCase))).ToList<LocalizationFile>()).SelectMany<LocalizationFile, PoLineDescriptor>((Func<LocalizationFile, IEnumerable<PoLineDescriptor>>) (f => (IEnumerable<PoLineDescriptor>) f.Resources)).ToList<PoLineDescriptor>();
      List<PoLineDescriptor> first = LocalizationFile.ApplyFilter((IEnumerable<PoLineDescriptor>) list, filter);
      if (joinHolder != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        List<PoLineDescriptor> newRes = (filter == null || string.IsNullOrEmpty(filter.FileName) ? joinHolder.Files : joinHolder.Files.Where<LocalizationFile>((Func<LocalizationFile, bool>) (f => LocalizationHolder.\u003C\u003Ec__DisplayClass25_0.qEksrBvrATJHwN7FUTxU(LocalizationHolder.\u003C\u003Ec__DisplayClass25_0.FXgGm7vrH448OPYXKi5l((object) f), LocalizationHolder.\u003C\u003Ec__DisplayClass25_0.sovh3fvr6h7qJGiC79Fe((object) filter), StringComparison.OrdinalIgnoreCase))).ToList<LocalizationFile>()).SelectMany<LocalizationFile, PoLineDescriptor>((Func<LocalizationFile, IEnumerable<PoLineDescriptor>>) (f => (IEnumerable<PoLineDescriptor>) f.Resources)).ToList<PoLineDescriptor>();
        List<PoLineDescriptor> ress = first;
        if (filter != null && !string.IsNullOrEmpty(filter.SearchString))
        {
          PoLineFilter poLineFilter = new PoLineFilter();
          poLineFilter.SearchString = filter.SearchString;
          PoLineFilter filter1 = poLineFilter;
          newRes = LocalizationFile.ApplyFilter((IEnumerable<PoLineDescriptor>) newRes, filter1);
          IEnumerable<PoLineDescriptor> second = list.Where<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r =>
          {
            int num = 5;
            PoLineDescriptor r1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_6;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (ress.All<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (nr => LocalizationHolder.\u003C\u003Ec__DisplayClass25_2.yXgVIQvrgfEAaqBKRYX0(LocalizationHolder.\u003C\u003Ec__DisplayClass25_2.Bp5FsKvrlnxgesXDTxMA((object) nr), (object) r1.Key))))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
                    continue;
                  }
                  goto label_7;
                case 3:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!newRes.Any<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (nr => LocalizationHolder.\u003C\u003Ec__DisplayClass25_2.G6y5iivrropXoPhCy9oj(LocalizationHolder.\u003C\u003Ec__DisplayClass25_2.Bp5FsKvrlnxgesXDTxMA((object) nr), (object) r1.Key))))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 2;
                case 4:
                  r1 = r;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 3;
                  continue;
                case 5:
                  num = 4;
                  continue;
                default:
                  goto label_7;
              }
            }
label_6:
            // ISSUE: reference to a compiler-generated method
            return LocalizationHolder.\u003C\u003Ec__DisplayClass25_1.wkfgnXvryV1Ibqq2Y7yI((object) filter, (object) r1);
label_7:
            return false;
          }));
          first = first.Union<PoLineDescriptor>(second).ToList<PoLineDescriptor>();
        }
      }
      return first;
    }

    /// <summary>Количество ресурсов, по условию</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public static long Count(
      PoLineFilter filter,
      LocalizationHolder mainHolder,
      LocalizationHolder joinHolder)
    {
      return (long) LocalizationHolder.T8XhNIGG8AC2LnT9eiAQ((object) LocalizationHolder.GetDescriptors(filter, mainHolder, joinHolder));
    }

    /// <summary>Количество ресурсов, по условию</summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public long Count(PoLineFilter filter) => LocalizationHolder.okGCsxGGnD0xuGd8qEwp((object) filter, (object) this, (object) null);

    /// <summary>Поиск по всем ресурсам</summary>
    /// <param name="options"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    public static List<PoLineDescriptor> Find(
      FetchOptions options,
      PoLineFilter filter,
      LocalizationHolder mainHolder,
      LocalizationHolder joinHolder)
    {
      List<PoLineDescriptor> source = LocalizationHolder.GetDescriptors(filter, mainHolder, joinHolder);
      if (options != (FetchOptions) null)
      {
        if (!string.IsNullOrEmpty(options.SortExpression))
        {
          string sortExpression = options.SortExpression;
          if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459597973)))
          {
            if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113887831))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              source = (options.SortDirection == ListSortDirection.Descending ? (IEnumerable<PoLineDescriptor>) source.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.N6YjT2vrPb6Ysw8yl2cw((object) r))) : (IEnumerable<PoLineDescriptor>) source.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.N6YjT2vrPb6Ysw8yl2cw((object) r)))).ToList<PoLineDescriptor>();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            source = (options.SortDirection == ListSortDirection.Ascending ? (IEnumerable<PoLineDescriptor>) source.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r))) : (IEnumerable<PoLineDescriptor>) source.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)))).ToList<PoLineDescriptor>();
          }
        }
        source = options.FirstResult + options.MaxResults >= source.Count ? source.GetRange(options.FirstResult, source.Count - options.FirstResult) : source.GetRange(options.FirstResult, options.MaxResults);
      }
      return source;
    }

    /// <summary>Вернуть ресурсы, удовлетворяющие условию</summary>
    /// <param name="options"></param>
    /// <param name="filter"></param>
    /// <returns></returns>
    public List<PoLineDescriptor> Find(FetchOptions options, PoLineFilter filter) => LocalizationHolder.Find(options, filter, this, (LocalizationHolder) null);

    /// <summary>Поиск ресурса по ключу</summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public PoLineDescriptor Find(string key)
    {
      int num1 = 2;
      List<LocalizationFile>.Enumerator enumerator;
      string key1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            key1 = key;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_15;
          case 4:
            goto label_3;
          default:
            enumerator = this.Files.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 4;
            continue;
        }
      }
label_3:
      PoLineDescriptor poLineDescriptor1;
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_10;
        else
          goto label_6;
label_4:
        PoLineDescriptor poLineDescriptor2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              poLineDescriptor1 = poLineDescriptor2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 5;
              continue;
            case 3:
              if (poLineDescriptor2 == null)
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 5:
              goto label_16;
            case 6:
              goto label_15;
            default:
              goto label_5;
          }
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 6 : 3;
        goto label_4;
label_10:
        // ISSUE: reference to a compiler-generated method
        poLineDescriptor2 = enumerator.Current.Resources.FirstOrDefault<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => ((string) LocalizationHolder.\u003C\u003Ec__DisplayClass30_0.Pp4O4cvrUMNBNyyUw7ju((object) r)).Equals(key1)));
        num2 = 3;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_16:
      return poLineDescriptor1;
label_15:
      return (PoLineDescriptor) null;
    }

    /// <summary>Поиск ресурсов по набору строк</summary>
    /// <param name="words"></param>
    /// <returns></returns>
    public List<PoLineDescriptor> FindByWords(
      FetchOptions options,
      List<List<string>> words,
      bool containsMode)
    {
      List<PoLineDescriptor> source = this.Files.SelectMany<LocalizationFile, PoLineDescriptor>((Func<LocalizationFile, IEnumerable<PoLineDescriptor>>) (f => (IEnumerable<PoLineDescriptor>) f.FindByWords(words, containsMode))).ToList<PoLineDescriptor>();
      if (options != (FetchOptions) null)
      {
        if (!string.IsNullOrEmpty(options.SortExpression))
        {
          string sortExpression = options.SortExpression;
          if (!(sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633539553)))
          {
            if (sortExpression == z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108611484))
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              source = (options.SortDirection == ListSortDirection.Descending ? (IEnumerable<PoLineDescriptor>) source.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.N6YjT2vrPb6Ysw8yl2cw((object) r))) : (IEnumerable<PoLineDescriptor>) source.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.N6YjT2vrPb6Ysw8yl2cw((object) r)))).ToList<PoLineDescriptor>();
            }
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            source = (options.SortDirection == ListSortDirection.Ascending ? (IEnumerable<PoLineDescriptor>) source.OrderBy<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r))) : (IEnumerable<PoLineDescriptor>) source.OrderByDescending<PoLineDescriptor, string>((Func<PoLineDescriptor, string>) (r => (string) LocalizationHolder.\u003C\u003Ec.xcOlucvrOMsZZWm1qLRv((object) r)))).ToList<PoLineDescriptor>();
          }
        }
        source = options.FirstResult + options.MaxResults >= source.Count ? source.GetRange(options.FirstResult, source.Count - options.FirstResult) : source.GetRange(options.FirstResult, options.MaxResults);
      }
      return source;
    }

    public static string[] SplitByWords(string text)
    {
      object source1 = LocalizationHolder.frr1R1GG2NoQa1EcY894((object) text, LocalizationHolder.LkMOMoGGObJX7pSilgLZ(~-306453669 ^ 306685904));
      // ISSUE: reference to a compiler-generated field
      Func<string, string> func1 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__32_0;
      Func<string, string> selector;
      if (func1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__32_0 = selector = (Func<string, string>) (w => (string) LocalizationHolder.\u003C\u003Ec.hxn8DmvrpsUFX4jgsLIn((object) w));
      }
      else
        goto label_1;
label_3:
      IEnumerable<string> source2 = ((IEnumerable<string>) source1).Select<string, string>(selector);
      // ISSUE: reference to a compiler-generated field
      Func<string, bool> func2 = LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__32_1;
      Func<string, bool> predicate;
      if (func2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        LocalizationHolder.\u003C\u003Ec.\u003C\u003E9__32_1 = predicate = (Func<string, bool>) (w =>
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                if (string.IsNullOrEmpty(w))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          return LocalizationHolder.\u003C\u003Ec.PhblcbvraXIuC3woKfXG((object) w) > 2;
label_3:
          return false;
        });
      }
      else
        goto label_4;
label_6:
      return source2.Where<string>(predicate).ToArray<string>();
label_4:
      predicate = func2;
      goto label_6;
label_1:
      selector = func1;
      goto label_3;
    }

    /// <summary>Поиск ресурсов по набору строк</summary>
    /// <param name="options">Параметры выборки</param>
    /// <param name="text">Текст для поиска</param>
    /// <param name="level">Уровень соответствия</param>
    /// <returns></returns>
    public List<PoLineDescriptor> FindByWords(
      FetchOptions options,
      string text,
      double level,
      bool containsMode)
    {
      string[] strArray = LocalizationHolder.SplitByWords(text);
      if (strArray.Length == 0)
        return new List<PoLineDescriptor>();
      if (strArray.Length > 10)
        strArray = ((IEnumerable<string>) strArray).ToList<string>().GetRange(0, 10).ToArray();
      int length = strArray.Length;
      long int64 = Convert.ToInt64(Math.Round((double) strArray.Length * level));
      List<List<string>> stringListList = new List<List<string>>();
      string[] buffer = new string[int64];
      this.GetCombination(0L, 0L, (long) length, int64, strArray, stringListList, buffer);
      return this.FindByWords(options, stringListList, containsMode);
    }

    /// <summary>Найдем все сочетания без повторений</summary>
    /// <param name="pos"></param>
    /// <param name="maxUsed"></param>
    /// <param name="wordsCount"></param>
    /// <param name="wordsLevelCount"></param>
    /// <param name="words"></param>
    /// <param name="combinations"></param>
    /// <param name="buffer"></param>
    public void GetCombination(
      long pos,
      long maxUsed,
      long wordsCount,
      long wordsLevelCount,
      string[] words,
      List<List<string>> combinations,
      string[] buffer)
    {
      if (pos == wordsLevelCount)
      {
        combinations.Add(((IEnumerable<string>) buffer).ToList<string>());
      }
      else
      {
        for (long maxUsed1 = maxUsed + 1L; maxUsed1 <= wordsCount; ++maxUsed1)
        {
          buffer[pos] = words[maxUsed1 - 1L];
          this.GetCombination(pos + 1L, maxUsed1, wordsCount, wordsLevelCount, words, combinations, buffer);
        }
      }
    }

    internal static void VWXUOXGGFuOkNlqpQ1M4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool eQ09tOGhcg0Qg5KlAW0H() => LocalizationHolder.ymdk8gGhsskcwF28v8Aa == null;

    internal static LocalizationHolder gXSx2mGhzpNiPSYJECKe() => LocalizationHolder.ymdk8gGhsskcwF28v8Aa;

    internal static object jPl69FGGBXtIf1TkGWO0([In] object obj0) => (object) ((PoLineDescriptor) obj0).Value;

    internal static void aOZ0bZGGWlPH8YLRriLs([In] object obj0, [In] object obj1) => ((PoLineDescriptor) obj0).Value = (string) obj1;

    internal static void F3BbSrGGovE6ZP5KLoc0([In] object obj0, bool value) => ((PoLineDescriptor) obj0).IsFuzzy = value;

    internal static bool JDSNW0GGbNrxJ6LmUUjN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void e5aY0fGGhyBwpXUEbVyB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void BAtHgqGGGOYcxTXapULw([In] object obj0, bool value) => ((PoLineDescriptor) obj0).IsLow = value;

    internal static object mIrKkSGGEHFLsEiRIFtP([In] object obj0, [In] object obj1) => (object) LocalizationHolder.GetStatistic((LocalizationHolder) obj0, (PoLineFilter) obj1);

    internal static void Vq2xFbGGfXopoVwHvFRj([In] object obj0) => Monitor.Exit(obj0);

    internal static object ap1pouGGQ9D5RelvYWe9([In] object obj0) => (object) ((PoLineFilter) obj0).FileName;

    internal static bool VN3F2wGGC1N1yZN7et8b([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object nivQGPGGvhHVYgLrgE0B([In] object obj0) => (object) ((LocalizationFile) obj0).Name;

    internal static int T8XhNIGG8AC2LnT9eiAQ([In] object obj0) => ((List<PoLineDescriptor>) obj0).Count;

    internal static void Tp9kpOGGZgKdi5DChnvF([In] object obj0, long value) => ((LocalizationStatistic) obj0).Translated = value;

    internal static long NkyqEVGGuM9LUCArKZQZ([In] object obj0) => ((LocalizationStatistic) obj0).TotalStrings;

    internal static long Murt8YGGIcGKN2aFPGeT([In] object obj0) => ((LocalizationStatistic) obj0).Translated;

    internal static int qyRdk3GGVxtHOjFdsN4R([In] long obj0) => Convert.ToInt32(obj0);

    internal static void NsehwFGGShtui6qS5jjM([In] object obj0, int value) => ((LocalizationStatistic) obj0).TotalProgress = value;

    internal static void Q369UUGGi9h9H9TpL8Q0([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalWords = value;

    internal static void WUATp2GGRfwNURipDvGn([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalChars = value;

    internal static void nhmNkoGGqEDWdhUEeyNN([In] object obj0, long value) => ((LocalizationStatistic) obj0).TranslatedChars = value;

    internal static void qJswHXGGK3aKY8uSKZgL([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalFuzzyWords = value;

    internal static void aFhLhEGGXLpuvlvSKvdx([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalFuzzyChars = value;

    internal static void VHPAwfGGTJdSopTLUT3l([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalHighWords = value;

    internal static void yEOaM2GGkwvExi81MkAX([In] object obj0, long value) => ((LocalizationStatistic) obj0).TotalHighChars = value;

    internal static long okGCsxGGnD0xuGd8qEwp([In] object obj0, [In] object obj1, [In] object obj2) => LocalizationHolder.Count((PoLineFilter) obj0, (LocalizationHolder) obj1, (LocalizationHolder) obj2);

    internal static object LkMOMoGGObJX7pSilgLZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object frr1R1GG2NoQa1EcY894([In] object obj0, [In] object obj1) => (object) Regex.Split((string) obj0, (string) obj1);
  }
}
