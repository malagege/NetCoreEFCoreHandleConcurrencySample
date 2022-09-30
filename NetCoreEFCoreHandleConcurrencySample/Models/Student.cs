using System.ComponentModel.DataAnnotations;

namespace NetCoreEFCoreHandleConcurrencySample.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [ConcurrencyCheck]
        public string? StudentName { get; set; }
    }
}
