using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сохранение и загрузка
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Открываем поток для записи в файл с указанием пути. Вызываем сериализацию и передаем объект, который хотим сериализовать.
        /// <summary>
        public static void SaveToFile(Project data, string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
           
            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
              
                serializer.Serialize(writer, data);
            }
        }
        /// <summary>
        /// Открываем поток для чтения из файла с указанием пути. Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>

        public static Project LoadFromFile(string filename)
        {
            JsonSerializer serializer = new JsonSerializer();
           
            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                
                return (Project)serializer.Deserialize<Project>(reader);
            }
        }
    }
}
