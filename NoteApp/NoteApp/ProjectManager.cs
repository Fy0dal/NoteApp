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
    /// Класс "Менеджер Проекта", отвечающий за загрузку 
    /// и выгрузку данных из файла
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Константа, указывающая путь к файлу
        /// </summary>
        private static readonly string FolderPath = Environment.GetFolderPath
        (Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\";

        /// <summary>
        /// Константа, указывающая имя файла
        /// </summary>
        private static readonly string FileName = "Json.txt";

        /// <summary>
        /// Метод сохранения данных в файл
        /// </summary>
        /// <param name="notes"></param>
        public static void SaveToFile(Project notes)
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(FolderPath + FileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать
                serializer.Serialize(writer, notes);
            }
        }

        /// <summary>
        /// Метод загрузки данных из файла
        /// </summary>
        /// <returns></returns>
        public static Project LoadFromFile()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            if (!File.Exists(FileName))
            {
                return new Project();
            }
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                //Открываем поток для чтения из файла с указанием пути
                using (StreamReader sr = new StreamReader(FolderPath + FileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                    return (Project)serializer.Deserialize<Project>(reader);
                }
            }
            catch
            {
                return new Project();
            }
        }
    }
}
