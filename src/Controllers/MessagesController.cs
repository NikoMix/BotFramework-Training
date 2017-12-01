using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using BotTraining.Dialogs;

namespace BotTraining.Controllers
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// receive a message from a user and send replies
        /// </summary>
        /// <param name="activity"></param>
        [ResponseType(typeof(void))]
        public virtual async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            var client = new ConnectorClient(new Uri(activity.ServiceUrl), new MicrosoftAppCredentials());
            if (activity.Type == ActivityTypes.Message)
            {

                var typingActivity = activity.CreateReply();
                typingActivity.Type = ActivityTypes.Typing;
                await client.Conversations.ReplyToActivityAsync(typingActivity);


                await Conversation.SendAsync(activity, () =>new LuisDialog());
            }
            else if (activity.Type == ActivityTypes.ConversationUpdate)
            {
                IConversationUpdateActivity update = activity;
                if (update.MembersAdded != null && update.MembersAdded.Any())
                {
                    foreach (var newMember in update.MembersAdded)
                    {
                        if (newMember.Id != activity.Recipient.Id)
                        {
                            var reply = activity.CreateReply();
                            reply.Text =
                                $@"Hey there {newMember.Name}. Nice to meet you.";
                            await client.Conversations.ReplyToActivityAsync(reply);
                        }
                    }
                }
            }
            else
            {
                HandleSystemMessage(activity);
            }
            return new HttpResponseMessage(System.Net.HttpStatusCode.Accepted);
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}