using BigStar.Models.Data;

namespace BigStar.Data
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScrope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScrope.ServiceProvider.GetService<ApplicationContext>();

                context.Database.EnsureCreated();

                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>() { 
                        new MovieModel(){
                            Title = "Kill Boksoon",
                            ImageUrl = "Images/Kill_Boksoon.jpg"
                        },
                        new MovieModel(){
                            Title = "Thanh Sói",
                            ImageUrl = "Images/Thanh_Soi.jpg"
                        },
                        new MovieModel(){
                            Title = "Tri kỷ",
                            ImageUrl = "Images/Tri_Ky.jpg"
                        },
                        new MovieModel(){
                            Title = "Siêu lừa gặp siêu lầy",
                            ImageUrl = "Images/SLGSL.jpg"
                        },
                        new MovieModel(){
                            Title = "Murder Mystery 2",
                            ImageUrl = "Images/Murder_Mystery_2.jpg"
                        },
                        new MovieModel(){
                            Title = "Đảo Tội Ác",
                            ImageUrl = "Images/Dao_Toi_Ac.jpg"
                        },
                        new MovieModel(){
                            Title = "Avatar: Dòng chảy của nước",
                            ImageUrl = "Images/Avatar.jpg"
                        },
                        new MovieModel(){
                            Title = "Perfect Addiction",
                            ImageUrl = "Images/Perfect_Addiction.jpg"
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
