﻿using Spectre.Console;
using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareConsoleApp.FSM.Contexts;
using FoodShareCore.API;
using FoodShareConsoleApp.Entities.Response;
using Newtonsoft.Json;
using FoodShareCore.Utilities;
using System.Linq;

namespace FoodShareConsoleApp.FSM.States.Menu
{
    class ReadFoodMenuState : IMenuState
    {
        public async Task ShowFoodTable()
        {
            var table = new Table().Centered();

            // Animate
            await AnsiConsole.Live(table)
                .AutoClear(false)
                .Overflow(VerticalOverflow.Ellipsis)
                .Cropping(VerticalOverflowCropping.Top)
                .StartAsync(async ctx =>
                {
                    void Update(int delay, Action action)
                    {
                        action();
                        ctx.Refresh();
                        Thread.Sleep(delay);
                    }

                    ClientAPI api = new ClientAPI();
                    HttpResponseMessage response = await api.Get("/food");

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
                    }

                    String responseJSON = await response.Content.ReadAsStringAsync();
                    List<ReadFoodResponse> foods = JsonConvert.DeserializeObject<List<ReadFoodResponse>>(responseJSON);


                    // Columns
                    Update(70, () => table.AddColumn("ID"));
                    Update(70, () => table.AddColumn("Nama"));
                    Update(70, () => table.AddColumn("Deskripsi"));
                    Update(70, () => table.AddColumn("Kondisi"));
                    Update(70, () => table.AddColumn("Sumber"));
                    Update(70, () => table.AddColumn("Kategori"));
                    Update(70, () => table.AddColumn("Kadaluarsa"));
                    Update(70, () => table.AddColumn("Kuantitas"));

                    // Rows
                    foreach (ReadFoodResponse food in foods)
                    {
                        Update(70, () => table.AddRow(food.Id.ToString(), food.Name, food.Description, $"[green]{food.Condition}[/]", $"[blue]{food.Source}[/]", food.Category, DateUtilitites.ConvertDateOnlyToString(food.Expire), food.Quantity.ToString()));
                    }

                    // Column aligment
                    Update(400, () => table.Columns[7].RightAligned());

                    // Column footer
                    Update(400, () => table.Columns[0].Footer("Total"));
                    Update(400, () => table.Columns[7].Footer(foods.Sum(food => food.Quantity).ToString()));

                    // Column titles
                    Update(70, () => table.Columns[0].Header("[bold]ID[/]"));
                    Update(70, () => table.Columns[1].Header("[bold]Nama[/]"));
                    Update(70, () => table.Columns[2].Header("[bold]Deskripsi[/]"));
                    Update(70, () => table.Columns[3].Header("[bold]Kondisi[/]"));
                    Update(70, () => table.Columns[4].Header("[bold]Sumber[/]"));
                    Update(70, () => table.Columns[5].Header("[bold]Kategori[/]"));
                    Update(70, () => table.Columns[6].Header("[bold]Kadaluarsa[/]"));
                    Update(70, () => table.Columns[7].Header("[bold]Kuantitas[/]"));

                    // Title
                    Update(500, () => table.Title("Sharefood"));
                    Update(400, () => table.Title("[[ [yellow]Data Makanan Masuk[/] ]]"));

                    // Borders
                    Update(230, () => table.BorderColor(Color.Yellow));
                    Update(230, () => table.MinimalBorder());
                    Update(230, () => table.SimpleBorder());
                    Update(230, () => table.SimpleHeavyBorder());

                    // Caption
                    Update(400, () => table.Caption("[[ [blue]THE END[/] ]]"));
                });
        }

        public async Task HandleOutput(MenuContext context)
        {
            await ShowFoodTable();

            AnsiConsole.MarkupLine("Press [yellow]Enter[/] to exit... ");
            Console.Read();

            Console.Clear();
            await context.ActiveTrigger(MenuTrigger.Back);
        }
    }

}
