using AutoMapper;
namespace AutoMappers
{
public class OldUser
{
    public float wiek { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
}
public class Users
{
    public int wiek { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
}
    class Program
    {

        static void Main(string[] args)
        {
            OldUser personModel = new OldUser
            {
                wiek = 50.5f,
                FirstName = "Anna",
                Surname = "Nowak",
            };

            var config = new MapperConfiguration(cfg =>

            cfg.CreateMap<OldUser, Users>()
            //cfg.CreateMap<OldUser, Users>().ForMember(x => x.a, s => s.MapFrom(d => d.Surname))
            //cfg.CreateMap<OldUser,Users>().ForMember(x=>x.FirstName,s=>s.Ignore())

            );
            config.AssertConfigurationIsValid();
            var user = config.CreateMapper();
            Users test = user.Map<OldUser, Users>(personModel);          
            

        }
    }
}
