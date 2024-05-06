using FoodShareConsoleApp.Entities.Response;
using FoodShareConsoleApp.Exceptions;
using FoodShareConsoleApp.FSM.Contexts;
using FoodShareConsoleApp.FSM.Interfaces;
using FoodShareCore.API;
using Newtonsoft.Json;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShareConsoleApp.FSM.States.Menu
{
    class DeleteFoodMenuState : IMenuState
    {
        private ClientAPI api;

        public DeleteFoodMenuState() {
            api = new ClientAPI();
        }

        public async Task HandleOutput(MenuContext context)
        {
            try
            {
                ReadFoodMenuState readMenuState = new ReadFoodMenuState();
                await readMenuState.ShowFoodTable();

                bool isQuestioning = true;
                
                while(isQuestioning)
                {
                    int foodId = ConsoleUtils.Ask<int>("Masukan ID makanan atau tekan [yellow]-1[/] untuk kembali... ", "Integer");

                    if(foodId == -1) 
                    {
                        Console.Clear();
                        await context.ActiveTrigger(MenuTrigger.Back);
                    }

                    HttpResponseMessage response = await api.Delete("/food/" + foodId);

                    if (!response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                        {
                            Console.Clear();
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
                AnsiConsole.Write(new Table().AddColumns("[green1] Berhasil menghapus data makanan! [/]")
                            .RoundedBorder()
                            .BorderColor(Spectre.Console.Color.Green1));
                await context.ActiveTrigger(MenuTrigger.Back);
            } catch { throw; }
        }
    }
}
