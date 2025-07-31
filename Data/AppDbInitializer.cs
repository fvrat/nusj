using CraftCourses.Models;

namespace CraftCourses.Data
{
    public static class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course
                        {
                            Title = "أساسيات السدو",
                            Description = "تعلمي فن السدو التقليدي ونقوشه المستلهمة من بيئة البادية.",
                            Instructor = "أم فيصل",
                            Category = "نسيج تقليدي",
                            Price = 180,
                            StartDate = DateTime.Now.AddDays(5),
                            ImageUrl = "/images/sadu.jpg"
                        },
                        new Course
                        {
                            Title = "النقش النجدي اليدوي",
                            Description = "دورة لإتقان النقوش المستخدمة في الزخارف النجدية التقليدية.",
                            Instructor = "موضي العتيبي",
                            Category = "نقش وزخرفة",
                            Price = 220,
                            StartDate = DateTime.Now.AddDays(8),
                            ImageUrl = "/images/najdi-embroidery.jpg"
                        },
                        new Course
                        {
                            Title = "زخرفة الخوص وصناعة السلال",
                            Description = "اكتشفي أسرار صناعة المنتجات اليدوية من سعف النخل.",
                            Instructor = "فاطمة الحربي",
                            Category = "خوص وسلال",
                            Price = 160,
                            StartDate = DateTime.Now.AddDays(4),
                            ImageUrl = "/images/khoos.jpg"
                        }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
