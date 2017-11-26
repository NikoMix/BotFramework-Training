using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

using System.Configuration;
using Microsoft.Bot.Builder.FormFlow;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class FeedbackDialog
    {

        [Prompt("What {&} do you have?")]
        public string Feedback { get; set; }
        
        public static IForm<FeedbackDialog> BuildForm()
        {
            return new FormBuilder<FeedbackDialog>().Build();
        }

        public static IFormDialog<FeedbackDialog> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
        {
            return FormDialog.FromForm<FeedbackDialog>(BuildForm, options);
        }
    }
}