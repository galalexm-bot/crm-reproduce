// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Components.SettingsFeatureFlagProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FeatureFlags.Components
{
  /// <summary>Провайдер флагов для Settings.config</summary>
  [Component(Order = -2147483648)]
  internal sealed class SettingsFeatureFlagProvider : BaseFeatureFlagProvider
  {
    private readonly ILogger logger;
    private ISet<string> flagNames;
    private IDictionary<string, bool> flags;
    internal static SettingsFeatureFlagProvider Ui3HvPGWgLDZ9cThXJt4;

    /// <summary>ctor</summary>
    public SettingsFeatureFlagProvider()
    {
      SettingsFeatureFlagProvider.tSSV0SGWYUJy840a30E8();
      // ISSUE: type reference
      this.logger = (ILogger) SettingsFeatureFlagProvider.clBIgSGWUyXt2SdKqSEc(SettingsFeatureFlagProvider.MJTg23GWLF3KWhxo7gqO(__typeref (SettingsFeatureFlagProvider)));
      this.flagNames = (ISet<string>) new HashSet<string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            SettingsFeatureFlagProvider.oNuq3HGWsuGN9QmmAugW((object) SettingsFeatureFlagProvider.Container, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(
      IEnumerable<string> featureFlagNames)
    {
      int num = this.IsLogEnabled ? this.flags.Count<KeyValuePair<string, bool>>((Func<KeyValuePair<string, bool>, bool>) (p => this.flagNames.Contains(p.Key))) : 0;
      this.flagNames.UnionWith(featureFlagNames);
      if (this.IsLogEnabled && num < this.flags.Count<KeyValuePair<string, bool>>((Func<KeyValuePair<string, bool>, bool>) (p => this.flagNames.Contains(p.Key))))
        this.Log();
      bool flag;
      return this.flagNames.Select<string, (string, bool)>((Func<string, (string, bool)>) (name => !this.flags.TryGetValue(name, out flag) ? ((string) null, false) : (name, flag))).Where<(string, bool)>((Func<(string, bool), bool>) (p => p.name != null));
    }

    private void UpdateFlags(IDictionary<string, bool> newFlags)
    {
      bool flag;
      if (this.flags != null && this.flags.Count == newFlags.Count && !this.flags.Any<KeyValuePair<string, bool>>((Func<KeyValuePair<string, bool>, bool>) (p => !newFlags.TryGetValue(p.Key, out flag) || flag != p.Value)))
        return;
      this.flags = newFlags;
      this.Log();
      this.FlagsChanged();
    }

    private bool IsLogEnabled => this.logger.IsInfoEnabled();

    private void Log()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (!this.IsLogEnabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
          case 4:
            ILogger logger = this.logger;
            object format = SettingsFeatureFlagProvider.uIKS83GWz0hqhRk5EqTt(1597012150 ^ 1597227172);
            object[] objArray = new object[1];
            IEnumerable<KeyValuePair<string, bool>> source = this.flags.Where<KeyValuePair<string, bool>>((Func<KeyValuePair<string, bool>, bool>) (p => this.flagNames.Contains(p.Key)));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, bool>, string> func = SettingsFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__8_1;
            Func<KeyValuePair<string, bool>, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              SettingsFeatureFlagProvider.\u003C\u003Ec.\u003C\u003E9__8_1 = selector = (Func<KeyValuePair<string, bool>, string>) (p => Environment.NewLine + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282054332) + p.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397255820) + (object) p.Value);
            }
            else
              goto label_12;
label_11:
            objArray[0] = (object) string.Concat(source.Select<KeyValuePair<string, bool>, string>(selector));
            logger.InfoFormat((string) format, objArray);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 3 : 3;
            continue;
label_12:
            selector = func;
            goto label_11;
        }
        if (SettingsFeatureFlagProvider.PgFAPcGWcV4DRgxUgkKs((object) this.flagNames) > 0)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 4;
        else
          goto label_5;
      }
label_9:
      return;
label_2:
      return;
label_5:;
    }

    /// <summary>Контейнер значений</summary>
    internal static SettingsFeatureFlagProvider.SettingsFeatureFlagContainer Container { get; }

    static SettingsFeatureFlagProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SettingsFeatureFlagProvider.Container = new SettingsFeatureFlagProvider.SettingsFeatureFlagContainer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void tSSV0SGWYUJy840a30E8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type MJTg23GWLF3KWhxo7gqO([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object clBIgSGWUyXt2SdKqSEc(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static void oNuq3HGWsuGN9QmmAugW([In] object obj0, [In] object obj1) => ((SettingsFeatureFlagProvider.SettingsFeatureFlagContainer) obj0).Init((SettingsFeatureFlagProvider) obj1);

    internal static bool rKGxR8GW58YEXyIVyEKx() => SettingsFeatureFlagProvider.Ui3HvPGWgLDZ9cThXJt4 == null;

    internal static SettingsFeatureFlagProvider XbHcPcGWjYk3UXVeNx0F() => SettingsFeatureFlagProvider.Ui3HvPGWgLDZ9cThXJt4;

    internal static int PgFAPcGWcV4DRgxUgkKs([In] object obj0) => ((ICollection<string>) obj0).Count;

    internal static object uIKS83GWz0hqhRk5EqTt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    /// <summary>Класс контейнера значений</summary>
    internal sealed class SettingsFeatureFlagContainer
    {
      private IDictionary<string, bool> flags;
      private SettingsFeatureFlagProvider provider;
      internal static SettingsFeatureFlagProvider.SettingsFeatureFlagContainer d4F56RvdkSO2kdlU2MhQ;

      /// <summary>Инициализация</summary>
      /// <param name="provider">Провайдер флагов для Settings.config</param>
      public void Init(SettingsFeatureFlagProvider provider)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EleWise.ELMA.SR.GetSetting("");
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 4;
              continue;
            case 2:
              this.provider = provider;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
              continue;
            case 3:
              this.flags = (IDictionary<string, bool>) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 4:
              provider.UpdateFlags(this.flags);
              num = 3;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:;
      }

      /// <summary>Обновление значений в контейнере</summary>
      /// <param name="settigsStrings">Значения ключей</param>
      public void UpdateFlags(IDictionary<string, string> settigsStrings)
      {
        bool result;
        Dictionary<string, bool> dictionary = settigsStrings.Select<KeyValuePair<string, string>, (string, bool)>((Func<KeyValuePair<string, string>, (string, bool)>) (p => !bool.TryParse(p.Value, out result) ? ((string) null, false) : (p.Key, result))).Where<(string, bool)>((Func<(string, bool), bool>) (p => p.Key != null)).ToDictionary<(string, bool), string, bool>((Func<(string, bool), string>) (p => p.Key), (Func<(string, bool), bool>) (p => p.value));
        if (this.provider == null)
          this.flags = (IDictionary<string, bool>) dictionary;
        else
          this.provider.UpdateFlags((IDictionary<string, bool>) dictionary);
      }

      public SettingsFeatureFlagContainer()
      {
        SettingsFeatureFlagProvider.SettingsFeatureFlagContainer.Cxel3Cvd2oqvEtC1jVST();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool oLbIjYvdnNVnw5c6wfqP() => SettingsFeatureFlagProvider.SettingsFeatureFlagContainer.d4F56RvdkSO2kdlU2MhQ == null;

      internal static SettingsFeatureFlagProvider.SettingsFeatureFlagContainer AF0i61vdOskl5gtcLqYj() => SettingsFeatureFlagProvider.SettingsFeatureFlagContainer.d4F56RvdkSO2kdlU2MhQ;

      internal static void Cxel3Cvd2oqvEtC1jVST() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
