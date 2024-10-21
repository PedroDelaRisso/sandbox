using System.ComponentModel.DataAnnotations;

namespace GesFin.Api.Models.Request;

public class Request<T>(T data)
{
    public required T Data { get; set; } = data;
}