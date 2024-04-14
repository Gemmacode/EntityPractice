namespace EntityPractice.Models
{
    public class Student
    {        
        public Guid StudentId { get; set;}  
        public string StudentName { get; set;}
        public string StudentEmail { get; set;}
        public string StudentPhone { get; set; }  
        public Guid? DepartmentId { get; set;}
        public virtual Department? Department { get; set;}
    }
}
