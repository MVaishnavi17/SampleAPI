namespace StudentAPI.Model
{
    public class StudentRepository
    {
        public static List<StudentModel> Student
        {
            get; set;
        } = new List<StudentModel>()
        {
             new StudentModel
                {
                    Id = 1,
                    Name = "Vaishnavi",
                    Email = "vaishnavi@gmail.com",
                    Address = "Theni"

                },

                 new StudentModel
                {
                    Id = 2,
                    Name = "Sindhu",
                    Email = "sindhu@gmail.com",
                    Address = "Madurai"

                }
        };
    }
}
