namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

       static Repository()
{
    _courses = new List<Course>()
    {
        new Course()
        {
            Id = 1,
            Title = "C# kursu",
            Description = "Asp net core mvc dersleri ile sıfırdan ileri seviyeye kadar bir web programcının bilmesi gereken tüm konuların yer aldığı, piyasadaki en kapsamlı ve en güncel Core Mvc kursu olduğunu bilmenizi isterim.",
            Image = "1.png",
            Tags = new string[] { "Aspnet", "Web Geliştirme" },
            isActive = true,
            isHome = true
        },
        new Course()
        {
            Id = 2,
            Title = "Java Kursu",
            Description = "Bu kursta başlangıçtan ileri seviyeye kadar Java yazılım dilini ; programlama temellerini anlatarak ilerledim. Kursum sizlere hem temelden yazılıma başlamanızı hem de  nesne yönelimli programlamayı öğretecektir.Haydi hemen öğrenmeye başlayın!",
            Image = "2.png",
            Tags = new string[] { "Java", "Web Geliştirme" },
            isActive = true,
            isHome = true
        },
        new Course()
        {
            Id = 3,
            Title = "Sql ve Veri Bilimi Kursu",
            Description = "Microsoft SQL Server platformunda, gerçek hayat verileri ile sıfırdan SQL komutları anlatılmakta ve Temel DML komutları üzerinde durulmaktadır. Ayrıca, ilişkisel veritabanı kavramları, Join ve Subquery gibi komutlar, verilerin gruplama ve özet çıkarma işlemleri için kullanılanEğitim, bu kavramların gerçek veri setleri üzerinde nasıl kullanıldığını göstermektedir.",
            Image = "3.png",
            isActive = true,
            isHome = true
        },

        new Course()
        {
            Id = 4,
            Title = "Excel ile Tablo Analizi Kursu",
            Description = "Excel’de Pivot Tablolar ve Copilot yapay zeka aracı kullanarak veri analizi yapma becerilerini geliştirmeyi amaçlamaktadır. Katılımcılar, büyük veri setlerini hızlı ve etkili bir şekilde analiz etme, Pivot Tablolar ile derinlemesine raporlar oluşturma ve Copilot’un yapay zeka destekli özelliklerini kullanarak veri analiz süreçlerini hızlandırma konularında bilgi sahibi olacaklardır",
            Image = "4.png",
            isActive = true,
            isHome = true
        },
         new Course()
        {
            Id = 5,
            Title = "Swift ile Kodlama Öğrenme Kursu",
            Description = "Bu kursu, programlamaya yeni başlayan bireyleri Swift dili ile tanıştırarak, iOS geliştirme dünyasına sağlam bir adım atmalarını hedeflemektedir. Bu kurs, katılımcılara temel programlama kavramlarını öğretirken, aynı zamanda iOS uygulamaları geliştirme sürecinin temellerini anlamalarını sağlar.",
            Image = "5.png",
            isActive = true,
            isHome = true
        },
         new Course()
        {
             Id = 6,
            Title = "Android ile Kodlama Öğrenme Kursu",
            Description = "Bu kurs ile Android platformunda uygulama geliştirmeyi sıfırdan öğrenin. Temel Java/Kotlin bilgisiyle başlayarak, arayüz tasarımı, veri yönetimi ve Google Play mağazasına uygulama yayımlama süreçlerini adım adım keşfedeceksiniz.",
            Image = "6.jpg",
            isActive = true,
            isHome = true
        }
    };
}


        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course GetById(int id)
         {
            return _courses.FirstOrDefault(c => c.Id == id);
         }
    }
}