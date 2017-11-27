using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using Microsoft.Bot.Builder.Dialogs;
using System.Configuration;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {
        public QnaDialog() : base(new QnAMakerService(
            new QnAMakerAttribute(
                ConfigurationManager.AppSettings["QnaKey"],
                ConfigurationManager.AppSettings["QnaAppId"],
                ConfigurationManager.AppSettings["DefaultQnAResponse"], 0.3, 1)))
        {
        }
    }
}