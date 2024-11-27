using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using WineTastingApp.Models;

namespace WineTastingApp.Services
{
    public static class DataService
    {
        private static readonly string FilePath = "tastingData.json";

        public static void SaveTastingToJson(Tasting tasting)
        {
            string json = JsonSerializer.Serialize(tasting);

            // Get the path to the user's Documents folder
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Combine the documents path with the desired file name
            string filePath = Path.Combine(documentsPath, "tastingData.json");

            File.WriteAllText(filePath, json);
        }
        public static Tasting LoadTastingFromJson()
        {
            if (!File.Exists(FilePath))
            {
                throw new FileNotFoundException(FilePath);
            }

            string json = File.ReadAllText(FilePath);
            Tasting? tasting = JsonSerializer.Deserialize<Tasting>(json);

            if (tasting == null)
            {
                throw new InvalidOperationException("Deserialization resulted in a null object.");
            }

            return tasting;
        }

    }
}
