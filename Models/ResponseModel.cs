using DocumentationModels.Base;

namespace DocumentationModels
{
    public class ResponseModel<T> : BaseModel
    {
        public T Model { get; set; }
    }
}
