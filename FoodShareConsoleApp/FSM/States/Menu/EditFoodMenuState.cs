
using FoodShareConsoleApp.Entities.Request;
using FoodShareConsoleApp.Entities.Response;
using FoodShareConsoleApp.FSM.Contexts;
using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareCore.API;
using FoodShareCore.Utilities;
using Newtonsoft.Json;
using Spectre.Console;
using System.Xml.Linq;

namespace FoodShareConsoleApp.FSM.States.Menu
{
    public class EditFoodMenuState : IMenuState
    {
        private ClientAPI api;
        private ReadFoodMenuState readFoodMenuState;

        public EditFoodMenuState()
        {
            api = new ClientAPI();
            readFoodMenuState = new ReadFoodMenuState();
        }

        public async Task HandleOutput(MenuContext context)
        {
            try
            {
                await readFoodMenuState.ShowFoodTable();

                bool isQuestioning = true;
                HttpResponseMessage? response = null;
                int? foodId = null;

                while (isQuestioning)
                {
                    foodId = ConsoleUtils.Ask<int>("Masukan ID makanan atau input [yellow]-1[/] untuk kembali... ", "Integer");

                    if (foodId == -1)
                    {
                        Console.Clear();
                        await context.ActiveTrigger(MenuTrigger.Back);
                    }

                    response = await api.Get("/food/" + foodId);

                    if (!response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            Console.Clear();
                            await readFoodMenuState.ShowFoodTable();
                            AnsiConsole.Write(new Table().AddColumns("[red] ID Makanan tidak ditemukan! [/]")
                                .RoundedBorder()
                                .BorderColor(Spectre.Console.Color.Green1));
                            continue;
                        }

                        throw new Exception("Terjadi kesalahan ketika melakukan request API");
                    }

                    isQuestioning = false;
                }

                Console.Clear();
                isQuestioning = true;

                String responseJSON = await response!.Content.ReadAsStringAsync();
                ReadFoodResponse food = JsonConvert.DeserializeObject<ReadFoodResponse>(responseJSON);
                
                while(isQuestioning)
                {
                    AnsiConsole.Write(new Table().AddColumns("[grey]Pertanyaan[/]", "[grey]Jawaban[/]")
                            .RoundedBorder()
                            .BorderColor(Spectre.Console.Color.Grey)
                            .AddRow("[grey]Nama[/]", food.Name)
                            .AddRow("[grey]Deskripsi[/]", food.Description)
                            .AddRow("[grey]Kadaluarsa[/]", DateUtilitites.ConvertDateOnlyToString(food.Expire))
                            .AddRow("[grey]Jumlah[/]", food.Quantity.ToString())
                            .AddRow("[grey]Kondisi[/]", food.Condition)
                            .AddRow("[grey]Sumber Makanan[/]", food.Source)
                            .AddRow("[grey]Kategori[/]", food.Category));

                    AnsiConsole.Write(new Table().AddColumns("[grey]Ubah Data Makanan[/]")
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
                        await ConsoleUtils.ProgressBar("melakukan perubahan data makanan ke database", 5);

                        CreateFoodRequest body = new CreateFoodRequest { Category = category, Condition = condition, Description = description, Expire = expire, Name = name, Source = source, Quantity = amount };
                        response = await api.PutAsJson("/food/" + foodId, body);

                        if (!response.IsSuccessStatusCode)
                        {
                            throw new Exception("Terjadi kesalahan ketika melakukan request API");
                        }

                        Console.Clear();
                        AnsiConsole.Write(new Table().AddColumns("[green1] Berhasil merubah data makanan! [/]")
                            .RoundedBorder()
                            .BorderColor(Spectre.Console.Color.Green1));
                        await context.ActiveTrigger(MenuTrigger.Back);
                    }
                }

                await context.ActiveTrigger(MenuTrigger.Back);
            }
            catch { throw; }
        }
    }
}
