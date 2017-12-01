using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BotTraining.Dialogs
{
    [Serializable]
    public class QnaDialog : QnAMakerDialog
    {
        public QnaDialog() : base(new QnAMakerService(
            new QnAMakerAttribute(
                ConfigurationManager.AppSettings["QnaKey"],
                 ConfigurationManager.AppSettings["QnaAppId"])))
        { }
    }
}