namespace Solid_I
    {
    public class SaleService : IBasicActions<Sale>, IEditableActions<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Create the User");
        }
        public Sale Get(int Id)
        {
            Console.WriteLine("Get the User");
            return new Sale();
        }
        public List<Sale> GetList()
        {
            return new List<Sale>();
        }
        //<- By inheriting from an Interface, we have the obligation to comply with each part of the contract.
        //For this we should make an arrangement that is not the most appropriate

        public void Update(Sale entity)
        {
          throw new NotImplementedException();
        }
        public void Delete(Sale entity)
        {
            throw new NotImplementedException();
        }
    }

    //<- The principle of Interface Segregation pushes us to make cuts in our interface,
    //to make interfaces smaller and more manageable.

    public class UserService : IBasicActions<User>, IEditableActions<User>
    {
        public void Add(User entity)
        {
            Console.WriteLine("Create the User");
        }
        public void Update(User entity)
        {
            Console.WriteLine("Update the User");
        }
        public void Delete(User entity)
        {
            Console.WriteLine("Delete the User");
        }
        public User Get(int Id)
        {
            Console.WriteLine("Get the User");
            return new User();
        }

        //public class UserService : ICrud<User>
        //{
        //    public void Add(User entity) 
        //    {
        //        Console.WriteLine("Create the User");
        //    }
        //    public void Update(User entity)
        //    {
        //        Console.WriteLine("Update the User");
        //    }
        //    public void Delete(User entity)
        //    {
        //        Console.WriteLine("Delete the User");
        //    }
        //    public User Get(int Id)
        //    {
        //        Console.WriteLine("Get the User");
        //        return new User();
        //    }

        public List<User> GetList()
        {
            return new List<User>();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Sale
    {
        public decimal Amount { get; set; } 
        public DateTime Date { get; set; }
    }

    public interface IBasicActions<T>
    {
        public T Get(int id);
        public List<T> GetList();
        public void Add(T entity);
    }

    public interface IEditableActions<T>
    {
        public void Update(T entity);
        public void Delete(T entity);
    }

    //public interface ICrud<T>
    //{ 
    //    public T Get(int id);
    //    public List<T> GetList();
    //    public void Add(T entity);
    //    public void Update(T entity);
    //    public void Delete(T entity);
    //}


}