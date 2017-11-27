using System;
using System.Configuration;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class BasicLuisDialog : LuisDialog<object>
    {
        public BasicLuisDialog() : base(
            new LuisService(
                new LuisModelAttribute(
                    ConfigurationManager.AppSettings["LuisAppId"],
                    ConfigurationManager.AppSettings["LuisKey"], 
                    LuisApiVersion.V2, 
                    "westeurope.api.cognitive.microsoft.com")))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(new QnaDialog(), Resume, item);
        }

        [LuisIntent("GiveFeedback")]
        public async Task Feedback(IDialogContext context,IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(FeedbackDialog.BuildFormDialog(), Resume, item);
        }

        [LuisIntent("GiveIdea")]
        public async Task Idea(IDialogContext context,IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(IdeaDialog.BuildFormDialog(), Resume, item);
        }

        private async Task Resume(IDialogContext context, IAwaitable<object> result)
        {
            await context.SayAsync("Can I help with something else?");
            context.Wait(MessageReceived);
        }
    }
}