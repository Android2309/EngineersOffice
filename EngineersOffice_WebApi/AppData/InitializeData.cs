using EngineersOffice_WebApi.ContextFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace EngineersOffice_WebApi.AppData
{
    //первоначальная инициализация данных в БД
    public static class InitializeData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DataContext>>()))
            {
                // Проверка наличия данных таблицы SteelGradeGuide
                if (!context.SteelGrade_Guide.Any())
                {
                    AddDataFromScript(context, @"AppData\dbo.SteelGrade_Guide.data.sql");
                }

                // Проверка наличия данных таблицы Beam_gost26020_83
                if (!context.Beam_Guide.Any())
                {
                    AddDataFromScript(context, @"AppData\dbo.Beam_Guide.data.sql");
                }

                // Проверка наличия данных таблицы BendingCoefficient
                if (!context.BendingCoefficient_Guide.Any())
                {
                    AddDataFromScript(context, @"AppData\dbo.BendingCoefficient_Guide.data.sql");
                }
            }
        }

        //добавление данных в бд из файла sql скрипта
        public static void AddDataFromScript(DbContext context, string scriptPath)
        {
            FileInfo scriptFile = new FileInfo(scriptPath);
            string sqlScript = scriptFile.OpenText().ReadToEnd();
            context.Database.ExecuteSqlRaw(sqlScript);
        }
    }
}
