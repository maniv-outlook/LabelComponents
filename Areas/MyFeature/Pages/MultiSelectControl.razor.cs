#region Header

// /*****************************************
// Copyright:           Titan-Techs.
// Location:            Newtown, PA, USA
// Solution:            ProfSvc_AppTrack
// Project:             LabelComponents
// File Name:           MultiSelectControl.razor.cs
// Created By:          Narendra Kumaran Kadhirvelu, Jolly Joseph Paily, DonBosco Paily
// Created On:          05-23-2022 20:15
// Last Updated On:     05-23-2022 20:43
// *****************************************/

#endregion

namespace LabelComponents.Areas.MyFeature.Pages;

public partial class MultiSelectControl<TItem, TValue>
{
    private TValue _value;

    [Parameter]
    public bool CreateDivTag
    {
        get;
        set;
    }

    [Parameter]
    public bool CreateTooltip
    {
        get;
        set;
    } = true;

    [Parameter]
    public IEnumerable<TItem> DataSource
    {
        get;
        set;
    }

    [Parameter]
    public string FilterBarPlaceholder
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

    public RenderFragment ItemTemplate
    {
        get;
        set;
    }

    [Parameter]
    public string KeyField
    {
        get;
        set;
    }

    [Parameter]
    public VisualMode Mode
    {
        get;
        set;
    } = VisualMode.Box;

    [Parameter]
    public string Placeholder
    {
        get;
        set;
    }

    [Parameter]
    public Type TypeItem
    {
        get;
        set;
    }

    [Parameter]
    public Type TypeValue
    {
        get;
        set;
    }

    [Parameter]
    public bool UseCustomTemplate
    {
        get;
        set;
    }

    [Parameter]
    public Expression<Func<string>> ValidationMessage
    {
        get;
        set;
    }

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

    [Parameter]
    public EventCallback<TValue> ValueChanged
    {
        get;
        set;
    }

    [Parameter]
    public Expression<Func<TValue>> ValueExpression
    {
        get;
        set;
    }

    [Parameter]
    public string ValueField
    {
        get;
        set;
    }

    public RenderFragment ValueTemplate
    {
        get;
        set;
    }

    //[Parameter]
    //public Expression<Func<string>> ValueExpression
    //{
    //    get;
    //    set;
    //}

    [Parameter]
    public string Width
    {
        get;
        set;
    } = "100%";

    private static void ToolTipOpen(TooltipEventArgs args) => args.Cancel = !args.HasText;
}