namespace CrystalBLCore.APIResponses
{
    public class StandardResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        
        public string ErrorMessage { get; set; }
    }
}
