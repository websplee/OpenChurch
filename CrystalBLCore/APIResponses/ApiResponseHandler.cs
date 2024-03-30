using CrystalBLCore.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

public class ApiResponseHandler 
{
    private readonly RequestDelegate _next;

    public ApiResponseHandler(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        string errorMessage = null;
        var standardAPIResponse = new ApiResponse();



        // Store the original response body
        var originalBody = context.Response.Body;

        // Create a new memory stream to capture the response body
        using var memoryStream = new MemoryStream();
        context.Response.Body = memoryStream;

        // Call the next middleware in the pipeline
        await _next(context);

        // Reset the response body to the original stream
        context.Response.Body = originalBody;

        // Seek the memory stream to the beginning
        memoryStream.Seek(0, SeekOrigin.Begin);

        // Read the response body from the memory stream
        var responseBody = new StreamReader(memoryStream).ReadToEnd();

        if (context.Response.StatusCode > 299)
            standardAPIResponse = new ApiResponse(context.Response.StatusCode, null, responseBody, false);
        else
            standardAPIResponse = new ApiResponse(context.Response.StatusCode, responseBody);

        // Deserialize the response body into a standard response object
        // var standardResponse = JsonConvert.DeserializeObject<StandardResponse>(responseBody);

        context.Response.ContentLength = null;
        // Set the content type to JSON
        context.Response.ContentType = "application/json";

        // Write the standard response object to the response body
        await context.Response.WriteAsync(JsonConvert.SerializeObject(standardAPIResponse));
    }
}
