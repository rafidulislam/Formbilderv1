using Microsoft.AspNetCore.Http.Features;

namespace Formbilderv1.Models
{
    public class FormField
    {
        public int Id { get; set; }
        public int FormModelId { get; set; }
        public FormModel? FormModel { get; set; }

        public string Label { get; set; }
        public string FieldType { get; set; }  // "text", "multiple"
        public bool IsRequired { get; set; }

        public List<FormOption> Options { get; set; } = new();
    }
}
