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
            else
            {
                switch (response.Errors.FirstOrDefault()?.StatusCode)
                {
                    case HttpStatusCode.NotFound: return controller.NotFound(response.Errors);
                    case HttpStatusCode.Conflict: return controller.Conflict(response.Errors);
                    default: return controller.BadRequest(response.Errors);
                }
            }

        }
    }
}
