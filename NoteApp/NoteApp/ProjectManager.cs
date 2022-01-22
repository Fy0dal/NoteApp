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
    /// Класс менеджера проекта
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Путь по умолчанию,куда сохраняется файл
        /// </summary>
        public static string PathFile()
        {
            var filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return filepath + @"\NoteApp\NoteApp.json";
        }

        /// <summary>
        /// Путь по умолчанию,по которому создается папка для файла
        /// </summary>
        public static string PathDirectory()
        {
            var filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return filepath + @"\NoteApp\";
        }

        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="data">Данные для сериализации</param>
        /// <param name="filepath">Путь к файлу</param>
        public static void SaveToFile(Project project, string filepath)
        {
            var directoryFile = Path.GetDirectoryName(filepath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryFile);
            if (!Directory.Exists(directoryFile))
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            }
        }

        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="filepath">Путь к файлу</param>
        /// <returns></returns>
        public static Project LoadFromFile(string filepath)
        {
            Project project;
            if (!File.Exists(filepath))
            {
                return new Project();
            }
            var serializer = new JsonSerializer();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                using (JsonReader reader = new JsonTextReader(sr))
                    project = serializer.Deserialize<Project>(reader);
            }
            catch
            {
                return new Project();
            }
            return project;
        }
    }
}
