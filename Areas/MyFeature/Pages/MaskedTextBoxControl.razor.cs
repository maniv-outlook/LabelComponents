#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             LabelComponents
// File Name:           MaskedTextBoxControl.razor.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          05-23-2022 20:15
// Last Updated On:     05-23-2022 20:43
// *****************************************/

#endregion

namespace LabelComponents.Areas.MyFeature.Pages;

/// <summary>
/// </summary>
public partial class MaskedTextBoxControl
{
    private string _value;

    [Parameter]
    public bool CreateDivTag
    {
        get;
        set;
    }

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
    } = "maskedControl";

    /// <summary>
    /// </summary>
    [Parameter]
    public string Mask
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
    public string Value
    {
        get => _value;
        set
        {
            if (EqualityComparer<string>.Default.Equals(value, _value))
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
    public EventCallback<string> ValueChanged
    {
        get;
        set;
    }

    /// <summary>
    /// </summary>
    [Parameter]
    public Expression<Func<string>> ValueExpression
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
    } = "100%";

    private static void ToolTipOpen(TooltipEventArgs args) => args.Cancel = !args.HasText;
}