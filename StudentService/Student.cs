namespace StudentService
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        private int _age;
        public string Address { get; init; }
        public Gender Gender { get; init; }
        public int Age
        {
            set
            {
                if(value >= 6 && value <= 21)
                    _age = value;
            }
            get
            {
                return _age;
            }
        }

        public override string ToString()
            => $"Id = {Id} \t Name= {Name} \t Age = {_age} \t Address = {Address} \t Gender = {Gender}";
    }
}
