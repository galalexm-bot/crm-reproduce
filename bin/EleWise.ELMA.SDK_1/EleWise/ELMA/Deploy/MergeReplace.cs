// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.MergeReplace
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Deploy
{
  /// <summary>Класс для описания списков заменяемых uid'ов</summary>
  public class MergeReplace
  {
    private Dictionary<Guid, Guid> uidReplaceMD;
    private Dictionary<Guid, Dictionary<Guid, Guid>> uidReplaceProperty;
    private Dictionary<Guid, Dictionary<string, string>> nameReplaceProperty;
    internal static MergeReplace HkkM1qEpbPCJZxmSUmSn;

    /// <summary>Добавление пары замены Uid'ов метаданных</summary>
    /// <param name="uidFrom"></param>
    /// <param name="uidTo"></param>
    /// <returns></returns>
    public void SetUidReplaceMD(Guid uidFrom, Guid uidTo)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, string> dictionary1;
        Dictionary<Guid, Guid> dictionary2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
            case 8:
              if (!this.nameReplaceProperty.TryGetValue(uidFrom, out dictionary1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 11 : 9;
                continue;
              }
              goto case 12;
            case 2:
              this.uidReplaceProperty.Add(uidTo, dictionary2);
              num2 = 7;
              continue;
            case 4:
              goto label_5;
            case 5:
              if (this.uidReplaceMD.ContainsKey(uidFrom))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 4 : 1;
                continue;
              }
              this.uidReplaceMD.Add(uidFrom, uidTo);
              num2 = 13;
              continue;
            case 6:
              this.nameReplaceProperty.Add(uidTo, dictionary1);
              num2 = 9;
              continue;
            case 7:
              goto label_18;
            case 9:
              this.nameReplaceProperty.Remove(uidFrom);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 10 : 4;
              continue;
            case 10:
              goto label_19;
            case 11:
              goto label_4;
            case 12:
              if (!this.nameReplaceProperty.ContainsKey(uidTo))
              {
                num2 = 6;
                continue;
              }
              goto label_16;
            case 13:
              if (!this.uidReplaceProperty.TryGetValue(uidFrom, out dictionary2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
                continue;
              }
              goto default;
            default:
              if (!this.uidReplaceProperty.ContainsKey(uidTo))
                goto case 2;
              else
                goto label_7;
          }
        }
label_7:
        num1 = 3;
        continue;
label_18:
        this.uidReplaceProperty.Remove(uidFrom);
        num1 = 8;
      }
label_5:
      return;
label_19:
      return;
label_4:
      return;
label_16:;
    }

    /// <summary>Получение замещающего значения Uid'а метаданных</summary>
    /// <returns></returns>
    public Guid GetUidReplaceMD(Guid uidFrom)
    {
      int num = 1;
      Guid uidReplaceMd;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.uidReplaceMD.TryGetValue(uidFrom, out uidReplaceMd))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return uidFrom;
label_5:
      return uidReplaceMd;
    }

    /// <summary>Добавление пары замены Uid'ов свойства</summary>
    /// <param name="uidFrom"></param>
    /// <param name="uidTo"></param>
    /// <returns></returns>
    public void SetUidReplaceProperty(Guid mdUid, Guid uidFrom, Guid uidTo)
    {
      int num = 4;
      Guid uidReplaceMd;
      Dictionary<Guid, Guid> dictionary;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
          case 6:
            if (dictionary.ContainsKey(uidFrom))
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 2:
            this.uidReplaceProperty.Add(uidReplaceMd, dictionary = new Dictionary<Guid, Guid>());
            num = 6;
            continue;
          case 3:
            if (this.uidReplaceProperty.TryGetValue(uidReplaceMd, out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 4:
            uidReplaceMd = this.GetUidReplaceMD(mdUid);
            num = 3;
            continue;
          case 5:
            goto label_3;
          case 7:
            dictionary.Add(uidFrom, uidTo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Получение замещающего значения Uid'а свойства</summary>
    /// <returns></returns>
    public Guid GetUidReplaceProperty(Guid mdUid, Guid uidFrom)
    {
      int num = 1;
      Guid uidReplaceProperty;
      Dictionary<Guid, Guid> dictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.uidReplaceProperty.TryGetValue(this.GetUidReplaceMD(mdUid), out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            if (dictionary.TryGetValue(uidFrom, out uidReplaceProperty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return uidFrom;
label_3:
      return uidReplaceProperty;
    }

    /// <summary>Добавление пары замены Name'ов свойства</summary>
    /// <param name="stringFrom"></param>
    /// <param name="stringTo"></param>
    /// <returns></returns>
    public void SetNameReplaceProperty(Guid mdUid, string stringFrom, string stringTo)
    {
      int num = 5;
      Guid uidReplaceMd;
      Dictionary<string, string> dictionary;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (dictionary.ContainsKey(stringFrom))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 1;
              continue;
            }
            dictionary.Add(stringFrom, stringTo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            this.nameReplaceProperty.Add(uidReplaceMd, dictionary = new Dictionary<string, string>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
            continue;
          case 4:
            if (!this.nameReplaceProperty.TryGetValue(uidReplaceMd, out dictionary))
            {
              num = 3;
              continue;
            }
            goto case 1;
          case 5:
            uidReplaceMd = this.GetUidReplaceMD(mdUid);
            num = 4;
            continue;
          default:
            goto label_11;
        }
      }
label_2:
      return;
label_6:
      return;
label_11:;
    }

    /// <summary>Получение замещающего значения Name'а свойства</summary>
    /// <returns></returns>
    public string GetNameReplaceProperty(Guid mdUid, string stringFrom)
    {
      int num = 2;
      string nameReplaceProperty;
      Dictionary<string, string> dictionary;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dictionary.TryGetValue(stringFrom, out nameReplaceProperty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            if (this.nameReplaceProperty.TryGetValue(this.GetUidReplaceMD(mdUid), out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return stringFrom;
label_3:
      return nameReplaceProperty;
    }

    /// <summary>Получение списка замены uid'ов для метаданных</summary>
    /// <returns></returns>
    public IEnumerable<KeyValuePair<Guid, Guid>> GetAllUidReplaceMd() => (IEnumerable<KeyValuePair<Guid, Guid>>) this.uidReplaceMD;

    /// <summary>Получение списка замены uid'ов свойств для метаданных</summary>
    /// <returns></returns>
    public IEnumerable<KeyValuePair<Guid, Guid>> GetAllUidReplaceProperty() => this.uidReplaceProperty.Values.SelectMany<Dictionary<Guid, Guid>, KeyValuePair<Guid, Guid>>((Func<Dictionary<Guid, Guid>, IEnumerable<KeyValuePair<Guid, Guid>>>) (d => (IEnumerable<KeyValuePair<Guid, Guid>>) d));

    public MergeReplace()
    {
      MergeReplace.NhKlu6EpElLHZhHiXsTY();
      this.uidReplaceMD = new Dictionary<Guid, Guid>();
      this.uidReplaceProperty = new Dictionary<Guid, Dictionary<Guid, Guid>>();
      this.nameReplaceProperty = new Dictionary<Guid, Dictionary<string, string>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pKD03PEphrLvpyPXh06M() => MergeReplace.HkkM1qEpbPCJZxmSUmSn == null;

    internal static MergeReplace JJ1u0EEpGAK3UBH2lTbL() => MergeReplace.HkkM1qEpbPCJZxmSUmSn;

    internal static void NhKlu6EpElLHZhHiXsTY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
