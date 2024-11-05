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
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(tasting, options);
            File.WriteAllText(FilePath, json);
        }

        public static Tasting LoadTastingFromJson()
        {
            if (File.Exists(FilePath))
            {
                throw new FileNotFoundException(FilePath);
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<Tasting>(json);
        }
    }
}
