﻿namespace RiotCaller.Enums
{
    /// <summary>
    /// api url's parameters do not change type names!
    /////// ONLY '{variables}' name here !!!
    /// </summary>
    public enum param
    {
        /// <summary> Example Value => new List<string>() { summonerName1, summonerName2 } </summary>
        summonerNames,

        /// <summary> Example Value => new List<long>() { summonerId1, summonerId2 } </summary>
        summonerIds,

        /// <summary>
        /// Example Value =&gt; "variable type is int OR type of RegionEnum } 
        /// </summary>
        region,

        /// <summary>
        /// Example Value =&gt; variable type is long } 
        /// </summary>
        summonerId,

        /// <summary> Example Value => new List<string>() {
        /// "TEAM-6e7878e0-31a6-11e6-b7db-d4ae527241a0", } </summary>
        teamIds,

        season,

        seasons,

        championIds,

        rankedQueues,

        beginTime,

        endTime,

        beginIndex,

        endIndex
    }
}