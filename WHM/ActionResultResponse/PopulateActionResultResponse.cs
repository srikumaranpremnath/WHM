using ApplicationLayer.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WHM.ActionResultResponse
{
    public static class ActionResultResponse
    {
        public static IActionResult PopulateResult<T>(this ControllerBase controller, IBaseResponse<T> response) where T : class
        {
            if (response.Result != null)
                return controller.Ok(response.Result);
            else if (response.Errors.FirstOrDefault() == null)
                return controller.NoContent();
            else
                return (response.Errors.FirstOrDefault()?.StatusCode) switch
                {

                    HttpStatusCode.NotFound => controller.NotFound(response.Errors),
                    HttpStatusCode.Conflict => controller.Conflict(response.Errors),
                    _ => controller.BadRequest(response.Errors),
                };
        }
    }
}
