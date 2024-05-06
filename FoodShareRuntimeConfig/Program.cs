using System;
using System.IO;
using System.Text.Json;

public class Program
{
	public Program()
	{
        // Membaca konfigurasi dari file JSON
        string jsonConfig = File.ReadAllText("FoodShareConfig.json");
        var config = JsonSerializer.Deserialize<Configuration>(jsonConfig);

        // Mencetak konfigurasi awal
        Console.WriteLine("Initial Configuration:");
        Console.WriteLine(JsonSerializer.Serialize(config));

        // Mengubah beberapa nilai konfigurasi
        config.ApiURL = "http://example.com/api";
        config.Status = "Production";
        config.AppName = "Food Share Pro";
        config.AppVersion = "1.0";
        config.maxTitleLength = 60;
        config.descTitleLength = 100;

        // Mencetak konfigurasi yang telah diubah
        Console.WriteLine("\nUpdated Configuration:");
        Console.WriteLine(JsonSerializer.Serialize(config));

        // Menyimpan konfigurasi yang telah diubah kembali ke file JSON
        string updatedJsonConfig = JsonSerializer.Serialize(config);
        File.WriteAllText("FoodShareConfig.json", updatedJsonConfig);

        Console.WriteLine("\nConfiguration saved to FoodShareConfig.json");
    }
}
