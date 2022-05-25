#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             LabelComponents
// File Name:           DropDownControl.razor.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          05-23-2022 20:15
// Last Updated On:     05-23-2022 20:24
// *****************************************/

#endregion

namespace LabelComponents.Areas.MyFeature.Pages;

/// <summary>
/// </summary>
/// <typeparam name="TValue"></typeparam>
/// <typeparam name="TItem"></typeparam>
public partial class DropDownControl<TValue, TItem>
{
    private TValue _value;

    /// <summary>
    /// </summary>
    [Parameter]
    public bool CreateDivTag
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public IEnumerable<TItem> DataSource
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public EventCallback<ChangeEventArgs<TValue, TItem>> DropDownValueChange
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public string ID
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public string Placeholder
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public string TextField
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public TValue Value
    {
        get => _value;
        set
        {
            if (EqualityComparer<TValue>.Default.Equals(value, _value))
            {
                return;
            }

            _value = value;
            ValueChanged.InvokeAsync(value);
        }
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public EventCallback<TValue> ValueChanged
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public Expression<Func<TValue>> ValueExpression
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public string ValueField
    {
        get;
        set;
    }

    [Parameter]
    public string Width
    {
        get;
        set;
    } = "98%";
}