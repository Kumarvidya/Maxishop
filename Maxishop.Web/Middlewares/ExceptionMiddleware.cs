﻿using Maxishop.Application.Exceptions;
using Maxishop.Web.Models;
using System.Net;
using System.Threading.Tasks;

namespace Maxishop.Web.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next) { 
        _next=next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            { 
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
 private async Task HandleExceptionAsync(HttpContext httpContext,Exception ex)
        {
            HttpStatusCode statusCode=HttpStatusCode.InternalServerError;
            CustomProblemDetails problem = new();

            switch (ex)
            {
                case BadRequestException BadRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    problem = new CustomProblemDetails();
                    problem = new CustomProblemDetails()
                    {
                        Title = BadRequestException.Message,
                        Status = (int)statusCode,
                        Type = nameof(BadRequestException),
                        Detail = BadRequestException.InnerException?.Message,
                        Errors = BadRequestException.ValidationsErrors

                    };
                    break;
            }
            httpContext.Response.StatusCode=(int)statusCode;
            await httpContext.Response.WriteAsJsonAsync(problem);   

        }
    }

    
}
