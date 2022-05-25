#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             LabelComponents
// File Name:           SwitchControl.razor.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          05-23-2022 20:15
// Last Updated On:     05-23-2022 20:50
// *****************************************/

#endregion

namespace LabelComponents.Areas.MyFeature.Pages;

public partial class SwitchControl
{
    private bool _value;

    [Parameter]
    public bool BindValue
    {
        get => _value;
        set
        {
            if (_value == value)
            {
                return;
            }

            _value = value;
            BindValueChanged.InvokeAsync(value);
        }
    }

    [Parameter]
    public EventCallback<bool> BindValueChanged
    {
        get;
        set;
    }

    [Parameter]
    public string ID
    {
        get;
        set;
    }

    [Parameter]
    public string OffLabel
    {
        get;
        set;
    }

    [Parameter]
    public string OnLabel
    {
        get;
        set;
    }

    [Parameter]
    public string Placeholder
    {
        get;
        set;
    }
}