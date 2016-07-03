﻿using RiotCaller.Enums;
using RiotCaller.StaticEndPoints.Champion;
using RiotCaller.StaticEndPoints.Item;
using RiotCaller.StaticEndPoints.LanguageStrings;
using RiotCaller.StaticEndPoints.Map;
using RiotCaller.StaticEndPoints.Mastery;
using RiotCaller.StaticEndPoints.Realm;
using RiotCaller.StaticEndPoints.Runes;
using RiotCaller.StaticEndPoints.SummonerSpells;
using System.Collections.Generic;
using System.Linq;

namespace RiotCaller
{
    public class StaticApi : IStaticApi
    {
        public RiotApiCache Cache { get; set; }
        public StaticApi(RiotApiCache _cache)
        {
            Cache = _cache;
        }
        public StaticApi()//only for test project
        {

        }
        public Champions GetChampions(region region, language lang, champData? chamData = null)
        {
            RiotApiCaller<Champions> caller = new RiotApiCaller<Champions>(suffix.champions);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public ChampionData GetChampion(long championId, region region, language lang, champData? chamData = null)
        {
            RiotApiCaller<ChampionData> caller = new RiotApiCaller<ChampionData>(suffix.championsById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, championId);
            if (chamData != null)
                caller.AddParam(param.champData, chamData.Value);
            else
                caller.AddParam(param.champData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public Items GetItems(region region, language lang, itemListData? itemListData = null)
        {
            RiotApiCaller<Items> caller = new RiotApiCaller<Items>(suffix.items);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (itemListData != null)
                caller.AddParam(param.itemListData, itemListData.Value);
            else
                caller.AddParam(param.itemListData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public ItemData GetItem(long itemId, region region, language lang, itemListData? itemData = null)
        {
            RiotApiCaller<ItemData> caller = new RiotApiCaller<ItemData>(suffix.item);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, itemId);
            if (itemData != null)
                caller.AddParam(param.itemData, itemData.Value);
            else
                caller.AddParam(param.itemData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public LanguageStrings GetLanguageStrings(region region, language lang)
        {
            RiotApiCaller<LanguageStrings> caller = new RiotApiCaller<LanguageStrings>(suffix.languageStrings);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public List<language> GetLanguages(region region)
        {
            RiotApiCaller<List<language>> caller = new RiotApiCaller<List<language>>(suffix.languages);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }


        public MapData GetMaps(region region, language lang)
        {
            RiotApiCaller<MapData> caller = new RiotApiCaller<MapData>(suffix.map);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public MasteryData GetMasteries(region region, language lang, masteryListData? masteryData = null)
        {
            RiotApiCaller<MasteryData> caller = new RiotApiCaller<MasteryData>(suffix.mastery);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (masteryData != null)
                caller.AddParam(param.masteryListData, masteryData);
            else
                caller.AddParam(param.masteryListData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public Mastery GetMastery(int masteryId, region region, language lang, masteryListData? masteryData = null)
        {
            RiotApiCaller<Mastery> caller = new RiotApiCaller<Mastery>(suffix.masteryById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, masteryId);
            if (masteryData != null)
                caller.AddParam(param.masteryData, masteryData);
            else
                caller.AddParam(param.masteryData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public Realm GetRealm(region region)
        {
            RiotApiCaller<Realm> caller = new RiotApiCaller<Realm>(suffix.realm);
            caller.AddParam(param.region, region);

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public RuneList GetRunes(region region, language lang, runeListData runeData = runeListData.basic)
        {
            RiotApiCaller<RuneList> caller = new RiotApiCaller<RuneList>(suffix.runes);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.runeListData, runeData);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public RuneData GetRune(long runeId, region region, language lang, runeListData runeData = runeListData.basic)
        {
            RiotApiCaller<RuneData> caller = new RiotApiCaller<RuneData>(suffix.runeById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, runeId);
            caller.AddParam(param.runeData, runeData);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }

        public SummonerSpellList GetSummonerSpells(region region, language lang, spellData? spellData = null)
        {
            RiotApiCaller<SummonerSpellList> caller = new RiotApiCaller<SummonerSpellList>(suffix.summonerSpells);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            if (spellData != null)
                caller.AddParam(param.spellData, spellData);
            else
                caller.AddParam(param.spellData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public SummonerSpellData GetSummonerSpell(long summonerSpellId,region region, language lang, spellData? spellData = null)
        {
            RiotApiCaller<SummonerSpellData> caller = new RiotApiCaller<SummonerSpellData>(suffix.summonerSpellById);
            caller.AddParam(param.region, region);
            caller.AddParam(param.locale, lang);
            caller.AddParam(param.id, summonerSpellId);
            if (spellData != null)
                caller.AddParam(param.spellData, spellData);
            else
                caller.AddParam(param.spellData, "");//important for basic information

            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
        public List<string> GetVersions(region region)
        {
            RiotApiCaller<List<string>> caller = new RiotApiCaller<List<string>>(suffix.versionList);
            caller.AddParam(param.region, region);
            caller.CreateRequest();
            return caller.Result.FirstOrDefault();
        }
    }
}