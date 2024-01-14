using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace CustomerWebApi
{
    public class CustomerDBContext : DbContext
    {


        public CustomerDBContext(DbContextOptions<CustomerDBContext> dbContextOptions ): base(dbContextOptions)
        {
            try
            {

                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if( databaseCreator!=null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();

                    if (!databaseCreator.HasTables()) databaseCreator.CreateTables();

                }

            }
            catch(Exception ex ) 
            {
                Console.WriteLine(ex.Message.ToString());
            }



        }



    }
}
