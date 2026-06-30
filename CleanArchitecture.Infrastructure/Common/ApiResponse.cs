namespace CleanArchitecture.Infrastructure.Common
{
    public class ApiResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public T? Data { get; set; }
        public int StatusCode { get; set; }
        public string? Raw { get; set; }
    }
}
