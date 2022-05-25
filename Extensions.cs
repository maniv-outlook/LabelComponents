#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             ProfSvc_AppTrack
// File Name:           Extensions.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          01-26-2022 19:30
// Last Updated On:     02-12-2022 19:38
// *****************************************/

#endregion

namespace LabelComponents;

public static partial class Extensions
{

    /// <summary>
    ///     Checks if the string is null or blank.
    /// </summary>
    /// <param name="s"> String </param>
    /// <returns> Boolean </returns>
    public static bool NullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);

    /// <summary>
    ///     Checks if the object is null or blank.
    /// </summary>
    /// <param name="o"> Object </param>
    /// <returns> Boolean </returns>
    public static bool NullOrWhiteSpace(this object o) => o == null || o.ToString().NullOrWhiteSpace();
}