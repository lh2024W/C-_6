namespace C__6
{
    class Group
    {
        List<string?> students;
        public string? nameGroup;
        public string? descriptionGroup;
        public string? numberCourse;
        public string? studentInfo;
        public static Int32 count = 0;

        public Group(): this ("ПВ312", "Программирование", "562234", "Иванов И.И.") 
        {
            //Console.WriteLine ("c-tor without params");
        }

        //main c-tor
        public Group(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo) 
        {
            students = new List<string?> ();
            
            SetNameGroup(nameGroup);
            SetDescriptionGroup(descriptionGroup);
            SetNumberCourse(numberCourse);
            SetStudent(nameGroup, descriptionGroup, numberCourse, studentInfo);

            //Console.WriteLine("main c-tor");
        }
                
        public void SetStudent(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo)
        {
            students.Add(nameGroup);
            students.Add(descriptionGroup);
            students.Add(numberCourse);
            students.Add(studentInfo);
        }
                
        public void SetNameGroup(string? nameGroup)
        {
            this.nameGroup = nameGroup;
        }

        public void SetDescriptionGroup(string? descriptionGroup)
        {
            this.descriptionGroup = descriptionGroup;
        }

        public void SetNumberCourse(string? numberCourse)
        {
            this.numberCourse = numberCourse;
        }

        public void AddStudent(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo)
        {
            SetStudent(nameGroup, descriptionGroup, numberCourse, studentInfo);
        }

        public void ShowStudents() 
        {
            foreach (var s in students)
            {
                Console.Write(s + " " + "\n");// переделать
                
            }
           Console.WriteLine();
        }

        public void EditGroupInStudent(string? nameGroup, string? descriptionGroup)
        {
            //students.
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group();
            //g.ShowStudents();
            
            g.AddStudent("ПВ312", "Программирование", "562234", "Федоров А.И.");
            g.ShowStudents();
            
        }
    }
}
