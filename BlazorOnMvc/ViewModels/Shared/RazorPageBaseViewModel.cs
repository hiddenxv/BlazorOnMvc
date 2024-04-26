using Microsoft.AspNetCore.Components;

namespace BlazorOnMvc.ViewModels.Shared;

public class RazorPageBaseViewModel<TComponent> : IRazorPageBaseViewModel where TComponent : IComponent
{
    public Type Type => typeof( TComponent );
}
