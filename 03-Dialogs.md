# Dialogs

To build a great conversationalist - we first need to understand what a conversation itself is and what it consists of.

TODO

A Bot simply put is nothing more (or less) than a User Interface. In Windows History this mainly had been a Window on your screen with Buttons and 

## Conversation Flow

![Dialog Flow](https://jbbxbq.by3302.livefilestore.com/y4mtR08iUWnRj2xJZ3T7oEJroU3ZAeQkdI4DjwfVU2_PwKH680uPmx80IwbKUXe5bfAnOJsGal1jlhVtyYEim0jiopqFkMKsj-iLI8ToBQo-PxMUEqnhLXjzDdUfA4M_oF63_2uVzySNDBPa5IKlwmludz9yZUqzxeSprh1wGdj66SgRsRjHDMm_-HyK8PCy0wD6NCRqhZVHsW-FuffB8MsbQ?width=660&height=291&cropmode=none)

## Form Flow

## Anatomy of a Dialog

```csharp


```
It´s important your Dialog is Serializable since the Dialog will be serialized into the state Datastore, so on User Input the bot is able to resume the Conversation

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