namespace Formbilderv1.Models
{
    public class FormOption
    {
        public int Id { get; set; }
        public int FormFieldId { get; set; }
        public FormField FormField { get; set; }

        public string OptionText { get; set; }
    }
}
