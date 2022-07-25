public class UsersAPI
{
    public UsersAPI(ref WebApplication app)
    {
        app.MapGet("api/users",()=>{
            return new User{
                FirstName = "Teddy",
                LastName = "Roumanos"
            };
        });
    }
}