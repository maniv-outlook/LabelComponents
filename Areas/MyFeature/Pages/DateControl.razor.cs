#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             LabelComponents
// File Name:           DateControl.razor.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          07-09-2022 15:34
// Last Updated On:     07-09-2022 15:34
// *****************************************/

#endregion

namespace LabelComponents.Areas.MyFeature.Pages;

public partial class DateControl
{
    private DateTime _value;

    /// <summary>
    /// </summary>
    [Parameter]
    public bool CreateDivTag
    {
        get;
        set;
    } = true;

    /// <summary>
    /// </summary>
    [Parameter]
    public bool CreateTooltip
    {
        get;
        set;
    } = true;

    /// <summary>
    /// </summary>
    [Parameter]
    public string CssClass
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
    public DateTime Max
    {
        get;
        set;
    } = DateTime.MaxValue;

    /// <summary>
    /// </summary>
    [Parameter]
    public DateTime Min
    {
        get;
        set;
    } = DateTime.MinValue;

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
    public bool Readonly
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public Expression<Func<string>> ValidationMessage
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public DateTime Value
    {
        get => _value;
        set
        {
            if (EqualityComparer<DateTime?>.Default.Equals(value, _value))
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
    public EventCallback<DateTime> ValueChanged
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public Expression<Func<DateTime>> ValueExpression
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public string Width
    {
        get;
        set;
    } = "30%";

    /// <summary>
    /// </summary>
    private SfDatePicker<DateTime> DateTimeBox
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    private void DTFocus(FocusEventArgs args)
    {
        DateTimeBox.ShowPopupAsync();
    }

    /// <summary>
    /// </summary>
    /// <param name="args"></param>
    private static void ToolTipOpen(TooltipEventArgs args) => args.Cancel = !args.HasText;
}