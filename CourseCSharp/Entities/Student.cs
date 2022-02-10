namespace CourseCSharp.Entities
{
    public class Student
    {
        public int Id { get; set; }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }

            Student outher = obj as Student;
            return Id.Equals(outher.Id);
        }
    }
}