﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotCaller.Classes.Summoner;
using RiotCaller.Classes.Team;
using RiotCaller.Enums;
using System.Collections.Generic;

namespace RiotCaller.Tests
{
    [TestClass]
    public class ApiUrlTest
    {
        [TestMethod]
        public void summonerByname()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerByname);
            u.AddParam(paramType.summonerNames, new List<string>() { "Kesintisiz","MustyMax" });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);

            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void summonersummonerIds()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.summonerIds);
            u.AddParam(paramType.summonerIds, new List<long>() { 466244, 311699 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void leagueTeamIds()
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamIds);
            u.AddParam(paramType.summonerIds, new List<long>() { 466244 });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }
        [TestMethod]
        public void leagueTeamByIds()
        {
            ApiUrl<List<Team>> u = new ApiUrl<List<Team>>(suffix.teamByIds);
            u.AddParam(paramType.teamIds, new List<string>() { "TEAM-6e7878e0-31a6-11e6-b7db-d4ae527241a0" });
            u.AddParam(paramType.region, region.tr);
            u.CreateRequest(apikey.Key);
            Assert.IsTrue(u.DataResult.Count > 0);
        }

        [TestMethod]
        public void statsRanked()
        {
            ApiUrl<Summoner> u = new ApiUrl<Summoner>(suffix.statsRanked);
            u.AddParam(paramType.summonerId, 466244);
            u.AddParam(paramType.region, region.tr);
            string result = u.Url;

            Assert.AreEqual("https://tr.api.pvp.net/api/lol/tr/v1.3/stats/by-summoner/466244/ranked", result);
        }
    }
}