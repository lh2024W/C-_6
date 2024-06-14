namespace C__6
{
    class Group
    {
        List<string?> group;
        public string? nameGroup;
        public string? descriptionGroup;
        public string? numberCourse;
        public string? studentInfo;
        public string? numberOfStudent;

        public Group() : this("ПВ312", "Программирование", "562234", "Иванов И.И.", "1")
        {
            //Console.WriteLine ("c-tor without params");
        }

        //main c-tor
        public Group(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo, string? numberOfStudent)
        {
            group = new List<string?>();

            SetNameGroup(nameGroup);
            SetDescriptionGroup(descriptionGroup);
            SetNumberCourse(numberCourse);
            SetNumberOfStudent(numberOfStudent);
            SetStudent(nameGroup, descriptionGroup, numberCourse, studentInfo, numberOfStudent);

            //Console.WriteLine("main c-tor");
        }

        public void SetStudent(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo, string? numberOfStudent)
        {
            group.Add(nameGroup);
            group.Add(descriptionGroup);
            group.Add(numberCourse);
            group.Add(studentInfo);
            group.Add(numberOfStudent);
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

        public void AddStudent(string? nameGroup, string? descriptionGroup, string? numberCourse, string? studentInfo, string? numberOfStudent)
        {
            SetStudent(nameGroup, descriptionGroup, numberCourse, studentInfo, numberOfStudent);
        }

        public void SetNumberOfStudent(string? numberOfStudent)
        {
            this.numberOfStudent = numberOfStudent;
        }

        public void ShowStudents()
        {
            foreach (var s in group)
                Console.WriteLine(s + " ");

            Console.WriteLine();
        }

        public void EditNameGroup(string? nameGroupOld, string? nameGroupNew) // не работает ИЗМЕНИТЬ НАЗВАНИЕ ГРУППЫ
        {

            //group.FindAll(nameGroupOld);// не работает

            /*foreach (var s in group)// не работает
            {
                if (s == nameGroupOld)
                {
                    s = nameGroupNew;
                }
            } */

            //group.RemoveAt(index);//работает только, если знаешь индекс
            //group.Insert(index, nameGroupNew);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Group g = new Group();
            //g.ShowStudents();

            g.AddStudent("ПВ312", "Программирование", "562234", "Федоров А.И.", "2");
            g.AddStudent("ПВ312", "Программирование", "562234", "Васильев Б.С.", "3");
            // g.ShowStudents();
            g.EditNameGroup("ПВ312", "ПВ313");
            //g.EditNameGroup(0, "ПВ313");
            g.ShowStudents();
        }
    }
}
