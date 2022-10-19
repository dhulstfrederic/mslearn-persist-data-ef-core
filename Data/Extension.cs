namespace ContosoPizza.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<PizzaContext>();
                // ne marche pas et ne passe pas dans le if
            //    if (context.Database.EnsureCreated()) 
              //  {
                    DbInitializer.Initialize(context);
               // }
            }
        }
    }
}