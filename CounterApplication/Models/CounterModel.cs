using System.ComponentModel.DataAnnotations;


namespace CounterApplication
{
    public class CounterModel
    {
        [Key]
        public int Id { get; set; }
        public int Counter { get; set; }
    }
}