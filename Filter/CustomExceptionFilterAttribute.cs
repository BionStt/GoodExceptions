using Application.Exceptions;
using Application.Exceptions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace WebUI.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode statusCode;
            ErrorDto errorMessage;

            if (context.Exception is ExceptionBase processedException)
            {
                statusCode = processedException.StatusCode;
                errorMessage = processedException.ErrorDetails;
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
                errorMessage = new ErrorDto
                {
                    Message = context.Exception.Message
                };
            }

            context.Result = new JsonResult(errorMessage);
            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.HttpContext.Response.ContentType = "application/json";
        }
    }
}
