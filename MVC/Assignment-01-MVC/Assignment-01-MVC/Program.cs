using System.Net;

namespace Assignment_01_MVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        app.UseRouting();

        // app.Use(async (context, next) =>
        // {
        //     Endpoint endpoint = context.GetEndpoint();
        //     if(endpoint is null)
        //         await context.Response.WriteAsync("Your Requested Page Not Found");
        //     await next();
        // });
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/Home", async context =>
            {
                await context.Response.WriteAsync("You are at Home Page");
            });
            // endpoints.MapGet("/Products", async context =>
            // {
            //     await context.Response.WriteAsync("You are at Products Page");
            // });
            endpoints.MapGet("/Products/{id:int?}", async context =>
            {
                var IdData = context.Request.RouteValues["id"];
                if (IdData is not null)
                {
                    int id = Convert.ToInt32(IdData);
                    await context.Response.WriteAsync($"Your Request Product With Id => {id}");
                }
                else
                {
                    await context.Response.WriteAsync("You are at Products Page");
                }
            });
            endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(6)}", async context =>
            {
                int id = Convert.ToInt32(context.Request.RouteValues["id"]);
                string author = context.Request.RouteValues["author"].ToString();
                await context.Response.WriteAsync($"Your Request Book With Id => {id} and Author => {author}");
            });
        });
        app.Run(async (HttpContext) =>
        {
            await HttpContext.Response.WriteAsync("Your Requested Page Not Found");
        });
        app.Run();
    }
}