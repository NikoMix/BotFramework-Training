using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class LuisDialog : LuisDialog<object>
    {
        public LuisDialog() : base(
            new LuisService(
                new LuisModelAttribute(
                    ConfigurationManager.AppSettings["LuisAppId"],
                    ConfigurationManager.AppSettings["LuisKey"], 
                    LuisApiVersion.V2, 
                    "westeurope.api.cognitive.microsoft.com")
            )){ }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(new QnaDialog(), Resume, item);
        }

        [LuisIntent("FeedbackIntent")]
        public async Task Feedback(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            context.Call(FeedbackDialog.BuildFormDialog(), Resume);
        }

        [LuisIntent("IdeaIntent")]
        public async Task Idea(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            context.Call(IdeaDialog.BuildFormDialog(), Resume);
        }

        private async Task Resume(IDialogContext context, IAwaitable<object> result)
        {
            await context.SayAsync("Can I help with something else?");
            context.Wait(MessageReceived);
        }
    }
}