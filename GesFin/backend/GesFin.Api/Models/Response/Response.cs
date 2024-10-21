using System.Net;

namespace GesFin.Api.Models.Response;

public class Response<T>(T? data)
{
    public HttpStatusCode Code { get; set; }

    public T? Data { get; set; } = data;
}