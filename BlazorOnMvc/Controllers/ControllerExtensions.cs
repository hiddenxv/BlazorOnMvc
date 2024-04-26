using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorOnMvc.Controllers;


/// <summary>
/// Controllerクラスの拡張機能を提供する
/// </summary>
public static class ControllerExtensions
{
    /// <summary>
    /// Razorコンポーネントを返す
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    /// <param name="controller"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static async ValueTask<IActionResult> RazorComponent<TComponent>( this Controller controller, object? parameters = null )
        where TComponent : IComponent
    {
        var cmponent = parameters is null ?
            new RazorComponentResult<TComponent>() :
            new RazorComponentResult<TComponent>( parameters );
        await cmponent.ExecuteAsync( controller.HttpContext );
        return new OkObjectResult( cmponent );
    }
}
