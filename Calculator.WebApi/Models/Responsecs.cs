namespace Calculator.WebApi.Models
{
    public class Response<T>
    {
        public bool Sucess { get; set; }
        public string? Message { get; set; }
        public T? Obj { get; set; }
    }
}
