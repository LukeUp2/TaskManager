using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TaskManager.Communication.Errors;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is TaskManagerException)
            {
                HandleProjectException(context);
            }
            else
            {
                HandleUnexpectedException(context);
            }
        }


        private static void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException errorOnValidationException)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new BadRequestObjectResult(new ErrorResponseJson(errorOnValidationException.Errors));
            }
            else if (context.Exception is NotFoundException notFoundException)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                context.Result = new NotFoundObjectResult(new ErrorResponseJson([notFoundException.Error]));
            }
        }
        private static void HandleUnexpectedException(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new ObjectResult(new ErrorResponseJson(["An unexpected error occurred. Please try again later."]));
        }
    }
}