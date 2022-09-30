using System.ComponentModel.DataAnnotations;

namespace NetCoreEFCoreHandleConcurrencySample.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string? StudentName { get; set; }

        public int StudentAge { get; set; }

        //[ConcurrencyCheck]
        //public int RowVersion { get; set; }

        [Timestamp]
        public byte[]? RowVersionTs { get; set; }
    }
}
