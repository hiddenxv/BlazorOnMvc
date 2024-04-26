namespace BlazorOnMvc.ViewModels.Shared;

public interface IRazorPageBaseViewModel
{
    Type Type { get; }

    object? ModelParameter { get; }
}
