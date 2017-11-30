# Dialogs

To build a great conversationalist - we first need to understand what a conversation itself is and what it consists of.

A Conversation consists mostly out of two or more participants, which interact in a alternately matter. The Topic of the Conversation can change but mostly keeps in a certain context. Every Input in the Conversation is asumed to be related to this context or an Intent of switching to change the Context. For the matter of the Context the Bot Framework provides a State which you are able to attach Information to it. When ever a new Call to your Endpoint is made, it will identifiy the previous stored state (context) by its conversation ID.

A Bot simply put is nothing more (or less) than a User Interface. In Windows History this mainly had been a Window on your screen with Buttons and 

## Conversation Flow

![Dialog Flow](https://jbbxbq.by3302.livefilestore.com/y4mtR08iUWnRj2xJZ3T7oEJroU3ZAeQkdI4DjwfVU2_PwKH680uPmx80IwbKUXe5bfAnOJsGal1jlhVtyYEim0jiopqFkMKsj-iLI8ToBQo-PxMUEqnhLXjzDdUfA4M_oF63_2uVzySNDBPa5IKlwmludz9yZUqzxeSprh1wGdj66SgRsRjHDMm_-HyK8PCy0wD6NCRqhZVHsW-FuffB8MsbQ?width=660&height=291&cropmode=none)

In a classical Application its represented by an initial Dialog. By interacting with this form - for example a Storage Application - you open Detail Forms which are related to a certain topic. Back to our example, this could be a Entry Form to Insert a new "Storage Entity" inside our Storage. Another Detail Form could be creating a new Storage Facility - so each Detail Form covers their own Intent and address their Input. While a Storage Entity for example requires Size Information while a Storage Facility needs address Data to be created. 

Our Bot relates to it, only by not providing Forms, instead it routes the Conversation to a different Dialog. A Dialogue can consist out of different Inputs and "guides" through the collection of required Information.

## Anatomy of a Dialog

By using the Microsoft.Bot.Builder - Nuget Package we included the Bot Framework into our Application. A very important role of the Framework are Dialogs. To implement a very simple Dialog simply implement the Interface IDialog or IDialog<T> to create a Typed Dialogue. 

```csharp
[Serializable]
public class SampleDialog : IDialog
{
    public Task StartAsync(IDialogContext context)
    {
        // Do something
    }
}
```
It´s important your Dialog is Serializable since the Dialog will be serialized into the state Datastore, so the bot is able to restore the previous State on User Input and resume the Conversation

## Channels

![Channels](https://9g1m7q.by3302.livefilestore.com/y4myIlWbMS4CnEzvq69M9glttbzs0G7zb7F1fA84CIye4Ovnaj9Z8_exJZ5uzLNnbglyMHMTe2eFBD1fN_CUSBkCYAQ2rwJZnVHcR8ELP6AKWM82-CnEyGrOTVVW7h5bFRfHe9R-ePrt60FgV4RE1VNWj4jcY8igNgXb-UuKV9X_ItWLlIfOh4CvuelVVQXJMSHLjrt7JSIq6-rAILbLqUpdg?width=676&height=233&cropmode=none)

## Welcome the User

```csharp
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
```

### Differences between Channels

Websites do not send initial Conversation Update Activies

### Dialog Chains

```csharp
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
```

```csharp
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
        return Task.CompletedTask;
    }

    public static IFormDialog<IdeaDialog> BuildFormDialog(FormOptions options = FormOptions.PromptFieldsWithValues)
    {
        return FormDialog.FromForm<IdeaDialog>(BuildForm, options);
    }
}
```

### Default Commands

What can I say?
Help
etc.