namespace Formbilderv1.Models
{
    public class FormModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<FormField> Fields { get; set; } = new();
    }
}
