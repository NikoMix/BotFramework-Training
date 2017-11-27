using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BotTraining.Models;
using Microsoft.Bot.Builder.FormFlow;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class IdeaDialog 
    {
        public string Idea { get; set; }
        
        public Departments Department { get; set; }
        
        public bool Contact { get; set; }

        public static IForm<IdeaDialog> BuildForm()
        {
            return new FormBuilder<IdeaDialog>()
                .Message("Is this an Idea? Great! Tell me all about it")
                .Field(nameof(Idea))
                .Field(nameof(Department))
                .Field(nameof(Contact))
                .OnCompletion(HandleIdea)
                .Build();
        }

        private static Task HandleIdea(IDialogContext context, IdeaDialog state)
        {
            // TODO: Save Idea
            Console.Write(state);


            return Task.CompletedTask;
        }

        public static IFormDialog<IdeaDialog> BuildFormDialog(FormOptions options = FormOptions.PromptFieldsWithValues)
        {
            return FormDialog.FromForm<IdeaDialog>(BuildForm, options);
        }
    }
}