using Microsoft.AspNetCore.Components;

namespace BlazorOnMvc.ViewModels.Shared;

public class RazorPageBaseViewModel<TComponent> : IRazorPageBaseViewModel where TComponent : IComponent
{
    public RazorPageBaseViewModel( object model = null)
    {
        this.ModelParameter = model;            
    }

    public Type Type => typeof( TComponent );

    public object? ModelParameter { get; init; }
}
