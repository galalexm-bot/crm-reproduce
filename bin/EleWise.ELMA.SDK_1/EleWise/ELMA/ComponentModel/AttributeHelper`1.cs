// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AttributeHelper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Класс, предоставляющий методы для доступа к атрибутам</summary>
  /// <typeparam name="T">Тип атрибута</typeparam>
  public static class AttributeHelper<T> where T : Attribute
  {
    private static AttributeHelper<T>.AttributesCache<Type> _attributesCacheType;
    private static AttributeHelper<T>.AttributesCache<MemberInfo> _attributesCacheMemberInfo;
    private static AttributeHelper<T>.AttributesCache<Assembly> _attributesCacheAssembly;
    private static AttributeHelper<T>.AttributesCache<ParameterInfo> _attributesCacheParameterInfo;
    private static AttributeHelper<T>.AttributesCache<ParameterDescriptor> _attributesCacheParameterDescriptor;

    /// <summary>Сбросить атрибут у типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T ResetAttribute([NotNull] Type type, bool inherited)
    {
      Contract.ArgumentNotNull((object) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236070381));
      return AttributeHelper<T>.attributesCacheType.Get(type, inherited, new Func<Type, bool, IList<T>>(AttributeHelper<T>.GetTypeAttributes));
    }

    /// <summary>Получить атрибут у типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T GetAttribute([NotNull] Type type, bool inherited)
    {
      Contract.ArgumentNotNull((object) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283382521));
      return AttributeHelper<T>.attributesCacheType.Get(type, inherited, new Func<Type, bool, IList<T>>(AttributeHelper<T>.GetTypeAttributes));
    }

    /// <summary>Получить атрибут у типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static IList<T> GetAttributes([NotNull] Type type, bool inherited)
    {
      Contract.ArgumentNotNull((object) type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479500694));
      return AttributeHelper<T>.attributesCacheType.GetList(type, inherited, new Func<Type, bool, IList<T>>(AttributeHelper<T>.GetTypeAttributes));
    }

    /// <summary>Получить атрибут у сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T GetAttribute([NotNull] Assembly assembly) => !(assembly == (Assembly) null) ? AttributeHelper<T>.attributesCacheAssembly.Get(assembly, false, new Func<Assembly, bool, IList<T>>(AttributeHelper<T>.GetAssemblyAttributes)) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883337054));

    /// <summary>Получить атрибуты у сборки</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns>Атрибуты. Если не найдено - null</returns>
    public static IList<T> GetAttributes([NotNull] Assembly assembly) => !(assembly == (Assembly) null) ? AttributeHelper<T>.attributesCacheAssembly.GetList(assembly, false, new Func<Assembly, bool, IList<T>>(AttributeHelper<T>.GetAssemblyAttributes)) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408923040));

    /// <summary>Получить атрибут у члена типа</summary>
    /// <param name="memberInfo">Член типа</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T GetAttribute([NotNull] MemberInfo memberInfo, bool inherited)
    {
      if (memberInfo == (MemberInfo) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583926744));
      return AttributeHelper<T>.attributesCacheMemberInfo.Get(memberInfo, inherited, new Func<MemberInfo, bool, IList<T>>(AttributeHelper<T>.GetMemberInfoAttributes));
    }

    /// <summary>Получить атрибуты у члена типа</summary>
    /// <param name="memberInfo">Член типа</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибуты</returns>
    public static IList<T> GetAttributes([NotNull] MemberInfo memberInfo, bool inherited)
    {
      if (memberInfo == (MemberInfo) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195947063));
      return AttributeHelper<T>.attributesCacheMemberInfo.GetList(memberInfo, inherited, new Func<MemberInfo, bool, IList<T>>(AttributeHelper<T>.GetMemberInfoAttributes));
    }

    /// <summary>Получить атрибут у параметра</summary>
    /// <param name="parameterInfo">Параметр</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T GetAttribute([NotNull] ParameterInfo parameterInfo, bool inherited)
    {
      if (parameterInfo == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1410865831));
      return AttributeHelper<T>.attributesCacheParameterInfo.Get(parameterInfo, inherited, new Func<ParameterInfo, bool, IList<T>>(AttributeHelper<T>.GetParameterInfoAttributes));
    }

    /// <summary>Получить атрибут у параметра</summary>
    /// <param name="parameterInfo">Параметр</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибут. Если не найден - null</returns>
    public static T GetAttributeForParameterDescriptor(
      [NotNull] ParameterDescriptor parameterInfo,
      bool inherited)
    {
      if (parameterInfo == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1573940388));
      return AttributeHelper<T>.attributesCacheParameterDescriptor.Get(parameterInfo, inherited, new Func<ParameterDescriptor, bool, IList<T>>(AttributeHelper<T>.GetParameterInfoAttributes));
    }

    /// <summary>Получить атрибуты у параметра</summary>
    /// <param name="parameterInfo">Параметр</param>
    /// <param name="inherited">Учитывать родительские классы</param>
    /// <returns>Атрибуты</returns>
    public static IList<T> GetAttributes([NotNull] ParameterInfo parameterInfo, bool inherited)
    {
      if (parameterInfo == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883158724));
      return AttributeHelper<T>.attributesCacheParameterInfo.GetList(parameterInfo, inherited, new Func<ParameterInfo, bool, IList<T>>(AttributeHelper<T>.GetParameterInfoAttributes));
    }

    private static AttributeHelper<T>.AttributesCache<Type> attributesCacheType => AttributeHelper<T>._attributesCacheType ?? (AttributeHelper<T>._attributesCacheType = (AttributeHelper<T>.AttributesCache<Type>) new AttributeHelper<T>.AttributesCacheType());

    private static AttributeHelper<T>.AttributesCache<MemberInfo> attributesCacheMemberInfo => AttributeHelper<T>._attributesCacheMemberInfo ?? (AttributeHelper<T>._attributesCacheMemberInfo = (AttributeHelper<T>.AttributesCache<MemberInfo>) new AttributeHelper<T>.AttributesCacheMemberInfo());

    private static AttributeHelper<T>.AttributesCache<Assembly> attributesCacheAssembly => AttributeHelper<T>._attributesCacheAssembly ?? (AttributeHelper<T>._attributesCacheAssembly = new AttributeHelper<T>.AttributesCache<Assembly>());

    private static AttributeHelper<T>.AttributesCache<ParameterInfo> attributesCacheParameterInfo => AttributeHelper<T>._attributesCacheParameterInfo ?? (AttributeHelper<T>._attributesCacheParameterInfo = new AttributeHelper<T>.AttributesCache<ParameterInfo>());

    private static AttributeHelper<T>.AttributesCache<ParameterDescriptor> attributesCacheParameterDescriptor => AttributeHelper<T>._attributesCacheParameterDescriptor ?? (AttributeHelper<T>._attributesCacheParameterDescriptor = new AttributeHelper<T>.AttributesCache<ParameterDescriptor>());

    /// <summary>Получить атрибуты</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="inherited">Унаследовано?</param>
    /// <returns></returns>
    private static IList<T> GetAssemblyAttributes(Assembly assembly, bool inherited) => AttributeHelper<T>.ToArray(assembly.GetCustomAttributes(TypeOf<T>.Raw, inherited));

    /// <summary>Получить атрибуты</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherited">Унаследовано?</param>
    /// <returns></returns>
    private static IList<T> GetTypeAttributes(Type type, bool inherited) => AttributeHelper<T>.ToArray(type.GetReflectionCustomAttributes(TypeOf<T>.Raw, inherited));

    /// <summary>Получить атрибуты</summary>
    /// <param name="memberInfo">Информация о компоненте</param>
    /// <param name="inherited">Унаследовано?</param>
    /// <returns></returns>
    private static IList<T> GetMemberInfoAttributes(MemberInfo memberInfo, bool inherited) => AttributeHelper<T>.ToArray(memberInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));

    /// <summary>Получить атрибуты</summary>
    /// <param name="parameterInfo">Информация о параметре</param>
    /// <param name="inherited">Унаследовано?</param>
    /// <returns></returns>
    private static IList<T> GetParameterInfoAttributes(ParameterInfo parameterInfo, bool inherited) => AttributeHelper<T>.ToArray(parameterInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));

    /// <summary>Получить атрибуты</summary>
    /// <param name="parameterInfo">Информация о параметре</param>
    /// <param name="inherited">Унаследовано?</param>
    /// <returns></returns>
    private static IList<T> GetParameterInfoAttributes(
      ParameterDescriptor parameterInfo,
      bool inherited)
    {
      return AttributeHelper<T>.ToArray(parameterInfo.GetCustomAttributes(TypeOf<T>.Raw, inherited));
    }

    private static IList<T> ToArray(object[] attributes)
    {
      T[] array = new T[attributes.Length];
      for (int index = 0; index < attributes.Length; ++index)
        array[index] = (T) attributes[index];
      return (IList<T>) array;
    }

    private class AttributesCache<TKey> where TKey : class
    {
      protected IDictionary<TKey, WeakReference<IList<T>>> cache;
      protected IDictionary<TKey, WeakReference<IList<T>>> cacheInherited;
      internal static object ungsdh8gzNyksYIKGWFb;

      protected AttributesCache(
        IDictionary<TKey, WeakReference<IList<T>>> cache,
        IDictionary<TKey, WeakReference<IList<T>>> cacheInherited)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.cache = cache;
        this.cacheInherited = cacheInherited;
      }

      /// <summary>Кеш атрибутов</summary>
      /// <typeparam name="TKey">Класс для которого кешируются атрибуты</typeparam>
      public AttributesCache()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        this.\u002Ector((IDictionary<TKey, WeakReference<IList<T>>>) new ConcurrentDictionary<TKey, WeakReference<IList<T>>>(), (IDictionary<TKey, WeakReference<IList<T>>>) new ConcurrentDictionary<TKey, WeakReference<IList<T>>>());
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
          num = 0;
        switch (num)
        {
        }
      }

      /// <summary>Получить список атрибутов</summary>
      /// <param name="key">Класс</param>
      /// <param name="inherited">Унаследовано?</param>
      /// <param name="getResultFunc">Делегат выборки</param>
      /// <returns></returns>
      public IList<T> GetList(TKey key, bool inherited, Func<TKey, bool, IList<T>> getResultFunc)
      {
        IDictionary<TKey, WeakReference<IList<T>>> dictionary = inherited ? this.cacheInherited : this.cache;
        WeakReference<IList<T>> weakReference;
        IList<T> target;
        if (!dictionary.TryGetValue(key, out weakReference) || weakReference == null || !weakReference.TryGetTarget(out target))
        {
          target = getResultFunc(key, inherited);
          dictionary[key] = new WeakReference<IList<T>>(target);
        }
        return target;
      }

      /// <summary>Получить атрибут</summary>
      /// <param name="key">Класс</param>
      /// <param name="inherited">Унаследовано?</param>
      /// <param name="getResultFunc">Делегат выборки</param>
      /// <returns></returns>
      public T Get(TKey key, bool inherited, Func<TKey, bool, IList<T>> getResultFunc)
      {
        IList<T> list = this.GetList(key, inherited, getResultFunc);
        return list.Count <= 0 ? default (T) : list[0];
      }

      internal static bool FCtm0u85F3XkxP6eejhS() => AttributeHelper<T>.AttributesCache<TKey>.ungsdh8gzNyksYIKGWFb == null;

      internal static object bdyFuI85BOCEFM27F4aq() => AttributeHelper<T>.AttributesCache<TKey>.ungsdh8gzNyksYIKGWFb;
    }

    private class AttributesCacheType : AttributeHelper<T>.AttributesCache<Type>
    {
      internal static object Xv2rLm85WUgdpgjRRxwy;

      public AttributesCacheType()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        IDictionary<Type, WeakReference<IList<T>>> cache1 = PublishCacheContext.CreateCache<Type, WeakReference<IList<T>>>((Action<IDictionary<Type, WeakReference<IList<T>>>, Type, Guid>) ((c, type, _) => c.Remove(type)));
        // ISSUE: reference to a compiler-generated field
        Action<IDictionary<Type, WeakReference<IList<T>>>, Type, Guid> action = AttributeHelper<T>.AttributesCacheType.\u003C\u003Ec.\u003C\u003E9__0_1;
        Action<IDictionary<Type, WeakReference<IList<T>>>, Type, Guid> remove;
        if (action == null)
        {
          // ISSUE: reference to a compiler-generated field
          AttributeHelper<T>.AttributesCacheType.\u003C\u003Ec.\u003C\u003E9__0_1 = remove = (Action<IDictionary<Type, WeakReference<IList<T>>>, Type, Guid>) ((c, type, _) => c.Remove(type));
        }
        else
          goto label_7;
label_3:
        IDictionary<Type, WeakReference<IList<T>>> cache2 = PublishCacheContext.CreateCache<Type, WeakReference<IList<T>>>(remove);
        // ISSUE: explicit constructor call
        base.\u002Ector(cache1, cache2);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num = 0;
        switch (num)
        {
          case 0:
            return;
          default:
            return;
        }
label_7:
        remove = action;
        goto label_3;
      }

      internal static bool pxyfrM85orX2HCNWxU4D() => AttributeHelper<T>.AttributesCacheType.Xv2rLm85WUgdpgjRRxwy == null;

      internal static object MPDSbm85ba9RqhvIdjEg() => AttributeHelper<T>.AttributesCacheType.Xv2rLm85WUgdpgjRRxwy;
    }

    private class AttributesCacheMemberInfo : AttributeHelper<T>.AttributesCache<MemberInfo>
    {
      private static object FUZHcL85hEM6Aa2JgRYZ;

      public AttributesCacheMemberInfo()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector((IDictionary<MemberInfo, WeakReference<IList<T>>>) new AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary(), (IDictionary<MemberInfo, WeakReference<IList<T>>>) new AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary());
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool iGrxIq85GoEbFcVrqAx2() => AttributeHelper<T>.AttributesCacheMemberInfo.FUZHcL85hEM6Aa2JgRYZ == null;

      internal static object Jav7Xg85EcdijUu8toEV() => AttributeHelper<T>.AttributesCacheMemberInfo.FUZHcL85hEM6Aa2JgRYZ;

      private class Dictionary : 
        IDictionary<MemberInfo, WeakReference<IList<T>>>,
        ICollection<KeyValuePair<MemberInfo, WeakReference<IList<T>>>>,
        IEnumerable<KeyValuePair<MemberInfo, WeakReference<IList<T>>>>,
        IEnumerable
      {
        private IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> dictionary;
        internal static object ynwMXXZ3xBpEGhcE1C7G;

        public bool TryGetValue(MemberInfo key, out WeakReference<IList<T>> value)
        {
          int num = 3;
          ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>> concurrentDictionary;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                goto label_4;
              case 3:
                IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> dictionary = this.dictionary;
                Type declaringType = key.DeclaringType;
                Type key1 = (object) declaringType == null ? TypeOf<AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary>.Raw : declaringType;
                ref ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>> local = ref concurrentDictionary;
                if (dictionary.TryGetValue(key1, out local))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 2;
                  continue;
                }
                break;
            }
            value = (WeakReference<IList<T>>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
          }
label_3:
          return false;
label_4:
          return concurrentDictionary.TryGetValue(key, out value);
        }

        public WeakReference<IList<T>> this[MemberInfo key]
        {
          get => throw new NotImplementedException();
          set
          {
            IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> dictionary = this.dictionary;
            Type key1 = key.DeclaringType;
            if ((object) key1 == null)
              key1 = TypeOf<AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary>.Raw;
            Func<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> addValueFactory = (Func<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>>) (k => new ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>((IEnumerable<KeyValuePair<MemberInfo, WeakReference<IList<T>>>>) new KeyValuePair<MemberInfo, WeakReference<IList<T>>>[1]
            {
              new KeyValuePair<MemberInfo, WeakReference<IList<T>>>(key, value)
            }));
            Func<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>> updateValueFactory = (Func<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>>) ((k, d) =>
            {
              d[key] = value;
              return d;
            });
            dictionary.AddOrUpdate<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>>(key1, addValueFactory, updateValueFactory);
          }
        }

        public ICollection<MemberInfo> Keys => throw new NotImplementedException();

        public ICollection<WeakReference<IList<T>>> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(MemberInfo key, WeakReference<IList<T>> value) => throw new NotImplementedException();

        public void Add(
          KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
        {
          throw new NotImplementedException();
        }

        public void Clear() => throw new NotImplementedException();

        public bool Contains(
          KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
        {
          throw new NotImplementedException();
        }

        public bool ContainsKey(MemberInfo key) => throw new NotImplementedException();

        public void CopyTo(
          KeyValuePair<MemberInfo, WeakReference<IList<T>>>[] array,
          int arrayIndex)
        {
          throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<MemberInfo, WeakReference<IList<T>>>> GetEnumerator() => throw new NotImplementedException();

        public bool Remove(MemberInfo key) => throw new NotImplementedException();

        public bool Remove(
          KeyValuePair<MemberInfo, WeakReference<IList<T>>> item)
        {
          throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();

        public Dictionary()
        {
          TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
          this.dictionary = PublishCacheContext.CreateCache<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>>((Action<IDictionary<Type, ConcurrentDictionary<MemberInfo, WeakReference<IList<T>>>>, Type, Guid>) ((c, type, _) => c.Remove(type)));
          // ISSUE: explicit constructor call
          base.\u002Ector();
          int num = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
            num = 0;
          switch (num)
          {
          }
        }

        internal static bool YBpTTeZ30S0j4wiYZY0h() => AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary.ynwMXXZ3xBpEGhcE1C7G == null;

        internal static object DAm5KLZ3mKOqIjUlmvw5() => AttributeHelper<T>.AttributesCacheMemberInfo.Dictionary.ynwMXXZ3xBpEGhcE1C7G;
      }
    }
  }
}
