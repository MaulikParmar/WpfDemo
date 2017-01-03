using ListboxDemo.Entity;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace ListboxDemo
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            :base(ConnectionStringConfiguration.ConnectionString)
        {
            // Logic for database intialzer
            Database.SetInitializer<MyDbContext>(new MyDbIntilizer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Remove plural name convention
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            // First we will get types of our model
            // Then we will call entity method to generate our model

            var entityTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => !string.IsNullOrEmpty(x.Namespace))
                .Where(x => x.BaseType != null && x.BaseType == typeof(BaseEntity))
                .ToList();

            var method = typeof(DbModelBuilder).GetMethod("Entity");

            foreach (var type in entityTypes)
            {
                method.MakeGenericMethod(type)
                    .Invoke(modelBuilder, new object[] { });
            }
        }

    }


    public class MyDbIntilizer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            for (int i = 1; i <= 5; i++)
            {
                context.Set<Student>().Add(new Student() { Id = 1, FirstName = "Fname " + i, LastName = "Lname " + i });
                context.Set<Teacher>().Add(new Teacher() { Id = 1, FirstName = "Fname " + i, LastName = "Lname " + i });
            }

            base.Seed(context);
        }
    }
}
