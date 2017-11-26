using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.FormFlow;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class IdeaDialog 
    {
        [Prompt("What {&} do you have?")]
        public string Idea { get; set; }

        public static IForm<IdeaDialog> BuildForm()
        {
            return new FormBuilder<IdeaDialog>().Build();
        }

        public static IFormDialog<IdeaDialog> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
        {
            return FormDialog.FromForm<IdeaDialog>(BuildForm, options);
        }
    }
}