using System;

namespace ListboxDemo.Entity
{
    public class Student : BaseEntity
    {
        public Student()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RollNo { get; set; }
        
    }
    
    public class Teacher : BaseEntity
    {
        public Teacher()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
