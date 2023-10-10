using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EFCoretutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CriarEntidades();
            ListarEstadoUnchangedEntidades();
            listarEstadoAddedEntidadde();
        }

        private static void listarEstadoAddedEntidadde()
        {
            using (var context = new SchoolContext())
            {
                context.Students.Add(new Student() { FirstName = "Bill", LastName = "Gates" });

                DisplayStates(context.ChangeTracker.Entries());
            }
        }

        private static void CriarEntidades()
        {
            using (SchoolContext context = new SchoolContext())
            {

                context.Database.EnsureCreated();

                var grade01 = new Grade() { GradeName = "curso c# .Net" };
                var student01 = new Student() { FirstName = "Joao", LastName = "Magalhaes", Grade = grade01 };

                context.Students.Add(student01);
                context.SaveChanges();

                foreach (var std in context.Students)
                {

                    Console.WriteLine(std.FirstName + " " + std.LastName);

                }
            }
        }

        private static void ListarEstadoUnchangedEntidades()
        {
            using (var context = new SchoolContext())
            {
                // retrieve entity 
                var student = context.Students.FirstOrDefault();
                DisplayStates(context.ChangeTracker.Entries());
            }
        }



        static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}," +
                    $" State: { entry.State.ToString()}");
            }
        }



        

    }
    
}