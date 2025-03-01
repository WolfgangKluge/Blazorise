﻿#region Using directives
using Blazorise.Utilities;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise;

/// <summary>
/// Container for multiple <see cref="Field"/> component that needs to be placed in a flexbox grid row.
/// </summary>
public partial class Fields : BaseComponent
{
    #region Members

    private string label;

    private string help;

    private IFluentColumn columnSize;

    #endregion

    #region Methods

    /// <inheritdoc/>
    protected override void BuildClasses( ClassBuilder builder )
    {
        builder.Append( ClassProvider.Fields() );

        if ( ColumnSize != null )
        {
            builder.Append( ClassProvider.FieldsColumn() );
            builder.Append( ColumnSize.Class( ClassProvider ) );
        }

        base.BuildClasses( builder );
    }

    #endregion

    #region Properties

    /// <summary>
    /// Sets the field label.
    /// </summary>
    [Parameter]
    public string Label
    {
        get => label;
        set
        {
            label = value;

            DirtyClasses();
        }
    }

    /// <summary>
    /// Sets the field help-text positioned bellow the field.
    /// </summary>
    [Parameter]
    public string Help
    {
        get => help;
        set
        {
            help = value;

            DirtyClasses();
        }
    }

    /// <summary>
    /// Determines how much space will be used by the field inside of the grid row.
    /// </summary>
    [Parameter]
    public IFluentColumn ColumnSize
    {
        get => columnSize;
        set
        {
            columnSize = value;

            DirtyClasses();
        }
    }

    /// <summary>
    /// Gets or sets the reference to the parent <see cref="Fields"/> component.
    /// </summary>
    [Parameter] public RenderFragment ChildContent { get; set; }

    #endregion
}