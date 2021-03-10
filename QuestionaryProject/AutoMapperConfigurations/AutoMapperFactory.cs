using AutoMapper;

namespace QuestionaryProject.AutoMapperConfigurations
{
    public class AutoMapperFactory
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<QuestionsProfile>();
            }).CreateMapper();
        }
    }
}
