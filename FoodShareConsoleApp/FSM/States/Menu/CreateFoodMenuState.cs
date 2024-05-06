using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareConsoleApp.Entities.Request;
using FoodShareCore.API;
using Spectre.Console;
using FoodShareConsoleApp.FSM.Contexts;
using FoodShareCore.Utilities;

namespace FoodShareConsoleApp.FSM.States.Menu
{
    class CreateFoodMenuState : IMenuState
    {
        public async Task HandleOutput(MenuContext context)
        {
            try
            {
                bool isQuestioning = true;

                while (isQuestioning)
                {
                    AnsiConsole.Write(new Table().AddColumns("[grey]Form Pendaftaran Data Makanan[/]")
                        .RoundedBorder()
                        .BorderColor(Spectre.Console.Color.Green1));

                    String name = ConsoleUtils.Ask<String>("Masukan nama makanan?", "String");
                    String description = ConsoleUtils.Ask<String>("Masukan deskripsi makanan?", "String");
                    String expire = ConsoleUtils.AskValidation<String>("Masukan tanggal kadaluarsa? [yellow](ex. 2003-01-01)[/]", "String", DateUtilitites.ValidateDateInput,
                        "Format tanggal tidak valid!");

                    int amount = ConsoleUtils.Ask<int>("Masukan jumlah makanan?", "Integer");

                    String condition = ConsoleUtils.AskSelection<String>("Masukan kondisi makanan?", "Choices", new String[] { "Baik", "Cukup", "Buruk" });
                    String source = ConsoleUtils.AskSelection<String>("Masukan sumber makanan?", "Choices", new String[] { "Restoran", "Kafe", "Minimarket", "Toko Kelontong", "Pasar", "Hotel", "Katering", "Kantin", "Toko Roti / Kue" });
                    String category = ConsoleUtils.AskSelection<String>("Masukan kategori makanan?", "Choices", new String[] { "Daging", "Ayam", "Ikan / Produk Laut", "Sayuran", "Buah Buahan", "Biji Bijian", "Susu", "Roti / Kue", "Cemilan", "Siap Saji" });

                    AnsiConsole.Clear();

                    AnsiConsole.Write(new Table().AddColumns("[grey]Pertanyaan[/]", "[grey]Jawaban[/]")
                            .RoundedBorder()
                            .BorderColor(Spectre.Console.Color.Grey)
                            .AddRow("[grey]Nama[/]", name)
                            .AddRow("[grey]Deskripsi[/]", description)
                            .AddRow("[grey]Kadaluarsa[/]", expire)
                            .AddRow("[grey]Jumlah[/]", amount.ToString())
                            .AddRow("[grey]Kondisi[/]", condition)
                            .AddRow("[grey]Sumber Makanan[/]", source)
                            .AddRow("[grey]Kategori[/]", category));

                    AnsiConsole.WriteLine();
                    if (AnsiConsole.Confirm("Apakah data yang anda inputkan adalah benar?"))
                    {
                        AnsiConsole.Clear();
                        await ConsoleUtils.ProgressBar("Menyimpan data makanan ke database", 5);

                        ClientAPI api = new ClientAPI();
                        CreateFoodRequest body = new CreateFoodRequest { Category = category, Condition = condition, Description = description, Expire = expire, Name = name, Source = source, Quantity = amount };
                        HttpResponseMessage response = await api.PostAsJson("/food", body);

                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
                        }

                        Console.Clear();
                        AnsiConsole.Write(new Table().AddColumns("[green1] Berhasil menambahkan data makanan! [/]")
                            .RoundedBorder()
                            .BorderColor(Spectre.Console.Color.Green1));
                        await context.ActiveTrigger(MenuTrigger.Back);
                    }
                }
            }
            catch { throw; }
        }
    }

}
