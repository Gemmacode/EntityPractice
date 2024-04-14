namespace EntityPractice.Models
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

    }
}
