using Syncfusion.Blazor.Data;

namespace LabelComponents.Areas.MyFeature.Pages;

public partial class ComboBoxControl<TValue, TItem>
{
    private TValue _value;

    private SfComboBox<TValue, TItem> Combo;

    [Parameter]
    public bool AllowFilter
    {
        get;
        set;
    }

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
    public EventCallback<ChangeEventArgs<TValue, TItem>> ComboValueChange
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

    [Parameter]
    public Query Query
    {
        get;
        set;
    }

    [Parameter]
    public bool ShowClearButton
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

    public void Refresh()
    {
        Combo.RefreshDataAsync();
    }
}
