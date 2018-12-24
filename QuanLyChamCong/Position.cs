namespace QuanLyChamCong
{
    class Position
    {
        public Position() { }
        public Position(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }

        string name { get; set; }
        float salary { get; set; }

        public string getName()
        {
            return this.name;
        }
        public float getSalary()
        {
            return this.salary;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
    }
}
