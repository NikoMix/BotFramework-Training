using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class FeedbackDialog
    {
        [Prompt("What {&} do you have?")]
        public string Feedback { get; set; }

        [Prompt("Contact allowed?")]
        public bool ContactAllowed { get; set; }
        public Departments Department { get; set; }

        public static IForm<FeedbackDialog> BuildForm()
        {
            return new FormBuilder<FeedbackDialog>().Build();
        }

        public static IFormDialog<FeedbackDialog> BuildFormDialog(FormOptions options = FormOptions.PromptInStart)
        {
            return FormDialog.FromForm<FeedbackDialog>(BuildForm, options);
        }

    }

    public enum Departments
    {
        HumanResources,
        Legal,
        Delivery
    }
}