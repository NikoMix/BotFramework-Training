using System;
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
                    Utils.GetAppSetting("LuisAppId"),
                    Utils.GetAppSetting("LuisAPIKey"))))
        {
        }

        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.Forward(new QnaDialog(), Resume, context.Activity, default(System.Threading.CancellationToken));
        }

        [LuisIntent("GiveFeedback")]
        public async Task Feedback(IDialogContext context,IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(FeedbackDialog.BuildFormDialog(), ResumeFeedback, item);

            // context.Wait(MessageReceived);
        }

        private Task ResumeFeedback(IDialogContext context, IAwaitable<object> result)
        {
            throw new NotImplementedException();
        }

        [LuisIntent("GiveIdea")]
        public async Task Idea(IDialogContext context,IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            var item = await activity;
            await context.Forward(IdeaDialog.BuildFormDialog(), ResumeIdea, item);

           // context.Wait(MessageReceived);
        }

        private Task ResumeIdea(IDialogContext context, IAwaitable<object> result)
        {
            throw new NotImplementedException();
        }

        private Task Resume(IDialogContext context, IAwaitable<object> result)
        {
            context.SayAsync("Can I help with something else?");
            return Task.CompletedTask;
        }
    }
}