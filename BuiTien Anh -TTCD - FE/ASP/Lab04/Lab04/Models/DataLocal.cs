namespace Lab04.Models
{
    /// <summary>
    /// Datalocal; chứa dữ liệu và các phương thức thực hiện chức năng CRUD
    /// </summary>
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People()
            {
                Id = 0, Name = "Bùi Tiến Anh", Email="buitienanh13122003@gmail.com", Phone = "0828345288", Address = "Chiêm Hóa, Tuyên Quang",
                Avatar = "Images/Avatar/02.jfif", Birthday = Convert.ToDateTime("2003/12/13"), Bio = "Sắp sắp rồi", Gender = 0
            },

            new People()
            {
                Id = 1, Name = "nguyễn Anh", Email="buitienanh13122003@gmail.com", Phone = "0828345288", Address = "Phúc Thịnh, Tuyên Quang",
                Avatar = "Images/Avatar/01.jfif", Birthday = Convert.ToDateTime("2004/09/22"), Bio = "Đang tu tiên", Gender = 1
            },

            new People()
            {
                Id = 2, Name = "Bùi Anh", Email="buitienanh13122003@gmail.com", Phone = "0828345288", Address = "Chiêm Hóa, Tuyên Quang",
                Avatar = "Images/Avatar/03.jfif", Birthday = Convert.ToDateTime("2005/08/22"), Bio = "Sắp tới", Gender = 1
            },

            new People()
            {
                Id = 3, Name = "Tiến Anh", Email="buitienanh13122003@gmail.com", Phone = "0828345288", Address = "Chiêm Hóa, Tuyên Quang",
                Avatar = "Images/Avatar/04.jfif", Birthday = Convert.ToDateTime("2006/08/21"), Bio = "Đang bế quan", Gender = 2
            },
        };

        //Getpeople: lấy danh sách dữ liệu peoples
        public static List<People> GetPeoples()
        {
            return _peoples;
        }

        //getpeopleById : Lấy đối tượng people theo id
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }
    }
}
