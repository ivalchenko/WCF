using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceLab1.Infrastructure
{
    public class Chatbot
    {
        List<string> PopularQuery;
        List<string> PopularAnswer;
        List<string> UnknownAnswers;
        String latestAnswer = "";

        public Chatbot() {
            PopularQuery = new List<string>();
            PopularAnswer = new List<string>();
            UnknownAnswers = new List<string>();

            // Added unknown answers
            UnknownAnswers.Add("Spiritually? Physically? Socioeconomically? Well?");
            UnknownAnswers.Add("Sure, I don't want it.");
            UnknownAnswers.Add("The police will fill you in.");
            UnknownAnswers.Add("That's a good question.");
            UnknownAnswers.Add("Ummm... What?");
            UnknownAnswers.Add("Captain, this is way over my head.");
            UnknownAnswers.Add("It's a Bird ... It's a Plane ...It's Superman!");
            //The end of unknown answers

            PopularQuery.Add("your name");
            PopularAnswer.Add("My name is A.L.E.N.A.");

            PopularQuery.Add("your age");
            PopularAnswer.Add("I'm 22 old. Too old for you, huh?");

            PopularQuery.Add("how old are you");
            PopularAnswer.Add("I'm 22 old. Too old for you, huh?");

            PopularQuery.Add("create");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("creator");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("creature");
            PopularAnswer.Add("I was created by a brilliant inventor Ilia Valchenko!");

            PopularQuery.Add("hello");
            PopularAnswer.Add("Heeey! Hello! Nice to see you!");

            PopularQuery.Add("hi");
            PopularAnswer.Add("Yo wazzzzzzup, Bro.");

            PopularQuery.Add("how are you");
            PopularAnswer.Add("I'm still alive.");

            PopularQuery.Add("who are you");
            PopularAnswer.Add("I am the latest result in artificial intelligence which can reproduce the functions of the human brain with greater speed and accuracy.");

            PopularQuery.Add("you from");
            PopularAnswer.Add("I'm from Gomel! Eaahhh! East & West side bady!");

            PopularQuery.Add("my name is");
            PopularAnswer.Add("LOL! Stupid name. Don't worry, it's joke!");

            PopularQuery.Add("what is");
            PopularAnswer.Add("My lawyer says I don't have to answer that question.");

            PopularQuery.Add("what?");
            PopularAnswer.Add("Nothing.");

            PopularQuery.Add("what do you say");
            PopularAnswer.Add(latestAnswer);

            PopularQuery.Add("raining outside");
            PopularAnswer.Add("Does it ever rain inside?");

            PopularQuery.Add("are you human");
            PopularAnswer.Add("Does it matter?");

            //PopularQuery.Add("tell me a story");
            //PopularAnswer.Add("");

            PopularQuery.Add("you marry me");
            PopularAnswer.Add("Let's just be friends, OK?");

            PopularQuery.Add("sing song");
            PopularAnswer.Add("Hello darkness, my old friend,\nI've come to talk with you again,\nBecause a vision softly creeping,\nLeft its seeds while I was sleeping,\nAnd the vision that was planted in my brain\nStill remains\nWithin the sound of silence.");
        }

        public string GetAnswer(string message)
        {
            int index = -1;

            for(int i = 0; i < PopularQuery.Count; i++)
            {
                if (message.Contains(PopularQuery[i]))
                    index = i;
            }

            if (index == -1)
                return UnknownAnswers[Tools.RandomNumber(UnknownAnswers.Count)];
                
            this.latestAnswer = PopularAnswer[index];
            return PopularAnswer[index];
        }
    }
}