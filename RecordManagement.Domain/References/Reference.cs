using System.ComponentModel.DataAnnotations;

namespace RecordManagement.Domain.References;
    public class Reference
    {
        [Key]
         public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Name { get; }
        public string ContactInformation { get; }

        public Reference(string name, string contactInformation)
        {
            Name = name;
            ContactInformation = contactInformation;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    private Reference() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}